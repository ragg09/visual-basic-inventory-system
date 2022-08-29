Imports MySql.Data.MySqlClient
Public Class palamig

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

                Dim palamig1 As String = InputBox("INPUT QUANTITY TO BE CREATED")

                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 2 ", con)
                sqlcommand.ExecuteNonQuery()

                Dim sqlcommand2 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 3 ", con)
                sqlcommand2.ExecuteNonQuery()

                Dim sqlcommand3 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 9 ", con)
                sqlcommand3.ExecuteNonQuery()

                Dim sqlcommand4 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 10 ", con)
                sqlcommand4.ExecuteNonQuery()

                Dim sqlcommand5 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 11 ", con)
                sqlcommand5.ExecuteNonQuery()

                Dim sqlcommand8 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 17 ", con)
                sqlcommand8.ExecuteNonQuery()
                Dim palamig2 As Integer
                palamig2 = 30 * palamig1
                Dim sqlcommand6 As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity + '" & palamig2 & "' WHERE prod_id = 2", con)
                sqlcommand6.ExecuteNonQuery()

                Dim sqlcommand7 As New MySqlCommand("UPDATE product SET prod_date = '" & TextBox1.Text & "' WHERE prod_id = 2", con)
                sqlcommand7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 2)", con)
                cmd.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 3)", con)
                cmd2.ExecuteNonQuery()

                Dim cmd3 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 9)", con)
                cmd3.ExecuteNonQuery()

                Dim cmd4 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 10)", con)
                cmd4.ExecuteNonQuery()

                Dim cmd5 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 11)", con)
                cmd5.ExecuteNonQuery()

                Dim cmd6 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 12)", con)
                cmd6.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                Dim cmd7 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES('" & TextBox1.Text & "', (SELECT SUM(item_cost_in_unit) FROM items WHERE item_id = 2 OR item_id = 3 OR item_id = 9 OR item_id = 10 OR item_id = 11 OR item_id = 17), 0, 1)", con)
                cmd7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 2 OR item_id = 3 OR item_id = 9 OR item_id = 10 OR item_id = 11 OR item_id = 17"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("6 new record added in product items due to the creation of WATER MELON JUICE")
                MsgBox("Expense added in Manager Monitoring")
                MsgBox("WATER MELON JUICE CREATED SUCCESFULLY")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If

      
        con.Close()

    End Sub

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

    Private Sub btnmelon_Click(sender As System.Object, e As System.EventArgs) Handles btnmelon.Click
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

                Dim palamig1 As String = InputBox("INPUT QUANTITY TO BE CREATED")

                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 2 ", con)
                sqlcommand.ExecuteNonQuery()

                Dim sqlcommand2 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 4 ", con)
                sqlcommand2.ExecuteNonQuery()

                Dim sqlcommand3 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 9 ", con)
                sqlcommand3.ExecuteNonQuery()

                Dim sqlcommand4 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 10 ", con)
                sqlcommand4.ExecuteNonQuery()

                Dim sqlcommand5 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 11 ", con)
                sqlcommand5.ExecuteNonQuery()

                Dim sqlcommand8 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 16 ", con)
                sqlcommand8.ExecuteNonQuery()

                Dim palamig2 As Integer
                palamig2 = 30 * palamig1
                Dim sqlcommand6 As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity + '" & palamig2 & "' WHERE prod_id = 3", con)
                sqlcommand6.ExecuteNonQuery()

                Dim sqlcommand7 As New MySqlCommand("UPDATE product SET prod_date = '" & TextBox1.Text & "' WHERE prod_id = 3", con)
                sqlcommand7.ExecuteNonQuery()

                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 2)", con)
                cmd.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 4)", con)
                cmd2.ExecuteNonQuery()

                Dim cmd3 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 9)", con)
                cmd3.ExecuteNonQuery()

                Dim cmd4 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 10)", con)
                cmd4.ExecuteNonQuery()

                Dim cmd5 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 11)", con)
                cmd5.ExecuteNonQuery()

                Dim cmd6 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 16)", con)
                cmd6.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                Dim cmd7 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES('" & TextBox1.Text & "', (SELECT SUM(item_cost_in_unit) FROM items WHERE item_id = 2 OR item_id = 4 OR item_id = 9 OR item_id = 10 OR item_id = 11 OR item_id = 16), 0, 1)", con)
                cmd7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------

                sql = "SELECT item_id, item_name FROM items WHERE item_id = 2 OR item_id = 4 OR item_id = 9 OR item_id = 10 OR item_id = 11 OR item_id = 16"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("6 new record added in product items due to the creation of WATER MELON JUICE")
                MsgBox("Expense added in Manager Monitoring")
                MsgBox(" MELON JUICE CREATED SUCCESFULLY")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub btnmango_Click(sender As System.Object, e As System.EventArgs) Handles btnmango.Click
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

                Dim palamig1 As String = InputBox("INPUT QUANTITY TO BE CREATED")

                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 2 ", con)
                sqlcommand.ExecuteNonQuery()

                Dim sqlcommand2 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 5 ", con)
                sqlcommand2.ExecuteNonQuery()

                Dim sqlcommand3 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 9 ", con)
                sqlcommand3.ExecuteNonQuery()

                Dim sqlcommand4 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 10 ", con)
                sqlcommand4.ExecuteNonQuery()

                Dim sqlcommand5 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 13 ", con)
                sqlcommand5.ExecuteNonQuery()

                Dim sqlcommand8 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 44 ", con)
                sqlcommand8.ExecuteNonQuery()

                Dim palamig2 As Integer
                palamig2 = 30 * palamig1
                Dim sqlcommand6 As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity + '" & palamig2 & "' WHERE prod_id = 4", con)
                sqlcommand6.ExecuteNonQuery()

                Dim sqlcommand7 As New MySqlCommand("UPDATE product SET prod_date = '" & TextBox1.Text & "' WHERE prod_id = 4", con)
                sqlcommand7.ExecuteNonQuery()

                '----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 2)", con)
                cmd.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 5)", con)
                cmd2.ExecuteNonQuery()

                Dim cmd3 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 9)", con)
                cmd3.ExecuteNonQuery()

                Dim cmd4 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 10)", con)
                cmd4.ExecuteNonQuery()

                Dim cmd5 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 13)", con)
                cmd5.ExecuteNonQuery()

                Dim cmd6 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 44)", con)
                cmd6.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                Dim cmd7 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES('" & TextBox1.Text & "', (SELECT SUM(item_cost_in_unit) FROM items WHERE item_id = 2 OR item_id = 5 OR item_id = 9 OR item_id = 10 OR item_id = 13 or item_id = 44), 0, 1)", con)
                cmd7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------

                sql = "SELECT item_id, item_name FROM items WHERE item_id = 2 OR item_id = 5 OR item_id = 9 OR item_id = 10 OR item_id = 13 or item_id = 44"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("6 new record added in product items due to the creation of WATER MELON JUICE")
                MsgBox("Expense added in Manager Monitoring")
                MsgBox(" MANGO JUICE CREATED SUCCESFULLY")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub btnlemon_Click(sender As System.Object, e As System.EventArgs) Handles btnlemon.Click
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

                Dim palamig1 As String = InputBox("INPUT QUANTITY TO BE CREATED")

                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 2 ", con)
                sqlcommand.ExecuteNonQuery()

                Dim sqlcommand2 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 6 ", con)
                sqlcommand2.ExecuteNonQuery()

                Dim sqlcommand3 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 9 ", con)
                sqlcommand3.ExecuteNonQuery()

                Dim sqlcommand4 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 10 ", con)
                sqlcommand4.ExecuteNonQuery()

                Dim palamig2 As Integer
                palamig2 = 30 * palamig1
                Dim sqlcommand6 As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity + '" & palamig2 & "' WHERE prod_id = 5", con)
                sqlcommand6.ExecuteNonQuery()

                Dim sqlcommand7 As New MySqlCommand("UPDATE product SET prod_date = '" & TextBox1.Text & "' WHERE prod_id = 5", con)
                sqlcommand7.ExecuteNonQuery()

                '----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 2)", con)
                cmd.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 6)", con)
                cmd2.ExecuteNonQuery()

                Dim cmd3 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 9)", con)
                cmd3.ExecuteNonQuery()

                Dim cmd4 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 10)", con)
                cmd4.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                Dim cmd7 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES('" & TextBox1.Text & "', (SELECT SUM(item_cost_in_unit) FROM items  WHERE item_id = 2 OR item_id = 6 OR item_id = 9 OR item_id = 10), 0, 1)", con)
                cmd7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------


                sql = "SELECT item_id, item_name FROM items WHERE item_id = 2 OR item_id = 6 OR item_id = 9 OR item_id = 10"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("4 new record added in product items due to the creation of WATER MELON JUICE")
                MsgBox("Expense added in Manager Monitoring")
                MsgBox(" LEMONADE CREATED SUCCESFULLY")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub btnbuko_Click(sender As System.Object, e As System.EventArgs) Handles btnbuko.Click
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

                Dim palamig1 As String = InputBox("INPUT QUANTITY TO BE CREATED")

                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 2 ", con)
                sqlcommand.ExecuteNonQuery()

                Dim sqlcommand2 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 7 ", con)
                sqlcommand2.ExecuteNonQuery()

                Dim sqlcommand3 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 9 ", con)
                sqlcommand3.ExecuteNonQuery()

                Dim sqlcommand4 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 10 ", con)
                sqlcommand4.ExecuteNonQuery()

                Dim sqlcommand5 As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & palamig1 & "' WHERE item_id = 14 ", con)
                sqlcommand5.ExecuteNonQuery()

                Dim palamig2 As Integer
                palamig2 = 30 * palamig1
                Dim sqlcommand6 As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity + '" & palamig2 & "' WHERE prod_id = 6", con)
                sqlcommand6.ExecuteNonQuery()

                Dim sqlcommand7 As New MySqlCommand("UPDATE product SET prod_date = '" & TextBox1.Text & "' WHERE prod_id = 6", con)
                sqlcommand7.ExecuteNonQuery()

                '----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 2)", con)
                cmd.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 7)", con)
                cmd2.ExecuteNonQuery()

                Dim cmd3 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 9)", con)
                cmd3.ExecuteNonQuery()

                Dim cmd4 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 10)", con)
                cmd4.ExecuteNonQuery()

                Dim cmd5 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 14)", con)
                cmd5.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                Dim cmd7 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES('" & TextBox1.Text & "', (SELECT SUM(item_cost_in_unit) FROM items  WHERE item_id = 2 OR item_id = 7 OR item_id = 9 OR item_id = 10 OR item_id = 14), 0, 1)", con)
                cmd7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------

                sql = "SELECT item_id, item_name FROM items WHERE item_id = 2 OR item_id = 7 OR item_id = 9 OR item_id = 10 OR item_id = 14 "
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("5 new record added in product items due to the creation of WATER MELON JUICE")
                MsgBox("Expense added in Manager Monitoring")
                MsgBox(" BUKO JUICE CREATED SUCCESFULLY")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

End Class