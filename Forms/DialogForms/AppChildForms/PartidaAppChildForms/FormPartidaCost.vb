Public Class FormPartidaCost

    'Private WithEvents _UPDGViewPartidaCost As UPDataGridView
    Private WithEvents _UPDGViewPartidaCostValue As UPDataGridView


    Public Sub New(ByRef vUPDGViewpartidaCostValue As UPDataGridView,
                   Optional IsReadOnly As Boolean = False)

        InitializeComponent()

        '_UPDGViewPartidaCost = vUPDGViewpartidaCost
        _UPDGViewPartidaCostValue = vUPDGViewpartidaCostValue
        _UPDGViewPartidaCostValue.ReadOnly = IsReadOnly

        _UPDGViewPartidaCostValue.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Regular), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPDGViewPartidaCostValue.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter

        _UPDGViewPartidaCostValue.Columns(3).DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft '02/25

        _UPDGViewPartidaCostValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular,
                                              System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPDGViewPartidaCostValue.RowHeadersVisible = False

        _UPDGViewPartidaCostValue.AllowUserToAddRows = False
        _UPDGViewPartidaCostValue.AllowUserToDeleteRows = False
        _UPDGViewPartidaCostValue.AllowUserToOrderColumns = False
        _UPDGViewPartidaCostValue.AllowUserToResizeColumns = False
        _UPDGViewPartidaCostValue.Columns.Item("id").Visible = False

        'vUPDGViewpartidaCost.AllowUserToAddRows = False
        'vUPDGViewpartidaCost.AllowUserToDeleteRows = False
        'vUPDGViewpartidaCost.AllowUserToOrderColumns = False
        'vUPDGViewpartidaCost.AllowUserToResizeColumns = False

        Me.tlpCostos.Controls.Add(_UPDGViewPartidaCostValue)
        'Me.TabPage2.Controls.Add(_UPDGViewPartidaCost)

    End Sub

    Private Sub FormpartidaCostDirect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Me.Controls.Remove(_UPDGViewPartidaCostValue)
    End Sub



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class