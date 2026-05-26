Imports capaNegocio
Public Class jdGestionarCitas
    Dim objCita As New clsCita
    Private Sub jdGestionarCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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

    Private Sub btnGenerarCita_Click(sender As Object, e As EventArgs) Handles btnGenerarCita.Click
        Try
            If btnGenerarCita.Text = "Generar Cita" Then
                btnGenerarCita.Text = "Registrar Cita"
            Else
                btnGenerarCita.Text = "Generar Cita"
                Dim fecha As Date = Date.ParseExact(lblFecha.Text, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture)
                Dim hora As Date = Date.ParseExact(lblHora.Text, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)

                objCita.registrarCita(
                                        CInt(objCita.generarCodigoCita),
                                        fecha,
                                        hora,
                                        txtComentario.Text,
                                        dtpFechaRecojo.Value,
                                        objCita.buscarIDVehporPlaca(txtPlaca.Text),
                                        CInt(cmbTrabajador.SelectedValue)
                                    )
                dgvCitas.DataSource = objCita.listarCitas
                limpiarControles()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub limpiarControles()
        txtPlaca.Clear()
        txtComentario.Clear()
        lblNombreCliente.Text = ""
    End Sub

    Private Sub dgvCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellClick
        If e.RowIndex >= 0 Then
            Dim idCita As Integer = CInt(dgvCitas.Rows(e.RowIndex).Cells("idCita").Value)
            Dim frmDetalle As New JdDetalleOrdenTrabajo(idCita)
            frmDetalle.ShowDialog()
            dgvCitas.DataSource = objCita.listarCitas()
        End If
    End Sub

    Private Sub btnBuscarVehic_Click(sender As Object, e As EventArgs) Handles btnBuscarVehic.Click
        If txtPlaca.Text.Trim() = "" Then
            MessageBox.Show("Completar el campo por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nombre As String = objCita.buscarPersonaPorPlaca(txtPlaca.Text.Trim())

        If nombre = "" Then
            MessageBox.Show("No se encontró ningún cliente con esa placa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            lblNombreCliente.Text = nombre
        End If
    End Sub

End Class