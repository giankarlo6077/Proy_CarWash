Imports capaNegocio

Public Class jdSeleccionarServicio
    Dim objCita As New clsCita
    Public Property ServicioSeleccionado As DataRow

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub jdSeleccionarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSelecServicios.DataSource = objCita.listarServicios
        dgvSelecServicios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub

    Private Sub dgvSelecServicios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelecServicios.CellClick
        If e.RowIndex >= 0 Then
            Dim dt As DataTable = CType(dgvSelecServicios.DataSource, DataTable)
            ServicioSeleccionado = dt.Rows(e.RowIndex)
            Me.Close()
        End If
    End Sub


End Class