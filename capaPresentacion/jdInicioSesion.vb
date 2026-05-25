Imports capaNegocio ' No olvides importar tu capa de negocio

Public Class jdInicioSesion

    ' Instanciamos la clase trabajador de la capa de negocio
    Dim objTrabajador As New clsTrabajador()
    Dim intentos As Integer = 0
    Public nombreTrabajador As String = ""

    '================================================================
    ' BOTÓN INGRESAR
    '================================================================
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            ' 1. Validamos que el usuario esté activo
            If objTrabajador.ValidarVigencia(txtUsuario.Text) Then

                ' 2. Verificamos credenciales
                nombreTrabajador = objTrabajador.Login(txtUsuario.Text, psdContrasena.Text)

                If nombreTrabajador = "" Then
                    MessageBox.Show("Correo o contraseña incorrecto, intente nuevamente!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    intentos += 1
                    If intentos >= 3 Then
                        MessageBox.Show("Superó los tres intentos. Saliendo del sistema...", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Application.Exit()
                    End If
                Else
                    MessageBox.Show(nombreTrabajador & ", Bienvenido al Sistema!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Abrimos el menú principal
                    Dim objMnuPrincipal As New FrmMenuPrincipalModificado()
                    objMnuPrincipal.Show()

                    ' Cerramos el login actual
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Credenciales incorrectas o el usuario está inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '================================================================
    ' BOTÓN SALIR
    '================================================================
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    '================================================================
    ' ENLACE / BOTÓN RECUPERAR CONTRASEÑA
    '================================================================
    Private Sub btnRecuperarContra_Click(sender As Object, e As EventArgs) Handles btnRecuperarContra.Click
        If txtUsuario.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar un nombre de usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Abrimos el formulario de recuperar contraseña como ventana modal (JDialog en Java)
            Dim frmRecuperar As New jdRecuperarContrasena()
            frmRecuperar.usuarioRecovery = txtUsuario.Text
            frmRecuperar.ShowDialog()
        End If
    End Sub

    Private Sub jdInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class