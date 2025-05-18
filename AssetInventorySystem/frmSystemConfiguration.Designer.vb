<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemConfiguration
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
        Me.btnBackup = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRestore = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGenerateBackupScript = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSetupAutoBackup = New Guna.UI2.WinForms.Guna2Button()
        Me.btnShowActivityLog = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSystemReset = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.CheckedState.Parent = Me.btnBackup
        Me.btnBackup.CustomImages.Parent = Me.btnBackup
        Me.btnBackup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.HoverState.Parent = Me.btnBackup
        Me.btnBackup.Location = New System.Drawing.Point(292, 49)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.ShadowDecoration.Parent = Me.btnBackup
        Me.btnBackup.Size = New System.Drawing.Size(197, 40)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "Backup"
        '
        'btnRestore
        '
        Me.btnRestore.CheckedState.Parent = Me.btnRestore
        Me.btnRestore.CustomImages.Parent = Me.btnRestore
        Me.btnRestore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.HoverState.Parent = Me.btnRestore
        Me.btnRestore.Location = New System.Drawing.Point(292, 89)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.ShadowDecoration.Parent = Me.btnRestore
        Me.btnRestore.Size = New System.Drawing.Size(197, 40)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "Restore"
        '
        'btnGenerateBackupScript
        '
        Me.btnGenerateBackupScript.CheckedState.Parent = Me.btnGenerateBackupScript
        Me.btnGenerateBackupScript.CustomImages.Parent = Me.btnGenerateBackupScript
        Me.btnGenerateBackupScript.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGenerateBackupScript.ForeColor = System.Drawing.Color.White
        Me.btnGenerateBackupScript.HoverState.Parent = Me.btnGenerateBackupScript
        Me.btnGenerateBackupScript.Location = New System.Drawing.Point(292, 129)
        Me.btnGenerateBackupScript.Name = "btnGenerateBackupScript"
        Me.btnGenerateBackupScript.ShadowDecoration.Parent = Me.btnGenerateBackupScript
        Me.btnGenerateBackupScript.Size = New System.Drawing.Size(197, 40)
        Me.btnGenerateBackupScript.TabIndex = 2
        Me.btnGenerateBackupScript.Text = "Generate Backup Script"
        '
        'btnSetupAutoBackup
        '
        Me.btnSetupAutoBackup.CheckedState.Parent = Me.btnSetupAutoBackup
        Me.btnSetupAutoBackup.CustomImages.Parent = Me.btnSetupAutoBackup
        Me.btnSetupAutoBackup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSetupAutoBackup.ForeColor = System.Drawing.Color.White
        Me.btnSetupAutoBackup.HoverState.Parent = Me.btnSetupAutoBackup
        Me.btnSetupAutoBackup.Location = New System.Drawing.Point(292, 169)
        Me.btnSetupAutoBackup.Name = "btnSetupAutoBackup"
        Me.btnSetupAutoBackup.ShadowDecoration.Parent = Me.btnSetupAutoBackup
        Me.btnSetupAutoBackup.Size = New System.Drawing.Size(197, 40)
        Me.btnSetupAutoBackup.TabIndex = 3
        Me.btnSetupAutoBackup.Text = "Setup Auto Backup"
        '
        'btnShowActivityLog
        '
        Me.btnShowActivityLog.CheckedState.Parent = Me.btnShowActivityLog
        Me.btnShowActivityLog.CustomImages.Parent = Me.btnShowActivityLog
        Me.btnShowActivityLog.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnShowActivityLog.ForeColor = System.Drawing.Color.White
        Me.btnShowActivityLog.HoverState.Parent = Me.btnShowActivityLog
        Me.btnShowActivityLog.Location = New System.Drawing.Point(292, 255)
        Me.btnShowActivityLog.Name = "btnShowActivityLog"
        Me.btnShowActivityLog.ShadowDecoration.Parent = Me.btnShowActivityLog
        Me.btnShowActivityLog.Size = New System.Drawing.Size(197, 40)
        Me.btnShowActivityLog.TabIndex = 5
        Me.btnShowActivityLog.Text = "Activity Log"
        '
        'btnSystemReset
        '
        Me.btnSystemReset.CheckedState.Parent = Me.btnSystemReset
        Me.btnSystemReset.CustomImages.Parent = Me.btnSystemReset
        Me.btnSystemReset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSystemReset.ForeColor = System.Drawing.Color.White
        Me.btnSystemReset.HoverState.Parent = Me.btnSystemReset
        Me.btnSystemReset.Location = New System.Drawing.Point(292, 301)
        Me.btnSystemReset.Name = "btnSystemReset"
        Me.btnSystemReset.ShadowDecoration.Parent = Me.btnSystemReset
        Me.btnSystemReset.Size = New System.Drawing.Size(197, 40)
        Me.btnSystemReset.TabIndex = 6
        Me.btnSystemReset.Text = "System Reset"
        '
        'frmSystemConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSystemReset)
        Me.Controls.Add(Me.btnShowActivityLog)
        Me.Controls.Add(Me.btnSetupAutoBackup)
        Me.Controls.Add(Me.btnGenerateBackupScript)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnBackup)
        Me.Name = "frmSystemConfiguration"
        Me.Text = "frmSettings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBackup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRestore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGenerateBackupScript As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSetupAutoBackup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnShowActivityLog As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSystemReset As Guna.UI2.WinForms.Guna2Button
End Class
