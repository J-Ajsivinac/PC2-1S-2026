Module ModuloMensajes
    '═══════════════════════════════════════════════════════════
    ' FUNCIÓN 1: Validar rango de nota
    ' ENTRADA: nota (Integer)
    ' SALIDA: Boolean (True si está en rango válido)
    '═══════════════════════════════════════════════════════════
    Public Function ValidarRangoNota(nota As Integer) As Boolean
        If nota >= 0 And nota <= 100 Then
            Return True
        Else
            Return False
        End If
    End Function


    '═══════════════════════════════════════════════════════════
    ' FUNCIÓN 2: Obtener calificación según nota y materia
    ' ENTRADA: nota (0-100), materia (String)
    ' SALIDA: String con la calificación ("Excelente", "Bueno", etc.)
    '═══════════════════════════════════════════════════════════
    Public Function ObtenerCalificacion(nota As Integer, materia As String) As String
        Dim calif As String = ""
        If nota < 0 Or nota > 100 Then
            Return "Nota inválida"
            Exit Function
        End If

        Select Case materia
            Case "Matemáticas", "Ciencias"
                If nota >= 90 Then
                    calif = "Excelente"
                ElseIf nota >= 80 Then
                    calif = "Muy Bueno"
                ElseIf nota >= 75 Then
                    calif = "Bueno"
                Else
                    calif = "Insuficiente"
                End If
            Case "Lenguaje", "Sociales"
                If nota >= 90 Then
                    calif = "Excelente"
                ElseIf nota >= 80 Then
                    calif = "Muy Bueno"
                ElseIf nota >= 65 Then
                    calif = "Bueno"
                Else
                    calif = "Insuficiente"
                End If
            Case "Inglés"
                ' Criterio intermedio
                If nota >= 90 Then
                    calif = "Excelente"
                ElseIf nota >= 80 Then
                    calif = "Muy Bueno"
                ElseIf nota >= 70 Then
                    calif = "Bueno"
                Else
                    calif = "Insuficiente"
                End If
            Case Else
                calif = "Materia desconocida"
        End Select
        Return calif
    End Function

    '═══════════════════════════════════════════════════════════
    ' FUNCIÓN 3: Verificar si está aprobado
    ' ENTRADA: nota (Integer), materia (String)
    ' SALIDA: Boolean (True si aprobó)
    '═══════════════════════════════════════════════════════════
    Public Function EstaAprobado(nota As Integer, materia As String) As Boolean
        Dim notaMinima As Integer

        ' Determinar nota mínima según materia usando SELECT CASE
        Select Case materia
            Case "Matemáticas", "Ciencias"
                notaMinima = 75  ' Más exigente
            Case "Lenguaje", "Sociales"
                notaMinima = 65  ' Menos exigente
            Case "Inglés"
                notaMinima = 70  ' Intermedio
            Case Else
                notaMinima = 70  ' Por defecto
        End Select

        ' Retornar si aprobó
        If nota >= notaMinima Then
            Return True
        Else
            Return False
        End If
    End Function

    '═══════════════════════════════════════════════════════════
    ' FUNCIÓN 4: Calcular puntos extra por desempeño excepcional
    ' ENTRADA: nota (Integer), materia (String)
    ' SALIDA: Integer (puntos extra ganados)
    '═══════════════════════════════════════════════════════════
    Public Function CalcularPuntosExtra(nota As Integer, materia As String) As Integer
        Dim puntosExtra As Integer = 0

        ' Solo se dan puntos extra si la nota es >= 90
        If nota >= 90 Then
            Select Case materia
                Case "Matemáticas", "Ciencias"
                    If nota >= 95 Then
                        puntosExtra = 10
                    Else
                        puntosExtra = 5
                    End If
                Case "Lenguaje", "Sociales", "Inglés"
                    ' Otras materias: menos puntos extra
                    If nota >= 95 Then
                        puntosExtra = 7
                    Else
                        puntosExtra = 3
                    End If
            End Select
        End If
        Return puntosExtra
    End Function

    '═══════════════════════════════════════════════════════════
    ' PROCEDIMIENTO 1: Mostrar mensaje motivacional
    ' ENTRADA: calificación, materia, etiqueta (ByRef para modificarla)
    ' SALIDA: Ninguna (Sub), modifica directamente la etiqueta
    '═══════════════════════════════════════════════════════════
    Public Sub MostrarMensajeMotivacional(calificacion As String, materia As String, etiqueta As Label)
        Dim mensaje As String = ""

        Select Case calificacion
            Case "Excelente"
                mensaje = "¡Impresionante! Dominaste " & materia & "."
                etiqueta.ForeColor = Color.DarkGreen
            Case "Muy Bueno"
                mensaje = "Muy sólido en " & materia & ". ¡Vas excelente!"
                etiqueta.ForeColor = Color.ForestGreen

            Case "Bueno"
                mensaje = "Buen nivel en " & materia & ". Solo falta un poco más."
                etiqueta.ForeColor = Color.DodgerBlue

            Case "Insuficiente"
                mensaje = "No te preocupes. " & materia & " requiere práctica. ¡Tú puedes!"
                etiqueta.ForeColor = Color.Firebrick

            Case Else
                mensaje = "Revisa la nota o la materia seleccionada."
                etiqueta.ForeColor = Color.Black
        End Select

        etiqueta.Text = mensaje
    End Sub
End Module
