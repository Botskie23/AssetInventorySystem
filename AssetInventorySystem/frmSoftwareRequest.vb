Imports MySql.Data.MySqlClient

Public Class frmSoftwareRequest

    Private Sub frmSoftwareRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRequestedByName.ReadOnly = True
        lblCurrentDate.Text = DateTime.Now.ToString("yyyy-MM-dd")

        LoadEmployeeName()
        LoadMainLocations()
        LoadRequestTypes()

        ' Ensure no default selections
        cmbMainLocation.SelectedIndex = -1
        cmbSubLocation.DataSource = Nothing
        cmbRequestType.SelectedIndex = -1
    End Sub

    Private Sub LoadEmployeeName()
        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT FullName FROM employeeprofile WHERE EmployeeID=@empID", conn)
            cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtRequestedByName.Text = reader("FullName").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading employee name: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadMainLocations()
        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT MainLocationID, MainLocationName FROM mainlocationtable", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmbMainLocation.DataSource = dt
            cmbMainLocation.DisplayMember = "MainLocationName"
            cmbMainLocation.ValueMember = "MainLocationID"
            cmbMainLocation.SelectedIndex = -1 ' No default selection
        Catch ex As Exception
            MessageBox.Show("Error loading main locations: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadSubLocationsByBranch(mainLocationID As Integer)
        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT SubLocationID, SubLocationName FROM SubLocationTable WHERE MainLocationID=@MainLocationID", conn)
            cmd.Parameters.AddWithValue("@MainLocationID", mainLocationID)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmbSubLocation.DataSource = dt
            cmbSubLocation.DisplayMember = "SubLocationName"
            cmbSubLocation.ValueMember = "SubLocationID"
            cmbSubLocation.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading sub locations: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbMainLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMainLocation.SelectedIndexChanged
        If cmbMainLocation.SelectedIndex <> -1 AndAlso cmbMainLocation.SelectedValue IsNot Nothing Then
            Dim mainLocationID As Integer
            If Integer.TryParse(cmbMainLocation.SelectedValue.ToString(), mainLocationID) Then
                LoadSubLocationsByBranch(mainLocationID)
            End If
        End If
    End Sub

    Private Sub LoadRequestTypes()
        cmbRequestType.Items.Clear()
        cmbRequestType.Items.Add("New Software Installation")
        cmbRequestType.Items.Add("Repair Existing Software")
        cmbRequestType.Items.Add("Reinstallation")
        cmbRequestType.SelectedIndex = -1 ' No default
    End Sub

    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        ' Validation
        If cmbRequestType.SelectedIndex = -1 Then
            MessageBox.Show("Please select request type.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtSoftwareName.Text) Then
            MessageBox.Show("Please enter the software name.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtJustification.Text) Then
            MessageBox.Show("Please enter justification.")
            Return
        End If

        If cmbMainLocation.SelectedIndex = -1 Then
            MessageBox.Show("Please select main location.")
            Return
        End If

        If cmbSubLocation.SelectedIndex = -1 Then
            MessageBox.Show("Please select sub location.")
            Return
        End If

        ' Prepare DB Insert
        Dim conn As MySqlConnection = GetConnection()
        Dim cmd As New MySqlCommand()
        cmd.Connection = conn

        cmd.CommandText = "INSERT INTO SoftwareRequestsTable (RequestedBy, RequestType, SoftwareNameRequested, Justification, RequestDate, Status, MainLocationID, SubLocationID) " &
                          "VALUES (@RequestedBy, @RequestType, @SoftwareNameRequested, @Justification, @RequestDate, @Status, @MainLocationID, @SubLocationID)"

        cmd.Parameters.AddWithValue("@RequestedBy", LoggedInEmployeeID)
        cmd.Parameters.AddWithValue("@RequestType", cmbRequestType.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@SoftwareNameRequested", txtSoftwareName.Text)
        cmd.Parameters.AddWithValue("@Justification", txtJustification.Text)
        cmd.Parameters.AddWithValue("@RequestDate", DateTime.Now)
        cmd.Parameters.AddWithValue("@Status", "Pending")
        cmd.Parameters.AddWithValue("@MainLocationID", cmbMainLocation.SelectedValue)
        cmd.Parameters.AddWithValue("@SubLocationID", cmbSubLocation.SelectedValue)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Software request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Failed to submit request: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ClearForm()
        txtSoftwareName.Clear()
        txtJustification.Clear()
        cmbMainLocation.SelectedIndex = -1
        cmbSubLocation.DataSource = Nothing
        cmbRequestType.SelectedIndex = -1
    End Sub

End Class
