Imports MySql.Data.MySqlClient
Public Class transaction_between_customer

    Private Sub transaction_between_customer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM prod_cus"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "prod_cus")
        DataGridView1.DataSource = ds.Tables("prod_cus")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM prod_cus"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "prod_cus")
        DataGridView1.DataSource = ds.Tables("prod_cus")
    End Sub
End Class