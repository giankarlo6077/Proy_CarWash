Imports capaNegocio
Public Class jdGestionarCitas
    Dim objCita As New clsCita
    Private Sub jdGestionarCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbVehiculo.DataSource = objCita.listarVehiculos
            cmbVehiculo.DisplayMember = "placa"
            cmbVehiculo.ValueMember = "idVehiculo"
            cmbTrabajador.DataSource = objCita.listarTrabajadores
            cmbTrabajador.DisplayMember = "trabajador"
            cmbTrabajador.ValueMember = "idTrabajador"
            lblFecha.Text = DateString
            lblHora.Text = TimeString
            dgvCitas.DataSource = objCita.listarCitas
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbVehiculo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbVehiculo.SelectionChangeCommitted
        Try
            lblNombreCliente.Text = DirectCast(cmbVehiculo.SelectedItem, DataRowView)("Persona").ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerarCita_Click(sender As Object, e As EventArgs) Handles btnGenerarCita.Click
        Try
            If btnGenerarCita.Text = "Generar Cita" Then 'Generar idCita
                btnGenerarCita.Text = "Registrar Cita"
            Else 'Guardar empleado
                btnGenerarCita.Text = "Generar Cita"
                Dim fecha As Date = Date.ParseExact(lblFecha.Text, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture)
                Dim hora As Date = Date.ParseExact(lblHora.Text, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)

                objCita.registrarCita(
                                        CInt(objCita.generarCodigoCita),
                                        fecha,
                                        hora,
                                        txtComentario.Text,
                                        dtpFechaRecojo.Value,
                                        CInt(cmbVehiculo.SelectedValue),
                                        CInt(cmbTrabajador.SelectedValue)
                                    )
                dgvCitas.DataSource = objCita.listarCitas
                'limpiarControles()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellClick
        If e.RowIndex >= 0 Then
            Dim idCita As Integer = CInt(dgvCitas.Rows(e.RowIndex).Cells("idCita").Value)
            Dim frmDetalle As New JdDetalleOrdenTrabajo(idCita)
            frmDetalle.ShowDialog()

        End If
    End Sub

End Class