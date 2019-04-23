Imports System

Module Program
    Sub Main()
        Dim NombreEmpresa As String = "NoManzana"
        Dim NombreCalle As String = "Rademacher"
        Dim AlturaCalle As UShort = 2200
        Dim FechaActividades As Date = #05/04/2019#

        'Concatenacion Implicita
        Dim altura As String = AlturaCalle
        Dim fecha As String = FechaActividades
        Console.WriteLine("El nombre de la Empresa es: " & NombreEmpresa)
        Console.WriteLine("El Nombre de la calle es: " & NombreCalle)
        Console.WriteLine("La altura es de: " & altura)
        Console.WriteLine("La fecha de actividades: " & fecha)

        'Concatenacion Explicita
        Console.WriteLine("El nombre de la Empresa es: " & NombreEmpresa)
        Console.WriteLine("El Nombre de la calle es: " & NombreCalle)
        Console.WriteLine("La altura es de: " & Convert.ToString(AlturaCalle))
        Console.WriteLine("La fecha de actividades: " & Convert.ToString(FechaActividades))


    End Sub
End Module
