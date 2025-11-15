Public Class Mich
    Private Sub Mich_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "El equipo se registró correctamente en la base de datos" & Environment.NewLine &
                   "Ahora puede verificar el registro desde la plataforma o consola"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
