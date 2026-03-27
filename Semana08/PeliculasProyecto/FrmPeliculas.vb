Public Class FrmPeliculas

    ' Variable que guarda el código de la película seleccionada en el grid.
    ' Vale 0 cuando estamos en modo "Nueva película"
    Public _codigoPeliculaSeleccionada As Integer = 0
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim frm As New administrador()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub FrmPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ModPeliculasDAL.CargarGeneros(cmbGenero)
            ModPeliculasDAL.CargarDirectores(cmbDirector)
            ModPeliculasDAL.CargarPeliculas(dgvPeliculas)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ModPeliculasUI.ValidarCampos(txtNombre, cmbGenero, cmbDirector) Then Return

        Dim codGenero As Integer = ModPeliculasDAL.ObtenerCodigoCombo(cmbGenero)
        Dim codDirector As Integer = ModPeliculasDAL.ObtenerCodigoCombo(cmbDirector)

        If codGenero = -1 OrElse codDirector = -1 Then
            ModPeliculasUI.MostrarError(Me, "Selecciona un género y un director válidos.")
            Return
        End If

        Try
            ' .Trim() elimina espacios al inicio y final del nombre
            ' Razón: Evita guardar nombres como "   Batman   " que pueden causar problemas de búsqueda o duplicados visuales
            ModPeliculasDAL.InsertarPelicula(txtNombre.Text.Trim(), CInt(nudMinutos.Value), codGenero, codDirector)

            ModPeliculasUI.MostrarExito(Me, "Película guardada correctamente.")
            ModPeliculasDAL.CargarPeliculas(dgvPeliculas)
            ModPeliculasUI.LimpiarCampos(Me)
        Catch ex As Exception
            ModPeliculasUI.MostrarError(Me, "Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ModPeliculasUI.LimpiarCampos(Me)
    End Sub
End Class