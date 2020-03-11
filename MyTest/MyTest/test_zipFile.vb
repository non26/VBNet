Imports System.IO
Imports System.IO.Compression
Module test_zipFile
    Public Sub TestZipFile()
        Dim testZipFile As ZipArchive = ZipFile.OpenRead("C:\nonContent\workAtNielsen\AutoNAD_NEW.zip")
        For Each file As ZipArchiveEntry In testZipFile.Entries
            'For Each file As String In testZipFile.Entries --> Error
            Console.WriteLine(file.Name)
        Next

    End Sub

End Module
