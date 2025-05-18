Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmUserInfo
    Private currentEmployeeID As Integer = LoggedInEmployeeID ' Replace with actual logged-in ID

    Private Sub frmUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeInfo()
    End Sub

    Private Sub LoadEmployeeInfo()
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM EmployeeProfile WHERE EmployeeID = @EmployeeID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", currentEmployeeID)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtFirstName.Text = reader("FirstName").ToString()
                            txtMiddleName.Text = reader("MiddleName").ToString()
                            txtLastName.Text = reader("LastName").ToString()
                            txtExtName.Text = reader("ExtName").ToString()
                            txtPhoneNumber.Text = reader("PhoneNumber").ToString()
                            cmbDepartment.Text = reader("Department").ToString()
                            txtDesignation.Text = reader("Designation").ToString()
                            txtEmail.Text = reader("EmailAdd").ToString()

                            ' Load profile picture
                            If Not IsDBNull(reader("ProfilePicture")) Then
                                Dim imgData As Byte() = CType(reader("ProfilePicture"), Byte())
                                Using ms As New MemoryStream(imgData)
                                    picProfile.Image = Image.FromStream(ms)
                                End Using
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user info: " & ex.Message)
        End Try
    End Sub

    Private Function GetImageBytes() As Byte()
        If picProfile.Image Is Nothing Then Return Nothing
        Using ms As New MemoryStream()
            picProfile.Image.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                picProfile.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFirstName.Text = "" Or txtLastName.Text = "" Then
            MessageBox.Show("Please fill in required fields.")
            Return
        End If

        Dim imgData As Byte() = GetImageBytes()

        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "UPDATE EmployeeProfile SET 
                    FirstName = @FirstName,
                    MiddleName = @MiddleName,
                    LastName = @LastName,
                    ExtName = @ExtName,
                    PhoneNumber = @PhoneNumber,
                    Department = @Department,
                    Designation = @Designation,
                    EmailAdd = @EmailAdd,
                    ProfilePicture = @ProfilePicture
                    WHERE EmployeeID = @EmployeeID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@ExtName", txtExtName.Text)
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                    cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text)
                    cmd.Parameters.AddWithValue("@Designation", txtDesignation.Text)
                    cmd.Parameters.AddWithValue("@EmailAdd", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@ProfilePicture", If(imgData IsNot Nothing, imgData, DBNull.Value))
                    cmd.Parameters.AddWithValue("@EmployeeID", currentEmployeeID)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Information updated successfully.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to update info: " & ex.Message)
        End Try
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim changePasswordForm As New frmChangePassword()
        changePasswordForm.ShowDialog()
    End Sub
End Class
