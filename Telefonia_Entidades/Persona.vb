Public Class Persona
    Inherits Cliente
    Private _apellido As String
    Private _nombre As String
    Private _documento As UInteger
    Public Property apellido As String
        Set(value As String)
            If value = "" Then Throw New Exception("No ingresaste nada")
            If value.Length > 30 Then Throw New Exception("Cadena de texto demasiado larga")
            _apellido = value
        End Set
        Get
            Return _apellido
        End Get
    End Property
    Public Property nombre As String
        Set(value As String)
            If value = "" Then Throw New Exception("No ingresaste nada")
            If value.Length > 50 Then Throw New Exception("Cadena de texto demasiado larga")
            _nombre = value
        End Set
        Get
            Return _nombre
        End Get
    End Property
    Public Property documento As UInteger
        Set(value As UInteger)
            _documento = value
        End Set
        Get
            Return _documento
        End Get
    End Property
    Sub New()
        MyBase.New()
        _apellido = ""
        _nombre = ""
        _documento = 0
    End Sub
    Sub New(apellido As String, nombre As String, documento As UInteger)
        Me.New()
        Me.apellido = apellido
        Me.nombre = nombre
        Me.documento = documento
    End Sub
End Class
