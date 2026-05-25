<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jdGestionarCitas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGenerarCita = New System.Windows.Forms.Button()
        Me.tblDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnGenerarCita)
        Me.Panel1.Controls.Add(Me.tblDatos)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 821)
        Me.Panel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(34, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(950, 3)
        Me.Label14.TabIndex = 77
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(34, 356)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(950, 3)
        Me.Label13.TabIndex = 76
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(729, 766)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 37)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "..."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(667, 767)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 37)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "TOTAL:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarCita
        '
        Me.btnGenerarCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGenerarCita.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarCita.ForeColor = System.Drawing.Color.White
        Me.btnGenerarCita.Location = New System.Drawing.Point(410, 766)
        Me.btnGenerarCita.Name = "btnGenerarCita"
        Me.btnGenerarCita.Size = New System.Drawing.Size(174, 37)
        Me.btnGenerarCita.TabIndex = 73
        Me.btnGenerarCita.Text = "Generar Cita"
        Me.btnGenerarCita.UseVisualStyleBackColor = False
        '
        'tblDatos
        '
        Me.tblDatos.ColumnCount = 2
        Me.tblDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblDatos.Location = New System.Drawing.Point(37, 440)
        Me.tblDatos.Name = "tblDatos"
        Me.tblDatos.RowCount = 2
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatos.Size = New System.Drawing.Size(950, 305)
        Me.tblDatos.TabIndex = 72
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(530, 374)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(174, 37)
        Me.btnEliminar.TabIndex = 71
        Me.btnEliminar.Text = "Eliminar Servicio"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(285, 374)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(174, 37)
        Me.btnAgregar.TabIndex = 70
        Me.btnAgregar.Text = "Agregar Servicio"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(632, 240)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(319, 83)
        Me.TextBox2.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(471, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "COMENTARIO:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(471, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "FECHA DE RECOJO:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(815, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(743, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "HORA:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(543, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(471, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "FECHA:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(70, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TIPO DE COMPROBANTE:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(70, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "VEHICULO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(255, 240)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(147, 24)
        Me.ComboBox3.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(162, 173)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(240, 24)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(70, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CLIENTE:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestión de Citas"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(632, 176)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(319, 22)
        Me.DateTimePicker1.TabIndex = 78
        '
        'jdGestionarCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 867)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "jdGestionarCitas"
        Me.Text = "jdGestionarCitas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGenerarCita As Button
    Friend WithEvents tblDatos As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
