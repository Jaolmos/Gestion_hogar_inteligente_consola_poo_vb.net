Module Program
    Sub Main()
        ' Se crea las instancias de los dispositivos
        Dim altavozSala As New AltavozInteligente("Altavoz Sala", "Sony")
        Dim luzCocina As New LuzInteligente("Luz Cocina", 75)
        Dim termostatoHabitacion As New TermostatoInteligente("Termostato Habitación", 22)
        Dim camaraEntrada As New CamaraSeguridad("Cámara Entrada", True) ' True indica que tiene visión nocturna

        ' Creamos una instancia de HogarInteligente
        Dim hogar As New HogarInteligente()

        ' Agregamos los dispositivos al hogar inteligente
        hogar.AgregarDispositivo(altavozSala)
        hogar.AgregarDispositivo(luzCocina)
        hogar.AgregarDispositivo(termostatoHabitacion)
        hogar.AgregarDispositivo(camaraEntrada)

        ' Simulamos la interacción con los dispositivos
        Console.WriteLine("Simulando el encendido de todos los dispositivos y mostrando su información:")
        hogar.Simular()

        ' Interacciones individuales
        Console.WriteLine(vbCrLf & "Ajustando la intensidad de la luz de la cocina a 50:")
        luzCocina.Intensidad = 50
        Console.WriteLine(luzCocina.ObtenerInformacion())

        Console.WriteLine(vbCrLf & "Ajustando la temperatura del termostato de la habitación a 19:")
        termostatoHabitacion.Temperatura = 19
        Console.WriteLine(termostatoHabitacion.ObtenerInformacion())

        Console.WriteLine(vbCrLf & "Verificando la información de la cámara de seguridad:")
        Console.WriteLine(camaraEntrada.ObtenerInformacion())

        Console.ReadLine()
    End Sub
End Module
