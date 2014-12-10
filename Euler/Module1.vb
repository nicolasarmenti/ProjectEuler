Module Module1
    Sub Main() '85, no va por este lado. Hay que contar cuantos entran de 1x1, 1x2, 1x3, 2x1, 2x2, 2x3....
        Dim Sol As Integer = 0
        Dim n As Integer = 0

        While Sol <= 2000000
            n += 1
            Sol = (n + 1) * (n \ 2)
        End While

        Console.WriteLine("Los primeros " & n & " numeros suman " & Sol)
        Console.ReadKey()
    End Sub
End Module


'Posibles:
'85 Se puede hacer pensando un poco
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