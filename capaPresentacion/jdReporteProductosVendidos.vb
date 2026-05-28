Imports capaNegocio

Public Class jdReporteProductosVendidos
    Dim objReporte As New clsReporteProducto()

    Private Sub jdReporteProductosVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDesde.Value = Today.AddMonths(-12)
        dtpHasta.Value = Today
        CargarDatos()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        CargarDatos()
    End Sub

    Private Sub CargarDatos()
        If dtpHasta.Value.Date < dtpDesde.Value.Date Then
            MessageBox.Show("La fecha 'Hasta' no puede ser anterior a 'Desde'.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dt As DataTable = objReporte.ListarMasVendidos(dtpDesde.Value.Date, dtpHasta.Value.Date, CInt(numTop.Value))
            If dt.Rows.Count > 0 Then
                dgvProductos.DataSource = dt
            Else
                dgvProductos.DataSource = Nothing
                MessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado.", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message, "Error del Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
