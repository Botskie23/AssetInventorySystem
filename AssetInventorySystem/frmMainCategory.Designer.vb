<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainCategory
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtMainCategoryName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMainCategoryCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvMainCategories = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.dgvMainCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMainCategoryName
        '
        Me.txtMainCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMainCategoryName.DefaultText = ""
        Me.txtMainCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMainCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMainCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMainCategoryName.DisabledState.Parent = Me.txtMainCategoryName
        Me.txtMainCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMainCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMainCategoryName.FocusedState.Parent = Me.txtMainCategoryName
        Me.txtMainCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMainCategoryName.HoverState.Parent = Me.txtMainCategoryName
        Me.txtMainCategoryName.Location = New System.Drawing.Point(189, 70)
        Me.txtMainCategoryName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMainCategoryName.Name = "txtMainCategoryName"
        Me.txtMainCategoryName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMainCategoryName.PlaceholderText = ""
        Me.txtMainCategoryName.SelectedText = ""
        Me.txtMainCategoryName.ShadowDecoration.Parent = Me.txtMainCategoryName
        Me.txtMainCategoryName.Size = New System.Drawing.Size(225, 39)
        Me.txtMainCategoryName.TabIndex = 0
        '
        'txtMainCategoryCode
        '
        Me.txtMainCategoryCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMainCategoryCode.DefaultText = ""
        Me.txtMainCategoryCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMainCategoryCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMainCategoryCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMainCategoryCode.DisabledState.Parent = Me.txtMainCategoryCode
        Me.txtMainCategoryCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMainCategoryCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMainCategoryCode.FocusedState.Parent = Me.txtMainCategoryCode
        Me.txtMainCategoryCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMainCategoryCode.HoverState.Parent = Me.txtMainCategoryCode
        Me.txtMainCategoryCode.Location = New System.Drawing.Point(189, 117)
        Me.txtMainCategoryCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMainCategoryCode.Name = "txtMainCategoryCode"
        Me.txtMainCategoryCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMainCategoryCode.PlaceholderText = ""
        Me.txtMainCategoryCode.SelectedText = ""
        Me.txtMainCategoryCode.ShadowDecoration.Parent = Me.txtMainCategoryCode
        Me.txtMainCategoryCode.Size = New System.Drawing.Size(225, 39)
        Me.txtMainCategoryCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Main Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Main Category Code"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(198, 371)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(183, 48)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Tag = "btnAdd"
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(387, 371)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(183, 48)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Tag = "btnAdd"
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(576, 371)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(183, 48)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Tag = "btnAdd"
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvMainCategories
        '
        Me.dgvMainCategories.AllowUserToAddRows = False
        Me.dgvMainCategories.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvMainCategories.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMainCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMainCategories.BackgroundColor = System.Drawing.Color.White
        Me.dgvMainCategories.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMainCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMainCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMainCategories.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMainCategories.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMainCategories.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMainCategories.EnableHeadersVisualStyles = False
        Me.dgvMainCategories.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMainCategories.Location = New System.Drawing.Point(190, 164)
        Me.dgvMainCategories.Name = "dgvMainCategories"
        Me.dgvMainCategories.ReadOnly = True
        Me.dgvMainCategories.RowHeadersVisible = False
        Me.dgvMainCategories.RowHeadersWidth = 51
        Me.dgvMainCategories.RowTemplate.Height = 24
        Me.dgvMainCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMainCategories.Size = New System.Drawing.Size(568, 187)
        Me.dgvMainCategories.TabIndex = 8
        Me.dgvMainCategories.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvMainCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvMainCategories.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvMainCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvMainCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvMainCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvMainCategories.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvMainCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMainCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMainCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvMainCategories.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvMainCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvMainCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvMainCategories.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvMainCategories.ThemeStyle.ReadOnly = True
        Me.dgvMainCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvMainCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMainCategories.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvMainCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvMainCategories.ThemeStyle.RowsStyle.Height = 24
        Me.dgvMainCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMainCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'frmMainCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvMainCategories)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMainCategoryCode)
        Me.Controls.Add(Me.txtMainCategoryName)
        Me.Name = "frmMainCategory"
        Me.Text = "frmMainCategory"
        CType(Me.dgvMainCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMainCategoryName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMainCategoryCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvMainCategories As Guna.UI2.WinForms.Guna2DataGridView
End Class
