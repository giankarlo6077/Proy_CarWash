Imports System.Data
Imports capaNegocio

Public Class JdSeleccionarProductoVenta

    ' Propiedades que lee JdVentas al cerrarse
    Public Property Confirmado As Boolean = False
    Public Property NombreProducto As String = ""
    Public Property PrecioProducto As Decimal = 0
    Public Property CantidadSeleccionada As Integer = 1

    Dim objProducto As New clsProducto()

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
        ' Carga los tipos desde la BD usando clsProducto
        Dim strSQL As String =
            "SELECT idtipoproducto, tipoproducto FROM tipo_producto ORDER BY tipoproducto ASC"

        Dim objC As New capaDatos.clsConectaBD()
        Try
            objC.conectar()
            Dim da As New SqlClient.SqlDataAdapter(strSQL, objC.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)

            ' Agregar opción "Todos" al inicio
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
            .HeaderText = "ID",
            .DataPropertyName = "idproducto",
            .Visible = False
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Producto",
            .DataPropertyName = "producto",
            .Width = 240
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Marca",
            .DataPropertyName = "marcaproducto",
            .Width = 120
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Tipo",
            .DataPropertyName = "tipoproducto",
            .Width = 110
        })
        dgvProductos.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Precio (S/)",
            .DataPropertyName = "precioactual",
            .Width = 90,
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

    Private Sub cargarTodosLosProductos()
        ' listarIdNombre con "*" trae todos los vigentes
        dgvProductos.DataSource = objProducto.listarIdNombre("*")
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN BUSCAR — filtra por tipo de producto
    ' ══════════════════════════════════════════════

    Private Sub btnBuscar_Click(
        sender As Object, e As EventArgs
    ) Handles btnBuscar.Click

        Dim idTipo As Integer = Convert.ToInt32(cboTipoProducto.SelectedValue)

        If idTipo = 0 Then
            ' "-- Todos --" seleccionado
            cargarTodosLosProductos()
        Else
            ' Filtrar por tipo usando clsProducto
            Dim strSQL As String =
                "SELECT p.idproducto, p.producto, " &
                "pm.marcaproducto, tp.tipoproducto, " &
                "p.precioactual, p.stock " &
                "FROM producto p " &
                "INNER JOIN marca_producto pm ON pm.idmarcaproducto = p.idmarcaproducto " &
                "INNER JOIN tipo_producto tp  ON tp.idtipoproducto  = p.idtipoproducto " &
                "WHERE p.vigencia = 1 " &
                "AND p.idtipoproducto = " & idTipo & " " &
                "ORDER BY p.producto ASC"

            Dim objC As New capaDatos.clsConectaBD()
            Try
                objC.conectar()
                Dim da As New SqlClient.SqlDataAdapter(strSQL, objC.miConexion)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvProductos.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(
                    "Error al buscar: " & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
            Finally
                objC.desconectar()
            End Try
        End If

    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN SELECCIONAR — confirma y cierra
    ' ══════════════════════════════════════════════

    Private Sub btnSeleccionar_Click(
        sender As Object, e As EventArgs
    ) Handles btnSeleccionar.Click

        ' Validar que haya una fila seleccionada
        If dgvProductos.SelectedRows.Count = 0 Then
            MessageBox.Show(
                "Seleccione un producto de la lista.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validar cantidad
        If nudCantidad.Value < 1 Then
            MessageBox.Show(
                "La cantidad debe ser al menos 1.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim fila As DataGridViewRow = dgvProductos.SelectedRows(0)

        ' Validar stock disponible
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

        ' Pasar datos al form padre
        Me.NombreProducto = fila.Cells("producto").Value.ToString()
        Me.PrecioProducto = Convert.ToDecimal(fila.Cells("precioactual").Value)
        Me.CantidadSeleccionada = cantidad
        Me.Confirmado = True

        Me.Close()

    End Sub

    ' Doble clic en fila → selecciona directamente con cantidad 1
    Private Sub dgvProductos_CellDoubleClick(
        sender As Object, e As DataGridViewCellEventArgs
    ) Handles dgvProductos.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub
        nudCantidad.Value = 1
        btnSeleccionar_Click(sender, e)

    End Sub

End Class