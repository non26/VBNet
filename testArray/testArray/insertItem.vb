Module insertItem
    Sub insertItemInArray()
        Dim a1(2) As Integer
        'a1(0) = 99
        'a1(0) = 88 means that change the value as index zero to 88
        'a1(0) = 77 result is {77,0,0} 
        a1(2) = 99
        a1(1) = 88
        a1(0) = 77
        For Each item As Integer In a1
            Console.WriteLine(item.ToString)
        Next
    End Sub
End Module
