Imports System.Runtime.Remoting
Imports capaNegocio

Public Class jdGestionarRol

    Private Sub jdGestionarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEstados()
        configurarListView()
        cargarListView()
        desactivarControles()
        btnGuardar.Text = "Guardar"
    End Sub
    Private Sub desactivarControles()
        txtIdRol.Enabled = False
        txtDescripcion.Enabled = False
        txtNombreRol.Enabled = False
        cboEstado.Enabled = False
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub activarControles()
        txtIdRol.Enabled = True
        txtDescripcion.Enabled = True
        txtNombreRol.Enabled = True
        cboEstado.Enabled = True
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
    End Sub
    Private Sub cargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.Add("ACTIVO")
        cboEstado.Items.Add("INACTIVO")
        cboEstado.SelectedIndex = -1
    End Sub

    Private Sub cargarIdRol()
        Dim objRol As New clsRol()
        Try
            txtIdRol.Text = objRol.generarIdRol().ToString()
        Catch ex As Exception
            MessageBox.Show("Error al generar ID: " & ex.Message)
        End Try
    End Sub

    Private Sub configurarListView()
        lvRoles.View = View.Details
        lvRoles.FullRowSelect = True
        lvRoles.GridLines = True
        lvRoles.Columns.Clear()
        lvRoles.Columns.Add("Id Rol", 70)
        lvRoles.Columns.Add("Nombre del Rol", 220)
        lvRoles.Columns.Add("Estado", 100)
        lvRoles.Columns.Add("Descripción", 200)
    End Sub

    Private Sub cargarListView()
        lvRoles.Items.Clear()
        Dim objRol As New clsRol()
        Try
            Dim dt As DataTable = objRol.listarRoles()
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(row("idrol").ToString())
                item.SubItems.Add(row("rol").ToString())
                item.SubItems.Add(row("estado").ToString())
                item.SubItems.Add(row("descripcion").ToString())
                lvRoles.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar roles: " & ex.Message)
        End Try
    End Sub

    Private Sub lvwRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRoles.SelectedIndexChanged
        If lvRoles.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvRoles.SelectedItems(0)

            txtIdRol.Text = item.SubItems(0).Text
            txtNombreRol.Text = item.SubItems(1).Text
            txtDescripcion.Text = item.SubItems(2).Text

            If item.SubItems(3).Text = "Activo" Then
                cboEstado.SelectedIndex = 0
            Else
                cboEstado.SelectedIndex = 1
            End If
            activarControles()
            btnGuardar.Text = "Actualizar"
        End If
    End Sub

    Private Sub btnNuevoRol_Click(sender As Object, e As EventArgs) Handles btnNuevoRol.Click
        limpiarCampos()
        cargarIdRol()
        activarControles()
        txtNombreRol.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Text = "Actualizar" Then
            If txtNombreRol.Text.Trim() = "" Then
                MessageBox.Show("Ingrese el nombre del rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If cboEstado.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim objRol As New clsRol()
            Try
                Dim idRol As Integer = Convert.ToInt32(txtIdRol.Text)
                Dim estado As Integer = If(cboEstado.Text = "Activo", 1, 0)

                objRol.modificarRol(
                idRol,
                txtNombreRol.Text.Trim(),
                txtDescripcion.Text.Trim(),
                estado
            )

                MessageBox.Show("Rol actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarCampos()
                cargarIdRol()
                cargarListView()
                btnGuardar.Text = "Guardar"
            Catch ex As Exception
                MessageBox.Show("Error al actualizar rol: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf btnGuardar.Text = "Guardar" Then
            If txtNombreRol.Text.Trim() = "" Then
                MessageBox.Show("Ingrese el nombre del rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If cboEstado.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim objRol As New clsRol()
            Try
                Dim estado As Integer = If(cboEstado.Text = "Activo", 1, 0)

                objRol.registrarRol(
                Convert.ToInt32(txtIdRol.Text),
                txtNombreRol.Text.Trim(),
                txtDescripcion.Text.Trim(),
                estado
            )

                MessageBox.Show("Rol guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarCampos()
                cargarIdRol()
                cargarListView()
            Catch ex As Exception
                MessageBox.Show("Error al guardar rol: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarCampos()
        desactivarControles()
        btnGuardar.Text = "Guardar"
    End Sub

    Private Sub limpiarCampos()
        txtNombreRol.Clear()
        txtIdRol.Clear()
        txtDescripcion.Clear()
        cboEstado.SelectedIndex = -1
    End Sub

End Class