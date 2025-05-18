Imports MySql.Data.MySqlClient

Public Class frmSoftwareList
    ' Make sure the connection is already defined, use the GetConnection function for DB access
    Private connection As MySqlConnection = GetConnection()

    ' Load the software data into DataGridView
    Private Sub LoadSoftwareData()
        Dim conn As MySqlConnection = GetConnection()
        Dim cmd As New MySqlCommand("SELECT SoftwareCode,SoftwareName,SoftwareVersion,LicenseExpiryDate FROM SoftwareTable", conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            dt.Load(cmd.ExecuteReader())
            dgvSoftware.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading software data: " & ex.Message)
        Finally
            conn.Close()
        End Try



    End Sub



    ' Handle search text change to filter the software list
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Query to search software by SoftwareName
        Dim query As String = "SELECT SoftwareCode, SoftwareName, SoftwareVersion, SoftwareLicenseKey, " &
                              "MainCategoryID, SubCategoryID, Description, LicenseExpiryDate, PurchaseDate " &
                              "FROM SoftwareTable WHERE SoftwareName LIKE @SearchText"

        ' Create a MySqlCommand to fetch data
        Using cmd As New MySqlCommand(query, connection)
            ' Add parameter to prevent SQL injection
            cmd.Parameters.AddWithValue("@SearchText", "%" & txtSearch.Text & "%")

            Try
                ' Open connection
                connection.Open()

                ' Use MySqlDataAdapter to fill data into DataTable
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind the filtered data to DataGridView
                dgvSoftware.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error searching software data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close connection
                connection.Close()
            End Try
        End Using
    End Sub

    ' Event handler for DataBindingComplete event to hide the SoftwareCode column
    Private Sub dgvSoftware_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        ' Ensure SoftwareCode column is hidden after binding is complete
        Try
            If dgvSoftware.Columns.Contains("SoftwareCode") Then
                dgvSoftware.Columns("SoftwareCode").Visible = True
            End If
        Catch ex As Exception
            ' Handle any errors, such as if the column doesn't exist
            MessageBox.Show("Error hiding SoftwareCode column: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Delete selected software record
    Private Sub btnDeleteSoftware_Click(sender As Object, e As EventArgs) Handles btnDeleteSoftware.Click
        If dgvSoftware.SelectedRows.Count > 0 Then
            ' Get the SoftwareCode of the selected software record
            Dim selectedSoftwareCode As String = dgvSoftware.SelectedRows(0).Cells("SoftwareCode").Value.ToString()

            ' Ask for confirmation before deleting
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this software record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Call the DeleteSoftwareRecord method to delete the record
                DeleteSoftwareRecord(selectedSoftwareCode)

                ' Optionally, refresh the data in the DataGridView
                LoadSoftwareData()
            End If
        Else
            MessageBox.Show("Please select a software record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Delete a software record from the database
    Public Sub DeleteSoftwareRecord(softwareCode As String)
        ' Define the query to delete a record based on SoftwareCode
        Dim query As String = "DELETE FROM SoftwareTable WHERE SoftwareCode = @SoftwareCode"

        ' Use the connection inside the 'Using' block
        Using conn As MySqlConnection = GetConnection()
            ' Create the command and set its properties
            Using cmd As New MySqlCommand(query, conn)
                ' Add the parameter for the SoftwareCode to prevent SQL injection
                cmd.Parameters.AddWithValue("@SoftwareCode", softwareCode)

                Try
                    ' Open the connection (this is safe within the 'Using' block)
                    conn.Open()

                    ' Execute the command (this will delete the record)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if a record was deleted
                    If rowsAffected > 0 Then
                        MessageBox.Show("Software record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No record found with the given SoftwareCode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error deleting software record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

    End Sub

    ' Form Load event to load the software data into the DataGridView
    Private Sub frmSoftwareList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the software data on form load
        LoadSoftwareData()
        dgvSoftware.ScrollBars = ScrollBars.Both
        dgvSoftware.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvSoftware.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvSoftware.ColumnHeadersVisible = True
        ' Subscribe to the DataBindingComplete event once on form load
        AddHandler dgvSoftware.DataBindingComplete, AddressOf dgvSoftware_DataBindingComplete
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selectedSoftwareCode As String = dgvSoftware.SelectedRows(0).Cells("SoftwareCode").Value.ToString()
        Dim frmAddSoftware As New frmAddSoftware()

        ' Set the form to edit mode
        frmAddSoftware.isEditMode = True
        frmAddSoftware.EditSoftwareCode = selectedSoftwareCode

        ' Subscribe to the SoftwareUpdated event
        AddHandler frmAddSoftware.SoftwareUpdated, AddressOf RefreshSoftwareList

        frmAddSoftware.ShowDialog()

    End Sub
    Private Sub RefreshSoftwareList(sender As Object, e As EventArgs)
        LoadSoftwareData() ' This method reloads the software data into the DataGridView
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addForm As New frmAddSoftware()
        addForm.isEditMode = False ' Make sure it's in Add Mode
        addForm.ShowDialog()

        ' Optional: Reload list after closing frmAddSoftware
        LoadSoftwareData()
    End Sub

    Public Sub LoadSoftwareList()
        Dim query As String = "SELECT SoftwareCode, SoftwareName, SoftwareVersion, LicenseExpiryDate FROM SoftwareTable"

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    'dgvSoftware.Columns.Clear() ' Clear previous columns
                    'dgvSoftware.AutoGenerateColumns = True
                    dgvSoftware.DataSource = dt
                    dgvSoftware.ScrollBars = ScrollBars.Both
                    dgvSoftware.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                    dgvSoftware.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    dgvSoftware.ColumnHeadersVisible = True
                End Using
            End Using
        End Using
    End Sub




End Class
