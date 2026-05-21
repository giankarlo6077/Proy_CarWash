Imports System.Data

Public Class clsUbicacion
    Private _departamento As String
    Private _provincia As String
    Private _distrito As String

    Private objConectar As New capaDatos.clsConectaBD()
    Private strSQL As String = ""

    Public Function listarDepartamento() As DataTable
        strSQL = "Select * from departamento"
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Departamentos")
        End Try
    End Function

    Public Function listarDistrito(ByVal idpro As Integer) As DataTable
        strSQL = "select  * from distrito where idprovincia=" & idpro
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Distrito")
        End Try
    End Function

    Public Function listarProvincia(ByVal idDepartamento As Integer) As DataTable
        strSQL = "select * from provincia where iddepartamento= " & idDepartamento
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Erro al listar Provincias")
        End Try
    End Function

    Public Function buscarIDxDepartamento(ByVal nombre As String) As Integer
        strSQL = "Select * from departamento where departamento like  '" & nombre & "';"
        Try
            Dim dt As DataTable = objConectar.consultarBD(strSQL)
            If dt.Rows.Count > 0 Then Return Convert.ToInt32(dt.Rows(0)("iddepartamento"))
        Catch ex As Exception
            Throw New Exception("Erroral buscar id x Departamento")
        End Try
        Return -1
    End Function

    Public Function buscarIdXProvincia(ByVal nombre As String) As Integer
        strSQL = "Select * from provincia where provincia like '" & nombre & "';"
        Try
            Dim dt As DataTable = objConectar.consultarBD(strSQL)
            If dt.Rows.Count > 0 Then Return Convert.ToInt32(dt.Rows(0)("idprovincia"))
        Catch ex As Exception
            Throw New Exception("Erro al buscar id x Provincia")
        End Try
        Return -1
    End Function

    Public Function buscarIdxDistrito(ByVal distr As String) As Integer
        strSQL = "select * from distrito where distrito like '" & distr & "';"
        Try
            Dim dt As DataTable = objConectar.consultarBD(strSQL)
            If dt.Rows.Count > 0 Then Return Convert.ToInt32(dt.Rows(0)("iddistrito"))
        Catch ex As Exception
            Throw New Exception("Erro al buscar id x distrito")
        End Try
        Return -1
    End Function

End Class
