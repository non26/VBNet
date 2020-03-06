Module play
    Sub main()
        Dim person As Player = New Player(True, "", False)
        Dim ai As Player = New Player(False, "", True)
        Do While True
            Dim letPlayGame As Game = New Game(person, ai)
            Dim result As Boolean = letPlayGame.letPlay()
            If result Then
                person.predictor = True
                ai.predictor = False
                Continue Do
            Else
                Console.WriteLine("ok, bye")
                Exit Do
            End If
        Loop
        Console.ReadKey()
    End Sub

End Module
