Imports System.CodeDom

Module Module1
    Dim num1 As Integer
    Dim num2 As Integer
    Dim choice As Integer
    Sub Main()
        Do
            Console.WriteLine("plase make a choice")
            Console.WriteLine("1: add")
            Console.WriteLine("2: Subtract")
            Console.WriteLine("3: multiply")
            Console.WriteLine("4: Divide")
            Console.WriteLine("5: Exit")
            choice = Console.ReadLine

            If choice <> 5 Then
                inputNum()
            End If


            Select Case choice
                Case 1
                    add()
                Case 2
                    subtract()
                Case 3
                    muti()
                Case 4
                    divide()
            End Select
        Loop Until choice = 5
    End Sub
    Sub inputNum()
        Console.WriteLine("enter number 1")
        num1 = Console.ReadLine
        Console.WriteLine("enter number 2")
        num2 = Console.ReadLine
    End Sub
    Sub add()
        Console.WriteLine(num1 + num2)
        Console.ReadLine()
        Console.Clear()
    End Sub
    Sub subtract()
        Console.WriteLine(num1 - num2)
        Console.ReadLine()
        Console.Clear()
    End Sub
    Sub muti()
        Console.WriteLine(num1 * num2)
        Console.ReadLine()
        Console.Clear()
    End Sub
    Sub divide()
        Console.WriteLine(num1 / num2)
        Console.ReadLine()
        Console.Clear()
    End Sub
End Module
