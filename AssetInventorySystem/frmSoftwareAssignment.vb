Imports MySql.Data.MySqlClient

Public Class frmSoftwareAssignment

    ' Validate Assignment Limit
    Private Function IsValidAssignment(softwareCode As String) As Boolean
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "SELECT COUNT(*) FROM SoftwareAssignmentTable WHERE SoftwareCode = @SoftwareCode"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@SoftwareCode", softwareCode)

        Try
            conn.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Check if software (e.g., Antivirus) has exceeded install limit
            If softwareCode = "Antivirus" AndAlso count >= 4 Then
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show("Error validating assignment: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    ' Load Computers (Asset Codes)
    Private Sub LoadComputers()
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "SELECT AssetID, AssetCode FROM ITAssetTable"
        Dim cmd As New MySqlCommand(query, conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            cmbAssetCode.DataSource = dt
            cmbAssetCode.DisplayMember = "AssetCode"
            cmbAssetCode.ValueMember = "AssetID"
            cmbAssetCode.SelectedIndex = -1 ' Ensures nothing is selected by default
        Catch ex As Exception
            MessageBox.Show("Error loading computers: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Load Software Codes
    Private Sub LoadSoftwareCodes()
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "SELECT SoftwareCode FROM softwaretable"
        Dim cmd As New MySqlCommand(query, conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            cmbSoftwareCode.DataSource = dt
            cmbSoftwareCode.DisplayMember = "SoftwareCode"
            cmbSoftwareCode.ValueMember = "SoftwareCode"
            cmbSoftwareCode.SelectedIndex = -1 ' Ensures nothing is selected by default
        Catch ex As Exception
            MessageBox.Show("Error loading software codes: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Load Employees
    Private Sub LoadEmployees()
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "SELECT EmployeeID, FullName FROM EmployeeProfile"
        Dim cmd As New MySqlCommand(query, conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            cmbEmployee.DataSource = dt
            cmbEmployee.DisplayMember = "FullName"
            cmbEmployee.ValueMember = "EmployeeID"
            cmbEmployee.SelectedIndex = -1 ' Ensures nothing is selected by default
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    ' Load Statuses from the database
    Private Sub LoadStatuses()
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "SELECT StatusName FROM StatusTable" ' Assuming StatusName is the column name
        Dim cmd As New MySqlCommand(query, conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            cmbStatus.DataSource = dt
            cmbStatus.DisplayMember = "StatusName" ' Column name for status names
            cmbStatus.ValueMember = "StatusName" ' Use StatusName as the value
            cmbStatus.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading statuses: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Form Load Event
    Private Sub frmSoftwareAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data
        LoadComputers()  ' Load list of computers (AssetCode)
        LoadSoftwareCodes()  ' Load software codes
        LoadEmployees()  ' Load employee list
        LoadAssignments()  ' Load all software assignments into DataGridView
        LoadStatuses()  ' Load the status options from the database
    End Sub

    ' Load Assignments
    Private Sub LoadAssignments()
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "
SELECT 
    saa.AssignmentID,
    saa.softwarecode,
    iat.AssetCode,
    ep.FullName AS EmployeeName,
    saa.AssignmentDate,
    assignedby.FullName AS AssignedBy,
    saa.Status,
    saa.Remarks
FROM SoftwareAssignmentTable saa
INNER JOIN ITAssetTable iat ON saa.AssetID = iat.AssetID
INNER JOIN EmployeeProfile ep ON saa.EmployeeID = ep.EmployeeID
INNER JOIN EmployeeProfile assignedby ON saa.AssignedBy = assignedby.EmployeeID"




        Dim cmd As New MySqlCommand(query, conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            conn.Open()
            da.Fill(dt)
            dgvAssignments.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading assignments: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Search and load assignments based on search term
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchAssignments(txtSearch.Text)
    End Sub

    Private Sub SearchAssignments(searchTerm As String)
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "SELECT a.AssignmentID, e.FullName, s.SoftwareCode, i.AssetCode, a.AssignmentDate, a.Status " &
                              "FROM SoftwareAssignmentTable a " &
                              "JOIN EmployeeProfile e ON a.EmployeeID = e.EmployeeID " &
                              "JOIN ITAssetTable i ON a.AssetID = i.AssetID " &
                              "JOIN softwaretable s ON a.SoftwareCode = s.SoftwareCode " &
                              "WHERE (e.FullName LIKE @Search OR s.SoftwareCode LIKE @Search OR i.AssetCode LIKE @Search)"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Search", "%" & searchTerm & "%")

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            conn.Open()
            da.Fill(dt)
            dgvAssignments.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error searching assignments: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Refresh button click
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAssignments()  ' Reload assignments data
    End Sub

    ' Assign Software
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        ' Get the selected values from the form
        Dim employeeID As Integer = cmbEmployee.SelectedValue
        Dim softwareCode As String = cmbSoftwareCode.SelectedValue.ToString()
        Dim assetCode As String = cmbAssetCode.SelectedValue.ToString()
        Dim assignmentDate As Date = dtpAssignmentDate.Value
        Dim status As String = cmbStatus.SelectedValue.ToString()
        Dim remarks As String = txtRemarks.Text

        ' Automatically assign the current logged-in employee as the one who is assigning the software
        Dim assignedBy As Integer = LoggedInEmployeeID ' Assuming LoggedInEmployeeID holds the current user's ID

        ' Validate the assignment limit (e.g., 4 installs for Antivirus)
        If Not IsValidAssignment(softwareCode) Then
            MessageBox.Show("Assignment limit exceeded for this software.")
            Return
        End If

        ' Create the SQL query to insert the assignment record
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "INSERT INTO SoftwareAssignmentTable (EmployeeID, SoftwareCode, AssetID, AssignmentDate, AssignedBy,Status, Remarks) " &
                              "VALUES (@EmployeeID, @SoftwareCode, @AssetID, @AssignmentDate, @AssignedBy, @Status, @Remarks)"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
        cmd.Parameters.AddWithValue("@SoftwareCode", softwareCode)
        cmd.Parameters.AddWithValue("@AssetID", assetCode)
        cmd.Parameters.AddWithValue("@AssignmentDate", assignmentDate)
        cmd.Parameters.AddWithValue("@AssignedBy", assignedBy)
        cmd.Parameters.AddWithValue("@Status", status)
        cmd.Parameters.AddWithValue("@Remarks", remarks)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Software assigned successfully!")
            LoadAssignments()  ' Refresh the assignments data grid
        Catch ex As Exception
            MessageBox.Show("Error assigning software: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
