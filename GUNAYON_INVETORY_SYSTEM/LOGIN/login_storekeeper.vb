Imports MySql.Data.MySqlClient
Public Class login_storekeeper

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If txt_username.Text = Nothing Or txt_password.Text = Nothing Then
            MsgBox("Put Valid Credentials", MsgBoxStyle.Exclamation)
        Else
            If con.State = ConnectionState.Closed Then
                open()
            End If

            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM storekeeper_login WHERE username = '" & txt_username.Text & "' AND password = '" & txt_password.Text & "' ", con)
            'cmd.Parameters.AddWithValue("@1", MySqlDbType.VarChar).Value = txt_username.Text
            'cmd.Parameters.AddWithValue("@2", MySqlDbType.VarChar).Value = txt_password.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar)

            If (count > 0) Then
                storekeeper_main.Show()
                Me.Hide()
            Else
                MsgBox("Account not found", MsgBoxStyle.Critical)
                Me.Controls.Clear()
                Me.InitializeComponent()
            End If
            CheckBox1.Checked = True
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If txt_password.UseSystemPasswordChar = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub login_storekeeper_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True
    End Sub
End Class