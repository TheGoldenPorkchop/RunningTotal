Option Strict On
Option Explicit On
'header stuff
Imports System.Runtime.InteropServices



'TO DO LIST
'[X] Keep track of transactions in a Function called RunningTotal()
'[X] Get the current total as needed
'[X] Provide a way to clear/zero the total
'[X] Display transaction and running total formatted as currency
'[ ] Siuper bonus: creat a method to include sales tax to the transaction
Module RunningTotal
    Dim myGlobalNumberThing As Decimal
    Sub Main()
        Dim userInput As String
        Dim transNumber As Decimal
        Dim quit As Boolean = False
        Do
            Console.WriteLine("enter a transaction amount or press Q to quit")
            userInput = Console.ReadLine()
            If userInput = "q" Then
                quit = True
            Else
                Console.WriteLine($"you entered: {userInput}")
                Try
                    transNumber = CDec(userInput) * CDec(1.06)
                    Console.WriteLine("Your Vault has: " & RunningTotal(transNumber).ToString("c"))
                Catch ex As Exception
                    Console.WriteLine($"{userInput} is not a valid number")
                    Console.WriteLine($"Please enter a valid number")
                End Try
            End If
        Loop Until quit
        Console.Clear()
        Console.WriteLine("Have a good day")

        Console.WriteLine(RunningTotal(10))
    End Sub

    Function RunningTotal(currentNumber As Decimal) As Decimal
        Static _runningTotal As Decimal
        _runningTotal += currentNumber
        Return _runningTotal
    End Function

    Sub SomeOtherGuysBadSub()
        myGlobalNumberThing = 0
    End Sub

End Module
