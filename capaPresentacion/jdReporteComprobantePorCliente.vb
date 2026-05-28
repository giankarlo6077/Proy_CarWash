Imports capaNegocio

Public Class jdReporteComprobantePorCliente
    Dim objReporte As New clsReporteComprobantePorCliente()

    Private Sub jdReporteComprobantePorCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDesde.Value = Today.AddMonths(-12)
        dtpHasta.Value = Today
        CargarDatos("")
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        CargarDatos(txtCliente.Text.Trim())
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCliente.Clear()
        dtpDesde.Value = Today.AddMonths(-12)
        dtpHasta.Value = Today
        txtCliente.Focus()
        CargarDatos("")
    End Sub

    Private Sub CargarDatos(clienteBuscado As String)
        If dtpHasta.Value.Date < dtpDesde.Value.Date Then
            MessageBox.Show("La fecha 'Hasta' no puede ser anterior a 'Desde'.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dt As DataTable = objReporte.ListarComprobantesPorCliente(
                dtpDesde.Value.Date, dtpHasta.Value.Date, clienteBuscado)

            If dt.Rows.Count > 0 Then
                dgvComprobantes.DataSource = dt
                For Each col As DataGridViewColumn In dgvComprobantes.Columns
                    If col.Name = "Total S/." Then
                        col.DefaultCellStyle.Format = "N2"
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If
                    If col.Name = "Fecha Emisión" Then
                        col.DefaultCellStyle.Format = "dd/MM/yyyy"
                    End If
                Next
                ActualizarResumen(dt)
            Else
                dgvComprobantes.DataSource = Nothing
                lblResumen.Text = "Sin resultados"
                MessageBox.Show("No se encontraron comprobantes en el rango seleccionado.", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message, "Error del Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarResumen(dt As DataTable)
        Dim total As Decimal = 0
        Dim colIdx As Integer = dt.Columns.IndexOf("Total S/.")
        If colIdx >= 0 Then
            For Each row As DataRow In dt.Rows
                If Not IsDBNull(row(colIdx)) Then
                    total += Convert.ToDecimal(row(colIdx))
                End If
            Next
        End If
        lblResumen.Text = String.Format("Total registros: {0}   |   Monto total: S/. {1:N2}", dt.Rows.Count, total)
    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnGenerar.PerformClick()
        End If
    End Sub
End Class
