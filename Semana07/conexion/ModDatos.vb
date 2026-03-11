Imports Microsoft.Data.SqlClient   ' ← Importamos el paquete moderno para conectar con SQL Server
'    (reemplaza al antiguo System.Data.SqlClient)
'    Nos da las clases: SqlConnection, SqlCommand, SqlDataAdapter, etc.

Module ModDatos
    ' Este módulo contiene funciones reutilizables para trabajar con la base de datos.
    ' Es como una "capa de datos" (Data Access Layer) muy simple.
    ' Todo el código asume que existe otro módulo llamado ModConexion
    ' que tiene la función ObtenerConexion() que devuelve una conexión abierta.

    ''' <summary>
    ''' Retorna un DataTable con los datos de una consulta SELECT.
    ''' Ideal para leer información (SELECT).
    ''' </summary>
    Public Function ObtenerDatos(query As String) As DataTable
        ' Creamos un DataTable vacío. Este objeto es como una "tabla en memoria"
        ' que luego llenaremos con los resultados de la consulta.
        Dim dt As New DataTable()

        ' Obtenemos la conexión desde ModConexion.
        ' Si no se pudo crear la conexión, devolvemos Nothing para indicar error.
        Dim conn As SqlConnection = ModConexion.ObtenerConexion()
        If conn Is Nothing Then Return Nothing

        Try
            ' Creamos un comando SQL que ejecutará la consulta que nos pasan.
            ' El segundo parámetro es la conexión que usará.
            Dim cmd As New SqlCommand(query, conn)

            ' SqlDataAdapter es el "puente" entre la base de datos y el DataTable.
            ' Se encarga de ejecutar el comando y llenar automáticamente el DataTable.
            Dim adapter As New SqlDataAdapter(cmd)

            ' ¡Aquí ocurre la magia! Fill() ejecuta el SELECT y llena el DataTable con filas y columnas.
            adapter.Fill(dt)

        Catch ex As Exception
            ' Si algo falla (error de conexión, consulta mal escrita, permisos, etc.)
            ' mostramos un MessageBox al usuario y ponemos dt = Nothing para indicar error.
            MessageBox.Show("Error al obtener datos: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            dt = Nothing
        Finally
            ' ¡MUY IMPORTANTE! Siempre cerramos la conexión, aunque haya habido error.
            ' El bloque Finally se ejecuta SIEMPRE (éxito o fallo).
            conn.Close() ' Siempre cerrar la conexión
        End Try

        ' Devolvemos el DataTable ya lleno (o Nothing si hubo error).
        Return dt
    End Function

    ''' <summary>
    ''' Ejecuta INSERT, UPDATE o DELETE. Retorna el número de filas afectadas.
    ''' </summary>
    Public Function EjecutarComando(query As String) As Integer
        ' Obtenemos la conexión (igual que en la función anterior).
        Dim conn As SqlConnection = ModConexion.ObtenerConexion()

        ' Variable para guardar cuántas filas se modificaron.
        ' Empezamos en 0.
        Dim filasAfectadas As Integer = 0

        ' Si no hay conexión válida, devolvemos -1 (convención para indicar error).
        If conn Is Nothing Then Return -1

        Try
            ' Creamos el comando SQL (aquí puede ser INSERT, UPDATE o DELETE).
            Dim cmd As New SqlCommand(query, conn)

            ' ExecuteNonQuery() ejecuta comandos que NO devuelven filas (no SELECT).
            ' Devuelve un entero: cuántas filas fueron afectadas.
            filasAfectadas = cmd.ExecuteNonQuery()

        Catch ex As Exception
            ' Si falla (por ejemplo, violación de clave primaria, conexión perdida, etc.)
            ' mostramos mensaje y devolvemos -1 para indicar error.
            MessageBox.Show("Error al ejecutar: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            filasAfectadas = -1
        Finally
            ' Cerramos la conexión siempre.
            conn.Close()
        End Try

        ' Devolvemos el número de filas afectadas (o -1 si hubo error).
        Return filasAfectadas
    End Function


    Public Function ValidarLogin(usuario As String, contrasena As String) As DataTable
        Dim dt As New DataTable()
        Dim conn As SqlConnection = ModConexion.ObtenerConexion()
        If conn Is Nothing Then Return Nothing

        Try
            Dim query As String = "SELECT Id, NombreUsuario, Correo 
                               FROM Usuarios 
                               WHERE NombreUsuario = @Usuario 
                               AND Contrasena = @Contrasena"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Usuario", usuario.Trim())
                cmd.Parameters.AddWithValue("@Contrasena", contrasena)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al validar login: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            dt = Nothing
        Finally
            conn.Close()
        End Try

        Return dt
    End Function
End Module