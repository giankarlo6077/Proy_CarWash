<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JdDetalleOrdenTrabajo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JdDetalleOrdenTrabajo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblidCita = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbTrabajador = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.dtpFechaRecojo = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidCita = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tblServicios = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregarServicio = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.tblProductos = New System.Windows.Forms.TableLayoutPanel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(202, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CITA N°:"
        '
        'lblidCita
        '
        Me.lblidCita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblidCita.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblidCita.Location = New System.Drawing.Point(371, 13)
        Me.lblidCita.Name = "lblidCita"
        Me.lblidCita.Size = New System.Drawing.Size(197, 34)
        Me.lblidCita.TabIndex = 2
        Me.lblidCita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtComentario)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cmbTrabajador)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmbEstado)
        Me.Panel1.Controls.Add(Me.dtpFechaRecojo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblHora)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtidCita)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 261)
        Me.Panel1.TabIndex = 3
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(475, 165)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(336, 75)
        Me.txtComentario.TabIndex = 93
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(356, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 21)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "COMENTARIO:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(21, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 24)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "TÉCNICO RESPONSABLE:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTrabajador
        '
        Me.cmbTrabajador.FormattingEnabled = True
        Me.cmbTrabajador.Location = New System.Drawing.Point(206, 165)
        Me.cmbTrabajador.Name = "cmbTrabajador"
        Me.cmbTrabajador.Size = New System.Drawing.Size(136, 24)
        Me.cmbTrabajador.TabIndex = 90
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(561, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 21)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "ESTADO:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(633, 118)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(178, 24)
        Me.cmbEstado.TabIndex = 88
        '
        'dtpFechaRecojo
        '
        Me.dtpFechaRecojo.Location = New System.Drawing.Point(166, 121)
        Me.dtpFechaRecojo.Name = "dtpFechaRecojo"
        Me.dtpFechaRecojo.Size = New System.Drawing.Size(176, 22)
        Me.dtpFechaRecojo.TabIndex = 87
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(21, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 21)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "FECHA DE RECOJO:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHora
        '
        Me.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHora.Location = New System.Drawing.Point(675, 68)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(136, 21)
        Me.lblHora.TabIndex = 84
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(603, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "HORA:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFecha
        '
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFecha.Location = New System.Drawing.Point(420, 69)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(136, 21)
        Me.lblFecha.TabIndex = 82
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(348, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "FECHA:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtidCita
        '
        Me.txtidCita.Location = New System.Drawing.Point(93, 68)
        Me.txtidCita.Name = "txtidCita"
        Me.txtidCita.Size = New System.Drawing.Size(249, 22)
        Me.txtidCita.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(21, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "N° CITA:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(20, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(799, 3)
        Me.Label14.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Datos del Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTelefono)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.lblCliente)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lblPlaca)
        Me.Panel2.Controls.Add(Me.lblAno)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.lblModelo)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Location = New System.Drawing.Point(12, 331)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(847, 168)
        Me.Panel2.TabIndex = 4
        '
        'lblTelefono
        '
        Me.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefono.Location = New System.Drawing.Point(516, 122)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(164, 21)
        Me.lblTelefono.TabIndex = 98
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(420, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 21)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "TELEFONO:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCliente
        '
        Me.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCliente.Location = New System.Drawing.Point(149, 122)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(236, 21)
        Me.lblCliente.TabIndex = 96
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(77, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 21)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "CLIENTE:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaca
        '
        Me.lblPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlaca.Location = New System.Drawing.Point(93, 68)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(164, 21)
        Me.lblPlaca.TabIndex = 94
        Me.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAno
        '
        Me.lblAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAno.Location = New System.Drawing.Point(658, 68)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(153, 21)
        Me.lblAno.TabIndex = 84
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(564, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 21)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "AÑO FAB:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModelo
        '
        Me.lblModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblModelo.Location = New System.Drawing.Point(420, 69)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(136, 21)
        Me.lblModelo.TabIndex = 82
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(277, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(137, 21)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "MARCA / MODELO:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(21, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 21)
        Me.Label22.TabIndex = 79
        Me.Label22.Text = "PLACA:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(20, 45)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(799, 3)
        Me.Label23.TabIndex = 78
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(19, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(238, 30)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Vehículo del Cliente:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(30, 507)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(238, 30)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Servicios Realizados:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tblServicios
        '
        Me.tblServicios.ColumnCount = 2
        Me.tblServicios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblServicios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblServicios.Location = New System.Drawing.Point(12, 540)
        Me.tblServicios.Name = "tblServicios"
        Me.tblServicios.RowCount = 2
        Me.tblServicios.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblServicios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblServicios.Size = New System.Drawing.Size(847, 148)
        Me.tblServicios.TabIndex = 73
        '
        'btnAgregarServicio
        '
        Me.btnAgregarServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregarServicio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarServicio.ForeColor = System.Drawing.Color.White
        Me.btnAgregarServicio.Location = New System.Drawing.Point(670, 694)
        Me.btnAgregarServicio.Name = "btnAgregarServicio"
        Me.btnAgregarServicio.Size = New System.Drawing.Size(174, 37)
        Me.btnAgregarServicio.TabIndex = 74
        Me.btnAgregarServicio.Text = "Agregar Servicio"
        Me.btnAgregarServicio.UseVisualStyleBackColor = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.btnAgregarProducto.Location = New System.Drawing.Point(670, 920)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(174, 37)
        Me.btnAgregarProducto.TabIndex = 77
        Me.btnAgregarProducto.Text = "Agregar Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'tblProductos
        '
        Me.tblProductos.ColumnCount = 2
        Me.tblProductos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProductos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProductos.Location = New System.Drawing.Point(12, 764)
        Me.tblProductos.Name = "tblProductos"
        Me.tblProductos.RowCount = 2
        Me.tblProductos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblProductos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblProductos.Size = New System.Drawing.Size(847, 150)
        Me.tblProductos.TabIndex = 76
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 731)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(349, 30)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "Productos Usados en Mantenimiento:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Location = New System.Drawing.Point(101, 982)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(696, 61)
        Me.Panel3.TabIndex = 78
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(122, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(174, 37)
        Me.btnGuardar.TabIndex = 80
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(447, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(174, 37)
        Me.btnCancelar.TabIndex = 79
        Me.btnCancelar.Text = "Cancelar Cita"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'JdDetalleOrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 1055)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.btnAgregarServicio)
        Me.Controls.Add(Me.tblProductos)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.tblServicios)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblidCita)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "JdDetalleOrdenTrabajo"
        Me.Text = ".: DETALLE ORDEN DE TRABAJO :."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblidCita As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtidCita As TextBox
    Friend WithEvents lblHora As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFechaRecojo As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbTrabajador As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblPlaca As Label
    Friend WithEvents lblAno As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents tblServicios As TableLayoutPanel
    Friend WithEvents btnAgregarServicio As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents tblProductos As TableLayoutPanel
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class
