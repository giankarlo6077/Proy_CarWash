Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsProveedor

    ' ══════════════════════════════════════════════
    '  SECCIÓN EXISTENTE — sin cambios
    ' ══════════════════════════════════════════════

    Public Function listarProveedor() As DataTable
        Dim strSQL As String =
            "SELECT " &
            "idProveedor, " &
            "proveedor, " &
            "ruc, " &
            "telefono, " &
            "correo, " &
            "direccion, " &
            "contacto, " &
            "CASE " &
            "WHEN estado = 1 THEN 'Activo' " &
            "ELSE 'Inactivo' " &
            "END AS estado " &
            "FROM PROVEEDOR " &
            "ORDER BY proveedor ASC"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar proveedores: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Function buscarXid(ByVal id As Integer) As DataRow
        Dim strSQL As String =
            "SELECT * FROM PROVEEDOR " &
            "WHERE idProveedor = " & id
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Catch ex As Exception
            Throw New Exception("Error al buscar proveedor: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
        Return Nothing
    End Function

    Public Function buscarProveedor(ByVal nombre As String) As DataTable
        Dim strSQL As String =
            "SELECT " &
            "idProveedor, " &
            "proveedor, " &
            "ruc, " &
            "telefono, " &
            "correo, " &
            "direccion, " &
            "contacto, " &
            "CASE " &
            "WHEN estado = 1 THEN 'Activo' " &
            "ELSE 'Inactivo' " &
            "END AS estado " &
            "FROM PROVEEDOR " &
            "WHERE proveedor LIKE '%" & nombre & "%' " &
            "ORDER BY proveedor ASC"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al buscar proveedor: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    Public Sub registrarProveedor(
        ByVal proveedor As String,
        ByVal ruc As String,
        ByVal telefono As String,
        ByVal correo As String,
        ByVal direccion As String,
        ByVal contacto As String,
        ByVal estado As Boolean)
        Dim estadoSQL As Integer = If(estado, 1, 0)
        Dim strSQL As String =
            "INSERT INTO PROVEEDOR(" &
            "proveedor, ruc, telefono, correo, direccion, contacto, estado) " &
            "VALUES(" &
            "'" & proveedor & "', " &
            "'" & ruc & "', " &
            "'" & telefono & "', " &
            "'" & correo & "', " &
            "'" & direccion & "', " &
            "'" & contacto & "', " &
            estadoSQL & ")"
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar proveedor: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub modificarProveedor(
        ByVal id As Integer,
        ByVal proveedor As String,
        ByVal ruc As String,
        ByVal telefono As String,
        ByVal correo As String,
        ByVal direccion As String,
        ByVal contacto As String,
        ByVal estado As Boolean)
        Dim estadoSQL As Integer = If(estado, 1, 0)
        Dim strSQL As String =
            "UPDATE PROVEEDOR SET " &
            "proveedor = '" & proveedor & "', " &
            "ruc = '" & ruc & "', " &
            "telefono = '" & telefono & "', " &
            "correo = '" & correo & "', " &
            "direccion = '" & direccion & "', " &
            "contacto = '" & contacto & "', " &
            "estado = " & estadoSQL & " " &
            "WHERE idProveedor = " & id
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al modificar proveedor: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    Public Sub eliminarProveedor(ByVal id As Integer)
        Dim strSQL As String =
            "DELETE FROM PROVEEDOR " &
            "WHERE idProveedor = " & id
        Dim objConectar As New clsConectaBD()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar proveedor: " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  SECCIÓN NUEVA — PROVEEDOR_PRODUCTO
    ' ══════════════════════════════════════════════

    ' Productos YA vinculados al proveedor → DataGridView
    Public Function listarProductosDelProveedor(
        ByVal idProveedor As Integer
    ) As DataTable

        Dim strSQL As String =
            "SELECT " &
            "pp.idProveedorProducto, " &
            "p.idproducto, " &
            "p.producto, " &
            "pm.marcaproducto, " &
            "tp.tipoproducto, " &
            "p.precioactual AS precioVenta, " &
            "pp.precioCompra, " &
            "p.stock " &
            "FROM PROVEEDOR_PRODUCTO pp " &
            "INNER JOIN producto p " &
            "ON pp.idProducto = p.idproducto " &
            "INNER JOIN marca_producto pm " &
            "ON p.idmarcaproducto = pm.idmarcaproducto " &
            "INNER JOIN tipo_producto tp " &
            "ON p.idtipoproducto = tp.idtipoproducto " &
            "WHERE pp.idProveedor = " & idProveedor & " " &
            "ORDER BY p.producto ASC"

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
                "Error al listar productos del proveedor: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Function

    ' Productos disponibles para vincular
    ' (excluye los que el proveedor ya tiene)
    Public Function listarProductosParaVincular(
        ByVal idProveedor As Integer
    ) As DataTable

        Dim strSQL As String =
            "SELECT " &
            "p.idproducto, " &
            "p.producto, " &
            "pm.marcaproducto, " &
            "p.precioactual " &
            "FROM producto p " &
            "INNER JOIN marca_producto pm " &
            "ON p.idmarcaproducto = pm.idmarcaproducto " &
            "WHERE p.vigencia = 1 " &
            "AND p.idproducto NOT IN ( " &
            "SELECT idProducto FROM PROVEEDOR_PRODUCTO " &
            "WHERE idProveedor = " & idProveedor & ") " &
            "ORDER BY p.producto ASC"

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
                "Error al listar productos para vincular: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Function

    ' Buscar dentro de los vínculos del proveedor activo
    Public Function buscarProductoDelProveedor(
        ByVal idProveedor As Integer,
        ByVal criterio As String
    ) As DataTable

        Dim strSQL As String =
            "SELECT " &
            "pp.idProveedorProducto, " &
            "p.idproducto, " &
            "p.producto, " &
            "pm.marcaproducto, " &
            "tp.tipoproducto, " &
            "p.precioactual AS precioVenta, " &
            "pp.precioCompra, " &
            "p.stock " &
            "FROM PROVEEDOR_PRODUCTO pp " &
            "INNER JOIN producto p " &
            "ON pp.idProducto = p.idproducto " &
            "INNER JOIN marca_producto pm " &
            "ON p.idmarcaproducto = pm.idmarcaproducto " &
            "INNER JOIN tipo_producto tp " &
            "ON p.idtipoproducto = tp.idtipoproducto " &
            "WHERE pp.idProveedor = " & idProveedor & " " &
            "AND (p.producto LIKE '%" & criterio & "%' " &
            "OR pm.marcaproducto LIKE '%" & criterio & "%' " &
            "OR tp.tipoproducto LIKE '%" & criterio & "%') " &
            "ORDER BY p.producto ASC"

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
                "Error al buscar producto del proveedor: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Function

    ' Contar productos vinculados → tarjeta de resumen
    Public Function contarProductosDelProveedor(
        ByVal idProveedor As Integer
    ) As Integer

        Dim strSQL As String =
            "SELECT COUNT(*) " &
            "FROM PROVEEDOR_PRODUCTO " &
            "WHERE idProveedor = " & idProveedor

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim cmd As New SqlCommand(
                strSQL,
                objConectar.miConexion
            )

            Return Convert.ToInt32(cmd.ExecuteScalar())

        Catch ex As Exception

            Throw New Exception(
                "Error al contar productos: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Function

    ' Precio de compra promedio → tarjeta de resumen
    Public Function promedioPrecioCompra(
        ByVal idProveedor As Integer
    ) As Decimal

        Dim strSQL As String =
            "SELECT COALESCE(AVG(precioCompra), 0) " &
            "FROM PROVEEDOR_PRODUCTO " &
            "WHERE idProveedor = " & idProveedor

        Dim objConectar As New clsConectaBD()

        Try

            objConectar.conectar()

            Dim cmd As New SqlCommand(
                strSQL,
                objConectar.miConexion
            )

            Return Convert.ToDecimal(cmd.ExecuteScalar())

        Catch ex As Exception

            Throw New Exception(
                "Error al calcular promedio: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Function

    ' Vincular producto a proveedor → botón Vincular
    Public Sub vincularProducto(
        ByVal idProveedor As Integer,
        ByVal idProducto As Integer,
        ByVal precioCompra As Decimal
    )

        Dim strSQL As String =
            "INSERT INTO PROVEEDOR_PRODUCTO(" &
            "precioCompra, idProveedor, idProducto) " &
            "VALUES(" &
            precioCompra & ", " &
            idProveedor & ", " &
            idProducto & ")"

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
                "Error al vincular producto: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Sub

    ' Editar precio de compra → botón Actualizar precio
    Public Sub actualizarPrecioCompra(
        ByVal idProveedorProducto As Integer,
        ByVal precioCompra As Decimal
    )

        Dim strSQL As String =
            "UPDATE PROVEEDOR_PRODUCTO SET " &
            "precioCompra = " & precioCompra & " " &
            "WHERE idProveedorProducto = " & idProveedorProducto

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
                "Error al actualizar precio de compra: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Sub

    ' Desvincular producto → botón ✕ de la fila
    Public Sub desvincularProducto(
        ByVal idProveedorProducto As Integer
    )

        Dim strSQL As String =
            "DELETE FROM PROVEEDOR_PRODUCTO " &
            "WHERE idProveedorProducto = " & idProveedorProducto

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
                "Error al desvincular producto: " &
                ex.Message
            )

        Finally

            objConectar.desconectar()

        End Try

    End Sub

End Class