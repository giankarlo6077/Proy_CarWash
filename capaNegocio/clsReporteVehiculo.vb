Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsReporteVehiculo
    Private objConectar As New clsConectaBD()

    Public Function ListarHistorial(Optional placaBuscada As String = "") As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()

            ' Consulta 100% adaptada a los nombres exactos de tus tablas e imágenes
            Dim strSQL As String =
                "SELECT " &
                "   v.placa AS Placa, " &
                "   cv.fechaEmision AS Fecha, " &
                "   s.Servicio AS Servicio, " & ' <-- Columna "Servicio" de la tabla SERVICIO
                "   dc.precioVenta AS Precio, " &
                "   (SELECT COUNT(DISTINCT cv2.idComprobante) " &
                "    FROM COMPROBANTE_VENTA cv2 " &
                "    INNER JOIN CITA c2 ON cv2.idCita = c2.idCita " &
                "    WHERE c2.idVehiculo = v.idVehiculo) AS [Total Visitas] " &
                "FROM VEHICULO v " &
                "INNER JOIN CITA c ON v.idVehiculo = c.idVehiculo " &
                "INNER JOIN COMPROBANTE_VENTA cv ON c.idCita = cv.idCita " &
                "INNER JOIN DETALLE_CITA dc ON c.idCita = dc.idCita " &
                "INNER JOIN SERVICIO s ON dc.idServicio = s.idServicio " & ' <-- Conexión directa
                "WHERE (@placa = '' OR v.placa LIKE '%' + @placa + '%') " &
                "ORDER BY cv.fechaEmision DESC"

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@placa", placaBuscada)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al consultar el historial: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function
End Class