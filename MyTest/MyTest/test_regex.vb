Imports System.Text.RegularExpressions
Module test_regex
    Public Sub matchPatern()
        Dim regObj As Regex = New Regex("LAST_PERIOD[\s:]+MONTH[\s-]*([a-zA-Z0-9]*)")
        Dim matchObj As Match = regObj.Match("LAST_PERIOD :MONTH AS098")
        Console.WriteLine(matchObj.Success)
    End Sub

End Module
