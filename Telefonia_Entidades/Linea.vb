Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String
    Private _cliente As Cliente
    Private _equipo As Equipo
    Private _servicio As Servicio
    Public Property servicio As Servicio
        Get
            Return _servicio
        End Get
        Set(value As Servicio)
            _servicio = value
        End Set
    End Property
    Public Property Equipo As Equipo
        Set(value As Equipo)
            _equipo = value
        End Set
        Get
            Return _equipo
        End Get
    End Property
    Public Property Cliente As Cliente
        Friend Set(value As Cliente)
            If _cliente IsNot Nothing Then Throw New Exception("Esta linea ya tiene dueño")
            _cliente = value
        End Set
        Get
            Return _cliente
        End Get
    End Property
    Public Property CodigoArea As UShort
        Set(value As UShort)
            If value < 100 Or value > 9999 Then Throw New Exception("El codigo de area debe ser un numero entre 100 y 9999")
            _codigoArea = value
        End Set
        Get
            Return _codigoArea
        End Get
    End Property
    Public Property Numero As UInteger
        Set(value As UInteger)
            If value < 100000 Or value > 9999999 Then Throw New Exception("El numero debe valer entre 100000 y 9999999")
            _numero = value
        End Set
        Get
            Return _numero
        End Get
    End Property
    Public ReadOnly Property Estado As String
        Get
            Return _estado
        End Get
    End Property
    Sub New()
        _codigoArea = 0
        _numero = 0
        _estado = "Activa"
    End Sub
    Sub New(CodigoArea As UShort, Numero As UInteger)
        Me.New()
        Me.CodigoArea = CodigoArea
        Me.Numero = Numero
    End Sub
    Public Sub suspender()
        _estado = "Suspendida"
    End Sub
    Public Sub reactivar()
        _estado = "Activa"
    End Sub
End Class
