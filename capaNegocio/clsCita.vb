Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsCita

    Public Function listarCitas() As DataTable
        Dim strSQL As String = "select c.idCita,c.fecha,c.hora,c.estado,c.comentario,c.fechaRecojo,v.placa,trab.trabajador from CITA AS c
                                INNER JOIN VEHICULO AS v ON c.idVehiculo=v.idVehiculo
                                INNER JOIN TRABAJADOR AS trab ON c.idTrabajador=trab.idTrabajador
                                ORDER BY 1 ASC"
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


    Public Function buscarporEstado(estado As String) As DataTable
        Dim strSQL As String = "select * from cita where estado='" & estado & "'"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar Citas por Estado: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
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
                                fecha = @fecha, 
                                hora = @hora, 
                                estado = @estado, 
                                comentario = @comentario, 
                                fechaRecojo = @fechaRecojo, 
                                idVehiculo = @idVehiculo, 
                                idTrabajador = @idTrabajador  WHERE idCita = @id"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@fecha", fec.Date)
            cmd.Parameters.AddWithValue("@hora", hor.TimeOfDay)
            cmd.Parameters.AddWithValue("@estado", estado)
            cmd.Parameters.AddWithValue("@comentario", coment)
            cmd.Parameters.AddWithValue("@fechaRecojo", fechRecoj.Date)
            cmd.Parameters.AddWithValue("@idVehiculo", idVeh)
            cmd.Parameters.AddWithValue("@idTrabajador", idTrab)
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
    Public Function buscarPersonaPorPlaca(placa As String) As String
        Dim strSQL As String = "select p.persona from VEHICULO AS v INNER JOIN PERSONA AS p ON v.idCliente=p.idCliente  where v.placa= @placa"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@placa", placa)
            Dim resultado = cmd.ExecuteScalar()
            If resultado IsNot Nothing Then
                Return resultado.ToString()
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw New Exception("Error al buscar persona: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function buscarClienteporPlaca(placa As String) As DataTable
        Dim strSQL As String = "select * from VEHICULO AS v INNER JOIN PERSONA AS p ON v.idCliente=p.idCliente  where v.placa='" & placa & "'"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar Cliente por Placa: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function listarHistorialCitasMantenimientoporDocumento(documento As String) As DataTable
        Dim strSQL As String = "select c.idCita,COALESCE(p.Persona, emp.razonSocial) AS persona,cl.numDocumento,v.placa,c.fecha,c.hora,c.estado,c.fechaRecojo,ser.Servicio,pr.producto,tra.trabajador,dc.precioVenta from CITA AS c  
                                LEFT JOIN DETALLE_CITA AS dc ON c.idCita=dc.idCita
                                LEFT JOIN VEHICULO AS v ON c.idVehiculo=v.idVehiculo
                                LEFT JOIN PRODUCTO_MANTENIMIENTO AS pm ON c.idCita=pm.idCita
                                LEFT JOIN TRABAJADOR AS tra ON c.idTrabajador=tra.idTrabajador
                                LEFT JOIN SERVICIO AS ser ON dc.idServicio=ser.idServicio
                                LEFT JOIN PRODUCTO AS pr ON pm.idProducto=pr.idProducto
                                LEFT JOIN CLIENTE AS cl ON V.idCliente=cl.idCliente
                                LEFT JOIN PERSONA  AS p   ON cl.idCliente = p.idCliente
                                LEFT JOIN EMPRESA  AS emp ON cl.idCliente = emp.idCliente
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
    Public Function buscarIDVehporPlaca(placa As String) As Integer
        Dim strSQL As String = "select idvehiculo from VEHICULO where placa='" & placa & "'"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al consular código de vehículo: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
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
                                v.placa,mv.modeloVehiculo, tv.idTipoVehiculo, v.anoFabricacion,
                                tra.trabajador,
                                COALESCE(p.Persona, emp.razonSocial) AS cliente, cl.telefono
                                from CITA c 
                                INNER JOIN VEHICULO AS v ON c.idVehiculo=v.idVehiculo
                                INNER JOIN MODELO_VEHICULO AS mv ON v.idModeloVehiculo=mv.idModeloVehiculo
                                LEFT JOIN TIPO_VEHICULO AS tv ON mv.idTipoVehiculo=tv.idTipoVehiculo
                                INNER JOIN TRABAJADOR AS tra ON c.idTrabajador=tra.idTrabajador
                                INNER JOIN CLIENTE AS cl ON v.idCliente=cl.idCliente
                                LEFT JOIN PERSONA  AS p   ON cl.idCliente = p.idCliente
                                LEFT  JOIN EMPRESA AS emp ON cl.idCliente = emp.idCliente
                                WHERE c.idCita = @idCita"

        Dim objConectar As New clsConectaBD()
        Dim dt As New DataTable()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@idCita", idCita)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
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

    Public Function cargarProductosdelaCita(idCita As Integer) As DataTable
        Dim strSQL As String = "
        SELECT pr.idProducto, pr.producto, pm.precio
        FROM CITA AS c  
        INNER JOIN PRODUCTO_MANTENIMIENTO AS pm ON c.idCita = pm.idCita
        INNER JOIN PRODUCTO AS pr ON pm.idProducto = pr.idProducto
        WHERE c.idCita = @idCita"

        Dim objConectar As New clsConectaBD()
        Dim dt As New DataTable()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@idCita", idCita)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al cargar los productos de la cita: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try

        Return dt
    End Function

    Public Function cargarServiciosdelaCita(idCita As Integer) As DataTable
        Dim strSQL As String = "
            select ser.idServicio,ser.Servicio from CITA AS c  
            INNER JOIN DETALLE_CITA AS dc ON c.idCita=dc.idCita
            INNER JOIN SERVICIO AS ser ON dc.idServicio=ser.idServicio
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
            Throw New Exception("Error al cargar los servicios de la cita: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try

        Return dt
    End Function

    Public Function listarProductos() As DataTable
        Dim strSQL As String = "select pr.idProducto,pr.producto,pr.stock,pr.precioActual as precio,mp.marcaProducto,tp.TipoProducto from PRODUCTO AS pr
                                INNER JOIN MARCA_PRODUCTO AS mp ON pr.idMarcaProducto=mp.idMarcaProducto
                                INNER JOIN TIPO_PRODUCTO AS tp ON pr.idTipoProducto=tp.idTipoProducto
                                where vigencia= 1 order by pr.producto asc"
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

    Public Function listarServicios() As DataTable
        Dim strSQL As String = "select idServicio,Servicio,duracion from SERVICIO where estado= 1 order by SERVICIO asc"
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







    Public Function generarCodigoDetalleCita() As Integer
        Dim strSQL As String = "SELECT COALESCE(MAX(idDetalleCita), 0) + 1 AS codigo FROM DETALLE_CITA"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al generar código de Servicio a Registrar: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function obtenerIdTipoVehiculo(idCita As Integer) As Integer
        Dim strSQL As String = "SELECT mv.idTipoVehiculo 
                            FROM CITA c
                            INNER JOIN VEHICULO v ON c.idVehiculo = v.idVehiculo
                            INNER JOIN MODELO_VEHICULO mv ON v.idModeloVehiculo = mv.idModeloVehiculo
                            WHERE c.idCita = @idCita"
        Dim objConectar As New clsConectaBD()
        Dim resultado As Integer = 0
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.Add("@idCita", SqlDbType.Int).Value = idCita
            Dim valor = cmd.ExecuteScalar()
            If valor IsNot Nothing AndAlso valor IsNot DBNull.Value Then
                resultado = Convert.ToInt32(valor)
            End If
        Catch ex As Exception
            Throw New Exception("Error al obtener tipo vehículo: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
        Return resultado
    End Function

    Public Function obtenerPrecioServicio(idServicio As Integer, idTipoVehiculo As Integer) As Double
        Dim strSQL As String = "select precioActual from TARIFARIO where idServicio = @idServicio 
                            AND idTipoVehiculo = @idTipoVehiculo"
        Dim objConectar As New clsConectaBD()
        Dim resultado As Double = 0.0
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@idServicio", idServicio)
            cmd.Parameters.AddWithValue("@idTipoVehiculo", idTipoVehiculo)
            Dim valor = cmd.ExecuteScalar()
            If valor IsNot Nothing AndAlso valor IsNot DBNull.Value Then
                resultado = Convert.ToDouble(valor)
            End If
        Catch ex As Exception
            Throw New Exception("Error al obtener precio: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
        Return resultado
    End Function


    Public Sub registrarServicioparaCita(precioVenta As Double, idCita As Integer, idTipoVehiculo As Integer, idServicio As Integer)
        Dim strSQL As String = "INSERT INTO DETALLE_CITA (precioVenta, Cantidad, idCita, idTipoVehiculo, idServicio) 
                            VALUES (@precioVenta, 1, @idCita, @idTipoVehiculo, @idServicio)"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.Add("@precioVenta", SqlDbType.Decimal).Value = precioVenta  ' ← Decimal en lugar de Double
            cmd.Parameters.Add("@idCita", SqlDbType.Int).Value = idCita
            cmd.Parameters.Add("@idTipoVehiculo", SqlDbType.Int).Value = idTipoVehiculo
            cmd.Parameters.Add("@idServicio", SqlDbType.Int).Value = idServicio
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar Servicio para la Cita: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub


    Public Function generarCodigoProductoMantenimiento() As Integer
        Dim strSQL As String = "SELECT COALESCE(MAX(idProductoMantenimiento), 0) + 1 AS codigo FROM PRODUCTO_MANTENIMIENTO"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al generar código de Producto a Registrar: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Sub registrarProductoparaCita(cantidad As Integer, precio As Double, idCita As Integer, idProducto As Integer)
        Dim strSQL As String = "INSERT INTO PRODUCTO_MANTENIMIENTO (cantidad, precio, idCita, idProducto) 
                            VALUES (@cantidad, @precio, @idCita, @idProducto)"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad
            cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = precio
            cmd.Parameters.Add("@idCita", SqlDbType.Int).Value = idCita
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = idProducto
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar Producto para la Cita: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub eliminarServiciosdeCita(idCita As Integer)
        Dim strSQL As String = "DELETE FROM DETALLE_CITA WHERE idCita = @idCita"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.Add("@idCita", SqlDbType.Int).Value = idCita
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar servicios: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub eliminarProductosdeCita(idCita As Integer)
        Dim strSQL As String = "DELETE FROM PRODUCTO_MANTENIMIENTO WHERE idCita = @idCita"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.Add("@idCita", SqlDbType.Int).Value = idCita
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar productos: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

End Class
