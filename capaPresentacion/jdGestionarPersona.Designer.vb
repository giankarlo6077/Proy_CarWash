<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jdGestionarPersona
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
        Me.jPanel1 = New System.Windows.Forms.Panel()
        Me.jLabel1 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.jLabel7 = New System.Windows.Forms.Label()
        Me.txtFechaRegistro = New System.Windows.Forms.TextBox()
        Me.jLabel6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.jLabel3 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.jLabel4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.jLabel9 = New System.Windows.Forms.Label()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.jLabel8 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.jLabel13 = New System.Windows.Forms.Label()
        Me.cboDistrito = New System.Windows.Forms.ComboBox()
        Me.jLabel14 = New System.Windows.Forms.Label()
        Me.dchFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.jLabel10 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.jLabel11 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.jLabel12 = New System.Windows.Forms.Label()
        Me.rbnM = New System.Windows.Forms.RadioButton()
        Me.rbnF = New System.Windows.Forms.RadioButton()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tblPersona = New System.Windows.Forms.DataGridView()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.jPanel1.SuspendLayout()
        CType(Me.tblPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Text = "Registrar Nuevo Cliente"
        '
        'jPanel1
        '
        Me.jPanel1.BackColor = System.Drawing.Color.White
        Me.jPanel1.Location = New System.Drawing.Point(12, 45)
        Me.jPanel1.Name = "jPanel1"
        Me.jPanel1.Size = New System.Drawing.Size(870, 290)
        Me.jPanel1.Controls.Add(Me.jLabel7)
        Me.jPanel1.Controls.Add(Me.txtFechaRegistro)
        Me.jPanel1.Controls.Add(Me.jLabel1)
        Me.jPanel1.Controls.Add(Me.txtIdCliente)
        Me.jPanel1.Controls.Add(Me.jLabel6)
        Me.jPanel1.Controls.Add(Me.txtNombre)
        Me.jPanel1.Controls.Add(Me.jLabel3)
        Me.jPanel1.Controls.Add(Me.txtDni)
        Me.jPanel1.Controls.Add(Me.jLabel4)
        Me.jPanel1.Controls.Add(Me.txtDireccion)
        Me.jPanel1.Controls.Add(Me.jLabel9)
        Me.jPanel1.Controls.Add(Me.cboDepartamento)
        Me.jPanel1.Controls.Add(Me.jLabel8)
        Me.jPanel1.Controls.Add(Me.cboProvincia)
        Me.jPanel1.Controls.Add(Me.jLabel13)
        Me.jPanel1.Controls.Add(Me.cboDistrito)
        Me.jPanel1.Controls.Add(Me.jLabel14)
        Me.jPanel1.Controls.Add(Me.dchFechaNacimiento)
        Me.jPanel1.Controls.Add(Me.jLabel10)
        Me.jPanel1.Controls.Add(Me.txtCorreo)
        Me.jPanel1.Controls.Add(Me.jLabel11)
        Me.jPanel1.Controls.Add(Me.txtTelefono)
        Me.jPanel1.Controls.Add(Me.jLabel12)
        Me.jPanel1.Controls.Add(Me.rbnM)
        Me.jPanel1.Controls.Add(Me.rbnF)
        Me.jPanel1.Controls.Add(Me.btnNuevo)
        Me.jPanel1.Controls.Add(Me.btnCancelar)
        '
        'jLabel7
        '
        Me.jLabel7.AutoSize = True
        Me.jLabel7.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel7.Location = New System.Drawing.Point(470, 13)
        Me.jLabel7.Name = "jLabel7"
        Me.jLabel7.Text = "Fecha"
        '
        'txtFechaRegistro
        '
        Me.txtFechaRegistro.Location = New System.Drawing.Point(520, 10)
        Me.txtFechaRegistro.Name = "txtFechaRegistro"
        Me.txtFechaRegistro.Size = New System.Drawing.Size(119, 22)
        '
        'jLabel1
        '
        Me.jLabel1.AutoSize = True
        Me.jLabel1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel1.Location = New System.Drawing.Point(660, 13)
        Me.jLabel1.Name = "jLabel1"
        Me.jLabel1.Text = "Id Cliente:"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(730, 10)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(120, 22)
        '
        'jLabel6
        '
        Me.jLabel6.AutoSize = True
        Me.jLabel6.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel6.Location = New System.Drawing.Point(12, 45)
        Me.jLabel6.Name = "jLabel6"
        Me.jLabel6.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(12, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(323, 22)
        '
        'jLabel3
        '
        Me.jLabel3.AutoSize = True
        Me.jLabel3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel3.Location = New System.Drawing.Point(360, 45)
        Me.jLabel3.Name = "jLabel3"
        Me.jLabel3.Text = "N° DNI:"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(360, 65)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(142, 22)
        '
        'jLabel4
        '
        Me.jLabel4.AutoSize = True
        Me.jLabel4.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel4.Location = New System.Drawing.Point(12, 105)
        Me.jLabel4.Name = "jLabel4"
        Me.jLabel4.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(12, 125)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(330, 22)
        '
        'jLabel9
        '
        Me.jLabel9.AutoSize = True
        Me.jLabel9.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel9.Location = New System.Drawing.Point(360, 105)
        Me.jLabel9.Name = "jLabel9"
        Me.jLabel9.Text = "Departamento:"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.Location = New System.Drawing.Point(360, 125)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(162, 24)
        '
        'jLabel8
        '
        Me.jLabel8.AutoSize = True
        Me.jLabel8.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel8.Location = New System.Drawing.Point(540, 105)
        Me.jLabel8.Name = "jLabel8"
        Me.jLabel8.Text = "Provincia:"
        '
        'cboProvincia
        '
        Me.cboProvincia.Location = New System.Drawing.Point(540, 125)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(155, 24)
        '
        'jLabel13
        '
        Me.jLabel13.AutoSize = True
        Me.jLabel13.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel13.Location = New System.Drawing.Point(710, 105)
        Me.jLabel13.Name = "jLabel13"
        Me.jLabel13.Text = "Distritito"
        '
        'cboDistrito
        '
        Me.cboDistrito.Location = New System.Drawing.Point(710, 125)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(150, 24)
        '
        'jLabel14
        '
        Me.jLabel14.AutoSize = True
        Me.jLabel14.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel14.Location = New System.Drawing.Point(12, 175)
        Me.jLabel14.Name = "jLabel14"
        Me.jLabel14.Text = "Fecha de nacimiento:"
        '
        'dchFechaNacimiento
        '
        Me.dchFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dchFechaNacimiento.CustomFormat = "dd-MM-yyyy"
        Me.dchFechaNacimiento.Location = New System.Drawing.Point(12, 195)
        Me.dchFechaNacimiento.Name = "dchFechaNacimiento"
        Me.dchFechaNacimiento.Size = New System.Drawing.Size(161, 22)
        '
        'jLabel10
        '
        Me.jLabel10.AutoSize = True
        Me.jLabel10.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel10.Location = New System.Drawing.Point(200, 175)
        Me.jLabel10.Name = "jLabel10"
        Me.jLabel10.Text = "Correo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(200, 195)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(124, 22)
        '
        'jLabel11
        '
        Me.jLabel11.AutoSize = True
        Me.jLabel11.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel11.Location = New System.Drawing.Point(340, 175)
        Me.jLabel11.Name = "jLabel11"
        Me.jLabel11.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(340, 195)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(142, 22)
        '
        'jLabel12
        '
        Me.jLabel12.AutoSize = True
        Me.jLabel12.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.jLabel12.Location = New System.Drawing.Point(500, 175)
        Me.jLabel12.Name = "jLabel12"
        Me.jLabel12.Text = "Sexo:"
        '
        'rbnM
        '
        Me.rbnM.AutoSize = True
        Me.rbnM.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.rbnM.Location = New System.Drawing.Point(500, 195)
        Me.rbnM.Name = "rbnM"
        Me.rbnM.Text = "M"
        '
        'rbnF
        '
        Me.rbnF.AutoSize = True
        Me.rbnF.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.rbnF.Location = New System.Drawing.Point(555, 195)
        Me.rbnF.Name = "rbnF"
        Me.rbnF.Text = "F"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(31, 41, 55)
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(620, 240)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(124, 35)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(31, 41, 55)
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(750, 240)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 35)
        Me.btnCancelar.Text = "Cancelar"
        '
        'tblPersona
        '
        Me.tblPersona.AllowUserToAddRows = False
        Me.tblPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPersona.Location = New System.Drawing.Point(12, 345)
        Me.tblPersona.Name = "tblPersona"
        Me.tblPersona.Size = New System.Drawing.Size(870, 198)
        '
        'jdGestionarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 560)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.jPanel1)
        Me.Controls.Add(Me.tblPersona)
        Me.Name = "jdGestionarPersona"
        Me.Text = "Gestionar Persona"
        Me.jPanel1.ResumeLayout(False)
        Me.jPanel1.PerformLayout()
        CType(Me.tblPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents jPanel1 As Panel
    Friend WithEvents jLabel1 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents jLabel7 As Label
    Friend WithEvents txtFechaRegistro As TextBox
    Friend WithEvents jLabel6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents jLabel3 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents jLabel4 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents jLabel9 As Label
    Friend WithEvents cboDepartamento As ComboBox
    Friend WithEvents jLabel8 As Label
    Friend WithEvents cboProvincia As ComboBox
    Friend WithEvents jLabel13 As Label
    Friend WithEvents cboDistrito As ComboBox
    Friend WithEvents jLabel14 As Label
    Friend WithEvents dchFechaNacimiento As DateTimePicker
    Friend WithEvents jLabel10 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents jLabel11 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents jLabel12 As Label
    Friend WithEvents rbnM As RadioButton
    Friend WithEvents rbnF As RadioButton
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents tblPersona As DataGridView
    Friend WithEvents lblTitulo As Label
End Class
