Imports System

Module Program
    Sub Main()
        Dim monto, interes, tiempo As Integer
        Dim I As Int32

        Console.WriteLine("Ingrese el monto: ")
        monto = Console.ReadLine()

        Console.WriteLine("Ingrese el interes anual: ")
        interes = Console.ReadLine()

        Console.WriteLine("Ingrese el tiempo invertido: ")
        tiempo = Console.ReadLine()

        I = (monto * interes * tiempo) / (360 * 100)

        Console.WriteLine("Los intereses del monto invertido en el tiempo solicitado es de: $" & I & "00")

    End Sub
End Module
