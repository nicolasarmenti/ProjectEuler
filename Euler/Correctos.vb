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


    Sub Problem13() 'Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
        Dim Numeros() As String = "37107287533902102798797998220837590246510135740250,46376937677490009712648124896970078050417018260538,74324986199524741059474233309513058123726617309629,91942213363574161572522430563301811072406154908250,23067588207539346171171980310421047513778063246676,89261670696623633820136378418383684178734361726757,28112879812849979408065481931592621691275889832738,44274228917432520321923589422876796487670272189318,47451445736001306439091167216856844588711603153276,70386486105843025439939619828917593665686757934951,62176457141856560629502157223196586755079324193331,64906352462741904929101432445813822663347944758178,92575867718337217661963751590579239728245598838407,58203565325359399008402633568948830189458628227828,80181199384826282014278194139940567587151170094390,35398664372827112653829987240784473053190104293586,86515506006295864861532075273371959191420517255829,71693888707715466499115593487603532921714970056938,54370070576826684624621495650076471787294438377604,53282654108756828443191190634694037855217779295145,36123272525000296071075082563815656710885258350721,45876576172410976447339110607218265236877223636045,17423706905851860660448207621209813287860733969412,81142660418086830619328460811191061556940512689692,51934325451728388641918047049293215058642563049483,62467221648435076201727918039944693004732956340691,15732444386908125794514089057706229429197107928209,55037687525678773091862540744969844508330393682126,18336384825330154686196124348767681297534375946515,80386287592878490201521685554828717201219257766954,78182833757993103614740356856449095527097864797581,16726320100436897842553539920931837441497806860984,48403098129077791799088218795327364475675590848030,87086987551392711854517078544161852424320693150332,59959406895756536782107074926966537676326235447210,69793950679652694742597709739166693763042633987085,41052684708299085211399427365734116182760315001271,65378607361501080857009149939512557028198746004375,35829035317434717326932123578154982629742552737307,94953759765105305946966067683156574377167401875275,88902802571733229619176668713819931811048770190271,25267680276078003013678680992525463401061632866526,36270218540497705585629946580636237993140746255962,24074486908231174977792365466257246923322810917141,91430288197103288597806669760892938638285025333403,34413065578016127815921815005561868836468420090470,23053081172816430487623791969842487255036638784583,11487696932154902810424020138335124462181441773470,63783299490636259666498587618221225225512486764533,67720186971698544312419572409913959008952310058822,95548255300263520781532296796249481641953868218774,76085327132285723110424803456124867697064507995236,37774242535411291684276865538926205024910326572967,23701913275725675285653248258265463092207058596522,29798860272258331913126375147341994889534765745501,18495701454879288984856827726077713721403798879715,38298203783031473527721580348144513491373226651381,34829543829199918180278916522431027392251122869539,40957953066405232632538044100059654939159879593635,29746152185502371307642255121183693803580388584903,41698116222072977186158236678424689157993532961922,62467957194401269043877107275048102390895523597457,23189706772547915061505504953922979530901129967519,86188088225875314529584099251203829009407770775672,11306739708304724483816533873502340845647058077308,82959174767140363198008187129011875491310547126581,97623331044818386269515456334926366572897563400500,42846280183517070527831839425882145521227251250327,55121603546981200581762165212827652751691296897789,32238195734329339946437501907836945765883352399886,75506164965184775180738168837861091527357929701337,62177842752192623401942399639168044983993173312731,32924185707147349566916674687634660915035914677504,99518671430235219628894890102423325116913619626622,73267460800591547471830798392868535206946944540724,76841822524674417161514036427982273348055556214818,97142617910342598647204516893989422179826088076852,87783646182799346313767754307809363333018982642090,10848802521674670883215120185883543223812876952786,71329612474782464538636993009049310363619763878039,62184073572399794223406235393808339651327408011116,66627891981488087797941876876144230030984490851411,60661826293682836764744779239180335110989069790714,85786944089552990653640447425576083659976645795096,66024396409905389607120198219976047599490197230297,64913982680032973156037120041377903785566085089252,16730939319872750275468906903707539413042652315011,94809377245048795150954100921645863754710598436791,78639167021187492431995700641917969777599028300699,15368713711936614952811305876380278410754449733078,40789923115535562561142322423255033685442488917353,44889911501440648020369068063960672322193204149535,41503128880339536053299340368006977710650566631954,81234880673210146739058568557934581403627822703280,82616570773948327592232845941706525094512325230608,22918802058777319719839450180888072429661980811197,77158542502016545090413245809786882778948721859617,72107838435069186155435662884062257473692284509516,20849603980134001723930671666823555245252804609722,53503534226472524250874054075591789781264330331690".Split(",")
        Dim Sum As BigInteger = 0

        For i As Integer = 0 To Numeros.Length - 1
            Sum += Numeros(i)
        Next

        Console.WriteLine(Sum.ToString.Substring(0, 10))
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

    Sub Problem15() 'How many such routes are there through a 20×20 grid?
        Dim Size As Integer = 20
        Dim Grid(Size + 1, Size + 1) As BigInteger

        For i As Integer = Size To 0 Step -1
            Grid(i, Size) = 1
            Grid(Size, i) = 1
        Next

        For i As Integer = Size - 1 To 0 Step -1
            For j As Integer = Size - 1 To 0 Step -1
                Grid(i, j) = Grid(i + 1, j) + Grid(i, j + 1)
            Next
        Next
        Console.WriteLine(Grid(0, 0))
        Console.ReadKey()
    End Sub

    Sub Problem16() 'What is the sum of the digits of the number 2^1000?
        Dim Exp As BigInteger = 2 ^ 1000
        Dim StrExp As String = Exp.ToString

        Console.WriteLine(SumaDigitos(StrExp))
        Console.ReadKey()
    End Sub


    Sub Problem18() 'Find the maximum total from top to bottom in p018_piramid.txt
        Dim Piramid(,) As Integer = readMatrix("p018_piramid.txt", " ")

        For i As Integer = Piramid.GetUpperBound(0) - 1 To 0 Step -1
            For j As Integer = 0 To Piramid.GetUpperBound(1) - 1
                Piramid(i, j) = Piramid(i, j) + Math.Max(Piramid(i + 1, j), Piramid(i + 1, j + 1))
            Next
        Next

        Console.WriteLine(Piramid(0, 0))
        Console.ReadKey()
    End Sub


    Sub Problem20() 'Find the sum of the digits in the number 100!
        Dim Fact As BigInteger = Factorial(100)
        Dim StrFact As String = Fact.ToString

        Console.WriteLine(SumaDigitos(StrFact))
        Console.ReadKey()
    End Sub


    Sub Problem25() 'What is the first term in the Fibonacci sequence to contain 1000 digits?
        Dim FibNum1 As BigInteger = 1
        Dim FibNum2 As BigInteger = 1
        Dim FibNum3 As BigInteger = 0
        Dim Cont As Integer = 2

        While FibNum3.ToString.Length < 1000
            FibNum3 = FibNum1 + FibNum2
            FibNum1 = FibNum2
            FibNum2 = FibNum3
            Cont += 1
        End While

        Console.WriteLine(Cont)
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

    Sub Problem30() 'Find the sum of all the numbers that can be written as the sum of fifth powers of their digits
        Dim Encontrados As New List(Of Integer)

        For i As Integer = 2 To 1000000
            If SumaDigitos(i, 5) = i Then
                Encontrados.Add(i)
            End If
        Next

        Console.WriteLine(Encontrados.Sum)
        Console.ReadKey()
    End Sub


    Sub Problem34() 'Find the sum of all numbers which are equal to the sum of the factorial of their digits
        Dim Numbers As New List(Of Integer)
        Dim Number As String
        Dim Sum As BigInteger = 0
        For i As Integer = 3 To 100000
            Number = i
            While Number.Length > 0
                Sum += Factorial(Number.Substring(0, 1))
                Number = Number.Substring(1)
            End While
            If i = Sum Then
                Numbers.Add(i)
            End If
            Sum = 0
        Next

        Console.WriteLine(Numbers.Sum)
        Console.ReadKey()
    End Sub

    Sub Problem35() 'How many circular primes are there below one million?
        Dim CircularPrimes As List(Of Integer) = New List(Of Integer)
        Dim Primos As List(Of Long) = New List(Of Long)
        Dim Permutacion As String = 0
        Dim esCircular As Boolean = True

        For i As Integer = 2 To 1000000
            If i = 101 Then
                esCircular = True
            End If
            If esPrimo(i, Primos) Then
                Primos.Add(i)
                Permutacion = i
                Do
                    Permutacion = permutar(Permutacion)
                    If Not esPrimo(Permutacion) Then
                        esCircular = False
                    End If
                Loop Until (Permutacion = i) Or Not esCircular
                If esCircular Then
                    CircularPrimes.Add(i)
                End If
            End If
            esCircular = True
        Next

        Console.WriteLine(CircularPrimes.Count)
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

    Sub Problem37() 'Find the sum of the only eleven primes that are both truncatable from left to right and right to left
        Dim TruncatablePrimes As List(Of Integer) = New List(Of Integer)
        Dim Primos As List(Of Long) = New List(Of Long) From {2, 3, 5, 7}
        Dim i As Integer = 10

        While TruncatablePrimes.Count < 11
            If esPrimo(i, Primos) Then
                Primos.Add(i)
                If isPrimeTruncateRight(i, Primos) Then
                    If isPrimeTruncateleft(i, Primos) Then
                        TruncatablePrimes.Add(i)
                    End If
                End If
            End If
            i += 1
        End While

        Console.WriteLine(TruncatablePrimes.Sum)
        Console.ReadKey()
    End Sub


    Sub Problem39() 'If P=perimeter of a right angle triangle and a,b,c their sides lengths. For which value of p ≤ 1000, is the number of solutions maximised?
        Dim Solutions As Integer
        Dim MaxSolutions As Integer = 0
        Dim MaxP As Integer = 0
        Dim c As Integer

        For i As Integer = 3 To 1000
            Solutions = 0
            For a As Integer = 1 To i
                For b As Integer = 1 To i - a
                    c = i - a - b
                    If ((a ^ 2) + (b ^ 2) = (c ^ 2)) Then
                        Solutions += 1
                    End If
                Next
            Next
            If Solutions > MaxSolutions Then
                MaxP = i
                MaxSolutions = Solutions
            End If
        Next

        Console.WriteLine(MaxP)
        Console.ReadKey()
    End Sub

    Sub Problem40()
        Dim BigN As String = String.Empty
        Dim Ans As BigInteger = 1
        Dim i As Integer = 1
        Do
            BigN &= i.ToString
            i += 1
        Loop Until BigN.Length >= 1000000

        Ans *= CInt(BigN.Substring(0, 1)) * CInt(BigN.Substring(9, 1)) * CInt(BigN.Substring(99, 1)) * CInt(BigN.Substring(999, 1)) * CInt(BigN.Substring(9999, 1)) * CInt(BigN.Substring(99999, 1)) * CInt(BigN.Substring(999999, 1))

        Console.WriteLine(Ans)
        Console.ReadKey()
    End Sub

    Sub Problem41() 'What is the largest n-digit pandigital prime that exists?
        Dim PandigitalPrime As Integer = 0

        For i As Integer = 1 To 1000000000
            If isPandigital(i) Then
                If esPrimo(i) Then
                    PandigitalPrime = i
                End If
            End If
        Next

        Console.WriteLine(PandigitalPrime)
        Console.ReadKey()
    End Sub


    Sub Problem44()
        Dim D As Integer = 999999999
        Dim suma As Integer, resta As Integer

        For j As Integer = 1 To 5000
            For k As Integer = 1 To j
                suma = pentagonalNumber(j) + pentagonalNumber(k)
                resta = Math.Abs(pentagonalNumber(j) - pentagonalNumber(k))
                If isPentagonal(suma) Then
                    If isPentagonal(resta) Then
                        If resta < D Then
                            D = resta
                        End If
                    End If
                End If
            Next
        Next

        Console.WriteLine(D)
        Console.ReadKey()
    End Sub


    Sub Problem48() 'Find the last ten digits of the series, 11 + 22 + 33 + ... + 10001000.
        Dim s As BigInteger = 0
        For i As Integer = 1 To 1000
            s += BigInteger.Pow(i, i)
        Next
        Console.WriteLine(s.ToString.Substring(s.ToString.Length - 10))
        Console.ReadKey()
    End Sub


    Sub Problem52() 'Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits
        Dim i As Integer = 1, j As Integer
        Dim AuxI() As Char, AuxJ() As Char

        Do
            AuxI = i.ToString.ToCharArray
            j = 2 * i
            AuxJ = j.ToString.ToCharArray
            Array.Sort(AuxI)
            Array.Sort(AuxJ)
            If AuxI = AuxJ Then
                j = 3 * i
                AuxJ = j.ToString.ToCharArray
                Array.Sort(AuxJ)
                If AuxI = AuxJ Then
                    j = 4 * i
                    AuxJ = j.ToString.ToCharArray
                    Array.Sort(AuxJ)
                    If AuxI = AuxJ Then
                        j = 5 * i
                        AuxJ = j.ToString.ToCharArray
                        Array.Sort(AuxJ)
                        If AuxI = AuxJ Then
                            j = 2 * i
                            AuxJ = j.ToString.ToCharArray
                            Array.Sort(AuxJ)
                            If AuxI = AuxJ Then
                                Exit Do
                            End If
                        End If
                    End If
                End If
            End If
            i += 1
        Loop

        Console.WriteLine(i)
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

    Sub Problem56() 'Considering natural numbers of the form, ab, where a, b < 100, what is the maximum digital sum?
        Dim Num As BigInteger
        Dim Sum As Integer = 0
        Dim SumAux As Integer

        For a As Integer = 1 To 100
            For b As Integer = 1 To 100
                Num = BigInteger.Pow(a, b)
                SumAux = SumaDigitos(Num.ToString)
                If SumAux > Sum Then
                    Sum = SumAux
                End If
            Next
        Next

        Console.WriteLine(Sum)
        Console.ReadKey()
    End Sub

    Sub Problem67() 'Find the maximum total from top to bottom in p067_piramid.txt
        Dim Piramid(,) As Integer = readMatrix("p067_piramid.txt", " ")

        For i As Integer = Piramid.GetUpperBound(0) - 1 To 0 Step -1
            For j As Integer = 0 To Piramid.GetUpperBound(1) - 1
                Piramid(i, j) = Piramid(i, j) + Math.Max(Piramid(i + 1, j), Piramid(i + 1, j + 1))
            Next
        Next

        Console.WriteLine(Piramid(0, 0))
        Console.ReadKey()
    End Sub


    Sub Problem69() 'Find the value of n ≤ 1,000,000 for which n/φ(n) is a maximum.
        Dim Primos As List(Of Long) = New List(Of Long)
        Primos.Add(2)

        For i As Long = 3 To 1000000 Step 2
            If esPrimo(i, Primos) Then
                Primos.Add(i)
                If Primos.Aggregate(1, Function(x, y) x * y) > 1000000 Then
                    Exit For
                End If
            End If
        Next

        Primos.RemoveAt(Primos.Count - 1)

        Console.WriteLine(Primos.Aggregate(1, Function(x, y) x * y))
        Console.ReadKey()
    End Sub

    Sub Problem70() 'Find the value of n, 1 < n < 107, for which φ(n) is a permutation of n and the ratio n/φ(n) produces a minimum.
        Dim Best As Long = 1
        Dim phiBest As Long = 1
        Dim bestRatio As Double = Double.PositiveInfinity
        Dim Limit As BigInteger = BigInteger.Pow(10, 7)
        Dim Primos As List(Of Long) = New List(Of Long)
        For i As Long = 2001 To 5000 Step 2
            If esPrimo(i) Then
                Primos.Add(i)
            End If
        Next

        For i As Integer = 1 To Primos.Count - 1
            For j As Integer = i + 1 To Primos.Count - 1
                Dim N As Long = Primos(i) * Primos(j)
                If (N > Limit) Then Exit For

                Dim phii As Long = (Primos(i) - 1) * (Primos(j) - 1)
                Dim Ratio As Double = CDbl(N) / phii

                If (sonPermutados(N, phii) And bestRatio > Ratio) Then
                    Best = N
                    phiBest = phii
                    bestRatio = Ratio
                End If
            Next
        Next

        Console.WriteLine("Best: " & Best)
        Console.WriteLine("Best ratio: " & bestRatio)
        Console.ReadKey()
    End Sub


    Sub Problem74() 'How many chains, with a starting number below one million, contain exactly sixty non-repeating terms?
        Dim Count As Integer = 0
        Dim Chain As List(Of Integer) = New List(Of Integer)
        Dim Limit As Integer = 1000000

        For n As Integer = 1 To Limit
            Chain.Add(n)
            While Chain.Count <= 60000
                Dim Sum As Integer = 0
                Dim Number As String = Chain(Chain.Count - 1)
                While Number.Length > 0
                    Sum += Factorial(Number.Substring(0, 1))
                    Number = Number.Substring(1)
                End While
                If Chain.Contains(Sum) Then
                    Exit While
                End If
                Chain.Add(Sum)
            End While
            If Chain.Count.Equals(60) Then
                Count += 1
            End If
            Chain.Clear()
        Next

        Console.WriteLine(Count)
        Console.ReadKey()
    End Sub


    Sub Problem81() 'Find the minimal path sum in p081_matrix.txt from the top left to the bottom right by only moving right and down
        Dim Matrix(,) As Integer = readMatrix("p081_matrix.txt", ",")
        Dim lastRow = Matrix.GetUpperBound(0)
        Dim lastColumn = Matrix.GetUpperBound(1)

        For i As Integer = lastRow - 1 To 0 Step -1
            Matrix(i, lastColumn) += Matrix(i + 1, lastColumn)
        Next
        For i As Integer = lastColumn - 1 To 0 Step -1
            Matrix(lastRow, i) += Matrix(lastRow, i + 1)
        Next

        For i As Integer = lastRow - 1 To 0 Step -1
            For j As Integer = lastColumn - 1 To 0 Step -1
                Matrix(i, j) += Math.Min(Matrix(i + 1, j), Matrix(i, j + 1))
            Next
        Next

        Console.WriteLine(Matrix(0, 0))
        Console.ReadKey()
    End Sub
End Module
