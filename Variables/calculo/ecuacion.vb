Imports System

Module Program
    Sub Main()
        Dim a As UShort = 1
        Dim b As UShort = 5
        Dim c As UShort = 2

        Console.WriteLine("Resultado: " & (b ^ 2 - 4 * a * c) / 2 * a)
    End Sub
End Module
