Public Class LuzInteligente
    Inherits DispositivoInteligenteBase

    Private _intensidad As Integer

    Public Property Intensidad As Integer
        Get
            Return _intensidad
        End Get
        Set(value As Integer)
            If value < 0 Or value > 100 Then
                Throw New ArgumentException("La intensidad debe estar entre 0 y 100")
            End If
            _intensidad = value
        End Set
    End Property

    Public Sub New(nombre As String, intensidad As Integer)
        MyBase.New(nombre)
        Me.Intensidad = intensidad
    End Sub


    Public Overrides Function ObtenerInformacion() As String
        Return $"Luz Inteligente {Nombre} - Intensidad: {Intensidad} - Estado: {(If(EstadoEncendido, "Encendida", "Apagada"))}"
    End Function
End Class
