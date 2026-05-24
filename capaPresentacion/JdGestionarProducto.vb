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
        listar("")
        listarcbo()
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
    End Sub

    Public Sub listar(ByVal dato As String)
        ' TODO: integrar con la capa de negocio (listarIdNombre) en una siguiente etapa
    End Sub

    Public Sub listarcbo()
        ' TODO: integrar con la capa de negocio (listarMarca / listarTipoProducto) en una siguiente etapa
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
        ' TODO: integrar con la capa de negocio (buscarXid) en una siguiente etapa
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then
            btnNuevo.Text = "Guardar"
            limpiar()
        Else
            btnNuevo.Text = "Nuevo"
            ' TODO: registrar producto mediante la capa de negocio en una siguiente etapa
        End If
        listar("")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' TODO: modificar producto mediante la capa de negocio en una siguiente etapa
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
        ' TODO: dar de baja producto mediante la capa de negocio en una siguiente etapa
        listar("")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtId.Text) Then
            MessageBox.Show("ESCOJA UN ID PARA ELIMINAR")
            Return
        End If
        Dim respuesta = MessageBox.Show("¿Realmente quiere eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If respuesta = DialogResult.Yes Then
            ' TODO: eliminar producto mediante la capa de negocio en una siguiente etapa
            limpiar()
            listar("")
            MessageBox.Show("PRODUCTO ELIMINADO")
        End If
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub JdGestionarProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If padre IsNot Nothing Then
            padre.listar("")
        End If
    End Sub

End Class
