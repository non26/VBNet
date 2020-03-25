Module createArray
    Sub createArray()
        Dim array1() As Integer = New Integer() {1}
        Dim array2() As Integer = New Integer(1) {2, 2} ' this declare size of array of 1+1 = 2
        Dim array3() As Integer = {3, 3, 3}
        Console.WriteLine("array1")
        For Each item As Integer In array1
            Console.Write(item.ToString + " ")
        Next
        Console.WriteLine()
        Console.WriteLine("array2")
        For Each item As Integer In array2
            Console.Write(item.ToString + " ")
        Next
        Console.WriteLine()
        Console.WriteLine("array3")
        For Each item As Integer In array3
            Console.Write(item.ToString + " ")
        Next
        Console.WriteLine()
        Console.WriteLine("array4")
        Dim array4() As Integer = New Integer(3) {}
        For index As Integer = 0 To 3
            array4(index) = 4
        Next
        For Each item As Integer In array4
            Console.Write(item.ToString + " ")
        Next
    End Sub

End Module
