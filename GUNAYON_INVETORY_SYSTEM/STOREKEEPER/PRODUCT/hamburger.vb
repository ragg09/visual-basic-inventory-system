Imports MySql.Data.MySqlClient
Public Class hamburger

    Private Sub btncheck_Click(sender As System.Object, e As System.EventArgs) Handles btncheck.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM items ORDER BY item_quantity ASC"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "items")
        DataGridView2.DataSource = ds.Tables("items")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dateissued = DateTimePicker1.Value
        TextBox1.Text = Format(dateissued, "yyyy-MM-dd")
    End Sub

    Private Sub btn_Click(sender As System.Object, e As System.EventArgs) Handles btn.Click
        If TextBox1.Text = "" Then
            MsgBox("SELECT DATE")
        Else
            Try

                ds.Reset()
                If ConnectionState.Open Then
                    con.Close()
                End If

                open()

                trans = con.BeginTransaction

                Dim burger As String = InputBox("INPUT QUANTITY TO BE CREATED")

                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & burger & "' WHERE item_id = 29 ", con)
                sqlcommand.ExecuteNonQuery()

                Dim sqlcommand2 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & burger & "' WHERE item_id = 31 ", con)
                sqlcommand2.ExecuteNonQuery()

                Dim sqlcommand3 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & burger & "' WHERE item_id = 35 ", con)
                sqlcommand3.ExecuteNonQuery()

                Dim burger2 As Integer
                burger2 = 30 * burger

                Dim sqlcommand6 As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity + '" & burger2 & "' WHERE prod_id = 8 ", con)
                sqlcommand6.ExecuteNonQuery()

                Dim sqlcommand7 As New MySqlCommand("UPDATE product SET prod_date = '" & TextBox1.Text & "' WHERE prod_id = 8", con)
                sqlcommand7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 29)", con)
                cmd.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 31)", con)
                cmd2.ExecuteNonQuery()

                Dim cmd3 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 35)", con)
                cmd3.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                Dim cmd7 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES('" & TextBox1.Text & "', (SELECT SUM(item_cost_in_unit) FROM items WHERE item_id = 29 OR item_id = 31 OR item_id = 35), 0, 1)", con)
                cmd7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 29 OR item_id = 31 OR item_id = 35 "
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("3 new record added in product items due to the creation of HAMBURGER")
                MsgBox("Expense added in Manager Monitoring")
                MsgBox("HAMBURGER CREATED SUCCESFULLY")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub
End Class