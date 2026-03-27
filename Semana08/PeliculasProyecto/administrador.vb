Public Class administrador
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim confirmacion As DialogResult
        confirmacion = MessageBox.Show(
            "¿Estás seguro que deseas cerrar sesión?",
            "Cerrar Sesión",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirmacion = DialogResult.Yes Then
            ' Limpiamos los datos de sesión
            Sesion.CerrarSesion()

            ' Mostramos el login de nuevo
            Form1.Show()

            ' Cerramos el formulario actual
            Me.Close()
        End If
    End Sub

    Private Sub administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = Sesion.NombreCliente
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New FrmPeliculas()
        frm.Show()
        Me.Hide()
    End Sub
End Class