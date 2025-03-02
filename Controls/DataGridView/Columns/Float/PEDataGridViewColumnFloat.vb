Public Class PEDataGridViewColumnFloat
    Inherits UPDataGridViewColumn

    Public Sub New()
        MyBase.New("Name", "HeaderText", New DataGridViewTextBoxCell())
    End Sub

    Public Sub New(ByVal Name As String, ByVal HeaderText As String)
        MyBase.New(Name, HeaderText, New DataGridViewTextBoxCell())

    End Sub

End Class
