Imports System.Windows.Input
Imports Newtonsoft.Json.Linq

Public Class UPDataGridView

    Private _Editing As Boolean = False
    Private _TableName As String
    Private _ListIdOriginales As New List(Of Int32)
    Private _IdDefault As Int32

    Public Shadows Event EvCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)

    Private Sub Formatting() ' Editar este 12/06

        MyBase.AllowUserToAddRows = False
        MyBase.AllowUserToDeleteRows = False
        MyBase.EnableHeadersVisualStyles = False
        MyBase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                                                       Or System.Windows.Forms.AnchorStyles.Left) _
                                                                       Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MyBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        MyBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        MyBase.BackgroundColor = System.Drawing.SystemColors.Control
        MyBase.BorderStyle = System.Windows.Forms.BorderStyle.None
        MyBase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        MyBase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        MyBase.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer))
        MyBase.GridColor = System.Drawing.SystemColors.ControlLightLight
        MyBase.Location = New System.Drawing.Point(151, 86)
        MyBase.MultiSelect = False
        MyBase.Name = "DataGridView1"
        MyBase.RowHeadersVisible = False
        MyBase.RowHeadersWidth = 51
        MyBase.RowTemplate.Height = 24
        MyBase.Size = New System.Drawing.Size(567, 506)
        MyBase.TabIndex = 1

        MyBase.DefaultCellStyle.Padding = New Padding(0, 0, 0, 0)
        MyBase.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        MyBase.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)

        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        MyBase.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1

        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        'DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer)) 'yo

        'HEADER
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        MyBase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Regular), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Regular), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(182, Byte), Integer)) 'yo
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(182, Byte), Integer)) 'yo
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]

        'DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer)) 'yo

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'DataGridViewCellStyle3 Row Current
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        MyBase.DefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)) 'yo
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        'DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer)) 'yo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True '**

        'DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        'DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(213, Byte), Integer))
        ' DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window
        'DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)) 'yo
        'DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        ' DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer)) 'yo

        'COLOR DE LA FILA SELECCIONADA
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer),
                                                                                  CType(CType(120, Byte), Integer),
                                                                                  CType(CType(215, Byte), Integer))

        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke


        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        ' MyBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing

    End Sub

    Public Sub New(ByVal TableName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _TableName = TableName

        MyBase.AutoGenerateColumns = False
        MyBase.ColumnHeadersHeight = 40
        MyBase.AllowUserToOrderColumns = False
        MyBase.AllowUserToResizeColumns = False
        MyBase.AllowUserToResizeRows = False
        MyBase.RowTemplate.Height = 30
        MyBase.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        MyBase.EditMode = DataGridViewEditMode.EditProgrammatically
        MyBase.Rows.Clear()

        Formatting()

        'Test-------------------------
        'MyBase.BorderStyle = BorderStyle.FixedSingle
        '----------------------------------

    End Sub

    Public ReadOnly Property ListColumns As List(Of String)
        Get
            Dim _list As New List(Of String)
            For Each _Column As DataGridViewColumn In Columns
                _list.Add(_Column.Name)
            Next
            Return _list
        End Get
    End Property

    Public Shadows Property DataSource As Object
        Get
            Return MyBase.DataSource
        End Get
        Set(value As Object)
            If value IsNot Nothing Then
                _ListIdOriginales.Clear()
                For Each _DataRow As DataRow In CType(value, DataTable).Rows
                    If Not IsDBNull(_DataRow("id")) Then
                        _ListIdOriginales.Add(_DataRow("id"))
                    End If
                Next

                If value.Rows.Count > 0 Then

                    MyBase.DataSource = CType(value, DataTable)
                Else
                    MyBase.DataSource = Nothing
                End If

            Else
                MyBase.DataSource = Nothing
                MyBase.Rows.Clear()
            End If
        End Set
    End Property

    Public ReadOnly Property DataTable As DataTable
        Get

            If MyBase.DataSource Is Nothing Then
                ' Crear un DataTable vacío
                Dim dt As New DataTable()

                ' Agregar columnas al DataTable
                For Each column As DataGridViewColumn In Columns
                    dt.Columns.Add(column.Name, column.ValueType)
                Next

                ' Agregar filas al DataTable
                For Each row As DataGridViewRow In Rows
                    Dim dr As DataRow = dt.NewRow()
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value Is Nothing Then
                            dr(cell.ColumnIndex) = DBNull.Value
                        Else
                            dr(cell.ColumnIndex) = cell.Value
                        End If

                    Next
                    dt.Rows.Add(dr)
                Next
                Return dt
            Else
                Return MyBase.DataSource
            End If

        End Get
    End Property

    Public Function GetListValues(Of T)(ByVal ColumnName As String) As List(Of T)
        Dim _List As New List(Of T)

        For Each row As DataGridViewRow In Rows
            If Not IsDBNull(row.Cells(ColumnName).Value) Then
                If Not _List.Contains(row.Cells(ColumnName).Value) Then
                    _List.Add(row.Cells(ColumnName).Value)
                End If
            End If
        Next

        Return _List
    End Function


    Public Function GetColumnValue(ByVal ColumnName As String) As Object

        If SelectedRows IsNot Nothing AndAlso SelectedRows.Count > 0 Then
            Return SelectedRows(0).Cells(ColumnName).Value
        Else
            Return Nothing
        End If
    End Function

    Public Sub StartEditing()
        _Editing = True

        MyBase.AllowUserToAddRows = True
        MyBase.AllowUserToDeleteRows = True
        MyBase.EditMode = DataGridViewEditMode.EditOnEnter

        'If Rows.Count > 0 Then
        '    For Each _item As KeyValuePair(Of String, Int32) In _dicComboBoxDefault

        '        If Columns(_item.Key).GetType() Is GetType(UPDataGridViewColumnComboBox) Then

        '            Rows(Rows.Count - 1).Cells.Item(_item.Key).Value = DBNull.Value

        '            'If CType(Columns(_item.Key), UPDataGridViewColumnComboBox).IsFilterOptionsList Then
        '            '    Dim _Id As Int32 = CType(Columns(_item.Key), UPDataGridViewColumnComboBox).OptionsList.First.Id
        '            '    Rows(Rows.Count - 1).Cells.Item(_item.Key).Value = _Id
        '            'Else
        '            '    Rows(Rows.Count - 1).Cells.Item(_item.Key).Value = _item.Value
        '            'End If
        '        Else
        '            Rows(Rows.Count - 1).Cells.Item(_item.Key).Value = _item.Value
        '        End If

        '    Next
        'End If

        MyBase.Refresh()
    End Sub

    Public Sub EndEditing()
        _Editing = False

        MyBase.AllowUserToAddRows = False
        MyBase.AllowUserToDeleteRows = False
        MyBase.EditMode = DataGridViewEditMode.EditProgrammatically
    End Sub

    Public Sub ResetIds()
        For Each _DataRow As DataRow In DataTable.Rows
            _DataRow("Id") = DBNull.Value
        Next
        DataSource = DataTable
    End Sub

    Public Sub LoadRow(ByVal dicValues As JObject)

        'Dim _DataRow As DataGridViewRow = Rows(Rows.Add())
        'For Each _Prop As JProperty In dicValues.Children
        '    _DataRow.Cells(_Prop.Name).Value = CType(_Prop.Value, JValue).Value
        'Next

        If DataSource IsNot Nothing Then

            Dim dataTable As DataTable = DirectCast(DataSource, DataTable)
            Dim newRow As DataRow = dataTable.NewRow()

            For Each _Prop As JProperty In dicValues.Children
                newRow(_Prop.Name) = CType(_Prop.Value, JValue).Value
            Next
            dataTable.Rows.Add(newRow)
            dataTable.AcceptChanges()


            'Dim _DataTable As DataTable = DataTable
            'Dim _DataRow As DataRow = DataTable.NewRow()

            'For Each _Prop As JProperty In dicValues.Children
            '    _DataRow(_Prop.Name) = CType(_Prop.Value, JValue).Value
            'Next
            ''_DataTable.Rows.Add(_DataRow)

            'DataSource = _DataTable
            '_DataTable.AcceptChanges()
        Else
            Dim _DataRow As DataGridViewRow = Rows(Rows.Add())
            For Each _Prop As JProperty In dicValues.Children
                _DataRow.Cells(_Prop.Name).Value = CType(_Prop.Value, JValue).Value
            Next
        End If


    End Sub

    Public Sub SetUPDGViewReadOnly(ByVal IsReadOnly As Boolean)
        If IsReadOnly Then

            EndEditing()
            For Each columna As DataGridViewColumn In Columns
                columna.ReadOnly = True
            Next
        Else
            StartEditing()
            For Each columna As DataGridViewColumn In Columns
                columna.ReadOnly = False
            Next
        End If
    End Sub

    Public Sub SetColumnReadOnly(ByVal ColumnName As String, ByVal IsReadOnly As Boolean)
        Columns(ColumnName).ReadOnly = IsReadOnly

        'If Not _dicColumnsReadOnly.ContainsKey(ColumnName) Then
        '    _dicColumnsReadOnly.Add(ColumnName, IsReadOnly)
        'Else
        '    _dicColumnsReadOnly(ColumnName) = IsReadOnly
        'End If

    End Sub


    Public Function Saves(Optional ByVal FKPColumnName As String = Nothing, Optional ByVal FKPId As Int32 = -1) As List(Of Int32)

        EndEditing()

        Dim _DataTable As DataTable = DataTable


        If _DataTable.Rows.Count > 0 Then

            If FKPColumnName IsNot Nothing Then
                For Each _DataRow As DataRow In _DataTable.Rows
                    If Not _DataRow.RowState = DataRowState.Deleted Then
                        _DataRow(FKPColumnName) = FKPId
                    End If
                Next
            End If

            Dim _ListId As List(Of Int32) = CommonFuntion.Saves(_TableName, _DataTable, _ListIdOriginales)
            'MyBase.DataSource = Nothing

            StartEditing()

            Return _ListId
        Else
            StartEditing()
            Return New List(Of Int32)
        End If


    End Function

    Public Sub ReLoadData(Optional dicValuesFilter As JObject = Nothing, Optional IsDistinct As Boolean = False)
        Dim _datatable As DataTable = GetDataTable(_TableName, ColumnNames:=ListColumns, dicValuesFilter, IsDistinct)

        'Test---------------------------------------
        'Dim _Form8 As New Form8(_datatable)
        '_Form8.Show()
        '-------------------------------------------

        If _datatable.Rows.Count = 0 Then
            DataSource = Nothing
        Else
            DataSource = _datatable
        End If


    End Sub

    Public Function CrearteColumnText(ByVal ColumnName As String, ByVal HeaderText As String, ByVal IsReadOnly As Boolean,
                                 ByVal Visible As Boolean, ByVal IsTextLong As Boolean) As DataGridViewColumn

        Dim _DataGridViewColumn As DataGridViewColumn


        _DataGridViewColumn = New DataGridViewColumn(New DataGridViewTextBoxCell())
        _DataGridViewColumn.Name = ColumnName
        _DataGridViewColumn.HeaderText = HeaderText
        _DataGridViewColumn.DataPropertyName = ColumnName
        _DataGridViewColumn.ReadOnly = IsReadOnly
        _DataGridViewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        _DataGridViewColumn.Visible = Visible
        _DataGridViewColumn.ValueType = GetType(String)
        _DataGridViewColumn.MinimumWidth = 60

        If IsTextLong Then
            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            _DataGridViewColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            _DataGridViewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        End If

        Columns.Add(_DataGridViewColumn)


        Return _DataGridViewColumn
    End Function

    Public Function CreateColumnComboBox(ByVal ColumnName As String, ByVal HeaderText As String, ByVal IsReadOnly As Boolean,
                                    ByVal Visible As Boolean, ByVal IsTextLong As Boolean, ByVal CbxTableName As String,
                                    ByVal CbxColumnNames As List(Of String), ByVal CbxImageKey As String,
                                    ByVal CbxIsRequerido As Boolean, Optional CbxdicValuesFilter As JObject = Nothing,
                                         Optional ByVal IdDefault As Int32 = -1) As DataGridViewColumn

        _IdDefault = IdDefault

        Dim _OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String))
        _OptionsList = GetOptionsList(CbxTableName, CbxColumnNames, CbxImageKey, CbxIsRequerido, CbxdicValuesFilter)


        Dim _UPDataGridViewColumn As UPDataGridViewColumnComboBox
        _UPDataGridViewColumn = New UPDataGridViewColumnComboBox(ColumnName, HeaderText, _OptionsList)


        _UPDataGridViewColumn.Name = ColumnName
        _UPDataGridViewColumn.DataPropertyName = ColumnName
        _UPDataGridViewColumn.ReadOnly = IsReadOnly
        _UPDataGridViewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        ' _UPDataGridViewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter '28/08
        _UPDataGridViewColumn.Visible = Visible
        _UPDataGridViewColumn.ValueType = GetType(Int32)
        _UPDataGridViewColumn.MinimumWidth = 60


        'If CbxIsRequerido Then
        '    If _OptionsList.Count > 0 Then
        '        If IdDefault > 0 Then
        '            If Not _dicComboBoxDefault.ContainsKey(ColumnName) Then
        '                _dicComboBoxDefault.Add(ColumnName, IdDefault)
        '            End If
        '            '_UPDataGridViewColumn.DefaultCellStyle.DataSourceNullValue = IdDefault
        '            '_UPDataGridViewColumn.DefaultCellStyle.NullValue = IdDefault
        '        Else
        '            Dim _Item1 As Object = _OptionsList.First
        '            If _Item1 IsNot Nothing Then
        '                If Not _dicComboBoxDefault.ContainsKey(ColumnName) Then
        '                    _dicComboBoxDefault.Add(ColumnName, _OptionsList.First.Id)
        '                End If
        '                '_UPDataGridViewColumn.DefaultCellStyle.DataSourceNullValue = _OptionsList.First.Id
        '                '_UPDataGridViewColumn.DefaultCellStyle.NullValue = IdDefault
        '            End If
        '        End If
        '    End If
        'End If

        Columns.Add(_UPDataGridViewColumn)

        Return _UPDataGridViewColumn

    End Function

    Public Function CrearteColumnFloat(ByVal ColumnName As String, ByVal HeaderText As String, ByVal IsReadOnly As Boolean,
                                       ByVal Visible As Boolean, Optional Decimals As Int32 = 2) As DataGridViewColumn



        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = String.Format("N{0}", Decimals)


        Dim _DataGridViewColumn As DataGridViewColumn
        _DataGridViewColumn = New PEDataGridViewColumnFloat(ColumnName, HeaderText)



        _DataGridViewColumn.Name = ColumnName
        _DataGridViewColumn.HeaderText = HeaderText
        _DataGridViewColumn.DataPropertyName = ColumnName
        _DataGridViewColumn.ReadOnly = IsReadOnly
        _DataGridViewColumn.Visible = Visible
        _DataGridViewColumn.ValueType = GetType(Double)
        _DataGridViewColumn.DefaultCellStyle.Format = String.Format("N{0}", Decimals)
        _DataGridViewColumn.DefaultCellStyle.NullValue = Double.NaN
        _DataGridViewColumn.DefaultCellStyle = DataGridViewCellStyle1
        _DataGridViewColumn.MinimumWidth = 60


        Columns.Add(_DataGridViewColumn)


        Return _DataGridViewColumn

    End Function

    Private Sub PEDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MyBase.CellFormatting


        If Columns(e.ColumnIndex).GetType() Is GetType(UPDataGridViewColumnComboBox) Then
            Dim _IdTable As Integer
            Dim _UPDataGridViewColumnComboBox As UPDataGridViewColumnComboBox = Columns(e.ColumnIndex)

            If IsDBNull(e.Value) Then
                e.Value = _UPDataGridViewColumnComboBox.GetItemName(0)
                e.FormattingApplied = True
            ElseIf Integer.TryParse(e.Value, _IdTable) Then
                e.Value = _UPDataGridViewColumnComboBox.GetItemName(_IdTable)
                e.FormattingApplied = True
            Else
                e.Value = e.Value
                e.FormattingApplied = False
            End If

        ElseIf Columns(e.ColumnIndex).GetType() Is GetType(DataGridViewButtonColumn) Then
            If e.Value IsNot Nothing Then
                e.Value = "..."
                e.FormattingApplied = True
            End If

        ElseIf Columns(e.ColumnIndex).GetType() Is GetType(PEDataGridViewColumnFloat) Then
            If IsDBNull(e.Value) Then
                e.Value = Nothing
                e.FormattingApplied = False
            ElseIf Double.IsNaN(e.Value) Then
                e.Value = Nothing
                e.FormattingApplied = False
            End If

            'ElseIf Columns(e.ColumnIndex).GetType() Is GetType(PEDataGridViewColumnDate) Then
            '    If IsDBNull(e.Value) Then
            '        e.Value = Nothing
            '        e.FormattingApplied = False
            '    End If
            'ElseIf Columns(e.ColumnIndex).GetType() Is GetType(PEDataGridViewColumnNumericUpDown) Then
            '    If IsDBNull(e.Value) Then
            '        e.Value = DBNull.Value
            '        e.FormattingApplied = False
            '    End If
        End If

        RaiseEvent EvCellFormatting(sender, e)
    End Sub

    Private Sub UPDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles MyBase.EditingControlShowing
        If Columns(CurrentCell.ColumnIndex).GetType() Is GetType(PEDataGridViewColumnFloat) Then
            Dim tb As TextBox = TryCast(e.Control, TextBox)
            If tb IsNot Nothing Then
                Try
                    RemoveHandler tb.KeyPress, AddressOf Me.tb_KeyPress
                Catch ex As Exception
                End Try

                AddHandler tb.KeyPress, AddressOf Me.tb_KeyPress
            End If
        End If
    End Sub

    Private Sub tb_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub

    Private Sub UPDataGridView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles MyBase.UserDeletingRow
        ' Pregunta al usuario si realmente desea Delete la fila
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas Delete esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True ' Cancela la eliminación si el usuario no confirma
        End If
    End Sub

    Private Sub UPDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Me.RowHeaderMouseClick
        If _Editing Then
            MyBase.EndEdit()
        End If

    End Sub

    Private Sub UPDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Me.CellClick
        If _Editing Then
            If Not Columns(e.ColumnIndex).ReadOnly Then
                MyBase.BeginEdit(True)
            End If

            'Dim _ColumnName As String = Columns(e.ColumnIndex).Name
            'If _dicColumnsReadOnly.ContainsKey(_ColumnName) Then
            '    If _dicColumnsReadOnly(_ColumnName) Then
            '        MyBase.BeginEdit(True)
            '    End If
            'Else
            '    MyBase.BeginEdit(True)
            'End If
        End If
    End Sub

    'Private Sub UPDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Me.CellEnter
    '    If _Editing Then
    '        If Not Columns(e.ColumnIndex).ReadOnly Then
    '            MyBase.BeginEdit(True)
    '        End If

    '        'Dim _ColumnName As String = Columns(e.ColumnIndex).Name
    '        'If _dicColumnsReadOnly.ContainsKey(_ColumnName) Then
    '        '    If _dicColumnsReadOnly(_ColumnName) Then
    '        '        MyBase.BeginEdit(True)
    '        '    End If
    '        'Else
    '        '    MyBase.BeginEdit(True)
    '        'End If
    '    End If
    'End Sub
End Class
