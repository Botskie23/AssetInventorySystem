Imports MySql.Data.MySqlClient

Public Class frmMainClassification
    Private connectionString As String = "server=localhost;userid=root;password=;database=assetinventorydb;"
    Private selectedMainClassID As Integer = -1

    ' Load data when the form loads
    Private Sub frmMainClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMainClassificationData()
        btnEditUpdate.Text = "Edit"
    End Sub

    ' Function to generate a unique MainClassCode
    Private Function GenerateMainClassCode(mainClassName As String) As String
        Dim baseCode As String = mainClassName.Substring(0, Math.Min(2, mainClassName.Length)).ToUpper()
        Dim newCode As String = baseCode

        Dim query As String = "SELECT COUNT(*) FROM MainClassificationTable WHERE MainClassCode LIKE @BaseCodePattern"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BaseCodePattern", baseCode & "%")
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    newCode = baseCode & (count + 1).ToString()
                End If
            End Using
        End Using

        Return newCode
    End Function

    ' Function to check if MainClassName already exists
    Private Function IsDuplicateMainClassName(mainClassName As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM MainClassificationTable WHERE MainClassName = @MainClassName"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MainClassName", mainClassName)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    ' Function to add a new record
    Private Sub AddMainClassification()
        Dim mainClassName As String = txtMainClassname.Text.Trim()
        Dim description As String = txtDescription.Text.Trim()

        If String.IsNullOrEmpty(mainClassName) Then
            MessageBox.Show("Main Class Name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If IsDuplicateMainClassName(mainClassName) Then
            MessageBox.Show("Main Class Name already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim mainClassCode As String = GenerateMainClassCode(mainClassName)
        Dim query As String = "INSERT INTO MainClassificationTable (MainClassCode, MainClassName, Description) VALUES (@MainClassCode, @MainClassName, @Description)"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MainClassCode", mainClassCode)
                cmd.Parameters.AddWithValue("@MainClassName", mainClassName)
                cmd.Parameters.AddWithValue("@Description", description)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMainClassificationData()
            txtMainClassname.Clear()
            txtDescription.Clear()
        End Using
    End Sub

    ' Function to load data into DataGridView
    Private Sub LoadMainClassificationData()
        Dim query As String = "SELECT * FROM MainClassificationTable"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvMainClassifications.DataSource = table
        End Using
    End Sub

    ' Handle Add Button Click
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddMainClassification()
    End Sub

    ' Handle DataGridView Click to Select Record for Editing
    Private Sub dgvMainClassifications_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMainClassifications.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMainClassifications.Rows(e.RowIndex)
            selectedMainClassID = Convert.ToInt32(row.Cells("MainClassID").Value)
            txtMainClassname.Text = row.Cells("MainClassName").Value.ToString()
            txtDescription.Text = row.Cells("Description").Value.ToString()
            btnEditUpdate.Text = "Update"
        End If
    End Sub

    ' Handle Edit/Update button click
    Private Sub btnEditUpdate_Click(sender As Object, e As EventArgs) Handles btnEditUpdate.Click
        If btnEditUpdate.Text = "Edit" Then
            MessageBox.Show("Please select a record to edit first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit this record?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Exit Sub

        Dim mainClassName As String = txtMainClassname.Text.Trim()
        Dim description As String = txtDescription.Text.Trim()

        If String.IsNullOrEmpty(mainClassName) Then
            MessageBox.Show("Main Class Name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "UPDATE MainClassificationTable SET MainClassName = @MainClassName, Description = @Description WHERE MainClassID = @MainClassID"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MainClassID", selectedMainClassID)
                cmd.Parameters.AddWithValue("@MainClassName", mainClassName)
                cmd.Parameters.AddWithValue("@Description", description)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMainClassificationData()
            btnEditUpdate.Text = "Edit"
            txtMainClassname.Clear()
            txtDescription.Clear()
        End Using
    End Sub

    ' Handle Delete Button Click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedMainClassID = -1 Then
            MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then Exit Sub

        Dim query As String = "DELETE FROM MainClassificationTable WHERE MainClassID = @MainClassID"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MainClassID", selectedMainClassID)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMainClassificationData()
            txtMainClassname.Clear()
            txtDescription.Clear()
        End Using
    End Sub
End Class
