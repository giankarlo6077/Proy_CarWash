Imports capaNegocio

Public Class jdGestionarClientes
    Private Sub jdGestionarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTiposDocumento()
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


    Private Sub btnModificarPersona_Click(sender As Object, e As EventArgs) Handles btnModificarPersona.Click
        limpiarCampos()
        Dim frm As New jdModificarPersona()
        frm.ShowDialog()
    End Sub


    Private Sub btnBuscarPersona_Click(sender As Object, e As EventArgs) Handles btnBuscarPer.Click
        If txtDoc.Text.Trim() = "" Then
            MessageBox.Show("Ingrese un número de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim objPersona As New clsPersona()
        Try
            Dim dt As DataTable = objPersona.buscarPersonaRapida(txtDoc.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtNombreAp.Text = dt.Rows(0)("persona").ToString()
                txtCorreo.Text = dt.Rows(0)("correo").ToString()
                txtTelefono.Text = dt.Rows(0)("telefono").ToString()
                txtRazonSocial.Text = ""
            Else
                MessageBox.Show("No se encontró la persona.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarCampos()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar persona: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles btnBuscarEm.Click
        If txtRUC.Text.Trim() = "" Then
            MessageBox.Show("Ingrese un RUC.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim objEmpresa As New clsEmpresa()
        Try
            Dim dt As DataTable = objEmpresa.buscarEmpresaRUC(txtRUC.Text.Trim())

            If dt.Rows.Count > 0 Then
                txtRazonSocial.Text = dt.Rows(0)("razonSocial").ToString()
            Else
                MessageBox.Show("No se encontró la empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRazonSocial.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show("Error al buscar empresa: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevoPersona_Click(sender As Object, e As EventArgs) Handles btnNuevaPersona.Click
        limpiarCampos()
        Dim frm As New jdRegistrarPersona()
        frm.ShowDialog()
    End Sub

    Private Sub btnNuevaEmpresa_Click(sender As Object, e As EventArgs) Handles btnNuevaEmpresa.Click
        limpiarCampos()
        Dim frm As New jdRegistrarEmpresa()
        frm.ShowDialog()
    End Sub

    Private Sub limpiarCampos()
        txtDoc.Clear()
        txtRUC.Clear()
        txtNombreAp.Clear()
        txtRazonSocial.Clear()
        txtCorreo.Clear()
        txtTelefono.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub btnModificarEmpresa_Click(sender As Object, e As EventArgs) Handles btnModificarEmpresa.Click
        limpiarCampos()
        Dim frm As New jdGestionarEmpresa()
        frm.ShowDialog()
    End Sub

End Class