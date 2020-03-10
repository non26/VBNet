Module test_dictionary
    Public Function test_dictionary() As Dictionary(Of Integer, String)
        Dim dict1 As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
        ' Dim dict1 As New Dictionary(Of Integer, String)
        dict1.Add(1, "Cha")
        dict1.Add(2, "non")
        Return dict1
    End Function
End Module
