Imports MySql.Data.MySqlClient
Public Class item_order

    Private Sub item_order_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Reset()

        If ConnectionState.Open Then
            con.Close()
        End If


        open()
        sql = "SELECT * FROM items"
        Took(sql, "items", con, da)

        For i = 0 To ds.Tables("items").Rows.Count - 1
            cbitem.Items.Add(ds.Tables("items").Rows(i).Item(0))
        Next
        con.Close()


        open()
        sql = "SELECT * FROM manager_login"
        Took(sql, "manager_login", con, da)

        For i = 0 To ds.Tables("manager_login").Rows.Count - 1
            cbmanid.Items.Add(ds.Tables("manager_login").Rows(i).Item(0))
        Next
        con.Close()

        open()
        sql = "SELECT * FROM supplier"
        Took(sql, "supplier", con, da)

        For i = 0 To ds.Tables("supplier").Rows.Count - 1
            cbsupid.Items.Add(ds.Tables("supplier").Rows(i).Item(0))
        Next
        con.Close()

        txtdate.Text = Format(Date.Now(), "yyyy-MM-dd")
    End Sub

    Private Sub cbitem_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbitem.SelectedIndexChanged
        ds.Clear()

        Try
            open()

            sql = "SELECT * FROM items WHERE item_id = " & cbitem.SelectedItem & ""
            Took(sql, "items", con, da)

            txtitemname.Text = (ds.Tables("items").Rows(0).Item(1))
            txtitemcost.Text = (ds.Tables("items").Rows(0).Item(3))
            txtcurquantity.Text = (ds.Tables("items").Rows(0).Item(6))


            con.Close()
        Catch ex As Exception

        End Try

        'txttotal.Text = CInt(txtitemcost.Text) * CInt(txtquantity.Text)

        If txtitemcost.Text = "" Or txtquantity.Text = "" Then
            txttotal.Text = 0
        Else
            txttotal.Text = CInt(txtitemcost.Text) * CInt(txtquantity.Text)
        End If
    End Sub

    Private Sub btnorder_Click(sender As System.Object, e As System.EventArgs) Handles btnorder.Click
       
        ds.Reset()
        If cbmanid.Text = "" Or cbsupid.Text = "" Or cbitem.Text = "" Or txtdate.Text = "" Or txtcurquantity.Text = "" Then
            MsgBox("Please Fill up all neccesarry information")
        Else

            Try
                If ConnectionState.Open Then
                    con.Close()
                End If

                open()

                trans = con.BeginTransaction



                Dim cmd As New MySqlCommand("INSERT INTO manager_supplier(man_id, sup_id, item, purchase_date, quantity, total_amount) VALUES('" & CInt(cbmanid.Text) & "', '" & CInt(cbsupid.Text) & "', '" & txtitemname.Text & "' , '" & txtdate.Text & "' , '" & CInt(txtquantity.Text) & "' , '" & CInt(txttotal.Text) & "')", con)
                cmd.ExecuteNonQuery()


                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = '" & CInt(txtquantity.Text) & "' + '" & CInt(txtcurquantity.Text) & "'  WHERE item_id = ' " & CInt(cbitem.Text) & " '", con)
                sqlcommand.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES('" & txtdate.Text & "', '" & CInt(txttotal.Text) & "', 0, 1)", con)
                cmd2.ExecuteNonQuery()

                Dim cmd3 As New MySqlCommand("INSERT INTO item_supplier(item_id, sup_id, quantity, date_purchased) VALUES(' " & CInt(cbitem.Text) & " ', '" & CInt(cbsupid.Text) & "', '" & CInt(txtquantity.Text) & "', '" & txtdate.Text & "')", con)
                cmd3.ExecuteNonQuery()

                trans.Commit()

                MsgBox("ORDER SUCCESFULLY")
            Catch ex As MySqlException
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
            con.Close()
        End If
        'If ConnectionState.Open Then
        '    con.Close()
        'End If

        'open()


        'Dim cmd As New MySqlCommand("INSERT INTO manager_supplier() VALUES('" & CInt(cbmanid.Text) & "', '" & CInt(cbsupid.Text) & "', '" & txtitemname.Text & "' , '" & txtdate.Text & "' , '" & CInt(txtquantity.Text) & "' , '" & CInt(txttotal.Text) & "')", con)
        'cmd.ExecuteNonQuery()

        'con.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ds.Clear()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT DISTINCT item_id, item_name, item_unit, item_cost_in_unit, item_pc_per_pack, item_cost_per_pc, item_quantity, item_selling_cost FROM items"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "items")
        DataGridView1.DataSource = ds.Tables("items")

        con.Close()
    End Sub


End Class