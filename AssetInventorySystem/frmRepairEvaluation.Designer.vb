<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRepairEvaluation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRequests = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtRequestID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAssetCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAssetName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRemarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtIssueDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbNewStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnEvaluate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReportedBy = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRequests
        '
        Me.dgvRequests.AllowUserToAddRows = False
        Me.dgvRequests.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvRequests.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRequests.BackgroundColor = System.Drawing.Color.White
        Me.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRequests.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRequests.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRequests.EnableHeadersVisualStyles = False
        Me.dgvRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequests.Location = New System.Drawing.Point(430, 112)
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.ReadOnly = True
        Me.dgvRequests.RowHeadersVisible = False
        Me.dgvRequests.RowHeadersWidth = 51
        Me.dgvRequests.RowTemplate.Height = 24
        Me.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequests.Size = New System.Drawing.Size(600, 419)
        Me.dgvRequests.TabIndex = 0
        Me.dgvRequests.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvRequests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRequests.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRequests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRequests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRequests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRequests.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvRequests.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvRequests.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvRequests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRequests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRequests.ThemeStyle.HeaderStyle.Height = 29
        Me.dgvRequests.ThemeStyle.ReadOnly = True
        Me.dgvRequests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRequests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRequests.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvRequests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRequests.ThemeStyle.RowsStyle.Height = 24
        Me.dgvRequests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtRequestID
        '
        Me.txtRequestID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRequestID.DefaultText = ""
        Me.txtRequestID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRequestID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRequestID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRequestID.DisabledState.Parent = Me.txtRequestID
        Me.txtRequestID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRequestID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRequestID.FocusedState.Parent = Me.txtRequestID
        Me.txtRequestID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRequestID.HoverState.Parent = Me.txtRequestID
        Me.txtRequestID.Location = New System.Drawing.Point(552, 67)
        Me.txtRequestID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRequestID.Name = "txtRequestID"
        Me.txtRequestID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRequestID.PlaceholderText = ""
        Me.txtRequestID.SelectedText = ""
        Me.txtRequestID.ShadowDecoration.Parent = Me.txtRequestID
        Me.txtRequestID.Size = New System.Drawing.Size(289, 38)
        Me.txtRequestID.TabIndex = 1
        Me.txtRequestID.Visible = False
        '
        'txtAssetCode
        '
        Me.txtAssetCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAssetCode.DefaultText = ""
        Me.txtAssetCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAssetCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAssetCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssetCode.DisabledState.Parent = Me.txtAssetCode
        Me.txtAssetCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssetCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssetCode.FocusedState.Parent = Me.txtAssetCode
        Me.txtAssetCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssetCode.HoverState.Parent = Me.txtAssetCode
        Me.txtAssetCode.Location = New System.Drawing.Point(137, 138)
        Me.txtAssetCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAssetCode.Name = "txtAssetCode"
        Me.txtAssetCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssetCode.PlaceholderText = ""
        Me.txtAssetCode.ReadOnly = True
        Me.txtAssetCode.SelectedText = ""
        Me.txtAssetCode.ShadowDecoration.Parent = Me.txtAssetCode
        Me.txtAssetCode.Size = New System.Drawing.Size(286, 41)
        Me.txtAssetCode.TabIndex = 2
        '
        'txtAssetName
        '
        Me.txtAssetName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAssetName.DefaultText = ""
        Me.txtAssetName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAssetName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAssetName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssetName.DisabledState.Parent = Me.txtAssetName
        Me.txtAssetName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssetName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssetName.FocusedState.Parent = Me.txtAssetName
        Me.txtAssetName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssetName.HoverState.Parent = Me.txtAssetName
        Me.txtAssetName.Location = New System.Drawing.Point(137, 187)
        Me.txtAssetName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAssetName.Name = "txtAssetName"
        Me.txtAssetName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssetName.PlaceholderText = ""
        Me.txtAssetName.ReadOnly = True
        Me.txtAssetName.SelectedText = ""
        Me.txtAssetName.ShadowDecoration.Parent = Me.txtAssetName
        Me.txtAssetName.Size = New System.Drawing.Size(281, 49)
        Me.txtAssetName.TabIndex = 3
        '
        'txtRemarks
        '
        Me.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRemarks.DefaultText = ""
        Me.txtRemarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRemarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRemarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRemarks.DisabledState.Parent = Me.txtRemarks
        Me.txtRemarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRemarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRemarks.FocusedState.Parent = Me.txtRemarks
        Me.txtRemarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRemarks.HoverState.Parent = Me.txtRemarks
        Me.txtRemarks.Location = New System.Drawing.Point(134, 362)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemarks.PlaceholderText = ""
        Me.txtRemarks.SelectedText = ""
        Me.txtRemarks.ShadowDecoration.Parent = Me.txtRemarks
        Me.txtRemarks.Size = New System.Drawing.Size(286, 41)
        Me.txtRemarks.TabIndex = 5
        '
        'txtIssueDescription
        '
        Me.txtIssueDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIssueDescription.DefaultText = ""
        Me.txtIssueDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIssueDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIssueDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIssueDescription.DisabledState.Parent = Me.txtIssueDescription
        Me.txtIssueDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIssueDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIssueDescription.FocusedState.Parent = Me.txtIssueDescription
        Me.txtIssueDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIssueDescription.HoverState.Parent = Me.txtIssueDescription
        Me.txtIssueDescription.Location = New System.Drawing.Point(134, 316)
        Me.txtIssueDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIssueDescription.Name = "txtIssueDescription"
        Me.txtIssueDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIssueDescription.PlaceholderText = ""
        Me.txtIssueDescription.ReadOnly = True
        Me.txtIssueDescription.SelectedText = ""
        Me.txtIssueDescription.ShadowDecoration.Parent = Me.txtIssueDescription
        Me.txtIssueDescription.Size = New System.Drawing.Size(289, 38)
        Me.txtIssueDescription.TabIndex = 4
        '
        'cmbNewStatus
        '
        Me.cmbNewStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbNewStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cmbNewStatus.FocusedState.Parent = Me.cmbNewStatus
        Me.cmbNewStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbNewStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbNewStatus.FormattingEnabled = True
        Me.cmbNewStatus.HoverState.Parent = Me.cmbNewStatus
        Me.cmbNewStatus.ItemHeight = 30
        Me.cmbNewStatus.ItemsAppearance.Parent = Me.cmbNewStatus
        Me.cmbNewStatus.Location = New System.Drawing.Point(134, 410)
        Me.cmbNewStatus.Name = "cmbNewStatus"
        Me.cmbNewStatus.ShadowDecoration.Parent = Me.cmbNewStatus
        Me.cmbNewStatus.Size = New System.Drawing.Size(275, 36)
        Me.cmbNewStatus.TabIndex = 7
        '
        'btnEvaluate
        '
        Me.btnEvaluate.CheckedState.Parent = Me.btnEvaluate
        Me.btnEvaluate.CustomImages.Parent = Me.btnEvaluate
        Me.btnEvaluate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEvaluate.ForeColor = System.Drawing.Color.White
        Me.btnEvaluate.HoverState.Parent = Me.btnEvaluate
        Me.btnEvaluate.Location = New System.Drawing.Point(156, 617)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.ShadowDecoration.Parent = Me.btnEvaluate
        Me.btnEvaluate.Size = New System.Drawing.Size(132, 32)
        Me.btnEvaluate.TabIndex = 9
        Me.btnEvaluate.Text = "Update"
        '
        'btnCancel
        '
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(294, 617)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(132, 32)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Clear"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Asset Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Remarks:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Status Update:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Issue Description:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Asset Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Request ID:"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Reported by:"
        '
        'txtReportedBy
        '
        Me.txtReportedBy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReportedBy.DefaultText = ""
        Me.txtReportedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReportedBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReportedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReportedBy.DisabledState.Parent = Me.txtReportedBy
        Me.txtReportedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReportedBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReportedBy.FocusedState.Parent = Me.txtReportedBy
        Me.txtReportedBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReportedBy.HoverState.Parent = Me.txtReportedBy
        Me.txtReportedBy.Location = New System.Drawing.Point(134, 244)
        Me.txtReportedBy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReportedBy.Name = "txtReportedBy"
        Me.txtReportedBy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReportedBy.PlaceholderText = ""
        Me.txtReportedBy.ReadOnly = True
        Me.txtReportedBy.SelectedText = ""
        Me.txtReportedBy.ShadowDecoration.Parent = Me.txtReportedBy
        Me.txtReportedBy.Size = New System.Drawing.Size(281, 49)
        Me.txtReportedBy.TabIndex = 20
        '
        'frmRepairEvaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 736)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtReportedBy)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.cmbNewStatus)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtIssueDescription)
        Me.Controls.Add(Me.txtAssetName)
        Me.Controls.Add(Me.txtAssetCode)
        Me.Controls.Add(Me.txtRequestID)
        Me.Controls.Add(Me.dgvRequests)
        Me.Name = "frmRepairEvaluation"
        Me.Text = "frmRepairEvaluation"
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRequests As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtRequestID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAssetCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAssetName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRemarks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtIssueDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbNewStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnEvaluate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtReportedBy As Guna.UI2.WinForms.Guna2TextBox
End Class
