<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        btnRegresar = New Button()
        SuspendLayout()
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 428)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(181, 33)
        btnRegresar.TabIndex = 0
        btnRegresar.Text = "Volver al Inicio"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' Reportes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(662, 473)
        Controls.Add(btnRegresar)
        Name = "Reportes"
        Text = "Reportes"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnRegresar As Button
End Class
