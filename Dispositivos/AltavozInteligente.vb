Public Class AltavozInteligente
    Inherits DispositivoInteligenteBase

    Private _marca As String

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) Then
                Throw New ArgumentException("La marca no puede estar vacía")
            End If
            _marca = value
        End Set
    End Property

    Public Sub New(nombre As String, marca As String)
        MyBase.New(nombre)
        Me.Marca = marca
    End Sub
    Public Overrides Function ObtenerInformacion() As String
        Return $"Altavoz Inteligente {Nombre} - Marca: {Marca} - Estado: {(If(EstadoEncendido, "Encendido", "Apagado"))}"
    End Function
End Class
