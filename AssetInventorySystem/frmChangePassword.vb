Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmChangePassword

    ' Hashing function for password
    Private Function ComputeSHA256Hash(ByVal rawData As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each t As Byte In bytes
                builder.Append(t.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Save button click event
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(txtCurrentPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtNewPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            MessageBox.Show("Please complete all fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if new password matches confirmation
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("New password and confirm password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Check current password
                Dim checkQuery As String = "SELECT Password FROM EmployeeProfile WHERE EmployeeID = @EmployeeID"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@EmployeeID", LoggedInEmployeeID)
                    Dim storedHash As String = Convert.ToString(checkCmd.ExecuteScalar())

                    If storedHash <> ComputeSHA256Hash(txtCurrentPassword.Text) Then
                        MessageBox.Show("Current password is incorrect.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Update to new password
                Dim updateQuery As String = "UPDATE EmployeeProfile SET Password = @NewPassword WHERE EmployeeID = @EmployeeID"
                Using updateCmd As New MySqlCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@NewPassword", ComputeSHA256Hash(txtNewPassword.Text))
                    updateCmd.Parameters.AddWithValue("@EmployeeID", LoggedInEmployeeID)
                    updateCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
