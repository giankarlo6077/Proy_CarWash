Imports System.Data
Imports System.Globalization

Public Class jdGestionarPersona

    Private rs As DataTable = Nothing
    Private objPersona As New capaNegocio.clsPersona()
    Private objUbicacion As New capaNegocio.clsUbicacion()
    Private cargar_datos As Boolean = False, cargar_datos2 As Boolean = False
    Private WithEvents timer As New System.Windows.Forms.Timer()

    Public Sub New()
        InitializeComponent()
        listar()
        limpiar()
        cargarDepartamento()
        mostrarFechaCorta()
        idCliente()
        timer.Interval = 60000
        timer.Start()
    End Sub

    Public Sub listar()
        Dim mdl As New DataTable()
        mdl.Columns.Add("ID")
        mdl.Columns.Add("DNI")
        mdl.Columns.Add("Nombre")
        mdl.Columns.Add("Sexo")
        mdl.Columns.Add("Direccion")
        mdl.Columns.Add("Correo")
        Try
            rs = objPersona.listarPersona()
            For Each fila As DataRow In rs.Rows
                Dim sexoTexto As String
                If fila("sexo").ToString() = "M" Then
                    sexoTexto = "Masculino"
                Else
                    sexoTexto = "Feminino"
                End If
                mdl.Rows.Add(fila("idcliente"), fila("idpersona"), fila("persona"), sexoTexto, fila("direccion"), fila("correo"))
            Next
            tblPersona.DataSource = mdl
        Catch e As Exception
            MessageBox.Show("Error al listar ..." & e.Message)
        End Try
    End Sub

    Public Sub limpiar()
        txtIdCliente.Text = ""
        txtNombre.Text = ""
        txtDni.Text = ""
        txtDireccion.Text = ""
        cboDepartamento.SelectedIndex = -1
        cboProvincia.SelectedIndex = -1
        cboDistrito.SelectedIndex = -1
        dchFechaNacimiento.Value = DateTime.Now
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        rbnM.Checked = False
        rbnF.Checked = False

        cboProvincia.Enabled = False
        cboDistrito.Enabled = False
        cboProvincia.SelectedIndex = -1
        cboDistrito.SelectedIndex = -1
        cboDepartamento.SelectedIndex = -1
    End Sub

    Public Sub cargarDepartamento()
        Try
            rs = objUbicacion.listarDepartamento()
            cboDepartamento.Items.Clear()
            For Each fila As DataRow In rs.Rows
                cboDepartamento.Items.Add(fila("departamento").ToString())
            Next
            cargar_datos = True
        Catch e As Exception
            MessageBox.Show("Error al cargar Departamentos" & e.Message)
        End Try
        cboProvincia.Enabled = False
        cboDistrito.Enabled = False
    End Sub

    Public Sub cargarProvincia(ByVal departamento As String)
        Try
            Dim idDepartamento As Integer = objUbicacion.buscarIDxDepartamento(departamento)
            rs = objUbicacion.listarProvincia(idDepartamento)
            cboProvincia.Items.Clear()
            For Each fila As DataRow In rs.Rows
                cboProvincia.Items.Add(fila("provincia").ToString())
            Next
            cargar_datos2 = True
        Catch e As Exception
            MessageBox.Show("Error al provincia" & e.Message)
        End Try
        cboDistrito.Enabled = True
    End Sub

    Public Sub cargarDistrito(ByVal Provincia As String)
        Try
            Dim idProvincia As Integer = objUbicacion.buscarIdXProvincia(Provincia)
            rs = objUbicacion.listarDistrito(idProvincia)
            cboDistrito.Items.Clear()
            For Each fila As DataRow In rs.Rows
                cboDistrito.Items.Add(fila("distrito").ToString())
            Next
        Catch e As Exception
            MessageBox.Show("Error al cargar el cbo Distrito " & e.Message)
        End Try
    End Sub

    Public Sub idCliente()
        Try
            txtIdCliente.Text = CStr(objPersona.generarIdPersona())
        Catch e As Exception
            MessageBox.Show(e.Message)
        End Try
    End Sub

    Private Sub mostrarFechaCorta()
        Dim fecha As DateTime = DateTime.Now
        txtFechaRegistro.Text = fecha.ToString("dd-MM-yyyy", New CultureInfo("es-ES"))
    End Sub

    Public Shared Function formatearFecha(ByVal fecha As Object) As String
        If fecha Is Nothing Then
            Return Nothing
        End If
        Return CDate(fecha).ToString("dd-MM-yyyy")
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim idCliente As Integer = -1, idPersona As Integer = -1, idDistrito As Integer = -1
        Dim nombre As String = "", direccion As String = "", correo As String = "", telefono As String = "", sexo As String = ""
        Dim fechaRegistro As String = txtFechaRegistro.Text
        Dim fechaNacimiento As String = formatearFecha(dchFechaNacimiento.Value)

        Try
            If txtNombre.Text.Trim() = "" Then
                MessageBox.Show("El nombre es obligatorio")
                txtNombre.Focus()
                Return
            End If

            If txtDni.Text.Trim() = "" Then
                MessageBox.Show("El número de documento es obligatorio")
                txtDni.Focus()
                Return
            End If

            If Not rbnM.Checked AndAlso Not rbnF.Checked Then
                MessageBox.Show("Debe seleccionar el sexo")
                Return
            End If

            If cboDistrito.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un distrito")
                Return
            End If

            nombre = txtNombre.Text.Trim()
            idPersona = Integer.Parse(txtDni.Text.Trim())
            direccion = txtDireccion.Text.Trim()
            correo = txtCorreo.Text.Trim()
            telefono = txtTelefono.Text.Trim()

            If rbnM.Checked Then
                sexo = "M"
            ElseIf rbnF.Checked Then
                sexo = "F"
            End If

            Dim distrito As String = CStr(cboDistrito.SelectedItem)
            idDistrito = objUbicacion.buscarIdxDistrito(distrito)

            idCliente = objPersona.generarCodigoCliente()

            objPersona.registrarPersona(idCliente, idPersona, nombre, direccion, correo, telefono, sexo, fechaRegistro, idDistrito, fechaNacimiento)

            MessageBox.Show("CLIENTE REGISTRADO CORRECTAMENTE ")

            limpiar()
            listar()

        Catch ex As FormatException
            MessageBox.Show("Error: El documento debe ser numérico" & vbCrLf & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al registrar cliente:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged
        If cargar_datos2 AndAlso cboProvincia.SelectedIndex <> -1 Then
            Dim provincia As String = CStr(cboProvincia.SelectedItem)
            cboDistrito.Enabled = True
            cargarDistrito(provincia)
        End If
    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedIndexChanged
        If Not cargar_datos Then
            Return
        End If
        If cboDepartamento.SelectedIndex <> -1 Then
            Dim departamento As String = CStr(cboDepartamento.SelectedItem)

            cboProvincia.Items.Clear()
            cboDistrito.Items.Clear()
            cboProvincia.Enabled = False
            cboDistrito.Enabled = False
            cargar_datos2 = False

            cargarProvincia(departamento)
            cboProvincia.Enabled = True
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        mostrarFechaCorta()
    End Sub

End Class
