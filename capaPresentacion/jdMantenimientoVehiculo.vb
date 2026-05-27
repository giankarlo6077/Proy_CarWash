Imports System.Data
Imports capaNegocio

Public Class jdMantenimientoVehiculo
    Dim objVehiculo As New clsVehiculo()

    ' La instanciamos por si necesitas acceder a ella más adelante
    Dim objTipoVehiculo As New clsTipoVehiculo()

    Private Sub jdMantenimientoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub Listar()
        Try
            Dim dt As DataTable = objVehiculo.listarVehiculo()
            tblVehiculo.DataSource = dt

            ' Formato opcional de columnas
            If tblVehiculo.Columns.Count > 0 Then
                tblVehiculo.Columns("ID").Width = 50
                tblVehiculo.Columns("Placa").Width = 100
            End If
        Catch ex As Exception
            MessageBox.Show("Error al listar:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' 1. Validamos que la caja no esté vacía ni tenga puros espacios en blanco
        If String.IsNullOrWhiteSpace(txtbuscador.Text) Then
            MessageBox.Show("Por favor, ingrese un número de placa para realizar la búsqueda.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbuscador.Focus() ' Ponemos el cursor en la cajita para que escriba
            Return
        End If

        Try
            ' Usamos Trim() por si el empleado dejó un espacio al final de la placa sin querer
            Dim placaBuscar As String = txtbuscador.Text.Trim()
            Dim dt As DataTable = objVehiculo.buscarPLacaTotal(placaBuscar)

            ' 2. Verificamos si la base de datos devolvió algún resultado
            If dt.Rows.Count > 0 Then
                tblVehiculo.DataSource = dt
            Else
                ' 3. Si no hay resultados, mostramos el mensaje de placa incorrecta
                MessageBox.Show("La placa ingresada es incorrecta o no está registrada en el sistema. Por favor, ingrese una placa válida.", "Vehículo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtbuscador.SelectAll() ' Seleccionamos el texto malo para que al teclear se borre solo
                txtbuscador.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGestionarPersona_Click(sender As Object, e As EventArgs) Handles btnGestionarPersona.Click
        Dim frm As New jdGestionarVehiculo()
        frm.ShowDialog()

        Listar()
    End Sub

    Private Sub txtbuscador_TextChanged(sender As Object, e As EventArgs) Handles txtbuscador.TextChanged

    End Sub
End Class