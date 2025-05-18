<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailList





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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmailList))
        Me.dgvEmails = New System.Windows.Forms.DataGridView()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblSender = New System.Windows.Forms.Label()
        Me.lblDateReceived = New System.Windows.Forms.Label()
        Me.pnlToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInbox = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtEmailBody = New System.Windows.Forms.RichTextBox()
        Me.btnPrintEmail = New Guna.UI2.WinForms.Guna2Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToolbar.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmails
        '
        Me.dgvEmails.ColumnHeadersHeight = 29
        Me.dgvEmails.Location = New System.Drawing.Point(0, 60)
        Me.dgvEmails.Name = "dgvEmails"
        Me.dgvEmails.RowHeadersWidth = 51
        Me.dgvEmails.RowTemplate.Height = 24
        Me.dgvEmails.Size = New System.Drawing.Size(1136, 136)
        Me.dgvEmails.TabIndex = 0
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(72, 9)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(0, 16)
        Me.lblSubject.TabIndex = 2
        '
        'lblSender
        '
        Me.lblSender.AutoSize = True
        Me.lblSender.Location = New System.Drawing.Point(72, 37)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(0, 16)
        Me.lblSender.TabIndex = 3
        '
        'lblDateReceived
        '
        Me.lblDateReceived.AutoSize = True
        Me.lblDateReceived.Location = New System.Drawing.Point(113, 62)
        Me.lblDateReceived.Name = "lblDateReceived"
        Me.lblDateReceived.Size = New System.Drawing.Size(0, 16)
        Me.lblDateReceived.TabIndex = 4
        '
        'pnlToolbar
        '
        Me.pnlToolbar.Controls.Add(Me.btnRefresh)
        Me.pnlToolbar.Controls.Add(Me.btnClose)
        Me.pnlToolbar.Controls.Add(Me.btnInbox)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.ShadowDecoration.Parent = Me.pnlToolbar
        Me.pnlToolbar.Size = New System.Drawing.Size(1125, 60)
        Me.pnlToolbar.TabIndex = 7
        '
        'btnRefresh
        '
        Me.btnRefresh.CheckedState.Parent = Me.btnRefresh
        Me.btnRefresh.CustomImages.Parent = Me.btnRefresh
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.HoverState.Parent = Me.btnRefresh
        Me.btnRefresh.Location = New System.Drawing.Point(893, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.ShadowDecoration.Parent = Me.btnRefresh
        Me.btnRefresh.Size = New System.Drawing.Size(100, 35)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        '
        'btnClose
        '
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(995, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(100, 35)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        '
        'btnInbox
        '
        Me.btnInbox.CheckedState.Parent = Me.btnInbox
        Me.btnInbox.CustomImages.Parent = Me.btnInbox
        Me.btnInbox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnInbox.ForeColor = System.Drawing.Color.White
        Me.btnInbox.HoverState.Parent = Me.btnInbox
        Me.btnInbox.Location = New System.Drawing.Point(791, 12)
        Me.btnInbox.Name = "btnInbox"
        Me.btnInbox.ShadowDecoration.Parent = Me.btnInbox
        Me.btnInbox.Size = New System.Drawing.Size(100, 35)
        Me.btnInbox.TabIndex = 0
        Me.btnInbox.Text = "Inbox"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Date Received:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Subject:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.txtEmailBody)
        Me.Guna2Panel1.Controls.Add(Me.btnPrintEmail)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.lblDateReceived)
        Me.Guna2Panel1.Controls.Add(Me.lblSender)
        Me.Guna2Panel1.Controls.Add(Me.lblSubject)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 205)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1115, 338)
        Me.Guna2Panel1.TabIndex = 11
        '
        'txtEmailBody
        '
        Me.txtEmailBody.Location = New System.Drawing.Point(16, 84)
        Me.txtEmailBody.Name = "txtEmailBody"
        Me.txtEmailBody.Size = New System.Drawing.Size(1078, 253)
        Me.txtEmailBody.TabIndex = 11
        Me.txtEmailBody.Text = ""
        '
        'btnPrintEmail
        '
        Me.btnPrintEmail.CheckedState.Parent = Me.btnPrintEmail
        Me.btnPrintEmail.CustomImages.Parent = Me.btnPrintEmail
        Me.btnPrintEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPrintEmail.ForeColor = System.Drawing.Color.White
        Me.btnPrintEmail.HoverState.Parent = Me.btnPrintEmail
        Me.btnPrintEmail.Location = New System.Drawing.Point(958, 43)
        Me.btnPrintEmail.Name = "btnPrintEmail"
        Me.btnPrintEmail.ShadowDecoration.Parent = Me.btnPrintEmail
        Me.btnPrintEmail.Size = New System.Drawing.Size(100, 35)
        Me.btnPrintEmail.TabIndex = 3
        Me.btnPrintEmail.Text = "Print"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmEmailList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 562)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.dgvEmails)
        Me.Name = "frmEmailList"
        Me.Text = "frmEmailList"
        CType(Me.dgvEmails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToolbar.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEmails As DataGridView
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblSender As Label
    Friend WithEvents lblDateReceived As Label
    Friend WithEvents pnlToolbar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInbox As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPrintEmail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtEmailBody As RichTextBox
End Class
