Imports MySql.Data.MySqlClient
Public Class sup_create

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ConnectionState.Open Then
            con.Close()
        End If

        open()

        Dim cmd As New MySqlCommand("INSERT INTO supplier(sup_name) VALUES('" & txtsup_name.Text & "' )", con)
        cmd.ExecuteNonQuery()
        MsgBox("New Record Added")
        con.Close()

        txtsup_name.Clear()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT sup_name FROM supplier"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "supplier")
        DataGridView1.DataSource = ds.Tables("supplier")
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtsup_name_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsup_name.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class