<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssetList
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.dgvAssets = New System.Windows.Forms.DataGridView()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnOpenITAssetAddForm = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(115, 102)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(467, 22)
        Me.txtSearch.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(56, 105)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(53, 16)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search:"
        '
        'dgvAssets
        '
        Me.dgvAssets.AllowUserToAddRows = False
        Me.dgvAssets.AllowUserToDeleteRows = False
        Me.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssets.Location = New System.Drawing.Point(64, 137)
        Me.dgvAssets.Name = "dgvAssets"
        Me.dgvAssets.RowHeadersWidth = 51
        Me.dgvAssets.RowTemplate.Height = 24
        Me.dgvAssets.Size = New System.Drawing.Size(726, 491)
        Me.dgvAssets.TabIndex = 2
        Me.dgvAssets.TabStop = False
        '
        'picQRCode
        '
        Me.picQRCode.Location = New System.Drawing.Point(814, 102)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(283, 267)
        Me.picQRCode.TabIndex = 3
        Me.picQRCode.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(905, 586)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 41)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(991, 587)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 41)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(909, 414)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 22)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(910, 498)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(187, 22)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(909, 470)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(187, 22)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(910, 442)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(187, 22)
        Me.TextBox5.TabIndex = 9
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(819, 587)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 41)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print QR Code"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnOpenITAssetAddForm
        '
        Me.btnOpenITAssetAddForm.CheckedState.Parent = Me.btnOpenITAssetAddForm
        Me.btnOpenITAssetAddForm.CustomImages.Parent = Me.btnOpenITAssetAddForm
        Me.btnOpenITAssetAddForm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnOpenITAssetAddForm.ForeColor = System.Drawing.Color.White
        Me.btnOpenITAssetAddForm.HoverState.Parent = Me.btnOpenITAssetAddForm
        Me.btnOpenITAssetAddForm.Location = New System.Drawing.Point(824, 537)
        Me.btnOpenITAssetAddForm.Name = "btnOpenITAssetAddForm"
        Me.btnOpenITAssetAddForm.ShadowDecoration.Parent = Me.btnOpenITAssetAddForm
        Me.btnOpenITAssetAddForm.Size = New System.Drawing.Size(97, 32)
        Me.btnOpenITAssetAddForm.TabIndex = 11
        Me.btnOpenITAssetAddForm.Text = "Add Asset"
        '
        'frmAssetList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 671)
        Me.Controls.Add(Me.btnOpenITAssetAddForm)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.picQRCode)
        Me.Controls.Add(Me.dgvAssets)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAssetList"
        Me.Text = "frmAssetList"
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents dgvAssets As DataGridView
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnOpenITAssetAddForm As Guna.UI2.WinForms.Guna2Button
End Class
