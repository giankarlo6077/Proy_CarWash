Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsServicio
    Private objConectar As New clsConectaBD()

    Public Function listarServicio() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT S.*, " &
                                   "COALESCE(T.precioactual, 0.00) AS precioactual, " &
                                   "COALESCE(T.tiempoestimado, 0) AS duracion, " &
                                   "COALESCE(Tipo.TipoVehiculo, 'No asignado') AS tipovehiculo, " &
                                   "Tipo.idtipovehiculo " &
                                   "FROM Servicio S " &
                                   "LEFT JOIN Tarifario T ON S.idServicio = T.idServicio " &
                                   "LEFT JOIN Tipo_Vehiculo Tipo ON T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                                   "ORDER BY S.idservicio"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al consultar servicios: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function generarCodigoServicio() As Integer
        Dim codigo As Integer = 0
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT COALESCE(MAX(idServicio), 0) + 1 AS codigo FROM servicio"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            codigo = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al generar código del servicio: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return codigo
    End Function

    Public Sub registrar(idservicio As Integer, nombre As String, precio As Decimal, tiempoEstimado As Integer, idTipoVehiculo As Integer)
        Try
            objConectar.abrirconexion()

            ' Solución final: Agregamos "duracion" y "estado", y pasamos el parámetro @tiempo
            Dim strSQL As String = "SET IDENTITY_INSERT Servicio ON; " &
                                   "INSERT INTO Servicio (idServicio, servicio, duracion, estado) VALUES (@id, @nombre, @tiempo, 1); " &
                                   "SET IDENTITY_INSERT Servicio OFF; " &
                                   "INSERT INTO Tarifario (idTipoVehiculo, idServicio, precioactual, tiempoestimado) VALUES (@idTipo, @id, @precio, @tiempo);"

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", idservicio)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@idTipo", idTipoVehiculo)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@tiempo", tiempoEstimado) ' Se inserta en Servicio y Tarifario

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar el servicio -> " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Sub modificar(idservicio As Integer, nombre As String, precio As Decimal, tiempoEstimado As Integer, idTipoVehiculo As Integer)
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "UPDATE Servicio SET servicio = @nombre WHERE idServicio = @id; " &
                                   "UPDATE Tarifario SET precioactual = @precio, tiempoestimado = @tiempo WHERE idServicio = @id AND idTipoVehiculo = @idTipo;"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@tiempo", tiempoEstimado)
            cmd.Parameters.AddWithValue("@id", idservicio)
            cmd.Parameters.AddWithValue("@idTipo", idTipoVehiculo)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al modificar un servicio: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Function buscarServicioPorCodigo(cod As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT S.*, T.PrecioActual, Tipo.TipoVehiculo, T.tiempoestimado AS duracion " &
                                   "FROM Servicio S " &
                                   "LEFT JOIN Tarifario T ON S.idServicio = T.idServicio " &
                                   "LEFT JOIN Tipo_Vehiculo Tipo ON T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                                   "WHERE S.idServicio = @cod"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@cod", cod)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar servicio por codigo: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function buscarServicioPorTipo(tipo As String) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT S.*, T.PrecioActual, Tipo.TipoVehiculo, T.tiempoestimado AS duracion " &
                                   "FROM Servicio S " &
                                   "INNER JOIN Tarifario T ON S.idServicio = T.idServicio " &
                                   "INNER JOIN Tipo_Vehiculo Tipo ON T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                                   "WHERE Tipo.TipoVehiculo = @tipo"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@tipo", tipo)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar servicio por tipo de vehiculo: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function buscarServicioPorTipoYCodigo(tipo As String, cod As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT S.*, T.PrecioActual, Tipo.TipoVehiculo, T.tiempoestimado AS duracion " &
                                   "FROM Servicio S " &
                                   "INNER JOIN Tarifario T ON S.idServicio = T.idServicio " &
                                   "INNER JOIN Tipo_Vehiculo Tipo ON T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                                   "WHERE Tipo.TipoVehiculo = @tipo AND S.idServicio = @cod"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@tipo", tipo)
            cmd.Parameters.AddWithValue("@cod", cod)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar servicio por codigo y tipo: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Sub eliminarServicio(cod As Integer)
        Try
            objConectar.abrirconexion()
            ' En SQL Server, false se representa como 0
            Dim strSQL As String = "UPDATE Servicio SET estado = 0 WHERE idServicio = @cod;"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@cod", cod)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar servicio: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Function ordenarPor(columna As String) As DataTable
        Dim dt As New DataTable()
        Dim columnaDB As String = ""

        Select Case columna
            Case "Código"
                columnaDB = "S.idServicio"
            Case "Nombre"
                columnaDB = "S.servicio"
            Case "Precio"
                columnaDB = "T.precioactual"
            Case "Tiempo Estimado"
                columnaDB = "T.tiempoestimado"
            Case "Tipo de Vehículo"
                columnaDB = "Tipo.TipoVehiculo"
            Case Else
                columnaDB = "S.idServicio"
        End Select

        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT S.*, " &
                                   "COALESCE(T.precioactual, 0.00) AS precioactual, " &
                                   "COALESCE(T.tiempoestimado, 0) AS duracion, " &
                                   "COALESCE(Tipo.TipoVehiculo, 'No asignado') AS tipovehiculo " &
                                   "FROM Servicio S " &
                                   "LEFT JOIN Tarifario T ON S.idServicio = T.idServicio " &
                                   "LEFT JOIN Tipo_Vehiculo Tipo ON T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                                   "ORDER BY " & columnaDB

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al ordernar la tabla: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function listarServiciosPorCita(idCita As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT S.*, tv.tipovehiculo, DC.precioventa, T.tiempoestimado " &
                                   "FROM cita C " &
                                   "INNER JOIN Detalle_cita DC ON DC.idcita = C.idcita " &
                                   "INNER JOIN Servicio S ON S.idservicio = DC.idservicio " &
                                   "INNER JOIN Tarifario T ON S.idServicio = T.idServicio " &
                                   "INNER JOIN tipo_vehiculo TV ON T.idtipovehiculo = TV.idtipovehiculo " &
                                   "WHERE DC.idcita = @idCita AND DC.idtipovehiculo = T.idtipovehiculo"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@idCita", idCita)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar servicio por cita: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Function listarServiciosSimples() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            ' Traemos solo los servicios vigentes ordenados alfabéticamente
            Dim strSQL As String = "SELECT idServicio, servicio, duracion FROM Servicio WHERE estado = 1 ORDER BY servicio"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar servicios básicos: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function
End Class