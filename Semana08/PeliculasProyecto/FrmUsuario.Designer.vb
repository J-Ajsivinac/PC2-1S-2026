<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        lblBienvenida = New Label()
        btnRegrear = New Button()
        txtBuscar = New TextBox()
        dgvPeliculas = New DataGridView()
        lblDetalle = New Label()
        btnBuscar = New Button()
        CType(dgvPeliculas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblBienvenida
        ' 
        lblBienvenida.AutoSize = True
        lblBienvenida.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBienvenida.Location = New Point(12, 21)
        lblBienvenida.Name = "lblBienvenida"
        lblBienvenida.Size = New Size(100, 20)
        lblBienvenida.TabIndex = 0
        lblBienvenida.Text = "Bienvenido/a"
        ' 
        ' btnRegrear
        ' 
        btnRegrear.BackColor = Color.FromArgb(CByte(138), CByte(44), CByte(44))
        btnRegrear.FlatStyle = FlatStyle.Flat
        btnRegrear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegrear.ForeColor = SystemColors.Control
        btnRegrear.Location = New Point(482, 13)
        btnRegrear.Name = "btnRegrear"
        btnRegrear.Size = New Size(130, 37)
        btnRegrear.TabIndex = 1
        btnRegrear.Text = "Regresar"
        btnRegrear.UseVisualStyleBackColor = False
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(12, 65)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(464, 27)
        txtBuscar.TabIndex = 2
        ' 
        ' dgvPeliculas
        ' 
        dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPeliculas.Location = New Point(12, 110)
        dgvPeliculas.Name = "dgvPeliculas"
        dgvPeliculas.RowHeadersWidth = 51
        dgvPeliculas.Size = New Size(600, 343)
        dgvPeliculas.TabIndex = 3
        ' 
        ' lblDetalle
        ' 
        lblDetalle.AutoSize = True
        lblDetalle.Location = New Point(14, 472)
        lblDetalle.Name = "lblDetalle"
        lblDetalle.Size = New Size(89, 20)
        lblDetalle.TabIndex = 4
        lblDetalle.Text = "Información"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(44), CByte(92), CByte(138))
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = SystemColors.ButtonHighlight
        btnBuscar.Location = New Point(482, 65)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(130, 29)
        btnBuscar.TabIndex = 5
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' FrmUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(627, 517)
        Controls.Add(btnBuscar)
        Controls.Add(lblDetalle)
        Controls.Add(dgvPeliculas)
        Controls.Add(txtBuscar)
        Controls.Add(btnRegrear)
        Controls.Add(lblBienvenida)
        Name = "FrmUsuario"
        Text = "FrmUsuario"
        CType(dgvPeliculas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBienvenida As Label
    Friend WithEvents btnRegrear As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvPeliculas As DataGridView
    Friend WithEvents lblDetalle As Label
    Friend WithEvents btnBuscar As Button
End Class
