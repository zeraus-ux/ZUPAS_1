Imports Newtonsoft.Json.Linq
Imports System.Windows.Media.Media3D
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.ComponentModel

Public Class FormAPU

    Private WithEvents _UPCBoxCharter As UPComboBox
    Private WithEvents _UPCBoxUnitPartida As UPComboBox
    Private WithEvents _UPCBoxUnitRendimiento As UPComboBox
    Private WithEvents _CBxInsumo As Windows.Forms.ComboBox
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Private WithEvents _UPDGViewPartidaMaterial As UPDataGridView = Nothing
    Private WithEvents _UPDGViewPartidaEquipment As UPDataGridView = Nothing
    'Private WithEvents _UPDGViewPartidaTool As UPDataGridView = Nothing
    'Private WithEvents _UPDGViewPartidaTransport As UPDataGridView = Nothing
    Private WithEvents _UPDGViewPartidaLabour As UPDataGridView = Nothing

    Private WithEvents _UPDGViewpartidaCostValue As UPDataGridView

    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel
    Private WithEvents _UPlbl8 As UPLabel
    Private WithEvents _UPlbl9 As UPLabel
    Private WithEvents _UPlbl10 As UPLabel

    Private WithEvents _UPTxtRefPartida As UPTextBox
    Private WithEvents _UPTxtNamePartida As UPTextBox
    Private WithEvents _UPTxtDescriptionPartida As UPTextBox
    Private WithEvents _UPTxtRendimiento As UPTextBoxNumerico

    Private WithEvents _PanelListMaterial As PanelListMaterial = Nothing
    Private WithEvents _PanelListEquipment As PanelListEquipment = Nothing
    Private WithEvents _PanelListLabour As PanelListLabour = Nothing

    Private WithEvents _ContextMenuStripPrices As ContextMenuStrip
    Private WithEvents _MenuItemNewPrices As ToolStripMenuItem

    Private _FormReportPriceAnalysis As FormReportPriceAnalysis = Nothing
    Private _FormReportPriceAnalysisArg As FormReportPriceAnalisysArg = Nothing

    Private _PanelListActived As System.Windows.Forms.UserControl = Nothing
    Private _UPDGViewPartidaInsumoActived As UPDataGridView = Nothing

    Private _IsGuardando As Boolean = False
    Private _IsEdit As Boolean = False
    Private _HeigntBaseTable As Int16 = 300
    Private _IsInitialize = False
    Private _partida_id As Int32
    Private _IsChangedData As Boolean = False
    Private _IsButtonClosed As Boolean = False
    Private _appDataSourceInputIdDefaut As Int32 = -1

    Private _dicMatIsMaterialCompuesto As New Dictionary(Of Int32, Boolean)
    Private _dicEqpIsCompoundEquipment As New Dictionary(Of Int32, Boolean)
    Private _dicLabIsCompoundLabour As New Dictionary(Of Int32, Boolean)

    Private _ListRefPartida As List(Of String) ' MARCA

    Public Sub New(Optional ByVal partida_id As Int32 = -1, Optional DuplicatePartida_id As Int32 = -1,
                   Optional appDataSourceInputId As Int32 = -1, Optional ByVal CharterId As Int32 = -1)

        InitializeComponent()
        Me.Text = "Formulación Análisis de Precios Unitarios"

        _IsInitialize = True
        _appDataSourceInputIdDefaut = appDataSourceInputId

        'cREAR LISTA LIMPIA ---> ' MARCA

        _ListRefPartida = GetColumnList(Of String)("partida", "refPartida")
        Dim _ListRefPartida1 As New List(Of String)
        For Each _RefPartida As String In _ListRefPartida
            _ListRefPartida1.Add(Trim(_RefPartida))
        Next
        _ListRefPartida = _ListRefPartida1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' ContextMenuStripPrices
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ContextMenuStripPrices = New ContextMenuStrip()

        _MenuItemNewPrices = New ToolStripMenuItem()
        _MenuItemNewPrices.Text = "Nuevo precio"

        _ContextMenuStripPrices.Items.Add(_MenuItemNewPrices)

        scAPU.Panel2.Padding = New Padding(4, 0, 8, 0)
        scParent.Panel2.Padding = New Padding(0, 0, 8, 4)
        _IsEdit = partida_id > 0
        _partida_id = partida_id

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        If partida_id > 0 Then
            _UPlbl8 = New UPLabel("E d i c i ó n  d e  P a r t i d a ")
        Else
            _UPlbl8 = New UPLabel("N u e v a   P a r t i d a ")
        End If

        _UPlbl8.SetFortmatEtiquetaInsumo()
        _UPlbl8.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: _UPlbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        '_UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Unidad Partida")
        _UPlbl5 = New UPLabel("Capítulo")
        _UPlbl6 = New UPLabel("Rendimiento")
        _UPlbl7 = New UPLabel("Unidad Rendimiento")
        _UPlbl9 = New UPLabel("Origen de Datos")
        _UPlbl10 = New UPLabel("Insumo")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'TexBox: _UPTxt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefPartida = New UPTextBox(13)
        _UPTxtNamePartida = New UPTextBox(155)
        _UPTxtDescriptionPartida = New UPTextBox(255)

        'UPTxtRendimiento
        _UPTxtRendimiento = New UPTextBoxNumerico(0.000000000001, Double.NaN)
        _UPTxtRendimiento.Value = 1
        _UPTxtRendimiento.Margin = New System.Windows.Forms.Padding(4, 6, 8, 2)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'ComboBox: _UPCBox
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColUnitPartida As New List(Of String)
        _ColUnitPartida.Add("symbolUnit")
        Dim _dicValuesFilterUnit1 As New JObject()
        _dicValuesFilterUnit1("unitPartida") = True
        _UPCBoxUnitPartida = New UPComboBox("unit", _ColUnitPartida, "Unit", True, _dicValuesFilterUnit1)
        _UPCBoxUnitPartida.SelectedIndex = 2 - 1 '20/11/24

        'UPCBoxCharter
        Dim _ColumnNames3 As New List(Of String)
        _ColumnNames3.Add("nameChapter")

        Dim _dicValuesFilter2 As JObject = Nothing
        'Dim _dicValuesFilter2 As New JObject()
        '_dicValuesFilter2("project_id") = ProjectSelectedId

        _UPCBoxCharter = New UPComboBox("chapter", _ColumnNames3, "Chapter", True, _dicValuesFilter2)

        If CharterId > 0 Then
            _UPCBoxCharter.SetSelectedItem(CharterId)
        End If

        'UPCBoxUnitRendimiento
        Dim _columUnit As New List(Of String)
        _columUnit.Add("symbolUnit")
        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("unitRendimiento") = True
        _UPCBoxUnitRendimiento = New UPComboBox("unit", _columUnit, "Unit", True, _dicValuesFilter)
        _UPCBoxUnitRendimiento.SelectedIndex = 0

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'ComboBox Insumo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _CBxInsumo = New Windows.Forms.ComboBox()
        _CBxInsumo.AllowDrop = False
        _CBxInsumo.AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
        _CBxInsumo.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
        _CBxInsumo.DropDownWidth = 140
        _CBxInsumo.Cursor = System.Windows.Forms.Cursors.Hand
        _CBxInsumo.Dock = DockStyle.Fill
        _CBxInsumo.DropDownStyle = ComboBoxStyle.DropDownList
        _CBxInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Regular,
                                                  System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _CBxInsumo.ForeColor = System.Drawing.Color.Black
        _CBxInsumo.BackColor = System.Drawing.Color.WhiteSmoke
        _CBxInsumo.Location = New System.Drawing.Point(109, 218)
        _CBxInsumo.Margin = New System.Windows.Forms.Padding(4, 8, 4, 4)
        ' _CBxInsumo.Dock = DockStyle.Left

        For Each _Insumo As EnumInsumos In GetInsumos()
            Dim _Id As Int16 = _CBxInsumo.Items.Count + 1
            Dim _Text As String = ""
            Dim _ImageKey As String = ""
            Select Case _Insumo
                Case EnumInsumos.Materiales
                    _Text = "Materiales"
                    _ImageKey = "Materiales"
                Case EnumInsumos.Equipos
                    _Text = "Equipos"
                    _ImageKey = "Equipos"
                Case EnumInsumos.Herramientas
                    _Text = "Herramientas"
                    _ImageKey = "Herramientas"
                Case EnumInsumos.Transporte
                    _Text = "Transporte"
                    _ImageKey = "Transporte"
                Case EnumInsumos.ManoDeObra
                    _Text = "Mano de Obra"
                    _ImageKey = "ManoDeObra"
            End Select
            _CBxInsumo.Items.Add(New ComboBoxItemEnum(_Id, _Text, _ImageKey, _Insumo))
        Next

        _CBxInsumo.SelectedIndex = 0

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInpute                  '14/11
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource2 As New List(Of String)
        _ColumnMaterialSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnMaterialSource2, "Origen de Datos", True)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInput.SetSelectedItem(appDataSourceInputId)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me.PanelHeader2.Controls.Add(_UPlbl8)

        Me.tlpPartidaEdition.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpPartidaEdition.Controls.Add(_UPlbl2, 0, 1)
        'Me.tlpPartidaEdition.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpPartidaEdition.Controls.Add(_UPlbl4, 2, 0)

        Me.tlpLabelEdit.Controls.Add(_UPlbl9, 0, 0)
        Me.tlpLabelEdit.Controls.Add(_UPlbl5, 0, 1)
        Me.tlpLabelEdit.Controls.Add(_UPlbl6, 0, 2)
        Me.tlpLabelEdit.Controls.Add(_UPlbl7, 0, 3)

        Me.tlpPartidaEdition.Controls.Add(_UPTxtRefPartida, 1, 0)
        Me.tlpPartidaEdition.Controls.Add(_UPTxtNamePartida, 1, 1)
        'Me.tlpPartidaEdition.Controls.Add(_UPTxtDescriptionPartida, 1, 2)
        Me.tlpPartidaEdition.Controls.Add(_UPCBoxUnitPartida, 3, 0)

        Me.tlpTexEdit.Controls.Add(_UPCBoxDataSourceInput, 0, 0)
        Me.tlpTexEdit.Controls.Add(_UPCBoxCharter, 0, 1)
        Me.tlpTexEdit.Controls.Add(_UPTxtRendimiento, 0, 2)
        Me.tlpTexEdit.Controls.Add(_UPCBoxUnitRendimiento, 0, 3)

        tlpPartidaEditButton.Controls.Add(_UPlbl10, 0, 0)
        tlpPartidaEditButton.Controls.Add(_CBxInsumo, 1, 0)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDGViewpartidaCostValue
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDGViewpartidaCostValue = New UPDataGridView("partidaCostValue")
        _UPDGViewpartidaCostValue.Dock = DockStyle.Fill
        _UPDGViewpartidaCostValue.EditMode = DataGridViewEditMode.EditOnEnter
        _UPDGViewpartidaCostValue.AllowUserToAddRows = False
        _UPDGViewpartidaCostValue.AllowUserToDeleteRows = False
        _UPDGViewpartidaCostValue.AllowUserToOrderColumns = False
        _UPDGViewpartidaCostValue.AllowUserToResizeColumns = False

        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewpartidaCostValue.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewpartidaCostValue.CrearteColumnText("project_Id", "project_Id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column partida_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewpartidaCostValue.CrearteColumnText("partida_id", "partida_id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cost_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames2 As New List(Of String)
        _ColumnNames2.Add("refCostValue")
        _ColumnNames2.Add("nameCostValue")

        _DataGridViewColumn = _UPDGViewpartidaCostValue.CreateColumnComboBox("appCostValue_id", "Variables Administrativas", True, True, False,
                                                                  "appCostValue", _ColumnNames2, "cost", True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DataGridViewColumn.ReadOnly = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Value
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewpartidaCostValue.CrearteColumnFloat("defaultCostUser", "Value", False, True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.Width = 150

        Dim _DataTable1 = GetNewPartidaCostValue(ProjectSelectedId)
        _UPDGViewpartidaCostValue.DataSource = _DataTable1

        scParent.Panel2Collapsed = True

        _IsInitialize = False

        LoadPartidaSeleccionada()
        LoadListInsumo()

        DuplicatePartida(DuplicatePartida_id)

    End Sub

    Public ReadOnly Property IsReportPriceAnalysisShow As Boolean
        Get
            Return Not scParent.Panel2Collapsed
        End Get
    End Property

    Public ReadOnly Property Partida_id As Int32
        Get
            Return _partida_id
        End Get
    End Property

    Public ReadOnly Property Insumo As EnumInsumos
        Get
            Return CType(_CBxInsumo.SelectedItem, ComboBoxItemEnum).Enumeration
        End Get
    End Property

    Public ReadOnly Property material_Id As Int32
        Get
            Return _PanelListMaterial.selectedId
        End Get
    End Property

    Public ReadOnly Property materialName As String
        Get
            Return _PanelListMaterial.MaterialName
        End Get
    End Property

    Public ReadOnly Property equipment_Id As Int32
        Get
            Return _PanelListEquipment.selectedId
        End Get
    End Property

    Public ReadOnly Property equipmentName As String
        Get
            Return _PanelListEquipment.equipmentName
        End Get
    End Property

    Public ReadOnly Property labour_Id As Int32
        Get
            Return _PanelListLabour.selectedId
        End Get
    End Property

    Public ReadOnly Property labourName As String
        Get
            Return _PanelListLabour.labourName
        End Get
    End Property

    Public ReadOnly Property PartidaMaterial_Id As Int32
        Get
            Dim _PartidaMaterial_Id As Object = _UPDGViewPartidaMaterial.GetColumnValue("material_Id")
            If _PartidaMaterial_Id IsNot Nothing Then

                If IsDBNull(_PartidaMaterial_Id) Then
                    Return -1
                Else
                    Return _PartidaMaterial_Id
                End If
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property PartidaMaterialUnit_Id As Int32
        Get
            Dim _ParidaMaterial_Id As Object = _UPDGViewPartidaMaterial.GetColumnValue("unit_id")
            If _ParidaMaterial_Id IsNot Nothing Then
                If IsDBNull(_ParidaMaterial_Id) Then
                    Return -1
                Else
                    Return _ParidaMaterial_Id
                End If
                Return _ParidaMaterial_Id
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property MatIsMaterialCompuesto As Boolean
        Get
            If PartidaMaterial_Id > 0 Then
                If _dicMatIsMaterialCompuesto.ContainsKey(PartidaMaterial_Id) Then
                    Return _dicMatIsMaterialCompuesto(PartidaMaterial_Id)
                Else
                    Dim _isCmp As Boolean = Not GetDataValue("material", "isAtomic", PartidaMaterial_Id)
                    _dicMatIsMaterialCompuesto.Add(PartidaMaterial_Id, _isCmp)
                    Return _isCmp
                End If

            Else
                Return False
            End If

        End Get
    End Property

    Public ReadOnly Property partidaEquipment_Id As Int32
        'Get
        '    Dim _partidaEquipment_Id As Object = _UPDGViewPartidaEquipment.GetColumnValue("equipment_Id")
        '    If _partidaEquipment_Id IsNot Nothing Then
        '        Return _partidaEquipment_Id
        '    Else
        '        Return -1
        '    End If
        'End Get
        Get
            Dim _PartidaEquipmet_Id As Object = _UPDGViewPartidaEquipment.GetColumnValue("equipment_Id")
            If _PartidaEquipmet_Id IsNot Nothing Then

                If IsDBNull(_PartidaEquipmet_Id) Then
                    Return -1
                Else
                    Return _PartidaEquipmet_Id
                End If
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property partidaEquipmentUnit_Id As Int32
        Get
            Dim _partidaEquipmentUnit_Id As Object = _UPDGViewPartidaEquipment.GetColumnValue("unit_id")
            If _partidaEquipmentUnit_Id IsNot Nothing Then
                Return _partidaEquipmentUnit_Id
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property EqpIsCompoundEquipment As Boolean
        Get
            If partidaEquipment_Id > 0 Then
                If _dicMatIsMaterialCompuesto.ContainsKey(partidaEquipment_Id) Then
                    Return _dicMatIsMaterialCompuesto(partidaEquipment_Id)
                Else
                    Dim _isCmp As Boolean = Not GetDataValue("equipment", "isAtomic", partidaEquipment_Id)
                    _dicMatIsMaterialCompuesto.Add(partidaEquipment_Id, _isCmp)
                    Return _isCmp
                End If

            Else
                Return False
            End If

        End Get
    End Property

    Public ReadOnly Property partidaLabour_Id As Int32
        'Get
        '    Dim _partidaLabour_Id As Object = _UPDGViewPartidaLabour.GetColumnValue("labour_Id")
        '    If _partidaLabour_Id IsNot Nothing Then
        '        Return _partidaLabour_Id
        '    Else
        '        Return -1
        '    End If
        'End Get
        Get
            Dim _PartidaLabour_Id As Object = _UPDGViewPartidaLabour.GetColumnValue("labour_Id")
            If _PartidaLabour_Id IsNot Nothing Then

                If IsDBNull(_PartidaLabour_Id) Then
                    Return -1
                Else
                    Return _PartidaLabour_Id
                End If
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property partidaLabourUnit_Id As Int32
        Get
            Dim _partidaLabourUnit_Id As Object = _UPDGViewPartidaLabour.GetColumnValue("unit_id")
            If _partidaLabourUnit_Id IsNot Nothing Then
                Return _partidaLabourUnit_Id
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property LabIsCompoundLabour As Boolean
        Get
            If partidaLabour_Id > 0 Then
                If _dicLabIsCompoundLabour.ContainsKey(partidaLabour_Id) Then
                    Return _dicLabIsCompoundLabour(partidaLabour_Id)
                Else
                    Dim _isCmp As Boolean = Not GetDataValue("labour", "isAtomic", partidaLabour_Id)
                    _dicLabIsCompoundLabour.Add(partidaLabour_Id, _isCmp)
                    Return _isCmp
                End If

            Else
                Return False
            End If

        End Get
    End Property

    Public Function ValidatePartida() As Boolean

        'If String.IsNullOrEmpty(Me.txtRefPartida.Text) Then

        '    MessageBox.Show("no puede ser nulo el codigo de partida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Me.txtRefPartida.Focus()
        '    Return False

        'ElseIf String.IsNullOrEmpty(Me.txtNamePartida.Text) Then

        '    MessageBox.Show("no puede ser nulo el name de partida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Me.txtNamePartida.Focus()
        '    Return False
        'Else

        '    Return True
        'End If

        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefPartida.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNamePartida.Text, 155) Then
            Return False

        End If

        Return True

    End Function

    Private Function GetInsumos() As List(Of EnumInsumos)
        Dim _Insumos As New List(Of EnumInsumos)
        Select Case PartidaTypeForm
            Case EnumPartidaTypeForm.CIV
                _Insumos.Add(EnumInsumos.Materiales)
                _Insumos.Add(EnumInsumos.Equipos)
                _Insumos.Add(EnumInsumos.ManoDeObra)
            Case EnumPartidaTypeForm.MEX
                _Insumos.Add(EnumInsumos.Materiales)
                _Insumos.Add(EnumInsumos.Equipos)
                _Insumos.Add(EnumInsumos.ManoDeObra)
            Case EnumPartidaTypeForm.ARG
                _Insumos.Add(EnumInsumos.Materiales)
                _Insumos.Add(EnumInsumos.Equipos)
                _Insumos.Add(EnumInsumos.ManoDeObra)
            Case EnumPartidaTypeForm.ATN
                _Insumos.Add(EnumInsumos.Materiales)
                _Insumos.Add(EnumInsumos.Equipos)
                _Insumos.Add(EnumInsumos.ManoDeObra)
                _Insumos.Add(EnumInsumos.Transporte)
            Case EnumPartidaTypeForm.USA
                _Insumos.Add(EnumInsumos.Materiales)
                _Insumos.Add(EnumInsumos.Equipos)
                _Insumos.Add(EnumInsumos.ManoDeObra)
        End Select
        Return _Insumos
    End Function

    Private Sub DuplicatePartida(ByVal DuplicatePartida_id As Int32)
        If DuplicatePartida_id > 0 Then
            _partida_id = DuplicatePartida_id
            LoadPartidaSeleccionada(True)
            _partida_id = -1

            _UPTxtRefPartida.Text = ""
            _UPDGViewPartidaMaterial.ResetIds()
            _UPDGViewPartidaEquipment.ResetIds()
            '_UPDGViewPartidaTool.ResetIds()
            '_UPDGViewPartidaTransport.ResetIds()
            _UPDGViewPartidaLabour.ResetIds()

            '_UPDGViewPartidaMaterial.Refresh()
            '_UPDGViewPartidaEquipment.Refresh()
            '_UPDGViewPartidaTool.Refresh()
            '_UPDGViewPartidaTransport.Refresh()
            '_UPDGViewPartidaLabour.Refresh()

            _CBxInsumo.SelectedIndex = 1
            _CBxInsumo.SelectedIndex = 0

        End If
    End Sub

    Private Sub OnCrearpartidaMaterial()

        _UPDGViewPartidaMaterial = New UPDataGridView("partidaMaterial")
        _UPDGViewPartidaMaterial.Dock = DockStyle.Fill
        _UPDGViewPartidaMaterial.ContextMenuStrip = _ContextMenuStripPrices

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cargar Columnas de: partidaMaterial
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column partida_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnText("partida_id", "partida_id", True, False, False)
        _DataGridViewColumn.Visible = False


        Select Case PartidaTypeForm
            Case EnumPartidaTypeForm.CIV

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Código | Material", False, True, False,
                                                                               "material", _ColumnNames, "Material", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.MinimumWidth = 300 '03/07
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
                CType(_DataGridViewColumn, UPDataGridViewColumnComboBox).IsFilterOptionsList = True  'XXXXX ???????????

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                    "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)

                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60 '03/07

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60 '03/07

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Desperdicio 
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("defalultWasteMaterial", "Desperdicio", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60 '03/07

            Case EnumPartidaTypeForm.MEX

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Código | Material", False, True, False,
                                                                               "material", _ColumnNames, "Material", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                               "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.ARG

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Código | Material", False, True, False,
                                                                               "material", _ColumnNames, "Material", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                               "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.ATN

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Código | Material", False, True, False,
                                                                               "material", _ColumnNames, "Material", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                               "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.USA

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Code | Material", False, True, False,
                                                                               "material", _ColumnNames, "Materials", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unit
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unit", False, True, False,
                                                                               "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Quantity
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Quantity", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

        End Select

        _UPDGViewPartidaMaterial.SetUPDGViewReadOnly(False)
        _UPDGViewPartidaMaterial.SetColumnReadOnly("material_id", True)


    End Sub

    Private Sub OnCrearpartidaEquipment()

        _UPDGViewPartidaEquipment = New UPDataGridView("partidaEquipment")
        _UPDGViewPartidaEquipment.Dock = DockStyle.Fill
        _UPDGViewPartidaEquipment.ContextMenuStrip = _ContextMenuStripPrices

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
        'Cargar Columnas de: partidaEquipment
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column partida_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnText("partida_id", "partida_id", True, False, False)
        _DataGridViewColumn.Visible = False

        Select Case PartidaTypeForm
            Case EnumPartidaTypeForm.CIV
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Código | Equipo", False, True, False,
                                                                               "equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
                _DataGridViewColumn.MinimumWidth = 300 '03/07


                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitEquipment") = True


                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60 '03/07

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60 '03/07

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Costos de Posesión y Operación
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                ' _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("EquitmentTime", "COP", False, True)

                '_DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat()

                '_DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("EquitmentTime", "COP", False, True, 5)
                '_DataGridViewColumn.Visible = True
                '_DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                '_DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                '_DataGridViewColumn.Width = 200
                '_DataGridViewColumn.MinimumWidth = 60 '03/07

            Case EnumPartidaTypeForm.MEX

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Código | Equipo", False, True, False,
                                                                               "equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitEquipment") = True

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Rendimiento
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("rendimientoEquipment", "Rendimiento", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.ARG

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Código | Equipo", False, True, False,
                                                                               "Equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unit
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitEquipment") = True

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = False
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column HP
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                '_DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("HP", "HP", False, True)
                '_DataGridViewColumn.Visible = True
                '_DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                '_DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                '_DataGridViewColumn.Width = 200


            Case EnumPartidaTypeForm.ATN

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Código | Equipo", False, True, False,
                                                                               "Equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitEquipment") = True

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Rendimiento
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("rendimientoEquipment", "Rendimiento", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.USA

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Codigo | Equipment", False, True, False,
                                                                               "Equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unit
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitEquipment") = True

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unit", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit, 3)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.ReadOnly = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column N°
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "N°", False, True, 2)
                _DataGridViewColumn.Visible = True

                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column N° of Hour
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityhours", "Hours", False, True, 2)
                '_DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("rendimientoEquipment", "N° of Hours", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

        End Select

        _UPDGViewPartidaEquipment.SetUPDGViewReadOnly(False)
        _UPDGViewPartidaEquipment.SetColumnReadOnly("equipment_id", True)
    End Sub

    'Private Sub OnCrearpartidaTool()

    '    _UPDGViewPartidaTool = New UPDataGridView("partidaTool")
    '    _UPDGViewPartidaTool.Dock = DockStyle.Fill
    '    _UPDGViewPartidaTool.ContextMenuStrip = _ContextMenuStripPrices
    '    'SetUPDGViewReadOnly(_UPDGViewPartidaTool, True)

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
    '    'Cargar Columnas de: partidaTool
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
    '    Dim _DataGridViewColumn As DataGridViewColumn

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Column Id
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    _DataGridViewColumn = _UPDGViewPartidaTool.CrearteColumnText("id", "id", True, False, False)
    '    _DataGridViewColumn.Visible = False

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Column partida_id
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    _DataGridViewColumn = _UPDGViewPartidaTool.CrearteColumnText("partida_id", "partida_id", True, False, False)
    '    _DataGridViewColumn.Visible = False

    '    Select Case PartidaTypeForm
    '        Case EnumPartidaTypeForm.ATN

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Codigo
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames As New List(Of String)  ' Tabla: Tool
    '            _ColumnNames.Add("refTool")
    '            _ColumnNames.Add("nameTool")

    '            _DataGridViewColumn = _UPDGViewPartidaTool.CreateColumnComboBox("tool_id", "Codigo | Herrmientas", False, True, False,
    '                                                                           "tool", _ColumnNames, "Herramienta", True, Nothing)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Unit
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames1 As New List(Of String)
    '            _ColumnNames1.Add("nameUnit")

    '            _DataGridViewColumn = _UPDGViewPartidaTool.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
    '                                                                           "unit", _ColumnNames1, "Unit", True, Nothing)
    '            _DataGridViewColumn.Visible = True

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Cantidad
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    '            _DataGridViewColumn = _UPDGViewPartidaTool.CrearteColumnFloat("quantityTool", "Cantidad", False, True)
    '            _DataGridViewColumn.Visible = True

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Costos de Posesión y Operación
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    '            _DataGridViewColumn = _UPDGViewPartidaTool.CrearteColumnFloat("costPyO", "Costo O & M", False, True)
    '            _DataGridViewColumn.Visible = True

    '            _UPDGViewPartidaTool.SetUPDGViewReadOnly(False)
    '            _UPDGViewPartidaTool.SetColumnReadOnly("tool_id", True)

    '    End Select


    'End Sub

    'Private Sub OnCrearpartidaTransport()

    '    _UPDGViewPartidaTransport = New UPDataGridView("partidaTransport")
    '    _UPDGViewPartidaTransport.Dock = DockStyle.Fill
    '    _UPDGViewPartidaTransport.ContextMenuStrip = _ContextMenuStripPrices
    '    'SetUPDGViewReadOnly(_UPDGViewPartidaTransport, True)

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
    '    'Cargar Columnas de: partidaTransport
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
    '    Dim _DataGridViewColumn As DataGridViewColumn

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Column Id
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnText("id", "id", True, False, False)
    '    _DataGridViewColumn.Visible = False

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Column partida_id
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnText("partida_id", "partida_id", True, False, False)
    '    _DataGridViewColumn.Visible = False


    '    Select Case PartidaTypeForm

    '        Case EnumPartidaTypeForm.ARG

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Codigo
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames As New List(Of String)  ' Tabla: Transport
    '            _ColumnNames.Add("refTransport")
    '            _ColumnNames.Add("nameTransport")

    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CreateColumnComboBox("transport_id", "Código | Transporte", False, True, False,
    '                                                                   "transport", _ColumnNames, "Transport", True, Nothing)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Unit
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames1 As New List(Of String)
    '            _ColumnNames1.Add("nameUnit")

    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CreateColumnComboBox("unit_id", "Unit", False, True, False,
    '                                                                   "unit", _ColumnNames1, "Unit", True, Nothing)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    '            _DataGridViewColumn.Width = 200

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Cantidad
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnFloat("quantityTransport", "Cantidad", False, True)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    '            _DataGridViewColumn.Width = 200
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---
    '            'Column Distancia
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--- 

    '            '_DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("distancia", "Distancia", False, True)
    '            '_DataGridViewColumn.Visible = True

    '            _UPDGViewPartidaTransport.SetColumnReadOnly("transport_id", True)

    '        Case EnumPartidaTypeForm.ATN

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Codigo
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames As New List(Of String)  ' Tabla: Transport
    '            _ColumnNames.Add("refTransport")
    '            _ColumnNames.Add("nameTransport")

    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CreateColumnComboBox("transport_id", "Código | Transporte", False, True, False,
    '                                                                   "transport", _ColumnNames, "Transport", True, Nothing)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Unit
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames1 As New List(Of String)
    '            _ColumnNames1.Add("nameUnit")

    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
    '                                                                   "unit", _ColumnNames1, "Unit", True, Nothing)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    '            _DataGridViewColumn.Width = 200

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Cantidad
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnFloat("quantityTransport", "Cantidad", False, True)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    '            _DataGridViewColumn.Width = 200

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---
    '            'Column Distancia
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--- 
    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnFloat("distance", "Distancia", False, True)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    '            _DataGridViewColumn.Width = 200

    '            _UPDGViewPartidaTransport.SetColumnReadOnly("transport_id", True)


    '    End Select

    '    _UPDGViewPartidaTransport.SetUPDGViewReadOnly(False)


    'End Sub

    Private Sub OnCrearpartidaLabour()

        _UPDGViewPartidaLabour = New UPDataGridView("partidaLabour")
        _UPDGViewPartidaLabour.Dock = DockStyle.Fill
        _UPDGViewPartidaLabour.ContextMenuStrip = _ContextMenuStripPrices

        'SetUPDGViewReadOnly(_UPDGViewPartidaLabour, True)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
        'Cargar Columnas de: partidaLabour
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column partida_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnText("partida_id", "partida_id", True, False, False)
        _DataGridViewColumn.Visible = False

        Select Case PartidaTypeForm
            Case EnumPartidaTypeForm.CIV

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Código | Mano de Obra", False, True, False,
                                                                               "labour", _ColumnNames, "Mano de Obra", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.MEX

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Código | Mano de Obra", False, True, False,
                                                                               "labour", _ColumnNames, "Mano de Obra", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                  "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Rendimiento
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("rendimientoLabour", "Rendimiento", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200


            Case EnumPartidaTypeForm.ARG

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Código | Mano de Obra", False, True, False,
                                                                               "labour", _ColumnNames, "Mano de Obra", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                  "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.ATN
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Código | Mano de Obra", False, True, False,
                                                                               "labour", _ColumnNames, "Mano de Obra", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                  "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Prestaciones
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("prestacionesUser", "Prestaciones %", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.USA

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Code | Labor", False, True, False,
                                                                               "labour", _ColumnNames, "Labor", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unit", False, True, False,
                                                                                  "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                'todas las unidades de FORM USA son en horas, el Usuario no la selecciona
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "N°", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column N° de Horas
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityhours", "N° of Hours", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

        End Select

        _UPDGViewPartidaLabour.SetUPDGViewReadOnly(False)
        _UPDGViewPartidaLabour.SetColumnReadOnly("labour_id", True)
    End Sub

    Private Sub LoadListInsumo()

        If _PanelListActived IsNot Nothing Then
            scAPU.Panel1.Controls.Remove(_PanelListActived)
        End If

        If _UPDGViewPartidaInsumoActived IsNot Nothing Then
            scAPU.Panel2.Controls.Remove(_UPDGViewPartidaInsumoActived)
        End If


        Select Case Insumo
            Case EnumInsumos.Materiales

                If _PanelListMaterial Is Nothing Then
                    _PanelListMaterial = New PanelListMaterial()
                    If _appDataSourceInputIdDefaut > 0 Then
                        _PanelListMaterial.SetSelectedItemappDataSource(_appDataSourceInputIdDefaut)
                    End If
                End If

                If _UPDGViewPartidaMaterial Is Nothing Then
                    OnCrearpartidaMaterial()
                End If

                _UPDGViewPartidaInsumoActived = _UPDGViewPartidaMaterial
                _PanelListActived = _PanelListMaterial

            Case EnumInsumos.Equipos

                If _PanelListEquipment Is Nothing Then
                    _PanelListEquipment = New PanelListEquipment()
                    If _appDataSourceInputIdDefaut > 0 Then
                        _PanelListEquipment.SetSelectedItemappDataSource(_appDataSourceInputIdDefaut)
                    End If
                End If

                If _UPDGViewPartidaEquipment Is Nothing Then
                    OnCrearpartidaEquipment()
                End If

                _UPDGViewPartidaInsumoActived = _UPDGViewPartidaEquipment
                _PanelListActived = _PanelListEquipment

            Case EnumInsumos.Herramientas
            Case EnumInsumos.Transporte
            Case EnumInsumos.ManoDeObra

                If _PanelListLabour Is Nothing Then
                    _PanelListLabour = New PanelListLabour()
                    If _appDataSourceInputIdDefaut > 0 Then
                        _PanelListLabour.SetFilterSourceInput(_appDataSourceInputIdDefaut)
                    End If
                End If

                If _UPDGViewPartidaLabour Is Nothing Then
                    OnCrearpartidaLabour()
                End If

                _UPDGViewPartidaInsumoActived = _UPDGViewPartidaLabour
                _PanelListActived = _PanelListLabour
        End Select

        scAPU.Panel1.Controls.Add(_PanelListActived)
        scAPU.Panel2.Controls.Add(_UPDGViewPartidaInsumoActived)

        '_UPDGViewPartidaInsumoActived.SetUPDGViewReadOnly(False)

    End Sub

    Private Sub LoadPartidaSeleccionada(Optional IsDuplicate As Boolean = False)

        If _partida_id > 0 Then

            OnCrearpartidaMaterial()
            OnCrearpartidaEquipment()
            OnCrearpartidaLabour()
            'OnCrearpartidaTool()
            'OnCrearpartidaTransport()

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar Partida
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _id As Int32 = _partida_id

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("partida", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefPartida.Text = _datatable.Rows(0)("refPartida")
            _UPTxtNamePartida.Text = _datatable.Rows(0)("namePartida")
            _UPTxtDescriptionPartida.Text = _datatable.Rows(0)("descriptionPartida")

            _UPCBoxUnitPartida.SetSelectedItem(_datatable.Rows(0)("unit_id"))

            _UPCBoxCharter.SetSelectedItem(_datatable.Rows(0)("chapter_id"))

            'FATAN LOS OTROS CONTROLES

            _UPCBoxDataSourceInput.SetSelectedItem(_datatable.Rows(0)("appDataSourceInput_id"))



            If Double.IsNaN(_datatable.Rows(0)("rendimiento")) Then
                _UPTxtRendimiento.Value = 1
            Else
                _UPTxtRendimiento.Value = _datatable.Rows(0)("rendimiento")
            End If

            _UPCBoxUnitRendimiento.SetSelectedItem(_datatable.Rows(0)("unitRendimiento_id"))

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaMaterial
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _ColumnNames1 As New List(Of String)

            Dim _dicValuesFilter1 As New JObject()
            _dicValuesFilter1("partida_id") = _id

            _UPDGViewPartidaMaterial.ReLoadData(_dicValuesFilter1, False)

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaEquitment
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            _UPDGViewPartidaEquipment.ReLoadData(_dicValuesFilter1, False)

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaTool
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            '_UPDGViewPartidaTool.ReLoadData(_dicValuesFilter1, False)


            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaLabour
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            '_UPDGViewPartidaTransport.ReLoadData(_dicValuesFilter1, False)

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaLabour
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            _UPDGViewPartidaLabour.ReLoadData(_dicValuesFilter1, False)

            If Not IsDuplicate Then
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                ' Cargar partidaCostValue
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames2 As New List(Of String)

                Dim _dicValuesFilter2 As New JObject()
                _dicValuesFilter2("partida_id") = _id
                _dicValuesFilter2("project_Id") = ProjectSelectedId

                Dim _DataTable1 = GetDataTable("partidaCostValue", ColumnNames:=_ColumnNames2,
                                                           dicValuesFilter:=_dicValuesFilter2)
                _UPDGViewpartidaCostValue.DataSource = _DataTable1
            End If


        End If
    End Sub

    Private Sub RefrechTables()
        Dim _dicValuesFilter As New JObject
        _dicValuesFilter("partida_id") = Partida_id

        If _UPDGViewPartidaMaterial IsNot Nothing Then
            _UPDGViewPartidaMaterial.ReLoadData(_dicValuesFilter)
        End If

        If _UPDGViewPartidaEquipment IsNot Nothing Then
            _UPDGViewPartidaEquipment.ReLoadData(_dicValuesFilter)
        End If

        'If _UPDGViewPartidaTool IsNot Nothing Then
        '    _UPDGViewPartidaTool.ReLoadData(_dicValuesFilter)
        'End If

        'If _UPDGViewPartidaTransport IsNot Nothing Then
        '    _UPDGViewPartidaTransport.ReLoadData(_dicValuesFilter)
        'End If

        If _UPDGViewPartidaLabour IsNot Nothing Then
            _UPDGViewPartidaLabour.ReLoadData(_dicValuesFilter)
        End If

        If _UPDGViewpartidaCostValue IsNot Nothing Then
            _UPDGViewpartidaCostValue.ReLoadData(_dicValuesFilter)
        End If


    End Sub

    Private Sub SavesPartida()

        If ValidatePartida() Then

            _IsGuardando = True

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Guardando Partida
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()

            _dicValues("refPartida") = _UPTxtRefPartida.Text
            _dicValues("namePartida") = _UPTxtNamePartida.Text
            _dicValues("descriptionPartida") = _UPTxtNamePartida.Text 'Revisar ?????????
            _dicValues("appDataSourceInput_id") = _UPCBoxDataSourceInput.GetSelectedItemId()
            _dicValues("chapter_id") = _UPCBoxCharter.GetSelectedItemId()
            _dicValues("unit_id") = _UPCBoxUnitPartida.GetSelectedItemId()
            _dicValues("rendimiento") = CType(_UPTxtRendimiento.Text, Double)
            _dicValues("unitRendimiento_id") = _UPCBoxUnitRendimiento.GetSelectedItemId()

            '_dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                _dicValues("id") = Partida_id

                If GetUpdateTable("partida", _DataServices) IsNot Nothing Then

                    Dim _idPartida As Int32 = Partida_id

                    Select Case PartidaTypeForm
                        Case EnumPartidaTypeForm.CIV

                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If

                        Case EnumPartidaTypeForm.MEX

                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If

                        Case EnumPartidaTypeForm.ARG

                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If

                        Case EnumPartidaTypeForm.ATN

                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If

                            'If _UPDGViewPartidaTransport IsNot Nothing Then
                            '    _UPDGViewPartidaTransport.Saves("partida_id", _idPartida)
                            'End If

                        Case EnumPartidaTypeForm.USA

                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If


                    End Select


                    _UPDGViewpartidaCostValue.Saves("partida_id", _idPartida)

                    Dim _dicValuesFilter0 As New JObject
                    _dicValuesFilter0("project_id") = ProjectSelectedId

                    '_IsEdit = False
                    'EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            Else
                Dim _idPartida As Int32 = GetInsertTable("partida", _DataServices)

                If _idPartida > 0 Then

                    Select Case PartidaTypeForm
                        Case EnumPartidaTypeForm.CIV

                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If


                        Case EnumPartidaTypeForm.MEX

                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If

                        Case EnumPartidaTypeForm.ARG

                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If


                            '_UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaTransport.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.ATN

                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If

                            'If _UPDGViewPartidaTransport IsNot Nothing Then
                            '    _UPDGViewPartidaTransport.Saves("partida_id", _idPartida)
                            'End If

                            '_UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaTool.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.USA


                            If _UPDGViewPartidaMaterial IsNot Nothing Then
                                _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaEquipment IsNot Nothing Then
                                _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            End If

                            If _UPDGViewPartidaLabour IsNot Nothing Then
                                _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)
                            End If

                            '_UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                    End Select

                    _UPDGViewpartidaCostValue.Saves("partida_id", _idPartida)

                    GetCreatePartidaCost(_idPartida)

                    'Dim _dicValuesFilter0 As New JObject
                    '_dicValuesFilter0("project_id") = ProjectSelectedId

                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    _partida_id = _idPartida
                    _IsEdit = True

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If


            End If

            _IsGuardando = False
            _IsChangedData = True

            RefrechTables()

        End If
    End Sub

    Private Sub AddInsumo()
        Select Case Insumo
            Case EnumInsumos.Materiales

                If material_Id > 0 Then

                    Dim _List As List(Of Int32) = _UPDGViewPartidaMaterial.GetListValues(Of Int32)("material_id")

                    If _List.Contains(material_Id) Then

                        MessageBox.Show($"Material '{materialName}' cargado", "Material", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        Dim _dicValues As New JObject()
                        _dicValues("material_id") = material_Id
                        _dicValues("quantityMaterial") = 1
                        If Not IsPartidaARG Then
                            _dicValues("defalultWasteMaterial") = 0
                        End If
                        _dicValues("unit_id") = 2

                        _UPDGViewPartidaMaterial.LoadRow(_dicValues)
                    End If

                    _UPDGViewPartidaMaterial.StartEditing()
                    _UPDGViewPartidaMaterial.AllowUserToAddRows = False
                End If

            Case EnumInsumos.Equipos

                If equipment_Id > 0 Then

                    Dim _List As List(Of Int32) = _UPDGViewPartidaEquipment.GetListValues(Of Int32)("equipment_id")

                    If _List.Contains(equipment_Id) Then

                        MessageBox.Show($"Equipo '{equipmentName}' cargado", "Equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        Dim _dicValues As New JObject()
                        _dicValues("equipment_id") = equipment_Id
                        _dicValues("quantityEquipment") = 1
                        '_dicValues("EquitmentTime") = 1
                        If Not IsPartidaARG Then

                            ' Colocar la correcta segun la formtype

                            Select Case PartidaTypeForm
                                Case EnumPartidaTypeForm.CIV
                                    _dicValues("unit_id") = 38
                                Case EnumPartidaTypeForm.MEX
                                    _dicValues("unit_id") = 38
                                Case EnumPartidaTypeForm.ARG
                                    _dicValues("unit_id") = 38
                                Case EnumPartidaTypeForm.ATN
                                    _dicValues("unit_id") = 38
                                Case EnumPartidaTypeForm.USA
                                    _dicValues("unit_id") = 38
                            End Select

                        Else
                            _dicValues("unit_id") = 2
                        End If


                        _UPDGViewPartidaEquipment.LoadRow(_dicValues)
                    End If

                    _UPDGViewPartidaEquipment.StartEditing()
                    _UPDGViewPartidaEquipment.AllowUserToAddRows = False
                End If

            Case EnumInsumos.Herramientas
            Case EnumInsumos.Transporte
            Case EnumInsumos.ManoDeObra

                If labour_Id > 0 Then

                    Dim _List As List(Of Int32) = _UPDGViewPartidaLabour.GetListValues(Of Int32)("labour_id")

                    If _List.Contains(labour_Id) Then

                        MessageBox.Show($"Mano de Obra '{labourName}' cargado", "Mano de Obra", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        Dim _dicValues As New JObject()
                        _dicValues("labour_id") = labour_Id
                        _dicValues("quantityLabour") = 1
                        _dicValues("unit_id") = 4

                        _UPDGViewPartidaLabour.LoadRow(_dicValues)
                    End If

                    _UPDGViewPartidaLabour.StartEditing()
                    _UPDGViewPartidaLabour.AllowUserToAddRows = False
                End If
                '_UPDGViewPartidaLabour
        End Select
    End Sub

    Private Sub ReportPriceAnalysisShowRefresh()
        If IsPartidaARG Then
            If _FormReportPriceAnalysisArg IsNot Nothing Then
                _FormReportPriceAnalysisArg.RefreshReportPriceAnalysis()
                _FormReportPriceAnalysisArg.Refresh()
            End If

        Else
            If _FormReportPriceAnalysis IsNot Nothing Then
                _FormReportPriceAnalysis.RefreshReportPriceAnalysis()
                _FormReportPriceAnalysis.Refresh()
            End If
        End If



    End Sub

    Private Sub ReportPriceAnalysisShow()

        Dim _IsShowPanel = scParent.Panel2Collapsed

        If _IsShowPanel Then

            If IsPartidaARG Then

                If _FormReportPriceAnalysisArg Is Nothing Then

                    If _partida_id = -1 Then
                        If MessageBox.Show("Para visualizar el reporte debe salvar primero la partida. Saves?", "Saves",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                            If ValidatePartida() Then
                                SavesPartida()
                            End If

                            If _partida_id > 0 Then
                                _FormReportPriceAnalysisArg = New FormReportPriceAnalisysArg(_partida_id)
                            End If
                        End If

                    Else
                        _FormReportPriceAnalysisArg = New FormReportPriceAnalisysArg(_partida_id)
                    End If

                    If _FormReportPriceAnalysisArg IsNot Nothing Then
                        _FormReportPriceAnalysisArg.TopLevel = False
                        _FormReportPriceAnalysisArg.FormBorderStyle = FormBorderStyle.None
                        _FormReportPriceAnalysisArg.Dock = DockStyle.Fill
                        scParent.Panel2.Controls.Add(_FormReportPriceAnalysisArg)
                        _FormReportPriceAnalysisArg.BringToFront()
                        _FormReportPriceAnalysisArg.Show()
                    End If


                End If

                scParent.Panel2Collapsed = _FormReportPriceAnalysisArg Is Nothing

            Else
                If _FormReportPriceAnalysis Is Nothing Then

                    If _partida_id = -1 Then
                        If MessageBox.Show("Para visualizar el reporte debe salvar primero la partida. Saves?", "Saves",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                            If ValidatePartida() Then
                                SavesPartida()
                            End If

                            If _partida_id > 0 Then
                                _FormReportPriceAnalysis = New FormReportPriceAnalysis(_partida_id)
                            End If
                        End If

                    Else
                        _FormReportPriceAnalysis = New FormReportPriceAnalysis(_partida_id)
                    End If

                    If _FormReportPriceAnalysis IsNot Nothing Then
                        _FormReportPriceAnalysis.TopLevel = False
                        _FormReportPriceAnalysis.FormBorderStyle = FormBorderStyle.None
                        _FormReportPriceAnalysis.Dock = DockStyle.Fill
                        scParent.Panel2.Controls.Add(_FormReportPriceAnalysis)
                        _FormReportPriceAnalysis.BringToFront()
                        _FormReportPriceAnalysis.Show()
                    End If


                End If

                scParent.Panel2Collapsed = _FormReportPriceAnalysis Is Nothing
            End If

        Else
            scParent.Panel2Collapsed = True
        End If

    End Sub

    Private Sub ValidateRefPartida()

        Dim _RefPartida As String = _UPTxtRefPartida.Text.Trim()
        If _ListRefPartida.Contains(_RefPartida) Then
            MessageBox.Show("El código de la partida existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_UPTxtRefPartida.Focus()
        End If

    End Sub

    Private Sub _CBxInsumo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _CBxInsumo.SelectedIndexChanged
        If Not _IsInitialize Then
            LoadListInsumo()
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnPreView.Click
        ReportPriceAnalysisShow()
        ReportPriceAnalysisShowRefresh()
    End Sub

    Private Sub btnCostos_Click(sender As Object, e As EventArgs) Handles btnCostos.Click
        Dim _FormpartidaCost As New FormPartidaCost(_UPDGViewpartidaCostValue)
        _FormpartidaCost.ShowDialog(Me)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SavesPartida()
        If IsReportPriceAnalysisShow Then
            ReportPriceAnalysisShowRefresh()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        DialogResult = DialogResult.OK
        _IsButtonClosed = True
        Close()

    End Sub

    Private Sub btnAddInsumo_Click(sender As Object, e As EventArgs) Handles btnAddInsumo.Click
        AddInsumo()
    End Sub

    'Private Sub FormAPU_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
    '    Dim startPoint As New Point(0, 0)
    '    Dim endPoint As New Point(Me.Width, Me.Height)
    '    Dim startColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
    '    'Dim endColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(199, Byte), Integer))
    '    'Dim endColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(209, Byte), Integer))
    '    Dim endColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))

    '    Using linGrBrush As New LinearGradientBrush(startPoint, endPoint, startColor, endColor)
    '        e.Graphics.FillRectangle(linGrBrush, 0, 0, Me.Width, Me.Height)
    '    End Using
    'End Sub

    'Private Sub PanelHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelHeader.Paint
    '    Dim startPoint As New Point(Me.Width - Me.Size.Width, Me.Height - Me.Size.Height)
    '    Dim endPoint As New Point(Me.Width, Me.Height)
    '    Dim startColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
    '    'Dim endColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(199, Byte), Integer))
    '    'Dim endColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(209, Byte), Integer))
    '    Dim endColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))

    '    Using linGrBrush As New LinearGradientBrush(startPoint, endPoint, startColor, endColor)
    '        e.Graphics.FillRectangle(linGrBrush, 0, 0, Me.Width, Me.Height)
    '    End Using
    'End Sub

    Private Sub FormAPU_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        Me.scAPU.FixedPanel = FixedPanel.Panel1
        Me.scAPU.SplitterDistance = 500

        Dim toolTipAPU As New ToolTip()
        toolTipAPU.AutoPopDelay = 5000
        toolTipAPU.InitialDelay = 1000
        toolTipAPU.ReshowDelay = 500
        toolTipAPU.ShowAlways = True

        toolTipAPU.SetToolTip(Me.btnCost, "Costos de la Partida")
        toolTipAPU.SetToolTip(Me.btnCostos, "Costos de la Partida")
        toolTipAPU.SetToolTip(Me._CBxInsumo, "Tipo de Insumo")
        toolTipAPU.SetToolTip(Me.btnAddInsumo, "Agrega Insumo Seleccionado")
        toolTipAPU.SetToolTip(Me.btnPreView, "Vista previa APU")


        Me._UPTxtRefPartida.TabIndex = 1
        Me._UPTxtNamePartida.TabIndex = 2
        Me._CBxInsumo.TabIndex = 3
        Me._UPCBoxUnitPartida.TabIndex = 4
        Me._UPCBoxDataSourceInput.TabIndex = 5
        Me._UPCBoxCharter.TabIndex = 6
        Me._UPTxtRendimiento.TabIndex = 7
        Me._UPCBoxUnitRendimiento.TabIndex = 8

        Me._UPTxtRefPartida.Focus()

    End Sub

    'Private Sub _UPTxtRefPartida_GotFocus(sender As Object, e As EventArgs) Handles _UPTxtRefPartida.GotFocus

    'End Sub

    'Private Sub _UPTxtRefPartida_LostFocus(sender As Object, e As EventArgs) Handles _UPTxtRefPartida.LostFocus

    'End Sub

    Private Sub _UPTxtRefPartida_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefPartida.Validating
        ' MARCA
        ValidateRefPartida()
    End Sub

    Private Sub _PanelListMaterial_EvDoubleClick(sender As Object, e As EventArgs) Handles _PanelListMaterial.EvDoubleClick
        AddInsumo()
    End Sub

    Private Sub _PanelListEquipment_EvDoubleClick(sender As Object, e As EventArgs) Handles _PanelListEquipment.EvDoubleClick
        AddInsumo()
    End Sub

    Private Sub _PanelListLabour_EvDoubleClick(sender As Object, e As EventArgs) Handles _PanelListLabour.EvDoubleClick
        AddInsumo()
    End Sub

    Private Sub FormAPU_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not _IsButtonClosed Then
            DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim _FormpartidaCost As New FormPartidaCost(_UPDGViewpartidaCostValue)
        _FormpartidaCost.ShowDialog(Me)
    End Sub

    Private Sub _ContextMenuStripPrices_Opening(sender As Object, e As CancelEventArgs) Handles _ContextMenuStripPrices.Opening

        'HAY QUE REPETIR PARA EQUIPOS - 
        Select Case Insumo
            Case EnumInsumos.Materiales
                If MatIsMaterialCompuesto Then
                    _MenuItemNewPrices.Text = "Editar material compuesto"
                Else
                    _MenuItemNewPrices.Text = "Nuevo precio"
                End If
                _MenuItemNewPrices.Enabled = PartidaMaterial_Id > 0

            Case EnumInsumos.Equipos
                If EqpIsCompoundEquipment Then
                    _MenuItemNewPrices.Text = "Editar equipo compuesto"
                Else
                    _MenuItemNewPrices.Text = "Nuevo precio"
                End If
                _MenuItemNewPrices.Enabled = partidaEquipment_Id > 0

            Case EnumInsumos.Herramientas
            Case EnumInsumos.Transporte
            Case EnumInsumos.ManoDeObra

                If LabIsCompoundLabour Then
                    _MenuItemNewPrices.Text = "Editar Mano de Obra compuesta"
                Else
                    _MenuItemNewPrices.Text = "Nuevo precio"
                End If
                _MenuItemNewPrices.Enabled = partidaEquipment_Id > 0

            Case EnumInsumos.Herramientas
        End Select
    End Sub

    Private Sub _MenuItemNewPrices_Click(sender As Object, e As EventArgs) Handles _MenuItemNewPrices.Click

        Select Case Insumo
            Case EnumInsumos.Materiales

                If MatIsMaterialCompuesto Then

                    Dim _FormCompoundMaterial As New FormCompoundMaterial(PartidaMaterial_Id)
                    If _FormCompoundMaterial.ShowDialog(Me) = DialogResult.OK Then
                        ReportPriceAnalysisShowRefresh()
                    End If

                Else
                    Dim _FormMaterialPriceModal As New FormMaterialPriceModal(PartidaMaterial_Id, PartidaMaterialUnit_Id)
                    If _FormMaterialPriceModal.ShowDialog(Me) = DialogResult.OK Then
                        ReportPriceAnalysisShowRefresh()
                    End If
                End If

            Case EnumInsumos.Equipos

                If EqpIsCompoundEquipment Then

                    Dim _FormCompoundEquipment As New FormCompoundEquipment(partidaEquipment_Id)
                    If _FormCompoundEquipment.ShowDialog(Me) = DialogResult.OK Then
                        ReportPriceAnalysisShowRefresh()
                    End If

                Else
                    Dim _FormequipmentCostPyOUserModal As New FormequipmentCostPyOUserModal(partidaEquipment_Id, partidaEquipmentUnit_Id)
                    If _FormequipmentCostPyOUserModal.ShowDialog(Me) = DialogResult.OK Then
                        ReportPriceAnalysisShowRefresh()
                    End If
                End If

            Case EnumInsumos.Herramientas
            Case EnumInsumos.Transporte
            Case EnumInsumos.ManoDeObra

                If LabIsCompoundLabour Then

                    Dim _FormCompoundLabour As New FormCompoundLabour(partidaLabour_Id)
                    If _FormCompoundLabour.ShowDialog(Me) = DialogResult.OK Then
                        ReportPriceAnalysisShowRefresh()
                    End If

                Else
                    Dim _FormLabourPriceModal As New FormLabourPriceModal(partidaLabour_Id, partidaLabourUnit_Id)
                    If _FormLabourPriceModal.ShowDialog(Me) = DialogResult.OK Then
                        ReportPriceAnalysisShowRefresh()
                    End If
                End If

        End Select


    End Sub


    'Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
    '    Dim _FormpartidaCost As New FormPartidaCost(_UPDGViewpartidaCostValue, _UPDGViewpartidaCost)
    '    _FormpartidaCost.ShowDialog(Me)
    'End Sub


    Private Sub _UPDGViewPartidaMaterial_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles _UPDGViewPartidaMaterial.CellBeginEdit
        If MatIsMaterialCompuesto Then
            If e.ColumnIndex = 3 Then
                e.Cancel = True
            End If

        End If

    End Sub


    Private Sub btnReportAPU_Click(sender As Object, e As EventArgs) Handles btnReportAPU.Click


        If IsPartidaARG Then
            'Dim _Report As New FormReportPriceAnalysis(selectedId)
            '_Report.Show(Me)

            Dim _Report = New FormReportPriceAnalisysArg(_partida_id)
            _Report.Show(Me)

            '_FormReportPriceAnalysisArg.RefreshReportPriceAnalysis(selectedId)
        Else
            'Dim _Report As New FormReportPriceAnalysis(selectedId)
            '_Report.Show(Me)

            Dim _Report = New FormReportPriceAnalysis(_partida_id)
            _Report.Show(Me)

            '_FormReportPriceAnalysis.RefreshReportPriceAnalysis(selectedId)
        End If
    End Sub



#Region "Bordes Botones"

    Private Sub btnCostos_MouseEnter(sender As Object, e As EventArgs) Handles btnCostos.MouseEnter
        btnCostos.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCostos_MouseLeave(sender As Object, e As EventArgs) Handles btnCostos.MouseLeave
        btnCostos.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnPreView_MouseEnter(sender As Object, e As EventArgs) Handles btnPreView.MouseEnter
        btnPreView.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnPreView_MouseLeave(sender As Object, e As EventArgs) Handles btnPreView.MouseLeave
        btnPreView.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnReportAPU_MouseLeave(sender As Object, e As EventArgs) Handles btnReportAPU.MouseLeave

        btnReportAPU.FlatAppearance.BorderSize = 0

    End Sub

    Private Sub btnReportAPU_MouseEnter(sender As Object, e As EventArgs) Handles btnReportAPU.MouseEnter
        btnReportAPU.FlatAppearance.BorderSize = 1
    End Sub



    'Private Sub FormAPU_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    Me._UPTxtRefPartida.Focus()
    'End Sub

    'Private Sub FormAPU_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
    '    Me.Focus()
    '    Me._UPTxtRefPartida.Focus()
    'End Sub







#End Region

End Class
