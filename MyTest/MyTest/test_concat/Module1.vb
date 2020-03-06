Module Module1
    Sub Main()
        Dim string1 As String = "Cha"
        Dim string2 As String = "non"
        'Dim result As String = string1.Concat(string2)
        string1 = String.Concat(string1, string2)
        Console.WriteLine("test" + string1)
        'Console.WriteLine("test concat" + result)
        Console.ReadLine()
    End Sub
End Module
