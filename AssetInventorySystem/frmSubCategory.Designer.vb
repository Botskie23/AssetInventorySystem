<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubCategory
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbMainCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSubCategoryCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSubCategoryName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvSubCategories = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvSubCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMainCategory
        '
        Me.cmbMainCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbMainCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMainCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMainCategory.FocusedState.Parent = Me.cmbMainCategory
        Me.cmbMainCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMainCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMainCategory.FormattingEnabled = True
        Me.cmbMainCategory.HoverState.Parent = Me.cmbMainCategory
        Me.cmbMainCategory.ItemHeight = 30
        Me.cmbMainCategory.ItemsAppearance.Parent = Me.cmbMainCategory
        Me.cmbMainCategory.Location = New System.Drawing.Point(323, 33)
        Me.cmbMainCategory.Name = "cmbMainCategory"
        Me.cmbMainCategory.ShadowDecoration.Parent = Me.cmbMainCategory
        Me.cmbMainCategory.Size = New System.Drawing.Size(477, 36)
        Me.cmbMainCategory.TabIndex = 0
        '
        'txtSubCategoryCode
        '
        Me.txtSubCategoryCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubCategoryCode.DefaultText = ""
        Me.txtSubCategoryCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubCategoryCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubCategoryCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubCategoryCode.DisabledState.Parent = Me.txtSubCategoryCode
        Me.txtSubCategoryCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubCategoryCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubCategoryCode.FocusedState.Parent = Me.txtSubCategoryCode
        Me.txtSubCategoryCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubCategoryCode.HoverState.Parent = Me.txtSubCategoryCode
        Me.txtSubCategoryCode.Location = New System.Drawing.Point(322, 128)
        Me.txtSubCategoryCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubCategoryCode.Name = "txtSubCategoryCode"
        Me.txtSubCategoryCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubCategoryCode.PlaceholderText = ""
        Me.txtSubCategoryCode.SelectedText = ""
        Me.txtSubCategoryCode.ShadowDecoration.Parent = Me.txtSubCategoryCode
        Me.txtSubCategoryCode.Size = New System.Drawing.Size(478, 42)
        Me.txtSubCategoryCode.TabIndex = 1
        '
        'txtSubCategoryName
        '
        Me.txtSubCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubCategoryName.DefaultText = ""
        Me.txtSubCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubCategoryName.DisabledState.Parent = Me.txtSubCategoryName
        Me.txtSubCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubCategoryName.FocusedState.Parent = Me.txtSubCategoryName
        Me.txtSubCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubCategoryName.HoverState.Parent = Me.txtSubCategoryName
        Me.txtSubCategoryName.Location = New System.Drawing.Point(322, 76)
        Me.txtSubCategoryName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubCategoryName.Name = "txtSubCategoryName"
        Me.txtSubCategoryName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubCategoryName.PlaceholderText = ""
        Me.txtSubCategoryName.SelectedText = ""
        Me.txtSubCategoryName.ShadowDecoration.Parent = Me.txtSubCategoryName
        Me.txtSubCategoryName.Size = New System.Drawing.Size(478, 42)
        Me.txtSubCategoryName.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.Parent = Me.txtDescription
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.FocusedState.Parent = Me.txtDescription
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.HoverState.Parent = Me.txtDescription
        Me.txtDescription.Location = New System.Drawing.Point(323, 216)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = ""
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.ShadowDecoration.Parent = Me.txtDescription
        Me.txtDescription.Size = New System.Drawing.Size(477, 42)
        Me.txtDescription.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(76, 603)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(226, 43)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        '
        'btnDelete
        '
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(574, 603)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(226, 43)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        '
        'btnEditUpdate
        '
        Me.btnEditUpdate.CheckedState.Parent = Me.btnEditUpdate
        Me.btnEditUpdate.CustomImages.Parent = Me.btnEditUpdate
        Me.btnEditUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditUpdate.ForeColor = System.Drawing.Color.White
        Me.btnEditUpdate.HoverState.Parent = Me.btnEditUpdate
        Me.btnEditUpdate.Location = New System.Drawing.Point(326, 603)
        Me.btnEditUpdate.Name = "btnEditUpdate"
        Me.btnEditUpdate.ShadowDecoration.Parent = Me.btnEditUpdate
        Me.btnEditUpdate.Size = New System.Drawing.Size(226, 43)
        Me.btnEditUpdate.TabIndex = 6
        Me.btnEditUpdate.Text = "Edit"
        '
        'dgvSubCategories
        '
        Me.dgvSubCategories.AllowUserToAddRows = False
        Me.dgvSubCategories.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvSubCategories.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvSubCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubCategories.BackgroundColor = System.Drawing.Color.White
        Me.dgvSubCategories.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSubCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSubCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubCategories.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvSubCategories.ColumnHeadersHeight = 4
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubCategories.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvSubCategories.EnableHeadersVisualStyles = False
        Me.dgvSubCategories.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubCategories.Location = New System.Drawing.Point(76, 284)
        Me.dgvSubCategories.Name = "dgvSubCategories"
        Me.dgvSubCategories.ReadOnly = True
        Me.dgvSubCategories.RowHeadersVisible = False
        Me.dgvSubCategories.RowHeadersWidth = 51
        Me.dgvSubCategories.RowTemplate.Height = 24
        Me.dgvSubCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubCategories.Size = New System.Drawing.Size(724, 297)
        Me.dgvSubCategories.TabIndex = 7
        Me.dgvSubCategories.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvSubCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubCategories.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSubCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSubCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSubCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSubCategories.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSubCategories.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvSubCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSubCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSubCategories.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvSubCategories.ThemeStyle.ReadOnly = True
        Me.dgvSubCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSubCategories.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvSubCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSubCategories.ThemeStyle.RowsStyle.Height = 24
        Me.dgvSubCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Main Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Category Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Sub Category Name"
        '
        'frmSubCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 749)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSubCategories)
        Me.Controls.Add(Me.btnEditUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtSubCategoryName)
        Me.Controls.Add(Me.txtSubCategoryCode)
        Me.Controls.Add(Me.cmbMainCategory)
        Me.Name = "frmSubCategory"
        Me.Text = "frmSubCategory"
        CType(Me.dgvSubCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMainCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSubCategoryCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSubCategoryName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvSubCategories As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
