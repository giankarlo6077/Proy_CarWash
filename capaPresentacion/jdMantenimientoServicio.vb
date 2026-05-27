Imports System.Data
Imports capaNegocio

Public Class jdMantenimientoServicio
    Dim objServicio As New clsServicio()
    Dim objTipoVehiculo As New clsTipoVehiculo()

    Private Sub jdMantenimientoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Llenamos el ComboBox de ordenamiento desde el código
        cboOrdenar.Items.Clear()
        cboOrdenar.Items.Add("Código")
        cboOrdenar.Items.Add("Nombre")
        cboOrdenar.Items.Add("Precio")
        cboOrdenar.Items.Add("Tiempo Estimado")
        cboOrdenar.Items.Add("Tipo de Vehículo")

        If cboOrdenar.Items.Count > 0 Then
            cboOrdenar.SelectedIndex = 0
        End If

        ' 2. Bloqueamos los ComboBox para que el usuario no pueda escribir texto inventado
        cboOrdenar.DropDownStyle = ComboBoxStyle.DropDownList
        cboTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList

        ' 3. Cargamos los datos iniciales
        ListarTiposVehiculos()
        ListarServicios()

        ' 4. Configuramos la tabla para que sea de solo lectura y ocupe todo el espacio
        tblServicios.AllowUserToAddRows = False
        tblServicios.AllowUserToDeleteRows = False
        tblServicios.ReadOnly = True
        tblServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        tblServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Método auxiliar para formatear la tabla con la columna "Estado" traducida a texto
    Private Sub MostrarDatosEnGrilla(dtOriginal As DataTable)
        Dim dtUI As New DataTable()
        dtUI.Columns.Add("Código")
        dtUI.Columns.Add("Nombre")
        dtUI.Columns.Add("Precio")
        dtUI.Columns.Add("Tiempo Estimado")
        dtUI.Columns.Add("Tipo de Vehículo")
        dtUI.Columns.Add("Estado")

        For Each row As DataRow In dtOriginal.Rows
            Dim estadoTxt As String = "No vigente"
            ' Verificamos que el campo estado no sea nulo y evaluamos si es True/False (1/0)
            If Not IsDBNull(row("estado")) AndAlso Convert.ToBoolean(row("estado")) Then
                estadoTxt = "Vigente"
            End If

            dtUI.Rows.Add(row("idServicio"), row("servicio"), row("precioactual"), row("duracion"), row("tipovehiculo"), estadoTxt)
        Next

        tblServicios.Columns.Clear()
        tblServicios.DataSource = dtUI
    End Sub

    Private Sub ListarServicios()
        Try
            Dim dt As DataTable = objServicio.listarServicio()
            MostrarDatosEnGrilla(dt)
        Catch ex As Exception
            MessageBox.Show("Error al listar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListarTiposVehiculos()
        Try
            Dim dt As DataTable = objTipoVehiculo.listarTipoVehiculo()
            cboTipoVehiculo.Items.Clear()
            cboTipoVehiculo.Items.Add("Todos")

            For Each row As DataRow In dt.Rows
                cboTipoVehiculo.Items.Add(row("tipoVehiculo").ToString())
            Next

            If cboTipoVehiculo.Items.Count > 0 Then
                cboTipoVehiculo.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error al listar tipos de vehículos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dtResultado As DataTable = Nothing
        Dim textoCodigo As String = txtBuscarServicios.Text.Trim()
        Dim tipoSeleccionado As String = cboTipoVehiculo.SelectedItem.ToString()

        Try
            If textoCodigo = "" AndAlso tipoSeleccionado = "Todos" Then
                dtResultado = objServicio.listarServicio()
            ElseIf textoCodigo <> "" AndAlso tipoSeleccionado <> "Todos" Then
                Dim codigo As Integer = Convert.ToInt32(textoCodigo)
                dtResultado = objServicio.buscarServicioPorTipoYCodigo(tipoSeleccionado, codigo)
            ElseIf textoCodigo <> "" Then
                Dim codigo As Integer = Convert.ToInt32(textoCodigo)
                dtResultado = objServicio.buscarServicioPorCodigo(codigo)
            ElseIf tipoSeleccionado <> "Todos" Then
                dtResultado = objServicio.buscarServicioPorTipo(tipoSeleccionado)
            End If

            If dtResultado IsNot Nothing AndAlso dtResultado.Rows.Count > 0 Then
                MostrarDatosEnGrilla(dtResultado)
            Else
                tblServicios.DataSource = Nothing
                MessageBox.Show("No se encontraron resultados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar: Verifique que el código sea un número válido. " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        If cboOrdenar.SelectedIndex = -1 Then Return

        Dim columna As String = cboOrdenar.SelectedItem.ToString()
        Try
            Dim dt As DataTable = objServicio.ordenarPor(columna)
            MostrarDatosEnGrilla(dt)
        Catch ex As Exception
            MessageBox.Show("Error al ordenar la tabla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim obj As New jdGestionarServicio()
        obj.ShowDialog()
        ListarServicios()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If tblServicios.CurrentRow Is Nothing Then
            MessageBox.Show("Por favor, seleccione una fila para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Obtenemos los valores directo de la fila seleccionada en el DataGridView
            Dim idServicio As Integer = Convert.ToInt32(tblServicios.CurrentRow.Cells(0).Value)
            Dim tipoVehiculo As String = tblServicios.CurrentRow.Cells(4).Value.ToString()
            Dim idTipoVehiculo As Integer = objTipoVehiculo.obtenerCodigoTipoVehiculo(tipoVehiculo)

            Dim obj As New jdGestionarServicio(idServicio, idTipoVehiculo)
            obj.ShowDialog()
            ListarServicios()
        Catch ex As Exception
            MessageBox.Show("Error al preparar edición: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tblServicios.CurrentRow Is Nothing Then
            MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este servicio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Try
                Dim idServicio As Integer = Convert.ToInt32(tblServicios.CurrentRow.Cells(0).Value)
                objServicio.eliminarServicio(idServicio)

                MessageBox.Show("Servicio eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarServicios()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class