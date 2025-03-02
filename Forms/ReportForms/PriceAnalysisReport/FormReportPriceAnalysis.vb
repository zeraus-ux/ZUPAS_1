Imports System.Drawing.Text
Imports System.Security.Cryptography
Imports Microsoft.Reporting.WinForms
Imports Newtonsoft.Json.Linq

Public Class FormReportPriceAnalysis

    Private _partida_id As Int32 = -1
    Private _obra_id As Int32 = -1


    Public Sub New(ByVal partida_id As Int32, Optional ByVal obra_id As Int32 = -1)

        ' This call is required by the designer.
        InitializeComponent()

        _partida_id = partida_id
        _obra_id = obra_id

        RefreshReportPriceAnalysis()

        AddHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge

        AddHandler CommonFuntion.EvInsertRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvUpdateRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvDeleteRecord, AddressOf OnEvReLoadForCrud

    End Sub

    Public Sub RefreshReportPriceAnalysis(Optional ByVal partida_id As Int32 = -1, Optional ByVal obra_id As Int32 = -1)
        '_PriceAnalysisType = PriceAnalysisType
        ' Add any initialization after the InitializeComponent() call.

        If partida_id > 0 Then
            _partida_id = partida_id
        End If

        If obra_id > 0 Then
            _obra_id = obra_id
        End If

        Dim _moneyType_Id As Int32 = DisplayReportMoneyTypeid

        Dim _ReferenceDate As DateTime = Now()

        Dim _DataTablePartida As DataTable = Nothing
        Dim _DataTableMat As DataTable = Nothing
        Dim _DataTableEquit As DataTable = Nothing
        Dim _DataTableLabour As DataTable = Nothing
        Dim _DataTableTotMat As DataTable = Nothing
        Dim _DataTableTotLab As DataTable = Nothing
        Dim _DataTableTotEqt As DataTable = Nothing
        Dim _DataTablePartidaCosts As DataTable = Nothing

        If _partida_id > 0 Then
            _DataTablePartida = GetReportDataPartida(_partida_id)
            _DataTableMat = GetReportPartidaMaterial(_partida_id, _ReferenceDate, _moneyType_Id)
            _DataTableEquit = GetReportPartidaEquitpment(_partida_id, _ReferenceDate, _moneyType_Id)
            _DataTableLabour = GetReportPartidaLabour(_partida_id, _ReferenceDate, _moneyType_Id)
            _DataTableTotMat = GetPartidaTotalMateriales(_partida_id, _ReferenceDate, _moneyType_Id)
            _DataTableTotLab = GetPartidaTotalLabour(_partida_id, _ReferenceDate, _moneyType_Id)
            _DataTableTotEqt = GetPartidaTotalEquipment(_partida_id, _ReferenceDate, _moneyType_Id)
            _DataTablePartidaCosts = GetPartidaCosts(_partida_id, _ReferenceDate, _moneyType_Id, _obra_id)
        End If

        'Test~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Dim _Form1 As New Form1(_DataTablePartidaCosts)
        '_Form1.ShowDialog()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



#Region "SymbolMoney"



