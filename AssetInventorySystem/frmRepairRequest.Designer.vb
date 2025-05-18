<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRepairRequest
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
        Me.cmbAssetCode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtAssetName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpDateReported = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtIssueDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSubmitRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbReportedBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvRepairRequests = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvRepairRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAssetCode
        '
        Me.cmbAssetCode.BackColor = System.Drawing.Color.Transparent
        Me.cmbAssetCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAssetCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAssetCode.FocusedColor = System.Drawing.Color.Empty
        Me.cmbAssetCode.FocusedState.Parent = Me.cmbAssetCode
        Me.cmbAssetCode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbAssetCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbAssetCode.FormattingEnabled = True
        Me.cmbAssetCode.HoverState.Parent = Me.cmbAssetCode
        Me.cmbAssetCode.ItemHeight = 30
        Me.cmbAssetCode.ItemsAppearance.Parent = Me.cmbAssetCode
        Me.cmbAssetCode.Location = New System.Drawing.Point(143, 118)
        Me.cmbAssetCode.Name = "cmbAssetCode"
        Me.cmbAssetCode.ShadowDecoration.Parent = Me.cmbAssetCode
        Me.cmbAssetCode.Size = New System.Drawing.Size(225, 36)
        Me.cmbAssetCode.TabIndex = 0
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
        Me.txtAssetName.Location = New System.Drawing.Point(146, 174)
        Me.txtAssetName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAssetName.Name = "txtAssetName"
        Me.txtAssetName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssetName.PlaceholderText = ""
        Me.txtAssetName.SelectedText = ""
        Me.txtAssetName.ShadowDecoration.Parent = Me.txtAssetName
        Me.txtAssetName.Size = New System.Drawing.Size(221, 35)
        Me.txtAssetName.TabIndex = 1
        '
        'dtpDateReported
        '
        Me.dtpDateReported.CheckedState.Parent = Me.dtpDateReported
        Me.dtpDateReported.FillColor = System.Drawing.Color.White
        Me.dtpDateReported.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateReported.HoverState.Parent = Me.dtpDateReported
        Me.dtpDateReported.Location = New System.Drawing.Point(152, 298)
        Me.dtpDateReported.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateReported.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateReported.Name = "dtpDateReported"
        Me.dtpDateReported.ShadowDecoration.Parent = Me.dtpDateReported
        Me.dtpDateReported.Size = New System.Drawing.Size(213, 41)
        Me.dtpDateReported.TabIndex = 3
        Me.dtpDateReported.Value = New Date(2025, 4, 13, 16, 44, 32, 834)
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
        Me.txtIssueDescription.Location = New System.Drawing.Point(150, 370)
        Me.txtIssueDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIssueDescription.Name = "txtIssueDescription"
        Me.txtIssueDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIssueDescription.PlaceholderText = ""
        Me.txtIssueDescription.SelectedText = ""
        Me.txtIssueDescription.ShadowDecoration.Parent = Me.txtIssueDescription
        Me.txtIssueDescription.Size = New System.Drawing.Size(214, 45)
        Me.txtIssueDescription.TabIndex = 4
        '
        'btnSubmitRequest
        '
        Me.btnSubmitRequest.CheckedState.Parent = Me.btnSubmitRequest
        Me.btnSubmitRequest.CustomImages.Parent = Me.btnSubmitRequest
        Me.btnSubmitRequest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmitRequest.ForeColor = System.Drawing.Color.White
        Me.btnSubmitRequest.HoverState.Parent = Me.btnSubmitRequest
        Me.btnSubmitRequest.Location = New System.Drawing.Point(438, 475)
        Me.btnSubmitRequest.Name = "btnSubmitRequest"
        Me.btnSubmitRequest.ShadowDecoration.Parent = Me.btnSubmitRequest
        Me.btnSubmitRequest.Size = New System.Drawing.Size(240, 72)
        Me.btnSubmitRequest.TabIndex = 5
        Me.btnSubmitRequest.Text = "Submit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Asset Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Issue Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Date Reported"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Reported By"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Asset Name"
        '
        'cmbReportedBy
        '
        Me.cmbReportedBy.BackColor = System.Drawing.Color.Transparent
        Me.cmbReportedBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReportedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportedBy.FocusedColor = System.Drawing.Color.Empty
        Me.cmbReportedBy.FocusedState.Parent = Me.cmbReportedBy
        Me.cmbReportedBy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbReportedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbReportedBy.FormattingEnabled = True
        Me.cmbReportedBy.HoverState.Parent = Me.cmbReportedBy
        Me.cmbReportedBy.ItemHeight = 30
        Me.cmbReportedBy.ItemsAppearance.Parent = Me.cmbReportedBy
        Me.cmbReportedBy.Location = New System.Drawing.Point(149, 240)
        Me.cmbReportedBy.Name = "cmbReportedBy"
        Me.cmbReportedBy.ShadowDecoration.Parent = Me.cmbReportedBy
        Me.cmbReportedBy.Size = New System.Drawing.Size(214, 36)
        Me.cmbReportedBy.TabIndex = 12
        '
        'dgvRepairRequests
        '
        Me.dgvRepairRequests.AllowUserToAddRows = False
        Me.dgvRepairRequests.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvRepairRequests.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRepairRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRepairRequests.BackgroundColor = System.Drawing.Color.White
        Me.dgvRepairRequests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRepairRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRepairRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRepairRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRepairRequests.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRepairRequests.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRepairRequests.EnableHeadersVisualStyles = False
        Me.dgvRepairRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRepairRequests.Location = New System.Drawing.Point(401, 113)
        Me.dgvRepairRequests.Name = "dgvRepairRequests"
        Me.dgvRepairRequests.ReadOnly = True
        Me.dgvRepairRequests.RowHeadersVisible = False
        Me.dgvRepairRequests.RowHeadersWidth = 51
        Me.dgvRepairRequests.RowTemplate.Height = 24
        Me.dgvRepairRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRepairRequests.Size = New System.Drawing.Size(827, 319)
        Me.dgvRepairRequests.TabIndex = 6
        Me.dgvRepairRequests.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvRepairRequests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRepairRequests.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRepairRequests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRepairRequests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRepairRequests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRepairRequests.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvRepairRequests.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRepairRequests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRepairRequests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvRepairRequests.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvRepairRequests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRepairRequests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRepairRequests.ThemeStyle.HeaderStyle.Height = 29
        Me.dgvRepairRequests.ThemeStyle.ReadOnly = True
        Me.dgvRepairRequests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRepairRequests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRepairRequests.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvRepairRequests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRepairRequests.ThemeStyle.RowsStyle.Height = 24
        Me.dgvRepairRequests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRepairRequests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnDelete
        '
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(701, 478)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(135, 68)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        '
        'frmRepairRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 670)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cmbReportedBy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvRepairRequests)
        Me.Controls.Add(Me.btnSubmitRequest)
        Me.Controls.Add(Me.txtIssueDescription)
        Me.Controls.Add(Me.dtpDateReported)
        Me.Controls.Add(Me.txtAssetName)
        Me.Controls.Add(Me.cmbAssetCode)
        Me.Name = "frmRepairRequest"
        Me.Text = "frmRepairRequest"
        CType(Me.dgvRepairRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAssetCode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtAssetName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpDateReported As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtIssueDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSubmitRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbReportedBy As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dgvRepairRequests As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
End Class
