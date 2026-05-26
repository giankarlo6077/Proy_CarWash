Imports capaNegocio

Public Class jdGestionarPersona

    Private Sub jdGestionarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Value = Date.Now
        dtpFechaNac.Value = Date.Now
        cargarDepartamentos()
        configurarListView()
        cargarListView()
        txtId.Enabled = False
    End Sub

    Private Sub cargarIdCliente()
        Dim objPersona As New clsPersona()
        Try
            txtId.Text = objPersona.generarIdPersona().ToString()
        Catch ex As Exception
            MessageBox.Show("Error al generar ID: " & ex.Message)
        End Try
    End Sub

    Private Sub cargarDepartamentos()
        Dim objCliente As New clsCliente()
        Try
            Dim dt As DataTable = objCliente.listarDepartamentos()
            cboDepartamento.DataSource = dt
            cboDepartamento.DisplayMember = "departamento"
            cboDepartamento.ValueMember = "iddepartamento"
            cboDepartamento.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar departamentos: " & ex.Message)
        End Try
    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedIndexChanged
        If cboDepartamento.SelectedIndex = -1 Then Exit Sub
        Dim objCliente As New clsCliente()
        Try
            Dim idDepto As Integer = Convert.ToInt32(CType(cboDepartamento.SelectedItem, DataRowView)("iddepartamento"))
            Dim dt As DataTable = objCliente.listarProvincias(idDepto)
            cboProvincia.DataSource = dt
            cboProvincia.DisplayMember = "provincia"
            cboProvincia.ValueMember = "idprovincia"
            cboProvincia.SelectedIndex = -1
            cboDistrito.DataSource = Nothing  ' Limpiar distrito al cambiar departamento
        Catch ex As Exception
            MessageBox.Show("Error al cargar provincias: " & ex.Message)
        End Try
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged
        If cboProvincia.SelectedIndex = -1 Then Exit Sub
        Dim objCliente As New clsCliente()
        Try
            Dim idProv As Integer = Convert.ToInt32(CType(cboProvincia.SelectedItem, DataRowView)("idprovincia"))
            Dim dt As DataTable = objCliente.listarDistritos(idProv)
            cboDistrito.DataSource = dt
            cboDistrito.DisplayMember = "distrito"
            cboDistrito.ValueMember = "iddistrito"
            cboDistrito.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar distritos: " & ex.Message)
        End Try
    End Sub

    Private Sub configurarListView()
        lvPersona.View = View.Details
        lvPersona.FullRowSelect = True
        lvPersona.GridLines = True
        lvPersona.Columns.Clear()
        lvPersona.Columns.Add("ID Cliente", 70)
        lvPersona.Columns.Add("Nombres y Apellidos", 200)
        lvPersona.Columns.Add("Sexo", 60)
        lvPersona.Columns.Add("Dirección", 160)
        lvPersona.Columns.Add("Correo", 150)
        lvPersona.Columns.Add("Teléfono", 90)
    End Sub

    Private Sub cargarListView()
        lvPersona.Items.Clear()
        Dim objPersona As New clsPersona()
        Try
            Dim dt As DataTable = objPersona.listarPersona()
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(row("idcliente").ToString())
                item.SubItems.Add(row("persona").ToString())
                item.SubItems.Add(row("sexo").ToString())
                item.SubItems.Add(row("direccion").ToString())
                item.SubItems.Add(row("correo").ToString())
                item.SubItems.Add(row("telefono").ToString())
                lvPersona.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar personas: " & ex.Message)
        End Try
    End Sub

    Private Sub lvPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPersona.SelectedIndexChanged
        If lvPersona.SelectedItems.Count = 0 Then Exit Sub
        Dim item As ListViewItem = lvPersona.SelectedItems(0)
        txtId.Text = item.SubItems(0).Text
        txtNombreAp.Text = item.SubItems(1).Text
        txtDireccion.Text = item.SubItems(3).Text
        txtCorreo.Text = item.SubItems(4).Text
        txtTelefono.Text = item.SubItems(5).Text
        If item.SubItems(2).Text = "M" Then
            chkMasculino.Checked = True
        Else
            chkFemenino.Checked = True
        End If
    End Sub

    Private Sub chkMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles chkMasculino.CheckedChanged
        If chkMasculino.Checked Then chkFemenino.Checked = False
    End Sub

    Private Sub chkFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles chkFemenino.CheckedChanged
        If chkFemenino.Checked Then chkMasculino.Checked = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then
            limpiarCampos()
            cargarIdCliente()
            btnNuevo.Text = "Guardar"

        ElseIf btnNuevo.Text = "Guardar" Then
            Dim sexo As String = ""

            If txtNombreAp.Text.Trim() = "" OrElse txtDNI.Text.Trim() = "" Then
                MessageBox.Show("Complete los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If cboDistrito.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un distrito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim fechaNacimiento As Date = dtpFechaNac.Value.Date
            Dim fechaActual As Date = Date.Today
            Dim edad As Integer = fechaActual.Year - fechaNacimiento.Year

            If fechaNacimiento > fechaActual.AddYears(-edad) Then
                edad -= 1
            End If

            If fechaNacimiento > fechaActual Then
                MessageBox.Show("La fecha de nacimiento no puede ser una fecha futura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If edad < 18 Then
                MessageBox.Show("La persona debe ser mayor de edad (mínimo 18 años).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If chkMasculino.Checked Then
                sexo = "M"
            ElseIf chkFemenino.Checked Then
                sexo = "F"
            Else
                MessageBox.Show("Seleccione el sexo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim objPersona As New clsPersona()
            Try
                Dim idCli As Integer = Convert.ToInt32(txtId.Text)
                Dim idPer As Integer = Convert.ToInt32(txtId.Text)
                Dim idDis As Integer = Convert.ToInt32(CType(cboDistrito.SelectedItem, DataRowView)("iddistrito"))

                objPersona.registrarPersona(
                idCli,
                idPer,
                txtNombreAp.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTelefono.Text.Trim(),
                sexo,
                dtpFecha.Value,
                idDis,
                fechaNacimiento,
                txtDNI.Text.Trim
            )

                MessageBox.Show("Persona registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                limpiarCampos()
                cargarListView()
                btnNuevo.Text = "Nuevo"





            Catch ex As Exception
                MessageBox.Show("Error al registrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtNombreAp.Clear()
        txtDNI.Clear()
        txtDireccion.Clear()
        txtCorreo.Clear()
        txtTelefono.Clear()
        chkMasculino.Checked = False
        chkFemenino.Checked = False
        dtpFecha.Value = Date.Now
        dtpFechaNac.Value = Date.Now
        cboDepartamento.SelectedIndex = -1
        cboProvincia.DataSource = Nothing
        cboDistrito.DataSource = Nothing
        btnNuevo.Text = "Nuevo"
        txtId.Clear()
    End Sub

End Class