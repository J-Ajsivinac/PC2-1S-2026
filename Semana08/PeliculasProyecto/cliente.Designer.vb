<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cliente
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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(81, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 0
        Label1.Text = "Hola Cliente"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(62, 123)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(127, 42)
        btnCerrar.TabIndex = 1
        btnCerrar.Text = "Cerrar Sesión"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(92, 71)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(61, 20)
        lblNombre.TabIndex = 2
        lblNombre.Text = "nombre"
        ' 
        ' cliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(280, 236)
        Controls.Add(lblNombre)
        Controls.Add(btnCerrar)
        Controls.Add(Label1)
        Name = "cliente"
        Text = "cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblNombre As Label
End Class
