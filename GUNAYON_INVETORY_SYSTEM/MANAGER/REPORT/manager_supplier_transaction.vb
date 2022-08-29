Imports MySql.Data.MySqlClient
Public Class manager_supplier_transaction

    Private Sub manager_supplier_transaction_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM manager_supplier"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "manager_supplier")
        DataGridView1.DataSource = ds.Tables("manager_supplier")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM manager_supplier"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "manager_supplier")
        DataGridView1.DataSource = ds.Tables("manager_supplier")
    End Sub
End Class