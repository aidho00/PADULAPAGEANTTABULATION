Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmSettings
    Dim arrImage() As Byte
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

    Sub PageantBannerphoto()
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
                banner.Image = bitmap
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            banner.Image = Nothing
        End Try
    End Sub

    Sub elimination_setting()
        cn.Close()
        cn.Open()
        cm = New MySqlCommand("select judging_status from tbl_judging_setting where judging_name = 'PRELIMINARY'", cn)
        cbPrelim.Text = cm.ExecuteScalar
        cn.Close()
    End Sub

    Sub pageant_setting()
        cn.Close()
        cn.Open()
        cm = New MySqlCommand("select event_name from tbl_events", cn)
        txtPageantTitle.Text = cm.ExecuteScalar
        cn.Close()

        cn.Close()
        cn.Open()
        cm = New MySqlCommand("select event_year from tbl_events", cn)
        txtPageantYear.Text = cm.ExecuteScalar
        cn.Close()
    End Sub

    Sub final_setting()
        cn.Close()
        cn.Open()
        cm = New MySqlCommand("select judging_status from tbl_judging_setting where judging_name = 'FINAL'", cn)
        cbFinal.Text = cm.ExecuteScalar
        cn.Close()
    End Sub

    Sub PreliminaryCriteriaList()
        Try

            dgPrelim_criteria.Rows.Clear()
            Dim sql As String
            sql = "SELECT `ID`, `criteria_name`, `percentage`, `criteria_status` FROM `tbl_criterias`"
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgPrelim_criteria.Rows.Add(dr.Item("ID").ToString, dr.Item("criteria_name").ToString, dr.Item("percentage").ToString, dr.Item("criteria_status").ToString)
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            dr.Close()
            cn.Close()
            dgPrelim_criteria.Rows.Clear()
        End Try
    End Sub

    Sub FinalCriteriaList()
        Try

            dgFinal_criteria.Rows.Clear()
            Dim sql As String
            sql = "SELECT `ID`, `criteria_name`, `percentage`, `criteria_status` FROM `tbl_final_criterias`"
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgFinal_criteria.Rows.Add(dr.Item("ID").ToString, dr.Item("criteria_name").ToString, dr.Item("percentage").ToString, dr.Item("criteria_status").ToString)
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            dr.Close()
            cn.Close()
            dgFinal_criteria.Rows.Clear()
        End Try
    End Sub

    Private Sub btnAddPrelimCriteria_Click(sender As Object, e As EventArgs) Handles btnAddPrelimCriteria.Click
        frmCriteria.Label8.Text = "Preliminary Criteria"
        frmCriteria.criteriaType.Text = "Preliminary"
        frmCriteria.txtCriteriaDesc.Text = String.Empty
        frmCriteria.txtPercentage.Text = String.Empty
        frmCriteria.btnAddCriteria.Visible = True
        frmCriteria.btnUpdateCriteria.Visible = False
        frmCriteria.Size = New Size(599, 122)
        frmCriteria.ShowDialog()
    End Sub

    Private Sub btnAddFinalCriteria_Click(sender As Object, e As EventArgs) Handles btnAddFinalCriteria.Click
        frmCriteria.Label8.Text = "Final Criteria"
        frmCriteria.criteriaType.Text = "Final"
        frmCriteria.txtCriteriaDesc.Text = String.Empty
        frmCriteria.txtPercentage.Text = String.Empty
        frmCriteria.btnAddCriteria.Visible = True
        frmCriteria.btnUpdateCriteria.Visible = False
        frmCriteria.Size = New Size(599, 122)
        frmCriteria.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddCandidates_Click(sender As Object, e As EventArgs) Handles btnAddCandidates.Click
        frmCandidates.CandidatesList()
        frmCandidates.ShowDialog()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fillCombo("select criteria_name, ID from tbl_criterias", cbPrelim, "tbl_criterias", "criteria_name", "ID")
        'fillCombo("select criteria_name, ID from tbl_final_criterias", cbFinal, "tbl_final_criterias", "criteria_name", "ID")
        PageantBannerphoto()
        elimination_setting()
        final_setting()
        pageant_setting()
        PreliminaryCriteriaList()
        FinalCriteriaList()
    End Sub

    Private Sub btnUpdateCriteriaStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateCriteriaStatus.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Update judging status?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = DialogResult.No Then
        Else
            query("UPDATE tbl_judging_setting set judging_status  = '" & cbPrelim.Text & "' where judging_name = 'PRELIMINARY'")
            query("UPDATE tbl_judging_setting set judging_status  = '" & cbFinal.Text & "' where judging_name = 'FINAL'")
            MessageBox.Show("Judging status updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPageantSave_Click(sender As Object, e As EventArgs) Handles btnPageantSave.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Update pageant setting?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = DialogResult.No Then

        Else
            query("UPDATE tbl_events set event_name  = '" & txtPageantTitle.Text & "', event_year  = '" & txtPageantYear.Text & "'")
            MessageBox.Show("Pageant settings updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUploadBanner_Click(sender As Object, e As EventArgs) Handles btnUploadBanner.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            banner.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSaveBanner_Click(sender As Object, e As EventArgs) Handles btnSaveBanner.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Update pageant banner?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = DialogResult.No Then

        Else
            Try
                cn.Close()
                cn.Open()
                Dim FileSize As UInt32

                Dim mstream As New System.IO.MemoryStream()
                banner.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer()
                FileSize = mstream.Length
                mstream.Close()

                Dim sql As String = "Update tbl_events set event_banner = @cphoto where ID = '1'"
                Dim cmd As New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@cphoto", arrImage)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Pageant banner updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("File too large.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnResetPrelimScores_Click(sender As Object, e As EventArgs) Handles btnResetPrelimScores.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Are you sure you want to reset preliminary scores?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If dr = DialogResult.No Then
        Else
            Dim dr2 As DialogResult
            dr2 = MessageBox.Show("Are you really really sure you want to reset preliminary scores? This will reset all the data.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If dr2 = DialogResult.No Then
            Else
                query("delete from tbl_scoring")
                query("delete from tbl_subscoring")
                MessageBox.Show("Preliminary scores successfully reseted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnResetFinalScores_Click(sender As Object, e As EventArgs) Handles btnResetFinalScores.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Are you sure you want to reset Final scores?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If dr = DialogResult.No Then
        Else
            Dim dr2 As DialogResult
            dr2 = MessageBox.Show("Are you really really sure you want to reset Final scores? This will reset all the data.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If dr2 = DialogResult.No Then
            Else
                query("delete from tbl_final_scoring")
                query("delete from tbl_final_subscoring")
                MessageBox.Show("Final scores successfully reseted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgPrelim_criteria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPrelim_criteria.CellContentClick
        Dim colname As String = dgPrelim_criteria.Columns(e.ColumnIndex).Name
        If colname = "colUpdatePrelim" Then
            frmCriteria.Label8.Text = "Preliminary Criteria"
            frmCriteria.criteriaType.Text = "Preliminary"
            frmCriteria.Size = New Size(599, 344)

            frmCriteria.criteriaID.Text = dgPrelim_criteria.CurrentRow.Cells(0).Value
            frmCriteria.txtCriteriaDesc.Text = dgPrelim_criteria.CurrentRow.Cells(1).Value
            frmCriteria.txtPercentage.Text = dgPrelim_criteria.CurrentRow.Cells(2).Value
            frmCriteria.cbStatus.Text = dgPrelim_criteria.CurrentRow.Cells(3).Value

            frmCriteria.btnAddCriteria.Visible = False
            frmCriteria.btnUpdateCriteria.Visible = True

            frmCriteria.SubPreliminaryCriteriaList()
            frmCriteria.ShowDialog()
        End If
    End Sub

    Private Sub dgFinal_criteria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFinal_criteria.CellContentClick
        Dim colname As String = dgFinal_criteria.Columns(e.ColumnIndex).Name
        If colname = "colUpdateFinal" Then
            frmCriteria.Label8.Text = "Final Criteria"
            frmCriteria.criteriaType.Text = "Final"
            frmCriteria.Size = New Size(599, 344)

            frmCriteria.criteriaID.Text = dgFinal_criteria.CurrentRow.Cells(0).Value
            frmCriteria.txtCriteriaDesc.Text = dgFinal_criteria.CurrentRow.Cells(1).Value
            frmCriteria.txtPercentage.Text = dgFinal_criteria.CurrentRow.Cells(2).Value
            frmCriteria.cbStatus.Text = dgFinal_criteria.CurrentRow.Cells(3).Value

            frmCriteria.btnAddCriteria.Visible = False
            frmCriteria.btnUpdateCriteria.Visible = True

            frmCriteria.SubFinalCriteriaList()

            If frmCriteria.dgSubCriteria.RowCount = 0 Then
                frmCriteria.lblTotalPercentage.Text = "0"
            Else
                Dim sum As Decimal = 0
                Dim columnIndex As Integer = frmCriteria.dgSubCriteria.Columns(2).Index

                For Each row As DataGridViewRow In frmCriteria.dgSubCriteria.Rows
                    If Not row.IsNewRow Then
                        Dim cellValue As Object = row.Cells(columnIndex).Value
                        If IsNumeric(cellValue) Then
                            sum += Convert.ToDecimal(cellValue)
                        End If
                    End If
                Next
                frmCriteria.lblTotalPercentage.Text = sum
            End If

            frmCriteria.ShowDialog()
        End If
    End Sub

    Private Sub btnDesginateTop_Click(sender As Object, e As EventArgs) Handles btnDesginateTop.Click
        frmTopDesignation.Show()
    End Sub
End Class