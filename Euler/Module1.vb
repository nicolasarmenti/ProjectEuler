Module Module1

    Sub Main()
        Dim Matrix(,) As Integer = readMatrix("p011_matrix.txt", " ")
        Dim Ans As Integer = 0

        For row As Integer = 0 To Matrix.GetUpperBound(0)
            For col As Integer = 0 To Matrix.GetUpperBound(1)
                'Testear si se puede usar el ultimo y hacer la multiplicacion (una para cada direccion -4-)
                'En cada una comparar math.max() y guardar
            Next
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

