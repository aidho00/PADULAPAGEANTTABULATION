Imports MySql.Data.MySqlClient

Public Class frmTopDesignation

    Private Sub ChangeButtonCellTextMale(rowIndex As Integer, newText As String)
        ' Check if the specified cell is a button cell
        If TypeOf dgCandidates_Male.Rows(rowIndex).Cells(5) Is DataGridViewButtonCell Then
            ' Change the button text
            Dim buttonCell As DataGridViewButtonCell = CType(dgCandidates_Male.Rows(rowIndex).Cells(5), DataGridViewButtonCell)
            buttonCell.Value = newText
        Else
            MessageBox.Show("The specified cell is not a button cell.")
        End If
    End Sub

    Private Sub ChangeButtonCellTextFemale(rowIndex As Integer, newText As String)
        ' Check if the row index is valid
        If rowIndex >= 0 AndAlso rowIndex < dgCandidates_Female.Rows.Count Then
            ' Change the text of the button cell in the specified row
            dgCandidates_Female.Rows(rowIndex).Cells(5).Value = newText
        End If
    End Sub

    Sub malecandidates()

        Try
            dgCandidates_Male.Rows.Clear()
            Dim sql As String
            sql = "WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ), total_criteria AS ( SELECT COUNT(ID) AS total_criteria FROM tbl_criterias ) SELECT ct.ID AS contestant_ID, ct.contestant_number, ct.contestant_name, ct.contestant_gender, COALESCE((SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100) / NULLIF(tc.total_criteria, 0), 0) AS total_score, RANK() OVER (ORDER BY COALESCE((SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100) / NULLIF(tc.total_criteria, 0), 0) DESC) AS rank FROM tbl_contestants ct LEFT JOIN tbl_scoring s ON ct.ID = s.contestant_ID LEFT JOIN tbl_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj CROSS JOIN total_criteria tc WHERE ct.contestant_gender = 'MALE' GROUP BY ct.ID ORDER BY total_score DESC;"
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgCandidates_Male.Rows.Add(dr.Item("contestant_ID").ToString, dr.Item("rank").ToString, dr.Item("contestant_name").ToString, dr.Item("contestant_number").ToString, Format(CDec(dr.Item("total_score").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try

        For Each row As DataGridViewRow In dgCandidates_Male.Rows
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM tbl_top WHERE contestant_ID = " & CInt(row.Cells(0).Value) & "", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cn.Close()
                row.Cells(5).Value = True
            Else
                dr.Close()
                cn.Close()
                row.Cells(5).Value = False
            End If
        Next
    End Sub

    Sub femalecandidates()

        Try
            dgCandidates_Female.Rows.Clear()
            Dim sql As String
            sql = "WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ), total_criteria AS ( SELECT COUNT(ID) AS total_criteria FROM tbl_criterias ) SELECT ct.ID AS contestant_ID, ct.contestant_number, ct.contestant_name, ct.contestant_gender, COALESCE((SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100) / NULLIF(tc.total_criteria, 0), 0) AS total_score, RANK() OVER (ORDER BY COALESCE((SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100) / NULLIF(tc.total_criteria, 0), 0) DESC) AS rank FROM tbl_contestants ct LEFT JOIN tbl_scoring s ON ct.ID = s.contestant_ID LEFT JOIN tbl_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj CROSS JOIN total_criteria tc WHERE ct.contestant_gender = 'FEMALE' GROUP BY ct.ID ORDER BY total_score DESC;"
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgCandidates_Female.Rows.Add(dr.Item("contestant_ID").ToString, dr.Item("rank").ToString, dr.Item("contestant_name").ToString, dr.Item("contestant_number").ToString, Format(CDec(dr.Item("total_score").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try

        For Each row As DataGridViewRow In dgCandidates_Female.Rows
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM tbl_top WHERE contestant_ID = " & CInt(row.Cells(0).Value) & "", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cn.Close()
                row.Cells(5).Value = True
            Else
                dr.Close()
                cn.Close()
                row.Cells(5).Value = False
            End If
        Next
    End Sub

    Private Sub frmTopDesignation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        malecandidates()
        femalecandidates()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Function GetButtonCellTextMale(rowIndex As Integer) As String
        ' Check if the row index is valid
        If rowIndex >= 0 AndAlso rowIndex < dgCandidates_Male.Rows.Count Then
            ' Get the text of the button cell in the specified row at index 5
            Return dgCandidates_Male.Rows(rowIndex).Cells(5).Value.ToString()
        End If
        Return String.Empty ' Return empty string if the row index is invalid
    End Function

    Private Function GetButtonCellTextFemale(rowIndex As Integer) As String
        ' Check if the row index is valid
        If rowIndex >= 0 AndAlso rowIndex < dgCandidates_Female.Rows.Count Then
            ' Get the text of the button cell in the specified row at index 5
            Return dgCandidates_Female.Rows(rowIndex).Cells(5).Value.ToString()
        End If
        Return String.Empty ' Return empty string if the row index is invalid
    End Function

    Private Sub dgCandidates_Male_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCandidates_Male.CellContentClick
        If dgCandidates_Male.CurrentRow.Cells(5).Value = True Then
            dgCandidates_Male.CurrentRow.Cells(5).Value = False
        Else
            dgCandidates_Male.CurrentRow.Cells(5).Value = True
        End If

        Dim colname As String = dgCandidates_Male.Columns(e.ColumnIndex).Name
        If colname = "colDesignateMale" Then
            If dgCandidates_Male.CurrentRow.Cells(5).Value = True Then
                query("INSERT INTO tbl_top (contestant_ID, contestant_number, contestant_gender) VALUES (" & CInt(dgCandidates_Male.CurrentRow.Cells(0).Value) & ", " & CInt(dgCandidates_Male.CurrentRow.Cells(3).Value) & ", 'MALE')")
                MessageBox.Show("Candidate successfully designated for final judging.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                query("Delete from tbl_top where contestant_ID = " & CInt(dgCandidates_Male.CurrentRow.Cells(0).Value) & "")
                MessageBox.Show("Candidate successfully removed for final judging.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            malecandidates()
            femalecandidates()
        End If
    End Sub

    Private Sub dgCandidates_Female_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCandidates_Female.CellContentClick
        If dgCandidates_Female.CurrentRow.Cells(5).Value = True Then
            dgCandidates_Female.CurrentRow.Cells(5).Value = False
        Else
            dgCandidates_Female.CurrentRow.Cells(5).Value = True
        End If

        Dim colname As String = dgCandidates_Female.Columns(e.ColumnIndex).Name
        If colname = "colDesignateFemale" Then

            If dgCandidates_Female.CurrentRow.Cells(5).Value = True Then
                query("INSERT INTO tbl_top (contestant_ID, contestant_number, contestant_gender) VALUES (" & CInt(dgCandidates_Female.CurrentRow.Cells(0).Value) & ", " & CInt(dgCandidates_Female.CurrentRow.Cells(3).Value) & ", 'FEMALE')")
                MessageBox.Show("Candidate successfully designated for final judging.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                query("Delete from tbl_top where contestant_ID = " & CInt(dgCandidates_Female.CurrentRow.Cells(0).Value) & "")
                MessageBox.Show("Candidate successfully removed for final judging.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            malecandidates()
            femalecandidates()
        End If
    End Sub
End Class