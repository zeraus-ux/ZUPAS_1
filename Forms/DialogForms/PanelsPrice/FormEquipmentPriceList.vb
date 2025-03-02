Imports Newtonsoft.Json.Linq
Imports System.Windows.Media.Media3D
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.ComponentModel
Public Class FormequipmentCostPyOUserList
    Private WithEvents _PanelListequipmentCostPyOUser As PanelListequipmentCostPyOUser = Nothing

    Public Sub New()

        InitializeComponent()

        _PanelListequipmentCostPyOUser = New PanelListequipmentCostPyOUser()
        Panel1.Controls.Add(_PanelListequipmentCostPyOUser)

    End Sub
End Class