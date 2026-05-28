Imports capaNegocio

Public Class jdRegistrarEmpresa

    Private Sub jdRegistrarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDepartamentos()
    End Sub

    ' =============================================
    ' CARGA UBIGEO
    ' =============================================
    Private Sub cargarDepartamentos()
        Dim objCliente As New clsCliente()
        Try
            Dim dt As DataTable = objCliente.listarDepartamentos()
            cboDepartamento.DataSource = dt
            cboDepartamento.DisplayMember = "departamento"
            cboDepartamento.ValueMember = "iddepartamento"
            cboDepartamento.SelectedIndex = -1
            cboProvincia.DataSource = Nothing
            cboDistrito.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show("Error al cargar departamentos: " & ex.Message)
        End Try
    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedIndexChanged
        If cboDepartamento.SelectedIndex = -1 Then Exit Sub
        Dim objCliente As New clsCliente()
        Try
            Dim idDepto As Integer = Convert.ToInt32(CType(cboDepartamento.SelectedItem, DataRowView)("iddepartamento"))
            cboProvincia.DataSource = objCliente.listarProvincias(idDepto)
            cboProvincia.DisplayMember = "provincia"
            cboProvincia.ValueMember = "idprovincia"
            cboProvincia.SelectedIndex = -1
            cboDistrito.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show("Error al cargar provincias: " & ex.Message)
        End Try
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged
        If cboProvincia.SelectedIndex = -1 Then Exit Sub
        Dim objCliente As New clsCliente()
        Try
            Dim idProv As Integer = Convert.ToInt32(CType(cboProvincia.SelectedItem, DataRowView)("idprovincia"))
            cboDistrito.DataSource = objCliente.listarDistritos(idProv)
            cboDistrito.DisplayMember = "distrito"
            cboDistrito.ValueMember = "iddistrito"
            cboDistrito.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar distritos: " & ex.Message)
        End Try
    End Sub

    ' =============================================
    ' BOTÓN GUARDAR
    ' =============================================
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Validaciones obligatorias
        If txtRazonSocial.Text.Trim() = "" Then
            MessageBox.Show("Ingrese la razón social.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtRUC.Text.Trim() = "" OrElse txtRUC.Text.Trim().Length <> 11 Then
            MessageBox.Show("Ingrese un RUC válido (11 dígitos).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtDireccion.Text.Trim() = "" Then
            MessageBox.Show("Ingrese la dirección.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If cboDistrito.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un distrito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim objCliente As New clsCliente()
        Dim objEmpresa As New clsEmpresa()
        Try
            ' 1. Insertar en CLIENTE y obtener ID
            Dim idCliente As Integer = objCliente.registrarClienteEmpresa(
                txtRUC.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTelefono.Text.Trim(),
                CInt(cboDistrito.SelectedValue)
            )

            ' 2. Insertar en EMPRESA con el ID obtenido
            objEmpresa.registrarEmpresa(
                txtRazonSocial.Text.Trim(),
                txtRUC.Text.Trim(),
                idCliente
            )

            MessageBox.Show("Empresa registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =============================================
    ' BOTÓN CANCELAR
    ' =============================================
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    ' =============================================
    ' LIMPIAR CAMPOS
    ' =============================================
    Private Sub limpiarCampos()
        txtRazonSocial.Text = ""
        txtRUC.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""
        cargarDepartamentos()
    End Sub

End Class