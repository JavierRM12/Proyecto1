Imports System.Data.SqlClient
Public Class Form4
    Dim conn As New SqlConnection("Server=localhost\SQLEXPRESS;Database=BD_201700322_201700710;Trusted_Connection=True;")
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()

    End Sub
    Private Sub MostrarDatos()
        Try
            Dim command As New SqlCommand("SELECT * FROM EDITORIAL", conn)
            Dim dataAdapter As New SqlDataAdapter(command)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "EDITORIAL")
            DataGridView1.DataSource = dataSet.Tables("EDITORIAL")

        Catch ex As Exception



        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim command As New SqlCommand("INSERT INTO EDITORIAL VALUES(@NOMBRE,@DIRECCION,@TELEFONO)", conn)
            command.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = ENOMBRE.Text
            command.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = EDIRECCION.Text
            command.Parameters.Add("@TELEFONO", SqlDbType.Int).Value = Convert.ToInt32(ETELEFONO.Text)
            conn.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Se registro correctamente")
            Else
                MessageBox.Show("no se logro ")
            End If
            conn.Close()
            MostrarDatos()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim commnad As New SqlCommand("UPDATE EDITORIAL SET NOMBRE=@NOMBRE, DIRECCION=@DIRECCION, TELEFONO=@TELEFONO WHERE ID_EDITORIAL=@ID_EDITORIAL", conn)
            commnad.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = ENOMBRE.Text
            commnad.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = EDIRECCION.Text
            commnad.Parameters.Add("@TELEFONO", SqlDbType.Int).Value = Convert.ToInt32(ETELEFONO.Text)
            commnad.Parameters.Add("@ID_EDITORIAL", SqlDbType.Int).Value = Convert.ToInt32(txtid.Text)
            conn.Open()
            If commnad.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Se modifico correctamente el usuario")
            Else
                MessageBox.Show("No se logro modificar ")
            End If
            conn.Close()
            MostrarDatos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim command As New SqlCommand("DELETE FROM EDITORIAL WHERE ID_EDITORIAL=@ID_EDITORIAL", conn)
        command.Parameters.Add("@ID_EDITORIAL", SqlDbType.Int).Value = Convert.ToInt32(txtid.Text)
            conn.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Se elimino el registro")
            Else
                MessageBox.Show("No se logro eliminar el registro ")
            End If
            conn.Close()
            MostrarDatos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ENOMBRE.Text = ""
        EDIRECCION.Text = ""
        ETELEFONO.Text = ""
        txtid.Text = ""


    End Sub
End Class