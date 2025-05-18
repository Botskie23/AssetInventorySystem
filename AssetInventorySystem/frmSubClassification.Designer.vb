<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubClassification
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEditUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtSubClassName = New System.Windows.Forms.TextBox()
        Me.dgvSubClassifications = New System.Windows.Forms.DataGridView()
        Me.lblSubClassID = New System.Windows.Forms.Label()
        Me.cmbMainClass = New System.Windows.Forms.ComboBox()
        CType(Me.dgvSubClassifications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(576, 307)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 43)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEditUpdate
        '
        Me.btnEditUpdate.Location = New System.Drawing.Point(231, 307)
        Me.btnEditUpdate.Name = "btnEditUpdate"
        Me.btnEditUpdate.Size = New System.Drawing.Size(109, 43)
        Me.btnEditUpdate.TabIndex = 12
        Me.btnEditUpdate.Text = "Edit"
        Me.btnEditUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(116, 307)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 43)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(75, 133)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(278, 22)
        Me.txtDescription.TabIndex = 10
        '
        'txtSubClassName
        '
        Me.txtSubClassName.Location = New System.Drawing.Point(77, 105)
        Me.txtSubClassName.Name = "txtSubClassName"
        Me.txtSubClassName.Size = New System.Drawing.Size(276, 22)
        Me.txtSubClassName.TabIndex = 9
        '
        'dgvSubClassifications
        '
        Me.dgvSubClassifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubClassifications.Location = New System.Drawing.Point(75, 178)
        Me.dgvSubClassifications.Name = "dgvSubClassifications"
        Me.dgvSubClassifications.RowHeadersWidth = 51
        Me.dgvSubClassifications.RowTemplate.Height = 24
        Me.dgvSubClassifications.Size = New System.Drawing.Size(610, 110)
        Me.dgvSubClassifications.TabIndex = 18
        '
        'lblSubClassID
        '
        Me.lblSubClassID.AutoSize = True
        Me.lblSubClassID.Location = New System.Drawing.Point(517, 63)
        Me.lblSubClassID.Name = "lblSubClassID"
        Me.lblSubClassID.Size = New System.Drawing.Size(48, 16)
        Me.lblSubClassID.TabIndex = 19
        Me.lblSubClassID.Text = "Label1"
        '
        'cmbMainClass
        '
        Me.cmbMainClass.FormattingEnabled = True
        Me.cmbMainClass.Location = New System.Drawing.Point(89, 48)
        Me.cmbMainClass.Name = "cmbMainClass"
        Me.cmbMainClass.Size = New System.Drawing.Size(273, 24)
        Me.cmbMainClass.TabIndex = 20
        '
        'frmSubClassification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbMainClass)
        Me.Controls.Add(Me.lblSubClassID)
        Me.Controls.Add(Me.dgvSubClassifications)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEditUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtSubClassName)
        Me.Name = "frmSubClassification"
        Me.Text = "frmSubClassification"
        CType(Me.dgvSubClassifications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEditUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtSubClassName As TextBox
    Friend WithEvents dgvSubClassifications As DataGridView
    Friend WithEvents lblSubClassID As Label
    Friend WithEvents cmbMainClass As ComboBox



    Private Sub cmbMainClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMainClass.SelectedIndexChanged

    End Sub
End Class
