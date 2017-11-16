Public Class Cliente
    Private _id As UInteger
    Private _lineas As List(Of Linea)
    Public Property Id As UInteger
        Set(value As UInteger)
            _id = value
        End Set
        Get
            Return _id
        End Get
    End Property
    Sub New()
        _id = 0
        _lineas = New List(Of Linea)
    End Sub
    Public Sub addLinea(Linea As Linea)
        Linea.Cliente = Me
        _lineas.Add(Linea)
    End Sub
    Public Sub removeLinea(Linea As Linea)
        Linea.Cliente = Nothing
        _lineas.Remove(Linea)
    End Sub
    Public Function getAllLineas() As List(Of Linea)
        Return _lineas
    End Function
End Class
