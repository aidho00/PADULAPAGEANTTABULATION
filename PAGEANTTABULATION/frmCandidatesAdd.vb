Imports MySql.Data.MySqlClient

Public Class frmCandidatesAdd
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            candidatePicture.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnPageantSave_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim drr As DialogResult
        drr = MessageBox.Show("Add new candidate?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If drr = DialogResult.No Then

        Else
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM tbl_contestants WHERE contestant_number = '" & cbNumber.Text & "' and contestant_GENDER = '" & frmCandidates.cbGender.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cn.Close()
                MessageBox.Show("" & frmCandidates.cbGender.Text & " Candidate number '" & cbNumber.Text & "' already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dr.Close()
                cn.Close()
                If txtCandidateName.Text = "" Then
                    MessageBox.Show("Please input candidate name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCandidateName.Select()
                ElseIf cbNumber.Text = "" Then
                    MessageBox.Show("Please select candidate number.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbNumber.Select()
                ElseIf candidatePicture.Image Is Nothing Then
                    MessageBox.Show("Please input candidate photo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    btnUpload.Select()
                Else
                    cn.Close()
                    cn.Open()

                    Dim FileSize As UInt32

                    Dim mstream As New System.IO.MemoryStream()
                    candidatePicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer()
                    FileSize = mstream.Length
                    mstream.Close()

                    Dim str As String
                    str = "INSERT INTO tbl_contestants (contestant_name, contestant_number, contestant_gender, contestant_photo) values (@cname, @cnumber, @cgender, @cphoto)"

                    cm = New MySqlCommand(str, cn)
                    cm.Parameters.AddWithValue("@cname", txtCandidateName.Text)
                    cm.Parameters.AddWithValue("@cnumber", cbNumber.Text)
                    cm.Parameters.AddWithValue("@cgender", frmCandidates.cbGender.Text)
                    cm.Parameters.AddWithValue("@cphoto", arrImage)

                    Dim r As Integer
                    r = cm.ExecuteNonQuery()
                    If r > 0 Then
                        MessageBox.Show("New CANDIDATE added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmCandidates.CandidatesList()
                        txtCandidateName.Text = String.Empty
                        candidatePicture.Image = Dummypicture.Image
                    Else
                        MsgBox("No CANDIDATE added!")
                    End If
                    cm.Dispose()

                    cn.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim drr As DialogResult
        drr = MessageBox.Show("Update candidate?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If drr = DialogResult.No Then

        Else
            cn.Close()
            cn.Open()

            Dim FileSize As UInt32

            Dim mstream As New System.IO.MemoryStream()
            candidatePicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()

            Dim sql As String = "Update tbl_contestants set contestant_name = '" & txtCandidateName.Text & "', contestant_photo = @cphoto where ID = '" & candidateID.Text & "'"
            Dim cmd As New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@cphoto", arrImage)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Candidate updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmCandidates.CandidatesList()
            cn.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class