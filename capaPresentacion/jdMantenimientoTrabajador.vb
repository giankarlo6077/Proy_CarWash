Imports System.Data
Imports capaNegocio

Public Class jdMantenimientoTrabajador

    Dim objTrabajador As New clsTrabajador()

    Dim idTrabajadorSeleccionado As Integer = 0

    '========================================
    ' LISTAR
    '========================================
    Sub listar()

        Dim dt As DataTable =
            objTrabajador.ListarUsuariosGrid(
                txtBuscar.Text.Trim
            )

        ' Crear columna texto para mostrar estado
        If Not dt.Columns.Contains("EstadoTexto") Then

            dt.Columns.Add(
                "EstadoTexto",
                GetType(String)
            )

            For Each fila As DataRow In dt.Rows

                If Convert.ToBoolean(
                    fila("Activo")
                ) = True Then

                    fila("EstadoTexto") =
                        "Activo"

                Else

                    fila("EstadoTexto") =
                        "De baja"

                End If

            Next

        End If

        dgvTrabajador.DataSource = dt

        If dgvTrabajador.Columns.Count > 0 Then

            ' Ocultar columnas
            dgvTrabajador.Columns("ID").Visible = False

            dgvTrabajador.Columns("Activo").Visible = False

            ' Encabezados
            dgvTrabajador.Columns(
                "Empleado"
            ).HeaderText = "Trabajador"

            dgvTrabajador.Columns(
                "Usuario"
            ).HeaderText = "Usuario"

            dgvTrabajador.Columns(
                "EstadoTexto"
            ).HeaderText = "Estado"

        End If

        ' Diseño
        dgvTrabajador.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvTrabajador.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvTrabajador.MultiSelect = False

        dgvTrabajador.ReadOnly = True

        dgvTrabajador.AllowUserToAddRows = False

        dgvTrabajador.AllowUserToDeleteRows = False

        dgvTrabajador.ClearSelection()

        For Each fila As DataGridViewRow In dgvTrabajador.Rows

            If fila.Cells("EstadoTexto").Value.ToString() = "Activo" Then

                fila.Cells("EstadoTexto").Style.ForeColor =
                    Color.Green

            Else

                fila.Cells("EstadoTexto").Style.ForeColor =
                    Color.Red

            End If

        Next

    End Sub

    '========================================
    ' LOAD
    '========================================
    Private Sub jdMantenimientoTrabajador_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        listar()

    End Sub

    '========================================
    ' BUSCAR
    '========================================
    Private Sub txtBuscar_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtBuscar.TextChanged

        listar()

    End Sub

    '========================================
    ' SELECCIONAR FILA
    '========================================
    Private Sub dgvTrabajador_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvTrabajador.CellClick

        If e.RowIndex >= 0 Then

            idTrabajadorSeleccionado =
                CInt(
                    dgvTrabajador.Rows(e.RowIndex).
                    Cells("ID").Value
                )

        End If

    End Sub

    '========================================
    ' NUEVO
    '========================================
    Private Sub btnNuevo_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNuevo.Click

        Dim frm As New jdGestionarTrabajador()

        frm.ShowDialog()

        listar()

    End Sub

    '========================================
    ' EDITAR
    '========================================
    Private Sub btnEditar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEditar.Click

        If idTrabajadorSeleccionado = 0 Then

            MessageBox.Show(
                "Seleccione un trabajador",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        Dim frm As New jdGestionarTrabajador()

        frm.idTrabajador =
            idTrabajadorSeleccionado

        frm.ShowDialog()

        listar()

    End Sub

    '========================================
    ' DAR BAJA
    '========================================
    Private Sub btnDarBaja_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDarBaja.Click

        If idTrabajadorSeleccionado = 0 Then

            MessageBox.Show(
                "Seleccione un trabajador",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        Try

            Dim rpta As DialogResult

            rpta = MessageBox.Show(
                "¿Desea dar de baja al trabajador?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If rpta = DialogResult.Yes Then

                objTrabajador.cambiarEstadoTrabajador(
                    idTrabajadorSeleccionado,
                    False
                )

                MessageBox.Show(
                    "Trabajador dado de baja correctamente",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                listar()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    '========================================
    ' REACTIVAR
    '========================================


    '========================================
    ' CERRAR
    '========================================
    Private Sub btnCerrar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCerrar.Click

        Me.Close()

    End Sub

    '========================================
    ' EVITAR ERROR DATAGRIDVIEW
    '========================================
    Private Sub dgvTrabajador_DataError(
        sender As Object,
        e As DataGridViewDataErrorEventArgs
    ) Handles dgvTrabajador.DataError

        e.ThrowException = False

    End Sub

End Class