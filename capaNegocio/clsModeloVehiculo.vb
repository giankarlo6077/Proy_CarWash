Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsModeloVehiculo
    Private objConectar As New clsConectaBD()

    Public Function listar() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT DISTINCT(mv.modelovehiculo) AS modelovehiculo, mv.idmodelovehiculo, vm.marcavehiculo, tv.tipovehiculo " &
                                   "FROM modelo_vehiculo mv " &
                                   "INNER JOIN tipo_vehiculo_marca tvm ON tvm.idtipovehiculo = mv.idtipovehiculo " &
                                   "INNER JOIN marca_vehiculo vm ON vm.idmarcavehiculo = tvm.idmarcavehiculo " &
                                   "INNER JOIN tipo_vehiculo tv ON tv.idtipovehiculo = tvm.idtipovehiculo"

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function buscarxId(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT mv.idmodelovehiculo, mv.modelovehiculo, vm.marcavehiculo, tv.tipovehiculo " &
                                   "FROM modelo_vehiculo mv " &
                                   "INNER JOIN tipo_vehiculo_marca tvm ON tvm.idtipovehiculo = mv.idtipovehiculo " &
                                   "INNER JOIN marca_vehiculo vm ON vm.idmarcavehiculo = tvm.idmarcavehiculo " &
                                   "INNER JOIN tipo_vehiculo tv ON tv.idtipovehiculo = tvm.idtipovehiculo " &
                                   "WHERE mv.idmodelovehiculo = @id"

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function buscarIdxNombre(nombre As String) As Integer
        Dim id As Integer = -1
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT mv.idmodelovehiculo FROM modelo_vehiculo mv " &
                                   "INNER JOIN tipo_vehiculo_marca tvm ON tvm.idtipovehiculo = mv.idtipovehiculo " &
                                   "INNER JOIN marca_vehiculo vm ON vm.idmarcavehiculo = tvm.idmarcavehiculo " &
                                   "INNER JOIN tipo_vehiculo tv ON tv.idtipovehiculo = tvm.idtipovehiculo " &
                                   "WHERE mv.modelovehiculo LIKE @nombre"

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            ' Usamos % para buscar coincidencias parciales como lo tenías en Java
            cmd.Parameters.AddWithValue("@nombre", "%" & nombre & "%")

            Dim resultado As Object = cmd.ExecuteScalar()
            If resultado IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado) Then
                id = Convert.ToInt32(resultado)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return id
    End Function
End Class