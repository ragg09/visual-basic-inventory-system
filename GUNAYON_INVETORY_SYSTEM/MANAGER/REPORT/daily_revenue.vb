Imports MySql.Data.MySqlClient
Public Class daily_revenue

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM customer"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "customer")
        DataGridView1.DataSource = ds.Tables("customer")

        sql = "SELECT * FROM prod_cus"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "prod_cus")
        DataGridView2.DataSource = ds.Tables("prod_cus")

        sql = "SELECT * FROM product"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "product")
        DataGridView5.DataSource = ds.Tables("product")

        con.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dateissued = DateTimePicker1.Value 'Format(DateTimePicker1.Value, "MM/dd/yyyy")
        txtdate_selected.Text = Format(dateissued, "yyyy-MM-dd")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtdate_selected.Text = "" Then
            MsgBox("No Date Inputted")
        Else
            Try
                ds.Reset()
                If ConnectionState.Open Then
                    con.Close()
                End If
                Dim Total As String = "Total"
                open()
                sql = "SELECT SUM(total_revenue) AS '" & Total & "' FROM manager_monitoring WHERE show_date = '" & txtdate_selected.Text & "'"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "manager_monitoring")
                dgvrevenue.DataSource = ds.Tables("manager_monitoring")

               
                sql = "SELECT * FROM customer WHERE cus_date = '" & txtdate_selected.Text & "'"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "customer")
                DataGridView1.DataSource = ds.Tables("customer")

                sql = "SELECT mm_id, total_revenue FROM manager_monitoring WHERE show_date = '" & txtdate_selected.Text & "'"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "manager_monitoring")
                DataGridView2.DataSource = ds.Tables("manager_monitoring")

                sql = "SELECT * FROM product"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(ds, "product")
                DataGridView5.DataSource = ds.Tables("product")



            Catch ex As Exception
                MsgBox("Invalid Input")
            End Try

            con.Close()
        End If

    End Sub

    Private Sub daily_revenue_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class