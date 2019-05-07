Module Module1

    Sub Main()
        Dim frase As String = "Aunque la cadena sea de oro, sirve para lo mismo"
        Dim palabra1, palabra2 As String


        Console.WriteLine(frase)
        Console.WriteLine("Ingrese la palabra para reemplazar: ")
        palabra1 = Console.ReadLine()
        Console.WriteLine("Ingrese la palabra que reemplaza: ")
        palabra2 = Console.ReadLine()


        Console.WriteLine(Replace(frase, palabra1, palabra2))

    End Sub

End Module
