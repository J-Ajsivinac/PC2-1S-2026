Module ModPeliculasUI
    Public Sub SeleccionarEnCombo(cmb As ComboBox, texto As String)
        ' Busca el texto en el ComboBox y selecciona el índice correspondiente
        For i As Integer = 0 To cmb.Items.Count - 1
            ' Nota: Asegúrate de que el texto en el ComboBox coincida exactamente con el texto que estás buscando (incluyendo mayúsculas, espacios, etc.)
            If cmb.Items(i).ToString() = texto Then
                ' Si encontramos el texto, seleccionamos ese índice
                cmb.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Public Function ValidarCampos(txtNombre As TextBox, cmbGenero As ComboBox, cmbDirector As ComboBox) As Boolean
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MostrarError(txtNombre.FindForm(), "El nombre de la película es obligatorio.")
            txtNombre.Focus()
            Return False
        End If

        If cmbGenero.SelectedIndex <= 0 Then
            MostrarError(cmbGenero.FindForm(), "Debes seleccionar un género.")
            cmbGenero.Focus()
            Return False
        End If

        If cmbDirector.SelectedIndex <= 0 Then
            MostrarError(cmbDirector.FindForm(), "Debes seleccionar un director.")
            cmbDirector.Focus()
            Return False
        End If

        Return True
    End Function


    Public Sub ModoNuevo(frm As FrmPeliculas)
        frm.btnGuardar.Enabled = True
        frm.btnEditar.Enabled = False
        frm.btnEliminar.Enabled = False
    End Sub

    Public Sub MostrarError(frm As Form, mensaje As String)
        Dim lbl As Label = CType(frm.Controls("lblMensaje"), Label)
        lbl.ForeColor = Color.Red
        lbl.Text = "-" & mensaje
    End Sub

    Public Sub MostrarExito(frm As Form, mensaje As String)
        Dim lbl As Label = CType(frm.Controls("lblMensaje"), Label)
        lbl.ForeColor = Color.Green
        lbl.Text = "✅" & mensaje
    End Sub

    Public Sub LimpiarCampos(frm As FrmPeliculas)
        frm.txtNombre.Clear()
        frm.nudMinutos.Value = frm.nudMinutos.Minimum
        frm.cmbGenero.SelectedIndex = 0
        frm.cmbDirector.SelectedIndex = 0
        frm.lblMensaje.Text = ""
        frm._codigoPeliculaSeleccionada = 0

        ModoNuevo(frm)
        frm.txtNombre.Focus()
    End Sub
End Module
