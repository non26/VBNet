Module copyArray
    Sub copyArrayWithLengthEven(ByVal test() As Integer)
        Dim lenArray As Integer = test.Length
        Dim bottom As Integer = CInt(lenArray / 2)
        Dim left(bottom - 1) As Integer
        Dim right(bottom - 1) As Integer
        Array.Copy(test, 0, left, 0, bottom)
        Array.Copy(test, bottom, right, 0, bottom)
        For Each item As Integer In left
            Console.WriteLine($"even left wing {item.ToString}")
        Next
        For Each item As Integer In right
            Console.WriteLine($"even rigth wing {item.ToString}")
        Next
    End Sub
    Sub copyArrayWithLengthOdd(ByVal test() As Integer)
        Dim lenArray As Integer = test.Length
        Dim bottom As Integer = CInt(lenArray / 2) - 1 ' Cint() round number
        Dim left(bottom - 1) As Integer
        Dim right(bottom - 1) As Integer
        Array.Copy(test, 0, left, 0, bottom)
        Array.Copy(test, bottom + 1, right, 0, bottom)
        For Each item As Integer In left
            Console.WriteLine($"even left wing {item.ToString}")
        Next
        For Each item As Integer In right
            Console.WriteLine($"even rigth wing {item.ToString}")
        Next
    End Sub

End Module
