Public Class UPCtlCellComboBox
    Inherits UPComboBox
    Implements IDataGridViewEditingControl

    Private _DataGridView As DataGridView
    Private _RowIndex As Int32
    Private _ValueIsChanged As Boolean
    'Private _OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String))
    'Private _IsValidateLoaded As Boolean = False
    'Private _ListIdLoaded As List(Of Int32)



    Public Sub New()
        MyBase.New()
        MyBase.DropDownHeight = 150
        MyBase.AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
        'MyBase.AutoCompleteSource = AutoCompleteSource.CustomSource
        'MyBase.AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
        MyBase.AutoCompleteMode = Windows.Forms.AutoCompleteMode.Suggest
        'MyBase.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
        'MyBase.AutoCompleteMode = Windows.Forms.AutoCompleteMode.Append
        MyBase.DropDownStyle = ComboBoxStyle.DropDown

    End Sub

    Public Shadows Sub ReLoad(ByRef OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String)))
        MyBase.ReLoad(OptionsList)

        'If IsValidateLoaded Then
        '    _OptionsList = OptionsList
        '    _IsValidateLoaded = IsValidateLoaded
        '    _ListIdLoaded = ListIdLoaded
        'End If



    End Sub


    'Private Function ValidateLoaded(ByVal Id As Int32) As Boolean
    '    If _IsValidateLoaded Then
    '        If _ListIdLoaded.Contains(Id) Then
    '            MessageBox.Show("Registro cargado", "Registro cargado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Return False
    '        End If
    '    End If
    '    Return True
    'End Function


#Region "IDataGridViewEditingControl"

    Public Property EditingControlDataGridView As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
        Get
            Return _DataGridView
        End Get
        Set(value As DataGridView)
            _DataGridView = value
        End Set
    End Property

    Public Property EditingControlRowIndex As Integer Implements IDataGridViewEditingControl.EditingControlRowIndex
        Get
            Return _RowIndex
        End Get
        Set(value As Integer)
            _RowIndex = value
        End Set
    End Property

    Public Property EditingControlValueChanged As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return _ValueIsChanged
        End Get
        Set(value As Boolean)
            _ValueIsChanged = value
        End Set
    End Property

    Public ReadOnly Property EditingPanelCursor As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

    Public ReadOnly Property RepositionEditingControlOnValueChange As Boolean Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return True
        End Get
    End Property

    Public Sub ApplyCellStyleToEditingControl(dataGridViewCellStyle As DataGridViewCellStyle) Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
        Me.ForeColor = dataGridViewCellStyle.ForeColor
        Me.BackColor = dataGridViewCellStyle.BackColor
    End Sub

    Public Function EditingControlWantsInputKey(keyData As Keys, dataGridViewWantsInputKey As Boolean) As Boolean Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        ' Let the DateTimePicker handle the keys listed.
        Select Case keyData And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right,
                Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp

                Return True

            Case Else

                Return False
        End Select
    End Function

    Public Sub PrepareEditingControlForEdit(selectAll As Boolean) Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

    End Sub


#End Region

    Public Property EditingControlFormattedValue As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            If Me.SelectedItem Is Nothing Then
                Return ""
            Else
                Return CType(Me.SelectedItem, ComboBoxItem).ToString
            End If

        End Get
        Set(value As Object)
            If TypeOf value Is [String] Then
                Me.SelectedItem = GetItemIndex(value)
            End If
        End Set
    End Property

    Public Function GetEditingControlFormattedValue(context As DataGridViewDataErrorContexts) As Object Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        If Me.SelectedItem IsNot Nothing Then
            Return CType(Me.SelectedItem, ComboBoxItem).Id.ToString()
        Else
            Return ""
        End If

    End Function

    Protected Overrides Sub OnSelectedIndexChanged(ByVal eventargs As System.EventArgs)
        _ValueIsChanged = True
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)

    End Sub

    Private Sub PECtlCellComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Me.SelectedIndexChanged

        _ValueIsChanged = True
        Me.EditingControlValueChanged = True
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)

        'If ValidateLoaded(GetSelectedItemId()) Then
        '    _ValueIsChanged = True
        '    Me.EditingControlValueChanged = True
        '    Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
        'End If
    End Sub

End Class
