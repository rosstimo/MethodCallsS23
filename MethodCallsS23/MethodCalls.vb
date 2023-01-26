'Tim Rossiter
'RCET0265
'MethodCalls

Option Strict On
Option Explicit On

Imports System

Module MethodCalls

    Sub Main(args As String())
        Dim firstNumber As Integer = 6
        'Sub runs code and/or performs a task
        'Console.WriteLine(DoMath())
        'Console.WriteLine(firstNumber)

        'Functions can/must return a value
        'Function calls (return value) can be used just like any variable
        'Console.WriteLine(AddTwoNumbers())
        'firstNumber = AddTwoNumbers()
        'AddTwoNumbers()

        'print first CMD line argument
        'Try
        '    Console.WriteLine(args(0))
        'Catch e As Exception
        '    Console.WriteLine("oops!")
        'End Try
        'Console.Read()

        SumOf(firstNumber, 7)
        Console.WriteLine(firstNumber)

    End Sub

    Sub DoMath()
        Console.WriteLine(2 + 2)
    End Sub

    Function AddTwoNumbers() As Integer
        'Console.WriteLine(5 + 5)
        Return 3
    End Function

    ''' <summary>
    ''' Writes the number sentence for the sum of the two arguments to the console.
    ''' </summary>
    ''' <param name="firstNumber"></param>
    ''' <param name="secondNumber"></param>
    Sub SumOf(firstNumber As Integer, secondNumber As Integer)
        Dim result As Integer
        firstNumber = 3
        result = firstNumber + secondNumber
        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}")
        Console.WriteLine(firstNumber)
    End Sub

End Module
