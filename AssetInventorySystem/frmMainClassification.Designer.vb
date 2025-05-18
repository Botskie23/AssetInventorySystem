<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainClassification
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
        Me.txtMainClassname = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEditUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvMainClassifications = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvMainClassifications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMainClassname
        '
        Me.txtMainClassname.Location = New System.Drawing.Point(82, 83)
        Me.txtMainClassname.Name = "txtMainClassname"
        Me.txtMainClassname.Size = New System.Drawing.Size(276, 22)
        Me.txtMainClassname.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(80, 125)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(278, 22)
        Me.txtDescription.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(92, 369)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 43)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEditUpdate
        '
        Me.btnEditUpdate.Location = New System.Drawing.Point(207, 369)
        Me.btnEditUpdate.Name = "btnEditUpdate"
        Me.btnEditUpdate.Size = New System.Drawing.Size(109, 43)
        Me.btnEditUpdate.TabIndex = 4
        Me.btnEditUpdate.Text = "Update"
        Me.btnEditUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(322, 369)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 43)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvMainClassifications
        '
        Me.dgvMainClassifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMainClassifications.Location = New System.Drawing.Point(80, 178)
        Me.dgvMainClassifications.Name = "dgvMainClassifications"
        Me.dgvMainClassifications.RowHeadersWidth = 51
        Me.dgvMainClassifications.RowTemplate.Height = 24
        Me.dgvMainClassifications.Size = New System.Drawing.Size(561, 150)
        Me.dgvMainClassifications.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Main Class Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Description"
        '
        'frmMainClassification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvMainClassifications)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEditUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtMainClassname)
        Me.Name = "frmMainClassification"
        Me.Text = "frmMainClassification"
        CType(Me.dgvMainClassifications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMainClassname As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEditUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvMainClassifications As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
