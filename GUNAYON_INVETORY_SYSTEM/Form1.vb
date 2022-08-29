Imports System.Data.OleDb
Public Class Form1
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_manager.Click
        login_manager.Show()
        Me.Hide()
    End Sub

    Private Sub btn_storekeeper_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_storekeeper.Click
        login_storekeeper.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class
