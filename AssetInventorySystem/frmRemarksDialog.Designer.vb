<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemarksDialog
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(22, 23)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(185, 16)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Enter remarks for this decision"
        '
        'txtRemarks
        '
        Me.txtRemarks.AccessibleDescription = " "
        Me.txtRemarks.Location = New System.Drawing.Point(28, 51)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(724, 254)
        Me.txtRemarks.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(460, 332)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(121, 43)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Confirm"
        '
        'btnCancel
        '
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(587, 332)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(121, 43)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'frmRemarksDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.lblStatus)
        Me.Name = "frmRemarksDialog"
        Me.Text = "frmRemarksDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class
