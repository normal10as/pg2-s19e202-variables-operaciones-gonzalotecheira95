Imports System

Module Program
    Sub Main()
        Dim entero1, entero2, entero3, entero4 As UShort
        Dim sumatoria As UShort


        Console.WriteLine("Ingrese N1: ")
        entero1 = Console.ReadLine()
        Console.WriteLine("Ingrese N2: ")
        entero2 = Console.ReadLine()
        Console.WriteLine("Ingrese N3: ")
        entero3 = Console.ReadLine()
        Console.WriteLine("Ingrese N4: ")
        entero4 = Console.ReadLine()

        sumatoria = entero1 + entero2 + entero3 + entero4

        Console.WriteLine("La media de la sumatoria de los 4 numeros es: " & sumatoria)
        Console.WriteLine("Y su media es: " & sumatoria / 4)


    End Sub
End Module
