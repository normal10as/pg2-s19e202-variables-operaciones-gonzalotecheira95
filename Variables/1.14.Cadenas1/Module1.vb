Module Module1

    Sub Main()
        Dim palabra As String
        Dim pos_a, pos_o As UShort

        Console.WriteLine("Ingrese una palabra: ")
        palabra = Console.ReadLine()
        pos_a = InStr(palabra, "a", CompareMethod.Text)
        pos_o = InStr(palabra, "o", CompareMethod.Text)


        Console.WriteLine("la letra a se encuentra en la posicion" & pos_a)
        Console.WriteLine("la letra o se encuentra en la posicion" & pos_o)
        Console.WriteLine("la palabra invertida es:" & StrReverse(palabra))
    End Sub

End Module
