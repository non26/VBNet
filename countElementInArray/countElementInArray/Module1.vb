Module Module1
    ' count element in the given array, if each element in the array occur only 2 times 
    ' then return 1 else return 0
    Function countElement(ByVal given() As Integer) As Integer
        Dim lenGiven As Integer = given.Length
        Dim keepTwoTime(lenGiven) As String
        Dim indexOfKeep As Integer = 0
        For Each item As Integer In given
            If keepTwoTime.Contains(item.ToString) Then
                Continue For
            End If
            Dim count As Integer = 0
            Dim startRange As Integer = -1
            Do While True
                Dim index As Integer = Array.IndexOf(given, item, startRange + 1)
                If index <> -1 Then
                    count = count + 1
                    startRange = index
                    If count > 2 Then
                        Return 0
                    End If
                Else
                    Exit Do
                End If
            Loop
            If count = 2 Then
                keepTwoTime(indexOfKeep) = given.GetValue(startRange).ToString
                indexOfKeep += 1
            Else
                Return 0
            End If
        Next
        Return 1
    End Function
    Sub Main()
        Dim result As Integer = countElement({1, 2, 3, 3, 2, 1, 4, 5})
        Console.WriteLine(result)
        Console.ReadKey()
    End Sub
End Module