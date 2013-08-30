Module Module1
    Sub Main()
        Console.Write("Enter a string: ")
        Dim Str As String = Console.ReadLine
        If Not Str = String.Empty And Str.Length > 0 Then
            Dim ReverseString As String = String.Empty
            For Each Letter As String In Str
                ReverseString = Letter & ReverseString
            Next
            If ReverseString = Str Then
                Console.WriteLine("{0} is a palindrome!", Str)
            Else
                Console.WriteLine("{0} is not a palindrome!", Str)
            End If
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
        Else
            Console.WriteLine("You must enter a string!")
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
        End If
    End Sub
End Module
