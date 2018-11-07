Imports System.ComponentModel
Imports System.Text

Public Class ArticulosCollection
    Inherits BindingList(Of ArticuloClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)
        e.NewObject = New ArticuloClass

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each carrera In Me
            If prop.GetValue(carrera).Equals(key) Then
                Return Me.IndexOf(carrera)
            End If
        Next

        Return -1
    End Function

    Public Function TraerArticulos() As ArticulosCollection

        If Me.Items.Count > 0 Then Me.ClearItems()

        'crea la intancia de base de datos
        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiArticulo As ArticuloClass

        ObjBaseDatos.objTabla = "Articulo"
        'devuelve los datos de la base de dato
        MiDataTable = ObjBaseDatos.TraerTodo
        'por cada dr (fila)llena cada fecha

        For Each dr As DataRow In MiDataTable.Rows
            'crea la instancia por cada campo
            MiArticulo = New ArticuloClass

            MiArticulo.Id = CInt(dr("Id"))
            MiArticulo.Descripcion = dr("Descripcion")
            MiArticulo.IdRubros = CInt(dr("IdRubros"))

            Me.Add(MiArticulo)

        Next

        Return Me

    End Function

    Public Sub InsertarArticulo(ByVal MiArticulo As ArticuloClass)

        Dim ObjBasedeDato As New BaseDatosClass
        'busca la tabla personas 
        ObjBasedeDato.objTabla = "Articulos"

        Dim vsql As New StringBuilder
        vsql.Append("(Descripcion")
        vsql.Append(",IdRubros)")

        vsql.Append(" VALUES ")

        vsql.Append("('" & MiArticulo.Descripcion & "'")
        vsql.Append(",'" & MiArticulo.IdRubros & "')")

        MiArticulo.Id = ObjBasedeDato.Insertar(vsql.ToString)

        'Evalúa el resultado del comando SQL.
        If MiArticulo.Id = 0 Then
            MsgBox("No fue posible agregar el Articulo ")
            Exit Sub
        End If

        Me.Add(MiArticulo)

    End Sub

    Public Sub EliminarArticulo(ByVal MiArticulo As RubroClass)

        ' Instancio en el objeto BaseDatosClass para accede a la base Fechas
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Articulos"

        For Each articulo In articulosList

            'ejecuta el método base eliminar 
            Dim resultado As Boolean

            resultado = objBaseDatos.Eliminar(articulo.Id)

            If Not resultado Then
                MessageBox.Show("No fue posible eliminar el articulo ")


                Exit Sub
            End If

        Next

        Me.ClearItems()

    End Sub

    Public Sub ActualizarArticulo(ByVal MiArticulo As ArticuloClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Articulo"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("Id='" & MiPersona.Id.ToString & "'")
        vSQL.Append("(Descripcion='" & MiArticulo.Descripcion & "'")
        vSQL.Append(",IdRubros='" & MiArticulo.IdRubros & "')")

        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiArticulo.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el Articulo ")
            Exit Sub
        End If

        'El código a continuación sirve para localizar el ítem en la lista
        'en este caso un Rubro.
        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiArticulo)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Me.Items.Item(Me.FindCore(myProperty, MiArticulo.Id)) = MiArticulo

    End Sub
End Class
