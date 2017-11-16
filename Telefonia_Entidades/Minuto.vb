Public Class Minuto
    Inherits Plan
    Private _consumo As UInteger
    Sub New()
        MyBase.New()
    End Sub
    Sub New(nombre As String, credito As UInteger, precio As Single)
        Me.New()
        Me.nombre = nombre
        Me.credito = credito
        Me.precio = precio
    End Sub
    Public Overrides Function ToString() As String
        Return "minuto"
    End Function
    Public Overrides Function getDisponible() As String
        Return credito - _consumo & ToString()
    End Function
    Public Overrides Sub addConsumo(valor As UInteger)
        If valor + _consumo <= credito Then _consumo += valor
    End Sub
End Class
