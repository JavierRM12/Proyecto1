Imports System.Data.SqlClient




Public Class Form2

    Dim conn As New SqlConnection("Server=localhost\SQLEXPRESS;Database=BD_201700322_201700710;Trusted_Connection=True;")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim command As New SqlCommand("INSERT INTO USUARIO VALUES(@NOMBRE,@APELLIDO,@USUARIO,@TIPO_USR,@NACIMIENTO,@CONTRASEÑA)", conn)
            command.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = TxtN.Text
            command.Parameters.Add("@APELLIDO", SqlDbType.VarChar).Value = TxtA.Text
            command.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = TxtU.Text
            command.Parameters.Add("@TIPO_USR", SqlDbType.VarChar).Value = TxtUT.Text
            command.Parameters.Add("@NACIMIENTO", SqlDbType.Date).Value = Convert.ToDateTime(TxtF.Text)
            command.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = TxtC.Text
            conn.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Se registro correctamente")
            Else
                MessageBox.Show("No se logro el registro ")
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class