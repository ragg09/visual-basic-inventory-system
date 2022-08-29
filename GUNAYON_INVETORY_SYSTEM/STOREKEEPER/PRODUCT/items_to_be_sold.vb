Imports MySql.Data.MySqlClient
Public Class items_to_be_sold

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

                Dim siomai As String = InputBox("HOW MANY PACK TO BE PREPARED?")

                Dim sqlcommand As New MySqlCommand("UPDATE items SET item_quantity = item_quantity - '" & siomai & "' WHERE item_id = 1 ", con)
                sqlcommand.ExecuteNonQuery()

              
                Dim siomai2 As Integer
                siomai2 = 48 * siomai
                Dim sqlcommand6 As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity + '" & siomai2 & "' WHERE prod_id = 1", con)
                sqlcommand6.ExecuteNonQuery()

                Dim sqlcommand7 As New MySqlCommand("UPDATE product SET prod_date = '" & TextBox1.Text & "' WHERE prod_id = 1", con)
                sqlcommand7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(1, 1)", con)
                cmd.ExecuteNonQuery()

                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                Dim cmd7 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES('" & TextBox1.Text & "', (SELECT SUM(item_cost_in_unit) FROM items WHERE item_id = 1), 0, 1)", con)
                cmd7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 1"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("1 new record added in product items due to the preparation of SIOMAI")
                MsgBox("Expense added in Manager Monitoring")
                MsgBox("48 SIOMAIs READY TO SELL")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub btnpiatoss_Click(sender As System.Object, e As System.EventArgs) Handles btnpiatoss.Click
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



                Dim sqlcommand7 As New MySqlCommand(" UPDATE product SET prod_quantity = (SELECT item_quantity FROM items WHERE item_id = 37), prod_date = ' " & TextBox1.Text & " ' WHERE prod_id = 10", con)
                sqlcommand7.ExecuteNonQuery()

                Dim sqlcommand8 As New MySqlCommand(" UPDATE product SET prod_quantity = (SELECT item_quantity FROM items WHERE item_id = 38), prod_date =  ' " & TextBox1.Text & " ' WHERE prod_id = 11", con)
                sqlcommand8.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(10, 37)", con)
                cmd.ExecuteNonQuery()
                Dim cmd1 As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(11, 38)", con)
                cmd1.ExecuteNonQuery()

                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 37 OR item_id = 38"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("PIATOSS HAS PREPARED")
                MsgBox("PIATOSS READY TO SELL")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub btnnova_Click(sender As System.Object, e As System.EventArgs) Handles btnnova.Click
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



                Dim sqlcommand7 As New MySqlCommand(" UPDATE product SET prod_quantity = (SELECT item_quantity FROM items WHERE item_id = 39), prod_date = ' " & TextBox1.Text & " ' WHERE prod_id = 12", con)
                sqlcommand7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(12, 39)", con)
                cmd.ExecuteNonQuery()

                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 39"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("NOVA HAS PREPARED")
                MsgBox("NOVA READY TO SELL")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub btnclover_Click(sender As System.Object, e As System.EventArgs) Handles btnclover.Click
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



                Dim sqlcommand7 As New MySqlCommand(" UPDATE product SET prod_quantity = (SELECT item_quantity FROM items WHERE item_id = 40), prod_date = ' " & TextBox1.Text & " ' WHERE prod_id = 13", con)
                sqlcommand7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(13, 40)", con)
                cmd.ExecuteNonQuery()

                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 40"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("CLOVER CHIPS HAS PREPARED")
                MsgBox("CLOVER CHIPS READY TO SELL")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub btnec_Click(sender As System.Object, e As System.EventArgs) Handles btnec.Click
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



                Dim sqlcommand7 As New MySqlCommand(" UPDATE product SET prod_quantity = (SELECT item_quantity FROM items WHERE item_id = 41), prod_date = ' " & TextBox1.Text & " ' WHERE prod_id = 14", con)
                sqlcommand7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(14, 41)", con)
                cmd.ExecuteNonQuery()

                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 41"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("EC CHOCO HAS PREPARED")
                MsgBox("EC CHOCO CHIPS READY TO SELL")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub btntoge_Click(sender As System.Object, e As System.EventArgs) Handles btntoge.Click
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



                Dim sqlcommand7 As New MySqlCommand(" UPDATE product SET prod_quantity = (SELECT item_quantity FROM items WHERE item_id = 42), prod_date = ' " & TextBox1.Text & " ' WHERE prod_id = 15", con)
                sqlcommand7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(15, 42)", con)
                cmd.ExecuteNonQuery()

                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 42"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("LUMPIANG TOGE HAS PREPARED")
                MsgBox("LUMPIANG TOGE READY TO SELL")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub btnshanghai_Click(sender As System.Object, e As System.EventArgs) Handles btnshanghai.Click
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



                Dim sqlcommand7 As New MySqlCommand(" UPDATE product SET prod_quantity = (SELECT item_quantity FROM items WHERE item_id = 43), prod_date = ' " & TextBox1.Text & " ' WHERE prod_id = 16", con)
                sqlcommand7.ExecuteNonQuery()
                '-----------------------------------------------------------------------------------------------------------------------------------------
                'produc_items
                Dim cmd As New MySqlCommand("INSERT INTO product_items(prod_id, item_id) VALUES(16, 43)", con)
                cmd.ExecuteNonQuery()

                '-----------------------------------------------------------------------------------------------------------------------------------------
                'expense
                '-----------------------------------------------------------------------------------------------------------------------------------------
                sql = "SELECT item_id, item_name FROM items WHERE item_id = 43"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "items")
                DataGridView1.DataSource = ds.Tables("items")

                trans.Commit()

                MsgBox("LUMPIANG SHANGHAI HAS PREPARED")
                MsgBox("LUMPIANG SHANGHAI READY TO SELL")

            Catch ex As Exception
                trans.Rollback()
                MsgBox("SOMETHING WENT WRONG")
            End Try
        End If


        con.Close()
    End Sub

    Private Sub items_to_be_sold_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class