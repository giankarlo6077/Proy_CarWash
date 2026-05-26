Imports System.Data
Imports capaNegocio

Public Class jdGestionarServicio
    Dim objTipoVehiculo As New clsTipoVehiculo()
    Dim objServicio As New clsServicio()
    Dim esNuevo As Boolean

    Dim cargandoVentana As Boolean = True

    ' Constructor 1: Para crear un NUEVO servicio
    Public Sub New()
        InitializeComponent()

        LlenarListaServicios()
        ListarTiposVehiculos()

        ' Bloqueamos las cajas de texto para que sean de solo lectura pero conserven un buen diseño
        txtCodigo.ReadOnly = True
        txtCodigo.BackColor = Color.WhiteSmoke

        txtPrecio.ReadOnly = True
        txtPrecio.BackColor = Color.WhiteSmoke

        txtDuracion.ReadOnly = True
        txtDuracion.BackColor = Color.WhiteSmoke

        esNuevo = True
        GenerarCodigo()

        cargandoVentana = False
    End Sub

    ' Constructor 2: Para EDITAR un servicio existente
    Public Sub New(idServicio As Integer, idTipoVehiculo As Integer)
        InitializeComponent()

        LlenarListaServicios()
        ListarTiposVehiculos()

        ' Bloqueamos las cajas de texto para que sean de solo lectura pero conserven un buen diseño
        txtCodigo.ReadOnly = True
        txtCodigo.BackColor = Color.WhiteSmoke

        txtPrecio.ReadOnly = True
        txtPrecio.BackColor = Color.WhiteSmoke

        txtDuracion.ReadOnly = True
        txtDuracion.BackColor = Color.WhiteSmoke

        esNuevo = False
        CargarDatos(idServicio, idTipoVehiculo)

        cargandoVentana = False
    End Sub

    ' 1. Llenamos el ComboBox conectándolo directo a tu base de datos
    Private Sub LlenarListaServicios()
        Try
            Dim dt As DataTable = objServicio.listarServiciosSimples()
            cboNombre.DataSource = dt
            cboNombre.DisplayMember = "servicio" ' Lo que ve el usuario
            cboNombre.ValueMember = "idServicio" ' El ID oculto

            cboNombre.DropDownStyle = ComboBoxStyle.DropDownList
            cboNombre.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar la lista de servicios de la BD: " & ex.Message)
        End Try
    End Sub

    Private Sub ListarTiposVehiculos()
        Try
            Dim dt As DataTable = objTipoVehiculo.listarTipoVehiculo()
            cboTipoVehiculo.Items.Clear()

            For Each row As DataRow In dt.Rows
                cboTipoVehiculo.Items.Add(row("tipoVehiculo").ToString())
            Next
            cboTipoVehiculo.Items.Add("No asignado")

            cboTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList
            If cboTipoVehiculo.Items.Count > 0 Then
                cboTipoVehiculo.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error al listar tipos de vehículos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =====================================================================
    ' EVENTOS: Cuando el usuario selecciona un servicio o un vehículo
    ' =====================================================================
    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        If cargandoVentana OrElse cboNombre.SelectedIndex = -1 Then Return

        ' 1. Autocompletar la duración extrayéndola de la base de datos
        Dim filaSeleccionada As DataRowView = TryCast(cboNombre.SelectedItem, DataRowView)
        If filaSeleccionada IsNot Nothing Then
            txtDuracion.Text = filaSeleccionada("duracion").ToString()
        End If

        ' 2. Calcular el precio
        CalcularPrecioSugerido()
    End Sub

    Private Sub cboTipoVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoVehiculo.SelectedIndexChanged
        CalcularPrecioSugerido()
    End Sub

    Private Sub CalcularPrecioSugerido()
        If cargandoVentana OrElse cboNombre.SelectedIndex = -1 OrElse cboTipoVehiculo.SelectedIndex = -1 Then Return

        Dim tipoVehiculo As String = cboTipoVehiculo.SelectedItem.ToString().ToLower()
        Dim duracion As Integer = 0

        If Integer.TryParse(txtDuracion.Text, duracion) Then
            ' FÓRMULA BASE: Cobramos 1.50 soles por cada minuto de trabajo
            Dim precioCalculado As Decimal = duracion * 1.5D

            ' Aumentos por tipo de vehículo (requieren más insumos/esfuerzo)
            If tipoVehiculo.Contains("camioneta") OrElse tipoVehiculo.Contains("suv") Then
                precioCalculado += 30D
            ElseIf tipoVehiculo.Contains("van") OrElse tipoVehiculo.Contains("combi") Then
                precioCalculado += 50D
            End If

            ' Si no ha seleccionado vehículo, mostramos 0 temporalmente
            If tipoVehiculo = "no asignado" Then precioCalculado = 0

            txtPrecio.Text = precioCalculado.ToString("0.00")
        End If
    End Sub
    ' =====================================================================

    Private Sub CargarDatos(id As Integer, id2 As Integer)
        Try
            Dim dtTipoVehiculo As DataTable = objTipoVehiculo.buscarTipoVehiculo(id2)
            Dim tipo As String = ""

            If dtTipoVehiculo.Rows.Count > 0 Then
                tipo = dtTipoVehiculo.Rows(0)("tipovehiculo").ToString()
            End If

            Dim dt As DataTable = objServicio.buscarServicioPorTipoYCodigo(tipo, id)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtCodigo.Text = id.ToString()

                ' Seleccionamos el texto en los combos
                cboNombre.Text = row("servicio").ToString()
                cboTipoVehiculo.SelectedItem = row("tipoVehiculo").ToString()

                txtDuracion.Text = row("duracion").ToString()
                txtPrecio.Text = row("precioActual").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerarCodigo()
        Try
            Dim id As Integer = objServicio.generarCodigoServicio()
            txtCodigo.Text = id.ToString()
        Catch ex As Exception
            MessageBox.Show("Error al generar código: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If cboNombre.SelectedIndex = -1 Then
                Throw New Exception("Error al guardar datos, debe seleccionar un nombre de servicio.")
            End If

            Dim tipoVehiculoSeleccionado As String = cboTipoVehiculo.SelectedItem.ToString()
            If tipoVehiculoSeleccionado.Equals("No asignado", StringComparison.OrdinalIgnoreCase) Then
                Throw New Exception("Error al guardar datos, debe seleccionar un tipo de vehículo válido.")
            End If

            Dim id As Integer = Convert.ToInt32(txtCodigo.Text)

            ' Como está conectado a BD, usamos .Text para sacar la palabra elegida
            Dim nombre As String = cboNombre.Text

            Dim tiempoEstimado As Integer = Convert.ToInt32(txtDuracion.Text)
            Dim precio As Decimal = Convert.ToDecimal(txtPrecio.Text)

            Dim idTipoVehiculo As Integer = objTipoVehiculo.obtenerCodigoTipoVehiculo(tipoVehiculoSeleccionado)

            If esNuevo Then
                objServicio.registrar(id, nombre, precio, tiempoEstimado, idTipoVehiculo)
                MessageBox.Show("Servicio registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                objServicio.modificar(id, nombre, precio, tiempoEstimado, idTipoVehiculo)
                MessageBox.Show("Servicio modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Close()
        Catch ex As FormatException
            MessageBox.Show("Error al guardar datos. Ocurrió un problema de formato con los números.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class