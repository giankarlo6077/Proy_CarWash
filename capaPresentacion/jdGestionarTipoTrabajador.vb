Imports capaNegocio

Public Class jdGestionarTipoTrabajador

    Dim objTipoTrabajador As New clsTipoTrabajador()

    Dim idSeleccionado As Integer = 0

    Sub listar()

        dgvTipoTrabajador.DataSource =
            objTipoTrabajador.listarTipoTrabajador()

        ' Ocultar ID
        dgvTipoTrabajador.Columns(0).Visible = False

        ' Nombre de columnas
        dgvTipoTrabajador.Columns(1).HeaderText =
            "Tipo de Trabajador"

        ' Configuración visual
        dgvTipoTrabajador.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvTipoTrabajador.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvTipoTrabajador.MultiSelect = False

        dgvTipoTrabajador.ReadOnly = True

        dgvTipoTrabajador.AllowUserToAddRows = False

    End Sub

    Sub limpiar()

        txtTipoTrabajador.Clear()

        idSeleccionado = 0

        btnRegistrar.Enabled = False

        txtTipoTrabajador.Focus()

    End Sub

    Private Sub jdGestionarTipoTrabajador_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        listar()

        btnRegistrar.Enabled = False

    End Sub

    Private Sub btnNuevo_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNuevo.Click

        limpiar()

        btnRegistrar.Enabled = True

        txtTipoTrabajador.Focus()

    End Sub

    Private Sub btnRegistrar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRegistrar.Click

        If txtTipoTrabajador.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese tipo de trabajador"
            )

            txtTipoTrabajador.Focus()

            Exit Sub

        End If

        Try

            objTipoTrabajador.
            registrarTipoTrabajador(
                txtTipoTrabajador.Text
            )

            MessageBox.Show(
                "Registro exitoso"
            )

            listar()

            limpiar()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnModificar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnModificar.Click

        If idSeleccionado = 0 Then

            MessageBox.Show(
                "Seleccione un registro"
            )

            Exit Sub

        End If

        If txtTipoTrabajador.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese tipo de trabajador"
            )

            txtTipoTrabajador.Focus()

            Exit Sub

        End If

        Try

            objTipoTrabajador.
            modificarTipoTrabajador(
                idSeleccionado,
                txtTipoTrabajador.Text
            )

            MessageBox.Show(
                "Modificado correctamente"
            )

            listar()

            limpiar()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnEliminar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEliminar.Click

        If idSeleccionado = 0 Then

            MessageBox.Show(
                "Seleccione un registro"
            )

            Exit Sub

        End If

        Try

            Dim rpta As DialogResult

            rpta = MessageBox.Show(
                "¿Desea eliminar el registro?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If rpta = DialogResult.Yes Then

                objTipoTrabajador.
                eliminarTipoTrabajador(
                    idSeleccionado
                )

                MessageBox.Show(
                    "Eliminado correctamente"
                )

                listar()

                limpiar()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnLimpiar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLimpiar.Click

        limpiar()

    End Sub

    Private Sub btnSalir_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub dgvTipoTrabajador_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvTipoTrabajador.CellClick

        If e.RowIndex >= 0 Then

            idSeleccionado =
                CInt(
                    dgvTipoTrabajador.Rows(e.RowIndex).
                    Cells(0).Value
                )

            txtTipoTrabajador.Text =
                dgvTipoTrabajador.Rows(e.RowIndex).
                Cells(1).Value.ToString()

        End If

    End Sub

End Class