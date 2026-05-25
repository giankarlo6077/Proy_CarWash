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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Orden de Trabajo N°:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(371, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 34)
        Me.Label2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 261)
        Me.Panel1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(475, 165)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(336, 75)
        Me.TextBox2.TabIndex = 93
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(206, 165)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 24)
        Me.ComboBox1.TabIndex = 90
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
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(633, 118)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(178, 24)
        Me.ComboBox3.TabIndex = 88
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 121)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(176, 22)
        Me.DateTimePicker1.TabIndex = 87
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
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(675, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 21)
        Me.Label7.TabIndex = 84
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(420, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 21)
        Me.Label6.TabIndex = 82
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(249, 22)
        Me.TextBox1.TabIndex = 80
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
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Location = New System.Drawing.Point(12, 331)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(847, 168)
        Me.Panel2.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(516, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 21)
        Me.Label16.TabIndex = 98
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(149, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(236, 21)
        Me.Label13.TabIndex = 96
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Location = New System.Drawing.Point(93, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(164, 21)
        Me.Label25.TabIndex = 94
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(658, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(153, 21)
        Me.Label18.TabIndex = 84
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(420, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 21)
        Me.Label20.TabIndex = 82
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "JdDetalleOrdenTrabajo"
        Me.Text = "JdDetalleOrdenTrabajo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
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
