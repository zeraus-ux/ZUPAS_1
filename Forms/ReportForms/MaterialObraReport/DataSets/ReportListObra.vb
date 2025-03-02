Partial Class ReportListObra
    Partial Public Class PruebaDataTable
    End Class

    Partial Public Class SymbolMoneyDataTable
        Private Sub SymbolMoneyDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SymbolMoneyNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
