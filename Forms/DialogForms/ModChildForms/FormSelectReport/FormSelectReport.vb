Public Class FormSelectReport

    Private _PresupuestoType = EnumPresupuestoType.None

    Public ReadOnly Property PresupuestoType As EnumPresupuestoType
        Get
            Return _PresupuestoType
        End Get
    End Property

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        RadioButton1.Checked = True

    End Sub

    Private Sub FormSelectReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If RadioButton1.Checked Then
            _PresupuestoType = EnumPresupuestoType.None
        ElseIf RadioButton2.Checked Then
            _PresupuestoType = EnumPresupuestoType.IsByChapter
        ElseIf RadioButton3.Checked Then
            _PresupuestoType = EnumPresupuestoType.IsByStage
        Else
            _PresupuestoType = EnumPresupuestoType.None
        End If
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    DialogResult = DialogResult.Cancel

    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    DialogResult = DialogResult.OK
    'End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class