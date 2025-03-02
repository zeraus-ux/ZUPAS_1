

Partial Public Class DataSetReportArg
    Partial Public Class PartidaCostsEquitmentTotalArgDataTable
        Private Sub PartidaCostsEquitmentTotalArgDataTable_PartidaCostsEquitmentTotalArgRowChanging(sender As Object, e As PartidaCostsEquitmentTotalArgRowChangeEvent) Handles Me.PartidaCostsEquitmentTotalArgRowChanging

        End Sub

    End Class

    Partial Public Class PartidaCostsEquitmentTbArgDataTable


    End Class

    Partial Public Class PartidaEquipmentTotalArgDataTable
        Private Sub PartidaEquipmentTotalArgDataTable_PartidaEquipmentTotalArgRowChanging(sender As Object, e As PartidaEquipmentTotalArgRowChangeEvent) Handles Me.PartidaEquipmentTotalArgRowChanging

        End Sub

        Private Sub PartidaEquipmentTotalArgDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Valor_TOTALColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class PartidaEquipmentArgDataTable
        Private Sub PartidaEquipmentArgDataTable_PartidaEquipmentArgRowChanging(sender As Object, e As PartidaEquipmentArgRowChangeEvent) Handles Me.PartidaEquipmentArgRowChanging

        End Sub

        'Private Sub PartidaEquipmentArgDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
        '    If (e.Column.ColumnName = Me.DataColumnColumn.ColumnName) Then
        '        'Add user code here
        '    End If

        'End Sub

    End Class
End Class
