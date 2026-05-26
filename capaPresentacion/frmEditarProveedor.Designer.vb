<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarProveedor
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblRUC = New System.Windows.Forms.Label()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblLinea = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(520, 65)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(520, 65)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "EDITAR PROVEEDOR"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(24, 82)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre del proveedor *"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(24, 102)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(472, 24)
        Me.txtNombre.TabIndex = 1
        '
        'lblRUC
        '
        Me.lblRUC.AutoSize = True
        Me.lblRUC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUC.Location = New System.Drawing.Point(24, 142)
        Me.lblRUC.Name = "lblRUC"
        Me.lblRUC.TabIndex = 3
        Me.lblRUC.Text = "RUC (11 dígitos) *"
        '
        'txtRUC
        '
        Me.txtRUC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.Location = New System.Drawing.Point(24, 162)
        Me.txtRUC.MaxLength = 11
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(220, 24)
        Me.txtRUC.TabIndex = 2
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(268, 142)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Teléfono (9 dígitos) *"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(268, 162)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(228, 24)
        Me.txtTelefono.TabIndex = 3
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(24, 202)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.TabIndex = 7
        Me.lblCorreo.Text = "Correo electrónico *"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(24, 222)
        Me.txtCorreo.MaxLength = 100
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(472, 24)
        Me.txtCorreo.TabIndex = 4
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(24, 262)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.TabIndex = 9
        Me.lblDireccion.Text = "Dirección *"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(24, 282)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(472, 24)
        Me.txtDireccion.TabIndex = 5
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacto.Location = New System.Drawing.Point(24, 322)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.TabIndex = 11
        Me.lblContacto.Text = "Persona de contacto *"
        '
        'txtContacto
        '
        Me.txtContacto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.Location = New System.Drawing.Point(24, 342)
        Me.txtContacto.MaxLength = 100
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(220, 24)
        Me.txtContacto.TabIndex = 6
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(268, 322)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "Estado *"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cboEstado.Location = New System.Drawing.Point(268, 342)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(150, 26)
        Me.cboEstado.TabIndex = 7
        '
        'lblLinea
        '
        Me.lblLinea.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLinea.Location = New System.Drawing.Point(24, 384)
        Me.lblLinea.Name = "lblLinea"
        Me.lblLinea.Size = New System.Drawing.Size(472, 2)
        Me.lblLinea.TabIndex = 15
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(24, 396)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 38)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(366, 396)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(130, 38)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmEditarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 450)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblLinea)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.lblContacto)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtRUC)
        Me.Controls.Add(Me.lblRUC)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar Proveedor"
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblRUC As Label
    Friend WithEvents txtRUC As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblContacto As Label
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents lblLinea As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class
