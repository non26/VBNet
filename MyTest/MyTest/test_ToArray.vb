Module test_ToArray
    Public Function aiInput(ByVal holder As Boolean) As String
        Dim starter As String = ""
        Dim characterArray As String() = {"C", "O"}
        Dim numberRandom As System.Random = New System.Random()
        Dim characterRandom As System.Random = New System.Random()
        For counter As Integer = 0 To 1
            Dim character As String = characterArray.GetValue(characterRandom.Next(0, 2))
            starter = String.Concat(starter, character)
        Next
        If (holder) Then
            Dim number As String = CStr(numberRandom.Next(0, 5))
            starter = String.Concat(starter, number)
        End If
        Return starter
    End Function

    Sub Main()
        'Dim testArray As Char() = "Chanon".ToArray()
        'Console.WriteLine(testArray.Count())

        'Dim testSubString As String = "Chanog"
        'Dim len As Integer = testSubString.Length
        'Console.WriteLine(testSubString.Substring(len - 1, 1))

        Console.WriteLine(aiInput(False))
        Console.ReadKey()
    End Sub

End Module
