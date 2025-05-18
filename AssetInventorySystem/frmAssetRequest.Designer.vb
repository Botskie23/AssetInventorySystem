<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssetRequest
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbEmployee = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtEmployeeID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDesignation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDepartment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbAssetType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReason = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpDateNeeded = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbRequestCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPriority = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asset Request Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Company ID Number"
        '
        'cmbEmployee
        '
        Me.cmbEmployee.BackColor = System.Drawing.Color.Transparent
        Me.cmbEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmployee.FocusedColor = System.Drawing.Color.Empty
        Me.cmbEmployee.FocusedState.Parent = Me.cmbEmployee
        Me.cmbEmployee.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbEmployee.FormattingEnabled = True
        Me.cmbEmployee.HoverState.Parent = Me.cmbEmployee
        Me.cmbEmployee.ItemHeight = 30
        Me.cmbEmployee.ItemsAppearance.Parent = Me.cmbEmployee
        Me.cmbEmployee.Location = New System.Drawing.Point(176, 118)
        Me.cmbEmployee.Name = "cmbEmployee"
        Me.cmbEmployee.ShadowDecoration.Parent = Me.cmbEmployee
        Me.cmbEmployee.Size = New System.Drawing.Size(261, 36)
        Me.cmbEmployee.TabIndex = 2
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmployeeID.DefaultText = ""
        Me.txtEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployeeID.DisabledState.Parent = Me.txtEmployeeID
        Me.txtEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmployeeID.FocusedState.Parent = Me.txtEmployeeID
        Me.txtEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmployeeID.HoverState.Parent = Me.txtEmployeeID
        Me.txtEmployeeID.Location = New System.Drawing.Point(176, 164)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployeeID.PlaceholderText = ""
        Me.txtEmployeeID.SelectedText = ""
        Me.txtEmployeeID.ShadowDecoration.Parent = Me.txtEmployeeID
        Me.txtEmployeeID.Size = New System.Drawing.Size(260, 34)
        Me.txtEmployeeID.TabIndex = 3
        '
        'txtDesignation
        '
        Me.txtDesignation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesignation.DefaultText = ""
        Me.txtDesignation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDesignation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDesignation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesignation.DisabledState.Parent = Me.txtDesignation
        Me.txtDesignation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesignation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesignation.FocusedState.Parent = Me.txtDesignation
        Me.txtDesignation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesignation.HoverState.Parent = Me.txtDesignation
        Me.txtDesignation.Location = New System.Drawing.Point(177, 206)
        Me.txtDesignation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesignation.PlaceholderText = ""
        Me.txtDesignation.SelectedText = ""
        Me.txtDesignation.ShadowDecoration.Parent = Me.txtDesignation
        Me.txtDesignation.Size = New System.Drawing.Size(260, 34)
        Me.txtDesignation.TabIndex = 4
        '
        'txtDepartment
        '
        Me.txtDepartment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDepartment.DefaultText = ""
        Me.txtDepartment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDepartment.DisabledState.Parent = Me.txtDepartment
        Me.txtDepartment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDepartment.FocusedState.Parent = Me.txtDepartment
        Me.txtDepartment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDepartment.HoverState.Parent = Me.txtDepartment
        Me.txtDepartment.Location = New System.Drawing.Point(444, 206)
        Me.txtDepartment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDepartment.PlaceholderText = ""
        Me.txtDepartment.SelectedText = ""
        Me.txtDepartment.ShadowDecoration.Parent = Me.txtDepartment
        Me.txtDepartment.Size = New System.Drawing.Size(260, 34)
        Me.txtDepartment.TabIndex = 5
        '
        'txtFullName
        '
        Me.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullName.DefaultText = ""
        Me.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFullName.DisabledState.Parent = Me.txtFullName
        Me.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.FocusedState.Parent = Me.txtFullName
        Me.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.HoverState.Parent = Me.txtFullName
        Me.txtFullName.Location = New System.Drawing.Point(444, 164)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullName.PlaceholderText = ""
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.ShadowDecoration.Parent = Me.txtFullName
        Me.txtFullName.Size = New System.Drawing.Size(260, 34)
        Me.txtFullName.TabIndex = 6
        '
        'cmbAssetType
        '
        Me.cmbAssetType.BackColor = System.Drawing.Color.Transparent
        Me.cmbAssetType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAssetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAssetType.FocusedColor = System.Drawing.Color.Empty
        Me.cmbAssetType.FocusedState.Parent = Me.cmbAssetType
        Me.cmbAssetType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbAssetType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbAssetType.FormattingEnabled = True
        Me.cmbAssetType.HoverState.Parent = Me.cmbAssetType
        Me.cmbAssetType.ItemHeight = 30
        Me.cmbAssetType.ItemsAppearance.Parent = Me.cmbAssetType
        Me.cmbAssetType.Location = New System.Drawing.Point(176, 247)
        Me.cmbAssetType.Name = "cmbAssetType"
        Me.cmbAssetType.ShadowDecoration.Parent = Me.cmbAssetType
        Me.cmbAssetType.Size = New System.Drawing.Size(261, 36)
        Me.cmbAssetType.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Asset Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.Parent = Me.txtQuantity
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.FocusedState.Parent = Me.txtQuantity
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.HoverState.Parent = Me.txtQuantity
        Me.txtQuantity.Location = New System.Drawing.Point(177, 292)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.PlaceholderText = ""
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.ShadowDecoration.Parent = Me.txtQuantity
        Me.txtQuantity.Size = New System.Drawing.Size(260, 34)
        Me.txtQuantity.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Justification:"
        '
        'txtReason
        '
        Me.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReason.DefaultText = ""
        Me.txtReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReason.DisabledState.Parent = Me.txtReason
        Me.txtReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReason.FocusedState.Parent = Me.txtReason
        Me.txtReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReason.HoverState.Parent = Me.txtReason
        Me.txtReason.Location = New System.Drawing.Point(177, 376)
        Me.txtReason.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReason.PlaceholderText = ""
        Me.txtReason.SelectedText = ""
        Me.txtReason.ShadowDecoration.Parent = Me.txtReason
        Me.txtReason.Size = New System.Drawing.Size(260, 34)
        Me.txtReason.TabIndex = 11
        '
        'dtpDateNeeded
        '
        Me.dtpDateNeeded.CheckedState.Parent = Me.dtpDateNeeded
        Me.dtpDateNeeded.FillColor = System.Drawing.Color.White
        Me.dtpDateNeeded.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateNeeded.HoverState.Parent = Me.dtpDateNeeded
        Me.dtpDateNeeded.Location = New System.Drawing.Point(182, 425)
        Me.dtpDateNeeded.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateNeeded.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateNeeded.Name = "dtpDateNeeded"
        Me.dtpDateNeeded.ShadowDecoration.Parent = Me.dtpDateNeeded
        Me.dtpDateNeeded.Size = New System.Drawing.Size(253, 35)
        Me.dtpDateNeeded.TabIndex = 13
        Me.dtpDateNeeded.Value = New Date(2025, 4, 24, 13, 40, 29, 685)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date needed:"
        '
        'cmbRequestCategory
        '
        Me.cmbRequestCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbRequestCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRequestCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRequestCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbRequestCategory.FocusedState.Parent = Me.cmbRequestCategory
        Me.cmbRequestCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbRequestCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbRequestCategory.FormattingEnabled = True
        Me.cmbRequestCategory.HoverState.Parent = Me.cmbRequestCategory
        Me.cmbRequestCategory.ItemHeight = 30
        Me.cmbRequestCategory.ItemsAppearance.Parent = Me.cmbRequestCategory
        Me.cmbRequestCategory.Location = New System.Drawing.Point(177, 471)
        Me.cmbRequestCategory.Name = "cmbRequestCategory"
        Me.cmbRequestCategory.ShadowDecoration.Parent = Me.cmbRequestCategory
        Me.cmbRequestCategory.Size = New System.Drawing.Size(259, 36)
        Me.cmbRequestCategory.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 477)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Category:"
        '
        'cmbPriority
        '
        Me.cmbPriority.BackColor = System.Drawing.Color.Transparent
        Me.cmbPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriority.FocusedColor = System.Drawing.Color.Empty
        Me.cmbPriority.FocusedState.Parent = Me.cmbPriority
        Me.cmbPriority.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPriority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbPriority.FormattingEnabled = True
        Me.cmbPriority.HoverState.Parent = Me.cmbPriority
        Me.cmbPriority.ItemHeight = 30
        Me.cmbPriority.ItemsAppearance.Parent = Me.cmbPriority
        Me.cmbPriority.Location = New System.Drawing.Point(180, 519)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.ShadowDecoration.Parent = Me.cmbPriority
        Me.cmbPriority.Size = New System.Drawing.Size(255, 36)
        Me.cmbPriority.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(82, 525)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Priority Level:"
        '
        'btnSubmit
        '
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(554, 452)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(111, 43)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit"
        '
        'btnClear
        '
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(685, 453)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(95, 42)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Description:"
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
        Me.txtDescription.Location = New System.Drawing.Point(177, 334)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = ""
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.ShadowDecoration.Parent = Me.txtDescription
        Me.txtDescription.Size = New System.Drawing.Size(260, 34)
        Me.txtDescription.TabIndex = 21
        '
        'frmAssetRequest
        '
        Me.AccessibleName = " "
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 687)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbPriority)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbRequestCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpDateNeeded)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cmbAssetType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.cmbEmployee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAssetRequest"
        Me.Text = "frmAssetRequest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEmployee As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtEmployeeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDesignation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDepartment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbAssetType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReason As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpDateNeeded As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbRequestCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbPriority As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
End Class
