Imports System

Module Program
    Sub Main()
        Dim dias As UShort = 365
        Dim diasLaborables As Byte = 5
        Dim diasSemana As Byte = 7

        Console.WriteLine("Semanas del a�o: " & (dias / diasSemana))
        Console.WriteLine("Semanas laborables del a�o " & (dias / diasLaborables) - (dias / diasSemana))

    End Sub
End Module
