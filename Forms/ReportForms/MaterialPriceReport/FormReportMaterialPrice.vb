Imports System.Drawing.Text
Imports System.Security.Cryptography
Imports Microsoft.Reporting.WinForms
Imports Newtonsoft.Json.Linq
Public Class FormReportMaterialPrice
    Private _project_Id As Int32
    Private _moneyType_Id As Int32

    Public Sub New()

        InitializeComponent()

        RefreshReportMaterialListPrice()

        AddHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge

        AddHandler CommonFuntion.EvInsertRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvUpdateRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvDeleteRecord, AddressOf OnEvReLoadForCrud

    End Sub

    Public Sub RefreshReportMaterialListPrice()
        ReportViewer1.LocalReport.DataSources.Clear()

        Dim _DataTableListMaterialSource As DataTable = GetListMaterialPrices(_project_Id, _moneyType_Id)

        If _DataTableListMaterialSource IsNot Nothing Then
            Dim reportDataSource As New ReportDataSource()
            reportDataSource.Name = "ReportMaterialPrice" ' Nombre de la tabla en report rdlc
            reportDataSource.Value = _DataTableListMaterialSource

            ReportViewer1.LocalReport.DataSources.Add(reportDataSource)

        End If

        ReportViewer1.LocalReport.ReportEmbeddedResource = "UPAZ.ReportMaterialPrice.rdlc"

        ReportViewer1.LocalReport.Refresh()

        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Sub OnEvDisplayReportMoneyCheged(sender As Object, e As EventArgs)
        If Not IsDisposed Then
            RefreshReportMaterialListPrice()
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
            RefreshReportMaterialListPrice()
        End If
    End Sub

    Private Sub FormReportMaterialPrice_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ReportViewer1.Refresh()
    End Sub
End Class