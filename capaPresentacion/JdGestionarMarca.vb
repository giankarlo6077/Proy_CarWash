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
        Try
            Dim obj As New capaNegocio.clsMarca()
            Dim dt As DataTable = obj.listarMarca()
            tblMarca.Rows.Clear()
            For Each fila As DataRow In dt.Rows
                tblMarca.Rows.Add(fila("idmarcaproducto"), fila("marcaproducto"))
            Next
        Catch ex As Exception
            MessageBox.Show("Error al listar marcas: " & ex.Message)
        End Try
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
        Try
            Dim obj As New capaNegocio.clsMarca()
            Dim fila As DataRow = obj.buscarXid(Convert.ToInt32(txtIdMarca.Text))
            If fila IsNot Nothing Then
                txtNombre.Text = Convert.ToString(fila("marcaproducto"))
            Else
                MessageBox.Show("No se encontró la marca con ese ID")
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
                Dim obj As New capaNegocio.clsMarca()
                Dim id As Integer = obj.generarCodigoMarca()
                obj.registrarMarca(id, txtNombre.Text)
                MessageBox.Show("MARCA REGISTRADA")
                lista()
            Catch ex As Exception
                MessageBox.Show("Error al registrar: " & ex.Message)
            End Try
            limpiar()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdMarca.Text = "" Then
            MessageBox.Show("Seleccina una marca para modificar")
            Return
        End If
        Try
            Dim obj As New capaNegocio.clsMarca()
            obj.modificarMarca(Convert.ToInt32(txtIdMarca.Text), txtNombre.Text)
            MessageBox.Show("MARCA MODIFICADA")
            lista()
            limpiar()
        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdMarca.Text = "" Then
            MessageBox.Show("Seleccinoa una marca para eliminar")
            Return
        End If
        Try
            Dim obj As New capaNegocio.clsMarca()
            obj.eliminarMarca(Convert.ToInt32(txtIdMarca.Text))
            MessageBox.Show("MARCA ELIMINADA")
            lista()
            limpiar()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        End Try
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
