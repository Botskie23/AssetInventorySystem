
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSoftwareAssignment
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbEmployee = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpAssignmentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRemarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvAssignments = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssign = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSoftwareCode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbAssetCode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Employee:"
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
        Me.cmbEmployee.Location = New System.Drawing.Point(181, 123)
        Me.cmbEmployee.Name = "cmbEmployee"
        Me.cmbEmployee.ShadowDecoration.Parent = Me.cmbEmployee
        Me.cmbEmployee.Size = New System.Drawing.Size(345, 36)
        Me.cmbEmployee.TabIndex = 2
        '
        'dtpAssignmentDate
        '
        Me.dtpAssignmentDate.Location = New System.Drawing.Point(181, 261)
        Me.dtpAssignmentDate.Name = "dtpAssignmentDate"
        Me.dtpAssignmentDate.Size = New System.Drawing.Size(345, 22)
        Me.dtpAssignmentDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Assignment Date:"
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
        Me.txtRemarks.Location = New System.Drawing.Point(181, 344)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemarks.PlaceholderText = ""
        Me.txtRemarks.SelectedText = ""
        Me.txtRemarks.ShadowDecoration.Parent = Me.txtRemarks
        Me.txtRemarks.Size = New System.Drawing.Size(345, 54)
        Me.txtRemarks.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Remarks:"
        '
        'dgvAssignments
        '
        Me.dgvAssignments.AllowUserToAddRows = False
        Me.dgvAssignments.AllowUserToDeleteRows = False
        Me.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignments.Location = New System.Drawing.Point(620, 84)
        Me.dgvAssignments.Name = "dgvAssignments"
        Me.dgvAssignments.ReadOnly = True
        Me.dgvAssignments.RowHeadersWidth = 51
        Me.dgvAssignments.RowTemplate.Height = 24
        Me.dgvAssignments.Size = New System.Drawing.Size(452, 436)
        Me.dgvAssignments.TabIndex = 10
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(620, 40)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "🔍 Search by Employee/Software"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(328, 39)
        Me.txtSearch.TabIndex = 11
        '
        'btnRefresh
        '
        Me.btnRefresh.CheckedState.Parent = Me.btnRefresh
        Me.btnRefresh.CustomImages.Parent = Me.btnRefresh
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.HoverState.Parent = Me.btnRefresh
        Me.btnRefresh.Location = New System.Drawing.Point(956, 43)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.ShadowDecoration.Parent = Me.btnRefresh
        Me.btnRefresh.Size = New System.Drawing.Size(115, 35)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh List"
        '
        'btnAssign
        '
        Me.btnAssign.CheckedState.Parent = Me.btnAssign
        Me.btnAssign.CustomImages.Parent = Me.btnAssign
        Me.btnAssign.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAssign.ForeColor = System.Drawing.Color.White
        Me.btnAssign.HoverState.Parent = Me.btnAssign
        Me.btnAssign.Location = New System.Drawing.Point(197, 425)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.ShadowDecoration.Parent = Me.btnAssign
        Me.btnAssign.Size = New System.Drawing.Size(278, 53)
        Me.btnAssign.TabIndex = 13
        Me.btnAssign.Text = "Assign Software"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(457, 70)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Software Assignment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Software Code:"
        '
        'cmbSoftwareCode
        '
        Me.cmbSoftwareCode.BackColor = System.Drawing.Color.Transparent
        Me.cmbSoftwareCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSoftwareCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSoftwareCode.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSoftwareCode.FocusedState.Parent = Me.cmbSoftwareCode
        Me.cmbSoftwareCode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSoftwareCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSoftwareCode.FormattingEnabled = True
        Me.cmbSoftwareCode.HoverState.Parent = Me.cmbSoftwareCode
        Me.cmbSoftwareCode.ItemHeight = 30
        Me.cmbSoftwareCode.ItemsAppearance.Parent = Me.cmbSoftwareCode
        Me.cmbSoftwareCode.Location = New System.Drawing.Point(181, 165)
        Me.cmbSoftwareCode.Name = "cmbSoftwareCode"
        Me.cmbSoftwareCode.ShadowDecoration.Parent = Me.cmbSoftwareCode
        Me.cmbSoftwareCode.Size = New System.Drawing.Size(345, 36)
        Me.cmbSoftwareCode.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Asset Code:"
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
        Me.cmbAssetCode.Location = New System.Drawing.Point(181, 207)
        Me.cmbAssetCode.Name = "cmbAssetCode"
        Me.cmbAssetCode.ShadowDecoration.Parent = Me.cmbAssetCode
        Me.cmbAssetCode.Size = New System.Drawing.Size(345, 36)
        Me.cmbAssetCode.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cmbStatus.FocusedState.Parent = Me.cmbStatus
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.HoverState.Parent = Me.cmbStatus
        Me.cmbStatus.ItemHeight = 30
        Me.cmbStatus.ItemsAppearance.Parent = Me.cmbStatus
        Me.cmbStatus.Location = New System.Drawing.Point(181, 301)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShadowDecoration.Parent = Me.cmbStatus
        Me.cmbStatus.Size = New System.Drawing.Size(345, 36)
        Me.cmbStatus.TabIndex = 19
        '
        'frmSoftwareAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 684)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbAssetCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbSoftwareCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvAssignments)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpAssignmentDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbEmployee)
        Me.Name = "frmSoftwareAssignment"
        Me.Text = "frmSoftwareAssignment"
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEmployee As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpAssignmentDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRemarks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvAssignments As DataGridView
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssign As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbSoftwareCode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbAssetCode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
End Class
