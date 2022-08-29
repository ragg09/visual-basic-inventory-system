Imports MySql.Data.MySqlClient
Public Class display_all

    Private Sub display_all_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM items ORDER BY item_quantity ASC"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "items")
        DataGridView1.DataSource = ds.Tables("items")
    End Sub
End Class