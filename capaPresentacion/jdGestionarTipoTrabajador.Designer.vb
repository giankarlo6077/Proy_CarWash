<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jdGestionarTipoTrabajador
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipoTrabajador = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tblDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnDarDeBaja = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(452, 42)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Gestionar Tipo Trabajador"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(42, 141)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(116, 22)
        Me.txtCodigo.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Tipo de trabajador"
        '
        'txtTipoTrabajador
        '
        Me.txtTipoTrabajador.Location = New System.Drawing.Point(42, 217)
        Me.txtTipoTrabajador.Name = "txtTipoTrabajador"
        Me.txtTipoTrabajador.Size = New System.Drawing.Size(223, 22)
        Me.txtTipoTrabajador.TabIndex = 52
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(322, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(2, 150)
        Me.Label20.TabIndex = 53
        '
        'tblDatos
        '
        Me.tblDatos.ColumnCount = 2
        Me.tblDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblDatos.Location = New System.Drawing.Point(42, 288)
        Me.tblDatos.Name = "tblDatos"
        Me.tblDatos.RowCount = 2
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatos.Size = New System.Drawing.Size(587, 231)
        Me.tblDatos.TabIndex = 57
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegistrar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(380, 134)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(98, 37)
        Me.btnRegistrar.TabIndex = 71
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnDarDeBaja
        '
        Me.btnDarDeBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDarDeBaja.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarDeBaja.ForeColor = System.Drawing.Color.White
        Me.btnDarDeBaja.Location = New System.Drawing.Point(496, 134)
        Me.btnDarDeBaja.Name = "btnDarDeBaja"
        Me.btnDarDeBaja.Size = New System.Drawing.Size(118, 37)
        Me.btnDarDeBaja.TabIndex = 71
        Me.btnDarDeBaja.Text = "Dar de baja"
        Me.btnDarDeBaja.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(437, 202)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 37)
        Me.btnCancelar.TabIndex = 71
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'jdGestionarTipoTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 545)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnDarDeBaja)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.tblDatos)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtTipoTrabajador)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Name = "jdGestionarTipoTrabajador"
        Me.Text = "jdGestionarTipoTrabajador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTipoTrabajador As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tblDatos As TableLayoutPanel
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnDarDeBaja As Button
    Friend WithEvents btnCancelar As Button
End Class
