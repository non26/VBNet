Module Module1
    '2.given the number as input 
    'such as 5 then square it Like 5*5 = 25 And the check that 
    'there's the presence of input in the result 
    Function countOccuranceInSquaer(ByVal x As Integer) As Integer
        Dim lenInput As Integer = x.ToString.Length
        Dim square As Integer = x * x
        Dim lenSquare As Integer = square.ToString.Length
        Dim occurance As Integer = CInt(square.ToString.Substring(lenSquare - lenInput, lenInput))
        If occurance = x Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Sub Main()
        Dim input As Integer = 9
        Console.WriteLine(countOccuranceInSquaer(input).ToString)
        Console.ReadKey()
    End Sub

End Module
