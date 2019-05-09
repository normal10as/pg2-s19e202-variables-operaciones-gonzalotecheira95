Imports System.DateTime

Module Program
    Enum Dias
        Lunes = 1
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
        Domingo
    End Enum
    Sub Main()
        Dim ING As Byte
        Console.WriteLine("Ingrese un numero del 1 al 7 para saber a que dia corresponde: ")
        ING = Console.ReadLine
        Select Case ING
            Case Dias.Lunes
                Console.WriteLine("Es Lunes")
            Case Dias.Martes
                Console.WriteLine("Es Martes")
            Case Dias.Miercoles
                Console.WriteLine("Es Miercoles")
            Case Dias.Jueves
                Console.WriteLine("Es Jueves")
            Case Dias.Viernes
                Console.WriteLine("Es Viernes")
            Case Dias.Sabado
                Console.WriteLine("Es Sabado")
            Case Dias.Domingo
                Console.WriteLine("Es Domingo")
        End Select
    End Sub
End Module
