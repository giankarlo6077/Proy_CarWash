Imports capaNegocio

Public Class jdRecuperarContrasena

    Dim objTrabajador As New clsTrabajador()
    Dim contador As Integer = 0
    Dim contadorCaptcha As Integer = 0

    ' Esta variable recibirá el usuario desde el frmInicioSesion
    Public usuarioRecovery As String = ""

    '================================================================
    ' AL CARGAR EL FORMULARIO
    '================================================================
    Private Sub frmRecuperarContrasena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargamos la pregunta desde la BD
            lblPregunta.Text = objTrabajador.PreguntaRecuperarContra(usuarioRecovery)

            ' Generamos el primer Captcha
            lblCaptcha.Text = GenerarCaptcha()

            ' Bloqueamos la sección inferior
            psdNvaContrasena.Enabled = False
            psdConfirmNvaContrasena.Enabled = False
            btnGuardar.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '================================================================
    ' GENERADOR DE CAPTCHA
    '================================================================
    Private Function GenerarCaptcha() As String
        Dim rnd As New Random()
        Dim letras As String = "ABCDEFGHIJKL"

        Dim num1 As Integer = rnd.Next(1, 10)
        Dim num2 As Integer = rnd.Next(1, 10)
        Dim num3 As Integer = 3 ' Mantenido igual que en tu código original
        Dim num4 As Integer = rnd.Next(1, 10)
        Dim num5 As Integer = rnd.Next(1, 10)

        Dim letra1 As Char = letras(rnd.Next(0, letras.Length))
        Dim letra2 As Char = letras(rnd.Next(0, letras.Length))

        Return $"{num1}{num2}{num3}{num4}{num5}{letra1}{letra2}"
    End Function

    '================================================================
    ' BOTÓN CONFIRMAR (Pregunta + Captcha)
    '================================================================
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtRespuesta.Text.Trim() = "" Or txtRptaCaptcha.Text.Trim() = "" Then
            MessageBox.Show("Ingrese todos los datos solicitados", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim respuestaBD As String = objTrabajador.RespuestaRecuperarContra(usuarioRecovery)

            If respuestaBD.Equals(txtRespuesta.Text, StringComparison.OrdinalIgnoreCase) AndAlso txtRptaCaptcha.Text.Equals(lblCaptcha.Text) Then

                ' Éxito: Desbloqueamos la parte inferior y bloqueamos la superior
                psdNvaContrasena.Enabled = True
                psdConfirmNvaContrasena.Enabled = True
                btnGuardar.Enabled = True

                txtRespuesta.Enabled = False
                txtRptaCaptcha.Enabled = False
                btnConfirmar.Enabled = False
                btnRecargarCaptcha.Enabled = False

                MessageBox.Show("Datos confirmados, ingrese una nueva contraseña", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If contador < 3 Then
                    MessageBox.Show("Respuesta o Captcha Incorrecto", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lblCaptcha.Text = GenerarCaptcha()
                    contador += 1

                    If contador = 2 Then
                        MessageBox.Show("Te queda 1 intento", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    If contador = 3 Then
                        MessageBox.Show("Error al cambiar contraseña. Excedió los intentos.", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '================================================================
    ' BOTÓN RECARGAR CAPTCHA
    '================================================================
    Private Sub btnRecargarCaptcha_Click(sender As Object, e As EventArgs) Handles btnRecargarCaptcha.Click
        If contadorCaptcha < 3 Then
            lblCaptcha.Text = GenerarCaptcha()
            contadorCaptcha += 1
            If contadorCaptcha = 2 Then
                MessageBox.Show("Te queda 1 intento para recargar el código Captcha", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Solo puedes recargar 3 veces el código Captcha", "Límite", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    '================================================================
    ' BOTÓN GUARDAR (Nueva Contraseña)
    '================================================================
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nvaContra As String = psdNvaContrasena.Text
        Dim confirNvaContra As String = psdConfirmNvaContrasena.Text

        If nvaContra.Equals(confirNvaContra) AndAlso nvaContra.Trim() <> "" Then
            Try
                objTrabajador.NuevaContrasena(nvaContra, usuarioRecovery)
                MessageBox.Show("Contraseña nueva guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Verifique que ambas contraseñas sean las mismas y no estén vacías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class