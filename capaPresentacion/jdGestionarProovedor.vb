Imports capaNegocio

Public Class jdGestionarProovedor

    Dim objProveedor As New clsProveedor()

    Dim idProveedorSeleccionado As Integer = 0

    Sub listar()

        DataGridView1.DataSource =
            objProveedor.listarProveedor()

        ' Ocultar ID
        DataGridView1.Columns(0).Visible = False

        ' Nombres columnas
        DataGridView1.Columns(1).HeaderText =
            "Proveedor"

        DataGridView1.Columns(2).HeaderText =
            "RUC"

        DataGridView1.Columns(3).HeaderText =
            "Teléfono"

        DataGridView1.Columns(4).HeaderText =
            "Correo"

        DataGridView1.Columns(5).HeaderText =
            "Dirección"

        DataGridView1.Columns(6).HeaderText =
            "Contacto"

        DataGridView1.Columns(7).HeaderText =
            "Estado"

        ' Configuración visual
        DataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        DataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        DataGridView1.MultiSelect = False

        DataGridView1.ReadOnly = True

        DataGridView1.AllowUserToAddRows = False

    End Sub

    Sub limpiar()

        txtNombre.Clear()
        txtRUC.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtDireccion.Clear()
        txtContacto.Clear()

        cboEstado.SelectedIndex = 0

        idProveedorSeleccionado = 0

        deshabilitarCampos()

    End Sub

    Sub habilitarCampos()

        txtNombre.Enabled = True
        txtRUC.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
        txtDireccion.Enabled = True
        txtContacto.Enabled = True
        cboEstado.Enabled = True

    End Sub

    Sub deshabilitarCampos()

        txtNombre.Enabled = False
        txtRUC.Enabled = False
        txtTelefono.Enabled = False
        txtCorreo.Enabled = False
        txtDireccion.Enabled = False
        txtContacto.Enabled = False
        cboEstado.Enabled = False

    End Sub

    Sub estadoInicial()

        btnRegistrar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False

    End Sub

    Sub estadoNuevo()

        btnRegistrar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False

    End Sub

    Sub estadoEdicion()

        btnRegistrar.Enabled = False
        btnEditar.Enabled = True
        btnEliminar.Enabled = True

    End Sub

    Function validarCampos() As Boolean

        If txtNombre.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese proveedor"
            )

            txtNombre.Focus()

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
                "El RUC debe contener números"
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

        If txtTelefono.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese teléfono"
            )

            txtTelefono.Focus()

            Return False

        End If

        If Not IsNumeric(txtTelefono.Text) Then

            MessageBox.Show(
                "El teléfono debe contener números"
            )

            txtTelefono.Focus()

            Return False

        End If

        If txtTelefono.TextLength <> 9 Then

            MessageBox.Show(
                "El teléfono debe tener 9 dígitos"
            )

            txtTelefono.Focus()

            Return False

        End If

        If txtCorreo.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese correo"
            )

            txtCorreo.Focus()

            Return False

        End If

        If txtCorreo.Text.Contains("@") = False Then

            MessageBox.Show(
                "Ingrese un correo válido"
            )

            txtCorreo.Focus()

            Return False

        End If

        If txtDireccion.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese dirección"
            )

            txtDireccion.Focus()

            Return False

        End If

        If txtContacto.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese contacto"
            )

            txtContacto.Focus()

            Return False

        End If

        Return True

    End Function

    Private Sub jdGestionarProovedor_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        cboEstado.Items.Clear()

        cboEstado.Items.Add("Activo")
        cboEstado.Items.Add("Inactivo")

        cboEstado.SelectedIndex = 0

        listar()

        deshabilitarCampos()

        estadoInicial()

    End Sub

    Private Sub btnNuevo_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNuevo.Click

        limpiar()

        habilitarCampos()

        estadoNuevo()

        txtNombre.Focus()

    End Sub

    Private Sub btnRegistrar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRegistrar.Click

        If validarCampos() = False Then
            Exit Sub
        End If

        Try

            Dim estado As Boolean

            If cboEstado.Text = "Activo" Then
                estado = True
            Else
                estado = False
            End If

            objProveedor.registrarProveedor(
                txtNombre.Text,
                txtRUC.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                txtDireccion.Text,
                txtContacto.Text,
                estado
            )

            MessageBox.Show(
                "Proveedor registrado correctamente"
            )

            listar()

            limpiar()

            estadoInicial()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnEditar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEditar.Click

        If idProveedorSeleccionado = 0 Then

            MessageBox.Show(
                "Seleccione un proveedor"
            )

            Exit Sub

        End If

        If validarCampos() = False Then
            Exit Sub
        End If

        Try

            Dim estado As Boolean

            If cboEstado.Text = "Activo" Then
                estado = True
            Else
                estado = False
            End If

            objProveedor.modificarProveedor(
                idProveedorSeleccionado,
                txtNombre.Text,
                txtRUC.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                txtDireccion.Text,
                txtContacto.Text,
                estado
            )

            MessageBox.Show(
                "Proveedor modificado correctamente"
            )

            listar()

            limpiar()

            estadoInicial()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnEliminar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEliminar.Click

        If idProveedorSeleccionado = 0 Then

            MessageBox.Show(
                "Seleccione un proveedor"
            )

            Exit Sub

        End If

        Try

            Dim rpta As DialogResult

            rpta = MessageBox.Show(
                "¿Desea eliminar definitivamente el proveedor?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If rpta = DialogResult.Yes Then

                objProveedor.eliminarProveedor(
                    idProveedorSeleccionado
                )

                MessageBox.Show(
                    "Proveedor eliminado correctamente"
                )

                listar()

                limpiar()

                estadoInicial()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtBuscarProveedor_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtBuscarProveedor.TextChanged

        DataGridView1.DataSource =
            objProveedor.buscarProveedor(
                txtBuscarProveedor.Text
            )

    End Sub

    Private Sub DataGridView1_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then

            habilitarCampos()

            estadoEdicion()

            idProveedorSeleccionado =
                CInt(
                    DataGridView1.Rows(e.RowIndex).
                    Cells(0).Value
                )

            txtNombre.Text =
                DataGridView1.Rows(e.RowIndex).
                Cells(1).Value.ToString()

            txtRUC.Text =
                DataGridView1.Rows(e.RowIndex).
                Cells(2).Value.ToString()

            txtTelefono.Text =
                DataGridView1.Rows(e.RowIndex).
                Cells(3).Value.ToString()

            txtCorreo.Text =
                DataGridView1.Rows(e.RowIndex).
                Cells(4).Value.ToString()

            txtDireccion.Text =
                DataGridView1.Rows(e.RowIndex).
                Cells(5).Value.ToString()

            txtContacto.Text =
                DataGridView1.Rows(e.RowIndex).
                Cells(6).Value.ToString()

            cboEstado.Text =
                DataGridView1.Rows(e.RowIndex).
                Cells(7).Value.ToString()

        End If

    End Sub

    Private Sub btnCancelar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    Private Sub btnLimpiar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLimpiar.Click

        limpiar()

        estadoInicial()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class