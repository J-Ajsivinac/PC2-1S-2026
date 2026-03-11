<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        lblFechaCorta = New Label()
        lblFecha = New Label()
        lblCantidad = New Label()
        lblPrioridad = New Label()
        chkEstaCompletada = New CheckBox()
        chkEsUrgente = New CheckBox()
        dtpFechaVencimiento = New DateTimePicker()
        Label5 = New Label()
        nudCantidadSubtareas = New NumericUpDown()
        Label4 = New Label()
        txtDescripcionTarea = New TextBox()
        Label3 = New Label()
        nudNivelPrioridad = New NumericUpDown()
        txtNombreTarea = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnAgregarTarea = New Button()
        btnActualizar = New Button()
        btnLimpiar = New Button()
        Label6 = New Label()
        pbrProgresoTareas = New ProgressBar()
        txtListaTareas = New TextBox()
        GroupBox1.SuspendLayout()
        CType(nudCantidadSubtareas, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudNivelPrioridad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblFechaCorta)
        GroupBox1.Controls.Add(lblFecha)
        GroupBox1.Controls.Add(lblCantidad)
        GroupBox1.Controls.Add(lblPrioridad)
        GroupBox1.Controls.Add(chkEstaCompletada)
        GroupBox1.Controls.Add(chkEsUrgente)
        GroupBox1.Controls.Add(dtpFechaVencimiento)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(nudCantidadSubtareas)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtDescripcionTarea)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(nudNivelPrioridad)
        GroupBox1.Controls.Add(txtNombreTarea)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(712, 368)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Detalle de Nueva Tarea"
        ' 
        ' lblFechaCorta
        ' 
        lblFechaCorta.AutoSize = True
        lblFechaCorta.Location = New Point(185, 287)
        lblFechaCorta.Name = "lblFechaCorta"
        lblFechaCorta.Size = New Size(0, 20)
        lblFechaCorta.TabIndex = 15
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(183, 251)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(0, 20)
        lblFecha.TabIndex = 14
        ' 
        ' lblCantidad
        ' 
        lblCantidad.AutoSize = True
        lblCantidad.Location = New Point(491, 185)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New Size(0, 20)
        lblCantidad.TabIndex = 13
        ' 
        ' lblPrioridad
        ' 
        lblPrioridad.AutoSize = True
        lblPrioridad.Location = New Point(490, 90)
        lblPrioridad.Name = "lblPrioridad"
        lblPrioridad.Size = New Size(0, 20)
        lblPrioridad.TabIndex = 12
        ' 
        ' chkEstaCompletada
        ' 
        chkEstaCompletada.AutoSize = True
        chkEstaCompletada.Location = New Point(143, 328)
        chkEstaCompletada.Name = "chkEstaCompletada"
        chkEstaCompletada.Size = New Size(175, 24)
        chkEstaCompletada.TabIndex = 11
        chkEstaCompletada.Text = "¿Ya está completada?"
        chkEstaCompletada.UseVisualStyleBackColor = True
        ' 
        ' chkEsUrgente
        ' 
        chkEsUrgente.AutoSize = True
        chkEsUrgente.Location = New Point(12, 328)
        chkEsUrgente.Name = "chkEsUrgente"
        chkEsUrgente.Size = New Size(116, 24)
        chkEsUrgente.TabIndex = 10
        chkEsUrgente.Text = "¿Es Urgente?"
        chkEsUrgente.UseVisualStyleBackColor = True
        ' 
        ' dtpFechaVencimiento
        ' 
        dtpFechaVencimiento.Location = New Point(183, 221)
        dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        dtpFechaVencimiento.Size = New Size(510, 27)
        dtpFechaVencimiento.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(153, 20)
        Label5.TabIndex = 8
        Label5.Text = "Fecha de vencimiento"
        ' 
        ' nudCantidadSubtareas
        ' 
        nudCantidadSubtareas.Location = New Point(490, 151)
        nudCantidadSubtareas.Name = "nudCantidadSubtareas"
        nudCantidadSubtareas.Size = New Size(203, 27)
        nudCantidadSubtareas.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(490, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(203, 20)
        Label4.TabIndex = 6
        Label4.Text = "Cantidad de Subtareas (0-50)"
        ' 
        ' txtDescripcionTarea
        ' 
        txtDescripcionTarea.Location = New Point(16, 150)
        txtDescripcionTarea.Name = "txtDescripcionTarea"
        txtDescripcionTarea.Size = New Size(456, 27)
        txtDescripcionTarea.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 4
        Label3.Text = "Descripción"
        ' 
        ' nudNivelPrioridad
        ' 
        nudNivelPrioridad.Location = New Point(490, 60)
        nudNivelPrioridad.Name = "nudNivelPrioridad"
        nudNivelPrioridad.Size = New Size(203, 27)
        nudNivelPrioridad.TabIndex = 3
        ' 
        ' txtNombreTarea
        ' 
        txtNombreTarea.Location = New Point(16, 59)
        txtNombreTarea.Name = "txtNombreTarea"
        txtNombreTarea.Size = New Size(456, 27)
        txtNombreTarea.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(490, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nivel de prioridad (1-10)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre de la tarea"
        ' 
        ' btnAgregarTarea
        ' 
        btnAgregarTarea.Location = New Point(7, 386)
        btnAgregarTarea.Name = "btnAgregarTarea"
        btnAgregarTarea.Size = New Size(255, 38)
        btnAgregarTarea.TabIndex = 1
        btnAgregarTarea.Text = "Agregar Tarea"
        btnAgregarTarea.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(268, 387)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(229, 36)
        btnActualizar.TabIndex = 2
        btnActualizar.Text = "Ver Progreso"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(503, 388)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(216, 36)
        btnLimpiar.TabIndex = 3
        btnLimpiar.Text = "Limpiar Todo"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 429)
        Label6.Name = "Label6"
        Label6.Size = New Size(226, 20)
        Label6.TabIndex = 4
        Label6.Text = "Progreso de Tareas Completadas"
        ' 
        ' pbrProgresoTareas
        ' 
        pbrProgresoTareas.Location = New Point(12, 452)
        pbrProgresoTareas.Name = "pbrProgresoTareas"
        pbrProgresoTareas.Size = New Size(712, 29)
        pbrProgresoTareas.TabIndex = 5
        ' 
        ' txtListaTareas
        ' 
        txtListaTareas.Location = New Point(12, 487)
        txtListaTareas.Multiline = True
        txtListaTareas.Name = "txtListaTareas"
        txtListaTareas.ReadOnly = True
        txtListaTareas.Size = New Size(712, 188)
        txtListaTareas.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(741, 687)
        Controls.Add(txtListaTareas)
        Controls.Add(pbrProgresoTareas)
        Controls.Add(Label6)
        Controls.Add(btnLimpiar)
        Controls.Add(btnActualizar)
        Controls.Add(btnAgregarTarea)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(nudCantidadSubtareas, ComponentModel.ISupportInitialize).EndInit()
        CType(nudNivelPrioridad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nudNivelPrioridad As NumericUpDown
    Friend WithEvents txtNombreTarea As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudCantidadSubtareas As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcionTarea As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkEstaCompletada As CheckBox
    Friend WithEvents chkEsUrgente As CheckBox
    Friend WithEvents dtpFechaVencimiento As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregarTarea As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents pbrProgresoTareas As ProgressBar
    Friend WithEvents txtListaTareas As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPrioridad As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblFechaCorta As Label

End Class
