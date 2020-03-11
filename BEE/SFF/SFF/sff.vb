Imports System.IO
Imports System.IO.Compression
Imports System.Text.RegularExpressions

Module sff
    Function createMonthDict() As Dictionary(Of Integer, String)
        Dim month_dict As New Dictionary(Of Integer, String)
        Dim month() As String = {"JAN", "FEB", "MAR", "APR", "MAY", "JUNE", "JULY", "AUG", "SEP", "OCT",
                                    "NOV", "DEC"}
        Dim number() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
        For i As Integer = 0 To number.Length - 1
            month_dict.Add(number(i), month(i))
        Next
        Return month_dict
    End Function

    Class sff
        Shared month_dict As Dictionary(Of Integer, String) = createMonthDict()
        Dim pathSharedDriveFolderZipFileSFF As String
        Dim pathSharedDriveFolderTxtFiles As String
        Dim pathLocalFolderSFF As String
        Dim pathLocalFolderForTxt As String
        Dim month As String
        Dim week As String
        Dim year As String
        Dim yearChange As String
        Dim pattern As String
        Dim checkFromUser As String
        Public Sub New(ByVal flag As String,
                 ByVal pathZipFile As String,
                 ByVal pathtxtFile As String,
                 ByVal userMonth As String,
                 ByVal userWeek As String,
                 ByVal userYear As String)
            Me.pathSharedDriveFolderZipFileSFF = pathZipFile
            Me.pathSharedDriveFolderTxtFiles = pathtxtFile
            Me.pathLocalFolderSFF = Directory.GetCurrentDirectory() + "\" + $"sim2localZipFile{flag.ToUpper()}"
            Me.pathLocalFolderForTxt = Directory.GetCurrentDirectory() + "\" + $"ForExtract_file_{flag.ToLower()}ly"
            Me.month = userMonth
            Me.week = userWeek
            Me.year = userYear
            If Me.month.Equals("1") Then
                Me.yearChange = (Integer.Parse(Me.year) - 1).ToString()
            Else
                Me.yearChange = Me.year.Trim(" "c)
            End If
            Dim checked_month As String
            If flag.ToLower.Equals("week") Then
                Me.pattern = "LAST_PERIOD[\b:]+WEEKLY[\b-]*(W[0-9]*)"
                Me.checkFromUser = $"W{Me.week.ToString}{Me.yearChange.Substring(Me.yearChange.Length - 2, 2)}"
            Else
                If Me.month.Equals("1") Then
                    checked_month = sff.month_dict(12)
                Else
                    checked_month = sff.month_dict(Integer.Parse(Me.month) - 1)
                End If
                Me.checkFromUser = $"{checked_month}{Me.yearChange.Substring(Me.yearChange.Length - 2, 2)}"
                Me.pattern = "LAST_PERIOD[\b:]+MONTH[\b-]*([a-zA-Z0-9]*)"
            End If
        End Sub
        Public Shared Sub createFolder(ByVal path As String)
            If Not Directory.Exists(path) Then
                Directory.CreateDirectory(path)
            End If
        End Sub
        Public Shared Sub copiedFile(ByVal startPath As String, ByVal targetPath As String)
            If Directory.Exists(startPath) And Directory.Exists(targetPath) Then
                My.Computer.FileSystem.CopyFile(startPath, targetPath)
            End If
        End Sub
        Public Shared Sub removeFolder(ByVal pathFolder As String)
            If Directory.Exists(pathFolder) Then
                My.Computer.FileSystem.DeleteDirectory(pathFolder,
                                                     FileIO.UIOption.AllDialogs,
                                                     FileIO.RecycleOption.SendToRecycleBin,
                                                     FileIO.UICancelOption.ThrowException)
            End If

        End Sub
        Public Sub getFile()
            Me.copiedFile(Me.pathSharedDriveFolderZipFileSFF, Me.pathLocalFolderSFF)
            Dim i As Integer = 0
            Dim fileTxt As String = ""
            'Dim row_excel As Integer = 1
            Dim files() As String = Directory.GetFiles(Me.pathLocalFolderSFF)
            Dim pathDirectoryName As String
            Dim pathZipFile As String
            For Each f As String In files
                If f.EndsWith("ZIP") Then
                    'f is representative of file
                    pathZipFile = Path.GetDirectoryName(Me.pathLocalFolderSFF) + "\" + f
                    Dim zipToOpen As ZipArchive = ZipFile.OpenRead(pathZipFile)
                    Console.WriteLine(f)
                    For Each entry As ZipArchiveEntry In zipToOpen.Entries
                        fileTxt = entry.Name ' entry is file in the archive
                        Dim pathFileTxtEntry As String = Path.Combine(pathZipFile, fileTxt)
                        ' path of txt in the archive
                        If fileTxt.EndsWith(".txt") Then
                            Dim lasModify As DateTime = File.GetLastWriteTime(pathFileTxtEntry)
                            Dim monthLastModify As String = lasModify.Month.ToString
                            Dim yearLastModify As String = lasModify.Year.ToString
                            If Me.month = monthLastModify And Me.year = yearLastModify Then
                                Dim txtReader As StreamReader = New StreamReader(pathFileTxtEntry)
                                Dim contentTxt As String = txtReader.ReadToEnd
                                txtReader.Close()
                                Dim oneLineString As String = String.Join(" ", contentTxt.Split(New String() {Environment.NewLine},
                                                                                                StringSplitOptions.None))
                                Dim regObj As Regex = New Regex(Me.pattern)
                                Dim matchObj As Match = regObj.Match(oneLineString)
                                If matchObj.Success Then
                                    Console.WriteLine(fileTxt + ":" + matchObj.Value)
                                End If
                                Exit For
                            End If
                        Else
                            Continue For
                        End If
                    Next
                End If
            Next

        End Sub
    End Class
End Module
