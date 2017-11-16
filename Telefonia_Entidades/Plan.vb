Imports Telefonia_Entidades
Public MustInherit Class Plan
    Implements Servicio
    Private _nombre As String
    Private _precio As Single
    Private _credito As UInteger
    Private _consumo As UInteger
    Public Property credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property
    Public Property nombre As String Implements Servicio.nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
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

    Public Overridable Function getDisponible() As String Implements Servicio.getDisponible
        Throw New NotImplementedException()
    End Function
    Sub New()
        _nombre = ""
        _precio = 0
        _credito = 0
    End Sub
    Sub New(nombre As String, credito As UInteger, precio As Single)
        Me.New()
        Me.nombre = nombre
        Me.credito = credito
        Me.precio = precio
    End Sub
    Public MustOverride Sub addConsumo(valor As UInteger)
End Class
