<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ITAssetAddForm
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
        Me.cmbSubClassification = New System.Windows.Forms.ComboBox()
        Me.txtAssetCode = New System.Windows.Forms.TextBox()
        Me.txtAssetName = New System.Windows.Forms.TextBox()
        Me.txtAssetBrand = New System.Windows.Forms.TextBox()
        Me.txtAssetColor = New System.Windows.Forms.TextBox()
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.txtAssetModel = New System.Windows.Forms.TextBox()
        Me.cmbCondition = New System.Windows.Forms.ComboBox()
        Me.CMBSourceofAcquisition = New System.Windows.Forms.ComboBox()
        Me.cmbAvailabilityStatus = New System.Windows.Forms.ComboBox()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEditUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpAssetDateAquire = New System.Windows.Forms.DateTimePicker()
        Me.dtpWarrantyEndDate = New System.Windows.Forms.DateTimePicker()
        Me.CmbSupplier = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Label()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbSubClassification
        '
        Me.cmbSubClassification.FormattingEnabled = True
        Me.cmbSubClassification.Location = New System.Drawing.Point(81, 126)
        Me.cmbSubClassification.Name = "cmbSubClassification"
        Me.cmbSubClassification.Size = New System.Drawing.Size(306, 24)
        Me.cmbSubClassification.TabIndex = 0
        '
        'txtAssetCode
        '
        Me.txtAssetCode.Location = New System.Drawing.Point(468, 130)
        Me.txtAssetCode.Name = "txtAssetCode"
        Me.txtAssetCode.Size = New System.Drawing.Size(322, 22)
        Me.txtAssetCode.TabIndex = 1
        '
        'txtAssetName
        '
        Me.txtAssetName.Location = New System.Drawing.Point(83, 193)
        Me.txtAssetName.Name = "txtAssetName"
        Me.txtAssetName.Size = New System.Drawing.Size(304, 22)
        Me.txtAssetName.TabIndex = 2
        '
        'txtAssetBrand
        '
        Me.txtAssetBrand.Location = New System.Drawing.Point(83, 234)
        Me.txtAssetBrand.Name = "txtAssetBrand"
        Me.txtAssetBrand.Size = New System.Drawing.Size(304, 22)
        Me.txtAssetBrand.TabIndex = 3
        '
        'txtAssetColor
        '
        Me.txtAssetColor.Location = New System.Drawing.Point(83, 363)
        Me.txtAssetColor.Name = "txtAssetColor"
        Me.txtAssetColor.Size = New System.Drawing.Size(304, 22)
        Me.txtAssetColor.TabIndex = 4
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Location = New System.Drawing.Point(83, 319)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(304, 22)
        Me.txtSerialNo.TabIndex = 5
        '
        'txtAssetModel
        '
        Me.txtAssetModel.Location = New System.Drawing.Point(83, 274)
        Me.txtAssetModel.Name = "txtAssetModel"
        Me.txtAssetModel.Size = New System.Drawing.Size(304, 22)
        Me.txtAssetModel.TabIndex = 6
        '
        'cmbCondition
        '
        Me.cmbCondition.FormattingEnabled = True
        Me.cmbCondition.Location = New System.Drawing.Point(81, 408)
        Me.cmbCondition.Name = "cmbCondition"
        Me.cmbCondition.Size = New System.Drawing.Size(306, 24)
        Me.cmbCondition.TabIndex = 7
        '
        'CMBSourceofAcquisition
        '
        Me.CMBSourceofAcquisition.FormattingEnabled = True
        Me.CMBSourceofAcquisition.Location = New System.Drawing.Point(468, 191)
        Me.CMBSourceofAcquisition.Name = "CMBSourceofAcquisition"
        Me.CMBSourceofAcquisition.Size = New System.Drawing.Size(322, 24)
        Me.CMBSourceofAcquisition.TabIndex = 8
        '
        'cmbAvailabilityStatus
        '
        Me.cmbAvailabilityStatus.FormattingEnabled = True
        Me.cmbAvailabilityStatus.Location = New System.Drawing.Point(468, 232)
        Me.cmbAvailabilityStatus.Name = "cmbAvailabilityStatus"
        Me.cmbAvailabilityStatus.Size = New System.Drawing.Size(322, 24)
        Me.cmbAvailabilityStatus.TabIndex = 9
        '
        'picQRCode
        '
        Me.picQRCode.Location = New System.Drawing.Point(819, 133)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(317, 251)
        Me.picQRCode.TabIndex = 14
        Me.picQRCode.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(479, 496)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 48)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEditUpdate
        '
        Me.btnEditUpdate.Location = New System.Drawing.Point(621, 496)
        Me.btnEditUpdate.Name = "btnEditUpdate"
        Me.btnEditUpdate.Size = New System.Drawing.Size(124, 48)
        Me.btnEditUpdate.TabIndex = 16
        Me.btnEditUpdate.Text = "Edit"
        Me.btnEditUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(765, 496)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 48)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Sub Class Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Asset Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Brand"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Serial No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Color"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Condition"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(476, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Asset Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(476, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Source of Acquisition"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(476, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Availability Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(476, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "DateAquire"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(476, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Warranty End Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(476, 344)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Supplier"
        '
        'dtpAssetDateAquire
        '
        Me.dtpAssetDateAquire.Location = New System.Drawing.Point(468, 276)
        Me.dtpAssetDateAquire.Name = "dtpAssetDateAquire"
        Me.dtpAssetDateAquire.Size = New System.Drawing.Size(322, 22)
        Me.dtpAssetDateAquire.TabIndex = 31
        '
        'dtpWarrantyEndDate
        '
        Me.dtpWarrantyEndDate.Location = New System.Drawing.Point(468, 317)
        Me.dtpWarrantyEndDate.Name = "dtpWarrantyEndDate"
        Me.dtpWarrantyEndDate.Size = New System.Drawing.Size(322, 22)
        Me.dtpWarrantyEndDate.TabIndex = 32
        '
        'CmbSupplier
        '
        Me.CmbSupplier.FormattingEnabled = True
        Me.CmbSupplier.Location = New System.Drawing.Point(468, 363)
        Me.CmbSupplier.Name = "CmbSupplier"
        Me.CmbSupplier.Size = New System.Drawing.Size(322, 24)
        Me.CmbSupplier.TabIndex = 33
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1227, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 25)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "X"
        '
        'ITAssetAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 1175)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.CmbSupplier)
        Me.Controls.Add(Me.dtpWarrantyEndDate)
        Me.Controls.Add(Me.dtpAssetDateAquire)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEditUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.picQRCode)
        Me.Controls.Add(Me.cmbAvailabilityStatus)
        Me.Controls.Add(Me.CMBSourceofAcquisition)
        Me.Controls.Add(Me.cmbCondition)
        Me.Controls.Add(Me.txtAssetModel)
        Me.Controls.Add(Me.txtSerialNo)
        Me.Controls.Add(Me.txtAssetColor)
        Me.Controls.Add(Me.txtAssetBrand)
        Me.Controls.Add(Me.txtAssetName)
        Me.Controls.Add(Me.txtAssetCode)
        Me.Controls.Add(Me.cmbSubClassification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ITAssetAddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITAssetAddForm"
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbSubClassification As ComboBox
    Friend WithEvents txtAssetCode As TextBox
    Friend WithEvents txtAssetName As TextBox
    Friend WithEvents txtAssetBrand As TextBox
    Friend WithEvents txtAssetColor As TextBox
    Friend WithEvents txtSerialNo As TextBox
    Friend WithEvents txtAssetModel As TextBox
    Friend WithEvents cmbCondition As ComboBox
    Friend WithEvents CMBSourceofAcquisition As ComboBox
    Friend WithEvents cmbAvailabilityStatus As ComboBox
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEditUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpAssetDateAquire As DateTimePicker
    Friend WithEvents dtpWarrantyEndDate As DateTimePicker
    Friend WithEvents CmbSupplier As ComboBox
    Friend WithEvents btnClose As Label
End Class
