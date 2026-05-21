Imports System.Data

Public Class JdGestionarCliente

    Private servicioCreado As capaNegocio.clsServicio = Nothing
    ' Referencia fuera de alcance de la migración (formulario JdMantenimientoServicio no migrado)
    ' Public objcls As New JdMantenimientoServicio()
    Private objPersona As New capaNegocio.clsPersona()
    Private objEmpresa As New capaNegocio.clsEmpresa()

    Public Sub New()
        InitializeComponent()
        cboTipoCliente.SelectedIndex = 0
        controlCboTipoCliente()
    End Sub

    Public Sub controlCboTipoCliente()
        If CStr(cboTipoCliente.SelectedItem) = "Empresa" Then
            pnl1.Visible = True
        Else
            pnl1.Visible = False
        End If
    End Sub

    Private Sub cboTipoCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCliente.SelectedIndexChanged
        controlCboTipoCliente()
    End Sub

    Private Sub jButton3_Click(sender As Object, e As EventArgs) Handles jButton3.Click
        Dim obj As New jdGestionarPersona()
        obj.StartPosition = FormStartPosition.CenterParent
        obj.ShowDialog(Me)
    End Sub

    Private Sub jButton6_Click(sender As Object, e As EventArgs) Handles jButton6.Click
        ' Referencia fuera de alcance: jdGestionarEmpresa no fue migrado
        MessageBox.Show("Funcionalidad 'Nueva Empresa' no disponible (formulario no migrado)")
    End Sub

    Private Sub jButton1_Click(sender As Object, e As EventArgs) Handles jButton1.Click
        Dim rs As DataTable = Nothing
        Try
            rs = objPersona.buscarPersona(txtNroDocumento.Text)
            If rs.Rows.Count > 0 Then
                txtNombres.Text = rs.Rows(0)("persona").ToString()
                txtCorreo.Text = rs.Rows(0)("correo").ToString()
                txtTelefono.Text = "telefono"
            Else
                MessageBox.Show("NO se encontro cliente")
            End If
        Catch ex As Exception
            MessageBox.Show("NO se encontro cliente")
        End Try
    End Sub

    Private Sub jButton2_Click(sender As Object, e As EventArgs) Handles jButton2.Click
        Dim rs As DataTable = Nothing
        Try
            rs = objEmpresa.buscar(Integer.Parse(txtNroDocumento.Text))
            If rs.Rows.Count > 0 Then
                txtRuc.Text = rs.Rows(0)("idEmpresa").ToString()
                txtRazonSocial.Text = rs.Rows(0)("razonsocial").ToString()
            Else
                MessageBox.Show("NO se encontro Empresa")
            End If
        Catch ex As Exception
            MessageBox.Show("NO se encontro Empresa")
        End Try
    End Sub

    Public Function getServicioCreado() As capaNegocio.clsServicio
        Return servicioCreado
    End Function

End Class
