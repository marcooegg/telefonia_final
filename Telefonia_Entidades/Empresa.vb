Public Class Empresa
    Inherits Cliente
    Private _razonSocial As String
    Private _cuit As String
    Public Property razonSocial As String
        Set(value As String)
            If value = "" Then Throw New Exception("No ingresaste nada")
            If value.Length > 80 Then Throw New Exception("Cadena de texto demasiado larga")
            _razonSocial = value
        End Set
        Get
            Return _razonSocial
        End Get
    End Property
    Public Property cuit As String
        Set(value As String)
            If value = "" Then Throw New Exception("No ingresaste nada")
            If value.Length > 13 Then Throw New Exception("Cadena de texto demasiado larga")
            _cuit = value
        End Set
        Get
            Return _cuit
        End Get
    End Property
    Sub New()
        MyBase.New()
        _razonSocial = ""
        _cuit = ""
    End Sub
    Sub New(razonSocial As String, cuit As String)
        Me.New()
        Me.razonSocial = razonSocial
        Me.cuit = cuit
    End Sub
End Class
