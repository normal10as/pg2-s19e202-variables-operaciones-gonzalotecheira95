Imports System.Math

Module Program
    Sub Main()
        Dim valor As Short
        Console.WriteLine("Ingrese un valor para mostrar el resultado: ")
        valor = Console.ReadLine()

        Console.WriteLine("El valor absolto es: " & Abs(valor))
        Console.WriteLine("Elevado a la decima potencia es: " & (valor ^ 10))
        Console.WriteLine("Y su raiz cuadrada es: " & Sqrt(valor))
    End Sub
End Module
