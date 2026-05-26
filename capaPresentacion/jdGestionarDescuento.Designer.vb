<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jdGestionarDescuento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jdGestionarDescuento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscarCodigo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboAplicaA = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboTipoDescuento = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvDescuentos = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnDarDeBaja = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gestionar Descuento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar por código:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBuscarCodigo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtBuscador)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(28, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 115)
        Me.Panel1.TabIndex = 3
        '
        'btnBuscarCodigo
        '
        Me.btnBuscarCodigo.Image = CType(resources.GetObject("btnBuscarCodigo.Image"), System.Drawing.Image)
        Me.btnBuscarCodigo.Location = New System.Drawing.Point(169, 41)
        Me.btnBuscarCodigo.Name = "btnBuscarCodigo"
        Me.btnBuscarCodigo.Size = New System.Drawing.Size(60, 40)
        Me.btnBuscarCodigo.TabIndex = 5
        Me.btnBuscarCodigo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(4, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingresa el código exacto del descuento"
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(7, 50)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(156, 22)
        Me.txtBuscador.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = ""
        Me.Panel2.Controls.Add(Me.chkActivo)
        Me.Panel2.Controls.Add(Me.dtpFechaFin)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.dtpFechaInicio)
        Me.Panel2.Controls.Add(Me.cboAplicaA)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cboTipoDescuento)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtValor)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtCodigo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(28, 231)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 551)
        Me.Panel2.TabIndex = 4
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(18, 511)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(87, 26)
        Me.chkActivo.TabIndex = 19
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(159, 469)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(135, 22)
        Me.dtpFechaFin.TabIndex = 18
        Me.dtpFechaFin.Value = New Date(2026, 5, 25, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 469)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 22)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Fecha Fin:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 430)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 22)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Fecha Inicio:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(159, 430)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(133, 22)
        Me.dtpFechaInicio.TabIndex = 15
        Me.dtpFechaInicio.Value = New Date(2026, 5, 25, 0, 0, 0, 0)
        '
        'cboAplicaA
        '
        Me.cboAplicaA.FormattingEnabled = True
        Me.cboAplicaA.Location = New System.Drawing.Point(105, 138)
        Me.cboAplicaA.Name = "cboAplicaA"
        Me.cboAplicaA.Size = New System.Drawing.Size(148, 24)
        Me.cboAplicaA.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Aplica a:"
        '
        'cboTipoDescuento
        '
        Me.cboTipoDescuento.FormattingEnabled = True
        Me.cboTipoDescuento.Location = New System.Drawing.Point(188, 373)
        Me.cboTipoDescuento.Name = "cboTipoDescuento"
        Me.cboTipoDescuento.Size = New System.Drawing.Size(131, 24)
        Me.cboTipoDescuento.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 22)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Tipo descuento:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(83, 320)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(160, 22)
        Me.txtValor.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 22)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Valor:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 202)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(281, 81)
        Me.txtDescripcion.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Descripción:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(105, 82)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(148, 22)
        Me.txtCodigo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Código:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(49, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(70, 22)
        Me.txtID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(190, 25)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Datos del descuento"
        '
        'dgvDescuentos
        '
        Me.dgvDescuentos.AllowUserToAddRows = False
        Me.dgvDescuentos.AllowUserToDeleteRows = False
        Me.dgvDescuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDescuentos.Location = New System.Drawing.Point(372, 99)
        Me.dgvDescuentos.Name = "dgvDescuentos"
        Me.dgvDescuentos.ReadOnly = True
        Me.dgvDescuentos.RowHeadersVisible = False
        Me.dgvDescuentos.RowHeadersWidth = 51
        Me.dgvDescuentos.RowTemplate.Height = 24
        Me.dgvDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDescuentos.Size = New System.Drawing.Size(753, 510)
        Me.dgvDescuentos.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(368, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(189, 22)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Lista de descuentos"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(15, 27)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(170, 68)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(200, 27)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(186, 68)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(406, 27)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(159, 68)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnDarDeBaja
        '
        Me.btnDarDeBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarDeBaja.Image = CType(resources.GetObject("btnDarDeBaja.Image"), System.Drawing.Image)
        Me.btnDarDeBaja.Location = New System.Drawing.Point(580, 27)
        Me.btnDarDeBaja.Name = "btnDarDeBaja"
        Me.btnDarDeBaja.Size = New System.Drawing.Size(159, 68)
        Me.btnDarDeBaja.TabIndex = 11
        Me.btnDarDeBaja.Text = "Dar de baja"
        Me.btnDarDeBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDarDeBaja.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnLimpiar)
        Me.Panel3.Controls.Add(Me.btnDarDeBaja)
        Me.Panel3.Controls.Add(Me.btnNuevo)
        Me.Panel3.Controls.Add(Me.btnModificar)
        Me.Panel3.Location = New System.Drawing.Point(372, 637)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(753, 145)
        Me.Panel3.TabIndex = 12
        '
        'jdGestionarDescuento
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 807)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgvDescuentos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "jdGestionarDescuento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jdGestionarDescuento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents cboAplicaA As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboTipoDescuento As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvDescuentos As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnDarDeBaja As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBuscarCodigo As Button
End Class
