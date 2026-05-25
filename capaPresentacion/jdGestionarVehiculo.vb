Imports System.Data
Imports capaNegocio

Public Class jdGestionarVehiculo
    Dim objVehiculo As New clsVehiculo()
    Dim objModeloVehiculo As New clsModeloVehiculo()
    Dim objCliente As New clsCliente()

    ' Variable oculta para almacenar el ID del vehículo que estamos gestionando
    Private idVehiculoSeleccionado As Integer = -1

    Private Sub jdGestionarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        ListarcboModelo()
    End Sub

    Private Sub Limpiar()
        txtNombre.Clear() ' Esta es tu caja de texto de la Placa
        txtdoc.Clear()
        txtfabricacion.Clear()
        cboMarcaProducto.SelectedIndex = -1

        ' Reiniciamos el ID oculto
        idVehiculoSeleccionado = -1
    End Sub

    Private Sub Listar()
        Try
            Dim dt As DataTable = objVehiculo.listarVehiculo()
            tblVehiculo.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al listar:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListarcboModelo()
        Try
            Dim dt As DataTable = objModeloVehiculo.listar()
            cboMarcaProducto.Items.Clear()
            For Each row As DataRow In dt.Rows
                cboMarcaProducto.Items.Add(row("modelovehiculo").ToString())
            Next
            cboMarcaProducto.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar modelos:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Ahora validamos que se haya escrito una Placa
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("Ingrese una Placa para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim placaBuscar As String = txtNombre.Text.Trim()
            Dim dt As DataTable = objVehiculo.buscarVehiculoPorPlaca(placaBuscar)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)

                ' Guardamos el ID de forma silenciosa en la memoria
                idVehiculoSeleccionado = Convert.ToInt32(row("idvehiculo"))

                ' Llenamos el resto del formulario
                txtfabricacion.Text = row("anofabricacion").ToString()

                Dim idModelo As Integer = Convert.ToInt32(row("idmodelovehiculo"))
                Dim dtModelo As DataTable = objModeloVehiculo.buscarxId(idModelo)
                If dtModelo.Rows.Count > 0 Then
                    cboMarcaProducto.SelectedItem = dtModelo.Rows(0)("modelovehiculo").ToString()
                End If

                txtdoc.Text = row("idcliente").ToString()
            Else
                MessageBox.Show("EL VEHÍCULO NO EXISTE O NO SE ENCUENTRA DISPONIBLE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If btnNuevo.Text = "Nuevo" Then
                Limpiar()
                ' Generamos el nuevo código y lo guardamos en la variable interna
                idVehiculoSeleccionado = objVehiculo.obtenercod()
                btnNuevo.Text = "Guardar"
            Else
                ' Evitamos errores por si se borró la variable
                If idVehiculoSeleccionado = -1 Then
                    idVehiculoSeleccionado = objVehiculo.obtenercod()
                End If

                Dim nombre As String = txtNombre.Text ' Placa
                Dim anofabricacion As Integer = Convert.ToInt32(txtfabricacion.Text)
                Dim cliente As Integer = Convert.ToInt32(txtdoc.Text)

                Dim nombreModelo As String = cboMarcaProducto.SelectedItem.ToString()
                Dim modeloV As Integer = objModeloVehiculo.buscarIdxNombre(nombreModelo)

                ' Llama al método de registrar usando el ID interno
                objVehiculo.registrar(idVehiculoSeleccionado, nombre, anofabricacion, modeloV, cliente)
                MessageBox.Show("PRODUCTO CORRECTAMENTE GUARDADO", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                btnNuevo.Text = "Nuevo"
                Limpiar()
                Listar()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al procesar el registro:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' Verificamos si hay un vehículo cargado en memoria
        If idVehiculoSeleccionado = -1 Then
            MessageBox.Show("Busque un vehículo por placa primero para poder modificarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim nombre As String = txtNombre.Text ' Placa
            Dim anofabricacion As Integer = Convert.ToInt32(txtfabricacion.Text)
            Dim cliente As Integer = Convert.ToInt32(txtdoc.Text)

            Dim nombreModelo As String = cboMarcaProducto.SelectedItem.ToString()
            Dim modeloV As Integer = objModeloVehiculo.buscarIdxNombre(nombreModelo)

            ' Modificamos usando el ID interno
            objVehiculo.Modificar(idVehiculoSeleccionado, nombre, cliente, anofabricacion, modeloV)

            MessageBox.Show("PRODUCTO CORRECTAMENTE MODIFICADO", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Listar()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show("Error al modificar:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificamos si hay un vehículo cargado en memoria
        If idVehiculoSeleccionado = -1 Then
            MessageBox.Show("Busque un vehículo por placa primero para poder eliminarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Realmente quiere eliminar este vehículo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If respuesta = DialogResult.Yes Then
            Try
                ' Eliminamos usando el ID interno
                objVehiculo.eliminarVehiculo(idVehiculoSeleccionado)
                Limpiar()
                MessageBox.Show("VEHÍCULO ELIMINADO", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Listar()
            Catch ex As Exception
                MessageBox.Show("Error al Eliminar vehiculo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDarsebaja_Click(sender As Object, e As EventArgs) Handles btnDarsebaja.Click
        ' Botón vacío en el código original de Java
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
End Class