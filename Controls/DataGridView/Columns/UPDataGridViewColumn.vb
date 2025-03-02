Public Class UPDataGridViewColumn
    Inherits System.Windows.Forms.DataGridViewColumn

    Public Sub New(ByVal Name As String, ByVal HeaderText As String, ByVal DataGridViewCell As DataGridViewCell)
        MyBase.New(DataGridViewCell)
        MyBase.Name = Name
        MyBase.HeaderText = HeaderText
        MyBase.DataPropertyName = Name
    End Sub


End Class
