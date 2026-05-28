<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jdGestionarCitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jdGestionarCitas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.btnBuscarVehic = New System.Windows.Forms.Button()
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.dtpFechaRecojo = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGenerarCita = New System.Windows.Forms.Button()
        Me.btnGenerarComprobante = New System.Windows.Forms.Button()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTrabajador = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtPlaca)
        Me.Panel1.Controls.Add(Me.btnBuscarVehic)
        Me.Panel1.Controls.Add(Me.dgvCitas)
        Me.Panel1.Controls.Add(Me.lblNombreCliente)
        Me.Panel1.Controls.Add(Me.dtpFechaRecojo)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnGenerarCita)
        Me.Panel1.Controls.Add(Me.btnGenerarComprobante)
        Me.Panel1.Controls.Add(Me.txtComentario)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblHora)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbTrabajador)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1230, 777)
        Me.Panel1.TabIndex = 0
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(205, 118)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(220, 22)
        Me.txtPlaca.TabIndex = 82
        '
        'btnBuscarVehic
        '
        Me.btnBuscarVehic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscarVehic.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarVehic.ForeColor = System.Drawing.Color.White
        Me.btnBuscarVehic.Location = New System.Drawing.Point(454, 108)
        Me.btnBuscarVehic.Name = "btnBuscarVehic"
        Me.btnBuscarVehic.Size = New System.Drawing.Size(69, 37)
        Me.btnBuscarVehic.TabIndex = 81
        Me.btnBuscarVehic.Text = "..."
        Me.btnBuscarVehic.UseVisualStyleBackColor = False
        '
        'dgvCitas
        '
        Me.dgvCitas.AllowUserToAddRows = False
        Me.dgvCitas.AllowUserToDeleteRows = False
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitas.Location = New System.Drawing.Point(37, 433)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.ReadOnly = True
        Me.dgvCitas.RowHeadersWidth = 51
        Me.dgvCitas.RowTemplate.Height = 24
        Me.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCitas.Size = New System.Drawing.Size(1176, 305)
        Me.dgvCitas.TabIndex = 80
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreCliente.Location = New System.Drawing.Point(210, 179)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(313, 32)
        Me.lblNombreCliente.TabIndex = 79
        Me.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaRecojo
        '
        Me.dtpFechaRecojo.Location = New System.Drawing.Point(790, 176)
        Me.dtpFechaRecojo.Name = "dtpFechaRecojo"
        Me.dtpFechaRecojo.Size = New System.Drawing.Size(281, 22)
        Me.dtpFechaRecojo.TabIndex = 78
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(34, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1179, 3)
        Me.Label14.TabIndex = 77
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(34, 356)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1179, 3)
        Me.Label13.TabIndex = 76
        '
        'btnGenerarCita
        '
        Me.btnGenerarCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGenerarCita.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarCita.ForeColor = System.Drawing.Color.White
        Me.btnGenerarCita.Location = New System.Drawing.Point(454, 375)
        Me.btnGenerarCita.Name = "btnGenerarCita"
        Me.btnGenerarCita.Size = New System.Drawing.Size(174, 37)
        Me.btnGenerarCita.TabIndex = 73
        Me.btnGenerarCita.Text = "Generar Cita"
        Me.btnGenerarCita.UseVisualStyleBackColor = False
        '
        'btnGenerarComprobante
        '
        Me.btnGenerarComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerarComprobante.Enabled = False
        Me.btnGenerarComprobante.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarComprobante.ForeColor = System.Drawing.Color.White
        Me.btnGenerarComprobante.Location = New System.Drawing.Point(654, 375)
        Me.btnGenerarComprobante.Name = "btnGenerarComprobante"
        Me.btnGenerarComprobante.Size = New System.Drawing.Size(219, 37)
        Me.btnGenerarComprobante.TabIndex = 74
        Me.btnGenerarComprobante.Text = "Generar Comprobante"
        Me.btnGenerarComprobante.UseVisualStyleBackColor = False
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(790, 240)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(383, 83)
        Me.txtComentario.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(643, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "COMENTARIO:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(615, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "FECHA DE RECOJO:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHora
        '
        Me.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHora.Location = New System.Drawing.Point(1037, 117)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(136, 21)
        Me.lblHora.TabIndex = 14
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(965, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "HORA:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFecha
        '
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFecha.Location = New System.Drawing.Point(790, 117)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(136, 21)
        Me.lblFecha.TabIndex = 12
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(704, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "FECHA:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(58, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TRABAJADOR ASIGNADO:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(98, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CLIENTE:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTrabajador
        '
        Me.cmbTrabajador.FormattingEnabled = True
        Me.cmbTrabajador.Location = New System.Drawing.Point(279, 244)
        Me.cmbTrabajador.Name = "cmbTrabajador"
        Me.cmbTrabajador.Size = New System.Drawing.Size(244, 24)
        Me.cmbTrabajador.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(98, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "VEHICULO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'jdGestionarCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 813)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "jdGestionarCitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: GESTIONAR CITAS :."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTrabajador As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnGenerarCita As Button
    Friend WithEvents btnGenerarComprobante As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpFechaRecojo As DateTimePicker
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents dgvCitas As DataGridView
    Friend WithEvents btnBuscarVehic As Button
    Friend WithEvents txtPlaca As TextBox
End Class
