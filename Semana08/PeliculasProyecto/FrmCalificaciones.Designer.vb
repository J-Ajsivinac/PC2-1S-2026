<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalificaciones
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
        cmbPelicula = New ComboBox()
        Label2 = New Label()
        nudCalificacion = New NumericUpDown()
        lblPromedio = New Label()
        Label3 = New Label()
        txtComentario = New TextBox()
        btnGuardar = New Button()
        btnLimpiar = New Button()
        lblMensaje = New Label()
        Label4 = New Label()
        dgvComentarios = New DataGridView()
        btnRegresar = New Button()
        chkFavorito = New CheckBox()
        CType(nudCalificacion, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvComentarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 0
        Label1.Text = "Película"
        ' 
        ' cmbPelicula
        ' 
        cmbPelicula.FormattingEnabled = True
        cmbPelicula.Location = New Point(17, 42)
        cmbPelicula.Name = "cmbPelicula"
        cmbPelicula.Size = New Size(250, 28)
        cmbPelicula.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(287, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 2
        Label2.Text = "Calificación"
        ' 
        ' nudCalificacion
        ' 
        nudCalificacion.Location = New Point(287, 42)
        nudCalificacion.Name = "nudCalificacion"
        nudCalificacion.Size = New Size(256, 27)
        nudCalificacion.TabIndex = 3
        ' 
        ' lblPromedio
        ' 
        lblPromedio.AutoSize = True
        lblPromedio.Location = New Point(17, 83)
        lblPromedio.Name = "lblPromedio"
        lblPromedio.Size = New Size(74, 20)
        lblPromedio.TabIndex = 4
        lblPromedio.Text = "Pendiente"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 5
        Label3.Text = "Comentario"
        ' 
        ' txtComentario
        ' 
        txtComentario.Location = New Point(17, 146)
        txtComentario.Multiline = True
        txtComentario.Name = "txtComentario"
        txtComentario.PlaceholderText = "Escibe aquí tu opinión sobre la película"
        txtComentario.Size = New Size(526, 179)
        txtComentario.TabIndex = 6
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(26), CByte(106), CByte(58))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.ForeColor = SystemColors.ButtonHighlight
        btnGuardar.Location = New Point(17, 375)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(154, 42)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar Reseña"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Location = New Point(187, 375)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(107, 42)
        btnLimpiar.TabIndex = 8
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoSize = True
        lblMensaje.Location = New Point(17, 430)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(74, 20)
        lblMensaje.TabIndex = 9
        lblMensaje.Text = "Pendiente"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 488)
        Label4.Name = "Label4"
        Label4.Size = New Size(212, 20)
        Label4.TabIndex = 10
        Label4.Text = "Comentarios de Otros usuarios"
        ' 
        ' dgvComentarios
        ' 
        dgvComentarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvComentarios.Location = New Point(17, 522)
        dgvComentarios.Name = "dgvComentarios"
        dgvComentarios.ReadOnly = True
        dgvComentarios.RowHeadersWidth = 51
        dgvComentarios.Size = New Size(526, 188)
        dgvComentarios.TabIndex = 11
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(383, 718)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(160, 39)
        btnRegresar.TabIndex = 12
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' chkFavorito
        ' 
        chkFavorito.AutoSize = True
        chkFavorito.Location = New Point(459, 331)
        chkFavorito.Name = "chkFavorito"
        chkFavorito.Size = New Size(84, 24)
        chkFavorito.TabIndex = 13
        chkFavorito.Text = "Favorito"
        chkFavorito.UseVisualStyleBackColor = True
        ' 
        ' FrmCalificaciones
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(563, 806)
        Controls.Add(chkFavorito)
        Controls.Add(btnRegresar)
        Controls.Add(dgvComentarios)
        Controls.Add(Label4)
        Controls.Add(lblMensaje)
        Controls.Add(btnLimpiar)
        Controls.Add(btnGuardar)
        Controls.Add(txtComentario)
        Controls.Add(Label3)
        Controls.Add(lblPromedio)
        Controls.Add(nudCalificacion)
        Controls.Add(Label2)
        Controls.Add(cmbPelicula)
        Controls.Add(Label1)
        Name = "FrmCalificaciones"
        Text = "FrmCalificaciones"
        CType(nudCalificacion, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvComentarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPelicula As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudCalificacion As NumericUpDown
    Friend WithEvents lblPromedio As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvComentarios As DataGridView
    Friend WithEvents btnRegresar As Button
    Friend WithEvents chkFavorito As CheckBox
End Class
