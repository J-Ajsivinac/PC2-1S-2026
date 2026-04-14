Imports Microsoft.Data.SqlClient

Public Class Form1

    ' --------------------------------------------------
    ' EVENTO: Formulario cargado
    ' Se ejecuta automáticamente cuando el form aparece
    ' --------------------------------------------------
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Inicio de Sesión"
        lblMensaje.Text = ""
        lblMensaje.ForeColor = Color.Red

        ' La barra de progreso también inicia oculta
        prgCargando.Visible = False

        txtContrasenia.PasswordChar = "*"c
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' ── PASO 1: Leer lo que escribió el usuario ──────────────────
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contrasenia As String = txtContrasenia.Text.Trim()

        ' ── PASO 2: Validación básica (campos vacíos) ─────────────────
        If usuario = "" OrElse contrasenia = "" Then
            lblMensaje.Text = "Por favor ingresa usuario y contraseña."
            Return ' Salimos del evento, no continuamos
        End If

        ' TODO: Agregar validaciones más robustas, por ejemplo:
        '   - Limitar la longitud máxima del campo usuario (ej. 50 caracteres)
        '   - Detectar caracteres peligrosos como comillas simples para prevenir inyección SQL
        '   - Deshabilitar el botón btnLogin mientras se procesa para evitar doble clic

        ' ── PASO 3: Mostrar indicador de carga ────────────────────────
        prgCargando.Visible = True
        prgCargando.Style = ProgressBarStyle.Marquee ' Animación continua
        btnLogin.Enabled = False                     ' Evita doble clic

        ' ── PASO 4: Intentar conectar y verificar credenciales ────────
        Try
            ' Creamos la conexión usando nuestro módulo centralizado
            Using conexion As New SqlConnection(ModConexion.ObtenerCadenaConexion())

                ' ── CONSULTA SQL ──────────────────────────────────────
                ' Buscamos en CLIENTE un registro que coincida con
                ' el Usuario Y la Contrasenia ingresados.
                ' Traemos también Nombre y Tipo para usarlos luego.
                '
                ' NOTA: Usamos @usuario y @contrasenia como parámetros
                ' para evitar SQL Injection (nunca concatenes strings en SQL)
                Dim consulta As String =
                    "SELECT codigo_Cliente, nombre, tipo " &
                    "FROM cliente " &
                    "WHERE usuario = @usuario AND contrasenia = @contrasenia"

                Using comando As New SqlCommand(consulta, conexion)

                    ' Asignamos los valores a los parámetros de forma segura
                    comando.Parameters.AddWithValue("@usuario", usuario)
                    comando.Parameters.AddWithValue("@contrasenia", contrasenia)

                    ' Abrimos la conexión justo antes de usarla
                    conexion.Open()

                    ' ExecuteReader nos permite leer filas del resultado
                    Using reader As SqlDataReader = comando.ExecuteReader()

                        ' ── PASO 5: ¿Encontró algún usuario? ─────────
                        If reader.Read() Then
                            ' Sí encontró → leemos los datos del usuario
                            Dim codigoCliente As Integer = Convert.ToInt32(reader("codigo_cliente"))
                            Dim nombreCliente As String = reader("nombre").ToString()
                            TipoCliente = reader("tipo").ToString()

                            ' Cerramos el reader antes de abrir otro formulario
                            reader.Close()

                            ' ── PASO 6: Guardar datos en módulo global ─
                            ' Guardamos el usuario logueado para usarlo en otros formularios
                            Sesion.CodigoCliente = codigoCliente
                            Sesion.NombreCliente = nombreCliente
                            Sesion.TipoCliente = tipoCliente

                            ' ── PASO 7: Redirigir según el rol ────────
                            NavegacionPorRol(tipoCliente)

                        Else
                            ' No encontró → credenciales incorrectas
                            lblMensaje.Text = "Usuario o contraseña incorrectos."

                            ' Limpiamos solo la contraseña por seguridad
                            txtContrasenia.Clear()
                            txtContrasenia.Focus()

                            ' TODO: Mejorar UX implementando un contador de intentos fallidos.
                            ' Si el usuario falla 3 veces seguidas, deshabilitar el botón
                            ' por 30 segundos usando un Timer. Guarda el contador en una
                            ' variable de módulo (Module) para persistirla entre intentos.
                        End If

                    End Using ' Cierra el reader automáticamente
                End Using     ' Cierra el comando automáticamente
            End Using         ' Cierra y libera la conexión automáticamente

        Catch ex As SqlException
            ' Error específico de SQL Server (conexión caída, BD no existe, etc.)
            lblMensaje.Text = "Error de base de datos. Contacta al administrador."

        Catch ex As Exception
            ' Cualquier otro error inesperado
            lblMensaje.Text = "Error inesperado: " & ex.Message

        Finally
            ' Finally siempre se ejecuta, haya error o no
            ' Restauramos la interfaz sin importar qué pasó
            txtUsuario.Clear()
            txtContrasenia.Clear()
            prgCargando.Visible = False
            btnLogin.Enabled = True
        End Try

    End Sub


    ' --------------------------------------------------
    ' MÉTODO PRIVADO: Navegación según el rol
    ' Centralizar esto aquí evita repetir código
    ' --------------------------------------------------
    Private Sub NavegacionPorRol(tipo As String)

        Select Case tipo.ToLower().Trim()

            Case "admin"
                ' Es administrador → abrir formulario de Admin
                Dim frmAdmin As New administrador()
                frmAdmin.Show()
                Me.Hide() ' Ocultamos el login (no lo cerramos aún)

            Case "cliente"
                ' Es cliente normal → abrir formulario de Cliente
                Dim frmCliente As New cliente()
                frmCliente.Show()
                Me.Hide()

            Case Else
                ' El campo Tipo tiene un valor desconocido o está vacío
                lblMensaje.Text = "Rol no reconocido. Contacta al administrador."

                ' TODO: Definir un rol por defecto si Tipo está vacío,
                ' o redirigir a un formulario genérico de bienvenida.
                ' Considera si los nuevos registros de CLIENTE siempre
                ' tendrán el campo Tipo lleno al crearse.

        End Select

    End Sub

    Private Sub chkMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrar.CheckedChanged
        If chkMostrar.Checked Then
            txtContrasenia.PasswordChar = Nothing ' Muestra el texto en claro
        Else
            txtContrasenia.PasswordChar = "*"c   ' Vuelve a ocultar con asteriscos
        End If
    End Sub
End Class
