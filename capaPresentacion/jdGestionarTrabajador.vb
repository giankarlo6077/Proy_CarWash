Imports System.Data
Imports capaNegocio

Public Class jdGestionarTrabajador

    Dim objTrabajador As New clsTrabajador()
    Dim objTipoTrabajador As New clsTipoTrabajador()

    Public idTrabajador As Integer = 0

    '========================================
    ' LOAD
    '=======================================
    Private Sub jdGestionarTrabajador_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        cargarSexo()

        cargarTipoTrabajador()

        If idTrabajador > 0 Then

            cargarTrabajador()

            btnRegistrar.Text =
                "Modificar"

        Else

            btnRegistrar.Text =
                "Registrar"

            txtCodigo.Text = "AUTO"

            chkActivo.Checked = True

        End If

    End Sub

    '========================================
    ' CARGAR SEXO
    '========================================
    Sub cargarSexo()

        cboSexo.Items.Clear()

        cboSexo.Items.Add("M")

        cboSexo.Items.Add("F")

    End Sub

    '========================================
    ' CARGAR TIPOS DE TRABAJADOR
    '========================================
    Sub cargarTipoTrabajador()

        Try

            Dim dt As DataTable =
                objTipoTrabajador.listarTipoTrabajador()

            cboTipoTrabajador.DataSource = dt

            cboTipoTrabajador.DisplayMember =
                "tipoTrabajador"

            cboTipoTrabajador.ValueMember =
                "idTipoTrabajador"

            cboTipoTrabajador.SelectedIndex = -1

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
            )

        End Try

    End Sub

    '========================================
    ' CARGAR DATOS
    '========================================
    Sub cargarTrabajador()

        Try

            Dim fila As DataRow =
                objTrabajador.obtenerTrabajadorXid(
                    idTrabajador
                )

            If fila IsNot Nothing Then

                txtCodigo.Text =
                    fila("idTrabajador").ToString()

                txtNombre.Text =
                    fila("trabajador").ToString()

                txtTelefono.Text =
                    fila("telefono").ToString()

                txtDNI.Text =
                    fila("dni").ToString()

                txtCorreo.Text =
                    fila("correo").ToString()

                cboSexo.Text =
                    fila("sexo").ToString()

                chkActivo.Checked =
                    Convert.ToBoolean(
                        fila("estado")
                    )

                cboTipoTrabajador.SelectedValue =
                    Convert.ToInt32(
                        fila("idTipoTrabajador")
                    )

            End If

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
            )

        End Try

    End Sub

    '========================================
    ' VALIDAR CAMPOS
    '========================================
    Function validarCampos() As Boolean

        If txtCorreo.Text.Trim <> "" Then

            If Not txtCorreo.Text.Contains("@") Then

                MessageBox.Show(
            "Correo inválido"
        )

                txtCorreo.Focus()

                Return False

            End If

        End If

        If txtNombre.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese nombre"
            )

            txtNombre.Focus()

            Return False

        End If

        If txtDNI.Text.Trim = "" Then

            MessageBox.Show(
                "Ingrese DNI"
            )

            txtDNI.Focus()

            Return False

        End If

        If Not IsNumeric(txtDNI.Text) Then

            MessageBox.Show(
                "El DNI debe ser numérico"
            )

            txtDNI.Focus()

            Return False

        End If

        If txtDNI.TextLength <> 8 Then

            MessageBox.Show(
                "El DNI debe tener 8 dígitos"
            )

            txtDNI.Focus()

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
                "El teléfono debe ser numérico"
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

        If cboSexo.Text.Trim = "" Then

            MessageBox.Show(
                "Seleccione sexo"
            )

            cboSexo.Focus()

            Return False

        End If

        If cboTipoTrabajador.SelectedIndex = -1 Then

            MessageBox.Show(
                "Seleccione tipo trabajador"
            )

            cboTipoTrabajador.Focus()

            Return False

        End If

        If objTrabajador.existeDNI(
                txtDNI.Text.Trim,
                idTrabajador
            ) Then

            MessageBox.Show(
                    "El DNI ya existe"
                )

            txtDNI.Focus()

            Return False

        End If

        Return True

    End Function

    '========================================
    ' REGISTRAR / MODIFICAR
    '========================================
    Private Sub btnRegistrar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRegistrar.Click

        If validarCampos() = False Then
            Exit Sub
        End If

        Try

            If idTrabajador = 0 Then

                '================================
                ' REGISTRAR
                '================================
                objTrabajador.registrarTrabajador(
                    txtNombre.Text.Trim,
                    txtTelefono.Text.Trim,
                    txtDNI.Text.Trim,
                    cboSexo.Text,
                    txtCorreo.Text.Trim,
                    chkActivo.Checked,
                    CInt(cboTipoTrabajador.SelectedValue),
                    1
                )

                MessageBox.Show(
                    "Trabajador registrado correctamente",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            Else

                '================================
                ' MODIFICAR
                '================================
                objTrabajador.modificarTrabajador(
                    idTrabajador,
                    txtNombre.Text.Trim,
                    txtTelefono.Text.Trim,
                    txtDNI.Text.Trim,
                    cboSexo.Text,
                    txtCorreo.Text.Trim,
                    chkActivo.Checked,
                    CInt(cboTipoTrabajador.SelectedValue),
                    1
                )

                MessageBox.Show(
                    "Trabajador modificado correctamente",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End If

            Me.Close()

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
    ' CANCELAR
    '========================================
    Private Sub btnCancelar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCancelar.Click

        Me.Close()

    End Sub

    '========================================
    ' MÉTODO LIMPIAR
    '========================================
    Sub limpiar()

        txtCodigo.Text = "AUTO"

        txtNombre.Clear()

        txtTelefono.Clear()

        txtDNI.Clear()

        txtCorreo.Clear()

        cboSexo.SelectedIndex = -1

        cboTipoTrabajador.SelectedIndex = -1

        chkActivo.Checked = True

        txtNombre.Focus()

    End Sub

    Private Sub cboTipoTrabajador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoTrabajador.SelectedIndexChanged

    End Sub

    Private Sub btnGestionar_Click(sender As Object, e As EventArgs) Handles btnGestionar.Click
        Dim frm As New jdGestionarTipoTrabajador()

        frm.ShowDialog()

        cargarTipoTrabajador()
    End Sub
End Class