<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jdMantenimientoServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jdMantenimientoServicio))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboOrdenar = New System.Windows.Forms.ComboBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBuscarServicios = New System.Windows.Forms.TextBox()
        Me.cboTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tblServicios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.tblServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(763, -4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 702)
        Me.Panel3.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 40)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Mantenimiento de Servicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(790, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Ordenar por:"
        '
        'cboOrdenar
        '
        Me.cboOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrdenar.FormattingEnabled = True
        Me.cboOrdenar.Location = New System.Drawing.Point(793, 132)
        Me.cboOrdenar.Name = "cboOrdenar"
        Me.cboOrdenar.Size = New System.Drawing.Size(207, 24)
        Me.cboOrdenar.TabIndex = 35
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnListar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.Location = New System.Drawing.Point(807, 170)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(182, 40)
        Me.btnListar.TabIndex = 36
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(793, 311)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(207, 66)
        Me.btnNuevo.TabIndex = 37
        Me.btnNuevo.Text = "Nuevo Servicio"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(793, 399)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(207, 65)
        Me.btnEditar.TabIndex = 38
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(793, 494)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(207, 65)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Buscar por codigo o tipo de vehículo:"
        '
        'txtBuscarServicios
        '
        Me.txtBuscarServicios.Location = New System.Drawing.Point(31, 188)
        Me.txtBuscarServicios.Name = "txtBuscarServicios"
        Me.txtBuscarServicios.Size = New System.Drawing.Size(383, 22)
        Me.txtBuscarServicios.TabIndex = 41
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoVehiculo.FormattingEnabled = True
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(461, 186)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(177, 24)
        Me.cboTipoVehiculo.TabIndex = 42
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(658, 177)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(44, 44)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tblServicios
        '
        Me.tblServicios.AllowUserToAddRows = False
        Me.tblServicios.AllowUserToDeleteRows = False
        Me.tblServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblServicios.Location = New System.Drawing.Point(31, 231)
        Me.tblServicios.Name = "tblServicios"
        Me.tblServicios.ReadOnly = True
        Me.tblServicios.RowHeadersVisible = False
        Me.tblServicios.RowHeadersWidth = 51
        Me.tblServicios.RowTemplate.Height = 24
        Me.tblServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblServicios.Size = New System.Drawing.Size(712, 396)
        Me.tblServicios.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 80)
        Me.Panel1.TabIndex = 45
        '
        'jdMantenimientoServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tblServicios)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cboTipoVehiculo)
        Me.Controls.Add(Me.txtBuscarServicios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.cboOrdenar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "jdMantenimientoServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jdMantenimientoServicio"
        CType(Me.tblServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboOrdenar As ComboBox
    Friend WithEvents btnListar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBuscarServicios As TextBox
    Friend WithEvents cboTipoVehiculo As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tblServicios As DataGridView
    Friend WithEvents Panel1 As Panel
End Class
