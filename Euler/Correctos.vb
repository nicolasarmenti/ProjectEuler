Module Correctos

    Sub Problem1() 'Find the sum of all the multiples of 3 or 5 below 1000.
        Dim Top As Integer = 1000
        Dim List As List(Of Integer) = New List(Of Integer)

        For i As Integer = 1 To Top - 1
            If (i Mod 3) = 0 Then
                List.Add(i)
            ElseIf (i Mod 5) = 0 Then
                List.Add(i)
            End If
        Next

        Console.WriteLine(List.Sum)
        Console.ReadKey()
    End Sub

    Sub Problem2() 'By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        Dim Limit As Integer = 4000000, Fib1 As Integer = 1, Fib2 As Integer = 1, Fib3 As Integer
        Dim List As List(Of Integer) = New List(Of Integer)

        While Fib2 < Limit
            If (Fib2 Mod 2) = 0 Then
                List.Add(Fib2)
            End If
            'Calcular siguiente
            Fib3 = Fib1 + Fib2
            Fib1 = Fib2
            Fib2 = Fib3
        End While

        Console.WriteLine(List.Sum)
        Console.ReadKey()
    End Sub

    Sub Problem3() 'What is the largest prime factor of the number 600851475143?
        Dim Num As Long = 600851475143
        Dim NewNum As Long = Num
        Dim Fact As Long = 0

        Dim counter As Integer = 2
        While (counter * counter < NewNum)
            If (NewNum Mod counter) = 0 Then
                NewNum = NewNum / counter
                Fact = counter
            Else
                counter += 1
            End If
        End While
        If (NewNum > Fact) Then
            Fact = NewNum
        End If

        Console.WriteLine(Fact)
        Console.ReadKey()
    End Sub

    Sub Problem4() 'Find the largest palindrome made from the product of two 3-digit numbers.
        Dim Prod As String
        Dim Largest As Integer

        For i As Integer = 100 To 1000
            For j As Integer = 100 To 1000
                Prod = i * j
                If isPalindrome(Prod) Then
                    If CInt(Prod) > Largest Then
                        Largest = Prod
                    End If
                End If
            Next
        Next

        Console.WriteLine(Largest)
        Console.ReadKey()
    End Sub

    Sub Problem5() 'What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        Dim Fin As Boolean = False, Div As Boolean
        Dim i As Integer = 0

        While Not (Fin)
            i += 1
            Div = True
            For j As Integer = 1 To 20
                If (i Mod j) Then
                    Div = False
                    Exit For
                End If
            Next
            Fin = Div
        End While

        Console.WriteLine(i)
        Console.ReadKey()
    End Sub

    Sub Problem6() 'Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        Dim Limit As Integer = 100
        Dim SumOfSquares As Integer = 0
        Dim SquareOfSum As Integer = 0

        For i As Integer = 1 To Limit
            SumOfSquares += (i * i)
            SquareOfSum += i
        Next

        SquareOfSum *= SquareOfSum

        Console.WriteLine(SumOfSquares)
        Console.WriteLine(SquareOfSum)
        Console.WriteLine(SquareOfSum - SumOfSquares)
        Console.ReadKey()
    End Sub

    Sub Problem7() 'What is the 10 001st prime number?
        Dim Primos As List(Of Long) = New List(Of Long)
        Primos.Add(2)
        Dim Nth = 10001
        Dim Ans As Long

        For i As Long = 3 To 1000000 Step 2
            If esPrimo(i, Primos) Then
                Primos.Add(i)
                If Primos.Count = Nth Then
                    Ans = i
                    Exit For
                End If
            End If
        Next

        Console.WriteLine(Ans)
        Console.ReadKey()
    End Sub

    Sub Problem8() 'Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        Dim Num As String = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450"
        Dim Longitud As Integer = 13
        Dim SubNum As String
        Dim MaxMult As Decimal = 0
        Dim Mult As Decimal
        While Num.Length >= Longitud
            SubNum = Num.Substring(0, Longitud)
            Num = Num.Substring(1)
            Mult = 1
            For Each Number In SubNum.ToCharArray
                Mult *= CInt(Number.ToString)
            Next
            If Mult > MaxMult Then
                MaxMult = Mult
            End If
        End While

        Console.WriteLine(MaxMult)
        Console.ReadKey()
    End Sub

    Sub Problem9() 'Find a*b*c / a+b+c=100 & a^2+b^2=c^2 & a<b<c
        Dim Ans As Integer = 0
        For i = 1 To 999
            For j = i + 1 To 998
                For k = j + 1 To 997
                    If (i + j + k) = 1000 Then
                        If ((i ^ 2) + (j ^ 2) = (k ^ 2)) Then
                            Console.WriteLine("a=" & i)
                            Console.WriteLine("b=" & j)
                            Console.WriteLine("c=" & k)
                            Ans = i * j * k
                        End If
                    End If
                Next
            Next
        Next

        Console.WriteLine(Ans)
        Console.ReadKey()
    End Sub

    Sub Problem10() 'Find the sum of all the primes below two million.
        Dim Limit As Integer = 2000000
        Dim Primos As List(Of Long) = New List(Of Long)
        Primos.Add(2)

        For i As Long = 3 To Limit Step 2
            If esPrimo(i, Primos) Then
                Primos.Add(i)
            End If
        Next

        Console.WriteLine(Primos.Sum)
        Console.ReadKey()
    End Sub

    Sub Problem11() 'What is the value of the first triangle number to have over five hundred divisors?
        Dim Fin As Boolean = False
        Dim Number As ULong = 0
        Dim Sum As ULong

        While Not Fin
            Number += 1
            Sum = 0
            For i As Integer = 1 To Number
                Sum += i
            Next
            If factorQ(Sum) >= 500 Then
                Console.WriteLine(Sum)
                Fin = True
            End If
        End While

        Console.ReadKey()
    End Sub

    Sub Problem14() 'Which starting number, under one million, produces the longest chain? When n → n/2 (n is even), n → 3n + 1 (n is odd)
        Dim Last As Long
        Dim Bound As Integer = 1000000
        Dim Count As Integer
        Dim MaxCount As Integer = 0
        Dim MaxSeed As Integer = 0

        For i As Integer = 2 To Bound
            Last = i
            Count = 0
            While Last > 1
                If (Last Mod 2) = 0 Then
                    Last = Last / 2
                Else
                    Last = 3 * Last + 1
                End If
                Count += 1
            End While
            If Count > MaxCount Then
                MaxSeed = i
                MaxCount = Count
            End If
        Next

        Console.WriteLine(MaxSeed)
        Console.ReadKey()
    End Sub

    Sub Problem29() 'How many distinct terms are in the sequence generated by ab for 2 ≤ a ≤ 100 and 2 ≤ b ≤ 100?
        Dim Pot As String
        Dim Potencias As New List(Of String)
        For i As Integer = 2 To 100
            For j As Integer = 2 To 100
                Pot = (i ^ j)
                If Not (Potencias.Contains(Pot)) Then
                    Potencias.Add(Pot)
                End If
            Next
        Next
        Console.WriteLine(Potencias.Count)
        Console.ReadKey()
    End Sub

    Sub Problem36() 'Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        Dim Lista As New List(Of Integer)
        Dim Binary As String
        For i As Integer = 1 To 1000000
            If isPalindrome(i) Then
                Binary = Convert.ToString(i, 2)
                If isPalindrome(Binary) Then
                    Lista.Add(i)
                End If
            End If
        Next

        Console.WriteLine(Lista.Sum)
        Console.ReadKey()
    End Sub

    Sub Problem55() 'How many Lychrel numbers are there below ten-thousand?
        Dim Lychrels As Integer = 0
        For i As Decimal = 1 To 10000
            If isLychrel(i) Then
                Lychrels += 1
            End If
        Next

        Console.WriteLine(Lychrels)
        Console.ReadKey()
    End Sub
End Module
