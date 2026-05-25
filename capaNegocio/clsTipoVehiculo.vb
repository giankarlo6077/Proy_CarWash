Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsTipoVehiculo
    Private objConectar As New clsConectaBD()

    Public Function listarTipoVehiculo() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT * FROM tipo_vehiculo"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar tipos de vehiculos -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function generarCodigoTipoVehiculo() As Integer
        Dim codigo As Integer = 0
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT COALESCE(MAX(idTipoVehiculo), 0) + 1 AS codigo FROM tipo_vehiculo"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)

            codigo = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al generar codigo del tipo de vehiculo -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return codigo
    End Function

    Public Sub registrar(cod As Integer, nom As String)
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "INSERT INTO tipo_vehiculo VALUES (@cod, @nom)"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)

            cmd.Parameters.AddWithValue("@cod", cod)
            cmd.Parameters.AddWithValue("@nom", nom)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar el tipo de vehiculo -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Function buscarTipoVehiculo(cod As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT * FROM tipo_vehiculo WHERE idTipoVehiculo = @cod"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)

            cmd.Parameters.AddWithValue("@cod", cod)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar el tipo de vehiculo -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Sub eliminarTipoVehiculo(cod As Integer)
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "DELETE FROM tipo_vehiculo WHERE idTipoVehiculo = @cod"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)

            cmd.Parameters.AddWithValue("@cod", cod)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar el tipo de vehiculo -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Sub modificar(cod As Integer, nom As String)
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "UPDATE tipo_vehiculo SET tipoVehiculo = @nom WHERE idTipoVehiculo = @cod"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)

            cmd.Parameters.AddWithValue("@cod", cod)
            cmd.Parameters.AddWithValue("@nom", nom)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al modificar el tipo de vehiculo -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Function obtenerCodigoTipoVehiculo(nom As String) As Integer
        Dim codigo As Integer = 0
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT idTipoVehiculo FROM tipo_vehiculo WHERE tipoVehiculo = @nom"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)

            cmd.Parameters.AddWithValue("@nom", nom)

            Dim resultado As Object = cmd.ExecuteScalar()
            If resultado IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado) Then
                codigo = Convert.ToInt32(resultado)
            End If
        Catch ex As Exception
            Throw New Exception("Error al buscar el tipo de vehiculo -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return codigo
    End Function
End Class