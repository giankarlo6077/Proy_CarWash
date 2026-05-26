Imports System.Globalization
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

        cmbTrabajador.DataSource = objCita.listarTrabajadores
        cmbTrabajador.DisplayMember = "trabajador"
        cmbTrabajador.ValueMember = "idTrabajador"

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
            dgvProductos.DataSource = objCita.cargarProductosdelaCita(_idCita)
            dgvServicios.DataSource = objCita.cargarServiciosdelaCita(_idCita)
        Else
            MessageBox.Show("No se encontró la cita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Validación básica
            If cmbEstado.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If cmbTrabajador.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione un técnico responsable.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Recoger datos del formulario
            Dim id As Integer = CInt(txtidCita.Text)
            Dim fec As Date = Date.ParseExact(lblFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim hor As Date = Date.ParseExact(lblHora.Text, "HH:mm:ss", CultureInfo.InvariantCulture)
            Dim estado As String = cmbEstado.SelectedItem.ToString()
            Dim coment As String = txtComentario.Text.Trim()
            Dim fechRec As Date = dtpFechaRecojo.Value
            Dim idVeh As Integer = objCita.buscarIDVehporPlaca(lblPlaca.Text)       ' guarda el idVehiculo en el .Tag
            Dim idTrab As Integer = CInt(cmbTrabajador.SelectedValue)

            ' Llamar al método
            objCita.modificarCita(id, fec, hor, estado, coment, fechRec, idVeh, idTrab)

            MessageBox.Show("Cita actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class