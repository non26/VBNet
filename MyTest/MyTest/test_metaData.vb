Imports System.IO
Module test_metaData
    Sub test_metaData()
        Dim lastModify As DateTime = File.GetLastWriteTime("C:\nonContent\googleAPI\test_googleDriveAPI.py")
        Console.WriteLine(lastModify.Day.ToString + " " + lastModify.Month.ToString)
    End Sub
End Module
