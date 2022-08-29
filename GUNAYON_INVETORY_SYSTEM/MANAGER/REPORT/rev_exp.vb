Imports MySql.Data.MySqlClient
Public Class rev_exp

    Private Sub OKAY_Click(sender As System.Object, e As System.EventArgs) Handles OKAY.Click
        ds.Reset()
        If txtmonth.Text = "JAN" Then
            lblmonth.Text = "JANUARY"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 1"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "FEB" Then
            lblmonth.Text = "FEBRUARY"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 2 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "MAR" Then
            lblmonth.Text = "MARCH"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 3 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "APR" Then
            lblmonth.Text = "APRIL"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 4 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "MAY" Then
            lblmonth.Text = "MAY"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 5 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "JUN" Then
            lblmonth.Text = "JUNE"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 6 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "JUL" Then
            lblmonth.Text = "JUL"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 7 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "AUG" Then
            lblmonth.Text = "AUGUST"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 8 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "SEP" Then
            lblmonth.Text = "SEPTEMBER"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 9 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "OCT" Then
            lblmonth.Text = "OCTOBER"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 10"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "NOV" Then
            lblmonth.Text = "NOVEMBER"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 11 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()


        ElseIf txtmonth.Text = "DEC" Then
            lblmonth.Text = "DECEMBER"

            ds.Reset()
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            sql = " SELECT SUM(total_revenue) AS 'TOTAL REVENUE', SUM(total_expense) AS 'TOTAL EXPENSE' FROM manager_monitoring WHERE (SELECT EXTRACT(MONTH FROM show_date)) = 12 "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "manager_monitoring")
            dgvrevenue.DataSource = ds.Tables("manager_monitoring")

            con.Close()
        End If
    End Sub

    Private Sub rev_exp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM manager_monitoring"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "manager_monitoring")
        DataGridView1.DataSource = ds.Tables("manager_monitoring")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ds.Reset()
        If ConnectionState.Open Then
            con.Close()
        End If

        open()
        sql = "SELECT * FROM manager_monitoring"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "manager_monitoring")
        DataGridView1.DataSource = ds.Tables("manager_monitoring")
    End Sub
End Class