<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JdMantenimientoCliente
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.jLabel2 = New System.Windows.Forms.Label()
        Me.cboTipoCliente = New System.Windows.Forms.ComboBox()
        Me.jPanel2 = New System.Windows.Forms.Panel()
        Me.jLabel5 = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.btnGestionarPersona = New System.Windows.Forms.Button()
        Me.jLabel6 = New System.Windows.Forms.Label()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.btnBuscarPersona = New System.Windows.Forms.Button()
        Me.jLabel15 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.jLabel10 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.jLabel11 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.jLabel16 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.btnBuscarEmpresa = New System.Windows.Forms.Button()
        Me.jLabel13 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtGestionarEmpresa = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.jPanel1.SuspendLayout()
        Me.jPanel2.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'jPanel1
        '
        Me.jPanel1.BackColor = System.Drawing.Color.FromArgb(223, 218, 214)
        Me.jPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jPanel1.Location = New System.Drawing.Point(0, 0)
        Me.jPanel1.Name = "jPanel1"
        Me.jPanel1.Size = New System.Drawing.Size(720, 420)
        Me.jPanel1.Controls.Add(Me.lblTitulo)
        Me.jPanel1.Controls.Add(Me.jLabel2)
        Me.jPanel1.Controls.Add(Me.cboTipoCliente)
        Me.jPanel1.Controls.Add(Me.jPanel2)
        Me.jPanel1.Controls.Add(Me.pnl1)
        Me.jPanel1.Controls.Add(Me.btnGuardar)
        Me.jPanel1.Controls.Add(Me.btnCancelar)
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(25, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Text = "Registrar Nuevo Cliente"
        '
        'jLabel2
        '
        Me.jLabel2.AutoSize = True
        Me.jLabel2.Location = New System.Drawing.Point(25, 48)
        Me.jLabel2.Name = "jLabel2"
        Me.jLabel2.Text = "Tipo de Cliente"
        '
        'cboTipoCliente
        '
        Me.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCliente.Items.AddRange(New Object() {"Natural", "Juridica"})
        Me.cboTipoCliente.Location = New System.Drawing.Point(25, 68)
        Me.cboTipoCliente.Name = "cboTipoCliente"
        Me.cboTipoCliente.Size = New System.Drawing.Size(137, 24)
        '
        'jPanel2
        '
        Me.jPanel2.Location = New System.Drawing.Point(25, 105)
        Me.jPanel2.Name = "jPanel2"
        Me.jPanel2.Size = New System.Drawing.Size(360, 235)
        Me.jPanel2.Controls.Add(Me.jLabel5)
        Me.jPanel2.Controls.Add(Me.cboTipoDocumento)
        Me.jPanel2.Controls.Add(Me.btnGestionarPersona)
        Me.jPanel2.Controls.Add(Me.jLabel6)
        Me.jPanel2.Controls.Add(Me.txtNroDocumento)
        Me.jPanel2.Controls.Add(Me.btnBuscarPersona)
        Me.jPanel2.Controls.Add(Me.jLabel15)
        Me.jPanel2.Controls.Add(Me.txtNombres)
        Me.jPanel2.Controls.Add(Me.jLabel10)
        Me.jPanel2.Controls.Add(Me.txtCorreo)
        Me.jPanel2.Controls.Add(Me.jLabel11)
        Me.jPanel2.Controls.Add(Me.txtTelefono)
        '
        'jLabel5
        '
        Me.jLabel5.AutoSize = True
        Me.jLabel5.Location = New System.Drawing.Point(10, 10)
        Me.jLabel5.Name = "jLabel5"
        Me.jLabel5.Text = "Tipo Documento:"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.Items.AddRange(New Object() {"DNI", "CARNET DE EXTRANJERIA"})
        Me.cboTipoDocumento.Location = New System.Drawing.Point(10, 32)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(160, 24)
        '
        'btnGestionarPersona
        '
        Me.btnGestionarPersona.BackColor = System.Drawing.Color.FromArgb(51, 51, 255)
        Me.btnGestionarPersona.ForeColor = System.Drawing.Color.White
        Me.btnGestionarPersona.Location = New System.Drawing.Point(190, 32)
        Me.btnGestionarPersona.Name = "btnGestionarPersona"
        Me.btnGestionarPersona.Size = New System.Drawing.Size(151, 30)
        Me.btnGestionarPersona.Text = "Gestionar"
        '
        'jLabel6
        '
        Me.jLabel6.AutoSize = True
        Me.jLabel6.Location = New System.Drawing.Point(10, 70)
        Me.jLabel6.Name = "jLabel6"
        Me.jLabel6.Text = "N° Documento:"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(10, 92)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(160, 22)
        '
        'btnBuscarPersona
        '
        Me.btnBuscarPersona.BackColor = System.Drawing.Color.FromArgb(51, 51, 255)
        Me.btnBuscarPersona.ForeColor = System.Drawing.Color.White
        Me.btnBuscarPersona.Location = New System.Drawing.Point(190, 90)
        Me.btnBuscarPersona.Name = "btnBuscarPersona"
        Me.btnBuscarPersona.Size = New System.Drawing.Size(151, 32)
        Me.btnBuscarPersona.Text = "Buscar"
        '
        'jLabel15
        '
        Me.jLabel15.AutoSize = True
        Me.jLabel15.Location = New System.Drawing.Point(10, 130)
        Me.jLabel15.Name = "jLabel15"
        Me.jLabel15.Text = "Nombres y Apellidos:"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(10, 152)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(320, 22)
        '
        'jLabel10
        '
        Me.jLabel10.AutoSize = True
        Me.jLabel10.Location = New System.Drawing.Point(10, 185)
        Me.jLabel10.Name = "jLabel10"
        Me.jLabel10.Text = "Correo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(10, 207)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(124, 22)
        '
        'jLabel11
        '
        Me.jLabel11.AutoSize = True
        Me.jLabel11.Location = New System.Drawing.Point(160, 185)
        Me.jLabel11.Name = "jLabel11"
        Me.jLabel11.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(160, 207)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(127, 22)
        '
        'pnl1
        '
        Me.pnl1.Location = New System.Drawing.Point(400, 105)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(290, 235)
        Me.pnl1.Controls.Add(Me.jLabel16)
        Me.pnl1.Controls.Add(Me.txtRuc)
        Me.pnl1.Controls.Add(Me.btnBuscarEmpresa)
        Me.pnl1.Controls.Add(Me.jLabel13)
        Me.pnl1.Controls.Add(Me.txtRazonSocial)
        Me.pnl1.Controls.Add(Me.txtGestionarEmpresa)
        '
        'jLabel16
        '
        Me.jLabel16.AutoSize = True
        Me.jLabel16.Location = New System.Drawing.Point(10, 10)
        Me.jLabel16.Name = "jLabel16"
        Me.jLabel16.Text = "RUC"
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(10, 32)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(196, 22)
        '
        'btnBuscarEmpresa
        '
        Me.btnBuscarEmpresa.BackColor = System.Drawing.Color.FromArgb(51, 51, 255)
        Me.btnBuscarEmpresa.ForeColor = System.Drawing.Color.White
        Me.btnBuscarEmpresa.Location = New System.Drawing.Point(10, 62)
        Me.btnBuscarEmpresa.Name = "btnBuscarEmpresa"
        Me.btnBuscarEmpresa.Size = New System.Drawing.Size(136, 30)
        Me.btnBuscarEmpresa.Text = "Buscar"
        '
        'jLabel13
        '
        Me.jLabel13.AutoSize = True
        Me.jLabel13.Location = New System.Drawing.Point(10, 105)
        Me.jLabel13.Name = "jLabel13"
        Me.jLabel13.Text = "Razon Social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(10, 127)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(250, 22)
        '
        'txtGestionarEmpresa
        '
        Me.txtGestionarEmpresa.BackColor = System.Drawing.Color.FromArgb(51, 51, 255)
        Me.txtGestionarEmpresa.ForeColor = System.Drawing.Color.White
        Me.txtGestionarEmpresa.Location = New System.Drawing.Point(10, 160)
        Me.txtGestionarEmpresa.Name = "txtGestionarEmpresa"
        Me.txtGestionarEmpresa.Size = New System.Drawing.Size(135, 30)
        Me.txtGestionarEmpresa.Text = "Gestionar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(25, 350)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 40)
        Me.btnGuardar.Text = "Atender"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(150, 350)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 40)
        Me.btnCancelar.Text = "Cancelar"
        '
        'JdMantenimientoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 420)
        Me.Controls.Add(Me.jPanel1)
        Me.Name = "JdMantenimientoCliente"
        Me.Text = "JdMantenimientoCliente"
        Me.jPanel1.ResumeLayout(False)
        Me.jPanel1.PerformLayout()
        Me.jPanel2.ResumeLayout(False)
        Me.jPanel2.PerformLayout()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents jPanel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents jLabel2 As Label
    Friend WithEvents cboTipoCliente As ComboBox
    Friend WithEvents jPanel2 As Panel
    Friend WithEvents jLabel5 As Label
    Friend WithEvents cboTipoDocumento As ComboBox
    Friend WithEvents btnGestionarPersona As Button
    Friend WithEvents jLabel6 As Label
    Friend WithEvents txtNroDocumento As TextBox
    Friend WithEvents btnBuscarPersona As Button
    Friend WithEvents jLabel15 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents jLabel10 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents jLabel11 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents pnl1 As Panel
    Friend WithEvents jLabel16 As Label
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents btnBuscarEmpresa As Button
    Friend WithEvents jLabel13 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents txtGestionarEmpresa As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class
