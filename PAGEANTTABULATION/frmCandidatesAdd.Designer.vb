<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCandidatesAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCandidatesAdd))
        Me.systemSign = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.candidatePicture = New System.Windows.Forms.PictureBox()
        Me.txtCandidateName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.cbNumber = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.candidateID = New System.Windows.Forms.Label()
        Me.Dummypicture = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.systemSign.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.candidatePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.Dummypicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'systemSign
        '
        Me.systemSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.systemSign.Controls.Add(Me.Label12)
        Me.systemSign.Controls.Add(Me.btnClose)
        Me.systemSign.Dock = System.Windows.Forms.DockStyle.Top
        Me.systemSign.Location = New System.Drawing.Point(0, 0)
        Me.systemSign.Name = "systemSign"
        Me.systemSign.Padding = New System.Windows.Forms.Padding(5)
        Me.systemSign.Size = New System.Drawing.Size(797, 36)
        Me.systemSign.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(772, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 26)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "✕"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Dummypicture)
        Me.Panel4.Controls.Add(Me.btnUpload)
        Me.Panel4.Controls.Add(Me.candidatePicture)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 36)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(294, 351)
        Me.Panel4.TabIndex = 11
        '
        'candidatePicture
        '
        Me.candidatePicture.BackColor = System.Drawing.Color.Black
        Me.candidatePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.candidatePicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.candidatePicture.Location = New System.Drawing.Point(5, 5)
        Me.candidatePicture.Name = "candidatePicture"
        Me.candidatePicture.Padding = New System.Windows.Forms.Padding(5)
        Me.candidatePicture.Size = New System.Drawing.Size(284, 341)
        Me.candidatePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.candidatePicture.TabIndex = 200
        Me.candidatePicture.TabStop = False
        '
        'txtCandidateName
        '
        Me.txtCandidateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCandidateName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCandidateName.Location = New System.Drawing.Point(383, 96)
        Me.txtCandidateName.Name = "txtCandidateName"
        Me.txtCandidateName.Size = New System.Drawing.Size(402, 21)
        Me.txtCandidateName.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(304, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(303, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Candidate Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.FlatAppearance.BorderSize = 0
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(234, 314)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(41, 19)
        Me.btnUpload.TabIndex = 84
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'cbNumber
        '
        Me.cbNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNumber.FormattingEnabled = True
        Me.cbNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cbNumber.Location = New System.Drawing.Point(383, 142)
        Me.cbNumber.Name = "cbNumber"
        Me.cbNumber.Size = New System.Drawing.Size(103, 21)
        Me.cbNumber.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(304, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnUpdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.candidateID)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(314, 351)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(474, 37)
        Me.FlowLayoutPanel1.TabIndex = 86
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAdd.BackColor = System.Drawing.Color.Black
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(298, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(173, 27)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdate.BackColor = System.Drawing.Color.Black
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(119, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(173, 27)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'candidateID
        '
        Me.candidateID.AutoSize = True
        Me.candidateID.Location = New System.Drawing.Point(99, 0)
        Me.candidateID.Name = "candidateID"
        Me.candidateID.Size = New System.Drawing.Size(14, 16)
        Me.candidateID.TabIndex = 228
        Me.candidateID.Text = "0"
        Me.candidateID.Visible = False
        '
        'Dummypicture
        '
        Me.Dummypicture.BackColor = System.Drawing.Color.Transparent
        Me.Dummypicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dummypicture.Image = CType(resources.GetObject("Dummypicture.Image"), System.Drawing.Image)
        Me.Dummypicture.Location = New System.Drawing.Point(183, 316)
        Me.Dummypicture.Name = "Dummypicture"
        Me.Dummypicture.Size = New System.Drawing.Size(22, 23)
        Me.Dummypicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dummypicture.TabIndex = 348
        Me.Dummypicture.TabStop = False
        Me.Dummypicture.Visible = False
        '
        'Label12
        '
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(5, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 26)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Candidates Entry"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCandidatesAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.cbNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCandidateName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.systemSign)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCandidatesAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.systemSign.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.candidatePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.Dummypicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents systemSign As Panel
    Friend WithEvents btnClose As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents candidatePicture As PictureBox
    Friend WithEvents txtCandidateName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents cbNumber As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents candidateID As Label
    Friend WithEvents Dummypicture As PictureBox
    Friend WithEvents Label12 As Label
End Class
