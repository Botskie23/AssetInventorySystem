Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmResetPassword
    ' Variable to hold the token passed by the user
    Private Token As String = ""

    ' Form Load event
    Private Sub frmResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial visibility and instructions
        lblError.Visible = False

    End Sub

    ' Button click to reset the password
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get the token entered by the user
        Token = txtToken.Text.Trim()

        ' Validate the token
        If Not ValidateToken(Token) Then
            lblError.Text = "Invalid or expired token."
            lblError.Visible = True
            Return
        End If

        ' Check if new password and confirm password match
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            lblError.Text = "Passwords do not match."
            lblError.Visible = True
            Return
        End If

        ' Hash the new password before saving it
        Dim hashedPassword As String = ComputeSHA256Hash(txtNewPassword.Text)

        ' SQL query to update the password and clear the token
        Dim query As String = "UPDATE EmployeeProfile SET Password = @Password, ResetToken = NULL, TokenExpiry = NULL WHERE ResetToken = @ResetToken"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Password", hashedPassword)
                    cmd.Parameters.AddWithValue("@ResetToken", Token)
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    ' Notify the user
                    MessageBox.Show("Password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close() ' Close the form
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub

    ' Function to validate token from the database
    Private Function ValidateToken(token As String) As Boolean
        Dim query As String = "SELECT * FROM EmployeeProfile WHERE ResetToken = @ResetToken AND TokenExpiry > NOW()"
        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ResetToken", token)
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            ' Token is valid
                            Return True
                        Else
                            ' Token is invalid or expired
                            Return False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
            Return False
        End Try
    End Function

    ' Function to hash the password using SHA-256
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
End Class
