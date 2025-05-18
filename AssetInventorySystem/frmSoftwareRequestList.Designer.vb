<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftwareRequestList
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
        Me.dgvSoftwareRequests = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbStatusFilter = New System.Windows.Forms.ComboBox()
        Me.btnApprove = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeny = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.txtRemarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvSoftwareRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSoftwareRequests
        '
        Me.dgvSoftwareRequests.AllowUserToAddRows = False
        Me.dgvSoftwareRequests.AllowUserToDeleteRows = False
        Me.dgvSoftwareRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSoftwareRequests.Location = New System.Drawing.Point(51, 65)
        Me.dgvSoftwareRequests.Name = "dgvSoftwareRequests"
        Me.dgvSoftwareRequests.ReadOnly = True
        Me.dgvSoftwareRequests.RowHeadersWidth = 51
        Me.dgvSoftwareRequests.RowTemplate.Height = 24
        Me.dgvSoftwareRequests.Size = New System.Drawing.Size(900, 266)
        Me.dgvSoftwareRequests.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status:"
        '
        'cmbStatusFilter
        '
        Me.cmbStatusFilter.FormattingEnabled = True
        Me.cmbStatusFilter.ItemHeight = 16
        Me.cmbStatusFilter.Location = New System.Drawing.Point(109, 24)
        Me.cmbStatusFilter.Name = "cmbStatusFilter"
        Me.cmbStatusFilter.Size = New System.Drawing.Size(183, 24)
        Me.cmbStatusFilter.TabIndex = 2
        '
        'btnApprove
        '
        Me.btnApprove.CheckedState.Parent = Me.btnApprove
        Me.btnApprove.CustomImages.Parent = Me.btnApprove
        Me.btnApprove.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.HoverState.Parent = Me.btnApprove
        Me.btnApprove.Location = New System.Drawing.Point(544, 412)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.ShadowDecoration.Parent = Me.btnApprove
        Me.btnApprove.Size = New System.Drawing.Size(115, 42)
        Me.btnApprove.TabIndex = 3
        Me.btnApprove.Text = "Approve"
        '
        'btnDeny
        '
        Me.btnDeny.CheckedState.Parent = Me.btnDeny
        Me.btnDeny.CustomImages.Parent = Me.btnDeny
        Me.btnDeny.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDeny.ForeColor = System.Drawing.Color.White
        Me.btnDeny.HoverState.Parent = Me.btnDeny
        Me.btnDeny.Location = New System.Drawing.Point(665, 412)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.ShadowDecoration.Parent = Me.btnDeny
        Me.btnDeny.Size = New System.Drawing.Size(115, 42)
        Me.btnDeny.TabIndex = 4
        Me.btnDeny.Text = "Deny"
        '
        'btnRefresh
        '
        Me.btnRefresh.CheckedState.Parent = Me.btnRefresh
        Me.btnRefresh.CustomImages.Parent = Me.btnRefresh
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.HoverState.Parent = Me.btnRefresh
        Me.btnRefresh.Location = New System.Drawing.Point(786, 412)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.ShadowDecoration.Parent = Me.btnRefresh
        Me.btnRefresh.Size = New System.Drawing.Size(115, 42)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
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
        Me.txtRemarks.Location = New System.Drawing.Point(51, 374)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemarks.PlaceholderText = ""
        Me.txtRemarks.SelectedText = ""
        Me.txtRemarks.ShadowDecoration.Parent = Me.txtRemarks
        Me.txtRemarks.Size = New System.Drawing.Size(423, 142)
        Me.txtRemarks.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Remarks:"
        '
        'frmSoftwareRequestList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 602)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDeny)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.cmbStatusFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSoftwareRequests)
        Me.Name = "frmSoftwareRequestList"
        Me.Text = "frmSoftwareRequestList"
        CType(Me.dgvSoftwareRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSoftwareRequests As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStatusFilter As ComboBox
    Friend WithEvents btnApprove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeny As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtRemarks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
End Class
