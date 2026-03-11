Public Class Reportes
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub
End Class