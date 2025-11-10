Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmScoringFinal

    Sub malecandidates()

        Try
            dgcandidates_male.Rows.Clear()
            Dim sql As String
            sql = "Select (t1.contestant_number) as 'Candidate Number', t1.contestant_ID from tbl_top t1 JOIN tbl_contestants t2 ON t1.contestant_ID = t2.ID where t2.contestant_gender = 'MALE' order by t1.ID asc"
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgcandidates_male.Rows.Add(dr.Item("Candidate Number").ToString, dr.Item("contestant_ID").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try

    End Sub

    Sub malecandidate_info()
        Try
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("select contestant_name tbl_contestants from tbl_contestants where ID = " & CInt(dgcandidates_male.CurrentRow.Cells(1).Value) & "", cn)
            name_male.Text = cm.ExecuteScalar.ToString.ToUpper
            cn.Close()
        Catch ex As Exception
            name_male.Text = "-"
        End Try

        Try
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("select contestant_photo from tbl_contestants where ID = " & CInt(dgcandidates_male.CurrentRow.Cells(1).Value) & "", cn)
            dr = cm.ExecuteReader
            While dr.Read
                Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(0, 0, array, 0, CInt(len))
                Dim ms As New MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)
                PictureBox_male.Image = bitmap
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            PictureBox_male.Image = Dummypicture.Image
        End Try
    End Sub

    Sub femalecandidate_info()
        Try
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("select contestant_name tbl_contestants from tbl_contestants where ID = " & CInt(dgcandidates_female.CurrentRow.Cells(1).Value) & "", cn)
            name_female.Text = cm.ExecuteScalar.ToString.ToUpper
            cn.Close()
        Catch ex As Exception
            name_female.Text = "-"
        End Try

        Try
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("select contestant_photo from tbl_contestants where ID = " & CInt(dgcandidates_female.CurrentRow.Cells(1).Value) & "", cn)
            dr = cm.ExecuteReader
            While dr.Read
                Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(0, 0, array, 0, CInt(len))
                Dim ms As New MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)
                PictureBox_female.Image = bitmap
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            PictureBox_female.Image = Dummypicture.Image
        End Try
    End Sub

    Sub femalecandidates()

        Try
            dgcandidates_female.Rows.Clear()
            Dim sql As String
            sql = "Select (t1.contestant_number) as 'Candidate Number', t1.contestant_ID from tbl_top t1 JOIN tbl_contestants t2 ON t1.contestant_ID = t2.ID where t2.contestant_gender = 'FEMALE' order by t1.ID asc"
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgcandidates_female.Rows.Add(dr.Item("Candidate Number").ToString, dr.Item("contestant_ID").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try

    End Sub




    Sub MalePreliminaryCriteriaList()
        Try
            final_criteria_male.Rows.Clear()
            Dim sql As String
            sql = "SELECT `ID`, `criteria_name`, `percentage` FROM `tbl_final_criterias`"
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                final_criteria_male.Rows.Add(dr.Item("ID").ToString, dr.Item("criteria_name").ToString, dr.Item("percentage").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try
        MaleSubCriteriaScoring()
    End Sub

    Sub FemalePreliminaryCriteriaList()
        Try
            final_criteria_female.Rows.Clear()
            Dim sql As String
            sql = "SELECT `ID`, `criteria_name`, `percentage` FROM `tbl_final_criterias`"
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                final_criteria_female.Rows.Add(dr.Item("ID").ToString, dr.Item("criteria_name").ToString, dr.Item("percentage").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try
        FemaleSubCriteriaScoring()
    End Sub

    Sub MaleSubCriteriaScoring()
        Try
            dgcriteria_male.Rows.Clear()
            Dim sql As String
            sql = "SELECT `ID`, `criteria_name`, `percentage` FROM `tbl_subcriterias2` WHERE criteria_ID = " & CInt(final_criteria_male.CurrentRow.Cells(0).Value) & ""
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgcriteria_male.Rows.Add(dr.Item("ID").ToString, dr.Item("criteria_name").ToString, dr.Item("percentage").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try
        MaleScores()
    End Sub
    Sub MaleScores()
        Try
            For Each row As DataGridViewRow In dgcriteria_male.Rows
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select ifnull(t1.judge_score, 0) from tbl_final_subscoring t1 where t1.subcriteria_ID = " & row.Cells(0).Value & " and t1.contestant_number = " & CInt(candidatenumber_male.Text) & " and t1.contestant_gender = 'MALE' and t1.judge_number = " & str_user_number & "", cn)
                    row.Cells(3).Value = Format(CDec(cm.ExecuteScalar), "#,##0.00")
                    cn.Close()
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        End Try
    End Sub

    Sub FemaleSubCriteriaScoring()
        Try
            dgcriteria_female.Rows.Clear()
            Dim sql As String
            sql = "SELECT `ID`, `criteria_name`, `percentage` FROM `tbl_subcriterias2` WHERE criteria_ID = " & CInt(final_criteria_female.CurrentRow.Cells(0).Value) & ""
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgcriteria_female.Rows.Add(dr.Item("ID").ToString, dr.Item("criteria_name").ToString, dr.Item("percentage").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try
        FemaleScores()
    End Sub

    Sub FemaleScores()
        Try
            For Each row As DataGridViewRow In dgcriteria_female.Rows
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select ifnull(t1.judge_score, 0) from tbl_final_subscoring t1 where t1.subcriteria_ID = " & row.Cells(0).Value & " and t1.contestant_number = " & CInt(candidatenumber_female.Text) & " and t1.contestant_gender = 'FEMALE' and t1.judge_number = " & str_user_number & "", cn)
                    row.Cells(3).Value = Format(CDec(cm.ExecuteScalar), "#,##0.00")
                    cn.Close()
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmScoringFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        malecandidates()
        femalecandidates()

        Try
            candidatenumber_male.Text = dgcandidates_male.CurrentRow.Cells(0).Value
            candidatenumber_female.Text = dgcandidates_female.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try

        MalePreliminaryCriteriaList()
        FemalePreliminaryCriteriaList()
    End Sub

    Private Sub prelim_criteria_male_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles final_criteria_male.CellClick
        MaleSubCriteriaScoring()
    End Sub

    Private Sub dgcriteria_female_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcriteria_female.CellContentClick

    End Sub


    Private Sub dgcriteria_male_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcriteria_male.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            dgcriteria_male.BeginEdit(True)
        End If
    End Sub
    Private Sub dgcriteria_female_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcriteria_female.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            dgcriteria_female.BeginEdit(True)
        End If
    End Sub

    Private Sub dgcriteria_male_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgcriteria_male.CellValidating
        Dim columnIndex As Integer = e.ColumnIndex
        ' Check if the edited cell is the Score column (assuming it's column index 3)
        If columnIndex = 3 Then
            Dim scoreValue As Decimal
            Dim percentageValue As Decimal

            ' Try to parse the values to Decimal
            If Decimal.TryParse(e.FormattedValue.ToString(), scoreValue) AndAlso
           Decimal.TryParse(dgcriteria_male.CurrentRow.Cells(2).Value.ToString(), percentageValue) Then

                ' Check if the score exceeds the percentage value
                If scoreValue > percentageValue Then
                    MessageBox.Show("Male Score in sub-criteria " & dgcriteria_male.CurrentRow.Cells(1).Value & " must not exceed the sub-criteria percentage value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' Prevent moving to another cell
                    e.Cancel = True

                    ' Set focus back to the score cell
                    dgcriteria_male.CurrentCell = dgcriteria_male.CurrentRow.Cells(3)
                    dgcriteria_male.BeginEdit(True)
                End If
            Else
                MessageBox.Show("Invalid input. Please enter valid numeric values for score.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Prevent moving to another cell
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub dgcriteria_female_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgcriteria_female.CellValidating
        Dim columnIndex As Integer = e.ColumnIndex
        ' Check if the edited cell is the Score column (assuming it's column index 3)
        If columnIndex = 3 Then
            Dim scoreValue As Decimal
            Dim percentageValue As Decimal

            ' Try to parse the values to Decimal
            If Decimal.TryParse(e.FormattedValue.ToString(), scoreValue) AndAlso
           Decimal.TryParse(dgcriteria_female.CurrentRow.Cells(2).Value.ToString(), percentageValue) Then

                ' Check if the score exceeds the percentage value
                If scoreValue > percentageValue Then
                    MessageBox.Show("Female Score in sub criteria " & dgcriteria_female.CurrentRow.Cells(1).Value & " must not exceed the sub-criteria percentage value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' Prevent moving to another cell
                    e.Cancel = True

                    ' Set focus back to the score cell
                    dgcriteria_female.CurrentCell = dgcriteria_female.CurrentRow.Cells(3)
                    dgcriteria_female.BeginEdit(True)
                End If
            Else
                MessageBox.Show("Invalid input. Please enter numeric values for score.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Prevent moving to another cell
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub nxt_candidate_male_Click(sender As Object, e As EventArgs) Handles nxt_candidate_male.Click
        MaleNext()
    End Sub

    Sub MaleNext()
        Try
            Dim a As Integer = dgcandidates_male.RowCount
            If dgcandidates_male.Rows(a - 1).Selected = True Then
                dgcandidates_male.CurrentCell = dgcandidates_male.Rows(0).Cells(0)
                dgcandidates_male.Rows(0).Selected = True
            Else
                Dim _rowIndex = dgcandidates_male.SelectedRows(0).Index + 1
                If _rowIndex <= dgcandidates_male.Rows.Count - 1 Then
                    Dim nextRow As DataGridViewRow = dgcandidates_male.Rows(_rowIndex)
                    ' Move the Glyph arrow to the next row
                    dgcandidates_male.CurrentCell = nextRow.Cells(0)
                    dgcandidates_male.Rows(_rowIndex).Selected = True
                End If
            End If
            candidatenumber_male.Text = dgcandidates_male.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub prev_candidate_male_Click(sender As Object, e As EventArgs) Handles prev_candidate_male.Click
        Try
            Dim a As Integer = dgcandidates_male.RowCount
            If dgcandidates_male.Rows(0).Selected = True Then
                dgcandidates_male.CurrentCell = dgcandidates_male.Rows(a - 1).Cells(0)
                dgcandidates_male.Rows(a - 1).Selected = True
            Else
                Dim _rowIndex = dgcandidates_male.SelectedRows(0).Index - 1
                If _rowIndex <= dgcandidates_male.Rows.Count + 1 Then
                    Dim nextRow As DataGridViewRow = dgcandidates_male.Rows(_rowIndex)
                    ' Move the Glyph arrow to the next row
                    dgcandidates_male.CurrentCell = nextRow.Cells(0)
                    dgcandidates_male.Rows(_rowIndex).Selected = True
                End If
            End If
            candidatenumber_male.Text = dgcandidates_male.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub nxt_candidate_female_Click(sender As Object, e As EventArgs) Handles nxt_candidate_female.Click
        FemaleNext()
    End Sub

    Sub FemaleNext()
        Try
            Dim a As Integer = dgcandidates_female.RowCount
            If dgcandidates_female.Rows(a - 1).Selected = True Then
                dgcandidates_female.CurrentCell = dgcandidates_female.Rows(0).Cells(0)
                dgcandidates_female.Rows(0).Selected = True
            Else
                Dim _rowIndex = dgcandidates_female.SelectedRows(0).Index + 1
                If _rowIndex <= dgcandidates_female.Rows.Count - 1 Then
                    Dim nextRow As DataGridViewRow = dgcandidates_female.Rows(_rowIndex)
                    ' Move the Glyph arrow to the next row
                    dgcandidates_female.CurrentCell = nextRow.Cells(0)
                    dgcandidates_female.Rows(_rowIndex).Selected = True
                End If
            End If
            candidatenumber_female.Text = dgcandidates_female.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub prev_candidate_female_Click(sender As Object, e As EventArgs) Handles prev_candidate_female.Click
        Try
            Dim a As Integer = dgcandidates_female.RowCount
            If dgcandidates_female.Rows(0).Selected = True Then
                dgcandidates_female.CurrentCell = dgcandidates_female.Rows(a - 1).Cells(0)
                dgcandidates_female.Rows(a - 1).Selected = True
            Else
                Dim _rowIndex = dgcandidates_female.SelectedRows(0).Index - 1
                If _rowIndex <= dgcandidates_female.Rows.Count + 1 Then
                    Dim nextRow As DataGridViewRow = dgcandidates_female.Rows(_rowIndex)
                    ' Move the Glyph arrow to the next row
                    dgcandidates_female.CurrentCell = nextRow.Cells(0)
                    dgcandidates_female.Rows(_rowIndex).Selected = True
                End If
            End If
            candidatenumber_female.Text = dgcandidates_female.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub candidatenumber_male_TextChanged(sender As Object, e As EventArgs) Handles candidatenumber_male.TextChanged
        malecandidate_info()
        MaleScores()
    End Sub

    Private Sub candidatenumber_female_TextChanged(sender As Object, e As EventArgs) Handles candidatenumber_female.TextChanged
        femalecandidate_info()
        FemaleScores()
    End Sub

    Private Sub btnSubmitMaleScore_Click(sender As Object, e As EventArgs) Handles btnSubmitMaleScore.Click
        cn.Close()
        cn.Open()
        cm = New MySqlCommand("SELECT * FROM tbl_final_criterias WHERE ID = " & CInt(final_criteria_male.CurrentRow.Cells(0).Value) & " and criteria_status = 'CLOSE'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            cn.Close()
            MessageBox.Show("Criteria '" & final_criteria_male.CurrentRow.Cells(1).Value & "' is close.", "Submit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dr.Close()
            cn.Close()
            Dim subCriteriaPercent As Decimal = 0
            Dim subCriteriaScore As Decimal = 0

            For Each row As DataGridViewRow In dgcriteria_male.Rows
                cn.Close()
                cn.Open()
                cm = New MySqlCommand("SELECT judge_score FROM tbl_final_subscoring WHERE judge_number = " & str_user_number & " and contestant_number = " & CInt(candidatenumber_male.Text) & " and contestant_gender = 'MALE' and subcriteria_ID = " & CInt(row.Cells(0).Value) & "", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    dr.Close()
                    cn.Close()
                    subCriteriaPercent = CDec(row.Cells(2).Value)
                    subCriteriaScore = CDec(row.Cells(3).Value)
                    query("UPDATE tbl_final_subscoring set judge_score  = " & subCriteriaScore & " where judge_number = " & str_user_number & " and contestant_number = " & CInt(candidatenumber_male.Text) & " and contestant_gender = 'MALE' and subcriteria_ID = " & CInt(row.Cells(0).Value) & "")
                Else
                    dr.Close()
                    cn.Close()
                    subCriteriaPercent = CDec(row.Cells(2).Value)
                    subCriteriaScore = CDec(row.Cells(3).Value)
                    query("INSERT INTO tbl_final_subscoring (judge_number, contestant_ID, contestant_number, contestant_gender, subcriteria_ID, judge_score) values (" & str_user_number & ", " & CInt(dgcandidates_male.CurrentRow.Cells(1).Value) & ", " & CInt(candidatenumber_male.Text) & ", 'MALE', " & CInt(row.Cells(0).Value) & ", " & subCriteriaScore & ")")
                End If
            Next


            subCriteriaScore = GetColumnSum(dgcriteria_male, 3)

            cn.Close()
            cn.Open()
            cm = New MySqlCommand("SELECT judge_score FROM tbl_final_scoring WHERE judge_number = " & str_user_number & " and contestant_number = " & CInt(candidatenumber_male.Text) & " and contestant_gender = 'MALE' and criteria_ID = " & CInt(final_criteria_male.CurrentRow.Cells(0).Value) & "", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cn.Close()
                query("UPDATE tbl_final_scoring set judge_score  = " & subCriteriaScore & " where judge_number = " & str_user_number & " and contestant_number = " & CInt(candidatenumber_male.Text) & " and contestant_gender = 'MALE' and criteria_ID = " & CInt(final_criteria_male.CurrentRow.Cells(0).Value) & "")
            Else
                dr.Close()
                cn.Close()
                query("INSERT INTO tbl_final_scoring (judge_number, contestant_ID, contestant_number, contestant_gender, criteria_ID, judge_score) values (" & str_user_number & ", " & CInt(dgcandidates_male.CurrentRow.Cells(1).Value) & ", " & CInt(candidatenumber_male.Text) & ", 'MALE', " & CInt(final_criteria_male.CurrentRow.Cells(0).Value) & ", " & subCriteriaScore & ")")
            End If

            MessageBox.Show("Male candidate number " & candidatenumber_male.Text & " - " & name_male.Text & " score for criteria '" & final_criteria_male.CurrentRow.Cells(1).Value & "' submitted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MaleNext()
        End If
    End Sub

    Private Sub btnSubmitFemaleScore_Click(sender As Object, e As EventArgs) Handles btnSubmitFemaleScore.Click
        cn.Close()
        cn.Open()
        cm = New MySqlCommand("SELECT * FROM tbl_final_criterias WHERE ID = " & CInt(final_criteria_female.CurrentRow.Cells(0).Value) & " and criteria_status = 'CLOSE'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            cn.Close()
            MessageBox.Show("Criteria '" & final_criteria_female.CurrentRow.Cells(1).Value & "' is close.", "Submit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dr.Close()
            cn.Close()
            Dim subCriteriaPercent As Decimal = 0
            Dim subCriteriaScore As Decimal = 0

            For Each row As DataGridViewRow In dgcriteria_female.Rows

                cn.Close()
                cn.Open()
                cm = New MySqlCommand("SELECT judge_score FROM tbl_final_subscoring WHERE judge_number = " & str_user_number & " and contestant_number = " & CInt(candidatenumber_female.Text) & " and contestant_gender = 'FEMALE' and subcriteria_ID = " & CInt(row.Cells(0).Value) & "", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    dr.Close()
                    cn.Close()
                    subCriteriaPercent = CDec(row.Cells(2).Value)
                    subCriteriaScore = CDec(row.Cells(3).Value)
                    query("UPDATE tbl_final_subscoring set judge_score  = " & subCriteriaScore & " where judge_number = " & str_user_number & " and contestant_number = " & CInt(candidatenumber_female.Text) & " and contestant_gender = 'FEMALE' and subcriteria_ID = " & CInt(row.Cells(0).Value) & "")
                Else
                    dr.Close()
                    cn.Close()
                    subCriteriaPercent = CDec(row.Cells(2).Value)
                    subCriteriaScore = CDec(row.Cells(3).Value)
                    query("INSERT INTO tbl_final_subscoring (judge_number, contestant_ID, contestant_number, contestant_gender, subcriteria_ID, judge_score) values (" & str_user_number & ", " & CInt(dgcandidates_female.CurrentRow.Cells(1).Value) & ", " & CInt(candidatenumber_female.Text) & ", 'FEMALE', " & CInt(row.Cells(0).Value) & ", " & subCriteriaScore & ")")

                End If
            Next

            subCriteriaScore = GetColumnSum(dgcriteria_female, 3)

            cn.Close()
            cn.Open()
            cm = New MySqlCommand("SELECT judge_score FROM tbl_final_scoring WHERE judge_number = " & str_user_number & " and contestant_number = " & CInt(candidatenumber_female.Text) & " and contestant_gender = 'FEMALE' and criteria_ID = " & CInt(final_criteria_female.CurrentRow.Cells(0).Value) & "", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cn.Close()
                query("UPDATE tbl_final_scoring set judge_score  = " & subCriteriaScore & " where judge_number = " & str_user_number & " and contestant_number = " & CInt(candidatenumber_female.Text) & " and contestant_gender = 'FEMALE' and criteria_ID = " & CInt(final_criteria_female.CurrentRow.Cells(0).Value) & "")
            Else
                dr.Close()
                cn.Close()
                query("INSERT INTO tbl_final_scoring (judge_number, contestant_ID, contestant_number, contestant_gender, criteria_ID, judge_score) values (" & str_user_number & ", " & CInt(dgcandidates_female.CurrentRow.Cells(1).Value) & ", " & CInt(candidatenumber_female.Text) & ", 'FEMALE', " & CInt(final_criteria_female.CurrentRow.Cells(0).Value) & ", " & subCriteriaScore & ")")
            End If

            MessageBox.Show("Female candidate number " & candidatenumber_female.Text & " - " & name_female.Text & " score for criteria '" & final_criteria_female.CurrentRow.Cells(1).Value & "' submitted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FemaleNext()
        End If
    End Sub

    Private Sub dgcriteria_female_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgcriteria_female.CellEndEdit
        dgcriteria_female.CurrentRow.Cells(3).Value = Format(CDec(dgcriteria_female.CurrentRow.Cells(3).Value), "#,##0.00")
    End Sub

    Private Sub dgcriteria_male_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgcriteria_male.CellEndEdit
        dgcriteria_male.CurrentRow.Cells(3).Value = Format(CDec(dgcriteria_male.CurrentRow.Cells(3).Value), "#,##0.00")
    End Sub

    Private Sub final_criteria_male_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles final_criteria_male.CellContentClick

    End Sub

    Private Sub final_criteria_female_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles final_criteria_female.CellContentClick

    End Sub

    Private Sub final_criteria_female_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles final_criteria_female.CellClick
        FemaleSubCriteriaScoring()
    End Sub

    Private Sub PictureBox_male_Click(sender As Object, e As EventArgs) Handles PictureBox_male.Click

    End Sub

    Private Sub PictureBox_female_Click(sender As Object, e As EventArgs) Handles PictureBox_female.Click

    End Sub
End Class
