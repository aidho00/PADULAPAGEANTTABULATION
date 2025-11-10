<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCandidates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCandidates))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.systemSign = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Dummypicture = New System.Windows.Forms.PictureBox()
        Me.candidatePicture = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgCandidates = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.frmTitle = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.systemSign.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Dummypicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.candidatePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgCandidates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'systemSign
        '
        Me.systemSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.systemSign.Controls.Add(Me.Label2)
        Me.systemSign.Controls.Add(Me.btnClose)
        Me.systemSign.Dock = System.Windows.Forms.DockStyle.Top
        Me.systemSign.Location = New System.Drawing.Point(0, 0)
        Me.systemSign.Name = "systemSign"
        Me.systemSign.Padding = New System.Windows.Forms.Padding(5)
        Me.systemSign.Size = New System.Drawing.Size(980, 36)
        Me.systemSign.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(955, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 26)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "✕"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 479)
        Me.Panel2.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Dummypicture)
        Me.Panel4.Controls.Add(Me.candidatePicture)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(629, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(351, 479)
        Me.Panel4.TabIndex = 1
        '
        'Dummypicture
        '
        Me.Dummypicture.BackColor = System.Drawing.Color.Transparent
        Me.Dummypicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dummypicture.Image = CType(resources.GetObject("Dummypicture.Image"), System.Drawing.Image)
        Me.Dummypicture.Location = New System.Drawing.Point(317, 444)
        Me.Dummypicture.Name = "Dummypicture"
        Me.Dummypicture.Size = New System.Drawing.Size(22, 23)
        Me.Dummypicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dummypicture.TabIndex = 349
        Me.Dummypicture.TabStop = False
        Me.Dummypicture.Visible = False
        '
        'candidatePicture
        '
        Me.candidatePicture.BackColor = System.Drawing.Color.Black
        Me.candidatePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.candidatePicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.candidatePicture.Location = New System.Drawing.Point(5, 5)
        Me.candidatePicture.Name = "candidatePicture"
        Me.candidatePicture.Padding = New System.Windows.Forms.Padding(5)
        Me.candidatePicture.Size = New System.Drawing.Size(341, 469)
        Me.candidatePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.candidatePicture.TabIndex = 200
        Me.candidatePicture.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgCandidates)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 479)
        Me.Panel1.TabIndex = 0
        '
        'dgCandidates
        '
        Me.dgCandidates.AllowUserToAddRows = False
        Me.dgCandidates.AllowUserToDeleteRows = False
        Me.dgCandidates.BackgroundColor = System.Drawing.Color.White
        Me.dgCandidates.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCandidates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgCandidates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCandidates.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgCandidates.ColumnHeadersHeight = 40
        Me.dgCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCandidates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.colUpdate})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCandidates.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgCandidates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCandidates.EnableHeadersVisualStyles = False
        Me.dgCandidates.GridColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgCandidates.Location = New System.Drawing.Point(0, 33)
        Me.dgCandidates.Name = "dgCandidates"
        Me.dgCandidates.ReadOnly = True
        Me.dgCandidates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgCandidates.RowHeadersVisible = False
        Me.dgCandidates.RowTemplate.Height = 26
        Me.dgCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCandidates.Size = New System.Drawing.Size(629, 446)
        Me.dgCandidates.TabIndex = 209
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "No."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 49
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'colUpdate
        '
        Me.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colUpdate.DefaultCellStyle = DataGridViewCellStyle5
        Me.colUpdate.HeaderText = ""
        Me.colUpdate.Name = "colUpdate"
        Me.colUpdate.ReadOnly = True
        Me.colUpdate.Text = "Edit"
        Me.colUpdate.UseColumnTextForButtonValue = True
        Me.colUpdate.Width = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(629, 33)
        Me.Panel3.TabIndex = 208
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.cbGender)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.txtSearch)
        Me.Panel8.Controls.Add(Me.frmTitle)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Controls.Add(Me.btnAdd)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel8.Size = New System.Drawing.Size(629, 33)
        Me.Panel8.TabIndex = 12
        '
        'cbGender
        '
        Me.cbGender.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbGender.Location = New System.Drawing.Point(536, 3)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(91, 28)
        Me.cbGender.TabIndex = 358
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(534, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 27)
        Me.Label1.TabIndex = 357
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(186, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(348, 27)
        Me.txtSearch.TabIndex = 355
        '
        'frmTitle
        '
        Me.frmTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.frmTitle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmTitle.ForeColor = System.Drawing.Color.Black
        Me.frmTitle.Location = New System.Drawing.Point(134, 3)
        Me.frmTitle.Name = "frmTitle"
        Me.frmTitle.Size = New System.Drawing.Size(52, 27)
        Me.frmTitle.TabIndex = 354
        Me.frmTitle.Text = " Search"
        Me.frmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(30, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 27)
        Me.Label12.TabIndex = 353
        Me.Label12.Text = "Create New     |"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(27, 27)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 351
        Me.btnAdd.TabStop = False
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Candidates"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCandidates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.systemSign)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCandidates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.systemSign.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.Dummypicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.candidatePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgCandidates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents systemSign As Panel
    Friend WithEvents btnClose As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgCandidates As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents candidatePicture As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents frmTitle As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents colUpdate As DataGridViewButtonColumn
    Friend WithEvents Dummypicture As PictureBox
    Friend WithEvents Label2 As Label
End Class
