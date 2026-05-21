Imports System.Data

Public Class clsPersona
    Inherits clsCliente

    Private _idpersona As Integer
    Private _persona As String
    Private _sexo As String
    Private _fechanacimiento As Date

    '***************************************************************************
    Private objCliente As New clsCliente()
    Private strSQLGrupo() As String

    Public Function listarPersona() As DataTable
        strSQL = "select pe.idcliente,pe.idpersona,pe.persona,pe.sexo,cl.direccion,cl.correo from persona pe " &
                 " inner join cliente cl on cl.idcliente = pe.idcliente "
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Personas")
        End Try
    End Function

    Public Function generarIdPersona() As Integer
        strSQL = "select coalesce(max(idpersona)+1,1) as cant from persona"
        Try
            Dim dt As DataTable = objConectar.consultarBD(strSQL)
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("cant"))
            End If
        Catch ex As Exception
            Throw New Exception("Error al generar id Persona")
        End Try
        Return 0
    End Function

    Public Function buscarPersona(ByVal numeroDocumento As String) As DataTable
        strSQL = "select pe.idcliente,pe.persona,pe.sexo,cl.direccion,cl.correo from persona pe " &
                 "inner join cliente cl on cl.idcliente = pe.idcliente " &
                 "where persona like '%" & numeroDocumento & "%'"
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar Persona")
        End Try
    End Function

    Public Sub registrarPersona(
            ByVal cliente As Integer,
            ByVal persona As Integer,
            ByVal nombre As String,
            ByVal direccion As String,
            ByVal correo As String,
            ByVal telefono As String,
            ByVal sexo As String,
            ByVal fechaRegistro As String,
            ByVal distrito As Integer,
            ByVal fechaNacimiento As String)
        strSQLGrupo = New String(1) {}
        strSQLGrupo(0) = "insert into cliente values(" & cliente & ",'PERSONA','" & fechaRegistro & "','" & direccion & "','" & correo & "'," & telefono & ",1," & distrito & ", null)"
        strSQLGrupo(1) = "insert into persona values(" & persona & ",'" & nombre & "','" & sexo & "','" & fechaNacimiento & "'," & cliente & ")"
        Try
            objConectar.ejecutarBDTransacciones(strSQLGrupo)
        Catch ex As Exception
            Throw New Exception("error al registrar cliente -Persona" & ex.Message)
        End Try
    End Sub

    Public Sub modificarPersona(
            ByVal cliente As Integer,
            ByVal nombre As String,
            ByVal apepaterno As String,
            ByVal apematerno As String,
            ByVal tipodocumento As String,
            ByVal numerodoc As String,
            ByVal direccion As String,
            ByVal correo As String,
            ByVal telefono As String,
            ByVal sexo As String)
        strSQL = "update persona set " &
                 " nombre=" & nombre & "," &
                 "apepaterno=" & apepaterno & "," &
                 "apematerno=" & apematerno & "," &
                 "tipodocumento=" & tipodocumento & "," &
                 "numerodoc=" & numerodoc & "," &
                 "direccion=" & direccion & "," &
                 "correo" & correo & "," &
                 "telefono" & telefono & "," &
                 "sexo" & sexo & "," &
                 "where idcliente=" & cliente
        Try
            objConectar.ejecutarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar Persona")
        End Try
    End Sub

    Public Sub eliminarPersona(ByVal id As Integer)
        strSQL = "delete from cliente where idcliente=" & id
        objCliente.eliminarCliente(id)
        Try
            objConectar.ejecutarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar Persona")
        End Try
    End Sub
    '***************************************************************************

    Public Sub New()
    End Sub

    Public Sub New(ByVal idpersona As Integer, ByVal persona As String, ByVal sexo As String, ByVal fechanacimiento As Date, ByVal idcliente As Integer, ByVal tipocliente As String, ByVal fecharegistro As Date, ByVal direccion As String, ByVal correo As String, ByVal telefono As String, ByVal idtipodocumento As Integer, ByVal iddistrito As Integer, ByVal idrepresentate As Integer)
        MyBase.New(idcliente, tipocliente, fecharegistro, direccion, correo, telefono, idtipodocumento, iddistrito, idrepresentate)
        Me._idpersona = idpersona
        Me._persona = persona
        Me._sexo = sexo
        Me._fechanacimiento = fechanacimiento
    End Sub

    Public Property idpersona() As Integer
        Get
            Return _idpersona
        End Get
        Set(ByVal value As Integer)
            _idpersona = value
        End Set
    End Property

    Public Property persona() As String
        Get
            Return _persona
        End Get
        Set(ByVal value As String)
            _persona = value
        End Set
    End Property

    Public Property sexo() As String
        Get
            Return _sexo
        End Get
        Set(ByVal value As String)
            _sexo = value
        End Set
    End Property

    Public Property fechanacimiento() As Date
        Get
            Return _fechanacimiento
        End Get
        Set(ByVal value As Date)
            _fechanacimiento = value
        End Set
    End Property

End Class
