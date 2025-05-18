<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblWarrantyNotification = New System.Windows.Forms.Label()
        Me.dgvWarrantyDetails = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnMarkAsNotified = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvAssignedAssetsPerBranch = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmailCount = New System.Windows.Forms.Label()
        Me.picEnvelopeIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.dgvPendingEvaluations = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.dgvWarrantyDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAssignedAssetsPerBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvelopeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPendingEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWarrantyNotification
        '
        Me.lblWarrantyNotification.AutoSize = True
        Me.lblWarrantyNotification.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarrantyNotification.ForeColor = System.Drawing.Color.Navy
        Me.lblWarrantyNotification.Location = New System.Drawing.Point(74, 178)
        Me.lblWarrantyNotification.Name = "lblWarrantyNotification"
        Me.lblWarrantyNotification.Size = New System.Drawing.Size(75, 36)
        Me.lblWarrantyNotification.TabIndex = 0
        Me.lblWarrantyNotification.Text = "Label1"
        '
        'dgvWarrantyDetails
        '
        Me.dgvWarrantyDetails.AllowUserToAddRows = False
        Me.dgvWarrantyDetails.AllowUserToDeleteRows = False
        Me.dgvWarrantyDetails.AllowUserToResizeColumns = False
        Me.dgvWarrantyDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvWarrantyDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvWarrantyDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvWarrantyDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvWarrantyDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvWarrantyDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvWarrantyDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvWarrantyDetails.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvWarrantyDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWarrantyDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvWarrantyDetails.ColumnHeadersHeight = 25
        Me.dgvWarrantyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvWarrantyDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvWarrantyDetails.EnableHeadersVisualStyles = False
        Me.dgvWarrantyDetails.GridColor = System.Drawing.Color.White
        Me.dgvWarrantyDetails.Location = New System.Drawing.Point(71, 217)
        Me.dgvWarrantyDetails.Name = "dgvWarrantyDetails"
        Me.dgvWarrantyDetails.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWarrantyDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvWarrantyDetails.RowHeadersVisible = False
        Me.dgvWarrantyDetails.RowHeadersWidth = 51
        Me.dgvWarrantyDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvWarrantyDetails.RowTemplate.Height = 24
        Me.dgvWarrantyDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWarrantyDetails.Size = New System.Drawing.Size(629, 214)
        Me.dgvWarrantyDetails.TabIndex = 4
        Me.dgvWarrantyDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvWarrantyDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvWarrantyDetails.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvWarrantyDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvWarrantyDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvWarrantyDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvWarrantyDetails.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvWarrantyDetails.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvWarrantyDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvWarrantyDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvWarrantyDetails.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvWarrantyDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvWarrantyDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvWarrantyDetails.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvWarrantyDetails.ThemeStyle.ReadOnly = True
        Me.dgvWarrantyDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvWarrantyDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvWarrantyDetails.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvWarrantyDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvWarrantyDetails.ThemeStyle.RowsStyle.Height = 24
        Me.dgvWarrantyDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvWarrantyDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnMarkAsNotified
        '
        Me.btnMarkAsNotified.CheckedState.Parent = Me.btnMarkAsNotified
        Me.btnMarkAsNotified.CustomImages.Parent = Me.btnMarkAsNotified
        Me.btnMarkAsNotified.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMarkAsNotified.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkAsNotified.ForeColor = System.Drawing.Color.White
        Me.btnMarkAsNotified.HoverState.Parent = Me.btnMarkAsNotified
        Me.btnMarkAsNotified.Location = New System.Drawing.Point(539, 162)
        Me.btnMarkAsNotified.Name = "btnMarkAsNotified"
        Me.btnMarkAsNotified.ShadowDecoration.Parent = Me.btnMarkAsNotified
        Me.btnMarkAsNotified.Size = New System.Drawing.Size(150, 49)
        Me.btnMarkAsNotified.TabIndex = 5
        Me.btnMarkAsNotified.Text = "Mark as Notified"
        '
        'dgvAssignedAssetsPerBranch
        '
        Me.dgvAssignedAssetsPerBranch.AllowUserToAddRows = False
        Me.dgvAssignedAssetsPerBranch.AllowUserToDeleteRows = False
        Me.dgvAssignedAssetsPerBranch.AllowUserToResizeColumns = False
        Me.dgvAssignedAssetsPerBranch.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgvAssignedAssetsPerBranch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAssignedAssetsPerBranch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAssignedAssetsPerBranch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAssignedAssetsPerBranch.BackgroundColor = System.Drawing.Color.White
        Me.dgvAssignedAssetsPerBranch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAssignedAssetsPerBranch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAssignedAssetsPerBranch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvAssignedAssetsPerBranch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAssignedAssetsPerBranch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAssignedAssetsPerBranch.ColumnHeadersHeight = 25
        Me.dgvAssignedAssetsPerBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAssignedAssetsPerBranch.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAssignedAssetsPerBranch.EnableHeadersVisualStyles = False
        Me.dgvAssignedAssetsPerBranch.GridColor = System.Drawing.Color.White
        Me.dgvAssignedAssetsPerBranch.Location = New System.Drawing.Point(728, 217)
        Me.dgvAssignedAssetsPerBranch.Name = "dgvAssignedAssetsPerBranch"
        Me.dgvAssignedAssetsPerBranch.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAssignedAssetsPerBranch.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAssignedAssetsPerBranch.RowHeadersVisible = False
        Me.dgvAssignedAssetsPerBranch.RowHeadersWidth = 51
        Me.dgvAssignedAssetsPerBranch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAssignedAssetsPerBranch.RowTemplate.Height = 24
        Me.dgvAssignedAssetsPerBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssignedAssetsPerBranch.Size = New System.Drawing.Size(438, 214)
        Me.dgvAssignedAssetsPerBranch.TabIndex = 6
        Me.dgvAssignedAssetsPerBranch.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.ReadOnly = True
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.RowsStyle.Height = 24
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssignedAssetsPerBranch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(734, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 36)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Assigned Assets Per Branch"
        '
        'lblEmailCount
        '
        Me.lblEmailCount.AutoSize = True
        Me.lblEmailCount.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCount.Location = New System.Drawing.Point(1005, 44)
        Me.lblEmailCount.Name = "lblEmailCount"
        Me.lblEmailCount.Size = New System.Drawing.Size(49, 30)
        Me.lblEmailCount.TabIndex = 8
        Me.lblEmailCount.Text = "Mail:"
        '
        'picEnvelopeIcon
        '
        Me.picEnvelopeIcon.BackgroundImage = CType(resources.GetObject("picEnvelopeIcon.BackgroundImage"), System.Drawing.Image)
        Me.picEnvelopeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvelopeIcon.Location = New System.Drawing.Point(972, 42)
        Me.picEnvelopeIcon.Name = "picEnvelopeIcon"
        Me.picEnvelopeIcon.ShadowDecoration.Parent = Me.picEnvelopeIcon
        Me.picEnvelopeIcon.Size = New System.Drawing.Size(36, 32)
        Me.picEnvelopeIcon.TabIndex = 9
        Me.picEnvelopeIcon.TabStop = False
        '
        'dgvPendingEvaluations
        '
        Me.dgvPendingEvaluations.AllowUserToAddRows = False
        Me.dgvPendingEvaluations.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.dgvPendingEvaluations.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPendingEvaluations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPendingEvaluations.BackgroundColor = System.Drawing.Color.White
        Me.dgvPendingEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPendingEvaluations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPendingEvaluations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPendingEvaluations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPendingEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPendingEvaluations.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvPendingEvaluations.EnableHeadersVisualStyles = False
        Me.dgvPendingEvaluations.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPendingEvaluations.Location = New System.Drawing.Point(70, 458)
        Me.dgvPendingEvaluations.Name = "dgvPendingEvaluations"
        Me.dgvPendingEvaluations.ReadOnly = True
        Me.dgvPendingEvaluations.RowHeadersVisible = False
        Me.dgvPendingEvaluations.RowHeadersWidth = 51
        Me.dgvPendingEvaluations.RowTemplate.Height = 24
        Me.dgvPendingEvaluations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPendingEvaluations.Size = New System.Drawing.Size(629, 130)
        Me.dgvPendingEvaluations.TabIndex = 10
        Me.dgvPendingEvaluations.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvPendingEvaluations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPendingEvaluations.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPendingEvaluations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPendingEvaluations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPendingEvaluations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPendingEvaluations.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPendingEvaluations.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPendingEvaluations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPendingEvaluations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPendingEvaluations.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvPendingEvaluations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPendingEvaluations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendingEvaluations.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvPendingEvaluations.ThemeStyle.ReadOnly = True
        Me.dgvPendingEvaluations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPendingEvaluations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPendingEvaluations.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvPendingEvaluations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPendingEvaluations.ThemeStyle.RowsStyle.Height = 24
        Me.dgvPendingEvaluations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPendingEvaluations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 843)
        Me.Controls.Add(Me.dgvPendingEvaluations)
        Me.Controls.Add(Me.picEnvelopeIcon)
        Me.Controls.Add(Me.lblEmailCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAssignedAssetsPerBranch)
        Me.Controls.Add(Me.btnMarkAsNotified)
        Me.Controls.Add(Me.dgvWarrantyDetails)
        Me.Controls.Add(Me.lblWarrantyNotification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        CType(Me.dgvWarrantyDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAssignedAssetsPerBranch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvelopeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPendingEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWarrantyNotification As Label
    Friend WithEvents dgvWarrantyDetails As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnMarkAsNotified As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvAssignedAssetsPerBranch As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmailCount As Label
    Friend WithEvents picEnvelopeIcon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents dgvPendingEvaluations As Guna.UI2.WinForms.Guna2DataGridView
End Class
