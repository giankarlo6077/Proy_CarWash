Imports capaNegocio

Public Class jdGestionarDescuento
    Dim objDescuento As New clsDescuento()
    Dim objTipoDescuento As New clsTipoDescuento()
    Private idDescuentoSeleccionado As Integer = -1

    Private Sub jdGestionarDescuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComboTipo() : CargarComboAplicaA() : Listar() : txtID.ReadOnly = True
    End Sub

    Private Sub CargarComboTipo()
        cboTipoDescuento.DataSource = objTipoDescuento.listar()
        cboTipoDescuento.DisplayMember = "tipoDescuento"
        cboTipoDescuento.ValueMember = "idTipoDescuento"
    End Sub

    Private Sub CargarComboAplicaA()
        cboAplicaA.Items.AddRange({"Producto", "Servicio", "Ambos"})
        cboAplicaA.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Listar()
        dgvDescuentos.DataSource = objDescuento.listar()
    End Sub

    Private Sub Limpiar()
        txtID.Clear() : txtCodigo.Clear() : txtDescripcion.Clear() : txtValor.Clear()
        cboTipoDescuento.SelectedIndex = -1 : cboAplicaA.SelectedIndex = -1
        dtpFechaInicio.Value = DateTime.Now : dtpFechaFin.Value = DateTime.Now
        chkActivo.Checked = False : idDescuentoSeleccionado = -1 : btnNuevo.Text = "Nuevo"
    End Sub

    Private Sub CargarDatosFila(row As DataGridViewRow)
        idDescuentoSeleccionado = Convert.ToInt32(row.Cells("ID").Value)
        txtID.Text = idDescuentoSeleccionado.ToString()
        txtCodigo.Text = row.Cells("Codigo").Value.ToString()
        txtDescripcion.Text = row.Cells("Descripcion").Value.ToString()
        txtValor.Text = row.Cells("Valor").Value.ToString()
        cboTipoDescuento.Text = row.Cells("Tipo de descuento").Value.ToString()
        cboAplicaA.Text = row.Cells("Aplica a").Value.ToString()
        dtpFechaInicio.Value = Convert.ToDateTime(row.Cells("Fecha inicio").Value)
        dtpFechaFin.Value = Convert.ToDateTime(row.Cells("Fecha fin").Value)
        chkActivo.Checked = Convert.ToBoolean(row.Cells("estado").Value)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then
            Limpiar()
            idDescuentoSeleccionado = objDescuento.obtenerNuevoID()
            txtID.Text = idDescuentoSeleccionado.ToString()
            btnNuevo.Text = "Guardar"
        Else
            Try
                Dim v As Decimal = Convert.ToDecimal(txtValor.Text)
                objDescuento.registrar(idDescuentoSeleccionado, txtCodigo.Text, txtDescripcion.Text, v, Convert.ToInt32(cboTipoDescuento.SelectedValue), cboAplicaA.Text, dtpFechaInicio.Value, dtpFechaFin.Value, chkActivo.Checked)
                MessageBox.Show("Guardado con éxito")
                Limpiar() : Listar()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objDescuento.modificar(idDescuentoSeleccionado, txtCodigo.Text, txtDescripcion.Text, Convert.ToDecimal(txtValor.Text), Convert.ToInt32(cboTipoDescuento.SelectedValue), cboAplicaA.Text, dtpFechaInicio.Value, dtpFechaFin.Value, chkActivo.Checked)
            MessageBox.Show("Modificado") : Listar() : Limpiar()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        objDescuento.darDeBaja(idDescuentoSeleccionado) : Listar() : Limpiar()
    End Sub

    Private Sub btnBuscarCodigo_Click(sender As Object, e As EventArgs) Handles btnBuscarCodigo.Click
        For Each row As DataGridViewRow In dgvDescuentos.Rows
            If row.Cells("Codigo").Value.ToString() = txtBuscador.Text.Trim() Then
                CargarDatosFila(row) : Exit Sub
            End If
        Next
    End Sub

    Private Sub dgvDescuentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescuentos.CellClick
        If e.RowIndex >= 0 Then CargarDatosFila(dgvDescuentos.Rows(e.RowIndex))
    End Sub


End Class