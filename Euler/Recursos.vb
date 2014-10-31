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
        For Each Primo In Primos
            If Primo * Primo <= Num Then
                If (Num Mod Primo) = 0 Then
                    Return False
                End If
            End If
        Next
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
End Module
