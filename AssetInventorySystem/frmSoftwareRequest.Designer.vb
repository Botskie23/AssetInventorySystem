<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftwareRequest
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
        Me.txtSoftwareName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSoftwareName = New System.Windows.Forms.Label()
        Me.lblJustification = New System.Windows.Forms.Label()
        Me.txtJustification = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMainLocation = New System.Windows.Forms.Label()
        Me.cmbMainLocation = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblRequestedBy = New System.Windows.Forms.Label()
        Me.txtRequestedByName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRequestDate = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.btnSubmitRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbSubLocation = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cmbRequestType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoftwareName.DefaultText = ""
        Me.txtSoftwareName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSoftwareName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSoftwareName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSoftwareName.DisabledState.Parent = Me.txtSoftwareName
        Me.txtSoftwareName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSoftwareName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSoftwareName.FocusedState.Parent = Me.txtSoftwareName
        Me.txtSoftwareName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSoftwareName.HoverState.Parent = Me.txtSoftwareName
        Me.txtSoftwareName.Location = New System.Drawing.Point(225, 37)
        Me.txtSoftwareName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSoftwareName.PlaceholderText = ""
        Me.txtSoftwareName.SelectedText = ""
        Me.txtSoftwareName.ShadowDecoration.Parent = Me.txtSoftwareName
        Me.txtSoftwareName.Size = New System.Drawing.Size(300, 45)
        Me.txtSoftwareName.TabIndex = 0
        '
        'lblSoftwareName
        '
        Me.lblSoftwareName.AutoSize = True
        Me.lblSoftwareName.Location = New System.Drawing.Point(49, 41)
        Me.lblSoftwareName.Name = "lblSoftwareName"
        Me.lblSoftwareName.Size = New System.Drawing.Size(102, 16)
        Me.lblSoftwareName.TabIndex = 1
        Me.lblSoftwareName.Text = "Software Name:"
        '
        'lblJustification
        '
        Me.lblJustification.AutoSize = True
        Me.lblJustification.Location = New System.Drawing.Point(49, 355)
        Me.lblJustification.Name = "lblJustification"
        Me.lblJustification.Size = New System.Drawing.Size(79, 16)
        Me.lblJustification.TabIndex = 3
        Me.lblJustification.Text = "Justification:"
        '
        'txtJustification
        '
        Me.txtJustification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJustification.DefaultText = ""
        Me.txtJustification.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtJustification.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtJustification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJustification.DisabledState.Parent = Me.txtJustification
        Me.txtJustification.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJustification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJustification.FocusedState.Parent = Me.txtJustification
        Me.txtJustification.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJustification.HoverState.Parent = Me.txtJustification
        Me.txtJustification.Location = New System.Drawing.Point(225, 351)
        Me.txtJustification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJustification.Multiline = True
        Me.txtJustification.Name = "txtJustification"
        Me.txtJustification.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJustification.PlaceholderText = ""
        Me.txtJustification.SelectedText = ""
        Me.txtJustification.ShadowDecoration.Parent = Me.txtJustification
        Me.txtJustification.Size = New System.Drawing.Size(300, 100)
        Me.txtJustification.TabIndex = 2
        '
        'lblMainLocation
        '
        Me.lblMainLocation.AutoSize = True
        Me.lblMainLocation.Location = New System.Drawing.Point(45, 88)
        Me.lblMainLocation.Name = "lblMainLocation"
        Me.lblMainLocation.Size = New System.Drawing.Size(93, 16)
        Me.lblMainLocation.TabIndex = 5
        Me.lblMainLocation.Text = "Main Location:"
        '
        'cmbMainLocation
        '
        Me.cmbMainLocation.BackColor = System.Drawing.Color.Transparent
        Me.cmbMainLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMainLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMainLocation.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMainLocation.FocusedState.Parent = Me.cmbMainLocation
        Me.cmbMainLocation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMainLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMainLocation.FormattingEnabled = True
        Me.cmbMainLocation.HoverState.Parent = Me.cmbMainLocation
        Me.cmbMainLocation.ItemHeight = 30
        Me.cmbMainLocation.ItemsAppearance.Parent = Me.cmbMainLocation
        Me.cmbMainLocation.Location = New System.Drawing.Point(225, 89)
        Me.cmbMainLocation.Name = "cmbMainLocation"
        Me.cmbMainLocation.ShadowDecoration.Parent = Me.cmbMainLocation
        Me.cmbMainLocation.Size = New System.Drawing.Size(295, 36)
        Me.cmbMainLocation.TabIndex = 6
        '
        'lblRequestedBy
        '
        Me.lblRequestedBy.AutoSize = True
        Me.lblRequestedBy.Location = New System.Drawing.Point(49, 268)
        Me.lblRequestedBy.Name = "lblRequestedBy"
        Me.lblRequestedBy.Size = New System.Drawing.Size(96, 16)
        Me.lblRequestedBy.TabIndex = 8
        Me.lblRequestedBy.Text = "Requested By:"
        '
        'txtRequestedByName
        '
        Me.txtRequestedByName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRequestedByName.DefaultText = ""
        Me.txtRequestedByName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRequestedByName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRequestedByName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRequestedByName.DisabledState.Parent = Me.txtRequestedByName
        Me.txtRequestedByName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRequestedByName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRequestedByName.FocusedState.Parent = Me.txtRequestedByName
        Me.txtRequestedByName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRequestedByName.HoverState.Parent = Me.txtRequestedByName
        Me.txtRequestedByName.Location = New System.Drawing.Point(225, 264)
        Me.txtRequestedByName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRequestedByName.Name = "txtRequestedByName"
        Me.txtRequestedByName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRequestedByName.PlaceholderText = ""
        Me.txtRequestedByName.ReadOnly = True
        Me.txtRequestedByName.SelectedText = ""
        Me.txtRequestedByName.ShadowDecoration.Parent = Me.txtRequestedByName
        Me.txtRequestedByName.Size = New System.Drawing.Size(300, 45)
        Me.txtRequestedByName.TabIndex = 7
        '
        'lblRequestDate
        '
        Me.lblRequestDate.AutoSize = True
        Me.lblRequestDate.Location = New System.Drawing.Point(49, 321)
        Me.lblRequestDate.Name = "lblRequestDate"
        Me.lblRequestDate.Size = New System.Drawing.Size(93, 16)
        Me.lblRequestDate.TabIndex = 10
        Me.lblRequestDate.Text = "Request Date:"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Location = New System.Drawing.Point(222, 321)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(159, 16)
        Me.lblCurrentDate.TabIndex = 11
        Me.lblCurrentDate.Text = "DateTime.Now.ToString()"
        '
        'btnSubmitRequest
        '
        Me.btnSubmitRequest.CheckedState.Parent = Me.btnSubmitRequest
        Me.btnSubmitRequest.CustomImages.Parent = Me.btnSubmitRequest
        Me.btnSubmitRequest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmitRequest.ForeColor = System.Drawing.Color.White
        Me.btnSubmitRequest.HoverState.Parent = Me.btnSubmitRequest
        Me.btnSubmitRequest.Location = New System.Drawing.Point(82, 481)
        Me.btnSubmitRequest.Name = "btnSubmitRequest"
        Me.btnSubmitRequest.ShadowDecoration.Parent = Me.btnSubmitRequest
        Me.btnSubmitRequest.Size = New System.Drawing.Size(143, 34)
        Me.btnSubmitRequest.TabIndex = 12
        Me.btnSubmitRequest.Text = "Submit Request"
        '
        'btnClear
        '
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(242, 481)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(143, 34)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        '
        'cmbSubLocation
        '
        Me.cmbSubLocation.BackColor = System.Drawing.Color.Transparent
        Me.cmbSubLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSubLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubLocation.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSubLocation.FocusedState.Parent = Me.cmbSubLocation
        Me.cmbSubLocation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSubLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSubLocation.FormattingEnabled = True
        Me.cmbSubLocation.HoverState.Parent = Me.cmbSubLocation
        Me.cmbSubLocation.ItemHeight = 30
        Me.cmbSubLocation.ItemsAppearance.Parent = Me.cmbSubLocation
        Me.cmbSubLocation.Location = New System.Drawing.Point(225, 131)
        Me.cmbSubLocation.Name = "cmbSubLocation"
        Me.cmbSubLocation.ShadowDecoration.Parent = Me.cmbSubLocation
        Me.cmbSubLocation.Size = New System.Drawing.Size(295, 36)
        Me.cmbSubLocation.TabIndex = 15
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(45, 130)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(80, 16)
        Me.lblDepartment.TabIndex = 14
        Me.lblDepartment.Text = "Department:"
        '
        'cmbRequestType
        '
        Me.cmbRequestType.BackColor = System.Drawing.Color.Transparent
        Me.cmbRequestType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRequestType.FocusedColor = System.Drawing.Color.Empty
        Me.cmbRequestType.FocusedState.Parent = Me.cmbRequestType
        Me.cmbRequestType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbRequestType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbRequestType.FormattingEnabled = True
        Me.cmbRequestType.HoverState.Parent = Me.cmbRequestType
        Me.cmbRequestType.ItemHeight = 30
        Me.cmbRequestType.ItemsAppearance.Parent = Me.cmbRequestType
        Me.cmbRequestType.Location = New System.Drawing.Point(225, 173)
        Me.cmbRequestType.Name = "cmbRequestType"
        Me.cmbRequestType.ShadowDecoration.Parent = Me.cmbRequestType
        Me.cmbRequestType.Size = New System.Drawing.Size(295, 36)
        Me.cmbRequestType.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Request Type:"
        '
        'frmSoftwareRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 536)
        Me.Controls.Add(Me.cmbRequestType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSubLocation)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmitRequest)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblRequestDate)
        Me.Controls.Add(Me.lblRequestedBy)
        Me.Controls.Add(Me.txtRequestedByName)
        Me.Controls.Add(Me.cmbMainLocation)
        Me.Controls.Add(Me.lblMainLocation)
        Me.Controls.Add(Me.lblJustification)
        Me.Controls.Add(Me.txtJustification)
        Me.Controls.Add(Me.lblSoftwareName)
        Me.Controls.Add(Me.txtSoftwareName)
        Me.Name = "frmSoftwareRequest"
        Me.Text = "frmSoftwareRequest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSoftwareName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSoftwareName As Label
    Friend WithEvents lblJustification As Label
    Friend WithEvents txtJustification As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMainLocation As Label
    Friend WithEvents cmbMainLocation As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblRequestedBy As Label
    Friend WithEvents txtRequestedByName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRequestDate As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents btnSubmitRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbSubLocation As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents cmbRequestType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
End Class
