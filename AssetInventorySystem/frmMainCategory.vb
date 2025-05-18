' Function to load main categories into the DataGridView
Imports MySql.Data.MySqlClient
Public Class frmMainCategory
    Private Sub LoadMainCategories()
        Dim query As String = "SELECT MainCategoryID, MainCategoryCode, MainCategoryName FROM maincategory"
        Dim dt As New DataTable

        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        dgvMainCategories.DataSource = dt

        ' Set column headers
        dgvMainCategories.Columns("MainCategoryID").HeaderText = "ID"
        dgvMainCategories.Columns("MainCategoryCode").HeaderText = "Category Code"
        dgvMainCategories.Columns("MainCategoryName").HeaderText = "Category Name"

        ' Optional: Adjust column widths
        dgvMainCategories.Columns("MainCategoryID").Width = 50
        dgvMainCategories.Columns("MainCategoryCode").Width = 120
        dgvMainCategories.Columns("MainCategoryName").AutoSizeMode = DataGridViewAutoSizeColumnMode.None

        ' Optional: Make grid read-only and visually appealing
        dgvMainCategories.ReadOnly = True
        dgvMainCategories.AllowUserToAddRows = False
        dgvMainCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMainCategories.MultiSelect = False
    End Sub


    ' Function to add a new main category
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtMainCategoryName.Text.Trim() = "" Or txtMainCategoryCode.Text.Trim() = "" Then
            MessageBox.Show("Please enter both the Category Name and Code.")
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            If btnAdd.Text = "Add" Then
                ' ADD NEW RECORD
                Dim insertQuery As String = "INSERT INTO maincategory (MainCategoryCode, MainCategoryName) VALUES (@Code, @Name)"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@Code", txtMainCategoryCode.Text)
                    cmd.Parameters.AddWithValue("@Name", txtMainCategoryName.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Main category added successfully.")
            ElseIf btnAdd.Text = "Update" Then
                ' UPDATE EXISTING RECORD
                If dgvMainCategories.SelectedRows.Count = 0 Then
                    MessageBox.Show("Please select a category to update.")
                    Return
                End If

                Dim selectedID As Integer = Convert.ToInt32(dgvMainCategories.SelectedRows(0).Cells("MainCategoryID").Value)
                Dim updateQuery As String = "UPDATE maincategory SET MainCategoryCode = @Code, MainCategoryName = @Name WHERE MainCategoryID = @ID"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@Code", txtMainCategoryCode.Text)
                    cmd.Parameters.AddWithValue("@Name", txtMainCategoryName.Text)
                    cmd.Parameters.AddWithValue("@ID", selectedID)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Main category updated successfully.")
                btnAdd.Text = "Add" ' Reset back to Add
            End If
        End Using

        ClearForm()
        LoadMainCategories()
    End Sub
    Private Sub ClearForm()
        txtMainCategoryCode.Clear()
        txtMainCategoryName.Clear()
        btnAdd.Text = "Add"
        dgvMainCategories.ClearSelection()
    End Sub

    Private Sub dgvMainCategories_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMainCategories.CellClick
        If e.RowIndex >= 0 Then
            ' Just highlight the selected row, no action needed here
        End If
    End Sub




    ' Function to edit an existing main category
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvMainCategories.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvMainCategories.SelectedRows(0)

            ' Fill the textboxes with the selected row values
            txtMainCategoryCode.Text = selectedRow.Cells("MainCategoryCode").Value.ToString()
            txtMainCategoryName.Text = selectedRow.Cells("MainCategoryName").Value.ToString()

            ' Change the button text to "Update"
            btnAdd.Text = "Update"
        Else
            MessageBox.Show("Please select a category to edit.")
        End If
    End Sub


    ' Function to delete a main category
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvMainCategories.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a main category to delete.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvMainCategories.SelectedRows(0)
        Dim mainCategoryId As Integer = Convert.ToInt32(selectedRow.Cells("MainCategoryID").Value)

        Dim query As String = "DELETE FROM maincategory WHERE MainCategoryID = @ID"

        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", mainCategoryId)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Main category deleted successfully.")
        LoadMainCategories()
    End Sub

    Private Sub frmMainCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMainCategories()
    End Sub

End Class