<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jdMantenimientoCitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jdMantenimientoCitas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnNuevaCita = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGestion = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvGestion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbEstado)
        Me.Panel1.Controls.Add(Me.btnListar)
        Me.Panel1.Controls.Add(Me.btnNuevaCita)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 762)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(890, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 21)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Listar Por Estado:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Pendiente", "En Proceso", "Realizado"})
        Me.cmbEstado.Location = New System.Drawing.Point(893, 182)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(267, 24)
        Me.cmbEstado.TabIndex = 76
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnListar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.Color.White
        Me.btnListar.Location = New System.Drawing.Point(1181, 174)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(142, 37)
        Me.btnListar.TabIndex = 75
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'btnNuevaCita
        '
        Me.btnNuevaCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNuevaCita.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaCita.ForeColor = System.Drawing.Color.White
        Me.btnNuevaCita.Location = New System.Drawing.Point(1181, 84)
        Me.btnNuevaCita.Name = "btnNuevaCita"
        Me.btnNuevaCita.Size = New System.Drawing.Size(142, 37)
        Me.btnNuevaCita.TabIndex = 74
        Me.btnNuevaCita.Text = "Nueva Cita"
        Me.btnNuevaCita.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(36, 174)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(433, 37)
        Me.txtID.TabIndex = 72
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(491, 174)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(142, 37)
        Me.btnBuscar.TabIndex = 71
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(33, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Buscar Por Código (ID):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Administra las citas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mantenimiento de Citas"
        '
        'dgvGestion
        '
        Me.dgvGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGestion.Location = New System.Drawing.Point(14, 227)
        Me.dgvGestion.Name = "dgvGestion"
        Me.dgvGestion.RowHeadersWidth = 51
        Me.dgvGestion.RowTemplate.Height = 24
        Me.dgvGestion.Size = New System.Drawing.Size(1309, 506)
        Me.dgvGestion.TabIndex = 78
        '
        'jdMantenimientoCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1374, 786)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "jdMantenimientoCitas"
        Me.Text = ".: MANTENIMIENTO CITAS :."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents btnListar As Button
    Friend WithEvents btnNuevaCita As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents dgvGestion As DataGridView
End Class
