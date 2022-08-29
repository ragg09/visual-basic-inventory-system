Imports MySql.Data.MySqlClient
Public Class other_transactions

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM sk_items"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "sk_items")
        DataGridView1.DataSource = ds.Tables("sk_items")
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM product_items"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "product_items")
        DataGridView1.DataSource = ds.Tables("product_items")
        con.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM sk_product"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "sk_product")
        DataGridView1.DataSource = ds.Tables("sk_product")
        con.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM item_supplier"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "item_supplier")
        DataGridView1.DataSource = ds.Tables("item_supplier")
        con.Close()
    End Sub

    Private Sub other_transactions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class