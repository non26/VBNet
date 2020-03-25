Module Module1
    '3.given the array of integer such as {1,2,3,4,5} 
    'And the integer of k such as 9 if the sum of last n elements Is 9 then return 1 else 0 Like
    '{1,2,3,4,5}, k=9 And 4+5 = 9 then return 1
    '{} then  return 0
    '{1,2,3,5,6}, k = 14 And 6+5+3 = 14 then return 1
    '{-1,1,-1,1,0,1}, k=1 And 1=k And 1+0+1+-1 = 1 then get the shortest
    Function sumOfNArray(ByVal k As Integer, ByVal array1() As Integer) As Integer
        Dim lenArray As Integer = array1.Length
        Dim numberOfElement As Integer = 1
        'Dim keep(lenArray)() As Integer
        For round As Integer = 0 To lenArray - 1
            Dim total As Integer = 0
            Dim keepResult(numberOfElement - 1) As Integer
            For number As Integer = 1 To numberOfElement
                Dim element As Integer = array1.GetValue(lenArray - number)
                'keepResult(numberOfElement - number) = element
                total += element
            Next
            If total = k Then
                'Array.Copy(keepResult, keep(round), keepResult.Length)
                Return 1
            Else
                numberOfElement += 1
                Continue For
            End If
        Next
        'Dim indexOfMin As Integer = keep.Length + 1
        Return 0
    End Function
    Sub Main()
        Dim result As Integer = sumOfNArray(5, {1, 2, 4, 10, -5})
        Console.WriteLine(result)
        Console.ReadKey()
    End Sub

End Module
