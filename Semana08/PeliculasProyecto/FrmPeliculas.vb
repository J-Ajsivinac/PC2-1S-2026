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
            ModPeliculasUI.ModoNuevo(Me)
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

    Private Sub dgvPeliculas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeliculas.CellClick
        ' Ignoramos clics en el encabezado (índice -1)
        If e.RowIndex < 0 Then Return

        Dim fila As DataGridViewRow = dgvPeliculas.Rows(e.RowIndex)

        ' Guardamos el código de la película seleccionada
        _codigoPeliculaSeleccionada = Convert.ToInt32(fila.Cells("codigo_pelicula").Value)

        ' Llenamos los campos con los datos de la fila
        txtNombre.Text = fila.Cells("Película").Value.ToString()

        If Not IsDBNull(fila.Cells("Minutos").Value) Then
            nudMinutos.Value = Convert.ToDecimal(fila.Cells("Minutos").Value)
        End If

        ' Buscamos y seleccionamos el género correspondiente en el combo
        SeleccionarEnCombo(cmbGenero, fila.Cells("Género").Value.ToString())
        SeleccionarEnCombo(cmbDirector, fila.Cells("Director").Value.ToString())

        ' Activamos botones de editar y eliminar
        ModPeliculasUI.ModoEdicion(Me)
        lblMensaje.Text = ""
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If _codigoPeliculaSeleccionada = 0 Then
            ModPeliculasUI.MostrarError(Me, "Selecciona una película primero.")
            Return
        End If

        If Not ModPeliculasUI.ValidarCampos(txtNombre, cmbGenero, cmbDirector) Then Return

        Dim codGenero As Integer = ModPeliculasDAL.ObtenerCodigoCombo(cmbGenero)
        Dim codDirector As Integer = ModPeliculasDAL.ObtenerCodigoCombo(cmbDirector)

        If codGenero = -1 OrElse codDirector = -1 Then
            ModPeliculasUI.MostrarError(Me, "Selecciona un género y un director válidos.")
            Return
        End If

        Try
            ModPeliculasDAL.ActualizarPelicula(_codigoPeliculaSeleccionada, txtNombre.Text.Trim(), CInt(nudMinutos.Value), codGenero, codDirector)
            ModPeliculasUI.MostrarExito(Me, "Película actualizada correctamente.")
            ModPeliculasDAL.CargarPeliculas(dgvPeliculas)
            ModPeliculasUI.LimpiarCampos(Me)
        Catch ex As Exception
            ModPeliculasUI.MostrarError(Me, "Error al editar: " & ex.Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _codigoPeliculaSeleccionada = 0 Then
            ModPeliculasUI.MostrarError(Me, "Selecciona una película primero.")
            Return
        End If

        If MessageBox.Show("¿Estás seguro de eliminar esta película?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Return
        End If

        Try
            ModPeliculasDAL.EliminarPelicula(_codigoPeliculaSeleccionada)
            ModPeliculasUI.MostrarExito(Me, "Película eliminada correctamente.")
            ModPeliculasDAL.CargarPeliculas(dgvPeliculas)
            ModPeliculasUI.LimpiarCampos(Me)
        Catch ex As Exception
            ModPeliculasUI.MostrarError(Me, "Error al eliminar: " & ex.Message)
        End Try
    End Sub
End Class