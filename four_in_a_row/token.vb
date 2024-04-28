Public Class token
    Inherits Label

    Private _used As Boolean
    Public Property Used() As Boolean
        Get
            Return _used
        End Get
        Set(value As Boolean)
            _used = value
        End Set
    End Property
End Class
