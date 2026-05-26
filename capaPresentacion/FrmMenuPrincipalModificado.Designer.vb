<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipalModificado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrincipalModificado))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACERCADEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANTENIMIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CITASVENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarCitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DescuentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.MANTENIMIENTOToolStripMenuItem, Me.CITASVENTASToolStripMenuItem, Me.REPORTESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(15, 16, 4, 16)
        Me.MenuStrip1.Size = New System.Drawing.Size(958, 59)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACERCADEToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InicioToolStripMenuItem.Image = CType(resources.GetObject("InicioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 100, 0)
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(230, 27)
        Me.InicioToolStripMenuItem.Text = "INICIO"
        '
        'ACERCADEToolStripMenuItem
        '
        Me.ACERCADEToolStripMenuItem.Image = CType(resources.GetObject("ACERCADEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ACERCADEToolStripMenuItem.Name = "ACERCADEToolStripMenuItem"
        Me.ACERCADEToolStripMenuItem.Size = New System.Drawing.Size(192, 28)
        Me.ACERCADEToolStripMenuItem.Text = "Acerca De"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(192, 28)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MANTENIMIENTOToolStripMenuItem
        '
        Me.MANTENIMIENTOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.TrabajadorToolStripMenuItem, Me.VehiculoToolStripMenuItem, Me.ServicioToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.DescuentosToolStripMenuItem})
        Me.MANTENIMIENTOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.TrabajadorToolStripMenuItem, Me.VehiculoToolStripMenuItem, Me.ServicioToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.RolToolStripMenuItem})
        Me.MANTENIMIENTOToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MANTENIMIENTOToolStripMenuItem.Image = CType(resources.GetObject("MANTENIMIENTOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MANTENIMIENTOToolStripMenuItem.Name = "MANTENIMIENTOToolStripMenuItem"
        Me.MANTENIMIENTOToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5, 0, 100, 0)
        Me.MANTENIMIENTOToolStripMenuItem.Size = New System.Drawing.Size(326, 27)
        Me.MANTENIMIENTOToolStripMenuItem.Text = "MANTENIMIENTO"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Image = CType(resources.GetObject("ClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'TrabajadorToolStripMenuItem
        '
        Me.TrabajadorToolStripMenuItem.Image = CType(resources.GetObject("TrabajadorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrabajadorToolStripMenuItem.Name = "TrabajadorToolStripMenuItem"
        Me.TrabajadorToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.TrabajadorToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.TrabajadorToolStripMenuItem.Text = "Trabajador"
        '
        'VehiculoToolStripMenuItem
        '
        Me.VehiculoToolStripMenuItem.Image = CType(resources.GetObject("VehiculoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VehiculoToolStripMenuItem.Name = "VehiculoToolStripMenuItem"
        Me.VehiculoToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.VehiculoToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.VehiculoToolStripMenuItem.Text = "Vehiculo"
        '
        'ServicioToolStripMenuItem
        '
        Me.ServicioToolStripMenuItem.Image = CType(resources.GetObject("ServicioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServicioToolStripMenuItem.Name = "ServicioToolStripMenuItem"
        Me.ServicioToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.ServicioToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.ServicioToolStripMenuItem.Text = "Servicio"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Image = CType(resources.GetObject("ProductoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Image = CType(resources.GetObject("UsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Image = CType(resources.GetObject("UsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'CITASVENTASToolStripMenuItem
        '
        Me.CITASVENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarCitasToolStripMenuItem, Me.RegistrarVentasToolStripMenuItem})
        Me.CITASVENTASToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CITASVENTASToolStripMenuItem.Image = CType(resources.GetObject("CITASVENTASToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CITASVENTASToolStripMenuItem.Name = "CITASVENTASToolStripMenuItem"
        Me.CITASVENTASToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5, 0, 100, 0)
        Me.CITASVENTASToolStripMenuItem.Size = New System.Drawing.Size(304, 27)
        Me.CITASVENTASToolStripMenuItem.Text = "CITAS/VENTAS"
        '
        'RegistrarCitasToolStripMenuItem
        '
        Me.RegistrarCitasToolStripMenuItem.Image = CType(resources.GetObject("RegistrarCitasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrarCitasToolStripMenuItem.Name = "RegistrarCitasToolStripMenuItem"
        Me.RegistrarCitasToolStripMenuItem.Size = New System.Drawing.Size(265, 28)
        Me.RegistrarCitasToolStripMenuItem.Text = "Registrar Citas"
        '
        'RegistrarVentasToolStripMenuItem
        '
        Me.RegistrarVentasToolStripMenuItem.Image = CType(resources.GetObject("RegistrarVentasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrarVentasToolStripMenuItem.Name = "RegistrarVentasToolStripMenuItem"
        Me.RegistrarVentasToolStripMenuItem.Size = New System.Drawing.Size(265, 28)
        Me.RegistrarVentasToolStripMenuItem.Text = "Registrar Ventas"
        '
        'REPORTESToolStripMenuItem
        '
        Me.REPORTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem1})
        Me.REPORTESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.REPORTESToolStripMenuItem.Image = CType(resources.GetObject("REPORTESToolStripMenuItem.Image"), System.Drawing.Image)
        Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        Me.REPORTESToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5, 0, 100, 0)
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(252, 27)
        Me.REPORTESToolStripMenuItem.Text = "REPORTES"
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.Image = CType(resources.GetObject("ReportesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(180, 28)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 59)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(958, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'DescuentosToolStripMenuItem
        'RolToolStripMenuItem
        '
        Me.DescuentosToolStripMenuItem.Image = CType(resources.GetObject("DescuentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DescuentosToolStripMenuItem.Name = "DescuentosToolStripMenuItem"
        Me.DescuentosToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.DescuentosToolStripMenuItem.Text = "Descuentos"
        Me.RolToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.rol
        Me.RolToolStripMenuItem.Name = "RolToolStripMenuItem"
        Me.RolToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.RolToolStripMenuItem.Text = "Rol"
        '
        'FrmMenuPrincipalModificado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 366)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMenuPrincipalModificado"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACERCADEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MANTENIMIENTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CITASVENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarCitasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescuentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolToolStripMenuItem As ToolStripMenuItem
End Class
