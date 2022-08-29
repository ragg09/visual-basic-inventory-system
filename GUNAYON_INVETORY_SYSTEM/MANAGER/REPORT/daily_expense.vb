Imports MySql.Data.MySqlClient
Public Class daily_expense
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

        sql = "SELECT item_id, item_cost_in_unit FROM items"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "items")
        DataGridView2.DataSource = ds.Tables("items")

        sql = "SELECT * FROM manager_supplier"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "manager_supplier")
        DataGridView3.DataSource = ds.Tables("manager_supplier")

        con.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dateissued = DateTimePicker1.Value 'Format(DateTimePicker1.Value, "MM/dd/yyyy")
        txtdate_selected.Text = Format(dateissued, "yyyy-MM-dd")
    End Sub

   
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If
        Dim Total As String = "Total"
        open()
        sql = "SELECT SUM(total_expense) AS '" & Total & "' FROM manager_monitoring WHERE show_date = '" & txtdate_selected.Text & "'"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "manager_monitoring")
        dgvrevenue.DataSource = ds.Tables("manager_monitoring")


        con.Close()

        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM product_items"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "product_items")
        DataGridView1.DataSource = ds.Tables("product_items")

        sql = "SELECT mm_id, total_expense FROM manager_monitoring WHERE show_date = '" & txtdate_selected.Text & "'"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "items")
        DataGridView2.DataSource = ds.Tables("items")

        sql = "SELECT * FROM manager_supplier WHERE purchase_date = '" & txtdate_selected.Text & "' "
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "manager_supplier")
        DataGridView3.DataSource = ds.Tables("manager_supplier")

        con.Close()
    End Sub

    Private Sub daily_expense_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class