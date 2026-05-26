Imports System.Collections.Generic
Imports System.Data
Imports capaNegocio

Public Class JdVentas

    Dim objVenta As New clsVenta()
    Dim objCliente As New clsCliente()
    Dim objComprobante As New clsComprobante()

    Dim dtDetalle As New DataTable()
    Dim _trabajadorSesion As String = "Admin"

    ' ══════════════════════════════════════════════
    '  CARGA DEL FORMULARIO
    ' ══════════════════════════════════════════════

    Private Sub JdVentas_Load(
        sender As Object, e As EventArgs
    ) Handles MyBase.Load

        inicializarDetalle()
        configurarGrilla()
        cargarClientes()
        cargarTiposComprobante()
        autocompletarCabecera()

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

    Private Sub cargarClientes()
        Dim dt As DataTable = objCliente.listarNombreClientes()
        cboCliente.DataSource = dt
        cboCliente.DisplayMember = "cliente"
        cboCliente.SelectedIndex = -1
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
        txtNumeroVenta.Text = objComprobante.mostrarNuevoNumeroComprobante(tipo)
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN AGREGAR
    ' ══════════════════════════════════════════════

    Private Sub btnAgregar_Click(
        sender As Object, e As EventArgs
    ) Handles btnAgregar.Click

        Dim frmSel As New JdSeleccionarProductoVenta()
        frmSel.ShowDialog()

        If Not frmSel.Confirmado Then Exit Sub

        Dim nombre As String = frmSel.NombreProducto
        Dim precio As Decimal = frmSel.PrecioProducto
        Dim cantidad As Integer = frmSel.CantidadSeleccionada

        ' Si el producto ya existe → sumar cantidad
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

        ' ── Validaciones ──────────────────────────────
        If cboCliente.SelectedIndex = -1 Then
            MessageBox.Show(
                "Seleccione un cliente.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cboTipoComprobante.SelectedIndex = -1 Then
            MessageBox.Show(
                "Seleccione el tipo de comprobante.",
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

        ' ── Armar parámetros ──────────────────────────
        Dim fecha As String = Date.Now.ToString("yyyy-MM-dd")
        Dim hora As String = Date.Now.ToString("HH:mm:ss")
        Dim numComprobante As String = txtNumeroVenta.Text.Trim()
        Dim tipoComprobante As String = cboTipoComprobante.SelectedItem.ToString()
        Dim nombreCliente As String = cboCliente.SelectedItem.ToString()

        ' Medio de pago fijo — no hay combo en el form
        Dim medioPago As String = "Efectivo"

        ' ── Construir lista de detalles ───────────────
        ' transaccion() espera: Object() = {nombre, cantidad, precio}
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

        ' ── Confirmar antes de guardar ────────────────
        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Generar comprobante " & numComprobante & " por S/ " &
            txtTotal.Text & "?",
            "Confirmar venta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If respuesta = DialogResult.No Then Exit Sub

        ' ── Ejecutar transacción ──────────────────────
        Try
            objComprobante.transaccion(
                fecha,
                hora,
                numComprobante,
                "Pagado",
                tipoComprobante,
                0,
                medioPago,
                _trabajadorSesion,
                nombreCliente,
                listaDetalles)

            MessageBox.Show(
                "Comprobante " & numComprobante & " generado correctamente." &
                vbNewLine & "Total: S/ " & txtTotal.Text,
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            limpiarFormulario()

        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error al registrar",
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
        cboCliente.SelectedIndex = -1
        cboTipoComprobante.SelectedIndex = 0
        autocompletarCabecera()
    End Sub

End Class