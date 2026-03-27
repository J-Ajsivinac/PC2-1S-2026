' =============================================
' MÓDULO: ModPeliculasDAL.vb
' Propósito: Contiene TODAS las operaciones con la Base de Datos (CRUD)
' Ventaja: Separa la lógica de datos del formulario (buena práctica)
' =============================================
Imports Microsoft.Data.SqlClient

Module ModPeliculasDAL
    Public Sub CargarGeneros(cmb As ComboBox)
        Try
            Using conn As New SqlConnection(ModConexion.ObtenerCadenaConexion())
                Dim sql As String = "SELECT codigo_genero, nombre FROM genero ORDER BY Nombre"

                Using cmd As New SqlCommand(sql, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        cmb.Items.Clear()
                        cmb.Items.Add("-- Seleccione un género --")

                        Dim codigos As New List(Of Integer)

                        While reader.Read()
                            cmb.Items.Add(reader("nombre").ToString())
                            codigos.Add(Convert.ToInt32(reader("codigo_genero")))
                        End While

                        ' Guardamos los códigos en el Tag del ComboBox
                        ' Razón: El ComboBox solo muestra texto (Nombre), pero necesitamos el Código_Genero para guardar en la BD
                        cmb.Tag = codigos.ToArray()
                        cmb.SelectedIndex = 0   ' Selecciona el placeholder por defecto

                    End Using
                End Using
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al cargar géneros: " & ex.Message)
        End Try
    End Sub

    Public Sub CargarDirectores(cmb As ComboBox)
        Try
            Using conn As New SqlConnection(ModConexion.ObtenerCadenaConexion())
                Dim sql As String = "SELECT codigo_director, nombre FROM DIRECTOR ORDER BY Nombre"

                Using cmd As New SqlCommand(sql, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        cmb.Items.Clear()
                        cmb.Items.Add("-- Selecciona director --")

                        Dim codigos As New List(Of Integer)

                        While reader.Read()
                            cmb.Items.Add(reader("nombre").ToString())
                            codigos.Add(Convert.ToInt32(reader("codigo_director")))
                        End While

                        cmb.Tag = codigos.ToArray()
                        cmb.SelectedIndex = 0
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al cargar directores: " & ex.Message)
        End Try
    End Sub

    Public Sub CargarPeliculas(dgv As DataGridView)
        Try
            Using conn As New SqlConnection(ModConexion.ObtenerCadenaConexion())
                Dim sql As String =
                    "SELECT P.codigo_pelicula, " &
                    "       P.nombre AS película, " &
                    "       P.minutos, " &
                    "       G.nombre AS género, " &
                    "       D.nombre AS director " &
                    "FROM pelicula P " &
                    "INNER JOIN genero G ON G.codigo_genero = P.codigo_genero " &
                    "INNER JOIN director D ON D.codigo_director = P.codigo_director " &
                    "ORDER BY P.Nombre"

                Using da As New SqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgv.DataSource = dt

                    ' Ocultamos la columna del código porque es solo para uso interno
                    If dgv.Columns.Contains("codigo_pelicula") Then
                        dgv.Columns("codigo_pelicula").Visible = False
                    End If
                End Using
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al cargar películas: " & ex.Message)
        End Try
    End Sub

    Public Sub InsertarPelicula(nombre As String, minutos As Integer, codGenero As Integer, codDirector As Integer)
        Using conn As New SqlConnection(ModConexion.ObtenerCadenaConexion())
            Dim sql As String =
                "INSERT INTO pelicula (nombre, minutos, codigo_genero, codigo_director) " &
                "VALUES (@nombre, @minutos, @codGenero, @codDirector)"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@minutos", minutos)
                cmd.Parameters.AddWithValue("@codGenero", codGenero)
                cmd.Parameters.AddWithValue("@codDirector", codDirector)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Obtiene el código real (codigo_genero o codigo_director) desde el Tag del ComboBox
    ''' </summary>
    Public Function ObtenerCodigoCombo(cmb As ComboBox) As Integer
        ' Si el usuario no ha seleccionado nada (está en el placeholder), devolvemos -1
        If cmb.SelectedIndex <= 0 Then Return -1

        Dim codigos() As Integer = CType(cmb.Tag, Integer())

        ' Restamos 1 porque el índice 0 del ComboBox es el texto "-- Selecciona --"
        Return codigos(cmb.SelectedIndex - 1)
    End Function
End Module
