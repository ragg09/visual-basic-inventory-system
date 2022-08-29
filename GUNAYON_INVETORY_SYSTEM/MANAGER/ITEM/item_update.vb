Imports MySql.Data.MySqlClient
Public Class item_update

    Private Sub item_update_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If


        open()
        sql = "SELECT * FROM items"
        Took(sql, "items", con, da)

        For i = 0 To ds.Tables("items").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("items").Rows(i).Item(0))
        Next
        con.Close()

        'open()
        'Dim sqlcommand As New MySqlCommand("SELECT * FROM items", con)
        'da = New MySqlDataAdapter(sqlcommand)
        'da.Fill(table)
        'ComboBox1.DataSource = table
        'ComboBox1.DisplayMember = "item_id"
        'ComboBox1.ValueMember = "item_name"
        'con.Close()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ds.Clear()

        Try
            open()

            sql = "SELECT * FROM items WHERE item_id= " & CInt(ComboBox1.SelectedItem) & ""
            Took(sql, "items", con, da)


            txtitem_id.Text = (ds.Tables("items").Rows(0).Item(0))
            txtname.Text = (ds.Tables("items").Rows(0).Item(1))
            txtcost_in_unit.Text = (ds.Tables("items").Rows(0).Item(3))
            txtpc_pe_pack.Text = (ds.Tables("items").Rows(0).Item(4))
            txtcost_per_pc.Text = (ds.Tables("items").Rows(0).Item(5))
            txtquantity.Text = (ds.Tables("items").Rows(0).Item(6))
            txtselling_cost.Text = (ds.Tables("items").Rows(0).Item(7))


        Catch ex As Exception

        End Try

        con.Close()
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()

        Dim sqlcommand As New MySqlCommand("UPDATE items SET item_name = '" & txtname.Text & "', item_cost_in_unit = '" & CInt(txtcost_in_unit.Text) & "', item_pc_per_pack = '" & CInt(txtpc_pe_pack.Text) & "', item_cost_per_pc = '" & CInt(txtcost_per_pc.Text) & "', item_quantity = '" & CInt(txtquantity.Text) & "', item_selling_cost = '" & CInt(txtselling_cost.Text) & "'  WHERE item_id = '" & CInt(txtitem_id.Text) & "' ", con)
        sqlcommand.ExecuteNonQuery()

        MsgBox("Record Updated")
        con.Close()



        txtitem_id.Clear()
        ComboBox1.Text = ""
        txtname.Clear()
        txtcost_in_unit.Clear()
        txtpc_pe_pack.Clear()
        txtcost_per_pc.Clear()
        txtquantity.Clear()
        txtselling_cost.Clear()

    End Sub

    Private Sub btn_display_Click(sender As System.Object, e As System.EventArgs) Handles btn_display.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM items"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "items")
        DataGridView1.DataSource = ds.Tables("items")
    End Sub
End Class