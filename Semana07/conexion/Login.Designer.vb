<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        txtUsuario = New TextBox()
        txtContrasena = New TextBox()
        btnIngresar = New Button()
        btnRegrear = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(24, 39)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(251, 27)
        txtUsuario.TabIndex = 0
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(24, 94)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(251, 27)
        txtContrasena.TabIndex = 1
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Location = New Point(24, 153)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(251, 29)
        btnIngresar.TabIndex = 2
        btnIngresar.Text = "Button1"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' btnRegrear
        ' 
        btnRegrear.Location = New Point(24, 188)
        btnRegrear.Name = "btnRegrear"
        btnRegrear.Size = New Size(251, 29)
        btnRegrear.TabIndex = 3
        btnRegrear.Text = "cerrar"
        btnRegrear.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 236)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(251, 123)
        DataGridView1.TabIndex = 4
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(302, 385)
        Controls.Add(DataGridView1)
        Controls.Add(btnRegrear)
        Controls.Add(btnIngresar)
        Controls.Add(txtContrasena)
        Controls.Add(txtUsuario)
        Name = "Login"
        Text = "Login"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnRegrear As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
