Module Module1
    Sub Main()
        Console.Write("Calculate how many digits of pi?: ")
        Dim Int As Integer = Console.ReadLine
        If Not Int = 0 And Int > 1 Then
            If Int > 10 Then
                Console.WriteLine("Digits limited to 10.")
                Int = 10
            End If
            Dim pi As String = Math.PI.ToString.Substring(0, Int + 2)
            Console.WriteLine(pi)
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
        Else
            Console.WriteLine("You must enter a number!")
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
        End If
    End Sub
End Module
