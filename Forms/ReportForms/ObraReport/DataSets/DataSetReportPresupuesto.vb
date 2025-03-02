

Partial Public Class DataSetReportPresupuesto
    Partial Public Class DataTable2DataTable
        'Private Sub DataTable2DataTable_DataTable2RowChanging(sender As Object, e As DataTable2RowChangeEvent) Handles Me.DataTable2RowChanging

        'End Sub

    End Class

    Partial Public Class TotalPresupuestoDataTable
        Private Sub TotalPresupuestoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            'If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
            '    'Add user code here
            'End If

        End Sub

        Private Sub TotalPresupuestoDataTable_TotalPresupuestoRowChanging(sender As Object, e As TotalPresupuestoRowChangeEvent) Handles Me.TotalPresupuestoRowChanging

        End Sub

    End Class

    Partial Public Class ReportPresupuestoDataTable
        Private Sub ReportPresupuestoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.symbolUnitColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

