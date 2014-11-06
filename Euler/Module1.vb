Module Module1

    Sub Main() '(Problem 40)
        Dim BigN As String = String.Empty
        Dim Ans As BigInteger = 1
        Dim i As Integer = 1
        Do
            BigN &= i.ToString
            i += 1
        Loop Until BigN.Length >= 1000000

        Ans *= BigN.Substring(1, 1) * BigN.Substring(10, 1) * BigN.Substring(100, 1) * BigN.Substring(1000, 1) * BigN.Substring(10000, 1) * BigN.Substring(100000, 1) * BigN.Substring(1000000, 1)

        Console.WriteLine(Ans)
        Console.ReadKey()
    End Sub
End Module


'Posibles: 
'   41
'   42
'   46
'   54
'   69
