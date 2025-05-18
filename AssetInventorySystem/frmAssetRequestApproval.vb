Imports MySql.Data.MySqlClient

Public Class frmAssetRequestApproval

    Private Sub frmAssetRequestApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupAssetRequestsGrid()
        LoadAssetRequests()
    End Sub

    Private Sub dgvAssetRequests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAssetRequests.CellContentClick
        If e.ColumnIndex = dgvAssetRequests.Columns("btnView").Index AndAlso e.RowIndex >= 0 Then
            ' Get RequestID from selected row
            Dim requestID As Integer = Convert.ToInt32(dgvAssetRequests.Rows(e.RowIndex).Cells("RequestID").Value)

            ' Pass it to frmReportViewer
            '  Dim reportViewer As New frmReportViewer()
            '  reportViewer.SelectedRequestID = requestID
            '  reportViewer.ShowDialog()
        End If
    End Sub


    Private Sub SetupAssetRequestsGrid()
        With dgvAssetRequests
            .Columns.Clear()
            .AutoGenerateColumns = False

            .Columns.Add("RequestID", "Request ID")
            .Columns("RequestID").DataPropertyName = "RequestID"

            .Columns.Add("ReferenceNumber", "Reference #")
            .Columns("ReferenceNumber").DataPropertyName = "ReferenceNumber"

            .Columns.Add("FullName", "Requested By")
            .Columns("FullName").DataPropertyName = "FullName"

            .Columns.Add("RequestDate", "Request Date")
            .Columns("RequestDate").DataPropertyName = "RequestDate"

            .Columns.Add("FinalStatus", "FinalStatus")
            .Columns("FinalStatus").DataPropertyName = "FinalStatus"

            .Columns.Add("FinalRemarks", "FinalRemarks")
            .Columns("FinalRemarks").DataPropertyName = "FinalRemarks"

            ' Add View button
            Dim viewButton As New DataGridViewButtonColumn()
            viewButton.HeaderText = "Action"
            viewButton.Text = "View"
            viewButton.Name = "btnView"
            viewButton.UseColumnTextForButtonValue = True
            .Columns.Add(viewButton)
        End With
    End Sub

    Private Sub LoadAssetRequests()
        Dim query As String = "
        SELECT 
            ar.RequestID, 
            ar.ReferenceNumber,
            CONCAT(e.FirstName, ' ', e.LastName) AS FullName,
            ar.RequestDate,
            ar.FinalStatus,
            ar.FinalRemarks
        FROM assetrequesttable ar
        LEFT JOIN employeeprofile e ON ar.EmployeeID = e.EmployeeID
        ORDER BY ar.RequestDate DESC"

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvAssetRequests.DataSource = table
                End Using
            End Using
        End Using
    End Sub

    ' Common method to handle all status updates
    Private Sub UpdateRequestStatus(status As String)
        If dgvAssetRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a request to proceed.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get the RequestID from the selected row
        Dim requestID As Integer = Convert.ToInt32(dgvAssetRequests.SelectedRows(0).Cells("RequestID").Value)

        ' Open the Remarks Dialog and set the status
        Dim remarksDialog As New frmRemarksDialog()
        remarksDialog.RequestID = requestID
        remarksDialog.lblStatus.Text = status
        remarksDialog.ShowDialog()

        ' I-clear ang selection at i-refresh ang grid
        dgvAssetRequests.ClearSelection()
        LoadAssetRequests()
    End Sub

    ' Approve button click event
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        UpdateRequestStatus("Approved")
    End Sub

    ' Pending button click event
    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        UpdateRequestStatus("Pending")
    End Sub

    ' Denied button click event
    Private Sub btnDenied_Click(sender As Object, e As EventArgs) Handles btnDenied.Click
        UpdateRequestStatus("Denied")
    End Sub

End Class
