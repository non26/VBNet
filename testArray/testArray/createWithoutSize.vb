Module createWithoutSize
    Public Sub createArrayWithoutSize()
        Dim test() As Integer = New Integer() {}
        Dim size As Integer = 1
        For i As Integer = 1 To 5
            ReDim Preserve test(size)
            test(i) = 99
            size = size + 1
        Next
        For Each item As Integer In test
            Console.WriteLine(item.ToString) ' first element will be the defalut value, zero
        Next
    End Sub

End Module
