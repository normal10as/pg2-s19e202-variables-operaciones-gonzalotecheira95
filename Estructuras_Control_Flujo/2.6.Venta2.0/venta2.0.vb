Imports System

Module Program
    Sub Main()
        Dim cantidad, precio_unitario, monto_descontado As Integer
        Dim total_productos As Integer = 0

        Console.WriteLine("Ingrese la cantidad de productos: ")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese el precio del producto: ")
        precio_unitario = Console.ReadLine()
        total_productos = cantidad * precio_unitario

        Console.WriteLine("El subtotal es de: $" & total_productos)

        Select Case cantidad
            Case Is >= 10
                Console.WriteLine("se desconto un 5%")
                monto_descontado = total_productos * 5 / 100
            Case Is >= 50
                Console.WriteLine("se desconto un 10%")
                monto_descontado = total_productos * 10 / 100
            Case Is >= 250
                Console.WriteLine("se desconto un 20%")
                monto_descontado = total_productos * 20 / 100
        End Select
        Console.WriteLine("El monto descontado es de: $" & monto_descontado)
        Console.WriteLine("El total a pagar es de: $" & (total_productos - monto_descontado))

    End Sub
End Module
