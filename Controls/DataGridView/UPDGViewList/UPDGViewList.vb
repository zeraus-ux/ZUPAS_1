Imports System.ComponentModel
Imports System.Windows.Controls
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq

Public Class UPDGViewList

    Private _ColumnName1 As String
    Private _ColumnName2 As String
    Private _ColumnText1 As String
    Private _ColumnText2 As String
    Private _TableName As String

    Private WithEvents _ContextMenuStrip As ContextMenuStrip
    Private WithEvents _MenuItemNewSupply As ToolStripMenuItem
    Private WithEvents _MenuItemDuplicateSupply As ToolStripMenuItem
    Private WithEvents _MenuItemEditSupply As ToolStripMenuItem
    Private WithEvents _MenuItemDeleteSupply As ToolStripMenuItem
    Private WithEvents _MenuItemFilterSupply As ToolStripMenuItem
    Private WithEvents _MenuItemFilterClear As ToolStripMenuItem

    Public Event EvNewSupply(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EvDuplicateSupply(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EvEditSupply(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EvDeleteSupply(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EvSelectedIndexChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)

    Private _CallDeletedActive As Boolean = True
    Private _Filter As String = ""
    Private _dicValuesFilter As JObject = Nothing
    Private _DataTable As DataTable
    Private _IsDuplicateSupplyActive As Boolean
    Private _IsCargandoConstructor = False

    Private Sub Formatting()

        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        MyBase.AllowUserToAddRows = False
        MyBase.AllowUserToDeleteRows = False
        MyBase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MyBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        MyBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        MyBase.BackgroundColor = System.Drawing.SystemColors.Control
        MyBase.BorderStyle = System.Windows.Forms.BorderStyle.None
        MyBase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        MyBase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        MyBase.EnableHeadersVisualStyles = False
        MyBase.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer))
        MyBase.GridColor = System.Drawing.SystemColors.ControlLightLight
        MyBase.Location = New System.Drawing.Point(151, 86)
        MyBase.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        MyBase.MultiSelect = False
        MyBase.Name = "DataGridView1"
        MyBase.RowHeadersVisible = False
        MyBase.RowHeadersWidth = 51
        MyBase.RowTemplate.Height = 24
        MyBase.Size = New System.Drawing.Size(567, 506)
        MyBase.TabIndex = 1
        MyBase.DefaultCellStyle.Padding = New Padding(10, 0, 0, 0)
        MyBase.ForeColor = System.Drawing.Color.Red
        'MyBase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer),
        '                                                 CType(CType(36, Byte), Integer),
        '                                                 CType(CType(34, Byte), Integer)) casi negro !!!!!!!!!!!!!1

        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer),
                                                                         CType(CType(240, Byte), Integer),
                                                                         CType(CType(240, Byte), Integer))



        MyBase.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Regular), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        MyBase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer),
                                                                         CType(CType(143, Byte), Integer),
                                                                         CType(CType(182, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer),
                                                                         CType(CType(238, Byte), Integer),
                                                                         CType(CType(238, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer),
                                                                                  CType(CType(143, Byte), Integer),
                                                                                  CType(CType(182, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer),
                                                                                  CType(CType(238, Byte), Integer),
                                                                                  CType(CType(238, Byte), Integer))
        'DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]

        MyBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)) 'yo
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        ' DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window

        'COLOR DE LA FILA SELECCIONADA
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer),
                                                                                  CType(CType(120, Byte), Integer),
                                                                                  CType(CType(215, Byte), Integer))
        'celeste 229,241,251
        '0,120,215
        '33,57,94

        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke

        'ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        MyBase.DefaultCellStyle = DataGridViewCellStyle3

        '
        'Form5

    End Sub


    Public Sub New(ByVal TableName As String, ByVal ColumnName1 As String, ByVal ColumnName2 As String,
                    ByVal ColumnText1 As String, ByVal ColumnText2 As String, Optional dicValuesFilter As JObject = Nothing,
                   Optional IsDuplicateSupplyActive As Boolean = False)
        MyBase.New(TableName)
        ' This call is required by the designer.
        InitializeComponent()

        _IsCargandoConstructor = True

        Formatting()

        MyBase.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        MyBase.MultiSelect = False
        MyBase.Dock = DockStyle.Fill
        MyBase.AutoGenerateColumns = False

        _IsDuplicateSupplyActive = IsDuplicateSupplyActive

        ' Add any initialization after the InitializeComponent() call.

        _ColumnName1 = ColumnName1
        _ColumnName2 = ColumnName2
        _ColumnText1 = ColumnText1
        _ColumnText2 = ColumnText2
        _TableName = TableName

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------
        ' Columns
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------

        Dim _DataGridViewColumn As DataGridViewColumn
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = CrearteColumnText("id", "id", True, True, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column _ColumnName1
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = CrearteColumnText(_ColumnName1, ColumnText1, True, True, True)
        _DataGridViewColumn.Frozen = True
        _DataGridViewColumn.MinimumWidth = 50
        _DataGridViewColumn.Width = 120


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column _ColumnName2
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = CrearteColumnText(_ColumnName2, ColumnText2, True, True, True)
        _DataGridViewColumn.Frozen = False
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        _DataGridViewColumn.Width = 120


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------
        ' ContextMenuStrip
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------

        _ContextMenuStrip = New ContextMenuStrip()

        _MenuItemNewSupply = New ToolStripMenuItem()
        _MenuItemNewSupply.Text = "Nuevo"

        If IsDuplicateSupplyActive Then
            _MenuItemDuplicateSupply = New ToolStripMenuItem()
            _MenuItemDuplicateSupply.Text = "Duplicar"
        End If

        _MenuItemEditSupply = New ToolStripMenuItem()
        _MenuItemEditSupply.Text = "Edit"

        _MenuItemDeleteSupply = New ToolStripMenuItem()
        _MenuItemDeleteSupply.Text = "Delete"

        _MenuItemFilterSupply = New ToolStripMenuItem()
        _MenuItemFilterSupply.Text = "Filtar"

        _MenuItemFilterClear = New ToolStripMenuItem()
        _MenuItemFilterClear.Text = "Filtar Clear"

        _ContextMenuStrip.Items.Add(_MenuItemNewSupply)
        If IsDuplicateSupplyActive Then
            _ContextMenuStrip.Items.Add(_MenuItemDuplicateSupply)
        End If
        _ContextMenuStrip.Items.Add(_MenuItemEditSupply)
        _ContextMenuStrip.Items.Add(_MenuItemDeleteSupply)
        _ContextMenuStrip.Items.Add(New ToolStripSeparator())
        _ContextMenuStrip.Items.Add(_MenuItemFilterSupply)
        _ContextMenuStrip.Items.Add(_MenuItemFilterClear)

        Me.ContextMenuStrip = _ContextMenuStrip


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------
        ' ContextMenuStrip
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------


        LoadList(dicValuesFilter)

        AddHandler CommonFuntion.EvInsertRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvUpdateRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvDeleteRecord, AddressOf OnEvReLoadForCrud


        _IsCargandoConstructor = False
    End Sub

    Public ReadOnly Property selectedItem As DataGridViewRow
        Get
            If SelectedRows IsNot Nothing AndAlso SelectedRows.Count > 0 Then
                Return SelectedRows(0)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property selectedId As Int32
        Get
            If selectedItem IsNot Nothing Then
                Return selectedItem.Cells(0).Value
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property selectedCode As String
        Get
            If selectedItem IsNot Nothing Then
                Return selectedItem.Cells(1).Value
            Else
                Return ""
            End If
        End Get
    End Property

    Public ReadOnly Property selectedSupplyName As String
        Get
            If selectedItem IsNot Nothing Then
                Return selectedItem.Cells(2).Value
            Else
                Return ""
            End If
        End Get
    End Property

    Public Property MenuItemEditSupplyVisible As Boolean
        Get
            Return _MenuItemEditSupply.Visible
        End Get
        Set(value As Boolean)
            _MenuItemEditSupply.Visible = value
        End Set
    End Property

    Public Property CallDeletedActive As Boolean
        Get
            Return _CallDeletedActive
        End Get
        Set(value As Boolean)
            _CallDeletedActive = value
        End Set
    End Property

    Public Sub SetSelectedItem(ByVal Index As Int32)
        If Not _IsCargandoConstructor Then
            If RowCount > 0 Then
                ClearSelection()
                Rows(Max(Index, 0)).Selected = True
                HacerFilaVisible(Max(Index, 0))
            End If
            RaiseEvent EvSelectedIndexChanged(Me, New DataGridViewCellEventArgs(0, Index))
        End If
    End Sub

    Private Sub HacerFilaVisible(ByVal indiceFila As Integer)
        If indiceFila >= 0 AndAlso indiceFila < Rows.Count Then
            FirstDisplayedScrollingRowIndex = indiceFila
        End If
    End Sub

    Public Sub SetSelectedItemId(ByVal Id As Int32)
        For Each _row As DataGridViewRow In Rows
            If _row.Cells("id").Value = Id Then
                SetSelectedItem(_row.Index)
                Exit Sub
            End If
        Next
    End Sub

    Public Sub LoadList(Optional dicValuesFilter As JObject = Nothing)

        _dicValuesFilter = dicValuesFilter

        Dim _datatable As DataTable = GetDataTable(_TableName, ColumnNames:=ListColumns, dicValuesFilter:=dicValuesFilter)

        DataSource = _datatable

        _MenuItemFilterSupply.Text = "Filter"

        SetSelectedItem(Rows.Count - 1)

        Me._DataTable = _datatable
    End Sub

    Public Shadows Sub ReLoadData(Optional dicValuesFilter As JObject = Nothing, Optional IsDistinct As Boolean = False)
        _dicValuesFilter = dicValuesFilter
        MyBase.ReLoadData(dicValuesFilter, IsDistinct)

        Me._DataTable = TryCast(DataSource, DataTable)
    End Sub

    Public Shadows Sub ReLoadData()
        ReLoadData(_dicValuesFilter)
    End Sub

    Public Sub FilterList(ByVal Filter As String)
        _Filter = Filter

        'LoadList(_dicValuesFilter)

        If Not String.IsNullOrEmpty(Filter) Then

            'Dim dataTable As DataTable = TryCast(_DataTable, DataTable)
            'Dim dataTable As DataTable = TryCast(DataSource, DataTable)
            'Dim dataView As New DataView(DataTable)
            Dim dataView As New DataView(_DataTable)
            dataView.RowFilter = String.Format("{0} LIKE '%{1}%' OR {2} LIKE '%{3}%' ", _ColumnName2, Filter, _ColumnName1, Filter)
            DataSource = dataView.ToTable()

            _MenuItemFilterSupply.Text = String.Format("Filerted: {0}", Filter)

        Else
            DataSource = _DataTable
        End If

    End Sub


    Public Sub ReLoadList()
        FilterList(_Filter)

    End Sub

    Private Sub OnEvReLoadForCrud(ByVal TableName As String)
        If _TableName.ToLower() = TableName.ToLower() Then
            ReLoadData()
        End If
    End Sub


#Region "ContextMenuStrip"

    Public Sub LoadMenuItem(ByRef MenuItem As ToolStripItem)
        Me.ContextMenuStrip.Items.Add(MenuItem)
    End Sub

    Private Sub _ContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles _ContextMenuStrip.Opening
        _MenuItemEditSupply.Enabled = selectedItem IsNot Nothing
        _MenuItemDeleteSupply.Enabled = selectedItem IsNot Nothing AndAlso _CallDeletedActive

        If _IsDuplicateSupplyActive Then
            _MenuItemDuplicateSupply.Enabled = selectedItem IsNot Nothing
        End If
    End Sub

    Private Sub _MenuItemNewSupply_Click(sender As Object, e As EventArgs) Handles _MenuItemNewSupply.Click
        RaiseEvent EvNewSupply(sender, e)

    End Sub

    Private Sub _MenuItemDuplicateSupply_Click(sender As Object, e As EventArgs) Handles _MenuItemDuplicateSupply.Click
        RaiseEvent EvDuplicateSupply(sender, e)
    End Sub

    Private Sub _MenuItemEditSupply_Click(sender As Object, e As EventArgs) Handles _MenuItemEditSupply.Click
        RaiseEvent EvEditSupply(sender, e)

    End Sub

    Private Sub _MenuItemFilterSupply_Click(sender As Object, e As EventArgs) Handles _MenuItemFilterSupply.Click

        Dim _Result As String = InputBox("Indicar el filtro", "Filter Materiales", "")
        If Not String.IsNullOrEmpty(_Result) Then
            FilterList(_Result)
        End If

    End Sub

    Private Sub _MenuItemFilterClear_Click(sender As Object, e As EventArgs) Handles _MenuItemFilterClear.Click

        LoadList()

    End Sub

    Private Sub UPDGViewList_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles MyBase.RowEnter

        ' NOTA: HAY QUE BUSCAR UN MEJOR EVENTO PARA EL SELECT INDEX CHANGE. ESTE EVENTO SE DISPARA DOS VECES Y DESELECCIONA EL ROW.

        RaiseEvent EvSelectedIndexChanged(sender, e)
    End Sub

    Private Sub _MenuItemDeleteSupply_Click(sender As Object, e As EventArgs) Handles _MenuItemDeleteSupply.Click
        If CallDeletedActive Then
            If selectedItem IsNot Nothing Then
                If GetDelete(_TableName, selectedId) Then
                    Dim _Index As Int32 = selectedItem.Index - 1
                    ReLoadData()
                    ReLoadList()
                    MessageBox.Show("Registro borrado", "borrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SetSelectedItem(_Index)
                End If
            End If
        End If
        RaiseEvent EvDeleteSupply(Me, e)
    End Sub

#End Region


End Class
