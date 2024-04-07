Public Class TermostatoInteligente
    Inherits DispositivoInteligenteBase

    Private _temperatura As Decimal

    Public Property Temperatura As Decimal
        Get
            Return _temperatura
        End Get
        Set(value As Decimal)
            If value < 16 Or value > 30 Then
                Throw New ArgumentException("Temperatura fuera de rango")
            End If
            _temperatura = value
        End Set
    End Property

    Public Sub New(nombre As String, temperatura As Decimal)
        MyBase.New(nombre)
        Me.Temperatura = temperatura
    End Sub

    Public Overrides Function ObtenerInformacion() As String
        Return $"Termostato Inteligente {Nombre} - Temperatura: {Temperatura}°C - Estado: {(If(EstadoEncendido, "Encendido", "Apagado"))}"
    End Function
End Class