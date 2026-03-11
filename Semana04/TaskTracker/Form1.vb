Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cambiar el título de la ventana
        Me.Text = "Gestor de Tareas"

        'Mostrar la ventanan en el centro de la pantalla
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Prioridad: valores del 1 al 10
        nudNivelPrioridad.Minimum = 1
        nudNivelPrioridad.Maximum = 10
        nudNivelPrioridad.Value = 1

        ' Cantidad de subtareas: 0 a 50
        nudCantidadSubtareas.Minimum = 0
        nudCantidadSubtareas.Maximum = 50
        nudCantidadSubtareas.Value = 0

        ' Fecha de vencimiento: hoy por defecto
        dtpFechaVencimiento.Value = DateTime.Now

        ' Configuracion de la barra de progreso
        pbrProgresoTareas.Minimum = 0
        pbrProgresoTareas.Maximum = 100
        pbrProgresoTareas.Value = 0

        ' Configurar el TextBox para mostrar las tareas medianto código
        'txtListaTareas.Multiline = True
        txtListaTareas.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub btnAgregarTarea_Click(sender As Object, e As EventArgs) Handles btnAgregarTarea.Click
        If ValidarEntrada() Then
            Dim nombre As String = txtNombreTarea.Text
            Dim descripcion As String = txtDescripcionTarea.Text
            Dim fecha As Date = dtpFechaVencimiento.Value
            Dim esUrgente As Boolean = chkEsUrgente.Checked
            Dim estaCompleta As Boolean = chkEstaCompletada.Checked
            Dim nivelPrioridad As Integer = nudNivelPrioridad.Value
            Dim cantidadSubtareas As Integer = nudCantidadSubtareas.Value

            UtilidadesTareas.AgregarTareaAString(nombre, descripcion, fecha, esUrgente, estaCompleta, nivelPrioridad, cantidadSubtareas)
            actualizarTXTTareas()
            LimpiarCampos()

        End If
    End Sub

    Private Function ValidarEntrada() As Boolean
        ' Validar que el nombre de la tarea no esté vacío
        If String.IsNullOrWhiteSpace(txtNombreTarea.Text) Then Return False
        If String.IsNullOrWhiteSpace(txtDescripcionTarea.Text) Then Return False
        If dtpFechaVencimiento.Value < Date.Now Then
            MessageBox.Show("La fecha de vencimiento debe ser futura.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show("La fecha de vencimiento debe ser futura.", "Error de Validación")
            Return False
        End If
        Return True
    End Function

    Private Sub actualizarTXTTareas()
        txtListaTareas.Text = UtilidadesTareas.TareasString
    End Sub

    Private Sub LimpiarCampos()
        txtNombreTarea.Clear()
        txtDescripcionTarea.Clear()
        dtpFechaVencimiento.Value = DateTime.Now
        chkEsUrgente.Checked = False
        chkEstaCompletada.Checked = False
        nudNivelPrioridad.Value = 1
        nudCantidadSubtareas.Value = 0
    End Sub

    Private Sub actualizarProgreso()
        Dim porcentaje As Integer = UtilidadesTareas.CalcularPorcentajeCompletadas()
        pbrProgresoTareas.Value = porcentaje
        MessageBox.Show("Porcentaje de tareas completadas: " & porcentaje.ToString() & "%", "Progreso de Tareas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarProgreso()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        UtilidadesTareas.LimpiarTareas()
        actualizarTXTTareas()
        LimpiarCampos()
        pbrProgresoTareas.Value = 0
        MessageBox.Show("Todas las tareas han sido eliminadas.", "Tareas Limpiadas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub nudNivelPrioridad_ValueChanged(sender As Object, e As EventArgs) Handles nudNivelPrioridad.ValueChanged
        If nudNivelPrioridad.Value > 5 Then
            lblPrioridad.Text = "Prioridad alta Seleccionada"
            lblPrioridad.ForeColor = Color.Red
        Else
            lblPrioridad.Text = "Prioridad baja Seleccionada"
            lblPrioridad.ForeColor = Color.Green
        End If
    End Sub

    Private Sub nudCantidadSubtareas_ValueChanged(sender As Object, e As EventArgs) Handles nudCantidadSubtareas.ValueChanged
        If nudCantidadSubtareas.Value > nudCantidadSubtareas.Maximum / 2 Then
            lblCantidad.Text = "Muchas subtareas seleccionadas"
            lblCantidad.ForeColor = Color.OrangeRed
        Else
            lblCantidad.Text = "Pocas subtareas seleccionadas"
            lblCantidad.ForeColor = Color.CadetBlue
        End If
    End Sub

    Private Sub chkEsUrgente_MouseCaptureChanged(sender As Object, e As EventArgs) Handles chkEsUrgente.MouseCaptureChanged
        If chkEsUrgente.Checked Then
            MessageBox.Show("¡Tarea marcada como urgente!. Asegurate de completarla pronto", "Urgente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dtpFechaVencimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaVencimiento.ValueChanged
        lblFecha.Text = "Fecha Seleccionada: " & dtpFechaVencimiento.Value.ToLongDateString()
        lblFechaCorta.ForeColor = Color.Purple
        lblFechaCorta.Text = "Fecha Corta: " & dtpFechaVencimiento.Value.ToShortDateString()
        lblFechaCorta.ForeColor = Color.Coral
    End Sub

    Private Sub chkEsUrgente_CheckedChanged(sender As Object, e As EventArgs) Handles chkEsUrgente.CheckedChanged

    End Sub

    Private Sub chkEstaCompletada_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstaCompletada.CheckedChanged
        If chkEstaCompletada.Checked Then
            MessageBox.Show("¡Tarea marcada como completada!. ¡Buen trabajo!", "Completada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
