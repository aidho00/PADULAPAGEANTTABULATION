Imports MySql.Data.MySqlClient

Public Class frmTabulationReport
    Private Sub cbAcademicYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRound.SelectedIndexChanged
        If cbRound.Text = "Preliminary" Then
            fillCombo("SELECT `ID`, `criteria_name` FROM `tbl_criterias`", cbCriteria, "tbl_criterias", "criteria_name", "ID")
        Else
            fillCombo("SELECT `ID`, `criteria_name` FROM `tbl_final_criterias`", cbCriteria, "tbl_final_criterias", "criteria_name", "ID")
        End If
    End Sub

    Private Sub frmTabulationReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbRound.SelectedIndex = 0
        cbGender.SelectedIndex = 0
    End Sub

    Private Sub btnPerCriteria_Click(sender As Object, e As EventArgs) Handles btnPerCriteria.Click
        If cbRound.Text = "Preliminary" Then
            Try

                'load_datagrid("select t1.`contestant_number`, t1.`contestant_name`, IFNULL(t2.SCORE,0) as AVERAGE from tbl_contestants t1 LEFT JOIN (SELECT `contestant_number`, `contestant_gender`, `criteria_ID`, ROUND(SUM(`judge_score`) / (select count(*) from tbl_system_accounts where type = 'Judge'),2) as SCORE FROM `tbl_scoring` where `contestant_gender` = '" & cbGender.Text & "' and `criteria_ID` = " & CInt(cbCriteria.SelectedValue) & " group by `criteria_ID`, `contestant_number`, `contestant_gender`) as t2 ON t1.`contestant_number` = t2.`contestant_number` and t1.`contestant_gender` = t2.`contestant_gender` where t1.`contestant_gender` = '" & cmb_prelim_gender.Text & "' order by AVERAGE desc", dg_report)
                'load_datagrid("WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ) SELECT ct.ID AS contestant_ID, ct.contestant_number, ct.contestant_name, ct.contestant_gender, COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100, 0) AS total_score, RANK() OVER (ORDER BY COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100, 0) DESC) AS rank FROM tbl_contestants ct LEFT JOIN tbl_scoring s ON ct.ID = s.contestant_ID AND s.criteria_ID = " & CInt(cbCriteria.SelectedValue) & " LEFT JOIN tbl_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj WHERE ct.contestant_gender = '" & cbGender.Text & "' GROUP BY ct.ID ORDER BY total_score DESC;", dg_report)

                load_datagrid("WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ) SELECT ct.ID AS contestant_ID, ct.contestant_number, ct.contestant_name, ct.contestant_gender, COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges, 0) AS total_score, RANK() OVER (ORDER BY COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges, 0) DESC) AS rank FROM tbl_contestants ct LEFT JOIN tbl_scoring s ON ct.ID = s.contestant_ID AND s.criteria_ID = " & CInt(cbCriteria.SelectedValue) & " LEFT JOIN tbl_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj WHERE ct.contestant_gender = '" & cbGender.Text & "' GROUP BY ct.ID ORDER BY total_score DESC;", dg_report)

                Dim dt As New DataTable
                With dt
                    .Columns.Add("candidatenumber")
                    .Columns.Add("candidatename")
                    .Columns.Add("average")
                End With
                For Each dr As DataGridViewRow In dg_report.Rows
                    dt.Rows.Add(dr.Cells(1).Value, dr.Cells(2).Value, Format(CDec(dr.Cells(4).Value), "#,##0.00"))
                Next
                Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptdoc = New ReportReport
                rptdoc.SetDataSource(dt)
                rptdoc.SetParameterValue("userfullname", str_name)
                rptdoc.SetParameterValue("eventname", frmMain.PageantTitle.Text)
                rptdoc.SetParameterValue("categoryname", cbCriteria.Text)
                rptdoc.SetParameterValue("gender", cbGender.Text)
                rptdoc.SetParameterValue("judgingcategory", "PRELIMINARY")
                ReportViewer.ReportSource = rptdoc
                dg_report.DataSource = Nothing
            Catch ex As Exception
            End Try
        Else
            Try

                'load_datagrid("select t1.`contestant_number`, t1.`contestant_name`, IFNULL(t2.SCORE,0) as AVERAGE from tbl_contestants t1 LEFT JOIN (SELECT `contestant_number`, `contestant_gender`, `criteria_ID`, ROUND(SUM(`judge_score`) / (select count(*) from tbl_system_accounts where type = 'Judge'),2) as SCORE FROM `tbl_scoring` where `contestant_gender` = '" & cbGender.Text & "' and `criteria_ID` = " & CInt(cbCriteria.SelectedValue) & " group by `criteria_ID`, `contestant_number`, `contestant_gender`) as t2 ON t1.`contestant_number` = t2.`contestant_number` and t1.`contestant_gender` = t2.`contestant_gender` where t1.`contestant_gender` = '" & cmb_prelim_gender.Text & "' order by AVERAGE desc", dg_report)
                load_datagrid("WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ) SELECT t.contestant_ID AS contestant_ID, ct.contestant_number, ct.contestant_name, ct.contestant_gender, COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges, 0) AS total_score, RANK() OVER (ORDER BY COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges, 0) DESC) AS rank FROM tbl_top t LEFT JOIN tbl_contestants ct ON t.contestant_ID = ct.ID LEFT JOIN tbl_final_scoring s ON t.contestant_ID = s.contestant_ID AND s.criteria_ID = " & CInt(cbCriteria.SelectedValue) & " LEFT JOIN tbl_final_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj WHERE ct.contestant_gender = '" & cbGender.Text & "' GROUP BY t.contestant_ID ORDER BY total_score DESC;", dg_report)

                Dim dt As New DataTable
                With dt
                    .Columns.Add("candidatenumber")
                    .Columns.Add("candidatename")
                    .Columns.Add("average")
                End With
                For Each dr As DataGridViewRow In dg_report.Rows
                    dt.Rows.Add(dr.Cells(1).Value, dr.Cells(2).Value, Format(CDec(dr.Cells(4).Value), "#,##0.00"))
                Next
                Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptdoc = New ReportReport
                rptdoc.SetDataSource(dt)
                rptdoc.SetParameterValue("userfullname", str_name)
                rptdoc.SetParameterValue("eventname", frmMain.PageantTitle.Text)
                rptdoc.SetParameterValue("categoryname", cbCriteria.Text)
                rptdoc.SetParameterValue("gender", cbGender.Text)
                rptdoc.SetParameterValue("judgingcategory", "FINAL")
                ReportViewer.ReportSource = rptdoc
                dg_report.DataSource = Nothing
            Catch ex As Exception
            End Try
        End If



    End Sub

    Private Sub btnOverall_Click(sender As Object, e As EventArgs) Handles btnOverall.Click
        If cbRound.Text = "Preliminary" Then
            Try
                'load_datagrid("select table1.`contestant_number`, table1.`contestant_name`, IFNULL(ROUND(table2.SCORE,2),00) as TOTAL from tbl_top5 table1 LEFT JOIN (select SUM(t1.SCORE) as SCORE, `contestant_number` as Candidate, contestant_gender as Gender from (SELECT SUM(`judge_score`) / (select count(*) from tbl_system_accounts where type = 'Judge') as SCORE, criteria_ID, `contestant_number`, contestant_gender FROM `tbl_top5_scoring` where `contestant_gender` = '" & cmb_top_gender.Text & "' group by `criteria_ID`, `contestant_number`) as t1 group by `contestant_number`) as table2 ON table1.contestant_number = table2.Candidate and table1.contestant_gender = table2.Gender where `contestant_gender` = '" & cmb_top_gender.Text & "' order by TOTAL desc", dg_report)
                load_datagrid("WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ), total_criteria AS ( SELECT COUNT(ID) AS total_criteria FROM tbl_criterias ) SELECT ct.ID AS contestant_ID, ct.contestant_number, ct.contestant_name, ct.contestant_gender, COALESCE((SUM(COALESCE(s.judge_score, 0)) / tj.total_judges), 0) AS total_score, RANK() OVER (ORDER BY COALESCE((SUM(COALESCE(s.judge_score, 0)) / tj.total_judges), 0) DESC) AS rank FROM tbl_contestants ct LEFT JOIN tbl_scoring s ON ct.ID = s.contestant_ID LEFT JOIN tbl_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj CROSS JOIN total_criteria tc WHERE ct.contestant_gender = '" & cbGender.Text & "' GROUP BY ct.ID ORDER BY total_score DESC;", dg_report)

                Dim dt As New DataTable
                With dt
                    .Columns.Add("candidatenumber")
                    .Columns.Add("candidatename")
                    .Columns.Add("average")
                End With
                For Each dr As DataGridViewRow In dg_report.Rows
                    dt.Rows.Add(dr.Cells(1).Value, dr.Cells(2).Value, Format(CDec(dr.Cells(4).Value), "#,##0.00"))
                Next
                Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptdoc = New ReportReport
                rptdoc.SetDataSource(dt)
                rptdoc.SetParameterValue("userfullname", str_name)
                rptdoc.SetParameterValue("eventname", frmMain.PageantTitle.Text)
                rptdoc.SetParameterValue("categoryname", "OVERALL RESULT")
                rptdoc.SetParameterValue("gender", cbGender.Text)
                rptdoc.SetParameterValue("judgingcategory", "PRELIMINARY")
                ReportViewer.ReportSource = rptdoc
                dg_report.DataSource = Nothing
            Catch ex As Exception
            End Try
        Else
            Try
                'load_datagrid("select table1.`contestant_number`, table1.`contestant_name`, IFNULL(ROUND(table2.SCORE,2),00) as TOTAL from tbl_top5 table1 LEFT JOIN (select SUM(t1.SCORE) as SCORE, `contestant_number` as Candidate, contestant_gender as Gender from (SELECT SUM(`judge_score`) / (select count(*) from tbl_system_accounts where type = 'Judge') as SCORE, criteria_ID, `contestant_number`, contestant_gender FROM `tbl_top5_scoring` where `contestant_gender` = '" & cmb_top_gender.Text & "' group by `criteria_ID`, `contestant_number`) as t1 group by `contestant_number`) as table2 ON table1.contestant_number = table2.Candidate and table1.contestant_gender = table2.Gender where `contestant_gender` = '" & cmb_top_gender.Text & "' order by TOTAL desc", dg_report)
                load_datagrid("WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ), total_criteria AS ( SELECT COUNT(ID) AS total_criteria FROM tbl_final_criterias ) SELECT ct.ID AS contestant_ID, ct.contestant_number, ct.contestant_name, ct.contestant_gender, COALESCE((SUM(COALESCE(s.judge_score, 0)) / tj.total_judges), 0) AS total_score, RANK() OVER (ORDER BY COALESCE((SUM(COALESCE(s.judge_score, 0)) / tj.total_judges), 0) DESC) AS rank FROM tbl_top t LEFT JOIN tbl_contestants ct ON t.contestant_ID = ct.ID LEFT JOIN tbl_final_scoring s ON t.contestant_ID = s.contestant_ID LEFT JOIN tbl_final_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj CROSS JOIN total_criteria tc WHERE ct.contestant_gender = '" & cbGender.Text & "' GROUP BY ct.ID ORDER BY total_score DESC;", dg_report)

                Dim dt As New DataTable
                With dt
                    .Columns.Add("candidatenumber")
                    .Columns.Add("candidatename")
                    .Columns.Add("average")
                End With
                For Each dr As DataGridViewRow In dg_report.Rows
                    dt.Rows.Add(dr.Cells(1).Value, dr.Cells(2).Value, Format(CDec(dr.Cells(4).Value), "#,##0.00"))
                Next
                Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptdoc = New ReportReport
                rptdoc.SetDataSource(dt)
                rptdoc.SetParameterValue("userfullname", str_name)
                rptdoc.SetParameterValue("eventname", frmMain.PageantTitle.Text)
                rptdoc.SetParameterValue("categoryname", "OVERALL RESULT")
                rptdoc.SetParameterValue("gender", cbGender.Text)
                rptdoc.SetParameterValue("judgingcategory", "FINAL")
                ReportViewer.ReportSource = rptdoc
                dg_report.DataSource = Nothing
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPerCriteriaJudge_Click(sender As Object, e As EventArgs) Handles btnPerCriteriaJudge.Click
        If cbRound.Text = "Preliminary" Then
            Try
                'load_datagrid("WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ) SELECT ct.contestant_number, ct.contestant_name, COALESCE(MAX(CASE WHEN s.judge_number = 1 THEN s.judge_score END), 0) AS judge_1_score, COALESCE(MAX(CASE WHEN s.judge_number = 2 THEN s.judge_score END), 0) AS judge_2_score, COALESCE(MAX(CASE WHEN s.judge_number = 3 THEN s.judge_score END), 0) AS judge_3_score, COALESCE(MAX(CASE WHEN s.judge_number = 4 THEN s.judge_score END), 0) AS judge_4_score, COALESCE(MAX(CASE WHEN s.judge_number = 5 THEN s.judge_score END), 0) AS judge_5_score, COALESCE(MAX(CASE WHEN s.judge_number = 6 THEN s.judge_score END), 0) AS judge_6_score, COALESCE(MAX(CASE WHEN s.judge_number = 7 THEN s.judge_score END), 0) AS judge_7_score, COALESCE(MAX(CASE WHEN s.judge_number = 8 THEN s.judge_score END), 0) AS judge_8_score, COALESCE(MAX(CASE WHEN s.judge_number = 9 THEN s.judge_score END), 0) AS judge_9_score, COALESCE(MAX(CASE WHEN s.judge_number = 10 THEN s.judge_score END), 0) AS judge_10_score, COALESCE(MAX(CASE WHEN s.judge_number = 11 THEN s.judge_score END), 0) AS judge_11_score, COALESCE(MAX(CASE WHEN s.judge_number = 12 THEN s.judge_score END), 0) AS judge_12_score, COALESCE(MAX(CASE WHEN s.judge_number = 13 THEN s.judge_score END), 0) AS judge_13_score, COALESCE(MAX(CASE WHEN s.judge_number = 14 THEN s.judge_score END), 0) AS judge_14_score, COALESCE(MAX(CASE WHEN s.judge_number = 15 THEN s.judge_score END), 0) AS judge_15_score,  COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100, 0) AS total_score, RANK() OVER (ORDER BY COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100, 0) DESC) AS rank FROM tbl_contestants ct LEFT JOIN tbl_scoring s ON ct.ID = s.contestant_ID AND s.criteria_ID = " & CInt(cbCriteria.SelectedValue) & " LEFT JOIN tbl_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj WHERE ct.contestant_gender = '" & cbGender.Text & "' GROUP BY ct.ID ORDER BY total_score DESC;", dg_report)

                load_datagrid("WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ) SELECT ct.contestant_number, ct.contestant_name, MAX(CASE WHEN s.judge_number = 1 THEN s.judge_score END) AS judge_1_score, MAX(CASE WHEN s.judge_number = 2 THEN s.judge_score END) AS judge_2_score, MAX(CASE WHEN s.judge_number = 3 THEN s.judge_score END) AS judge_3_score, MAX(CASE WHEN s.judge_number = 4 THEN s.judge_score END) AS judge_4_score, MAX(CASE WHEN s.judge_number = 5 THEN s.judge_score END) AS judge_5_score, MAX(CASE WHEN s.judge_number = 6 THEN s.judge_score END) AS judge_6_score, MAX(CASE WHEN s.judge_number = 7 THEN s.judge_score END) AS judge_7_score, MAX(CASE WHEN s.judge_number = 8 THEN s.judge_score END) AS judge_8_score, MAX(CASE WHEN s.judge_number = 9 THEN s.judge_score END) AS judge_9_score, MAX(CASE WHEN s.judge_number = 10 THEN s.judge_score END) AS judge_10_score, MAX(CASE WHEN s.judge_number = 11 THEN s.judge_score END) AS judge_11_score, MAX(CASE WHEN s.judge_number = 12 THEN s.judge_score END) AS judge_12_score, MAX(CASE WHEN s.judge_number = 13 THEN s.judge_score END) AS judge_13_score, MAX(CASE WHEN s.judge_number = 14 THEN s.judge_score END) AS judge_14_score, MAX(CASE WHEN s.judge_number = 15 THEN s.judge_score END) AS judge_15_score,  COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges, 0) AS total_score, RANK() OVER (ORDER BY COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges, 0) DESC) AS rank FROM tbl_contestants ct LEFT JOIN tbl_scoring s ON ct.ID = s.contestant_ID AND s.criteria_ID = " & CInt(cbCriteria.SelectedValue) & " LEFT JOIN tbl_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj WHERE ct.contestant_gender = '" & cbGender.Text & "' GROUP BY ct.ID ORDER BY total_score DESC;", dg_report)

                Dim dt As New DataTable
            With dt
                .Columns.Add("candidatenumber")
                .Columns.Add("candidatename")
                .Columns.Add("J1")
                .Columns.Add("J2")
                .Columns.Add("J3")
                .Columns.Add("J4")
                .Columns.Add("J5")
                .Columns.Add("J6")
                .Columns.Add("J7")
                .Columns.Add("J8")
                .Columns.Add("J9")
                .Columns.Add("J10")
                .Columns.Add("J11")
                .Columns.Add("J12")
                .Columns.Add("J13")
                .Columns.Add("J14")
                .Columns.Add("J15")
                .Columns.Add("average")
            End With
            For Each dr As DataGridViewRow In dg_report.Rows
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, dr.Cells(5).Value, dr.Cells(6).Value, dr.Cells(7).Value, dr.Cells(8).Value, dr.Cells(9).Value, dr.Cells(10).Value, dr.Cells(11).Value, dr.Cells(12).Value, dr.Cells(13).Value, dr.Cells(14).Value, dr.Cells(15).Value, dr.Cells(16).Value, Format(CDec(dr.Cells(17).Value), "#,##0.00"))
                Next
            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New ReportReportPerJudge15
            rptdoc.SetDataSource(dt)
            rptdoc.SetParameterValue("userfullname", str_name)
                rptdoc.SetParameterValue("eventname", frmMain.PageantTitle.Text)
                rptdoc.SetParameterValue("categoryname", cbCriteria.Text & " | Per Judge")
            rptdoc.SetParameterValue("gender", cbGender.Text)
                rptdoc.SetParameterValue("judgingcategory", "PRELIMINARY")
                ReportViewer.ReportSource = rptdoc
            dg_report.DataSource = Nothing
            Catch ex As Exception
            End Try
        Else
            Try
                'load_datagrid("WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ) SELECT ct.contestant_number, ct.contestant_name, COALESCE(MAX(CASE WHEN s.judge_number = 1 THEN s.judge_score END), 0) AS judge_1_score, COALESCE(MAX(CASE WHEN s.judge_number = 2 THEN s.judge_score END), 0) AS judge_2_score, COALESCE(MAX(CASE WHEN s.judge_number = 3 THEN s.judge_score END), 0) AS judge_3_score, COALESCE(MAX(CASE WHEN s.judge_number = 4 THEN s.judge_score END), 0) AS judge_4_score, COALESCE(MAX(CASE WHEN s.judge_number = 5 THEN s.judge_score END), 0) AS judge_5_score, COALESCE(MAX(CASE WHEN s.judge_number = 6 THEN s.judge_score END), 0) AS judge_6_score, COALESCE(MAX(CASE WHEN s.judge_number = 7 THEN s.judge_score END), 0) AS judge_7_score, COALESCE(MAX(CASE WHEN s.judge_number = 8 THEN s.judge_score END), 0) AS judge_8_score, COALESCE(MAX(CASE WHEN s.judge_number = 9 THEN s.judge_score END), 0) AS judge_9_score, COALESCE(MAX(CASE WHEN s.judge_number = 10 THEN s.judge_score END), 0) AS judge_10_score, COALESCE(MAX(CASE WHEN s.judge_number = 11 THEN s.judge_score END), 0) AS judge_11_score, COALESCE(MAX(CASE WHEN s.judge_number = 12 THEN s.judge_score END), 0) AS judge_12_score, COALESCE(MAX(CASE WHEN s.judge_number = 13 THEN s.judge_score END), 0) AS judge_13_score, COALESCE(MAX(CASE WHEN s.judge_number = 14 THEN s.judge_score END), 0) AS judge_14_score, COALESCE(MAX(CASE WHEN s.judge_number = 15 THEN s.judge_score END), 0) AS judge_15_score,  COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100, 0) AS total_score, RANK() OVER (ORDER BY COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges * c.percentage / 100, 0) DESC) AS rank FROM tbl_contestants ct LEFT JOIN tbl_scoring s ON ct.ID = s.contestant_ID AND s.criteria_ID = " & CInt(cbCriteria.SelectedValue) & " LEFT JOIN tbl_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj WHERE ct.contestant_gender = '" & cbGender.Text & "' GROUP BY ct.ID ORDER BY total_score DESC;", dg_report)

                load_datagrid("WITH total_judges AS ( SELECT COUNT(ID) AS total_judges FROM tbl_system_accounts WHERE type = 'Judge' ) SELECT ct.contestant_number, ct.contestant_name, MAX(CASE WHEN s.judge_number = 1 THEN s.judge_score END) AS judge_1_score, MAX(CASE WHEN s.judge_number = 2 THEN s.judge_score END) AS judge_2_score, MAX(CASE WHEN s.judge_number = 3 THEN s.judge_score END) AS judge_3_score, MAX(CASE WHEN s.judge_number = 4 THEN s.judge_score END) AS judge_4_score, MAX(CASE WHEN s.judge_number = 5 THEN s.judge_score END) AS judge_5_score, MAX(CASE WHEN s.judge_number = 6 THEN s.judge_score END) AS judge_6_score, MAX(CASE WHEN s.judge_number = 7 THEN s.judge_score END) AS judge_7_score, MAX(CASE WHEN s.judge_number = 8 THEN s.judge_score END) AS judge_8_score, MAX(CASE WHEN s.judge_number = 9 THEN s.judge_score END) AS judge_9_score, MAX(CASE WHEN s.judge_number = 10 THEN s.judge_score END) AS judge_10_score, MAX(CASE WHEN s.judge_number = 11 THEN s.judge_score END) AS judge_11_score, MAX(CASE WHEN s.judge_number = 12 THEN s.judge_score END) AS judge_12_score, MAX(CASE WHEN s.judge_number = 13 THEN s.judge_score END) AS judge_13_score, MAX(CASE WHEN s.judge_number = 14 THEN s.judge_score END) AS judge_14_score, MAX(CASE WHEN s.judge_number = 15 THEN s.judge_score END) AS judge_15_score,  COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges, 0) AS total_score, RANK() OVER (ORDER BY COALESCE(SUM(COALESCE(s.judge_score, 0)) / tj.total_judges, 0) DESC) AS rank FROM tbl_top t LEFT JOIN tbl_contestants ct ON t.contestant_ID = ct.ID LEFT JOIN tbl_final_scoring s ON t.contestant_ID = s.contestant_ID AND s.criteria_ID = " & CInt(cbCriteria.SelectedValue) & " LEFT JOIN tbl_final_criterias c ON s.criteria_ID = c.ID CROSS JOIN total_judges tj WHERE ct.contestant_gender = '" & cbGender.Text & "' GROUP BY t.contestant_ID ORDER BY total_score DESC;", dg_report)

                Dim dt As New DataTable
            With dt
                .Columns.Add("candidatenumber")
                .Columns.Add("candidatename")
                .Columns.Add("J1")
                .Columns.Add("J2")
                .Columns.Add("J3")
                .Columns.Add("J4")
                .Columns.Add("J5")
                .Columns.Add("J6")
                .Columns.Add("J7")
                .Columns.Add("J8")
                .Columns.Add("J9")
                .Columns.Add("J10")
                .Columns.Add("J11")
                .Columns.Add("J12")
                .Columns.Add("J13")
                .Columns.Add("J14")
                .Columns.Add("J15")
                .Columns.Add("average")
            End With
            For Each dr As DataGridViewRow In dg_report.Rows
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, dr.Cells(5).Value, dr.Cells(6).Value, dr.Cells(7).Value, dr.Cells(8).Value, dr.Cells(9).Value, dr.Cells(10).Value, dr.Cells(11).Value, dr.Cells(12).Value, dr.Cells(13).Value, dr.Cells(14).Value, dr.Cells(15).Value, dr.Cells(16).Value, Format(CDec(dr.Cells(17).Value), "#,##0.00"))
                Next
                Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New ReportReportPerJudge15
            rptdoc.SetDataSource(dt)
            rptdoc.SetParameterValue("userfullname", str_name)
                rptdoc.SetParameterValue("eventname", frmMain.PageantTitle.Text)
                rptdoc.SetParameterValue("categoryname", cbCriteria.Text & " | Per Judge")
            rptdoc.SetParameterValue("gender", cbGender.Text)
            rptdoc.SetParameterValue("judgingcategory", "FINAL")
            ReportViewer.ReportSource = rptdoc
            dg_report.DataSource = Nothing
            Catch ex As Exception
            End Try
        End If



    End Sub
End Class