Imports capaNegocio

Public Class jdGestionarClientes
    Private Sub jdGestionarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTiposDocumento()
    End Sub

    Private Sub cargarTiposDocumento()
        Dim objCliente As New clsCliente()
        Try
            Dim dt As DataTable = objCliente.listarTiposDocumento()
            cboTipoDoc.DataSource = dt
            cboTipoDoc.DisplayMember = "tipodocumento"
            cboTipoDoc.ValueMember = "idtipodocumento"
        Catch ex As Exception
            MessageBox.Show("Error al cargar tipos de documento: " & ex.Message)
        End Try
    End Sub


    Private Sub btnPersonaNatural_Click(sender As Object, e As EventArgs) Handles btnPersonaNatural.Click
        limpiarCampos()
        Dim frm As New jdMantenimientoCliente()
        frm.ShowDialog()
    End Sub


    Private Sub btnBuscarPersona_Click(sender As Object, e As EventArgs) Handles btnBuscarPer.Click
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
                txtRazonSocial.Text = dt.Rows(0)("razonsocial").ToString()
                txtCorreo.Text = dt.Rows(0)("correo").ToString()
                txtTelefono.Text = dt.Rows(0)("telefono").ToString()
                txtNombreAp.Text = ""
            Else
                MessageBox.Show("No se encontró la empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarCampos()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar empresa: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim frm As New jdGestionarPersona()
        frm.ShowDialog()
    End Sub

    Private Sub btnNuevaEmpresa_Click(sender As Object, e As EventArgs) Handles btnNuevaEmpresa.Click
        Dim frm As New jdGestionarEmpresa()
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class