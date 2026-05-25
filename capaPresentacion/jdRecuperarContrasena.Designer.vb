<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jdRecuperarContrasena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jdRecuperarContrasena))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fake = New System.Windows.Forms.Label()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCaptcha = New System.Windows.Forms.Label()
        Me.txtRptaCaptcha = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.psdNvaContrasena = New System.Windows.Forms.TextBox()
        Me.psdConfirmNvaContrasena = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnRecargarCaptcha = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(627, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECUPERAR CONTRASEÑA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(492, 209)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(591, 62)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Para mayor seguridad responda la siguiente pregunta y escriba el código captcha, " &
    "luego haga clic en confirmar."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(44, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(613, 11)
        Me.Label3.TabIndex = 3
        '
        'fake
        '
        Me.fake.AutoSize = True
        Me.fake.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fake.Location = New System.Drawing.Point(42, 181)
        Me.fake.Name = "fake"
        Me.fake.Size = New System.Drawing.Size(78, 16)
        Me.fake.TabIndex = 4
        Me.fake.Text = "Pregunta:"
        '
        'lblPregunta
        '
        Me.lblPregunta.Location = New System.Drawing.Point(148, 181)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(335, 61)
        Me.lblPregunta.TabIndex = 5
        Me.lblPregunta.Text = "¿Nombre de tu primer perro?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Respuesta:"
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(151, 245)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(332, 22)
        Me.txtRespuesta.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Captcha:"
        '
        'lblCaptcha
        '
        Me.lblCaptcha.BackColor = System.Drawing.Color.LightGray
        Me.lblCaptcha.Location = New System.Drawing.Point(148, 289)
        Me.lblCaptcha.Name = "lblCaptcha"
        Me.lblCaptcha.Size = New System.Drawing.Size(175, 36)
        Me.lblCaptcha.TabIndex = 2
        '
        'txtRptaCaptcha
        '
        Me.txtRptaCaptcha.Location = New System.Drawing.Point(151, 350)
        Me.txtRptaCaptcha.Name = "txtRptaCaptcha"
        Me.txtRptaCaptcha.Size = New System.Drawing.Size(215, 22)
        Me.txtRptaCaptcha.TabIndex = 4
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConfirmar.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.White
        Me.btnConfirmar.Location = New System.Drawing.Point(243, 402)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(164, 34)
        Me.btnConfirmar.TabIndex = 5
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(40, 458)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(613, 11)
        Me.Label9.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 500)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Nueva Contraseña:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 537)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Confirmar Contraseña:"
        '
        'psdNvaContrasena
        '
        Me.psdNvaContrasena.Location = New System.Drawing.Point(243, 500)
        Me.psdNvaContrasena.Name = "psdNvaContrasena"
        Me.psdNvaContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.psdNvaContrasena.Size = New System.Drawing.Size(331, 22)
        Me.psdNvaContrasena.TabIndex = 6
        '
        'psdConfirmNvaContrasena
        '
        Me.psdConfirmNvaContrasena.Location = New System.Drawing.Point(243, 537)
        Me.psdConfirmNvaContrasena.Name = "psdConfirmNvaContrasena"
        Me.psdConfirmNvaContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.psdConfirmNvaContrasena.Size = New System.Drawing.Size(331, 22)
        Me.psdConfirmNvaContrasena.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(243, 603)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(164, 44)
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnRecargarCaptcha
        '
        Me.btnRecargarCaptcha.BackgroundImage = CType(resources.GetObject("btnRecargarCaptcha.BackgroundImage"), System.Drawing.Image)
        Me.btnRecargarCaptcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRecargarCaptcha.Location = New System.Drawing.Point(332, 289)
        Me.btnRecargarCaptcha.Name = "btnRecargarCaptcha"
        Me.btnRecargarCaptcha.Size = New System.Drawing.Size(75, 45)
        Me.btnRecargarCaptcha.TabIndex = 3
        Me.btnRecargarCaptcha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecargarCaptcha.UseVisualStyleBackColor = True
        '
        'jdRecuperarContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(721, 698)
        Me.Controls.Add(Me.btnRecargarCaptcha)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.psdConfirmNvaContrasena)
        Me.Controls.Add(Me.psdNvaContrasena)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtRptaCaptcha)
        Me.Controls.Add(Me.lblCaptcha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.fake)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "jdRecuperarContrasena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Contraseña"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fake As Label
    Friend WithEvents lblPregunta As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCaptcha As Label
    Friend WithEvents txtRptaCaptcha As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents psdNvaContrasena As TextBox
    Friend WithEvents psdConfirmNvaContrasena As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnRecargarCaptcha As Button
End Class
