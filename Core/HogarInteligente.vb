Public Class HogarInteligente
    Private ReadOnly dispositivos As List(Of IDispositivoInteligente) = New List(Of IDispositivoInteligente)()

    Public Sub AgregarDispositivo(dispositivo As IDispositivoInteligente)
        dispositivos.Add(dispositivo)
    End Sub

    Public Sub Simular()
        For Each dispositivo In dispositivos
            dispositivo.Encender()
            Console.WriteLine(dispositivo.ObtenerInformacion())
        Next
    End Sub
End Class
