Imports MySql.Data.MySqlClient

Public Class frmSubClassification

    Dim connectionString As String = "server=localhost;userid=root;password=;database=assetinventorydb;"
    Dim selectedSubClassID As Integer = -1 ' To keep track of the selected SubClass for editing/deleting

    ' Load data into ComboBox (cmbMainClass)
    Private Sub LoadMainClassData()
        Dim query As String = "SELECT MainClassID, MainClassName FROM MainClassificationTable"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                cmbMainClass.DataSource = table
                cmbMainClass.DisplayMember = "MainClassName"
                cmbMainClass.ValueMember = "MainClassID"
            Catch ex As Exception
                MessageBox.Show("Error loading Main Class data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Load data into DataGridView (dgvSubClassifications)
    Private Sub LoadSubClassificationData()
        Dim query As String = "SELECT SubClassID,SubClassCode , SubClassName, Description FROM SubClassificationTable"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Renaaming header column
                dgvSubClassifications.DataSource = table
                dgvSubClassifications.Columns("SubClassID").HeaderText = "ID"
                dgvSubClassifications.Columns("SubClassName").HeaderText = "Name"
                dgvSubClassifications.Columns("SubClassCode").HeaderText = "Code"
                ' center allignment of header column
                dgvSubClassifications.Columns("SubClassID").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvSubClassifications.Columns("SubClassName").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvSubClassifications.Columns("SubClassCode").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvSubClassifications.Columns("Description").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Catch ex As Exception
                MessageBox.Show("Error loading Sub Classification data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Handle Add Button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim subClassName As String = txtSubClassName.Text.Trim()
        Dim description As String = txtDescription.Text.Trim()

        ' Validate SubClassName
        If String.IsNullOrEmpty(subClassName) Then
            MessageBox.Show("Sub Classification Name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Generate unique SubClassCode
        Dim subClassCode As String = GenerateSubClassCode(subClassName)

        ' Insert new record
        Dim query As String = "INSERT INTO SubClassificationTable (MainClassID, SubClassName, SubClassCode, Description) VALUES (@MainClassID, @SubClassName, @SubClassCode, @Description)"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MainClassID", cmbMainClass.SelectedValue)
                    cmd.Parameters.AddWithValue("@SubClassName", subClassName)
                    cmd.Parameters.AddWithValue("@SubClassCode", subClassCode)
                    cmd.Parameters.AddWithValue("@Description", description)
                    cmd.ExecuteNonQuery()
                End Using
                ' Show success message without SubClassCode
                MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadSubClassificationData()
                txtSubClassName.Clear()
                txtDescription.Clear()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    ' Handle Edit/Update Button
    Private Sub btnEditUpdate_Click(sender As Object, e As EventArgs) Handles btnEditUpdate.Click
        Dim subClassName As String = txtSubClassName.Text.Trim()
        Dim description As String = txtDescription.Text.Trim()

        ' Validate SubClassName
        If String.IsNullOrEmpty(subClassName) Then
            MessageBox.Show("Sub Classification Name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Generate unique SubClassCode
        Dim subClassCode As String = GenerateSubClassCode(subClassName)

        ' Update record
        Dim query As String = "UPDATE SubClassificationTable SET MainClassID = @MainClassID, SubClassName = @SubClassName, SubClassCode = @SubClassCode, Description = @Description WHERE SubClassID = @SubClassID"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MainClassID", cmbMainClass.SelectedValue)
                    cmd.Parameters.AddWithValue("@SubClassName", subClassName)
                    cmd.Parameters.AddWithValue("@SubClassCode", subClassCode)
                    cmd.Parameters.AddWithValue("@Description", description)
                    cmd.Parameters.AddWithValue("@SubClassID", selectedSubClassID)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadSubClassificationData()
                txtSubClassName.Clear()
                txtDescription.Clear()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Handle Delete Button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedSubClassID = -1 Then
            MessageBox.Show("Please select a record to delete first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Exit Sub

        Dim query As String = "DELETE FROM SubClassificationTable WHERE SubClassID = @SubClassID"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SubClassID", selectedSubClassID)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadSubClassificationData()
                selectedSubClassID = -1
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Handle Row Selection in DataGridView for Edit/Delete
    Private Sub dgvSubClassifications_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubClassifications.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSubClassifications.Rows(e.RowIndex)
            selectedSubClassID = Convert.ToInt32(row.Cells("SubClassID").Value)
            txtSubClassName.Text = row.Cells("SubClassName").Value.ToString()
            txtDescription.Text = row.Cells("Description").Value.ToString()
            cmbMainClass.SelectedValue = row.Cells("MainClassID").Value
        End If
    End Sub

    ' Generate SubClassCode (Unique Code)
    Private Function GenerateSubClassCode(subClassName As String) As String
        If String.IsNullOrEmpty(subClassName) Then Return ""

        ' Split words
        Dim words As String() = subClassName.Split(" "c)
        Dim baseCode As String

        ' Generate base code based on word count
        If words.Length = 1 Then
            baseCode = words(0).Substring(0, Math.Min(2, words(0).Length)).ToUpper() ' First 2 letters
        Else
            baseCode = (words(0)(0).ToString() & words(1)(0).ToString()).ToUpper() ' First letter of each word
        End If

        Dim newCode As String = baseCode
        Dim counter As Integer = 1

        ' Check for existing codes
        Dim query As String = "SELECT SubClassCode FROM SubClassificationTable WHERE SubClassCode LIKE @BaseCodePattern ORDER BY SubClassCode DESC"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BaseCodePattern", baseCode & "%")
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim existingCode As String = reader.GetString(0)
                        Dim numberPart As String = existingCode.Substring(baseCode.Length)

                        If Integer.TryParse(numberPart, counter) Then
                            counter += 1
                        Else
                            counter = 1
                        End If
                    End While
                End Using
            End Using
        End Using

        newCode = baseCode & counter.ToString("D2") ' Append number (e.g., LA01, GL01)
        Return newCode
    End Function

    ' Form Load - Load SubClass and MainClass data
    Private Sub frmSubClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load SubClassification data
        LoadSubClassificationData()

        ' Load MainClass data into ComboBox
        LoadMainClassData()

        ' Set cmbMainClass to have no selected item (user must click the dropdown)
        cmbMainClass.SelectedIndex = -1
    End Sub


End Class
