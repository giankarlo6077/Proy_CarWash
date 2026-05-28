Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsReporteComprobantePorCliente
    Private objConectar As New clsConectaBD()

    Public Function ListarComprobantesPorCliente(desde As Date, hasta As Date,
                                                 Optional clienteBuscado As String = "") As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()

            Dim strSQL As String =
                "SELECT " &
                "   COALESCE(per.persona, emp.razonsocial)               AS [Cliente], " &
                "   cv.numcomprobante                                     AS [N° Comprobante], " &
                "   cv.tipocomprobante                                    AS [Tipo], " &
                "   cv.fechaemision                                       AS [Fecha Emisión], " &
                "   mp.mediopago                                          AS [Medio Pago], " &
                "   CASE WHEN cv.estado = 1 THEN 'Pagado' ELSE 'Pendiente' END AS [Estado], " &
                "   COALESCE(SUM(CAST(dv.cantidad AS decimal(18,2)) * dv.precioventa), 0) AS [Total S/.] " &
                "FROM COMPROBANTE_VENTA cv " &
                "INNER JOIN CLIENTE cl      ON cl.idcliente    = cv.idcliente " &
                "LEFT  JOIN PERSONA per     ON per.idcliente   = cl.idcliente " &
                "LEFT  JOIN EMPRESA emp     ON emp.idempresa   = cl.idrepresentante " &
                "INNER JOIN MEDIO_PAGO mp   ON mp.idmediopago  = cv.idmediopago " &
                "LEFT  JOIN DETALLE_VENTA dv ON dv.idcomprobante = cv.idcomprobante " &
                "WHERE cv.fechaemision BETWEEN @desde AND @hasta " &
                "  AND (@cliente = '' OR COALESCE(per.persona, emp.razonsocial) LIKE '%' + @cliente + '%') " &
                "GROUP BY COALESCE(per.persona, emp.razonsocial), cv.numcomprobante, " &
                "         cv.tipocomprobante, cv.fechaemision, mp.mediopago, cv.estado " &
                "ORDER BY cv.fechaemision DESC, COALESCE(per.persona, emp.razonsocial)"

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@desde", desde)
            cmd.Parameters.AddWithValue("@hasta", hasta)
            cmd.Parameters.AddWithValue("@cliente", clienteBuscado)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar comprobantes por cliente: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function
End Class
