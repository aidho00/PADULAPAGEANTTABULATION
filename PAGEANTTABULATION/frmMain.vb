Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmMain

#Region "Drag Form"

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles systemSign.MouseDown  ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles systemSign.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles systemSign.MouseUp   ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region


    Sub PageantDescription()
        cn.Close()
        cn.Open()
        cm = New MySqlCommand("select * from tbl_events", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            PageantTitle.Text = dr.Item("event_name").ToString & " " & dr.Item("event_year").ToString
        Else
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub PreliminaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreliminaryToolStripMenuItem.Click
        cn.Close()
        cn.Open()
        cm = New MySqlCommand("SELECT judging_name FROM tbl_judging_setting WHERE judging_name = 'PRELIMINARY' and judging_status = 'OPEN'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            OpenForm(frmScoringPrelim)
        Else
            MsgBox("Preliminary judging is close. Unable to proceed.", MsgBoxStyle.Exclamation)
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub FinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalToolStripMenuItem.Click
        cn.Close()
        cn.Open()
        cm = New MySqlCommand("SELECT judging_name FROM tbl_judging_setting WHERE judging_name = 'FINAL' and judging_status = 'OPEN'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            OpenForm(frmScoringFinal)
        Else
            MsgBox("Final judging is close. Unable to proceed.", MsgBoxStyle.Exclamation)
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frmSettings.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        judge.Text = str_user
        If str_role = "Administrator" Then
            btnTabulation.Visible = True
            btnScoring.Visible = True
        Else
            btnTabulation.Visible = False
            btnScoring.Visible = True
        End If
        Try
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("select event_banner from tbl_events", cn)
            dr = cm.ExecuteReader
            While dr.Read
                Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(0, 0, array, 0, CInt(len))
                Dim ms As New MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)
                MainPanel.BackgroundImage = bitmap
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MainPanel.BackgroundImage = Nothing
        End Try

        PageantDescription()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure you want to logout?", vbYesNo + vbQuestion) = vbYes Then
            Me.Close()
            frmLogin.Show()
        Else
        End If
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        frmTabulationReport.Show()
        'frmReport.Show()
    End Sub

    Private Sub btnScoring_Click(sender As Object, e As EventArgs) Handles btnScoring.Click

    End Sub
End Class