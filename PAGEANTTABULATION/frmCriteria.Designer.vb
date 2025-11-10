<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriteria
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCriteria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.criteriaID = New System.Windows.Forms.Label()
        Me.criteriaType = New System.Windows.Forms.Label()
        Me.txtCriteriaDesc = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddCriteria = New System.Windows.Forms.Button()
        Me.btnUpdateCriteria = New System.Windows.Forms.Button()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SubCriteriaPanel = New System.Windows.Forms.Panel()
        Me.dgSubCriteria = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalPercentage = New System.Windows.Forms.Label()
        Me.SubCriteriaID = New System.Windows.Forms.Label()
        Me.SubCriteriaAddPanel = New System.Windows.Forms.Panel()
        Me.criteriaID2 = New System.Windows.Forms.Label()
        Me.btnClose2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddSubCriteria = New System.Windows.Forms.Button()
        Me.btnUpdateSubCriteria = New System.Windows.Forms.Button()
        Me.txtsubCriteriaPercentage = New System.Windows.Forms.TextBox()
        Me.txtSubCriteria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SubCriteriaPanel.SuspendLayout()
        CType(Me.dgSubCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubCriteriaAddPanel.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Criteria Description"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 5)
        Me.Panel1.TabIndex = 224
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(578, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(19, 19)
        Me.btnClose.TabIndex = 225
        Me.btnClose.Text = "✕"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'criteriaID
        '
        Me.criteriaID.AutoSize = True
        Me.criteriaID.Location = New System.Drawing.Point(134, 16)
        Me.criteriaID.Name = "criteriaID"
        Me.criteriaID.Size = New System.Drawing.Size(14, 16)
        Me.criteriaID.TabIndex = 227
        Me.criteriaID.Text = "0"
        Me.criteriaID.Visible = False
        '
        'criteriaType
        '
        Me.criteriaType.AutoSize = True
        Me.criteriaType.Location = New System.Drawing.Point(151, 16)
        Me.criteriaType.Name = "criteriaType"
        Me.criteriaType.Size = New System.Drawing.Size(14, 16)
        Me.criteriaType.TabIndex = 227
        Me.criteriaType.Text = "0"
        Me.criteriaType.Visible = False
        '
        'txtCriteriaDesc
        '
        Me.txtCriteriaDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCriteriaDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriteriaDesc.Location = New System.Drawing.Point(126, 44)
        Me.txtCriteriaDesc.Name = "txtCriteriaDesc"
        Me.txtCriteriaDesc.Size = New System.Drawing.Size(460, 21)
        Me.txtCriteriaDesc.TabIndex = 228
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddCriteria)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnUpdateCriteria)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(448, 72)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(140, 37)
        Me.FlowLayoutPanel1.TabIndex = 356
        '
        'btnAddCriteria
        '
        Me.btnAddCriteria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddCriteria.BackColor = System.Drawing.Color.Black
        Me.btnAddCriteria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCriteria.FlatAppearance.BorderSize = 0
        Me.btnAddCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCriteria.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCriteria.ForeColor = System.Drawing.Color.White
        Me.btnAddCriteria.Location = New System.Drawing.Point(76, 3)
        Me.btnAddCriteria.Name = "btnAddCriteria"
        Me.btnAddCriteria.Size = New System.Drawing.Size(61, 27)
        Me.btnAddCriteria.TabIndex = 7
        Me.btnAddCriteria.Text = "Save"
        Me.btnAddCriteria.UseVisualStyleBackColor = False
        '
        'btnUpdateCriteria
        '
        Me.btnUpdateCriteria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdateCriteria.BackColor = System.Drawing.Color.Black
        Me.btnUpdateCriteria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateCriteria.FlatAppearance.BorderSize = 0
        Me.btnUpdateCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateCriteria.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCriteria.ForeColor = System.Drawing.Color.White
        Me.btnUpdateCriteria.Location = New System.Drawing.Point(9, 3)
        Me.btnUpdateCriteria.Name = "btnUpdateCriteria"
        Me.btnUpdateCriteria.Size = New System.Drawing.Size(61, 27)
        Me.btnUpdateCriteria.TabIndex = 8
        Me.btnUpdateCriteria.Text = "Update"
        Me.btnUpdateCriteria.UseVisualStyleBackColor = False
        '
        'txtPercentage
        '
        Me.txtPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPercentage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPercentage.Location = New System.Drawing.Point(126, 79)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(72, 21)
        Me.txtPercentage.TabIndex = 228
        Me.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "Percentage"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Panel2)
        Me.Panel.Controls.Add(Me.SubCriteriaPanel)
        Me.Panel.Controls.Add(Me.SubCriteriaAddPanel)
        Me.Panel.Location = New System.Drawing.Point(0, 126)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(597, 223)
        Me.Panel.TabIndex = 357
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 5)
        Me.Panel2.TabIndex = 360
        '
        'SubCriteriaPanel
        '
        Me.SubCriteriaPanel.Controls.Add(Me.dgSubCriteria)
        Me.SubCriteriaPanel.Controls.Add(Me.btnAdd)
        Me.SubCriteriaPanel.Controls.Add(Me.Label12)
        Me.SubCriteriaPanel.Controls.Add(Me.Label3)
        Me.SubCriteriaPanel.Controls.Add(Me.lblTotalPercentage)
        Me.SubCriteriaPanel.Controls.Add(Me.SubCriteriaID)
        Me.SubCriteriaPanel.Location = New System.Drawing.Point(4, 9)
        Me.SubCriteriaPanel.Name = "SubCriteriaPanel"
        Me.SubCriteriaPanel.Size = New System.Drawing.Size(588, 205)
        Me.SubCriteriaPanel.TabIndex = 358
        '
        'dgSubCriteria
        '
        Me.dgSubCriteria.AllowUserToAddRows = False
        Me.dgSubCriteria.AllowUserToDeleteRows = False
        Me.dgSubCriteria.BackgroundColor = System.Drawing.Color.White
        Me.dgSubCriteria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSubCriteria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgSubCriteria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSubCriteria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSubCriteria.ColumnHeadersHeight = 40
        Me.dgSubCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgSubCriteria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.colUpdate})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSubCriteria.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgSubCriteria.EnableHeadersVisualStyles = False
        Me.dgSubCriteria.GridColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgSubCriteria.Location = New System.Drawing.Point(7, 26)
        Me.dgSubCriteria.Name = "dgSubCriteria"
        Me.dgSubCriteria.ReadOnly = True
        Me.dgSubCriteria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgSubCriteria.RowHeadersVisible = False
        Me.dgSubCriteria.RowTemplate.Height = 26
        Me.dgSubCriteria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSubCriteria.Size = New System.Drawing.Size(573, 152)
        Me.dgSubCriteria.TabIndex = 214
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sub-Criteria"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Percentage"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 95
        '
        'colUpdate
        '
        Me.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUpdate.HeaderText = ""
        Me.colUpdate.Name = "colUpdate"
        Me.colUpdate.ReadOnly = True
        Me.colUpdate.Text = "Edit"
        Me.colUpdate.UseColumnTextForButtonValue = True
        Me.colUpdate.Width = 5
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(21, 17)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 354
        Me.btnAdd.TabStop = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(22, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 17)
        Me.Label12.TabIndex = 355
        Me.Label12.Text = "Create New     |   Sub-Criteria"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(284, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 16)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'lblTotalPercentage
        '
        Me.lblTotalPercentage.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPercentage.ForeColor = System.Drawing.Color.Black
        Me.lblTotalPercentage.Location = New System.Drawing.Point(433, 181)
        Me.lblTotalPercentage.Name = "lblTotalPercentage"
        Me.lblTotalPercentage.Size = New System.Drawing.Size(146, 16)
        Me.lblTotalPercentage.TabIndex = 226
        Me.lblTotalPercentage.Text = "0"
        Me.lblTotalPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalPercentage.Visible = False
        '
        'SubCriteriaID
        '
        Me.SubCriteriaID.AutoSize = True
        Me.SubCriteriaID.Location = New System.Drawing.Point(251, 6)
        Me.SubCriteriaID.Name = "SubCriteriaID"
        Me.SubCriteriaID.Size = New System.Drawing.Size(14, 16)
        Me.SubCriteriaID.TabIndex = 227
        Me.SubCriteriaID.Text = "0"
        Me.SubCriteriaID.Visible = False
        '
        'SubCriteriaAddPanel
        '
        Me.SubCriteriaAddPanel.Controls.Add(Me.criteriaID2)
        Me.SubCriteriaAddPanel.Controls.Add(Me.btnClose2)
        Me.SubCriteriaAddPanel.Controls.Add(Me.FlowLayoutPanel2)
        Me.SubCriteriaAddPanel.Controls.Add(Me.txtsubCriteriaPercentage)
        Me.SubCriteriaAddPanel.Controls.Add(Me.txtSubCriteria)
        Me.SubCriteriaAddPanel.Controls.Add(Me.Label5)
        Me.SubCriteriaAddPanel.Controls.Add(Me.Label6)
        Me.SubCriteriaAddPanel.Controls.Add(Me.Label7)
        Me.SubCriteriaAddPanel.Location = New System.Drawing.Point(4, 9)
        Me.SubCriteriaAddPanel.Name = "SubCriteriaAddPanel"
        Me.SubCriteriaAddPanel.Size = New System.Drawing.Size(588, 178)
        Me.SubCriteriaAddPanel.TabIndex = 359
        '
        'criteriaID2
        '
        Me.criteriaID2.AutoSize = True
        Me.criteriaID2.Location = New System.Drawing.Point(147, 24)
        Me.criteriaID2.Name = "criteriaID2"
        Me.criteriaID2.Size = New System.Drawing.Size(14, 16)
        Me.criteriaID2.TabIndex = 363
        Me.criteriaID2.Text = "0"
        Me.criteriaID2.Visible = False
        '
        'btnClose2
        '
        Me.btnClose2.AutoSize = True
        Me.btnClose2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose2.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose2.ForeColor = System.Drawing.Color.Black
        Me.btnClose2.Location = New System.Drawing.Point(569, 0)
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(19, 19)
        Me.btnClose2.TabIndex = 362
        Me.btnClose2.Text = "✕"
        Me.btnClose2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAddSubCriteria)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnUpdateSubCriteria)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(269, 98)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(313, 37)
        Me.FlowLayoutPanel2.TabIndex = 361
        '
        'btnAddSubCriteria
        '
        Me.btnAddSubCriteria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddSubCriteria.BackColor = System.Drawing.Color.Black
        Me.btnAddSubCriteria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSubCriteria.FlatAppearance.BorderSize = 0
        Me.btnAddSubCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSubCriteria.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubCriteria.ForeColor = System.Drawing.Color.White
        Me.btnAddSubCriteria.Location = New System.Drawing.Point(249, 3)
        Me.btnAddSubCriteria.Name = "btnAddSubCriteria"
        Me.btnAddSubCriteria.Size = New System.Drawing.Size(61, 27)
        Me.btnAddSubCriteria.TabIndex = 7
        Me.btnAddSubCriteria.Text = "Save"
        Me.btnAddSubCriteria.UseVisualStyleBackColor = False
        '
        'btnUpdateSubCriteria
        '
        Me.btnUpdateSubCriteria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdateSubCriteria.BackColor = System.Drawing.Color.Black
        Me.btnUpdateSubCriteria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateSubCriteria.FlatAppearance.BorderSize = 0
        Me.btnUpdateSubCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSubCriteria.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSubCriteria.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSubCriteria.Location = New System.Drawing.Point(182, 3)
        Me.btnUpdateSubCriteria.Name = "btnUpdateSubCriteria"
        Me.btnUpdateSubCriteria.Size = New System.Drawing.Size(61, 27)
        Me.btnUpdateSubCriteria.TabIndex = 8
        Me.btnUpdateSubCriteria.Text = "Update"
        Me.btnUpdateSubCriteria.UseVisualStyleBackColor = False
        '
        'txtsubCriteriaPercentage
        '
        Me.txtsubCriteriaPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsubCriteriaPercentage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsubCriteriaPercentage.Location = New System.Drawing.Point(150, 105)
        Me.txtsubCriteriaPercentage.Name = "txtsubCriteriaPercentage"
        Me.txtsubCriteriaPercentage.Size = New System.Drawing.Size(81, 21)
        Me.txtsubCriteriaPercentage.TabIndex = 359
        Me.txtsubCriteriaPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubCriteria
        '
        Me.txtSubCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubCriteria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubCriteria.Location = New System.Drawing.Point(150, 70)
        Me.txtSubCriteria.Name = "txtSubCriteria"
        Me.txtSubCriteria.Size = New System.Drawing.Size(429, 21)
        Me.txtSubCriteria.TabIndex = 360
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 357
        Me.Label5.Text = "Percentage"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 16)
        Me.Label6.TabIndex = 358
        Me.Label6.Text = "Sub-Criteria Description"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 16)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "Sub Criteria"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 215
        Me.Label8.Text = "Criteria"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbStatus
        '
        Me.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"OPEN", "CLOSE"})
        Me.cbStatus.Location = New System.Drawing.Point(291, 79)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(103, 21)
        Me.cbStatus.TabIndex = 359
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(237, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 358
        Me.Label9.Text = "Status"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(597, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.txtCriteriaDesc)
        Me.Controls.Add(Me.criteriaType)
        Me.Controls.Add(Me.criteriaID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel.ResumeLayout(False)
        Me.SubCriteriaPanel.ResumeLayout(False)
        Me.SubCriteriaPanel.PerformLayout()
        CType(Me.dgSubCriteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubCriteriaAddPanel.ResumeLayout(False)
        Me.SubCriteriaAddPanel.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Label
    Friend WithEvents criteriaID As Label
    Friend WithEvents criteriaType As Label
    Friend WithEvents txtCriteriaDesc As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAddCriteria As Button
    Friend WithEvents btnUpdateCriteria As Button
    Friend WithEvents txtPercentage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents SubCriteriaAddPanel As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnAddSubCriteria As Button
    Friend WithEvents btnUpdateSubCriteria As Button
    Friend WithEvents txtsubCriteriaPercentage As TextBox
    Friend WithEvents txtSubCriteria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SubCriteriaPanel As Panel
    Friend WithEvents dgSubCriteria As DataGridView
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose2 As Label
    Friend WithEvents SubCriteriaID As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents colUpdate As DataGridViewButtonColumn
    Friend WithEvents criteriaID2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalPercentage As Label
End Class
