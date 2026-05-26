Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsTipoDescuento
    Private objConectar As New clsConectaBD()

    Public Function listar() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT idTipoDescuento, tipoDescuento FROM TIPO_DESCUENTO"
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar tipos: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function
End Class