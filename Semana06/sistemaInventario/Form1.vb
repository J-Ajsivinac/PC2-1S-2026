Public Class Form1

    Private productNames() As String
    Private inventory(,) As Double
    Private numProducts As Integer
    Private numAttributes As Integer

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim reportes As New Reportes()
        reportes.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbNumAttributes.Items.AddRange({"2", "3", "4"})
        cmbNumAttributes.SelectedIndex = 1 ' Defecto a 3 atributos
        rdbManualLoad.Checked = True
    End Sub

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Try
            numProducts = Integer.Parse(txtNumProducts.Text)
            numAttributes = Integer.Parse(cmbNumAttributes.SelectedItem.ToString())  ' De ComboBox

            If numProducts <= 0 Or numAttributes <= 0 Then Throw New ArgumentException("Números positivos requeridos.")

            If rdbDemoLoad.Checked Then
                productNames = {"Laptop", "Mouse", "Teclado"}
                numProducts = 3
                ' Ajusta numAttributes si es necesario
                ReDim inventory(2, numAttributes - 1)

                Dim demoData() As Double = {10, 500, 400, 20, 50, 40, 15, 100, 8} ' Para 3 attrs
                Dim idx As Integer = 0
                For i As Integer = 0 To 2
                    For j As Integer = 0 To numAttributes - 1
                        inventory(i, j) = demoData(idx)
                        idx += 1
                    Next
                Next
            Else
                productNames = txtProductNames.Text.Split(","c).Select(Function(s) s.Trim()).ToArray()
                If productNames.Length <> numProducts Then Throw New Exception("Nombres no coinciden.")

                ReDim inventory(numProducts - 1, numAttributes - 1)
                Dim rows() As String = txtInventoryData.Text.Split(";"c)
                If rows.Length <> numProducts Then Throw New Exception("Filas no coinciden.")

                For i As Integer = 0 To numProducts - 1
                    Dim cols() As String = rows(i).Split(","c)
                    If cols.Length <> numAttributes Then Throw New Exception("Columnas en fila " & (i + 1) & " no coinciden.")
                    For j As Integer = 0 To numAttributes - 1
                        inventory(i, j) = Double.Parse(cols(j).Trim())
                        If inventory(i, j) < 0 Then Throw New Exception("Valor negativo en (" & i & "," & j & ").")
                    Next
                Next

                txtNumProducts.Clear()
                txtProductNames.Clear()
                txtInventoryData.Clear()
            End If

            lstProducts.Items.Clear()

            For Each name As String In productNames
                lstProducts.Items.Add(name)
            Next

            dgvInventory.Rows.Clear()
            dgvInventory.ColumnCount = numAttributes + 1

            For i As Integer = 0 To numProducts - 1   ' For de Filas
                dgvInventory.Rows.Add()
                For j As Integer = 0 To numAttributes   ' For de Columnas
                    'dgvInventory.Rows(i).Cells(j).Value = inventory(i, j)
                    If j = 0 Then
                        dgvInventory.Rows(i).Cells(j).Value = productNames(i)
                    Else
                        dgvInventory.Rows(i).Cells(j).Value = inventory(i, j - 1)
                    End If
                Next
            Next

            MessageBox.Show("Datos cargados.")

        Catch ex As FormatException
            ' Atrapa errores de formato (por ejemplo, si el usuario ingresa texto en lugar de números)
            MessageBox.Show("Formato inválido.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
