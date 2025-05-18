<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAISMainDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAISMainDashboard))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.picUserProfile = New System.Windows.Forms.PictureBox()
        Me.lblUserDesignation = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.pnlMainMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlDashboardButtons = New Guna.UI2.WinForms.Guna2Panel()
        Me.btndashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssets = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlAssetsButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRepairEvaluation = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssetsEvaluation = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssetAssignment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRepairRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssetDisposal = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssetList = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssetReturn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSoftware = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlSoftwareButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.BTNSoftwareList = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSoftwareRequestList = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSoftwareAssignment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSoftwareRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRequests = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlRequestsButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAssetRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUserApproval = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssetRequestApproval = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlUsersButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnUserInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAccountManagement = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlReportsButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnShowReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlSettingsButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSystemConfiguration = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlView = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictLogout = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picUserProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMainMenu.SuspendLayout()
        Me.pnlDashboardButtons.SuspendLayout()
        Me.pnlAssetsButtons.SuspendLayout()
        Me.pnlSoftwareButtons.SuspendLayout()
        Me.pnlRequestsButtons.SuspendLayout()
        Me.pnlUsersButtons.SuspendLayout()
        Me.pnlReportsButtons.SuspendLayout()
        Me.pnlSettingsButtons.SuspendLayout()
        CType(Me.PictLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(144, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(679, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Asset Inventory Management System"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.Label3)
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Controls.Add(Me.PictLogout)
        Me.pnlHeader.Controls.Add(Me.picUserProfile)
        Me.pnlHeader.Controls.Add(Me.lblUserDesignation)
        Me.pnlHeader.Controls.Add(Me.lblWelcome)
        Me.pnlHeader.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.lblUserName)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.ShadowDecoration.Parent = Me.pnlHeader
        Me.pnlHeader.Size = New System.Drawing.Size(1500, 147)
        Me.pnlHeader.TabIndex = 9
        '
        'picUserProfile
        '
        Me.picUserProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picUserProfile.Location = New System.Drawing.Point(1029, 25)
        Me.picUserProfile.Name = "picUserProfile"
        Me.picUserProfile.Size = New System.Drawing.Size(80, 80)
        Me.picUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUserProfile.TabIndex = 17
        Me.picUserProfile.TabStop = False
        '
        'lblUserDesignation
        '
        Me.lblUserDesignation.AutoSize = True
        Me.lblUserDesignation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUserDesignation.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDesignation.ForeColor = System.Drawing.Color.White
        Me.lblUserDesignation.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblUserDesignation.Location = New System.Drawing.Point(1125, 73)
        Me.lblUserDesignation.Name = "lblUserDesignation"
        Me.lblUserDesignation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUserDesignation.Size = New System.Drawing.Size(60, 26)
        Me.lblUserDesignation.TabIndex = 16
        Me.lblUserDesignation.Text = "Label2"
        Me.lblUserDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWelcome.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(1215, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(110, 36)
        Me.lblWelcome.TabIndex = 11
        Me.lblWelcome.Text = "Welcome"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(129, 129)
        Me.Guna2PictureBox1.TabIndex = 15
        Me.Guna2PictureBox1.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUserName.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblUserName.Location = New System.Drawing.Point(1125, 45)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUserName.Size = New System.Drawing.Size(60, 26)
        Me.lblUserName.TabIndex = 14
        Me.lblUserName.Text = "Label2"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlMainMenu.Controls.Add(Me.pnlDashboardButtons)
        Me.pnlMainMenu.Controls.Add(Me.btnAssets)
        Me.pnlMainMenu.Controls.Add(Me.pnlAssetsButtons)
        Me.pnlMainMenu.Controls.Add(Me.btnSoftware)
        Me.pnlMainMenu.Controls.Add(Me.pnlSoftwareButtons)
        Me.pnlMainMenu.Controls.Add(Me.btnRequests)
        Me.pnlMainMenu.Controls.Add(Me.pnlRequestsButtons)
        Me.pnlMainMenu.Controls.Add(Me.btnUsers)
        Me.pnlMainMenu.Controls.Add(Me.pnlUsersButtons)
        Me.pnlMainMenu.Controls.Add(Me.btnReports)
        Me.pnlMainMenu.Controls.Add(Me.pnlReportsButtons)
        Me.pnlMainMenu.Controls.Add(Me.btnSettings)
        Me.pnlMainMenu.Controls.Add(Me.pnlSettingsButtons)
        Me.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMainMenu.Location = New System.Drawing.Point(0, 147)
        Me.pnlMainMenu.Name = "pnlMainMenu"
        Me.pnlMainMenu.Size = New System.Drawing.Size(262, 1075)
        Me.pnlMainMenu.TabIndex = 0
        '
        'pnlDashboardButtons
        '
        Me.pnlDashboardButtons.AutoSize = True
        Me.pnlDashboardButtons.Controls.Add(Me.btndashboard)
        Me.pnlDashboardButtons.Location = New System.Drawing.Point(3, 3)
        Me.pnlDashboardButtons.Name = "pnlDashboardButtons"
        Me.pnlDashboardButtons.ShadowDecoration.Parent = Me.pnlDashboardButtons
        Me.pnlDashboardButtons.Size = New System.Drawing.Size(267, 66)
        Me.pnlDashboardButtons.TabIndex = 64
        '
        'btndashboard
        '
        Me.btndashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndashboard.CheckedState.Parent = Me.btndashboard
        Me.btndashboard.CustomImages.Parent = Me.btndashboard
        Me.btndashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btndashboard.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.ForeColor = System.Drawing.Color.White
        Me.btndashboard.HoverState.Parent = Me.btndashboard
        Me.btndashboard.Image = CType(resources.GetObject("btndashboard.Image"), System.Drawing.Image)
        Me.btndashboard.ImageSize = New System.Drawing.Size(40, 40)
        Me.btndashboard.Location = New System.Drawing.Point(6, 6)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.ShadowDecoration.Parent = Me.btndashboard
        Me.btndashboard.Size = New System.Drawing.Size(258, 57)
        Me.btndashboard.TabIndex = 0
        Me.btndashboard.Text = "Dashboard"
        '
        'btnAssets
        '
        Me.btnAssets.BorderColor = System.Drawing.Color.Transparent
        Me.btnAssets.BorderRadius = 3
        Me.btnAssets.CheckedState.Parent = Me.btnAssets
        Me.btnAssets.CustomImages.Parent = Me.btnAssets
        Me.btnAssets.FillColor = System.Drawing.Color.Transparent
        Me.btnAssets.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssets.ForeColor = System.Drawing.Color.White
        Me.btnAssets.HoverState.Parent = Me.btnAssets
        Me.btnAssets.Image = CType(resources.GetObject("btnAssets.Image"), System.Drawing.Image)
        Me.btnAssets.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssets.Location = New System.Drawing.Point(1, 73)
        Me.btnAssets.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAssets.Name = "btnAssets"
        Me.btnAssets.ShadowDecoration.Parent = Me.btnAssets
        Me.btnAssets.Size = New System.Drawing.Size(258, 40)
        Me.btnAssets.TabIndex = 65
        Me.btnAssets.Text = " Assets"
        Me.btnAssets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlAssetsButtons
        '
        Me.pnlAssetsButtons.AutoSize = True
        Me.pnlAssetsButtons.BackColor = System.Drawing.Color.Navy
        Me.pnlAssetsButtons.Controls.Add(Me.btnRepairEvaluation)
        Me.pnlAssetsButtons.Controls.Add(Me.btnAssetsEvaluation)
        Me.pnlAssetsButtons.Controls.Add(Me.btnAssetAssignment)
        Me.pnlAssetsButtons.Controls.Add(Me.btnRepairRequest)
        Me.pnlAssetsButtons.Controls.Add(Me.btnAssetDisposal)
        Me.pnlAssetsButtons.Controls.Add(Me.btnAssetList)
        Me.pnlAssetsButtons.Controls.Add(Me.btnAssetReturn)
        Me.pnlAssetsButtons.Location = New System.Drawing.Point(3, 117)
        Me.pnlAssetsButtons.Name = "pnlAssetsButtons"
        Me.pnlAssetsButtons.Size = New System.Drawing.Size(259, 222)
        Me.pnlAssetsButtons.TabIndex = 63
        '
        'btnRepairEvaluation
        '
        Me.btnRepairEvaluation.BorderColor = System.Drawing.Color.Transparent
        Me.btnRepairEvaluation.BorderRadius = 3
        Me.btnRepairEvaluation.CheckedState.Parent = Me.btnRepairEvaluation
        Me.btnRepairEvaluation.CustomImages.Parent = Me.btnRepairEvaluation
        Me.btnRepairEvaluation.FillColor = System.Drawing.Color.Transparent
        Me.btnRepairEvaluation.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepairEvaluation.ForeColor = System.Drawing.Color.White
        Me.btnRepairEvaluation.HoverState.Parent = Me.btnRepairEvaluation
        Me.btnRepairEvaluation.Image = Global.AssetInventorySystem.My.Resources.Resources.icons8_return_30
        Me.btnRepairEvaluation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnRepairEvaluation.Location = New System.Drawing.Point(3, 3)
        Me.btnRepairEvaluation.Name = "btnRepairEvaluation"
        Me.btnRepairEvaluation.ShadowDecoration.Parent = Me.btnRepairEvaluation
        Me.btnRepairEvaluation.Size = New System.Drawing.Size(253, 28)
        Me.btnRepairEvaluation.TabIndex = 26
        Me.btnRepairEvaluation.Text = "Repair Evaluation"
        Me.btnRepairEvaluation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnRepairEvaluation.Visible = False
        '
        'btnAssetsEvaluation
        '
        Me.btnAssetsEvaluation.BorderColor = System.Drawing.Color.Transparent
        Me.btnAssetsEvaluation.BorderRadius = 1
        Me.btnAssetsEvaluation.CheckedState.Parent = Me.btnAssetsEvaluation
        Me.btnAssetsEvaluation.CustomImages.Parent = Me.btnAssetsEvaluation
        Me.btnAssetsEvaluation.FillColor = System.Drawing.Color.Transparent
        Me.btnAssetsEvaluation.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssetsEvaluation.ForeColor = System.Drawing.Color.White
        Me.btnAssetsEvaluation.HoverState.Parent = Me.btnAssetsEvaluation
        Me.btnAssetsEvaluation.Image = CType(resources.GetObject("btnAssetsEvaluation.Image"), System.Drawing.Image)
        Me.btnAssetsEvaluation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetsEvaluation.Location = New System.Drawing.Point(3, 37)
        Me.btnAssetsEvaluation.Name = "btnAssetsEvaluation"
        Me.btnAssetsEvaluation.ShadowDecoration.Parent = Me.btnAssetsEvaluation
        Me.btnAssetsEvaluation.Size = New System.Drawing.Size(253, 28)
        Me.btnAssetsEvaluation.TabIndex = 24
        Me.btnAssetsEvaluation.Text = " Asset Evaluation"
        Me.btnAssetsEvaluation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetsEvaluation.Visible = False
        '
        'btnAssetAssignment
        '
        Me.btnAssetAssignment.BorderColor = System.Drawing.Color.Transparent
        Me.btnAssetAssignment.BorderRadius = 3
        Me.btnAssetAssignment.CheckedState.Parent = Me.btnAssetAssignment
        Me.btnAssetAssignment.CustomImages.Parent = Me.btnAssetAssignment
        Me.btnAssetAssignment.FillColor = System.Drawing.Color.Transparent
        Me.btnAssetAssignment.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssetAssignment.ForeColor = System.Drawing.Color.White
        Me.btnAssetAssignment.HoverState.Parent = Me.btnAssetAssignment
        Me.btnAssetAssignment.Image = CType(resources.GetObject("btnAssetAssignment.Image"), System.Drawing.Image)
        Me.btnAssetAssignment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetAssignment.Location = New System.Drawing.Point(1, 69)
        Me.btnAssetAssignment.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAssetAssignment.Name = "btnAssetAssignment"
        Me.btnAssetAssignment.ShadowDecoration.Parent = Me.btnAssetAssignment
        Me.btnAssetAssignment.Size = New System.Drawing.Size(253, 28)
        Me.btnAssetAssignment.TabIndex = 21
        Me.btnAssetAssignment.Text = " Asset Assignment "
        Me.btnAssetAssignment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetAssignment.Visible = False
        '
        'btnRepairRequest
        '
        Me.btnRepairRequest.BorderColor = System.Drawing.Color.Transparent
        Me.btnRepairRequest.BorderRadius = 1
        Me.btnRepairRequest.CheckedState.Parent = Me.btnRepairRequest
        Me.btnRepairRequest.CustomImages.Parent = Me.btnRepairRequest
        Me.btnRepairRequest.FillColor = System.Drawing.Color.Transparent
        Me.btnRepairRequest.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepairRequest.ForeColor = System.Drawing.Color.White
        Me.btnRepairRequest.HoverState.Parent = Me.btnRepairRequest
        Me.btnRepairRequest.Image = CType(resources.GetObject("btnRepairRequest.Image"), System.Drawing.Image)
        Me.btnRepairRequest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnRepairRequest.Location = New System.Drawing.Point(1, 99)
        Me.btnRepairRequest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRepairRequest.Name = "btnRepairRequest"
        Me.btnRepairRequest.ShadowDecoration.Parent = Me.btnRepairRequest
        Me.btnRepairRequest.Size = New System.Drawing.Size(253, 28)
        Me.btnRepairRequest.TabIndex = 27
        Me.btnRepairRequest.Text = "Repair Request"
        Me.btnRepairRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnRepairRequest.Visible = False
        '
        'btnAssetDisposal
        '
        Me.btnAssetDisposal.BorderColor = System.Drawing.Color.Transparent
        Me.btnAssetDisposal.BorderRadius = 3
        Me.btnAssetDisposal.CheckedState.Parent = Me.btnAssetDisposal
        Me.btnAssetDisposal.CustomImages.Parent = Me.btnAssetDisposal
        Me.btnAssetDisposal.FillColor = System.Drawing.Color.Transparent
        Me.btnAssetDisposal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssetDisposal.ForeColor = System.Drawing.Color.White
        Me.btnAssetDisposal.HoverState.Parent = Me.btnAssetDisposal
        Me.btnAssetDisposal.Image = CType(resources.GetObject("btnAssetDisposal.Image"), System.Drawing.Image)
        Me.btnAssetDisposal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetDisposal.Location = New System.Drawing.Point(3, 131)
        Me.btnAssetDisposal.Name = "btnAssetDisposal"
        Me.btnAssetDisposal.ShadowDecoration.Parent = Me.btnAssetDisposal
        Me.btnAssetDisposal.Size = New System.Drawing.Size(253, 28)
        Me.btnAssetDisposal.TabIndex = 25
        Me.btnAssetDisposal.Text = "Asset Disposal"
        Me.btnAssetDisposal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetDisposal.Visible = False
        '
        'btnAssetList
        '
        Me.btnAssetList.BorderColor = System.Drawing.Color.Transparent
        Me.btnAssetList.BorderRadius = 3
        Me.btnAssetList.CheckedState.Parent = Me.btnAssetList
        Me.btnAssetList.CustomImages.Parent = Me.btnAssetList
        Me.btnAssetList.FillColor = System.Drawing.Color.Transparent
        Me.btnAssetList.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssetList.ForeColor = System.Drawing.Color.White
        Me.btnAssetList.HoverState.Parent = Me.btnAssetList
        Me.btnAssetList.Image = CType(resources.GetObject("btnAssetList.Image"), System.Drawing.Image)
        Me.btnAssetList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetList.Location = New System.Drawing.Point(1, 163)
        Me.btnAssetList.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAssetList.Name = "btnAssetList"
        Me.btnAssetList.ShadowDecoration.Parent = Me.btnAssetList
        Me.btnAssetList.Size = New System.Drawing.Size(253, 28)
        Me.btnAssetList.TabIndex = 22
        Me.btnAssetList.Text = " Asset List"
        Me.btnAssetList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetList.Visible = False
        '
        'btnAssetReturn
        '
        Me.btnAssetReturn.BorderColor = System.Drawing.Color.Transparent
        Me.btnAssetReturn.BorderRadius = 3
        Me.btnAssetReturn.CheckedState.Parent = Me.btnAssetReturn
        Me.btnAssetReturn.CustomImages.Parent = Me.btnAssetReturn
        Me.btnAssetReturn.FillColor = System.Drawing.Color.Transparent
        Me.btnAssetReturn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssetReturn.ForeColor = System.Drawing.Color.White
        Me.btnAssetReturn.HoverState.Parent = Me.btnAssetReturn
        Me.btnAssetReturn.Image = Global.AssetInventorySystem.My.Resources.Resources.icons8_return_30
        Me.btnAssetReturn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetReturn.Location = New System.Drawing.Point(1, 193)
        Me.btnAssetReturn.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAssetReturn.Name = "btnAssetReturn"
        Me.btnAssetReturn.ShadowDecoration.Parent = Me.btnAssetReturn
        Me.btnAssetReturn.Size = New System.Drawing.Size(253, 28)
        Me.btnAssetReturn.TabIndex = 23
        Me.btnAssetReturn.Text = " Asset Return "
        Me.btnAssetReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetReturn.Visible = False
        '
        'btnSoftware
        '
        Me.btnSoftware.BorderColor = System.Drawing.Color.Transparent
        Me.btnSoftware.BorderRadius = 3
        Me.btnSoftware.CheckedState.Parent = Me.btnSoftware
        Me.btnSoftware.CustomImages.Parent = Me.btnSoftware
        Me.btnSoftware.FillColor = System.Drawing.Color.Transparent
        Me.btnSoftware.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftware.ForeColor = System.Drawing.Color.White
        Me.btnSoftware.HoverState.Parent = Me.btnSoftware
        Me.btnSoftware.Image = CType(resources.GetObject("btnSoftware.Image"), System.Drawing.Image)
        Me.btnSoftware.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSoftware.Location = New System.Drawing.Point(1, 343)
        Me.btnSoftware.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSoftware.Name = "btnSoftware"
        Me.btnSoftware.ShadowDecoration.Parent = Me.btnSoftware
        Me.btnSoftware.Size = New System.Drawing.Size(258, 40)
        Me.btnSoftware.TabIndex = 66
        Me.btnSoftware.Text = "Software"
        Me.btnSoftware.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlSoftwareButtons
        '
        Me.pnlSoftwareButtons.AutoSize = True
        Me.pnlSoftwareButtons.BackColor = System.Drawing.Color.Navy
        Me.pnlSoftwareButtons.Controls.Add(Me.BTNSoftwareList)
        Me.pnlSoftwareButtons.Controls.Add(Me.btnSoftwareRequestList)
        Me.pnlSoftwareButtons.Controls.Add(Me.btnSoftwareAssignment)
        Me.pnlSoftwareButtons.Controls.Add(Me.btnSoftwareRequest)
        Me.pnlSoftwareButtons.Location = New System.Drawing.Point(3, 387)
        Me.pnlSoftwareButtons.Name = "pnlSoftwareButtons"
        Me.pnlSoftwareButtons.Size = New System.Drawing.Size(259, 136)
        Me.pnlSoftwareButtons.TabIndex = 62
        '
        'BTNSoftwareList
        '
        Me.BTNSoftwareList.BorderColor = System.Drawing.Color.Transparent
        Me.BTNSoftwareList.BorderRadius = 1
        Me.BTNSoftwareList.CheckedState.Parent = Me.BTNSoftwareList
        Me.BTNSoftwareList.CustomImages.Parent = Me.BTNSoftwareList
        Me.BTNSoftwareList.FillColor = System.Drawing.Color.Transparent
        Me.BTNSoftwareList.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSoftwareList.ForeColor = System.Drawing.Color.White
        Me.BTNSoftwareList.HoverState.Parent = Me.BTNSoftwareList
        Me.BTNSoftwareList.Image = CType(resources.GetObject("BTNSoftwareList.Image"), System.Drawing.Image)
        Me.BTNSoftwareList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BTNSoftwareList.Location = New System.Drawing.Point(3, 3)
        Me.BTNSoftwareList.Name = "BTNSoftwareList"
        Me.BTNSoftwareList.ShadowDecoration.Parent = Me.BTNSoftwareList
        Me.BTNSoftwareList.Size = New System.Drawing.Size(253, 28)
        Me.BTNSoftwareList.TabIndex = 32
        Me.BTNSoftwareList.Text = "Software List"
        Me.BTNSoftwareList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BTNSoftwareList.Visible = False
        '
        'btnSoftwareRequestList
        '
        Me.btnSoftwareRequestList.BorderColor = System.Drawing.Color.Transparent
        Me.btnSoftwareRequestList.BorderRadius = 1
        Me.btnSoftwareRequestList.CheckedState.Parent = Me.btnSoftwareRequestList
        Me.btnSoftwareRequestList.CustomImages.Parent = Me.btnSoftwareRequestList
        Me.btnSoftwareRequestList.FillColor = System.Drawing.Color.Transparent
        Me.btnSoftwareRequestList.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftwareRequestList.ForeColor = System.Drawing.Color.White
        Me.btnSoftwareRequestList.HoverState.Parent = Me.btnSoftwareRequestList
        Me.btnSoftwareRequestList.Image = CType(resources.GetObject("btnSoftwareRequestList.Image"), System.Drawing.Image)
        Me.btnSoftwareRequestList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSoftwareRequestList.Location = New System.Drawing.Point(3, 37)
        Me.btnSoftwareRequestList.Name = "btnSoftwareRequestList"
        Me.btnSoftwareRequestList.ShadowDecoration.Parent = Me.btnSoftwareRequestList
        Me.btnSoftwareRequestList.Size = New System.Drawing.Size(253, 28)
        Me.btnSoftwareRequestList.TabIndex = 33
        Me.btnSoftwareRequestList.Text = "Software Request List"
        Me.btnSoftwareRequestList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSoftwareRequestList.Visible = False
        '
        'btnSoftwareAssignment
        '
        Me.btnSoftwareAssignment.BorderColor = System.Drawing.Color.Transparent
        Me.btnSoftwareAssignment.BorderRadius = 1
        Me.btnSoftwareAssignment.CheckedState.Parent = Me.btnSoftwareAssignment
        Me.btnSoftwareAssignment.CustomImages.Parent = Me.btnSoftwareAssignment
        Me.btnSoftwareAssignment.FillColor = System.Drawing.Color.Transparent
        Me.btnSoftwareAssignment.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftwareAssignment.ForeColor = System.Drawing.Color.White
        Me.btnSoftwareAssignment.HoverState.Parent = Me.btnSoftwareAssignment
        Me.btnSoftwareAssignment.Image = CType(resources.GetObject("btnSoftwareAssignment.Image"), System.Drawing.Image)
        Me.btnSoftwareAssignment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSoftwareAssignment.Location = New System.Drawing.Point(3, 71)
        Me.btnSoftwareAssignment.Name = "btnSoftwareAssignment"
        Me.btnSoftwareAssignment.ShadowDecoration.Parent = Me.btnSoftwareAssignment
        Me.btnSoftwareAssignment.Size = New System.Drawing.Size(253, 28)
        Me.btnSoftwareAssignment.TabIndex = 31
        Me.btnSoftwareAssignment.Text = "Software Assignment"
        Me.btnSoftwareAssignment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSoftwareAssignment.Visible = False
        '
        'btnSoftwareRequest
        '
        Me.btnSoftwareRequest.BorderColor = System.Drawing.Color.Transparent
        Me.btnSoftwareRequest.BorderRadius = 1
        Me.btnSoftwareRequest.CheckedState.Parent = Me.btnSoftwareRequest
        Me.btnSoftwareRequest.CustomImages.Parent = Me.btnSoftwareRequest
        Me.btnSoftwareRequest.FillColor = System.Drawing.Color.Transparent
        Me.btnSoftwareRequest.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftwareRequest.ForeColor = System.Drawing.Color.White
        Me.btnSoftwareRequest.HoverState.Parent = Me.btnSoftwareRequest
        Me.btnSoftwareRequest.Image = CType(resources.GetObject("btnSoftwareRequest.Image"), System.Drawing.Image)
        Me.btnSoftwareRequest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSoftwareRequest.Location = New System.Drawing.Point(3, 105)
        Me.btnSoftwareRequest.Name = "btnSoftwareRequest"
        Me.btnSoftwareRequest.ShadowDecoration.Parent = Me.btnSoftwareRequest
        Me.btnSoftwareRequest.Size = New System.Drawing.Size(253, 28)
        Me.btnSoftwareRequest.TabIndex = 30
        Me.btnSoftwareRequest.Text = "Software Request"
        Me.btnSoftwareRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSoftwareRequest.Visible = False
        '
        'btnRequests
        '
        Me.btnRequests.BorderColor = System.Drawing.Color.Transparent
        Me.btnRequests.BorderRadius = 3
        Me.btnRequests.CheckedState.Parent = Me.btnRequests
        Me.btnRequests.CustomImages.Parent = Me.btnRequests
        Me.btnRequests.FillColor = System.Drawing.Color.Transparent
        Me.btnRequests.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequests.ForeColor = System.Drawing.Color.White
        Me.btnRequests.HoverState.Parent = Me.btnRequests
        Me.btnRequests.Image = CType(resources.GetObject("btnRequests.Image"), System.Drawing.Image)
        Me.btnRequests.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnRequests.Location = New System.Drawing.Point(1, 527)
        Me.btnRequests.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRequests.Name = "btnRequests"
        Me.btnRequests.ShadowDecoration.Parent = Me.btnRequests
        Me.btnRequests.Size = New System.Drawing.Size(258, 40)
        Me.btnRequests.TabIndex = 67
        Me.btnRequests.Text = "Requests"
        Me.btnRequests.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlRequestsButtons
        '
        Me.pnlRequestsButtons.AutoSize = True
        Me.pnlRequestsButtons.BackColor = System.Drawing.Color.Navy
        Me.pnlRequestsButtons.Controls.Add(Me.btnAssetRequest)
        Me.pnlRequestsButtons.Controls.Add(Me.btnUserApproval)
        Me.pnlRequestsButtons.Controls.Add(Me.btnAssetRequestApproval)
        Me.pnlRequestsButtons.Location = New System.Drawing.Point(3, 571)
        Me.pnlRequestsButtons.Name = "pnlRequestsButtons"
        Me.pnlRequestsButtons.Size = New System.Drawing.Size(259, 98)
        Me.pnlRequestsButtons.TabIndex = 61
        '
        'btnAssetRequest
        '
        Me.btnAssetRequest.BorderColor = System.Drawing.Color.Transparent
        Me.btnAssetRequest.BorderRadius = 1
        Me.btnAssetRequest.CheckedState.Parent = Me.btnAssetRequest
        Me.btnAssetRequest.CustomImages.Parent = Me.btnAssetRequest
        Me.btnAssetRequest.FillColor = System.Drawing.Color.Transparent
        Me.btnAssetRequest.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssetRequest.ForeColor = System.Drawing.Color.White
        Me.btnAssetRequest.HoverState.Parent = Me.btnAssetRequest
        Me.btnAssetRequest.Image = CType(resources.GetObject("btnAssetRequest.Image"), System.Drawing.Image)
        Me.btnAssetRequest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetRequest.Location = New System.Drawing.Point(1, 1)
        Me.btnAssetRequest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAssetRequest.Name = "btnAssetRequest"
        Me.btnAssetRequest.ShadowDecoration.Parent = Me.btnAssetRequest
        Me.btnAssetRequest.Size = New System.Drawing.Size(253, 28)
        Me.btnAssetRequest.TabIndex = 34
        Me.btnAssetRequest.Text = "Asset Request"
        Me.btnAssetRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetRequest.Visible = False
        '
        'btnUserApproval
        '
        Me.btnUserApproval.BorderColor = System.Drawing.Color.Transparent
        Me.btnUserApproval.BorderRadius = 1
        Me.btnUserApproval.CheckedState.Parent = Me.btnUserApproval
        Me.btnUserApproval.CustomImages.Parent = Me.btnUserApproval
        Me.btnUserApproval.FillColor = System.Drawing.Color.Transparent
        Me.btnUserApproval.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserApproval.ForeColor = System.Drawing.Color.White
        Me.btnUserApproval.HoverState.Parent = Me.btnUserApproval
        Me.btnUserApproval.Image = CType(resources.GetObject("btnUserApproval.Image"), System.Drawing.Image)
        Me.btnUserApproval.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnUserApproval.Location = New System.Drawing.Point(3, 33)
        Me.btnUserApproval.Name = "btnUserApproval"
        Me.btnUserApproval.ShadowDecoration.Parent = Me.btnUserApproval
        Me.btnUserApproval.Size = New System.Drawing.Size(253, 28)
        Me.btnUserApproval.TabIndex = 35
        Me.btnUserApproval.Text = "User Approval"
        Me.btnUserApproval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnUserApproval.Visible = False
        '
        'btnAssetRequestApproval
        '
        Me.btnAssetRequestApproval.BorderColor = System.Drawing.Color.Transparent
        Me.btnAssetRequestApproval.BorderRadius = 1
        Me.btnAssetRequestApproval.CheckedState.Parent = Me.btnAssetRequestApproval
        Me.btnAssetRequestApproval.CustomImages.Parent = Me.btnAssetRequestApproval
        Me.btnAssetRequestApproval.FillColor = System.Drawing.Color.Transparent
        Me.btnAssetRequestApproval.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssetRequestApproval.ForeColor = System.Drawing.Color.White
        Me.btnAssetRequestApproval.HoverState.Parent = Me.btnAssetRequestApproval
        Me.btnAssetRequestApproval.Image = CType(resources.GetObject("btnAssetRequestApproval.Image"), System.Drawing.Image)
        Me.btnAssetRequestApproval.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetRequestApproval.Location = New System.Drawing.Point(3, 67)
        Me.btnAssetRequestApproval.Name = "btnAssetRequestApproval"
        Me.btnAssetRequestApproval.ShadowDecoration.Parent = Me.btnAssetRequestApproval
        Me.btnAssetRequestApproval.Size = New System.Drawing.Size(253, 28)
        Me.btnAssetRequestApproval.TabIndex = 33
        Me.btnAssetRequestApproval.Text = "Asset Request Approval"
        Me.btnAssetRequestApproval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAssetRequestApproval.Visible = False
        '
        'btnUsers
        '
        Me.btnUsers.BorderColor = System.Drawing.Color.Transparent
        Me.btnUsers.BorderRadius = 3
        Me.btnUsers.CheckedState.Parent = Me.btnUsers
        Me.btnUsers.CustomImages.Parent = Me.btnUsers
        Me.btnUsers.FillColor = System.Drawing.Color.Transparent
        Me.btnUsers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.HoverState.Parent = Me.btnUsers
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnUsers.Location = New System.Drawing.Point(1, 673)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.ShadowDecoration.Parent = Me.btnUsers
        Me.btnUsers.Size = New System.Drawing.Size(258, 40)
        Me.btnUsers.TabIndex = 68
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlUsersButtons
        '
        Me.pnlUsersButtons.AutoSize = True
        Me.pnlUsersButtons.BackColor = System.Drawing.Color.Navy
        Me.pnlUsersButtons.Controls.Add(Me.btnUserInfo)
        Me.pnlUsersButtons.Controls.Add(Me.btnAccountManagement)
        Me.pnlUsersButtons.Location = New System.Drawing.Point(3, 717)
        Me.pnlUsersButtons.Name = "pnlUsersButtons"
        Me.pnlUsersButtons.Size = New System.Drawing.Size(259, 68)
        Me.pnlUsersButtons.TabIndex = 60
        '
        'btnUserInfo
        '
        Me.btnUserInfo.BorderColor = System.Drawing.Color.Transparent
        Me.btnUserInfo.BorderRadius = 1
        Me.btnUserInfo.CheckedState.Parent = Me.btnUserInfo
        Me.btnUserInfo.CustomImages.Parent = Me.btnUserInfo
        Me.btnUserInfo.FillColor = System.Drawing.Color.Transparent
        Me.btnUserInfo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserInfo.ForeColor = System.Drawing.Color.White
        Me.btnUserInfo.HoverState.Parent = Me.btnUserInfo
        Me.btnUserInfo.Image = CType(resources.GetObject("btnUserInfo.Image"), System.Drawing.Image)
        Me.btnUserInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnUserInfo.Location = New System.Drawing.Point(3, 3)
        Me.btnUserInfo.Name = "btnUserInfo"
        Me.btnUserInfo.ShadowDecoration.Parent = Me.btnUserInfo
        Me.btnUserInfo.Size = New System.Drawing.Size(253, 28)
        Me.btnUserInfo.TabIndex = 28
        Me.btnUserInfo.Text = "User Information"
        Me.btnUserInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnUserInfo.Visible = False
        '
        'btnAccountManagement
        '
        Me.btnAccountManagement.BorderColor = System.Drawing.Color.Transparent
        Me.btnAccountManagement.BorderRadius = 1
        Me.btnAccountManagement.CheckedState.Parent = Me.btnAccountManagement
        Me.btnAccountManagement.CustomImages.Parent = Me.btnAccountManagement
        Me.btnAccountManagement.FillColor = System.Drawing.Color.Transparent
        Me.btnAccountManagement.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountManagement.ForeColor = System.Drawing.Color.White
        Me.btnAccountManagement.HoverState.Parent = Me.btnAccountManagement
        Me.btnAccountManagement.Image = CType(resources.GetObject("btnAccountManagement.Image"), System.Drawing.Image)
        Me.btnAccountManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAccountManagement.Location = New System.Drawing.Point(3, 37)
        Me.btnAccountManagement.Name = "btnAccountManagement"
        Me.btnAccountManagement.ShadowDecoration.Parent = Me.btnAccountManagement
        Me.btnAccountManagement.Size = New System.Drawing.Size(253, 28)
        Me.btnAccountManagement.TabIndex = 29
        Me.btnAccountManagement.Text = "Add/Edit Usser Account"
        Me.btnAccountManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAccountManagement.Visible = False
        '
        'btnReports
        '
        Me.btnReports.BorderColor = System.Drawing.Color.Transparent
        Me.btnReports.BorderRadius = 3
        Me.btnReports.CheckedState.Parent = Me.btnReports
        Me.btnReports.CustomImages.Parent = Me.btnReports
        Me.btnReports.FillColor = System.Drawing.Color.Transparent
        Me.btnReports.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.HoverState.Parent = Me.btnReports
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnReports.Location = New System.Drawing.Point(1, 789)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(1)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.ShadowDecoration.Parent = Me.btnReports
        Me.btnReports.Size = New System.Drawing.Size(258, 40)
        Me.btnReports.TabIndex = 69
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlReportsButtons
        '
        Me.pnlReportsButtons.AutoSize = True
        Me.pnlReportsButtons.BackColor = System.Drawing.Color.Navy
        Me.pnlReportsButtons.Controls.Add(Me.btnShowReport)
        Me.pnlReportsButtons.Location = New System.Drawing.Point(3, 833)
        Me.pnlReportsButtons.Name = "pnlReportsButtons"
        Me.pnlReportsButtons.Size = New System.Drawing.Size(259, 34)
        Me.pnlReportsButtons.TabIndex = 59
        '
        'btnShowReport
        '
        Me.btnShowReport.BorderColor = System.Drawing.Color.Transparent
        Me.btnShowReport.BorderRadius = 1
        Me.btnShowReport.CheckedState.Parent = Me.btnShowReport
        Me.btnShowReport.CustomImages.Parent = Me.btnShowReport
        Me.btnShowReport.FillColor = System.Drawing.Color.Transparent
        Me.btnShowReport.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowReport.ForeColor = System.Drawing.Color.White
        Me.btnShowReport.HoverState.Parent = Me.btnShowReport
        Me.btnShowReport.Image = CType(resources.GetObject("btnShowReport.Image"), System.Drawing.Image)
        Me.btnShowReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnShowReport.Location = New System.Drawing.Point(3, 3)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.ShadowDecoration.Parent = Me.btnShowReport
        Me.btnShowReport.Size = New System.Drawing.Size(253, 28)
        Me.btnShowReport.TabIndex = 26
        Me.btnShowReport.Text = "More Reports...."
        Me.btnShowReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnShowReport.Visible = False
        '
        'btnSettings
        '
        Me.btnSettings.BorderColor = System.Drawing.Color.Transparent
        Me.btnSettings.BorderRadius = 3
        Me.btnSettings.CheckedState.Parent = Me.btnSettings
        Me.btnSettings.CustomImages.Parent = Me.btnSettings
        Me.btnSettings.FillColor = System.Drawing.Color.Transparent
        Me.btnSettings.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.HoverState.Parent = Me.btnSettings
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSettings.Location = New System.Drawing.Point(1, 871)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.ShadowDecoration.Parent = Me.btnSettings
        Me.btnSettings.Size = New System.Drawing.Size(258, 40)
        Me.btnSettings.TabIndex = 70
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlSettingsButtons
        '
        Me.pnlSettingsButtons.AutoSize = True
        Me.pnlSettingsButtons.BackColor = System.Drawing.Color.Navy
        Me.pnlSettingsButtons.Controls.Add(Me.btnSystemConfiguration)
        Me.pnlSettingsButtons.Location = New System.Drawing.Point(3, 915)
        Me.pnlSettingsButtons.Name = "pnlSettingsButtons"
        Me.pnlSettingsButtons.Size = New System.Drawing.Size(259, 34)
        Me.pnlSettingsButtons.TabIndex = 58
        '
        'btnSystemConfiguration
        '
        Me.btnSystemConfiguration.BorderColor = System.Drawing.Color.Transparent
        Me.btnSystemConfiguration.BorderRadius = 1
        Me.btnSystemConfiguration.CheckedState.Parent = Me.btnSystemConfiguration
        Me.btnSystemConfiguration.CustomImages.Parent = Me.btnSystemConfiguration
        Me.btnSystemConfiguration.FillColor = System.Drawing.Color.Transparent
        Me.btnSystemConfiguration.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystemConfiguration.ForeColor = System.Drawing.Color.White
        Me.btnSystemConfiguration.HoverState.Parent = Me.btnSystemConfiguration
        Me.btnSystemConfiguration.Image = CType(resources.GetObject("btnSystemConfiguration.Image"), System.Drawing.Image)
        Me.btnSystemConfiguration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSystemConfiguration.Location = New System.Drawing.Point(3, 3)
        Me.btnSystemConfiguration.Name = "btnSystemConfiguration"
        Me.btnSystemConfiguration.ShadowDecoration.Parent = Me.btnSystemConfiguration
        Me.btnSystemConfiguration.Size = New System.Drawing.Size(253, 28)
        Me.btnSystemConfiguration.TabIndex = 26
        Me.btnSystemConfiguration.Text = "System Configuration"
        Me.btnSystemConfiguration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSystemConfiguration.Visible = False
        '
        'pnlView
        '
        Me.pnlView.BackColor = System.Drawing.Color.White
        Me.pnlView.BackgroundImage = CType(resources.GetObject("pnlView.BackgroundImage"), System.Drawing.Image)
        Me.pnlView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlView.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlView.Location = New System.Drawing.Point(262, 147)
        Me.pnlView.Name = "pnlView"
        Me.pnlView.ShadowDecoration.Parent = Me.pnlView
        Me.pnlView.Size = New System.Drawing.Size(1238, 1075)
        Me.pnlView.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(262, 1048)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1238, 174)
        Me.Panel1.TabIndex = 11
        '
        'PictLogout
        '
        Me.PictLogout.BackColor = System.Drawing.Color.Transparent
        Me.PictLogout.BackgroundImage = CType(resources.GetObject("PictLogout.BackgroundImage"), System.Drawing.Image)
        Me.PictLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictLogout.Location = New System.Drawing.Point(1436, 84)
        Me.PictLogout.Name = "PictLogout"
        Me.PictLogout.Size = New System.Drawing.Size(52, 54)
        Me.PictLogout.TabIndex = 18
        Me.PictLogout.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OldLace
        Me.Label2.Location = New System.Drawing.Point(144, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 27)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Miriam College"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OldLace
        Me.Label3.Location = New System.Drawing.Point(147, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Katipunan Avenue, Loyola Heights, Quezon City"
        '
        'frmAISMainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1500, 1222)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlView)
        Me.Controls.Add(Me.pnlMainMenu)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1500, 1500)
        Me.Name = "frmAISMainDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAISMainDashboard"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picUserProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMainMenu.ResumeLayout(False)
        Me.pnlMainMenu.PerformLayout()
        Me.pnlDashboardButtons.ResumeLayout(False)
        Me.pnlAssetsButtons.ResumeLayout(False)
        Me.pnlSoftwareButtons.ResumeLayout(False)
        Me.pnlRequestsButtons.ResumeLayout(False)
        Me.pnlUsersButtons.ResumeLayout(False)
        Me.pnlReportsButtons.ResumeLayout(False)
        Me.pnlSettingsButtons.ResumeLayout(False)
        CType(Me.PictLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblUserDesignation As Label
    Friend WithEvents picUserProfile As PictureBox
    Friend WithEvents pnlMainMenu As FlowLayoutPanel
    Friend WithEvents pnlSettingsButtons As FlowLayoutPanel
    Friend WithEvents btnSystemConfiguration As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlReportsButtons As FlowLayoutPanel
    Friend WithEvents btnShowReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlUsersButtons As FlowLayoutPanel
    Friend WithEvents btnUserInfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAccountManagement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlRequestsButtons As FlowLayoutPanel
    Friend WithEvents btnAssetRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUserApproval As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssetRequestApproval As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlSoftwareButtons As FlowLayoutPanel
    Friend WithEvents BTNSoftwareList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSoftwareRequestList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSoftwareAssignment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSoftwareRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlAssetsButtons As FlowLayoutPanel
    Friend WithEvents btnRepairEvaluation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssetsEvaluation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssetAssignment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRepairRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssetDisposal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssetList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssetReturn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRequests As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSoftware As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssets As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlDashboardButtons As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btndashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlView As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictLogout As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
