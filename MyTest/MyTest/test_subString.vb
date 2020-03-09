Module test_subString
    Sub testSubString()
        Dim testSubString As String = "Chanog"
        Dim len As Integer = testSubString.Length
        Console.WriteLine(testSubString.Substring(len - 1, 1))
    End Sub
End Module
