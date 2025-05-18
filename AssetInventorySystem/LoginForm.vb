Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm

    ' Hash password with SHA-256
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

    ' Login button click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check login attempts and lockout
        Dim message As String = ""
        If Not CanLogin(txtUsername.Text.Trim(), message) Then
            MessageBox.Show(message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Verify user credentials
        Dim query As String = "SELECT EmployeeID, UserType, ApprovalStatus, Designation, ProfilePicture, CONCAT(FirstName, ' ', LastName) AS FullName " &
                          "FROM employeeprofile WHERE Username = @username AND Password = @password"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtPassword.Text.Trim()))

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim approvalStatus As String = reader("ApprovalStatus").ToString()

                            If approvalStatus <> "Approved" Then
                                MessageBox.Show("Your account is pending approval. Please contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If

                            ' Set session
                            GlobalVariables.LoggedInEmployeeID = Convert.ToInt32(reader("EmployeeID"))
                            GlobalVariables.LoggedInEmployeeName = reader("FullName").ToString()
                            GlobalVariables.LoggedInUserDesignation = reader("Designation").ToString()
                            GlobalVariables.LoggedInProfilePicture = If(Convert.IsDBNull(reader("ProfilePicture")), Nothing, CType(reader("ProfilePicture"), Byte()))

                            reader.Close()

                            ' Load roles
                            LoadUserRoleNames(GlobalVariables.LoggedInEmployeeID)

                            If GlobalVariables.LoggedInRoleNames.Count > 0 Then
                                LogLoginAttempt(txtUsername.Text.Trim(), True)
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                Dim dashboard As New frmAISMainDashboard()
                                dashboard.Show()
                                Me.Hide()
                                txtUsername.Clear()
                                txtPassword.Clear()
                            Else
                                MessageBox.Show("No roles assigned. Access denied.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            ' Log the failed attempt first
                            LogLoginAttempt(txtUsername.Text.Trim(), False)

                            ' Recalculate the attempt message AFTER logging
                            Dim attemptMessage As String = "Invalid username or password."
                            CanLogin(txtUsername.Text.Trim(), attemptMessage)

                            ' Show the updated message with remaining attempts
                            MessageBox.Show(attemptMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Load user roles
    Private Sub LoadUserRoleNames(employeeID As Integer)
        GlobalVariables.LoggedInRoleNames = New List(Of String)
        Dim query As String = "SELECT r.RoleName FROM employeeroles er " &
                              "INNER JOIN roles r ON er.RoleID = r.RoleID WHERE er.EmployeeID = @employeeID"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@employeeID", employeeID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            GlobalVariables.LoggedInRoleNames.Add(reader("RoleName").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading role names: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Log login attempt
    Private Sub LogLoginAttempt(username As String, isSuccess As Boolean)
        Dim query As String = If(isSuccess,
            "UPDATE LoginAttempts SET AttemptCount = 0, LastAttempt = CURRENT_TIMESTAMP WHERE Username = @Username",
            "INSERT INTO LoginAttempts (Username, AttemptCount, LastAttempt) VALUES (@Username, 1, CURRENT_TIMESTAMP) " &
            "ON DUPLICATE KEY UPDATE AttemptCount = AttemptCount + 1, LastAttempt = CURRENT_TIMESTAMP")

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Check if user can login
    Private Function CanLogin(username As String, ByRef message As String) As Boolean
        message = "" ' Reset the message.
        Dim query As String = "SELECT AttemptCount, LastAttempt FROM LoginAttempts WHERE Username = @Username"

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim attempts As Integer = Convert.ToInt32(reader("AttemptCount"))
                        Dim lastAttempt As DateTime = Convert.ToDateTime(reader("LastAttempt"))

                        If attempts >= 5 Then
                            ' Account is locked, show lockout message.
                            Dim timeDiff = DateTime.Now - lastAttempt
                            If timeDiff.TotalMinutes <= 15 Then
                                Dim remaining = Math.Ceiling(15 - timeDiff.TotalMinutes)
                                message = $"Account is locked. Try again in {remaining} minute(s)."
                                Return False
                            Else
                                ' Reset the attempts after lockout period.
                                reader.Close()
                                Using resetCmd As New MySqlCommand("UPDATE LoginAttempts SET AttemptCount = 0 WHERE Username = @Username", conn)
                                    resetCmd.Parameters.AddWithValue("@Username", username)
                                    resetCmd.ExecuteNonQuery()
                                End Using
                            End If
                        ElseIf attempts > 0 Then
                            ' Show remaining attempts.
                            Dim remainingTries As Integer = 5 - attempts
                            message = $"Invalid username or password.{Environment.NewLine}Warning: {remainingTries} attempt(s) remaining before account lockout."
                        End If
                    End If
                End Using
            End Using
        End Using

        Return True
    End Function


    ' Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.ShowDialog()
    End Sub

    ' Exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' Forgot Password
    Private Sub lnkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPassword.LinkClicked
        Dim forgotPasswordForm As New frmForgotPassword()
        forgotPasswordForm.ShowDialog()
    End Sub

    ' Admin Reset
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim resetPasswordForm As New frmResetPassword()
        resetPasswordForm.ShowDialog()
    End Sub

    ' Enter Key Press on Password
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    ' Enter Key Press on Username
    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        End If
    End Sub

End Class
