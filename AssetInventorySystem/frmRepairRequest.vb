Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class frmRepairRequest
    Private selectedCompanyID As String = ""
    Private editMode As Boolean = False
    Private selectedRequestID As Integer = -1

    Private Sub frmRepairRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReportedBy()
        LoadRepairRequests()
        LoadAvailableAssetCodes()
    End Sub

    ' Load available asset codes (those not in "RepairRequest" table with status other than "Resolved")
    Private Sub LoadAvailableAssetCodes()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "
                    SELECT AssetCode 
                    FROM itassettable 
                    WHERE AssetCode NOT IN (
                        SELECT AssetCode 
                        FROM repairrequesttable 
                        WHERE RequestStatus <> 'Resolved'
                    ) 
                    AND AvailabilityStatus = 'In Use'"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbAssetCode.Items.Clear()
                        While reader.Read()
                            cmbAssetCode.Items.Add(reader("AssetCode").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading asset codes: " & ex.Message)
        End Try
    End Sub

    ' Auto-fill asset name when asset code is selected
    Private Sub cmbAssetCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAssetCode.SelectedIndexChanged
        If cmbAssetCode.SelectedIndex <> -1 Then
            Try
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    Dim query As String = "SELECT AssetName FROM itassettable WHERE AssetCode = @AssetCode"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@AssetCode", cmbAssetCode.Text)
                        Dim assetName As Object = cmd.ExecuteScalar()
                        txtAssetName.Text = If(assetName IsNot Nothing, assetName.ToString(), "")
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading asset name: " & ex.Message)
            End Try
        End If
    End Sub

    ' Load "ReportedBy" combo box with employee details (CompanyIDNumber - FullName)
    Private Sub LoadReportedBy()
        cmbReportedBy.Items.Clear()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT CompanyIDNumber, CONCAT(FirstName, ' ', LastName) AS FullName FROM employeeprofile"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbReportedBy.Items.Add($"{reader("CompanyIDNumber")} - {reader("FullName")}")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        End Try
    End Sub

    ' Capture selected company ID when "ReportedBy" is changed
    Private Sub cmbReportedBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReportedBy.SelectedIndexChanged
        If cmbReportedBy.SelectedIndex <> -1 Then
            selectedCompanyID = cmbReportedBy.SelectedItem.ToString().Split("-"c)(0).Trim()
        End If
    End Sub

    ' Load repair requests into DataGridView
    Public Sub LoadRepairRequests()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "
                    SELECT RequestID, AssetCode, ReportedBy, DateReported, IssueDescription, RequestStatus 
                    FROM repairrequesttable 
                    WHERE RequestStatus <> 'Resolved'"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvRepairRequests.DataSource = table
                    End Using
                End Using
            End Using

            dgvRepairRequests.ColumnHeadersVisible = True
            dgvRepairRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            ' Highlight rows based on request status
            For Each row As DataGridViewRow In dgvRepairRequests.Rows
                Dim status = row.Cells("RequestStatus").Value.ToString()
                If status = "Pending" Then
                    row.DefaultCellStyle.BackColor = Color.LightYellow
                ElseIf status = "Resolved" Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading repair requests: " & ex.Message)
        End Try
    End Sub


    ' Submit or update repair request


    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        If cmbAssetCode.Text = "" Or txtAssetName.Text = "" Or selectedCompanyID = "" Or txtIssueDescription.Text = "" Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String
                If editMode Then
                    query = "UPDATE repairrequesttable SET AssetCode=@AssetCode, AssetName=@AssetName, ReportedBy=@ReportedBy, DateReported=@DateReported, IssueDescription=@IssueDescription WHERE RequestID=@RequestID"
                Else
                    query = "INSERT INTO repairrequesttable (AssetCode, AssetName, ReportedBy, DateReported, IssueDescription, RequestStatus)
                         VALUES (@AssetCode, @AssetName, @ReportedBy, @DateReported, @IssueDescription, 'Pending')"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AssetCode", cmbAssetCode.Text)
                    cmd.Parameters.AddWithValue("@AssetName", txtAssetName.Text)
                    cmd.Parameters.AddWithValue("@ReportedBy", selectedCompanyID)
                    cmd.Parameters.AddWithValue("@DateReported", dtpDateReported.Value)
                    cmd.Parameters.AddWithValue("@IssueDescription", txtIssueDescription.Text)
                    cmd.Parameters.AddWithValue("@CompanyIDNumber", selectedCompanyID)

                    If editMode Then cmd.Parameters.AddWithValue("@RequestID", selectedRequestID)

                    cmd.ExecuteNonQuery()
                End Using

                ' Fetch email of ReportedBy using CompanyIDNumber
                Dim emailQuery As String = "SELECT EmailAdd FROM employeeprofile WHERE CompanyIDNumber = @CompanyIDNumber"
                Dim emailAddress As String = ""

                Using emailCmd As New MySqlCommand(emailQuery, conn)
                    emailCmd.Parameters.AddWithValue("@CompanyIDNumber", selectedCompanyID)
                    Dim reader = emailCmd.ExecuteReader()
                    If reader.Read() Then
                        emailAddress = reader("EmailAdd").ToString() ' Ensure this matches the actual column name
                        Debug.Print("Email retrieved: " & emailAddress)
                    End If
                    reader.Close()
                End Using
                LoadRepairRequests()
                ClearForm()
                ' Send Email Notification
                If emailAddress <> "" Then
                    SendEmailNotification(emailAddress, txtAssetName.Text, txtIssueDescription.Text)
                End If

                MessageBox.Show("Repair request submitted and notification sent.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SendEmailNotification(toEmail As String, assetName As String, issueDescription As String)
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("balboaryanoliver@gmail.com") ' Replace with your system email
            mail.To.Add(toEmail)
            mail.Subject = "Repair Request Submitted"
            mail.Body = $"Dear user," & vbCrLf & vbCrLf &
                    $"Your repair request for asset: {assetName} has been successfully submitted." & vbCrLf &
                    $"Issue: {issueDescription}" & vbCrLf & vbCrLf &
                    $"Our technician will look into this issue shortly." & vbCrLf & vbCrLf &
                    $"Thank you."

            Dim smtp As New SmtpClient("smtp.gmail.com") ' Actual SMTP server
            smtp.Port = 587
            smtp.Credentials = New Net.NetworkCredential("balboaryanoliver@gmail.com", "percowsqptjarqno") ' Update credentials
            smtp.EnableSsl = True
            smtp.Send(mail)
        Catch ex As Exception
            MessageBox.Show("Failed to send email notification: " & ex.Message)
        End Try
    End Sub


    ' Clear form fields and reset mode
    Private Sub ClearForm()
        cmbAssetCode.SelectedIndex = -1
        txtAssetName.Clear()
        cmbReportedBy.SelectedIndex = -1
        txtIssueDescription.Clear()
        dtpDateReported.Value = Date.Now
        selectedCompanyID = ""
        editMode = False
        selectedRequestID = -1
        btnSubmitRequest.Text = "Submit Request"
        LoadAvailableAssetCodes()
    End Sub




    ' Optional: Delete selected request
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedRequestID = -1 Then
            MessageBox.Show("Please select a request to delete.")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this request?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    Dim query As String = "DELETE FROM repairrequesttable WHERE RequestID = @RequestID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@RequestID", selectedRequestID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Request deleted successfully.")
                ClearForm()
                LoadRepairRequests()

            Catch ex As Exception
                MessageBox.Show("Error deleting request: " & ex.Message)
            End Try
        End If
    End Sub


End Class
