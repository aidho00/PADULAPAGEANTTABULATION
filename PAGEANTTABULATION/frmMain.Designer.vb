<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.systemSign = New System.Windows.Forms.Panel()
        Me.PageantTitle = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.schoolLogo = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblDay = New System.Windows.Forms.ToolStripLabel()
        Me.btnScoring = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PreliminaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTabulation = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.judge = New System.Windows.Forms.ToolStripLabel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.systemSign.SuspendLayout()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schoolLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'systemSign
        '
        Me.systemSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.systemSign.Controls.Add(Me.PageantTitle)
        Me.systemSign.Controls.Add(Me.btnLogout)
        Me.systemSign.Controls.Add(Me.Label18)
        Me.systemSign.Controls.Add(Me.schoolLogo)
        Me.systemSign.Dock = System.Windows.Forms.DockStyle.Top
        Me.systemSign.Location = New System.Drawing.Point(0, 0)
        Me.systemSign.Name = "systemSign"
        Me.systemSign.Padding = New System.Windows.Forms.Padding(5)
        Me.systemSign.Size = New System.Drawing.Size(1022, 36)
        Me.systemSign.TabIndex = 7
        '
        'PageantTitle
        '
        Me.PageantTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PageantTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.PageantTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageantTitle.ForeColor = System.Drawing.Color.White
        Me.PageantTitle.Location = New System.Drawing.Point(31, 5)
        Me.PageantTitle.Name = "PageantTitle"
        Me.PageantTitle.Size = New System.Drawing.Size(457, 26)
        Me.PageantTitle.TabIndex = 355
        Me.PageantTitle.Text = "PAGEANT"
        Me.PageantTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(952, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(18, 26)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogout.TabIndex = 353
        Me.btnLogout.TabStop = False
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(970, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 26)
        Me.Label18.TabIndex = 352
        Me.Label18.Text = "Logout"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'schoolLogo
        '
        Me.schoolLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.schoolLogo.Image = CType(resources.GetObject("schoolLogo.Image"), System.Drawing.Image)
        Me.schoolLogo.Location = New System.Drawing.Point(5, 5)
        Me.schoolLogo.Name = "schoolLogo"
        Me.schoolLogo.Size = New System.Drawing.Size(26, 26)
        Me.schoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.schoolLogo.TabIndex = 0
        Me.schoolLogo.TabStop = False
        Me.schoolLogo.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDay, Me.btnScoring, Me.btnTabulation, Me.ToolStripLabel1, Me.judge})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 36)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1022, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblDay
        '
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(0, 22)
        '
        'btnScoring
        '
        Me.btnScoring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnScoring.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreliminaryToolStripMenuItem, Me.FinalToolStripMenuItem})
        Me.btnScoring.Image = CType(resources.GetObject("btnScoring.Image"), System.Drawing.Image)
        Me.btnScoring.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnScoring.Name = "btnScoring"
        Me.btnScoring.Size = New System.Drawing.Size(60, 22)
        Me.btnScoring.Text = "Scoring"
        '
        'PreliminaryToolStripMenuItem
        '
        Me.PreliminaryToolStripMenuItem.Name = "PreliminaryToolStripMenuItem"
        Me.PreliminaryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreliminaryToolStripMenuItem.Text = "Preliminary"
        '
        'FinalToolStripMenuItem
        '
        Me.FinalToolStripMenuItem.Name = "FinalToolStripMenuItem"
        Me.FinalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FinalToolStripMenuItem.Text = "Final"
        '
        'btnTabulation
        '
        Me.btnTabulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnTabulation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.btnTabulation.Image = CType(resources.GetObject("btnTabulation.Image"), System.Drawing.Image)
        Me.btnTabulation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTabulation.Name = "btnTabulation"
        Me.btnTabulation.Size = New System.Drawing.Size(75, 22)
        Me.btnTabulation.Text = "Tabulation"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(10, 22)
        Me.ToolStripLabel1.Text = " "
        '
        'judge
        '
        Me.judge.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.judge.Name = "judge"
        Me.judge.Size = New System.Drawing.Size(38, 22)
        Me.judge.Text = "Judge"
        '
        'MainPanel
        '
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 61)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1022, 705)
        Me.MainPanel.TabIndex = 12
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.systemSign)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.systemSign.ResumeLayout(False)
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schoolLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents systemSign As Panel
    Friend WithEvents btnLogout As PictureBox
    Friend WithEvents schoolLogo As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lblDay As ToolStripLabel
    Friend WithEvents btnScoring As ToolStripDropDownButton
    Friend WithEvents PreliminaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnTabulation As ToolStripDropDownButton
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainPanel As Panel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents judge As ToolStripLabel
    Friend WithEvents PageantTitle As Label
End Class
