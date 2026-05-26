Imports capaNegocio

Public Class JdGestionarProveedorProducto

    Dim objProveedor As New clsProveedor()
    Dim _idProveedorProducto As Integer = 0
    Dim _modoEdicion As Boolean = False

    ' ══════════════════════════════════════════════
    '  CARGA DEL FORMULARIO
    ' ══════════════════════════════════════════════

    Private Sub JdGestionarProveedorProducto_Load(
        sender As Object, e As EventArgs
    ) Handles MyBase.Load

        cargarProveedores()
        configurarGrilla()

    End Sub

    ' ══════════════════════════════════════════════
    '  CONFIGURACIÓN INICIAL
    ' ══════════════════════════════════════════════

    Private Sub cargarProveedores()

        Dim dt As DataTable = objProveedor.listarProveedor()

        cboProveedor.DataSource = dt
        cboProveedor.DisplayMember = "proveedor"
        cboProveedor.ValueMember = "idProveedor"
        cboProveedor.SelectedIndex = -1

        txtRuc.Text = ""
        txtContacto.Text = ""

    End Sub

    Private Sub configurarGrilla()

        dgvProductos.AutoGenerateColumns = False
        dgvProductos.Columns.Clear()

        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "ID",
            .DataPropertyName = "idProveedorProducto",
            .Visible = False
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "ID Producto",
            .DataPropertyName = "idproducto",
            .Visible = False
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Producto",
            .DataPropertyName = "producto",
            .Width = 200
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Marca",
            .DataPropertyName = "marcaproducto",
            .Width = 120
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Tipo",
            .DataPropertyName = "tipoproducto",
            .Width = 120
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "P. Venta (S/)",
            .DataPropertyName = "precioVenta",
            .Width = 100,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Format = "N2",
                .Alignment = DataGridViewContentAlignment.MiddleRight
            }
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "P. Compra (S/)",
            .DataPropertyName = "precioCompra",
            .Width = 110,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Format = "N2",
                .Alignment = DataGridViewContentAlignment.MiddleRight
            }
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
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

    ' ══════════════════════════════════════════════
    '  SECCIÓN 1 — SELECCIONAR PROVEEDOR
    ' ══════════════════════════════════════════════

    Private Sub cboProveedor_SelectedIndexChanged(
        sender As Object, e As EventArgs
    ) Handles cboProveedor.SelectedIndexChanged

        If cboProveedor.SelectedIndex = -1 Then Exit Sub

        Dim idProveedor As Integer =
            Convert.ToInt32(cboProveedor.SelectedValue)

        ' Rellenar RUC y Contacto
        Dim fila As DataRow = objProveedor.buscarXid(idProveedor)

        If fila IsNot Nothing Then
            txtRuc.Text = fila("ruc").ToString()
            txtContacto.Text = fila("contacto").ToString()
        End If

        ' Recargar combo de productos disponibles
        cargarProductosParaVincular(idProveedor)

        ' Recargar grilla
        cargarGrilla(idProveedor)

        ' Limpiar estado de edición
        limpiarFormulario()

    End Sub

    ' ══════════════════════════════════════════════
    '  SECCIÓN 2 — VINCULAR NUEVO PRODUCTO
    ' ══════════════════════════════════════════════

    Private Sub cargarProductosParaVincular(ByVal idProveedor As Integer)

        Dim dt As DataTable =
            objProveedor.listarProductosParaVincular(idProveedor)

        cboProducto.DataSource = dt
        cboProducto.DisplayMember = "producto"
        cboProducto.ValueMember = "idproducto"
        cboProducto.SelectedIndex = -1

        txtPrecioCompra.Text = ""

    End Sub

    Private Sub btnVincular_Click(
        sender As Object, e As EventArgs
    ) Handles btnVincular.Click

        If cboProveedor.SelectedIndex = -1 Then
            MessageBox.Show(
                "Seleccione un proveedor.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cboProducto.SelectedIndex = -1 Then
            MessageBox.Show(
                "Seleccione un producto.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim precio As Decimal
        If Not Decimal.TryParse(txtPrecioCompra.Text.Trim(), precio) OrElse precio <= 0 Then
            MessageBox.Show(
                "Ingrese un precio de compra válido (mayor a 0).",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim idProveedor As Integer =
                Convert.ToInt32(cboProveedor.SelectedValue)
            Dim idProducto As Integer =
                Convert.ToInt32(cboProducto.SelectedValue)

            objProveedor.vincularProducto(idProveedor, idProducto, precio)

            MessageBox.Show(
                "Producto vinculado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            cargarProductosParaVincular(idProveedor)
            cargarGrilla(idProveedor)
            limpiarFormulario()

        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnLimpiar_Click(
        sender As Object, e As EventArgs
    ) Handles btnLimpiar.Click

        limpiarFormulario()

    End Sub

    Private Sub limpiarFormulario()

        _idProveedorProducto = 0
        _modoEdicion = False

        cboProducto.Enabled = True
        txtPrecioCompra.Text = ""
        btnVincular.Enabled = True
        btnEditar.Enabled = False

        dgvProductos.ClearSelection()

    End Sub

    ' ══════════════════════════════════════════════
    '  SECCIÓN 3 — GRILLA DE PRODUCTOS
    ' ══════════════════════════════════════════════

    Private Sub cargarGrilla(ByVal idProveedor As Integer)

        dgvProductos.DataSource =
            objProveedor.listarProductosDelProveedor(idProveedor)

    End Sub

    Private Sub btnBuscar_Click(
        sender As Object, e As EventArgs
    ) Handles btnBuscar.Click

        If cboProveedor.SelectedIndex = -1 Then
            MessageBox.Show(
                "Seleccione un proveedor primero.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idProveedor As Integer =
            Convert.ToInt32(cboProveedor.SelectedValue)
        Dim criterio As String = txtBuscar.Text.Trim()

        If criterio = "" Then
            cargarGrilla(idProveedor)
        Else
            dgvProductos.DataSource =
                objProveedor.buscarProductoDelProveedor(idProveedor, criterio)
        End If

    End Sub

    Private Sub btnEditar_Click(
        sender As Object, e As EventArgs
    ) Handles btnEditar.Click

        If _idProveedorProducto = 0 Then
            MessageBox.Show(
                "Seleccione una fila de la grilla primero.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim precio As Decimal
        If Not Decimal.TryParse(txtPrecioCompra.Text.Trim(), precio) OrElse precio <= 0 Then
            MessageBox.Show(
                "Ingrese un precio de compra válido (mayor a 0).",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            objProveedor.actualizarPrecioCompra(_idProveedorProducto, precio)

            MessageBox.Show(
                "Precio actualizado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            Dim idProveedor As Integer =
                Convert.ToInt32(cboProveedor.SelectedValue)

            cargarGrilla(idProveedor)
            limpiarFormulario()

        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try

    End Sub

    ' Clic en fila → cargar datos para editar precio
    Private Sub dgvProductos_CellClick(
        sender As Object, e As DataGridViewCellEventArgs
    ) Handles dgvProductos.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim fila As DataGridViewRow = dgvProductos.Rows(e.RowIndex)

        _idProveedorProducto =
            Convert.ToInt32(fila.Cells("idProveedorProducto").Value)

        txtPrecioCompra.Text =
            Convert.ToDecimal(fila.Cells("precioCompra").Value).ToString("N2")

        ' Bloquear combo de producto (modo edición)
        cboProducto.SelectedValue =
            Convert.ToInt32(fila.Cells("idproducto").Value)
        cboProducto.Enabled = False

        btnVincular.Enabled = False
        btnEditar.Enabled = True
        _modoEdicion = True

    End Sub

    ' Doble clic en fila → confirmar desvincular
    Private Sub dgvProductos_CellDoubleClick(
        sender As Object, e As DataGridViewCellEventArgs
    ) Handles dgvProductos.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub

        Dim fila As DataGridViewRow = dgvProductos.Rows(e.RowIndex)
        Dim nombreProducto As String =
            fila.Cells("producto").Value.ToString()
        Dim idPP As Integer =
            Convert.ToInt32(fila.Cells("idProveedorProducto").Value)

        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Desea desvincular el producto '" & nombreProducto & "' de este proveedor?",
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                objProveedor.desvincularProducto(idPP)

                MessageBox.Show(
                    "Producto desvinculado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                Dim idProveedor As Integer =
                    Convert.ToInt32(cboProveedor.SelectedValue)

                cargarProductosParaVincular(idProveedor)
                cargarGrilla(idProveedor)
                limpiarFormulario()

            Catch ex As Exception
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
            End Try
        End If

    End Sub

End Class