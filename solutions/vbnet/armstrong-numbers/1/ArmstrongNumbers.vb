Public Module ArmstrongNumbers
    Public Function IsArmstrongNumber(ByVal number As Integer) As Boolean
        Dim numberString As String = number.ToString()
        Dim digitCount As Integer = numberString.length
        Dim digitsSquareSum As Integer = 0

        For Each digit As Char In numberString
            digitsSquareSum += CInt(digit.ToString()) ^ digitCount
        Next

        If number = digitsSquareSum Then Return True

        Return False
    End Function
End Module
