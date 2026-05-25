Imports System.Data.SqlClient
Imports capaDatos

Public Class clsTrabajador

    ' Instanciamos tu clase de conexión
    Dim objConexion As New clsConectaBD()

    '================================================================
    ' MÉTODO 1: VALIDAR VIGENCIA (Si el usuario está activo)
    '================================================================
    Public Function ValidarVigencia(usuario As String) As Boolean
        Dim estado As Boolean = False
        Try
            objConexion.conectar()

            ' Consulta segura usando parámetros
            Dim strSQL As String = "SELECT estado FROM trabajador WHERE usuario = @user"

            ' AQUI ESTÁ EL CAMBIO: Usamos objConexion.miConexion
            Dim cmd As New SqlCommand(strSQL, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@user", usuario)

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                estado = Convert.ToBoolean(dr("estado"))
            End If
            dr.Close()

        Catch ex As Exception
            Throw New Exception("Error al validar usuario. --> " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return estado
    End Function

    '================================================================
    ' MÉTODO 2: LOGIN (Devuelve el nombre del trabajador)
    '================================================================
    Public Function Login(usuario As String, contrasena As String) As String
        Dim nombreTrabajador As String = ""
        Try
            objConexion.conectar()

            ' Consulta segura usando parámetros
            Dim strSQL As String = "SELECT trabajador FROM trabajador WHERE usuario = @user AND contraseña = @pass"

            ' AQUI ESTÁ EL CAMBIO: Usamos objConexion.miConexion
            Dim cmd As New SqlCommand(strSQL, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@user", usuario)
            cmd.Parameters.AddWithValue("@pass", contrasena)

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                nombreTrabajador = dr("trabajador").ToString()
            End If
            dr.Close()

        Catch ex As Exception
            Throw New Exception("Error al iniciar sesión. -->" & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return nombreTrabajador
    End Function
    '================================================================
    ' MÉTODO 3: OBTENER PREGUNTA DE SEGURIDAD
    '================================================================
    Public Function PreguntaRecuperarContra(usuario As String) As String
        Dim pregunta As String = ""
        Try
            objConexion.conectar()
            Dim strSQL As String = "SELECT pregunta FROM trabajador WHERE usuario = @user"

            Dim cmd As New SqlCommand(strSQL, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@user", usuario)

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                pregunta = dr("pregunta").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Error al mostrar pregunta. --> " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return pregunta
    End Function

    '================================================================
    ' MÉTODO 4: OBTENER RESPUESTA DE SEGURIDAD
    '================================================================
    Public Function RespuestaRecuperarContra(usuario As String) As String
        Dim respuesta As String = ""
        Try
            objConexion.conectar()
            Dim strSQL As String = "SELECT respuesta FROM trabajador WHERE usuario = @user"

            Dim cmd As New SqlCommand(strSQL, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@user", usuario)

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                respuesta = dr("respuesta").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Error al cargar respuesta. --> " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return respuesta
    End Function

    '================================================================
    ' MÉTODO 5: GUARDAR NUEVA CONTRASEÑA
    '================================================================
    Public Sub NuevaContrasena(nvaContra As String, usuario As String)
        Try
            objConexion.conectar()
            ' Envolvemos la palabra contraseña entre corchetes por la letra "ñ"
            Dim strSQL As String = "UPDATE trabajador SET [contraseña] = @pass WHERE usuario = @user"

            Dim cmd As New SqlCommand(strSQL, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@pass", nvaContra)
            cmd.Parameters.AddWithValue("@user", usuario)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al guardar nueva contraseña: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    '================================================================
    ' MÉTODO 6: LISTAR EMPLEADOS PARA EL COMBOBOX
    '================================================================
    Public Function ListarEmpleadosParaCombo() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            ' Traemos solo el ID y el Nombre para el desplegable
            Dim strSQL As String = "SELECT idtrabajador, trabajador FROM trabajador"
            Dim da As New SqlDataAdapter(strSQL, objConexion.miConexion)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al cargar lista de empleados: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    '================================================================
    ' MÉTODO 7: LISTAR USUARIOS PARA EL DATAGRIDVIEW
    '================================================================
    Public Function ListarUsuariosGrid(Optional textoBusqueda As String = "") As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            ' Traemos a TODOS los trabajadores. Usamos ISNULL para que no salgan errores si no tienen usuario aún.
            Dim strSQL As String = "SELECT idtrabajador AS ID, trabajador AS Empleado, ISNULL(usuario, '') AS Usuario, ISNULL(estado, 0) AS Activo " &
                                   "FROM trabajador WHERE trabajador LIKE '%' + @busqueda + '%'"

            Dim cmd As New SqlCommand(strSQL, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@busqueda", textoBusqueda)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al cargar la tabla de usuarios: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    '================================================================
    ' MÉTODO 8: ASIGNAR / MODIFICAR CREDENCIALES
    '================================================================
    Public Sub GuardarCredenciales(idTrabajador As Integer, usuario As String, contrasena As String, pregunta As String, respuesta As String, estado As Boolean)
        Try
            objConexion.conectar()
            ' Actualizamos el registro basándonos en el ID oculto
            Dim strSQL As String = "UPDATE trabajador SET usuario = @usu, [contraseña] = @pass, pregunta = @preg, respuesta = @resp, estado = @est " &
                                   "WHERE idtrabajador = @id"

            Dim cmd As New SqlCommand(strSQL, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@usu", usuario)
            cmd.Parameters.AddWithValue("@pass", contrasena)
            cmd.Parameters.AddWithValue("@preg", pregunta)
            cmd.Parameters.AddWithValue("@resp", respuesta)
            cmd.Parameters.AddWithValue("@est", estado)
            cmd.Parameters.AddWithValue("@id", idTrabajador)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al guardar credenciales: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    '================================================================
    ' MÉTODO 9: OBTENER PREGUNTAS DE SEGURIDAD EXISTENTES
    '================================================================
    Public Function ListarPreguntasSeguridad() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            ' Filtramos los nulos o vacíos para que no salga una opción en blanco.
            Dim strSQL As String = "SELECT DISTINCT pregunta FROM trabajador WHERE pregunta IS NOT NULL AND pregunta <> ''"

            Dim da As New SqlDataAdapter(strSQL, objConexion.miConexion)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al cargar preguntas de seguridad: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function
End Class