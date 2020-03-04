Module findUpperWords
    Function LongStr(ByVal x As String) As String
        ' this method is used to convert long string separated by space
        ' to the long string that each word is upper case
        Dim longString As String = ""
        Dim sep As Char = " "
        For Each ch As String In x.Split(sep)
            Dim len As Integer = ch.Length
            longString += String.Concat(ch.Substring(0, 1).ToUpper(), ch.Substring(1, len - 1))
        Next
        ' stringArray = x.Split(New Char(){" "c})
        Return longString
    End Function
    Function countUpperCase(ByRef x As String) As Integer
        Dim totalWords As Integer
        'Asc(Char) convert that Char type to the order in Ascii
        Dim a As Integer = Asc("A")
        Dim z As Integer = Asc("Z")
        For index As Integer = a To z
            Dim start As Integer = 0
            Dim result As Integer
            Do While True
                ' Chr(integer) convert that integer to the ascii value
                result = InStr(start + 1, x, Chr(index))
                If result <> 0 Then
                    start = result
                    totalWords += 1
                    Continue Do
                Else
                    Exit Do
                End If
            Loop
        Next
        countUpperCase = totalWords
    End Function
    Sub Main()
        Dim numberUpper As Integer = countUpperCase("ChanonEiemrodIsCute")
        'Console.WriteLine("[{0}]", String.Join(", ", test))
        Console.WriteLine(numberUpper)
        Dim lString As String = LongStr("chanon eiemrod is cute")
        Console.WriteLine(lString)
        Console.ReadKey()
    End Sub

End Module
