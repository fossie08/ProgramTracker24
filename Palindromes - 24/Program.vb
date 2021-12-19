Imports System

Module Program
    Sub Main(args As String())
        Dim name As String
        Dim reversal As String

        Console.WriteLine("Please enter a name to see if it a palindrome ")
        name = Console.ReadLine()

        reversal = StrReverse(name)

        If name = reversal Then
            Console.WriteLine("Your name is a palindrome")
        Else
            Console.WriteLine("Your name is not a palindrome ")
        End If

    End Sub
End Module
