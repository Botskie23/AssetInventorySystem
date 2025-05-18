Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class frmRepairEvaluation

    ' Technician name (fetched from login session)
    Dim technicianName As String = "TechnicianName" ' Replace this with your login logic
    Dim requestID As Integer = 0

    ' Form Load
    Private Sub frmRepairEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dgvRequests.Columns.Count = 0 Then
            dgvRequests.Columns.Add("RequestID", "Request ID")
            dgvRequests.Columns.Add("AssetCode", "Asset Code")
            dgvRequests.Columns.Add("AssetName", "Asset Name")
            dgvRequests.Columns.Add("IssueDescription", "Issue Description")
            dgvRequests.Columns.Add("ReportedBy", "Reported By")
            dgvRequests.Columns.Add("DateReported", "Date Reported")
            dgvRequests.Columns.Add("RequestStatus", "Request Status")
        End If

        LoadRepairRequests()
        LoadStatusOptions()
        technicianName = LoggedInEmployeeName ' Automatically set from login session
    End Sub

    ' Load available statuses
    Private Sub LoadStatusOptions()
        cmbNewStatus.Items.Clear()
        cmbNewStatus.Items.Add("Pending")
        cmbNewStatus.Items.Add("In Progress")
        cmbNewStatus.Items.Add("Resolved")
        cmbNewStatus.SelectedIndex = -1
    End Sub

    ' Load all requests that are not resolved
    Private Sub LoadRepairRequests()
        dgvRequests.Rows.Clear()

        Dim query As String = "SELECT RequestID, AssetCode, AssetName, IssueDescription, ReportedBy, DateReported, RequestStatus " &
                              "FROM repairrequesttable WHERE RequestStatus <> 'Resolved'"

        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvRequests.Rows.Add(reader("RequestID"), reader("AssetCode"), reader("AssetName"),
                                             reader("IssueDescription"), reader("ReportedBy"),
                                             reader("DateReported"), reader("RequestStatus"))
                    End While
                End Using
            End Using
        End Using

        dgvRequests.ColumnHeadersVisible = True
        dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
    End Sub

    ' When a request row is clicked
    Private Sub dgvRequests_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequests.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRequests.Rows(e.RowIndex)

            txtRequestID.Text = row.Cells(0).Value.ToString()
            txtAssetCode.Text = row.Cells(1).Value.ToString()
            txtAssetName.Text = row.Cells(2).Value.ToString()
            txtIssueDescription.Text = row.Cells(3).Value.ToString()
            txtReportedBy.Text = row.Cells(4).Value.ToString()
            cmbNewStatus.SelectedItem = row.Cells(6).Value.ToString()
        End If
    End Sub

    ' Update the repair request status and send notification
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        ' Validation
        If String.IsNullOrEmpty(txtRequestID.Text) Then
            MessageBox.Show("Please select a request to evaluate.")
            Return
        End If

        If cmbNewStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a new status.")
            Return
        End If

        ' Gather data
        requestID = Convert.ToInt32(txtRequestID.Text)
        Dim newStatus As String = cmbNewStatus.SelectedItem.ToString()
        Dim remarks As String = txtRemarks.Text.Trim()
        Dim handledBy As String = technicianName
        Dim dateResolved As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        ' SQL Query
        Dim query As String = "UPDATE repairrequesttable SET RequestStatus = @RequestStatus, " &
                              "HandledBy = @HandledBy, Remarks = @Remarks"

        If newStatus = "Resolved" Then
            query &= ", DateResolved = @DateResolved"
        End If

        query &= " WHERE RequestID = @RequestID"

        ' Execute update
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RequestStatus", newStatus)
                cmd.Parameters.AddWithValue("@HandledBy", handledBy)
                cmd.Parameters.AddWithValue("@Remarks", remarks)
                cmd.Parameters.AddWithValue("@RequestID", requestID)

                If newStatus = "Resolved" Then
                    cmd.Parameters.AddWithValue("@DateResolved", dateResolved)
                End If

                conn.Open()
                Dim result = cmd.ExecuteNonQuery()

                If result > 0 Then
                    ' Try refreshing repair request form if open
                    For Each f As Form In Application.OpenForms
                        If TypeOf f Is frmRepairRequest Then
                            Dim requestForm As frmRepairRequest = CType(f, frmRepairRequest)
                            requestForm.LoadRepairRequests()
                            Exit For
                        End If
                    Next

                    ' Fetch email of reporter
                    Dim reportedByID As String = ""
                    Dim emailAddress As String = ""

                    ' Get the reporter ID using RequestID
                    Dim getReporterQuery As String = "SELECT ReportedBy FROM repairrequesttable WHERE RequestID = @RequestID"
                    Using reporterCmd As New MySqlCommand(getReporterQuery, conn)
                        reporterCmd.Parameters.AddWithValue("@RequestID", requestID)
                        Dim reader = reporterCmd.ExecuteReader()
                        If reader.Read() Then
                            reportedByID = reader("ReportedBy").ToString()
                        End If
                        reader.Close()
                    End Using

                    ' Get email address from employeeprofile
                    If reportedByID <> "" Then
                        Dim emailQuery As String = "SELECT EmailAdd FROM employeeprofile WHERE CompanyIDNumber = @CompanyIDNumber"
                        Using emailCmd As New MySqlCommand(emailQuery, conn)
                            emailCmd.Parameters.AddWithValue("@CompanyIDNumber", reportedByID)
                            Dim reader = emailCmd.ExecuteReader()
                            If reader.Read() Then
                                emailAddress = reader("EmailAdd").ToString()
                            End If
                            reader.Close()
                        End Using
                    End If

                    ' Send email if found
                    If emailAddress <> "" Then
                        SendEvaluationNotification(emailAddress)
                        MessageBox.Show("Evaluation submitted successfully and notification sent.")
                    Else
                        MessageBox.Show("Evaluation submitted successfully, but no email was found for the reporter.")
                    End If

                    LoadRepairRequests()
                    ClearForm()

                Else
                    MessageBox.Show("Failed to update request.")
                End If
            End Using
        End Using
    End Sub

    ' Email Notification Function
    Private Sub SendEvaluationNotification(toEmail As String)
        Try
            Dim assetCode As String = txtAssetCode.Text
            Dim newStatus As String = cmbNewStatus.SelectedItem.ToString()
            Dim remarks As String = txtRemarks.Text.Trim()

            Dim mail As New MailMessage()
            mail.From = New MailAddress("balboaryanoliver@gmail.com")
            mail.To.Add(toEmail)
            mail.Subject = "Repair Request Status Updated"

            mail.Body = "Dear User," & vbCrLf & vbCrLf &
                    "This is to notify you that your repair request for the asset with the following details has been evaluated:" & vbCrLf & vbCrLf &
                    "Asset Code: " & assetCode & vbCrLf &
                    "New Status: " & newStatus & vbCrLf &
                    "Technician Remarks: " & remarks & vbCrLf & vbCrLf &
                    "Please log in to the system for full information." & vbCrLf & vbCrLf &
                    "Thank you," & vbCrLf &
                    "IT Support Team"

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New Net.NetworkCredential("balboaryanoliver@gmail.com", "percowsqptjarqno") ' App password
            smtp.EnableSsl = True
            smtp.Send(mail)
        Catch ex As Exception
            MessageBox.Show("Failed to send email: " & ex.Message)
        End Try
    End Sub


    ' Cancel/Close the form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Clear all inputs
    Private Sub ClearForm()
        txtRequestID.Clear()
        txtAssetCode.Clear()
        txtAssetName.Clear()
        txtIssueDescription.Clear()
        txtReportedBy.Clear()
        txtRemarks.Clear()
        cmbNewStatus.SelectedIndex = -1
    End Sub

    ' MySQL connection helper
    Private Function GetConnection() As MySqlConnection
        Dim connStr As String = "server=localhost;userid=root;password=;database=assetinventorydb;"
        Return New MySqlConnection(connStr)
    End Function

End Class
