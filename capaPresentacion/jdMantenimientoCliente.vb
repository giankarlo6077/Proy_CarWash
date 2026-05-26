Imports capaNegocio

Public Class jdMantenimientoCliente
    Private Sub jdMantenimientoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoCliente()
        cargarTiposDocumento()
        deshabilitarClientePersona()
        deshabilitarClienteEmpresa()
    End Sub

    Private Sub cargarTipoCliente()
        cboTipoCliente.Items.Clear()
        cboTipoCliente.Items.Add("PERSONA")
        cboTipoCliente.Items.Add("EMPRESA")
        cboTipoCliente.SelectedIndex = -1
    End Sub
    Private Sub cargarTiposDocumento()
        Try
            cboTipoDoc.DataSource = Nothing
            cboTipoDoc.Items.Clear()
            Dim dt As New DataTable()
            dt.Columns.Add("idtipodocumento", GetType(Integer))
            dt.Columns.Add("tipodocumento", GetType(String))
            dt.Rows.Add(1, "DNI")
            cboTipoDoc.DataSource = dt
            cboTipoDoc.DisplayMember = "tipodocumento"
            cboTipoDoc.ValueMember = "idtipodocumento"
            cboTipoDoc.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error al asignar el tipo de documento: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarPersona_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        If txtDoc.Text.Trim() = "" Then
            MessageBox.Show("Ingrese un número de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim objPersona As New clsPersona()
        Try
            Dim dt As DataTable = objPersona.buscarPersona(txtDoc.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtNombreAp.Text = dt.Rows(0)("persona").ToString()
                txtCorreo.Text = dt.Rows(0)("correo").ToString()
                txtTelefono.Text = dt.Rows(0)("telefono").ToString()
            Else
                MessageBox.Show("No se encontró la persona.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNombreAp.Clear()
                txtCorreo.Clear()
                txtTelefono.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar persona: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles btnBuscar2.Click
        If txtRUC.Text.Trim() = "" Then
            MessageBox.Show("Ingrese un RUC.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim objEmpresa As New clsEmpresa()
        Try
            Dim dt As DataTable = objEmpresa.buscarEmpresaRUC(txtRUC.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtRazonSocial.Text = dt.Rows(0)("razonsocial").ToString()
            Else
                MessageBox.Show("No se encontró la empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRazonSocial.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar empresa: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGestionar_Click(sender As Object, e As EventArgs) Handles btnGestionarPersona.Click
        Dim frm As New jdGestionarPersona()
        frm.ShowDialog()
    End Sub

    Private Sub btnGestionarEmpresa_Click(sender As Object, e As EventArgs) Handles btnGestionarEmpresa.Click
        Dim frm As New jdGestionarEmpresa()
        frm.ShowDialog()
        MessageBox.Show("Abrir formulario Gestionar Empresa")
    End Sub

    Private Sub btnAtender_Click(sender As Object, e As EventArgs) 
        If cboTipoCliente.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        MessageBox.Show("Cliente atendido correctamente.")
        limpiarCampos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea cancelar? Se perderán los datos no guardados.",
                                                    "Confirmar Cancelación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            limpiarCampos()
        End If
    End Sub

    Private Sub cboTipoCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCliente.SelectedIndexChanged
        If cboTipoCliente.SelectedIndex = 0 Then
            habilitarClientePersona()
            deshabilitarClienteEmpresa()

        ElseIf cboTipoCliente.SelectedIndex = 1 Then
            habilitarClienteEmpresa()
            deshabilitarClientePersona()
        End If
    End Sub

    Private Sub habilitarClientePersona()
        txtCorreo.Enabled = True
        txtTelefono.Enabled = True
        txtDoc.Enabled = True
        txtNombreAp.Enabled = True
        cboTipoDoc.Enabled = True
        btnBuscar1.Enabled = True
        btnGestionarPersona.Enabled = True
    End Sub
    Private Sub deshabilitarClientePersona()
        txtCorreo.Enabled = False
        txtTelefono.Enabled = False
        txtDoc.Enabled = False
        txtNombreAp.Enabled = False
        cboTipoDoc.Enabled = False
        btnBuscar1.Enabled = False
        btnGestionarPersona.Enabled = False
    End Sub
    Private Sub habilitarClienteEmpresa()
        txtRUC.Enabled = True
        txtRazonSocial.Enabled = True
        btnBuscar2.Enabled = True
        btnGestionarEmpresa.Enabled = True
    End Sub
    Private Sub deshabilitarClienteEmpresa()
        txtRUC.Enabled = False
        txtRazonSocial.Enabled = False
        btnBuscar2.Enabled = False
        btnGestionarEmpresa.Enabled = False
    End Sub
    Private Sub limpiarCampos()
        txtDoc.Clear()
        txtNombreAp.Clear()
        txtCorreo.Clear()
        txtTelefono.Clear()
        txtRUC.Clear()
        txtRazonSocial.Clear()
        cboTipoCliente.SelectedIndex = -1
        cboTipoDoc.SelectedIndex = -1
        deshabilitarClientePersona()
        deshabilitarClienteEmpresa()
    End Sub
End Class