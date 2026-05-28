Imports capaNegocio

Public Class jdModificarPersona
    Private Sub jdModificarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaNac.Value = Date.Now
        cargarDepartamentos()
        configurarListView()
        cargarListView()
        txtIdCliente.Enabled = False
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
        lvPersona.Columns.Add("DNI", 90)
        lvPersona.Columns.Add("Dirección", 160)
        lvPersona.Columns.Add("Correo", 150)
        lvPersona.Columns.Add("Teléfono", 90)
        lvPersona.Columns.Add("F. Nacimiento", 100)
    End Sub

    Private Sub cargarListView()
        lvPersona.Items.Clear()
        Dim objPersona As New clsPersona()
        Try
            Dim dt As DataTable = objPersona.listarPersonaMo()
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(row("idcliente").ToString())
                item.SubItems.Add(row("persona").ToString())
                item.SubItems.Add(row("sexo").ToString())
                item.SubItems.Add(row("numDocumento").ToString())
                item.SubItems.Add(row("direccion").ToString())
                item.SubItems.Add(row("correo").ToString())
                item.SubItems.Add(row("telefono").ToString())
                item.SubItems.Add(Convert.ToDateTime(row("fechaNacimiento")).ToString("dd/MM/yyyy"))
                lvPersona.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar personas: " & ex.Message)
        End Try
    End Sub

    Private Sub lvPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPersona.SelectedIndexChanged
        If lvPersona.SelectedItems.Count = 0 Then Exit Sub
        Dim item As ListViewItem = lvPersona.SelectedItems(0)

        txtIdCliente.Text = item.SubItems(0).Text
        txtNombreAp.Text = item.SubItems(1).Text
        txtDNI.Text = item.SubItems(3).Text
        txtDireccion.Text = item.SubItems(4).Text
        txtCorreo.Text = item.SubItems(5).Text
        txtTelefono.Text = item.SubItems(6).Text
        dtpFechaNac.Value = Convert.ToDateTime(item.SubItems(7).Text)

        If item.SubItems(2).Text = "M" Then
            chkMasculino.Checked = True
        Else
            chkFemenino.Checked = True
        End If

        btnEliminar.Enabled = True
        btnModificar.Enabled = True
    End Sub

    Private Sub chkMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles chkMasculino.CheckedChanged
        If chkMasculino.Checked Then chkFemenino.Checked = False
    End Sub

    Private Sub chkFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles chkFemenino.CheckedChanged
        If chkFemenino.Checked Then chkMasculino.Checked = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNombreAp.Text.Trim() = "" Then
            MessageBox.Show("Ingrese nombres y apellidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtDNI.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el N° DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If cboDistrito.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un distrito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not chkMasculino.Checked AndAlso Not chkFemenino.Checked Then
            MessageBox.Show("Seleccione un sexo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim sexo As String = If(chkMasculino.Checked, "M", "F")

        Dim objPersona As New clsPersona()
        Try
            objPersona.modificarPersona(
                CInt(txtIdCliente.Text),
                txtNombreAp.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtDNI.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTelefono.Text.Trim(),
                sexo,
                CInt(cboDistrito.SelectedValue),
                dtpFechaNac.Value.Date
            )
            MessageBox.Show("Persona modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdCliente.Text.Trim() = "" Then
            MessageBox.Show("No hay persona seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "¿Está seguro de eliminar esta persona?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If confirm = DialogResult.No Then Exit Sub

        Dim objPersona As New clsPersona()
        Try
            objPersona.eliminarPersona(CInt(txtIdCliente.Text))
            MessageBox.Show("Persona eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarCampos()
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub limpiarCampos()
        txtIdCliente.Text = ""
        txtNombreAp.Text = ""
        txtDNI.Text = ""
        txtDireccion.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        dtpFechaNac.Value = Date.Today
        chkMasculino.Checked = False
        chkFemenino.Checked = False
        cargarDepartamentos()
    End Sub

End Class