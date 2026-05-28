Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports capaNegocio

Public Class ComprobanteVenta

    Private objComprobante As New clsComprobante()

    ' Datos que un formulario de Ventas/Citas puede enviar antes de mostrar el comprobante
    Private datosPendientes As Boolean = False
    Private clientePend As String = ""
    Private dniRucPend As String = ""
    Private trabajadorPend As String = ""
    Private detallesPend As List(Of Object()) = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    ' ─────────────────────────────────────────────
    '  API pública: permite cargar los datos de una venta
    '  detalles = lista de Object() con {producto, cantidad, precio}
    ' ─────────────────────────────────────────────
    Public Sub CargarVenta(ByVal cliente As String, ByVal dniRuc As String,
                           ByVal trabajador As String, ByVal detalles As List(Of Object()))
        clientePend = cliente
        dniRucPend = dniRuc
        trabajadorPend = trabajador
        detallesPend = detalles
        datosPendientes = True
    End Sub

    ' ─────────────────────────────────────────────
    '  CARGA DEL FORMULARIO
    ' ─────────────────────────────────────────────
    Private Sub ComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "COMPROBANTE DE PAGO"
        configurarTabla()
        cargarCombos()
        txtFecha.Text = Date.Now.ToString("yyyy-MM-dd")
        txtFecha.ReadOnly = True
        txtNumComprobante.ReadOnly = True
        txtSubTotal.ReadOnly = True
        txtIgv.ReadOnly = True
        txtTotal.ReadOnly = True
        txtSon.ReadOnly = True
        txtVuelto.ReadOnly = True
        generarNumComprobante()

        If datosPendientes Then
            ' La venta ya fue registrada por el formulario de origen:
            ' este comprobante es solo para visualizar/exportar.
            btnGuardar.Enabled = False
            txtSeñor.Text = clientePend
            txtDniRuc.Text = dniRucPend
            txtTrabajador.Text = trabajadorPend
            If detallesPend IsNot Nothing Then
                For Each d As Object() In detallesPend
                    Dim cant As Decimal = Convert.ToDecimal(d(1))
                    Dim precio As Decimal = Convert.ToDecimal(d(2))
                    DataGridView1.Rows.Add(d(0), cant, precio, (cant * precio).ToString("0.00"))
                Next
            End If
        End If

        calcularTotales()
    End Sub

    ' ─────────────────────────────────────────────
    '  CONFIGURAR GRILLA DE DETALLE
    ' ─────────────────────────────────────────────
    Private Sub configurarTabla()
        DataGridView1.Columns.Clear()
        DataGridView1.AllowUserToAddRows = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DataGridView1.Columns.Add("Producto", "Producto")
        DataGridView1.Columns.Add("Cantidad", "Cantidad")
        DataGridView1.Columns.Add("Precio", "Precio Unit.")

        Dim colSub As New DataGridViewTextBoxColumn()
        colSub.Name = "Subtotal"
        colSub.HeaderText = "Subtotal"
        colSub.ReadOnly = True
        DataGridView1.Columns.Add(colSub)

        DataGridView1.Columns("Producto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    ' ─────────────────────────────────────────────
    '  CARGAR COMBOS
    ' ─────────────────────────────────────────────
    Private Sub cargarCombos()
        ' Estado
        cbxEstado.Items.Clear()
        cbxEstado.Items.Add("Pagado")
        cbxEstado.Items.Add("Pendiente")
        cbxEstado.SelectedIndex = 0

        ' Tipo de comprobante (determina el prefijo de la numeración)
        cbxTipoServicio.Items.Clear()
        cbxTipoServicio.Items.Add("Boleta")
        cbxTipoServicio.Items.Add("Factura")
        cbxTipoServicio.SelectedIndex = 0

        ' Medio de pago (desde la BD)
        Try
            Dim dt As DataTable = objComprobante.listarMedioPago()
            cbxMedioPago.DataSource = dt
            cbxMedioPago.DisplayMember = "mediopago"
            cbxMedioPago.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar medios de pago: " & ex.Message)
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    '  GENERAR NÚMERO DE COMPROBANTE
    ' ─────────────────────────────────────────────
    Private Sub generarNumComprobante()
        Try
            Dim tipo As String = cbxTipoServicio.Text
            Dim num As String = objComprobante.mostrarNuevoNumeroComprobante(tipo)
            If String.IsNullOrWhiteSpace(num) Then
                Dim prefijo As String = If(tipo = "Factura", "F001", "B001")
                num = prefijo & "-00000001"
            End If
            txtNumComprobante.Text = num
        Catch ex As Exception
            txtNumComprobante.Text = If(cbxTipoServicio.Text = "Factura", "F001-00000001", "B001-00000001")
        End Try
    End Sub

    Private Sub cbxTipoServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoServicio.SelectedIndexChanged
        generarNumComprobante()
    End Sub

    ' ─────────────────────────────────────────────
    '  RECÁLCULO DE LA GRILLA Y TOTALES
    ' ─────────────────────────────────────────────
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        recalcularFila(e.RowIndex)
        calcularTotales()
    End Sub

    Private Sub recalcularFila(ByVal rowIndex As Integer)
        If rowIndex < 0 Then Return
        Dim fila As DataGridViewRow = DataGridView1.Rows(rowIndex)
        If fila.IsNewRow Then Return
        Dim cant As Decimal = 0
        Dim precio As Decimal = 0
        Decimal.TryParse(Convert.ToString(fila.Cells("Cantidad").Value), cant)
        Decimal.TryParse(Convert.ToString(fila.Cells("Precio").Value), precio)
        fila.Cells("Subtotal").Value = (cant * precio).ToString("0.00")
    End Sub

    Private Sub calcularTotales()
        Dim total As Decimal = 0
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.IsNewRow Then Continue For
            Dim subFila As Decimal = 0
            Decimal.TryParse(Convert.ToString(fila.Cells("Subtotal").Value), subFila)
            total += subFila
        Next

        Dim baseImponible As Decimal = Math.Round(total / 1.18D, 2)
        Dim igv As Decimal = total - baseImponible

        txtSubTotal.Text = baseImponible.ToString("0.00")
        txtIgv.Text = igv.ToString("0.00")
        txtTotal.Text = total.ToString("0.00")
        Try
            txtSon.Text = objComprobante.numeroALetras(Convert.ToDouble(total))
        Catch
            txtSon.Text = ""
        End Try
        calcularVuelto()
    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        calcularVuelto()
    End Sub

    Private Sub calcularVuelto()
        Dim monto As Decimal = 0
        Dim total As Decimal = 0
        Decimal.TryParse(txtMonto.Text, monto)
        Decimal.TryParse(txtTotal.Text, total)
        Dim vuelto As Decimal = monto - total
        txtVuelto.Text = If(vuelto >= 0, vuelto.ToString("0.00"), "0.00")
    End Sub

    ' ─────────────────────────────────────────────
    '  VALIDACIÓN
    ' ─────────────────────────────────────────────
    Private Function validar() As Boolean
        If String.IsNullOrWhiteSpace(txtSeñor.Text) Then
            MessageBox.Show("Ingrese el nombre del cliente (Señor(es))")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtTrabajador.Text) Then
            MessageBox.Show("Ingrese el trabajador")
            Return False
        End If
        If cbxMedioPago.SelectedIndex < 0 OrElse String.IsNullOrWhiteSpace(cbxMedioPago.Text) Then
            MessageBox.Show("Seleccione el medio de pago")
            Return False
        End If

        Dim hayDetalle As Boolean = False
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If Not fila.IsNewRow AndAlso Not String.IsNullOrWhiteSpace(Convert.ToString(fila.Cells("Producto").Value)) Then
                hayDetalle = True
                Exit For
            End If
        Next
        If Not hayDetalle Then
            MessageBox.Show("Agregue al menos un producto al detalle")
            Return False
        End If

        Dim total As Decimal = 0
        Dim monto As Decimal = 0
        Decimal.TryParse(txtTotal.Text, total)
        Decimal.TryParse(txtMonto.Text, monto)
        If cbxEstado.Text = "Pagado" AndAlso monto < total Then
            MessageBox.Show("El monto pagado no puede ser menor al total")
            Return False
        End If

        Return True
    End Function

    ' ─────────────────────────────────────────────
    '  GUARDAR COMPROBANTE
    ' ─────────────────────────────────────────────
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not validar() Then Return

        Try
            Dim detalles As New List(Of Object())()
            For Each fila As DataGridViewRow In DataGridView1.Rows
                If fila.IsNewRow Then Continue For
                If String.IsNullOrWhiteSpace(Convert.ToString(fila.Cells("Producto").Value)) Then Continue For
                Dim producto As String = Convert.ToString(fila.Cells("Producto").Value)
                Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
                Dim precio As Single = Convert.ToSingle(fila.Cells("Precio").Value)
                detalles.Add(New Object() {producto, cantidad, precio})
            Next

            Dim fecha As String = Date.Now.ToString("yyyy-MM-dd")
            Dim hora As String = Date.Now.ToString("HH:mm:ss")

            objComprobante.transaccion(fecha, hora, txtNumComprobante.Text, cbxEstado.Text,
                                       cbxTipoServicio.Text, 0, cbxMedioPago.Text,
                                       txtTrabajador.Text, txtSeñor.Text, detalles)

            MessageBox.Show("Comprobante registrado correctamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            generarNumComprobante()
        Catch ex As Exception
            MessageBox.Show("Error al guardar el comprobante: " & ex.Message)
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    '  EXPORTAR A JPG / PNG
    ' ─────────────────────────────────────────────
    Private Sub btnExporJPG_Click(sender As Object, e As EventArgs) Handles btnExporJPG.Click
        Try
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Imagen PNG|*.png|Imagen JPEG|*.jpg"
                sfd.FileName = "Comprobante_" & txtNumComprobante.Text.Replace("-", "_")
                If sfd.ShowDialog() <> DialogResult.OK Then Return

                Using bmp As New Bitmap(Panel1.Width, Panel1.Height)
                    Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))
                    Dim fmt As ImageFormat = If(sfd.FilterIndex = 2, ImageFormat.Jpeg, ImageFormat.Png)
                    bmp.Save(sfd.FileName, fmt)
                End Using

                MessageBox.Show("Comprobante exportado correctamente")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al exportar la imagen: " & ex.Message)
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    '  EXPORTAR A PDF  (vía "Microsoft Print to PDF")
    ' ─────────────────────────────────────────────
    Private Sub btnExportarPdf_Click(sender As Object, e As EventArgs) Handles btnExportarPdf.Click
        Try
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Documento PDF|*.pdf"
                sfd.FileName = "Comprobante_" & txtNumComprobante.Text.Replace("-", "_") & ".pdf"
                If sfd.ShowDialog() <> DialogResult.OK Then Return

                Dim bmp As New Bitmap(Panel1.Width, Panel1.Height)
                Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))

                Using pd As New PrintDocument()
                    pd.PrinterSettings.PrinterName = "Microsoft Print to PDF"
                    If Not pd.PrinterSettings.IsValid Then
                        bmp.Dispose()
                        MessageBox.Show("No se encontró la impresora 'Microsoft Print to PDF'." & vbCrLf &
                                        "Use el botón 'Exportar a JPG/PNG'.")
                        Return
                    End If
                    pd.PrinterSettings.PrintToFile = True
                    pd.PrinterSettings.PrintFileName = sfd.FileName

                    AddHandler pd.PrintPage,
                        Sub(s As Object, ev As PrintPageEventArgs)
                            Dim m As Rectangle = ev.MarginBounds
                            Dim ratio As Double = Math.Min(m.Width / CDbl(bmp.Width), m.Height / CDbl(bmp.Height))
                            Dim w As Integer = CInt(bmp.Width * ratio)
                            Dim h As Integer = CInt(bmp.Height * ratio)
                            ev.Graphics.DrawImage(bmp, m.Left, m.Top, w, h)
                        End Sub

                    pd.Print()
                End Using

                bmp.Dispose()
                MessageBox.Show("Comprobante exportado a PDF correctamente")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al exportar a PDF: " & ex.Message)
        End Try
    End Sub

End Class
