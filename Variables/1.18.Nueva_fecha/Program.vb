Imports System.DateTime

Module Program
    Sub Main()
        Dim fecha, fecha2 As Date
        Dim dias As Byte

        Console.WriteLine("Ingrese una fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese dias a sumar: ")
        dias = Console.ReadLine()

        fecha2 = New DateTime(fecha.Year, fecha.Month, fecha.Day)

        Console.WriteLine("La nueva fecha es: " & fecha2.AddDays(dias))

    End Sub
End Module
