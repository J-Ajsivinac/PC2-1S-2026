Module UtilidadesTareas
    ' ---------------------------------------------------------------
    ' ALMACENAMIENTO GLOBAL (en memoria, formato delimitado por "|")
    ' Cada línea representa una tarea:
    '   nombre|descripcion|fecha(yyyy-MM-dd)|urgente|completada|prioridad|subtareas
    ' ---------------------------------------------------------------

    Public TareasString As String = ""

    Public Sub AgregarTareaAString(nombre As String, descripcion As String, fecha As Date,
                                   esUrgente As Boolean, estaCompletada As Boolean,
                                   nivelPrioridad As Integer, cantidadSubtareas As Integer)

        'Forma 1: Usar String.Format para crear la línea de texto con formato delimitado
        Dim lineaTarea As String = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}",
                                            nombre, descripcion, fecha.ToString("yyyy-MM-dd"),
                                            esUrgente, estaCompletada, nivelPrioridad, cantidadSubtareas)

        ' Forma 2: Usar interpolación de cadenas (más legible)
        'Dim lineaTarea As String = nombre & "|" &
        '                           descripcion & "|" &
        '                           fecha.ToString("yyyy-MM-dd") & "|" &
        '                           esUrgente.ToString() & "|" &
        '                           estaCompletada.ToString() & "|" &
        '                           nivelPrioridad.ToString() & "|" &
        '                           cantidadSubtareas.ToString()

        If TareasString <> "" Then
            TareasString = TareasString & vbCrLf & lineaTarea
            ' Caso inicial: si no hay tareas, asignamos directamente la primera línea
        Else
            TareasString = lineaTarea
        End If

    End Sub

    Public Function CalcularPorcentajeCompletadas() As Integer
        Dim total As Integer = ContarTotalTareas()
        If total = 0 Then Return 0
        ' CInt es el tipo de dato entero en VB.NET, se usa para convertir el resultado a un número entero
        ' CInt es necesario porque el resultado de la división es un número decimal (Double) y queremos un porcentaje entero
        ' El cálculo es: (número de tareas completadas / número total de tareas) * 100 para obtener el porcentaje
        Return CInt((ContarTareasCompletadas() / total) * 100)
    End Function

    Public Function ContarTotalTareas() As Integer
        If TareasString = "" Then Return 0
        Dim total As Integer = 0

        ' Dividir el string en líneas usando vbCrLf como separador
        ' Cada línea representa una tarea, por lo que el número de líneas es el número de tareas
        ' TareaString = "Tarea1|Descripción1|2024-06-30|True|False|5|3" & vbCrLf & "Tarea2|Descripción2|2024-07-15|False|True|3|0"
        ' lineas = {"Tarea1|Descripción1|2024-06-30|True|False|5|3", "Tarea2|Descripción2|2024-07-15|False|True|3|0"}

        Dim lineas As String() = TareasString.Split(vbCrLf)
        total = lineas.Length
        Return total
    End Function

    Public Function ContarTareasCompletadas() As Integer
        If TareasString = "" Then Return 0
        Dim completadas As Integer = 0
        Dim lineas As String() = TareasString.Split(vbCrLf)
        For Each linea As String In lineas
            ' Cada línea tiene el formato: nombre|descripcion|fecha|urgente|completada|prioridad|subtareas
            ' Para obtener el campo "completada", dividimos la línea por "|" y accedemos al índice 4 (0-based)
            Dim campos As String() = linea.Split("|"c)
            If campos.Length >= 5 Then
                Dim estaCompletada As Boolean
                If Boolean.TryParse(campos(4), estaCompletada) AndAlso estaCompletada Then
                    completadas += 1
                End If
            End If
        Next
        Return completadas
    End Function


    Public Sub LimpiarTareas()
        TareasString = ""
    End Sub

End Module
