Module ModConexion
    Public Function ObtenerCadenaConexion() As String
        ' Ajusta "Server", "Database", "User Id" y "Password" según tu entorno
        ' Return "Server=localhost;Database=PeliculasDB;User Id=SA;Password=Contra123!;TrustServerCertificate=True;"

        ' Si usas autenticación de Windows (sin usuario/contraseña), usa esta:
        Return "Server=localhost;Database=PeliculasDB;Integrated Security=true;TrustServerCertificate=True;"
    End Function
End Module
