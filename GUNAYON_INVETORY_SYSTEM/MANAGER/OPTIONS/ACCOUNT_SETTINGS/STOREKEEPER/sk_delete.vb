Imports MySql.Data.MySqlClient
Public Class sk_delete

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ds.Clear()
        Try
            open()

            sql = "SELECT * FROM storekeeper_login WHERE sk_id = " & CInt(ComboBox1.SelectedItem) & ""
            Took(sql, "storekeeper_login", con, da)

            txtid.Text = (ds.Tables("storekeeper_login").Rows(0).Item(0))
            txtusername.Text = (ds.Tables("storekeeper_login").Rows(0).Item(1))
            txtpassword.Text = (ds.Tables("storekeeper_login").Rows(0).Item(2))
            txtmanid.Text = (ds.Tables("storekeeper_login").Rows(0).Item(3))


        Catch ex As Exception
            MsgBox("SOMETHING WENT WRONG")
        End Try

        con.Close()
    End Sub

    Private Sub sk_delete_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If


        open()
        sql = "SELECT * FROM storekeeper_login"
        Took(sql, "storekeeper_login", con, da)

        For i = 0 To ds.Tables("storekeeper_login").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("storekeeper_login").Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub btnupdate_Click(sender As System.Object, e As System.EventArgs) Handles btnupdate.Click
        ds.Clear()
        Dim ask As MsgBoxResult = MsgBox("Proceed Deletion?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            Dim cmd As New MySqlCommand("DELETE FROM storekeeper_login WHERE sk_id = '" & CInt(ComboBox1.Text) & "' ", con)
            cmd.ExecuteNonQuery()
            MsgBox("New Record Added")
            con.Close()


        End If
    End Sub
End Class