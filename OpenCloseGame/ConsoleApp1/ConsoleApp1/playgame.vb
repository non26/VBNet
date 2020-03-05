Imports ConsoleApp1.createplayer.Player

Module playgame
    Class game
        Shared msg As String() = {"You are the predictor", "AI is the predictor"}
        Shared win As Boolean = True
        Dim personPlayer As Player
        Dim aiPlayer As Player
        Public Sub New(ByVal personP1 As Player, ByVal aiP2 As Player)
            personPlayer = personP1
            aiPlayer = aiP2
        End Sub


    End Class

End Module
