<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAssetEvaluation
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
        Me.dgvAssetsToEvaluate = New System.Windows.Forms.DataGridView()
        Me.txtAssetCode = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtOriginalCondition = New System.Windows.Forms.TextBox()
        Me.cmbEvaluationResult = New System.Windows.Forms.ComboBox()
        Me.txtEvaluatedBy = New System.Windows.Forms.TextBox()
        Me.btnSaveEvaluation = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Technician = New System.Windows.Forms.Label()
        Me.txtAssetName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEvaluationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbUpdatedStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvAssetsToEvaluate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAssetsToEvaluate
        '
        Me.dgvAssetsToEvaluate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssetsToEvaluate.Location = New System.Drawing.Point(401, 83)
        Me.dgvAssetsToEvaluate.Name = "dgvAssetsToEvaluate"
        Me.dgvAssetsToEvaluate.RowHeadersWidth = 51
        Me.dgvAssetsToEvaluate.RowTemplate.Height = 24
        Me.dgvAssetsToEvaluate.Size = New System.Drawing.Size(722, 870)
        Me.dgvAssetsToEvaluate.TabIndex = 0
        '
        'txtAssetCode
        '
        Me.txtAssetCode.Location = New System.Drawing.Point(169, 77)
        Me.txtAssetCode.Name = "txtAssetCode"
        Me.txtAssetCode.ReadOnly = True
        Me.txtAssetCode.Size = New System.Drawing.Size(220, 22)
        Me.txtAssetCode.TabIndex = 1
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(175, 291)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(220, 22)
        Me.txtRemarks.TabIndex = 2
        '
        'txtOriginalCondition
        '
        Me.txtOriginalCondition.Location = New System.Drawing.Point(171, 168)
        Me.txtOriginalCondition.Name = "txtOriginalCondition"
        Me.txtOriginalCondition.ReadOnly = True
        Me.txtOriginalCondition.ShortcutsEnabled = False
        Me.txtOriginalCondition.Size = New System.Drawing.Size(220, 22)
        Me.txtOriginalCondition.TabIndex = 3
        '
        'cmbEvaluationResult
        '
        Me.cmbEvaluationResult.FormattingEnabled = True
        Me.cmbEvaluationResult.Location = New System.Drawing.Point(174, 201)
        Me.cmbEvaluationResult.Name = "cmbEvaluationResult"
        Me.cmbEvaluationResult.Size = New System.Drawing.Size(215, 24)
        Me.cmbEvaluationResult.TabIndex = 4
        '
        'txtEvaluatedBy
        '
        Me.txtEvaluatedBy.Location = New System.Drawing.Point(175, 263)
        Me.txtEvaluatedBy.Name = "txtEvaluatedBy"
        Me.txtEvaluatedBy.ReadOnly = True
        Me.txtEvaluatedBy.Size = New System.Drawing.Size(215, 22)
        Me.txtEvaluatedBy.TabIndex = 5
        '
        'btnSaveEvaluation
        '
        Me.btnSaveEvaluation.Location = New System.Drawing.Point(256, 398)
        Me.btnSaveEvaluation.Name = "btnSaveEvaluation"
        Me.btnSaveEvaluation.Size = New System.Drawing.Size(134, 52)
        Me.btnSaveEvaluation.TabIndex = 6
        Me.btnSaveEvaluation.Text = "Evaluate"
        Me.btnSaveEvaluation.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(252, 471)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(138, 37)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Asset Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Condition On Return:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Remarks:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Evaluation Result"
        '
        'Technician
        '
        Me.Technician.AutoSize = True
        Me.Technician.Location = New System.Drawing.Point(122, 235)
        Me.Technician.Name = "Technician"
        Me.Technician.Size = New System.Drawing.Size(39, 16)
        Me.Technician.TabIndex = 12
        Me.Technician.Text = "Date:"
        '
        'txtAssetName
        '
        Me.txtAssetName.Location = New System.Drawing.Point(171, 116)
        Me.txtAssetName.Name = "txtAssetName"
        Me.txtAssetName.ReadOnly = True
        Me.txtAssetName.Size = New System.Drawing.Size(219, 22)
        Me.txtAssetName.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Asset Name:"
        '
        'dtpEvaluationDate
        '
        Me.dtpEvaluationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEvaluationDate.Location = New System.Drawing.Point(174, 235)
        Me.dtpEvaluationDate.Name = "dtpEvaluationDate"
        Me.dtpEvaluationDate.Size = New System.Drawing.Size(215, 22)
        Me.dtpEvaluationDate.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Technician Name:"
        '
        'cmbUpdatedStatus
        '
        Me.cmbUpdatedStatus.FormattingEnabled = True
        Me.cmbUpdatedStatus.Location = New System.Drawing.Point(174, 322)
        Me.cmbUpdatedStatus.Name = "cmbUpdatedStatus"
        Me.cmbUpdatedStatus.Size = New System.Drawing.Size(216, 24)
        Me.cmbUpdatedStatus.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(114, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Status:"
        '
        'frmAssetEvaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 998)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbUpdatedStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpEvaluationDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAssetName)
        Me.Controls.Add(Me.Technician)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveEvaluation)
        Me.Controls.Add(Me.txtEvaluatedBy)
        Me.Controls.Add(Me.cmbEvaluationResult)
        Me.Controls.Add(Me.txtOriginalCondition)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtAssetCode)
        Me.Controls.Add(Me.dgvAssetsToEvaluate)
        Me.Name = "frmAssetEvaluation"
        Me.Text = "frmAssetEvaluation"
        CType(Me.dgvAssetsToEvaluate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAssetsToEvaluate As DataGridView
    Friend WithEvents txtAssetCode As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtOriginalCondition As TextBox
    Friend WithEvents cmbEvaluationResult As ComboBox
    Friend WithEvents txtEvaluatedBy As TextBox
    Friend WithEvents btnSaveEvaluation As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Technician As Label
    Friend WithEvents txtAssetName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpEvaluationDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbUpdatedStatus As ComboBox
    Friend WithEvents Label7 As Label
End Class
