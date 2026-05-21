Imports System.Data

Public Class JdMantenimientoCliente

    ' Referencia fuera de alcance: FrmMenuPrincipalModificado no fue migrado
    Private objPersona As New capaNegocio.clsPersona()
    Private objEmpresa As New capaNegocio.clsEmpresa()

    Public Sub New()
        InitializeComponent()
        cboTipoCliente.SelectedIndex = 0
    End Sub

    Public Sub switchTipoCliente()
        pnl1.Visible = True
        If CStr(cboTipoCliente.SelectedItem) = "Natural" Then
            pnl1.Visible = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpresa.Click
        Dim rs As DataTable = Nothing
        Try
            rs = objEmpresa.bucarEmpresaRUC(txtRuc.Text)
            txtRazonSocial.Text = rs.Rows(0)("razonsocial").ToString()
        Catch ex As Exception
            MessageBox.Show("Error al buscar Empresa")
        End Try
    End Sub

    Private Sub txtGestionarEmpresa_Click(sender As Object, e As EventArgs) Handles txtGestionarEmpresa.Click
        ' Referencia fuera de alcance: jdGestionarEmpresa no fue migrado
        MessageBox.Show("Funcionalidad 'Gestionar Empresa' no disponible (formulario no migrado)")
    End Sub

    Private Sub btnBuscarPersona_Click(sender As Object, e As EventArgs) Handles btnBuscarPersona.Click
        Dim nroDocumento As String = ""
        Dim rs As DataTable = Nothing
        Try
            nroDocumento = txtNroDocumento.Text
            rs = objPersona.buscarPersona(nroDocumento)
            txtNombres.Text = rs.Rows(0)("nombres").ToString()
            txtCorreo.Text = rs.Rows(0)("correo").ToString()
            txtTelefono.Text = rs.Rows(0)("telefono").ToString()
        Catch ex As Exception
            MessageBox.Show("ERROR AL BUSCAR EL DOCUMENTO " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnGestionarPersona_Click(sender As Object, e As EventArgs) Handles btnGestionarPersona.Click
        Dim obj As New jdGestionarPersona()
        obj.StartPosition = FormStartPosition.CenterParent
        obj.ShowDialog(Me)
    End Sub

    Private Sub cboTipoCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCliente.SelectedIndexChanged
        switchTipoCliente()
    End Sub

End Class
