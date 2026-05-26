Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsVenta

    Dim objConectar As New clsConectaBD()
    Dim dr As SqlDataReader = Nothing
    Dim strSQL As String

    Public Function generarCodigoVenta() As Integer
        strSQL = "SELECT COALESCE(MAX(iddetalleventa), 0) + 1 AS codigo FROM detalle_venta"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Return Convert.ToInt32(dr("codigo"))
            End While
        Catch ex As Exception
            Throw New Exception("Error al generar código --> " & ex.Message)
        Finally
            If dr IsNot Nothing Then dr.Close()
            objConectar.desconectar()
        End Try
        Return 0
    End Function

End Class