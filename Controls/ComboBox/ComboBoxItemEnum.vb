Public Class ComboBoxItemEnum
    Inherits ComboBoxItem


    Private _Enumeration As [Enum]

    Public Sub New(ByVal Id As String, ByVal Text As String, ByVal ImageKey As String, ByVal Enumeration As [Enum])
        MyBase.New(Id, Text, ImageKey)

        _Enumeration = Enumeration
    End Sub

    Public ReadOnly Property Enumeration As [Enum]
        Get
            Return _Enumeration
        End Get
    End Property

End Class
