Imports capaNegocio

Public Class jdGestionarUsuario

    Dim objTrabajador As New clsTrabajador()

    ' VARIABLE CLAVE: Aquí guardaremos el ID del trabajador cuando hagamos doble clic
    Dim idTrabajadorSeleccionado As Integer = 0

    '================================================================
    ' AL CARGAR EL FORMULARIO
    '================================================================
    Private Sub frmGestionarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarTablaUsuarios()
            LimpiarFormulario()

            CargarComboPreguntas()

            ' Bloqueamos la caja de texto para que no escriban nombres a mano
            txtTrabajador.ReadOnly = True

            txtContrasena.PasswordChar = "*"
            txtConfirmarContrasena.PasswordChar = "*"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inicial", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '================================================================
    ' MÉTODOS DE APOYO
    '================================================================
    Private Sub CargarTablaUsuarios(Optional filtro As String = "")
        dgvUsuarios.DataSource = objTrabajador.ListarUsuariosGrid(filtro)
    End Sub

    Private Sub CargarComboPreguntas()
        Try
            cboPregunta.Items.Clear() ' Limpiamos por si acaso

            ' 1. Agregamos nuestras preguntas por defecto (así nunca estará vacío)
            cboPregunta.Items.Add("¿Nombre de tu primera mascota?")
            cboPregunta.Items.Add("¿Ciudad de nacimiento?")
            cboPregunta.Items.Add("¿Nombre de tu escuela primaria?")

            ' 2. Consultamos la Base de Datos
            Dim dt As DataTable = objTrabajador.ListarPreguntasSeguridad()

            ' 3. Agregamos las de la BD SOLO si no están repetidas
            For Each fila As DataRow In dt.Rows
                Dim preguntaBD As String = fila("pregunta").ToString().Trim()

                ' Verificamos que no exista ya en el combo para no duplicar
                If Not cboPregunta.Items.Contains(preguntaBD) Then
                    cboPregunta.Items.Add(preguntaBD)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar preguntas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LimpiarFormulario()
        idTrabajadorSeleccionado = 0 ' Reseteamos el ID
        txtTrabajador.Clear()
        txtUsuario.Clear()
        txtContrasena.Clear()
        txtConfirmarContrasena.Clear()
        cboPregunta.SelectedIndex = -1
        txtRespuesta.Clear()
        chkActivo.Checked = True
    End Sub

    '================================================================
    ' BOTONERA DE ACCIONES
    '================================================================
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarFormulario()
        MessageBox.Show("Seleccione un trabajador de la tabla haciendo doble clic para asignarle un usuario.", "Instrucción", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' 1. Validaciones
        If idTrabajadorSeleccionado = 0 Then
            MessageBox.Show("Debe seleccionar un trabajador de la tabla haciendo doble clic.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtUsuario.Text.Trim() = "" Or txtContrasena.Text.Trim() = "" Or txtRespuesta.Text.Trim() = "" Then
            MessageBox.Show("Por favor complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtContrasena.Text <> txtConfirmarContrasena.Text Then
            MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 2. Guardar en BD usando el ID oculto
        Try
            Dim preguntaStr As String = cboPregunta.Text

            objTrabajador.GuardarCredenciales(idTrabajadorSeleccionado, txtUsuario.Text, txtContrasena.Text, preguntaStr, txtRespuesta.Text, chkActivo.Checked)

            MessageBox.Show("Credenciales guardadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarFormulario()
            CargarTablaUsuarios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' Ejecutamos la misma lógica de Guardar (es un UPDATE)
        btnGuardar_Click(sender, e)
    End Sub

    '================================================================
    ' BUSCADOR
    '================================================================
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarTablaUsuarios(txtBuscar.Text)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        CargarTablaUsuarios(txtBuscar.Text)
    End Sub

    '================================================================
    ' PASAR DATOS DE LA TABLA AL FORMULARIO AL HACER DOBLE CLIC
    '================================================================
    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)

            ' 1. Guardamos el ID oculto
            idTrabajadorSeleccionado = Convert.ToInt32(fila.Cells("ID").Value)

            ' 2. Mostramos los textos en las cajas
            txtTrabajador.Text = fila.Cells("Empleado").Value.ToString()
            txtUsuario.Text = fila.Cells("Usuario").Value.ToString()
            chkActivo.Checked = Convert.ToBoolean(fila.Cells("Activo").Value)

            ' Limpiamos contraseñas y preguntas por seguridad
            txtContrasena.Clear()
            txtConfirmarContrasena.Clear()
            txtRespuesta.Clear()
            cboPregunta.SelectedIndex = -1
        End If
    End Sub

End Class