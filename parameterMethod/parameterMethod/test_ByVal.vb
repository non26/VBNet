Public Class test_ByVal
    Shared Function testByVal(ByVal x As Integer, ByVal y() As Integer)
        x = 4
        Console.WriteLine(x)
        Console.WriteLine("Before changing the array")
        For Each item As Integer In y
            Console.Write(item.ToString() + " ")
        Next
        y(0) = 100
        Console.WriteLine()
        Console.WriteLine("After changing the array")
        For Each item As Integer In y
            Console.Write(item.ToString() + " ")
        Next
        Console.WriteLine()
    End Function

End Class
