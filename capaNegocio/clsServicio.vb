Imports System.Data

Public Class clsServicio
    Private objConectar As New capaDatos.clsConectaBD()
    Private strSQL As String

    Public Function listarServicio() As DataTable
        strSQL = "select S.*," &
                "COALESCE(T.precioactual, 00.00) as precioactual, " &
                "COALESCE(T.tiempoestimado, 00.00) as duracion, " &
                "COALESCE(Tipo.TipoVehiculo, 'No asignado') as tipovehiculo, " &
                "Tipo.idtipovehiculo " &
                "From Servicio S " &
                "Left Join Tarifario T on S.idServicio = T.idServicio " &
                "Left Join Tipo_Vehiculo Tipo on T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                "Order by idservicio"
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al consultar servicios: " & ex.Message)
        End Try
    End Function

    Public Function generarCodigoServicio() As Integer
        strSQL = "Select COALESCE (max(idServicio),0) +1 as codigo from servicio"
        Try
            Dim dt As DataTable = objConectar.consultarBD(strSQL)
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("codigo"))
            End If
        Catch ex As Exception
            Throw New Exception("Error al generar código del servicio" & ex.Message)
        End Try
        Return 0
    End Function

    Public Sub registrar(ByVal idservicio As Integer, ByVal nombre As String, ByVal precio As Single, ByVal tiempoEstimado As Integer, ByVal idTipoVehiculo As Integer)
        strSQL = "insert into Servicio values (" & idservicio & ", '" & nombre & "' ); " &
                 "insert into Tarifario values (" & idTipoVehiculo & "," & idservicio & "," & precio & "," & tiempoEstimado & ");"
        Try
            objConectar.ejecutarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar el servicio -> " & ex.Message)
        End Try
    End Sub

    Public Sub modificar(ByVal idservicio As Integer, ByVal nombre As String, ByVal precio As Single, ByVal tiempoEstimado As Integer, ByVal idTipoVehiculo As Integer)
        strSQL = "update Servicio set servicio = '" & nombre & "' where idServicio=" & idservicio & "; " &
                 "update Tarifario set precioactual = " &
                 precio & ", tiempoestimado = " & tiempoEstimado &
                 " where idServicio=" & idservicio & " and idTipoVehiculo = " & idTipoVehiculo & ";"
        Try
            objConectar.ejecutarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar un servicio" & ex.Message)
        End Try
    End Sub

    Public Function buscarServicioPorCodigo(ByVal cod As Integer) As DataTable
        strSQL = "select S.*,T.PrecioActual,Tipo.TipoVehiculo,T.tiempoestimado as duracion From Servicio S " &
                 "LEFT Join Tarifario T on S.idServicio = T.idServicio " &
                 "LEFT Join Tipo_Vehiculo Tipo on T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                 "Where S.idServicio =" & cod
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar servicio por codigo" & ex.Message)
        End Try
    End Function

    Public Function buscarServicioPorTipo(ByVal tipo As String) As DataTable
        strSQL = "select S.*,T.PrecioActual,Tipo.TipoVehiculo,T.tiempoestimado as duracion From Servicio S " &
                 "Inner Join Tarifario T on S.idServicio = T.idServicio " &
                 "Inner Join Tipo_Vehiculo Tipo on T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                 "Where Tipo.TipoVehiculo ='" & tipo & "'"
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar servicio por tipo de vehiculo" & ex.Message)
        End Try
    End Function

    Public Function buscarServicioPorTipoYCodigo(ByVal tipo As String, ByVal cod As Integer) As DataTable
        strSQL = "select S.*,T.PrecioActual,Tipo.TipoVehiculo,T.tiempoestimado as duracion From Servicio S " &
                 "Inner Join Tarifario T on S.idServicio = T.idServicio " &
                 "Inner Join Tipo_Vehiculo Tipo on T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                 "Where Tipo.TipoVehiculo ='" & tipo & "' and S.idServicio = " & cod
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar servicio por codigo y tipo" & ex.Message)
        End Try
    End Function

    Public Sub eliminarServicio(ByVal cod As Integer)
        strSQL = "update Servicio set estado = 0 where idServicio=" & cod & ";"
        Try
            objConectar.ejecutarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar servicio" & ex.Message)
        End Try
    End Sub

    Public Function ordenarPor(ByVal columna As String) As DataTable
        Select Case columna
            Case "Código"
                columna = "S.idServicio"
            Case "Nombre"
                columna = "S.servicio"
            Case "Precio"
                columna = "T.precioactual"
            Case "Tiempo Estimado"
                columna = "T.tiempoestimado"
            Case "Tipo de Vehículo"
                columna = "Tipo.TipoVehiculo"
        End Select
        strSQL = "select S.*," &
                "COALESCE(T.precioactual, 00.00) as precioactual, " &
                "COALESCE(T.tiempoestimado, 00.00) as duracion, " &
                "COALESCE(Tipo.TipoVehiculo, 'No asignado') as tipovehiculo " &
                "From Servicio S " &
                "Left Join Tarifario T on S.idServicio = T.idServicio " &
                "Left Join Tipo_Vehiculo Tipo on T.idTipoVehiculo = Tipo.idTipoVehiculo " &
                "Order by " & columna
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al ordernar la tabla" & ex.Message)
        End Try
    End Function

    Public Function listarServiciosPorCita(ByVal idCita As Integer) As DataTable
        strSQL = "select S.*,tv.tipovehiculo, DC.precioventa,T.tiempoestimado From cita C " &
                 "Inner Join Detalle_cita DC on DC.idcita = C.idcita " &
                 "Inner Join Servicio S on S.idservicio = DC.idservicio " &
                 "Inner Join Tarifario T on S.idServicio = T.idServicio " &
                 "Inner Join tipo_vehiculo TV on T.idtipovehiculo = TV.idtipovehiculo " &
                 "Where DC.idcita =" & idCita & " and DC.idtipovehiculo = T.idtipovehiculo"
        Try
            Return objConectar.consultarBD(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar servicio por codigo y tipo" & ex.Message)
        End Try
    End Function

End Class
