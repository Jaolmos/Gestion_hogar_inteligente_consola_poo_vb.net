' Clase Abstracta
Public MustInherit Class DispositivoInteligenteBase
    Implements IDispositivoInteligente

    Private _nombre As String
    Private _estadoEncendido As Boolean = False

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) Then
                Throw New ArgumentException("El nombre no puede estar vacío")
            End If
            _nombre = value
        End Set
    End Property

    Public ReadOnly Property EstadoEncendido As Boolean
        Get
            Return _estadoEncendido
        End Get
    End Property

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Public Sub Encender() Implements IDispositivoInteligente.Encender
        _estadoEncendido = True
    End Sub

    Public Sub Apagar() Implements IDispositivoInteligente.Apagar
        _estadoEncendido = False
    End Sub

    Public MustOverride Function ObtenerInformacion() As String Implements IDispositivoInteligente.ObtenerInformacion

End Class
