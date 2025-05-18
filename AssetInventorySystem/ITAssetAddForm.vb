Imports MySql.Data.MySqlClient
Imports ZXing
Imports System.Drawing
Imports System.IO

Public Class ITAssetAddForm
    ' ✅ Define the connection string at the class level
    Private connectionString As String = "server=localhost;userid=root;password=;database=assetinventorydb;"

    ' ✅ Function to load SubClassification into ComboBox
    Private Sub LoadSubClassification()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT SubClassName FROM SubClassificationTable"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbSubClassification.Items.Clear() ' Clear old items
                        While reader.Read()
                            cmbSubClassification.Items.Add(reader("SubClassName").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading SubClassifications: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Function to load Conditions into ComboBox
    Private Sub LoadConditions()
        cmbCondition.Items.Add("New")
        cmbCondition.Items.Add("Used")

    End Sub

    ' ✅ Function to load Availability Status into ComboBox
    Private Sub LoadAvailabilityStatus()
        cmbAvailabilityStatus.Items.Add("Available")
        cmbAvailabilityStatus.Items.Add("In Used")
        cmbAvailabilityStatus.Items.Add("In Maintenance")
        cmbAvailabilityStatus.Items.Add("Reserved")
    End Sub

    Private Sub LoadSourceofAcquisition()
        CMBSourceofAcquisition.Items.Add("Purchased")
        CMBSourceofAcquisition.Items.Add("Leased")
        CMBSourceofAcquisition.Items.Add("Donated")
        CMBSourceofAcquisition.Items.Add("Borrowed")
    End Sub

    ' ✅ Function to load Suppliers into ComboBox
    Private Sub LoadSuppliers()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT SupplierName FROM SupplierTable"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        CmbSupplier.Items.Clear() ' Clear old items
                        While reader.Read()
                            CmbSupplier.Items.Add(reader("SupplierName").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading suppliers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Function to generate AssetCode
    Private Sub GenerateAssetCode()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' ✅ Ensure ComboBox is Not Empty
                If cmbSubClassification.SelectedItem Is Nothing Then
                    MessageBox.Show("Please select a SubClassification.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim selectedSubClass As String = cmbSubClassification.SelectedItem.ToString()
                Dim subClassID As Integer = -1
                Dim subClassCode As String = ""
                Dim mainClassCode As String = ""

                ' ✅ Get SubClassID, SubClassCode, and MainClassCode
                Dim query As String = "SELECT s.SubClassID, s.SubClassCode, m.MainClassCode 
                                   FROM SubClassificationTable s
                                   JOIN MainClassificationTable m ON s.MainClassID = m.MainClassID
                                   WHERE s.SubClassName = @SubClassName"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SubClassName", selectedSubClass)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        subClassID = Convert.ToInt32(reader("SubClassID"))
                        subClassCode = reader("SubClassCode").ToString()
                        mainClassCode = reader("MainClassCode").ToString()
                    Else
                        MessageBox.Show("SubClassification not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        reader.Close()
                        conn.Close()
                        Exit Sub
                    End If
                    reader.Close()
                End Using

                ' ✅ Get next series number for the asset
                Dim seriesNumber As Integer = 1
                query = "SELECT COUNT(*) + 1 FROM ITAssetTable WHERE SubClassID = @SubClassID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SubClassID", subClassID)
                    seriesNumber = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' ✅ Format series number as 4-digit
                Dim series As String = seriesNumber.ToString("D4")

                ' ✅ Generate AssetCode
                Dim assetCode As String = subClassCode & DateTime.Now.ToString("yyyyMM") & mainClassCode & series

                ' ✅ Display AssetCode in the textbox
                txtAssetCode.Text = assetCode
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating AssetCode: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' ✅ Function to generate and display QR Code in PictureBox
    ' ✅ Function to generate QR code
    Private Function GenerateQRCode(text1 As String, text2 As String) As Bitmap
        Dim qrCodeText As String = "AssetCode: " & text1 & " AssetName: " & text2
        Dim qrCodeWriter As New BarcodeWriter()
        qrCodeWriter.Format = BarcodeFormat.QR_CODE
        qrCodeWriter.Options = New ZXing.Common.EncodingOptions() With {
        .Width = 200,
        .Height = 200
    }

        ' Generate the QR code bitmap
        Dim qrCode As Bitmap = qrCodeWriter.Write(qrCodeText)
        Return qrCode
    End Function








    ' ✅ Function to generate and display QR Code in PictureBox
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Ensure all required fields are filled
            If String.IsNullOrEmpty(txtAssetName.Text) OrElse cmbSubClassification.SelectedIndex = -1 Then
                MessageBox.Show("Please fill in all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Generate AssetCode if SubClassification is selected
            If cmbSubClassification.SelectedIndex <> -1 Then
                GenerateAssetCode() ' Generate the asset code after clicking Add
            End If

            ' Get the correct SubClassID from the database
            Dim subClassID As Integer = -1
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim getSubClassIDQuery As String = "SELECT SubClassID FROM SubClassificationTable WHERE SubClassName = @SubClassName"
                Using cmd As New MySqlCommand(getSubClassIDQuery, conn)
                    cmd.Parameters.AddWithValue("@SubClassName", cmbSubClassification.Text)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then subClassID = Convert.ToInt32(result)
                End Using
            End Using

            ' If SubClassID is still -1, exit
            If subClassID = -1 Then
                MessageBox.Show("SubClassification ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Generate the QR Code
            Dim qrCode As Bitmap = GenerateQRCode(txtAssetCode.Text, txtAssetName.Text)

            ' Convert QR Code to Byte Array
            Dim qrCodeBytes As Byte() = ConvertBitmapToByteArray(qrCode)

            ' Insert the asset data into the database along with QR Code and CreatedBy (LoggedInUser)
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "INSERT INTO ITAssetTable 
                                   (SubClassID, AssetCode, AssetName, SourceofAcquisition, AssetBrand, 
                                    AssetModel, SerialNo, AssetColor, AssetDATEAquire, WarrantyENDDATE, 
                                    Supplier, AssetCondition, AvailabilityStatus, QRCode, CreatedBy) 
                                   VALUES 
                                   (@SubClassID, @AssetCode, @AssetName, @SourceofAcquisition, @AssetBrand, 
                                    @AssetModel, @SerialNo, @AssetColor, @AssetDATEAquire, @WarrantyENDDATE, 
                                    @Supplier, @AssetCondition, @AvailabilityStatus, @QRCode, @CreatedBy)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SubClassID", subClassID)
                    cmd.Parameters.AddWithValue("@AssetCode", txtAssetCode.Text)
                    cmd.Parameters.AddWithValue("@AssetName", txtAssetName.Text)
                    cmd.Parameters.AddWithValue("@SourceofAcquisition", CMBSourceofAcquisition.Text)
                    cmd.Parameters.AddWithValue("@AssetBrand", txtAssetBrand.Text)
                    cmd.Parameters.AddWithValue("@AssetModel", txtAssetModel.Text)
                    cmd.Parameters.AddWithValue("@SerialNo", txtSerialNo.Text)
                    cmd.Parameters.AddWithValue("@AssetColor", txtAssetColor.Text)

                    ' Handle empty date values (insert NULL if hidden)
                    If dtpAssetDateAquire.CustomFormat = " " Then
                        cmd.Parameters.AddWithValue("@AssetDATEAquire", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@AssetDATEAquire", dtpAssetDateAquire.Value.ToString("yyyy-MM-dd"))
                    End If

                    If dtpWarrantyEndDate.CustomFormat = " " Then
                        cmd.Parameters.AddWithValue("@WarrantyENDDATE", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@WarrantyENDDATE", dtpWarrantyEndDate.Value.ToString("yyyy-MM-dd"))
                    End If

                    cmd.Parameters.AddWithValue("@Supplier", CmbSupplier.Text)
                    cmd.Parameters.AddWithValue("@AssetCondition", cmbCondition.Text)
                    cmd.Parameters.AddWithValue("@AvailabilityStatus", cmbAvailabilityStatus.Text)
                    cmd.Parameters.AddWithValue("@QRCode", qrCodeBytes) ' Insert the QR code as a byte array

                    ' Set CreatedBy to the logged-in user's EmployeeID
                    cmd.Parameters.AddWithValue("@CreatedBy", GlobalVariables.LoggedInEmployeeID)

                    ' Execute the query
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Clear the form after successful addition
            ClearForm()
            MessageBox.Show("Asset added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh the Asset List form if it's open
            For Each f As Form In Application.OpenForms
                If TypeOf f Is frmAssetList Then
                    CType(f, frmAssetList).LoadAssets()
                    Exit For
                End If
            Next

            ClearForm() ' Optional: reset form after adding



        Catch ex As Exception
            MessageBox.Show("Error adding asset: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' ✅ Function to convert Bitmap (QR Code) to Byte Array
    Private Function ConvertBitmapToByteArray(ByVal image As Bitmap) As Byte()
        Using ms As New System.IO.MemoryStream()
            image.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    ' ✅ Function to display QR code in PictureBox from the database
    Private Sub DisplayQRCodeFromDatabase(assetID As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Query to get the QR Code from the database
                Dim query As String = "SELECT QRCode FROM ITAssetTable WHERE AssetID = @AssetID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AssetID", assetID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Check if QRCode is not null
                            If Not IsDBNull(reader("QRCode")) Then
                                Dim qrCodeBytes As Byte() = CType(reader("QRCode"), Byte())
                                Using ms As New MemoryStream(qrCodeBytes)
                                    ' Display the QR code in the PictureBox
                                    picQRCode.Image = Image.FromStream(ms)
                                End Using
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error displaying QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    ' ✅ Clear the form
    Private Sub ClearForm()
        txtAssetName.Clear()
        txtAssetBrand.Clear()
        txtAssetModel.Clear()
        txtSerialNo.Clear()
        txtAssetColor.Clear()
        CMBSourceofAcquisition.SelectedIndex = -1
        cmbCondition.SelectedIndex = -1
        cmbAvailabilityStatus.SelectedIndex = -1
        CmbSupplier.SelectedIndex = -1
        cmbSubClassification.SelectedIndex = -1

        ' ✅ Reset date pickers to today and visible
        dtpAssetDateAquire.Format = DateTimePickerFormat.Short
        dtpAssetDateAquire.Value = Date.Today

        dtpWarrantyEndDate.Format = DateTimePickerFormat.Short
        dtpWarrantyEndDate.Value = Date.Today

        txtAssetCode.Clear()
        picQRCode.Image = Nothing ' Clear the picture box
    End Sub


    ' ✅ Form Load: Load all data into ComboBoxes
    Private Sub ITAssetAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubClassification() ' Load SubClassifications
        LoadConditions() ' Load Conditions
        LoadAvailabilityStatus() ' Load Availability Status
        LoadSuppliers() ' Load Suppliers
        LoadSourceofAcquisition() 'load Acquisition
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class
