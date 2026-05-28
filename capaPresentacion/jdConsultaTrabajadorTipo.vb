Imports capaNegocio

Public Class jdConsultaTrabajadorTipo

    Dim objReporte As New clsReporteTrabajador()

    Dim objTipoTrabajador As New clsTipoTrabajador()

    '========================================
    ' LOAD
    '========================================
    Private Sub jdConsultaTrabajadorTipo_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        listarTiposTrabajador()

        listarReporte()

    End Sub

    '========================================
    ' LISTAR TIPOS TRABAJADOR
    '========================================
    Sub listarTiposTrabajador()

        Try

            cboTipoTrabajador.DataSource =
                objTipoTrabajador.listarTipoTrabajador()

            cboTipoTrabajador.DisplayMember =
                "tipoTrabajador"

            cboTipoTrabajador.ValueMember =
                "idTipoTrabajador"

            cboTipoTrabajador.SelectedIndex = -1

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
    ' LISTAR REPORTE
    '========================================
    Sub listarReporte()

        Try

            dgvReporte.DataSource =
                objReporte.listarReporteTrabajador()

            configurarTabla()

            lblTotal.Text =
                "Total trabajadores: " &
                dgvReporte.Rows.Count

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
            )

        End Try

    End Sub

    '========================================
    ' CONFIGURAR TABLA
    '========================================
    Sub configurarTabla()

        If dgvReporte.Columns.Count > 0 Then

            dgvReporte.Columns(0).HeaderText =
                "ID"

            dgvReporte.Columns(1).HeaderText =
                "Trabajador"

            dgvReporte.Columns(2).HeaderText =
                "DNI"

            dgvReporte.Columns(3).HeaderText =
                "Tipo Trabajador"

            dgvReporte.Columns(4).HeaderText =
                "Estado"

        End If

        dgvReporte.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvReporte.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvReporte.MultiSelect = False

        dgvReporte.ReadOnly = True

        dgvReporte.AllowUserToAddRows = False

        dgvReporte.AllowUserToDeleteRows = False

    End Sub

    '========================================
    ' BUSCAR / FILTRAR
    '========================================
    Private Sub btnBuscar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBuscar.Click

        Try

            If cboTipoTrabajador.SelectedIndex = -1 Then

                MessageBox.Show(
                    "Seleccione un tipo trabajador",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Exit Sub

            End If

            dgvReporte.DataSource =
                objReporte.filtrarTrabajadorPorTipo(
                    CInt(
                        cboTipoTrabajador.SelectedValue
                    )
                )

            configurarTabla()

            lblTotal.Text =
                "Total trabajadores: " &
                dgvReporte.Rows.Count

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
            )

        End Try

    End Sub


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
    ' MOSTRAR TODOS
    '========================================

    Private Sub btnMostrarTodo_Click_1(sender As Object, e As EventArgs) Handles btnMostrarTodo.Click
        cboTipoTrabajador.SelectedIndex = -1

        listarReporte()
    End Sub
End Class