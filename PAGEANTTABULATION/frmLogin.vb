Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If IS_EMPTY(txtUsername) = True Then Return
            If IS_EMPTY(txtPassword) = True Then Return
            cn.Close()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_system_accounts where username = @1 and password = @2", cn)
            With cm
                .Parameters.AddWithValue("@1", txtUsername.Text)
                .Parameters.AddWithValue("@2", txtPassword.Text)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                str_userid = dr.Item("ID").ToString
                str_user = dr.Item("username").ToString
                str_name = dr.Item("user_name").ToString
                str_role = dr.Item("type").ToString
                str_user_number = CInt(dr.Item("a_number").ToString)

                txtPassword.Text = String.Empty
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox("System Failed. " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion) = vbYes Then
            MsgBox("System Exit!", vbExclamation)
            Application.Exit()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        LoginPanel.BringToFront()

        txtUsername.Text = My.Settings.Username
        txtHost.Text = My.Settings.Host
        txtUser.Text = My.Settings.User
        txtPass.Text = My.Settings.Pass

        'txtHost.Text = "127.0.0.1"
        'txtUser.Text = "server"
        'txtPass.Text = "cronasia"

        systemdbhost = txtHost.Text
        systemdbuser = txtUser.Text
        systemdbpass = txtPass.Text
        Try
            Connection1()
        Catch ex As Exception
            ConnectionPanel.BringToFront()
        End Try
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        systemdbhost = txtHost.Text
        systemdbuser = txtUser.Text
        systemdbpass = txtPass.Text

        Try
            Connection1()

            My.Settings.Host = txtHost.Text
            My.Settings.User = txtUser.Text
            My.Settings.Pass = txtPass.Text

            LoginPanel.BringToFront()
        Catch ex As Exception
            ConnectionPanel.BringToFront()
            MsgBox("Connection Failed!", vbCritical)
        End Try
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub LoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginPanel.Paint

    End Sub
End Class