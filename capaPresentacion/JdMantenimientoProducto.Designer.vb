<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JdMantenimientoProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JdMantenimientoProducto))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtbuscador = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGestionarPersona = New System.Windows.Forms.Button()
        Me.tblProducto = New System.Windows.Forms.DataGridView()
        CType(Me.tblProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(15, 14)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(362, 34)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mantenimiento de Producto"
        '
        'txtbuscador
        '
        Me.txtbuscador.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscador.Location = New System.Drawing.Point(15, 61)
        Me.txtbuscador.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.Size = New System.Drawing.Size(230, 25)
        Me.txtbuscador.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(255, 59)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(113, 26)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnGestionarPersona
        '
        Me.btnGestionarPersona.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGestionarPersona.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionarPersona.ForeColor = System.Drawing.Color.White
        Me.btnGestionarPersona.Location = New System.Drawing.Point(420, 59)
        Me.btnGestionarPersona.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGestionarPersona.Name = "btnGestionarPersona"
        Me.btnGestionarPersona.Size = New System.Drawing.Size(165, 26)
        Me.btnGestionarPersona.TabIndex = 3
        Me.btnGestionarPersona.Text = "Administrar Producto"
        Me.btnGestionarPersona.UseVisualStyleBackColor = False
        '
        'tblProducto
        '
        Me.tblProducto.AllowUserToAddRows = False
        Me.tblProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProducto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblProducto.Location = New System.Drawing.Point(15, 98)
        Me.tblProducto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tblProducto.Name = "tblProducto"
        Me.tblProducto.ReadOnly = True
        Me.tblProducto.RowHeadersWidth = 51
        Me.tblProducto.Size = New System.Drawing.Size(585, 309)
        Me.tblProducto.TabIndex = 4
        '
        'JdMantenimientoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(615, 426)
        Me.Controls.Add(Me.tblProducto)
        Me.Controls.Add(Me.btnGestionarPersona)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "JdMantenimientoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Producto"
        CType(Me.tblProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtbuscador As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGestionarPersona As Button
    Friend WithEvents tblProducto As DataGridView
End Class
