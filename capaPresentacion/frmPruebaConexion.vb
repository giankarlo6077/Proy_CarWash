Public Class frmPruebaConexion
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConexion As New capaDatos.clsConectaBD()

        Try
            ' 2. Intentamos conectar a la base de datos
            objConexion.conectar()

            ' 3. Si llega a esta línea sin saltar al Catch, significa que conectó perfectamente
            MessageBox.Show("¡Conexión Exitosa a Somee!" & vbCrLf &
                            "Estado: " & objConexion.estadoCN,
                            "Prueba de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' 4. Si hay algún error (contraseña mal, servidor caído, etc.), mostramos el error sin que se cierre el programa
            MessageBox.Show("Error al intentar conectar: " & vbCrLf & ex.Message,
                            "Fallo de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' 5. Siempre cerramos la conexión al terminar la prueba para no saturar el servidor
            objConexion.desconectar()
        End Try
    End Sub
End Class