Module Module1

    Sub Main()
        Dim Matrix(,) As Integer = readMatrix("p011_matrix.txt", " ")
        Dim Ans As Integer = 0

        For row As Integer = 0 To Matrix.GetUpperBound(0)
            For col As Integer = 0 To Matrix.GetUpperBound(1)
                'Testear si se puede usar el ultimo y hacer la multiplicacion (una para cada direccion -4-)
                'En cada una comparar math.max() y guardar
                Dim sol As Integer = 1
                If Not Matrix(row, col + 3) = Nothing Then 'Horizontal
                    For i As Integer = 0 To 3
                        sol *= Matrix(row, col + i)
                    Next
                    Ans = Math.Max(Ans, sol)
                End If

                If Not Matrix(row + 3, col) = Nothing Then 'Vertical
                    For i As Integer = 0 To 3
                        sol *= Matrix(row + i, col)
                    Next
                    Ans = Math.Max(Ans, sol)
                End If

                If Not Matrix(row + 3, col + 3) = Nothing Then 'Diagonal hacia la derecha
                    For i As Integer = 0 To 3
                        sol *= Matrix(row + i, col + i)
                    Next
                    Ans = Math.Max(Ans, sol)
                End If

                If Not Matrix(row - 3, col + 3) = Nothing Then 'Diagonal hacia la izquierda
                    For i As Integer = 0 To 3
                        sol *= Matrix(row - i, col + i)
                    Next
                    Ans = Math.Max(Ans, sol)
                End If
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

