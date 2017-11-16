Public Class Equipo
    Private _marca As String
    Private _modelo As String
    Private _serie As String
    Private _fechaVenta As Date
    Public Property marca As String
        Set(value As String)
            If value = "" Then Throw New Exception("No ingresaste nada")
            If value.Length > 30 Then Throw New Exception("Cadena de texto demasiado larga")
            _marca = value
        End Set
        Get
            Return _marca
        End Get
    End Property
    Public Property modelo As String
        Set(value As String)
            If value = "" Then Throw New Exception("No ingresaste nada")
            If value.Length > 50 Then Throw New Exception("Cadena de texto demasiado larga")
            _marca = value
        End Set
        Get
            Return _modelo
        End Get
    End Property
    Public Property serie As String
        Set(value As String)
            If value = "" Then Throw New Exception("No ingresaste nada")
            If value.Length > 15 Then Throw New Exception("Cadena de texto demasiado larga")
            _serie = value
        End Set
        Get
            Return _serie
        End Get
    End Property
    Public ReadOnly Property fechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property
    Sub New()
        _marca = ""
        _modelo = ""
        _serie = ""
        _fechaVenta = Nothing
    End Sub
    Sub New(marca As String, modelo As String, serie As String)
        Me.New()
        Me.marca = marca
        Me.modelo = modelo
        Me.serie = serie
    End Sub
    Public Sub vender(fecha As Date)
        _fechaVenta = fecha
    End Sub

End Class
