Imports Newtonsoft.Json.Linq
Imports System.Windows.Media.Media3D
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.ComponentModel
Public Class FormMaterialPriceList
    Private WithEvents _PanelListMaterialPrice As PanelListMaterialPrice = Nothing
    Private WithEvents _PanelListMaterial As PanelListMaterial = Nothing

    Public Sub New()

        InitializeComponent()

        '_PanelListMaterial = New PanelListMaterial()
        'Panel1.Controls.Add(_PanelListMaterial)

        _PanelListMaterialPrice = New PanelListMaterialPrice()
        Panel1.Controls.Add(_PanelListMaterialPrice)

    End Sub
End Class