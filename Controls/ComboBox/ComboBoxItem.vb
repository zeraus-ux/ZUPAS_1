Public Class ComboBoxItem

    Private _Id As Int32
    Private _Text As String
    Private _ImageKey As String

    Public Sub New(ByVal Id As String, ByVal Text As String, ByVal ImageKey As String)
        _Text = Text
        _ImageKey = ImageKey
        _Id = Id
    End Sub

    Public ReadOnly Property ImageKey As String
        Get
            Return _ImageKey
        End Get
    End Property

    Public ReadOnly Property Id As Int32
        Get
            Return _Id
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return _Text
    End Function

End Class
