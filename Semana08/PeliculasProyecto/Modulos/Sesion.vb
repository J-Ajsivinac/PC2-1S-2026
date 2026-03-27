Module Sesion
    ' Código único del cliente en la BD (de CLIENTE.Codigo_Cliente)
    Public CodigoCliente As Integer = 0

    ' Nombre real del usuario (de CLIENTE.Nombre)
    Public NombreCliente As String = ""

    ' Rol del usuario (de CLIENTE.Tipo) → "Administrador" o "Cliente"
    Public TipoCliente As String = ""

    ' --------------------------------------------------
    ' SUB: CerrarSesion
    ' Llama esto desde cualquier formulario al hacer logout
    ' --------------------------------------------------
    Public Sub CerrarSesion()
        ' Resetea todos los datos de sesión
        CodigoCliente = 0
        NombreCliente = ""
        TipoCliente = ""

        ' TODO: Si en el futuro agregas más datos de sesión
        ' (ej. email, token, etc.) recuerda limpiarlos aquí también.
    End Sub
End Module
