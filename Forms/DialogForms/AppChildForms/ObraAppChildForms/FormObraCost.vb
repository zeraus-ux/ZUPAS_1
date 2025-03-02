Public Class FormObraCost

    'Private WithEvents _UPDGViewObraCost As UPDataGridView
    Private WithEvents _UPDGViewObraCostValue As UPDataGridView

    Public Sub New(ByRef vUPDGViewobraCostValue As UPDataGridView)

        InitializeComponent()

        '_UPDGViewObraCostValue = vUPDGViewobraCost
        _UPDGViewObraCostValue = vUPDGViewobraCostValue

        _UPDGViewObraCostValue.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Regular,
                                              System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPDGViewObraCostValue.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _UPDGViewObraCostValue.Columns(3).DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter

        _UPDGViewObraCostValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular,
                                              System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPDGViewObraCostValue.RowHeadersVisible = False

        _UPDGViewObraCostValue.AllowUserToAddRows = False
        _UPDGViewObraCostValue.AllowUserToDeleteRows = False
        _UPDGViewObraCostValue.AllowUserToOrderColumns = False
        _UPDGViewObraCostValue.AllowUserToResizeColumns = False
        _UPDGViewObraCostValue.Columns.Item("id").Visible = False

        'vUPDGViewobraCost.AllowUserToAddRows = False
        'vUPDGViewobraCost.AllowUserToDeleteRows = False
        'vUPDGViewobraCost.AllowUserToOrderColumns = False
        'vUPDGViewobraCost.AllowUserToResizeColumns = False

        Me.tlpCostos.Controls.Add(_UPDGViewObraCostValue, 0, 0)
        'Me.TabPage2.Controls.Add(_UPDGViewObraCost)

    End Sub

    Private Sub FormObraCostDirect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Me.Controls.Remove(_UPDGViewObraCost)

    End Sub



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class