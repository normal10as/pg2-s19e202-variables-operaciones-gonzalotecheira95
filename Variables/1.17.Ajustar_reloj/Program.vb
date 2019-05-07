Imports System.DateTime

Module Program
    Sub Main()
        Dim dia, hora As Byte
        Dim fecha As Date

        Console.WriteLine("Ingrese dias: ")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese hora: ")
        hora = Console.ReadLine()

        fecha = New DateTime(Now.Year, Now.Month, dia, hora, Now.Minute, Now.Second)

        Console.WriteLine(fecha)
    End Sub
End Module
