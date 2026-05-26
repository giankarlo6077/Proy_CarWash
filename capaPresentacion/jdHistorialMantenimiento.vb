Imports capaNegocio
Public Class jdHistorialMantenimiento
    Dim objCita As New clsCita
    Dim dtProducto As New DataTable

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            dtProducto = objCita.listarHistorialCitasMantenimientoporDocumento(txtDocumento.Text)

            dgvMantenimientos.DataSource = dtProducto

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Citas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class