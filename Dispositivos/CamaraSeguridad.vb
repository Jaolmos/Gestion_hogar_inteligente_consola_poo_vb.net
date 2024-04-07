Public Class CamaraSeguridad
    Inherits DispositivoInteligenteBase

    Private _tieneVisionNocturna As Boolean

    Public Property TieneVisionNocturna As Boolean
        Get
            Return _tieneVisionNocturna
        End Get
        Set(value As Boolean)
            _tieneVisionNocturna = value
        End Set
    End Property

    Public Sub New(nombre As String, tieneVisionNocturna As Boolean)
        MyBase.New(nombre)
        Me.TieneVisionNocturna = tieneVisionNocturna
    End Sub

    Public Overrides Function ObtenerInformacion() As String
        Dim infoVisionNocturna As String = If(TieneVisionNocturna, "con", "sin")
        Return $"Cámara de Seguridad {Nombre} - {infoVisionNocturna} visión nocturna - Estado: {(If(EstadoEncendido, "Activa", "Inactiva"))}"
    End Function
End Class
