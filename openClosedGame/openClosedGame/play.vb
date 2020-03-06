Module play

    Class game
        Shared msg As String() = {"You are the predictor", "AI is the predictor"}
        Shared win As Boolean = True
        Dim personPlayer As Player
        Dim aiPlayer As Player
        Public Sub New(ByVal personP1 As Player, ByVal aiP2 As Player)
            Me.personPlayer = personP1 ' person player
            Me.aiPlayer = aiP2 ' ai player
        End Sub
        Public Function aiInput() As String
            Dim starter As String = ""
            Dim characterArray As String() = {"C", "O"}
            Dim numberRandom As System.Random = New System.Random()
            Dim characterRandom As System.Random = New System.Random()
            For counter As Integer = 0 To 1
                Dim character As String = characterArray.GetValue(characterRandom.Next(0, 2))
                starter = String.Concat(starter, character)
            Next
            If (Me.aiPlayer.predictor) Then
                Dim number As String = CStr(numberRandom.Next(0, 5))
                starter = String.Concat(starter, number)
            End If
            Return starter
        End Function
        Public Function userInput() As String
            Dim uinput As String
            uinput = Console.ReadLine.ToUpper
            userInput = uinput
        End Function
        Private Sub getInput()
            Me.personPlayer.answer = userInput()
            Me.aiPlayer.answer = aiInput()
        End Sub
        Public Function checkAnswer() As Boolean
            If Me.personPlayer.predictor Then
                Dim lenAnswer As Integer = Me.personPlayer.answer.Length
                Dim numberOfO As Integer = CInt(Me.personPlayer.answer.Substring(lenAnswer - 1, lenAnswer))
                Dim restCharacter As String = ""
                restCharacter = String.Concat(Me.personPlayer.answer, Me.aiPlayer.answer)
                Dim countCharO As Integer = countO(restCharacter)
                If countCharO = countCharO Then
                    Console.WriteLine("person wins")
                    Return game.win
                Else
                    Console.WriteLine("on one wins")
                    Return Not game.win
                End If
            Else ' ai is the predicter
                Dim lenAnswer As Integer = Me.aiPlayer.answer.Length
                Dim numberOfO As Integer = CInt(Me.aiPlayer.answer.Substring(lenAnswer - 1, lenAnswer))
                Dim restCharacter As String = ""
                restCharacter = String.Concat(Me.aiPlayer.answer, Me.personPlayer.answer)
                Dim countCharO As Integer = countO(restCharacter)
                If countCharO = countCharO Then
                    Console.WriteLine("ai wins")
                    Return game.win
                Else
                    Console.WriteLine("on one wins")
                    Return Not game.win
                End If
            End If
        End Function
        Public Function countO(ByVal x As String) As Integer
            Dim count As Integer
            Dim starter As Integer = -1
            Do While True
                Dim index As Integer = x.IndexOf("O"c, starter + 1)
                If index <> -1 Then
                    starter = index
                    count += 1
                Else
                    Continue Do
                End If
            Loop
            Return count
        End Function
        Public Function letPlay() As Boolean
            Do While True
                Console.WriteLine(game.msg(0) + ", What is your input?")
                getInput()
                Dim result As Boolean = checkAnswer()
                If Me.personPlayer.answer Then
                    If result Then
                        Exit Do
                    Else
                        Me.personPlayer.predictor = False
                        Me.aiPlayer.predictor = True
                        Continue Do
                    End If
                Else ' indicating that aiPlayer.predicter is true
                    If result Then
                        Exit Do
                    Else
                        Me.personPlayer.predictor = True
                        Me.aiPlayer.predictor = False
                        Continue Do
                    End If
                End If
            Loop
            Console.WriteLine("Do you want to play again? (Y/N)")
            Dim again As String = Console.ReadLine.ToUpper
            If again.Equals("Y") Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class


End Module
