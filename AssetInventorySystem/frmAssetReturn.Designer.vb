<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssetReturn
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
        Me.dgvAssignmentsToReturn = New System.Windows.Forms.DataGridView()
        Me.txtAssetCode = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbConditionOnReturn = New System.Windows.Forms.ComboBox()
        Me.txtReturnedBy = New System.Windows.Forms.TextBox()
        Me.txtReceivedBy = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnReturnAsset = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvAssignmentsToReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAssignmentsToReturn
        '
        Me.dgvAssignmentsToReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignmentsToReturn.Location = New System.Drawing.Point(468, 103)
        Me.dgvAssignmentsToReturn.Name = "dgvAssignmentsToReturn"
        Me.dgvAssignmentsToReturn.RowHeadersWidth = 51
        Me.dgvAssignmentsToReturn.RowTemplate.Height = 24
        Me.dgvAssignmentsToReturn.Size = New System.Drawing.Size(543, 283)
        Me.dgvAssignmentsToReturn.TabIndex = 0
        '
        'txtAssetCode
        '
        Me.txtAssetCode.Location = New System.Drawing.Point(182, 115)
        Me.txtAssetCode.Name = "txtAssetCode"
        Me.txtAssetCode.Size = New System.Drawing.Size(259, 22)
        Me.txtAssetCode.TabIndex = 1
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(182, 156)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(259, 22)
        Me.txtEmployeeName.TabIndex = 2
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.Location = New System.Drawing.Point(174, 197)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(266, 22)
        Me.dtpReturnDate.TabIndex = 3
        '
        'cmbConditionOnReturn
        '
        Me.cmbConditionOnReturn.DisplayMember = "(none)"
        Me.cmbConditionOnReturn.FormattingEnabled = True
        Me.cmbConditionOnReturn.Location = New System.Drawing.Point(173, 239)
        Me.cmbConditionOnReturn.Name = "cmbConditionOnReturn"
        Me.cmbConditionOnReturn.Size = New System.Drawing.Size(267, 24)
        Me.cmbConditionOnReturn.TabIndex = 4
        '
        'txtReturnedBy
        '
        Me.txtReturnedBy.Location = New System.Drawing.Point(172, 282)
        Me.txtReturnedBy.Name = "txtReturnedBy"
        Me.txtReturnedBy.Size = New System.Drawing.Size(259, 22)
        Me.txtReturnedBy.TabIndex = 5
        '
        'txtReceivedBy
        '
        Me.txtReceivedBy.AllowDrop = True
        Me.txtReceivedBy.Location = New System.Drawing.Point(177, 319)
        Me.txtReceivedBy.Name = "txtReceivedBy"
        Me.txtReceivedBy.Size = New System.Drawing.Size(259, 22)
        Me.txtReceivedBy.TabIndex = 6
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(178, 364)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(259, 22)
        Me.txtRemarks.TabIndex = 7
        '
        'btnReturnAsset
        '
        Me.btnReturnAsset.Location = New System.Drawing.Point(700, 535)
        Me.btnReturnAsset.Name = "btnReturnAsset"
        Me.btnReturnAsset.Size = New System.Drawing.Size(133, 36)
        Me.btnReturnAsset.TabIndex = 8
        Me.btnReturnAsset.Text = "Return"
        Me.btnReturnAsset.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(833, 535)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 36)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Asset Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ReturnDate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Received By"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ReturnedBy"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Condition On Return"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Remarks"
        '
        'frmAssetReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 679)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReturnAsset)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtReceivedBy)
        Me.Controls.Add(Me.txtReturnedBy)
        Me.Controls.Add(Me.cmbConditionOnReturn)
        Me.Controls.Add(Me.dtpReturnDate)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.txtAssetCode)
        Me.Controls.Add(Me.dgvAssignmentsToReturn)
        Me.Name = "frmAssetReturn"
        Me.Text = "frmAssetReturn"
        CType(Me.dgvAssignmentsToReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAssignmentsToReturn As DataGridView
    Friend WithEvents txtAssetCode As TextBox
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents cmbConditionOnReturn As ComboBox
    Friend WithEvents txtReturnedBy As TextBox
    Friend WithEvents txtReceivedBy As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents btnReturnAsset As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
End Class
