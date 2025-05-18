Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmForgotPassword

    ' Function to hash password using SHA-256
    Private Function ComputeSHA256Hash(ByVal rawData As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each t As Byte In bytes
                builder.Append(t.ToString("x2")) ' Convert bytes to hexadecimal
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Send Reset Token (handles token generation and email sending)
    Private Sub SendResetToken(email As String)
        ' Generate a unique reset token
        Dim token As String = Guid.NewGuid().ToString()
        ' Set token expiration time (15 minutes from now)
        Dim expiry As DateTime = DateTime.Now.AddMinutes(15)

        ' Update the database with the reset token and expiration
        Dim updateQuery As String = "UPDATE employeeprofile SET ResetToken = @Token, TokenExpiry = @Expiry WHERE EmailAdd = @Email"
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@Token", token)
                cmd.Parameters.AddWithValue("@Expiry", expiry)
                cmd.Parameters.AddWithValue("@Email", email)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Create the body of the email
        Dim emailSubject As String = "Password Reset Request"
        Dim emailBody As String = $"You requested a password reset. Use the following token to reset your password:" & vbCrLf &
                                  $"Reset Token: {token}" & vbCrLf &
                                  $"The token will expire in 15 minutes."

        ' Send the email with the token to the user's email address
        Try
            ' Call the SendNotificationEmail method from SendEmail.vb to send the email
            SendNotificationEmail(email, emailSubject, emailBody)
            MessageBox.Show("A password reset token has been sent to your email address.", "Reset Token Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button click event to handle the password reset request
    Private Sub btnRequestReset_Click(sender As Object, e As EventArgs) Handles btnRequestReset.Click
        ' Validate the email input
        Dim email As String = txtEmail.Text.Trim()

        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter your registered email address.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the email exists in the database
        Dim query As String = "SELECT COUNT(*) FROM employeeprofile WHERE EmailAdd = @Email"
        Dim emailExists As Boolean = False
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Email", email)
                conn.Open()

                ' If email exists, the count will be greater than 0
                emailExists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using

        If emailExists Then
            ' If the email exists, send the reset token
            SendResetToken(email)
        Else
            MessageBox.Show("The email address is not registered.", "Email Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
