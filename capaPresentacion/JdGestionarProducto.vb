Public Class JdGestionarProducto

    Private padre As JdMantenimientoProducto

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal padre As JdMantenimientoProducto)
        InitializeComponent()
        Me.padre = padre
    End Sub

    Private Sub JdGestionarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarTabla()
        listarcbo()
        listar("")
    End Sub

    Private Sub configurarTabla()
        tblProducto.Columns.Clear()
        tblProducto.Columns.Add("Id", "Id")
        tblProducto.Columns.Add("Nombre", "Nombre")
        tblProducto.Columns.Add("stock", "stock")
        tblProducto.Columns.Add("vigencia", "vigencia")
        tblProducto.Columns.Add("Precio", "Precio")
        tblProducto.Columns.Add("TipoProducto", "Tipo Producto")
        tblProducto.Columns.Add("Marca", "Marca")
        tblProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Public Sub listar(ByVal dato As String)
        Try
            Dim obj As New capaNegocio.clsProducto()
            Dim dt As DataTable = obj.listarIdNombre(dato)
            tblProducto.Rows.Clear()
            For Each fila As DataRow In dt.Rows
                tblProducto.Rows.Add(fila("idproducto"), fila("producto"), fila("stock"), fila("vigencia"), fila("precioactual"), fila("tipoproducto"), fila("marcaproducto"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error al listar productos: " & ex.Message)
        End Try
    End Sub

    Public Sub listarcbo()
        Try
            Dim objMarca As New capaNegocio.clsMarca()
            Dim dtMarca As DataTable = objMarca.listarMarca()
            cboMarcaProducto.DataSource = dtMarca
            cboMarcaProducto.DisplayMember = "marcaproducto"
            cboMarcaProducto.ValueMember = "idmarcaproducto"
            cboMarcaProducto.SelectedIndex = -1

            Dim objTipo As New capaNegocio.clsTipoProducto()
            Dim dtTipo As DataTable = objTipo.listarTipoProducto()
            cboTipoProducto.DataSource = dtTipo
            cboTipoProducto.DisplayMember = "tipoproducto"
            cboTipoProducto.ValueMember = "idtipoproducto"
            cboTipoProducto.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar combos: " & ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        cboMarcaProducto.SelectedIndex = -1
        cboTipoProducto.SelectedIndex = -1
        chkVigencia.Checked = True
        txtId.Text = ""
        spnStock.Value = 0
        txtNombre.Text = ""
        txtPrecio.Text = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If String.IsNullOrWhiteSpace(txtId.Text) Then
            MessageBox.Show("Ingrese un ID para buscar")
            Return
        End If
        Try
            Dim obj As New capaNegocio.clsProducto()
            Dim fila As DataRow = obj.buscarXid(Convert.ToInt32(txtId.Text))
            If fila IsNot Nothing Then
                txtNombre.Text = Convert.ToString(fila("producto"))
                spnStock.Value = Convert.ToDecimal(fila("stock"))
                chkVigencia.Checked = Convert.ToBoolean(fila("vigencia"))
                txtPrecio.Text = Convert.ToString(fila("precioactual"))
                Dim idxMarca As Integer = cboMarcaProducto.FindStringExact(Convert.ToString(fila("marcaproducto")))
                If idxMarca >= 0 Then cboMarcaProducto.SelectedIndex = idxMarca
                Dim idxTipo As Integer = cboTipoProducto.FindStringExact(Convert.ToString(fila("tipoproducto")))
                If idxTipo >= 0 Then cboTipoProducto.SelectedIndex = idxTipo
            Else
                MessageBox.Show("No se encontró el producto con ese ID")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then
            btnNuevo.Text = "Guardar"
            limpiar()
            ' Mostrar automáticamente el ID que tendrá el nuevo producto
            Try
                Dim obj As New capaNegocio.clsProducto()
                txtId.Text = obj.generarCodigoProducto().ToString()
            Catch ex As Exception
                MessageBox.Show("Error al generar el código del producto: " & ex.Message)
            End Try
        Else
            ' Validaciones antes de registrar
            If String.IsNullOrWhiteSpace(txtNombre.Text) Then
                MessageBox.Show("Ingrese el nombre del producto")
                Return
            End If
            If cboTipoProducto.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione el tipo de producto")
                Return
            End If
            If cboMarcaProducto.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione la marca del producto")
                Return
            End If
            Dim precio As Decimal
            If Not Decimal.TryParse(txtPrecio.Text, precio) Then
                MessageBox.Show("Ingrese un precio válido")
                Return
            End If

            btnNuevo.Text = "Nuevo"
            Try
                Dim obj As New capaNegocio.clsProducto()
                Dim id As Integer = obj.generarCodigoProducto()
                Dim idMarca As Integer = Convert.ToInt32(cboMarcaProducto.SelectedValue)
                Dim idTipo As Integer = Convert.ToInt32(cboTipoProducto.SelectedValue)
                obj.registrarProducto(id, txtNombre.Text, Convert.ToInt32(spnStock.Value), chkVigencia.Checked, precio, idTipo, idMarca)
                MessageBox.Show("PRODUCTO REGISTRADO")
                limpiar()
            Catch ex As Exception
                MessageBox.Show("Error al registrar: " & ex.Message)
            End Try
            listar("")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If String.IsNullOrWhiteSpace(txtId.Text) Then
            MessageBox.Show("Seleccione un producto para modificar")
            Return
        End If
        Try
            Dim obj As New capaNegocio.clsProducto()
            Dim idMarca As Integer = Convert.ToInt32(cboMarcaProducto.SelectedValue)
            Dim idTipo As Integer = Convert.ToInt32(cboTipoProducto.SelectedValue)
            obj.modificarProducto(Convert.ToInt32(txtId.Text), txtNombre.Text, Convert.ToInt32(spnStock.Value), chkVigencia.Checked, Convert.ToDecimal(txtPrecio.Text), idTipo, idMarca)
            MessageBox.Show("PRODUCTO MODIFICADO")
        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message)
        End Try
        listar("")
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnDarsebaja_Click(sender As Object, e As EventArgs) Handles btnDarsebaja.Click
        If String.IsNullOrWhiteSpace(txtId.Text) Then
            MessageBox.Show("ESCOJA UN ID PARA ELIMINAR")
            Return
        End If
        Try
            Dim obj As New capaNegocio.clsProducto()
            obj.darbajaProducto(Convert.ToInt32(txtId.Text))
            MessageBox.Show("PRODUCTO DADO DE BAJA")
        Catch ex As Exception
            MessageBox.Show("Error al dar de baja: " & ex.Message)
        End Try
        listar("")
    End Sub

    Private Sub btnTipoProducto_Click(sender As Object, e As EventArgs) Handles btnTipoProducto.Click
        Dim obj As New JdGestionarTipoDeProducto(Me)
        obj.StartPosition = FormStartPosition.CenterParent
        obj.ShowDialog(Me)
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        Dim obj As New JdGestionarMarca(Me)
        obj.StartPosition = FormStartPosition.CenterParent
        obj.ShowDialog(Me)
    End Sub

    Private Sub btnPapelera_Click(sender As Object, e As EventArgs) Handles btnPapelera.Click
        Dim obj As New JdPapeleraProducto(Me)
        obj.StartPosition = FormStartPosition.CenterParent
        obj.ShowDialog(Me)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub JdGestionarProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If padre IsNot Nothing Then
            padre.listar("")
        End If
    End Sub

End Class
