Module test_concatenate
    Sub testConcat()
        Dim strX As String = ""
        For i As Integer = 1 To 10
            strX = strX + i.ToString()
        Next
        Console.WriteLine(strX)
    End Sub

End Module
