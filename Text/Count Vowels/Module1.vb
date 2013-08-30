Module Module1
    Sub Main()
        Console.Write("Enter a string: ")
        Dim Str As String = Console.ReadLine
        If Not Str = String.Empty And Str.Length > 0 Then
            Dim VowelsCount(5) As Integer
            For Each Letter As String In Str
                Letter = Letter.ToUpper()
                Select Case Letter
                    Case "A"
                        VowelsCount(0) += 1
                    Case "E"
                        VowelsCount(1) += 1
                    Case "I"
                        VowelsCount(2) += 1
                    Case "O"
                        VowelsCount(3) += 1
                    Case "U"
                        VowelsCount(4) += 1
                    Case "Y"
                        VowelsCount(5) += 1
                End Select

            Next
            Console.WriteLine("Number of vowels: {0}", VowelsCount(0) + VowelsCount(1) + VowelsCount(2) + VowelsCount(3) + VowelsCount(4) + VowelsCount(5))
            Console.WriteLine("A: {0}", VowelsCount(0))
            Console.WriteLine("E: {0}", VowelsCount(1))
            Console.WriteLine("I: {0}", VowelsCount(2))
            Console.WriteLine("O: {0}", VowelsCount(3))
            Console.WriteLine("U: {0}", VowelsCount(4))
            Console.WriteLine("Y: {0}", VowelsCount(5))
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
        Else
            Console.WriteLine("You must enter a string!")
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
        End If
    End Sub
End Module
