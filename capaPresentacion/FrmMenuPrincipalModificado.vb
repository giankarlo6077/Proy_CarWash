Public Class FrmMenuPrincipalModificado
    Private Sub ACERCADEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACERCADEToolStripMenuItem.Click
        Dim obj As New jdAcercaDe()
        obj.StartPosition = FormStartPosition.CenterParent
        obj.ShowDialog(Me)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub REPORTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTESToolStripMenuItem.Click

    End Sub

    Private Sub FrmMenuPrincipalModificado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New MiTemaMenu())
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim obj As New JdMantenimientoProducto()
        obj.StartPosition = FormStartPosition.CenterParent
        obj.ShowDialog(Me)
    End Sub

    Public Class MiTemaMenu
        Inherits ProfessionalColorTable

        ' 1. Cambia el color de fondo cuando el menú está desplegado (presionado)
        Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
            Get
                Return Color.FromArgb(10, 20, 50)
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientMiddle As Color
            Get
                Return Color.FromArgb(10, 20, 50)
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
            Get
                Return Color.FromArgb(10, 20, 50)
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemBorder As Color
            Get
                Return Color.Transparent
            End Get
        End Property

    End Class

    Private Sub VehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculoToolStripMenuItem.Click
        Dim frmVehiculo As New jdMantenimientoVehiculo()
        frmVehiculo.ShowDialog()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Dim frmGestionarUsuario As New jdGestionarUsuario()
        frmGestionarUsuario.ShowDialog()
    End Sub
End Class