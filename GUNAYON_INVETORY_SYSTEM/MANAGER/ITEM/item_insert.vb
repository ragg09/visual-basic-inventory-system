Imports MySql.Data.MySqlClient
Public Class item_insert

    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()

        Dim cmd As New MySqlCommand("INSERT INTO items(item_name, item_unit, item_cost_in_unit, item_pc_per_pack, item_cost_per_pc, item_quantity, item_selling_cost) VALUES('" & txtname.Text & "', '" & txtunit.Text & "', '" & CInt(txtcost_in_unit.Text) & "', '" & CInt(txtpc_pe_pack.Text) & "', '" & CInt(txtcost_per_pc.Text) & "','" & CInt(txtquantity.Text) & "', '" & CInt(txtselling_cost.Text) & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("New Record Added")
        con.Close()

        txtname.Clear()
        txtunit.Text = ""
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
        sql = "SELECT item_name, item_unit, item_quantity, item_selling_cost FROM items"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "items")
        DataGridView1.DataSource = ds.Tables("items")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtunit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtunit.SelectedIndexChanged

    End Sub

    Private Sub item_insert_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class