Public Class Paquete
    Implements Servicio
    Private _nombre As String
    Private _precio As Single
    Private _planes As List(Of Plan)
    Public Property nombre As String Implements Servicio.nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value = "" Then Throw New Exception("No ingresaste nada")
            If value.Length > 50 Then Throw New Exception("Cadena de texto demasiado larga")
            _nombre = value
        End Set
    End Property

    Public Property precio As Single Implements Servicio.precio
        Get
            Return _precio
        End Get
        Set(value As Single)
            _precio = value
        End Set
    End Property
    Public Function getDisponible() As String Implements Servicio.getDisponible
        Throw New NotImplementedException()
    End Function
    Public Sub addPlan(plan As Plan)
        If _planes.Count < 3 Then
            _planes.Add(plan)
        End If
    End Sub
    Public Sub removePlan(plan As Plan)
        _planes.Remove(plan)
    End Sub
    Public Function getAllPlan() As List(Of Plan)
        Return _planes
    End Function
End Class
