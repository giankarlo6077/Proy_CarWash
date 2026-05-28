<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jdRegistrarPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jdRegistrarPersona))
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreAp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkFemenino = New System.Windows.Forms.CheckBox()
        Me.chkMasculino = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboDistrito = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lvPersona = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(445, 96)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(160, 21)
        Me.txtCorreo.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(441, 80)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Correo"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(445, 52)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(327, 21)
        Me.txtDNI.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(441, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "N° DNI"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(11, 96)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(364, 21)
        Me.txtDireccion.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(601, 130)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fecha de Nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 80)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Dirección"
        '
        'txtNombreAp
        '
        Me.txtNombreAp.Location = New System.Drawing.Point(8, 52)
        Me.txtNombreAp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNombreAp.Name = "txtNombreAp"
        Me.txtNombreAp.Size = New System.Drawing.Size(367, 21)
        Me.txtNombreAp.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nombres y Apellidos"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Location = New System.Drawing.Point(11, 147)
        Me.cboDepartamento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(160, 21)
        Me.cboDepartamento.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(612, 97)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(160, 21)
        Me.txtTelefono.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 131)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(608, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DATOS PERSONALES"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkFemenino)
        Me.Panel1.Controls.Add(Me.chkMasculino)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cboProvincia)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cboDistrito)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.dtpFechaNac)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtDNI)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtNombreAp)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cboDepartamento)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(20, 99)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 249)
        Me.Panel1.TabIndex = 13
        '
        'chkFemenino
        '
        Me.chkFemenino.AutoSize = True
        Me.chkFemenino.Location = New System.Drawing.Point(141, 200)
        Me.chkFemenino.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkFemenino.Name = "chkFemenino"
        Me.chkFemenino.Size = New System.Drawing.Size(90, 17)
        Me.chkFemenino.TabIndex = 28
        Me.chkFemenino.Text = "Femenino"
        Me.chkFemenino.UseVisualStyleBackColor = True
        '
        'chkMasculino
        '
        Me.chkMasculino.AutoSize = True
        Me.chkMasculino.Location = New System.Drawing.Point(11, 200)
        Me.chkMasculino.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkMasculino.Name = "chkMasculino"
        Me.chkMasculino.Size = New System.Drawing.Size(90, 17)
        Me.chkMasculino.TabIndex = 27
        Me.chkMasculino.Text = "Masculino"
        Me.chkMasculino.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 180)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Sexo"
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(191, 147)
        Me.cboProvincia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(160, 21)
        Me.cboProvincia.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(187, 131)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Provincia"
        '
        'cboDistrito
        '
        Me.cboDistrito.FormattingEnabled = True
        Me.cboDistrito.Location = New System.Drawing.Point(371, 147)
        Me.cboDistrito.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(160, 21)
        Me.cboDistrito.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(367, 131)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Distrito"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(605, 147)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(167, 21)
        Me.dtpFechaNac.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Registrar Nuevo Cliente"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(669, 354)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(153, 23)
        Me.btnNuevo.TabIndex = 21
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(523, 354)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(139, 23)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar "
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lvPersona
        '
        Me.lvPersona.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lvPersona.HideSelection = False
        Me.lvPersona.Location = New System.Drawing.Point(20, 394)
        Me.lvPersona.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lvPersona.Name = "lvPersona"
        Me.lvPersona.Size = New System.Drawing.Size(801, 125)
        Me.lvPersona.TabIndex = 22
        Me.lvPersona.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(681, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Id Cliente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(488, 33)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(492, 49)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(133, 21)
        Me.dtpFecha.TabIndex = 16
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(685, 49)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(132, 21)
        Me.txtId.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(835, 82)
        Me.Panel3.TabIndex = 84
        '
        'jdRegistrarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(835, 523)
        Me.Controls.Add(Me.lvPersona)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "jdRegistrarPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registrar Persona"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreAp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboDepartamento As ComboBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cboProvincia As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboDistrito As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents chkFemenino As CheckBox
    Friend WithEvents chkMasculino As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lvPersona As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtId As TextBox
    Friend WithEvents Panel3 As Panel
End Class
