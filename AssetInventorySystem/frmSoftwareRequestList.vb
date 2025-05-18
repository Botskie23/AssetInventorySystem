Imports MySql.Data.MySqlClient

Public Class frmSoftwareRequestList
    Private Sub frmSoftwareRequestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatusFilter.Items.AddRange(New String() {"All", "Pending", "Approved", "Denied"})
        cmbStatusFilter.SelectedIndex = 0
        LoadRequests()
    End Sub

    Private Sub LoadRequests()
        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()

            Dim query As String = "SELECT r.RequestID, e.FullName AS RequestedBy, r.SoftwareNameRequested, r.Justification, r.RequestDate, r.Status, m.MainLocationName, s.SubLocationName " &
                                  "FROM SoftwareRequestsTable r " &
                                  "JOIN employeeprofile e ON r.RequestedBy = e.EmployeeID " &
                                  "JOIN mainlocationtable m ON r.MainLocationID = m.MainLocationID " &
                                  "JOIN sublocationtable s ON r.SubLocationID = s.SubLocationID"

            If cmbStatusFilter.SelectedItem.ToString() <> "All" Then
                query &= " WHERE r.Status = @Status"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            If cmbStatusFilter.SelectedItem.ToString() <> "All" Then
                cmd.Parameters.AddWithValue("@Status", cmbStatusFilter.SelectedItem.ToString())
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvSoftwareRequests.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading requests: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatusFilter.SelectedIndexChanged
        LoadRequests()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRequests()
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        UpdateRequestStatus("Approved")
    End Sub

    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        UpdateRequestStatus("Denied")
    End Sub

    Private Sub UpdateRequestStatus(newStatus As String)
        If dgvSoftwareRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a request.")
            Return
        End If

        Dim requestID As Integer = CInt(dgvSoftwareRequests.SelectedRows(0).Cells("RequestID").Value)
        Dim remarks As String = txtRemarks.Text.Trim()

        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()

            ' Get request details including email
            Dim queryDetails As String = "SELECT r.SoftwareNameRequested, e.FullName AS RequestedByName, e.EmailAdd FROM SoftwareRequestsTable r " &
                                     "JOIN employeeprofile e ON r.RequestedBy = e.EmployeeID WHERE r.RequestID = @RequestID"
            Dim cmdDetails As New MySqlCommand(queryDetails, conn)
            cmdDetails.Parameters.AddWithValue("@RequestID", requestID)
            Dim reader As MySqlDataReader = cmdDetails.ExecuteReader()

            Dim softwareName As String = ""
            Dim requesterName As String = ""
            Dim requesterEmail As String = ""

            If reader.Read() Then
                softwareName = reader("SoftwareNameRequested").ToString()
                requesterName = reader("RequestedByName").ToString()
                requesterEmail = reader("EmailAdd").ToString()
            End If
            reader.Close()

            ' Update status
            Dim updateQuery As String = "UPDATE SoftwareRequestsTable SET Status=@Status WHERE RequestID=@RequestID"
            Dim cmdUpdate As New MySqlCommand(updateQuery, conn)
            cmdUpdate.Parameters.AddWithValue("@Status", newStatus)
            cmdUpdate.Parameters.AddWithValue("@RequestID", requestID)
            cmdUpdate.ExecuteNonQuery()

            ' Send email
            Dim subject As String = $"Software Request {newStatus}"
            Dim body As String = $"Hello {requesterName}," & vbCrLf & vbCrLf &
                             $"Your software request for: {softwareName}" & vbCrLf &
                             $"Status: {newStatus}" & vbCrLf &
                             If(remarks <> "", $"Remarks: {remarks}" & vbCrLf, "") &
                             $"Processed by: {GetEmployeeFullName(LoggedInEmployeeID)}" & vbCrLf &
                             $"Date: {DateTime.Now}" & vbCrLf & vbCrLf &
                             "Regards," & vbCrLf &
                             "IT Asset Request System"

            SendNotificationEmail(requesterEmail, subject, body)

            MessageBox.Show($"Request marked as {newStatus}. Email sent.")
            LoadRequests()
            txtRemarks.Clear()

        Catch ex As Exception
            MessageBox.Show("Error updating request: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Function GetEmployeeFullName(empID As Integer) As String
        Dim name As String = ""
        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT FullName FROM employeeprofile WHERE EmployeeID = @empID", conn)
            cmd.Parameters.AddWithValue("@empID", empID)
            name = Convert.ToString(cmd.ExecuteScalar())
        Catch
            name = "Unknown"
        Finally
            conn.Close()
        End Try
        Return name
    End Function


    Private Sub dgvSoftwareRequests_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSoftwareRequests.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow = dgvSoftwareRequests.Rows(e.RowIndex)
            MessageBox.Show("Requested By: " & selectedRow.Cells("RequestedBy").Value.ToString() & vbCrLf &
                            "Software: " & selectedRow.Cells("SoftwareNameRequested").Value.ToString() & vbCrLf &
                            "Justification: " & selectedRow.Cells("Justification").Value.ToString(),
                            "Request Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
