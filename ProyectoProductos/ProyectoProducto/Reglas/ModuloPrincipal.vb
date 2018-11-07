Option Strict On
Option Explicit Off

Module ModuloPrincipal

    Public articulosList As New ArticulosCollection
    Public rubrosList As New RubrosCollection

    Public Sub main()

        Application.Run(MenuForm)

    End Sub

End Module