#End Region

        ReportViewer1.LocalReport.DataSources.Clear()

        If _DataTablePartida IsNot Nothing Then

            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "ReportDataPartida" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTablePartida

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        End If

        If _DataTableMat IsNot Nothing Then

            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "ReportPartidaMaterial" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableMat

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)

            '~~~~~~~~~~~~~~~~~~~~~
            ' cargando la moneda 13/09/24
            '~~~~~~~~~~~~~~~~~~~~~

            Dim _DataTableTMSymbolMoney As New DataTable
            _DataTableTMSymbolMoney.Columns.Add("TMSymbolMoneyName", GetType(String))

            Dim _DataRow As DataRow = _DataTableTMSymbolMoney.NewRow()
            _DataRow("TMSymbolMoneyName") = $"Total Materiales {DisplayReportSymbolMoney}:"

            _DataTableTMSymbolMoney.Rows.Add(_DataRow)
            _DataTableTMSymbolMoney.AcceptChanges()

            Dim reportDataSource1 As New ReportDataSource()
            reportDataSource1.Name = "TMSymbolMoney" ' Nombre de la tabla en report rdlc
            reportDataSource1.Value = _DataTableTMSymbolMoney

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource1)

            Dim _DataTablePUMSymbolMoney As New DataTable
            _DataTablePUMSymbolMoney.Columns.Add("PUMSymbolMoneyName", GetType(String))

            Dim _DataRow2 As DataRow = _DataTablePUMSymbolMoney.NewRow()
            _DataRow2("PUMSymbolMoneyName") = $"Unitario de Materiales {DisplayReportSymbolMoney}:"

            _DataTablePUMSymbolMoney.Rows.Add(_DataRow2)
            _DataTableTMSymbolMoney.AcceptChanges()

            Dim reportDataSource2 As New ReportDataSource()
            reportDataSource2.Name = "PUMSymbolMoney" ' Nombre de la tabla en report rdlc
            reportDataSource2.Value = _DataTablePUMSymbolMoney

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource2)

        End If

        If _DataTableEquit IsNot Nothing Then

            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "ReportPartidaEquitpment" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableEquit

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)

            '~~~~~~~~~~~~~~~~~~~~~
            ' cargarndo la moneda 13/09/24
            '~~~~~~~~~~~~~~~~~~~~~

            Dim _DataTableTESymbolMoney As New DataTable
            _DataTableTESymbolMoney.Columns.Add("TESymbolMoneyName", GetType(String))

            Dim _DataRow As DataRow = _DataTableTESymbolMoney.NewRow()
            _DataRow("TESymbolMoneyName") = $"Total Equipos {DisplayReportSymbolMoney}:"

            _DataTableTESymbolMoney.Rows.Add(_DataRow)
            _DataTableTESymbolMoney.AcceptChanges()

            Dim reportDataSource1 As New ReportDataSource()
            reportDataSource1.Name = "TESymbolMoney" ' Nombre de la tabla en report rdlc
            reportDataSource1.Value = _DataTableTESymbolMoney

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource1)

            Dim _DataTablePUESymbolMoney As New DataTable
            _DataTablePUESymbolMoney.Columns.Add("PUESymbolMoneyName", GetType(String))

            Dim _DataRow2 As DataRow = _DataTablePUESymbolMoney.NewRow()
            _DataRow2("PUESymbolMoneyName") = $"Unitario de Equipos {DisplayReportSymbolMoney}:"

            _DataTablePUESymbolMoney.Rows.Add(_DataRow2)
            _DataTableTESymbolMoney.AcceptChanges()

            Dim reportDataSource2 As New ReportDataSource()
            reportDataSource2.Name = "PUESymbolMoney" ' Nombre de la tabla en report rdlc
            reportDataSource2.Value = _DataTablePUESymbolMoney

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource2)

        End If

        If _DataTableLabour IsNot Nothing Then
            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "ReportPartidaLabour" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableLabour

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        End If

        If _DataTableTotMat IsNot Nothing Then
            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "PartidaTotalMateriales" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableTotMat

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        End If


        If _DataTableTotLab IsNot Nothing Then
            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "PartidaTotalLabour" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableTotLab

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        End If


        If _DataTableTotEqt IsNot Nothing Then
            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "PartidaTotalEquipment" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableTotEqt

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        End If

        If _DataTablePartidaCosts IsNot Nothing Then
            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "PartidaCosts" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTablePartidaCosts

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        End If


        ReportViewer1.LocalReport.ReportEmbeddedResource = "UPAZ.PriceAnalysis.rdlc"

        'Select Case _PriceAnalysisType
        '    Case EnumPriceAnalysisType.Obra

        '        ReportViewer1.LocalReport.ReportEmbeddedResource = "UPAZ.PriceAnalysis.rdlc"

        '    Case EnumPriceAnalysisType.Partida
        '        ReportViewer1.LocalReport.ReportEmbeddedResource = "UPAZ.PriceAnalysisPartida.rdlc"

        'End Select

        'ReportViewer1.LocalReport.ReportPath = "Report1.rdlc" ' Ruta al archivo de informe

        ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Sub OnEvDisplayReportMoneyCheged(sender As Object, e As EventArgs)
        If Not IsDisposed Then
            RefreshReportPriceAnalysis()
        Else
            Try
                RemoveHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
                RemoveHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub OnEvProjectSeletedChnge(sender, e)
        Try
            RemoveHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
            RemoveHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge
        Catch ex As Exception
        End Try

        Close()
    End Sub

    Private Sub OnEvReLoadForCrud(ByVal TableName As String) ' hoy para todo slos formularios de reportes
        If Not IsDisposed Then
            RefreshReportPriceAnalysis()
        End If
    End Sub

    Private Sub FormReportPriceAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class