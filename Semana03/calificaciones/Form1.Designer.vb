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
        Dim ListViewGroup1 As ListViewGroup = New ListViewGroup("ListViewGroup", HorizontalAlignment.Left)
        Dim ListViewGroup2 As ListViewGroup = New ListViewGroup("ListViewGroup", HorizontalAlignment.Left)
        Dim ListViewGroup3 As ListViewGroup = New ListViewGroup("ListViewGroup", HorizontalAlignment.Left)
        Label1 = New Label()
        Label2 = New Label()
        cboMateria = New ComboBox()
        Label3 = New Label()
        btnEvaluar = New Button()
        btnLimpiar = New Button()
        btnEstastisticas = New Button()
        btnReiniciar = New Button()
        Panel1 = New Panel()
        lblMotivacion = New Label()
        lblMensaje = New Label()
        lblResultado = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        lblMayorMenor = New Label()
        lblPromedio = New Label()
        lblContador = New Label()
        Label6 = New Label()
        txtNota = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        CheckBox1 = New CheckBox()
        RadioButton1 = New RadioButton()
        ProgressBar1 = New ProgressBar()
        ListView1 = New ListView()
        NumericUpDown1 = New NumericUpDown()
        RichTextBox1 = New RichTextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(100, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 27)
        Label1.TabIndex = 0
        Label1.Text = "SISTEMA DE CALIFICACIONES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 20)
        Label2.TabIndex = 1
        Label2.Text = "Ingresa tu nota ( 0-100):"
        ' 
        ' cboMateria
        ' 
        cboMateria.FormattingEnabled = True
        cboMateria.Location = New Point(24, 141)
        cboMateria.Name = "cboMateria"
        cboMateria.Size = New Size(487, 28)
        cboMateria.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 3
        Label3.Text = "Opciones"
        ' 
        ' btnEvaluar
        ' 
        btnEvaluar.Location = New Point(24, 195)
        btnEvaluar.Name = "btnEvaluar"
        btnEvaluar.Size = New Size(155, 36)
        btnEvaluar.TabIndex = 4
        btnEvaluar.Text = "Evaluar nota"
        btnEvaluar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(185, 195)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(160, 36)
        btnLimpiar.TabIndex = 5
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEstastisticas
        ' 
        btnEstastisticas.Location = New Point(351, 195)
        btnEstastisticas.Name = "btnEstastisticas"
        btnEstastisticas.Size = New Size(160, 36)
        btnEstastisticas.TabIndex = 6
        btnEstastisticas.Text = "Ver Estadísticas"
        btnEstastisticas.UseVisualStyleBackColor = True
        ' 
        ' btnReiniciar
        ' 
        btnReiniciar.Location = New Point(24, 237)
        btnReiniciar.Name = "btnReiniciar"
        btnReiniciar.Size = New Size(487, 35)
        btnReiniciar.TabIndex = 7
        btnReiniciar.Text = "Reinicar Todo"
        btnReiniciar.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.InactiveBorder
        Panel1.Controls.Add(lblMotivacion)
        Panel1.Controls.Add(lblMensaje)
        Panel1.Controls.Add(lblResultado)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(29, 301)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(482, 152)
        Panel1.TabIndex = 8
        ' 
        ' lblMotivacion
        ' 
        lblMotivacion.AutoSize = True
        lblMotivacion.Location = New Point(20, 113)
        lblMotivacion.Name = "lblMotivacion"
        lblMotivacion.Size = New Size(74, 20)
        lblMotivacion.TabIndex = 4
        lblMotivacion.Text = "Pendiente"
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoSize = True
        lblMensaje.Location = New Point(20, 56)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(86, 20)
        lblMensaje.TabIndex = 3
        lblMensaje.Text = "PENDIENTE"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(101, 19)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(72, 20)
        lblResultado.TabIndex = 1
        lblResultado.Text = "Excelente"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 20)
        Label4.TabIndex = 0
        Label4.Text = "Resultado"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(lblMayorMenor)
        Panel2.Controls.Add(lblPromedio)
        Panel2.Controls.Add(lblContador)
        Panel2.Location = New Point(29, 459)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(482, 139)
        Panel2.TabIndex = 9
        ' 
        ' lblMayorMenor
        ' 
        lblMayorMenor.AutoSize = True
        lblMayorMenor.Location = New Point(20, 107)
        lblMayorMenor.Name = "lblMayorMenor"
        lblMayorMenor.Size = New Size(54, 20)
        lblMayorMenor.TabIndex = 2
        lblMayorMenor.Text = "Mayor:"
        ' 
        ' lblPromedio
        ' 
        lblPromedio.AutoSize = True
        lblPromedio.Location = New Point(20, 66)
        lblPromedio.Name = "lblPromedio"
        lblPromedio.Size = New Size(74, 20)
        lblPromedio.TabIndex = 1
        lblPromedio.Text = "Promedio"
        ' 
        ' lblContador
        ' 
        lblContador.AutoSize = True
        lblContador.Location = New Point(20, 27)
        lblContador.Name = "lblContador"
        lblContador.Size = New Size(94, 20)
        lblContador.TabIndex = 0
        lblContador.Text = "Evaluaciones"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 117)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 20)
        Label6.TabIndex = 10
        Label6.Text = "Materia"
        ' 
        ' txtNota
        ' 
        txtNota.Location = New Point(24, 87)
        txtNota.Name = "txtNota"
        txtNota.Size = New Size(487, 27)
        txtNota.TabIndex = 11
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(645, 110)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 12
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(645, 168)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(645, 224)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(121, 24)
        RadioButton1.TabIndex = 14
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(645, 273)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(125, 29)
        ProgressBar1.TabIndex = 15
        ' 
        ' ListView1
        ' 
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "ListViewGroup"
        ListViewGroup3.Name = "ListViewGroup3"
        ListView1.Groups.AddRange(New ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        ListView1.Location = New Point(634, 343)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(151, 121)
        ListView1.TabIndex = 16
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(834, 270)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 27)
        NumericUpDown1.TabIndex = 17
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(819, 344)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(125, 120)
        RichTextBox1.TabIndex = 18
        RichTextBox1.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1117, 631)
        Controls.Add(RichTextBox1)
        Controls.Add(NumericUpDown1)
        Controls.Add(ListView1)
        Controls.Add(ProgressBar1)
        Controls.Add(RadioButton1)
        Controls.Add(CheckBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtNota)
        Controls.Add(Label6)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnReiniciar)
        Controls.Add(btnEstastisticas)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEvaluar)
        Controls.Add(Label3)
        Controls.Add(cboMateria)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboMateria As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEvaluar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEstastisticas As Button
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMensaje As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMayorMenor As Label
    Friend WithEvents lblPromedio As Label
    Friend WithEvents lblContador As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNota As TextBox
    Friend WithEvents lblMotivacion As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ListView1 As ListView
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents RichTextBox1 As RichTextBox

End Class
