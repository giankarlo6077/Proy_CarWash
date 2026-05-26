Imports capaNegocio

Public Class jdGestionCliente
    Private Sub jdGestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoCliente()
        cargarTiposDocumento()
    End Sub

    Private Sub cargarTipoCliente()
        cboTipoCliente.Items.Clear()
        cboTipoCliente.Items.Add("PERSONA")
        cboTipoCliente.Items.Add("EMPRESA")
        cboTipoCliente.SelectedIndex = -1
    End Sub

    Private Sub cargarTiposDocumento()
        Dim objCliente As New clsCliente()
        Try
            Dim dt As DataTable = objCliente.listarTiposDocumento()
            cboTipoDoc.DataSource = dt
            cboTipoDoc.DisplayMember = "tipodocumento"
            cboTipoDoc.ValueMember = "idtipodocumento"
            cboTipoDoc.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar tipos de documento: " & ex.Message)
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
                If dt.Rows(0)("sexo").ToString() = "M" Then
                    chkMasculino.Checked = True
                Else
                    chkFemenino.Checked = True
                End If
            Else
                MessageBox.Show("No se encontró la persona.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarCampos()
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

    Private Sub chkMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles chkMasculino.CheckedChanged
        If chkMasculino.Checked Then chkFemenino.Checked = False
    End Sub

    Private Sub chkFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles chkFemenino.CheckedChanged
        If chkFemenino.Checked Then chkMasculino.Checked = False
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim frm As New jdGestionarPersona()
        frm.ShowDialog()
    End Sub

    Private Sub btnNuevaEmpresa_Click(sender As Object, e As EventArgs) Handles btnNuevaEmpresa.Click
        Dim frm As New jdGestionarEmpresa()
        frm.ShowDialog()
    End Sub

    Private Sub btnAtender_Click(sender As Object, e As EventArgs) Handles btnAtender.Click
        MessageBox.Show("Atender cliente")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtDoc.Clear()
        txtNombreAp.Clear()
        txtCorreo.Clear()
        txtTelefono.Clear()
        txtRUC.Clear()
        txtRazonSocial.Clear()
        chkMasculino.Checked = False
        chkFemenino.Checked = False
        cboTipoCliente.SelectedIndex = -1
        cboTipoDoc.SelectedIndex = -1
    End Sub
End Class