Public Class UPDataGridViewColumnComboBox
    Inherits UPDataGridViewColumn

    Private _OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String))

    Private _IsFilterOptionsList As Boolean = False
    Private _IsValidateLoaded As Boolean = False

    Public Sub New()
        MyBase.New("Name", "HeaderText", New UPEditorCellComboBox())
    End Sub

    Public Sub New(ByVal Name As String, ByVal HeaderText As String,
                   ByRef OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String)))

        MyBase.New(Name, HeaderText, New UPEditorCellComboBox())

        _OptionsList = OptionsList
    End Sub

    'Public Shadows Property [ReadOnly] As Boolean
    '    Get
    '        Return MyBase.ReadOnly
    '    End Get
    '    Set(value As Boolean)
    '        MyBase.ReadOnly = value
    '    End Set
    'End Property


    Public ReadOnly Property OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String))
        Get
            If _IsFilterOptionsList Then
                Return GetFilterOptionsList()
            Else
                Return _OptionsList
            End If

        End Get
    End Property

    Public Property IsFilterOptionsList As Boolean
        Get
            Return _IsFilterOptionsList
        End Get
        Set(value As Boolean)
            _IsFilterOptionsList = value
        End Set
    End Property


    'Public Property IsValidateLoaded As Boolean
    '    Get
    '        Return _IsValidateLoaded
    '    End Get
    '    Set(value As Boolean)
    '        _IsValidateLoaded = value
    '    End Set
    'End Property


    Public Function GetFilterOptionsList() As List(Of (Name As String, Id As Integer, ImageKey As String))

        Dim _IdLoads As New List(Of Int32)
        For Each row As DataGridViewRow In DataGridView.Rows
            If DataGridView.CurrentRow IsNot Nothing Then
                If Not row.IsNewRow And Not row.Index = DataGridView.CurrentRow.Index Then
                    If Not IsDBNull(row.Cells(Name).Value) Then
                        _IdLoads.Add(row.Cells(Name).Value)
                    End If

                End If
            End If
        Next

        Dim _OptionsListFilert As New List(Of (Name As String, Id As Integer, ImageKey As String))
        For Each _Item As (Name As String, Id As Integer, ImageKey As String) In _OptionsList
            If Not _IdLoads.Contains(_Item.Id) Then
                _OptionsListFilert.Add(_Item)
            End If
        Next
        Return _OptionsListFilert
    End Function

    Public Function GetListIdLoaded() As List(Of Int32)
        Dim _IdLoads As New List(Of Int32)
        If _IsValidateLoaded Then
            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow And Not row.Index = DataGridView.CurrentRow.Index Then
                    _IdLoads.Add(row.Cells(Name).Value)
                End If
            Next
        End If
        Return _IdLoads
    End Function


    Public Function GetItemName(ByVal Id As Int32) As String
        If Id < 1 Then
            If OptionsList.Count > 0 AndAlso OptionsList Is Nothing Then
                Return OptionsList.First.Item1
            Else
                Return ""
            End If

        Else
            If _OptionsList.Count > 0 Then
                Dim _Option As Object = _OptionsList.Find(Function(p) p.Id = Id)
                If _Option.Item1 Is Nothing Then
                    Return OptionsList.First.Item1
                Else
                    Return _Option.Item1
                End If
            Else
                Return ""
            End If
        End If
    End Function

    Public Function GetItemId(ByVal Name As String) As Int32
        Dim _Option As Object = OptionsList.Find(Function(p) p.Name = Name)
        Return _Option.Item2
    End Function

End Class
