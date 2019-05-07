Imports System

Module Program
    Sub Main()
        Dim num1, num2, num3 As Short

        Console.WriteLine("Ingrese el primer numero: ")
        num1 = Console.ReadLine()

        Console.WriteLine("Ingrese el segundo numero: ")
        num2 = Console.ReadLine()

        Console.WriteLine("Ingrese el tercer numero: ")
        num3 = Console.ReadLine()

        If (num1 > num2 And num1 > num3) Then
            Console.WriteLine("El primer numero es mayor")
        ElseIf (num2 > num3 And num2 > num1) Then
            Console.WriteLine("El segundo numero es mayor")
        ElseIf (num3 > num1 And num3 > num2) Then
            Console.WriteLine("El tercer numero es mayor")
        End If
    End Sub
End Module
