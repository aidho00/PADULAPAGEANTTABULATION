<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabulationReport
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.systemSign = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelAcad = New System.Windows.Forms.Panel()
        Me.cbRound = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbCriteria = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPerCriteria = New System.Windows.Forms.Button()
        Me.btnPerCriteriaJudge = New System.Windows.Forms.Button()
        Me.btnOverall = New System.Windows.Forms.Button()
        Me.dg_report = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.systemSign.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanelAcad.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.systemSign.Size = New System.Drawing.Size(1175, 36)
        Me.systemSign.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tabulation Report"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(1150, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 26)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "✕"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(245, 576)
        Me.Panel1.TabIndex = 11
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PanelAcad)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPerCriteria)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPerCriteriaJudge)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOverall)
        Me.FlowLayoutPanel1.Controls.Add(Me.dg_report)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(235, 566)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'PanelAcad
        '
        Me.PanelAcad.Controls.Add(Me.cbRound)
        Me.PanelAcad.Controls.Add(Me.Label1)
        Me.PanelAcad.Location = New System.Drawing.Point(3, 3)
        Me.PanelAcad.Name = "PanelAcad"
        Me.PanelAcad.Size = New System.Drawing.Size(229, 44)
        Me.PanelAcad.TabIndex = 1
        '
        'cbRound
        '
        Me.cbRound.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRound.FormattingEnabled = True
        Me.cbRound.Items.AddRange(New Object() {"Preliminary", "Final"})
        Me.cbRound.Location = New System.Drawing.Point(0, 16)
        Me.cbRound.Name = "cbRound"
        Me.cbRound.Size = New System.Drawing.Size(229, 24)
        Me.cbRound.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Round"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cbGender)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(3, 53)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(229, 44)
        Me.Panel6.TabIndex = 16
        '
        'cbGender
        '
        Me.cbGender.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbGender.Location = New System.Drawing.Point(0, 16)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(229, 24)
        Me.cbGender.TabIndex = 91
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Gender"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbCriteria)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(3, 103)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(229, 44)
        Me.Panel3.TabIndex = 22
        '
        'cbCriteria
        '
        Me.cbCriteria.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCriteria.FormattingEnabled = True
        Me.cbCriteria.Location = New System.Drawing.Point(0, 16)
        Me.cbCriteria.Name = "cbCriteria"
        Me.cbCriteria.Size = New System.Drawing.Size(229, 24)
        Me.cbCriteria.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Criteria"
        '
        'btnPerCriteria
        '
        Me.btnPerCriteria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPerCriteria.BackColor = System.Drawing.Color.Black
        Me.btnPerCriteria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPerCriteria.FlatAppearance.BorderSize = 0
        Me.btnPerCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerCriteria.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerCriteria.ForeColor = System.Drawing.Color.White
        Me.btnPerCriteria.Location = New System.Drawing.Point(3, 153)
        Me.btnPerCriteria.Name = "btnPerCriteria"
        Me.btnPerCriteria.Size = New System.Drawing.Size(229, 41)
        Me.btnPerCriteria.TabIndex = 23
        Me.btnPerCriteria.Text = "Generate Per Criteria Result"
        Me.btnPerCriteria.UseVisualStyleBackColor = False
        '
        'btnPerCriteriaJudge
        '
        Me.btnPerCriteriaJudge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPerCriteriaJudge.BackColor = System.Drawing.Color.Black
        Me.btnPerCriteriaJudge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPerCriteriaJudge.FlatAppearance.BorderSize = 0
        Me.btnPerCriteriaJudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerCriteriaJudge.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerCriteriaJudge.ForeColor = System.Drawing.Color.White
        Me.btnPerCriteriaJudge.Location = New System.Drawing.Point(3, 200)
        Me.btnPerCriteriaJudge.Name = "btnPerCriteriaJudge"
        Me.btnPerCriteriaJudge.Size = New System.Drawing.Size(229, 41)
        Me.btnPerCriteriaJudge.TabIndex = 24
        Me.btnPerCriteriaJudge.Text = "Generate Per Criteria - Judge Result"
        Me.btnPerCriteriaJudge.UseVisualStyleBackColor = False
        '
        'btnOverall
        '
        Me.btnOverall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOverall.BackColor = System.Drawing.Color.Black
        Me.btnOverall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOverall.FlatAppearance.BorderSize = 0
        Me.btnOverall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverall.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverall.ForeColor = System.Drawing.Color.White
        Me.btnOverall.Location = New System.Drawing.Point(3, 247)
        Me.btnOverall.Name = "btnOverall"
        Me.btnOverall.Size = New System.Drawing.Size(229, 41)
        Me.btnOverall.TabIndex = 25
        Me.btnOverall.Text = "Generate Overall Result"
        Me.btnOverall.UseVisualStyleBackColor = False
        '
        'dg_report
        '
        Me.dg_report.AllowUserToAddRows = False
        Me.dg_report.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dg_report.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_report.BackgroundColor = System.Drawing.Color.White
        Me.dg_report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_report.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_report.ColumnHeadersHeight = 30
        Me.dg_report.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_report.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg_report.EnableHeadersVisualStyles = False
        Me.dg_report.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dg_report.Location = New System.Drawing.Point(3, 294)
        Me.dg_report.MultiSelect = False
        Me.dg_report.Name = "dg_report"
        Me.dg_report.ReadOnly = True
        Me.dg_report.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_report.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_report.RowHeadersWidth = 25
        Me.dg_report.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dg_report.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg_report.RowTemplate.Height = 20
        Me.dg_report.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_report.Size = New System.Drawing.Size(229, 39)
        Me.dg_report.TabIndex = 169
        Me.dg_report.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ReportViewer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(245, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(930, 576)
        Me.Panel2.TabIndex = 12
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.ShowCloseButton = False
        Me.ReportViewer.ShowParameterPanelButton = False
        Me.ReportViewer.Size = New System.Drawing.Size(930, 576)
        Me.ReportViewer.TabIndex = 168
        Me.ReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmTabulationReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1175, 612)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.systemSign)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmTabulationReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.systemSign.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PanelAcad.ResumeLayout(False)
        Me.PanelAcad.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dg_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents systemSign As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PanelAcad As Panel
    Friend WithEvents cbRound As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbCriteria As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPerCriteria As Button
    Friend WithEvents btnPerCriteriaJudge As Button
    Friend WithEvents btnOverall As Button
    Friend WithEvents dg_report As DataGridView
End Class
