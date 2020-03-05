Module createplayer
    Class Player
        Dim predictor_ As Boolean
        Dim answer_ As String
        Dim ai_ As Boolean
        Dim order_ As Integer
        Public Sub New(ByVal pre As Boolean, ByVal ans As String, ByVal ai As Boolean, ByVal th As Integer)
            predictor_ = pre
            answer_ = ans
            ai_ = ai
            order_ = th
        End Sub
        Public Property predictor() As Boolean
            Get
                Return predictor_
            End Get
            Set(ByVal another As Boolean)
                predictor_ = another
            End Set
        End Property
        Public Property answer() As String
            Get
                Return answer_
            End Get
            Set(ByVal another As String)
                answer_ = another
            End Set
        End Property
        Public Property ai() As Boolean
            Get
                Return ai_
            End Get
            Set(ByVal another As Boolean)
                ai_ = another
            End Set
        End Property
        Public Property order() As Integer
            Get
                Return order_
            End Get
            Set(ByVal another As Integer)
                order_ = another
            End Set
        End Property
    End Class

    'Sub Main()
    '    Dim player1 = New Player(True, "", False)
    '    Console.WriteLine(player1.predictor)
    '    Console.ReadLine()
    'End Sub

End Module
