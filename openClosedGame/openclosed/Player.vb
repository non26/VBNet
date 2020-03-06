Public Class Player
    Dim predictor_ As Boolean
    Dim answer_ As String
    Dim ai_ As Boolean
    Public Sub New(ByVal pre As Boolean, ByVal ans As String, ByVal ai As Boolean)
        Me.predictor_ = pre
        Me.answer_ = ans
        Me.ai_ = ai
    End Sub
    Public Property predictor() As Boolean
        Get
            Return Me.predictor_
        End Get
        Set(ByVal another As Boolean)
            Me.predictor_ = another
        End Set
    End Property
    Public Property answer() As String
        Get
            Return Me.answer_
        End Get
        Set(ByVal another As String)
            Me.answer_ = another
        End Set
    End Property
    Public Property ai() As Boolean
        Get
            Return Me.ai_
        End Get
        Set(ByVal another As Boolean)
            Me.ai_ = another
        End Set
    End Property
End Class
