Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse
           String.IsNullOrWhiteSpace(txtContrasena.Text) Then
            MessageBox.Show("Por favor ingresa usuario y contraseña.", "Datos requeridos",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dt As DataTable = ValidarLogin(txtUsuario.Text, txtContrasena.Text)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ' Guardamos los datos (solo variables públicas)
            IdUsuarioLogueado = CInt(dt.Rows(0)("Id"))
            NombreUsuarioLogueado = dt.Rows(0)("NombreUsuario").ToString()
            CorreoUsuarioLogueado = If(dt.Rows(0)("Correo") IsNot DBNull.Value,
                                       dt.Rows(0)("Correo").ToString(), "")

            MessageBox.Show($"¡Bienvenido {NombreUsuarioLogueado}!", "Acceso concedido",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            If dt IsNot Nothing Then
                DataGridView1.DataSource = dt
            End If
        Else
            MessageBox.Show("Usuario o contraseña incorrectos.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContrasena.Clear()
            txtContrasena.Focus()
        End If
    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then btnIngresar.PerformClick()
    End Sub

    Private Sub btnRegrear_Click(sender As Object, e As EventArgs) Handles btnRegrear.Click
        Me.Close()
    End Sub
End Class