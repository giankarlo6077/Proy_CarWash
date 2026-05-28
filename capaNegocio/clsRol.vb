Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsRol

    Public Property idrol As Integer
    Public Property nombrerol As String
    Public Property estado As String
    Public Property descripcion As String

    Public Function listarRoles() As DataTable
        Dim strSQL As String = "SELECT idrol, rol, estado, descripcion FROM rol ORDER BY 1"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar roles: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function generarIdRol() As Integer
        Dim strSQL As String = "SELECT COALESCE(MAX(idrol), 0) + 1 AS codigo FROM rol"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al generar ID de rol: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function buscarRol(id As Integer) As DataTable
        Dim strSQL As String = "SELECT idrol, rol, estado, descripcion FROM rol WHERE idrol = " & id
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al buscar rol: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Sub registrarRol(id As Integer, nombre As String, est As Boolean, desc As String)
        Dim strSQL As String = "INSERT INTO rol VALUES(" & id & ", '" & nombre & "', '" & desc & "', '" & est & "')"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar rol: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub modificarRol(id As Integer, nombre As String, desc As String, est As Boolean)
        Dim strSQL As String = "UPDATE ROL SET " &
                           "rol = @nombre, " &
                           "descripcion = @desc, " &
                           "estado = @estado " &
                           "WHERE idRol = @id"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre
            cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc
            cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = est
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al modificar rol: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub eliminarRol(id As Integer)
        Dim strSQL As String = "DELETE FROM rol WHERE idrol = " & id
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar rol: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

End Class