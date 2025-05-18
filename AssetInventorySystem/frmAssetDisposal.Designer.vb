<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssetDisposal
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
        Me.dgvAssetsToDispose = New System.Windows.Forms.DataGridView()
        Me.txtAssetCode = New System.Windows.Forms.TextBox()
        Me.txtAssetName = New System.Windows.Forms.TextBox()
        Me.dtpDisposalDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbDisposalReason = New System.Windows.Forms.ComboBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtDisposalBy = New System.Windows.Forms.TextBox()
        Me.btnDisposeAsset = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvAssetsToDispose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAssetsToDispose
        '
        Me.dgvAssetsToDispose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssetsToDispose.Location = New System.Drawing.Point(409, 167)
        Me.dgvAssetsToDispose.Name = "dgvAssetsToDispose"
        Me.dgvAssetsToDispose.RowHeadersWidth = 51
        Me.dgvAssetsToDispose.RowTemplate.Height = 24
        Me.dgvAssetsToDispose.Size = New System.Drawing.Size(546, 307)
        Me.dgvAssetsToDispose.TabIndex = 0
        '
        'txtAssetCode
        '
        Me.txtAssetCode.Location = New System.Drawing.Point(161, 167)
        Me.txtAssetCode.Name = "txtAssetCode"
        Me.txtAssetCode.Size = New System.Drawing.Size(203, 22)
        Me.txtAssetCode.TabIndex = 1
        '
        'txtAssetName
        '
        Me.txtAssetName.Location = New System.Drawing.Point(161, 201)
        Me.txtAssetName.Name = "txtAssetName"
        Me.txtAssetName.Size = New System.Drawing.Size(203, 22)
        Me.txtAssetName.TabIndex = 2
        '
        'dtpDisposalDate
        '
        Me.dtpDisposalDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDisposalDate.Location = New System.Drawing.Point(160, 243)
        Me.dtpDisposalDate.Name = "dtpDisposalDate"
        Me.dtpDisposalDate.Size = New System.Drawing.Size(201, 22)
        Me.dtpDisposalDate.TabIndex = 3
        Me.dtpDisposalDate.Value = New Date(2025, 4, 12, 0, 0, 0, 0)
        '
        'cmbDisposalReason
        '
        Me.cmbDisposalReason.FormattingEnabled = True
        Me.cmbDisposalReason.Location = New System.Drawing.Point(160, 286)
        Me.cmbDisposalReason.Name = "cmbDisposalReason"
        Me.cmbDisposalReason.Size = New System.Drawing.Size(202, 24)
        Me.cmbDisposalReason.TabIndex = 4
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(160, 327)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(203, 22)
        Me.txtRemarks.TabIndex = 5
        '
        'txtDisposalBy
        '
        Me.txtDisposalBy.Location = New System.Drawing.Point(160, 366)
        Me.txtDisposalBy.Name = "txtDisposalBy"
        Me.txtDisposalBy.Size = New System.Drawing.Size(202, 22)
        Me.txtDisposalBy.TabIndex = 6
        '
        'btnDisposeAsset
        '
        Me.btnDisposeAsset.Location = New System.Drawing.Point(440, 522)
        Me.btnDisposeAsset.Name = "btnDisposeAsset"
        Me.btnDisposeAsset.Size = New System.Drawing.Size(126, 48)
        Me.btnDisposeAsset.TabIndex = 7
        Me.btnDisposeAsset.Text = "Dispose"
        Me.btnDisposeAsset.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(623, 526)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 44)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Asset Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Disposal By:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Remarks:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Reason:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Disposal Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Asset Name:"
        '
        'frmAssetDisposal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 688)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisposeAsset)
        Me.Controls.Add(Me.txtDisposalBy)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.cmbDisposalReason)
        Me.Controls.Add(Me.dtpDisposalDate)
        Me.Controls.Add(Me.txtAssetName)
        Me.Controls.Add(Me.txtAssetCode)
        Me.Controls.Add(Me.dgvAssetsToDispose)
        Me.Name = "frmAssetDisposal"
        Me.Text = "frmAssetDisposal"
        CType(Me.dgvAssetsToDispose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAssetsToDispose As DataGridView
    Friend WithEvents txtAssetCode As TextBox
    Friend WithEvents txtAssetName As TextBox
    Friend WithEvents dtpDisposalDate As DateTimePicker
    Friend WithEvents cmbDisposalReason As ComboBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtDisposalBy As TextBox
    Friend WithEvents btnDisposeAsset As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
