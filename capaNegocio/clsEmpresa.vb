Imports System.Data

Public Class clsEmpresa
    Inherits clsCliente

    Private _idempresa As Integer
    Private _razonsocia As String

    Public Sub New()
    End Sub

    '******************************************************
    Private rstSQL As String = ""
    Private strSQLGrupo() As String

    Public Function listarEmpresa() As DataTable
        rstSQL = "select  * from empresa e inner join cliente c on c.idcliente = e.idcliente order by 1 "
        Try
            Return objConectar.consultarBD(rstSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar La Empresa")
        End Try
    End Function

    Public Function bucarEmpresaRUC(ByVal ruc As String) As DataTable
        rstSQL = "Select * from empresa where idempresa='" & ruc & "'"
        Try
            Return objConectar.consultarBD(rstSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar Empresa")
        End Try
    End Function

    Public Sub RegistrarEmpresa(
        ByVal idcliente As Integer,
        ByVal direccion As String,
        ByVal correo As String,
        ByVal telefono As String,
        ByVal idDistrito As Integer,
        ByVal idrepresentante As Integer,
        ByVal idempresa As Integer,
        ByVal razon As String)
        strSQLGrupo = New String(1) {}
        strSQLGrupo(0) = "insert into cliente values(" & idcliente & ",'EMPRESA',GETDATE(),'" &
                direccion & "','" & correo & "','" & telefono & "',2," & idDistrito & "," & idrepresentante & ");"
        strSQLGrupo(1) = "insert into empresa values(" & idempresa & "," & razon & "," & idcliente & ")"
        Try
            objConectar.ejecutarBDTransacciones(strSQLGrupo)
        Catch ex As Exception
            Throw New Exception("Error al Registrar Empresa")
        End Try
    End Sub

    Public Sub ModificarEmpresa(
        ByVal idcliente As Integer,
        ByVal direccion As String,
        ByVal correo As String,
        ByVal telefono As String,
        ByVal idDistrito As Integer,
        ByVal idrepresentante As Integer,
        ByVal idempresa As Integer,
        ByVal razon As String)
        strSQLGrupo = New String(1) {}
        strSQLGrupo(0) = "update cliente set " &
                " direccion = '" & direccion & "'," &
                " correo = '" & correo & "'," &
                " telefono = '" & telefono & "'," &
                " iddistrito =" & idDistrito & "," &
                " idrepresentante =" & idrepresentante &
                " where idcliente = " & idcliente & ";"
        strSQLGrupo(1) = " update  empresa set " &
                " razon = '" & razon & "'," &
                " where insert into empresa values(" & idempresa & "," & razon & "," & idcliente & ")"
    End Sub

    Public Sub eliminar(ByVal idEmpresa As Integer)
        strSQL = "delete from empresa where idempresa=" & idEmpresa
        Try
            objConectar.ejecutarBD(strSQL)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    '******************************************************

    Public Sub New(ByVal idempresa As Integer, ByVal razonsocia As String, ByVal idcliente As Integer, ByVal tipocliente As String, ByVal fecharegistro As Date, ByVal direccion As String, ByVal correo As String, ByVal telefono As String, ByVal idtipodocumento As Integer, ByVal iddistrito As Integer, ByVal idrepresentate As Integer)
        MyBase.New(idcliente, tipocliente, fecharegistro, direccion, correo, telefono, idtipodocumento, iddistrito, idrepresentate)
        Me._idempresa = idempresa
        Me._razonsocia = razonsocia
    End Sub

    Public Property idempresa() As Integer
        Get
            Return _idempresa
        End Get
        Set(ByVal value As Integer)
            _idempresa = value
        End Set
    End Property

    Public Property razonsocia() As String
        Get
            Return _razonsocia
        End Get
        Set(ByVal value As String)
            _razonsocia = value
        End Set
    End Property

End Class
