Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Module Module1

    Sub Main()
        Dim server As String = "127.0.0.1"
        Dim user As String = "root"
        Dim pw As String = "0988327674Mysql"
        Dim db As String = "world"
        Dim connectionString As String = $"server={server}
                                            ;userid={user}
                                            ;password={pw}
                                            ;database={db}"
        Dim conn As MySqlConnection = Nothing
        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT * 
                                    FROM city 
                                    LIMIT 10"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            da.Fill(ds, "city")
            Dim dt As DataTable = ds.Tables("city")

            For Each row As DataRow In dt.Rows
                For Each col As DataColumn In dt.Columns
                    Console.Write(row(col).ToString + vbTab)
                Next
                Console.Write(Environment.NewLine)
            Next
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        Console.ReadKey()
    End Sub
End Module
