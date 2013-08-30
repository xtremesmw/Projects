Module Module1
    Sub Main()
        Console.Write("Enter a string: ")
        Dim Str As String = Console.ReadLine
        If Not Str = String.Empty And Str.Length > 0 Then
            Dim NewStr As String = String.Empty
            For Each Letter As String In Str
                NewStr = Letter & NewStr
            Next
            Console.WriteLine("The reversed string: {0}", NewStr)
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
        Else
            Console.WriteLine("You must enter a string!")
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
        End If
    End Sub
End Module
