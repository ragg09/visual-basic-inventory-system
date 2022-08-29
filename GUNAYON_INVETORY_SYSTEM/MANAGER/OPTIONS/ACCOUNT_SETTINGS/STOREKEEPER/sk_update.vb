Imports MySql.Data.MySqlClient
Public Class sk_update

    Private Sub sk_update_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Clear()
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ds.Clear()

        Try
            open()

            sql = "SELECT * FROM storekeeper_login WHERE sk_id= " & CInt(ComboBox1.SelectedItem) & ""
            Took(sql, "storekeeper_login", con, da)


            txtusername.Text = (ds.Tables("storekeeper_login").Rows(0).Item(1))
            txtpassword.Text = (ds.Tables("storekeeper_login").Rows(0).Item(2))

            con.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnupdate_Click(sender As System.Object, e As System.EventArgs) Handles btnupdate.Click
        ds.Reset()
        If txtnewpass.Text = txtnewpasss.Text Then
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            Dim sqlcommand As New MySqlCommand("UPDATE storekeeper_login SET password = '" & txtnewpasss.Text & "' WHERE sk_id = '" & CInt(ComboBox1.Text) & "' ", con)
            sqlcommand.ExecuteNonQuery()

            MsgBox("Password Changed")
            con.Close()

            txtnewpass.Clear()
            txtnewpasss.Clear()
        Else
            MsgBox("Password Dont Match")
            txtnewpass.Clear()
            txtnewpasss.Clear()
        End If
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub
End Class