Public Class JdGestionarMarca

    Private jd As JdGestionarProducto

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal jd As JdGestionarProducto)
        InitializeComponent()
        Me.jd = jd
    End Sub

    Private Sub JdGestionarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarTabla()
        lista()
    End Sub

    Private Sub configurarTabla()
        tblMarca.Columns.Clear()
        tblMarca.Columns.Add("ID", "ID")
        tblMarca.Columns.Add("NOMBRE", "NOMBRE")
    End Sub

    Public Sub lista()
        ' TODO: integrar con la capa de negocio (listarMarca) en una siguiente etapa
    End Sub

    Public Sub limpiar()
        txtIdMarca.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdMarca.Text = "" Then
            MessageBox.Show("Ingresa por favor el id para buscar")
            Return
        End If
        ' TODO: integrar con la capa de negocio (buscarXid) en una siguiente etapa
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then
            btnNuevo.Text = "Guardar"
            limpiar()
        Else
            btnNuevo.Text = "Nuevo"
            ' TODO: registrar marca mediante la capa de negocio en una siguiente etapa
            limpiar()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdMarca.Text = "" Then
            MessageBox.Show("Seleccina una marca para modificar")
            Return
        End If
        ' TODO: modificar marca mediante la capa de negocio en una siguiente etapa
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdMarca.Text = "" Then
            MessageBox.Show("Seleccinoa una marca para eliminar")
            Return
        End If
        ' TODO: eliminar marca mediante la capa de negocio en una siguiente etapa
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub tblMarca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblMarca.CellClick
        If e.RowIndex < 0 Then
            Return
        End If
        txtIdMarca.Text = Convert.ToString(tblMarca.Rows(e.RowIndex).Cells(0).Value)
        txtNombre.Text = Convert.ToString(tblMarca.Rows(e.RowIndex).Cells(1).Value)
    End Sub

    Private Sub JdGestionarMarca_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If jd IsNot Nothing Then
            jd.listarcbo()
        End If
    End Sub

End Class
