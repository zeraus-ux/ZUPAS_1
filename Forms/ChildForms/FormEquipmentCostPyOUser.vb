Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormEquipmentCostPyOUser
    'Private WithEvents _FormequipmentCostPyOUserList As FormequipmentCostPyOUserList = Nothing

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel

    Private WithEvents _UPTxtBox As UPTextBox
    Private WithEvents _UPTxtequipmentCostPyOUserFilter As UPTextBox
    Private WithEvents _UPCTBoxCodigoNombre As UPTextBox

    Private WithEvents _UPTxtBoxNumerico1 As UPTextBoxNumerico

    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPCBoxUnit As UPComboBox
    Private WithEvents _UPCBoxUnit2 As UPComboBox
    Private WithEvents _UPCBoxCodigoNombre As UPComboBox
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox
    Private WithEvents _UPCBoxEquipmentTypeList As UPComboBox

    Private WithEvents _UPDateTimePicker As UPDateTimePicker

    Private _IsEdit As Boolean = False
    'Private _IsCargandoConstructor = False
    Private _equipmentCostPyOUser_Id As Int32 = -1
    Private _selectedEquipmentType_id As Int32 = -1
    Private _equipmentPriceEstimate_Id As Int32 = -1
    Private _IsInitialize As Boolean = False
    Private _IsNewSupply As Boolean = False
    Private _dicValuesEqmtPriceEst As JObject = Nothing
    Public _IsGuardando As Boolean = False

    Public Sub New()

        InitializeComponent()
        _IsInitialize = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters (SourceInput)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnEquipmentMode As New List(Of String)
        _ColumnEquipmentMode.Add("nameEquipmentType")

        _UPCBoxEquipmentTypeList = New UPComboBox("equipmentType", _ColumnEquipmentMode, "Tipo de Equipo", True)
        _UPCBoxEquipmentTypeList.Margin = New Padding(8, 0, 4, 4)
        _UPCBoxEquipmentTypeList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxEquipmentTypeList.BackColor = Color.WhiteSmoke
        _UPCBoxEquipmentTypeList.Dock = DockStyle.Fill
        _UPCBoxEquipmentTypeList.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters (SourceInput)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnEquipmentSource As New List(Of String)
        _ColumnEquipmentSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnEquipmentSource, "Origen de Datos", False)
        _UPCBoxDataSourceInput.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInput.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInput.Dock = DockStyle.Fill
        _UPCBoxDataSourceInput.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtequipmentCostPyOUserFilter = New UPTextBox
        _UPTxtequipmentCostPyOUserFilter.Margin = New Padding(8, 0, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Equipos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("isAtomic") = True

        If equipmentTypeId > 0 Then
            _dicValuesFilter("equipmentType_id") = equipmentTypeId
        End If

        If appDataSourceInputId > 0 Then
            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        End If

        _UPDGViewList = New UPDGViewList("equipment", "refEquipment", "nameEquipment", "Código", "Nombre del Equipo", _dicValuesFilter)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 0, 5, 8)
        _UPDGViewList.MenuItemEditSupplyVisible = False
        _UPDGViewList.CallDeletedActive = False

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
        _UPlbl0 = New UPLabel("L i s t a d o  d e  E q u i p o s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl7 = New UPLabel("E d i c i ó n  P r e c i o  d e  E q u i p o s")
        _UPlbl7.SetFortmatEtiquetaInsumo()
        _UPlbl7.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas 
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me._UPlbl6.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me._UPlbl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me._UPlbl6.Padding = New System.Windows.Forms.Padding(0)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Código - Nombre
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames4 As New List(Of String)
        _ColumnNames4.Add("refEquipment")
        _ColumnNames4.Add("nameEquipment")

        _UPCBoxCodigoNombre = New UPComboBox("equipment", _ColumnNames4, "Equipment", True)

        _UPCTBoxCodigoNombre = New UPTextBox()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Unit
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        If Not IsPartidaARG Then
            Dim _ColumnNames3 As New List(Of String)
            _ColumnNames3.Add("symbolUnit")

            Dim _dicValuesFilterUnit As New JObject()
            _dicValuesFilterUnit("unitEquipment") = True
            _dicValuesFilterUnit("moneyType_Id") = ProjectMoneyTypeid

            _UPCBoxUnit = New UPComboBox("unit", _ColumnNames3, "Unidad", True, _dicValuesFilterUnit)
            If _UPCBoxUnit.Items.Count > 0 Then
                _UPCBoxUnit.SelectedIndex = 0
            End If
            _UPCBoxUnit.Margin = New System.Windows.Forms.Padding(8, 0, 4, 4)

            _UPCBoxUnit2 = New UPComboBox("unit", _ColumnNames3, "Unidad", True, _dicValuesFilterUnit)
            If _UPCBoxUnit2.Items.Count > 0 Then
                _UPCBoxUnit2.SelectedIndex = 1
            End If
        Else
            Dim _ColumnNames3 As New List(Of String)
            _ColumnNames3.Add("symbolUnit")

            Dim _dicValuesFilterUnit As New JObject()
            _dicValuesFilterUnit("id") = 2


            _UPCBoxUnit = New UPComboBox("unit", _ColumnNames3, "Unidad", True, _dicValuesFilterUnit)
            If _UPCBoxUnit.Items.Count > 0 Then
                _UPCBoxUnit.SelectedIndex = 0
            End If

            _UPCBoxUnit.Margin = New System.Windows.Forms.Padding(8, 0, 4, 4)

            _UPCBoxUnit2 = New UPComboBox("unit", _ColumnNames3, "Unidad", True, _dicValuesFilterUnit)
            If _UPCBoxUnit2.Items.Count > 0 Then
                _UPCBoxUnit2.SelectedIndex = 0
            End If

        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDateTimePicker Fecha
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDateTimePicker = New UPDateTimePicker()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Númerico (Precio)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtBoxNumerico1 = New UPTextBoxNumerico(0, Double.NaN)
        _UPTxtBoxNumerico1.Padding = New Padding(20, 0, 0, 0)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListEquipment.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListEquipment.Controls.Add(_UPCBoxDataSourceInput, 0, 1)
        Me.tlpListEquipment.Controls.Add(_UPCBoxEquipmentTypeList, 0, 2)
        Me.tlpListEquipment.Controls.Add(_UPDGViewList, 0, 5)

        Me.tlpEquipmentLook.Controls.Add(_UPTxtequipmentCostPyOUserFilter, 0, 0)

        Me.tlpListUnit.Controls.Add(_UPlbl6, 0, 0)
        Me.tlpListUnit.Controls.Add(_UPCBoxUnit, 1, 0)

        Me.tlpEquipmentEdition.Controls.Add(_UPlbl7, 0, 0)

        Me.tlpEquipmentEdition2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEquipmentEdition2.Controls.Add(_UPlbl2, 0, 2)
        Me.tlpEquipmentEdition2.Controls.Add(_UPlbl3, 0, 3)
        Me.tlpEquipmentEdition2.Controls.Add(_UPlbl4, 0, 1)

        'Me.tlpEquipmentEdition2.Controls.Add(_UPCBoxCodigoNombre, 1, 0)
        Me.tlpEquipmentEdition2.Controls.Add(_UPCTBoxCodigoNombre, 1, 0)
        Me.tlpEquipmentEdition2.Controls.Add(_UPCBoxUnit2, 1, 2)
        Me.tlpEquipmentEdition2.Controls.Add(_UPDateTimePicker, 1, 3)

        Me.TableLayoutPanel1.Controls.Add(_UPTxtBoxNumerico1, 0, 0)

        btnGuardar1.Enabled = False
        EnableControls(False)
        _IsInitialize = False
        _UPDGViewList.SetSelectedItem(0)

        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnProjectSeletedChnge 'Preguntar a daniel

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
    '---------
    Public ReadOnly Property equipmentTypeId As Int32
        Get
            Return _UPCBoxEquipmentTypeList.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _UPCBoxDataSourceInput.GetSelectedItemId()
        End Get
    End Property

    Public Function Validate1() As Boolean
        If Double.IsNaN(_UPTxtBoxNumerico1.Value) Then
            MessageBox.Show("Requiere un valor para el precio unitarios XXXXX", "xxxxxxx", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub LoadBoxUnits()
        If Not IsPartidaARG Then
            Dim _ColumnNames3 As New List(Of String)
            _ColumnNames3.Add("symbolUnit")

            Dim _dicValuesFilterUnit As New JObject()
            _dicValuesFilterUnit("unitEquipment") = True
            _dicValuesFilterUnit("moneyType_Id") = ProjectMoneyTypeid

            _UPCBoxUnit.ReLoad(_dicValuesFilterUnit)
            _UPCBoxUnit.SelectedIndex = 0

            _UPCBoxUnit2.ReLoad(_dicValuesFilterUnit)
            _UPCBoxUnit2.SelectedIndex = 0

        Else
            Dim _ColumnNames3 As New List(Of String)
            _ColumnNames3.Add("symbolUnit")

            Dim _dicValuesFilterUnit As New JObject()
            _dicValuesFilterUnit("id") = 2


            _UPCBoxUnit.ReLoad(_dicValuesFilterUnit)
            _UPCBoxUnit.SelectedIndex = 0

            _UPCBoxUnit2.ReLoad(_dicValuesFilterUnit)
            _UPCBoxUnit2.SelectedIndex = 0
        End If

        _UPlbl4.Text = $"Precio ({ProjectSymbolMoneyType})"
    End Sub


    'Private Sub OnSetTextPrecio()
    '    vbAbort\ $"Precio ({ProjectSymbolMoneyType})"
    'End Sub

    Private Sub EnableControls(ByVal Enabled As Boolean)

        _UPCBoxCodigoNombre.Enabled = Enabled
        _UPCBoxUnit2.Enabled = Enabled
        _UPDateTimePicker.Enabled = Enabled
        _UPTxtBoxNumerico1.Enabled = Enabled
        _UPCTBoxCodigoNombre.Enabled = Enabled
        SetEnableButonEqmtPrice()

    End Sub

    Private Sub LoadPriceEquipmentSelect()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames2 As New List(Of String)

            Dim _dicValuesFilter2 As New JObject()
            _dicValuesFilter2("equipment_id") = selectedId
            _dicValuesFilter2("unit_id") = _UPCBoxUnit.GetSelectedItemId()
            _dicValuesFilter2("project_id") = ProjectSelectedId

            Dim _SelectMax As String = "dateUser"

            Dim _datatable3 As DataTable = GetDataTable("equipmentCostPyOUser", ColumnNames:=_ColumnNames2,
                                                       dicValuesFilter:=_dicValuesFilter2, SelectMax:=_SelectMax)


            If _datatable3.Rows.Count > 0 Then

                _UPCBoxCodigoNombre.SetSelectedItem(_datatable3.Rows(0)("equipment_id"))
                _UPCBoxUnit2.SetSelectedItem(_datatable3.Rows(0)("unit_id"))
                _UPDateTimePicker.Value = _datatable3.Rows(0)("dateUser")
                _UPTxtBoxNumerico1.Value = _datatable3.Rows(0)("price")
                _equipmentCostPyOUser_Id = _datatable3.Rows(0)("Id")

                _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text

                '-------------------
                'EqmtPriceEst
                '-------------------
                _equipmentPriceEstimate_Id = _datatable3.Rows(0)("equipmentPriceEstimate_Id")

                If _equipmentPriceEstimate_Id > 0 Then
                    Dim _ColumnNames5 As New List(Of String)

                    Dim _dicValuesFilter5 As New JObject()
                    _dicValuesFilter5("id") = _equipmentPriceEstimate_Id

                    Dim _datatable5 As DataTable = GetDataTable("equipmentPriceEstimate", ColumnNames:=_ColumnNames5,
                                                               dicValuesFilter:=_dicValuesFilter5)

                    _dicValuesEqmtPriceEst = New JObject()

                    _dicValuesEqmtPriceEst("eqmtPricDate") = CType(_datatable5.Rows(0)("eqmtPricDate"), DateTime)
                    _dicValuesEqmtPriceEst("eqmtPricName") = CType(_datatable5.Rows(0)("eqmtPricName"), String)
                    _dicValuesEqmtPriceEst("eqmtPricDescrip") = CType(_datatable5.Rows(0)("eqmtPricDescrip"), String)

                    _dicValuesEqmtPriceEst("eqmtPriceEstType_id") = CType(_datatable5.Rows(0)("eqmtPriceEstType_id"), Int32)
                    ' _dicValuesEqmtPriceEst("quantityLabour") = CType(_datatable5.Rows(0)("quantityLabour"), Double)
                    _dicValuesEqmtPriceEst("equipmentPriceNew") = CType(_datatable5.Rows(0)("equipmentPriceNew"), Double)
                    _dicValuesEqmtPriceEst("equipmentUsefulLife") = CType(_datatable5.Rows(0)("equipmentUsefulLife"), Double)
                    _dicValuesEqmtPriceEst("equipmentUseTime") = CType(_datatable5.Rows(0)("equipmentUseTime"), Double)
                    _dicValuesEqmtPriceEst("equipmentSalvageValue") = CType(_datatable5.Rows(0)("equipmentSalvageValue"), Double)
                    _dicValuesEqmtPriceEst("equipmentInterestRate") = CType(_datatable5.Rows(0)("equipmentInterestRate"), Double)
                    _dicValuesEqmtPriceEst("equipmentInsurance") = CType(_datatable5.Rows(0)("equipmentInsurance"), Double)
                    _dicValuesEqmtPriceEst("equipmentTax") = CType(_datatable5.Rows(0)("equipmentTax"), Double)
                    _dicValuesEqmtPriceEst("equipmentCustodyHour") = CType(_datatable5.Rows(0)("equipmentCustodyHour"), Double)
                    _dicValuesEqmtPriceEst("equipmentMajorRepairs") = CType(_datatable5.Rows(0)("equipmentMajorRepairs"), Double)
                    _dicValuesEqmtPriceEst("equipmentMaintenanceFactor") = CType(_datatable5.Rows(0)("equipmentMaintenanceFactor"), Double)
                    _dicValuesEqmtPriceEst("equipmentWorkshopSpareParts") = CType(_datatable5.Rows(0)("equipmentWorkshopSpareParts"), Double)
                    _dicValuesEqmtPriceEst("equipmentHp") = CType(_datatable5.Rows(0)("equipmentHp"), Double)
                    _dicValuesEqmtPriceEst("equipmentOperationFactor") = CType(_datatable5.Rows(0)("equipmentOperationFactor"), Double)
                    _dicValuesEqmtPriceEst("equipmentFuel") = CType(_datatable5.Rows(0)("equipmentFuel"), Double)
                    _dicValuesEqmtPriceEst("equipmentFuelFactor") = CType(_datatable5.Rows(0)("equipmentFuelFactor"), Double)
                    _dicValuesEqmtPriceEst("equipmentOtherEnergySources") = CType(_datatable5.Rows(0)("equipmentOtherEnergySources"), Double)
                    _dicValuesEqmtPriceEst("equipmentCrankcaseCap") = CType(_datatable5.Rows(0)("equipmentCrankcaseCap"), Double)
                    _dicValuesEqmtPriceEst("equipmentLubricant") = CType(_datatable5.Rows(0)("equipmentLubricant"), Double)
                    _dicValuesEqmtPriceEst("equipmentLubricantPrice") = CType(_datatable5.Rows(0)("equipmentLubricantPrice"), Double)
                    _dicValuesEqmtPriceEst("equipmentLubricantTime") = CType(_datatable5.Rows(0)("equipmentLubricantTime"), Double)
                    _dicValuesEqmtPriceEst("equipmentLubricantFactor") = CType(_datatable5.Rows(0)("equipmentLubricantFactor"), Double)
                    _dicValuesEqmtPriceEst("equipmentTiresPrice") = CType(_datatable5.Rows(0)("equipmentTiresPrice"), Double)
                    _dicValuesEqmtPriceEst("equipmentTiresNumber") = CType(_datatable5.Rows(0)("equipmentTiresNumber"), Double)
                    _dicValuesEqmtPriceEst("equipmentTiresHour") = CType(_datatable5.Rows(0)("equipmentTiresHour"), Double)
                    _dicValuesEqmtPriceEst("equipmentTiresUsefulLife") = CType(_datatable5.Rows(0)("equipmentTiresUsefulLife"), Double)
                    _dicValuesEqmtPriceEst("equipmentLabor") = CType(_datatable5.Rows(0)("equipmentLabor"), Double)
                    _dicValuesEqmtPriceEst("equipmentWearElements") = CType(_datatable5.Rows(0)("equipmentWearElements"), Double)
                    _dicValuesEqmtPriceEst("equipmentFuelPrice") = CType(_datatable5.Rows(0)("equipmentFuelPrice"), Double)
                    _dicValuesEqmtPriceEst("equipmentSpecialPices") = CType(_datatable5.Rows(0)("equipmentSpecialPices"), Double)
                    _dicValuesEqmtPriceEst("equipmentStore") = CType(_datatable5.Rows(0)("equipmentStore"), Double)


                Else
                    _equipmentPriceEstimate_Id = -1
                    _dicValuesEqmtPriceEst = Nothing


                End If

            Else
                _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
                _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
                _UPDateTimePicker.Value = Now()
                _UPTxtBoxNumerico1.Value = Nothing
                _equipmentCostPyOUser_Id = -1

                '_equipmentPriceEstimate_Id
                _equipmentPriceEstimate_Id = -1
                _dicValuesEqmtPriceEst = Nothing
                _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text

            End If

            '_selectedEquipmentType_id

            Dim _ColumnNames4 As New List(Of String)
            _ColumnNames4.Add("equipmentType_id")


            Dim _dicValuesFilter4 As New JObject()
            _dicValuesFilter4("id") = selectedId


            Dim _datatable4 As DataTable = GetDataTable("equipment", ColumnNames:=_ColumnNames4,
                                           dicValuesFilter:=_dicValuesFilter4)

            _selectedEquipmentType_id = _datatable4.Rows(0)("equipmentType_id")

        End If

        SetEnableButonEqmtPrice()

    End Sub

    Private Sub ReloadEquipment()

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("isAtomic") = True

        If appDataSourceInputId > 0 Then
            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        End If

        If equipmentTypeId > 0 Then
            _dicValuesFilter("equipmentType_id") = equipmentTypeId
        End If

        _UPDGViewList.ReLoadData(_dicValuesFilter, True)

    End Sub

    Private Sub OnProjectSeletedChnge(sender As Object, e As EventArgs)

        LoadBoxUnits()
        LoadPriceEquipmentSelect()

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged
        LoadPriceEquipmentSelect()
        EnableControls(False)

        If Not _IsGuardando Then
            btnGuardar1.Enabled = False
        End If
        _IsEdit = False
        _IsNewSupply = False
        SetEnableButonEqmtPrice()
        'ResetEqmtPriceEst()
    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply
        '_UPDGViewList.LoadList()
        btnGuardar1.Enabled = True
        EnableControls(True)
        Me._UPTxtBoxNumerico1.Focus()
        _IsEdit = True
        _IsNewSupply = False
    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        _dicValuesEqmtPriceEst = Nothing

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

        _IsEdit = False
        _IsNewSupply = True
        Me._UPTxtBoxNumerico1.Focus()
        btnGuardar1.Enabled = True
        EnableControls(True)
        SetEnableButonEqmtPrice()

    End Sub

    Private Sub _UPCBoxUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxUnit.SelectedIndexChanged
        LoadPriceEquipmentSelect()
    End Sub

    Private Sub _UPDGViewList_EvDeleteSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvDeleteSupply

        If selectedId > 0 AndAlso _equipmentCostPyOUser_Id > 0 Then
            GetDelete("materialPrice", _equipmentCostPyOUser_Id)
        End If
    End Sub

    Private Sub FormequipmentCostPyOUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        splitContEquipment.SplitterDistance = 440

        splitContEquipment.Panel1MinSize = 220
        splitContEquipment.Panel2MinSize = 330

        Dim toolTipEquipment As New ToolTip()
        toolTipEquipment.AutoPopDelay = 5000
        toolTipEquipment.InitialDelay = 1000
        toolTipEquipment.ReshowDelay = 500
        toolTipEquipment.ShowAlways = True

        toolTipEquipment.SetToolTip(Me.btnEquipmentFilter, "Busca el Equipo")
        toolTipEquipment.SetToolTip(Me.btnDataSource, "Ir a Origen de Datos")
        toolTipEquipment.SetToolTip(Me.btnGuardar1, "Guardar Precio")
        toolTipEquipment.SetToolTip(Me._UPCBoxDataSourceInput, "Origen de Datos")
        toolTipEquipment.SetToolTip(Me._UPCBoxDataSourceInput, "Origen de Datos")
        toolTipEquipment.SetToolTip(Me._UPTxtequipmentCostPyOUserFilter, "Filtro Dinámico Equipos")

    End Sub

    Private Sub FormEquipmentCostPyOUser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me._UPTxtBoxNumerico1.TabIndex = 0
        Me._UPCBoxUnit2.TabIndex = 1
        Me._UPDateTimePicker.TabIndex = 2
        Me.btnGuardar1.TabIndex = 3
        Me.btnEquipmentType.TabIndex = 6
        Me.btnDataSource.TabIndex = 7
        Me.btnequipmentCostPyOUserList.TabIndex = 8
        Me.btnReportequipmentCostPyOUserList.TabIndex = 9
        Me.btnEqmtPriceEst.TabIndex = 4
        Me.btnEqmtPriceEstReset.TabIndex = 5
    End Sub
#Region "Button"

    'Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

    '    If Validate1() Then

    '        _IsGuardando = True

    '        Dim _DataServices As New JArray()

    '        Dim _dicValues As New JObject()

    '        _dicValues("equipment_id") = _UPCBoxCodigoNombre.GetSelectedItemId()

    '        If IsPartidaARG Then
    '            _dicValues("unit_id") = 2
    '        Else
    '            _dicValues("unit_id") = _UPCBoxUnit2.GetSelectedItemId()
    '        End If

    '        _dicValues("dateUser") = CType(_UPDateTimePicker.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
    '        _dicValues("price") = GetNotNulDouble(_UPTxtBoxNumerico1.Value)
    '        _dicValues("project_id") = ProjectSelectedId

    '        _DataServices.Add(_dicValues)

    '        If _IsEdit Then

    '            Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
    '            _dicValues("id") = selectedId

    '            If GetUpdateTable("equipmentCostPyOUser", _DataServices) IsNot Nothing Then
    '                '_UPDGViewList.LoadList()
    '                '_UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

    '                ReloadEquipment()
    '                _UPDGViewList.SetSelectedItem(_SelectedIndex)
    '                MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '                _IsEdit = False
    '                EnableControls(False)
    '                btnGuardar1.Enabled = False

    '            Else
    '                MessageBox.Show("ERROR !!! Revisar")
    '            End If
    '        Else

    '            Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index '30/01
    '            _dicValues("id") = selectedId

    '            If _dicValuesEqmtPriceEst IsNot Nothing Then
    '                Dim _DataServices1 As New JArray()
    '                _DataServices1.Add(_dicValuesEqmtPriceEst)

    '                _equipmentPriceEstimate_Id = GetInsertTable("equipmentPriceEstimate", _DataServices1)

    '                If _equipmentPriceEstimate_Id > 0 Then

    '                    _DataServices(0)("equipmentPriceEstimate_Id") = _equipmentPriceEstimate_Id
    '                Else
    '                    MessageBox.Show("ERROR !!! Revisar")
    '                    Exit Sub
    '                End If
    '            End If

    '            If GetInsertTable("equipmentCostPyOUser", _DataServices) > 0 Then
    '                'ReloadEquipment()
    '                _UPDGViewList.LoadList()
    '                _UPDGViewList.SetSelectedItem(_SelectedIndex)
    '                '_UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
    '                _IsEdit = False
    '                EnableControls(False)
    '                MessageBox.Show("Precio guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                btnGuardar1.Enabled = False

    '                _equipmentPriceEstimate_Id = -1 'deactivado 30/01
    '                _dicValuesEqmtPriceEst = Nothing

    '                SetEnableButonEqmtPrice()
    '            Else
    '                MessageBox.Show("ERROR !!! Revisar")
    '            End If
    '        End If

    '        _IsGuardando = False

    '    End If

    '    Me._UPTxtequipmentCostPyOUserFilter.Clear()
    'End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        If Validate1() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()

            _dicValues("equipment_id") = _UPCBoxCodigoNombre.GetSelectedItemId()
            If IsPartidaARG Then
                _dicValues("unit_id") = 2
            Else
                _dicValues("unit_id") = _UPCBoxUnit2.GetSelectedItemId()
            End If

            _dicValues("dateUser") = CType(_UPDateTimePicker.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("price") = GetNotNulDouble(_UPTxtBoxNumerico1.Value)
            _dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("equipmentCostPyOUser", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar1.Enabled = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else

                If _dicValuesEqmtPriceEst IsNot Nothing Then
                    Dim _DataServices1 As New JArray()
                    _DataServices1.Add(_dicValuesEqmtPriceEst)

                    _equipmentPriceEstimate_Id = GetInsertTable("equipmentPriceEstimate", _DataServices1)

                    If _equipmentPriceEstimate_Id > 0 Then

                        _DataServices(0)("equipmentPriceEstimate_Id") = _equipmentPriceEstimate_Id
                    Else
                        MessageBox.Show("ERROR !!! Revisar")
                        Exit Sub
                    End If
                End If

                If GetInsertTable("equipmentCostPyOUser", _DataServices) > 0 Then
                    '_UPDGViewList.LoadList()
                    '_UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Precio guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar1.Enabled = False

                    _equipmentPriceEstimate_Id = -1
                    _dicValuesEqmtPriceEst = Nothing

                    SetEnableButonEqmtPrice()
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

        Me._UPTxtequipmentCostPyOUserFilter.Clear()
    End Sub



    Private Sub btnEquipmentFilter_Click(sender As Object, e As EventArgs) Handles btnEquipmentFilter.Click
        _UPDGViewList.FilterList(_UPTxtequipmentCostPyOUserFilter.Text)
    End Sub

    Private Sub _UPTxtequipmentCostPyOUserFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtequipmentCostPyOUserFilter.TextChanged

        _UPDGViewList.FilterList(_UPTxtequipmentCostPyOUserFilter.Text)

    End Sub

    Private Sub _UPCBoxDataSourceInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInput.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadEquipment()
            LoadPriceEquipmentSelect() ' yo 22/08/24
            _UPTxtequipmentCostPyOUserFilter.Text = ""
        End If
    End Sub

    Private Sub _UPCBoxEquipmentTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxEquipmentTypeList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadEquipment()
            LoadPriceEquipmentSelect() ' yo 22/08/24
            _UPTxtequipmentCostPyOUserFilter.Text = ""
        End If
    End Sub

    Private Sub _UPDGViewList_DoubleClick(sender As Object, e As EventArgs) Handles _UPDGViewList.DoubleClick
        If HasSelectedItem Then
            _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing

        Else
            _UPCBoxCodigoNombre.SetSelectedItem(1)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing
        End If

        btnGuardar1.Enabled = True
        EnableControls(True)
    End Sub


#End Region

    Private Sub btnDataSource_Click(sender As Object, e As EventArgs) Handles btnDataSource.Click
        Dim _FormAppDataSource As New FormDataSourceInput()
        _FormAppDataSource.ShowDialog()
    End Sub

    Private Sub btnPriceList_Click(sender As Object, e As EventArgs) Handles btnequipmentCostPyOUserList.Click
        Dim _FormequipmentCostPyOUserList As New FormequipmentCostPyOUserList()
        _FormequipmentCostPyOUserList.ShowDialog()
    End Sub

    Private Sub btnEqmtPriceEstReset_Click(sender As Object, e As EventArgs) Handles btnEqmtPriceEstReset.Click
        ResetEqmtPriceEst()
    End Sub

#Region "EqmtPriceEst"

    Public Sub SetEnableButonEqmtPrice()
        If IsPartidaARG Then
            btnEqmtPriceEstReset.Enabled = False
            btnEqmtPriceEst.Enabled = False
        Else
            If _IsEdit Then
                btnEqmtPriceEstReset.Enabled = False
                btnEqmtPriceEst.Enabled = False
            ElseIf _IsNewSupply Then
                btnEqmtPriceEstReset.Enabled = True
                btnEqmtPriceEst.Enabled = True
            Else
                btnEqmtPriceEstReset.Enabled = False
                btnEqmtPriceEst.Enabled = _equipmentPriceEstimate_Id > 0
            End If
        End If

    End Sub

    Private Sub ResetEqmtPriceEst()

        _UPTxtBoxNumerico1.Enabled = True
        _equipmentPriceEstimate_Id = -1
        _dicValuesEqmtPriceEst = Nothing
    End Sub

    Private Sub btnEqmtPriceEst_Click_1(sender As Object, e As EventArgs) Handles btnEqmtPriceEst.Click

        _UPTxtBoxNumerico1.Enabled = False

        Dim _IsShowGuardar As Boolean = True
        Dim _DisplayType As EnumDisplayType
        Dim _EquipmentType_id As Int32

        If _IsEdit Then
            _DisplayType = EnumDisplayType.Edit
            _EquipmentType_id = _selectedEquipmentType_id

        ElseIf _IsNewSupply Then
            _DisplayType = EnumDisplayType.New
            _EquipmentType_id = equipmentTypeId
        Else
            _DisplayType = EnumDisplayType.Display
            _EquipmentType_id = _selectedEquipmentType_id
        End If

        Dim _FomEqmtPriceEst As New FomEqmtPriceEst(_EquipmentType_id, _DisplayType, selectedsupplyName,
                                                    _dicValuesEqmtPriceEst)
        If _FomEqmtPriceEst.ShowDialog() = DialogResult.OK Then

            Select Case _DisplayType
                Case EnumDisplayType.Display
                Case EnumDisplayType.Edit
                    _dicValuesEqmtPriceEst = _FomEqmtPriceEst.dicValuesEqmtPriceEst

                    If _UPCBoxUnit2.GetSelectedItemId() = 37 Then
                        _UPTxtBoxNumerico1.Value = _FomEqmtPriceEst.EquitmentPriceResult

                    Else
                        _UPTxtBoxNumerico1.Value = _FomEqmtPriceEst.EquitmentPriceResult * ProjectHorasPerDay
                    End If

                Case EnumDisplayType.New
                    _dicValuesEqmtPriceEst = _FomEqmtPriceEst.dicValuesEqmtPriceEst

                    If _UPCBoxUnit2.GetSelectedItemId() = 37 Then
                        _UPTxtBoxNumerico1.Value = _FomEqmtPriceEst.EquitmentPriceResult

                    Else
                        _UPTxtBoxNumerico1.Value = _FomEqmtPriceEst.EquitmentPriceResult * ProjectHorasPerDay
                    End If

                    '_UPTxtBoxNumerico1.Value = _FomEqmtPriceEst.EquitmentPriceResult
            End Select
        Else
            If Not _DisplayType = EnumDisplayType.Display Then
                ResetEqmtPriceEst()
                _IsShowGuardar = False
            End If

        End If

        If _IsShowGuardar AndAlso Not _DisplayType = EnumDisplayType.Display Then

            If MessageBox.Show("quiere guardar?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                btnGuardar1_Click(Nothing, New EventArgs)
                ResetEqmtPriceEst()
                LoadPriceEquipmentSelect()
            End If

        End If
    End Sub


#End Region


#Region "Bordes Botones"


    Private Sub btnDataSource_MouseEnter(sender As Object, e As EventArgs) Handles btnDataSource.MouseEnter
        btnDataSource.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnDataSource_MouseLeave(sender As Object, e As EventArgs) Handles btnDataSource.MouseLeave
        btnDataSource.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnGuardar1_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar1.MouseEnter
        btnGuardar1.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnGuardar1_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar1.MouseLeave
        btnGuardar1.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnequipmentCostPyOUserList_MouseEnter(sender As Object, e As EventArgs) Handles btnequipmentCostPyOUserList.MouseEnter
        btnequipmentCostPyOUserList.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnequipmentCostPyOUserList_MouseLeave(sender As Object, e As EventArgs) Handles btnequipmentCostPyOUserList.MouseLeave
        btnequipmentCostPyOUserList.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnReportequipmentCostPyOUserList_MouseEnter(sender As Object, e As EventArgs) Handles btnReportequipmentCostPyOUserList.MouseEnter
        btnReportequipmentCostPyOUserList.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReportequipmentCostPyOUserList_MouseLeave(sender As Object, e As EventArgs) Handles btnReportequipmentCostPyOUserList.MouseLeave
        btnReportequipmentCostPyOUserList.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnEqmtPriceEst_MouseEnter(sender As Object, e As EventArgs) Handles btnEqmtPriceEst.MouseEnter
        btnEqmtPriceEst.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnEqmtPriceEst_MouseLeave(sender As Object, e As EventArgs) Handles btnEqmtPriceEst.MouseLeave
        btnEqmtPriceEst.FlatAppearance.BorderSize = 0
    End Sub

#End Region

End Class

