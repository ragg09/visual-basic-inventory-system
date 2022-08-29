Imports MySql.Data.MySqlClient
'Imports System.Data.OleDb
Module Module1
    Public con As New MySqlConnection
    'Public con As New OleDbConnection
    'Public path As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\GUNAYON_INVETORY_SYSTEM\inventory.accdb"
    Public path As String = "datasource=localhost;port=3306;database=final_inventory_system;username=root;password=;Convert Zero Datetime=True"
    Public sql As String
    Public da As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable
    Public dr As MySqlDataReader
    Public trans As MySqlTransaction

    Public Function open()
        con.ConnectionString = path
        con.Open()
    End Function

    Public Function Took(ByVal Sql As String, ByVal tabletitle As String, ByVal con As MySqlConnection, ByVal da2 As MySqlDataAdapter) As DataSet

        da = New MySqlDataAdapter(Sql, con)
        da.Fill(ds, tabletitle)

        Return ds
    End Function

End Module
