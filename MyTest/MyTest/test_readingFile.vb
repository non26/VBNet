Imports System.IO
Module test_readingFile
    Sub test_reading()
        Dim txtFile As StreamReader = New StreamReader("C:\nonContent\DotNetFrameWork\MyTest\MyTest\testReading.txt")
        Dim txtReader As String = txtFile.ReadToEnd
        Dim oneLine As String = String.Join(" ", txtReader.Split(New String() {Environment.NewLine},
        StringSplitOptions.None))
        txtReader.Split()
        Console.WriteLine(oneLine)
    End Sub

End Module
