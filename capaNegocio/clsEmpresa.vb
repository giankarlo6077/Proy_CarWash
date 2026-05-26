Imports System.Data.SqlClient
Imports capaDatos

Public Class clsEmpresa

    '========================================
    ' LISTAR EMPRESAS
    '========================================
    Public Function listarEmpresa() As DataTable

        Dim strSQL As String =
            "SELECT " &
            "idEmpresa, " &
            "razonSocial, " &
            "ruc " &
            "FROM EMPRESA " &
            "ORDER BY razonSocial ASC"

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
                "Error al listar empresas: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Function

    '========================================
    ' BUSCAR POR ID
    '========================================
    Public Function buscarXid(
        ByVal id As Integer
    ) As DataRow

        Dim strSQL As String =
            "SELECT * FROM EMPRESA " &
            "WHERE idEmpresa = " & id

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
                "Error al buscar empresa: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

        Return Nothing

    End Function

    '========================================
    ' BUSCAR EMPRESA
    '========================================
    Public Function buscarEmpresa(
        ByVal nombre As String
    ) As DataTable

        Dim strSQL As String =
            "SELECT " &
            "idEmpresa, " &
            "razonSocial, " &
            "ruc " &
            "FROM EMPRESA " &
            "WHERE razonSocial LIKE '%" &
            nombre & "%' " &
            "ORDER BY razonSocial ASC"

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
                "Error al buscar empresa: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Function

    '========================================
    ' REGISTRAR EMPRESA
    '========================================
    Public Sub registrarEmpresa(
        ByVal razonSocial As String,
        ByVal ruc As String
    )

        Dim strSQL As String =
            "INSERT INTO EMPRESA(" &
            "razonSocial, " &
            "ruc) " &
            "VALUES(" &
            "'" & razonSocial & "', " &
            "'" & ruc & "')"

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
                "Error al registrar empresa: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Sub

    '========================================
    ' MODIFICAR EMPRESA
    '========================================
    Public Sub modificarEmpresa(
        ByVal idEmpresa As Integer,
        ByVal razonSocial As String,
        ByVal ruc As String
    )

        Dim strSQL As String =
            "UPDATE EMPRESA SET " &
            "razonSocial = '" & razonSocial & "', " &
            "ruc = '" & ruc & "' " &
            "WHERE idEmpresa = " & idEmpresa

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
                "Error al modificar empresa: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Sub

    '========================================
    ' ELIMINAR EMPRESA
    '========================================
    Public Sub eliminarEmpresa(
        ByVal idEmpresa As Integer
    )

        Dim strSQL As String =
            "DELETE FROM EMPRESA " &
            "WHERE idEmpresa = " & idEmpresa

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
                "Error al eliminar empresa: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Sub

    Public Function buscarEmpresaRUC(ruc As String) As DataTable
        Dim strSQL As String = "SELECT * FROM empresa WHERE idempresa = '" & ruc & "'"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al buscar Empresa: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function
End Class