Imports MySql.Data.MySqlClient
Public Class sk_create

    Private Sub btn_display_Click(sender As System.Object, e As System.EventArgs) Handles btn_display.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM storekeeper_login"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "storekeeper_login")
        DataGridView1.DataSource = ds.Tables("storekeeper_login")

    End Sub

    Private Sub sk_create_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If


        open()
        sql = "SELECT * FROM manager_login"
        Took(sql, "manager_login", con, da)

        For i = 0 To ds.Tables("manager_login").Rows.Count - 1
            txtman_id.Items.Add(ds.Tables("manager_login").Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()

        Dim cmd As New MySqlCommand("INSERT INTO storekeeper_login(username, password, man_id) VALUES('" & txtusername.Text & "', '" & txtpassword.Text & "', '" & CInt(txtman_id.Text) & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("New Record Added")
        con.Close()

        txtusername.Clear()
        txtman_id.Text = ""
        txtpassword.Clear()
    End Sub

End Class