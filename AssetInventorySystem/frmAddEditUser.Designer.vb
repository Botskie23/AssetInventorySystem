<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEditUser
    Inherits System.Windows.Forms.Form

    'Dispose method...
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtExtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbApprovalStatus = New System.Windows.Forms.ComboBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtComID = New System.Windows.Forms.TextBox()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(30, 30)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(250, 30)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(200, 22)
        Me.txtMiddleName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(470, 30)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(200, 22)
        Me.txtLastName.TabIndex = 2
        '
        'txtExtName
        '
        Me.txtExtName.Location = New System.Drawing.Point(690, 30)
        Me.txtExtName.Name = "txtExtName"
        Me.txtExtName.Size = New System.Drawing.Size(60, 22)
        Me.txtExtName.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(30, 70)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(300, 22)
        Me.txtEmail.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(350, 70)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 22)
        Me.txtUsername.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(570, 70)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(180, 22)
        Me.txtPassword.TabIndex = 6
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(30, 110)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 22)
        Me.txtPhoneNumber.TabIndex = 7
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Location = New System.Drawing.Point(250, 110)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(200, 24)
        Me.cmbDepartment.TabIndex = 8
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(470, 110)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(200, 22)
        Me.txtDesignation.TabIndex = 9
        '
        'cmbUserType
        '
        Me.cmbUserType.Location = New System.Drawing.Point(690, 110)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(120, 24)
        Me.cmbUserType.TabIndex = 10
        '
        'cmbStatus
        '
        Me.cmbStatus.Location = New System.Drawing.Point(30, 150)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(120, 24)
        Me.cmbStatus.TabIndex = 11
        '
        'cmbApprovalStatus
        '
        Me.cmbApprovalStatus.Location = New System.Drawing.Point(170, 150)
        Me.cmbApprovalStatus.Name = "cmbApprovalStatus"
        Me.cmbApprovalStatus.Size = New System.Drawing.Size(150, 24)
        Me.cmbApprovalStatus.TabIndex = 12
        '
        'picProfile
        '
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(830, 30)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(120, 120)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 13
        Me.picProfile.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(830, 160)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(120, 25)
        Me.btnUpload.TabIndex = 14
        Me.btnUpload.Text = "Upload Photo"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(30, 190)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 30)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(250, 190)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 30)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.ColumnHeadersHeight = 29
        Me.dgvUsers.Location = New System.Drawing.Point(30, 240)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(920, 250)
        Me.dgvUsers.TabIndex = 18
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(30, 500)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 22)
        Me.txtSearch.TabIndex = 19
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(350, 190)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 30)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(140, 190)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 30)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "Edit"
        '
        'txtComID
        '
        Me.txtComID.Location = New System.Drawing.Point(30, 2)
        Me.txtComID.Name = "txtComID"
        Me.txtComID.Size = New System.Drawing.Size(200, 22)
        Me.txtComID.TabIndex = 21
        '
        'frmAddEditUser
        '
        Me.ClientSize = New System.Drawing.Size(1000, 550)
        Me.Controls.Add(Me.txtComID)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtExtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbApprovalStatus)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "frmAddEditUser"
        Me.Text = "Add/Edit User (Admin Only)"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtExtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbApprovalStatus As ComboBox
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtComID As TextBox
End Class
