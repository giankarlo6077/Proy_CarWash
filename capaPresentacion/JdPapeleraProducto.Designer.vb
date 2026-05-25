<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JdPapeleraProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JdPapeleraProducto))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.jPanel1 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.jPanel2 = New System.Windows.Forms.Panel()
        Me.tblPapelera = New System.Windows.Forms.DataGridView()
        Me.jPanel1.SuspendLayout()
        Me.jPanel2.SuspendLayout()
        CType(Me.tblPapelera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(25, 9)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(355, 34)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Papelera de Productos"
        '
        'jPanel1
        '
        Me.jPanel1.BackColor = System.Drawing.Color.White
        Me.jPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.jPanel1.Controls.Add(Me.lblId)
        Me.jPanel1.Controls.Add(Me.txtId)
        Me.jPanel1.Controls.Add(Me.btnRecuperar)
        Me.jPanel1.Controls.Add(Me.btnEliminar)
        Me.jPanel1.Controls.Add(Me.btnActualizar)
        Me.jPanel1.Controls.Add(Me.btnSalir)
        Me.jPanel1.Location = New System.Drawing.Point(9, 45)
        Me.jPanel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.jPanel1.Name = "jPanel1"
        Me.jPanel1.Size = New System.Drawing.Size(553, 46)
        Me.jPanel1.TabIndex = 1
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(7, 13)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(26, 17)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "id:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(37, 11)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(68, 20)
        Me.txtId.TabIndex = 1
        '
        'btnRecuperar
        '
        Me.btnRecuperar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRecuperar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperar.ForeColor = System.Drawing.Color.White
        Me.btnRecuperar.Location = New System.Drawing.Point(127, 9)
        Me.btnRecuperar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(83, 27)
        Me.btnRecuperar.TabIndex = 2
        Me.btnRecuperar.Text = "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(244, 9)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(77, 27)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar definitivamente"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnActualizar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(352, 9)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(83, 27)
        Me.btnActualizar.TabIndex = 4
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(480, 9)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(60, 27)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'jPanel2
        '
        Me.jPanel2.BackColor = System.Drawing.Color.White
        Me.jPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.jPanel2.Controls.Add(Me.tblPapelera)
        Me.jPanel2.Location = New System.Drawing.Point(9, 98)
        Me.jPanel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.jPanel2.Name = "jPanel2"
        Me.jPanel2.Size = New System.Drawing.Size(553, 235)
        Me.jPanel2.TabIndex = 2
        '
        'tblPapelera
        '
        Me.tblPapelera.AllowUserToAddRows = False
        Me.tblPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPapelera.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblPapelera.Location = New System.Drawing.Point(7, 8)
        Me.tblPapelera.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tblPapelera.Name = "tblPapelera"
        Me.tblPapelera.ReadOnly = True
        Me.tblPapelera.RowHeadersWidth = 51
        Me.tblPapelera.Size = New System.Drawing.Size(534, 214)
        Me.tblPapelera.TabIndex = 0
        '
        'JdPapeleraProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(570, 346)
        Me.Controls.Add(Me.jPanel2)
        Me.Controls.Add(Me.jPanel1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "JdPapeleraProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recuperar Producto"
        Me.jPanel1.ResumeLayout(False)
        Me.jPanel1.PerformLayout()
        Me.jPanel2.ResumeLayout(False)
        CType(Me.tblPapelera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents jPanel1 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnRecuperar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents jPanel2 As Panel
    Friend WithEvents tblPapelera As DataGridView
End Class
