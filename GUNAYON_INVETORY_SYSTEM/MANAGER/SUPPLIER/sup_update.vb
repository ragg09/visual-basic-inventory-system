Imports MySql.Data.MySqlClient
Public Class sup_update

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

    Private Sub sup_update_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Clear()
        If ConnectionState.Open Then
            con.Close()
        End If


        open()
        sql = "SELECT * FROM supplier"
        Took(sql, "supplier", con, da)

        For i = 0 To ds.Tables("supplier").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("supplier").Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ds.Clear()

        Try
            open()

            sql = "SELECT * FROM supplier WHERE sup_id= " & CInt(ComboBox1.SelectedItem) & ""
            Took(sql, "supplier", con, da)


            txtsup_id.Text = (ds.Tables("supplier").Rows(0).Item(0))
            txtsup_name.Text = (ds.Tables("supplier").Rows(0).Item(1))
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ConnectionState.Open Then
            con.Close()
        End If

        open()

        Dim sqlcommand As New MySqlCommand("UPDATE supplier SET sup_name = '" & txtsup_name.Text & "' WHERE sup_id = '" & CInt(ComboBox1.Text) & "' ", con)
        sqlcommand.ExecuteNonQuery()

        MsgBox("Record Updated")
        con.Close()



        txtsup_id.Clear()
        ComboBox1.Text = ""
        txtsup_name.Clear()
    End Sub
End Class