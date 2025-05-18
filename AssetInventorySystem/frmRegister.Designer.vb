<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtExtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.btnUploadPic = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.txtComIDNum = New System.Windows.Forms.TextBox()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(54, 28)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(325, 58)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "User Registration"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(46, 238)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(223, 37)
        Me.txtFirstName.TabIndex = 1
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtMiddleName.Location = New System.Drawing.Point(277, 238)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(223, 37)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtLastName.Location = New System.Drawing.Point(506, 238)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(223, 37)
        Me.txtLastName.TabIndex = 3
        '
        'txtExtName
        '
        Me.txtExtName.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtExtName.Location = New System.Drawing.Point(737, 238)
        Me.txtExtName.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtExtName.Name = "txtExtName"
        Me.txtExtName.Size = New System.Drawing.Size(223, 37)
        Me.txtExtName.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(47, 309)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(451, 37)
        Me.txtEmail.TabIndex = 5
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtUserName.Location = New System.Drawing.Point(46, 456)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(223, 37)
        Me.txtUserName.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(274, 456)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(223, 37)
        Me.txtPassword.TabIndex = 11
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(508, 456)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(223, 37)
        Me.txtConfirmPassword.TabIndex = 12
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtPhoneNumber.Location = New System.Drawing.Point(506, 309)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(223, 37)
        Me.txtPhoneNumber.TabIndex = 6
        '
        'cmbUserType
        '
        Me.cmbUserType.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Admin", "Technician", "Employee", "Manager", "IT Support"})
        Me.cmbUserType.Location = New System.Drawing.Point(52, 155)
        Me.cmbUserType.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(246, 38)
        Me.cmbUserType.TabIndex = 0
        '
        'picProfile
        '
        Me.picProfile.Location = New System.Drawing.Point(751, 289)
        Me.picProfile.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(187, 170)
        Me.picProfile.TabIndex = 12
        Me.picProfile.TabStop = False
        '
        'btnUploadPic
        '
        Me.btnUploadPic.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPic.Location = New System.Drawing.Point(751, 466)
        Me.btnUploadPic.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnUploadPic.Name = "btnUploadPic"
        Me.btnUploadPic.Size = New System.Drawing.Size(187, 30)
        Me.btnUploadPic.TabIndex = 13
        Me.btnUploadPic.Text = "Upload Picture"
        Me.btnUploadPic.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(540, 534)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(200, 53)
        Me.btnRegister.TabIndex = 14
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(744, 534)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(194, 51)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 211)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 26)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 211)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 211)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 26)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(737, 211)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 26)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Ext. Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 127)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "User Type:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 284)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(508, 284)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 26)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Contact Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 352)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 26)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Designation"
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtDesignation.Location = New System.Drawing.Point(46, 377)
        Me.txtDesignation.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(223, 37)
        Me.txtDesignation.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(284, 352)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 26)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Department"
        '
        'txtDepartment
        '
        Me.txtDepartment.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtDepartment.Location = New System.Drawing.Point(277, 377)
        Me.txtDepartment.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(223, 37)
        Me.txtDepartment.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(55, 432)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 26)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "User Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(284, 432)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 26)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(508, 432)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 26)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Confirm Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(508, 353)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 26)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Company ID #:"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel1.Controls.Add(Me.btnClose)
        Me.Guna2Panel1.Controls.Add(Me.lblTitle)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1007, 100)
        Me.Guna2Panel1.TabIndex = 32
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(968, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 36)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        '
        'txtComIDNum
        '
        Me.txtComIDNum.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtComIDNum.Location = New System.Drawing.Point(506, 377)
        Me.txtComIDNum.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtComIDNum.Name = "txtComIDNum"
        Me.txtComIDNum.Size = New System.Drawing.Size(223, 37)
        Me.txtComIDNum.TabIndex = 9
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 620)
        Me.Controls.Add(Me.txtComIDNum)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnUploadPic)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtExtName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegister"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtExtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnUploadPic As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose As Label
    Friend WithEvents txtComIDNum As TextBox
End Class
