Public Class JdMantenimientoProducto

    Private Sub JdMantenimientoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarTabla()
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
    End Sub

    Public Sub listar(ByVal dato As String)
        ' TODO: integrar con la capa de negocio (listarIdNombre) en una siguiente etapa
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        listar(txtbuscador.Text)
    End Sub

    Private Sub btnGestionarPersona_Click(sender As Object, e As EventArgs) Handles btnGestionarPersona.Click
        Dim obj As New JdGestionarProducto(Me)
        obj.StartPosition = FormStartPosition.CenterParent
        obj.ShowDialog(Me)
    End Sub

End Class
