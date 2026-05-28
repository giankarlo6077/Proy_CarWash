<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JdVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JdVentas))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnGenerarComprobante = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(380, 40)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Gestion de Ventas"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(20, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(780, 4)
        Me.Label9.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "NÚMERO DE VENTA:"
        '
        'txtNumeroVenta
        '
        Me.txtNumeroVenta.Location = New System.Drawing.Point(180, 78)
        Me.txtNumeroVenta.Name = "txtNumeroVenta"
        Me.txtNumeroVenta.Size = New System.Drawing.Size(200, 22)
        Me.txtNumeroVenta.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "CLIENTE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "FECHA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(610, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "HORA:"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(455, 78)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(140, 22)
        Me.txtFecha.TabIndex = 59
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(660, 78)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(140, 22)
        Me.txtHora.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "TIPO DE COMPROBANTE:"
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.Location = New System.Drawing.Point(582, 124)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(216, 24)
        Me.cboTipoComprobante.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(779, 13)
        Me.Label6.TabIndex = 64
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(241, 348)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(160, 36)
        Me.btnEliminar.TabIndex = 68
        Me.btnEliminar.Text = "Eliminar Producto"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(23, 348)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(201, 36)
        Me.btnAgregar.TabIndex = 69
        Me.btnAgregar.Text = "Agregar Producto"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(23, 398)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersWidth = 51
        Me.dgvDetalle.RowTemplate.Height = 26
        Me.dgvDetalle.Size = New System.Drawing.Size(780, 220)
        Me.dgvDetalle.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(583, 632)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "TOTAL:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(663, 628)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(140, 28)
        Me.txtTotal.TabIndex = 72
        '
        'btnGenerarComprobante
        '
        Me.btnGenerarComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGenerarComprobante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGenerarComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarComprobante.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarComprobante.ForeColor = System.Drawing.Color.White
        Me.btnGenerarComprobante.Location = New System.Drawing.Point(243, 668)
        Me.btnGenerarComprobante.Name = "btnGenerarComprobante"
        Me.btnGenerarComprobante.Size = New System.Drawing.Size(340, 38)
        Me.btnGenerarComprobante.TabIndex = 73
        Me.btnGenerarComprobante.Text = "GENERAR COMPROBANTE"
        Me.btnGenerarComprobante.UseVisualStyleBackColor = False
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(93, 121)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(287, 22)
        Me.txtCliente.TabIndex = 75
        '
        'dgvCliente
        '
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(23, 154)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.RowHeadersWidth = 51
        Me.dgvCliente.RowTemplate.Height = 24
        Me.dgvCliente.Size = New System.Drawing.Size(779, 175)
        Me.dgvCliente.TabIndex = 76
        '
        'JdVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 717)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.btnGenerarComprobante)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboTipoComprobante)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumeroVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "JdVentas"
        Me.Text = "Gestion de Ventas"
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeroVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboTipoComprobante As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnGenerarComprobante As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents dgvCliente As DataGridView
End Class
