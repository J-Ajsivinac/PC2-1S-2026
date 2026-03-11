Imports Microsoft.Data.SqlClient   ' ← Mismo paquete que usamos en ModDatos.
'    Proporciona la clase SqlConnection (la más importante aquí).

Module ModConexion
    ' Este módulo es la "capa de conexión". 
    ' Su única responsabilidad es manejar todo lo relacionado con abrir la conexión a SQL Server.
    ' Al tener la cadena de conexión aquí (centralizada), si cambias de servidor, base de datos o credenciales,
    ' solo modificas este archivo y TODA la aplicación se actualiza automáticamente.

    ' Cadena de conexión centralizada
    ' Esta es la información que SQL Server necesita para conectarse.
    ' Formato típico: Server=NombreServidor;Database=NombreBD;User Id=Usuario;Password=Contraseña;...
    ' OJO agregar TrustServerCertificate=True; para evitar errores de certificado.
    Public ConexionString As String = "Server=localhost;Database=Ejemplo;User Id=SA;Password=Contra123!;TrustServerCertificate=True;"

    ' Comentario útil: alternativa con Windows Authentication (más segura, no guarda contraseña).
    ' Si usas Windows Authentication:
    ' Public ConexionString As String = "Server=localhost;Database=Ejemplo;Integrated Security=true;TrustServerCertificate=True;"

    ''' <summary>
    ''' Abre y retorna una conexión activa a SQL Server
    ''' </summary>
    Public Function ObtenerConexion() As SqlConnection
        ' Creamos un objeto SqlConnection usando la cadena definida arriba.
        ' En este momento la conexión todavía está "cerrada".
        Dim conn As New SqlConnection(ConexionString)

        Try
            ' Abrimos la conexión real con la base de datos.
            ' Aquí es donde realmente se establece la comunicación.
            conn.Open()

            ' Si todo salió bien, devolvemos la conexión ABIERTA.
            ' ModDatos (el módulo anterior) la usará inmediatamente.
            Return conn

        Catch ex As Exception
            ' Si falla la conexión (servidor apagado, credenciales incorrectas,
            ' base de datos no existe, red caída, etc.) mostramos mensaje al usuario.
            MessageBox.Show("Error al conectar: " & ex.Message, "Error de Conexión",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Devolvemos Nothing para indicar que NO hay conexión válida.
            ' Esto es lo que detectan las funciones de ModDatos.
            Return Nothing
        End Try
        ' Nota: No hay bloque Finally aquí porque si falla, no tenemos nada que cerrar.
    End Function

    ''' <summary>
    ''' Verifica si la conexión está activa
    ''' Útil para probar la conexión antes de empezar la aplicación.
    ''' </summary>
    Public Function ProbarConexion() As Boolean
        ' Llamamos a la función anterior para intentar abrir la conexión.
        Dim conn As SqlConnection = ObtenerConexion()

        ' Si ObtenerConexion() devolvió una conexión (no Nothing)...
        If conn IsNot Nothing Then
            ' ...la cerramos inmediatamente (solo la estábamos probando).
            conn.Close()
            ' Devolvemos True = conexión OK
            Return True
        End If

        ' Si llegamos aquí es porque falló la conexión
        Return False
    End Function

End Module