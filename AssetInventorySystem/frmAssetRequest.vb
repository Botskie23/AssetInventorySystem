' Full code for frmAssetRequest

Imports MySql.Data.MySqlClient

Public Class frmAssetRequest
    Dim connection As MySqlConnection = GetConnection()

    Private Sub frmAssetRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        LoadAssetTypes()
        LoadCategories()
        LoadPriorities()

    End Sub

    Private Sub LoadEmployees()
        cmbEmployee.Items.Clear()
        Dim cmd As New MySqlCommand("SELECT CompanyIDNumber FROM EmployeeProfile", connection)
        Dim reader As MySqlDataReader
        Try
            If connection.State = ConnectionState.Closed Then connection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                cmbEmployee.Items.Add(reader("CompanyIDNumber").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub cmbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployee.SelectedIndexChanged
        Dim cmd As New MySqlCommand("SELECT * FROM EmployeeProfile WHERE CompanyIDNumber = @CompanyIDNumber", connection)
        cmd.Parameters.AddWithValue("@CompanyIDNumber", cmbEmployee.Text)
        Dim reader As MySqlDataReader

        Try
            If connection.State = ConnectionState.Closed Then connection.Open()
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                txtEmployeeID.Text = reader("EmployeeID").ToString()
                txtFullName.Text = reader("FullName").ToString()
                txtDesignation.Text = reader("Designation").ToString()
                txtDepartment.Text = reader("Department").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error fetching employee details: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadAssetTypes()
        cmbAssetType.Items.Clear()
        Dim cmd As New MySqlCommand("SELECT SubClassName FROM SubClassificationTable", connection)
        Dim reader As MySqlDataReader

        Try
            connection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                cmbAssetType.Items.Add(reader("SubClassName").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading asset types: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadCategories()
        cmbRequestCategory.Items.Clear()
        cmbRequestCategory.Items.AddRange(New String() {"New", "Replacement", "Upgrade"})
    End Sub

    Private Sub LoadPriorities()
        cmbPriority.Items.Clear()
        cmbPriority.Items.AddRange(New String() {"Low", "Medium", "High"})
    End Sub

    Private Function GenerateReferenceNumber(assetType As String) As String
        Dim prefix As String = "AS"
        Dim monthPart As String = Now.ToString("MM")
        Dim yearPart As String = Now.ToString("yy")

        Dim assetCode As String
        Dim words = assetType.Trim().Split(" "c)
        If words.Length = 1 Then
            assetCode = assetType.Substring(0, Math.Min(2, assetType.Length)).ToUpper()
        Else
            assetCode = (words(0).Substring(0, 1) & words(1).Substring(0, 1)).ToUpper()
        End If

        Dim cmd As New MySqlCommand("SELECT COUNT(*) + 1 FROM AssetRequestTable WHERE AssetType = @AssetType AND MONTH(RequestDate) = @Month AND YEAR(RequestDate) = @Year", connection)
        cmd.Parameters.AddWithValue("@AssetType", assetType)
        cmd.Parameters.AddWithValue("@Month", Now.Month)
        cmd.Parameters.AddWithValue("@Year", Now.Year)

        Dim series As Integer = 1
        Try
            connection.Open()
            series = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error generating series: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Dim seriesStr As String = series.ToString("D4")
        Return $"{prefix}{monthPart}{yearPart}{assetCode}{seriesStr}"
    End Function
    Public Sub LoadRequest(requestID As Integer)
        ' Clear any existing data
        ClearForm()

        ' Now load the request details into the form controls
        Dim cmd As New MySqlCommand("SELECT * FROM AssetRequestTable WHERE RequestID = @RequestID", connection)
        cmd.Parameters.AddWithValue("@RequestID", requestID)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Assuming the fields in your table match the control names
                cmbEmployee.Text = reader("EmployeeID").ToString()
                cmbAssetType.Text = reader("AssetType").ToString()
                txtQuantity.Text = reader("Quantity").ToString()
                txtReason.Text = reader("Reason").ToString()
                dtpDateNeeded.Value = Convert.ToDateTime(reader("DateNeeded"))
                cmbRequestCategory.Text = reader("RequestCategory").ToString()
                cmbPriority.Text = reader("PriorityLevel").ToString()
                txtDescription.Text = reader("Description").ToString()

                ' Set the controls to be read-only (optional)
                SetReadOnly(True)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading request details: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub SetReadOnly(isReadOnly As Boolean)
        ' Set the controls to be read-only if needed
        cmbEmployee.Enabled = Not isReadOnly
        cmbAssetType.Enabled = Not isReadOnly
        txtQuantity.Enabled = Not isReadOnly
        txtReason.Enabled = Not isReadOnly
        dtpDateNeeded.Enabled = Not isReadOnly
        cmbRequestCategory.Enabled = Not isReadOnly
        cmbPriority.Enabled = Not isReadOnly
        txtDescription.Enabled = Not isReadOnly
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cmbEmployee.Text = "" Or cmbAssetType.Text = "" Or txtQuantity.Text = "" Or txtQuantity.Text = "0" Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Dim referenceNumber As String = GenerateReferenceNumber(cmbAssetType.Text)

        Dim cmd As New MySqlCommand("INSERT INTO AssetRequestTable (ReferenceNumber, EmployeeID, AssetType, Quantity, Reason, DateNeeded, RequestCategory, PriorityLevel, CreatedBy, Approver1Status, Approver2Status, Approver3Status, FinalStatus, RequestDate, Description) VALUES (@ReferenceNumber, @EmployeeID, @AssetType, @Quantity, @Reason, @DateNeeded, @RequestCategory, @PriorityLevel, @CreatedBy, 'Pending', 'Pending', 'Pending', 'Pending', NOW(), @Description)", connection)

        cmd.Parameters.AddWithValue("@ReferenceNumber", referenceNumber)
        cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
        cmd.Parameters.AddWithValue("@AssetType", cmbAssetType.Text)
        cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
        cmd.Parameters.AddWithValue("@Reason", txtReason.Text)
        cmd.Parameters.AddWithValue("@DateNeeded", dtpDateNeeded.Value)
        cmd.Parameters.AddWithValue("@RequestCategory", cmbRequestCategory.Text)
        cmd.Parameters.AddWithValue("@PriorityLevel", cmbPriority.Text)
        cmd.Parameters.AddWithValue("@CreatedBy", GlobalVariables.LoggedInEmployeeID) ' Or use ID
        cmd.Parameters.AddWithValue("@Description", txtDescription.Text)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Asset request submitted successfully!")
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error saving request: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        cmbEmployee.SelectedIndex = -1
        txtEmployeeID.Clear()
        txtFullName.Clear()
        txtDesignation.Clear()
        txtDepartment.Clear()
        cmbAssetType.SelectedIndex = -1
        txtQuantity.Text = 1
        txtReason.Clear()
        cmbRequestCategory.SelectedIndex = -1
        cmbPriority.SelectedIndex = -1
        dtpDateNeeded.Value = Date.Now
        txtDescription.Clear()
    End Sub


End Class
