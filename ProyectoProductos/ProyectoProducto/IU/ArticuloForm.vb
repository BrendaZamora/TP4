Public Class ArticuloForm

    Dim operacion_ As String
    Dim MiArticulo As New ArticuloClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Dim rubrocombo_ As Integer


    Public Property rubrocombo() As Integer
        Get
            Return rubrocombo_
        End Get
        Set(ByVal value As Integer)
            rubrocombo_ = value
        End Set
    End Property


    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        If operacion <> "Agregar" Then
            MiArticulo.Id = CInt(IdTextBox1.Text)
        End If

        MiArticulo.Descripcion = Descripcion.Text
        MiArticulo.IdRubro = IdRubrosComboBox.SelectedIndex

        Select Case operacion_
            Case "Agregar"
                articulosList.Add(MiArticulo)

            Case "Eliminar"
                articulosList.RemoveAt(indice_)

            Case "Modificar"
                articulosList.Item(indice_) = MiArticulo

        End Select
        Me.Close()

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ArticuloForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Fuente de datos fechasList
        IdRubrosComboBox.DataSource = rubrosList
        'Miembro para mostrar de fecha
        IdRubrosComboBox.DisplayMember = "Fecha"
        'Miembro de valor de fecha
        IdRubrosComboBox.ValueMember = "Id"
        'Selecciona un valor del combobox
        IdRubrosComboBox.SelectedValue = rubrocombo

    End Sub
End Class
