Imports System.Math

Module Program
    Sub Main()
        Dim valor As Decimal

        Console.WriteLine("Ingrese un valor: ")
        valor = Console.ReadLine()

        Console.WriteLine("Su valor por exceso: " & Math.Ceiling(valor))
        Console.WriteLine("Su valor por defecto: " & Math.Floor(valor))
        Console.WriteLine("Su valor redondeado: " & Math.Round(valor))


    End Sub
End Module
