Module Module1
    Function createTable() As DataTable
        Dim dt1 As DataTable = New DataTable()
        ' add datacolumns to the  data table
        dt1.Columns.Add("data1", GetType(Integer))
        dt1.Columns.Add("data2", GetType(Integer))
        Dim column3 As DataColumn = New DataColumn("data3", GetType(Integer))
        dt1.Columns.Add(column3)
        ' add datarow to each column
        dt1.Rows.Add(1, 2, 3)
        dt1.Rows.Add(4, 5, 6)
        dt1.Rows.Add(7, 8, 9)
        dt1.Rows.Add(10, 11, 12)
        createTable = dt1
    End Function

    Sub Main()
        Dim dt As DataTable = createTable()
        'For Each dtRow As DataRow In dt.Rows
        '    Console.WriteLine("ROW: {0}", String.Join(","c, dtRow.ItemArray))
        'Next
        'Console.WriteLine(GetType(Integer))
        Dim strConcat As String = ""
        For Each row As DataRow In dt.Rows
            For Each col As DataColumn In dt.Columns
                strConcat += row(col).ToString
            Next
            Console.WriteLine(strConcat)
            strConcat = ""
        Next
        Console.ReadKey()
    End Sub

End Module
