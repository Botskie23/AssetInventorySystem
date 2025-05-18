<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssetAssignment
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
        Me.cmbAssetCode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEmployeeID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMainLocation = New System.Windows.Forms.ComboBox()
        Me.btnSaveAssignment = New System.Windows.Forms.Button()
        Me.cmbSubLocation = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAvailabilityStatus = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAssetName = New System.Windows.Forms.TextBox()
        Me.dgvAssetAssignments = New System.Windows.Forms.DataGridView()
        Me.txtDateAssigned = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvAssetAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAssetCode
        '
        Me.cmbAssetCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAssetCode.FormattingEnabled = True
        Me.cmbAssetCode.Location = New System.Drawing.Point(141, 344)
        Me.cmbAssetCode.Name = "cmbAssetCode"
        Me.cmbAssetCode.Size = New System.Drawing.Size(257, 24)
        Me.cmbAssetCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Asset Code:"
        '
        'cmbEmployeeID
        '
        Me.cmbEmployeeID.FormattingEnabled = True
        Me.cmbEmployeeID.Location = New System.Drawing.Point(141, 23)
        Me.cmbEmployeeID.Name = "cmbEmployeeID"
        Me.cmbEmployeeID.Size = New System.Drawing.Size(257, 24)
        Me.cmbEmployeeID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employee ID:"
        '
        'cmbMainLocation
        '
        Me.cmbMainLocation.FormattingEnabled = True
        Me.cmbMainLocation.Location = New System.Drawing.Point(141, 228)
        Me.cmbMainLocation.Name = "cmbMainLocation"
        Me.cmbMainLocation.Size = New System.Drawing.Size(257, 24)
        Me.cmbMainLocation.TabIndex = 6
        '
        'btnSaveAssignment
        '
        Me.btnSaveAssignment.Location = New System.Drawing.Point(223, 506)
        Me.btnSaveAssignment.Name = "btnSaveAssignment"
        Me.btnSaveAssignment.Size = New System.Drawing.Size(107, 50)
        Me.btnSaveAssignment.TabIndex = 8
        Me.btnSaveAssignment.Text = "Assign"
        Me.btnSaveAssignment.UseVisualStyleBackColor = True
        '
        'cmbSubLocation
        '
        Me.cmbSubLocation.FormattingEnabled = True
        Me.cmbSubLocation.Location = New System.Drawing.Point(141, 266)
        Me.cmbSubLocation.Name = "cmbSubLocation"
        Me.cmbSubLocation.Size = New System.Drawing.Size(257, 24)
        Me.cmbSubLocation.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Branch"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(141, 63)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.ReadOnly = True
        Me.txtEmployeeName.Size = New System.Drawing.Size(255, 27)
        Me.txtEmployeeName.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Employee Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Designation:"
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.Location = New System.Drawing.Point(141, 96)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(255, 27)
        Me.txtDesignation.TabIndex = 15
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(70, 162)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(65, 16)
        Me.label10.TabIndex = 18
        Me.label10.Text = "Contact #:"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(141, 162)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.ReadOnly = True
        Me.txtContactNumber.Size = New System.Drawing.Size(255, 27)
        Me.txtContactNumber.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Department:"
        '
        'txtDepartment
        '
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(141, 129)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(255, 27)
        Me.txtDepartment.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 440)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Date Assigned:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 407)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Availability Status:"
        '
        'txtAvailabilityStatus
        '
        Me.txtAvailabilityStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailabilityStatus.Location = New System.Drawing.Point(141, 407)
        Me.txtAvailabilityStatus.Name = "txtAvailabilityStatus"
        Me.txtAvailabilityStatus.ReadOnly = True
        Me.txtAvailabilityStatus.Size = New System.Drawing.Size(257, 27)
        Me.txtAvailabilityStatus.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 374)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Asset Name:"
        '
        'txtAssetName
        '
        Me.txtAssetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssetName.Location = New System.Drawing.Point(141, 374)
        Me.txtAssetName.Name = "txtAssetName"
        Me.txtAssetName.ReadOnly = True
        Me.txtAssetName.Size = New System.Drawing.Size(257, 27)
        Me.txtAssetName.TabIndex = 21
        '
        'dgvAssetAssignments
        '
        Me.dgvAssetAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssetAssignments.Location = New System.Drawing.Point(410, 22)
        Me.dgvAssetAssignments.Name = "dgvAssetAssignments"
        Me.dgvAssetAssignments.RowHeadersWidth = 51
        Me.dgvAssetAssignments.RowTemplate.Height = 24
        Me.dgvAssetAssignments.Size = New System.Drawing.Size(712, 455)
        Me.dgvAssetAssignments.TabIndex = 27
        '
        'txtDateAssigned
        '
        Me.txtDateAssigned.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateAssigned.Location = New System.Drawing.Point(141, 446)
        Me.txtDateAssigned.Name = "txtDateAssigned"
        Me.txtDateAssigned.Size = New System.Drawing.Size(255, 22)
        Me.txtDateAssigned.TabIndex = 28
        '
        'frmAssetAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 575)
        Me.Controls.Add(Me.txtDateAssigned)
        Me.Controls.Add(Me.dgvAssetAssignments)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtAvailabilityStatus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAssetName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSubLocation)
        Me.Controls.Add(Me.btnSaveAssignment)
        Me.Controls.Add(Me.cmbMainLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbEmployeeID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAssetCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAssetAssignment"
        Me.Text = "frmAssetAssignment"
        CType(Me.dgvAssetAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAssetCode As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEmployeeID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMainLocation As ComboBox
    Friend WithEvents btnSaveAssignment As Button
    Friend WithEvents cmbSubLocation As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents label10 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAvailabilityStatus As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAssetName As TextBox
    Friend WithEvents dgvAssetAssignments As DataGridView
    Friend WithEvents txtDateAssigned As DateTimePicker
End Class
