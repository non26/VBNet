Module jaggedArray
    Sub jaggedArray1()
        Dim test As Integer()() = New Integer(3)() {}
        test(0) = {1, 2, 3}
        test(1) = {1, 2}
        ' we declare the size of jagged array of 3 but add 2 arrays in it, 
        ' so last index will point to null and cause nullReferenceException
        For Each subArray In test
            'For Each item As Integer In subArray
            '    Console.Write(item + " ")
            'Next
            Console.WriteLine(subArray.Length)
            Console.WriteLine()
        Next
    End Sub
End Module
