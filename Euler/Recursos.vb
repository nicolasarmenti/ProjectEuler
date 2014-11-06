Module Recursos
    Friend Function esPrimo(ByVal Num As Long) As Boolean
        For i As Integer = 2 To Num \ 2
            If (Num Mod i) = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Friend Function esPrimo(ByVal Num As Long, ByRef Primos As List(Of Long)) As Boolean
        If Num > 1 Then
            For Each Primo In Primos
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

    Friend Function isPalindrome(ByVal Num As String) As Boolean
        Dim Reverse As String = StrReverse(Num)
        Return Num.Equals(Reverse)
    End Function

    Friend Function factorQ(ByVal Num As ULong) As Integer
        Dim a As Integer = 1
        For i As Integer = 2 To CInt(Math.Sqrt(Num))
            If (Num Mod i) = 0 Then
                a += 1
            End If
        Next
        Return (a * 2) - 1
    End Function

    Friend Function isLychrel(ByVal Num As Decimal) As Boolean
        Dim Inverse As String
        For i As Integer = 1 To 50
            Inverse = StrReverse(Num.ToString)
            Num = Num + Inverse
            If isPalindrome(Num) Then
                Return False
            End If
        Next
        Return True
    End Function

    Friend Function Factorial(ByVal Num As Integer) As BigInteger
        Select Num
            Case 1, 0
                Return 1
            Case Else
                Return Factorial(Num - 1) * Num
        End Select
    End Function

    Friend Function SumaDigitos(ByVal Num As String) As Integer
        Dim Sum As ULong = 0

        While Num.Length > 0
            Sum += Num.Substring(0, 1)
            Num = Num.Substring(1)
        End While

        Return Sum
    End Function

    Friend Function SumaDigitos(ByVal Num As String, ByVal Exp As Integer) As Integer
        Dim Sum As ULong = 0

        While Num.Length > 0
            Sum += (CInt(Num.Substring(0, 1))) ^ Exp
            Num = Num.Substring(1)
        End While

        Return Sum
    End Function

    Friend Function permutar(ByVal Numero As String) As String
        Numero = (Numero.Substring(1) & Numero.Substring(0, 1))
        Return Numero
    End Function

    Friend Function isPrimeTruncateRight(ByVal Numero As String, ByRef Primos As List(Of Long)) As Boolean
        While Numero.Length > 0
            If Not esPrimo(Numero, Primos) Then
                Return False
            End If
            Numero = Numero.Substring(1)
        End While
        Return True
    End Function

    Friend Function isPrimeTruncateleft(ByVal Numero As String, ByRef Primos As List(Of Long)) As Boolean
        While Numero.Length > 0
            If Not esPrimo(Numero, Primos) Then
                Return False
            End If
            Numero = Numero.Substring(0, Numero.Length - 1)
        End While
        Return True
    End Function
End Module
