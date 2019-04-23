Imports System

Module Program
    Sub Main()
        Dim Nombre As String = "Carlos"
        Dim DNI As Integer = "39458965"
        Dim LugarNacimiento As String = "Posadas"
        Dim FechaNacimiento As Date = "18/04/1996"
        Dim AlturaCorporal As Single = "1,7"
        Dim Argentino As Boolean = True
        Dim TemperaturaAmbiente As Byte = "39"
        Dim NombreCalle As String = "Calle 117"
        Dim AlturaCalle As UShort = "2200"
        Dim DistanciaCiudad As UShort = "30"
        Dim ProfundidadMar As UShort = "1150"
        Dim CantidadHabitantes As Integer = "33000"
        Dim PesoProducto As UShort = "10"
        Dim MontoArticulo As Byte = "40"


        Console.WriteLine("Nombre: " & Nombre)
        Console.WriteLine("El DNI: " & DNI)
        Console.WriteLine("Nacio en: " & LugarNacimiento)
        Console.WriteLine("Nacio el dia: ")
        Console.WriteLine("Su altura es de: " & AlturaCorporal)
        Console.WriteLine("Es argentino?: " & Argentino)
        Console.WriteLine("La temperatura es de: " & TemperaturaAmbiente)
        Console.WriteLine("Calle donde vive: " & NombreCalle)
        Console.WriteLine("Altura de la calle: " & AlturaCalle)
        Console.WriteLine("Distancia entre las ciudades: " & DistanciaCiudad)
        Console.WriteLine("La profundidad del mar es de: " & ProfundidadMar)
        Console.WriteLine("La cantidad de habitantes es de: " & CantidadHabitantes)
        Console.WriteLine("El peso del producto es de " & PesoProducto & " y vale " & MontoArticulo)

    End Sub
End Module
