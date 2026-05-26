Imports System.Data
Imports capaNegocio

Public Class jdGestionarVehiculo
    Dim objVehiculo As New clsVehiculo()
    Dim objModeloVehiculo As New clsModeloVehiculo()

    Private idVehiculoSeleccionado As Integer = -1
    Private estadoActual As Integer = 1

    Private Sub jdGestionarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        ListarcboModelo()
        cboMarcaProducto.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Limpiar()
        txtNombre.Clear()
        txtdoc.Clear()
        txtfabricacion.Clear()
        cboMarcaProducto.SelectedIndex = -1
        idVehiculoSeleccionado = -1
        btnNuevo.Text = "Nuevo"
        btnDarsebaja.Text = "Dar de baja"
    End Sub

    Private Sub Listar()
        Try
            tblVehiculo.DataSource = objVehiculo.listarVehiculo()
        Catch ex As Exception
            MessageBox.Show("Error al listar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListarcboModelo()
        Try
            cboMarcaProducto.Items.Clear()
            Dim dt As DataTable = objModeloVehiculo.listar()
            Dim listaModelos As New List(Of String)
            For Each row As DataRow In dt.Rows
                Dim modelo As String = row("modelovehiculo").ToString().Trim()
                If Not listaModelos.Contains(modelo) Then
                    listaModelos.Add(modelo)
                    cboMarcaProducto.Items.Add(modelo)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar modelos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("Ingrese una Placa para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dt As DataTable = objVehiculo.buscarPLacaTotal(txtNombre.Text.Trim())
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                idVehiculoSeleccionado = Convert.ToInt32(row("ID"))
                txtfabricacion.Text = row("Año de fabricacion").ToString()
                cboMarcaProducto.SelectedItem = row("Modelo").ToString()
                txtdoc.Text = row("DNI").ToString()

                If IsDBNull(row("estado")) Then
                    estadoActual = 1 ' Valor por defecto si no hay nada en la BD
                Else
                    estadoActual = Convert.ToInt32(row("estado"))
                End If
                btnDarsebaja.Text = If(estadoActual = 1, "Dar de baja", "Activar")
            Else
                MessageBox.Show("Vehículo no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then
            Limpiar()
            idVehiculoSeleccionado = objVehiculo.obtenercod()
            btnNuevo.Text = "Guardar"
        Else
            Try
                Dim anofabricacion As Integer
                If Not Integer.TryParse(txtfabricacion.Text.Trim(), anofabricacion) OrElse String.IsNullOrWhiteSpace(txtNombre.Text) OrElse cboMarcaProducto.SelectedIndex = -1 Then
                    MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim idClienteFinal As Integer = objVehiculo.obtenerIdClientePorDNI(txtdoc.Text.Trim())
                If idClienteFinal = -1 Then
                    MessageBox.Show("El DNI ingresado no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim modeloV As Integer = objModeloVehiculo.buscarIdxNombre(cboMarcaProducto.SelectedItem.ToString())
                objVehiculo.registrar(idVehiculoSeleccionado, txtNombre.Text.Trim(), anofabricacion, modeloV, idClienteFinal)

                MessageBox.Show("Vehículo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                Listar()
            Catch ex As Exception
                MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If idVehiculoSeleccionado = -1 Then Return
        Try
            Dim idClienteFinal As Integer = objVehiculo.obtenerIdClientePorDNI(txtdoc.Text.Trim())
            Dim modeloV As Integer = objModeloVehiculo.buscarIdxNombre(cboMarcaProducto.SelectedItem.ToString())

            objVehiculo.Modificar(idVehiculoSeleccionado, txtNombre.Text.Trim(), idClienteFinal, Convert.ToInt32(txtfabricacion.Text), modeloV)
            MessageBox.Show("Vehículo modificado.", "Éxito")
            Listar()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idVehiculoSeleccionado = -1 Then Return
        Dim res As DialogResult = MessageBox.Show("¿Seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo)
        If res = DialogResult.Yes Then
            Try
                objVehiculo.eliminarVehiculo(idVehiculoSeleccionado)
                Listar()
                Limpiar()
            Catch ex As Exception
                MessageBox.Show("El vehículo tiene citas asociadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub

    Private Sub btnDarsebaja_Click(sender As Object, e As EventArgs) Handles btnDarsebaja.Click
        If idVehiculoSeleccionado = -1 Then Return
        Dim nuevoEstado As Integer = If(estadoActual = 1, 0, 1)
        Dim msg As String = If(estadoActual = 1, "¿Desea dar de baja?", "¿Desea activar?")

        If MessageBox.Show(msg, "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            objVehiculo.cambiarEstadoVehiculo(idVehiculoSeleccionado, nuevoEstado)
            Listar()
            Limpiar()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub tblVehiculo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblVehiculo.CellClick
        If e.RowIndex >= 0 Then
            Try
                txtNombre.Text = tblVehiculo.Rows(e.RowIndex).Cells("Placa").Value.ToString()
                btnBuscar_Click(Nothing, Nothing)
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class