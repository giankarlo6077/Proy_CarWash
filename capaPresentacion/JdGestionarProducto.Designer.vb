<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JdGestionarProducto
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.jPanel1 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.chkVigencia = New System.Windows.Forms.CheckBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.spnStock = New System.Windows.Forms.NumericUpDown()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblTipoProducto = New System.Windows.Forms.Label()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.btnTipoProducto = New System.Windows.Forms.Button()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cboMarcaProducto = New System.Windows.Forms.ComboBox()
        Me.btnMarca = New System.Windows.Forms.Button()
        Me.jPanel2 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnDarsebaja = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.jPanel3 = New System.Windows.Forms.Panel()
        Me.tblProducto = New System.Windows.Forms.DataGridView()
        Me.jPanel1.SuspendLayout()
        CType(Me.spnStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.jPanel2.SuspendLayout()
        Me.jPanel3.SuspendLayout()
        CType(Me.tblProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(38, 14)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(533, 52)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mantenimiento de Producto"
        '
        'jPanel1
        '
        Me.jPanel1.BackColor = System.Drawing.Color.White
        Me.jPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.jPanel1.Controls.Add(Me.lblId)
        Me.jPanel1.Controls.Add(Me.txtId)
        Me.jPanel1.Controls.Add(Me.btnBuscar)
        Me.jPanel1.Controls.Add(Me.chkVigencia)
        Me.jPanel1.Controls.Add(Me.lblNombre)
        Me.jPanel1.Controls.Add(Me.txtNombre)
        Me.jPanel1.Controls.Add(Me.lblStock)
        Me.jPanel1.Controls.Add(Me.spnStock)
        Me.jPanel1.Controls.Add(Me.lblPrecio)
        Me.jPanel1.Controls.Add(Me.txtPrecio)
        Me.jPanel1.Controls.Add(Me.lblTipoProducto)
        Me.jPanel1.Controls.Add(Me.cboTipoProducto)
        Me.jPanel1.Controls.Add(Me.btnTipoProducto)
        Me.jPanel1.Controls.Add(Me.lblMarca)
        Me.jPanel1.Controls.Add(Me.cboMarcaProducto)
        Me.jPanel1.Controls.Add(Me.btnMarca)
        Me.jPanel1.Location = New System.Drawing.Point(14, 69)
        Me.jPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.jPanel1.Name = "jPanel1"
        Me.jPanel1.Size = New System.Drawing.Size(828, 186)
        Me.jPanel1.TabIndex = 1
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(11, 22)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(39, 25)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "id:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(68, 19)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(144, 26)
        Me.txtId.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(225, 16)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(101, 34)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'chkVigencia
        '
        Me.chkVigencia.AutoSize = True
        Me.chkVigencia.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVigencia.Location = New System.Drawing.Point(360, 20)
        Me.chkVigencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkVigencia.Name = "chkVigencia"
        Me.chkVigencia.Size = New System.Drawing.Size(123, 29)
        Me.chkVigencia.TabIndex = 3
        Me.chkVigencia.Text = "Vigencia"
        Me.chkVigencia.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(11, 72)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(100, 25)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 69)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(224, 26)
        Me.txtNombre.TabIndex = 5
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(360, 72)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(77, 25)
        Me.lblStock.TabIndex = 6
        Me.lblStock.Text = "Stock:"
        '
        'spnStock
        '
        Me.spnStock.Location = New System.Drawing.Point(428, 69)
        Me.spnStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.spnStock.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.spnStock.Name = "spnStock"
        Me.spnStock.Size = New System.Drawing.Size(79, 26)
        Me.spnStock.TabIndex = 7
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(523, 72)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(82, 25)
        Me.lblPrecio.TabIndex = 8
        Me.lblPrecio.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(591, 69)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(102, 26)
        Me.txtPrecio.TabIndex = 9
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.AutoSize = True
        Me.lblTipoProducto.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoProducto.Location = New System.Drawing.Point(11, 131)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(189, 25)
        Me.lblTipoProducto.TabIndex = 10
        Me.lblTipoProducto.Text = "Tipo de Producto:"
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.FormattingEnabled = True
        Me.cboTipoProducto.Location = New System.Drawing.Point(163, 128)
        Me.cboTipoProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(242, 28)
        Me.cboTipoProducto.TabIndex = 11
        '
        'btnTipoProducto
        '
        Me.btnTipoProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTipoProducto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoProducto.ForeColor = System.Drawing.Color.White
        Me.btnTipoProducto.Location = New System.Drawing.Point(413, 126)
        Me.btnTipoProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTipoProducto.Name = "btnTipoProducto"
        Me.btnTipoProducto.Size = New System.Drawing.Size(36, 32)
        Me.btnTipoProducto.TabIndex = 12
        Me.btnTipoProducto.Text = "..."
        Me.btnTipoProducto.UseVisualStyleBackColor = False
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(467, 131)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(81, 25)
        Me.lblMarca.TabIndex = 13
        Me.lblMarca.Text = "Marca:"
        '
        'cboMarcaProducto
        '
        Me.cboMarcaProducto.FormattingEnabled = True
        Me.cboMarcaProducto.Location = New System.Drawing.Point(532, 128)
        Me.cboMarcaProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboMarcaProducto.Name = "cboMarcaProducto"
        Me.cboMarcaProducto.Size = New System.Drawing.Size(202, 28)
        Me.cboMarcaProducto.TabIndex = 14
        '
        'btnMarca
        '
        Me.btnMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMarca.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarca.ForeColor = System.Drawing.Color.White
        Me.btnMarca.Location = New System.Drawing.Point(741, 126)
        Me.btnMarca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(36, 32)
        Me.btnMarca.TabIndex = 15
        Me.btnMarca.Text = "..."
        Me.btnMarca.UseVisualStyleBackColor = False
        '
        'jPanel2
        '
        Me.jPanel2.BackColor = System.Drawing.Color.White
        Me.jPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.jPanel2.Controls.Add(Me.btnNuevo)
        Me.jPanel2.Controls.Add(Me.btnModificar)
        Me.jPanel2.Controls.Add(Me.btnLimpiar)
        Me.jPanel2.Controls.Add(Me.btnDarsebaja)
        Me.jPanel2.Controls.Add(Me.btnEliminar)
        Me.jPanel2.Controls.Add(Me.btnSalir)
        Me.jPanel2.Location = New System.Drawing.Point(14, 269)
        Me.jPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.jPanel2.Name = "jPanel2"
        Me.jPanel2.Size = New System.Drawing.Size(828, 68)
        Me.jPanel2.TabIndex = 2
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(17, 12)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(101, 41)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(129, 12)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(107, 41)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(248, 12)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(101, 41)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnDarsebaja
        '
        Me.btnDarsebaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDarsebaja.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarsebaja.ForeColor = System.Drawing.Color.White
        Me.btnDarsebaja.Location = New System.Drawing.Point(360, 12)
        Me.btnDarsebaja.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDarsebaja.Name = "btnDarsebaja"
        Me.btnDarsebaja.Size = New System.Drawing.Size(124, 41)
        Me.btnDarsebaja.TabIndex = 3
        Me.btnDarsebaja.Text = "Dar de Baja"
        Me.btnDarsebaja.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(495, 12)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(101, 41)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(720, 12)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 41)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'jPanel3
        '
        Me.jPanel3.BackColor = System.Drawing.Color.White
        Me.jPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.jPanel3.Controls.Add(Me.tblProducto)
        Me.jPanel3.Location = New System.Drawing.Point(14, 350)
        Me.jPanel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.jPanel3.Name = "jPanel3"
        Me.jPanel3.Size = New System.Drawing.Size(828, 324)
        Me.jPanel3.TabIndex = 3
        '
        'tblProducto
        '
        Me.tblProducto.AllowUserToAddRows = False
        Me.tblProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProducto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblProducto.Location = New System.Drawing.Point(11, 12)
        Me.tblProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tblProducto.Name = "tblProducto"
        Me.tblProducto.ReadOnly = True
        Me.tblProducto.RowHeadersWidth = 51
        Me.tblProducto.Size = New System.Drawing.Size(801, 294)
        Me.tblProducto.TabIndex = 0
        '
        'JdGestionarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(855, 700)
        Me.Controls.Add(Me.jPanel3)
        Me.Controls.Add(Me.jPanel2)
        Me.Controls.Add(Me.jPanel1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "JdGestionarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "JdGestionarProducto"
        Me.jPanel1.ResumeLayout(False)
        Me.jPanel1.PerformLayout()
        CType(Me.spnStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.jPanel2.ResumeLayout(False)
        Me.jPanel3.ResumeLayout(False)
        CType(Me.tblProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents jPanel1 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents chkVigencia As CheckBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents spnStock As NumericUpDown
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblTipoProducto As Label
    Friend WithEvents cboTipoProducto As ComboBox
    Friend WithEvents btnTipoProducto As Button
    Friend WithEvents lblMarca As Label
    Friend WithEvents cboMarcaProducto As ComboBox
    Friend WithEvents btnMarca As Button
    Friend WithEvents jPanel2 As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnDarsebaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents jPanel3 As Panel
    Friend WithEvents tblProducto As DataGridView
End Class
