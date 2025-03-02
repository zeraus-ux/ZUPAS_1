Public Class UPEditorCellComboBox
    Inherits System.Windows.Forms.DataGridViewTextBoxCell

    'Private _UPDataGridViewColumnComboBox As UPDataGridViewColumnComboBox

    'Public Sub New(ByRef vUPDataGridViewColumnComboBox As UPDataGridViewColumnComboBox)
    '    _UPDataGridViewColumnComboBox = vUPDataGridViewColumnComboBox
    'End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object,
                                                  ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim _UPDataGridViewColumnComboBox As UPDataGridViewColumnComboBox
        Dim _OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String))
        'Dim _IsValidateLoaded As Boolean
        'Dim _ListIdLoaded As List(Of Int32)

        _UPDataGridViewColumnComboBox = Me.OwningColumn
        _OptionsList = _UPDataGridViewColumnComboBox.OptionsList
        '_IsValidateLoaded = _UPDataGridViewColumnComboBox.IsValidateLoaded
        '_ListIdLoaded = _UPDataGridViewColumnComboBox.GetListIdLoaded()

        Dim ctl As UPCtlCellComboBox = CType(DataGridView.EditingControl, UPCtlCellComboBox)
        ctl.ReLoad(_OptionsList)

        If ctl.Items.Count > 0 Then
            Dim _IdTable As Integer
            If Integer.TryParse(ctl.GetItemId(initialFormattedValue), _IdTable) Then
                ctl.SelectedIndex = ctl.GetItemIndex(_IdTable)
            Else
                ctl.SelectedIndex = ctl.FindString(_OptionsList.First.Name)
            End If

            'If _IsValidateLoaded Then
            '    For Each _item As (Name As String, Id As Integer, ImageKey As String) In _OptionsList
            '        If Not _ListIdLoaded.Contains(_item.Id) Then
            '            ctl.SelectedIndex = ctl.GetItemIndex(_item.Id)
            '        End If
            '    Next
            'Else
            '    Dim _IdTable As Integer
            '    If Integer.TryParse(ctl.GetItemId(initialFormattedValue), _IdTable) Then
            '        ctl.SelectedIndex = ctl.GetItemIndex(_IdTable)
            '    Else
            '        ctl.SelectedIndex = ctl.FindString(_OptionsList.First.Name)
            '    End If
            'End If
        Else
            ctl.Text = ""
        End If

    End Sub


    Public Overrides ReadOnly Property EditType() As Type
        Get
            Return GetType(UPCtlCellComboBox)
        End Get
    End Property
    Public Overrides ReadOnly Property ValueType() As Type
        Get
            Return GetType(String)
        End Get
    End Property
    Public Overrides ReadOnly Property FormattedValueType() As System.Type
        Get
            Return GetType(String)
        End Get
    End Property
    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            'Return
        End Get
    End Property


End Class
