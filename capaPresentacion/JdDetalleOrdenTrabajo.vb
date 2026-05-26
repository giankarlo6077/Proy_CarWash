Imports capaNegocio

Public Class JdDetalleOrdenTrabajo
    Dim objCita As New clsCita
    Private _idCita As Integer

    Public Sub New(idCita As Integer)
        InitializeComponent()
        _idCita = idCita
    End Sub

    Private Sub JdDetalleOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fila As DataRow = objCita.cargarDatosCita(_idCita)

        If fila IsNot Nothing Then
            lblidCita.Text = fila("idCita").ToString()
            txtidCita.Text = fila("idCita").ToString()
            lblFecha.Text = CDate(fila("fecha")).ToString("dd/MM/yyyy")
            lblHora.Text = fila("hora").ToString()
            dtpFechaRecojo.Text = CDate(fila("fechaRecojo")).ToString("dd/MM/yyyy")
            cmbEstado.Text = fila("estado").ToString()
            txtComentario.Text = fila("comentario").ToString()
            cmbTrabajador.Text = fila("trabajador").ToString()
            lblPlaca.Text = fila("placa").ToString()
            lblModelo.Text = fila("modeloVehiculo").ToString()
            lblAno.Text = fila("anoFabricacion").ToString()
            lblCliente.Text = fila("cliente").ToString()
            lblTelefono.Text = fila("telefono").ToString()
        Else
            MessageBox.Show("No se encontró la cita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub JdDetalleOrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class