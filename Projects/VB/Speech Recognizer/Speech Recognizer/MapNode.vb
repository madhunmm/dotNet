Public Class MapNode
    Private cmd As String
    Private act As String
    Private params() As String
    Private resp As String
    Private restricted As Boolean

    Public Property Command() As String
        Get
            Command = cmd
        End Get
        Set(ByVal value As String)
            cmd = value
        End Set
    End Property
    Public Property Action() As String
        Get
            Action = act
        End Get
        Set(ByVal value As String)
            act = value
        End Set
    End Property
    Public Property Parameters() As String()
        Get
            Parameters = params
        End Get
        Set(ByVal value As String())
            params = value
        End Set
    End Property
    Public Property Response() As String
        Get
            Response = resp
        End Get
        Set(ByVal value As String)
            resp = value
        End Set
    End Property
    Public Property UICommand() As Boolean
        Get
            UICommand = restricted
        End Get
        Set(ByVal value As Boolean)
            restricted = value
        End Set
    End Property
End Class
