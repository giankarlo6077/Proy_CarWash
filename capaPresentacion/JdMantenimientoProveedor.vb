Imports capaNegocio

Public Class JdMantenimientoProveedor

    Dim objProveedor As New clsProveedor()
    Dim _idProveedor As Integer = 0

    ' ══════════════════════════════════════════════
    '  CARGA
    ' ══════════════════════════════════════════════

    Private Sub JdMantenimientoProveedor_Load(
        sender As Object, e As EventArgs
    ) Handles MyBase.Load

        configurarGrilla()
        cargarGrilla()

    End Sub

    ' ══════════════════════════════════════════════
    '  CONFIGURACIÓN GRILLA
    ' ══════════════════════════════════════════════

    Private Sub configurarGrilla()

        dgvProveedores.AutoGenerateColumns = False
        dgvProveedores.Columns.Clear()

        dgvProveedores.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "idProveedor",
            .HeaderText = "ID",
            .DataPropertyName = "idProveedor",
            .Visible = False
        })
        dgvProveedores.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Proveedor",
            .DataPropertyName = "proveedor",
            .Width = 190
        })
        dgvProveedores.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "RUC",
            .DataPropertyName = "ruc",
            .Width = 95
        })
        dgvProveedores.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Teléfono",
            .DataPropertyName = "telefono",
            .Width = 80
        })
        dgvProveedores.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Correo",
            .DataPropertyName = "correo",
            .Width = 150
        })
        dgvProveedores.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Dirección",
            .DataPropertyName = "direccion",
            .Width = 150
        })
        dgvProveedores.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Contacto",
            .DataPropertyName = "contacto",
            .Width = 110
        })
        dgvProveedores.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Estado",
            .DataPropertyName = "estado",
            .Width = 65
        })

        dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProveedores.MultiSelect = False
        dgvProveedores.ReadOnly = True
        dgvProveedores.AllowUserToAddRows = False
        dgvProveedores.RowHeadersVisible = False

    End Sub

    ' ══════════════════════════════════════════════
    '  CARGAR GRILLA
    ' ══════════════════════════════════════════════

    Private Sub cargarGrilla()

        dgvProveedores.DataSource = objProveedor.listarProveedor()
        _idProveedor = 0
        btnEditar.Enabled = False
        btnDarDeBaja.Enabled = False

    End Sub

    ' ══════════════════════════════════════════════
    '  SELECCIÓN DE FILA
    ' ══════════════════════════════════════════════

    Private Sub dgvProveedores_CellClick(
        sender As Object, e As DataGridViewCellEventArgs
    ) Handles dgvProveedores.CellClick

        If e.RowIndex < 0 Then Exit Sub

        _idProveedor = Convert.ToInt32(
            dgvProveedores.Rows(e.RowIndex).Cells("idProveedor").Value)

        btnEditar.Enabled = True
        btnDarDeBaja.Enabled = True

    End Sub

    ' ══════════════════════════════════════════════
    '  BUSCAR
    ' ══════════════════════════════════════════════

    Private Sub btnBuscar_Click(
        sender As Object, e As EventArgs
    ) Handles btnBuscar.Click

        Dim criterio As String = txtBuscar.Text.Trim()

        If criterio = "" Then
            cargarGrilla()
        Else
            dgvProveedores.DataSource =
                objProveedor.buscarProveedor(criterio)
            _idProveedor = 0
            btnEditar.Enabled = False
            btnDarDeBaja.Enabled = False
        End If

    End Sub

    Private Sub txtBuscar_KeyDown(
        sender As Object, e As KeyEventArgs
    ) Handles txtBuscar.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnBuscar_Click(sender, e)
        End If

    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN NUEVO → abre JdGestionarProveedor vacío
    ' ══════════════════════════════════════════════

    Private Sub btnNuevo_Click(
        sender As Object, e As EventArgs
    ) Handles btnNuevo.Click

        Dim frmGestionar As New jdGestionarProovedor()
        frmGestionar.ShowDialog()
        cargarGrilla()

    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN EDITAR → abre JdGestionarProveedor con datos
    ' ══════════════════════════════════════════════

    Private Sub btnEditar_Click(
        sender As Object, e As EventArgs
    ) Handles btnEditar.Click

        If _idProveedor = 0 Then
            MessageBox.Show("Seleccione un proveedor de la lista.",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim fila As DataRow = objProveedor.buscarXid(_idProveedor)
        If fila Is Nothing Then Exit Sub

        Using frm As New frmEditarProveedor(_idProveedor, fila)
            frm.ShowDialog(Me)
            If frm.Guardado Then cargarGrilla()
        End Using

    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN DAR DE BAJA (baja lógica — estado = 0)
    ' ══════════════════════════════════════════════

    Private Sub btnDarDeBaja_Click(
        sender As Object, e As EventArgs
    ) Handles btnDarDeBaja.Click

        If _idProveedor = 0 Then
            MessageBox.Show(
                "Seleccione un proveedor de la lista.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim fila As DataRow = objProveedor.buscarXid(_idProveedor)
        If fila Is Nothing Then Exit Sub

        If fila("estado").ToString() = "Inactivo" Then
            MessageBox.Show(
                "El proveedor ya se encuentra inactivo.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Dar de baja al proveedor '" &
            fila("proveedor").ToString() & "'?",
            "Confirmar baja",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If respuesta = DialogResult.No Then Exit Sub

        Try
            objProveedor.modificarProveedor(
                _idProveedor,
                fila("proveedor").ToString(),
                fila("ruc").ToString(),
                fila("telefono").ToString(),
                fila("correo").ToString(),
                fila("direccion").ToString(),
                fila("contacto").ToString(),
                False)

            MessageBox.Show(
                "Proveedor dado de baja correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            cargarGrilla()

        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try

    End Sub

End Class