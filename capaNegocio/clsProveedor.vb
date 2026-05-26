Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsProveedor

    Dim objConectar As New clsConectaBD()
    Dim dr As SqlDataReader = Nothing
    Dim strSQL As String

    ' ─────────────────────────────────────────────
    '  LISTAR PROVEEDORES ACTIVOS (para el DataGridView)
    ' ─────────────────────────────────────────────
    Public Function listarProveedores() As DataTable
        strSQL = "SELECT idProveedor, proveedor, ruc, telefono, correo, " &
                 "       direccion, contacto, " &
                 "       CASE WHEN estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS estado " &
                 "FROM PROVEEDOR " &
                 "ORDER BY proveedor ASC"
        Dim dt As New DataTable()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar proveedores -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  BUSCAR PROVEEDOR (por nombre, RUC o contacto)
    ' ─────────────────────────────────────────────
    Public Function buscarProveedor(criterio As String) As DataTable
        strSQL = "SELECT idProveedor, proveedor, ruc, telefono, correo, " &
                 "       direccion, contacto, " &
                 "       CASE WHEN estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS estado " &
                 "FROM PROVEEDOR " &
                 "WHERE proveedor LIKE @criterio " &
                 "   OR ruc       LIKE @criterio " &
                 "   OR contacto  LIKE @criterio " &
                 "ORDER BY proveedor ASC"
        Dim dt As New DataTable()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@criterio", "%" & criterio & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al buscar proveedor -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  OBTENER PROVEEDOR POR ID (para cargar al editar)
    ' ─────────────────────────────────────────────
    Public Function obtenerProveedorPorId(idProveedor As Integer) As DataTable
        strSQL = "SELECT idProveedor, proveedor, ruc, telefono, correo, " &
                 "       direccion, contacto, estado " &
                 "FROM PROVEEDOR " &
                 "WHERE idProveedor = @idProveedor"
        Dim dt As New DataTable()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@idProveedor", idProveedor)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al obtener proveedor -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  INSERTAR PROVEEDOR (botón Nuevo)
    ' ─────────────────────────────────────────────
    Public Sub insertarProveedor(nombre As String, ruc As String, telefono As String,
                                  correo As String, direccion As String, contacto As String)
        ' Validar que el RUC no esté duplicado
        If existeRuc(ruc) Then
            Throw New Exception("Ya existe un proveedor con el RUC ingresado.")
        End If

        strSQL = "INSERT INTO PROVEEDOR (proveedor, ruc, telefono, correo, direccion, contacto, estado) " &
                 "VALUES (@nombre, @ruc, @telefono, @correo, @direccion, @contacto, 1)"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@ruc", ruc)
            cmd.Parameters.AddWithValue("@telefono", telefono)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            cmd.Parameters.AddWithValue("@contacto", contacto)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al insertar proveedor -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    '  ACTUALIZAR PROVEEDOR (botón Editar)
    ' ─────────────────────────────────────────────
    Public Sub actualizarProveedor(idProveedor As Integer, nombre As String, ruc As String,
                                    telefono As String, correo As String,
                                    direccion As String, contacto As String)
        ' Validar RUC duplicado (excluye el mismo proveedor)
        If existeRucExcluyendo(ruc, idProveedor) Then
            Throw New Exception("El RUC ya pertenece a otro proveedor.")
        End If

        strSQL = "UPDATE PROVEEDOR SET " &
                 "  proveedor  = @nombre, " &
                 "  ruc        = @ruc, " &
                 "  telefono   = @telefono, " &
                 "  correo     = @correo, " &
                 "  direccion  = @direccion, " &
                 "  contacto   = @contacto " &
                 "WHERE idProveedor = @idProveedor"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@ruc", ruc)
            cmd.Parameters.AddWithValue("@telefono", telefono)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            cmd.Parameters.AddWithValue("@contacto", contacto)
            cmd.Parameters.AddWithValue("@idProveedor", idProveedor)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al actualizar proveedor -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    '  DAR DE BAJA (baja lógica — estado = 0)
    ' ─────────────────────────────────────────────
    Public Sub darDeBajaProveedor(idProveedor As Integer)
        strSQL = "UPDATE PROVEEDOR SET estado = 0 WHERE idProveedor = @idProveedor"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@idProveedor", idProveedor)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al dar de baja al proveedor -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    '  VALIDAR RUC DUPLICADO (insertar)
    ' ─────────────────────────────────────────────
    Private Function existeRuc(ruc As String) As Boolean
        strSQL = "SELECT COUNT(*) FROM PROVEEDOR WHERE ruc = @ruc"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@ruc", ruc)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            Throw New Exception("Error al validar RUC -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  VALIDAR RUC DUPLICADO (editar — excluye el mismo)
    ' ─────────────────────────────────────────────
    Private Function existeRucExcluyendo(ruc As String, idProveedor As Integer) As Boolean
        strSQL = "SELECT COUNT(*) FROM PROVEEDOR " &
                 "WHERE ruc = @ruc AND idProveedor <> @idProveedor"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@ruc", ruc)
            cmd.Parameters.AddWithValue("@idProveedor", idProveedor)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            Throw New Exception("Error al validar RUC -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

End Class