Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsVehiculo
    Private objConectar As New clsConectaBD()

    Public Function listarModeloVehiculoPorid(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT * FROM modelo_vehiculo WHERE idmodelovehiculo = @id"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar modelos de vehiculos -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function buscarVehiculoPorPersona(cod As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT M.modelovehiculo, V.placa " &
                                   "FROM VEHICULO V " &
                                   "INNER JOIN modelo_vehiculo M ON V.IDMODELOVEHICULO = M.IDMODELOVEHICULO " &
                                   "INNER JOIN CLIENTE C ON V.IDCLIENTE = C.IDCLIENTE " &
                                   "WHERE C.IDCLIENTE = @cod"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@cod", cod)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar vehiculos del cliente: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function buscarVehiculoPorPlaca(placa As String) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT * FROM VEHICULO WHERE placa = @placa"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@placa", placa)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar vehiculos por placa: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function buscarVehiculoxId(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT * FROM vehiculo WHERE idvehiculo = @id"
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

    Public Sub eliminarVehiculo(id As Integer)
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "DELETE FROM vehiculo WHERE idvehiculo = @id"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Function listarVehiculo() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            ' Ajustamos los alias para que coincidan con lo que espera el formulario principal
            Dim strSQL As String = "SELECT v.idvehiculo AS ID, v.placa AS Placa, c.numdocumento AS DNI, v.anofabricacion AS [Año de fabricacion], mv.modelovehiculo AS Modelo " &
                                   "FROM vehiculo v " &
                                   "INNER JOIN modelo_vehiculo mv ON mv.idmodelovehiculo = v.idmodelovehiculo " &
                                   "INNER JOIN cliente c ON c.idcliente = v.idcliente " &
                                   "ORDER BY v.idvehiculo"
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

    Public Function obtenercod() As Integer
        Dim codigo As Integer = -1
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT COALESCE(MAX(idvehiculo), 0) + 1 FROM vehiculo"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)

            Dim resultado = cmd.ExecuteScalar()
            If resultado IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado) Then
                codigo = Convert.ToInt32(resultado)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return codigo
    End Function

    Public Sub registrar(idvehiculo As Integer, placa As String, anofabricacion As Integer, idmodelovehiculo As Integer, idcliente As Integer)
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "INSERT INTO vehiculo (idvehiculo, placa, anofabricacion, idmodelovehiculo, idcliente) VALUES (@id, @placa, @anio, @idmodelo, @idcliente)"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", idvehiculo)
            cmd.Parameters.AddWithValue("@placa", placa)
            cmd.Parameters.AddWithValue("@anio", anofabricacion)
            cmd.Parameters.AddWithValue("@idmodelo", idmodelovehiculo)
            cmd.Parameters.AddWithValue("@idcliente", idcliente)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Sub Modificar(id As Integer, placa As String, doc As Integer, fabricacion As Integer, modelo As Integer)
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "UPDATE vehiculo SET placa = @placa, anofabricacion = @fabricacion, idmodelovehiculo = @modelo, idcliente = @doc WHERE idvehiculo = @id"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@placa", placa)
            cmd.Parameters.AddWithValue("@fabricacion", fabricacion)
            cmd.Parameters.AddWithValue("@modelo", modelo)
            cmd.Parameters.AddWithValue("@doc", doc)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Function buscarPLacaTotal(placa As String) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT v.idvehiculo AS ID, v.placa AS Placa, c.numdocumento AS DNI, v.anofabricacion AS [Año de fabricacion], mv.modelovehiculo AS Modelo " &
                                   "FROM vehiculo v " &
                                   "INNER JOIN modelo_vehiculo mv ON mv.idmodelovehiculo = v.idmodelovehiculo " &
                                   "INNER JOIN cliente c ON c.idcliente = v.idcliente " &
                                   "WHERE v.placa = @placa"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@placa", placa)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function
End Class