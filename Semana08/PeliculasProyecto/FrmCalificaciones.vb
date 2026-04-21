Imports Microsoft.Data.SqlClient

Public Class FrmCalificaciones
    Private Sub FrmCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPeliculas()
    End Sub

    Private Sub CargarPeliculas()
        Try
            Using conexion As New SqlConnection(ModConexion.ObtenerCadenaConexion())
                Dim consulta As String =
                    "SELECT codigo_pelicula, nombre FROM pelicula ORDER BY nombre"

                Using comando As New SqlCommand(consulta, conexion)
                    conexion.Open()

                    Using reader As SqlDataReader = comando.ExecuteReader()
                        cmbPelicula.Items.Clear()
                        cmbPelicula.Items.Add("-- Selecciona una película --")

                        Dim codigos() As Integer = {}
                        While reader.Read()
                            cmbPelicula.Items.Add(reader("nombre").ToString())
                            ReDim Preserve codigos(codigos.Length)
                            codigos(codigos.Length - 1) = Convert.ToInt32(reader("codigo_pelicula"))
                        End While

                        cmbPelicula.Tag = codigos
                        cmbPelicula.SelectedIndex = 0
                    End Using
                End Using

            End Using
        Catch ex As Exception
            MostrarError("Error al cargar películas: " & ex.Message)
        End Try
    End Sub



    Private Function ObtenerCodigoCombo(combo As ComboBox) As Integer
        If combo.SelectedIndex <= 0 Then Return -1
        Dim codigos() As Integer = CType(combo.Tag, Integer())
        Return codigos(combo.SelectedIndex - 1)
    End Function

    Private Sub MostrarError(mensaje As String)
        lblMensaje.ForeColor = Color.Red
        lblMensaje.Text = "[Error] " & mensaje
    End Sub

    Private Sub MostrarExito(mensaje As String)
        lblMensaje.ForeColor = Color.Green
        lblMensaje.Text = "[OK] " & mensaje
    End Sub

    ' =========================================================
    ' SECCIÓN 3 — AL CAMBIAR PELÍCULA EN EL COMBO
    ' Carga los comentarios y el promedio de esa película
    ' =========================================================
    Private Sub cmbPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelicula.SelectedIndexChanged
        If cmbPelicula.SelectedIndex <= 0 Then
            dgvComentarios.DataSource = Nothing
            lblPromedio.Text = ""
            Return
        End If

        Dim codigoPelicula As Integer = ObtenerCodigoCombo(cmbPelicula)
        CargarComentarios(codigoPelicula)
        CargarPromedio(codigoPelicula)
        VerificarReseñaExistente(codigoPelicula)
    End Sub

    Private Sub CargarComentarios(codigoPelicula As Integer)
        Try
            Using conexion As New SqlConnection(ModConexion.ObtenerCadenaConexion())
                Dim consulta As String =
               "SELECT C.Nombre       AS Usuario, " &
               "       F.Calificacion, " &
               "       F.Comentario, " &
               "       F.Favorito " &
               "FROM   FAVORITOS F " &
               "INNER JOIN CLIENTE C ON C.Codigo_Cliente = F.Codigo_Cliente " &
               "WHERE  F.Codigo_Pelicula = @codigo " &
               "  AND  F.Comentario IS NOT NULL " &
               "  AND  F.Comentario <> '' " &
               "ORDER BY F.Codigo_Rep DESC"


                Using adaptador As New SqlDataAdapter(consulta, conexion)
                    adaptador.SelectCommand.Parameters.AddWithValue("@codigo", codigoPelicula)
                    Dim tabla As New DataTable()
                    adaptador.Fill(tabla)
                    dgvComentarios.DataSource = tabla

                    ' TODO: Mejorar visual: colorear filas según Calificacion
                    ' (1-2 rojo, 3 amarillo, 4-5 verde) usando el evento
                    ' dgvComentarios.RowPrePaint o CellFormatting
                End Using
            End Using
        Catch ex As Exception
            MostrarError("Error al cargar comentarios: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarPromedio(codigoPelicula As Integer)
        Try
            Using conexion As New SqlConnection(ModConexion.ObtenerCadenaConexion())
                Dim consulta As String =
                    "SELECT ROUND(AVG(CAST(Calificacion AS FLOAT)), 1) AS Promedio, " &
                    "       COUNT(*) AS TotalResenas " &
                    "FROM   FAVORITOS " &
                    "WHERE  Codigo_Pelicula = @codigo " &
                    "  AND  Calificacion IS NOT NULL"

                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@codigo", codigoPelicula)
                    conexion.Open()
                    Using reader As SqlDataReader = comando.ExecuteReader()
                        If reader.Read() Then
                            If Not IsDBNull(reader("Promedio")) Then
                                Dim promedio As Double = Convert.ToDouble(reader("Promedio"))
                                Dim total As Integer = Convert.ToInt32(reader("TotalResenas"))
                                lblPromedio.Text = $"Promedio: {promedio:F1} / 5  ({total} reseñas)"
                                lblPromedio.ForeColor = Color.DarkSlateBlue
                            Else
                                lblPromedio.Text = "Sin calificaciones aún"
                                lblPromedio.ForeColor = Color.Gray
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MostrarError("Error al cargar promedio: " & ex.Message)
        End Try
    End Sub

    Private Sub VerificarReseñaExistente(codigoPelicula As Integer)
        Try
            Using conexion As New SqlConnection(ModConexion.ObtenerCadenaConexion())
                Dim consulta As String =
                    "SELECT Calificacion, Comentario, Favorito " &
                    "FROM   FAVORITOS " &
                    "WHERE  Codigo_Cliente  = @cliente " &
                    "  AND  Codigo_Pelicula = @pelicula"

                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@cliente", Sesion.CodigoCliente)
                    comando.Parameters.AddWithValue("@pelicula", codigoPelicula)
                    conexion.Open()

                    Using reader As SqlDataReader = comando.ExecuteReader()
                        If reader.Read() Then
                            ' Ya tiene reseña → cargamos sus valores actuales
                            If Not IsDBNull(reader("Calificacion")) Then
                                nudCalificacion.Value = Convert.ToDecimal(reader("Calificacion"))
                            End If
                            If Not IsDBNull(reader("Comentario")) Then
                                txtComentario.Text = reader("Comentario").ToString()
                            End If
                            If Not IsDBNull(reader("Favorito")) Then
                                chkFavorito.Checked = Convert.ToBoolean(reader("Favorito"))
                            End If
                            btnGuardar.Text = "Actualizar reseña"
                        Else
                            ' No tiene reseña → limpiamos campos
                            nudCalificacion.Value = 3
                            txtComentario.Clear()
                            chkFavorito.Checked = False
                            btnGuardar.Text = "Guardar reseña"
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MostrarError("Error al verificar reseña: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cmbPelicula.SelectedIndex <= 0 Then
            MostrarError("Selecciona una película primero.")
            Return
        End If

        Dim codigoPelicula As Integer = ObtenerCodigoCombo(cmbPelicula)
        Dim calificacion As Integer = CInt(nudCalificacion.Value)
        Dim comentario As String = txtComentario.Text.Trim()
        Dim esFavorito As Boolean = chkFavorito.Checked

        Try
            Using conexion As New SqlConnection(ModConexion.ObtenerCadenaConexion())
                ' MERGE: si ya existe la combinación cliente+película la actualiza,
                ' si no existe la inserta. Evita duplicados sin necesidad de hacer
                ' un SELECT previo por separado.
                Dim consulta As String =
                    "MERGE FAVORITOS AS destino " &
                    "USING (SELECT @cliente AS Codigo_Cliente, @pelicula AS Codigo_Pelicula) AS origen " &
                    "   ON destino.Codigo_Cliente  = origen.Codigo_Cliente " &
                    "  AND destino.Codigo_Pelicula = origen.Codigo_Pelicula " &
                    "WHEN MATCHED THEN " &
                    "   UPDATE SET Calificacion = @cal, Comentario = @com, Favorito = @favo " &
                    "WHEN NOT MATCHED THEN " &
                    "   INSERT (Codigo_Cliente, Codigo_Pelicula, Calificacion, Comentario, Favorito) " &
                    "   VALUES (@cliente, @pelicula, @cal, @com, @favo);"

                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@cliente", Sesion.CodigoCliente)
                    comando.Parameters.AddWithValue("@pelicula", codigoPelicula)
                    comando.Parameters.AddWithValue("@cal", calificacion)
                    comando.Parameters.AddWithValue("@com", If(comentario = "", CObj(DBNull.Value), CObj(comentario)))
                    comando.Parameters.AddWithValue("@favo", esFavorito)

                    conexion.Open()
                    comando.ExecuteNonQuery()
                End Using

            End Using

            MostrarExito("Reseña guardada correctamente.")
            CargarComentarios(codigoPelicula)
            CargarPromedio(codigoPelicula)
            btnGuardar.Text = "Actualizar reseña"
        Catch ex As Exception
            MostrarError("Error al guardar reseña: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbPelicula.SelectedIndex = 0
        nudCalificacion.Value = 3
        txtComentario.Clear()
        lblPromedio.Text = ""
        lblMensaje.Text = ""
        dgvComentarios.DataSource = Nothing
        btnGuardar.Text = "Guardar reseña"
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim frm As New cliente()
        frm.Show()
        Me.Hide()
    End Sub
End Class