Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms

Public Class frmAISMainDashboard


    Private WithEvents inactivityTimer As New Timer()
    Private lastActivityTime As DateTime = DateTime.Now
    Private timeoutMinutes As Integer = 5 ' Adjust timeout as needed




    Private Sub CollapseAllMenus()
        ' Collapse all panels by setting their height to 0
        pnlAssetsButtons.Height = 0
        pnlSoftwareButtons.Height = 0
        pnlRequestsButtons.Height = 0
        pnlUsersButtons.Height = 0
        pnlReportsButtons.Height = 0
        pnlSettingsButtons.Height = 0

        ' Hide all panels after collapsing
        pnlAssetsButtons.Visible = False
        pnlSoftwareButtons.Visible = False
        pnlRequestsButtons.Visible = False
        pnlUsersButtons.Visible = False
        pnlReportsButtons.Visible = False
        pnlSettingsButtons.Visible = False
    End Sub



    Private Sub FRMAISMainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CollapseAllMenus()

        ' Set inactivity timer interval to 1 minute
        inactivityTimer.Interval = 60000 ' 1 minute

        ' Set initial last activity time
        GlobalVariables.LastActivityTime = DateTime.Now

        ' Start monitoring activity globally
        Application.AddMessageFilter(New InactivityMessageFilter())

        ' Start the timer
        inactivityTimer.Start()



        ' Show default panel
        switchPanel(frmDashboard)

        ' Show welcome text and user info
        lblWelcome.Text = "Welcome"
        lblUserName.Text = "User: " & GlobalVariables.LoggedInEmployeeName
        lblUserDesignation.Text = "Designation: " & GlobalVariables.LoggedInUserDesignation

        ' Style labels
        lblUserName.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblUserDesignation.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        lblUserName.ForeColor = Color.White
        lblUserDesignation.ForeColor = Color.White



        ' Load profile picture from GlobalVariables
        Try
            If GlobalVariables.LoggedInProfilePicture IsNot Nothing Then
                Using ms As New IO.MemoryStream(GlobalVariables.LoggedInProfilePicture)
                    picUserProfile.Image = Image.FromStream(ms)
                End Using
            Else
                picUserProfile.Image = ByteArrayToImage(GlobalVariables.LoggedInProfilePicture) ' fallback image from Resources
            End If

        Catch ex As Exception
            picUserProfile.Image = ByteArrayToImage(GlobalVariables.LoggedInProfilePicture) ' fallback in case of error
        End Try

        ' Make picture circular
        Dim gp As New Drawing2D.GraphicsPath()
        gp.AddEllipse(0, 0, picUserProfile.Width, picUserProfile.Height)
        picUserProfile.Region = New Region(gp)

        ApplyRolePermissions()
    End Sub




    ' Convert Byte() to Image
    Private Function ByteArrayToImage(imageData As Byte()) As Image
        If imageData Is Nothing OrElse imageData.Length = 0 Then
            Return Nothing
        End If

        Using ms As New System.IO.MemoryStream(imageData)
            Return Image.FromStream(ms)
        End Using
    End Function




    Private Sub inactivityTimer_Tick(sender As Object, e As EventArgs) Handles inactivityTimer.Tick
        Dim elapsedMinutes As Double = (DateTime.Now - GlobalVariables.LastActivityTime).TotalMinutes
        Console.WriteLine("Elapsed minutes: " & elapsedMinutes)

        If elapsedMinutes >= timeoutMinutes Then
            inactivityTimer.Stop()

            MessageBox.Show("Session expired due to inactivity. You will be logged out.", "Session Timeout", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear session info
            GlobalVariables.LoggedInEmployeeID = 0
            GlobalVariables.LoggedInUserType = ""
            GlobalVariables.LoggedInEmployeeName = ""
            GlobalVariables.LoggedInUserDesignation = ""

            ' Show login form
            Dim loginForm As New LoginForm()
            loginForm.Show()

            ' Close dashboard
            Me.Close()
        End If
    End Sub







    Private Sub switchPanel(newForm As Form)
        pnlView.Controls.Clear()
        newForm.TopLevel = False
        newForm.FormBorderStyle = FormBorderStyle.None
        newForm.Dock = DockStyle.Fill
        pnlView.Controls.Add(newForm)
        newForm.Show()
    End Sub












    Private Function IsInRole(roleName As String) As Boolean
        Return GlobalVariables.LoggedInRoleNames.Contains(roleName)
    End Function


    Private Sub ApplyRolePermissions()
        btnAssetAssignment.Visible = False
        btnAssetList.Visible = False
        btnAssetReturn.Visible = False
        btnRepairRequest.Visible = False
        btnAssetRequest.Visible = False
        btnAssetsEvaluation.Visible = False
        btnAssetDisposal.Visible = False
        btnRepairEvaluation.Visible = False
        BTNSoftwareList.Visible = False
        btnSoftwareAssignment.Visible = False
        btnSoftwareRequest.Visible = False
        btnUserApproval.Visible = False
        btnSoftwareRequestList.Visible = False
        btnAssetRequestApproval.Visible = False
        btnUserInfo.Visible = False
        btnShowReport.Visible = False
        btnSystemConfiguration.Visible = False
        btnAccountManagement.Visible = False

        If IsInRole("Admin") Then
            btnAssetAssignment.Visible = True
            btnAssetList.Visible = True
            btnAssetReturn.Visible = True
            btnRepairRequest.Visible = True
            btnAssetRequest.Visible = True
            btnAssetsEvaluation.Visible = True
            btnAssetDisposal.Visible = True
            btnRepairEvaluation.Visible = True
            BTNSoftwareList.Visible = True
            btnSoftwareAssignment.Visible = True
            btnSoftwareRequest.Visible = True
            btnUserApproval.Visible = True
            btnSoftwareRequestList.Visible = True
            btnAssetRequestApproval.Visible = True
            btnShowReport.Visible = True
            btnSystemConfiguration.Visible = True
            btnAccountManagement.Visible = True
        End If

        If IsInRole("Technician") Then
            btnAssetsEvaluation.Visible = True
            btnRepairEvaluation.Visible = True
            btnAssetList.Visible = True
        End If

        If IsInRole("User") Then
            btnAssetRequest.Visible = True
            btnSoftwareRequest.Visible = True
            btnUserInfo.Visible = True
        End If

        If IsInRole("Approver1") Then
            btnAssetRequestApproval.Visible = True
        End If

        If IsInRole("Approver2") Then
            btnAssetRequestApproval.Visible = True
        End If

        If IsInRole("Approver3") Then
            btnAssetRequestApproval.Visible = True
        End If


    End Sub






    Private Sub btnAssets_Click(sender As Object, e As EventArgs) Handles btnAssets.Click
        ' Reset all button styles
        ResetAccordionButtonColors()

        ' Style this clicked button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        btn.BackColor = Color.Teal
        btn.Font = New Font(btn.Font, FontStyle.Bold)

        ' Check if panel is currently expanded
        Dim isExpanded As Boolean = pnlAssetsButtons.Visible

        ' Collapse all other menus first
        CollapseAllMenus()

        ' Expand or collapse this panel with animation
        If Not isExpanded Then
            pnlAssetsButtons.Visible = True
            For i As Integer = 1 To 100 Step 10
                pnlAssetsButtons.Height = i
                Application.DoEvents()
            Next
        Else
            For i As Integer = pnlAssetsButtons.Height To 0 Step -10
                pnlAssetsButtons.Height = i
                Application.DoEvents()
            Next
            pnlAssetsButtons.Visible = False
        End If
    End Sub



    Private Sub btnSoftware_Click(sender As Object, e As EventArgs) Handles btnSoftware.Click

        ResetAccordionButtonColors()

        ' Style this clicked button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        btn.BackColor = Color.Teal
        btn.Font = New Font(btn.Font, FontStyle.Bold)

        ' Check if panel is currently expanded
        Dim isExpanded As Boolean = pnlSoftwareButtons.Visible
        ' Collapse all panels first
        CollapseAllMenus()

        ' Expand the Software panel
        If pnlSoftwareButtons.Visible = False Then
            pnlSoftwareButtons.Visible = True
            For i As Integer = 1 To 100 Step 5
                pnlSoftwareButtons.Height = i
                Application.DoEvents()  ' This will force the form to refresh while expanding
            Next
        Else
            ' If it's already expanded, collapse it
            For i As Integer = pnlSoftwareButtons.Height To 0 Step -5
                pnlSoftwareButtons.Height = i
                Application.DoEvents()  ' This will force the form to refresh while collapsing
            Next
            pnlSoftwareButtons.Visible = False
        End If
    End Sub

    Private Sub btnRequests_Click(sender As Object, e As EventArgs) Handles btnRequests.Click

        ResetAccordionButtonColors()

        ' Style this clicked button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        btn.BackColor = Color.Teal
        btn.Font = New Font(btn.Font, FontStyle.Bold)

        ' Check if panel is currently expanded
        Dim isExpanded As Boolean = pnlRequestsButtons.Visible
        CollapseAllMenus()
        If pnlRequestsButtons.Visible = False Then
            pnlRequestsButtons.Visible = True
            For i As Integer = 1 To 100 Step 5
                pnlRequestsButtons.Height = i
                Application.DoEvents()  ' This will force the form to refresh while expanding
            Next
        Else
            ' If it's already expanded, collapse it
            For i As Integer = pnlRequestsButtons.Height To 0 Step -5
                pnlRequestsButtons.Height = i
                Application.DoEvents()  ' This will force the form to refresh while collapsing
            Next
            pnlRequestsButtons.Visible = False
        End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click

        ResetAccordionButtonColors()

        ' Style this clicked button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        btn.BackColor = Color.Teal
        btn.Font = New Font(btn.Font, FontStyle.Bold)

        ' Check if panel is currently expanded
        Dim isExpanded As Boolean = pnlUsersButtons.Visible
        CollapseAllMenus()
        If pnlUsersButtons.Height = 0 Then
            CollapseAllMenus()
            pnlUsersButtons.Visible = True
            For i As Integer = 1 To 100 Step 5
                pnlUsersButtons.Height = i
                Application.DoEvents()
            Next
        Else
            For i As Integer = pnlUsersButtons.Height To 0 Step -5
                pnlUsersButtons.Height = i
                Application.DoEvents()
            Next
            pnlUsersButtons.Visible = False
        End If
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        ResetAccordionButtonColors()

        ' Style this clicked button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        btn.BackColor = Color.Teal
        btn.Font = New Font(btn.Font, FontStyle.Bold)

        ' Check if panel is currently expanded
        Dim isExpanded As Boolean = pnlReportsButtons.Visible
        CollapseAllMenus()
        If pnlReportsButtons.Height = 0 Then
            CollapseAllMenus()
            pnlReportsButtons.Visible = True
            For i As Integer = 1 To 100 Step 5
                pnlReportsButtons.Height = i
                Application.DoEvents()
            Next
        Else
            For i As Integer = pnlReportsButtons.Height To 0 Step -5
                pnlReportsButtons.Height = i
                Application.DoEvents()
            Next
            pnlReportsButtons.Visible = False
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        ResetAccordionButtonColors()

        ' Style this clicked button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        btn.BackColor = Color.Teal
        btn.Font = New Font(btn.Font, FontStyle.Bold)

        ' Check if panel is currently expanded
        Dim isExpanded As Boolean = pnlSettingsButtons.Visible

        CollapseAllMenus()
        If pnlSettingsButtons.Height = 0 Then
            CollapseAllMenus()
            pnlSettingsButtons.Visible = True
            For i As Integer = 1 To 100 Step 5
                pnlSettingsButtons.Height = i
                Application.DoEvents()
            Next
        Else
            For i As Integer = pnlSettingsButtons.Height To 0 Step -5
                pnlSettingsButtons.Height = i
                Application.DoEvents()
            Next
            pnlSettingsButtons.Visible = False
        End If
    End Sub

    Private Sub btnRepairEvaluation_Click(sender As Object, e As EventArgs) Handles btnRepairEvaluation.Click
        switchPanel(frmRepairEvaluation)
    End Sub

    Private Sub btnAssetsEvaluation_Click(sender As Object, e As EventArgs) Handles btnAssetsEvaluation.Click
        switchPanel(frmAssetEvaluation)
    End Sub

    Private Sub btnAssetAssignment_Click(sender As Object, e As EventArgs) Handles btnAssetAssignment.Click
        switchPanel(frmAssetAssignment)
    End Sub

    Private Sub btnRepairRequest_Click(sender As Object, e As EventArgs) Handles btnRepairRequest.Click
        switchPanel(frmRepairRequest)
    End Sub

    Private Sub btnAssetDisposal_Click(sender As Object, e As EventArgs) Handles btnAssetDisposal.Click
        switchPanel(frmAssetDisposal)
    End Sub

    Private Sub btnAssetList_Click(sender As Object, e As EventArgs) Handles btnAssetList.Click
        switchPanel(frmAssetList)
    End Sub

    Private Sub btnAssetReturn_Click(sender As Object, e As EventArgs) Handles btnAssetReturn.Click
        switchPanel(frmAssetReturn)
    End Sub

    Private Sub BTNSoftwareList_Click(sender As Object, e As EventArgs) Handles BTNSoftwareList.Click
        switchPanel(frmSoftwareList)
    End Sub

    Private Sub btnSoftwareRequestList_Click(sender As Object, e As EventArgs) Handles btnSoftwareRequestList.Click
        switchPanel(frmSoftwareRequestList)
    End Sub

    Private Sub btnSoftwareAssignment_Click(sender As Object, e As EventArgs) Handles btnSoftwareAssignment.Click
        switchPanel(frmSoftwareAssignment)
    End Sub

    Private Sub btnSoftwareRequest_Click(sender As Object, e As EventArgs) Handles btnSoftwareRequest.Click
        switchPanel(frmSoftwareRequest)
    End Sub

    Private Sub btnAssetRequest_Click(sender As Object, e As EventArgs) Handles btnAssetRequest.Click
        switchPanel(frmAssetRequest)
    End Sub

    Private Sub btnUserApproval_Click(sender As Object, e As EventArgs) Handles btnUserApproval.Click
        switchPanel(frmUserApproval)
    End Sub

    Private Sub btnAssetRequestApproval_Click(sender As Object, e As EventArgs) Handles btnAssetRequestApproval.Click
        switchPanel(frmAssetRequestApproval)
    End Sub

    Private Sub btnUserInfo_Click(sender As Object, e As EventArgs) Handles btnUserInfo.Click
        switchPanel(frmUserInfo)
    End Sub

    Private Sub btnAccountManagement_Click(sender As Object, e As EventArgs) Handles btnAccountManagement.Click
        switchPanel(frmAddEditUser)
    End Sub

    Private Sub btnShowReport_Click(sender As Object, e As EventArgs) Handles btnShowReport.Click

    End Sub

    Private Sub btnSystemConfiguration_Click(sender As Object, e As EventArgs) Handles btnSystemConfiguration.Click
        switchPanel(frmSystemConfiguration)
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        switchPanel(frmDashboard)
    End Sub

    Private Sub ResetAccordionButtonColors(Optional parent As Control = Nothing)
        Me.btnAssets.BackColor = Color.FromArgb(0, 0, 64)
        Me.btnSoftware.BackColor = Color.FromArgb(0, 0, 64)
        Me.btnRequests.BackColor = Color.FromArgb(0, 0, 64)
        Me.btnUsers.BackColor = Color.FromArgb(0, 0, 64)
        Me.btnReports.BackColor = Color.FromArgb(0, 0, 64)
        Me.btnSettings.BackColor = Color.FromArgb(0, 0, 64)

    End Sub

    Private Sub PictLogout_Click(sender As Object, e As EventArgs) Handles PictLogout.Click

        ' ✅ Confirm logout
        If MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' ✅ Stop any active timers in frmDashboard before closing
            For Each ctrl As Control In pnlView.Controls
                If TypeOf ctrl Is frmDashboard Then
                    CType(ctrl, frmDashboard).StopEmailTimer()
                End If
            Next

            ' ✅ Optional: Clear global variables if needed
            GlobalVariables.LoggedInEmployeeID = 0
            GlobalVariables.LoggedInEmployeeName = ""
            GlobalVariables.LoggedInUserDesignation = ""
            GlobalVariables.LoggedInRoles.Clear()

            ' ✅ Hide current dashboard and show login form
            Me.Hide()
            LoginForm.Show()
        End If

    End Sub
End Class