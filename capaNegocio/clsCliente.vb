Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsCliente
    ' Propiedades
    Public Property idcliente As Integer
    Public Property tipocliente As String
    Public Property fecharegistro As Date
    Public Property direccion As String
    Public Property correo As String
    Public Property telefono As String
    Public Property idtipodocumento As Integer
    Public Property iddistrito As Integer
    Public Property idrepresentate As Integer

    Private objConectar As New clsConectaBD()

    ' Constructor vacío
    Public Sub New()
    End Sub

    ' Constructor con parámetros
    Public Sub New(id As Integer, tipo As String, fecha As Date, dir As String, cor As String, tel As String, idDoc As Integer, idDis As Integer, idRep As Integer)
        Me.idcliente = id
        Me.tipocliente = tipo
        Me.fecharegistro = fecha
        Me.direccion = dir
        Me.correo = cor
        Me.telefono = tel
        Me.idtipodocumento = idDoc
        Me.iddistrito = idDis
        Me.idrepresentate = idRep
    End Sub

    Public Function listarClientes() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT cl.idcliente, tp.tipodocumento FROM cliente cl INNER JOIN tipo_documento tp ON tp.idtipodocumento = cl.idtipodocumento"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar Cliente: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function registrarClienteEmpresa(
    ruc As String,
    direccion As String,
    correo As String,
    telefono As String,
    idDistrito As Integer
    ) As Integer

        Dim strSQL As String =
        "INSERT INTO CLIENTE(" &
        "tipoCliente, " &
        "fechaRegistro, " &
        "direccion, " &
        "correo, " &
        "telefono, " &
        "idTipoDocumento, " &
        "idDistrito, " &
        "numDocumento, " &
        "estado) " &
        "VALUES(" &
        "'Empresa', " &
        "@fecha, " &
        "@direccion, " &
        "@correo, " &
        "@telefono, " &
        "2, " &  ' idTipoDocumento = 2 (RUC)
        "@idDistrito, " &
        "@ruc, " &
        "1); " &
        "SELECT SCOPE_IDENTITY()"

        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = Date.Today
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = If(direccion = "", DBNull.Value, direccion)
            cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = If(correo = "", DBNull.Value, correo)
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = If(telefono = "", DBNull.Value, telefono)
            cmd.Parameters.Add("@idDistrito", SqlDbType.Int).Value = idDistrito
            cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 11).Value = ruc
            Return Convert.ToInt32(cmd.ExecuteScalar())

        Catch ex As Exception
            Throw New Exception("Error al registrar cliente empresa: " & ex.Message)

        Finally
            objConectar.desconectar()
        End Try
    End Function
    Public Function generarCodigoCliente() As Integer
        Dim codigo As Integer = 0
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT COALESCE(MAX(idcliente), 0) + 1 AS codigo FROM CLIENTE"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            codigo = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al generar código de cliente: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return codigo
    End Function

    Public Function buscar(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT * FROM cliente WHERE idcliente = @id"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function buscarIdDistrito(nombre As String) As Integer
        Dim id As Integer = -1
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT iddistrito FROM distrito WHERE nomdistrito LIKE @nombre"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@nombre", "%" & nombre & "%")

            Dim resultado As Object = cmd.ExecuteScalar()
            If resultado IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado) Then
                id = Convert.ToInt32(resultado)
            End If
        Catch ex As Exception
            Throw New Exception("Error al buscar distrito: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return id
    End Function

    Public Function buscarIdCliente(nombre As String) As Integer
        Dim id As Integer = -1
        Try
            objConectar.abrirconexion()

            ' Primera consulta: Empresa
            Dim strSQL As String = "SELECT C.idcliente FROM CLIENTE C INNER JOIN EMPRESA E ON E.idempresa = C.idrepresentante WHERE E.RAZONSOCIAL = @nombre"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)

            Dim resultado As Object = cmd.ExecuteScalar()
            If resultado IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado) Then
                id = Convert.ToInt32(resultado)
            Else
                ' Segunda consulta: Persona
                Dim strSQL1 As String = "SELECT P.idcliente FROM CLIENTE C INNER JOIN PERSONA P ON P.IDCLIENTE = C.IDCLIENTE WHERE P.persona = @nombre"
                Dim cmd1 As New SqlCommand(strSQL1, objConectar.miConexion)
                cmd1.Parameters.AddWithValue("@nombre", nombre)

                Dim resultado1 As Object = cmd1.ExecuteScalar()
                If resultado1 IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado1) Then
                    id = Convert.ToInt32(resultado1)
                End If
            End If
        Catch ex As Exception
            Throw New Exception("Error al buscar cliente: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return id
    End Function

    Public Sub registrarCliente(id As Integer, tipoCliente As String, fechaRegistro As Date, distrito As String, representate As Integer)
        Try
            Dim idDistrito As Integer = buscarIdDistrito(distrito)
            objConectar.abrirconexion()

            Dim strSQL As String = "INSERT INTO cliente VALUES(@id, @tipo, @fecha, @idDistrito, @rep)"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@tipo", tipoCliente)
            cmd.Parameters.AddWithValue("@fecha", fechaRegistro)
            cmd.Parameters.AddWithValue("@idDistrito", idDistrito)
            cmd.Parameters.AddWithValue("@rep", representate)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar Cliente: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Sub modificarCliente(id As Integer, distrito As String)
        Try
            Dim idDistrito As Integer = buscarIdDistrito(distrito)
            objConectar.abrirconexion()

            Dim strSQL As String = "UPDATE cliente SET iddistrito = @idDistrito WHERE idcliente = @id"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@idDistrito", idDistrito)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al modificar al cliente: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Sub eliminarCliente(id As Integer)
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "DELETE FROM cliente WHERE idcliente = @id"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar cliente: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Function listarNombreClientes() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT p.persona AS cliente FROM cliente c INNER JOIN persona p ON p.idcliente = c.idcliente " &
                                   "UNION ALL " &
                                   "SELECT e.razonsocial FROM cliente c INNER JOIN empresa e ON e.idempresa = c.idrepresentante"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar clientes --> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function listarClientesConTipo() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            ' Personas: siempre tienen registro en cliente (se registran juntos en transacción)
            ' Empresas: se registran solo en la tabla empresa, sin registro en cliente
            Dim strSQL As String =
                "SELECT 'Persona' AS tipo, p.persona AS cliente " &
                "FROM persona p INNER JOIN cliente c ON c.idcliente = p.idcliente " &
                "UNION ALL " &
                "SELECT 'Empresa' AS tipo, e.razonsocial AS cliente " &
                "FROM empresa e " &
                "ORDER BY tipo, cliente"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar clientes con tipo --> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function obtenerNumeroDocumento(nombre As String) As String
        Dim nroDocumento As String = ""
        Try
            objConectar.abrirconexion()

            ' Primero buscar en personas (cliente con persona asociada)
            Dim strPersona As String =
                "SELECT cli.numdocumento FROM cliente cli " &
                "INNER JOIN persona per ON per.idcliente = cli.idcliente " &
                "WHERE per.persona = @nombre"
            Dim cmdPersona As New SqlCommand(strPersona, objConectar.miConexion)
            cmdPersona.Parameters.AddWithValue("@nombre", nombre)
            Dim res1 As Object = cmdPersona.ExecuteScalar()
            If res1 IsNot Nothing AndAlso Not DBNull.Value.Equals(res1) Then
                nroDocumento = res1.ToString()
                Return nroDocumento
            End If

            ' Si no se encontró, buscar RUC directamente en empresa
            Dim strEmpresa As String =
                "SELECT COALESCE(ruc, '') FROM empresa WHERE razonsocial = @nombre"
            Dim cmdEmpresa As New SqlCommand(strEmpresa, objConectar.miConexion)
            cmdEmpresa.Parameters.AddWithValue("@nombre", nombre)
            Dim res2 As Object = cmdEmpresa.ExecuteScalar()
            If res2 IsNot Nothing AndAlso Not DBNull.Value.Equals(res2) Then
                nroDocumento = res2.ToString()
            End If

        Catch ex As Exception
            Throw New Exception("Error al obtener numero de documento del cliente -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return nroDocumento
    End Function

    Public Function listarTiposDocumento() As DataTable
        Dim strSQL As String = "SELECT idtipodocumento, tipodocumento FROM tipo_documento"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar tipos de documento: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function listarDepartamentos() As DataTable
        Dim strSQL As String = "SELECT iddepartamento, departamento FROM departamento ORDER BY departamento"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar departamentos: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function listarProvincias(idDepto As Integer) As DataTable
        Dim strSQL As String = "SELECT idprovincia, provincia FROM provincia WHERE iddepartamento = " & idDepto & " ORDER BY provincia"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar provincias: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function listarDistritos(idProvincia As Integer) As DataTable
        Dim strSQL As String = "SELECT iddistrito, distrito FROM distrito WHERE idprovincia = " & idProvincia & " ORDER BY distrito"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar distritos: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function
End Class