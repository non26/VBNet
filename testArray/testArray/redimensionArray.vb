Module redimensionArray
    Sub testRedimension()

        '' this error because we didn't yet create the array object, so the array1 reference to Null
        'Dim array1() As Integer
        'array1(0) = 1
        'For Each item As Integer In array1
        '    Console.Write(item.ToString + " ")
        'Next

        '' this also error generating "System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'"
        '' because we instantiate it with an empty array , so we need to redimension it
        'Dim array1() As Integer = New Integer() {}
        'array1(0) = 1
        'array1(1) = 1
        'array1(2) = 1
        'For Each item As Integer In array1
        '    Console.Write(item.ToString + " ")
        'Next

        Dim array1() As Integer = New Integer() {}
        ReDim array1(2)
        array1(0) = 1
        array1(1) = 1
        array1(2) = 1
        For Each item As Integer In array1
            Console.Write(item.ToString + " ")
        Next
        ReDim Preserve array1(4)
        array1(3) = 11
        array1(4) = 11
        Console.WriteLine()
        For Each item As Integer In array1
            Console.Write(item.ToString + " ")
        Next


    End Sub

End Module
