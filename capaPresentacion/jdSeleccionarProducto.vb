Imports capaNegocio

Public Class jdSeleccionarProducto
    Dim objCita As New clsCita
    Public Property ProductoSeleccionado As DataRow

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub jdSeleccionarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSelecProduct.DataSource = objCita.listarProductos
        dgvSelecProduct.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub

    Private Sub dgvSelecProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelecProduct.CellClick
        If e.RowIndex >= 0 Then
            Dim dt As DataTable = CType(dgvSelecProduct.DataSource, DataTable)
            ProductoSeleccionado = dt.Rows(e.RowIndex)
            Me.Close()
        End If
    End Sub

End Class