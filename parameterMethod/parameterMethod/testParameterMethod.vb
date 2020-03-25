Module testParameterMethod
    Sub call_test_byval()
        Dim ar1 As Integer = 3
        Dim ar2() As Integer = New Integer() {1, 2, 3, 4}
        test_ByVal.testByVal(ar1, ar2)
        Console.WriteLine("After changing the array 'ar2' in the test_byval")
        For Each item As Integer In ar2
            Console.Write(item.ToString() + " ")
        Next
        Console.WriteLine()
        Console.WriteLine(ar1)
    End Sub
    Sub call_test_byref()
        Dim ar1 As Integer = 3
        Dim ar2() As Integer = New Integer() {1, 2, 3, 4}
        test_byRef.testByRef(ar1, ar2)
        Console.WriteLine("After changing the array 'ar2' in the test_byref")
        For Each item As Integer In ar2
            Console.Write(item.ToString() + " ")
        Next
        Console.WriteLine()
        Console.WriteLine(ar1)
    End Sub
    Sub Main()
        call_test_byval()
        Console.WriteLine()
        call_test_byref()
        Console.ReadKey()
    End Sub
End Module
