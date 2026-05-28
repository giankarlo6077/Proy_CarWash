Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsReporteProducto
    Private objConectar As New clsConectaBD()

    Public Function ListarMasVendidos(desde As Date, hasta As Date, Optional topN As Integer = 0) As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()

            Dim top As String = ""
            If topN > 0 Then top = "TOP (@topN) "

            Dim strSQL As String =
                "SELECT " & top &
                "   p.idProducto       AS [Id], " &
                "   p.producto         AS [Producto], " &
                "   tp.tipoProducto    AS [Tipo], " &
                "   mp.marcaProducto   AS [Marca], " &
                "   SUM(dv.cantidad)                                        AS [Cantidad Vendida], " &
                "   SUM(CAST(dv.cantidad AS decimal(18,2)) * dv.precioVenta) AS [Importe Total] " &
                "FROM DETALLE_VENTA dv " &
                "INNER JOIN PRODUCTO p           ON p.idProducto       = dv.idProducto " &
                "INNER JOIN TIPO_PRODUCTO tp     ON tp.idTipoProducto  = p.idTipoProducto " &
                "INNER JOIN MARCA_PRODUCTO mp    ON mp.idMarcaProducto = p.idMarcaProducto " &
                "INNER JOIN COMPROBANTE_VENTA cv ON cv.idComprobante   = dv.idComprobante " &
                "WHERE cv.fechaEmision BETWEEN @desde AND @hasta " &
                "GROUP BY p.idProducto, p.producto, tp.tipoProducto, mp.marcaProducto " &
                "ORDER BY SUM(dv.cantidad) DESC"

            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@desde", desde)
            cmd.Parameters.AddWithValue("@hasta", hasta)
            If topN > 0 Then cmd.Parameters.AddWithValue("@topN", topN)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar productos más vendidos: " & ex.Message)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function
End Class
