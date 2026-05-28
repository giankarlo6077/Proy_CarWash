Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports capaDatos

Public Class clsComprobante

    Dim objConectar As New clsConectaBD()
    Dim dr As SqlDataReader = Nothing
    Dim strSQL As String

    ' ─────────────────────────────────────────────
    '  LISTAR MEDIO DE PAGO
    ' ─────────────────────────────────────────────
    Public Function listarMedioPago() As DataTable
        strSQL = "SELECT mediopago FROM medio_pago"
        Dim dt As New DataTable()
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar medios de pago -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  NÚMERO A LETRAS
    ' ─────────────────────────────────────────────
    Public Function numeroALetras(valor As Double) As String
        If valor = 0 Then Return "Cero soles con 00/100"

        Dim entero As Long = CLng(Math.Truncate(valor))
        Dim centavos As Integer = CInt(Math.Round((valor - entero) * 100))
        If centavos = 100 Then
            entero += 1
            centavos = 0
        End If

        Dim unidades() As String = {"", "un", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim decenas() As String = {"", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
        Dim especiales() As String = {"once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve"}

        Dim convertir As Func(Of Long, String) = Nothing
        convertir = Function(n As Long) As String
                        If n = 0 Then Return ""
                        If n < 10 Then Return unidades(CInt(n))
                        If n < 20 Then
                            If n = 10 Then Return "diez"
                            Return especiales(CInt(n) - 11)
                        End If
                        If n < 100 Then
                            Dim d As Integer = CInt(n \ 10)
                            Dim u As Integer = CInt(n Mod 10)
                            If u = 0 Then Return decenas(d)
                            If d = 2 Then Return "veinti" & unidades(u)
                            Return decenas(d) & " y " & unidades(u)
                        End If
                        If n < 1000 Then
                            Dim c As Integer = CInt(n \ 100)
                            Dim r As Integer = CInt(n Mod 100)
                            Dim cien As String
                            Select Case c
                                Case 1 : cien = If(r = 0, "cien", "ciento")
                                Case 2 : cien = "doscientos"
                                Case 3 : cien = "trescientos"
                                Case 4 : cien = "cuatrocientos"
                                Case 5 : cien = "quinientos"
                                Case 6 : cien = "seiscientos"
                                Case 7 : cien = "setecientos"
                                Case 8 : cien = "ochocientos"
                                Case 9 : cien = "novecientos"
                                Case Else : cien = ""
                            End Select
                            Return If(r = 0, cien, cien & " " & convertir(r))
                        End If
                        If n < 2000 Then
                            Dim resto2000 As Long = n - 1000
                            Dim parteResto As String = convertir(resto2000)
                            Return If(parteResto = "", "mil", "mil " & parteResto)
                        End If
                        If n < 1000000 Then
                            Dim miles As Long = n \ 1000
                            Dim resto As Long = n Mod 1000
                            Dim milParte As String = convertir(miles)
                            Return If(resto = 0, milParte & " mil", milParte & " mil " & convertir(resto))
                        End If
                        Return "monto muy alto"
                    End Function

        Dim parteEntera As String = convertir(entero).Trim()
        If parteEntera.Length > 0 Then
            parteEntera = parteEntera.Substring(0, 1).ToUpper() & parteEntera.Substring(1)
        Else
            parteEntera = "Cero"
        End If

        Return parteEntera & " soles con " & centavos.ToString("D2") & "/100"
    End Function

    ' ─────────────────────────────────────────────
    '  MOSTRAR NUEVO NÚMERO DE COMPROBANTE
    ' ─────────────────────────────────────────────
    Public Function mostrarNuevoNumeroComprobante(tipoComprobante As String) As String
        Dim prefijo As String = If(tipoComprobante.ToLower() = "factura", "F001", "B001")
        ' Extrae la parte numérica del número de comprobante y hace MAX entero real
        ' para evitar que la comparación lexicográfica de VARCHAR devuelva un resultado incorrecto.
        strSQL = "SELECT ISNULL(MAX(CAST(SUBSTRING(numcomprobante, " &
                 "CHARINDEX('-', numcomprobante) + 1, LEN(numcomprobante)) AS INT)), 0) + 1 " &
                 "AS siguiente " &
                 "FROM comprobante_venta " &
                 "WHERE tipocomprobante = @tipoComprobante " &
                 "AND numcomprobante LIKE @prefijo + '-%'"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@tipoComprobante", tipoComprobante)
            cmd.Parameters.AddWithValue("@prefijo", prefijo)
            dr = cmd.ExecuteReader()

            If dr.Read() AndAlso Not IsDBNull(dr("siguiente")) Then
                Dim siguiente As Integer = Convert.ToInt32(dr("siguiente"))
                Return prefijo & "-" & siguiente.ToString().PadLeft(8, "0"c)
            End If

            Return prefijo & "-00000001"
        Catch ex As Exception
            Throw New Exception("Error al obtener numero de comprobante -> " & ex.Message)
        Finally
            If dr IsNot Nothing Then dr.Close()
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  OBTENER ID MEDIO DE PAGO
    ' ─────────────────────────────────────────────
    Public Function obteneridMedioPago(medioPago As String) As Integer
        strSQL = "SELECT idmediopago FROM medio_pago WHERE medioPago = @medioPago"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@medioPago", medioPago)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Return Convert.ToInt32(dr("idmediopago"))
            End While
            Return 0
        Catch ex As Exception
            Throw New Exception("Error al obtener id del medio de pago -> " & ex.Message)
        Finally
            If dr IsNot Nothing Then dr.Close()
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  OBTENER ID TRABAJADOR
    ' ─────────────────────────────────────────────
    Public Function obteneridTrabajador(trabajador As String) As Integer
        strSQL = "SELECT idtrabajador FROM trabajador WHERE trabajador = @trabajador"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@trabajador", trabajador)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Return Convert.ToInt32(dr("idtrabajador"))
            End While
            Return 0
        Catch ex As Exception
            Throw New Exception("Error al obtener id del trabajador -> " & ex.Message)
        Finally
            If dr IsNot Nothing Then dr.Close()
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  OBTENER ID CLIENTE
    ' ─────────────────────────────────────────────
    Public Function obteneridCliente(cliente As String) As Integer
        strSQL = "SELECT cli.idcliente " &
                 "FROM cliente cli " &
                 "LEFT JOIN persona per ON cli.idcliente = per.idcliente " &
                 "LEFT JOIN empresa emp ON cli.idrepresentante = emp.idempresa " &
                 "WHERE per.persona = @cliente OR emp.razonsocial = @cliente"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@cliente", cliente)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Return Convert.ToInt32(dr("idcliente"))
            End While
            Return 0
        Catch ex As Exception
            Throw New Exception("Error al obtener id del cliente -> " & ex.Message)
        Finally
            If dr IsNot Nothing Then dr.Close()
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  OBTENER ID PRODUCTO
    ' ─────────────────────────────────────────────
    Public Function obteneridProducto(producto As String) As Integer
        strSQL = "SELECT idproducto FROM producto WHERE producto = @producto"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            cmd.Parameters.AddWithValue("@producto", producto)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Return Convert.ToInt32(dr("idproducto"))
            End While
            Return 0
        Catch ex As Exception
            Throw New Exception("Error al obtener id del producto -> " & ex.Message)
        Finally
            If dr IsNot Nothing Then dr.Close()
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  OBTENER NUEVO NÚMERO DE COMPROBANTE (ID)
    ' ─────────────────────────────────────────────
    Public Function obtenerNuevoNumComprobante() As Integer
        strSQL = "SELECT COALESCE(MAX(idcomprobante), 0) + 1 AS nuevoNumComprobante FROM comprobante_venta"
        Try
            objConectar.conectar()
            Dim cmd As New SqlCommand(strSQL, objConectar.miConexion)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Return Convert.ToInt32(dr("nuevoNumComprobante"))
            End While
            Return 0
        Catch ex As Exception
            Throw New Exception("Error al obtener el nuevo número de comprobante -> " & ex.Message)
        Finally
            If dr IsNot Nothing Then dr.Close()
            objConectar.desconectar()
        End Try
    End Function

    ' ─────────────────────────────────────────────
    '  TRANSACCIÓN PRINCIPAL (INSERT comprobante + detalles)
    ' ─────────────────────────────────────────────
    Public Sub transaccion(fecha As String, hora As String, numComprobante As String,
                           estado As String, tipoComprobante As String, idCita As Integer,
                           medioPago As String, trabajador As String, cliente As String,
                           listaDetalles As List(Of Object()))

        Dim estadoBoolean As Boolean = False
        Dim idMedioPago As Integer = obteneridMedioPago(medioPago)
        Dim idTrabajador As Integer = obteneridTrabajador(trabajador)
        Dim idCliente As Integer = obteneridCliente(cliente)

        If idTrabajador = 0 Then
            Throw New Exception("No se encontró al trabajador '" & trabajador & "'.")
        End If
        If idCliente = 0 Then
            Throw New Exception("No se encontró al cliente '" & cliente & "'.")
        End If
        If idMedioPago = 0 Then
            Throw New Exception("No se encontró el medio de pago '" & medioPago & "'.")
        End If

        Dim fechaVenta As Date = Date.ParseExact(fecha, "yyyy-MM-dd", Nothing)
        Dim horaVenta As TimeSpan = TimeSpan.Parse(hora)

        If estado.ToLower() = "pagado" Then
            estadoBoolean = True
        ElseIf estado.ToLower() = "pendiente" Then
            estadoBoolean = False
        End If

        Dim sqlComprobante As String =
            "INSERT INTO comprobante_venta (fechaemision, horaemision, numcomprobante, estado, " &
            "tipocomprobante, idmediopago, idtrabajador, idcliente) " &
            "VALUES (@fecha, @hora, @numComp, @estado, @tipo, @idMedio, @idTrab, @idCliente)"

        Dim sqlDetalle As String =
            "INSERT INTO detalle_venta (precioventa, cantidad, idcomprobante, idproducto) " &
            "VALUES (@precio, @cantidad, @idComp, @idProd)"

        ' Resolver los id de producto ANTES de iniciar la transacción.
        ' obteneridProducto abre y cierra la conexión compartida; si se llamara
        ' dentro de la transacción la invalidaría ("SqlTransaction se completó").
        Dim idsProducto As New List(Of Integer)
        For Each detalle As Object() In listaDetalles
            Dim idProd As Integer = obteneridProducto(CStr(detalle(0)))
            If idProd = 0 Then
                Throw New Exception("No se encontró el producto '" & CStr(detalle(0)) & "'.")
            End If
            idsProducto.Add(idProd)
        Next

        objConectar.conectar()
        Dim con As SqlConnection = objConectar.miConexion
        Dim trans As SqlTransaction = con.BeginTransaction()

        Dim idComprobante As Integer

        Try
            ' — INSERT comprobante (devuelve el id generado con SCOPE_IDENTITY) —
            Using cmdComp As New SqlCommand(sqlComprobante & "; SELECT CAST(SCOPE_IDENTITY() AS INT);", con, trans)
                cmdComp.Parameters.AddWithValue("@fecha", fechaVenta.Date)
                cmdComp.Parameters.AddWithValue("@hora", horaVenta)
                cmdComp.Parameters.AddWithValue("@numComp", numComprobante)
                cmdComp.Parameters.AddWithValue("@estado", estadoBoolean)
                cmdComp.Parameters.AddWithValue("@tipo", tipoComprobante)
                cmdComp.Parameters.AddWithValue("@idMedio", idMedioPago)
                cmdComp.Parameters.AddWithValue("@idTrab", idTrabajador)
                cmdComp.Parameters.AddWithValue("@idCliente", idCliente)
                idComprobante = Convert.ToInt32(cmdComp.ExecuteScalar())
            End Using

            ' — INSERT detalles —
            Using cmdDet As New SqlCommand(sqlDetalle, con, trans)
                For i As Integer = 0 To listaDetalles.Count - 1
                    Dim detalle As Object() = listaDetalles(i)
                    Dim cantidad As Integer = CInt(detalle(1))
                    Dim precioVenta As Single = CSng(detalle(2))
                    Dim idProducto As Integer = idsProducto(i)

                    cmdDet.Parameters.Clear()
                    cmdDet.Parameters.AddWithValue("@precio", precioVenta)
                    cmdDet.Parameters.AddWithValue("@cantidad", cantidad)
                    cmdDet.Parameters.AddWithValue("@idComp", idComprobante)
                    cmdDet.Parameters.AddWithValue("@idProd", idProducto)
                    cmdDet.ExecuteNonQuery()
                Next
            End Using

            trans.Commit()

        Catch ex As Exception
            trans.Rollback()
            Throw New Exception("Error al registrar comprobante y detalles -> " & ex.Message)
        Finally
            objConectar.desconectar()
        End Try
    End Sub

End Class