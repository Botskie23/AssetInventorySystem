Imports MySql.Data.MySqlClient

Public Class frmAddSoftware
    Public isEditMode As Boolean = False
    Public EditSoftwareCode As String = ""
    Public Event SoftwareUpdated As EventHandler
    Private Sub frmAddSoftware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMainCategories()
        cmbMainCategory.SelectedIndex = -1

        If isEditMode Then
            btnAddSoftware.Text = "Update"
            LoadSoftwareForEditing(EditSoftwareCode)
        Else
            btnAddSoftware.Text = "Add"
        End If
    End Sub

    Private Sub LoadMainCategories()
        Dim conn As MySqlConnection = GetConnection()
        Dim cmd As New MySqlCommand("SELECT MainCategoryID, MainCategoryName FROM maincategory", conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            dt.Load(cmd.ExecuteReader())
            cmbMainCategory.DataSource = dt
            cmbMainCategory.DisplayMember = "MainCategoryName"
            cmbMainCategory.ValueMember = "MainCategoryID"
        Catch ex As Exception
            MessageBox.Show("Error loading main categories: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbMainCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMainCategory.SelectedIndexChanged
        If cmbMainCategory.SelectedValue Is Nothing Then Exit Sub
        Dim mainCatID As Integer
        If Integer.TryParse(cmbMainCategory.SelectedValue.ToString(), mainCatID) Then
            LoadSubCategories(mainCatID)
        End If
    End Sub

    Private Sub LoadSubCategories(mainCategoryID As Integer)
        Dim conn As MySqlConnection = GetConnection()
        Dim cmd As New MySqlCommand("SELECT SubCategoryID, SubCategoryName FROM subcategory WHERE MainCategoryID = @MainCategoryID", conn)
        cmd.Parameters.AddWithValue("@MainCategoryID", mainCategoryID)

        Try
            conn.Open()
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            cmbSubCategory.DataSource = dt
            cmbSubCategory.DisplayMember = "SubCategoryName"
            cmbSubCategory.ValueMember = "SubCategoryID"
        Catch ex As Exception
            MessageBox.Show("Error loading subcategories: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAddSoftware_Click(sender As Object, e As EventArgs) Handles btnAddSoftware.Click
        ' --- Validation ---
        If String.IsNullOrWhiteSpace(txtSoftwareName.Text) Then
            MessageBox.Show("Software name is required.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtVersion.Text) Then
            MessageBox.Show("Software version is required.")
            Return
        End If

        If cmbMainCategory.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a main category.")
            Return
        End If

        If cmbSubCategory.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a subcategory.")
            Return
        End If

        If String.IsNullOrWhiteSpace(LoggedInEmployeeID) Then
            MessageBox.Show("LoggedInEmployeeID is not set correctly.")
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand()
                    cmd.Connection = conn

                    If isEditMode Then
                        ' --- UPDATE ---
                        cmd.CommandText = "UPDATE SoftwareTable SET SoftwareName=@SoftwareName, SoftwareVersion=@SoftwareVersion, SoftwareLicenseKey=@SoftwareLicenseKey, " &
                        "MainCategoryID=@MainCategoryID, SubCategoryID=@SubCategoryID, Description=@Description, LicenseExpiryDate=@LicenseExpiryDate, " &
                        "PurchaseDate=@PurchaseDate, EditBy=@EditBy WHERE SoftwareCode=@SoftwareCode"
                        cmd.Parameters.AddWithValue("@SoftwareCode", EditSoftwareCode)
                        cmd.Parameters.AddWithValue("@EditBy", LoggedInEmployeeID)
                    Else
                        ' --- INSERT ---
                        Dim softwareCode As String = "SW-" & Guid.NewGuid().ToString().Substring(0, 8).ToUpper()
                        cmd.CommandText = "INSERT INTO SoftwareTable (SoftwareCode, SoftwareName, SoftwareVersion, SoftwareLicenseKey, MainCategoryID, SubCategoryID, Description, LicenseExpiryDate, PurchaseDate, CreatedBy) " &
                        "VALUES (@SoftwareCode, @SoftwareName, @SoftwareVersion, @SoftwareLicenseKey, @MainCategoryID, @SubCategoryID, @Description, @LicenseExpiryDate, @PurchaseDate, @CreatedBy)"
                        cmd.Parameters.AddWithValue("@SoftwareCode", softwareCode)
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInEmployeeID)
                    End If

                    ' --- Common Parameters (for both insert and update) ---
                    cmd.Parameters.AddWithValue("@SoftwareName", txtSoftwareName.Text)
                    cmd.Parameters.AddWithValue("@SoftwareVersion", txtVersion.Text)
                    cmd.Parameters.AddWithValue("@SoftwareLicenseKey", txtLicenseKey.Text)
                    cmd.Parameters.AddWithValue("@MainCategoryID", cmbMainCategory.SelectedValue)
                    cmd.Parameters.AddWithValue("@SubCategoryID", cmbSubCategory.SelectedValue)
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@LicenseExpiryDate", dtpLicenseExpiry.Value)
                    cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record saved successfully!")

                        If Application.OpenForms().OfType(Of frmSoftwareList).Any() Then
                            Dim form As frmSoftwareList = Application.OpenForms().OfType(Of frmSoftwareList).First()
                            form.LoadSoftwareList()
                        End If

                        If isEditMode Then
                            Me.Close()
                        Else
                            ClearForm()
                        End If
                    Else
                        MessageBox.Show("No changes were made.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub




    Private Sub ClearForm()
        txtSoftwareName.Clear()
        txtVersion.Clear()
        txtLicenseKey.Clear()
        txtDescription.Clear()
        dtpLicenseExpiry.Value = DateTime.Now
        dtpPurchaseDate.Value = DateTime.Now
        cmbMainCategory.SelectedIndex = -1
        cmbSubCategory.SelectedIndex = -1
    End Sub

    Private Sub btnAddMainCategory_Click(sender As Object, e As EventArgs) Handles btnAddMainCategory.Click
        Dim frm As New frmMainCategory()
        frm.ShowDialog()  ' This will open the frmMainCategory form
        LoadMainCategories()  ' Reload the main categories after adding a new one
    End Sub

    ' Button click event for opening frmSubCategory
    Private Sub btnAddSubCategory_Click(sender As Object, e As EventArgs) Handles btnAddSubCategory.Click
        Dim frm As New frmSubCategory()
        frm.ShowDialog()  ' This will open the frmSubCategory form
        If cmbMainCategory.SelectedValue IsNot Nothing Then
            LoadSubCategories(cmbMainCategory.SelectedValue)
        End If
    End Sub
    Public Sub LoadSoftwareForEditing(softwareCode As String)
        Dim query As String = "SELECT * FROM SoftwareTable WHERE SoftwareCode = @SoftwareCode"

        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SoftwareCode", softwareCode)

                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtSoftwareCode.Text = reader("SoftwareCode").ToString()
                        txtSoftwareName.Text = reader("SoftwareName").ToString()
                        txtVersion.Text = reader("SoftwareVersion").ToString()
                        txtLicenseKey.Text = reader("SoftwareLicenseKey").ToString()
                        txtDescription.Text = reader("Description").ToString()
                        dtpLicenseExpiry.Value = Convert.ToDateTime(reader("LicenseExpiryDate"))
                        dtpPurchaseDate.Value = Convert.ToDateTime(reader("PurchaseDate"))
                        cmbMainCategory.SelectedValue = reader("MainCategoryID")
                        cmbSubCategory.SelectedValue = reader("SubCategoryID")
                    Else
                        MessageBox.Show("Software not found.")
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class
