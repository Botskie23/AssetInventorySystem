Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class frmUserApproval
    Private Sub frmUserApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPendingUsers() ' Load pending users on form load
    End Sub

    ' Load pending users into DataGridView
    Private Sub LoadPendingUsers()
        Dim conn As New MySqlConnection("Server=localhost;User ID=root;Password=;Database=assetinventorydb;")
        Dim query As String = "SELECT EmployeeID, FullName, EmailAdd, UserType, ApprovalStatus FROM employeeprofile WHERE ApprovalStatus = 'Pending'"

        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvUsers.DataSource = table ' Load data into DataGridView
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Approve User and Send Email
    Private Sub ApproveUser(employeeID As Integer, newStatus As String)
        Dim conn As New MySqlConnection("Server=localhost;User ID=root;Password=;Database=assetinventorydb;")

        Try
            conn.Open()
            ' Update user approval status in the database
            Dim updateQuery As String = "UPDATE employeeprofile SET ApprovalStatus = @Status WHERE EmployeeID = @ID"
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@Status", newStatus)
            cmd.Parameters.AddWithValue("@ID", employeeID)
            cmd.ExecuteNonQuery()

            ' Retrieve user's email
            Dim emailQuery As String = "SELECT EmailAdd FROM employeeprofile WHERE EmployeeID = @ID"
            cmd = New MySqlCommand(emailQuery, conn)
            cmd.Parameters.AddWithValue("@ID", employeeID)
            Dim userEmail As String = cmd.ExecuteScalar().ToString()

            conn.Close()

            ' Send email notification
            If Not String.IsNullOrEmpty(userEmail) Then
                SendEmailNotification(userEmail, newStatus)
            End If

            ' Reload users list
            LoadPendingUsers()

            MessageBox.Show("User status updated and notification sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message)
        End Try
    End Sub

    ' Function to send email notification
    Private Sub SendEmailNotification(userEmail As String, status As String)
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com") ' Change this if using Outlook
            smtp.Port = 587
            smtp.Credentials = New Net.NetworkCredential("balboaryanoliver@gmail.com", "percowsqptjarqno") ' Replace with your credentials
            smtp.EnableSsl = True

            Dim mail As New MailMessage()
            mail.From = New MailAddress("balboaryanoliver@gmail.com")
            mail.To.Add(userEmail)
            mail.Subject = "Your Account Approval Status"
            mail.Body = "Dear User," & vbCrLf & "Your account status has been updated to: " & status & vbCrLf & "Thank you."

            smtp.Send(mail)

        Catch ex As Exception
            MessageBox.Show("Email sending failed: " & ex.Message)
        End Try
    End Sub

    ' Approve button click
    ' Approve button click event
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = dgvUsers.SelectedCells(0).RowIndex ' Get the selected row index
            Dim selectedRow As DataGridViewRow = dgvUsers.Rows(rowIndex) ' Get the selected row
            Dim employeeID As Integer = CInt(selectedRow.Cells("EmployeeID").Value) ' Retrieve EmployeeID

            ApproveUser(employeeID, "Approved")
        Else
            MessageBox.Show("Please select a user to approve.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Deny button click event
    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = dgvUsers.SelectedCells(0).RowIndex ' Get the selected row index
            Dim selectedRow As DataGridViewRow = dgvUsers.Rows(rowIndex) ' Get the selected row
            Dim employeeID As Integer = CInt(selectedRow.Cells("EmployeeID").Value) ' Retrieve EmployeeID

            ApproveUser(employeeID, "Denied")
        Else
            MessageBox.Show("Please select a user to deny.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnUserRole_Click(sender As Object, e As EventArgs) Handles btnUserRole.Click
        frmUserRoleAssignment.Show()
    End Sub
End Class
