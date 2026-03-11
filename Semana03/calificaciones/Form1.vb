Public Class Form1
    '═══════════════════════════════════════════════════════════
    ' EVENTO: Load del formulario
    ' CÓMO CREAR: Doble clic en el formulario (área vacía)
    '═══════════════════════════════════════════════════════════
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Mi primer formulario en Visual Basic .NET"

        cboMateria.Items.Add("Matemáticas")  ' Index 0
        cboMateria.Items.Add("Lenguaje")     ' Index 1
        cboMateria.Items.Add("Ciencias")     ' Index 2
        cboMateria.Items.Add("Sociales")     ' Index 3
        cboMateria.Items.Add("Inglés")       ' Index 4

        ' Seleccionar el primer elemento por defecto
        'If cboMateria.Items.Count > 0 Then
        '    cboMateria.SelectedIndex = 2 ' Selecciona "Ciencias"
        'End If
    End Sub

    Private Sub btnEvaluar_Click(sender As Object, e As EventArgs) Handles btnEvaluar.Click
        Dim nota As Integer
        Dim resultado As String
        Dim materia As String
        Dim esAprobado As Boolean
        Dim puntosExtra As Integer

        ' Verificar que se haya seleccionado una materia
        If cboMateria.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione una materia.", "ATENCIÓN")
            ' exit sub es para salir del procedimiento sin ejecutar el resto del código
            Exit Sub
        End If

        materia = cboMateria.SelectedItem.ToString() ' Obtener el texto de la materia seleccionada

        'Intentar converr el texto de la nota a un número entero
        If Integer.TryParse(txtNota.Text, nota) Then
            ' Validar rango usnado Función de un módulo
            If Not ModuloMensajes.ValidarRangoNota(nota) Then
                MessageBox.Show("La nota debe estar entre 0 y 100.", "ERROR DE VALIDACIÓN")
                Exit Sub
            End If

            resultado = ModuloMensajes.ObtenerCalificacion(nota, materia)
            esAprobado = ModuloMensajes.EstaAprobado(nota, materia)
            puntosExtra = ModuloMensajes.CalcularPuntosExtra(nota, materia)

            lblResultado.Text = "En " & materia & ": " & resultado
            If esAprobado Then
                lblMensaje.Text = "Estado: APROBADO"
            Else
                lblMensaje.Text = "Estado: REPROBADO"
            End If

            If puntosExtra > 0 Then
                lblMensaje.Text &= vbCrLf & "Puntos Extra Gandados: " & puntosExtra
            End If

            ModuloMensajes.MostrarMensajeMotivacional(resultado, materia, lblMotivacion)
        End If
    End Sub
End Class
