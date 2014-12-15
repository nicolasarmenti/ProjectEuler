Module Module1
    Sub Main() 'Esto debería funcionar, pero tarda años
        Dim Limit As BigInteger = BigInteger.Pow(10, 100)
        Dim NonBouncyCount As Integer = 99

        For i As BigInteger = 100 To Limit - 1
            If Not isBouncy(i) Then
                NonBouncyCount += 1
            End If
        Next

        Console.WriteLine(NonBouncyCount)
        Console.ReadKey()
    End Sub
End Module


'Posibles:
'33
'78 parte del problema de "de cuantas maneras se puede sumar X numero?"
'Sub Problem83()
'    Dim Matix(,) As Integer = readMatrix("p083_matrix.txt", ",")
'    Dim i As Integer = 0
'    Dim j As Integer = 0
'    Dim Ans As Integer = Matix(i, j)

'    Do

'    Loop Until i = 79 And j = 79


'    Console.WriteLine()
'    Console.ReadKey()
'End Sub