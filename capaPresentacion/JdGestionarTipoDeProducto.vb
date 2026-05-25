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
        ' TODO: integrar con la capa de negocio (listarTipoProducto) en una siguiente etapa
    End Sub

    Public Sub limpiar()
        txtIdTipoProducto.Text = ""
        txtNombre.Text = ""
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
            ' TODO: registrar tipo de producto mediante la capa de negocio en una siguiente etapa
        End If
        limpiar()
        listar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdTipoProducto.Text = "" Then
            MessageBox.Show("Porfavor Seleccione un Producto para Modificar")
            Return
        End If
        ' TODO: modificar tipo de producto mediante la capa de negocio en una siguiente etapa
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
        ' TODO: eliminar tipo de producto mediante la capa de negocio en una siguiente etapa
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
