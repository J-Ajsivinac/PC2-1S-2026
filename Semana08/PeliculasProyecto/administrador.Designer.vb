<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrador
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
        btnCerrar = New Button()
        lblNombre = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(4, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 20)
        Label1.TabIndex = 0
        Label1.Text = "Hola Administrador"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(389, 9)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(147, 34)
        btnCerrar.TabIndex = 1
        btnCerrar.Text = "Cerrar Sesión"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombre.Location = New Point(4, 29)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(64, 20)
        lblNombre.TabIndex = 2
        lblNombre.Text = "nombre"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(107))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(12, 70)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 118)
        Button1.TabIndex = 3
        Button1.Text = "Películas"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' administrador
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(548, 221)
        Controls.Add(Button1)
        Controls.Add(lblNombre)
        Controls.Add(btnCerrar)
        Controls.Add(Label1)
        Name = "administrador"
        Text = "administrador"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents Button1 As Button
End Class
