Imports capaNegocio

Public Class jdReporteVehiculo
    Dim objReporte As New clsReporteVehiculo()

    ' 1. EVENTO LOAD: Se ejecuta apenas abres la ventana
    Private Sub jdReporteVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Le pasamos un texto vacío para que traiga TODOS los vehículos
        CargarDatos("")
    End Sub

    ' 2. EVENTO CLIC: Se ejecuta al presionar la lupa
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Le pasamos lo que el usuario escribió
        CargarDatos(txtPlaca.Text.Trim())
    End Sub

    ' 3. MÉTODO AUXILIAR: Centraliza la lógica de llenado de la tabla
    Private Sub CargarDatos(placa As String)
        Try
            ' Obtenemos los datos con nuestra nueva consulta súper poderosa
            Dim dtHistorial As DataTable = objReporte.ListarHistorial(placa)

            If dtHistorial.Rows.Count > 0 Then
                ' Llenamos la tabla directamente, ya viene con la columna "Total Visitas" desde SQL
                dgvHistorial.DataSource = dtHistorial

                ' Ajustes visuales
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvHistorial.AllowUserToAddRows = False
            Else
                ' Si no hay datos, limpiamos la tabla
                dgvHistorial.DataSource = Nothing

                ' Solo mostramos mensaje de error si el usuario intentó buscar algo específico
                If placa <> "" Then
                    MessageBox.Show("No se encontró historial para la placa: " & placa, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtPlaca.Clear()
                    txtPlaca.Focus()
                    CargarDatos("") ' Volvemos a cargar toda la lista para que no quede vacía la pantalla
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Opcional: Buscar presionando Enter
    Private Sub txtPlaca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPlaca.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnBuscar.PerformClick()
        End If
    End Sub
End Class