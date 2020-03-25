Module Module1
    'Input: an array Of integers.
    'Output: this array, but sorted In such a way that there are two wings:
    '=the left wing With numbers decreasing,
    '=the right wing With numbers increasing.
    '=the two wings have the same length. 
    'If the length Of the array Is odd the wings are around the bottom,
    'If the length Is even the bottom Is considered To be part Of the right wing.

    '// no solution for below instruction right now
    '=each integer l of the left wing must be greater 
    'Or equal to its counterpart r in the right wing, the difference l - r being as small as possible.
    'In other words the right wing must be nearly as steep as the left wing.

    Function descendingOrder(ByVal x As Integer, ByVal y As Integer) As Integer
        Return -(x.CompareTo(y))
    End Function
    Function AscendingOrder(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x.CompareTo(y)
    End Function
    Sub leftWingRightWing(ByVal array1() As Integer)
        Dim lenArray = array1.Length
        Dim bottom As Integer
        Dim leftWing() As Integer
        Dim rightWing() As Integer
        Dim even As Boolean = If(lenArray Mod 2 = 0, True, False)
        If even Then
            bottom = CInt(lenArray / 2)
            ReDim leftWing(bottom - 1)
            ReDim rightWing(bottom - 1)
            Array.Copy(array1, 0, leftWing, 0, bottom)
            Array.Copy(array1, bottom, rightWing, 0, bottom)
        Else
            bottom = CInt(lenArray / 2) - 1
            ReDim leftWing(bottom - 1)
            ReDim rightWing(bottom - 1)
            Array.Copy(array1, 0, leftWing, 0, bottom)
            Array.Copy(array1, bottom + 1, rightWing, 0, bottom)
        End If
        Array.Sort(leftWing, New Comparison(Of Integer)(AddressOf descendingOrder))
        Array.Sort(rightWing, New Comparison(Of Integer)(AddressOf AscendingOrder))
        Dim mergeArray(lenArray - 1) As Integer
        If even Then
            Array.Copy(leftWing, mergeArray, bottom)
            Array.Copy(rightWing, 0, mergeArray, bottom, bottom)
        Else
            Array.Copy(leftWing, mergeArray, bottom)
            Array.Copy({array1(bottom)}, 0, mergeArray, bottom, 1)
            Array.Copy(rightWing, 0, mergeArray, bottom + 1, bottom)
        End If
        For Each item As Integer In mergeArray
            Console.WriteLine(item.ToString)
        Next
    End Sub
    Sub Main()
        leftWingRightWing({17, 17, 15, 14, 8, 7, 7, 5, 4, 4, 1})
        Console.ReadKey()
    End Sub

End Module
