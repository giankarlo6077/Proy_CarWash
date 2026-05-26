Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsDescuento
    Private objConectar As New clsConectaBD()

    Public Function obtenerNuevoID() As Integer
        Dim id As Integer = 1
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT ISNULL(MAX(idDescuento), 0) + 1 FROM DESCUENTO"
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            id = Convert.ToInt32(cmd.ExecuteScalar())
        Finally
            objConectar.cerrarconexion()
        End Try
        Return id
    End Function

    Public Function listar() As DataTable
        Dim dt As New DataTable()
        Try
            objConectar.abrirconexion()
            Dim strSQL As String = "SELECT d.idDescuento AS ID, d.codigo AS Codigo, d.descripcion AS Descripcion, d.valor AS Valor, " &
                                   "t.tipoDescuento AS [Tipo de descuento], d.aplicaA AS [Aplica a], " &
                                   "d.fechaInicio AS [Fecha inicio], d.fechaFin AS [Fecha fin], d.estado " &
                                   "FROM DESCUENTO d INNER JOIN TIPO_DESCUENTO t ON d.idTipoDescuento = t.idTipoDescuento"
            Dim da As New SqlDataAdapter(strSQL, objConectar.miConexion)
            da.Fill(dt)
        Finally
            objConectar.cerrarconexion()
        End Try
        Return dt
    End Function

    Public Sub registrar(id As Integer, cod As String, desc As String, val As Decimal, idTipo As Integer, aplica As String, fIni As Date, fFin As Date, est As Boolean)
        Try
            objConectar.abrirconexion()
            Dim sql As String = "INSERT INTO DESCUENTO (idDescuento, codigo, descripcion, valor, idTipoDescuento, aplicaA, fechaInicio, fechaFin, estado) " &
                                "VALUES (@id, @cod, @desc, @val, @idTipo, @aplica, @fIni, @fFin, @est)"
            Dim cmd As New SqlCommand(sql, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@cod", cod)
            cmd.Parameters.AddWithValue("@desc", desc)
            cmd.Parameters.AddWithValue("@val", val)
            cmd.Parameters.AddWithValue("@idTipo", idTipo)
            cmd.Parameters.AddWithValue("@aplica", aplica)
            cmd.Parameters.AddWithValue("@fIni", fIni)
            cmd.Parameters.AddWithValue("@fFin", fFin)
            cmd.Parameters.AddWithValue("@est", est)
            cmd.ExecuteNonQuery()
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Sub modificar(id As Integer, cod As String, desc As String, val As Decimal, idTipo As Integer, aplica As String, fIni As Date, fFin As Date, est As Boolean)
        Try
            objConectar.abrirconexion()
            Dim sql As String = "UPDATE DESCUENTO SET codigo=@cod, descripcion=@desc, valor=@val, idTipoDescuento=@idTipo, aplicaA=@aplica, " &
                                "fechaInicio=@fIni, fechaFin=@fFin, estado=@est WHERE idDescuento=@id"
            Dim cmd As New SqlCommand(sql, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@cod", cod)
            cmd.Parameters.AddWithValue("@desc", desc)
            cmd.Parameters.AddWithValue("@val", val)
            cmd.Parameters.AddWithValue("@idTipo", idTipo)
            cmd.Parameters.AddWithValue("@aplica", aplica)
            cmd.Parameters.AddWithValue("@fIni", fIni)
            cmd.Parameters.AddWithValue("@fFin", fFin)
            cmd.Parameters.AddWithValue("@est", est)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub

    Public Sub darDeBaja(id As Integer)
        Try
            objConectar.abrirconexion()
            Dim cmd As New SqlCommand("UPDATE DESCUENTO SET estado = 0 WHERE idDescuento = @id", objConectar.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Finally
            objConectar.cerrarconexion()
        End Try
    End Sub
End Class