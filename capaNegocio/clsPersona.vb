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

    Public Function listarPersonaMo() As DataTable
        Dim strSQL As String =
        "SELECT " &
        "cl.idCliente, " &
        "pe.persona AS persona, " &
        "pe.sexo, " &
        "cl.numDocumento, " &
        "cl.direccion, " &
        "cl.correo, " &
        "cl.telefono, " &
        "pe.fechaNacimiento " &
        "FROM PERSONA pe " &
        "INNER JOIN CLIENTE cl ON cl.idCliente = pe.idCliente " &
        "ORDER BY pe.persona ASC"

        Dim objConectar As New clsConectaBD()
        Dim dt As New DataTable()

        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            da.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw New Exception("Error al listar personas: " & ex.Message)

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

    Public Function buscarPersonaRapida(nombre As String) As DataTable
        Dim strSQL As String = "SELECT pe.idCliente, pe.persona, cl.correo,cl.telefono " &
                           "FROM PERSONA pe " &
                           "INNER JOIN CLIENTE cl ON cl.idCliente = pe.idCliente " &
                           "WHERE cl.numDocumento LIKE @txtDoc"
        Dim objConectar As New clsConectaBD()
        Dim dt As New DataTable()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            da.SelectCommand.Parameters.Add("@txtDoc", SqlDbType.VarChar).Value = "%" & nombre & "%"
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al buscar Persona: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function buscarPersona(nombre As String) As DataTable
        Dim strSQL As String = "SELECT pe.idCliente, pe.Personavarchar, pe.sexo, cl.direccion, cl.correo " &
                           "FROM PERSONA pe " &
                           "INNER JOIN CLIENTE cl ON cl.idCliente = pe.idCliente " &
                           "WHERE pe.Personavarchar LIKE @nombre"
        Dim objConectar As New clsConectaBD()
        Dim dt As New DataTable()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = "%" & nombre & "%"
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

    Public Sub modificarPersona(idCli As Integer, nombre As String, dir As String, dni As String, cor As String, tel As String, sx As String, idDis As Integer, fechaNac As Date)
        Dim objConectar As New clsConectaBD()
        objConectar.conectar()
        Dim trans As SqlTransaction = objConectar.miConexion.BeginTransaction()

        Try
            Dim cmd1 As New SqlCommand(
            "UPDATE CLIENTE SET " &
            "numDocumento = @dni, " &
            "direccion    = @dir, " &
            "correo       = @cor, " &
            "telefono     = @tel, " &
            "idDistrito   = @idDis " &
            "WHERE idCliente = @idCli",
            objConectar.miConexion, trans
        )
            cmd1.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni
            cmd1.Parameters.Add("@dir", SqlDbType.VarChar).Value = dir
            cmd1.Parameters.Add("@cor", SqlDbType.VarChar).Value = cor
            cmd1.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel
            cmd1.Parameters.Add("@idDis", SqlDbType.Int).Value = idDis
            cmd1.Parameters.Add("@idCli", SqlDbType.Int).Value = idCli
            cmd1.ExecuteNonQuery()

            Dim cmd2 As New SqlCommand(
            "UPDATE PERSONA SET " &
            "Personavarchar  = @nombre, " &
            "sexo            = @sx, " &
            "fechaNacimiento = @fechaNac " &
            "WHERE idCliente = @idCli",
            objConectar.miConexion, trans
        )
            cmd2.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre
            cmd2.Parameters.Add("@sx", SqlDbType.Char, 1).Value = sx
            cmd2.Parameters.Add("@fechaNac", SqlDbType.Date).Value = fechaNac
            cmd2.Parameters.Add("@idCli", SqlDbType.Int).Value = idCli
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
            ' 1. Eliminar descuentos de comprobantes
            Dim cmd1 As New SqlCommand(
            "DELETE FROM DESCUENTO_COMPROBANTE WHERE idComprobante IN " &
            "(SELECT idComprobante FROM COMPROBANTE_VENTA WHERE idCliente = @idCli)",
            objConectar.miConexion, trans)
            cmd1.Parameters.Add("@idCli", SqlDbType.Int).Value = idCli
            cmd1.ExecuteNonQuery()

            ' 2. Eliminar detalle de ventas
            Dim cmd2 As New SqlCommand(
            "DELETE FROM DETALLE_VENTA WHERE idComprobante IN " &
            "(SELECT idComprobante FROM COMPROBANTE_VENTA WHERE idCliente = @idCli)",
            objConectar.miConexion, trans)
            cmd2.Parameters.Add("@idCli", SqlDbType.Int).Value = idCli
            cmd2.ExecuteNonQuery()

            ' 3. Eliminar comprobantes
            Dim cmd3 As New SqlCommand(
            "DELETE FROM COMPROBANTE_VENTA WHERE idCliente = @idCli",
            objConectar.miConexion, trans)
            cmd3.Parameters.Add("@idCli", SqlDbType.Int).Value = idCli
            cmd3.ExecuteNonQuery()

            ' 4. Eliminar persona
            Dim cmd4 As New SqlCommand(
            "DELETE FROM PERSONA WHERE idCliente = @idCli",
            objConectar.miConexion, trans)
            cmd4.Parameters.Add("@idCli", SqlDbType.Int).Value = idCli
            cmd4.ExecuteNonQuery()

            ' 5. Eliminar cliente
            Dim cmd5 As New SqlCommand(
            "DELETE FROM CLIENTE WHERE idCliente = @idCli",
            objConectar.miConexion, trans)
            cmd5.Parameters.Add("@idCli", SqlDbType.Int).Value = idCli
            cmd5.ExecuteNonQuery()

            trans.Commit()

        Catch ex As Exception
            trans.Rollback()
            Throw New Exception("Error al eliminar Persona: " & ex.Message)

        Finally
            objConectar.desconectar()
        End Try
    End Sub

End Class