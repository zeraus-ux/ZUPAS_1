Imports Newtonsoft.Json.Linq
Public Class PanelListLabourPrice
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPTxtLabourFilter As UPTextBox
    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPCBoxDataSourceInpute As UPComboBox

    Public Event EvDoubleClick(sender As Object, e As EventArgs)

    Private _IsInitialize As Boolean = False

    Public Sub New()

        InitializeComponent()

        _IsInitialize = True

        MyBase.Dock = DockStyle.Fill
        MyBase.Padding = New Padding(0)
        MyBase.Margin = New Padding(0)

        Me.tlpListLabour.Dock = DockStyle.Fill
        Me.tlpListLabour.Padding = New Padding(0)
        Me.tlpListLabour.Margin = New Padding(0)

        _UPlbl0 = New UPLabel("L i s t a d o  d e  M a n o  d e  O b r a  c o n  P r e c i o s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)

        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInpute = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "XXXXXXXX", False)
        _UPCBoxDataSourceInpute.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInpute.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInpute.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInpute.Dock = DockStyle.Fill
        _UPCBoxDataSourceInpute.SetSelectedItem(1)

        _UPTxtLabourFilter = New UPTextBox
        _UPTxtLabourFilter.Margin = New Padding(8, 4, 4, 4)

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter = Nothing

        If appDataSourceInputId > 0 Then
            If _dicValuesFilter Is Nothing Then
                _dicValuesFilter = New JObject()
            End If

            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        Else
            _dicValuesFilter = Nothing
        End If

        _UPDGViewList = New UPDGViewList("labour", "reflabour", "namelabour", "Código", "Nombre de la Mano de Obra", _dicValuesFilter)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 4, 4, 0)

        Me.tlpListLabour.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListLabour.Controls.Add(_UPCBoxDataSourceInpute, 0, 1)
        Me.tlpListLabour.Controls.Add(_UPDGViewList, 0, 3)
        Me.tlpEquipmentLook.Controls.Add(_UPTxtLabourFilter, 0, 0)


        _IsInitialize = False

    End Sub

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _UPCBoxDataSourceInpute.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property selectedId As Int32
        Get
            Return _UPDGViewList.selectedId
        End Get
    End Property

    Public ReadOnly Property labourName As String
        Get
            Return _UPDGViewList.selectedSupplyName
        End Get
    End Property


    Public Function GetListValues(Of T)(ByVal ColumnName As String) As List(Of T)

        Return _UPDGViewList.GetListValues(Of T)(ColumnName)
    End Function

    Private Sub ReloadLabour()

        Dim _dicValuesFilter As JObject = Nothing

        If appDataSourceInputId > 0 Then
            If _dicValuesFilter Is Nothing Then
                _dicValuesFilter = New JObject()
            End If

            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        Else
            _dicValuesFilter = Nothing
        End If

        _UPDGViewList.ReLoadData(_dicValuesFilter, True)

    End Sub

    Private Sub _UPCBoxDataSourceInpute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInpute.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadLabour()
        End If
    End Sub

    Private Sub _UPDGViewList_DoubleClick(sender As Object, e As EventArgs) Handles _UPDGViewList.DoubleClick
        RaiseEvent EvDoubleClick(sender, e)
    End Sub

    Private Sub _UPTxtLabourFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtLabourFilter.TextChanged
        _UPDGViewList.FilterList(_UPTxtLabourFilter.Text)
    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply
        Dim _formLabour As New FormLabourModal()
        If _formLabour.ShowDialog(Me) = DialogResult.OK Then
            ReloadLabour()
        End If
    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply
        Dim _formLabour As New FormLabourModal(selectedId)
        If _formLabour.ShowDialog(Me) = DialogResult.OK Then
            ReloadLabour()
        End If
    End Sub



End Class
