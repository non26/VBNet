Module changeElement
    Sub testChangeElement()
        Dim array1() As Integer = New Integer() {1, 2, 3, 4, 5}
        array1(0) = 6 ' this work is fine
        Console.WriteLine("change item in the array")
        For Each item As Integer In array1
            Console.Write(item.ToString + " ")
        Next
    End Sub
End Module
