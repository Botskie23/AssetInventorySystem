Imports MySql.Data.MySqlClient

Public Class frmAssetDisposal

    Private Sub frmAssetDisposal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssetsForDisposal()
        cmbDisposalReason.Items.AddRange(New String() {"Obsolete", "Damaged beyond repair", "Excess", "Other"})
        cmbDisposalReason.SelectedIndex = 0
        dtpDisposalDate.Value = Date.Today
    End Sub

    ' Load assets that are marked for disposal or damaged
    Private Sub LoadAssetsForDisposal()
        Dim query As String = "
            SELECT AssetCode, AssetName
            FROM itassettable
            WHERE AvailabilityStatus = 'For Disposal' OR AvailabilityStatus = 'Damaged'
        "

        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvAssetsToDispose.DataSource = table
            End Using
        End Using
    End Sub

    ' Handle cell click to populate asset info for disposal
    Private Sub dgvAssetsToDispose_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAssetsToDispose.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAssetsToDispose.Rows(e.RowIndex)
            txtAssetCode.Text = row.Cells("AssetCode").Value.ToString()
            txtAssetName.Text = row.Cells("AssetName").Value.ToString()
            txtDisposalBy.Text = Environment.UserName ' Or fetch logged-in user
        End If
    End Sub

    ' Confirm the disposal and update records
    Private Sub btnDisposeAsset_Click(sender As Object, e As EventArgs) Handles btnDisposeAsset.Click
        If dgvAssetsToDispose.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an asset from the list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim assetCode As String = txtAssetCode.Text.Trim()
        Dim disposalDate As Date = dtpDisposalDate.Value.Date
        Dim disposalReason As String = cmbDisposalReason.Text
        Dim remarks As String = txtRemarks.Text.Trim()
        Dim disposalBy As String = txtDisposalBy.Text.Trim()

        ' Insert disposal record into AssetDisposalTable
        Dim insertQuery As String = "
            INSERT INTO AssetDisposalTable (AssetCode, DisposalDate, DisposalReason, Remarks, DisposalBy)
            VALUES (@AssetCode, @DisposalDate, @DisposalReason, @Remarks, @DisposalBy)
        "

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@AssetCode", assetCode)
                cmd.Parameters.AddWithValue("@DisposalDate", disposalDate)
                cmd.Parameters.AddWithValue("@DisposalReason", disposalReason)
                cmd.Parameters.AddWithValue("@Remarks", remarks)
                cmd.Parameters.AddWithValue("@DisposalBy", disposalBy)
                cmd.ExecuteNonQuery()
            End Using

            ' Update AvailabilityStatus in ITAssetTable to "Disposed"
            Dim updateQuery As String = "
                UPDATE itassettable 
                SET AvailabilityStatus = 'Disposed' 
                WHERE AssetCode = @AssetCode
            "

            Using updateCmd As New MySqlCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@AssetCode", assetCode)
                updateCmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Asset successfully disposed and status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearForm()
        LoadAssetsForDisposal() ' Refresh the list of assets for disposal
    End Sub

    ' Clear form fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    ' Clear all form fields
    Private Sub ClearForm()
        txtAssetCode.Clear()
        txtAssetName.Clear()
        txtDisposalBy.Clear()
        txtRemarks.Clear()
        dtpDisposalDate.Value = Date.Today
        cmbDisposalReason.SelectedIndex = 0
    End Sub

End Class
