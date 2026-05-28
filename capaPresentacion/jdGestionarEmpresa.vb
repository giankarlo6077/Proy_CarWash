Imports capaNegocio

Public Class jdGestionarEmpresa

    Dim objEmpresa As New clsEmpresa()

    Dim idEmpresaSeleccionado As Integer = 0

    '========================================
    ' LOAD
    '========================================
    Private Sub jdGestionarEmpresa_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        listar()

        limpiar()

        btnModificar.Enabled = False

        btnEliminar.Enabled = False

    End Sub

    '========================================
    ' LISTAR EMPRESAS
    '========================================
    Sub listar()

        Try

            dgvEmpresa.DataSource =
                objEmpresa.listarEmpresa()

            If dgvEmpresa.Columns.Count >= 4 Then

                ' Ocultar ID Empresa
                dgvEmpresa.Columns(0).Visible = False

                dgvEmpresa.Columns(1).HeaderText =
                    "ID Cliente"

                dgvEmpresa.Columns(2).HeaderText =
                    "Razón Social"

                dgvEmpresa.Columns(3).HeaderText =
                    "RUC"

            End If

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
    ' LIMPIAR
    '========================================
    Sub limpiar()

        txtEmpresa.Clear()

        txtRazonSocial.Clear()

        txtRUC.Clear()

        idEmpresaSeleccionado = 0

        deshabilitarCampos()

        dgvEmpresa.ClearSelection()

        btnModificar.Enabled = False

        btnEliminar.Enabled = False

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
                "Ingrese razón social"
            )

            txtRazonSocial.Focus()

            Return False

        End If

        If txtRUC.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese RUC"
            )

            txtRUC.Focus()

            Return False

        End If

        If Not IsNumeric(txtRUC.Text) Then

            MessageBox.Show(
                "El RUC debe ser numérico"
            )

            txtRUC.Focus()

            Return False

        End If

        If txtRUC.TextLength <> 11 Then

            MessageBox.Show(
                "El RUC debe tener 11 dígitos"
            )

            txtRUC.Focus()

            Return False

        End If

        Return True

    End Function

    '========================================
    ' BUSCAR EMPRESA
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

            If dgvEmpresa.Columns.Count >= 4 Then

                dgvEmpresa.Columns(0).Visible = False

                dgvEmpresa.Columns(1).HeaderText =
                    "ID Cliente"

                dgvEmpresa.Columns(2).HeaderText =
                    "Razón Social"

                dgvEmpresa.Columns(3).HeaderText =
                    "RUC"

            End If

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
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

                habilitarCampos()

                btnModificar.Enabled = True

                btnEliminar.Enabled = True

                idEmpresaSeleccionado =
                    CInt(
                        dgvEmpresa.Rows(e.RowIndex).
                        Cells(0).Value
                    )

                txtRazonSocial.Text =
                    dgvEmpresa.Rows(e.RowIndex).
                    Cells(2).Value.ToString()

                txtRUC.Text =
                    dgvEmpresa.Rows(e.RowIndex).
                    Cells(3).Value.ToString()

            End If

        Catch ex As Exception

            MessageBox.Show(
                "Error al seleccionar empresa"
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
                "Seleccione una empresa"
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
                "Empresa modificada correctamente"
            )

            listar()

            limpiar()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
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
                "Seleccione una empresa"
            )

            Exit Sub

        End If

        Try

            Dim rpta As DialogResult

            rpta = MessageBox.Show(
                "¿Desea eliminar la empresa?",
                "Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If rpta = DialogResult.Yes Then

                objEmpresa.eliminarEmpresa(
                    idEmpresaSeleccionado
                )

                MessageBox.Show(
                    "Empresa eliminada correctamente"
                )

                listar()

                limpiar()

            End If

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
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