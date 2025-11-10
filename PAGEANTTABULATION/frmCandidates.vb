Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmCandidates
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmCandidatesAdd.txtCandidateName.Text = String.Empty
        frmCandidatesAdd.btnAdd.Visible = True
        frmCandidatesAdd.btnUpdate.Visible = False
        frmCandidatesAdd.cbNumber.Enabled = True
        frmCandidatesAdd.candidatePicture.Image = Dummypicture.Image
        frmCandidatesAdd.ShowDialog()
    End Sub

    Sub CandidatesList()
        Try

            dgCandidates.Rows.Clear()
            Dim sql As String
            sql = "Select ID, (contestant_number) as Number, (contestant_name) as Name from tbl_contestants where contestant_gender = '" & cbGender.Text & "' and contestant_name LIKE '%" & txtSearch.Text & "%' order by contestant_number asc"
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgCandidates.Rows.Add(dr.Item("ID").ToString, dr.Item("Number").ToString, dr.Item("Name").ToString)
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            dr.Close()
            cn.Close()
            dgCandidates.Rows.Clear()
        End Try
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub frmCandidates_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbGender.SelectedIndex = 0
    End Sub

    Private Sub cbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGender.SelectedIndexChanged
        CandidatesList()
    End Sub

    Private Sub dgCandidates_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCandidates.CellContentClick
        Dim colname As String = dgCandidates.Columns(e.ColumnIndex).Name
        If colname = "colUpdate" Then
            frmCandidatesAdd.txtCandidateName.Text = dgCandidates.CurrentRow.Cells(2).Value
            frmCandidatesAdd.cbNumber.Text = dgCandidates.CurrentRow.Cells(1).Value
            frmCandidatesAdd.candidateID.Text = dgCandidates.CurrentRow.Cells(0).Value

            frmCandidatesAdd.cbNumber.Enabled = False

            frmCandidatesAdd.btnAdd.Visible = False
            frmCandidatesAdd.btnUpdate.Visible = True

            Try
                cn.Close()
                cn.Open()
                cm = New MySqlCommand("select contestant_photo from tbl_contestants where ID = @1", cn)
                With cm
                    .Parameters.AddWithValue("@1", CInt(frmCandidatesAdd.candidateID.Text))
                End With
                dr = cm.ExecuteReader
                While dr.Read
                    Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                    Dim array(CInt(len)) As Byte
                    dr.GetBytes(0, 0, array, 0, CInt(len))
                    Dim ms As New MemoryStream(array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    frmCandidatesAdd.candidatePicture.Image = bitmap
                End While
                dr.Close()
                cn.Close()
            Catch ex As Exception
                frmCandidatesAdd.candidatePicture.Image = frmCandidatesAdd.Dummypicture.Image
            End Try
            frmCandidatesAdd.ShowDialog()
        End If
    End Sub

    Private Sub dgCandidates_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCandidates.CellClick
        Try
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("select contestant_photo from tbl_contestants where ID = @1", cn)
            With cm
                .Parameters.AddWithValue("@1", dgCandidates.CurrentRow.Cells(0).Value.ToString)
            End With
            dr = cm.ExecuteReader
            While dr.Read
                Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(0, 0, array, 0, CInt(len))
                Dim ms As New MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)
                candidatePicture.Image = bitmap
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            candidatePicture.Image = Dummypicture.Image
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        CandidatesList()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class