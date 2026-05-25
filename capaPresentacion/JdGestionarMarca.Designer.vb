<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JdGestionarMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JdGestionarMarca))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.jPanel1 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtIdMarca = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.jPanel2 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.jPanel3 = New System.Windows.Forms.Panel()
        Me.tblMarca = New System.Windows.Forms.DataGridView()
        Me.jPanel1.SuspendLayout()
        Me.jPanel2.SuspendLayout()
        Me.jPanel3.SuspendLayout()
        CType(Me.tblMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(25, 16)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(323, 34)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mantenimiento de Marca"
        '
        'jPanel1
        '
        Me.jPanel1.BackColor = System.Drawing.Color.White
        Me.jPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.jPanel1.Controls.Add(Me.lblId)
        Me.jPanel1.Controls.Add(Me.txtIdMarca)
        Me.jPanel1.Controls.Add(Me.btnBuscar)
        Me.jPanel1.Controls.Add(Me.lblNombre)
        Me.jPanel1.Controls.Add(Me.txtNombre)
        Me.jPanel1.Location = New System.Drawing.Point(25, 57)
        Me.jPanel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.jPanel1.Name = "jPanel1"
        Me.jPanel1.Size = New System.Drawing.Size(196, 74)
        Me.jPanel1.TabIndex = 1
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(7, 14)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "id:"
        '
        'txtIdMarca
        '
        Me.txtIdMarca.Location = New System.Drawing.Point(39, 12)
        Me.txtIdMarca.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtIdMarca.Name = "txtIdMarca"
        Me.txtIdMarca.Size = New System.Drawing.Size(83, 20)
        Me.txtIdMarca.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(126, 12)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(7, 43)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(67, 40)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 20)
        Me.txtNombre.TabIndex = 4
        '
        'jPanel2
        '
        Me.jPanel2.BackColor = System.Drawing.Color.White
        Me.jPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.jPanel2.Controls.Add(Me.btnNuevo)
        Me.jPanel2.Controls.Add(Me.btnModificar)
        Me.jPanel2.Controls.Add(Me.btnLimpiar)
        Me.jPanel2.Controls.Add(Me.btnEliminar)
        Me.jPanel2.Controls.Add(Me.btnSalir)
        Me.jPanel2.Location = New System.Drawing.Point(25, 138)
        Me.jPanel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.jPanel2.Name = "jPanel2"
        Me.jPanel2.Size = New System.Drawing.Size(196, 107)
        Me.jPanel2.TabIndex = 2
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(11, 10)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 27)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(93, 10)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 27)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(11, 42)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 27)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(93, 42)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 27)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(60, 75)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 27)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'jPanel3
        '
        Me.jPanel3.BackColor = System.Drawing.Color.White
        Me.jPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.jPanel3.Controls.Add(Me.tblMarca)
        Me.jPanel3.Location = New System.Drawing.Point(233, 57)
        Me.jPanel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.jPanel3.Name = "jPanel3"
        Me.jPanel3.Size = New System.Drawing.Size(226, 187)
        Me.jPanel3.TabIndex = 3
        '
        'tblMarca
        '
        Me.tblMarca.AllowUserToAddRows = False
        Me.tblMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblMarca.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblMarca.Location = New System.Drawing.Point(7, 8)
        Me.tblMarca.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tblMarca.MultiSelect = False
        Me.tblMarca.Name = "tblMarca"
        Me.tblMarca.ReadOnly = True
        Me.tblMarca.RowHeadersWidth = 51
        Me.tblMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblMarca.Size = New System.Drawing.Size(207, 166)
        Me.tblMarca.TabIndex = 0
        '
        'JdGestionarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 268)
        Me.Controls.Add(Me.jPanel3)
        Me.Controls.Add(Me.jPanel2)
        Me.Controls.Add(Me.jPanel1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "JdGestionarMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestionar Marca"
        Me.jPanel1.ResumeLayout(False)
        Me.jPanel1.PerformLayout()
        Me.jPanel2.ResumeLayout(False)
        Me.jPanel3.ResumeLayout(False)
        CType(Me.tblMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents jPanel1 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents txtIdMarca As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents jPanel2 As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents jPanel3 As Panel
    Friend WithEvents tblMarca As DataGridView
End Class
