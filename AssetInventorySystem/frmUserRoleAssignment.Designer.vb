<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserRoleAssignment
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
        Me.cmbEmployee = New System.Windows.Forms.ComboBox()
        Me.clbRoles = New System.Windows.Forms.CheckedListBox()
        Me.cmbPrimaryRole = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbEmployee
        '
        Me.cmbEmployee.FormattingEnabled = True
        Me.cmbEmployee.Location = New System.Drawing.Point(132, 63)
        Me.cmbEmployee.Name = "cmbEmployee"
        Me.cmbEmployee.Size = New System.Drawing.Size(405, 24)
        Me.cmbEmployee.TabIndex = 0
        '
        'clbRoles
        '
        Me.clbRoles.FormattingEnabled = True
        Me.clbRoles.Location = New System.Drawing.Point(132, 109)
        Me.clbRoles.Name = "clbRoles"
        Me.clbRoles.Size = New System.Drawing.Size(404, 72)
        Me.clbRoles.TabIndex = 1
        '
        'cmbPrimaryRole
        '
        Me.cmbPrimaryRole.FormattingEnabled = True
        Me.cmbPrimaryRole.Location = New System.Drawing.Point(132, 202)
        Me.cmbPrimaryRole.Name = "cmbPrimaryRole"
        Me.cmbPrimaryRole.Size = New System.Drawing.Size(403, 24)
        Me.cmbPrimaryRole.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(132, 263)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(173, 36)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmUserRoleAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbPrimaryRole)
        Me.Controls.Add(Me.clbRoles)
        Me.Controls.Add(Me.cmbEmployee)
        Me.Name = "frmUserRoleAssignment"
        Me.Text = "frmUserRoleAssignment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents clbRoles As CheckedListBox
    Friend WithEvents cmbPrimaryRole As ComboBox
    Friend WithEvents btnSave As Button
End Class
