Imports capaNegocio
Public Class jdGestionarCitas
    Dim objCita As New clsCita
    Private selectedIdCita As Integer = -1

    Private Sub jdGestionarCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbTrabajador.DataSource = objCita.listarTrabajadores
            cmbTrabajador.DisplayMember = "trabajador"
            cmbTrabajador.ValueMember = "idTrabajador"
            lblFecha.Text = DateString
            lblHora.Text = TimeString
            dgvCitas.DataSource = objCita.listarCitas
            btnGenerarComprobante.Enabled = False
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
            selectedIdCita = CInt(dgvCitas.Rows(e.RowIndex).Cells("idCita").Value)
            Try
                btnGenerarComprobante.Enabled = objCita.citaTieneServiciosYProductos(selectedIdCita)
            Catch
                btnGenerarComprobante.Enabled = False
            End Try
        Else
            selectedIdCita = -1
            btnGenerarComprobante.Enabled = False
        End If
    End Sub

    Private Sub dgvCitas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim idCita As Integer = CInt(dgvCitas.Rows(e.RowIndex).Cells("idCita").Value)
            Dim frmDetalle As New JdDetalleOrdenTrabajo(idCita)
            frmDetalle.ShowDialog()
            dgvCitas.DataSource = objCita.listarCitas()
            selectedIdCita = -1
            btnGenerarComprobante.Enabled = False
        End If
    End Sub

    Private Function seleccionarTipoComprobante() As String
        Dim dlg As New Form()
        dlg.Text = "Tipo de Comprobante"
        dlg.Size = New System.Drawing.Size(320, 160)
        dlg.StartPosition = FormStartPosition.CenterParent
        dlg.FormBorderStyle = FormBorderStyle.FixedDialog
        dlg.MaximizeBox = False
        dlg.MinimizeBox = False

        Dim lbl As New Label()
        lbl.Text = "¿Qué tipo de comprobante desea generar?"
        lbl.Location = New System.Drawing.Point(15, 18)
        lbl.Size = New System.Drawing.Size(280, 32)
        lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        dlg.Controls.Add(lbl)

        Dim btnBoleta As New Button()
        btnBoleta.Text = "Boleta"
        btnBoleta.DialogResult = DialogResult.Yes
        btnBoleta.Location = New System.Drawing.Point(30, 65)
        btnBoleta.Size = New System.Drawing.Size(110, 40)
        btnBoleta.BackColor = System.Drawing.Color.FromArgb(0, 0, 64)
        btnBoleta.ForeColor = System.Drawing.Color.White
        btnBoleta.Font = New System.Drawing.Font("Verdana", 9, System.Drawing.FontStyle.Bold)
        btnBoleta.UseVisualStyleBackColor = False
        dlg.Controls.Add(btnBoleta)

        Dim btnFactura As New Button()
        btnFactura.Text = "Factura"
        btnFactura.DialogResult = DialogResult.No
        btnFactura.Location = New System.Drawing.Point(175, 65)
        btnFactura.Size = New System.Drawing.Size(110, 40)
        btnFactura.BackColor = System.Drawing.Color.FromArgb(0, 0, 64)
        btnFactura.ForeColor = System.Drawing.Color.White
        btnFactura.Font = New System.Drawing.Font("Verdana", 9, System.Drawing.FontStyle.Bold)
        btnFactura.UseVisualStyleBackColor = False
        dlg.Controls.Add(btnFactura)

        Dim resultado As DialogResult = dlg.ShowDialog(Me)
        dlg.Dispose()

        Select Case resultado
            Case DialogResult.Yes
                Return "Boleta"
            Case DialogResult.No
                Return "Factura"
            Case Else
                Return ""
        End Select
    End Function

    Private Sub btnGenerarComprobante_Click(sender As Object, e As EventArgs) Handles btnGenerarComprobante.Click
        If selectedIdCita < 0 Then Return

        Dim tipoComp As String = seleccionarTipoComprobante()
        If String.IsNullOrEmpty(tipoComp) Then Return

        Try
            Dim datosCita As DataRow = objCita.cargarDatosCita(selectedIdCita)
            If datosCita Is Nothing Then
                MessageBox.Show("No se pudo obtener los datos de la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim clienteNombre As String = datosCita("cliente").ToString()
            Dim trabajadorNombre As String = datosCita("trabajador").ToString()

            Dim objCliente As New clsCliente()
            Dim dniRuc As String = ""
            Try
                dniRuc = objCliente.obtenerNumeroDocumento(clienteNombre)
            Catch
                dniRuc = ""
            End Try

            Dim detalles As List(Of Object()) = objCita.obtenerDetallesComprobanteCita(selectedIdCita)

            Dim frmComprobante As New ComprobanteVenta()
            frmComprobante.CargarVenta(
                clienteNombre,
                dniRuc,
                trabajadorNombre,
                detalles,
                tipoComp,
                "",
                selectedIdCita.ToString(),
                "Cita"
            )
            frmComprobante.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error al generar comprobante: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
