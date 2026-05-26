<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jdMantenimientoVehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jdMantenimientoVehiculo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuscador = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGestionarPersona = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tblVehiculo = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.tblVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenimiento Vehiculo"
        '
        'txtbuscador
        '
        Me.txtbuscador.Location = New System.Drawing.Point(73, 131)
        Me.txtbuscador.Name = "txtbuscador"
        Me.txtbuscador.Size = New System.Drawing.Size(288, 22)
        Me.txtbuscador.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(367, 117)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(211, 55)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar por placa"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGestionarPersona
        '
        Me.btnGestionarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionarPersona.Image = CType(resources.GetObject("btnGestionarPersona.Image"), System.Drawing.Image)
        Me.btnGestionarPersona.Location = New System.Drawing.Point(751, 117)
        Me.btnGestionarPersona.Name = "btnGestionarPersona"
        Me.btnGestionarPersona.Size = New System.Drawing.Size(224, 55)
        Me.btnGestionarPersona.TabIndex = 3
        Me.btnGestionarPersona.Text = "Administrar Vehiculo"
        Me.btnGestionarPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGestionarPersona.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tblVehiculo)
        Me.Panel1.Location = New System.Drawing.Point(73, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 404)
        Me.Panel1.TabIndex = 4
        '
        'tblVehiculo
        '
        Me.tblVehiculo.AllowUserToAddRows = False
        Me.tblVehiculo.AllowUserToDeleteRows = False
        Me.tblVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblVehiculo.Location = New System.Drawing.Point(19, 20)
        Me.tblVehiculo.Name = "tblVehiculo"
        Me.tblVehiculo.ReadOnly = True
        Me.tblVehiculo.RowHeadersVisible = False
        Me.tblVehiculo.RowHeadersWidth = 51
        Me.tblVehiculo.RowTemplate.Height = 24
        Me.tblVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblVehiculo.Size = New System.Drawing.Size(865, 370)
        Me.tblVehiculo.TabIndex = 1
        '
        'jdMantenimientoVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 662)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGestionarPersona)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtbuscador)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "jdMantenimientoVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jdMantenimientoVehiculo"
        Me.Panel1.ResumeLayout(False)
        CType(Me.tblVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtbuscador As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGestionarPersona As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tblVehiculo As DataGridView
End Class
