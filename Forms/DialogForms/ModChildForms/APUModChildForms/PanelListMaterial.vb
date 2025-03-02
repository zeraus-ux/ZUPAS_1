Imports System.Diagnostics.Eventing.Reader
Imports System.Windows
Imports Newtonsoft.Json.Linq

Public Class PanelListMaterial

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPCBoxMaterialTypeList As UPComboBox
    Private WithEvents _UPTxtFilterType As UPTextBox
    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPCBoxDataSourceInpute As UPComboBox
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

        Me.tlpListMaterial.Dock = DockStyle.Fill
        Me.tlpListMaterial.Padding = New Padding(0)
        Me.tlpListMaterial.Margin = New Padding(0)

        _dicValuesFilter = dicValuesFilter

        _UPlbl0 = New UPLabel("L i s t a d o  d e  M a t e r i a l e s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'filtro origen de datos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInpute = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", True)
        _UPCBoxDataSourceInpute.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInpute.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInpute.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInpute.Dock = DockStyle.Fill
        _UPCBoxDataSourceInpute.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'filtro tipo de material
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialMode As New List(Of String)
        _ColumnMaterialMode.Add("nameMaterialType")

        _UPCBoxMaterialTypeList = New UPComboBox("materialType", _ColumnMaterialMode, "Tipo de Material", DSourceIsRequerido)
        _UPCBoxMaterialTypeList.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxMaterialTypeList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxMaterialTypeList.BackColor = Color.WhiteSmoke
        _UPCBoxMaterialTypeList.Dock = DockStyle.Fill
        _UPCBoxMaterialTypeList.SetSelectedItem(1)

        _UPTxtFilterType = New UPTextBox
        _UPTxtFilterType.Margin = New Padding(8, 4, 4, 4)

        '--------------------------------------------

        Dim _dicValuesFilter1 As JObject

        If _dicValuesFilter Is Nothing Then
            _dicValuesFilter1 = New JObject()
        Else
            _dicValuesFilter1 = New JObject(_dicValuesFilter)
        End If

        If materialTypeId > 0 Then
            _dicValuesFilter1("materialType_id") = materialTypeId
        End If

        If appDataSourceInputId > 0 Then
            _dicValuesFilter1("appDataSourceInput_id") = appDataSourceInputId
        End If

        _UPDGViewList = New UPDGViewList("material", "refMaterial", "nameMaterial", "Codigo", "Nombre del Material",
                                         _dicValuesFilter1)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 4, 4, 0)

        Me.tlpListMaterial.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListMaterial.Controls.Add(_UPCBoxDataSourceInpute, 0, 1)
        Me.tlpListMaterial.Controls.Add(_UPCBoxMaterialTypeList, 0, 2)
        Me.tlpMaterialLook.Controls.Add(_UPTxtFilterType, 0, 0)
        Me.tlpListMaterial.Controls.Add(_UPDGViewList, 0, 4)

        _IsInitialize = False

        _UPDGViewList.SetSelectedItem(0)

    End Sub

    Public ReadOnly Property materialTypeId As Int32
        Get
            Return _UPCBoxMaterialTypeList.GetSelectedItemId()
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

    Public ReadOnly Property MaterialName As String
        Get
            Return _UPDGViewList.selectedSupplyName
        End Get
    End Property

    Public Sub SetSelectedItemappDataSource(ByVal Id As Int32)
        _UPCBoxDataSourceInpute.SetSelectedItem(Id)
    End Sub

    Public Sub SetFilters(materialTypeId As Int32, ByVal appDataSourceInputId As Int32)

        If materialTypeId > 0 Then
            _UPCBoxMaterialTypeList.SetSelectedItem(materialTypeId)
        End If

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInpute.SetSelectedItem(appDataSourceInputId)
        End If

    End Sub

    Public Function GetListValues(Of T)(ByVal ColumnName As String) As List(Of T)

        Return _UPDGViewList.GetListValues(Of T)(ColumnName)
    End Function

    Private Sub ReloadMateriales()

        Dim _dicValuesFilter1 As JObject

        If _dicValuesFilter Is Nothing Then
            _dicValuesFilter1 = New JObject()
        Else
            _dicValuesFilter1 = New JObject(_dicValuesFilter)
        End If

        If materialTypeId > 0 Then
            _dicValuesFilter1("materialType_id") = materialTypeId
        End If

        If appDataSourceInputId > 0 Then
            _dicValuesFilter1("appDataSourceInput_id") = appDataSourceInputId
        End If

        _UPDGViewList.ReLoadData(_dicValuesFilter1, True)

    End Sub

    Private Sub _UPDGViewList_DoubleClick(sender As Object, e As EventArgs) Handles _UPDGViewList.DoubleClick
        RaiseEvent EvDoubleClick(sender, e)
    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply
        Dim _formMaterial As New FormMateriaModal(selectedId)
        If _formMaterial.ShowDialog(Me) = DialogResult.OK Then
            ReloadMateriales()
        End If

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        Dim Result As MessageBoxResult = MessageBox.Show("Nuevo Materal compuesto?", "Material", MessageBoxButtons.YesNoCancel,
                           MessageBoxIcon.Question)

        If Result = MessageBoxResult.Yes Then
            Dim _FormCompoundMaterial As New FormCompoundMaterial(materialTypeId:=materialTypeId,
                                                                 appDataSourceInputId:=appDataSourceInputId)

            If _FormCompoundMaterial.ShowDialog(Me) = DialogResult.OK Then

                ReloadMateriales()

                _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

            End If

        ElseIf Result = MessageBoxResult.No Then

            Dim _formMaterial As New FormMateriaModal(appDataSourceInputId:=appDataSourceInputId, materialTypeId:=materialTypeId)
            If _formMaterial.ShowDialog(Me) = DialogResult.OK Then
                ReloadMateriales()
                '_UPTxtFilterType.Text = ""
            End If

        End If



        'Dim _formMaterial As New FormMateriaModal(appDataSourceInputId:=appDataSourceInputId, materialTypeId:=materialTypeId)
        'If _formMaterial.ShowDialog(Me) = DialogResult.OK Then
        '    ReloadMateriales()
        '    _UPTxtFilterType.Text = ""
        'End If

    End Sub

    Private Sub _UPCBoxMaterialTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxMaterialTypeList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadMateriales()
            _UPTxtFilterType.Text = ""
        End If

    End Sub

    Private Sub _UPCBoxDataSourceInpute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInpute.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadMateriales()
            _UPTxtFilterType.Text = ""

        End If
    End Sub

    Private Sub _UPTxtFilterType_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtFilterType.TextChanged
        'If String.IsNullOrEmpty(_UPTxtFilterType.Text) Then
        '    _UPDGViewList.FilterList(_UPTxtFilterType.Text)
        'End If
        If _UPDGViewList.RowCount < 500 Then
            _UPDGViewList.FilterList(_UPTxtFilterType.Text)
        End If

    End Sub

    Private Sub btnMaterialFilter_Click(sender As Object, e As EventArgs) Handles btnMaterialFilter.Click
        _UPDGViewList.FilterList(_UPTxtFilterType.Text)
    End Sub

    Private Sub PanelListMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim toolTipPnaMat As New ToolTip()
        toolTipPnaMat.AutoPopDelay = 5000
        toolTipPnaMat.InitialDelay = 1000
        toolTipPnaMat.ReshowDelay = 500
        toolTipPnaMat.ShowAlways = True

        toolTipPnaMat.SetToolTip(Me._UPTxtFilterType, "Buscar Material")
        toolTipPnaMat.SetToolTip(Me._UPCBoxMaterialTypeList, "Tipo de Material")
        toolTipPnaMat.SetToolTip(Me._UPCBoxDataSourceInpute, "Fuente del Insumo")

    End Sub



    'Private Sub _UPTxtFilterType_KeyDown(sender As Object, e As KeyEventArgs) Handles _UPTxtFilterType.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        _UPDGViewList.FilterList(_UPTxtFilterType.Text)
    '    End If


    'End Sub

End Class
