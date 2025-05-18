Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmAssetList
    ' Declare connection string
    Dim connectionString As String = "server=localhost;userid=root;password=;database=assetinventorydb;"

    ' Form Load - Populate DataGridView with asset data
    Private Sub frmAssetList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the asset data when the form loads
        LoadAssets()
    End Sub

    ' Load assets into DataGridView
    Public Sub LoadAssets()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' SQL query to select necessary columns from ITAssetTable
                Dim query As String = "SELECT AssetID, AssetCode, AssetName, AssetBrand, AvailabilityStatus " &
                                      "FROM ITAssetTable "

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind the data to the DataGridView
                dgvAssets.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading assets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Search functionality to filter assets
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' SQL query to filter results based on Asset Name, Asset Brand, and Availability Status
                Dim query As String = "SELECT AssetID,  Assetcode, AssetName, AssetBrand, AvailabilityStatus " &
                                  "FROM ITAssetTable  " &
                                  "WHERE AssetName LIKE @searchTerm OR AssetCode LIKE @searchTerm OR AssetBrand LIKE @searchTerm OR AvailabilityStatus LIKE @searchTerm"

                ' Use the search term with wildcards for partial matches
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchTerm", "%" & txtSearch.Text & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind the filtered data to the DataGridView
                dgvAssets.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching assets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Display QR Code when an asset is selected
    Private Sub dgvAssets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAssets.CellClick
        If e.RowIndex >= 0 Then
            ' Get the selected AssetID
            Dim selectedAssetID As Integer = dgvAssets.Rows(e.RowIndex).Cells("AssetID").Value

            ' Generate the QR code for the selected asset
            GenerateQRCode(selectedAssetID)
        End If
    End Sub

    ' Generate QR Code for the selected asset
    Private Sub GenerateQRCode(assetID As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Query to get asset details
                Dim query As String = "SELECT AssetCode, AssetName FROM ITAssetTable WHERE AssetID = @assetID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@assetID", assetID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' Get asset details
                    Dim assetCode As String = reader("AssetCode").ToString()
                    Dim assetName As String = reader("AssetName").ToString()

                    ' Generate QR code from asset details
                    Dim qrCodeData As String = assetCode & "|" & assetName
                    Dim qrCode As New ZXing.BarcodeWriter()
                    qrCode.Format = ZXing.BarcodeFormat.QR_CODE
                    qrCode.Options = New ZXing.Common.EncodingOptions With {
                        .Width = 200,
                        .Height = 200
                    }

                    ' Create the QR code and display it in the PictureBox
                    picQRCode.Image = qrCode.Write(qrCodeData)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Refresh Button - Reload the asset data
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAssets()
    End Sub

    ' Close Button - Close the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Dim printDoc As New PrintDocument()

    ' Button click event to initiate the printing process
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If picQRCode.Image IsNot Nothing Then
            ' Set the PrintPage event handler
            AddHandler printDoc.PrintPage, AddressOf PrintPage
            ' Start the print job
            printDoc.Print()
        Else
            MessageBox.Show("No QR code to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' PrintPage event handler to define how the QR code is printed
    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        Try
            ' Get the QR code image from the PictureBox
            Dim qrImage As Image = picQRCode.Image

            ' Define where to print the QR code on the page (top-left corner in this case)
            Dim x As Integer = 100
            Dim y As Integer = 100
            Dim width As Integer = qrImage.Width
            Dim height As Integer = qrImage.Height

            ' Draw the image (QR code) onto the print page
            e.Graphics.DrawImage(qrImage, x, y, width, height)
        Catch ex As Exception
            MessageBox.Show("Error printing QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOpenITAssetAddForm_Click(sender As Object, e As EventArgs) Handles btnOpenITAssetAddForm.Click
        Dim assetForm As New ITAssetAddForm()
        assetForm.ShowDialog()

    End Sub
End Class
