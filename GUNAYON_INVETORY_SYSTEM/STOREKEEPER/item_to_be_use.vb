Imports MySql.Data.MySqlClient
Public Class item_to_be_use

    Private Sub item_to_be_use_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If


        open()
        sql = "SELECT * FROM items"
        Took(sql, "items", con, da)

        For i = 0 To ds.Tables("items").Rows.Count - 1
            txtitem_id.Items.Add(ds.Tables("items").Rows(i).Item(0))
        Next
        con.Close()

        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM items ORDER BY item_id ASC"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "items")
        DataGridView1.DataSource = ds.Tables("items")
        con.Close()

        If ConnectionState.Open Then
            con.Close()
        End If


        open()
        sql = "SELECT * FROM storekeeper_login"
        Took(sql, "storekeeper_login", con, da)

        For i = 0 To ds.Tables("storekeeper_login").Rows.Count - 1
            txtsk_id.Items.Add(ds.Tables("storekeeper_login").Rows(i).Item(0))
        Next
        con.Close()


        txtdate.Text = Format(Date.Now(), "yyyy-MM-dd")

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtitem_id.SelectedIndexChanged
        ds.Clear()

        Try
            open()

            sql = "SELECT * FROM items WHERE item_id= " & CInt(txtitem_id.SelectedItem) & ""
            Took(sql, "items", con, da)


            txtname.Text = (ds.Tables("items").Rows(0).Item(1))



        Catch ex As Exception

        End Try

        con.Close()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM items ORDER BY item_id ASC"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "items")
        DataGridView1.DataSource = ds.Tables("items")
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If txtitem_id.Text = "" Or txtsk_id.Text = "" Or txtname.Text = "" Or txtquantity.Text = "" Or txtdate.Text = "" Or txtusefor.Text = "" Then
            MsgBox("Please Fill Out everything")
        Else
            Try
                ds.Reset()
                If ConnectionState.Open Then
                    con.Close()
                End If

                open()
                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - ' " & CInt(txtquantity.Text) & " ' WHERE item_id = ' " & txtitem_id.Text & "' ", con)
                sqlcommand.ExecuteNonQuery()

                Dim cmd As New MySqlCommand("INSERT INTO sk_items(sk_id, item_id, item_name, used_for, quantity_used, date_used) VALUES('" & CInt(txtsk_id.Text) & "', '" & CInt(txtitem_id.Text) & "', '" & txtname.Text & "', '" & txtusefor.Text & "', '" & CInt(txtquantity.Text) & "', '" & txtdate.Text & "')", con)
                cmd.ExecuteNonQuery()


                sql = "SELECT * FROM items ORDER BY item_id ASC"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")


                MsgBox("ITEM USED")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        con.Close()
    End Sub

End Class