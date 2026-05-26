Imports capaNegocio

Public Class jdMantenimientoCitas
    Dim objCita As New clsCita
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvGestion.DataSource = objCita.buscarporID(CInt(txtID.Text))
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        dgvGestion.DataSource = objCita.buscarporEstado(cmbEstado.SelectedItem.ToString())
    End Sub

    Private Sub btnNuevaCita_Click(sender As Object, e As EventArgs) Handles btnNuevaCita.Click
        Dim objFrmGestionarCita As New jdGestionarCitas
        objFrmGestionarCita.ShowDialog()
    End Sub
End Class