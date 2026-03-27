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
        Panel1 = New Panel()
        prgCargando = New ProgressBar()
        lblMensaje = New Label()
        btnLimpiar = New Button()
        btnLogin = New Button()
        chkMostrar = New CheckBox()
        txtContrasenia = New TextBox()
        Label4 = New Label()
        txtUsuario = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(prgCargando)
        Panel1.Controls.Add(lblMensaje)
        Panel1.Controls.Add(btnLimpiar)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(chkMostrar)
        Panel1.Controls.Add(txtContrasenia)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtUsuario)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(12, 84)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(426, 401)
        Panel1.TabIndex = 0
        ' 
        ' prgCargando
        ' 
        prgCargando.Location = New Point(17, 369)
        prgCargando.Name = "prgCargando"
        prgCargando.Size = New Size(391, 29)
        prgCargando.TabIndex = 8
        prgCargando.Visible = False
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoSize = True
        lblMensaje.Location = New Point(17, 329)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(0, 20)
        lblMensaje.TabIndex = 7
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(17, 259)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(391, 36)
        btnLimpiar.TabIndex = 6
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(107))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(17, 215)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(391, 38)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Iniciar Sesión"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' chkMostrar
        ' 
        chkMostrar.AutoSize = True
        chkMostrar.Location = New Point(23, 175)
        chkMostrar.Name = "chkMostrar"
        chkMostrar.Size = New Size(160, 24)
        chkMostrar.TabIndex = 4
        chkMostrar.Text = "Mostrar Contraseña"
        chkMostrar.UseVisualStyleBackColor = True
        ' 
        ' txtContrasenia
        ' 
        txtContrasenia.Location = New Point(17, 121)
        txtContrasenia.Name = "txtContrasenia"
        txtContrasenia.Size = New Size(391, 27)
        txtContrasenia.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 2
        Label4.Text = "Contraseña"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(17, 52)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(391, 27)
        txtUsuario.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 20)
        Label3.TabIndex = 0
        Label3.Text = "Usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(170, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 1
        Label1.Text = "MovieStore"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(125, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(191, 20)
        Label2.TabIndex = 2
        Label2.Text = "Inicia Sesión para continuar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 517)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents prgCargando As ProgressBar
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents chkMostrar As CheckBox
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents Label4 As Label

End Class
