Public Class RubrosGrid

    Private Sub RubrosGrid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        RubroForm.operacion = "Agregar"
        RubroForm.Text = "Agregar"
        RubroForm.Show()

    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click

        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        RubroForm.operacion = "Modificar"
        RubroForm.Text = "Modificar"
        RubroForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        RubroForm.Show()

        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = False
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click

        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        RubroForm.operacion = "Eliminar"
        RubroForm.Text = "Eliminar"
        RubroForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        RubroForm.Show()


    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click

        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub

    Private Sub llenarform()

        Dim fila As Integer = DataGridView1.CurrentRow.Index

        RubroForm.IdTextBox.Text = rubrosList.Item(fila).Id
        RubroForm.Descrip.Text = rubrosList.Item(fila).Descripcion

    End Sub

    Private Sub RubrosGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        RubrosCollectionBindingSource.DataSource = rubrosList.TraerRubros
        'DataGridView1.DataSource = carrerasList.traerCarreras

        'Si la cantidad de filas es mayor a cero, entonces selecciono la primer fila.
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

    End Sub
End Class