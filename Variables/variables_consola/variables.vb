Imports System

Module Program
    Sub Main()
        Dim nombre, apellido As String
        Dim fecha_nacimiendo As Date

        Console.WriteLine("Ingrese Nombre")
        nombre = Console.ReadLine()
        Console.WriteLine("Ingrese Apellido")
        apellido = Console.ReadLine()
        Console.WriteLine("Ingrese Fecha de Nacimiento")
        fecha_nacimiendo = Console.ReadLine()

        Console.WriteLine(apellido & " " & nombre & " " & "Nacio el: " & fecha_nacimiendo)
    End Sub
End Module
