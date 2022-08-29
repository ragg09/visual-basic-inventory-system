Imports MySql.Data.MySqlClient
Public Class pancake

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

                Dim pancake As String = InputBox("INPUT QUANTITY TO BE CREATED")

                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & pancake & "' WHERE item_id = 8 ", con)
                sqlcommand.ExecuteNonQuery()

                Dim sqlcommand2 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & pancake & "' WHERE item_id = 25 ", con)
                sqlcommand2.ExecuteNonQuery()

                Dim sqlcommand3 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & pancake & "' WHERE item_id = 26 ", con)
                sqlcommand3.ExecuteNonQuery()

                Dim sqlcommand4 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & pancake & "' WHERE item_id = 27 ", con)
                sqlcommand4.ExecuteNonQuery()

                Dim sqlcommand5 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & pancake & "' WHERE item_id = 45 ", con)
                sqlcommand5.ExecuteNonQuery()

                Dim pancake2 As Integer
                pancake2 = 30 * pancake

                Dim sqlcommand6 As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity + '" & pancake2 & "' WHERE prod_id = 7 ", con)
                sqlcommand6.ExecuteNonQuery()

                Dim sqlcommand7 As New MySqlCommand("UPDATE product SET prod_date = '" & TextBox1.Text & "' WHERE prod_id = 7", con)
                sqlcommand7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 8)", con)
                cmd.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 25)", con)
                cmd2.ExecuteNonQuery()

                Dim cmd3 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 26)", con)
                cmd3.ExecuteNonQuery()

                Dim cmd4 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 27)", con)
                cmd4.ExecuteNonQuery()

                Dim cmd5 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 45)", con)
                cmd5.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                Dim cmd7 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES('" & TextBox1.Text & "', (SELECT SUM(item_cost_in_unit) FROM items WHERE item_id = 8 OR item_id = 25 OR item_id = 26 OR item_id = 27 OR item_id = 45), 0, 1)", con)
                cmd7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 8 OR item_id = 25 OR item_id = 26 OR item_id = 27 OR item_id = 45"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("5 new record added in product items due to the creation of PANCAKE")
                MsgBox("Expense added in Manager Monitoring")
                MsgBox("PANCAKE CREATED SUCCESFULLY")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dateissued = DateTimePicker1.Value
        TextBox1.Text = Format(dateissued, "yyyy-MM-dd")
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class