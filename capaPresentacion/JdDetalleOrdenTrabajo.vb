Imports System.Globalization
Imports capaNegocio

Public Class JdDetalleOrdenTrabajo
    Dim objCita As New clsCita
    Private _idCita As Integer
    Private dtServicios As New DataTable()
    Private dtProductos As New DataTable()

    Public Sub New(idCita As Integer)
        InitializeComponent()
        _idCita = idCita
    End Sub

    Private Sub JdDetalleOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fila As DataRow = objCita.cargarDatosCita(_idCita)

        cmbTrabajador.DataSource = objCita.listarTrabajadores
        cmbTrabajador.DisplayMember = "trabajador"
        cmbTrabajador.ValueMember = "idTrabajador"

        If fila IsNot Nothing Then
            lblidCita.Text = fila("idCita").ToString()
            lblFecha.Text = CDate(fila("fecha")).ToString("dd/MM/yyyy")
            lblHora.Text = fila("hora").ToString()
            dtpFechaRecojo.Text = CDate(fila("fechaRecojo")).ToString("dd/MM/yyyy")
            cmbEstado.Text = fila("estado").ToString()
            txtComentario.Text = fila("comentario").ToString()
            cmbTrabajador.Text = fila("trabajador").ToString()
            lblPlaca.Text = fila("placa").ToString()
            lblModelo.Text = fila("modeloVehiculo").ToString()
            lblAno.Text = fila("anoFabricacion").ToString()
            lblCliente.Text = fila("cliente").ToString()
            lblTelefono.Text = fila("telefono").ToString()

            dtServicios = objCita.cargarServiciosdelaCita(_idCita)
            dgvServicios.DataSource = dtServicios
            dgvServicios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

            dtProductos = objCita.cargarProductosdelaCita(_idCita)
            dgvProductos.DataSource = dtProductos
            dgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        Else
            MessageBox.Show("No se encontró la cita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Validación básica
            If cmbEstado.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If cmbTrabajador.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione un técnico responsable.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Recoger datos del formulario
            Dim id As Integer = CInt(lblidCita.Text)
            Dim fec As Date = Date.ParseExact(lblFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim hor As Date = Date.ParseExact(lblHora.Text, "HH:mm:ss", CultureInfo.InvariantCulture)
            Dim estado As String = cmbEstado.SelectedItem.ToString()
            Dim coment As String = txtComentario.Text.Trim()
            Dim fechRec As Date = dtpFechaRecojo.Value
            Dim idVeh As Integer = objCita.buscarIDVehporPlaca(lblPlaca.Text)       ' guarda el idVehiculo en el .Tag
            Dim idTrab As Integer = CInt(cmbTrabajador.SelectedValue)

            ' Llamar al método
            objCita.modificarCita(id, fec, hor, estado, coment, fechRec, idVeh, idTrab)

            Dim idCita As Integer = CInt(lblidCita.Text)

            Dim idTipoVehiculo As Integer = objCita.obtenerIdTipoVehiculo(idCita)

            ' ─── GUARDAR SERVICIOS ───────────────────────────────────────
            Try
                For Each fila As DataGridViewRow In dgvServicios.Rows
                    If fila.IsNewRow Then Continue For
                    Dim idServicio As Integer = CInt(fila.Cells("idServicio").Value)
                    Dim precioVenta As Double = objCita.obtenerPrecioServicio(idServicio, idTipoVehiculo)

                    If precioVenta = 0 Then
                        MessageBox.Show("Este servicio no está disponible para el tipo de vehículo de esta cita. POR FAVOR ELIJA OTRO. ",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Continue For
                    End If

                    objCita.registrarServicioparaCita(precioVenta, idCita, idTipoVehiculo, idServicio)
                Next
                MsgBox("Servicios guardados OK")
            Catch ex As Exception
                MsgBox("Error en SERVICIOS: " & ex.Message)
            End Try

            ' ─── GUARDAR PRODUCTOS ───────────────────────────────────────
            Try
                ' Calcular cantidad correctamente
                Dim cantidadTotal As Integer = 0
                For Each fila As DataGridViewRow In dgvProductos.Rows
                    If Not fila.IsNewRow Then cantidadTotal += 1
                Next

                For Each fila As DataGridViewRow In dgvProductos.Rows
                    If fila.IsNewRow Then Continue For

                    Dim idProducto As Integer = CInt(fila.Cells("idProducto").Value)
                    Dim precio As Double = CDbl(fila.Cells("precio").Value)

                    objCita.registrarProductoparaCita(cantidadTotal, precio, idCita, idProducto)
                Next
                MsgBox("Productos guardados OK")
            Catch ex As Exception
                MsgBox("Error en PRODUCTOS: " & ex.Message)
            End Try

            MessageBox.Show("Cita actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarServicio_Click(sender As Object, e As EventArgs) Handles btnAgregarServicio.Click
        Dim frmServicio As New jdSeleccionarServicio()
        frmServicio.ShowDialog()

        If frmServicio.ServicioSeleccionado IsNot Nothing Then
            Dim fila As DataRow = frmServicio.ServicioSeleccionado

            ' Validar si el servicio existe en TARIFARIO para este tipo de vehículo
            Dim idCita As Integer = CInt(lblidCita.Text)
            Dim idTipoVehiculo As Integer = objCita.obtenerIdTipoVehiculo(idCita)
            Dim idServicio As Integer = CInt(fila("idServicio"))
            Dim precio As Double = objCita.obtenerPrecioServicio(idServicio, idTipoVehiculo)

            If precio = 0 Then
                MessageBox.Show("Este servicio no está disponible para el tipo de vehículo de esta cita.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return  ' ← no agrega la fila al dgvServicios y termina aquí
            End If

            ' Si el precio es válido, agrega normalmente
            Dim dr As DataRow = dtServicios.NewRow()
            dr("idServicio") = fila("idServicio")
            dr("servicio") = fila("servicio")
            dtServicios.Rows.Add(dr)
        End If
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim frmProducto As New jdSeleccionarProducto()
        frmProducto.ShowDialog()

        If frmProducto.ProductoSeleccionado IsNot Nothing Then
            Dim fila As DataRow = frmProducto.ProductoSeleccionado

            Dim dr As DataRow = dtProductos.NewRow()
            dr("idProducto") = fila("idProducto")
            dr("producto") = fila("producto")
            dr("precio") = fila("precio")
            dtProductos.Rows.Add(dr)
        End If
    End Sub
End Class