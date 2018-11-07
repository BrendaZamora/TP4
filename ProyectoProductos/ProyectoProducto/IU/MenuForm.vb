Public Class MenuForm
    Private Sub ArticulosButton_Click(sender As Object, e As EventArgs) Handles ArticulosButton.Click

        ToolStrip1.Enabled = False

        Dim gridArticulos As New ArticulosGrid

        gridArticulos.MdiParent = Me

        gridArticulos.Show()
    End Sub

    Private Sub RubrosButton_Click(sender As Object, e As EventArgs) Handles RubrosButton.Click

        ToolStrip1.Enabled = False

        Dim gridRubros As New RubrosGrid

        gridRubros.MdiParent = Me

        gridRubros.Show()
    End Sub

    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles SalirButton.Click
        End
    End Sub
End Class