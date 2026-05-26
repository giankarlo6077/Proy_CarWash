Imports capaNegocio

Public Class jdGestionarEmpresa

    Dim objEmpresa As New clsEmpresa()

    Dim idEmpresaSeleccionado As Integer = 0

    '========================================
    ' LISTAR EMPRESAS
    '========================================
    Sub listar()

        Try

            dgvEmpresa.DataSource =
                objEmpresa.listarEmpresa()

            ' Validar columnas
            If dgvEmpresa.Columns.Count >= 3 Then

                ' Ocultar ID
                dgvEmpresa.Columns(0).Visible = False

                ' Encabezados
                dgvEmpresa.Columns(1).HeaderText =
                    "Razón Social"

                dgvEmpresa.Columns(2).HeaderText =
                    "RUC"

            End If

            ' Configuración visual
            dgvEmpresa.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            dgvEmpresa.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

            dgvEmpresa.MultiSelect = False

            dgvEmpresa.ReadOnly = True

            dgvEmpresa.AllowUserToAddRows = False

            dgvEmpresa.AllowUserToDeleteRows = False

            dgvEmpresa.ClearSelection()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    '========================================
    ' LIMPIAR CAMPOS
    '========================================
    Sub limpiar()

        txtEmpresa.Clear()
        txtRazonSocial.Clear()
        txtRUC.Clear()

        idEmpresaSeleccionado = 0

        deshabilitarCampos()

        btnRegistrar.Enabled = False

        dgvEmpresa.ClearSelection()

    End Sub

    '========================================
    ' HABILITAR CAMPOS
    '========================================
    Sub habilitarCampos()

        txtRazonSocial.Enabled = True
        txtRUC.Enabled = True

    End Sub

    '========================================
    ' DESHABILITAR CAMPOS
    '========================================
    Sub deshabilitarCampos()

        txtRazonSocial.Enabled = False
        txtRUC.Enabled = False

    End Sub

    '========================================
    ' VALIDAR CAMPOS
    '========================================
    Function validarCampos() As Boolean

        If txtRazonSocial.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese razón social",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtRazonSocial.Focus()

            Return False

        End If

        If txtRUC.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese RUC",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtRUC.Focus()

            Return False

        End If

        If Not IsNumeric(txtRUC.Text) Then

            MessageBox.Show(
                "El RUC debe contener números",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtRUC.Focus()

            Return False

        End If

        If txtRUC.TextLength <> 11 Then

            MessageBox.Show(
                "El RUC debe tener 11 dígitos",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtRUC.Focus()

            Return False

        End If

        Return True

    End Function

    '========================================
    ' LOAD
    '========================================
    Private Sub jdGestionarEmpresa_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        listar()

        deshabilitarCampos()

        btnRegistrar.Enabled = False

    End Sub

    '========================================
    ' NUEVO
    '========================================
    Private Sub btnNuevo_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNuevo.Click

        limpiar()

        habilitarCampos()

        btnRegistrar.Enabled = True

        txtRazonSocial.Focus()

    End Sub

    '========================================
    ' REGISTRAR
    '========================================
    Private Sub btnRegistrar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRegistrar.Click

        If validarCampos() = False Then
            Exit Sub
        End If

        Try

            objEmpresa.registrarEmpresa(
                txtRazonSocial.Text.Trim,
                txtRUC.Text.Trim
            )

            MessageBox.Show(
                "Empresa registrada correctamente",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            listar()

            limpiar()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    '========================================
    ' MODIFICAR
    '========================================
    Private Sub btnModificar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnModificar.Click

        If idEmpresaSeleccionado = 0 Then

            MessageBox.Show(
                "Seleccione una empresa",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        If validarCampos() = False Then
            Exit Sub
        End If

        Try

            objEmpresa.modificarEmpresa(
                idEmpresaSeleccionado,
                txtRazonSocial.Text.Trim,
                txtRUC.Text.Trim
            )

            MessageBox.Show(
                "Empresa modificada correctamente",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            listar()

            limpiar()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    '========================================
    ' ELIMINAR
    '========================================
    Private Sub btnEliminar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEliminar.Click

        If idEmpresaSeleccionado = 0 Then

            MessageBox.Show(
                "Seleccione una empresa",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        Try

            Dim rpta As DialogResult

            rpta = MessageBox.Show(
                "¿Desea eliminar la empresa?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If rpta = DialogResult.Yes Then

                objEmpresa.eliminarEmpresa(
                    idEmpresaSeleccionado
                )

                MessageBox.Show(
                    "Empresa eliminada correctamente",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                listar()

                limpiar()

            End If

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    '========================================
    ' BUSCAR
    '========================================
    Private Sub txtEmpresa_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtEmpresa.TextChanged

        Try

            dgvEmpresa.DataSource =
                objEmpresa.buscarEmpresa(
                    txtEmpresa.Text.Trim
                )

            ' Configurar columnas
            If dgvEmpresa.Columns.Count >= 3 Then

                dgvEmpresa.Columns(0).Visible = False

                dgvEmpresa.Columns(1).HeaderText =
                    "Razón Social"

                dgvEmpresa.Columns(2).HeaderText =
                    "RUC"

            End If

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    '========================================
    ' SELECCIONAR FILA
    '========================================
    Private Sub dgvEmpresa_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvEmpresa.CellClick

        Try

            If e.RowIndex >= 0 Then

                If dgvEmpresa.Rows.Count > 0 Then

                    habilitarCampos()

                    btnRegistrar.Enabled = False

                    idEmpresaSeleccionado =
                        CInt(
                            dgvEmpresa.Rows(e.RowIndex).
                            Cells(0).Value
                        )

                    txtRazonSocial.Text =
                        dgvEmpresa.Rows(e.RowIndex).
                        Cells(1).Value.ToString()

                    txtRUC.Text =
                        dgvEmpresa.Rows(e.RowIndex).
                        Cells(2).Value.ToString()

                End If

            End If

        Catch ex As Exception

            MessageBox.Show(
                "Error al seleccionar fila",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        End Try

    End Sub

    '========================================
    ' LIMPIAR
    '========================================
    Private Sub btnLimpiar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLimpiar.Click

        limpiar()

    End Sub

    '========================================
    ' CERRAR
    '========================================
    Private Sub Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button1.Click

        Me.Close()

    End Sub

End Class