Module Module1

    Sub Main() 'Problem 70
        Dim Min As Double = 999999999999999999
        Dim minN As Integer
        Dim minAux As Double
        Dim phii As Double
        For i As BigInteger = 2 To BigInteger.Pow(10, 7)
            phii = phi(i)
            If sonPermutados(phii, i.ToString) Then
                minAux = CType(i, Double) / phii
                If minAux <= Min Then
                    Min = minAux
                    minN = i
                End If
            End If
        Next
        Console.WriteLine(minN)
        Console.ReadKey()
    End Sub

    Friend Function sonPermutados(ByVal a As String, ByVal b As String) As Boolean
        Dim ArrA() As Char = a.ToCharArray
        Dim Arrb() As Char = b.ToCharArray
        Array.Sort(ArrA)
        Array.Sort(Arrb)
        Return ArrA = Arrb
    End Function
End Module


'Posibles: 
'   42
'   46
'   54
'   69

