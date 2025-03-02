Imports System.Windows.Controls
Imports Newtonsoft.Json.Linq

Public Class PanelListPartida


    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPCBoxChapterList As UPComboBox
    Private WithEvents _UPTxtFilterType As UPTextBox
    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Public Event EvDoubleClick(sender As Object, e As EventArgs)

    Private _IsInitialize As Boolean = False
    Private _dicValuesFilter As JObject = Nothing

    Public Sub New(Optional ByVal dicValuesFilter As JObject = Nothing,
                   Optional ByVal DSourceIsRequerido As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        MyBase.Dock = DockStyle.Fill
        MyBase.Padding = New Padding(0)
        MyBase.Margin = New Padding(0)

        'Test-------------------------
        ' MyBase.BorderStyle = BorderStyle.FixedSingle
        '----------------------------------


        Me.tlpListPartida.Dock = DockStyle.Fill
        Me.tlpListPartida.Padding = New Padding(0)
        Me.tlpListPartida.Margin = New Padding(0)



        _IsInitialize = True

        _UPlbl0 = New UPLabel("L i s t a d o  d e  P a r t i d a s")
        ' _UPlbl0.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        ' _UPlbl0.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        '_UPlbl0.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(199, Byte), Integer))
        _UPlbl0.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(182, Byte), Integer))



        _UPlbl0.Font = New System.Drawing.Font("Microsoft Segoe UI", 14.25, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPlbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        _UPlbl0.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'filtro origen de datos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", False)
        _UPCBoxDataSourceInput.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInput.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInput.Dock = DockStyle.Fill
        _UPCBoxDataSourceInput.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Chapter
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim _columnamesPartidaChapter As New List(Of String)
        _columnamesPartidaChapter.Add("nameChapter")

        Dim _dicValuesFilter2 As JObject = Nothing
        'Dim _dicValuesFilter2 As New JObject()
        '_dicValuesFilter2("project_id") = ProjectSelectedId

        _UPCBoxChapterList = New UPComboBox("chapter", _columnamesPartidaChapter, "Capítulo", False, _dicValuesFilter2)
        _UPCBoxChapterList.SetSelectedItem(1)
        _UPCBoxChapterList.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)
        _UPCBoxChapterList.Padding = New Padding(0)
        _UPCBoxChapterList.BackColor = Color.WhiteSmoke
        _UPCBoxChapterList.Dock = DockStyle.Fill


        _UPTxtFilterType = New UPTextBox
        _UPTxtFilterType.Margin = New Padding(8, 4, 4, 4)
        _UPTxtFilterType.Padding = New Padding(0, 0, 0, 0)
        _UPTxtFilterType.Location = New System.Drawing.Point(0, 0)
        _UPTxtFilterType.Dock = DockStyle.Fill
        _UPTxtFilterType.Multiline = False
        _UPTxtFilterType.Font = New System.Drawing.Font("Microsoft Sans Serif", 13, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        '_UPTxtFilterType.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        '_UPTxtFilterType.BorderStyle = BorderStyle.None
        '_UPTxtFilterType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))


        Dim _dicValuesFilter As JObject = Nothing

        '_dicValuesFilter("project_id") = ProjectSelectedId
        If chapterId > 0 Then
            _dicValuesFilter = New JObject()
            _dicValuesFilter("chapter_id") = chapterId
        End If

        If appDataSourceInputId > 0 Then
            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        End If

        'Test----------------
        '_dicValuesFilter = New JObject()
        '_dicValuesFilter("chapter_id") = 10
        '------------------------------------

        _UPDGViewList = New UPDGViewList("partida", "refPartida", "namePartida", "Codigo", "Nombre de la Partida", _dicValuesFilter)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 4, 4, 0)


        Me.tlpListPartida.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListPartida.Controls.Add(_UPCBoxDataSourceInput, 0, 1)
        Me.tlpListPartida.Controls.Add(_UPCBoxChapterList, 0, 2)
        Me.tlpPartidaLook.Controls.Add(_UPTxtFilterType, 0, 0)
        Me.tlpListPartida.Controls.Add(_UPDGViewList, 0, 4)


        _IsInitialize = False
    End Sub

    Public Shadows Property Dock As Dock

    Public ReadOnly Property chapterId As Int32
        Get
            Return _UPCBoxChapterList.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property selectedId As Int32
        Get
            Return _UPDGViewList.selectedId
        End Get
    End Property

    Public ReadOnly Property partidaName As String
        Get
            Return _UPDGViewList.selectedSupplyName
        End Get
    End Property

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _UPCBoxDataSourceInput.GetSelectedItemId()
        End Get
    End Property

    Public Function GetListValues(Of T)(ByVal ColumnName As String) As List(Of T)

        Return _UPDGViewList.GetListValues(Of T)(ColumnName)
    End Function

    Private Sub ReloadPartida()

        Dim _dicValuesFilter As JObject
        If chapterId > 0 Then
            _dicValuesFilter = New JObject()
            _dicValuesFilter("chapter_id") = chapterId
        Else
            _dicValuesFilter = Nothing
        End If

        If chapterId > 0 Then
            _dicValuesFilter("chapter_id") = chapterId
        End If

        If appDataSourceInputId > 0 Then
            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        End If

        _UPDGViewList.ReLoadData(_dicValuesFilter, True)


    End Sub

    Private Sub _UPDGViewList_DoubleClick(sender As Object, e As EventArgs) Handles _UPDGViewList.DoubleClick
        RaiseEvent EvDoubleClick(sender, e)
    End Sub


    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply
        Dim _formPartida As New FormAPU(selectedId)
        If _formPartida.ShowDialog(Me) = DialogResult.OK Then
            ReloadPartida()
        End If


    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply
        Dim _formPartida As New FormAPU()
        If _formPartida.ShowDialog(Me) = DialogResult.OK Then
            ReloadPartida()
        End If

    End Sub


    Private Sub _UPCBoxMaterialTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxChapterList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadPartida()
            _UPTxtFilterType.Text = ""
        End If

    End Sub


    Private Sub _UPTxtFilterType_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtFilterType.TextChanged
        'If String.IsNullOrEmpty(_UPTxtFilterType.Text) Then
        '    _UPDGViewList.FilterList(_UPTxtFilterType.Text)
        'End If
        _UPDGViewList.FilterList(_UPTxtFilterType.Text)
    End Sub

    Public Sub SetSelectedItemappDataSource(ByVal Id As Int32)
        _UPCBoxDataSourceInput.SetSelectedItem(Id)
    End Sub

    Public Sub SetFilters(chapterId As Int32, ByVal appDataSourceInputId As Int32)

        If chapterId > 0 Then
            _UPCBoxChapterList.SetSelectedItem(chapterId)
        End If

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInput.SetSelectedItem(appDataSourceInputId)
        End If

    End Sub

    Private Sub _UPCBoxDataSourceInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInput.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadPartida()
            _UPTxtFilterType.Text = ""
        End If
    End Sub

    'Private Sub _UPTxtFilterType_KeyDown(sender As Object, e As KeyEventArgs) Handles _UPTxtFilterType.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        _UPDGViewList.FilterList(_UPTxtFilterType.Text)
    '    End If


    'End Sub


End Class
