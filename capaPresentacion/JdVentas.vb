Imports System.Collections.Generic
Imports System.Data
Imports capaNegocio

Public Class JdVentas

    Dim objVenta As New clsVenta()
    Dim objCliente As New clsCliente()
    Dim objComprobante As New clsComprobante()

    Dim dtDetalle As New DataTable()
    Dim dtClientes As New DataTable()
    Public Property trabajadorSesion As String = ""

    ' ══════════════════════════════════════════════
    '  CARGA DEL FORMULARIO
    ' ══════════════════════════════════════════════

    Private Sub JdVentas_Load(
        sender As Object, e As EventArgs
    ) Handles MyBase.Load

        inicializarDetalle()
        configurarGrilla()
        configurarGrillaCliente()
        cargarClientes()
        cargarTiposComprobante()
        autocompletarCabecera()

        txtNumeroVenta.ReadOnly = True
        txtFecha.ReadOnly = True
        txtHora.ReadOnly = True
        txtTotal.ReadOnly = True

    End Sub

    ' ══════════════════════════════════════════════
    '  INICIALIZACIÓN
    ' ══════════════════════════════════════════════

    Private Sub inicializarDetalle()
        dtDetalle.Columns.Clear()
        dtDetalle.Columns.Add("producto", GetType(String))
        dtDetalle.Columns.Add("cantidad", GetType(Integer))
        dtDetalle.Columns.Add("precioVenta", GetType(Decimal))
        dtDetalle.Columns.Add("subtotal", GetType(Decimal))
    End Sub

    Private Sub configurarGrilla()
        dgvDetalle.AutoGenerateColumns = False
        dgvDetalle.Columns.Clear()

        dgvDetalle.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Producto",
            .DataPropertyName = "producto",
            .Width = 230
        })
        dgvDetalle.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Cantidad",
            .DataPropertyName = "cantidad",
            .Width = 70,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        })
        dgvDetalle.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Precio Unit. (S/)",
            .DataPropertyName = "precioVenta",
            .Width = 110,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Format = "N2",
                .Alignment = DataGridViewContentAlignment.MiddleRight
            }
        })
        dgvDetalle.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Subtotal (S/)",
            .DataPropertyName = "subtotal",
            .Width = 110,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Format = "N2",
                .Alignment = DataGridViewContentAlignment.MiddleRight
            }
        })

        dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetalle.MultiSelect = False
        dgvDetalle.ReadOnly = True
        dgvDetalle.AllowUserToAddRows = False
        dgvDetalle.RowHeadersVisible = False
        dgvDetalle.DataSource = dtDetalle
    End Sub

    Private Sub configurarGrillaCliente()
        dgvCliente.AutoGenerateColumns = False
        dgvCliente.Columns.Clear()
        dgvCliente.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Tipo",
            .DataPropertyName = "tipo",
            .Width = 100
        })
        dgvCliente.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Nombre / Razón Social",
            .DataPropertyName = "cliente",
            .Width = 640
        })
        dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCliente.MultiSelect = False
        dgvCliente.ReadOnly = True
        dgvCliente.AllowUserToAddRows = False
        dgvCliente.RowHeadersVisible = False
    End Sub

    Private Sub cargarClientes()
        dtClientes = objCliente.listarClientesConTipo()
        dgvCliente.DataSource = dtClientes.DefaultView
    End Sub

    Private Sub cargarTiposComprobante()
        cboTipoComprobante.Items.Clear()
        cboTipoComprobante.Items.Add("Boleta")
        cboTipoComprobante.Items.Add("Factura")
        cboTipoComprobante.SelectedIndex = 0
    End Sub

    Private Sub autocompletarCabecera()
        txtFecha.Text = Date.Now.ToString("yyyy-MM-dd")
        txtHora.Text = Date.Now.ToString("HH:mm:ss")
        actualizarNumComprobante()
    End Sub

    ' Refresca el número cada vez que JdVentas recupera el foco
    Private Sub JdVentas_Activated(
        sender As Object, e As EventArgs
    ) Handles MyBase.Activated
        actualizarNumComprobante()
    End Sub

    ' ══════════════════════════════════════════════
    '  BÚSQUEDA DE CLIENTE EN TIEMPO REAL
    ' ══════════════════════════════════════════════

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        If dtClientes Is Nothing OrElse dtClientes.Rows.Count = 0 Then Return
        Dim filtro As String = txtCliente.Text.Trim().Replace("'", "''")
        dtClientes.DefaultView.RowFilter =
            If(String.IsNullOrWhiteSpace(filtro), "", "cliente LIKE '%" & filtro & "%'")
    End Sub

    ' ══════════════════════════════════════════════
    '  TIPO COMPROBANTE → actualiza número
    ' ══════════════════════════════════════════════

    Private Sub cboTipoComprobante_SelectedIndexChanged(
        sender As Object, e As EventArgs
    ) Handles cboTipoComprobante.SelectedIndexChanged

        actualizarNumComprobante()

    End Sub

    Private Sub actualizarNumComprobante()
        If cboTipoComprobante.SelectedIndex = -1 Then Exit Sub
        Dim tipo As String = cboTipoComprobante.SelectedItem.ToString()
        Try
            Dim num As String = objComprobante.mostrarNuevoNumeroComprobante(tipo)
            If String.IsNullOrWhiteSpace(num) Then
                num = If(tipo = "Factura", "F001", "B001") & "-00000001"
            End If
            txtNumeroVenta.Text = num
        Catch
            txtNumeroVenta.Text = If(tipo = "Factura", "F001", "B001") & "-00000001"
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN AGREGAR
    ' ══════════════════════════════════════════════

    Private Sub btnAgregar_Click(
        sender As Object, e As EventArgs
    ) Handles btnAgregar.Click

        Dim frmSel As New JdSeleccionarProductoVenta()
        AddHandler frmSel.ProductoAgregado, AddressOf agregarProductoEnDetalle
        frmSel.ShowDialog(Me)
        RemoveHandler frmSel.ProductoAgregado, AddressOf agregarProductoEnDetalle

    End Sub

    Private Sub agregarProductoEnDetalle(nombre As String, precio As Decimal, cantidad As Integer)
        ' Si el producto ya existe en la tabla → sumar cantidad
        For Each fila As DataRow In dtDetalle.Rows
            If fila.RowState <> DataRowState.Deleted AndAlso
               fila("producto").ToString() = nombre Then
                fila("cantidad") = CInt(fila("cantidad")) + cantidad
                fila("subtotal") = CDec(fila("precioVenta")) * CInt(fila("cantidad"))
                actualizarTotal()
                Exit Sub
            End If
        Next

        ' Producto nuevo → nueva fila
        dtDetalle.Rows.Add(nombre, cantidad, precio, precio * cantidad)
        actualizarTotal()
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN ELIMINAR
    ' ══════════════════════════════════════════════

    Private Sub btnEliminar_Click(
        sender As Object, e As EventArgs
    ) Handles btnEliminar.Click

        If dgvDetalle.SelectedRows.Count = 0 Then
            MessageBox.Show(
                "Seleccione un producto para eliminar.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Desea eliminar el producto seleccionado?",
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Dim idx As Integer = dgvDetalle.SelectedRows(0).Index
            dtDetalle.Rows(idx).Delete()
            actualizarTotal()
        End If

    End Sub

    ' ══════════════════════════════════════════════
    '  CALCULAR TOTAL
    ' ══════════════════════════════════════════════

    Private Sub actualizarTotal()
        Dim total As Decimal = 0
        For Each fila As DataRow In dtDetalle.Rows
            If fila.RowState <> DataRowState.Deleted Then
                total += Convert.ToDecimal(fila("subtotal"))
            End If
        Next
        txtTotal.Text = total.ToString("N2")
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN GENERAR COMPROBANTE
    ' ══════════════════════════════════════════════

    Private Sub btnGenerarComprobante_Click(
        sender As Object, e As EventArgs
    ) Handles btnGenerarComprobante.Click

        ' ── Validaciones previas ──────────────────────
        If dgvCliente.SelectedRows.Count = 0 Then
            MessageBox.Show(
                "Seleccione un cliente de la lista.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(trabajadorSesion) Then
            MessageBox.Show(
                "No se identificó al trabajador de la sesión. Inicie sesión nuevamente.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim filasActivas As Integer = 0
        For Each fila As DataRow In dtDetalle.Rows
            If fila.RowState <> DataRowState.Deleted Then filasActivas += 1
        Next

        If filasActivas = 0 Then
            MessageBox.Show(
                "Agregue al menos un producto.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ── Seleccionar tipo de comprobante ───────────
        Dim respTipo As DialogResult = MessageBox.Show(
            "¿Qué tipo de comprobante desea generar?" & vbNewLine & vbNewLine &
            "[Sí]        →  Boleta de Venta" & vbNewLine &
            "[No]        →  Factura" & vbNewLine &
            "[Cancelar] →  Volver",
            "Tipo de Comprobante",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question)

        If respTipo = DialogResult.Cancel Then Exit Sub

        Dim tipoComprobante As String = If(respTipo = DialogResult.Yes, "Boleta", "Factura")

        ' Sincronizar combo y actualizar número de comprobante
        Dim idxTipo As Integer = If(tipoComprobante = "Boleta", 0, 1)
        If cboTipoComprobante.SelectedIndex <> idxTipo Then
            cboTipoComprobante.SelectedIndex = idxTipo
        End If

        ' ── Armar parámetros ──────────────────────────
        Dim numComprobante As String = txtNumeroVenta.Text.Trim()
        Dim boundRow As DataRowView = TryCast(dgvCliente.SelectedRows(0).DataBoundItem, DataRowView)
        Dim nombreCliente As String = If(boundRow IsNot Nothing,
                                         boundRow("cliente").ToString(),
                                         dgvCliente.SelectedRows(0).Cells(1).Value.ToString())

        ' ── Construir lista de detalles ───────────────
        Dim listaDetalles As New List(Of Object())
        For Each fila As DataRow In dtDetalle.Rows
            If fila.RowState <> DataRowState.Deleted Then
                listaDetalles.Add(New Object() {
                    fila("producto").ToString(),
                    Convert.ToInt32(fila("cantidad")),
                    Convert.ToSingle(fila("precioVenta"))
                })
            End If
        Next

        ' ── Abrir comprobante para que el usuario guarde y exporte ──
        Try
            Dim dniRuc As String = ""
            Try
                dniRuc = objCliente.obtenerNumeroDocumento(nombreCliente)
            Catch
            End Try

            Dim frmComp As New ComprobanteVenta()
            frmComp.CargarVenta(nombreCliente, dniRuc, trabajadorSesion, listaDetalles,
                                tipoComprobante, codigoVenta:=numComprobante, tipoServicio:="Venta")
            frmComp.StartPosition = FormStartPosition.CenterParent
            frmComp.ShowDialog(Me)

            limpiarFormulario()

        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error al abrir comprobante",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try

    End Sub

    ' ══════════════════════════════════════════════
    '  LIMPIAR DESPUÉS DE REGISTRAR
    ' ══════════════════════════════════════════════

    Private Sub limpiarFormulario()
        dtDetalle.Rows.Clear()
        txtTotal.Text = "0.00"
        txtCliente.Text = ""
        If dtClientes IsNot Nothing Then dtClientes.DefaultView.RowFilter = ""
        dgvCliente.ClearSelection()
        cboTipoComprobante.SelectedIndex = 0
        autocompletarCabecera()
        actualizarNumComprobante()
    End Sub

End Class
