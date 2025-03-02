Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid
Public Class FormSelectProject

    Private WithEvents _UPCBoxProjectSeleted As UPComboBox

    Private _SelectedItemId As Int32 = -1
    Private _SelectedItemId1 As Int32 = -1

    Public Sub New(ByVal UPCBoxProjectSeleted As UPComboBox)

        InitializeComponent()

        _UPCBoxProjectSeleted = UPCBoxProjectSeleted
        _UPCBoxProjectSeleted.Location = New System.Drawing.Point(23, 25)
        _UPCBoxProjectSeleted.Size = New System.Drawing.Size(327, 21)

        Me.Panel1.Controls.Add(_UPCBoxProjectSeleted)


        _SelectedItemId = _UPCBoxProjectSeleted.GetSelectedItemId()


    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        DialogResult = DialogResult.OK
        'Close()
    End Sub

    Private Sub FormSelectProject_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            _UPCBoxProjectSeleted.SetSelectedItem(_SelectedItemId)
            DialogResult = DialogResult.Cancel
        Else
            If Not _SelectedItemId1 = _SelectedItemId AndAlso _SelectedItemId1 > 0 Then
                DialogResult = DialogResult.OK
            Else
                DialogResult = DialogResult.Cancel
            End If
        End If
    End Sub

    Private Sub _UPCBoxProjectSeleted_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxProjectSeleted.SelectedIndexChanged
        _SelectedItemId1 = _UPCBoxProjectSeleted.GetSelectedItemId()
    End Sub

End Class