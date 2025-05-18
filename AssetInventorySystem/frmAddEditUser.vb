Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAddEditUser
    Dim currentUserId As Integer = -1

    Private Sub frmAddEditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
        LoadUserTypes()
        LoadStatuses()
        LoadApprovalStatuses()
        LoadUsers()
    End Sub

    Private Sub LoadDepartments()
        Try
            cmbDepartment.Items.Clear()
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT st.SubLocationName, ml.MainLocationName FROM sublocationtable st JOIN mainlocationtable ml ON st.MainLocationID = ml.MainLocationID"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim departmentName As String = reader("SubLocationName").ToString() & " (" & reader("MainLocationName").ToString() & ")"
                            cmbDepartment.Items.Add(departmentName)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error loading departments: " & ex.Message)
        End Try

        LogActivity("Opened Form: " & Me.Name, LoggedInEmployeeName)
    End Sub

    Private Sub LoadUserTypes()
        cmbUserType.Items.Clear()
        cmbUserType.Items.Add("Admin")
        cmbUserType.Items.Add("User")
    End Sub

    Private Sub LoadStatuses()
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Active")
        cmbStatus.Items.Add("Inactive")
    End Sub

    Private Sub LoadApprovalStatuses()
        cmbApprovalStatus.Items.Clear()
        cmbApprovalStatus.Items.Add("Approved")
        cmbApprovalStatus.Items.Add("Pending")
        cmbApprovalStatus.Items.Add("Denied")
    End Sub

    Private Sub LoadUsers()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT EmployeeID, CompanyIDNumber, FirstName, MiddleName, LastName, ExtName, EmailAdd, Username, PhoneNumber, Department, Designation, UserType, Status, ApprovalStatus, ProfilePicture FROM employeeprofile", conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvUsers.DataSource = table
                dgvUsers.ClearSelection()
                dgvUsers.Columns("ProfilePicture").Visible = False
                dgvUsers.Columns("EmployeeID").Visible = False
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateInputs() Then
            Dim imageData As Byte() = Nothing
            If picProfile.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    picProfile.Image.Save(ms, Imaging.ImageFormat.Png)
                    imageData = ms.ToArray()
                End Using
            End If

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO employeeprofile (CompanyIDNumber, FirstName, MiddleName, LastName, ExtName, EmailAdd, Username, Password, PhoneNumber, Department, Designation, UserType, Status, ApprovalStatus, ProfilePicture) VALUES (@CompanyIDNumber, @FirstName, @MiddleName, @LastName, @ExtName, @EmailAdd, @Username, @Password, @PhoneNumber, @Department, @Designation, @UserType, @Status, @ApprovalStatus, @ProfilePicture)", conn)

                cmd.Parameters.AddWithValue("@CompanyIDNumber", txtComID.Text)
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@ExtName", txtExtName.Text)
                cmd.Parameters.AddWithValue("@EmailAdd", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text)
                cmd.Parameters.AddWithValue("@Designation", txtDesignation.Text)
                cmd.Parameters.AddWithValue("@UserType", cmbUserType.Text)
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@ApprovalStatus", cmbApprovalStatus.Text)
                cmd.Parameters.AddWithValue("@ProfilePicture", If(imageData IsNot Nothing, imageData, DBNull.Value))

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("User added successfully!")
            ClearInputs()
            LoadUsers()
        End If

        LogActivity("Add Account of: " & txtComID.Text.Trim(), LoggedInEmployeeName)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If currentUserId = -1 Then
            MessageBox.Show("Please select a user and click Edit first.")
            Return
        End If

        If ValidateInputs() Then
            Dim imageData As Byte() = Nothing
            If picProfile.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    picProfile.Image.Save(ms, Imaging.ImageFormat.Png)
                    imageData = ms.ToArray()
                End Using
            End If

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "UPDATE employeeprofile SET CompanyIDNumber = @CompanyIDNumber, FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, ExtName = @ExtName, EmailAdd = @EmailAdd, Username = @Username, Password = @Password, PhoneNumber = @PhoneNumber, Department = @Department, Designation = @Designation, UserType = @UserType, Status = @Status, ApprovalStatus = @ApprovalStatus, ProfilePicture = @ProfilePicture WHERE EmployeeID = @EmployeeID"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@CompanyIDNumber", txtComID.Text)
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@ExtName", txtExtName.Text)
                cmd.Parameters.AddWithValue("@EmailAdd", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)

                ' Conditional password logic
                If Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                Else
                    cmd.Parameters.AddWithValue("@Password", GetCurrentPassword(currentUserId))
                End If

                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text)
                cmd.Parameters.AddWithValue("@Designation", txtDesignation.Text)
                cmd.Parameters.AddWithValue("@UserType", cmbUserType.Text)
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@ApprovalStatus", cmbApprovalStatus.Text)
                cmd.Parameters.AddWithValue("@ProfilePicture", If(imageData IsNot Nothing, imageData, DBNull.Value))
                cmd.Parameters.AddWithValue("@EmployeeID", currentUserId)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("User updated successfully!")
            ClearInputs()
            LoadUsers()
        End If

        LogActivity("Edit and Update Account of: " & txtComID.Text.Trim(), LoggedInEmployeeName)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to edit.")
            Return
        End If

        If MessageBox.Show("Are you sure you want to edit the selected record?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim row As DataGridViewRow = dgvUsers.SelectedRows(0)

            currentUserId = Convert.ToInt32(row.Cells("EmployeeID").Value)
            txtComID.Text = row.Cells("CompanyIDNumber").Value.ToString()
            txtFirstName.Text = row.Cells("FirstName").Value.ToString()
            txtMiddleName.Text = row.Cells("MiddleName").Value.ToString()
            txtLastName.Text = row.Cells("LastName").Value.ToString()
            txtExtName.Text = row.Cells("ExtName").Value.ToString()
            txtEmail.Text = row.Cells("EmailAdd").Value.ToString()
            txtUsername.Text = row.Cells("Username").Value.ToString()
            txtPhoneNumber.Text = row.Cells("PhoneNumber").Value.ToString()
            cmbDepartment.Text = row.Cells("Department").Value.ToString()
            txtDesignation.Text = row.Cells("Designation").Value.ToString()
            cmbUserType.Text = row.Cells("UserType").Value.ToString()
            cmbStatus.Text = row.Cells("Status").Value.ToString()
            cmbApprovalStatus.Text = row.Cells("ApprovalStatus").Value.ToString()
            txtPassword.Enabled = False
            txtUsername.Enabled = False
            If Not IsDBNull(row.Cells("ProfilePicture").Value) Then
                Dim imageData As Byte() = CType(row.Cells("ProfilePicture").Value, Byte())
                Using ms As New MemoryStream(imageData)
                    picProfile.Image = Image.FromStream(ms)
                End Using
            Else
                picProfile.Image = Nothing
            End If

            btnAdd.Enabled = False
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            If ofd.ShowDialog() = DialogResult.OK Then
                picProfile.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
        LogActivity("Upload Picture of: " & txtComID.Text.Trim(), LoggedInEmployeeName)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub ClearInputs()
        txtComID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtExtName.Clear()
        txtEmail.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtPhoneNumber.Clear()
        cmbDepartment.SelectedIndex = -1
        txtDesignation.Clear()
        cmbUserType.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        cmbApprovalStatus.SelectedIndex = -1
        picProfile.Image = Nothing

        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        currentUserId = -1
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtComID.Text) OrElse String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("Please fill in the required fields.")
            Return False
        End If
        Return True
    End Function

    Private Function GetCurrentPassword(userId As Integer) As String
        ' Retrieve the current password for the user from the database
        Dim currentPassword As String = String.Empty
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT Password FROM employeeprofile WHERE EmployeeID = @EmployeeID", conn)
                cmd.Parameters.AddWithValue("@EmployeeID", userId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        currentPassword = reader("Password").ToString()
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error retrieving password: " & ex.Message)
        End Try
        Return currentPassword
    End Function

    ' Step 1: Add a TextBox (txtSearch) to the form and the following handler.

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchUsers(txtSearch.Text)
    End Sub

    ' Step 2: Implement the SearchUsers method to filter the DataGridView.

    Private Sub SearchUsers(searchTerm As String)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT EmployeeID, CompanyIDNumber, FirstName, MiddleName, LastName, ExtName, EmailAdd, Username, PhoneNumber, Department, Designation, UserType, Status, ApprovalStatus, ProfilePicture " &
                                  "FROM employeeprofile WHERE CONCAT(CompanyIDNumber, ' ', FirstName, ' ', MiddleName, ' ', LastName, ' ', Username) LIKE @SearchTerm"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvUsers.DataSource = table
                    dgvUsers.ClearSelection()
                    dgvUsers.Columns("ProfilePicture").Visible = False
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching users: " & ex.Message)
        End Try
    End Sub


End Class