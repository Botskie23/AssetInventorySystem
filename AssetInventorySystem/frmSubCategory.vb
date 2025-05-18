Imports MySql.Data.MySqlClient

Public Class frmSubCategory

    ' Load form and necessary data
    Private Sub frmSubCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubCategories()
        LoadMainCategories()
    End Sub

    ' Load SubCategories from database
    Private Sub LoadSubCategories()
        Dim query As String = "SELECT * FROM SubCategory"
        Dim dt As DataTable = GetData(query)

        dgvSubCategories.DataSource = dt
        dgvSubCategories.Columns("SubCategoryID").Visible = False
    End Sub

    ' Load Main Categories into ComboBox
    Private Sub LoadMainCategories()
        Dim query As String = "SELECT * FROM MainCategory"
        Dim dt As DataTable = GetData(query)

        cmbMainCategory.DataSource = dt
        cmbMainCategory.DisplayMember = "MainCategoryName"
        cmbMainCategory.ValueMember = "MainCategoryID"
        cmbMainCategory.SelectedIndex = -1
    End Sub

    ' Add or Update SubCategory
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtSubCategoryName.Text = "" Or cmbMainCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim mainCategoryID As Integer = cmbMainCategory.SelectedValue
        Dim subCategoryName As String = txtSubCategoryName.Text.Trim()

        If btnAdd.Text = "Add" Then
            ' Check for duplicate
            If IsDuplicateSubCategory(mainCategoryID, subCategoryName) Then
                MessageBox.Show("This subcategory already exists under the selected main category.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ClearForm()
                Return

            End If

            Dim query As String = "INSERT INTO SubCategory (MainCategoryID, SubCategoryCode, SubCategoryName, Description) " &
                              "VALUES (@MainCategoryID, @SubCategoryCode, @SubCategoryName, @Description)"
            Dim cmd As New MySqlCommand(query)
            cmd.Parameters.AddWithValue("@MainCategoryID", mainCategoryID)
            cmd.Parameters.AddWithValue("@SubCategoryCode", txtSubCategoryCode.Text)
            cmd.Parameters.AddWithValue("@SubCategoryName", subCategoryName)
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text)

            ExecuteQuery(cmd)
            MessageBox.Show("Subcategory added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf btnAdd.Text = "Update" Then
            Dim subCategoryID As Integer = Convert.ToInt32(btnAdd.Tag)

            ' Check for duplicate during update
            If IsDuplicateSubCategory(mainCategoryID, subCategoryName, subCategoryID) Then
                MessageBox.Show("This subcategory already exists under the selected main category.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim query As String = "UPDATE SubCategory SET " &
                              "MainCategoryID = @MainCategoryID, " &
                              "SubCategoryCode = @SubCategoryCode, " &
                              "SubCategoryName = @SubCategoryName, " &
                              "Description = @Description WHERE SubCategoryID = @SubCategoryID"
            Dim cmd As New MySqlCommand(query)
            cmd.Parameters.AddWithValue("@MainCategoryID", mainCategoryID)
            cmd.Parameters.AddWithValue("@SubCategoryCode", txtSubCategoryCode.Text)
            cmd.Parameters.AddWithValue("@SubCategoryName", subCategoryName)
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
            cmd.Parameters.AddWithValue("@SubCategoryID", subCategoryID)

            ExecuteQuery(cmd)
            MessageBox.Show("Subcategory updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnAdd.Text = "Add"
            btnAdd.Tag = Nothing
        End If

        ClearForm()
        LoadSubCategories()
    End Sub


    ' Handle Edit button (load selected row data)
    Private Sub btnEditUpdate_Click(sender As Object, e As EventArgs) Handles btnEditUpdate.Click
        If dgvSubCategories.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subcategory to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to edit this subcategory?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow = dgvSubCategories.SelectedRows(0)
            Dim subCategoryID As Integer = Convert.ToInt32(selectedRow.Cells("SubCategoryID").Value)

            txtSubCategoryCode.Text = selectedRow.Cells("SubCategoryCode").Value.ToString()
            txtSubCategoryName.Text = selectedRow.Cells("SubCategoryName").Value.ToString()
            txtDescription.Text = selectedRow.Cells("Description").Value.ToString()

            Dim mainCategoryID As Integer = Convert.ToInt32(selectedRow.Cells("MainCategoryID").Value)
            cmbMainCategory.SelectedValue = mainCategoryID

            btnAdd.Text = "Update"
            btnAdd.Tag = subCategoryID
        End If
    End Sub




    ' Execute INSERT or UPDATE
    Private Sub ExecuteQuery(cmd As MySqlCommand)
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Get data from database
    Private Function GetData(query As String) As DataTable
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            Return dt
        End Using
    End Function
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvSubCategories.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subcategory to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataGridViewRow = dgvSubCategories.SelectedRows(0)
        Dim subCategoryID As Integer = Convert.ToInt32(row.Cells("SubCategoryID").Value)

        If MessageBox.Show("Are you sure you want to delete this subcategory?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim query As String = "DELETE FROM SubCategory WHERE SubCategoryID = @SubCategoryID"
            Dim cmd As New MySqlCommand(query)
            cmd.Parameters.AddWithValue("@SubCategoryID", subCategoryID)
            ExecuteQuery(cmd)

            MessageBox.Show("Subcategory deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadSubCategories()
        End If
    End Sub

    Private Sub ClearForm()
        txtSubCategoryCode.Clear()
        txtSubCategoryName.Clear()
        txtDescription.Clear()
        cmbMainCategory.SelectedIndex = -1
        btnAdd.Text = "Add"
        btnAdd.Tag = Nothing
    End Sub

    Private Function IsDuplicateSubCategory(mainCategoryID As Integer, subCategoryName As String, Optional excludeID As Integer = 0) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM SubCategory WHERE MainCategoryID = @MainCategoryID AND LOWER(SubCategoryName) = @SubCategoryName"
        If excludeID > 0 Then
            query &= " AND SubCategoryID <> @SubCategoryID"
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@MainCategoryID", mainCategoryID)
            cmd.Parameters.AddWithValue("@SubCategoryName", subCategoryName.ToLower())
            If excludeID > 0 Then
                cmd.Parameters.AddWithValue("@SubCategoryID", excludeID)
            End If

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

End Class
