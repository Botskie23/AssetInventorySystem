Imports MySql.Data.MySqlClient

Public Class frmAssetEvaluation

    Private Sub frmAssetEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssetsForEvaluation()
        PopulateEvaluationResult()
        PopulateUpdatedStatus()
    End Sub

    Private Sub LoadAssetsForEvaluation()
        Dim query As String = "
            SELECT ar.AssetCode, it.AssetName, ar.ConditionOnReturn, ar.Remarks
            FROM assetreturntable ar
            INNER JOIN itassettable it ON ar.AssetCode = it.AssetCode
            LEFT JOIN assetevaluationtable ae ON ar.AssetCode = ae.AssetCode
            WHERE (ar.ConditionOnReturn = 'Damaged' OR ar.ConditionOnReturn = 'Needs Repair')
              AND ae.AssetCode IS NULL
        "

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvAssetsToEvaluate.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading assets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateEvaluationResult()
        cmbEvaluationResult.Items.Clear()
        cmbEvaluationResult.Items.Add("Repaired")
        cmbEvaluationResult.Items.Add("Unrepairable")
        cmbEvaluationResult.Items.Add("Still Under Repair")
    End Sub

    Private Sub PopulateUpdatedStatus()
        cmbUpdatedStatus.Items.Clear()
        cmbUpdatedStatus.Items.Add("Available")
        cmbUpdatedStatus.Items.Add("Still Under Repair")
        cmbUpdatedStatus.Items.Add("For Disposal")
        cmbUpdatedStatus.Items.Add("Damaged")
    End Sub

    Private Sub dgvAssetsToEvaluate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAssetsToEvaluate.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAssetsToEvaluate.Rows(e.RowIndex)
            txtAssetCode.Text = row.Cells("AssetCode").Value.ToString()
            txtAssetName.Text = row.Cells("AssetName").Value.ToString()
            txtOriginalCondition.Text = row.Cells("ConditionOnReturn").Value.ToString()
        End If
    End Sub

    Private Sub btnSaveEvaluation_Click(sender As Object, e As EventArgs) Handles btnSaveEvaluation.Click
        If String.IsNullOrWhiteSpace(txtAssetCode.Text) OrElse
           cmbEvaluationResult.SelectedIndex = -1 OrElse
           cmbUpdatedStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please complete all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Insert into assetevaluationtable
                Dim insertQuery As String = "
                    INSERT INTO assetevaluationtable 
                    (AssetCode, EvaluatedBy, EvaluationDate, OriginalCondition, TechnicianRemarks, UpdatedStatus) 
                    VALUES (@AssetCode, @EvaluatedBy, @EvaluationDate, @OriginalCondition, @Remarks, @UpdatedStatus)
                "

                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@AssetCode", txtAssetCode.Text.Trim())
                    cmd.Parameters.AddWithValue("@EvaluatedBy", GlobalVariables.LoggedInEmployeeID)
                    cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Now)
                    cmd.Parameters.AddWithValue("@OriginalCondition", txtOriginalCondition.Text.Trim())
                    cmd.Parameters.AddWithValue("@Remarks", cmbEvaluationResult.Text.Trim())
                    cmd.Parameters.AddWithValue("@UpdatedStatus", cmbUpdatedStatus.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                ' Update AvailabilityStatus in itassettable
                Dim updateQuery As String = "UPDATE itassettable SET AvailabilityStatus = @UpdatedStatus WHERE AssetCode = @AssetCode"

                Using updateCmd As New MySqlCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@UpdatedStatus", cmbUpdatedStatus.Text.Trim())
                    updateCmd.Parameters.AddWithValue("@AssetCode", txtAssetCode.Text.Trim())
                    updateCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Asset evaluation saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadAssetsForEvaluation()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving evaluation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        txtAssetCode.Clear()
        txtAssetName.Clear()
        txtOriginalCondition.Clear()
        cmbEvaluationResult.SelectedIndex = -1
        cmbUpdatedStatus.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

End Class
