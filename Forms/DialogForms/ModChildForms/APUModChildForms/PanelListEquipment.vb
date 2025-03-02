Imports System.Windows
Imports Newtonsoft.Json.Linq

Public Class PanelListEquipment

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPTxtEquipmentFilter As UPTextBox
    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPCBoxDataSourceInpute As UPComboBox
    Private WithEvents _UPCBoxEquipmentTypeList As UPComboBox
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

        Me.tlpListEquipment.Dock = DockStyle.Fill
        Me.tlpListEquipment.Padding = New Padding(0)
        Me.tlpListEquipment.Margin = New Padding(0)

        _dicValuesFilter = dicValuesFilter

        _UPlbl0 = New UPLabel("L i s t a d o  d e  E q u i p o s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'filtro origen de datos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInpute = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", DSourceIsRequerido)
        _UPCBoxDataSourceInpute.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInpute.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInpute.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInpute.Dock = DockStyle.Fill
        _UPCBoxDataSourceInpute.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'filtro tipo de equipo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialMode As New List(Of String)
        _ColumnMaterialMode.Add("nameEquipmentType")

        _UPCBoxEquipmentTypeList = New UPComboBox("equipmentType", _ColumnMaterialMode, "Tipo de Equipo", True)
        _UPCBoxEquipmentTypeList.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxEquipmentTypeList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxEquipmentTypeList.BackColor = Color.WhiteSmoke
        _UPCBoxEquipmentTypeList.Dock = DockStyle.Fill
        _UPCBoxEquipmentTypeList.SetSelectedItem(1)


        _UPTxtEquipmentFilter = New UPTextBox
        _UPTxtEquipmentFilter.Margin = New Padding(8, 4, 4, 4)

        Dim _dicValuesFilter2 As New JObject()

        If _dicValuesFilter Is Nothing Then
            _dicValuesFilter2 = New JObject()
        Else
            _dicValuesFilter2 = New JObject(_dicValuesFilter)
        End If

        If appDataSourceInputId > 0 Then
            _dicValuesFilter2("appDataSourceInput_id") = appDataSourceInputId
        End If

        If equipmentTypeId > 0 Then
            _dicValuesFilter2("equipmentType_id") = equipmentTypeId
        End If

        _UPDGViewList = New UPDGViewList("equipment", "refEquipment", "nameEquipment", "Código", "Nombre del Equipo",
                                         _dicValuesFilter2)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 4, 4, 0)

        Me.tlpListEquipment.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListEquipment.Controls.Add(_UPCBoxDataSourceInpute, 0, 1)
        Me.tlpListEquipment.Controls.Add(_UPCBoxEquipmentTypeList, 0, 2)
        Me.tlpEquipmentLook.Controls.Add(_UPTxtEquipmentFilter, 0, 0)
        Me.tlpListEquipment.Controls.Add(_UPDGViewList, 0, 4)

        _IsInitialize = False

    End Sub
    Public ReadOnly Property equipmentTypeId As Int32
        Get
            Return _UPCBoxEquipmentTypeList.GetSelectedItemId()
        End Get
    End Property

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

    Public ReadOnly Property equipmentName As String
        Get
            Return _UPDGViewList.selectedSupplyName
        End Get
    End Property

    Public Sub SetSelectedItemappDataSource(ByVal Id As Int32)
        _UPCBoxDataSourceInpute.SetSelectedItem(Id)
    End Sub

    Public Sub SetFiltersEquipment(equipmentTypeId As Int32, ByVal appDataSourceInputId As Int32)

        If equipmentTypeId > 0 Then
            _UPCBoxEquipmentTypeList.SetSelectedItem(equipmentTypeId)
        End If

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInpute.SetSelectedItem(appDataSourceInputId)
        End If

    End Sub

    Public Function GetListValues(Of T)(ByVal ColumnName As String) As List(Of T)
        Return _UPDGViewList.GetListValues(Of T)(ColumnName)
    End Function

    Private Sub ReloadEquipment()

        Dim _dicValuesFilter2 As New JObject()

        If _dicValuesFilter Is Nothing Then
            _dicValuesFilter2 = New JObject()
        Else
            _dicValuesFilter2 = New JObject(_dicValuesFilter)
        End If

        If appDataSourceInputId > 0 Then
            _dicValuesFilter2("appDataSourceInput_id") = appDataSourceInputId
        End If

        If equipmentTypeId > 0 Then
            _dicValuesFilter2("equipmentType_id") = equipmentTypeId
        End If

        _UPDGViewList.ReLoadData(_dicValuesFilter2, True)

    End Sub

    Private Sub _UPDGViewList_DoubleClick(sender As Object, e As EventArgs) Handles _UPDGViewList.DoubleClick
        RaiseEvent EvDoubleClick(sender, e)
    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply
        Dim _formEquipment As New FormEquipmentModal(selectedId)
        If _formEquipment.ShowDialog(Me) = DialogResult.OK Then
            ReloadEquipment()
        End If
    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply
        ' Dim _formEquipment As New FormEquipmentModal()

        If MessageBox.Show("Nuevo Equipo compuesto?", "Equipo", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = MessageBoxResult.Yes Then

            Dim _FormCompoundEquipment As New FormCompoundEquipment(equipmentTypeId:=equipmentTypeId,
                                                                 appDataSourceInputId:=appDataSourceInputId)

            If _FormCompoundEquipment.ShowDialog(Me) = DialogResult.OK Then

                ReloadEquipment()

                _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

            End If
        Else
            Dim _formequipment As New FormEquipmentModal(appDataSourceInputId:=appDataSourceInputId, equipmentTypeId:=equipmentTypeId)
            If _formequipment.ShowDialog(Me) = DialogResult.OK Then
                ReloadEquipment()
            End If
        End If

    End Sub

    Private Sub _UPCBoxEquipmentTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxEquipmentTypeList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadEquipment()
            _UPTxtEquipmentFilter.Text = ""
        End If
    End Sub

    Private Sub _UPCBoxDataSourceInpute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInpute.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadEquipment()
            _UPTxtEquipmentFilter.Text = ""
        End If
    End Sub

    Private Sub _UPTxtEquipmentFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtEquipmentFilter.TextChanged

        If _UPDGViewList.RowCount < 500 Then
            _UPDGViewList.FilterList(_UPTxtEquipmentFilter.Text)
        End If

    End Sub



End Class
