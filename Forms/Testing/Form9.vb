Imports Microsoft.Reporting.WinForms
Imports Newtonsoft.Json.Linq

Public Class Form9
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'Panel1.Controls.Add(_DataTablePresupuesto)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private _obra_id As Int32

    Private _PresuuestoType As EnumPresupuestoType = EnumPresupuestoType.None

    Public Sub New(ByVal obra_id As Int32, Optional PresuuestoType As EnumPresupuestoType = EnumPresupuestoType.None)

        ' This call is required by the designer.
        InitializeComponent()

        '_PriceAnalysisType = PriceAnalysisType
        ' Add any initialization after the InitializeComponent() call.


        _obra_id = obra_id
        _PresuuestoType = PresuuestoType

        AddHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge

        RefreshReportPresupuesto()

    End Sub

    Public Sub RefreshReportPresupuesto(Optional ByVal obra_id As Int32 = -1)

            If obra_id > 0 Then
                _obra_id = obra_id
            End If

            Dim _moneyType_Id As Int32 = DisplayReportMoneyTypeid



        Dim _ReferenceDate As DateTime = Now()

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _obra_id
            Dim _DataTableObra As DataTable = GetDataTable("obra", New List(Of String), _dicValuesFilter)

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            '~~~~~~~~~~~~~~~~~~~~~
            ' cargarndo la moneda 13/09/24
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



        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        If _DataTableObra IsNot Nothing Then

                Dim reportDataSource As New ReportDataSource()
                reportDataSource.Name = "DataTableObra" ' Nombre de la tabla en report rdlc
                reportDataSource.Value = _DataTableObra



        End If

            Select Case _PresuuestoType
            Case EnumPresupuestoType.None

                Dim _DataTablePresupuesto As DataTable = GetPresupuesto(_obra_id, _ReferenceDate, _moneyType_Id)

                    If _DataTablePresupuesto IsNot Nothing Then

                        Dim reportDataSource As New ReportDataSource()
                        reportDataSource.Name = "ReportPresupuesto" ' Nombre de la tabla en report rdlc
                        reportDataSource.Value = _DataTablePresupuesto


                End If


                    Dim _DataTableTotalPresupuesto As DataTable = GetTotalPresupuesto(_obra_id, _ReferenceDate, _moneyType_Id)

                    If _DataTableTotalPresupuesto IsNot Nothing Then

                        Dim reportDataSource As New ReportDataSource()
                        reportDataSource.Name = "TotalPresupuesto" ' Nombre de la tabla en report rdlc
                        reportDataSource.Value = _DataTableTotalPresupuesto


                End If


            Case EnumPresupuestoType.IsByChapter

                Dim _ListChapter As List(Of Int32) = GetListChapterPresupuesto(_obra_id)
                    Dim _Index As Int32 = 1

                    For Each _chapter_id As Int32 In _ListChapter

                        Dim _DataTablePresupuesto As DataTable = GetPresupuesto(_obra_id, _ReferenceDate,
                                                                                _moneyType_Id,
                                                                                chapter_id:=_chapter_id)

                        If _DataTablePresupuesto IsNot Nothing Then

                            Dim reportDataSource As New ReportDataSource()
                            reportDataSource.Name = String.Format("ReportPresupuesto{0}", _Index)
                            reportDataSource.Value = _DataTablePresupuesto

                    End If


                        Dim _DataTableTotalPresupuesto As DataTable = GetTotalPresupuesto(_obra_id, _ReferenceDate,
                                                                                          _moneyType_Id,
                                                                                          chapter_id:=_chapter_id)

                        If _DataTableTotalPresupuesto IsNot Nothing Then

                            Dim reportDataSource As New ReportDataSource()
                            reportDataSource.Name = String.Format("TotalPresupuesto{0}", _Index)  ' Nombre de la tabla en report rdlc
                            reportDataSource.Value = _DataTableTotalPresupuesto

                    End If

                        _Index += 1
                    Next


            Case EnumPresupuestoType.IsByStage

                Dim _ListStage As List(Of Int32) = GetListStagePresupuesto(_obra_id)
                    Dim _Index As Int32 = 1

                    For Each _obraStage_id As Int32 In _ListStage

                        Dim _DataTablePresupuesto As DataTable = GetPresupuesto(_obra_id, _ReferenceDate,
                                                                                _moneyType_Id,
                                                                                chapter_id:=-1,
                                                                                obraStage_id:=_obraStage_id)

                        If _DataTablePresupuesto IsNot Nothing Then

                            Dim reportDataSource As New ReportDataSource()
                            reportDataSource.Name = String.Format("ReportPresupuestoS{0}", _Index)
                            reportDataSource.Value = _DataTablePresupuesto


                    End If


                        Dim _DataTableTotalPresupuesto As DataTable = GetTotalPresupuesto(_obra_id, _ReferenceDate,
                                                                                          _moneyType_Id,
                                                                                          chapter_id:=-1,
                                                                                          obraStage_id:=_obraStage_id)

                        If _DataTableTotalPresupuesto IsNot Nothing Then

                            Dim reportDataSource As New ReportDataSource()
                            reportDataSource.Name = String.Format("TotalPresupuesto{0}", _Index)  ' Nombre de la tabla en report rdlc
                            reportDataSource.Value = _DataTableTotalPresupuesto


                    End If

                        _Index += 1
                    Next


        End Select


    End Sub


        Private Sub OnEvDisplayReportMoneyCheged(sender As Object, e As EventArgs)
            RefreshReportPresupuesto()
        End Sub

        Private Sub OnEvProjectSeletedChnge(sender, e)
            RemoveHandler CommonFuntion.EvDisplayReportMoneyCheged, AddressOf OnEvDisplayReportMoneyCheged
            RemoveHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnEvProjectSeletedChnge
            Close()
        End Sub


End Class
