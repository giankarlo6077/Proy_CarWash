Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsTipoTrabajador

    Public Function listarTipoTrabajador() As DataTable

        Dim strSQL As String =
            "SELECT * FROM TIPO_TRABAJADOR ORDER BY 1 ASC"

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim da As New SqlDataAdapter(
                strSQL,
                objConectar.miConexion
            )

            Dim dt As New DataTable()

            da.Fill(dt)

            Return dt

        Catch ex As Exception

            Throw New Exception(
                "Error al listar tipos de trabajador: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Function

    Public Function buscarXid(
        ByVal id As Integer
    ) As DataRow

        Dim strSQL As String =
            "SELECT * FROM TIPO_TRABAJADOR " &
            "WHERE idTipoTrabajador = " & id

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim da As New SqlDataAdapter(
                strSQL,
                objConectar.miConexion
            )

            Dim dt As New DataTable()

            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                Return dt.Rows(0)

            End If

        Catch ex As Exception

            Throw New Exception(
                "Error al buscar tipo trabajador: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

        Return Nothing

    End Function

    Public Function generarCodigoTipoTrabajador() As Integer

        Dim strSQL As String =
            "SELECT COALESCE(MAX(idTipoTrabajador),0)+1 AS codigo " &
            "FROM TIPO_TRABAJADOR"

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim cmd As New SqlCommand(
                strSQL,
                objConectar.miConexion
            )

            Return Convert.ToInt32(
                cmd.ExecuteScalar()
            )

        Catch ex As Exception

            Throw New Exception(
                "Error al generar código: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Function

    Public Sub registrarTipoTrabajador(
        ByVal nombre As String
    )

        Dim strSQL As String =
            "INSERT INTO TIPO_TRABAJADOR(tipoTrabajador) " &
            "VALUES('" & nombre & "')"

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim cmd As New SqlCommand(
                strSQL,
                objConectar.miConexion
            )

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(
                "Error al registrar: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Sub

    Public Sub modificarTipoTrabajador(
        ByVal id As Integer,
        ByVal nombre As String
    )

        Dim strSQL As String =
            "UPDATE TIPO_TRABAJADOR " &
            "SET tipoTrabajador = '" & nombre & "' " &
            "WHERE idTipoTrabajador = " & id

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim cmd As New SqlCommand(
                strSQL,
                objConectar.miConexion
            )

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(
                "Error al modificar: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Sub

    Public Sub eliminarTipoTrabajador(
        ByVal id As Integer
    )

        Dim strSQL As String =
            "DELETE FROM TIPO_TRABAJADOR " &
            "WHERE idTipoTrabajador = " & id

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim cmd As New SqlCommand(
                strSQL,
                objConectar.miConexion
            )

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(
                "Error al eliminar: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Sub

End Class