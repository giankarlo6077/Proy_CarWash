<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jdHistorialMantenimiento
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tblHistorialMantenimientos = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtDocumento)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(858, 137)
        Me.Panel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(22, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(799, 3)
        Me.Label14.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 30)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Buscar Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(162, 83)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(281, 22)
        Me.txtDocumento.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 21)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "N° DOCUMENTO:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(647, 75)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(174, 37)
        Me.btnBuscar.TabIndex = 83
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'tblHistorialMantenimientos
        '
        Me.tblHistorialMantenimientos.ColumnCount = 2
        Me.tblHistorialMantenimientos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblHistorialMantenimientos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblHistorialMantenimientos.Location = New System.Drawing.Point(12, 244)
        Me.tblHistorialMantenimientos.Name = "tblHistorialMantenimientos"
        Me.tblHistorialMantenimientos.RowCount = 2
        Me.tblHistorialMantenimientos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblHistorialMantenimientos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHistorialMantenimientos.Size = New System.Drawing.Size(858, 354)
        Me.tblHistorialMantenimientos.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(799, 3)
        Me.Label1.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 30)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Historial de Mantenimientos:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'jdHistorialMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 610)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tblHistorialMantenimientos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "jdHistorialMantenimiento"
        Me.Text = "jdHistorialMantenimiento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tblHistorialMantenimientos As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
