Public Class cliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New FrmUsuario
        frm.Show()
        Me.Hide()
    End Sub

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

    Private Sub btnCalificar_Click(sender As Object, e As EventArgs) Handles btnCalificar.Click
        Dim frm As New FrmCalificaciones
        frm.Show()
        Me.Hide()
    End Sub
End Class