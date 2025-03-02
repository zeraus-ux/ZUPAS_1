Imports Microsoft.Reporting.WinForms
Imports Newtonsoft.Json.Linq
Public Class FormMaterialList2
    Private _obra_id As Int32
    Private _IsByChapter As Boolean
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Public Sub New(ByVal obra_id As Int32, Optional IsByChapter As Boolean = False)

        InitializeComponent()

        _obra_id = obra_id
        _IsByChapter = IsByChapter

        RefreshReportMaterialList()

        AddHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge

        AddHandler CommonFuntion.EvInsertRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvUpdateRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvDeleteRecord, AddressOf OnEvReLoadForCrud

    End Sub


    Public Sub RefreshReportMaterialList(Optional ByVal obra_id As Int32 = -1)

        If obra_id > 0 Then
            _obra_id = obra_id
        End If

        Dim _moneyType_Id As Int32 = DisplayReportMoneyTypeid

        ReportViewer1.LocalReport.DataSources.Clear()

        Dim _ReferenceDate As DateTime = Now()

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("id") = _obra_id
        Dim _DataTableObra As DataTable = GetDataTable("obra", New List(Of String), _dicValuesFilter)

        'Test~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Dim _Form1 As New Form1(_DataTableObra)
        '_Form1.ShowDialog()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        '~~~~~~~~~~~~~~~~~~~~~
        ' cargarndo la moneda
        '~~~~~~~~~~~~~~~~~~~~~

        Dim _DataTableSymbolMoney As New DataTable
        _DataTableSymbolMoney.Columns.Add("SymbolMoneyName", GetType(String))

        Dim _DataRow As DataRow = _DataTableSymbolMoney.NewRow()
        _DataRow("SymbolMoneyName") = $"Total ({DisplayReportSymbolMoney}):"

        _DataTableSymbolMoney.Rows.Add(_DataRow)
        _DataTableSymbolMoney.AcceptChanges()

        Dim reportDataSource1 As New ReportDataSource()
        reportDataSource1.Name = "SymbolMoney" ' Nombre de la tabla en report rdlc
        reportDataSource1.Value = _DataTableSymbolMoney

        ReportViewer1.LocalReport.DataSources.Add(reportDataSource1)
        '--------------------------------------------------------------------------------------

        If _DataTableObra IsNot Nothing Then

            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "DataTableObra" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableObra

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)

        End If

        Dim _DataTableMaterialList As DataTable = GetMaterialesDeObra(_obra_id, _ReferenceDate, _moneyType_Id)

        'Test~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Stop
        'Dim _DataTablePresupuesto1 As DataTable = GetMaterialesDeObra(_obra_id, _ReferenceDate)
        'Dim _Form2 As New Form1(_DataTablePresupuesto1)
        '_Form2.ShowDialog()
        ''Stop
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        If _DataTableMaterialList IsNot Nothing Then

            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "MaterialesDeObra" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableMaterialList

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        End If

        '====================================================


        Dim _DataTableTotalMaterialList As DataTable = GetTotalMaterialesDeObra(_obra_id, _ReferenceDate, _moneyType_Id)


        If _DataTableTotalMaterialList IsNot Nothing Then

            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "TableTotalMaterialList" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableTotalMaterialList

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        End If


        '====================================================
        ReportViewer1.LocalReport.ReportEmbeddedResource = "UPAZ.ListadoMaterialesDeObra.rdlc"

        ReportViewer1.LocalReport.Refresh()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub OnEvDisplayReportMoneyCheged(sender As Object, e As EventArgs)
        RefreshReportMaterialList()
    End Sub

    Private Sub OnEvProjectSeletedChnge(sender, e)
        RemoveHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
        RemoveHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge
        Close()

    End Sub

    Private Sub OnEvReLoadForCrud(ByVal TableName As String) ' hoy para todo slos formularios de reportes
        If Not IsDisposed Then
            RefreshReportMaterialList()
        End If
    End Sub


    Private Sub FormMaterialList2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class