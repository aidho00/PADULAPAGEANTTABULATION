Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class frmCriteria

#Region "Drag Form"

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown  ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove  ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp   ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SubCriteriaAddPanel.BringToFront()
        btnAddSubCriteria.Visible = True
        btnUpdateSubCriteria.Visible = False

    End Sub

    Private Sub btnClose2_Click(sender As Object, e As EventArgs) Handles btnClose2.Click
        SubCriteriaAddPanel.SendToBack()
        txtSubCriteria.Text = String.Empty
        txtsubCriteriaPercentage.Text = String.Empty
    End Sub

    Private Sub btnAddCriteria_Click(sender As Object, e As EventArgs) Handles btnAddCriteria.Click
        Dim drr As DialogResult
        drr = MessageBox.Show("Add new " & criteriaType.Text & " criteria?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If drr = DialogResult.No Then

        Else
            If criteriaType.Text = "Preliminary" Then
                Dim Criteria_Percentage_Total As Decimal
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select Sum(percentage) as Total from tbl_criterias", cn)
                    Criteria_Percentage_Total = cm.ExecuteScalar.ToString.ToUpper
                    cn.Close()
                Catch ex As Exception
                End Try

                If CDec(txtPercentage.Text) > 100 Then
                    MessageBox.Show("New preliminary criteria percentage to add exceeds 100 percent if added.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    query("INSERT INTO tbl_criterias (criteria_name, percentage, criteria_status) VALUES ('" & txtCriteriaDesc.Text & "', " & CDec(txtPercentage.Text) & ", '" & cbStatus.Text & "')")
                    MessageBox.Show("Preliminary criteria added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmSettings.PreliminaryCriteriaList()
                    Me.Close()
                End If
            Else
                Dim Criteria_Percentage_Total As Decimal
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select Sum(percentage) as Total from tbl_final_criterias", cn)
                    Criteria_Percentage_Total = cm.ExecuteScalar.ToString.ToUpper
                    cn.Close()
                Catch ex As Exception
                End Try

                If CDec(txtPercentage.Text) > 100 Then
                    MessageBox.Show("New final criteria percentage to add exceeds 100 percent if added.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    query("INSERT INTO tbl_final_criterias (criteria_name, percentage, criteria_status) VALUES ('" & txtCriteriaDesc.Text & "', " & CDec(txtPercentage.Text) & ", '" & cbStatus.Text & "')")
                    MessageBox.Show("Final criteria added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmSettings.FinalCriteriaList()
                    Me.Close()
                End If
            End If


        End If
        PercentageTotal()
    End Sub

    Private Sub btnUpdateCriteria_Click(sender As Object, e As EventArgs) Handles btnUpdateCriteria.Click
        Dim drr As DialogResult
        drr = MessageBox.Show("Update " & criteriaType.Text & " criteria?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If drr = DialogResult.No Then

        Else
            If criteriaType.Text = "Preliminary" Then
                Dim Criteria_Percentage_Total As Decimal
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select Sum(percentage) as Total from tbl_criterias where ID not in (" & CInt(criteriaID.Text) & "", cn)
                    Criteria_Percentage_Total = cm.ExecuteScalar.ToString.ToUpper
                    cn.Close()
                Catch ex As Exception
                End Try

                If Criteria_Percentage_Total + CDec(txtPercentage.Text) > 100 Then
                    MessageBox.Show("Preliminary criteria percentage to update exceeds 100 percent if added.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    query("UPDATE tbl_criterias set criteria_name = '" & txtCriteriaDesc.Text & "', percentage = " & CDec(txtPercentage.Text) & ", criteria_status = '" & cbStatus.Text & "' WHERE ID = " & CInt(criteriaID.Text) & "")
                    MessageBox.Show("Preliminary criteria added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmSettings.PreliminaryCriteriaList()
                End If
            Else
                Dim Criteria_Percentage_Total As Decimal
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select Sum(percentage) as Total from tbl_final_criterias where ID not in (" & CInt(criteriaID.Text) & "", cn)
                    Criteria_Percentage_Total = cm.ExecuteScalar.ToString.ToUpper
                    cn.Close()
                Catch ex As Exception
                End Try

                If Criteria_Percentage_Total + CDec(txtPercentage.Text) > 100 Then
                    MessageBox.Show("Final criteria percentage to update exceeds 100 percent if added.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    query("UPDATE tbl_final_criterias set criteria_name = '" & txtCriteriaDesc.Text & "', percentage = " & CDec(txtPercentage.Text) & ", criteria_status = '" & cbStatus.Text & "' WHERE ID = " & CInt(criteriaID.Text) & "")
                    MessageBox.Show("Final criteria added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmSettings.FinalCriteriaList()
                End If
            End If


        End If
        PercentageTotal()
    End Sub

    Private Sub txtPercentage_TextChanged(sender As Object, e As EventArgs) Handles txtPercentage.TextChanged

    End Sub

    Private Sub txtPercentage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPercentage.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Sub SubPreliminaryCriteriaList()
        Try

            dgSubCriteria.Rows.Clear()
            Dim sql As String
            sql = "SELECT `ID`, `criteria_name`, `percentage` FROM `tbl_subcriterias` where criteria_ID = " & CInt(criteriaID.Text) & ""
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgSubCriteria.Rows.Add(dr.Item("ID").ToString, dr.Item("criteria_name").ToString, dr.Item("percentage").ToString)
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            dr.Close()
            cn.Close()
            dgSubCriteria.Rows.Clear()
        End Try
    End Sub

    Sub SubFinalCriteriaList()
        Try

            dgSubCriteria.Rows.Clear()
            Dim sql As String
            sql = "SELECT `ID`, `criteria_name`, `percentage` FROM `tbl_subcriterias2` where criteria_ID = " & CInt(criteriaID.Text) & ""
            cn.Close()
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgSubCriteria.Rows.Add(dr.Item("ID").ToString, dr.Item("criteria_name").ToString, dr.Item("percentage").ToString)
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            dr.Close()
            cn.Close()
            dgSubCriteria.Rows.Clear()
        End Try
    End Sub

    Private Sub btnAddSubCriteria_Click(sender As Object, e As EventArgs) Handles btnAddSubCriteria.Click
        Dim drr As DialogResult
        drr = MessageBox.Show("Add new " & criteriaType.Text & " sub criteria?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If drr = DialogResult.No Then

        Else
            If criteriaType.Text = "Preliminary" Then
                Dim Criteria_Percentage_Total As Decimal
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select Sum(percentage) as Total from tbl_subcriterias where criteria_ID = " & CInt(criteriaID.Text) & "", cn)
                    Criteria_Percentage_Total = cm.ExecuteScalar.ToString.ToUpper
                    cn.Close()
                Catch ex As Exception
                End Try

                If Criteria_Percentage_Total + CDec(txtsubCriteriaPercentage.Text) > CDec(txtPercentage.Text) Then
                    MessageBox.Show("New preliminary sub criteria percentage to add exceeds " & txtPercentage.Text & " percent if added.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    query("INSERT INTO tbl_subcriterias (criteria_name, percentage, criteria_ID) VALUES ('" & txtSubCriteria.Text & "', " & CDec(txtsubCriteriaPercentage.Text) & ", " & CInt(criteriaID.Text) & ")")
                    MessageBox.Show("Preliminary sub criteria added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SubPreliminaryCriteriaList()
                    SubCriteriaAddPanel.SendToBack()
                    txtSubCriteria.Text = String.Empty
                    txtsubCriteriaPercentage.Text = String.Empty
                End If
            Else
                Dim Criteria_Percentage_Total As Decimal
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select Sum(percentage) as Total from tbl_subcriterias2 where criteria_ID = " & CInt(criteriaID.Text) & "", cn)
                    Criteria_Percentage_Total = cm.ExecuteScalar.ToString.ToUpper
                    cn.Close()
                Catch ex As Exception
                End Try

                If Criteria_Percentage_Total + CDec(txtsubCriteriaPercentage.Text) > CDec(txtPercentage.Text) Then
                    MessageBox.Show("New final sub criteria percentage to add exceeds " & txtPercentage.Text & " percent if added.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    query("INSERT INTO tbl_subcriterias2 (criteria_name, percentage, criteria_ID) VALUES ('" & txtSubCriteria.Text & "', " & CDec(txtsubCriteriaPercentage.Text) & ", " & CInt(criteriaID.Text) & ")")
                    MessageBox.Show("Final sub criteria added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SubFinalCriteriaList()
                    SubCriteriaAddPanel.SendToBack()
                    txtSubCriteria.Text = String.Empty
                    txtsubCriteriaPercentage.Text = String.Empty
                End If
            End If

        End If
        PercentageTotal()
    End Sub

    Private Sub dgSubCriteria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSubCriteria.CellContentClick
        Dim colname As String = dgSubCriteria.Columns(e.ColumnIndex).Name
        If colname = "colUpdate" Then
            txtSubCriteria.Text = String.Empty
            txtsubCriteriaPercentage.Text = String.Empty
            criteriaID2.Text = dgSubCriteria.CurrentRow.Cells(0).Value
            txtSubCriteria.Text = dgSubCriteria.CurrentRow.Cells(1).Value
            txtsubCriteriaPercentage.Text = dgSubCriteria.CurrentRow.Cells(2).Value
            btnAddSubCriteria.Visible = False
            btnUpdateSubCriteria.Visible = True

            SubCriteriaPanel.SendToBack()
            PercentageTotal()
        End If
    End Sub
    Sub PercentageTotal()
        If dgSubCriteria.RowCount = 0 Then
            lblTotalPercentage.Text = "0"

        Else
            Dim sum As Decimal = 0
            Dim selectedRowIndex As Integer = dgSubCriteria.CurrentCell.RowIndex
            Dim columnIndex As Integer = dgSubCriteria.Columns(2).Index ' Replace with your column name or index

            For Each row As DataGridViewRow In dgSubCriteria.Rows
                If row.Index <> selectedRowIndex AndAlso Not row.IsNewRow Then
                    Dim cellValue As Object = row.Cells(columnIndex).Value
                    If IsNumeric(cellValue) Then
                        sum += Convert.ToDecimal(cellValue)
                    End If
                End If
            Next
            lblTotalPercentage.Text = sum
        End If
    End Sub
    Private Sub btnUpdateSubCriteria_Click(sender As Object, e As EventArgs) Handles btnUpdateSubCriteria.Click
        Dim drr As DialogResult
        drr = MessageBox.Show("Update new " & criteriaType.Text & " sub criteria?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If drr = DialogResult.No Then

        Else
            If criteriaType.Text = "Preliminary" Then
                Dim Criteria_Percentage_Total As Decimal
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select Sum(percentage) as Total from tbl_subcriterias where criteria_ID = " & CInt(criteriaID.Text) & " and ID not in (" & CInt(criteriaID2.Text) & ")", cn)
                    Criteria_Percentage_Total = cm.ExecuteScalar.ToString.ToUpper
                    cn.Close()
                Catch ex As Exception
                End Try

                If Criteria_Percentage_Total + CDec(txtsubCriteriaPercentage.Text) > CDec(txtPercentage.Text) Then
                    MessageBox.Show("Preliminary sub criteria percentage to update exceeds " & txtPercentage.Text & " percent if added.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    query("UPDATE tbl_subcriterias set criteria_name = '" & txtSubCriteria.Text & "', percentage = " & CDec(txtsubCriteriaPercentage.Text) & " where ID = " & CInt(criteriaID2.Text) & "")
                    MessageBox.Show("Preliminary sub criteria updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SubPreliminaryCriteriaList()
                    SubCriteriaAddPanel.SendToBack()
                    txtSubCriteria.Text = String.Empty
                    txtsubCriteriaPercentage.Text = String.Empty
                End If
            Else
                Dim Criteria_Percentage_Total As Decimal
                Try
                    cn.Close()
                    cn.Open()
                    cm = New MySqlCommand("select Sum(percentage) as Total from tbl_subcriterias2 where criteria_ID = " & CInt(criteriaID.Text) & " and ID not in (" & CInt(criteriaID2.Text) & ")", cn)
                    Criteria_Percentage_Total = cm.ExecuteScalar.ToString.ToUpper
                    cn.Close()
                Catch ex As Exception
                End Try

                If Criteria_Percentage_Total + CDec(txtSubCriteria.Text) > CDec(txtPercentage.Text) Then
                    MessageBox.Show("Final sub criteria percentage to add exceeds " & txtPercentage.Text & " percent if added.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    query("UPDATE tbl_subcriterias2 set criteria_name = '" & txtSubCriteria.Text & "', percentage = " & CDec(txtsubCriteriaPercentage.Text) & " where ID = " & CInt(criteriaID2.Text) & "")
                    MessageBox.Show("Final sub criteria updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SubFinalCriteriaList()
                    SubCriteriaAddPanel.SendToBack()
                    txtSubCriteria.Text = String.Empty
                    txtsubCriteriaPercentage.Text = String.Empty
                End If
            End If

        End If
        PercentageTotal()
    End Sub

    Private Sub frmCriteria_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SubCriteriaAddPanel.SendToBack()
        txtCriteriaDesc.Text = String.Empty
        txtPercentage.Text = String.Empty
    End Sub
End Class