Imports System

Module Program
    Sub Main()
        Dim valor As UShort

        Console.WriteLine("Ingrese un valor para dividirlo por 2: ")
        valor = Console.ReadLine()

        Console.WriteLine("El resultado es: " & valor / 2)
    End Sub
End Module
