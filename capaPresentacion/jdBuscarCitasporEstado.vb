Imports capaNegocio

Public Class jdBuscarCitasporEstado
    Dim objCita As New clsCita

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        dgvGestion.DataSource = objCita.buscarporEstado(cmbEstado.SelectedItem.ToString())
    End Sub

    Private Sub btnNuevaCita_Click(sender As Object, e As EventArgs) Handles btnNuevaCita.Click
        Dim objFrmGestionarCita As New jdGestionarCitas
        objFrmGestionarCita.ShowDialog()
    End Sub
End Class