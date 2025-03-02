Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormMaterialPrice

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtNameMaterial As UPTextBox '28/11

    Private WithEvents _UPCBoxMaterialTypeList As UPComboBox
    Private WithEvents _UPCBoxDataSourceInpute As UPComboBox
    Private WithEvents _UPTxtMaterialPriceFilter As UPTextBox

    Private WithEvents _UPTxtBoxNumerico1 As UPTextBoxNumerico

    Private WithEvents _UPCBoxUnit As UPComboBox
    Private WithEvents _UPCBoxUnit2 As UPComboBox
    Private WithEvents _UPCBoxCodigoNombre As UPComboBox

    Private WithEvents _UPCTBoxCodigoNombre As UPTextBox

    Private WithEvents _UPDateTimePicker As UPDateTimePicker

    Private _IsEdit As Boolean = False
    Private _IsInitialize = False
    Public _IsGuardando As Boolean = False
    Private _materialPrice_Id As Int32 = -1

    Public Sub New()

        InitializeComponent()

        _IsInitialize = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' _IsCargandoConstructor = True

        Dim _ColumnMaterialMode As New List(Of String)
        _ColumnMaterialMode.Add("nameMaterialType")

        _UPCBoxMaterialTypeList = New UPComboBox("materialType", _ColumnMaterialMode, "Tipo de Material", True)
        _UPCBoxMaterialTypeList.Margin = New Padding(8, 0, 4, 4)
        _UPCBoxMaterialTypeList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxMaterialTypeList.BackColor = Color.WhiteSmoke
        _UPCBoxMaterialTypeList.Dock = DockStyle.Fill
        _UPCBoxMaterialTypeList.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters (SourceInput)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInpute = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", False)
        _UPCBoxDataSourceInpute.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInpute.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInpute.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInpute.Dock = DockStyle.Fill
        _UPCBoxDataSourceInpute.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtMaterialPriceFilter = New UPTextBox
        _UPTxtMaterialPriceFilter.Margin = New System.Windows.Forms.Padding(8, 0, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Materiales
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("isAtomic") = True

        If materialTypeId > 0 Then
            _dicValuesFilter("materialType_id") = materialTypeId
        End If

        If appDataSourceInputId > 0 Then
            'If _dicValuesFilter Is Nothing Then
            '    _dicValuesFilter = New JObject()
            'End If

            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
            'Else
            '    _dicValuesFilter = Nothing
        End If

        _UPDGViewList = New UPDGViewList("material", "refMaterial", "nameMaterial", "Codigo", "Nombre del Material", _dicValuesFilter)
        '_UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        _UPDGViewList.MenuItemEditSupplyVisible = False  'xxxx
        _UPDGViewList.CallDeletedActive = False 'xxxx

        _UPDGViewList.Margin = New System.Windows.Forms.Padding(10, 4, 5, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Nombre")
        _UPlbl2 = New UPLabel("Unidad")
        _UPlbl3 = New UPLabel("Fecha")
        _UPlbl4 = New UPLabel($"Precio ({ProjectSymbolMoneyType})")
        _UPlbl6 = New UPLabel("Unidad para el precio")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  M a t e r i a l e s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl7 = New UPLabel("E d i c i ó n  P r e c i o  d e  M a t e r i a l e s")
        _UPlbl7.SetFortmatEtiquetaInsumo()
        _UPlbl7.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Código - Nombre
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames4 As New List(Of String)
        _ColumnNames4.Add("refMaterial")
        _ColumnNames4.Add("nameMaterial")

        _UPCBoxCodigoNombre = New UPComboBox("material", _ColumnNames4, "Material", True)
        '_UPCBoxCodigoNombre.Height = 60
        '_UPCBoxCodigoNombre.Dock = DockStyle.None


        _UPCTBoxCodigoNombre = New UPTextBox()


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Unit
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames3 As New List(Of String)
        _ColumnNames3.Add("nameUnit")

        Dim _dicValuesFilterUnit As New JObject()
        _dicValuesFilterUnit("unitMaterial") = True

        _UPCBoxUnit = New UPComboBox("unit", _ColumnNames3, "Unidad", True, _dicValuesFilterUnit)
        _UPCBoxUnit.Margin = New System.Windows.Forms.Padding(0, 0, 4, 8)
        _UPCBoxUnit.BackColor = Color.WhiteSmoke


        _UPlbl6.Padding = New Padding(6, 0, 4, 0)

        _UPCBoxUnit2 = New UPComboBox("unit", _ColumnNames3, "Unidad", True, _dicValuesFilterUnit)
        _UPCBoxUnit2.BackColor = Color.WhiteSmoke

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDateTimePicker Fecha
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDateTimePicker = New UPDateTimePicker()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'TexBox
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtNameMaterial = New UPTextBox
        _UPTxtNameMaterial.WordWrap = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Númerico
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtBoxNumerico1 = New UPTextBoxNumerico(0, Double.NaN)
        '_UPTxtBoxNumerico1.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        '_UPTxtBoxNumerico1.Padding = New Padding(8, 8, 4, 0)
        _UPTxtBoxNumerico1.Padding = New Padding(20, 0, 0, 0)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListMaterial.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListMaterial.Controls.Add(_UPCBoxDataSourceInpute, 0, 1)
        Me.tlpListMaterial.Controls.Add(_UPCBoxMaterialTypeList, 0, 2)
        Me.tlpListMaterial.Controls.Add(_UPDGViewList, 0, 5)

        Me.tlpMaterialLook.Controls.Add(_UPTxtMaterialPriceFilter, 0, 0)

        Me.tlpListUnit.Controls.Add(_UPlbl6, 0, 0)
        Me.tlpListUnit.Controls.Add(_UPCBoxUnit, 1, 0)

        Me.tlpEditionPriceMaterial.Controls.Add(_UPlbl7, 0, 0)

        Me.tlpEditionPriceMaterial2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEditionPriceMaterial2.Controls.Add(_UPlbl2, 0, 2)
        Me.tlpEditionPriceMaterial2.Controls.Add(_UPlbl3, 0, 3)
        Me.tlpEditionPriceMaterial2.Controls.Add(_UPlbl4, 0, 1)

        'Me.tlpEditionPriceMaterial2.Controls.Add(_UPCBoxCodigoNombre, 1, 0)
        Me.tlpEditionPriceMaterial2.Controls.Add(_UPCTBoxCodigoNombre, 1, 0)
        Me.tlpEditionPriceMaterial2.Controls.Add(_UPCBoxUnit2, 1, 2)
        Me.tlpEditionPriceMaterial2.Controls.Add(_UPDateTimePicker, 1, 3)
        Me.tlpEditionPriceMaterial2.Controls.Add(_UPTxtBoxNumerico1, 1, 1)

        btnGuardar2.Enabled = False
        _UPCBoxCodigoNombre.Enabled = False
        _UPCTBoxCodigoNombre.Enabled = False

        EnableControls(False)
        _IsInitialize = False
        _UPDGViewList.SetSelectedItem(0)
        _UPCBoxUnit.SelectedIndex = 1
        _UPCBoxUnit2.SelectedIndex = 1


        AddHandler CommonFuntion.EvUnitChanged, AddressOf OnEvUnitChanged ' marcha
        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnProjectSeletedChnge


    End Sub

    Public ReadOnly Property selectedItem As DataGridViewRow
        Get
            Return _UPDGViewList.selectedItem
        End Get
    End Property

    Public ReadOnly Property HasSelectedItem As Boolean
        Get
            Return selectedItem IsNot Nothing
        End Get
    End Property

    Public ReadOnly Property selectedId As Int32
        Get
            Return _UPDGViewList.selectedId
        End Get
    End Property

    Public ReadOnly Property selectedCode As String
        Get
            Return _UPDGViewList.selectedCode
        End Get
    End Property

    Public ReadOnly Property selectedsupplyName As String
        Get
            Return _UPDGViewList.selectedSupplyName
        End Get
    End Property

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

    Public Function Validate1() As Boolean
        'pendiente
        Return True
    End Function


    Private Sub EnableControls(ByVal Enabled As Boolean)

        'If Not _IsCargandoConstructor Then

        'End If

        '_UPCBoxCodigoNombre.Enabled = Enabled
        _UPCBoxUnit2.Enabled = Enabled
        _UPDateTimePicker.Enabled = Enabled
        _UPTxtBoxNumerico1.Enabled = Enabled

    End Sub

    Private Sub LoadPriceMaterialSelect()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames2 As New List(Of String)

            Dim _dicValuesFilter2 As New JObject()
            _dicValuesFilter2("material_id") = selectedId
            _dicValuesFilter2("unit_id") = _UPCBoxUnit.GetSelectedItemId()
            _dicValuesFilter2("project_id") = ProjectSelectedId

            Dim _SelectMax As String = "dateUser"

            Dim _datatable3 As DataTable = GetDataTable("materialPrice", ColumnNames:=_ColumnNames2,
                                                       dicValuesFilter:=_dicValuesFilter2, SelectMax:=_SelectMax)

            If _datatable3.Rows.Count > 0 Then

                _UPCBoxCodigoNombre.SetSelectedItem(_datatable3.Rows(0)("material_id"))
                _UPCBoxUnit2.SetSelectedItem(_datatable3.Rows(0)("unit_id"))
                _UPDateTimePicker.Value = _datatable3.Rows(0)("dateUser")
                _UPTxtBoxNumerico1.Value = _datatable3.Rows(0)("price")
                _materialPrice_Id = _datatable3.Rows(0)("Id")   'XXXXX

                _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text

            Else
                _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
                _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
                _UPDateTimePicker.Value = Now()
                _UPTxtBoxNumerico1.Value = Nothing
                _materialPrice_Id = -1  'XXXXX

                _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text

            End If

        End If

    End Sub

    Private Sub ReloadMateriales()

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter = New JObject()
        _dicValuesFilter("isAtomic") = True

        If materialTypeId > 0 Then
            _dicValuesFilter("materialType_id") = materialTypeId
        End If

        If appDataSourceInputId > 0 Then
            'If _dicValuesFilter Is Nothing Then
            '    _dicValuesFilter = New JObject()
            'End If

            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
            'Else
            '    _dicValuesFilter = Nothing
        End If

        'Dim _dicValuesFilter As JObject
        'If materialTypeId > 0 Then
        '    _dicValuesFilter = New JObject()
        '    _dicValuesFilter("materialType_id") = materialTypeId
        'Else
        '    _dicValuesFilter = Nothing
        'End If

        'If appDataSourceInputId > 0 Then
        '    If _dicValuesFilter Is Nothing Then
        '        _dicValuesFilter = New JObject()
        '    End If

        '    _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        'Else
        '    _dicValuesFilter = Nothing
        'End If

        _UPDGViewList.ReLoadData(_dicValuesFilter, True)


    End Sub

    Private Sub OnEvUnitChanged(sender As Object, e As EventArgs)
        _UPCBoxUnit.ReLoad()
        _UPCBoxUnit2.ReLoad()

    End Sub

    Private Sub OnProjectSeletedChnge(sender As Object, e As EventArgs)
        LoadPriceMaterialSelect()

        _UPlbl4.Text = $"Precio ({ProjectSymbolMoneyType})"
    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged
        LoadPriceMaterialSelect()
        EnableControls(False)
        If Not _IsGuardando Then
            btnGuardar2.Enabled = False
        End If

        _IsEdit = False
    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply
        '_UPDGViewList.LoadList()
        btnGuardar2.Enabled = True
        EnableControls(True)
        _IsEdit = True

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        If HasSelectedItem Then
            _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing

            _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text

        Else
            _UPCBoxCodigoNombre.SetSelectedItem(1)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing

            _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text
        End If


        btnGuardar2.Enabled = True
        EnableControls(True)

        Me._UPTxtBoxNumerico1.Focus()
        Me._UPTxtBoxNumerico1.TabIndex = 1
        Me._UPCBoxUnit2.TabIndex = 2
        Me.btnGuardar2.TabIndex = 3
        Me.btnMaterialType.TabIndex = 4
        Me.btnDataSource.TabIndex = 5
        Me.btnMaterialPriceList.TabIndex = 6
        Me.btnReportMaterialPriceList.TabIndex = 7
        ' Me._UPDateTimePicker.TabIndex = 8


    End Sub

    Private Sub btnGuardar2_Click(sender As Object, e As EventArgs) Handles btnGuardar2.Click
        If Validate1() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()

            _dicValues("material_id") = _UPCBoxCodigoNombre.GetSelectedItemId()
            _dicValues("unit_id") = _UPCBoxUnit2.GetSelectedItemId()
            _dicValues("dateUser") = CType(_UPDateTimePicker.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("price") = CType(_UPTxtBoxNumerico1.Value, Double)
            _dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("materialPrice", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar2.Enabled = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("materialPrice", _DataServices) > 0 Then

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Precio guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar2.Enabled = False
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

    End Sub

    Private Sub _UPCBoxUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxUnit.SelectedIndexChanged
        LoadPriceMaterialSelect()
    End Sub

    Private Sub _UPDGViewList_EvDeleteSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvDeleteSupply

        If selectedId > 0 AndAlso _materialPrice_Id > 0 Then
            GetDelete("materialPrice", _materialPrice_Id)
        End If

    End Sub

    Private Sub FormMaterialPrice_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        splitContMaterial.SplitterDistance = 440

        splitContMaterial.Panel1MinSize = 220
        splitContMaterial.Panel2MinSize = 330

        Dim toolTipMat As New ToolTip()
        toolTipMat.AutoPopDelay = 5000
        toolTipMat.InitialDelay = 1000
        toolTipMat.ReshowDelay = 500
        toolTipMat.ShowAlways = True

        toolTipMat.SetToolTip(Me.btnMaterialFilter, "Busca el Material")
        toolTipMat.SetToolTip(Me.btnMaterialType, "Ir a Tipo de el Material")
        toolTipMat.SetToolTip(Me.btnDataSource, "Ir a Origen de Datos")
        toolTipMat.SetToolTip(Me.btnGuardar2, "Guardar Precio")
        toolTipMat.SetToolTip(Me._UPCBoxDataSourceInpute, "Origen de Datos")
        toolTipMat.SetToolTip(Me._UPCBoxMaterialTypeList, "Tipo de el Material")
        toolTipMat.SetToolTip(Me._UPCBoxDataSourceInpute, "Origen de Datos")
        toolTipMat.SetToolTip(Me._UPTxtMaterialPriceFilter, "Filtro dinámico materiales")
        toolTipMat.SetToolTip(Me.btnReportMaterialPriceList, "Reporte de Materiales con precios")
        toolTipMat.SetToolTip(Me.btnMaterialPriceList, "Listado de Materiales con precios")

    End Sub

    Private Sub _UPCBoxMaterialTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxMaterialTypeList.SelectedIndexChanged
        If Not _IsInitialize Then

            ReloadMateriales()
            LoadPriceMaterialSelect()
            _UPTxtMaterialPriceFilter.Text = ""

        End If
    End Sub

    Private Sub _UPCBoxDataSourceInpute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInpute.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadMateriales()
            LoadPriceMaterialSelect()
            _UPTxtMaterialPriceFilter.Text = ""

        End If
    End Sub

    Private Sub btnMaterialFilter_Click(sender As Object, e As EventArgs) Handles btnMaterialFilter.Click
        _UPDGViewList.FilterList(_UPTxtMaterialPriceFilter.Text)
    End Sub

    Private Sub _UPTxtMaterialPriceFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtMaterialPriceFilter.TextChanged
        _UPDGViewList.FilterList(_UPTxtMaterialPriceFilter.Text)

    End Sub

    Private Sub _UPDGViewList_DoubleClick(sender As Object, e As EventArgs) Handles _UPDGViewList.DoubleClick
        If HasSelectedItem Then
            _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing

            _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text

        Else
            _UPCBoxCodigoNombre.SetSelectedItem(1)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing

            _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text
        End If


        btnGuardar2.Enabled = True
        EnableControls(True)
    End Sub

    Private Sub tlpListMaterial_Paint(sender As Object, e As PaintEventArgs) Handles tlpListMaterial.Paint

    End Sub

    Private Sub btnMaterialType_Click(sender As Object, e As EventArgs) Handles btnMaterialType.Click
        Dim _FormMaterialType As New FormMaterialType()
        _FormMaterialType.ShowDialog()
    End Sub

    Private Sub btnDataSource_Click(sender As Object, e As EventArgs) Handles btnDataSource.Click
        Dim _FormAppDataSource As New FormDataSourceInput()
        _FormAppDataSource.ShowDialog()
    End Sub

    Private Sub btnPriceList_Click(sender As Object, e As EventArgs) Handles btnMaterialPriceList.Click
        Dim _FormMaterialPriceList1 As New FormMaterialPriceList()
        _FormMaterialPriceList1.ShowDialog()
    End Sub



#Region "Bordes Botones"

    Private Sub btnDataSource_MouseEnter(sender As Object, e As EventArgs) Handles btnDataSource.MouseEnter
        btnDataSource.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnDataSource_MouseLeave(sender As Object, e As EventArgs) Handles btnDataSource.MouseLeave
        btnDataSource.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnMaterialType_MouseEnter(sender As Object, e As EventArgs) Handles btnMaterialType.MouseEnter
        btnMaterialType.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMaterialType_MouseLeave(sender As Object, e As EventArgs) Handles btnMaterialType.MouseLeave
        btnMaterialType.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnGuardar2_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar2.MouseEnter
        btnGuardar2.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnGuardar2_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar2.MouseLeave
        btnGuardar2.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnPriceList_MouseEnter(sender As Object, e As EventArgs) Handles btnMaterialPriceList.MouseEnter
        btnMaterialPriceList.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnPriceList_MouseLeave(sender As Object, e As EventArgs) Handles btnMaterialPriceList.MouseLeave
        btnMaterialPriceList.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReportMaterialPrice_MouseEnter(sender As Object, e As EventArgs) Handles btnReportMaterialPriceList.MouseEnter
        btnReportMaterialPriceList.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReportMaterialPrice_MouseLeave(sender As Object, e As EventArgs) Handles btnReportMaterialPriceList.MouseLeave
        btnReportMaterialPriceList.FlatAppearance.BorderSize = 0
    End Sub


#End Region
End Class