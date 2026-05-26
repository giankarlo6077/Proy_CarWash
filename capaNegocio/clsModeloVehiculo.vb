Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsModeloVehiculo
    Private objConectar As New clsConectaBD()

    ' Corrección: Usamos GROUP BY para eliminar duplicados de forma nativa en la BD
    Public Function listar() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            ' Al usar GROUP BY por el nombre, eliminamos duplicados automáticamente
            Dim strSQL As String = "SELECT modelovehiculo, MIN(idmodelovehiculo) AS idmodelovehiculo " &
                                   "FROM modelo_vehiculo " &
                                   "GROUP BY modelovehiculo"

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar modelos: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function buscarxId(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            ' He simplificado esta consulta para que sea más rápida
            Dim strSQL As String = "SELECT idmodelovehiculo, modelovehiculo FROM modelo_vehiculo WHERE idmodelovehiculo = @id"

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
            ' Usamos SELECT TOP 1 para asegurar que siempre nos devuelva solo un ID
            Dim strSQL As String = "SELECT TOP 1 idmodelovehiculo FROM modelo_vehiculo WHERE modelovehiculo = @nombre"

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            ' Quitamos los % para que la búsqueda sea exacta, evitando que tome un modelo equivocado
            cmd.Parameters.AddWithValue("@nombre", nombre)

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