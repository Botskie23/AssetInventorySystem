Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

' Custom class to represent an employee in the ComboBox
Public Class frmAssetAssignment
    Private loggedInUser As String
    Private isAssetCodesLoaded As Boolean = False
    Dim loadingLabel As Label
    Private isFormLoading As Boolean = False
    ' Connection string
    Dim connectionString As String = "server=localhost;userid=root;password=;database=assetinventorydb;"
    Dim connection As New MySqlConnection(connectionString)


    ' Form Load event to load assets, employees, and locations
    Private Sub frmAssetAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isFormLoading = True ' Prevent triggers during loading

        ' Optional loading label
        loadingLabel = New Label With {
    .Text = "Loading...",
    .AutoSize = True,
    .Location = New Point(100, 100)
}
        Me.Controls.Add(loadingLabel)
        loadingLabel.Visible = False

        txtDateAssigned.Value = DateTime.Now
        loggedInUser = GetLoggedInUser()

        ' Load combo boxes and data
        LoadEmployees()
        LoadMainLocations()
        LoadAssetCodes()
        LoadAssetAssignments()

        cmbAssetCode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMainLocation.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSubLocation.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMainLocation.SelectedIndex = -1

        ' Clear employee fields
        txtEmployeeName.Clear()
        txtDesignation.Clear()
        txtDepartment.Clear()
        txtContactNumber.Clear()

        ' Hide the EmployeeID column
        dgvAssetAssignments.Columns("EmployeeID").Visible = False

        isFormLoading = False ' Allow events after setup
    End Sub



    Private Function GetEmployeeDetailsByID(employeeID As Integer) As EmployeeProfile
        Dim connectionString As String = "Server=localhost;Port=3306;Database=assetinventorydb;Uid=root;Pwd=;" ' Replace with your actual connection string
        Dim query As String = "SELECT EmployeeID, FullName, Designation, Department, PhoneNumber FROM EmployeeProfile WHERE EmployeeID = @EmployeeID"
        Dim employee As EmployeeProfile = Nothing

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployeeID", employeeID)
                connection.Open()

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        employee = New EmployeeProfile(
                        reader("EmployeeID"), ' EmployeeID can be used for more than just display
                        reader("FullName").ToString(),
                        reader("Designation").ToString(),
                        reader("Department").ToString(),
                        reader("PhoneNumber").ToString()
                    )
                    End If
                End Using
            End Using
        End Using

        Return employee
    End Function
    Public Class EmployeeProfile
        Public Property EmployeeID As Integer
        Public Property EmployeeName As String
        Public Property Designation As String
        Public Property Department As String
        Public Property ContactNumber As String

        ' Constructor
        Public Sub New(employeeID As Integer, employeeName As String, designation As String, department As String, contactNumber As String)
            Me.EmployeeID = employeeID
            Me.EmployeeName = employeeName
            Me.Designation = designation
            Me.Department = department
            Me.ContactNumber = contactNumber
        End Sub
    End Class
    Public Class MainLocationItem
        Public Property MainLocationID As Integer
        Public Property MainLocationName As String

        ' Constructor to easily create an instance
        Public Sub New(id As Integer, name As String)
            MainLocationID = id
            MainLocationName = name
        End Sub

        ' Override ToString() for DisplayMember
        Public Overrides Function ToString() As String
            Return MainLocationName
        End Function
    End Class





    ' Method to load employees into ComboBox
    Private Sub cmbEmployeeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployeeID.SelectedIndexChanged
        If isFormLoading Then Exit Sub  ' Prevent trigger during form loading

        ' Clear text boxes if no employee is selected
        If cmbEmployeeID.SelectedValue IsNot Nothing Then
            ' Get the selected EmployeeID and retrieve details
            Dim selectedEmployeeID As Integer = Convert.ToInt32(cmbEmployeeID.SelectedValue) ' Use SelectedValue
            Dim employeeDetails As EmployeeProfile = GetEmployeeDetailsByID(selectedEmployeeID)

            ' Update text boxes with employee details
            txtEmployeeName.Text = employeeDetails.EmployeeName
            txtDesignation.Text = employeeDetails.Designation
            txtDepartment.Text = employeeDetails.Department
            txtContactNumber.Text = employeeDetails.ContactNumber

            ' Filter dgvAssetAssignments based on selected EmployeeID
            FilterAssetAssignmentsByEmployee(selectedEmployeeID)
        Else
            ' Clear text boxes if no employee is selected
            txtEmployeeName.Clear()
            txtDesignation.Clear()
            txtDepartment.Clear()
            txtContactNumber.Clear()

            ' Optionally clear the DataGridView when no employee is selected
            dgvAssetAssignments.DataSource = Nothing
        End If
    End Sub

    Private Sub FilterAssetAssignmentsByEmployee(employeeID As Integer)
        ' Create the query to fetch the asset assignments with human-readable values
        Dim query As String = "SELECT aa.AssetID, " &
                          "it.AssetCode, " &
                          "aa.AssignmentDate, " &
                          "aa.AssignedBy, " &
                          "ml.MainLocationName, " &
                          "sl.SubLocationName " &
                          "FROM assetassignments aa " &
                          "JOIN ITAssetTable it ON aa.AssetID = it.AssetID " &
                          "JOIN MainLocationTable ml ON aa.MainLocationID = ml.MainLocationID " &
                          "JOIN SubLocationTable sl ON aa.SubLocationID = sl.SubLocationID " &
                          "WHERE aa.EmployeeID = @EmployeeID"

        ' Open a connection to the database and execute the query
        Using conn As New MySqlConnection(connectionString),
          cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

            Try
                conn.Open()

                ' Create a data adapter to fill the DataGridView with the filtered data
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind the DataGridView to the filtered data
                dgvAssetAssignments.DataSource = dt

                ' Optionally hide the AssetID column if not needed
                dgvAssetAssignments.Columns("AssetID").Visible = False

            Catch ex As MySqlException
                MessageBox.Show("Error loading asset assignments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub






    Private Sub LoadMainLocations()
        Try
            cmbMainLocation.Items.Clear() ' Clear previous items if any

            ' Create a list to hold the locations
            Dim locations As New List(Of KeyValuePair(Of Integer, String))

            ' Example query to fetch data from the database
            Dim query As String = "SELECT MainLocationID, MainLocationName FROM MainLocationtable"

            ' Connect to the database to fetch main locations
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Add each location as a KeyValuePair (MainLocationID, MainLocationName)
                            locations.Add(New KeyValuePair(Of Integer, String)(Convert.ToInt32(reader("MainLocationID")), reader("MainLocationName").ToString()))
                        End While
                    End Using
                End Using
            End Using

            ' Debug: Show how many locations were loaded
            'MessageBox.Show("Main Locations Loaded: " & locations.Count.ToString())

            ' Set the ComboBox DataSource to the list of locations
            cmbMainLocation.DataSource = locations
            cmbMainLocation.DisplayMember = "Value" ' Display MainLocationName
            cmbMainLocation.ValueMember = "Key" ' Store MainLocationID as the value

            ' Set the first item as selected, if available
            'If cmbMainLocation.Items.Count > 0 Then
            'cmbMainLocation.SelectedIndex = 0
            'End If

        Catch ex As Exception
            MessageBox.Show("Error loading main locations: " & ex.Message)
        End Try
    End Sub











    Private Sub LoadSubLocations(mainLocationID As Integer)
        Try
            cmbSubLocation.Items.Clear() ' Clear previous items if any

            ' Create a list to hold the sublocations
            Dim subLocations As New List(Of KeyValuePair(Of Integer, String))

            ' Example query to fetch sublocations based on the selected MainLocationID
            Dim query As String = "SELECT SubLocationID, SubLocationName FROM SubLocationtable WHERE MainLocationID = @MainLocationID"

            ' Connect to the database to fetch sublocations
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Add the parameter for MainLocationID
                    cmd.Parameters.AddWithValue("@MainLocationID", mainLocationID)
                    conn.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Add each sublocation as a KeyValuePair (SubLocationID, SubLocationName)
                            subLocations.Add(New KeyValuePair(Of Integer, String)(Convert.ToInt32(reader("SubLocationID")), reader("SubLocationName").ToString()))
                        End While
                    End Using
                End Using
            End Using

            ' Debug: Show how many sublocations were loaded
            ' MessageBox.Show("Sub Locations Loaded: " & subLocations.Count.ToString())

            ' Set the ComboBox DataSource to the list of sublocations
            cmbSubLocation.DataSource = subLocations
            cmbSubLocation.DisplayMember = "Value" ' Display SubLocationName
            cmbSubLocation.ValueMember = "Key" ' Store SubLocationID as the value

            ' Set the first item as selected, if available
            'If cmbSubLocation.Items.Count > 0 Then
            'cmbSubLocation.SelectedIndex = 0
            ' End If

        Catch ex As Exception
            MessageBox.Show("Error loading sublocations: " & ex.Message)
        End Try
    End Sub






    Public Class EmployeeItem
        Public Property EmployeeID As Integer
        Public Property FullName As String

        Public Sub New(id As Integer, name As String)
            EmployeeID = id
            FullName = name
        End Sub

        Public Overrides Function ToString() As String
            Return FullName
        End Function
    End Class
    ' Custom class to represent a main location in the ComboBox

    ' Class for SubLocation item
    Public Class SubLocationItem
        Public Property SubLocationID As Integer
        Public Property SubLocationName As String

        Public Sub New(id As Integer, name As String)
            SubLocationID = id
            SubLocationName = name
        End Sub

        Public Overrides Function ToString() As String
            Return SubLocationName
        End Function
    End Class


    Private Sub LoadEmployees()
        Try
            Dim query As String = "SELECT EmployeeID, FullName FROM EmployeeProfile"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmbEmployeeID.DisplayMember = "FullName"
            cmbEmployeeID.ValueMember = "EmployeeID"
            cmbEmployeeID.DataSource = dt

            cmbEmployeeID.SelectedIndex = -1 ' Optional: Do not auto-select

        Catch ex As Exception
            MessageBox.Show("Error loading employee details: " & ex.Message)
        End Try
    End Sub




    Private Sub cmbMainLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMainLocation.SelectedIndexChanged
        ' Avoid triggering this during form load or reset
        If isFormLoading Then Return

        ' Clear sublocation ComboBox safely
        cmbSubLocation.DataSource = Nothing

        ' Load sublocations for selected main location
        Dim selectedMainLocationID As Integer
        If cmbMainLocation.SelectedValue IsNot Nothing AndAlso Integer.TryParse(cmbMainLocation.SelectedValue.ToString(), selectedMainLocationID) Then
            LoadSubLocations(selectedMainLocationID)
        End If
    End Sub




    Private Sub btnSaveAssignment_Click(sender As Object, e As EventArgs) Handles btnSaveAssignment.Click
        ' Check if MainLocation and SubLocation have valid selections
        If cmbMainLocation.SelectedIndex = -1 OrElse cmbSubLocation.SelectedIndex = -1 Then
            MessageBox.Show("Please select both main location and sub-location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the selected AssetID
        Dim selectedAssetID As Integer = Convert.ToInt32(cmbAssetCode.SelectedValue)

        ' Check if the asset is available
        If Not IsAssetAvailable(selectedAssetID) Then
            ' If the asset is not available, return without further processing
            Return
        End If

        ' Continue with saving the data
        Dim query As String = "INSERT INTO assetassignments (AssetID, EmployeeID, AssignmentDate, AssignedBy, MainLocationID, SubLocationID) " &
                          "VALUES (@AssetID, @EmployeeID, @AssignmentDate, @AssignedBy, @MainLocationID, @SubLocationID)"

        Using conn As New MySqlConnection(connectionString),
          cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@AssetID", selectedAssetID)
            cmd.Parameters.AddWithValue("@EmployeeID", cmbEmployeeID.SelectedValue)
            cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now)
            cmd.Parameters.AddWithValue("@AssignedBy", loggedInUser)
            cmd.Parameters.AddWithValue("@MainLocationID", cmbMainLocation.SelectedValue)
            cmd.Parameters.AddWithValue("@SubLocationID", cmbSubLocation.SelectedValue)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()

                ' Update Availability Status to "In Used" after successful assignment
                UpdateAssetAvailabilityStatus(selectedAssetID)

                MessageBox.Show("Asset successfully assigned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadAssetCodes()
                ClearAssignmentForm()
                LoadAssetAssignments()

            Catch ex As MySqlException
                MessageBox.Show("Error saving assignment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Function IsAssetAvailable(assetID As Integer) As Boolean
        ' Query to check the AvailabilityStatus of the asset
        Dim query As String = "SELECT AvailabilityStatus FROM ITAssetTable WHERE AssetID = @AssetID"

        Using conn As New MySqlConnection(connectionString),
          cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@AssetID", assetID)

            Try
                conn.Open()
                Dim status As String = Convert.ToString(cmd.ExecuteScalar())

                ' Check if the asset is "Available"
                If status <> "Available" Then
                    ' Show the current status in the error message
                    MessageBox.Show($"This asset is currently '{status}' and cannot be assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                Return True

            Catch ex As MySqlException
                MessageBox.Show("Error checking asset availability: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function



    Private Sub UpdateAssetAvailabilityStatus(assetID As Integer)
        ' Update the AvailabilityStatus to "Assigned" or "Unavailable" in ITAssetTable
        Dim query As String = "UPDATE ITAssetTable SET AvailabilityStatus = 'In Use' WHERE AssetID = @AssetID"

        Using conn As New MySqlConnection(connectionString),
          cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@AssetID", assetID)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show("Error updating asset availability: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Private Sub ClearAssignmentForm()
        ' Clear ComboBoxes
        cmbAssetCode.SelectedIndex = -1
        cmbEmployeeID.SelectedIndex = -1
        cmbMainLocation.SelectedIndex = -1
        cmbSubLocation.DataSource = Nothing
        cmbSubLocation.SelectedIndex = -1

        ' Clear TextBoxes
        txtEmployeeName.Clear()
        txtDesignation.Clear()
        txtDepartment.Clear()
        txtContactNumber.Clear()
        txtAssetName.Clear()
        txtAvailabilityStatus.Clear()

        txtDateAssigned.Format = DateTimePickerFormat.Short
        txtDateAssigned.Value = DateTime.Now
    End Sub



    ' Method to retrieve the logged-in user's name or ID
    Private Function GetLoggedInUser() As String
        ' Replace this with your actual login system logic to get the current user's name or ID
        ' Example: return a global variable, session, or a user object
        Return "LoggedUserName" ' Replace with actual user fetching logic
    End Function




    Private Sub LoadAssetCodes()

        Try

            Dim query As String = "SELECT AssetID, AssetCode FROM ITAssetTable"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmbAssetCode.DisplayMember = "AssetCode"
            cmbAssetCode.ValueMember = "AssetID"
            cmbAssetCode.DataSource = dt

            cmbAssetCode.SelectedIndex = -1

            isAssetCodesLoaded = True ' ✅ Allow event to trigger now

        Catch ex As Exception
            If connection.State = ConnectionState.Open Then connection.Close()
            MessageBox.Show("Error loading asset codes: " & ex.Message)
        End Try
    End Sub




    Private Sub cmbAssetCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAssetCode.SelectedIndexChanged
        If Not isAssetCodesLoaded OrElse cmbAssetCode.SelectedIndex = -1 Then
            Exit Sub
        End If

        ' ✅ Now it’s safe to run this code only after the user selects
        Dim query As String = "SELECT AssetName, AvailabilityStatus FROM ITAssetTable WHERE AssetID = @AssetID"

        Try
            connection.Open()
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@AssetID", cmbAssetCode.SelectedValue)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                txtAssetName.Text = reader("AssetName").ToString()
                txtAvailabilityStatus.Text = reader("AvailabilityStatus").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving asset details: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub


    Private Sub LoadAssetAssignments()
        ' SQL query to fetch the data from assetassignments (no need to join employeeprofile)
        Dim query As String = "SELECT a.AssignmentID, i.AssetCode, a.EmployeeID, a.AssignmentDate, a.AssignedBy, " &
                              "m.MainLocationName, s.SubLocationName " &
                              "FROM assetassignments a " &
                              "JOIN itassettable i ON a.AssetID = i.AssetID " &
                              "JOIN mainlocationtable m ON a.MainLocationID = m.MainLocationID " &
                              "JOIN sublocationtable s ON a.SubLocationID = s.SubLocationID"

        ' Create a new connection object
        Using conn As New MySqlConnection(connectionString)
            ' Create the command object with the SQL query
            Using cmd As New MySqlCommand(query, conn)
                ' Create a data adapter to fill the data into a DataTable
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()

                Try
                    ' Open the connection
                    conn.Open()

                    ' Fill the DataTable with the data from the database
                    da.Fill(dt)

                    ' Bind the DataTable to the DataGridView
                    dgvAssetAssignments.DataSource = dt

                    ' Optional: You can change the column headers if necessary
                    dgvAssetAssignments.Columns("AssignmentID").HeaderText = "Assignment ID"
                    dgvAssetAssignments.Columns("AssetCode").HeaderText = "Asset Code"
                    dgvAssetAssignments.Columns("EmployeeID").HeaderText = "Employee ID"
                    dgvAssetAssignments.Columns("AssignmentDate").HeaderText = "Assignment Date"
                    dgvAssetAssignments.Columns("AssignedBy").HeaderText = "Assigned By"
                    dgvAssetAssignments.Columns("MainLocationName").HeaderText = "Main Location"
                    dgvAssetAssignments.Columns("SubLocationName").HeaderText = "Sub Location"

                Catch ex As MySqlException
                    ' Handle any errors
                    MessageBox.Show("Error loading asset assignments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    Private Sub AddEmployeeNamesToGrid()
        For Each row As DataGridViewRow In dgvAssetAssignments.Rows
            Dim employeeID As Integer = Convert.ToInt32(row.Cells("EmployeeID").Value)
            row.Cells("EmployeeName").Value = GetEmployeeNameById(employeeID)
        Next
    End Sub

    Private Function GetEmployeeNameById(employeeID As Integer) As String
        Dim query As String = "SELECT EmployeeName FROM employeeprofile WHERE EmployeeID = @EmployeeID"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                Try
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return result.ToString()
                    Else
                        Return "Unknown"
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Error fetching employee name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return "Error"
                End Try
            End Using
        End Using
    End Function


End Class