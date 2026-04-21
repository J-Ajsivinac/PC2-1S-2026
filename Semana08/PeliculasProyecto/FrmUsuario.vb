Imports Microsoft.Data.SqlClient

Public Class FrmUsuario
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblBienvenida.Click

    End Sub

    Private Sub btnRegrear_Click(sender As Object, e As EventArgs) Handles btnRegrear.Click
        Dim frm As New cliente()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenida.Text = "Bienvenido/a, " & Sesion.NombreCliente

        CargarPeliculas("")

    End Sub

    Private Sub CargarPeliculas(filtro As String)
        Try
            Using conexion As New SqlConnection(ModConexion.ObtenerCadenaConexion())
                Dim consulta As String =
                    "SELECT P.Codigo_Pelicula, " &
                    "       P.Nombre        AS Película, " &
                    "       P.Minutos, " &
                    "       G.Nombre        AS Género, " &
                    "       D.Nombre        AS Director " &
                    "FROM   PELICULA  P " &
                    "INNER JOIN GENERO   G ON G.Codigo_Genero   = P.Codigo_Genero " &
                    "INNER JOIN DIRECTOR D ON D.Codigo_Director = P.Codigo_Director " &
                    "WHERE  P.Nombre LIKE '%' + @filtro + '%' " &
                    "ORDER BY P.Nombre"

                Using adaptador As New SqlDataAdapter(consulta, conexion)
                    adaptador.SelectCommand.Parameters.AddWithValue("@filtro", filtro)

                    Dim tabla As New DataTable()
                    adaptador.Fill(tabla)
                    dgvPeliculas.DataSource = tabla

                    If dgvPeliculas.Columns.Contains("Codigo_Pelicula") Then
                        dgvPeliculas.Columns("Codigo_Pelicula").Visible = False
                    End If

                    ' TODO: Mejorar visual del grid: filas alternadas, encabezado
                    ' con fondo de color y fuente en negrita.
                    ' Investiga dgvPeliculas.AlternatingRowsDefaultCellStyle
                End Using
            End Using
            lblDetalle.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error al cargar películas: " & ex.Message, "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarPeliculas(txtBuscar.Text.Trim())
    End Sub

    Private Sub dgvPeliculas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeliculas.CellClick
        If e.RowIndex < 0 Then Return

        Dim fila As DataGridViewRow = dgvPeliculas.Rows(e.RowIndex)

        Dim nombre As String = fila.Cells("Película").Value.ToString()
        Dim minutos As String = fila.Cells("Minutos").Value.ToString()
        Dim genero As String = fila.Cells("Género").Value.ToString()
        Dim director As String = fila.Cells("Director").Value.ToString()

        lblDetalle.ForeColor = Color.DarkSlateBlue

        lblDetalle.Text =
            $"  {nombre}     {minutos} min  |  Género: {genero}  |  Director: {director}"
    End Sub
End Class