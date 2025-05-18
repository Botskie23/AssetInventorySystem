Imports MySql.Data.MySqlClient

Public Class frmAssetReturn

    Private Sub frmAssetReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssignedAssets()
        cmbConditionOnReturn.Items.AddRange(New String() {"Good", "Damaged", "Needs Repair", "Missing Parts"})
        cmbConditionOnReturn.SelectedIndex = 0
        dtpReturnDate.Value = Date.Today
    End Sub

    ' Load assigned assets that have not been returned yet
    Private Sub LoadAssignedAssets()
        Dim query As String = "
            SELECT aa.AssignmentID, it.AssetCode, it.AssetName,
                   CONCAT(emp.FirstName, ' ', emp.LastName) AS EmployeeName
            FROM assetassignments aa
            INNER JOIN itassettable it ON aa.AssetID = it.AssetID
            INNER JOIN employeeprofile emp ON aa.EmployeeID = emp.EmployeeID
            LEFT JOIN assetreturntable ar ON aa.AssignmentID = ar.AssignmentID
            WHERE ar.AssignmentID IS NULL
        "

        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvAssignmentsToReturn.DataSource = table
            End Using
        End Using
    End Sub

    ' Handle cell click to populate asset and employee info
    Private Sub dgvAssignmentsToReturn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAssignmentsToReturn.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAssignmentsToReturn.Rows(e.RowIndex)
            txtAssetCode.Text = row.Cells("AssetCode").Value.ToString()
            txtEmployeeName.Text = row.Cells("EmployeeName").Value.ToString()
            txtReturnedBy.Text = Environment.UserName ' Or fetch logged-in user
        End If
    End Sub

    ' Confirm the return and update records
    Private Sub btnReturnAsset_Click(sender As Object, e As EventArgs) Handles btnReturnAsset.Click
        If dgvAssignmentsToReturn.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an assigned asset from the list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim assignmentID As Integer = Convert.ToInt32(dgvAssignmentsToReturn.SelectedRows(0).Cells("AssignmentID").Value)
        Dim returnDate As Date = dtpReturnDate.Value.Date
        Dim condition As String = cmbConditionOnReturn.Text
        Dim returnedBy As String = txtReturnedBy.Text.Trim()
        Dim receivedBy As String = txtReceivedBy.Text.Trim()
        Dim remarks As String = txtRemarks.Text.Trim()

        If receivedBy = "" Then
            MessageBox.Show("Please enter the name of the person who received the asset.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Map the condition to the AvailabilityStatus
        Dim availabilityStatus As String = MapConditionToAvailabilityStatus(condition)

        ' Insert return record into AssetReturnTable
        Dim insertQuery As String = "
            INSERT INTO assetreturntable (AssignmentID, AssetCode, ReturnDate, ConditionOnReturn, ReturnedBy, Remarks, ReceivedBy)
            VALUES (@AssignmentID, @AssetCode, @ReturnDate, @Condition, @ReturnedBy, @Remarks, @ReceivedBy);
        "

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            ' Insert the return record
            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID)
                cmd.Parameters.AddWithValue("@AssetCode", txtAssetCode.Text.Trim())
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate)
                cmd.Parameters.AddWithValue("@Condition", condition)
                cmd.Parameters.AddWithValue("@ReturnedBy", returnedBy)
                cmd.Parameters.AddWithValue("@Remarks", remarks)
                cmd.Parameters.AddWithValue("@ReceivedBy", receivedBy)
                cmd.ExecuteNonQuery()
            End Using

            ' Update AvailabilityStatus and AssetCondition in ITAssetTable
            Dim updateQuery As String = "
                UPDATE itassettable 
                SET AvailabilityStatus = @AvailabilityStatus,
                    AssetCondition = @AssetCondition
                WHERE AssetCode = @AssetCode;
            "

            Using updateCmd As New MySqlCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@AvailabilityStatus", availabilityStatus)
                updateCmd.Parameters.AddWithValue("@AssetCondition", condition)
                updateCmd.Parameters.AddWithValue("@AssetCode", txtAssetCode.Text.Trim())
                updateCmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Asset successfully returned and status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearForm()
        LoadAssignedAssets() ' Refresh the list of assigned assets
    End Sub

    ' Clear form fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    ' Clear all form fields
    Private Sub ClearForm()
        txtAssetCode.Clear()
        txtEmployeeName.Clear()
        txtReturnedBy.Clear()
        txtReceivedBy.Clear()
        txtRemarks.Clear()
        dtpReturnDate.Value = Date.Today
        cmbConditionOnReturn.SelectedIndex = 0
    End Sub

    ' Map condition on return to the asset's availability status
    Private Function MapConditionToAvailabilityStatus(condition As String) As String
        Select Case condition.Trim().ToLower()
            Case "good"
                Return "Available"
            Case "damaged", "needs repair"
                Return "Needs Repair"
            Case "missing parts"
                Return "For Disposal"
            Case Else
                Return "Unknown"
        End Select
    End Function

End Class
