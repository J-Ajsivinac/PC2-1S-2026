Public Class Form1
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim query As String = "SELECT * FROM Usuarios"
        Dim tabla As DataTable = ModDatos.ObtenerDatos(query)

        If tabla IsNot Nothing Then
            DataGridView1.DataSource = tabla
            lblEstado.Text = $"{tabla.Rows.Count} registros cargados"
            lblEstado.ForeColor = Color.MediumTurquoise
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModConexion.ProbarConexion() Then
            lblEstado.Text = "Conectado"
            lblEstado.ForeColor = Color.Green
        Else
            lblEstado.Text = "Sin conexión"
            lblEstado.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim loginForm As New Login()
        loginForm.ShowDialog()

    End Sub
End Class
