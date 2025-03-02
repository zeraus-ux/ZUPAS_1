Imports System.Windows
Imports Newtonsoft.Json.Linq

Public Class PanelListLabour

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPTxtLabourFilter As UPTextBox
    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Public Event EvDoubleClick(sender As Object, e As EventArgs)

    Private _IsInitialize As Boolean = False
    Private _dicValuesFilter As JObject = Nothing

    Public Sub New(Optional ByVal dicValuesFilter As JObject = Nothing,
                   Optional ByVal DSourceIsRequerido As Boolean = True)

        InitializeComponent()

        _IsInitialize = True

        MyBase.Dock = DockStyle.Fill
        MyBase.Padding = New Padding(0)
        MyBase.Margin = New Padding(0)

        Me.tlpListLabour.Dock = DockStyle.Fill
        Me.tlpListLabour.Padding = New Padding(0)
        Me.tlpListLabour.Margin = New Padding(0)

        _dicValuesFilter = dicValuesFilter

        _UPlbl0 = New UPLabel("L i s t a d o  d e  M a n o  d e  O b r a")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)

        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", DSourceIsRequerido)
        _UPCBoxDataSourceInput.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInput.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInput.Dock = DockStyle.Fill
        _UPCBoxDataSourceInput.SetSelectedItem(1)

        _UPTxtLabourFilter = New UPTextBox
        _UPTxtLabourFilter.Margin = New Padding(8, 4, 4, 4)

        Dim _dicValuesFilter3 As New JObject()

        If _dicValuesFilter Is Nothing Then
            _dicValuesFilter3 = New JObject()
        Else
            _dicValuesFilter3 = New JObject(_dicValuesFilter)
        End If

        If appDataSourceInputId > 0 Then
            _dicValuesFilter3("appDataSourceInput_id") = appDataSourceInputId
        End If

        _UPDGViewList = New UPDGViewList("labour", "reflabour", "namelabour", "Código", "Nombre de la Mano de Obra", _dicValuesFilter3)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 4, 4, 0)

        Me.tlpListLabour.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListLabour.Controls.Add(_UPCBoxDataSourceInput, 0, 1)
        Me.tlpListLabour.Controls.Add(_UPDGViewList, 0, 3)
        Me.tlpEquipmentLook.Controls.Add(_UPTxtLabourFilter, 0, 0)


        _IsInitialize = False

    End Sub

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _UPCBoxDataSourceInput.GetSelectedItemId()
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

    'Public Sub SetSelectedItemappDataSource(ByVal Id As Int32)
    '    _UPCBoxDataSourceInput.SetSelectedItem(Id)
    'End Sub

    Public Sub SetFilterSourceInput(ByVal appDataSourceInputId As Int32)

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInput.SetSelectedItem(appDataSourceInputId)
        End If

    End Sub

    Public Function GetListValues(Of T)(ByVal ColumnName As String) As List(Of T)

        Return _UPDGViewList.GetListValues(Of T)(ColumnName)

    End Function

    Private Sub ReloadLabour()

        Dim _dicValuesFilter3 As New JObject()

        If _dicValuesFilter Is Nothing Then
            _dicValuesFilter3 = New JObject()
        Else
            _dicValuesFilter3 = New JObject(_dicValuesFilter)
        End If

        If appDataSourceInputId > 0 Then
            _dicValuesFilter3("appDataSourceInput_id") = appDataSourceInputId
        End If


        _UPDGViewList.ReLoadData(_dicValuesFilter3, True)

    End Sub

    Private Sub _UPCBoxDataSourceInpute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInput.SelectedIndexChanged
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
        If MessageBox.Show("Nueva Mano de Obra compuesta?", "Mano de Obra", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = MessageBoxResult.Yes Then
            Dim _FormCompoundLabour As New FormCompoundLabour(appDataSourceInputId:=appDataSourceInputId)

            If _FormCompoundLabour.ShowDialog(Me) = DialogResult.OK Then

                ReloadLabour()

                _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

            End If

        Else
            Dim _formLabour As New FormLabourModal(appDataSourceInputId:=appDataSourceInputId)
            If _formLabour.ShowDialog(Me) = DialogResult.OK Then
                ReloadLabour()
                _UPTxtLabourFilter.Text = ""
            End If

        End If





    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply
        Dim _formLabour As New FormLabourModal(selectedId)
        If _formLabour.ShowDialog(Me) = DialogResult.OK Then
            ReloadLabour()
            _UPTxtLabourFilter.Text = ""
        End If
    End Sub


End Class
