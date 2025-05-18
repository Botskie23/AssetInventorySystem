<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserApproval
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
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnDeny = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUserRole = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(49, 92)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.RowTemplate.Height = 24
        Me.dgvUsers.Size = New System.Drawing.Size(730, 200)
        Me.dgvUsers.TabIndex = 0
        '
        'btnApprove
        '
        Me.btnApprove.Location = New System.Drawing.Point(451, 329)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(118, 29)
        Me.btnApprove.TabIndex = 1
        Me.btnApprove.Text = "Approved"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'btnDeny
        '
        Me.btnDeny.Location = New System.Drawing.Point(565, 329)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(87, 29)
        Me.btnDeny.TabIndex = 2
        Me.btnDeny.Text = "Deny"
        Me.btnDeny.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(646, 329)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 29)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnUserRole
        '
        Me.btnUserRole.Location = New System.Drawing.Point(638, 53)
        Me.btnUserRole.Name = "btnUserRole"
        Me.btnUserRole.Size = New System.Drawing.Size(127, 30)
        Me.btnUserRole.TabIndex = 4
        Me.btnUserRole.Text = "Open User Role "
        Me.btnUserRole.UseVisualStyleBackColor = True
        '
        'frmUserApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnUserRole)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDeny)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.dgvUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUserApproval"
        Me.Text = "frmUserApproval"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnDeny As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUserRole As Button
End Class
