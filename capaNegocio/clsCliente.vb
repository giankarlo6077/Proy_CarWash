Imports System.Data

Public Class clsCliente

    Private _idcliente As Integer
    Private _tipocliente As String
    Private _fecharegistro As Date
    Private _direccion As String
    Private _correo As String
    Private _telefono As String
    Private _idtipodocumento As Integer
    Private _iddistrito As Integer
    Private _idrepresentate As Integer

    '***********************************************************
    Protected strSQL As String
    Protected objConectar As New capaDatos.clsConectaBD()

    Public Function listarClientes() As DataTable
        strSQL = "select cl.idcliente,tp.tipodocumento from cliente cl inner join tipo_documento tp on tp.idtipodocumento = cl.idtipodocumento"
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Cliente")
        End Try
    End Function

    Public Function generarCodigoCliente() As Integer
        strSQL = "SELECT COALESCE(MAX(idcliente),0)+1 as codigo from CLIENTE"
        Try
            Dim dt As DataTable = objConectar.consultarBD(strSQL)
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("codigo"))
            End If
        Catch ex As Exception
            Throw New Exception("Error al generar código de cliente")
        End Try
        Return 0
    End Function

    Public Function buscar(ByVal idcliente As Integer) As DataTable
        strSQL = "Select * from cliente where idcliente= " & idcliente
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar" & ex.Message)
        End Try
    End Function

    Public Function buscarIdDistrito(ByVal nombre As String) As Integer
        strSQL = "select iddistrito from distrito where nomdistrito like '%" & nombre & "%'"
        Try
            Dim dt As DataTable = objConectar.consultarBD(strSQL)
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("iddistrito"))
            End If
        Catch ex As Exception
            Throw New Exception("Error al buscar distrito")
        End Try
        Return -1
    End Function

    Public Function buscarIdCliente(ByVal nombre As String) As Integer
        strSQL = "SELECT E.idcliente FROM CLIENTE C" &
                 " INNER JOIN EMPRESA E ON E.IDCLIENTE = C.IDCLIENTE " &
                 " WHERE E.RAZONSOCIAL = '" & nombre & "';"
        Dim strSQL1 As String = "SELECT P.idcliente FROM CLIENTE C" &
                 " INNER JOIN PERSONA P ON P.IDCLIENTE = C.IDCLIENTE " &
                 " WHERE P.persona = '" & nombre & "';"
        Try
            Dim dt As DataTable = objConectar.consultarBD(strSQL)
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("idcliente"))
            End If

            dt = objConectar.consultarBD(strSQL1)
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("idcliente"))
            End If
        Catch ex As Exception
            Throw New Exception("Error al buscar cliente" & ex.Message)
        End Try
        Return -1
    End Function

    Public Sub registrarCliente(ByVal id As Integer, ByVal tipoCliente As String, ByVal fechaRegistro As Date, ByVal distrito As String, ByVal representate As Integer)
        strSQL = "insert into cliente values(" & id & ",'" & tipoCliente & "','" & fechaRegistro & "'," & buscarIdDistrito(distrito) & "," & representate & ")"
        Try
            objConectar.ejecutarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar Cliente")
        End Try
    End Sub

    Public Sub modificarCliente(ByVal id As Integer, ByVal distrito As String)
        strSQL = "update cliente set iddistrito=" & buscarIdDistrito(distrito) & " where idcliente=" & id & ";"
        Try
            objConectar.ejecutarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar al cliente")
        End Try
    End Sub

    Public Sub eliminarCliente(ByVal id As Integer)
        strSQL = "delete from cliente where idcliente= " & id
        Try
            objConectar.ejecutarBD(strSQL)
        Catch ex As Exception
            Throw New Exception()
        End Try
    End Sub

    Public Sub darDeBajaCliente()
    End Sub

    Public Function listarNombreClientes() As DataTable
        strSQL = "select p.persona as cliente from cliente c inner join persona p on p.idcliente = c.idcliente " &
                 "union all " &
                 "select e.razonsocial from cliente c inner join empresa e on e.idcliente = c.idcliente"
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar clientes --> " & ex.Message)
        End Try
    End Function

    Public Function obtenerNumeroDocumento(ByVal nombre As String) As String
        strSQL = "select cli.numdocumento as nroDocumento " &
                 "from cliente cli " &
                 "inner join tipo_documento tp on tp.idtipodocumento = cli.idtipodocumento " &
                 "left join persona per on cli.idcliente = per.idcliente " &
                 "left join empresa emp on cli.idcliente = emp.idcliente " &
                 "where per.persona = '" & nombre & "' or emp.razonsocial = '" & nombre & "';"
        Try
            Dim dt As DataTable = objConectar.consultarBD(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)("nroDocumento").ToString()
            End If
            Return ""
        Catch ex As Exception
            Throw New Exception("Error al obtener numero de documento del cliente -> " & ex.Message)
        End Try
    End Function
    '***********************************************************

    Public Sub New()
    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal tipocliente As String, ByVal fecharegistro As Date, ByVal direccion As String, ByVal correo As String, ByVal telefono As String, ByVal idtipodocumento As Integer, ByVal iddistrito As Integer, ByVal idrepresentate As Integer)
        Me._idcliente = idcliente
        Me._tipocliente = tipocliente
        Me._fecharegistro = fecharegistro
        Me._direccion = direccion
        Me._correo = correo
        Me._telefono = telefono
        Me._idtipodocumento = idtipodocumento
        Me._iddistrito = iddistrito
        Me._idrepresentate = idrepresentate
    End Sub

    Public Property idcliente() As Integer
        Get
            Return _idcliente
        End Get
        Set(ByVal value As Integer)
            _idcliente = value
        End Set
    End Property

    Public Property tipocliente() As String
        Get
            Return _tipocliente
        End Get
        Set(ByVal value As String)
            _tipocliente = value
        End Set
    End Property

    Public Property fecharegistro() As Date
        Get
            Return _fecharegistro
        End Get
        Set(ByVal value As Date)
            _fecharegistro = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Property correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property

    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property idtipodocumento() As Integer
        Get
            Return _idtipodocumento
        End Get
        Set(ByVal value As Integer)
            _idtipodocumento = value
        End Set
    End Property

    Public Property iddistrito() As Integer
        Get
            Return _iddistrito
        End Get
        Set(ByVal value As Integer)
            _iddistrito = value
        End Set
    End Property

    Public Property idrepresentate() As Integer
        Get
            Return _idrepresentate
        End Get
        Set(ByVal value As Integer)
            _idrepresentate = value
        End Set
    End Property

End Class
