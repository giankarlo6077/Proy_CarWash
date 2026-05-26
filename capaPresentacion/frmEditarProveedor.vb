Imports capaNegocio
Imports System.Data

Public Class frmEditarProveedor

    Private _idProveedor As Integer
    Public Guardado As Boolean = False
    Private objProveedor As New clsProveedor()

    Public Sub New(id As Integer, fila As DataRow)
        InitializeComponent()
        _idProveedor = id
        txtNombre.Text = fila("proveedor").ToString()
        txtRUC.Text = fila("ruc").ToString()
        txtTelefono.Text = fila("telefono").ToString()
        txtCorreo.Text = fila("correo").ToString()
        txtDireccion.Text = fila("direccion").ToString()
        txtContacto.Text = fila("contacto").ToString()
        cboEstado.SelectedIndex = If(fila("estado").ToString() = "Activo", 0, 1)
    End Sub

    Private Function validar() As Boolean

        If txtNombre.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el nombre del proveedor.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        End If

        If txtRUC.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el RUC.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRUC.Focus()
            Return False
        End If

        If Not IsNumeric(txtRUC.Text) Then
            MessageBox.Show("El RUC debe contener solo números.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRUC.Focus()
            Return False
        End If

        If txtRUC.TextLength <> 11 Then
            MessageBox.Show("El RUC debe tener exactamente 11 dígitos.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRUC.Focus()
            Return False
        End If

        If txtTelefono.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el teléfono.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelefono.Focus()
            Return False
        End If

        If Not IsNumeric(txtTelefono.Text) Then
            MessageBox.Show("El teléfono debe contener solo números.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelefono.Focus()
            Return False
        End If

        If txtTelefono.TextLength <> 9 Then
            MessageBox.Show("El teléfono debe tener exactamente 9 dígitos.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelefono.Focus()
            Return False
        End If

        If txtCorreo.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el correo electrónico.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCorreo.Focus()
            Return False
        End If

        If Not txtCorreo.Text.Contains("@") Then
            MessageBox.Show("Ingrese un correo electrónico válido.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCorreo.Focus()
            Return False
        End If

        If txtDireccion.Text.Trim() = "" Then
            MessageBox.Show("Ingrese la dirección.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDireccion.Focus()
            Return False
        End If

        If txtContacto.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el nombre de la persona de contacto.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContacto.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not validar() Then Exit Sub

        Try
            Dim estado As Boolean = (cboEstado.SelectedIndex = 0)

            objProveedor.modificarProveedor(
                _idProveedor,
                txtNombre.Text.Trim(),
                txtRUC.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtContacto.Text.Trim(),
                estado)

            Guardado = True
            MessageBox.Show("Proveedor actualizado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
