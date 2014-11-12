Module Module1

    Sub Main() 'Problem 75
        Dim Limit As Integer = 1500000
        Dim Ans As Integer = 0
        For a As Integer = 1 To Math.Abs(Limit / 3) - 1
            Dim is1 As Boolean = False
            For b As Integer = 1 To a
                Dim Count As Integer = 0
                For c As Integer = b To Limit - a - b
                    Select Case (c ^ 2)
                        Case ((a ^ 2) + (b ^ 2))
                            Count += 1
                            is1 = True
                        Case Is > ((a ^ 2) + (b ^ 2))
                            Exit For
                    End Select
                Next
                If Count > 1 Then
                    Exit For
                    is1 = False
                End If
            Next
            If is1 Then
                Ans += 1
            End If
        Next
        Console.WriteLine(Ans)
        Console.ReadKey()
    End Sub
End Module


'Posibles: 
'   42
'   46
'   54
'   69

