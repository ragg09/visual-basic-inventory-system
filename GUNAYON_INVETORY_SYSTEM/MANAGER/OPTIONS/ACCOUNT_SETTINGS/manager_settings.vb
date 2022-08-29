Imports MySql.Data.MySqlClient
Public Class manager_settings


    Private Sub manager_settings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ds.Clear()
        If ConnectionState.Open Then
            con.Close()
        End If


        open()
        sql = "SELECT * FROM manager_login"
        Took(sql, "manager_login", con, da)

        For i = 0 To ds.Tables("manager_login").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("manager_login").Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ds.Clear()

        Try
            open()

            sql = "SELECT * FROM manager_login WHERE man_id= " & CInt(ComboBox1.SelectedItem) & ""
            Took(sql, "manager_login", con, da)


            txtusername.Text = (ds.Tables("manager_login").Rows(0).Item(1))
            txtpassword.Text = (ds.Tables("manager_login").Rows(0).Item(2))

            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_Click(sender As System.Object, e As System.EventArgs) Handles btnupdate.Click
        ds.Clear()
        If txtnewpass.Text = txtnewpasss.Text Then
            If ConnectionState.Open Then
                con.Close()
            End If

            open()

            Dim sqlcommand As New MySqlCommand("UPDATE manager_login SET password = '" & txtnewpasss.Text & "' WHERE man_id = '" & CInt(ComboBox1.Text) & "' ", con)
            sqlcommand.ExecuteNonQuery()

            MsgBox("Password Changed")
            con.Close()

            txtnewpass.Clear()
            txtnewpasss.Clear()
        Else
            MsgBox("Password Dont Match")
            txtnewpass.Clear()
            txtnewpasss.Clear()
        End If
    End Sub
End Class