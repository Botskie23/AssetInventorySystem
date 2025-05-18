<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAssetRequestApproval
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
        Me.dgvAssetRequests = New System.Windows.Forms.DataGridView()
        Me.btnApprove = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDenied = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPending = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvAssetRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAssetRequests
        '
        Me.dgvAssetRequests.AllowUserToAddRows = False
        Me.dgvAssetRequests.AllowUserToDeleteRows = False
        Me.dgvAssetRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssetRequests.Location = New System.Drawing.Point(37, 58)
        Me.dgvAssetRequests.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvAssetRequests.Name = "dgvAssetRequests"
        Me.dgvAssetRequests.ReadOnly = True
        Me.dgvAssetRequests.RowHeadersWidth = 51
        Me.dgvAssetRequests.RowTemplate.Height = 24
        Me.dgvAssetRequests.Size = New System.Drawing.Size(888, 358)
        Me.dgvAssetRequests.TabIndex = 0
        '
        'btnApprove
        '
        Me.btnApprove.CheckedState.Parent = Me.btnApprove
        Me.btnApprove.CustomImages.Parent = Me.btnApprove
        Me.btnApprove.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.HoverState.Parent = Me.btnApprove
        Me.btnApprove.Location = New System.Drawing.Point(585, 443)
        Me.btnApprove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.ShadowDecoration.Parent = Me.btnApprove
        Me.btnApprove.Size = New System.Drawing.Size(81, 33)
        Me.btnApprove.TabIndex = 1
        Me.btnApprove.Text = "Approve"
        '
        'btnDenied
        '
        Me.btnDenied.CheckedState.Parent = Me.btnDenied
        Me.btnDenied.CustomImages.Parent = Me.btnDenied
        Me.btnDenied.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDenied.ForeColor = System.Drawing.Color.White
        Me.btnDenied.HoverState.Parent = Me.btnDenied
        Me.btnDenied.Location = New System.Drawing.Point(758, 443)
        Me.btnDenied.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDenied.Name = "btnDenied"
        Me.btnDenied.ShadowDecoration.Parent = Me.btnDenied
        Me.btnDenied.Size = New System.Drawing.Size(81, 33)
        Me.btnDenied.TabIndex = 2
        Me.btnDenied.Text = "Deny"
        '
        'btnPending
        '
        Me.btnPending.CheckedState.Parent = Me.btnPending
        Me.btnPending.CustomImages.Parent = Me.btnPending
        Me.btnPending.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPending.ForeColor = System.Drawing.Color.White
        Me.btnPending.HoverState.Parent = Me.btnPending
        Me.btnPending.Location = New System.Drawing.Point(670, 443)
        Me.btnPending.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.ShadowDecoration.Parent = Me.btnPending
        Me.btnPending.Size = New System.Drawing.Size(81, 33)
        Me.btnPending.TabIndex = 3
        Me.btnPending.Text = "Pending"
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
        Me.txtSearch.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(114, 24)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(7, 12, 7, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(811, 28)
        Me.txtSearch.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search:"
        '
        'frmassetrequestApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 535)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnPending)
        Me.Controls.Add(Me.btnDenied)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.dgvAssetRequests)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmassetrequestApproval"
        Me.Text = "frmAssetRequestApproval"
        CType(Me.dgvAssetRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAssetRequests As DataGridView
    Friend WithEvents btnApprove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDenied As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPending As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
