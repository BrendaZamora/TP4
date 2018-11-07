Public Class ArticulosGrid


    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        ArticuloForm.operacion = "Agregar"
        ArticuloForm.Text = "Agregar"
        ArticuloForm.Show()
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        ArticuloForm.operacion = "Modificar"
        ArticuloForm.Text = "Modificar"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ArticuloForm.Show()

        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = False
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        ArticuloForm.operacion = "Eliminar"
        ArticuloForm.Text = "Eliminar"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ArticuloForm.Show()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()
    End Sub

    Private Sub llenarform()
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        ArticuloForm.IdTextBox1.Text = articulosList.Item(fila).Id
        ArticuloForm.Descripcion.Text = articulosList.Item(fila).Descripcion
        ArticuloForm.IdRubrosComboBox.Text = articulosList.Item(fila).IdRubros
    End Sub

    Private Sub ArticulosGrid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()
    End Sub

    Private Sub ArticulosGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ArticulosCollectionBindingSource.DataSource = articulosList.TraerArticulos

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

        IdRubros.ComboBox.DataSource = rubrosList.TraerRubros

        IdRubros.ComboBox.DisplayMember = "Descripcion"

        IdRubros.ComboBox.ValueMember = "Id"

        IdRubros.ComboBox.SelectedValue = 1
    End Sub

    Private Sub Filtro_Click(sender As Object, e As EventArgs) Handles Filtro.Click

        ArticulosCollectionBindingSource.DataSource = articulosList.TraerArticulos(IdRubros.ComboBox.SelectedValue)
    End Sub
End Class