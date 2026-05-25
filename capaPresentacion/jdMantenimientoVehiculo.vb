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
        If String.IsNullOrWhiteSpace(txtbuscador.Text) Then
            Listar()
        Else
            Try
                Dim dt As DataTable = objVehiculo.buscarPLacaTotal(txtbuscador.Text)

                If dt.Rows.Count > 0 Then
                    tblVehiculo.DataSource = dt
                Else
                    MessageBox.Show("No se encontró ninguna coincidencia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al buscar:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnGestionarPersona_Click(sender As Object, e As EventArgs) Handles btnGestionarPersona.Click
        ' Ojo aquí: asegúrate de tener creado el formulario JdGestionarVehiculo en VB.NET
        Dim frm As New jdGestionarVehiculo()
        frm.ShowDialog()

        Listar()
    End Sub
End Class