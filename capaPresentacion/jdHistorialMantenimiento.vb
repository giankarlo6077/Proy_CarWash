Imports capaNegocio
Public Class jdHistorialMantenimiento
    Dim objCita As New clsCita
    Dim dtProducto As New DataTable

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            dtProducto = objCita.listarHistorialCitasMantenimientoporDocumento(txtDocumento.Text)

            dgvMantenimientos.DataSource = dtProducto

        Catch ex As Exception
            MsgBox("Ingresar el nro Documento correcto" & ex.Message)
        End Try
    End Sub

End Class