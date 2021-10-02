Imports System.Data.SqlClient


Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conn As New SqlConnection("Server=localhost\SQLEXPRESS;Database=BD_201700322_201700710;Trusted_Connection=True;")
        conn.Open()
        MessageBox.Show("La conexion fue exitosa")






    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form7.Show()
        Me.Hide()

    End Sub
End Class
