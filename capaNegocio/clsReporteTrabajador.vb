Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsReporteTrabajador

    '========================================
    ' LISTAR TODOS LOS TRABAJADORES
    '========================================
    Public Function listarReporteTrabajador() As DataTable

        Dim dt As New DataTable()

        Dim strSQL As String =
            "SELECT " &
            "t.idTrabajador AS ID, " &
            "t.trabajador AS Trabajador, " &
            "t.dni AS DNI, " &
            "tt.tipoTrabajador AS TipoTrabajador, " &
            "CASE " &
            "WHEN t.estado = 1 THEN 'ACTIVO' " &
            "ELSE 'INACTIVO' " &
            "END AS Estado " &
            "FROM trabajador t " &
            "INNER JOIN tipo_trabajador tt " &
            "ON t.idTipoTrabajador = tt.idTipoTrabajador " &
            "ORDER BY tt.tipoTrabajador, t.trabajador"

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim da As New SqlDataAdapter(
                strSQL,
                objConectar.miConexion
            )

            da.Fill(dt)

        Catch ex As Exception

            Throw New Exception(
                "Error al listar reporte: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

        Return dt

    End Function

    '========================================
    ' FILTRAR POR TIPO TRABAJADOR
    '========================================
    Public Function filtrarTrabajadorPorTipo(
        ByVal idTipoTrabajador As Integer
    ) As DataTable

        Dim dt As New DataTable()

        Dim strSQL As String =
            "SELECT " &
            "t.idTrabajador AS ID, " &
            "t.trabajador AS Trabajador, " &
            "t.dni AS DNI, " &
            "tt.tipoTrabajador AS TipoTrabajador, " &
            "CASE " &
            "WHEN t.estado = 1 THEN 'ACTIVO' " &
            "ELSE 'INACTIVO' " &
            "END AS Estado " &
            "FROM trabajador t " &
            "INNER JOIN tipo_trabajador tt " &
            "ON t.idTipoTrabajador = tt.idTipoTrabajador " &
            "WHERE t.idTipoTrabajador = @idTipo " &
            "ORDER BY t.trabajador ASC"

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim cmd As New SqlCommand(
                strSQL,
                objConectar.miConexion
            )

            cmd.Parameters.AddWithValue(
                "@idTipo",
                idTipoTrabajador
            )

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        Catch ex As Exception

            Throw New Exception(
                "Error al filtrar trabajadores: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

        Return dt

    End Function

    '========================================
    ' CANTIDAD POR TIPO TRABAJADOR
    '========================================
    Public Function cantidadTrabajadoresPorTipo() As DataTable

        Dim dt As New DataTable()

        Dim strSQL As String =
            "SELECT " &
            "tt.tipoTrabajador AS TipoTrabajador, " &
            "COUNT(*) AS Cantidad " &
            "FROM trabajador t " &
            "INNER JOIN tipo_trabajador tt " &
            "ON t.idTipoTrabajador = tt.idTipoTrabajador " &
            "GROUP BY tt.tipoTrabajador " &
            "ORDER BY Cantidad DESC"

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim da As New SqlDataAdapter(
                strSQL,
                objConectar.miConexion
            )

            da.Fill(dt)

        Catch ex As Exception

            Throw New Exception(
                "Error al obtener cantidad: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

        Return dt

    End Function

End Class