Imports MySql.Data.MySqlClient
Imports System.IO

Module Modules
    Public Sub OpenForm(frm As Form)
        If frm.IsHandleCreated Then
            frm.BringToFront()
        Else
            frm.TopLevel = False
            frmMain.MainPanel.Controls.Add(frm)

            ' Center the form relative to the parent container (MainPanel)
            frm.Left = (frmMain.MainPanel.Width - frm.Width) \ 2
            frm.Top = (frmMain.MainPanel.Height - frm.Height) \ 2

            frm.BringToFront()
            frm.Show()
        End If
    End Sub

    Public Sub query(ByVal sql As String)
        cn.Close()
        cn.Open()
        cm = New MySqlCommand(sql, cn)
        cm.ExecuteNonQuery()
        cm.Dispose()
        cn.Close()
    End Sub

    Public Sub fillCombo(ByVal sql As String, ByVal combo_box As Object, ByVal table As String, ByVal dmember As String, ByVal vmember As String)
        Try
            cn.Close()
            cn.Open()
            Dim dtc As DataTableCollection
            ds = New DataSet
            dtc = ds.Tables
            da = New MySqlDataAdapter(sql, cn)
            da.Fill(ds, table)
            Dim view1 As New DataView(dtc(0))
            With combo_box
                .DataSource = ds.Tables(table)
                .DisplayMember = dmember
                .ValueMember = vmember
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With
            cn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Function IS_EMPTY(ByRef sText As Object) As Boolean
        On Error Resume Next
        If sText.Text = String.Empty Then
            IS_EMPTY = True
            sText.BackColor = Color.FromArgb(255, 192, 192)

            ' Scroll to the control
            Dim parentControl As Control = sText.Parent
            If TypeOf parentControl Is ScrollableControl Then
                Dim scrollableParent As ScrollableControl = CType(parentControl, ScrollableControl)
                scrollableParent.ScrollControlIntoView(sText)
            End If

            sText.SetFocus()
            MsgBox("Warning: Required missing field. Please fill in all required fields marked in red.", vbExclamation)
        Else
            IS_EMPTY = False
            sText.BackColor = Color.White
        End If
        Return IS_EMPTY
    End Function

    Public Function GetColumnSum(ByVal dgv As DataGridView, ByVal colIndex As Integer) As Decimal
        Dim sum As Double = 0.0
        For Each row As DataGridViewRow In dgv.Rows
            ' Check if cell value is numeric before adding
            If IsNumeric(row.Cells(colIndex).Value) Then
                sum += Convert.ToDecimal(row.Cells(colIndex).Value)
            End If
        Next
        Return sum
    End Function

    Public Sub load_datagrid(ByVal sql As String, ByVal DTG As Object)
        cn.Close()
        cn.Open()
        dt = New DataTable
        With cm
            .Connection = cn
            .CommandText = sql
        End With
        da.SelectCommand = cm
        da.Fill(dt)
        DTG.DataSource = dt
        da.Dispose()
        cn.Close()
    End Sub
End Module
