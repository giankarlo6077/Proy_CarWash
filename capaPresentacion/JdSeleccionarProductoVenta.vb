Imports System.Data
Imports capaNegocio

Public Class JdSeleccionarProductoVenta

    ' JdVentas se suscribe a este evento para recibir cada producto confirmado
    Public Event ProductoAgregado(nombre As String, precio As Decimal, cantidad As Integer)

    Dim objProducto As New clsProducto()
    Private _cargandoGrilla As Boolean = False

    ' ══════════════════════════════════════════════
    '  CARGA
    ' ══════════════════════════════════════════════

    Private Sub JdSeleccionarProductoVenta_Load(
        sender As Object, e As EventArgs
    ) Handles MyBase.Load

        cargarTiposProducto()
        configurarGrilla()
        cargarTodosLosProductos()

    End Sub

    ' ══════════════════════════════════════════════
    '  CONFIGURACIÓN
    ' ══════════════════════════════════════════════

    Private Sub cargarTiposProducto()
        Dim strSQL As String =
            "SELECT idtipoproducto, tipoproducto FROM tipo_producto ORDER BY tipoproducto ASC"

        Dim objC As New capaDatos.clsConectaBD()
        Try
            objC.conectar()
            Dim da As New SqlClient.SqlDataAdapter(strSQL, objC.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)

            Dim filaTodos As DataRow = dt.NewRow()
            filaTodos("idtipoproducto") = 0
            filaTodos("tipoproducto") = "-- Todos --"
            dt.Rows.InsertAt(filaTodos, 0)

            cboTipoProducto.DataSource = dt
            cboTipoProducto.DisplayMember = "tipoproducto"
            cboTipoProducto.ValueMember = "idtipoproducto"
            cboTipoProducto.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(
                "Error al cargar tipos: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        Finally
            objC.desconectar()
        End Try
    End Sub

    Private Sub configurarGrilla()
        dgvProductos.AutoGenerateColumns = False
        dgvProductos.Columns.Clear()

        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "idproducto",
            .HeaderText = "ID",
            .DataPropertyName = "idproducto",
            .Visible = False
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "producto",
            .HeaderText = "Producto",
            .DataPropertyName = "producto",
            .Width = 240
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "marcaproducto",
            .HeaderText = "Marca",
            .DataPropertyName = "marcaproducto",
            .Width = 120
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "tipoproducto",
            .HeaderText = "Tipo",
            .DataPropertyName = "tipoproducto",
            .Width = 110
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "precioactual",
            .HeaderText = "Precio (S/)",
            .DataPropertyName = "precioactual",
            .Width = 90,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Format = "N2",
                .Alignment = DataGridViewContentAlignment.MiddleRight
            }
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "stock",
            .HeaderText = "Stock",
            .DataPropertyName = "stock",
            .Width = 60,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        })

        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.MultiSelect = False
        dgvProductos.ReadOnly = True
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.RowHeadersVisible = False
    End Sub

    Private Sub cargarTodosLosProductos()
        _cargandoGrilla = True
        dgvProductos.DataSource = objProducto.listarIdNombre("*")
        dgvProductos.ClearSelection()
        _cargandoGrilla = False
        resetNudCantidad()
    End Sub

    Private Sub resetNudCantidad()
        nudCantidad.Value = 0
        nudCantidad.Maximum = 0
        nudCantidad.Enabled = False
    End Sub

    ' ══════════════════════════════════════════════
    '  COMBO — filtra automáticamente al cambiar tipo
    ' ══════════════════════════════════════════════

    Private Sub cboTipoProducto_SelectedIndexChanged(
        sender As Object, e As EventArgs
    ) Handles cboTipoProducto.SelectedIndexChanged

        Dim row As DataRowView = TryCast(cboTipoProducto.SelectedItem, DataRowView)
        If row Is Nothing Then Exit Sub

        Dim idTipo As Integer = Convert.ToInt32(row("idtipoproducto"))

        _cargandoGrilla = True
        Try
            If idTipo = 0 Then
                dgvProductos.DataSource = objProducto.listarIdNombre("*")
            Else
                dgvProductos.DataSource = objProducto.listarProductosPorTipoProducto(cboTipoProducto.Text)
            End If
        Catch ex As Exception
            _cargandoGrilla = False
            MessageBox.Show(
                "Error al filtrar: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return
        End Try

        dgvProductos.ClearSelection()
        _cargandoGrilla = False
        resetNudCantidad()

    End Sub

    ' ══════════════════════════════════════════════
    '  GRILLA — controla nudCantidad según el stock del producto
    ' ══════════════════════════════════════════════

    Private Sub dgvProductos_SelectionChanged(
        sender As Object, e As EventArgs
    ) Handles dgvProductos.SelectionChanged

        If _cargandoGrilla Then Return

        If dgvProductos.SelectedRows.Count = 0 Then
            resetNudCantidad()
            Return
        End If

        Dim fila As DataGridViewRow = dgvProductos.SelectedRows(0)
        Dim stock As Integer = Convert.ToInt32(fila.Cells("stock").Value)

        If stock = 0 Then
            resetNudCantidad()
            MessageBox.Show(
                "El producto seleccionado no tiene stock disponible.",
                "Sin stock",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
        Else
            nudCantidad.Maximum = stock
            nudCantidad.Value = 1
            nudCantidad.Enabled = True
        End If

    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN SELECCIONAR — agrega a JdVentas sin cerrar el form
    ' ══════════════════════════════════════════════

    Private Sub btnSeleccionar_Click(
        sender As Object, e As EventArgs
    ) Handles btnSeleccionar.Click

        If dgvProductos.SelectedRows.Count = 0 Then
            MessageBox.Show(
                "Seleccione un producto de la lista.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not nudCantidad.Enabled OrElse nudCantidad.Value < 1 Then
            MessageBox.Show(
                "Seleccione una cantidad válida (el producto debe tener stock).",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim fila As DataGridViewRow = dgvProductos.SelectedRows(0)
        Dim stock As Integer = Convert.ToInt32(fila.Cells("stock").Value)
        Dim cantidad As Integer = Convert.ToInt32(nudCantidad.Value)

        If cantidad > stock Then
            MessageBox.Show(
                "Stock insuficiente. Disponible: " & stock & " unidades.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim codigo As Integer = Convert.ToInt32(fila.Cells("idproducto").Value)
            Dim nombre As String = fila.Cells("producto").Value.ToString()
            Dim precio As Decimal = Convert.ToDecimal(fila.Cells("precioactual").Value)

            ' Descontar stock en BD
            objProducto.Aumentar_DisminuirStock(cantidad, codigo, "DISMINUIR")

            ' Notificar a JdVentas — agrega la fila en su tabla sin cerrar este form
            RaiseEvent ProductoAgregado(nombre, precio, cantidad)

            ' Refrescar grilla respetando el filtro activo
            Dim rowCombo As DataRowView = TryCast(cboTipoProducto.SelectedItem, DataRowView)
            Dim idTipoActual As Integer = If(rowCombo IsNot Nothing,
                                             Convert.ToInt32(rowCombo("idtipoproducto")), 0)
            _cargandoGrilla = True
            If idTipoActual = 0 Then
                dgvProductos.DataSource = objProducto.listarIdNombre("*")
            Else
                dgvProductos.DataSource = objProducto.listarProductosPorTipoProducto(cboTipoProducto.Text)
            End If
            dgvProductos.ClearSelection()
            _cargandoGrilla = False
            resetNudCantidad()

            MessageBox.Show(
                "'" & nombre & "' agregado a la venta.",
                "Producto agregado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

        Catch ex As Exception
            _cargandoGrilla = False
            MessageBox.Show(
                "Error al agregar el producto: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try

    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN CERRAR
    ' ══════════════════════════════════════════════

    Private Sub btnCerrar_Click(
        sender As Object, e As EventArgs
    ) Handles btnCerrar.Click
        Me.Close()
    End Sub

    ' Doble clic en fila con stock disponible → selecciona con cantidad 1
    Private Sub dgvProductos_CellDoubleClick(
        sender As Object, e As DataGridViewCellEventArgs
    ) Handles dgvProductos.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub
        If nudCantidad.Enabled Then
            btnSeleccionar_Click(sender, e)
        End If

    End Sub

End Class
