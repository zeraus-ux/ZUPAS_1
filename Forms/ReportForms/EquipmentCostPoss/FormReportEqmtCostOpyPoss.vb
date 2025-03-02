Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Text
Imports System.Security.Cryptography
Imports Newtonsoft.Json.Linq

Public Class FormReportEqmtCostOpyPoss

    Private _FomEqmtPriceEst As FomEqmtPriceEst

    Public Sub New(ByRef vFomEqmtPriceEst As FomEqmtPriceEst)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _FomEqmtPriceEst = vFomEqmtPriceEst

        RefreshReport()

        AddHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge

        AddHandler CommonFuntion.EvInsertRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvUpdateRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvDeleteRecord, AddressOf OnEvReLoadForCrud


    End Sub

    Public ReadOnly Property EqmtPriceEstType As EnumEqmtPriceEstType
        Get
            Return _FomEqmtPriceEst.EqmtPriceEstType
        End Get
    End Property


    Public Function GetDataTable() As DataTable
        Return _FomEqmtPriceEst.GetDataTable()
    End Function


    Public Sub RefreshReport()
        '_PriceAnalysisType = PriceAnalysisType
        ' Add any initialization after the InitializeComponent() call.

        Dim _moneyType_Id As Int32 = DisplayReportMoneyTypeid
        Dim _ReferenceDate As DateTime = Now()

        Dim _DataTablePrecEst As DataTable = GetDataTable()

        ReportViewer1.LocalReport.DataSources.Clear()

        If _DataTablePrecEst IsNot Nothing Then

            Dim reportDataSource As New ReportDataSource()

            reportDataSource.Name = "DataSetEqmtCost" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTablePrecEst

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        End If

        Select Case EqmtPriceEstType
            Case EnumEqmtPriceEstType.Maquinaria1
                ReportViewer1.LocalReport.ReportEmbeddedResource = "UPAZ.ReportEqmtPossOp1.rdlc"


            Case EnumEqmtPriceEstType.Maquinaria2
                ReportViewer1.LocalReport.ReportEmbeddedResource = "UPAZ.ReportEqmtPossOp2.rdlc"

            Case EnumEqmtPriceEstType.Maquinaria3
                ReportViewer1.LocalReport.ReportEmbeddedResource = "UPAZ.ReportEqmtPossOp3.rdlc"

            Case EnumEqmtPriceEstType.Maquinaria4
                ReportViewer1.LocalReport.ReportEmbeddedResource = "UPAZ.ReportEqmtPossOp4.rdlc"

        End Select


        ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub OnEvProjectSeletedChnge(sender, e)
        RemoveHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
        RemoveHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge
        Close()

    End Sub

    Private Sub OnEvDisplayReportMoneyCheged(sender As Object, e As EventArgs)
        RefreshReport()
    End Sub

    Private Sub OnEvReLoadForCrud(ByVal TableName As String)
        If Not IsDisposed Then
            RefreshReport()
        End If
    End Sub

    Private Sub FormReportEqmtCostOpyPoss_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshReport()
    End Sub


End Class