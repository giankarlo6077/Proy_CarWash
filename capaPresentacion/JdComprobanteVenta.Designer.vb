<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComprobanteVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComprobanteVenta))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNumComprobante = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtVuelto = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtSon = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtDniRuc = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSeñor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTrabajador = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtCodVenCit = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnExporJPG = New System.Windows.Forms.Button()
        Me.btnExportarPdf = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cbxTipoServicio = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxMedioPago = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtVuelto)
        Me.Panel1.Controls.Add(Me.txtMonto)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.txtIgv)
        Me.Panel1.Controls.Add(Me.txtSubTotal)
        Me.Panel1.Controls.Add(Me.txtSon)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.txtDniRuc)
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtSeñor)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtTrabajador)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 642)
        Me.Panel1.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(604, 604)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 22)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Vuelto:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(540, 576)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 22)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Monto Pagado:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtNumComprobante)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtRuc)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Location = New System.Drawing.Point(597, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 143)
        Me.Panel2.TabIndex = 30
        '
        'txtNumComprobante
        '
        Me.txtNumComprobante.Location = New System.Drawing.Point(59, 108)
        Me.txtNumComprobante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumComprobante.Name = "txtNumComprobante"
        Me.txtNumComprobante.Size = New System.Drawing.Size(127, 22)
        Me.txtNumComprobante.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "N°"
        '
        'txtRuc
        '
        Me.txtRuc.AutoSize = True
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(18, 17)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(161, 20)
        Me.txtRuc.TabIndex = 1
        Me.txtRuc.Text = "R.U.C. 10268574236"
        '
        'TextBox5
        '
        Me.TextBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox5.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox5.Location = New System.Drawing.Point(0, 39)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(204, 50)
        Me.TextBox5.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(615, 548)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 22)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Total:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(627, 521)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 22)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "IGV:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(584, 494)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 22)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "SubTotal:"
        '
        'txtVuelto
        '
        Me.txtVuelto.Location = New System.Drawing.Point(677, 604)
        Me.txtVuelto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.Size = New System.Drawing.Size(119, 22)
        Me.txtVuelto.TabIndex = 37
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(677, 577)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(119, 22)
        Me.txtMonto.TabIndex = 36
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(677, 549)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(119, 22)
        Me.txtTotal.TabIndex = 35
        '
        'txtIgv
        '
        Me.txtIgv.Location = New System.Drawing.Point(677, 521)
        Me.txtIgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(119, 22)
        Me.txtIgv.TabIndex = 34
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(677, 494)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(119, 22)
        Me.txtSubTotal.TabIndex = 33
        '
        'txtSon
        '
        Me.txtSon.Location = New System.Drawing.Point(53, 510)
        Me.txtSon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSon.Name = "txtSon"
        Me.txtSon.Size = New System.Drawing.Size(360, 22)
        Me.txtSon.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 508)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 22)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Son:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 222)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(797, 265)
        Me.DataGridView1.TabIndex = 30
        '
        'txtDniRuc
        '
        Me.txtDniRuc.Location = New System.Drawing.Point(532, 194)
        Me.txtDniRuc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDniRuc.Name = "txtDniRuc"
        Me.txtDniRuc.Size = New System.Drawing.Size(237, 22)
        Me.txtDniRuc.TabIndex = 29
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(532, 169)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(239, 22)
        Me.txtFecha.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(441, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "DNI / RUC:"
        '
        'txtSeñor
        '
        Me.txtSeñor.Location = New System.Drawing.Point(88, 194)
        Me.txtSeñor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSeñor.Name = "txtSeñor"
        Me.txtSeñor.Size = New System.Drawing.Size(325, 22)
        Me.txtSeñor.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(416, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Fecha Emisión:"
        '
        'txtTrabajador
        '
        Me.txtTrabajador.Location = New System.Drawing.Point(85, 168)
        Me.txtTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrabajador.Name = "txtTrabajador"
        Me.txtTrabajador.Size = New System.Drawing.Size(325, 22)
        Me.txtTrabajador.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Señor (es):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Trabajador:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(301, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Telf. 265-6091 / 998657423 / 968754123"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Jr. Callao 134 - Miraflores - Chiclayo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Av. Miguel Grau 892 - La Victoria - Chiclayo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 32)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = """WASHYCAR"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "MANTENIMIENTO DE VEHICULOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(819, 14)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(11, 644)
        Me.Panel3.TabIndex = 31
        '
        'TxtCodVenCit
        '
        Me.TxtCodVenCit.Location = New System.Drawing.Point(148, 66)
        Me.TxtCodVenCit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCodVenCit.Name = "TxtCodVenCit"
        Me.TxtCodVenCit.ReadOnly = True
        Me.TxtCodVenCit.Size = New System.Drawing.Size(121, 22)
        Me.TxtCodVenCit.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnExporJPG)
        Me.Panel4.Controls.Add(Me.btnExportarPdf)
        Me.Panel4.Controls.Add(Me.btnGuardar)
        Me.Panel4.Controls.Add(Me.cbxTipoServicio)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.cbxMedioPago)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.cbxEstado)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.TxtCodVenCit)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Location = New System.Drawing.Point(831, 14)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(280, 644)
        Me.Panel4.TabIndex = 32
        '
        'btnExporJPG
        '
        Me.btnExporJPG.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExporJPG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExporJPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExporJPG.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExporJPG.ForeColor = System.Drawing.Color.White
        Me.btnExporJPG.Location = New System.Drawing.Point(5, 596)
        Me.btnExporJPG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExporJPG.Name = "btnExporJPG"
        Me.btnExporJPG.Size = New System.Drawing.Size(267, 42)
        Me.btnExporJPG.TabIndex = 72
        Me.btnExporJPG.Text = "Exportar a JPG/PNG"
        Me.btnExporJPG.UseVisualStyleBackColor = False
        '
        'btnExportarPdf
        '
        Me.btnExportarPdf.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExportarPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarPdf.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportarPdf.ForeColor = System.Drawing.Color.White
        Me.btnExportarPdf.Location = New System.Drawing.Point(5, 544)
        Me.btnExportarPdf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExportarPdf.Name = "btnExportarPdf"
        Me.btnExportarPdf.Size = New System.Drawing.Size(267, 42)
        Me.btnExportarPdf.TabIndex = 71
        Me.btnExportarPdf.Text = "Exportar a PDF"
        Me.btnExportarPdf.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(5, 492)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(267, 42)
        Me.btnGuardar.TabIndex = 70
        Me.btnGuardar.Text = "Guardar Comprobante"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'cbxTipoServicio
        '
        Me.cbxTipoServicio.FormattingEnabled = True
        Me.cbxTipoServicio.Location = New System.Drawing.Point(12, 263)
        Me.cbxTipoServicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxTipoServicio.Name = "cbxTipoServicio"
        Me.cbxTipoServicio.Size = New System.Drawing.Size(257, 24)
        Me.cbxTipoServicio.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(10, 235)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 17)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Tipo de Servicio:"
        '
        'cbxMedioPago
        '
        Me.cbxMedioPago.FormattingEnabled = True
        Me.cbxMedioPago.Location = New System.Drawing.Point(11, 180)
        Me.cbxMedioPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxMedioPago.Name = "cbxMedioPago"
        Me.cbxMedioPago.Size = New System.Drawing.Size(257, 24)
        Me.cbxMedioPago.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 148)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(108, 17)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Medio de Pago:"
        '
        'cbxEstado
        '
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Location = New System.Drawing.Point(80, 102)
        Me.cbxEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(188, 24)
        Me.cbxEstado.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 17)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Estado:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 17)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Código Venta/Cita:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(79, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(126, 40)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Detalle"
        '
        'ComprobanteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 667)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ComprobanteVenta"
        Me.Text = "Comprobante Venta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSeñor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTrabajador As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDniRuc As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtVuelto As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIgv As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtSon As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNumComprobante As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRuc As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbxEstado As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cbxTipoServicio As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbxMedioPago As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnExportarPdf As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnExporJPG As Button
    Friend WithEvents TxtCodVenCit As TextBox
End Class
