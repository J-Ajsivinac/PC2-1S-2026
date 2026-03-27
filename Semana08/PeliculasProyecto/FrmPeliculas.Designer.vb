<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeliculas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtNombre = New TextBox()
        cmbGenero = New ComboBox()
        cmbDirector = New ComboBox()
        nudMinutos = New NumericUpDown()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        lblMensaje = New Label()
        dgvPeliculas = New DataGridView()
        btnRegresar = New Button()
        CType(nudMinutos, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPeliculas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 0
        Label1.Text = "NOMBRE"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(22, 41)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(266, 27)
        txtNombre.TabIndex = 1
        ' 
        ' cmbGenero
        ' 
        cmbGenero.FormattingEnabled = True
        cmbGenero.Location = New Point(22, 108)
        cmbGenero.Name = "cmbGenero"
        cmbGenero.Size = New Size(266, 28)
        cmbGenero.TabIndex = 2
        ' 
        ' cmbDirector
        ' 
        cmbDirector.FormattingEnabled = True
        cmbDirector.Location = New Point(331, 108)
        cmbDirector.Name = "cmbDirector"
        cmbDirector.Size = New Size(338, 28)
        cmbDirector.TabIndex = 3
        ' 
        ' nudMinutos
        ' 
        nudMinutos.Location = New Point(331, 42)
        nudMinutos.Name = "nudMinutos"
        nudMinutos.Size = New Size(338, 27)
        nudMinutos.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(331, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 20)
        Label2.TabIndex = 6
        Label2.Text = "MINTUOS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(328, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 8
        Label4.Text = "DIRECTOR"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 20)
        Label5.TabIndex = 9
        Label5.Text = "GÉNERO"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(44), CByte(122), CByte(58))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.ForeColor = SystemColors.ButtonHighlight
        btnGuardar.Location = New Point(22, 155)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(121, 40)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(138), CByte(163), CByte(190))
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.ForeColor = SystemColors.ButtonHighlight
        btnEditar.Location = New Point(149, 155)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(121, 40)
        btnEditar.TabIndex = 11
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(185), CByte(140), CByte(140))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.ForeColor = SystemColors.ButtonHighlight
        btnEliminar.Location = New Point(276, 155)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(121, 40)
        btnEliminar.TabIndex = 12
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = SystemColors.ButtonHighlight
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Location = New Point(548, 155)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(121, 40)
        btnLimpiar.TabIndex = 13
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoSize = True
        lblMensaje.Location = New Point(22, 210)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(64, 20)
        lblMensaje.TabIndex = 14
        lblMensaje.Text = "mensaje"
        ' 
        ' dgvPeliculas
        ' 
        dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPeliculas.Location = New Point(22, 242)
        dgvPeliculas.Name = "dgvPeliculas"
        dgvPeliculas.RowHeadersWidth = 51
        dgvPeliculas.Size = New Size(647, 253)
        dgvPeliculas.TabIndex = 15
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(519, 513)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(150, 40)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' FrmPeliculas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(694, 565)
        Controls.Add(btnRegresar)
        Controls.Add(dgvPeliculas)
        Controls.Add(lblMensaje)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(nudMinutos)
        Controls.Add(cmbDirector)
        Controls.Add(cmbGenero)
        Controls.Add(txtNombre)
        Controls.Add(Label1)
        Name = "FrmPeliculas"
        Text = "FrmPeliculas"
        CType(nudMinutos, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPeliculas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents cmbDirector As ComboBox
    Friend WithEvents nudMinutos As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents dgvPeliculas As DataGridView
    Friend WithEvents btnRegresar As Button
End Class
