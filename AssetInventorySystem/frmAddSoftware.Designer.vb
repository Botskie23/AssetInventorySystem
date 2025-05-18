<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSoftware
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSoftware))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddSoftware = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpLicenseExpiry = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtVersion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLicenseKey = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSoftwareName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbSubCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbMainCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpPurchaseDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSoftwareCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddMainCategory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddSubCategory = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 251)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 30)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Software Name:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(99, 281)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 30)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Version:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(63, 317)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 30)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "License Key:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(496, 322)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 30)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Expiration Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 353)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 30)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "MainCategory"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(520, 367)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 30)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Description:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(506, 245)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Sub Category:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescription
        '
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.Parent = Me.txtDescription
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.FocusedState.Parent = Me.txtDescription
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.HoverState.Parent = Me.txtDescription
        Me.txtDescription.Location = New System.Drawing.Point(647, 361)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = ""
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.ShadowDecoration.Parent = Me.txtDescription
        Me.txtDescription.Size = New System.Drawing.Size(269, 36)
        Me.txtDescription.TabIndex = 37
        '
        'btnDelete
        '
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(647, 425)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(199, 57)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Tag = "Delete"
        Me.btnDelete.Text = "Delete"
        '
        'btnEditUpdate
        '
        Me.btnEditUpdate.CheckedState.Parent = Me.btnEditUpdate
        Me.btnEditUpdate.CustomImages.Parent = Me.btnEditUpdate
        Me.btnEditUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditUpdate.ForeColor = System.Drawing.Color.White
        Me.btnEditUpdate.HoverState.Parent = Me.btnEditUpdate
        Me.btnEditUpdate.Location = New System.Drawing.Point(429, 425)
        Me.btnEditUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditUpdate.Name = "btnEditUpdate"
        Me.btnEditUpdate.ShadowDecoration.Parent = Me.btnEditUpdate
        Me.btnEditUpdate.Size = New System.Drawing.Size(199, 57)
        Me.btnEditUpdate.TabIndex = 35
        Me.btnEditUpdate.Tag = "btnEditUpdate"
        Me.btnEditUpdate.Text = "Edit"
        '
        'btnAddSoftware
        '
        Me.btnAddSoftware.CheckedState.Parent = Me.btnAddSoftware
        Me.btnAddSoftware.CustomImages.Parent = Me.btnAddSoftware
        Me.btnAddSoftware.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddSoftware.ForeColor = System.Drawing.Color.White
        Me.btnAddSoftware.HoverState.Parent = Me.btnAddSoftware
        Me.btnAddSoftware.Location = New System.Drawing.Point(210, 425)
        Me.btnAddSoftware.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddSoftware.Name = "btnAddSoftware"
        Me.btnAddSoftware.ShadowDecoration.Parent = Me.btnAddSoftware
        Me.btnAddSoftware.Size = New System.Drawing.Size(199, 57)
        Me.btnAddSoftware.TabIndex = 34
        Me.btnAddSoftware.Tag = "btnEditUpdate"
        Me.btnAddSoftware.Text = "Add"
        '
        'dtpLicenseExpiry
        '
        Me.dtpLicenseExpiry.CheckedState.Parent = Me.dtpLicenseExpiry
        Me.dtpLicenseExpiry.FillColor = System.Drawing.Color.White
        Me.dtpLicenseExpiry.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLicenseExpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLicenseExpiry.HoverState.Parent = Me.dtpLicenseExpiry
        Me.dtpLicenseExpiry.Location = New System.Drawing.Point(647, 322)
        Me.dtpLicenseExpiry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpLicenseExpiry.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpLicenseExpiry.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpLicenseExpiry.Name = "dtpLicenseExpiry"
        Me.dtpLicenseExpiry.ShadowDecoration.Parent = Me.dtpLicenseExpiry
        Me.dtpLicenseExpiry.Size = New System.Drawing.Size(269, 36)
        Me.dtpLicenseExpiry.TabIndex = 32
        Me.dtpLicenseExpiry.Value = New Date(2025, 4, 20, 19, 50, 2, 813)
        '
        'txtVersion
        '
        Me.txtVersion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVersion.DefaultText = ""
        Me.txtVersion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVersion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVersion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVersion.DisabledState.Parent = Me.txtVersion
        Me.txtVersion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVersion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVersion.FocusedState.Parent = Me.txtVersion
        Me.txtVersion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVersion.HoverState.Parent = Me.txtVersion
        Me.txtVersion.Location = New System.Drawing.Point(188, 281)
        Me.txtVersion.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVersion.PlaceholderText = ""
        Me.txtVersion.SelectedText = ""
        Me.txtVersion.ShadowDecoration.Parent = Me.txtVersion
        Me.txtVersion.Size = New System.Drawing.Size(269, 36)
        Me.txtVersion.TabIndex = 29
        '
        'txtLicenseKey
        '
        Me.txtLicenseKey.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLicenseKey.DefaultText = ""
        Me.txtLicenseKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLicenseKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLicenseKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLicenseKey.DisabledState.Parent = Me.txtLicenseKey
        Me.txtLicenseKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLicenseKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLicenseKey.FocusedState.Parent = Me.txtLicenseKey
        Me.txtLicenseKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLicenseKey.HoverState.Parent = Me.txtLicenseKey
        Me.txtLicenseKey.Location = New System.Drawing.Point(188, 317)
        Me.txtLicenseKey.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.txtLicenseKey.Name = "txtLicenseKey"
        Me.txtLicenseKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLicenseKey.PlaceholderText = ""
        Me.txtLicenseKey.SelectedText = ""
        Me.txtLicenseKey.ShadowDecoration.Parent = Me.txtLicenseKey
        Me.txtLicenseKey.Size = New System.Drawing.Size(269, 36)
        Me.txtLicenseKey.TabIndex = 28
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoftwareName.DefaultText = ""
        Me.txtSoftwareName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSoftwareName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSoftwareName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSoftwareName.DisabledState.Parent = Me.txtSoftwareName
        Me.txtSoftwareName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSoftwareName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSoftwareName.FocusedState.Parent = Me.txtSoftwareName
        Me.txtSoftwareName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSoftwareName.HoverState.Parent = Me.txtSoftwareName
        Me.txtSoftwareName.Location = New System.Drawing.Point(188, 245)
        Me.txtSoftwareName.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSoftwareName.PlaceholderText = ""
        Me.txtSoftwareName.SelectedText = ""
        Me.txtSoftwareName.ShadowDecoration.Parent = Me.txtSoftwareName
        Me.txtSoftwareName.Size = New System.Drawing.Size(269, 36)
        Me.txtSoftwareName.TabIndex = 27
        '
        'cmbSubCategory
        '
        Me.cmbSubCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbSubCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSubCategory.FocusedState.Parent = Me.cmbSubCategory
        Me.cmbSubCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSubCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSubCategory.FormattingEnabled = True
        Me.cmbSubCategory.HoverState.Parent = Me.cmbSubCategory
        Me.cmbSubCategory.ItemHeight = 30
        Me.cmbSubCategory.ItemsAppearance.Parent = Me.cmbSubCategory
        Me.cmbSubCategory.Location = New System.Drawing.Point(647, 245)
        Me.cmbSubCategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSubCategory.Name = "cmbSubCategory"
        Me.cmbSubCategory.ShadowDecoration.Parent = Me.cmbSubCategory
        Me.cmbSubCategory.Size = New System.Drawing.Size(269, 36)
        Me.cmbSubCategory.TabIndex = 26
        '
        'cmbMainCategory
        '
        Me.cmbMainCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbMainCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMainCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMainCategory.FocusedState.Parent = Me.cmbMainCategory
        Me.cmbMainCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMainCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMainCategory.FormattingEnabled = True
        Me.cmbMainCategory.HoverState.Parent = Me.cmbMainCategory
        Me.cmbMainCategory.ItemHeight = 30
        Me.cmbMainCategory.ItemsAppearance.Parent = Me.cmbMainCategory
        Me.cmbMainCategory.Location = New System.Drawing.Point(191, 356)
        Me.cmbMainCategory.Name = "cmbMainCategory"
        Me.cmbMainCategory.ShadowDecoration.Parent = Me.cmbMainCategory
        Me.cmbMainCategory.Size = New System.Drawing.Size(265, 36)
        Me.cmbMainCategory.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(498, 283)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 30)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Purchase Date:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpPurchaseDate
        '
        Me.dtpPurchaseDate.CheckedState.Parent = Me.dtpPurchaseDate
        Me.dtpPurchaseDate.FillColor = System.Drawing.Color.White
        Me.dtpPurchaseDate.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPurchaseDate.HoverState.Parent = Me.dtpPurchaseDate
        Me.dtpPurchaseDate.Location = New System.Drawing.Point(647, 283)
        Me.dtpPurchaseDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpPurchaseDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpPurchaseDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpPurchaseDate.Name = "dtpPurchaseDate"
        Me.dtpPurchaseDate.ShadowDecoration.Parent = Me.dtpPurchaseDate
        Me.dtpPurchaseDate.Size = New System.Drawing.Size(269, 36)
        Me.dtpPurchaseDate.TabIndex = 31
        Me.dtpPurchaseDate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.dtpPurchaseDate.Value = New Date(2025, 4, 20, 19, 47, 31, 793)
        '
        'btnClear
        '
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(647, 519)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(199, 57)
        Me.btnClear.TabIndex = 50
        Me.btnClear.Tag = "btnClear"
        Me.btnClear.Text = "Clear"
        '
        'txtSoftwareCode
        '
        Me.txtSoftwareCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoftwareCode.DefaultText = ""
        Me.txtSoftwareCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSoftwareCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSoftwareCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSoftwareCode.DisabledState.Parent = Me.txtSoftwareCode
        Me.txtSoftwareCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSoftwareCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSoftwareCode.FocusedState.Parent = Me.txtSoftwareCode
        Me.txtSoftwareCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSoftwareCode.HoverState.Parent = Me.txtSoftwareCode
        Me.txtSoftwareCode.Location = New System.Drawing.Point(187, 204)
        Me.txtSoftwareCode.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.txtSoftwareCode.Name = "txtSoftwareCode"
        Me.txtSoftwareCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSoftwareCode.PlaceholderText = ""
        Me.txtSoftwareCode.SelectedText = ""
        Me.txtSoftwareCode.ShadowDecoration.Parent = Me.txtSoftwareCode
        Me.txtSoftwareCode.Size = New System.Drawing.Size(269, 36)
        Me.txtSoftwareCode.TabIndex = 51
        Me.txtSoftwareCode.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 204)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 30)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Software Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'btnAddMainCategory
        '
        Me.btnAddMainCategory.AutoRoundedCorners = True
        Me.btnAddMainCategory.BackgroundImage = CType(resources.GetObject("btnAddMainCategory.BackgroundImage"), System.Drawing.Image)
        Me.btnAddMainCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddMainCategory.BorderRadius = 14
        Me.btnAddMainCategory.CheckedState.Parent = Me.btnAddMainCategory
        Me.btnAddMainCategory.CustomImages.Parent = Me.btnAddMainCategory
        Me.btnAddMainCategory.FillColor = System.Drawing.Color.Transparent
        Me.btnAddMainCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddMainCategory.ForeColor = System.Drawing.Color.White
        Me.btnAddMainCategory.HoverState.Parent = Me.btnAddMainCategory
        Me.btnAddMainCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAddMainCategory.Location = New System.Drawing.Point(462, 356)
        Me.btnAddMainCategory.Name = "btnAddMainCategory"
        Me.btnAddMainCategory.ShadowDecoration.Parent = Me.btnAddMainCategory
        Me.btnAddMainCategory.Size = New System.Drawing.Size(36, 30)
        Me.btnAddMainCategory.TabIndex = 53
        '
        'btnAddSubCategory
        '
        Me.btnAddSubCategory.AutoRoundedCorners = True
        Me.btnAddSubCategory.BackgroundImage = CType(resources.GetObject("btnAddSubCategory.BackgroundImage"), System.Drawing.Image)
        Me.btnAddSubCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddSubCategory.BorderRadius = 14
        Me.btnAddSubCategory.CheckedState.Parent = Me.btnAddSubCategory
        Me.btnAddSubCategory.CustomImages.Parent = Me.btnAddSubCategory
        Me.btnAddSubCategory.FillColor = System.Drawing.Color.Transparent
        Me.btnAddSubCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddSubCategory.ForeColor = System.Drawing.Color.White
        Me.btnAddSubCategory.HoverState.Parent = Me.btnAddSubCategory
        Me.btnAddSubCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAddSubCategory.Location = New System.Drawing.Point(923, 245)
        Me.btnAddSubCategory.Name = "btnAddSubCategory"
        Me.btnAddSubCategory.ShadowDecoration.Parent = Me.btnAddSubCategory
        Me.btnAddSubCategory.Size = New System.Drawing.Size(36, 30)
        Me.btnAddSubCategory.TabIndex = 54
        '
        'frmAddSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 634)
        Me.Controls.Add(Me.btnAddSubCategory)
        Me.Controls.Add(Me.btnAddMainCategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSoftwareCode)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cmbMainCategory)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEditUpdate)
        Me.Controls.Add(Me.btnAddSoftware)
        Me.Controls.Add(Me.dtpLicenseExpiry)
        Me.Controls.Add(Me.dtpPurchaseDate)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.txtLicenseKey)
        Me.Controls.Add(Me.txtSoftwareName)
        Me.Controls.Add(Me.cmbSubCategory)
        Me.Name = "frmAddSoftware"
        Me.Text = "frmAddSoftware"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddSoftware As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpLicenseExpiry As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtVersion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLicenseKey As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSoftwareName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbSubCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbMainCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpPurchaseDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSoftwareCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddMainCategory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddSubCategory As Guna.UI2.WinForms.Guna2Button
End Class
