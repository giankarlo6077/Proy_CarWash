Imports capaNegocio
Public Class jdGestionarCitas
    Dim objCita As New clsCita
    Public Property trabajadorSesion As String = ""

    Private Sub jdGestionarCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbTrabajador.DataSource = objCita.listarTrabajadores
            cmbTrabajador.DisplayMember = "trabajador"
            cmbTrabajador.ValueMember = "idTrabajador"
            lblFecha.Text = DateString
            lblHora.Text = TimeString
            dgvCitas.DataSource = objCita.listarCitas
            btnGenComprobante.Enabled = False
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

    ' Doble clic abre el detalle/edición de la cita
    Private Sub dgvCitas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim idCita As Integer = CInt(dgvCitas.Rows(e.RowIndex).Cells("idCita").Value)
            Dim frmDetalle As New JdDetalleOrdenTrabajo(idCita)
            frmDetalle.ShowDialog()
            dgvCitas.DataSource = objCita.listarCitas()
            btnGenComprobante.Enabled = False
        End If
    End Sub

    ' Clic simple: evalúa si la cita seleccionada tiene productos Y servicios
    Private Sub dgvCitas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCitas.SelectionChanged
        btnGenComprobante.Enabled = False
        If dgvCitas.SelectedRows.Count = 0 Then Return
        Try
            Dim idCita As Integer = CInt(dgvCitas.SelectedRows(0).Cells("idCita").Value)
            Dim dtProductos As DataTable = objCita.cargarProductosdelaCita(idCita)
            Dim dtServicios As DataTable = objCita.cargarServiciosdelaCita(idCita)
            btnGenComprobante.Enabled = (dtProductos.Rows.Count > 0 AndAlso dtServicios.Rows.Count > 0)
        Catch
            btnGenComprobante.Enabled = False
        End Try
    End Sub

    Private Sub btnGenComprobante_Click(sender As Object, e As EventArgs) Handles btnGenComprobante.Click
        If dgvCitas.SelectedRows.Count = 0 Then Return

        Dim idCita As Integer = CInt(dgvCitas.SelectedRows(0).Cells("idCita").Value)

        ' Preguntar tipo de comprobante con botones claros
        Dim tipoComprobante As String = ""
        Using dlg As New Form()
            dlg.Text = "Tipo de Comprobante"
            dlg.Size = New Drawing.Size(320, 155)
            dlg.StartPosition = FormStartPosition.CenterParent
            dlg.FormBorderStyle = FormBorderStyle.FixedDialog
            dlg.MaximizeBox = False
            dlg.MinimizeBox = False

            Dim lbl As New Label() With {
                .Text = "¿Qué tipo de comprobante desea generar?",
                .Location = New Drawing.Point(10, 18),
                .Size = New Drawing.Size(292, 30),
                .TextAlign = Drawing.ContentAlignment.MiddleCenter
            }
            Dim btnBoleta As New Button() With {
                .Text = "Boleta",
                .Location = New Drawing.Point(50, 70),
                .Size = New Drawing.Size(90, 32),
                .DialogResult = DialogResult.Yes,
                .BackColor = Drawing.Color.FromArgb(0, 0, 64),
                .ForeColor = Drawing.Color.White,
                .FlatStyle = FlatStyle.Flat
            }
            Dim btnFactura As New Button() With {
                .Text = "Factura",
                .Location = New Drawing.Point(175, 70),
                .Size = New Drawing.Size(90, 32),
                .DialogResult = DialogResult.No,
                .BackColor = Drawing.Color.FromArgb(0, 0, 64),
                .ForeColor = Drawing.Color.White,
                .FlatStyle = FlatStyle.Flat
            }

            dlg.Controls.AddRange(New Control() {lbl, btnBoleta, btnFactura})

            Dim resultado As DialogResult = dlg.ShowDialog(Me)
            If resultado = DialogResult.Yes Then
                tipoComprobante = "Boleta"
            ElseIf resultado = DialogResult.No Then
                tipoComprobante = "Factura"
            Else
                Return
            End If
        End Using

        Try
            Dim datosCita As DataRow = objCita.cargarDatosCita(idCita)
            If datosCita Is Nothing Then
                MessageBox.Show("No se pudo cargar la información de la cita.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim nombreCliente As String = datosCita("cliente").ToString()
            Dim nombreTrabajador As String = datosCita("trabajador").ToString()

            Dim dniRuc As String = ""
            Try
                Dim objCliente As New clsCliente()
                dniRuc = objCliente.obtenerNumeroDocumento(nombreCliente)
            Catch
            End Try

            ' Armar lista de detalles: solo productos de la cita
            Dim listaDetalles As New List(Of Object())()

            Dim dtProductos As DataTable = objCita.cargarProductosdelaCita(idCita)
            For Each fila As DataRow In dtProductos.Rows
                listaDetalles.Add(New Object() {
                    fila("producto").ToString(),
                    1,
                    Convert.ToSingle(fila("precio"))
                })
            Next

            Dim frmComp As New ComprobanteVenta()
            frmComp.CargarVenta(nombreCliente, dniRuc, nombreTrabajador, listaDetalles,
                                tipoComprobante, codigoCita:=idCita.ToString(), tipoServicio:="Cita")
            frmComp.StartPosition = FormStartPosition.CenterParent
            frmComp.ShowDialog(Me)

        Catch ex As Exception
            MessageBox.Show("Error al generar el comprobante: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
