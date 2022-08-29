Imports MySql.Data.MySqlClient
Public Class order_station

    Private Sub order_station_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'this part allows the gunayon to reset the quantity of products they sell
        'the product reset to zero becuase they dont close the store unless the maain products(palamig, pancake etc.) are sold out
        If con.State = ConnectionState.Closed Then
            open()
        End If

        Dim cmd As New MySqlCommand("SELECT COUNT(prod_date) FROM product WHERE prod_date = CURDATE()", con)
        Dim count = Convert.ToInt32(cmd.ExecuteScalar)

        'display 
        If (count > 0) Then
            ds.Reset()

            If con.State = ConnectionState.Closed Then
                open()
            End If

            sql = "SELECT prod_id, prod_name, prod_quantity, prod_selling_cost FROM product"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "product")
            DataGridView1.DataSource = ds.Tables("product")


            sql = "SELECT prod_id FROM product"
            Took(sql, "product", con, da)

            For i = 0 To ds.Tables("product").Rows.Count - 1
                txtid.Items.Add(ds.Tables("product").Rows(i).Item(0))
            Next


        Else
            'reset
            MsgBox("NEW DAY, NEW PRODUCT! CREATE PRODUCT FIRST")
            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            Dim sqlcommand As New MySqlCommand("UPDATE product SET prod_quantity = 0, prod_date = '0000-00-00'", con)
            sqlcommand.ExecuteNonQuery()
            con.Close()
        End If
        ds.Reset()
        sql = "SELECT prod_id, prod_name, prod_quantity FROM product"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "product")
        DataGridView1.DataSource = ds.Tables("product")


        con.Close()


        curdate.Text = Format(Date.Now(), "yyyy-MM-dd")
    End Sub

    Private Sub btnreload_Click(sender As System.Object, e As System.EventArgs) Handles btnreload.Click
        ds.Reset()

        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT prod_id, prod_name, prod_quantity FROM product"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "product")
        DataGridView1.DataSource = ds.Tables("product")

        con.Close()
    End Sub

    Private Sub txtid_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtid.SelectedIndexChanged
        ds.Clear()

        Try
            open()

            sql = "SELECT prod_id, prod_name, prod_quantity, prod_date, prod_selling_cost FROM product WHERE prod_id= " & CInt(txtid.SelectedItem) & ""
            Took(sql, "product", con, da)

            txtname.Text = (ds.Tables("product").Rows(0).Item(1))
            txtdate.Text = (ds.Tables("product").Rows(0).Item(3))
            txtcost.Text = (ds.Tables("product").Rows(0).Item(4))
        Catch ex As Exception

        End Try

        con.Close()
    End Sub

    Private Sub btnplaceorder_Click(sender As System.Object, e As System.EventArgs) Handles btnplaceorder.Click
        Try
            If txtquantity.Text = "" Then
                MsgBox("PLEASE PUT QUANTITY TO BUY")
            Else
                DataGridView2.Rows.Clear()

                DataGridView2.Rows.Add(txtquantity.Text, txtdate.Text, txtname.Text, Val(txtquantity.Text) * Val(txtcost.text))

                ds.Reset()
                If ConnectionState.Open Then
                    con.Close()
                End If

                open()

                Dim sqlcommand As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity  - '" & txtquantity.Text & "' WHERE prod_id =  ' " & txtid.Text & " '", con)
                sqlcommand.ExecuteNonQuery()
                con.Close()

                txtid.Enabled = False
                txtquantity.Enabled = False
                btnplaceorder.Enabled = False

            End If

        Catch ex As Exception
            MsgBox("SOMETHING WENT WRONG")
        End Try


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()

        Dim sqlcommand As New MySqlCommand("UPDATE product SET prod_quantity = prod_quantity  + '" & txtquantity.Text & "' WHERE prod_id =  ' " & txtid.Text & " '", con)
        sqlcommand.ExecuteNonQuery()

        MsgBox("ORDER CANCELLED")
        con.Close()

        txtid.Text = ""
        txtname.Clear()
        txtdate.Clear()
        txtquantity.Clear()
        txtcost.Text = ""

        DataGridView2.Rows.Clear()

        txtid.Enabled = True
        txtquantity.Enabled = True
        btnplaceorder.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()

        Dim cmd As New MySqlCommand("INSERT INTO customer(cus_amount_paid, cus_date, cus_item_description) VALUES('" & Val(txtcost.Text) & "' *  ' " & Val(txtquantity.Text) & " ', ' " & curdate.Text & " ', ' " & txtname.Text & " ')", con)
        cmd.ExecuteNonQuery()
        con.Close()

        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        Dim amount_paid = Val(txtquantity.Text) * Val(txtcost.Text)
        Dim cmd1 As New MySqlCommand("INSERT INTO prod_cus(prod_id, cus_id, prod_name, prod_quantity, cus_amount_paid, date_purchased) VALUES(' " & txtid.Text & " ', (SELECT cus_id FROM customer ORDER BY cus_id DESC LIMIT 1), '" & txtname.Text & "', ' " & CInt(txtquantity.Text) & " ', ' " & amount_paid & "', ' " & curdate.Text & "'  )", con)
        cmd1.ExecuteNonQuery()
        con.Close()

        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        Dim cmd2 As New MySqlCommand("INSERT INTO manager_monitoring(show_date, total_expense, total_revenue, man_id) VALUES(' " & txtdate.Text & " ', 0, '" & Val(txtcost.Text) & "' *  ' " & Val(txtquantity.Text) & " ', 1 )", con)
        cmd2.ExecuteNonQuery()
        MsgBox("ORDERED SUCCESFULLY")
        con.Close()

        DataGridView2.Rows.Clear()

        txtid.Enabled = True
        txtquantity.Enabled = True
        btnplaceorder.Enabled = True
    End Sub

    Private Sub curdate_TextChanged(sender As System.Object, e As System.EventArgs) Handles curdate.TextChanged

    End Sub
End Class