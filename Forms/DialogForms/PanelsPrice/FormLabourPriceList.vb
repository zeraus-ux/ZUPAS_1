Imports Newtonsoft.Json.Linq
Imports System.Windows.Media.Media3D
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.ComponentModel
Public Class FormLabourPriceList
    Private WithEvents _PanelListLabourPrice As PanelListLabourPrice = Nothing

    Public Sub New()

        InitializeComponent()

        _PanelListLabourPrice = New PanelListLabourPrice()
        Panel1.Controls.Add(_PanelListLabourPrice)


    End Sub
End Class