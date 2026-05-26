Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsCita

    Public Function listarCitas() As DataTable
        Dim strSQL As String = "SELECT * FROM cita ORDER BY 1 ASC"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar Citas: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function buscarporID(id As Integer) As DataRow
        Dim strSQL As String = "SELECT * FROM cita WHERE idCita = " & id
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Catch ex As Exception
            Throw New Exception("Error al buscar Citas por ID: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
        Return Nothing
    End Function

    Public Function buscarporEstado(estado As String) As DataRow
        Dim strSQL As String = "select * from cita where estado='" & estado & "'"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Catch ex As Exception
            Throw New Exception("Error al buscar Citas por Estado: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
        Return Nothing
    End Function

    Public Function generarCodigoCita() As Integer
        Dim strSQL As String = "SELECT COALESCE(MAX(idCita), 0) + 1 AS codigo FROM cita"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al generar código de Cita: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Sub registrarCita(id As Integer, fec As Date, hor As Date, coment As String, fechRecoj As Date, idVeh As Integer, idTrab As Integer)
        Dim strSQL As String = "INSERT INTO CITA (idCita, fecha, hora, estado, comentario, fechaRecojo, idVehiculo, idTrabajador)
                            VALUES (@id, @fecha, @hora, 'Pendiente', @comentario, @fechaRecojo, @idVehiculo, @idTrabajador)"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@fecha", fec.Date)
            cmd.Parameters.AddWithValue("@hora", hor.TimeOfDay)
            cmd.Parameters.AddWithValue("@comentario", coment)
            cmd.Parameters.AddWithValue("@fechaRecojo", fechRecoj.Date)
            cmd.Parameters.AddWithValue("@idVehiculo", idVeh)
            cmd.Parameters.AddWithValue("@idTrabajador", idTrab)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar Cita: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub modificarCita(id As Integer, fec As Date, hor As Date, estado As String, coment As String, fechRecoj As Date, idVeh As Integer, idTrab As Integer)
        Dim strSQL As String = "UPDATE CITA SET 
                                fecha = '" & fec & "', 
                                hora = '" & hor & "', 
                                estado = '" & estado & "', 
                                comentario = '" & coment & "', 
                                fechaRecojo = '" & fechRecoj & "', 
                                idVehiculo = " & idVeh & ", 
                                idTrabajador = " & idTrab & "  WHERE idCita = " & id
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al modificar Cita: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub eliminarCita(id As Integer)
        Dim strSQL As String = "DELETE FROM CITA WHERE idCita = " & id
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar Cita: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub



    'listar vehículos con nombres de clientes
    Public Function listarVehiculos() As DataTable
        Dim strSQL As String = "select * from VEHICULO AS v INNER JOIN PERSONA AS p ON v.idCliente=p.idCliente order by placa asc"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar Vehiculos: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function listarHistorialCitasMantenimientoporDocumento(documento As String) As DataTable
        Dim strSQL As String = "select c.idCita,p.persona,cl.numDocumento,v.placa,c.fecha,c.hora,c.estado,c.fechaRecojo,ser.Servicio,pr.producto,tra.trabajador,dc.precioVenta from CITA AS c  
                                INNER JOIN DETALLE_CITA AS dc ON c.idCita=dc.idCita
                                INNER JOIN VEHICULO AS v ON c.idVehiculo=v.idVehiculo
                                INNER JOIN PRODUCTO_MANTENIMIENTO AS pm ON c.idCita=pm.idCita
                                INNER JOIN TRABAJADOR AS tra ON c.idTrabajador=tra.idTrabajador
                                INNER JOIN SERVICIO AS ser ON dc.idServicio=ser.idServicio
                                INNER JOIN PRODUCTO AS pr ON pm.idProducto=pr.idProducto
                                INNER JOIN PERSONA AS p ON v.idCliente=p.idCliente
                                INNER JOIN CLIENTE AS cl ON p.idCliente=cl.idCliente
                                where cl.numDocumento='" & documento & "'"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar Historial de Mantenimientos por Documento: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function


    Public Function listarTrabajadores() As DataTable
        Dim strSQL As String = "select * from TRABAJADOR order by trabajador asc"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar Vehiculos: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    'obtener idVehiculo por placa
    Public Function buscarIDVehporPlaca(placa As String) As DataRow
        Dim strSQL As String = "select idvehiculo from VEHICULO where placa='" & placa & "'"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Catch ex As Exception
            Throw New Exception("Error al buscar Citas por Estado: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
        Return Nothing
    End Function

    'obtener idTrabajador por trabajador
    Public Function buscarIDTrabporNombre(nombretrab As String) As DataRow
        Dim strSQL As String = "select idTrabajador from TRABAJADOR where trabajador='" & nombretrab & "'"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Catch ex As Exception
            Throw New Exception("Error al buscar Citas por Estado: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
        Return Nothing
    End Function

    Public Function cargarDatosCita(idCita As Integer) As DataRow
        Dim strSQL As String = "
            select c.idCita, c.fecha, c.hora, c.estado, c.comentario, c.fechaRecojo,
                v.placa, mv.modeloVehiculo, v.anoFabricacion,
                tra.trabajador,
                p.Persona AS cliente, cl.telefono
            from CITA c 
            INNER JOIN VEHICULO AS v ON c.idVehiculo=v.idVehiculo
            INNER JOIN MODELO_VEHICULO AS mv ON v.idModeloVehiculo=mv.idModeloVehiculo
            INNER JOIN TRABAJADOR AS tra ON c.idTrabajador=tra.idTrabajador
            INNER JOIN CLIENTE AS cl ON v.idCliente=cl.idCliente
            INNER JOIN PERSONA AS p ON cl.idCliente=p.idCliente
            where c.idCita = @idCita"

        Dim objConectar As New clsConectaBD()
        Dim dt As New DataTable()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@idCita", idCita)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al cargar la cita: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If
    End Function

End Class
