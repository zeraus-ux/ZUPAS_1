

Partial Public Class DataSetReportPartida
    Partial Public Class PartidaCostsDataTable
        Private Sub PartidaCostsDataTable_PartidaCostsRowChanging(sender As Object, e As PartidaCostsRowChangeEvent) Handles Me.PartidaCostsRowChanging

        End Sub

    End Class

    Partial Public Class ReportPartidaMaterialDataTable
        Private Sub ReportPartidaMaterialDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            'If (e.Column.ColumnName = Me.CostoColumn.ColumnName) Then
            'Add user code here
            'End If

        End Sub

    End Class
End Class
