Public Class JdPapeleraProducto

    Private padre As JdGestionarProducto

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal padre As JdGestionarProducto)
        InitializeComponent()
        Me.padre = padre
    End Sub

    Private Sub JdPapeleraProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarTabla()
        listar()
    End Sub

    Private Sub configurarTabla()
        tblPapelera.Columns.Clear()
        tblPapelera.Columns.Add("Id", "Id")
        tblPapelera.Columns.Add("Nombre", "Nombre")
        tblPapelera.Columns.Add("stock", "stock")
        tblPapelera.Columns.Add("Precio", "Precio")
        tblPapelera.Columns.Add("TipoProducto", "Tipo Producto")
        tblPapelera.Columns.Add("Marca", "Marca")
    End Sub

    Public Sub listar()
        Try
            Dim obj As New capaNegocio.clsProducto()
            Dim dt As DataTable = obj.listarDadosDeBaja()
            tblPapelera.Rows.Clear()
            For Each fila As DataRow In dt.Rows
                tblPapelera.Rows.Add(fila("idproducto"), fila("producto"), fila("stock"), fila("precioactual"), fila("tipoproducto"), fila("marcaproducto"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error al listar productos dados de baja: " & ex.Message)
        End Try
    End Sub

    Private Sub tblPapelera_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblPapelera.CellClick
        If e.RowIndex < 0 Then
            Return
        End If
        txtId.Text = Convert.ToString(tblPapelera.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        If String.IsNullOrWhiteSpace(txtId.Text) Then
            MessageBox.Show("Seleccione un producto para recuperar")
            Return
        End If
        Try
            Dim obj As New capaNegocio.clsProducto()
            obj.recuperarProducto(Convert.ToInt32(txtId.Text))
            MessageBox.Show("PRODUCTO RECUPERADO")
            txtId.Text = ""
            listar()
        Catch ex As Exception
            MessageBox.Show("Error al recuperar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtId.Text) Then
            MessageBox.Show("ESCOJA UN ID PARA ELIMINAR")
            Return
        End If
        Dim respuesta = MessageBox.Show("¿Realmente quiere eliminar definitivamente este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If respuesta = DialogResult.Yes Then
            Try
                Dim obj As New capaNegocio.clsProducto()
                obj.eliminarProducto(Convert.ToInt32(txtId.Text))
                MessageBox.Show("PRODUCTO ELIMINADO")
                txtId.Text = ""
                listar()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        txtId.Text = ""
        listar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub JdPapeleraProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If padre IsNot Nothing Then
            padre.listar("")
        End If
    End Sub

End Class
