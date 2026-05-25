Public Class JdGestionarTipoDeProducto

    Private jd As JdGestionarProducto

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal jd As JdGestionarProducto)
        InitializeComponent()
        Me.jd = jd
    End Sub

    Private Sub JdGestionarTipoDeProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarTabla()
        listar()
    End Sub

    Private Sub configurarTabla()
        tblTipoProducto.Columns.Clear()
        tblTipoProducto.Columns.Add("ID", "ID")
        tblTipoProducto.Columns.Add("NOMBRE", "NOMBRE")
    End Sub

    Public Sub listar()
        Try
            Dim obj As New capaNegocio.clsTipoProducto()
            Dim dt As DataTable = obj.listarTipoProducto()
            tblTipoProducto.Rows.Clear()
            For Each fila As DataRow In dt.Rows
                tblTipoProducto.Rows.Add(fila("idtipoproducto"), fila("tipoproducto"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error al listar tipos de producto: " & ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        txtIdTipoProducto.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdTipoProducto.Text = "" Then
            MessageBox.Show("Ingrese el ID para buscar")
            Return
        End If
        Try
            Dim obj As New capaNegocio.clsTipoProducto()
            Dim fila As DataRow = obj.buscarXid(Convert.ToInt32(txtIdTipoProducto.Text))
            If fila IsNot Nothing Then
                txtNombre.Text = Convert.ToString(fila("tipoproducto"))
            Else
                MessageBox.Show("No se encontró el tipo de producto con ese ID")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then
            btnNuevo.Text = "Guardar"
            limpiar()
        Else
            btnNuevo.Text = "Nuevo"
            Try
                Dim obj As New capaNegocio.clsTipoProducto()
                Dim id As Integer = obj.generarCodigoTipoProducto()
                obj.registrarTipoProducto(id, txtNombre.Text)
                MessageBox.Show("TIPO DE PRODUCTO REGISTRADO")
            Catch ex As Exception
                MessageBox.Show("Error al registrar: " & ex.Message)
            End Try
        End If
        limpiar()
        listar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdTipoProducto.Text = "" Then
            MessageBox.Show("Porfavor Seleccione un Producto para Modificar")
            Return
        End If
        Try
            Dim obj As New capaNegocio.clsTipoProducto()
            obj.modificarTipoProducto(Convert.ToInt32(txtIdTipoProducto.Text), txtNombre.Text)
            MessageBox.Show("TIPO DE PRODUCTO MODIFICADO")
        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message)
        End Try
        limpiar()
        listar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdTipoProducto.Text = "" Then
            MessageBox.Show("Porfavor Seleccione un Producto para Eliminar")
            Return
        End If
        Try
            Dim obj As New capaNegocio.clsTipoProducto()
            obj.eliminarTipoProducto(Convert.ToInt32(txtIdTipoProducto.Text))
            MessageBox.Show("TIPO DE PRODUCTO ELIMINADO")
        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        End Try
        limpiar()
        listar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub tblTipoProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblTipoProducto.CellClick
        If e.RowIndex < 0 Then
            Return
        End If
        txtIdTipoProducto.Text = Convert.ToString(tblTipoProducto.Rows(e.RowIndex).Cells(0).Value)
        txtNombre.Text = Convert.ToString(tblTipoProducto.Rows(e.RowIndex).Cells(1).Value)
    End Sub

    Private Sub JdGestionarTipoDeProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If jd IsNot Nothing Then
            jd.listarcbo()
        End If
    End Sub

End Class
