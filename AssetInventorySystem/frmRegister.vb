Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class frmRegister
    ' Database connection string (Replace "your_db" with your actual database name)
    Private connString As String = "server=localhost;user id=root;password=;database=assetinventorydb"

    ' 🔽 REGISTER BUTTON CLICK EVENT
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate input fields before saving
        If ValidateForm() = False Then Exit Sub

        ' Hash the password before storing it in the database
        Dim hashedPassword As String = HashPassword(txtPassword.Text)

        Try
            ' Open database connection
            Using conn As New MySqlConnection(connString)
                Dim query As String = "INSERT INTO EmployeeProfile (FirstName, MiddleName, LastName, ExtName, FullName, EmailAdd, UserName, Password, PhoneNumber, Department, Designation, UserType, Status, CompanyIDNumber, ProfilePicture, CreatedAt) 
                                        VALUES (@fname, @mname, @lname, @extname, @fullname, @email, @uname, @pass, @phone, @dept, @desig, @utype, @status, @comid, @pic, NOW())"

                Using cmd As New MySqlCommand(query, conn)
                    ' Set parameter values
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@mname", txtMiddleName.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@extname", txtExtName.Text)

                    ' Generate FullName dynamically
                    Dim fullName As String = txtFirstName.Text & " " & If(txtMiddleName.Text <> "", txtMiddleName.Text & " ", "") & txtLastName.Text & If(txtExtName.Text <> "", " " & txtExtName.Text, "")
                    cmd.Parameters.AddWithValue("@fullname", fullName)

                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@uname", txtUserName.Text)
                    cmd.Parameters.AddWithValue("@pass", hashedPassword) ' Store hashed password
                    cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text)
                    cmd.Parameters.AddWithValue("@dept", txtDepartment.Text)
                    cmd.Parameters.AddWithValue("@desig", txtDesignation.Text)
                    cmd.Parameters.AddWithValue("@utype", cmbUserType.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@status", "Active") ' Default status
                    cmd.Parameters.AddWithValue("@approvalstatus", "Pending") ' Default status when registering
                    cmd.Parameters.AddWithValue("@comid", txtComIDNum.Text)

                    ' Convert profile picture to bytes
                    Dim imageBytes As Byte() = ConvertImageToBytes(picProfile.Image)
                    cmd.Parameters.AddWithValue("@pic", If(imageBytes Is Nothing, DBNull.Value, imageBytes))


                    ' Execute query
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtExtName.Clear()
        txtEmail.Clear()
        txtUserName.Clear()
        txtPassword.Clear()
        txtPhoneNumber.Clear()
        txtDepartment.Clear()
        txtDesignation.Clear()
        cmbUserType.SelectedIndex = -1
        txtComIDNum.Clear()
        picProfile.Image = Nothing
    End Sub


    ' 🔽 FUNCTION TO VALIDATE INPUT FIELDS
    Private Function ValidateForm() As Boolean
        If txtFirstName.Text.Trim() = "" OrElse txtLastName.Text.Trim() = "" OrElse txtEmail.Text.Trim() = "" OrElse txtUserName.Text.Trim() = "" OrElse txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validate email format
        If Not txtEmail.Text.Contains("@") OrElse Not txtEmail.Text.Contains(".") Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validate password length
        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' 🔹 CHECK IF USER TYPE IS SELECTED
        If cmbUserType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a User Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if username or email already exists
        If IsUserExists(txtUserName.Text, txtEmail.Text) Then
            MessageBox.Show("Username or Email already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function


    ' 🔽 FUNCTION TO CHECK IF USERNAME OR EMAIL EXISTS
    Private Function IsUserExists(username As String, email As String) As Boolean
        Try
            Using conn As New MySqlConnection(connString)
                Dim query As String = "SELECT COUNT(*) FROM EmployeeProfile WHERE UserName = @username OR EmailAdd = @email"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@email", email)

                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    conn.Close()

                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' 🔽 FUNCTION TO HASH PASSWORD USING SHA-256
    Private Function HashPassword(password As String) As String
Dim sha256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return BitConverter.ToString(hash).Replace("-", "").ToLower()
    End Function

    ' 🔽 FUNCTION TO CONVERT IMAGE TO BYTE ARRAY (FOR PROFILE PICTURE)
    Private Function ConvertImageToBytes(img As Image) As Byte()
        If img Is Nothing Then Return Nothing
        Using ms As New IO.MemoryStream()
            img.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    ' 🔽 FUNCTION TO LOAD PROFILE PICTURE
    Private Sub btnUploadPic_Click(sender As Object, e As EventArgs) Handles btnUploadPic.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picProfile.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
