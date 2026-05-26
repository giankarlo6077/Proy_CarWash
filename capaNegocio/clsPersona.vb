Imports System.Data.SqlClient
Imports capaDatos

Public Class clsPersona

    Public Property idpersona As Integer
    Public Property persona As String
    Public Property sexo As String
    Public Property fechanacimiento As Date

    Public Function listarPersona() As DataTable
        Dim strSQL As String = "SELECT pe.idcliente, pe.idpersona, pe.persona, pe.sexo, cl.direccion, cl.correo, cl.telefono " &
                           "FROM persona pe " &
                           "INNER JOIN cliente cl ON cl.idcliente = pe.idcliente"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar Personas: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function generarIdPersona() As Integer
        Dim strSQL As String = "SELECT COALESCE(MAX(idpersona) + 1, 1) AS cant FROM persona"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al generar id Persona: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function buscarPersona(nombre As String) As DataTable
        Dim strSQL As String = "SELECT pe.idcliente, pe.persona, pe.sexo, cl.direccion, cl.correo " &
                               "FROM persona pe " &
                               "INNER JOIN cliente cl ON cl.idcliente = pe.idcliente " &
                               "WHERE pe.persona LIKE '%" & nombre & "%'"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al buscar Persona: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Sub registrarPersona(idCli As Integer, idPer As Integer, nombre As String, dir As String, cor As String, tel As String, sx As String, fechaRegistro As Date, idDis As Integer, fechaNac As Date, dni As String)
        Dim objConectar As New clsConectaBD()
        objConectar.conectar()
        Dim trans As SqlTransaction = objConectar.miConexion.BeginTransaction()
        Try
            ' 1. Insertar en CLIENTE especificando columnas (Se omite idCliente porque es IDENTITY)
            Dim sqlCliente As String = "INSERT INTO CLIENTE (tipoCliente, fechaRegistro, direccion, correo, telefono, idTipoDocumento, idDistrito, idRepresentante, numDocumento, estado) " &
                                   "VALUES ('PERSONA', '" & fechaRegistro.ToString("yyyy-MM-dd") & "', '" & dir & "', '" & cor & "', '" & tel & "', 1, " & idDis & ", NULL, '" & dni & "', 1)"

            Dim cmd1 As New SqlCommand(sqlCliente, objConectar.miConexion, trans)
            cmd1.ExecuteNonQuery()

            ' Obtener el idCliente generado automáticamente por el IDENTITY
            Dim cmdId As New SqlCommand("SELECT @@IDENTITY", objConectar.miConexion, trans)
            Dim idClienteGenerado As Integer = Convert.ToInt32(cmdId.ExecuteScalar())

            ' 2. Insertar en PERSONA especificando columnas (Se omite idPersona porque es IDENTITY)
            Dim sqlPersona As String = "INSERT INTO PERSONA (Persona, sexo, fechaNacimiento, idCliente) " &
                                   "VALUES ('" & nombre & "', '" & sx & "', '" & fechaNac.ToString("yyyy-MM-dd") & "', " & idClienteGenerado & ")"

            Dim cmd2 As New SqlCommand(sqlPersona, objConectar.miConexion, trans)
            cmd2.ExecuteNonQuery()

            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            Throw New Exception("Error al registrar Persona: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub modificarPersona(idCli As Integer, nombre As String, dir As String, cor As String, tel As String, sx As String, idDis As Integer, fechaNac As Date)
        Dim objConectar As New clsConectaBD()
        objConectar.conectar()
        Dim trans As SqlTransaction = objConectar.miConexion.BeginTransaction()
        Try
            Dim cmd1 As New SqlCommand("UPDATE cliente SET direccion = '" & dir & "', correo = '" & cor & "', telefono = '" & tel & "', iddistrito = " & idDis & " WHERE idcliente = " & idCli, objConectar.miConexion, trans)
            cmd1.ExecuteNonQuery()
            Dim cmd2 As New SqlCommand("UPDATE persona SET persona = '" & nombre & "', sexo = '" & sx & "', fechanacimiento = '" & fechaNac & "' WHERE idcliente = " & idCli, objConectar.miConexion, trans)
            cmd2.ExecuteNonQuery()
            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            Throw New Exception("Error al modificar Persona: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub eliminarPersona(idCli As Integer)
        Dim objConectar As New clsConectaBD()
        objConectar.conectar()
        Dim trans As SqlTransaction = objConectar.miConexion.BeginTransaction()
        Try
            Dim cmd1 As New SqlCommand("DELETE FROM persona WHERE idcliente = " & idCli, objConectar.miConexion, trans)
            cmd1.ExecuteNonQuery()
            Dim cmd2 As New SqlCommand("DELETE FROM cliente WHERE idcliente = " & idCli, objConectar.miConexion, trans)
            cmd2.ExecuteNonQuery()
            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            Throw New Exception("Error al eliminar Persona: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

End Class