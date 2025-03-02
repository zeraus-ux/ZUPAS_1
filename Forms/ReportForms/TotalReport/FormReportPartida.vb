Imports System.Windows.Media
Imports System.Windows.Media.Media3D
Imports FontAwesome.Sharp
Imports Newtonsoft.Json.Linq

Public Class FormReportPartida
    Private WithEvents _UPlbl0 As UPLabel

    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPCBoxDataSourceInputList As UPComboBox
    Private WithEvents _UPCBoxChapterList As UPComboBox
    Private WithEvents _UPTxtPartidaFilter As UPTextBox
    Private _FormReportPriceAnalysis As FormReportPriceAnalysis = Nothing
    Private _FormReportPriceAnalysisArg As FormReportPriceAnalisysArg = Nothing

    Private _IsInitialize = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _IsInitialize = True

        'UPlbl0
        _UPlbl0 = New UPLabel("L i s t a d o  d e  P a r t i d a s")
        _UPlbl0.SetFormatForeColor2()

        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        _UPlbl0.Font = New System.Drawing.Font("Microsoft Segoe UI", 14.25, System.Drawing.FontStyle.Regular,
                                               System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPlbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        _UPlbl0.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)

        'UPDGViewList
        Dim _dicValuesFilter0 As New JObject
        _dicValuesFilter0("chapter_id") = 8

        _UPDGViewList = New UPDGViewList("partida", "refPartida", "namePartida", "Código", "Nombre de la partida", _dicValuesFilter0)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: (SourceInput) Para la Lista
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInputList = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", True)
        _UPCBoxDataSourceInputList.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)

        'UPCBoxChapterList
        Dim _columnamesPartidaChapter As New List(Of String)
        _columnamesPartidaChapter.Add("nameChapter")

        Dim _dicValuesFilterProj As JObject = Nothing

        'Dim _dicValuesFilterProj As New JObject()
        '_dicValuesFilterProj("project_id") = ProjectSelectedId

        _UPCBoxChapterList = New UPComboBox("chapter", _columnamesPartidaChapter, "Capítulo", True, _dicValuesFilterProj)
        _UPCBoxChapterList.SetSelectedItem(1)
        _UPCBoxChapterList.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)

        'UPTxtPartidaFilter
        _UPTxtPartidaFilter = New UPTextBox()
        _UPTxtPartidaFilter.Margin = New System.Windows.Forms.Padding(8, 4, 8, 4)


        If IsPartidaARG Then
            'FormReportPriceAnalysis
            _FormReportPriceAnalysisArg = New FormReportPriceAnalisysArg(selectedId)
            _FormReportPriceAnalysisArg.TopLevel = False
            _FormReportPriceAnalysisArg.FormBorderStyle = FormBorderStyle.None
            _FormReportPriceAnalysisArg.Dock = DockStyle.Fill
            Me.SplitContPartida.Panel2.Controls.Add(_FormReportPriceAnalysisArg)
            _FormReportPriceAnalysisArg.BringToFront()
            _FormReportPriceAnalysisArg.Show()

        Else
            'FormReportPriceAnalysis
            _FormReportPriceAnalysis = New FormReportPriceAnalysis(selectedId)
            _FormReportPriceAnalysis.TopLevel = False
            _FormReportPriceAnalysis.FormBorderStyle = FormBorderStyle.None
            _FormReportPriceAnalysis.Dock = DockStyle.Fill
            Me.SplitContPartida.Panel2.Controls.Add(_FormReportPriceAnalysis)
            _FormReportPriceAnalysis.BringToFront()
            _FormReportPriceAnalysis.Show()

        End If

        Me.tlpListPartida.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListPartida.Controls.Add(_UPCBoxDataSourceInputList, 0, 1)
        Me.tlpListPartida.Controls.Add(_UPCBoxChapterList, 0, 2)
        Me.tlpPartidaLook.Controls.Add(_UPTxtPartidaFilter, 0, 3)
        Me.tlpListPartida.Controls.Add(_UPDGViewList, 0, 4)
        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnProjectSeletedChnge

        _IsInitialize = False

        _UPDGViewList.SetSelectedItem(0)
    End Sub

    Public ReadOnly Property selectedId As Int32
        Get
            Return _UPDGViewList.selectedId
        End Get
    End Property

    Public ReadOnly Property selectedChapterId As Int32
        Get
            Return _UPCBoxChapterList.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property selectedSourceId As Int32
        Get
            Return _UPCBoxDataSourceInputList.GetSelectedItemId()
        End Get
    End Property

    Public Sub ReloadPartidas()

        Dim _dicValuesFilter0 As JObject
        '_dicValuesFilter0("project_id") = ProjectSelectedId

        If selectedChapterId > 0 Then
            _dicValuesFilter0 = New JObject()
            _dicValuesFilter0("chapter_Id") = selectedChapterId
        Else
            _dicValuesFilter0 = Nothing
        End If

        If selectedSourceId > 0 Then
            If _dicValuesFilter0 Is Nothing Then
                _dicValuesFilter0 = New JObject()
            End If

            _dicValuesFilter0("appDataSourceInput_id") = selectedSourceId
        Else
            _dicValuesFilter0 = Nothing
        End If
        _UPDGViewList.ReLoadData(_dicValuesFilter0, True)

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
        ' cada vez que cargue partida selecciona el evento 1

        _UPDGViewList.SetSelectedItem(0)

    End Sub

    Private Sub OnProjectSeletedChnge(sender As Object, e As EventArgs)

        Close()

        'If ProjectSelectedId > 0 Then
        '    Dim _dicValuesFilter0 As New JObject
        '    _dicValuesFilter0("project_id") = ProjectSelectedId

        '    _UPDGViewList.LoadList(_dicValuesFilter0)
        '    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

        '    _UPCBoxChapterList.ReLoad(_dicValuesFilter0)
        '    _UPCBoxChapterList.SetSelectedItem(1)

        '    _UPCBoxDataSourceInputList.ReLoad(_dicValuesFilter0)
        '    _UPCBoxDataSourceInputList.SetSelectedItem(1)

        'End If

        ''XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
        '' cada vez que cargue partida selecciona el evento 1

        '_UPDGViewList.SetSelectedItem(0)

    End Sub

    Private Sub _UPCBoxChapterList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxChapterList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadPartidas()
            _UPTxtPartidaFilter.Text = ""
        End If
    End Sub

    Private Sub RefreshReportPriceAnalysis()

        If selectedId = -1 Then
            'MessageBox.Show("No hay partida seleccionada", "visualizar partida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'SplitContainerAPU.Panel2Collapsed = True
            Exit Sub
        End If

        If IsPartidaARG Then
            _FormReportPriceAnalysisArg.RefreshReportPriceAnalysis(selectedId)
        Else
            _FormReportPriceAnalysis.RefreshReportPriceAnalysis(selectedId)
        End If


    End Sub

    Private Sub _UPTxtPartidaFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtPartidaFilter.TextChanged
        _UPDGViewList.FilterList(_UPTxtPartidaFilter.Text)
    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged
        If Not _IsInitialize Then
            RefreshReportPriceAnalysis()
        End If
    End Sub

    Private Sub FormReportPartida_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        SplitContPartida.SplitterDistance = 300
        SplitContPartida.Panel1MinSize = 300
        SplitContPartida.Panel2MinSize = 300

    End Sub

    Private Sub _UPCBoxDataSourceInputList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInputList.SelectedIndexChanged
        ReloadPartidas()
    End Sub
End Class