Module Recursos
    Friend Structure Punto
        Dim X As Integer
        Dim Y As Integer
    End Structure
    Friend Structure Vector
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
    End Structure


    'Funciones con Primos
    Friend Function generarPrimos(ByVal fin As Integer) As List(Of Long)
        Dim Primos As List(Of Long) = New List(Of Long) From {2}
        Dim sieveBound As Integer = CInt((fin - 1) / 2)
        Dim finSqrt As Integer = CInt((Math.Sqrt(fin) - 1) / 2)

        Dim PrimeBits As BitArray = New BitArray(sieveBound + 1, True)

        For i As Integer = 1 To finSqrt
            If PrimeBits.Get(i) Then
                For j As Integer = i * 2 * (i + 1) To sieveBound Step (2 * i + 1)
                    PrimeBits.Set(j, False)
                Next
            End If
        Next

        For i As Integer = 1 To sieveBound
            If PrimeBits.Get(i) Then
                Primos.Add(2 * i + 1)
            End If
        Next

        Return Primos
    End Function

    Friend Function esPrimo(ByVal Num As Long) As Boolean
        If Num > 1 Then
            For i As Integer = 2 To CInt(Num \ 2)
                If (Num Mod i) = 0 Then
                    Return False
                End If
            Next
        Else
            Return False
        End If
        Return True
    End Function

    Friend Function esPrimo(ByVal Num As Long, ByRef Primos As List(Of Long)) As Boolean
        If Num > 1 Then
            For Each Primo As Long In Primos
                If Primo * Primo <= Num Then
                    If (Num Mod Primo) = 0 Then
                        Return False
                    End If
                End If
            Next
        Else
            Return False
        End If
        Return True
    End Function

    Friend Function isPrimeTruncateRight(ByVal Numero As String, ByRef Primos As List(Of Long)) As Boolean
        While Numero.Length > 0
            If Not esPrimo(CLng(Numero), Primos) Then
                Return False
            End If
            Numero = Numero.Substring(1)
        End While
        Return True
    End Function

    Friend Function isPrimeTruncateLeft(ByVal Numero As String, ByRef Primos As List(Of Long)) As Boolean
        While Numero.Length > 0
            If Not esPrimo(CLng(Numero), Primos) Then
                Return False
            End If
            Numero = Numero.Substring(0, Numero.Length - 1)
        End While
        Return True
    End Function

    Friend Function SumOfFactors(ByVal Number As Integer) As Integer
        Dim Sum As Integer = 0
        For i As Integer = 1 To Number \ 2
            If (Number Mod i) = 0 Then
                Sum += i
            End If
        Next

        Return Sum
    End Function


    '---------------------------------------------------------------------------------------------------'
    'Operaciones con números
    Friend Function Factorial(ByVal Num As Integer) As BigInteger
        Dim Ans As BigInteger = 1
        For i As Integer = 2 To Num
            Ans *= i
        Next
        Return Ans
    End Function

    Friend Function phi(ByVal N As Integer) As Integer
        Dim Cant As Integer = 0
        For i As Integer = 1 To N
            If mcd(N, i) = 1 Then
                Cant += 1
            End If
        Next
        Return Cant
    End Function

    Friend Function mcd(ByVal a As Integer, ByVal b As Integer) As Integer
        If b = 0 Then
            Return a
        Else
            Return mcd(b, a Mod b)
        End If
    End Function

    Friend Function SquareRootDecimal(ByVal N As Integer, ByVal precision As Integer) As BigInteger
        Dim Limit As BigInteger = BigInteger.Pow(10, precision + 1)
        Dim a As BigInteger = 5 * N
        Dim b As BigInteger = 5

        While (b < Limit)
            If (a >= b) Then
                a -= b
                b += 10
            Else
                a *= 100
                b = (b / 10) * 100 + 5
            End If
        End While

        Return (b / 100)
    End Function

    Friend Function combinatory(ByVal N As Integer, ByVal R As Integer) As BigInteger
        Return (Factorial(N) / (Factorial(R) * Factorial(N - R)))
    End Function

    Friend Function SumaDigitos(ByVal Num As String) As ULong
        Dim Sum As ULong = 0

        While Num.Length > 0
            Sum += CULng(Num.Substring(0, 1))
            Num = Num.Substring(1)
        End While

        Return Sum
    End Function

    Friend Function SumaDigitos(ByVal Num As String, ByVal Exp As Integer) As ULong
        Dim Sum As ULong = 0

        While Num.Length > 0
            Sum += CULng((CInt(Num.Substring(0, 1))) ^ Exp)
            Num = Num.Substring(1)
        End While

        Return Sum
    End Function

    Friend Function cantidadFactores(ByVal Num As ULong) As Integer
        Dim a As Integer = 1
        For i As Integer = 2 To CInt(Math.Sqrt(Num))
            If (Num Mod i) = 0 Then
                a += 1
            End If
        Next
        Return (a * 2) - 1
    End Function

    Friend Function permutarRotar(ByVal Numero As String) As String
        Numero = (Numero.Substring(1) & Numero.Substring(0, 1))
        Return Numero
    End Function

    Friend Function getDivisors(ByVal Numero As Integer) As List(Of Integer)
        Dim Ans As List(Of Integer) = New List(Of Integer)

        For i As Integer = 1 To Numero \ 2
            If (Numero Mod i) = 0 Then
                Ans.Add(i)
            End If
        Next
        Return Ans
    End Function

    Friend Function perimeter(ByVal A As Integer, ByVal B As Integer, ByVal C As Integer) As Integer
        Return A + B + C
    End Function

    Friend Function areaFromSides(ByVal A As Integer, ByVal B As Integer, ByVal C As Integer) As Decimal
        Dim P As Integer = perimeter(A, B, C)
        Return CDec(Math.Sqrt(P * (P - A) * (P - B) * (P - C)))
    End Function

    Friend Function last10bigMul(ByVal Base As BigInteger, ByVal Exp As Integer) As BigInteger
        Dim Ans As BigInteger = BigInteger.Multiply(Base, Exp)
        Dim Length As Integer = Ans.ToString.Length
        Dim Longitud As Integer = Length - Math.Min(Length, 10)

        Return Ans.ToString.Substring(Longitud)
    End Function


    '---------------------------------------------------------------------------------------------------'
    'Funciones geométricas
    Friend Function crossProduct(ByVal A As Punto, ByVal B As Punto) As Integer
        Return ((A.X * B.Y) - (A.Y * B.X))
    End Function

    Friend Function sameSide(ByVal P1 As Punto, ByVal P2 As Punto, ByVal A As Punto, ByVal B As Punto) As Boolean
        Dim V1 As Punto
        V1.X = B.X - A.X
        V1.Y = B.Y - A.Y
        Dim V2 As Punto
        V2.X = P1.X - A.X
        V2.Y = P1.Y - A.Y
        Dim V3 As Punto
        V3.X = P2.X - A.X
        V3.Y = P2.Y - A.Y
        Dim Cross1 As Integer = crossProduct(V1, V2)
        Dim Cross2 As Integer = crossProduct(V1, V3)
        Return Math.Sign(Cross1) = Math.Sign(Cross2)
    End Function

    Friend Function trianguloTieneAlOrigen(ByVal Vertice1 As Punto, ByVal Vertice2 As Punto, ByVal Vertice3 As Punto) As Boolean
        Dim Origen As Punto
        Origen.X = 0
        Origen.Y = 0
        Return (sameSide(Origen, Vertice1, Vertice2, Vertice3) And _
                sameSide(Origen, Vertice2, Vertice1, Vertice3) And _
                sameSide(Origen, Vertice3, Vertice1, Vertice2))
    End Function


    '---------------------------------------------------------------------------------------------------'
    'Checks con números
    Friend Function isPalindrome(ByVal Num As String) As Boolean
        Dim Reverse As String = StrReverse(Num)
        Return Num.Equals(Reverse)
    End Function

    Friend Function isLychrel(ByVal Num As Integer) As Boolean
        Dim Inverse As String
        For i As Integer = 1 To 50
            Inverse = StrReverse(Num.ToString)
            Num = Num + CInt(Inverse)
            If isPalindrome(Num.ToString) Then
                Return False
            End If
        Next
        Return True
    End Function

    Friend Function isPandigital(ByVal Number As String) As Boolean
        For i As Integer = 1 To Number.Length
            If Not contiene(Number, i.ToString) Then
                Return False
            End If
        Next
        Return True
    End Function

    Friend Function sonPermutados(ByVal a As String, ByVal b As String) As Boolean
        Dim ArrA() As Char = a.ToCharArray
        Dim Arrb() As Char = b.ToCharArray
        Array.Sort(ArrA)
        Array.Sort(Arrb)
        Return ArrA = Arrb
    End Function

    Friend Function isGoldbach(ByVal N As Integer, ByRef Primos As List(Of Long)) As Boolean
        Dim Ans As Boolean = False

        For i As Integer = CInt(Math.Sqrt(N)) To 1 Step -1
            For Each Primo As Long In Primos
                If (Primo + (2 * (i ^ 2))) = N Then
                    Ans = True
                    Exit For
                End If
            Next
        Next

        Return Ans
    End Function

    Friend Function isTwiceSquare(ByVal N As Long) As Boolean
        Dim squateTest As Double = Math.Sqrt(N / 2)
        Return (squateTest = CInt(squateTest))
    End Function

    Friend Function isIncreasing(ByVal Number As Integer) As Boolean
        Dim N As String = Number
        For i As Integer = 0 To N.Length - 2
            If N(i + 1) < N(i) Then
                Return (False)
            End If
        Next
        Return True
    End Function

    Friend Function isDecreasing(ByVal Number As Integer) As Boolean
        Dim N As String = Number
        For i As Integer = 0 To N.Length - 2
            If N(i + 1) > N(i) Then
                Return (False)
            End If
        Next
        Return True
    End Function

    Friend Function isBouncy(ByVal Number As Integer) As Boolean
        Return ((Not isIncreasing(Number)) And (Not isDecreasing(Number)))
    End Function

    Friend Function isLeapYear(ByVal anio As Integer) As Boolean
        If (anio Mod 4) > 0 Then
            Return False
        End If
        If (anio Mod 100) = 0 Then
            If (anio Mod 400) = 0 Then
                Return False
            End If
            Return True
        End If
        Return True
    End Function



    '---------------------------------------------------------------------------------------------------'
    'Números poligonales
    Friend Function triangularNumber(ByVal N As Integer) As Integer
        Return CInt((N * (N + 1)) / 2)
    End Function

    Friend Function pentagonalNumber(ByVal N As Integer) As Integer
        Return CInt((N * ((3 * N) - 1)) / 2)
    End Function

    Friend Function hexagonalNumber(ByVal N As Integer) As Integer
        Return (N * ((2 * N) - 1))
    End Function

    Friend Function isTriangular(ByVal N As Integer) As Boolean
        Dim Aux As Double = (Math.Sqrt(1 + 8 * N) + 1.0) / 2.0
        Return Aux = CInt(Aux)
    End Function

    Friend Function isSquare(ByVal Number As Integer) As Boolean
        Return (Math.Sqrt(Number) = Int(Math.Sqrt(Number)))
    End Function

    Friend Function isPentagonal(ByVal N As Integer) As Boolean
        Dim aux As Double = (Math.Sqrt(1 + 24 * N) + 1.0) / 6.0 'Función inversa a pentagonalNumber (aplicando cuadreatica)
        Return aux = CInt(aux)
    End Function

    Friend Function isHexagonal(ByVal N As Integer) As Boolean
        Dim Aux As Double = (Math.Sqrt(1 + 8 * N) + 1.0) / 4.0
        Return Aux = CInt(Aux)
    End Function


    '---------------------------------------------------------------------------------------------------'
    'Operaciones con letras
    Friend Function contiene(ByVal Cadena As String, ByVal Buscado As String) As Boolean
        For i As Integer = 0 To Cadena.Length - 1
            If Cadena.Substring(i, 1) = Buscado Then
                Return True
            End If
        Next
        Return False
    End Function

    Friend Function getValue(ByVal Palabra As String) As Integer
        Dim Total As Integer = 0
        For Each Caracter As Char In Palabra
            Total += Asc(Caracter) - 64
        Next
        Return Total
    End Function


    '---------------------------------------------------------------------------------------------------'
    'Funciones para input de txt
    Friend Function readMatrix(ByVal file As String, ByVal Separator As String) As Integer(,)
        Dim line As String
        Dim linePieces() As String
        Dim lines As Integer = 0

        Dim reader As IO.StreamReader = New IO.StreamReader(file)
        line = reader.ReadLine
        While Not line = Nothing
            lines += 1
            line = reader.ReadLine
        End While

        Dim inputTriangle(lines - 1, lines - 1) As Integer
        reader.BaseStream.Seek(0, IO.SeekOrigin.Begin)

        Dim j As Integer = 0
        line = reader.ReadLine
        While Not line = Nothing
            linePieces = line.Split(CChar(Separator))
            For i As Integer = 0 To linePieces.Length - 1
                inputTriangle(j, i) = Integer.Parse(linePieces(i))
            Next
            j += 1
            line = reader.ReadLine
        End While

        reader.Close()

        Return inputTriangle
    End Function

    Friend Function readWords(ByVal file As String, ByVal Separator As String) As List(Of String)
        Dim line As String

        Dim inputWords() As String
        Dim reader As IO.StreamReader = New IO.StreamReader(file)
        line = reader.ReadLine
        inputWords = Split(line, Separator)

        Dim Words As List(Of String) = New List(Of String)
        For Each Word As String In inputWords
            Word = Word.Trim(Chr(34))
            Words.Add(Word)
        Next

        reader.Close()

        Return Words
    End Function

    Friend Function readList(ByVal file As String) As Integer()
        Dim line As String
        Dim inputList As List(Of Integer) = New List(Of Integer)

        Dim reader As IO.StreamReader = New IO.StreamReader(file)
        line = reader.ReadLine
        While Not line = Nothing
            inputList.Add(CInt(line))
            line = reader.ReadLine
        End While

        reader.Close()
        Return inputList.ToArray
    End Function

    Friend Function readTriangle(ByVal file As String) As Integer(,)
        Dim line As String
        Dim linePieces() As String
        Dim lines As Integer = 0

        Dim reader As IO.StreamReader = New IO.StreamReader(file)
        line = reader.ReadLine
        While Not line = Nothing
            lines += 1
            line = reader.ReadLine
        End While

        Dim inputTriangle(lines - 1, 5) As Integer
        reader.BaseStream.Seek(0, IO.SeekOrigin.Begin)

        Dim j As Integer = 0
        line = reader.ReadLine
        While Not line = Nothing
            linePieces = line.Split(CChar(","))
            For i As Integer = 0 To linePieces.Length - 1
                inputTriangle(j, i) = Integer.Parse(linePieces(i))
            Next
            j += 1
            line = reader.ReadLine
        End While

        reader.Close()

        Return inputTriangle
    End Function


    '---------------------------------------------------------------------------------------------------'
End Module
