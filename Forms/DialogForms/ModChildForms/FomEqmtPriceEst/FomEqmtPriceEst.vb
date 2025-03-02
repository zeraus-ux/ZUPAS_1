Imports System.Windows.Media
Imports Microsoft.Reporting.WinForms
Imports Newtonsoft.Json.Linq
Imports FontAwesome.Sharp

Public Class FomEqmtPriceEst

    Private WithEvents _UPEqmtPricDate As UPDateTimePicker
    Private WithEvents _UPTxtEqmtPricName As UPTextBox
    Private WithEvents _UPTxtEqmtPricDescrip As UPTextBox
    Private WithEvents _UPCBxEqmtPriceEstType As UPComboBox

    Private _UPlbl0 As UPLabel
    Private _UPlblEqmtPriceEstType As UPLabel
    Private _UPlblEqmtPricDate As UPLabel
    Private _UPlblEqmtPricName As UPLabel
    Private _UPlblEqmtPricDescrip As UPLabel
    'Private _UPlblQuantityLabour As UPLabel

    Private _UPlblEquipmentPriceNew1 As UPLabel
    Private _UPlblEquipmentPriceNew2 As UPLabel
    Private _UPlblEquipmentPriceNew3 As UPLabel
    Private _UPlblEquipmentPriceNew4 As UPLabel
    Private _UPlblEquipmetUsefulLife As UPLabel
    Private _UPlblEquipmetUsefulLife2 As UPLabel
    Private _UPlblEquipmetUsefulLife3 As UPLabel
    Private _UPlblEquipmentUseTime As UPLabel
    Private _UPlblEquipmentUseTime3 As UPLabel
    Private _UPlblEquipmentSalvageValue As UPLabel
    Private _UPlblEquipmentInterestRate As UPLabel
    Private _UPlblEquipmentInterestRate3 As UPLabel
    Private _UPlblEquipmentInsurance As UPLabel
    Private _UPlblEquipmentInsurance3 As UPLabel
    Private _UPlblEquipmentTax As UPLabel
    Private _UPlblEquipmentCustodyHour As UPLabel
    Private _UPlblEquipmentMajorRepairs As UPLabel
    Private _UPlblEquipmentMaintenanceFactor As UPLabel
    Private _UPlblEquipmentWorkshopSpareParts As UPLabel
    Private _UPlblEquipmentHp As UPLabel
    Private _UPlblEquipmentOperationFactor As UPLabel
    Private _UPlblEquipmentFuel As UPLabel
    Private _UPlblEquipmentFuel3 As UPLabel
    Private _UPlblEquipmentFuelPrice As UPLabel
    Private _UPlblEquipmentFuelFactor As UPLabel
    Private _UPlblEquipmentFuelFactor3 As UPLabel
    Private _UPlblEquipmentcrankcaseCap As UPLabel
    Private _UPlblEquipmentLubricant As UPLabel
    Private _UPlblEquipmentLubricant3 As UPLabel
    Private _UPlblEquipmentLubricantPrice As UPLabel
    Private _UPlblEquipmentlubricantTime As UPLabel
    Private _UplblEquipmentLubricantFactor As UPLabel
    Private _UplblEquipmentLubricantFactor3 As UPLabel
    Private _UPlblequipmentOtherEnergySources As UPLabel
    Private _UPlblEquipmentTiresPrice As UPLabel
    Private _UPlblEquipmentTiresNumber As UPLabel
    Private _UPlblEquipmentTiresHour As UPLabel
    Private _UPlblEquipmentTiresUsefulLife As UPLabel
    Private _UPlblEquipmentLabor As UPLabel
    Private _UPlblEquipmentLabor3 As UPLabel
    Private _UPlblEquipmentWearElements As UPLabel
    Private _UPlblEquipmentSpecialPices As UPLabel
    Private _UPlblequipmentStore As UPLabel
    Private _UPlblequitmentCostPyO As UPLabel

    Private _UPlblTotalOwnershipCost As UPLabel
    Private _UPlblTotalOperatingCost As UPLabel
    Private _UPlblTotalHourlyCost As UPLabel
    Private _UPlblTotalPyOCost As UPLabel

    Private _UPlblEquipmentfuelType As UPLabel

    Private _UPlblFixedCost As UPLabel
    Private _UPlblOperatingCost As UPLabel
    Private _UPlblConsumptionCost As UPLabel

    Private _UPlblEquipmentFuelFactorK As UPLabel
    Private _UPlblEquipmentFuelFactorNotK As UPLabel
    Private _UPlblequipmentOtherEnergySourcesK As UPLabel

    ' Private WithEvents _UPNumQuantityLabour As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentPriceNew As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmetUsefulLife As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentUseTime As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentSalvageValue As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentInterestRate As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentInsurance As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTax As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentCustodyHour As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentMajorRepairs As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentMaintenanceFactor As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentWorkshopSpareParts As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentHp As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentOperationFactor As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentFuel As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentFuelFactor As UPTextBoxNumerico

    'Private WithEvents _UPNumEquipmentFuelPrice As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentOtherEnergySources As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentCrankcaseCap As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentLubricant As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentLubricantPrice As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentlubricantTime As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentLubricantFactor As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTiresPrice As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTiresNumber As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTiresHour As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTiresUsefulLife As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentLabor As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentWearElements As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentSpecialPices As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentStore As UPTextBoxNumerico
    Private WithEvents _UPNumequitmentCostPyO As UPTextBoxNumerico

    Private WithEvents _UPNumFixedCost As UPTextBoxNumerico
    Private WithEvents _UPNumOperatingCost As UPTextBoxNumerico
    Private WithEvents _UPNumConsumptionCost As UPTextBoxNumerico

    Private WithEvents _UPCbxEquipmentfuelType As UPComboBox

    Private WithEvents _UPCBxLabourType As UPComboBox

    Private WithEvents _UPNumOwningCost As UPTextBoxNumerico
    'Private WithEvents _UPNumOperatingCost As UPTextBoxNumerico
    Private WithEvents _UPNumMachineHourlyCost As UPTextBoxNumerico


    Private _FormReportEqmtCostOpyPoss As FormReportEqmtCostOpyPoss = Nothing

    Private _dicValuesEqmtPriceEst As JObject
    Private _EquitmentPriceResult As Double
    Private _EquipmentType_id As Int32
    Private _DisplayType As EnumDisplayType
    Private _equipment_id As Int32 = -1

    Public Sub New(ByVal EquipmentType_id As Int32, ByVal DisplayType As EnumDisplayType,
                   ByVal selectedsupplyName As String,
                   Optional dicValuesEqmtPriceEst As JObject = Nothing)

        InitializeComponent()
        Me.Text = "Precio de equipos"
        _EquipmentType_id = EquipmentType_id
        _dicValuesEqmtPriceEst = dicValuesEqmtPriceEst
        _DisplayType = DisplayType

        ' Add any initialization after the InitializeComponent() call.

        '#---------------------------------------------------------------
        ' Encabezado
        '#---------------------------------------------------------------

        _UPlbl0 = New UPLabel("A n á l i s i s  de  C o s t o  H o r a r i o")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlblEqmtPricDate = New UPLabel("Fecha")
        _UPlblEqmtPricName = New UPLabel("Nombre del Equipo")
        _UPlblEqmtPricDescrip = New UPLabel("Datos Adicionales")
        _UPlblEqmtPriceEstType = New UPLabel("Tipo de método de cálculo")

        _UPEqmtPricDate = New UPDateTimePicker()
        _UPTxtEqmtPricName = New UPTextBox()
        _UPTxtEqmtPricName.Text = $"{selectedsupplyName} @ {Now.ToString("yyyy-MM-dd")}"
        _UPEqmtPricDate.Enabled = False

        _UPTxtEqmtPricDescrip = New UPTextBox()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: UPCBxEqmtPriceEstType
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim _ColumnNames3 As New List(Of String)
        _ColumnNames3.Add("nameEqmtPriceEstType")

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("equipmentType_id") = _EquipmentType_id

        'Test--------------------------
        '_dicValuesFilter = Nothing
        '------------------------------

        _UPCBxEqmtPriceEstType = New UPComboBox("eqmtPriceEstType", _ColumnNames3, "EqmtPriceEstType", True,
                                                _dicValuesFilter)

        tlpEqmPriceEstHead.Controls.Add(_UPlbl0, 0, 0)

        TableLayoutPanel2.Controls.Add(_UPlblEqmtPricDate, 0, 0)
        TableLayoutPanel2.Controls.Add(_UPlblEqmtPricName, 0, 1)
        TableLayoutPanel2.Controls.Add(_UPlblEqmtPricDescrip, 0, 2)
        TableLayoutPanel2.Controls.Add(_UPlblEqmtPriceEstType, 0, 3)

        TableLayoutPanel2.Controls.Add(_UPEqmtPricDate, 1, 0)
        TableLayoutPanel2.Controls.Add(_UPTxtEqmtPricName, 1, 1)
        TableLayoutPanel2.Controls.Add(_UPTxtEqmtPricDescrip, 1, 2)
        TableLayoutPanel2.Controls.Add(_UPCBxEqmtPriceEstType, 1, 3)

        '#---------------------------------------------------------------
        ' Controles
        '#---------------------------------------------------------------

        _UPNumEquipmentPriceNew = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmetUsefulLife = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentUseTime = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentSalvageValue = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentInterestRate = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentInsurance = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTax = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentCustodyHour = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentMajorRepairs = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentMaintenanceFactor = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentWorkshopSpareParts = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentHp = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentOperationFactor = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentFuel = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentFuelFactor = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentOtherEnergySources = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentCrankcaseCap = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentLubricant = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentLubricantPrice = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentlubricantTime = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentLubricantFactor = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTiresPrice = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTiresNumber = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTiresHour = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTiresUsefulLife = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentLabor = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentWearElements = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentSpecialPices = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentStore = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumequitmentCostPyO = New UPTextBoxNumerico(0, Double.NaN)

        OnLoadtlpPossCost1()   ' Crea controles faltantes y panel especifico
        OnLoadtlpPossCost2()
        OnLoadtlpPossCost3()
        OnLoadtlpPossCost4()

        SetDicValuesControls()  ' coloca los valores existentes si existen

        OnLoadPanel()  ' hace el cambio de panel

        SetHandlerOnUPNumTextChanged()

        OnEnableDisplay() ' Completar esta funcion

        scEqmtPriceEst.Panel2Collapsed = True

        _equipment_id = equipment_Id
    End Sub

    Public ReadOnly Property dicValuesEqmtPriceEst As JObject
        Get
            Return _dicValuesEqmtPriceEst
        End Get
    End Property

    Public ReadOnly Property EquitmentPriceResult As Double
        Get
            Return _EquitmentPriceResult
        End Get
    End Property

    Private Sub SetDicValues()
        _dicValuesEqmtPriceEst = New JObject()

        _dicValuesEqmtPriceEst("eqmtPriceEstType_id") = _UPCBxEqmtPriceEstType.GetSelectedItemId()

        _dicValuesEqmtPriceEst("eqmtPricDate") = CType(_UPEqmtPricDate.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
        _dicValuesEqmtPriceEst("eqmtPricName") = _UPTxtEqmtPricName.Text
        _dicValuesEqmtPriceEst("eqmtPricDescrip") = _UPTxtEqmtPricDescrip.Text

        _dicValuesEqmtPriceEst("equipmentPriceNew") = GetNotNulDouble(_UPNumEquipmentPriceNew.Value)
        _dicValuesEqmtPriceEst("equipmentUsefulLife") = GetNotNulDouble(_UPNumEquipmetUsefulLife.Value)
        _dicValuesEqmtPriceEst("equipmentUseTime") = GetNotNulDouble(_UPNumEquipmentUseTime.Value)
        _dicValuesEqmtPriceEst("equipmentSalvageValue") = GetNotNulDouble(_UPNumEquipmentSalvageValue.Value)
        _dicValuesEqmtPriceEst("equipmentInterestRate") = GetNotNulDouble(_UPNumEquipmentInterestRate.Value)
        _dicValuesEqmtPriceEst("equipmentInsurance") = GetNotNulDouble(_UPNumEquipmentInsurance.Value)
        _dicValuesEqmtPriceEst("equipmentTax") = GetNotNulDouble(_UPNumEquipmentTax.Value)
        _dicValuesEqmtPriceEst("equipmentCustodyHour") = GetNotNulDouble(_UPNumEquipmentCustodyHour.Value)
        _dicValuesEqmtPriceEst("equipmentMajorRepairs") = GetNotNulDouble(_UPNumEquipmentMajorRepairs.Value)
        _dicValuesEqmtPriceEst("equipmentMaintenanceFactor") = GetNotNulDouble(_UPNumEquipmentMaintenanceFactor.Value)
        _dicValuesEqmtPriceEst("equipmentWorkshopSpareParts") = GetNotNulDouble(_UPNumEquipmentWorkshopSpareParts.Value)
        _dicValuesEqmtPriceEst("equipmentHp") = GetNotNulDouble(_UPNumEquipmentHp.Value)
        _dicValuesEqmtPriceEst("equipmentOperationFactor") = GetNotNulDouble(_UPNumEquipmentOperationFactor.Value)
        _dicValuesEqmtPriceEst("equipmentFuel") = GetNotNulDouble(_UPNumEquipmentFuel.Value)
        _dicValuesEqmtPriceEst("equipmentFuelFactor") = GetNotNulDouble(_UPNumEquipmentFuelFactor.Value)

        _dicValuesEqmtPriceEst("equipmentCrankcaseCap") = GetNotNulDouble(_UPNumEquipmentCrankcaseCap.Value)
        _dicValuesEqmtPriceEst("equipmentLubricant") = GetNotNulDouble(_UPNumEquipmentLubricant.Value)
        _dicValuesEqmtPriceEst("equipmentLubricantPrice") = GetNotNulDouble(_UPNumEquipmentLubricantPrice.Value)
        _dicValuesEqmtPriceEst("equipmentlubricantTime") = GetNotNulDouble(_UPNumEquipmentlubricantTime.Value)
        _dicValuesEqmtPriceEst("equipmentLubricantFactor") = GetNotNulDouble(_UPNumEquipmentLubricantFactor.Value)
        _dicValuesEqmtPriceEst("equipmentOtherEnergySources") = GetNotNulDouble(_UPNumEquipmentOtherEnergySources.Value)
        _dicValuesEqmtPriceEst("equipmentTiresPrice") = GetNotNulDouble(_UPNumEquipmentTiresPrice.Value)
        _dicValuesEqmtPriceEst("equipmentTiresNumber") = GetNotNulDouble(_UPNumEquipmentTiresNumber.Value)
        _dicValuesEqmtPriceEst("equipmentTiresHour") = GetNotNulDouble(_UPNumEquipmentTiresHour.Value)
        _dicValuesEqmtPriceEst("equipmentTiresUsefulLife") = GetNotNulDouble(_UPNumEquipmentTiresUsefulLife.Value)
        _dicValuesEqmtPriceEst("equipmentLabor") = GetNotNulDouble(_UPNumEquipmentLabor.Value)
        _dicValuesEqmtPriceEst("equipmentWearElements") = GetNotNulDouble(_UPNumEquipmentWearElements.Value)
        _dicValuesEqmtPriceEst("equipmentSpecialPices") = GetNotNulDouble(_UPNumEquipmentSpecialPices.Value)
        _dicValuesEqmtPriceEst("equipmentStore") = GetNotNulDouble(_UPNumEquipmentStore.Value)
        _dicValuesEqmtPriceEst("EquitmentCostPyO") = GetNotNulDouble(_UPNumEquitmentCostPyO.Value)

        Select Case EqmtPriceEstType
            Case EnumEqmtPriceEstType.Maquinaria1
                _EquitmentPriceResult = machineHourlyCost1()

            Case EnumEqmtPriceEstType.Maquinaria2
                _EquitmentPriceResult = machineHourlyCost2()

            Case EnumEqmtPriceEstType.Maquinaria3
                _EquitmentPriceResult = machineHourlyCost3()

            Case EnumEqmtPriceEstType.Maquinaria4
                _EquitmentPriceResult = machineHourlyCost4()

            Case EnumEqmtPriceEstType.Herramienta1
                _EquitmentPriceResult = machineHourlyCost2()

        End Select

    End Sub

    Private Sub SetDicValuesDefault()

        _UPNumEquipmentPriceNew.Value = Nothing
        _UPNumEquipmetUsefulLife.Value = 10000
        _UPNumEquipmentUseTime.Value = 2000
        _UPNumEquipmentSalvageValue.Value = 10
        _UPNumEquipmentInterestRate.Value = 5
        _UPNumEquipmentInsurance.Value = 3
        _UPNumEquipmentTax.Value = 0
        _UPNumEquipmentCustodyHour.Value = 0
        _UPNumEquipmentMajorRepairs.Value = 0
        _UPNumEquipmentMaintenanceFactor.Value = 0.8
        _UPNumEquipmentWorkshopSpareParts.Value = 0
        _UPNumEquipmentHp.Value = Nothing
        _UPNumEquipmentOperationFactor.Value = 0.7
        _UPNumEquipmentFuel.Value = 1
        _UPNumEquipmentFuelFactor.Value = 0.2

        _UPNumEquipmentCrankcaseCap.Value = Nothing
        _UPNumEquipmentLubricant.Value = 1
        _UPNumEquipmentLubricantPrice.Value = 1
        _UPNumEquipmentlubricantTime.Value = 1
        _UPNumEquipmentLubricantFactor.Value = 0.003
        _UPNumEquipmentOtherEnergySources.Value = 1
        _UPNumEquipmentTiresPrice.Value = 1
        _UPNumEquipmentTiresNumber.Value = 4
        _UPNumEquipmentTiresHour.Value = 1
        _UPNumEquipmentTiresUsefulLife.Value = 1
        _UPNumEquipmentLabor.Value = 1
        _UPNumEquipmentWearElements.Value = 1
        _UPNumEquipmentSpecialPices.Value = 0
        _UPNumEquipmentStore.Value = 0

        _UPCbxEquipmentfuelType.SetSelectedItem(1)

    End Sub

    Private Sub SetDicValuesControls()

        If _dicValuesEqmtPriceEst IsNot Nothing Then

            _UPCBxEqmtPriceEstType.SetSelectedItem(CType(_dicValuesEqmtPriceEst("eqmtPriceEstType_id"), Int32))

            _UPEqmtPricDate.Value = CType(_dicValuesEqmtPriceEst("eqmtPricDate"), DateTime)
            _UPTxtEqmtPricName.Text = _dicValuesEqmtPriceEst("eqmtPricName")
            _UPTxtEqmtPricDescrip.Text = _dicValuesEqmtPriceEst("eqmtPricDescrip")

            _UPNumEquipmentPriceNew.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentPriceNew"))
            _UPNumEquipmetUsefulLife.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentUsefulLife"))
            _UPNumEquipmentUseTime.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentUseTime"))
            _UPNumEquipmentSalvageValue.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentSalvageValue"))
            _UPNumEquipmentInterestRate.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentInterestRate"))
            _UPNumEquipmentInsurance.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentInsurance"))
            _UPNumEquipmentTax.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentTax"))
            _UPNumEquipmentCustodyHour.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentCustodyHour"))
            _UPNumEquipmentMajorRepairs.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentMajorRepairs"))
            _UPNumEquipmentMaintenanceFactor.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentMaintenanceFactor"))
            _UPNumEquipmentWorkshopSpareParts.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentWorkshopSpareParts"))
            _UPNumEquipmentHp.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentHp"))
            _UPNumEquipmentOperationFactor.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentOperationFactor"))
            _UPNumEquipmentFuel.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentFuel"))
            _UPNumEquipmentFuelFactor.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentFuelFactor"))

            _UPNumEquipmentCrankcaseCap.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentCrankcaseCap"))
            _UPNumEquipmentLubricant.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentLubricant"))
            _UPNumEquipmentLubricantPrice.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentLubricantPrice"))
            _UPNumEquipmentlubricantTime.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentLubricantTime"))
            _UPNumEquipmentLubricantFactor.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentLubricantFactor"))
            _UPNumEquipmentOtherEnergySources.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentOtherEnergySources"))
            _UPNumEquipmentTiresPrice.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentTiresPrice"))
            _UPNumEquipmentTiresNumber.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentTiresNumber"))
            _UPNumEquipmentTiresHour.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentTiresHour"))
            _UPNumEquipmentTiresUsefulLife.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentTiresUsefulLife"))
            _UPNumEquipmentLabor.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentLabor"))
            _UPNumEquipmentWearElements.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentWearElements"))
            _UPNumEquipmentSpecialPices.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentSpecialPices"))
            _UPNumEquipmentStore.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equipmentStore"))
            _UPNumequitmentCostPyO.Value = GetNotNulJValue(_dicValuesEqmtPriceEst("equitmentCostPyO"))
        Else
            SetDicValuesDefault()

        End If
    End Sub

    Private Sub OnEnableDisplay()
        If _DisplayType = EnumDisplayType.Display Then

            _UPEqmtPricDate.Enabled = False
            _UPTxtEqmtPricName.Enabled = False
            _UPTxtEqmtPricDescrip.Enabled = False
            _UPCBxEqmtPriceEstType.Enabled = False

            _UPNumEquipmentPriceNew.Enabled = False
            _UPNumEquipmetUsefulLife.Enabled = False
            _UPNumEquipmentUseTime.Enabled = False
            _UPNumEquipmentSalvageValue.Enabled = False
            _UPNumEquipmentInterestRate.Enabled = False
            _UPNumEquipmentInsurance.Enabled = False
            _UPNumEquipmentTax.Enabled = False
            _UPNumEquipmentCustodyHour.Enabled = False
            _UPNumEquipmentMajorRepairs.Enabled = False
            _UPNumEquipmentMaintenanceFactor.Enabled = False
            _UPNumEquipmentWorkshopSpareParts.Enabled = False
            _UPNumEquipmentHp.Enabled = False
            _UPNumEquipmentOperationFactor.Enabled = False
            _UPNumEquipmentFuel.Enabled = False
            _UPNumEquipmentFuelFactor.Enabled = False
            _UPNumEquipmentOtherEnergySources.Enabled = False
            _UPNumEquipmentCrankcaseCap.Enabled = False
            _UPNumEquipmentLubricant.Enabled = False
            _UPNumEquipmentLubricantPrice.Enabled = False
            _UPNumEquipmentlubricantTime.Enabled = False
            _UPNumEquipmentLubricantFactor.Enabled = False
            _UPNumEquipmentTiresPrice.Enabled = False
            _UPNumEquipmentTiresNumber.Enabled = False
            _UPNumEquipmentTiresHour.Enabled = False
            _UPNumEquipmentTiresUsefulLife.Enabled = False
            _UPNumEquipmentLabor.Enabled = False
            _UPNumEquipmentWearElements.Enabled = False
            _UPNumEquipmentSpecialPices.Enabled = False
            _UPNumEquipmentStore.Enabled = False
            _UPNumequitmentCostPyO.Enabled = False

            _UPCbxEquipmentfuelType.Enabled = False
            _UPCBxLabourType.Enabled = False

            _IconButtonPriceLabor.Enabled = False
            _IconButtonPriceFuel.Enabled = False

            rbFuelKnown.Enabled = False
            rbFuelNotKnown.Enabled = False
            rbFuelOther.Enabled = False
        End If

    End Sub

    Private Function ValidateCalculos() As Boolean

        If Double.IsNaN(EquitmentPriceResult) OrElse EquitmentPriceResult <= 0 Then
            MessageBox.Show("NO SE HA REALIZADO CALCULO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function

#Region "Propertys"

    Public ReadOnly Property equipment_Id As Int32
        Get
            Return _equipment_id
        End Get
    End Property

    Public ReadOnly Property Labour_Id As Int32
        Get
            Return _UPCBxLabourType.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property fuelType As EnumfuelType
        Get
            Dim _EnumIndex As Integer = _UPCbxEquipmentfuelType.GetSelectedItemId() - 1
            Return GetNumeration(Of EnumfuelType)(_EnumIndex)
        End Get
    End Property

    Public ReadOnly Property eqmtPricDate As DateTime
        Get
            Return _UPEqmtPricDate.Value
        End Get
    End Property

    Public ReadOnly Property eqmtPricName As String
        Get
            Return _UPTxtEqmtPricName.Text
        End Get
    End Property

    Public ReadOnly Property eqmtPricDescrip As String
        Get
            Return _UPTxtEqmtPricDescrip.Text
        End Get
    End Property

    Public ReadOnly Property equipmentPriceNew As Double
        Get
            Return _UPNumEquipmentPriceNew.Value
        End Get
    End Property

    Public ReadOnly Property equipmentUsefulLife As Double
        Get
            Return _UPNumEquipmetUsefulLife.Value
        End Get
    End Property

    Public ReadOnly Property equipmentUseTime As Double
        Get
            Return _UPNumEquipmentUseTime.Value
        End Get
    End Property

    Public ReadOnly Property equipmentSalvageValue As Double
        Get
            Return _UPNumEquipmentSalvageValue.Value
        End Get
    End Property

    Public ReadOnly Property equipmentInterestRate As Double
        Get
            Return _UPNumEquipmentInterestRate.Value
        End Get
    End Property

    Public ReadOnly Property equipmentInsurance As Double
        Get
            Return _UPNumEquipmentInsurance.Value
        End Get
    End Property

    Public ReadOnly Property equipmentTax As Double
        Get
            Return _UPNumEquipmentTax.Value
        End Get
    End Property

    Public ReadOnly Property equipmentCustodyHour As Double
        Get
            Return _UPNumEquipmentCustodyHour.Value
        End Get
    End Property

    Public ReadOnly Property equipmentMajorRepairs As Double
        Get
            Return _UPNumEquipmentMajorRepairs.Value
        End Get
    End Property

    Public ReadOnly Property equipmentMaintenanceFactor As Double
        Get
            Return _UPNumEquipmentMaintenanceFactor.Value
        End Get
    End Property

    Public ReadOnly Property equipmentWorkshopSpareParts As Double
        Get
            Return _UPNumEquipmentWorkshopSpareParts.Value
        End Get
    End Property

    Public ReadOnly Property equipmentHp As Double
        Get
            Return _UPNumEquipmentHp.Value
        End Get
    End Property

    Public ReadOnly Property equipmentOperationFactor As Double
        Get
            Return _UPNumEquipmentOperationFactor.Value
        End Get
    End Property

    Public ReadOnly Property equipmentFuel As Double
        Get
            Return _UPNumEquipmentFuel.Value
        End Get
    End Property

    Public ReadOnly Property equipmentFuelPrice As Double
        Get
            Dim _material_id As Int32
            Dim _ReferenceDate As DateTime = eqmtPricDate
            Dim _moneyType_Id As Int32 = ProjectMoneyTypeid
            Dim _unit_id As Int32 = 29
            Select Case fuelType
                Case EnumfuelType.Diesel
                    _material_id = 3382
                Case EnumfuelType.Gasolina
                    _material_id = 3380

            End Select
            Dim _Value As Double = GetMaterialPrice(_material_id, _ReferenceDate, _moneyType_Id, _unit_id)
            Return _Value
        End Get
    End Property

    Public ReadOnly Property equipmentFuelFactor As Double
        Get
            Return _UPNumEquipmentFuelFactor.Value
        End Get
    End Property

    Public ReadOnly Property equipmentOtherEnergySources As Double
        Get
            Return _UPNumEquipmentOtherEnergySources.Value
        End Get
    End Property

    Public ReadOnly Property equipmentCrankcaseCap As Double
        Get
            Return _UPNumEquipmentCrankcaseCap.Value
        End Get
    End Property

    Public ReadOnly Property equipmentLubricant As Double
        Get
            Return _UPNumEquipmentLubricant.Value
        End Get
    End Property

    Public ReadOnly Property equipmentLubricantPrice As Double
        Get
            Return _UPNumEquipmentLubricantPrice.Value

        End Get
    End Property

    Public ReadOnly Property equipmentlubricantTime As Double
        Get
            Return _UPNumEquipmentlubricantTime.Value
        End Get
    End Property

    Public ReadOnly Property equipmentLubricantFactor As Double
        Get
            Return _UPNumEquipmentLubricantFactor.Value
        End Get
    End Property

    Public ReadOnly Property equipmentTiresPrice As Double
        Get
            Return _UPNumEquipmentTiresPrice.Value
        End Get
    End Property

    Public ReadOnly Property equipmentTiresNumber As Double
        Get
            Return _UPNumEquipmentTiresNumber.Value
        End Get
    End Property

    Public ReadOnly Property equipmentTiresHour As Double
        Get
            Return _UPNumEquipmentTiresHour.Value
        End Get
    End Property

    Public ReadOnly Property equipmentTiresUsefulLife As Double
        Get
            Return _UPNumEquipmentTiresUsefulLife.Value
        End Get
    End Property

    Public ReadOnly Property equipmentLabor As Double
        Get
            Return _UPNumEquipmentLabor.Value
        End Get
    End Property

    Public ReadOnly Property equipmentWearElements As Double
        Get
            Return _UPNumEquipmentWearElements.Value
        End Get
    End Property

    Public ReadOnly Property equipmentSpecialPices As Double
        Get
            Return _UPNumEquipmentSpecialPices.Value
        End Get
    End Property

    Public ReadOnly Property equipmentStore As Double
        Get
            Return _UPNumEquipmentStore.Value
        End Get
    End Property

    Public ReadOnly Property equitmentCostPyO As Double
        Get
            Return _UPNumequitmentCostPyO.Value
        End Get
    End Property

#End Region

#Region "Panels"

    Private _TableLayoutPanelActive As TableLayoutPanel = Nothing

#Region "Panel1"

    Private WithEvents _tlpContainerInputCIV As TableLayoutPanel
    Private WithEvents _tlpContainerCIV As TableLayoutPanel
    Private WithEvents _tlpContainerOutputCIV As TableLayoutPanel
    Private WithEvents _borderPanel As Panel
    Private WithEvents _borderPanel2 As Panel

    Private Sub OnLoadtlpPossCost1()

        Me._tlpContainerCIV = New System.Windows.Forms.TableLayoutPanel()
        Me._tlpContainerInputCIV = New System.Windows.Forms.TableLayoutPanel()
        Me._tlpContainerOutputCIV = New System.Windows.Forms.TableLayoutPanel()
        Me._borderPanel = New System.Windows.Forms.Panel()
        Me._borderPanel2 = New System.Windows.Forms.Panel()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Table Layout Panel Container Metodo 1 CIV Variables de entrada
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me._tlpContainerInputCIV.ColumnCount = 7
        Me._tlpContainerInputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me._tlpContainerInputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me._tlpContainerInputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerInputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me._tlpContainerInputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me._tlpContainerInputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerInputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me._tlpContainerInputCIV.Dock = System.Windows.Forms.DockStyle.None
        Me._tlpContainerInputCIV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                                                       Or System.Windows.Forms.AnchorStyles.Left) _
                                                                       Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._tlpContainerInputCIV.Location = New System.Drawing.Point(0, 0)
        Me._tlpContainerInputCIV.Margin = New System.Windows.Forms.Padding(0)
        Me._tlpContainerInputCIV.Name = "_tlpContainerInputCIV"
        Me._tlpContainerInputCIV.RowCount = 7
        Me._tlpContainerInputCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerInputCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerInputCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerInputCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerInputCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerInputCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerInputCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerInputCIV.Size = New System.Drawing.Size(1297, 210)
        Me._tlpContainerInputCIV.TabIndex = 2
        Me._tlpContainerInputCIV.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        'Me._tlpContainerInputCIV.BorderStyle = BorderStyle.FixedSingle

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Table Layout Panel Container Metodo 1 CIV Variables de salida
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me._tlpContainerOutputCIV.ColumnCount = 9
        Me._tlpContainerOutputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me._tlpContainerOutputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerOutputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me._tlpContainerOutputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me._tlpContainerOutputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerOutputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me._tlpContainerOutputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me._tlpContainerOutputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerOutputCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me._tlpContainerOutputCIV.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpContainerOutputCIV.Location = New System.Drawing.Point(3, 238)
        Me._tlpContainerOutputCIV.Name = "_tlpContainerOutputCIV"
        Me._tlpContainerOutputCIV.RowCount = 2
        Me._tlpContainerOutputCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerOutputCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerOutputCIV.Size = New System.Drawing.Size(1291, 60)
        Me._tlpContainerOutputCIV.TabIndex = 3
        ' Me._tlpContainerOutputCIV.BorderStyle = BorderStyle.FixedSingle

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Table Layout Panel Container Metodo 1 CIV 
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me._tlpContainerCIV.ColumnCount = 1
        Me._tlpContainerCIV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpContainerCIV.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpContainerCIV.Location = New System.Drawing.Point(0, 0)
        Me._tlpContainerCIV.Name = "_tlpContainerCIV"

        Me._tlpContainerCIV.RowCount = 6
        Me._tlpContainerCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me._tlpContainerCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me._tlpContainerCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me._tlpContainerCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me._tlpContainerCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!)) '43
        Me._tlpContainerCIV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpContainerCIV.Size = New System.Drawing.Size(1297, 725)
        Me._tlpContainerCIV.TabIndex = 3
        ' Me._tlpContainerCIV.BorderStyle = BorderStyle.FixedSingle

        ' Me._tlpContainerOutputCIV = New System.Windows.Forms.TableLayoutPanel()


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Linea divisor de paneles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _borderPanel.Dock = DockStyle.Fill
        AddHandler _borderPanel.Paint, Sub(sender As Object, e As PaintEventArgs)
                                           Dim g = e.Graphics
                                           Dim pen As New System.Drawing.Pen(System.Drawing.Color.Gray, 2) ' Ajusta el color y grosor del borde aquí
                                           g.DrawLine(pen, 0, 0, _borderPanel.Width, 0) ' Dibuja la línea superior
                                       End Sub

        _borderPanel2.Dock = DockStyle.Fill
        AddHandler _borderPanel2.Paint, Sub(sender As Object, e As PaintEventArgs)
                                            Dim g = e.Graphics
                                            Dim pen As New System.Drawing.Pen(System.Drawing.Color.Gray, 2) ' Ajusta el color y grosor del borde aquí
                                            g.DrawLine(pen, 0, 0, _borderPanel2.Width, 0) ' Dibuja la línea superior
                                        End Sub

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Distribucion del Container Metodo 1 CIV 
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me._tlpContainerCIV.Controls.Add(Me._borderPanel, 0, 0)
        Me._tlpContainerCIV.Controls.Add(Me._tlpContainerInputCIV, 0, 1)
        Me._tlpContainerCIV.Controls.Add(Me._borderPanel2, 0, 3)
        Me._tlpContainerCIV.Controls.Add(Me._tlpContainerOutputCIV, 0, 4)

        _UPlblEquipmentPriceNew1 = New UPLabel("Valor de reposición, USD")
        _UPlblEquipmetUsefulLife = New UPLabel("Vida útil, h")
        _UPlblEquipmentUseTime = New UPLabel("Horas de uso al año, h")
        _UPlblEquipmentInterestRate = New UPLabel("Interés (tasa activa), %")
        _UPlblEquipmentInsurance = New UPLabel("Seguro, %")
        _UPlblEquipmentTax = New UPLabel("Impuestos, %")
        _UPlblEquipmentCustodyHour = New UPLabel("Resguardo, USD/h")
        _UPlblEquipmentMajorRepairs = New UPLabel("Mantenimiento, USD/h")
        _UPlblEquipmentWorkshopSpareParts = New UPLabel("Repuestos de taller, USD/h")
        _UPlblEquipmentFuel = New UPLabel("Combustible, USD/h")
        _UPlblEquipmentLubricant = New UPLabel("Lubricantes, USD/h")
        _UPlblEquipmentTiresHour = New UPLabel("Neumáticos, USD/h")
        _UPlblEquipmentLabor = New UPLabel("Mano de Obra, USD/h")
        _UPlblEquipmentWearElements = New UPLabel("Elementos de desgaste, USD/h")

        _UPlblTotalOwnershipCost = New UPLabel("Costo de Posesión, USD/h")
        _UPlblTotalOperatingCost = New UPLabel("Costo de Operación, USD/h")
        _UPlblTotalHourlyCost = New UPLabel("Costo de Horario, USD/h")
        _UPlblTotalPyOCost = New UPLabel("Factor Costo de P&O, XXX")


        _UPNumOwningCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumOperatingCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumMachineHourlyCost = New UPTextBoxNumerico(0, Double.NaN)

    End Sub

    Private Sub OnLoadPanel1()

        'TableLayoutPanel1.Controls.Clear()
        '_tlpContainerCIV.Controls.Clear()

        _tlpContainerInputCIV.Controls.Clear()

        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentPriceNew1, 1, 0)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmetUsefulLife, 1, 1)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentUseTime, 1, 2)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentInterestRate, 1, 3)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentInsurance, 1, 4)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentTax, 1, 5)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentCustodyHour, 1, 6)

        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentMajorRepairs, 4, 0)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentWorkshopSpareParts, 4, 1)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentFuel, 4, 2)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentLubricant, 4, 3)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentLabor, 4, 4)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentWearElements, 4, 5)
        _tlpContainerInputCIV.Controls.Add(_UPlblEquipmentTiresHour, 4, 6)

        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentPriceNew, 2, 0)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmetUsefulLife, 2, 1)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentUseTime, 2, 2)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentInterestRate, 2, 3)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentInsurance, 2, 4)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentTax, 2, 5)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentCustodyHour, 2, 6)

        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentMajorRepairs, 5, 0)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentWorkshopSpareParts, 5, 1)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentFuel, 5, 2)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentLubricant, 5, 3)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentLabor, 5, 4)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentWearElements, 5, 5)
        _tlpContainerInputCIV.Controls.Add(_UPNumEquipmentTiresHour, 5, 6)

        ' Calculos
        _tlpContainerOutputCIV.Controls.Clear()
        _tlpContainerOutputCIV.Controls.Add(_UPlblTotalOwnershipCost, 0, 0)
        _tlpContainerOutputCIV.Controls.Add(_UPlblTotalOperatingCost, 3, 0)
        _tlpContainerOutputCIV.Controls.Add(_UPlblTotalHourlyCost, 6, 0)

        _tlpContainerOutputCIV.Controls.Add(_UPlblTotalPyOCost, 6, 1)

        _tlpContainerOutputCIV.Controls.Add(_UPNumOwningCost, 1, 0)
        _tlpContainerOutputCIV.Controls.Add(_UPNumOperatingCost, 4, 0)
        _tlpContainerOutputCIV.Controls.Add(_UPNumMachineHourlyCost, 7, 0)
        _tlpContainerOutputCIV.Controls.Add(_UPNumequitmentCostPyO, 7, 1)

        _tlpContainerOutputCIV.Enabled = False


        'TableLayoutPanel1.Controls.Clear()
        TableLayoutPanel1.Controls.Add(_tlpContainerCIV, 0, 3)

        _TableLayoutPanelActive = _tlpContainerCIV

    End Sub

#End Region

#Region "Panel2"

    Private WithEvents _tlpContainerCIV2 As TableLayoutPanel
    Private WithEvents _tlpContainerInputCIV2 As TableLayoutPanel
    Private WithEvents _tlpContainerOutputCIV2 As TableLayoutPanel
    Private WithEvents _borderPanel3 As Panel
    Private WithEvents _borderPanel4 As Panel

    Private Sub OnLoadtlpPossCost2()

        Me._tlpContainerOutputCIV2 = New System.Windows.Forms.TableLayoutPanel()
        Me._tlpContainerInputCIV2 = New System.Windows.Forms.TableLayoutPanel()
        Me._tlpContainerCIV2 = New System.Windows.Forms.TableLayoutPanel()
        Me._borderPanel3 = New System.Windows.Forms.Panel()
        Me._borderPanel4 = New System.Windows.Forms.Panel()

        _borderPanel3.Dock = DockStyle.Fill
        AddHandler _borderPanel3.Paint, Sub(sender As Object, e As PaintEventArgs)
                                            Dim g = e.Graphics
                                            Dim pen As New System.Drawing.Pen(System.Drawing.Color.Gray, 2) ' Ajusta el color y grosor del borde aquí
                                            g.DrawLine(pen, 0, 0, _borderPanel.Width, 0) ' Dibuja la línea superior
                                        End Sub

        _borderPanel4.Dock = DockStyle.Fill
        AddHandler _borderPanel4.Paint, Sub(sender As Object, e As PaintEventArgs)
                                            Dim g = e.Graphics
                                            Dim pen As New System.Drawing.Pen(System.Drawing.Color.Gray, 2) ' Ajusta el color y grosor del borde aquí
                                            g.DrawLine(pen, 0, 0, _borderPanel2.Width, 0) ' Dibuja la línea superior
                                        End Sub

        '
        'Table Layout Panel Container Metodo 2 CIV2 Variables de entrada
        '
        Me._tlpContainerInputCIV2.ColumnCount = 9
        Me._tlpContainerInputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me._tlpContainerInputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerInputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me._tlpContainerInputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me._tlpContainerInputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerInputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me._tlpContainerInputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me._tlpContainerInputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerInputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpContainerInputCIV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpContainerInputCIV2.Location = New System.Drawing.Point(3, 94)
        Me._tlpContainerInputCIV2.Name = "_tlpContainerInputCIV2"
        Me._tlpContainerInputCIV2.RowCount = 3
        Me._tlpContainerInputCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me._tlpContainerInputCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerInputCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpContainerInputCIV2.Size = New System.Drawing.Size(1297, 725)
        Me._tlpContainerInputCIV2.TabIndex = 3
        'Me._tlpContainerInputCIV2.BorderStyle = BorderStyle.Fixed3D

        '
        'Table Layout Panel Container Metodo 2 CIV2 Variables de salida
        '
        Me._tlpContainerOutputCIV2.ColumnCount = 9
        Me._tlpContainerOutputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me._tlpContainerOutputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerOutputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me._tlpContainerOutputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me._tlpContainerOutputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerOutputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me._tlpContainerOutputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me._tlpContainerOutputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me._tlpContainerOutputCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me._tlpContainerOutputCIV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpContainerOutputCIV2.Location = New System.Drawing.Point(3, 238)
        Me._tlpContainerOutputCIV2.Name = "_tlpContainerOutputCIV"
        Me._tlpContainerOutputCIV2.RowCount = 2
        Me._tlpContainerOutputCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerOutputCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me._tlpContainerOutputCIV2.Size = New System.Drawing.Size(1291, 60)
        Me._tlpContainerOutputCIV2.TabIndex = 3
        'Me._tlpContainerOutputCIV2.BorderStyle = BorderStyle.FixedSingle

        '
        'Table Layout Panel Container Metodo 2 CIV2 
        '
        Me._tlpContainerCIV2.ColumnCount = 1
        Me._tlpContainerCIV2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))

        Me._tlpContainerCIV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpContainerCIV2.Location = New System.Drawing.Point(0, 0)
        Me._tlpContainerCIV2.Margin = New System.Windows.Forms.Padding(0)
        Me._tlpContainerCIV2.Name = "_tlpContainerCIV2"
        Me._tlpContainerCIV2.RowCount = 6
        Me._tlpContainerCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me._tlpContainerCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me._tlpContainerCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me._tlpContainerCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me._tlpContainerCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me._tlpContainerCIV2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpContainerCIV2.Size = New System.Drawing.Size(1297, 71)
        Me._tlpContainerCIV2.TabIndex = 2
        ' Me._tlpContainerCIV2.BorderStyle = BorderStyle.FixedSingle

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Distribucion del Container Metodo 2 CIV 
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me._tlpContainerCIV2.Controls.Add(Me._borderPanel3, 0, 0)
        Me._tlpContainerCIV2.Controls.Add(Me._tlpContainerInputCIV2, 0, 1)
        Me._tlpContainerCIV2.Controls.Add(Me._borderPanel4, 0, 3)
        Me._tlpContainerCIV2.Controls.Add(Me._tlpContainerOutputCIV2, 0, 4)

        '_UPlblEquipmentPriceNew2 = New UPLabel("Valor de reposición, USD")
        '_UPlblEquipmetUsefulLife2 = New UPLabel("Vida útil, h")


        '_UPlblTotalOwnershipCost = New UPLabel("Costo de Posesión, USD/h")
        '_UPlblTotalOperatingCost = New UPLabel("Costo de Operación, USD/h")
        '_UPlblTotalHourlyCost = New UPLabel("Costo de Horario, USD/h")



        '_UPNumOwningCost = New UPTextBoxNumerico(0, Double.NaN)
        '_UPNumOperatingCost = New UPTextBoxNumerico(0, Double.NaN)
        '_UPNumMachineHourlyCost = New UPTextBoxNumerico(0, Double.NaN)


    End Sub

    Private Sub OnLoadPanel2()

        _tlpContainerInputCIV2.Controls.Clear()

        _tlpContainerInputCIV2.Controls.Add(_UPlblEquipmentPriceNew1, 0, 0)
        _tlpContainerInputCIV2.Controls.Add(_UPlblEquipmetUsefulLife, 0, 1)
        _tlpContainerInputCIV2.Controls.Add(_UPNumEquipmentPriceNew, 1, 0)
        _tlpContainerInputCIV2.Controls.Add(_UPNumEquipmetUsefulLife, 1, 1)

        'calculos
        _tlpContainerOutputCIV2.Controls.Clear()
        _tlpContainerOutputCIV2.Controls.Add(_UPlblTotalHourlyCost, 6, 0)
        _tlpContainerOutputCIV2.Controls.Add(_UPNumMachineHourlyCost, 7, 0)
        _tlpContainerOutputCIV2.Controls.Add(_UPlblTotalPyOCost, 6, 1)
        _tlpContainerOutputCIV2.Controls.Add(_UPNumequitmentCostPyO, 7, 1)
        _tlpContainerOutputCIV2.Enabled = False

        TableLayoutPanel1.Controls.Add(_tlpContainerCIV2, 0, 3)

        _TableLayoutPanelActive = _tlpContainerCIV2

    End Sub

#End Region

#Region "Panel3"

    Private WithEvents tlpContainerMex As TableLayoutPanel
    Private WithEvents tlpContainerInputMex As TableLayoutPanel
    Private WithEvents tlpContainer2InputMex As TableLayoutPanel
    Private WithEvents tlpContainerOutputMex As TableLayoutPanel
    Private WithEvents tlpContainerRadioBtn As TableLayoutPanel

    Private WithEvents _TableLayoutPanelCost3 As TableLayoutPanel
    Private WithEvents _IconButtonPriceLabor As FontAwesome.Sharp.IconButton

    Private WithEvents _TableLayoutPanelFuelCost3 As TableLayoutPanel
    Private WithEvents _IconButtonPriceFuel As FontAwesome.Sharp.IconButton

    Private WithEvents rbFuelKnown As RadioButton
    Private WithEvents rbFuelNotKnown As RadioButton
    Private WithEvents rbFuelOther As RadioButton
    Private WithEvents _borderPanel31 As Panel
    Private WithEvents _borderPanel32 As Panel
    Private WithEvents _borderPanel33 As Panel

    Private Sub OnLoadtlpPossCost3()

        Me.tlpContainerInputMex = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContainer2InputMex = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContainerOutputMex = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContainerMex = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContainerRadioBtn = New System.Windows.Forms.TableLayoutPanel()

        '_IconButtonPriceLabor
        _IconButtonPriceLabor = New FontAwesome.Sharp.IconButton()
        _IconButtonPriceLabor.Dock = System.Windows.Forms.DockStyle.Fill
        _IconButtonPriceLabor.IconChar = FontAwesome.Sharp.IconChar.None
        _IconButtonPriceLabor.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        _IconButtonPriceLabor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        _IconButtonPriceLabor.IconSize = 28
        _IconButtonPriceLabor.Location = New System.Drawing.Point(257, 3)
        _IconButtonPriceLabor.Name = "_IconButtonPriceLabor"
        _IconButtonPriceLabor.Size = New System.Drawing.Size(63, 29)
        _IconButtonPriceLabor.TabIndex = 0
        _IconButtonPriceLabor.FlatStyle = FlatStyle.Flat
        _IconButtonPriceLabor.FlatAppearance.BorderSize = 0
        _IconButtonPriceLabor.BackColor = System.Drawing.Color.WhiteSmoke
        _IconButtonPriceLabor.Text = "$"
        _IconButtonPriceLabor.UseVisualStyleBackColor = True
        _IconButtonPriceLabor.Padding = New Padding(0)
        _IconButtonPriceLabor.Margin = New Padding(0, 4, 0, 0)

        '_IconButtonPriceFuel
        _IconButtonPriceFuel = New FontAwesome.Sharp.IconButton()
        _IconButtonPriceFuel.Dock = System.Windows.Forms.DockStyle.Fill
        _IconButtonPriceFuel.IconChar = FontAwesome.Sharp.IconChar.None
        _IconButtonPriceFuel.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        _IconButtonPriceFuel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        _IconButtonPriceFuel.IconSize = 28
        _IconButtonPriceFuel.Location = New System.Drawing.Point(257, 3)
        _IconButtonPriceFuel.Name = "_IconButtonPriceFuel"
        _IconButtonPriceFuel.Size = New System.Drawing.Size(28, 24)
        _IconButtonPriceFuel.TabIndex = 0
        _IconButtonPriceFuel.FlatStyle = FlatStyle.Flat
        _IconButtonPriceFuel.FlatAppearance.BorderSize = 0
        _IconButtonPriceFuel.BackColor = System.Drawing.Color.WhiteSmoke
        _IconButtonPriceFuel.Text = "$"
        _IconButtonPriceFuel.UseVisualStyleBackColor = True
        _IconButtonPriceFuel.Padding = New Padding(0)
        _IconButtonPriceFuel.Margin = New Padding(0, 4, 0, 0)

        Me.rbFuelKnown = New System.Windows.Forms.RadioButton()
        Me.rbFuelNotKnown = New System.Windows.Forms.RadioButton()
        Me.rbFuelOther = New System.Windows.Forms.RadioButton()
        Me._borderPanel31 = New System.Windows.Forms.Panel()
        Me._borderPanel32 = New System.Windows.Forms.Panel()
        Me._borderPanel33 = New System.Windows.Forms.Panel()

        AddHandler Me.rbFuelKnown.CheckedChanged, AddressOf rbFuelCheckedChanged
        AddHandler Me.rbFuelNotKnown.CheckedChanged, AddressOf rbFuelCheckedChanged
        AddHandler Me.rbFuelOther.CheckedChanged, AddressOf rbFuelCheckedChanged

#Region "ContainerDataMetodo3"
        '
        'Table Layout Panel container Metodo 3 Mex
        '
        Me.tlpContainerMex.ColumnCount = 1
        Me.tlpContainerMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContainerMex.Controls.Add(Me._borderPanel31, 0, 0)
        Me.tlpContainerMex.Controls.Add(Me.tlpContainerInputMex, 0, 1)
        Me.tlpContainerMex.Controls.Add(Me._borderPanel32, 0, 2)
        Me.tlpContainerMex.Controls.Add(Me.tlpContainerRadioBtn, 0, 3)
        Me.tlpContainerMex.Controls.Add(Me.tlpContainer2InputMex, 0, 4)
        Me.tlpContainerMex.Controls.Add(Me._borderPanel33, 0, 5)
        Me.tlpContainerMex.Controls.Add(Me.tlpContainerOutputMex, 0, 6)
        Me.tlpContainerMex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContainerMex.Location = New System.Drawing.Point(0, 0)
        Me.tlpContainerMex.Name = "tlpContainerMex"
        Me.tlpContainerMex.RowCount = 7
        Me.tlpContainerMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpContainerMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.tlpContainerMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpContainerMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpContainerMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpContainerMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpContainerMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        ' Me.tlpContainerMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContainerMex.Size = New System.Drawing.Size(1297, 452) '735 total: 452+20
        Me.tlpContainerMex.TabIndex = 4
        ' Me.tlpContainerMex.BorderStyle = BorderStyle.FixedSingle
        'TableLayoutPanelEquipMexCombustible/Lubricante otras fuentes de energia

#End Region

#Region "ContainerInputDataMetd3"

        '
        'Table Layout Panel Container Metodo 3 Mex variables de entrada
        '
        Me.tlpContainerInputMex.ColumnCount = 9
        Me.tlpContainerInputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpContainerInputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.tlpContainerInputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerInputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpContainerInputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpContainerInputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.tlpContainerInputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerInputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpContainerInputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpContainerInputMex.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.tlpContainerInputMex.Dock = System.Windows.Forms.DockStyle.None
        'Me.tlpContainerInputMex.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        '                                                               Or System.Windows.Forms.AnchorStyles.Left) _
        '                                                               Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpContainerInputMex.Location = New System.Drawing.Point(0, 0)
        Me.tlpContainerInputMex.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpContainerInputMex.Name = "tlpContainerInputMex"
        Me.tlpContainerInputMex.RowCount = 6
        Me.tlpContainerInputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputMex.Size = New System.Drawing.Size(1297, 180)
        Me.tlpContainerInputMex.TabIndex = 2
        Me.tlpContainerInputMex.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        'Me.tlpContainerInputMex.BorderStyle = BorderStyle.FixedSingle

        Me.tlpContainer2InputMex.ColumnCount = 9
        Me.tlpContainer2InputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpContainer2InputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.tlpContainer2InputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainer2InputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpContainer2InputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpContainer2InputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.tlpContainer2InputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainer2InputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpContainer2InputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        'Me.tlpContainerInputMex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContainer2InputMex.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.tlpContainer2InputMex.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        '                                                               Or System.Windows.Forms.AnchorStyles.Left) _
        '                                                               Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpContainer2InputMex.Location = New System.Drawing.Point(0, 0)
        Me.tlpContainer2InputMex.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpContainer2InputMex.Name = "tlpContainer2InputMex"
        Me.tlpContainer2InputMex.RowCount = 4
        Me.tlpContainer2InputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainer2InputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainer2InputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainer2InputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        'Me.tlpContainer2InputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainer2InputMex.Size = New System.Drawing.Size(1297, 130)
        Me.tlpContainer2InputMex.TabIndex = 2
        Me.tlpContainer2InputMex.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        'Me.tlpContainerInputMex.BorderStyle = BorderStyle.FixedSingle

#End Region

#Region "ContainerOutputMetd3"
        '
        'Table Layout Panel container Metodo 3 Mex variables de salida
        '
        Me.tlpContainerOutputMex.ColumnCount = 9
        Me.tlpContainerOutputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpContainerOutputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerOutputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpContainerOutputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.tlpContainerOutputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerOutputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpContainerOutputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.tlpContainerOutputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerOutputMex.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContainerOutputMex.Dock = System.Windows.Forms.DockStyle.Fill
        ' Me.tlpContainerOutputMex.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        ' Or System.Windows.Forms.AnchorStyles.Left) _
        ' Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpContainerOutputMex.Location = New System.Drawing.Point(3, 292)
        Me.tlpContainerOutputMex.Name = "tlpContainerOutputMex"
        Me.tlpContainerOutputMex.RowCount = 2
        Me.tlpContainerOutputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerOutputMex.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerOutputMex.Size = New System.Drawing.Size(1291, 60)
        Me.tlpContainerOutputMex.TabIndex = 3
        Me.tlpContainerOutputMex.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        ' Me.tlpContainerOutputMex.BorderStyle = BorderStyle.FixedSingle

#End Region

#Region "ContainerRadioBouttonMetd3"

        Me.rbFuelKnown.AutoSize = True
        Me.rbFuelKnown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rbFuelKnown.Location = New System.Drawing.Point(33, 98)
        Me.rbFuelKnown.Name = "rbFuelKnown"
        Me.rbFuelKnown.Size = New System.Drawing.Size(147, 29)
        Me.rbFuelKnown.TabIndex = 0
        Me.rbFuelKnown.Text = "Factor conocido"
        Me.rbFuelKnown.UseVisualStyleBackColor = True
        Me.rbFuelKnown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFuelKnown.ForeColor = System.Drawing.Color.White

        Me.rbFuelNotKnown.AutoSize = True
        Me.rbFuelNotKnown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rbFuelNotKnown.Location = New System.Drawing.Point(33, 98)
        Me.rbFuelNotKnown.Name = "rbFuelNotKnown"
        Me.rbFuelNotKnown.Size = New System.Drawing.Size(147, 29)
        Me.rbFuelNotKnown.TabIndex = 0
        Me.rbFuelNotKnown.Text = "Factor no conocido"
        Me.rbFuelNotKnown.UseVisualStyleBackColor = True
        Me.rbFuelNotKnown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFuelNotKnown.ForeColor = System.Drawing.Color.White

        Me.rbFuelOther.AutoSize = True
        Me.rbFuelOther.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rbFuelOther.Location = New System.Drawing.Point(33, 98)
        Me.rbFuelOther.Name = "rbFuelOther"
        Me.rbFuelOther.Size = New System.Drawing.Size(147, 29)
        Me.rbFuelOther.TabIndex = 0
        Me.rbFuelOther.Text = "Otra fuente de energía"
        Me.rbFuelOther.UseVisualStyleBackColor = True
        Me.rbFuelOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFuelOther.ForeColor = System.Drawing.Color.White
        '    
        'Table Layout Panel Container Radio Button
        '
        Me.tlpContainerRadioBtn.ColumnCount = 7
        Me.tlpContainerRadioBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280.0!))
        Me.tlpContainerRadioBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpContainerRadioBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpContainerRadioBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpContainerRadioBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpContainerRadioBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpContainerRadioBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContainerRadioBtn.Location = New System.Drawing.Point(0, 0)
        Me.tlpContainerRadioBtn.Name = "tlpContainerRadioBtn"
        Me.tlpContainerRadioBtn.RowCount = 1
        Me.tlpContainerRadioBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContainerRadioBtn.Size = New System.Drawing.Size(1297, 40)
        Me.tlpContainerRadioBtn.TabIndex = 5
        Me.tlpContainerRadioBtn.Dock = System.Windows.Forms.DockStyle.Fill
        ' Me.tlpContainerRadioBtn.BorderStyle = BorderStyle.FixedSingle
        Me.tlpContainerRadioBtn.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)

        _UPlblequipmentOtherEnergySources = New UPLabel("Otra fuente de energía")

        _UPlblEquipmentFuelFactorK = New UPLabel("Factor de combustible / lubricante")
        _UPlblEquipmentFuelFactorK.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)

#End Region

#Region "PanelBordes"
        'border 1 ente datos generales y datos de entrada
        _borderPanel31.Dock = DockStyle.Fill
        AddHandler _borderPanel31.Paint, Sub(sender As Object, e As PaintEventArgs)
                                             Dim g = e.Graphics
                                             Dim pen As New System.Drawing.Pen(System.Drawing.Color.Gray, 2) ' Ajusta el color y grosor del borde aquí
                                             g.DrawLine(pen, 0, 0, _borderPanel31.Width, 0) ' Dibuja la línea superior
                                         End Sub

        'border 2 en datos de entrada antes de radioBoutton
        _borderPanel32.Dock = DockStyle.Fill
        AddHandler _borderPanel32.Paint, Sub(sender As Object, e As PaintEventArgs)
                                             Dim g = e.Graphics
                                             Dim pen As New System.Drawing.Pen(System.Drawing.Color.Gray, 2) ' Ajusta el color y grosor del borde aquí
                                             g.DrawLine(pen, 0, 0, _borderPanel32.Width, 0) ' Dibuja la línea superior
                                         End Sub

        'border 3 entre datos de entrada y datos de salida
        _borderPanel33.Dock = DockStyle.Fill
        AddHandler _borderPanel33.Paint, Sub(sender As Object, e As PaintEventArgs)
                                             Dim g = e.Graphics
                                             Dim pen As New System.Drawing.Pen(System.Drawing.Color.Gray, 2) ' Ajusta el color y grosor del borde aquí
                                             g.DrawLine(pen, 0, 0, _borderPanel33.Width, 0) ' Dibuja la línea superior
                                         End Sub

#End Region

        _UPlblEquipmentPriceNew1 = New UPLabel("Valor de mercado, USD")
        _UPlblEquipmentSalvageValue = New UPLabel("Valor de rescate, %")
        _UPlblEquipmentInterestRate3 = New UPLabel("Tasa de interés, %")
        _UPlblEquipmentInsurance3 = New UPLabel("Prima de seguro, %")
        _UPlblEquipmentMaintenanceFactor = New UPLabel("Factor de mantenimiento")
        _UPlblEquipmetUsefulLife3 = New UPLabel("Vida económica, h")
        _UPlblEquipmentUseTime3 = New UPLabel("Horas por año, h")
        _UPlblEquipmentHp = New UPLabel("Potencia de operación, hp")
        _UPlblEquipmentOperationFactor = New UPLabel("Factor de operación")

        _UPlblEquipmentfuelType = New UPLabel("Tipo de combustible")
        _UPlblEquipmentFuelFactor3 = New UPLabel("Factor de combustible")
        _UPlblEquipmentFuel3 = New UPLabel("Combustible, USD/h")
        _UPlblEquipmentcrankcaseCap = New UPLabel("Capacidad del carter, l")
        _UPlblEquipmentLubricant3 = New UPLabel("Lubricante, USD/h")
        _UPlblEquipmentlubricantTime = New UPLabel("Tiempo entre cambios, h")
        _UPlblEquipmentLubricantPrice = New UPLabel("Precio lubricante, USD/l")
        _UplblEquipmentLubricantFactor3 = New UPLabel("Factor de Lubricante")
        _UPlblEquipmentTiresNumber = New UPLabel("Cantidad de neumáticos")
        _UPlblEquipmentTiresPrice = New UPLabel("Precio de neumáticos, USD")
        _UPlblEquipmentTiresUsefulLife = New UPLabel("Vida económica de neumáticos, h")
        _UPlblEquipmentSpecialPices = New UPLabel("Piezas especiales, USD/h")
        _UPlblEquipmentLabor3 = New UPLabel("Operador")

        _UPlblFixedCost = New UPLabel("Costos fijos, USD/h")
        _UPlblConsumptionCost = New UPLabel("Costos por consumo, USD/h")
        _UPlblOperatingCost = New UPLabel("Costos de operación, USD/h")

        _UPNumFixedCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumConsumptionCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumOperatingCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentOperationFactor = New UPTextBoxNumerico(0, Double.NaN)

        '--------------------------------
        'UPNumEquipmentfuelType
        '--------------------------------
        Dim _ColumnNames3 As New List(Of String)
        _ColumnNames3.Add("nameFuelType")
        Dim _dicValuesFilter As JObject = Nothing
        _UPCbxEquipmentfuelType = New UPComboBox("fuelType", _ColumnNames3, "fuelType", True, _dicValuesFilter)

        '--------------------------------
        '_UPCBxLabourType
        '--------------------------------
        Dim _ColumnNames4 As New List(Of String)
        _ColumnNames4.Add("nameLabour")

        Dim _dicValuesFilter1 As New JObject()
        _dicValuesFilter1("isAtomic") = True

        _UPCBxLabourType = New UPComboBox("labour", _ColumnNames4, "labour", True, _dicValuesFilter1)
        _UPCBxLabourType.DropDownWidth = 250
        ' _UPCBxLabourType.Padding = New Padding(0)
        ' _UPCBxLabourType.Margin = New Padding(0)

        Me.rbFuelKnown.Checked = True
    End Sub

    Public ReadOnly Property FuelKnown As EnumFuelKnown
        Get
            If rbFuelKnown.Checked Then
                Return EnumFuelKnown.FuelKnown 'costo horario conocido
            ElseIf rbFuelNotKnown.Checked Then
                Return EnumFuelKnown.FuelNotKnown 'costo horario no conocido
            ElseIf rbFuelOther.Checked Then
                Return EnumFuelKnown.FuelOther 'Otra fuente de energia
            Else
                Return EnumFuelKnown.FuelKnown
            End If
        End Get
    End Property

    Public ReadOnly Property FuelKnownRadioButton As RadioButton
        Get
            If rbFuelKnown.Checked Then
                Return rbFuelKnown
            ElseIf rbFuelNotKnown.Checked Then
                Return rbFuelNotKnown
            ElseIf rbFuelOther.Checked Then
                Return rbFuelOther
            Else
                Return rbFuelKnown
            End If
        End Get
    End Property

    Public ReadOnly Property HasOperatorCost3 As Boolean
        Get
            Return Not Double.IsNaN(operatorCost3()) AndAlso operatorCost3() > 0
        End Get
    End Property

    Public ReadOnly Property HasequipmentFuelPrice3 As Boolean
        Get
            Return Not Double.IsNaN(equipmentFuelPrice3()) AndAlso equipmentFuelPrice3() > 0
        End Get
    End Property


    Private Sub OnValidateequipmentFuelPrice3()
        If EqmtPriceEstType = EnumEqmtPriceEstType.Maquinaria3 Then
            If Not HasequipmentFuelPrice3 Then
                _UPlblEquipmentfuelType.ForeColor = System.Drawing.Color.Red
            Else
                _UPlblEquipmentfuelType.ForeColor = System.Drawing.Color.White
            End If
        Else
            _UPlblEquipmentfuelType.ForeColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub OnValidateOperatorCost3()
        If EqmtPriceEstType = EnumEqmtPriceEstType.Maquinaria3 Then
            If Not HasOperatorCost3 Then
                _UPlblEquipmentLabor.ForeColor = System.Drawing.Color.Red
            Else
                _UPlblEquipmentLabor.ForeColor = System.Drawing.Color.White
            End If
        Else
            _UPlblEquipmentLabor.ForeColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub OnLoadPanel3()

        tlpContainerInputMex.Controls.Clear()

        tlpContainerRadioBtn.Controls.Add(_UPlblEquipmentFuelFactorK, 0, 0)
        tlpContainerRadioBtn.Controls.Add(rbFuelKnown, 1, 0)
        tlpContainerRadioBtn.Controls.Add(rbFuelNotKnown, 3, 0)
        tlpContainerRadioBtn.Controls.Add(rbFuelOther, 5, 0)

        tlpContainerInputMex.Controls.Add(_UPlblEquipmentPriceNew1, 1, 0)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmentSalvageValue, 1, 1)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmentInterestRate3, 1, 2)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmentInsurance3, 1, 3)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmentMaintenanceFactor, 1, 4)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmetUsefulLife3, 1, 5)

        tlpContainerInputMex.Controls.Add(_UPlblEquipmentUseTime3, 5, 0)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmentTiresNumber, 5, 1)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmentTiresPrice, 5, 2)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmentTiresUsefulLife, 5, 3)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmentSpecialPices, 5, 4)
        tlpContainerInputMex.Controls.Add(_UPlblEquipmentLabor, 5, 5)

        tlpContainerInputMex.Controls.Add(_UPNumEquipmentPriceNew, 2, 0)
        tlpContainerInputMex.Controls.Add(_UPNumEquipmentSalvageValue, 2, 1)
        tlpContainerInputMex.Controls.Add(_UPNumEquipmentInterestRate, 2, 2)
        tlpContainerInputMex.Controls.Add(_UPNumEquipmentInsurance, 2, 3)
        tlpContainerInputMex.Controls.Add(_UPNumEquipmentMaintenanceFactor, 2, 4)
        tlpContainerInputMex.Controls.Add(_UPNumEquipmetUsefulLife, 2, 5)

        tlpContainerInputMex.Controls.Add(_UPNumEquipmentUseTime, 6, 0)
        tlpContainerInputMex.Controls.Add(_UPNumEquipmentTiresNumber, 6, 1)
        tlpContainerInputMex.Controls.Add(_UPNumEquipmentTiresPrice, 6, 2)
        tlpContainerInputMex.Controls.Add(_UPNumEquipmentTiresUsefulLife, 6, 3)
        tlpContainerInputMex.Controls.Add(_UPNumEquipmentSpecialPices, 6, 4)
        tlpContainerInputMex.Controls.Add(_UPCBxLabourType, 6, 5)

        tlpContainerInputMex.Controls.Add(_IconButtonPriceLabor, 7, 5) 'boton labor

        '111124
        '_TableLayoutPanelCost3.Controls.Add(_UPCBxLabourType, 0, 0)
        'tlpContainerInputMex.Controls.Add(_TableLayoutPanelCost3, 5, 5)

        tlpContainerOutputMex.Controls.Clear()
        tlpContainerOutputMex.Controls.Add(_UPlblFixedCost, 0, 0)
        tlpContainerOutputMex.Controls.Add(_UPlblConsumptionCost, 3, 0)
        tlpContainerOutputMex.Controls.Add(_UPlblOperatingCost, 6, 0)

        tlpContainerOutputMex.Controls.Add(_UPNumFixedCost, 1, 0)
        tlpContainerOutputMex.Controls.Add(_UPNumConsumptionCost, 4, 0)
        tlpContainerOutputMex.Controls.Add(_UPNumOperatingCost, 7, 0)



        Dim _UPlblTotalHourlyCost As New UPLabel("Costo de Horario, USD/h")
        '_UPlblTotalHourlyCost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 8)
        '_UPlblTotalHourlyCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ' Me._UPNumMachineHourlyCost.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)

        tlpContainerOutputMex.Controls.Add(_UPlblTotalHourlyCost, 6, 1)
        tlpContainerOutputMex.Controls.Add(_UPNumMachineHourlyCost, 7, 1)
        ' _UPNumMachineHourlyCost.Margin = New System.Windows.Forms.Padding(4, 6, 8, 2)

        tlpContainerOutputMex.Enabled = False

        TableLayoutPanel1.Controls.Add(tlpContainerMex, 0, 3)

        _TableLayoutPanelActive = tlpContainerMex

        rbFuelCheckedChanged(FuelKnownRadioButton, New EventArgs())

    End Sub

    Private Sub OnRefreshLubricantFactor()

        If CType(_UPNumEquipmentHp.Value, Double) < 100 Then
            _UPNumEquipmentLubricantFactor.Value = 0.003
        Else
            _UPNumEquipmentLubricantFactor.Value = 0.0035
        End If
    End Sub

    Private Sub rbFuelCheckedChanged(sender As Object, e As EventArgs)

        If CType(sender, RadioButton).Checked Then

            Dim _LisControls As New List(Of Control)

            _LisControls.Add(_UPNumEquipmentOtherEnergySources)
            _LisControls.Add(_UPNumEquipmentOperationFactor)
            _LisControls.Add(_UPNumEquipmentlubricantTime)
            _LisControls.Add(_UPNumEquipmentLubricantPrice)
            _LisControls.Add(_UPNumEquipmentLubricantFactor)
            _LisControls.Add(_UPNumEquipmentLubricant)
            _LisControls.Add(_UPNumEquipmentHp)
            _LisControls.Add(_UPNumEquipmentFuelFactor)
            _LisControls.Add(_UPNumEquipmentFuel)
            _LisControls.Add(_UPNumEquipmentCrankcaseCap)
            _LisControls.Add(_UPlblequipmentOtherEnergySources)
            _LisControls.Add(_UPlblEquipmentOperationFactor)
            _LisControls.Add(_UPlblEquipmentlubricantTime)
            _LisControls.Add(_UPlblEquipmentLubricantPrice)
            _LisControls.Add(_UplblEquipmentLubricantFactor3)
            _LisControls.Add(_UPlblEquipmentLubricant3)
            _LisControls.Add(_UPlblEquipmentHp)
            _LisControls.Add(_UPlblEquipmentfuelType)
            _LisControls.Add(_UPlblEquipmentFuelFactor3)
            _LisControls.Add(_UPlblEquipmentFuel3)
            _LisControls.Add(_UPlblEquipmentcrankcaseCap)
            _LisControls.Add(_UPCbxEquipmentfuelType)


            For Each _ctl As Control In _LisControls
                If tlpContainer2InputMex.Controls.Contains(_ctl) Then
                    tlpContainer2InputMex.Controls.Remove(_ctl)
                End If

            Next

            Select Case FuelKnown 'Detallado costo horario no conocido 
                Case EnumFuelKnown.FuelKnown

                    tlpContainer2InputMex.Controls.Add(_UPlblEquipmentHp, 1, 0)
                    tlpContainer2InputMex.Controls.Add(_UPlblEquipmentOperationFactor, 1, 1)
                    tlpContainer2InputMex.Controls.Add(_UPlblEquipmentfuelType, 1, 2)
                    tlpContainer2InputMex.Controls.Add(_UPlblEquipmentFuelFactor3, 1, 3)

                    tlpContainer2InputMex.Controls.Add(_UPlblEquipmentcrankcaseCap, 5, 0)
                    tlpContainer2InputMex.Controls.Add(_UPlblEquipmentlubricantTime, 5, 1)
                    tlpContainer2InputMex.Controls.Add(_UPlblEquipmentLubricantPrice, 5, 2)
                    tlpContainer2InputMex.Controls.Add(_UplblEquipmentLubricantFactor3, 5, 3)

                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentHp, 2, 0)
                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentOperationFactor, 2, 1)

                    '_TableLayoutPanelFuelCost3.Controls.Add(_UPCbxEquipmentfuelType, 0, 0)

                    tlpContainer2InputMex.Controls.Add(_UPCbxEquipmentfuelType, 2, 2)
                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentFuelFactor, 2, 3)

                    tlpContainer2InputMex.Controls.Add(_IconButtonPriceFuel, 3, 2)

                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentCrankcaseCap, 6, 0)
                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentlubricantTime, 6, 1)
                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentLubricantPrice, 6, 2)
                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentLubricantFactor, 6, 3)

                Case EnumFuelKnown.FuelNotKnown 'Si detalle, costo horario conocido

                    tlpContainer2InputMex.Controls.Add(_UPlblEquipmentLubricant3, 4, 0)
                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentLubricant, 5, 0)

                    tlpContainer2InputMex.Controls.Add(_UPlblEquipmentFuel3, 1, 0)
                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentFuel, 2, 0)

                Case EnumFuelKnown.FuelOther

                    tlpContainer2InputMex.Controls.Add(_UPlblequipmentOtherEnergySources, 1, 0)
                    tlpContainer2InputMex.Controls.Add(_UPNumEquipmentOtherEnergySources, 2, 0)

            End Select

            RefresCalculos()
        End If

    End Sub

    'Private Sub _UPCbxEquipmentfuelType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _UPCbxEquipmentfuelType.SelectionChangeCommitted

    'End Sub

    Private Sub _UPNumEquipmentHp_LostFocus(sender As Object, e As EventArgs) Handles _UPNumEquipmentHp.LostFocus
        If Double.IsNaN(_UPNumEquipmentLubricantFactor.Value) AndAlso Not Double.IsNaN(_UPNumEquipmentHp.Value) Then
            OnRefreshLubricantFactor()

        End If
    End Sub

    Private Sub _UPCBxLabourType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBxLabourType.SelectedIndexChanged
        OnValidateOperatorCost3()
    End Sub

    Private Sub _UPCbxEquipmentfuelType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCbxEquipmentfuelType.SelectedIndexChanged
        Select Case fuelType
            Case EnumfuelType.Diesel
                _UPNumEquipmentFuelFactor.Value = 0.2

            Case EnumfuelType.Gasolina
                _UPNumEquipmentFuelFactor.Value = 0.24
        End Select

        OnValidateequipmentFuelPrice3()
    End Sub

    Private Sub _IconButtonPriceLabor_Click(sender As Object, e As EventArgs) Handles _IconButtonPriceLabor.Click
        Dim _FormLabourPriceModal As New FormLabourPriceModal(Labour_Id, 3, eqmtPricDate)
        If _FormLabourPriceModal.ShowDialog(Me) = DialogResult.OK Then
            RefresCalculos()
        End If
    End Sub

    Private Sub _IconButtonPriceFuel_Click(sender As Object, e As EventArgs) Handles _IconButtonPriceFuel.Click

        Dim _material_id As Int32
        Dim _unit_id As Int32 = 29

        Select Case fuelType
            Case EnumfuelType.Diesel
                _material_id = 3382
            Case EnumfuelType.Gasolina
                _material_id = 3380

        End Select

        Dim _FormMaterialPriceModal As New FormMaterialPriceModal(_material_id, _unit_id, eqmtPricDate)
        If _FormMaterialPriceModal.ShowDialog(Me) = DialogResult.OK Then
            RefresCalculos()
        End If
    End Sub



#End Region

#Region "Panel4"

    Private WithEvents tlpContainerPer As TableLayoutPanel
    Private WithEvents tlpContainerInputPer As TableLayoutPanel
    Private WithEvents tlpContainerOutputPer As TableLayoutPanel

    Private Sub OnLoadtlpPossCost4()

        Me.tlpContainerPer = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContainerInputPer = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContainerOutputPer = New System.Windows.Forms.TableLayoutPanel()

        '
        'Table Layout Panel container Metodo 4 Per variables de entrada
        '
        Me.tlpContainerInputPer.ColumnCount = 7
        Me.tlpContainerInputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpContainerInputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.tlpContainerInputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerInputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpContainerInputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.tlpContainerInputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerInputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpContainerInputPer.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpContainerInputPer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                                                       Or System.Windows.Forms.AnchorStyles.Left) _
                                                                       Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)


        Me.tlpContainerInputPer.Location = New System.Drawing.Point(0, 0)
        Me.tlpContainerInputPer.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpContainerInputPer.Name = "_tlpContainerInputCIV"
        Me.tlpContainerInputPer.RowCount = 8
        Me.tlpContainerInputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainerInputPer.Size = New System.Drawing.Size(1297, 320)
        Me.tlpContainerInputPer.TabIndex = 2
        Me.tlpContainerInputPer.Margin = New System.Windows.Forms.Padding(0, 40, 0, 0)

        '
        'Table Layout Panel Container Metodo 4 Per variables de salida
        '
        Me.tlpContainerOutputPer.ColumnCount = 9
        Me.tlpContainerOutputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.tlpContainerOutputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerOutputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpContainerOutputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.tlpContainerOutputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerOutputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpContainerOutputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpContainerOutputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpContainerOutputPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.tlpContainerOutputPer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContainerOutputPer.Location = New System.Drawing.Point(3, 238)
        Me.tlpContainerOutputPer.Name = "_tlpContainerOutputCIV"
        Me.tlpContainerOutputPer.RowCount = 1
        Me.tlpContainerOutputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContainerOutputPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpContainerOutputPer.Size = New System.Drawing.Size(1291, 37)
        Me.tlpContainerOutputPer.TabIndex = 3


        '
        'Table Layout Panel container Metodo 4 Per 
        '
        Me.tlpContainerPer.ColumnCount = 1
        Me.tlpContainerPer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContainerPer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContainerPer.Location = New System.Drawing.Point(0, 0)
        Me.tlpContainerPer.Name = "_tlpContainerCIV"
        Me.tlpContainerPer.RowCount = 4
        Me.tlpContainerPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320.0!))
        Me.tlpContainerPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpContainerPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.tlpContainerPer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContainerPer.Size = New System.Drawing.Size(1297, 725)
        Me.tlpContainerPer.TabIndex = 3

        Me.tlpContainerPer.Controls.Add(Me.tlpContainerInputPer, 0, 0)
        Me.tlpContainerPer.Controls.Add(Me.tlpContainerOutputPer, 0, 2)

        _UPlblEquipmentPriceNew4 = New UPLabel("Valor de adquisición, USD")
        _UPlblEquipmentSalvageValue = New UPLabel("Valor de rescate, %")
        _UPlblEquipmetUsefulLife = New UPLabel("Vida económica útil, h")
        _UPlblEquipmentUseTime = New UPLabel("Horas de uso al año, h")
        _UPlblEquipmentInterestRate = New UPLabel("Interés (tasa activa), %")
        _UPlblEquipmentInsurance = New UPLabel("Seguro, %")
        _UPlblEquipmentTax = New UPLabel("Impuestos, %")
        _UPlblequipmentStore = New UPLabel("Almacenaje, %")
        _UPlblEquipmentMajorRepairs = New UPLabel("Mantenimiento, USD/h")
        _UPlblEquipmentWorkshopSpareParts = New UPLabel("Repuestos de taller, USD/h")
        _UPlblEquipmentFuel = New UPLabel("Combustible, USD/h")
        _UPlblEquipmentLubricant = New UPLabel("Lubricantes, USD/h")
        _UPlblEquipmentTiresHour = New UPLabel("Neumáticos, USD/h")
        _UPlblEquipmentLabor = New UPLabel("Mano de Obra, USD/h")
        _UPlblEquipmentWearElements = New UPLabel("Elementos de desgaste, USD/h")


        _UPlblTotalOwnershipCost = New UPLabel("Costo de Posesión, USD/h")
        _UPlblTotalOperatingCost = New UPLabel("Costo de Operación, USD/h")
        _UPlblTotalHourlyCost = New UPLabel("Costo de Horario, USD/h")

        _UPlblequitmentCostPyO = New UPLabel("equitmentCostPyO, gdgg")

        _UPNumOwningCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumOperatingCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumMachineHourlyCost = New UPTextBoxNumerico(0, Double.NaN)
        ' _UPNumMachineHourlyCost.Margin = New System.Windows.Forms.Padding(4, 6, 8, 2)


    End Sub

    Private Sub OnLoadPanel4()

        _tlpContainerInputCIV.Controls.Clear()

        tlpContainerInputPer.Controls.Add(_UPlblEquipmentPriceNew4, 1, 0)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentSalvageValue, 1, 1)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmetUsefulLife, 1, 2)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentUseTime, 1, 3)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentInterestRate, 1, 4)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentInsurance, 1, 5)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentTax, 1, 6)
        tlpContainerInputPer.Controls.Add(_UPlblequipmentStore, 1, 7)

        tlpContainerInputPer.Controls.Add(_UPlblEquipmentMajorRepairs, 4, 0)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentWorkshopSpareParts, 4, 1)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentFuel, 4, 2)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentLubricant, 4, 3)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentLabor, 4, 4)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentWearElements, 4, 5)
        tlpContainerInputPer.Controls.Add(_UPlblEquipmentTiresHour, 4, 6)

        tlpContainerInputPer.Controls.Add(_UPNumEquipmentPriceNew, 2, 0)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentSalvageValue, 2, 1)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmetUsefulLife, 2, 2)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentUseTime, 2, 3)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentInterestRate, 2, 4)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentInsurance, 2, 5)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentTax, 2, 6)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentStore, 2, 7)

        tlpContainerInputPer.Controls.Add(_UPNumEquipmentMajorRepairs, 5, 0)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentWorkshopSpareParts, 5, 1)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentFuel, 5, 2)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentLubricant, 5, 3)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentLabor, 5, 4)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentWearElements, 5, 5)
        tlpContainerInputPer.Controls.Add(_UPNumEquipmentTiresHour, 5, 6)

        tlpContainerOutputPer.Controls.Clear()
        tlpContainerOutputPer.Controls.Add(_UPlblTotalOwnershipCost, 0, 0)
        tlpContainerOutputPer.Controls.Add(_UPlblTotalOperatingCost, 3, 0)
        tlpContainerOutputPer.Controls.Add(_UPlblTotalHourlyCost, 6, 0)

        tlpContainerOutputPer.Controls.Add(_UPNumOwningCost, 1, 0)
        tlpContainerOutputPer.Controls.Add(_UPNumOperatingCost, 4, 0)
        tlpContainerOutputPer.Controls.Add(_UPNumMachineHourlyCost, 7, 0)
        tlpContainerOutputPer.Enabled = False


        'TableLayoutPanel1.Controls.Clear()
        TableLayoutPanel1.Controls.Add(tlpContainerPer, 0, 3)

        _TableLayoutPanelActive = tlpContainerPer
    End Sub

#End Region

    Public ReadOnly Property EqmtPriceEstType As EnumEqmtPriceEstType
        Get
            Dim _EnumIndex As Integer = _UPCBxEqmtPriceEstType.GetSelectedItemId() - 1
            Return GetNumeration(Of EnumEqmtPriceEstType)(_EnumIndex)
        End Get
    End Property

    Private Sub OnLoadPanel()

        If _TableLayoutPanelActive IsNot Nothing Then
            TableLayoutPanel1.Controls.Remove(_TableLayoutPanelActive)
        End If

        Select Case EqmtPriceEstType
            Case EnumEqmtPriceEstType.Maquinaria1
                OnLoadPanel1()

            Case EnumEqmtPriceEstType.Maquinaria2
                OnLoadPanel2()

            Case EnumEqmtPriceEstType.Maquinaria3
                OnLoadPanel3()

            Case EnumEqmtPriceEstType.Maquinaria4
                OnLoadPanel4()

            Case EnumEqmtPriceEstType.Herramienta1
                OnLoadPanel2()

        End Select
        RefresCalculos()
    End Sub

    Private Sub _UPCBxEqmtPriceEstType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBxEqmtPriceEstType.SelectedIndexChanged
        OnLoadPanel()
    End Sub

#End Region

#Region "Calculos"

#Region "Metodo1"

    Private Function depreciation1() As Double
        Try
            Return equipmentPriceNew / equipmentUsefulLife

        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function investmentCost1() As Double
        Try
            Dim _Temp1 As Double = (equipmentInterestRate / 100 + equipmentInsurance / 100 + equipmentTax / 100)

            Return (((equipmentUsefulLife / equipmentUseTime) + 1) * equipmentPriceNew * _Temp1) / (2 * equipmentUsefulLife)
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function owningCost1() As Double
        Try
            Dim _OwningCost1 As Double = depreciation1() + investmentCost1() + equipmentCustodyHour
            Return Math.Round(_OwningCost1, 4)
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function operatingCost1() As Double
        '#todos los costos en este metodo deben estar expresados en USD/h
        Try
            Dim _Temp1 As Double = equipmentLubricant + equipmentWearElements + equipmentLabor + equipmentTiresHour
            Return Math.Round(equipmentMajorRepairs + equipmentWorkshopSpareParts + equipmentFuel + _Temp1, 4)
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Public Function machineHourlyCost1() As Double
        Try
            Return owningCost1() + operatingCost1()
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function equitmentCostPyO1() As Double
        Try
            Return Math.Round(machineHourlyCost1() * ProjectHorasPerDay / equipmentPriceNew, 5)  ''' en dias pendiente conversion
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

#End Region

#Region "Metodo2"

    Private Function depreciation2() As Double
        Try
            Return 1 / (equipmentUsefulLife / 8)
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function machineHourlyCost2() As Double
        Try
            Return (depreciation2() * equipmentPriceNew) / 8
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function equitmentCostPyO2() As Double
        Try

            Return Math.Round(depreciation2(), 5)

        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

#End Region

#Region "Metodo3"

    Private Function salvageValue3() As Double
        Try
            Return equipmentPriceNew * equipmentSalvageValue / 100
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function depreciation3() As Double
        Try
            Return (equipmentPriceNew - salvageValue3()) / equipmentUsefulLife
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function investment3() As Double
        Try
            Return ((equipmentPriceNew + salvageValue3()) / (2 * equipmentUseTime)) * equipmentInterestRate / 100
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function insurance3() As Double
        Try
            Return ((equipmentPriceNew + salvageValue3()) / (2 * equipmentUseTime)) * equipmentInsurance / 100
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function maintenance3() As Double
        Try
            Return depreciation3() * equipmentMaintenanceFactor
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function equipmentFuelQuantity() As Double '011124
        Try

            Dim _Value As Double = equipmentFuelFactor * equipmentOperationFactor * equipmentHp
            Return _Value
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Private Function equipmentFuelCal() As Double
        Try

            Dim _Value As Double = equipmentFuelQuantity() * equipmentFuelPrice3()
            Return _Value
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Private Function equipmentLubricantQuantity() As Double 'Ah cantidad de lubicante
        Try
            Return equipmentLubricantFactor * equipmentOperationFactor * equipmentHp
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Private Function equipmentLubricantCal() As Double
        Try
            Return (equipmentLubricantQuantity() + lubricantConsumption()) * equipmentLubricantPrice
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Private Function equipmentFuelPrice3() As Double
        Try
            Dim _material_id As Int32
            Dim _ReferenceDate As DateTime = eqmtPricDate
            Dim _moneyType_Id As Int32 = ProjectMoneyTypeid
            Dim _unit_id As Int32 = 29

            Select Case fuelType
                Case EnumfuelType.Diesel
                    '_material_id = 3382
                    _material_id = 1
                Case EnumfuelType.Gasolina
                    '_material_id = 3380
                    _material_id = 1
            End Select
            Dim Value As Double = GetMaterialPrice(_material_id, _ReferenceDate, _moneyType_Id, _unit_id)
            Return Value

        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function lubricantConsumption() As Double
        Try
            Return equipmentCrankcaseCap / equipmentlubricantTime
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function


    Private Function tiresValue() As Double
        Try
            Return equipmentTiresNumber * equipmentTiresPrice
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function tiresCost() As Double
        Try
            Return tiresValue() / equipmentTiresUsefulLife
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function


    Private Function operatorCost3() As Double 'hablar con daniel no trae el costo del operador
        Try
            ' Dim _labour_id As Int32 = Labour_Id
            Dim _labour_id As Int32 = Labour_Id '011124
            Dim _ReferenceDate As DateTime = eqmtPricDate
            Dim _moneyType_Id As Int32 = ProjectMoneyTypeid
            Dim _unit_id As Int32 = 3

            Dim _Value As Double = GetLabourprice(_labour_id, _ReferenceDate, _moneyType_Id, _unit_id)
            'test-----------
            'Return 85.37
            '---------------
            Return _Value
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function fixedCost3() As Double
        Try
            Return depreciation3() + investment3() + insurance3() + maintenance3()
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Public Function consumptionCost3() As Double


        Select Case FuelKnown

            Case EnumFuelKnown.FuelKnown

                Try
                    Return equipmentFuelCal() + equipmentLubricantCal() + tiresCost() + equipmentSpecialPices
                Catch ex As Exception
                    Return Double.NaN
                End Try

            Case EnumFuelKnown.FuelNotKnown
                Try
                    Return equipmentFuel + equipmentLubricant + tiresCost() + equipmentSpecialPices
                Catch ex As Exception
                    Return Double.NaN
                End Try

            Case EnumFuelKnown.FuelOther

                Try
                    Return equipmentOtherEnergySources + tiresCost() + equipmentSpecialPices
                Catch ex As Exception
                    Return Double.NaN
                End Try
            Case Else
                Return Double.NaN
        End Select


    End Function

    Public Function machineHourlyCost3() As Double
        Try
            Dim _Value As Double = fixedCost3() + consumptionCost3() + operatorCost3()
            Return _Value

        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function equitmentCostPyO3() As Double
        Try
            Return machineHourlyCost3() * ProjectHorasPerDay / equipmentPriceNew
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

#End Region

#Region "Metodo4"

    Private Function salvageValue4() As Double
        Try
            Return equipmentPriceNew * equipmentSalvageValue / 100
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function depreciation4() As Double
        Try
            Return (equipmentPriceNew - salvageValue4()) / (equipmentUsefulLife)
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function nyears() As Double
        Try
            Return (equipmentUsefulLife) / (equipmentUseTime)
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function investment4() As Double 'IMA Inversion Media Anual
        Try
            Dim _Temp2 As Double = (equipmentPriceNew * (nyears() + 1))

            Dim _Temp3 As Double = (salvageValue4() * (nyears() - 1))

            Return (_Temp2 + _Temp3) / (2 * nyears())
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function interest4() As Double
        Try
            Return ((investment4()) * equipmentInterestRate / 100) / equipmentUsefulLife
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function insurance4() As Double 'Csia Costo horario de Seguro, Impuesto y almacenaje

        Try
            Dim _Temp4 As Double = equipmentInsurance / 100 + equipmentTax / 100 + equipmentStore / 100

            Return (investment4() * _Temp4) / equipmentUsefulLife
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function owningCost4() As Double
        Try
            Return depreciation4() + interest4() + insurance4()
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function operatingCost4() As Double
        Try
            Dim _Temp5 As Double = equipmentMajorRepairs + equipmentWorkshopSpareParts + equipmentFuel + equipmentLubricant

            Dim _Temp6 As Double = equipmentWearElements + equipmentLabor + equipmentTiresHour

            Return _Temp5 + _Temp6
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Public Function machineHourlyCost4() As Double
        Try
            Return owningCost4() + operatingCost4()
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function


    Private Function equitmentCostPyO4() As Double
        Try
            Return machineHourlyCost4() * ProjectHorasPerDay / equipmentPriceNew
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

#End Region

#Region "Metodo5" 'costo de equipos por partidas ????
    Private Function hp5() As Double
        Try
            Return equipmentHp 'debe sumar los hp de todos los equipos de partida equipos
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Private Function equipmentPriceNew5() As Double
        Try
            Return equipmentPriceNew 'debe sumar los precios de todos los equipos de partida equipos
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Private Function investment5() As Double 'amortizacion
        Try
            Dim _Value As Double = equipmentPriceNew5() * (1 - equipmentSalvageValue / 100)
            Return _Value / equipmentUsefulLife * 1 'horasPerDay
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Private Function interest5() As Double
        Try
            Dim _Value As Double = equipmentPriceNew5() * equipmentInterestRate / 100
            Dim _Value2 As Double = 2 * equipmentUseTime
            Return (_Value / _Value2) * 1 'horasPerDay
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function equipmentMajorRepairs5() As Double
        'Aqui las reparaciones y repuestos son un % de la amortizacion del equipo
        Try
            Dim _Value As Double = equipmentPriceNew5() * equipmentInterestRate / 100
            Dim _Value2 As Double = 2 * equipmentUseTime
            Return equipmentPriceNew * equipmentMajorRepairs / 100
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function equipmentFuel5() As Double

        Try
            Dim _Value As Double = equipmentFuelFactor * equipmentHp
            Return _Value * equipmentFuelPrice3() * 1 'horasPerDay
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Private Function equipmentLubricant5() As Double
        'Aqui el Lubricante es un % de Combustible
        Try
            Dim _Value As Double = equipmentFuel5() * equipmentLubricant / 100
            Return _Value
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Public Function machineDayCost5() As Double
        Try
            Return investment5() + interest5() + equipmentMajorRepairs5() + equipmentFuel5() + equipmentLubricant5()
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

#End Region


#Region "Metodo6" 'Argentina

    Private Function salvageValue6() As Double
        Try
            Return equipmentPriceNew * equipmentSalvageValue / 100
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function depreciation6() As Double 'Amortizacion

        Dim _Temp1 As Double = (equipmentPriceNew - salvageValue6()) / equipmentUsefulLife

        Try
            Return _Temp1 * ProjectHorasPerDay
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function insurance6() As Double 'Intereses

        Dim _Temp1 As Double = equipmentPriceNew * equipmentInsurance / 100
        Dim _Temp2 As Double = 2 * equipmentUseTime

        Try
            Return (_Temp1 / _Temp2) * ProjectHorasPerDay
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function maintenance6() As Double 'Reparaciones y repuestos
        Try
            Return depreciation6() * equipmentMaintenanceFactor / 100
        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function equipmentFuelPrice6() As Double 'solo hay ejemplos de gasoil
        Try
            Dim _material_id As Int32
            Dim _ReferenceDate As DateTime = eqmtPricDate
            Dim _moneyType_Id As Int32 = ProjectMoneyTypeid
            Dim _unit_id As Int32 = 29

            Select Case fuelType
                Case EnumfuelType.Diesel
                    '_material_id = 3382
                    _material_id = 2
                Case EnumfuelType.Gasolina
                    '_material_id = 3380
                    _material_id = 1

            End Select
            Dim Value As Double = GetMaterialPrice(_material_id, _ReferenceDate, _moneyType_Id, _unit_id)
            Return Value

        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function

    Private Function equipmentFuelQuantity6() As Double ' equipmentFuelFactor en l/hp/h
        Try
            Dim _Value As Double = equipmentFuelFactor * equipmentHp * equipmentFuelPrice6() * ProjectHorasPerDay
            Return _Value
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Private Function equipmentLubricantQuantity6() As Double 'Ah cantidad de lubicante
        Try
            Return equipmentFuelQuantity6() * equipmentLubricantFactor / 100
        Catch ex As Exception
            Return Double.NaN
        End Try
    End Function

    Public Function machinedailyCost6() As Double
        Try
            Dim _Value As Double = depreciation6() + insurance6() + maintenance6() + equipmentFuelQuantity6() + equipmentLubricantQuantity6()
            Return _Value

        Catch ex As Exception
            Return Double.NaN
        End Try

    End Function
#End Region
    Private Sub SetHandlerOnUPNumTextChanged()

        'AddHandler _UPNumEquipmentPriceNew.TextChanged, AddressOf _OnUPNumTextChanged
        'AddHandler _UPNumEquipmentTiresHour.TextChanged, AddressOf _OnUPNumTextChanged

        AddHandler _UPNumEquipmentPriceNew.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmetUsefulLife.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentUseTime.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentSalvageValue.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentInterestRate.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentInsurance.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentTax.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentCustodyHour.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentMajorRepairs.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentMaintenanceFactor.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentWorkshopSpareParts.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentHp.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentOperationFactor.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentFuel.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentFuelFactor.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentOtherEnergySources.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentCrankcaseCap.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentLubricant.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentLubricantPrice.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentlubricantTime.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentLubricantFactor.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentTiresPrice.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentTiresNumber.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentTiresHour.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentTiresUsefulLife.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentLabor.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentWearElements.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentSpecialPices.TextChanged, AddressOf _OnUPNumTextChanged
        AddHandler _UPNumEquipmentStore.TextChanged, AddressOf _OnUPNumTextChanged

    End Sub

    Private Sub RefresCalculos()

        Select Case EqmtPriceEstType
            Case EnumEqmtPriceEstType.Maquinaria1
                _UPNumOwningCost.Value = owningCost1()
                _UPNumOperatingCost.Value = operatingCost1()
                _UPNumMachineHourlyCost.Value = machineHourlyCost1()
                _UPNumequitmentCostPyO.Value = equitmentCostPyO1()

            Case EnumEqmtPriceEstType.Maquinaria2
                _UPNumMachineHourlyCost.Value = machineHourlyCost2()
                _UPNumequitmentCostPyO.Value = equitmentCostPyO2()

            Case EnumEqmtPriceEstType.Maquinaria3
                _UPNumFixedCost.Value = fixedCost3()
                _UPNumConsumptionCost.Value = consumptionCost3()
                _UPNumOperatingCost.Value = operatorCost3()
                _UPNumMachineHourlyCost.Value = machineHourlyCost3()
                _UPNumequitmentCostPyO.Value = equitmentCostPyO3()

            Case EnumEqmtPriceEstType.Maquinaria4
                _UPNumOwningCost.Value = owningCost4()
                _UPNumOperatingCost.Value = operatingCost4()
                _UPNumMachineHourlyCost.Value = machineHourlyCost4()
                _UPNumequitmentCostPyO.Value = equitmentCostPyO4()

            Case EnumEqmtPriceEstType.Herramienta1
                _UPNumMachineHourlyCost.Value = machineHourlyCost2()
                _UPNumequitmentCostPyO.Value = equitmentCostPyO2()

        End Select

        OnRefreshLubricantFactor()
        OnValidateOperatorCost3()
        OnValidateequipmentFuelPrice3()

        If _FormReportEqmtCostOpyPoss IsNot Nothing Then
            _FormReportEqmtCostOpyPoss.RefreshReport()
        End If
    End Sub

    Private Sub _OnUPNumTextChanged(sender As Object, e As EventArgs)
        RefresCalculos()

    End Sub

#End Region

#Region "DataTableReport"

    Public Function GetDataTable() As DataTable

        Dim _DataTable As New DataTable

        _DataTable.Columns.Add("eqmtPricDate", GetType(DateTime))
        _DataTable.Columns.Add("eqmtPricName", GetType(String))
        _DataTable.Columns.Add("eqmtPricDescrip", GetType(String))
        _DataTable.Columns.Add("equipmentPriceNew", GetType(Double))
        _DataTable.Columns.Add("equipmentUsefulLife", GetType(Double))
        _DataTable.Columns.Add("equipmentUseTime", GetType(Double))
        _DataTable.Columns.Add("equipmentSalvageValue", GetType(Double))
        _DataTable.Columns.Add("equipmentInterestRate", GetType(Double))
        _DataTable.Columns.Add("equipmentInsurance", GetType(Double))
        _DataTable.Columns.Add("equipmentTax", GetType(Double))
        _DataTable.Columns.Add("equipmentCustodyHour", GetType(Double))
        _DataTable.Columns.Add("equipmentMajorRepairs", GetType(Double))
        _DataTable.Columns.Add("equipmentMaintenanceFactor", GetType(Double))
        _DataTable.Columns.Add("equipmentWorkshopSpareParts", GetType(Double))
        _DataTable.Columns.Add("equipmentHp", GetType(Double))
        _DataTable.Columns.Add("equipmentOperationFactor", GetType(Double))
        _DataTable.Columns.Add("equipmentFuel", GetType(Double))
        _DataTable.Columns.Add("equipmentFuelPrice", GetType(Double))
        _DataTable.Columns.Add("equipmentFuelFactor", GetType(Double))
        _DataTable.Columns.Add("equipmentFuelQuantity", GetType(Double))
        _DataTable.Columns.Add("equipmentCrankcaseCap", GetType(Double))
        _DataTable.Columns.Add("equipmentLubricant", GetType(Double))
        _DataTable.Columns.Add("equipmentLubricantPrice", GetType(Double))
        _DataTable.Columns.Add("equipmentLubricantTime", GetType(Double))
        _DataTable.Columns.Add("equipmentLubricantFactor", GetType(Double))
        _DataTable.Columns.Add("equipmentOtherEnergySources", GetType(Double))
        _DataTable.Columns.Add("equipmentTiresPrice", GetType(Double))
        _DataTable.Columns.Add("equipmentTiresNumber", GetType(Double))
        _DataTable.Columns.Add("equipmentTiresHour", GetType(Double))
        _DataTable.Columns.Add("equipmentTiresUsefulLife", GetType(Double))
        _DataTable.Columns.Add("equipmentLabor", GetType(Double))
        _DataTable.Columns.Add("equipmentWearElements", GetType(Double))
        _DataTable.Columns.Add("equipmentSpecialPices", GetType(Double))
        _DataTable.Columns.Add("equipmentStore", GetType(Double))
        _DataTable.Columns.Add("depreciation1", GetType(Double))
        _DataTable.Columns.Add("investmentCost1", GetType(Double))
        _DataTable.Columns.Add("owningCost1", GetType(Double))
        _DataTable.Columns.Add("operatingCost1", GetType(Double))
        _DataTable.Columns.Add("machineHourlyCost1", GetType(Double))
        _DataTable.Columns.Add("salvageValue3", GetType(Double))
        _DataTable.Columns.Add("depreciation3", GetType(Double))
        _DataTable.Columns.Add("investment3", GetType(Double))
        _DataTable.Columns.Add("insurance3", GetType(Double))
        _DataTable.Columns.Add("maintenance3", GetType(Double))
        _DataTable.Columns.Add("equipmentFuelCal", GetType(Double))
        _DataTable.Columns.Add("equipmentFuelPrice3", GetType(Double))
        _DataTable.Columns.Add("equipmentLubricantQuantity", GetType(Double))
        _DataTable.Columns.Add("equipmentLubricantCal", GetType(Double))
        _DataTable.Columns.Add("lubricantConsumption", GetType(Double))
        '_DataTable.Columns.Add("lubricantCost", GetType(Double)) '*
        _DataTable.Columns.Add("tiresValue", GetType(Double))
        _DataTable.Columns.Add("tiresCost", GetType(Double))
        _DataTable.Columns.Add("operatorCost3", GetType(Double))
        _DataTable.Columns.Add("fixedCost3", GetType(Double))
        _DataTable.Columns.Add("consumptionCost3", GetType(Double))
        _DataTable.Columns.Add("machineHourlyCost3", GetType(Double))
        _DataTable.Columns.Add("salvageValue4", GetType(Double))
        _DataTable.Columns.Add("depreciation4", GetType(Double))
        _DataTable.Columns.Add("nyears", GetType(Double))
        _DataTable.Columns.Add("investment4", GetType(Double))
        _DataTable.Columns.Add("interest4", GetType(Double))
        _DataTable.Columns.Add("insurance4", GetType(Double))
        _DataTable.Columns.Add("owningCost4", GetType(Double))
        _DataTable.Columns.Add("operatingCost4", GetType(Double))
        _DataTable.Columns.Add("machineHourlyCost4", GetType(Double))
        _DataTable.Columns.Add("equitmentCostPyO1", GetType(Double))
        _DataTable.Columns.Add("equitmentCostPyO2", GetType(Double))
        _DataTable.Columns.Add("equitmentCostPyO3", GetType(Double))
        _DataTable.Columns.Add("equitmentCostPyO4", GetType(Double))

        Dim _DataRow As DataRow = _DataTable.NewRow()

        _DataRow("eqmtPricDate") = eqmtPricDate
        _DataRow("eqmtPricName") = eqmtPricName
        _DataRow("eqmtPricDescrip") = eqmtPricDescrip
        _DataRow("equipmentPriceNew") = equipmentPriceNew
        _DataRow("equipmentUsefulLife") = equipmentUsefulLife
        _DataRow("equipmentUseTime") = equipmentUseTime
        _DataRow("equipmentSalvageValue") = equipmentSalvageValue
        _DataRow("equipmentInterestRate") = equipmentInterestRate
        _DataRow("equipmentInsurance") = equipmentInsurance
        _DataRow("equipmentTax") = equipmentTax
        _DataRow("equipmentCustodyHour") = equipmentCustodyHour
        _DataRow("equipmentMajorRepairs") = equipmentMajorRepairs
        _DataRow("equipmentMaintenanceFactor") = equipmentMaintenanceFactor
        _DataRow("equipmentWorkshopSpareParts") = equipmentWorkshopSpareParts
        _DataRow("equipmentHp") = equipmentHp
        _DataRow("equipmentOperationFactor") = equipmentOperationFactor
        _DataRow("equipmentFuel") = equipmentFuel
        _DataRow("equipmentFuelPrice") = equipmentFuelPrice
        _DataRow("equipmentFuelFactor") = equipmentFuelFactor
        _DataRow("equipmentCrankcaseCap") = equipmentCrankcaseCap
        _DataRow("equipmentLubricant") = equipmentLubricant
        _DataRow("equipmentLubricantPrice") = equipmentLubricantPrice
        _DataRow("equipmentLubricantTime") = equipmentLubricantTime
        _DataRow("equipmentLubricantFactor") = equipmentLubricantFactor
        _DataRow("equipmentOtherEnergySources") = equipmentOtherEnergySources
        _DataRow("equipmentTiresPrice") = equipmentTiresPrice
        _DataRow("equipmentTiresNumber") = equipmentTiresNumber
        _DataRow("equipmentTiresHour") = equipmentTiresHour
        _DataRow("equipmentTiresUsefulLife") = equipmentTiresUsefulLife
        _DataRow("equipmentLabor") = equipmentLabor
        _DataRow("equipmentWearElements") = equipmentWearElements
        _DataRow("equipmentSpecialPices") = equipmentSpecialPices
        _DataRow("equipmentStore") = equipmentStore
        _DataRow("depreciation1") = depreciation1()
        _DataRow("investmentCost1") = investmentCost1()
        _DataRow("owningCost1") = owningCost1()
        _DataRow("operatingCost1") = operatingCost1()
        _DataRow("machineHourlyCost1") = machineHourlyCost1()
        _DataRow("salvageValue3") = salvageValue3()
        _DataRow("depreciation3") = depreciation3()
        _DataRow("investment3") = investment3()
        _DataRow("insurance3") = insurance3()
        _DataRow("maintenance3") = maintenance3()
        _DataRow("equipmentFuelQuantity") = equipmentFuelQuantity()
        _DataRow("equipmentFuelCal") = equipmentFuelCal()
        _DataRow("equipmentFuelPrice3") = equipmentFuelPrice3()
        _DataRow("equipmentLubricantQuantity") = equipmentLubricantQuantity()
        _DataRow("equipmentLubricantCal") = equipmentLubricantCal()
        _DataRow("lubricantConsumption") = lubricantConsumption()
        _DataRow("tiresValue") = tiresValue()
        _DataRow("tiresCost") = tiresCost()
        _DataRow("operatorCost3") = operatorCost3()
        _DataRow("fixedCost3") = fixedCost3()
        _DataRow("consumptionCost3") = consumptionCost3()
        _DataRow("machineHourlyCost3") = machineHourlyCost3()
        _DataRow("salvageValue4") = salvageValue4()
        _DataRow("depreciation4") = depreciation4()
        _DataRow("nyears") = nyears()
        _DataRow("investment4") = investment4()
        _DataRow("interest4") = interest4()
        _DataRow("insurance4") = insurance4()
        _DataRow("owningCost4") = owningCost4()
        _DataRow("operatingCost4") = operatingCost4()
        _DataRow("machineHourlyCost4") = machineHourlyCost4()

        _DataRow("equitmentCostPyO1") = equitmentCostPyO1()
        _DataRow("equitmentCostPyO2") = equitmentCostPyO2()
        _DataRow("equitmentCostPyO3") = equitmentCostPyO3()
        _DataRow("equitmentCostPyO4") = equitmentCostPyO4()


        _DataTable.Rows.Add(_DataRow)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'test
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Dim _Form1 As New Form1(_DataTable)
        '_Form1.ShowDialog()

        Return _DataTable

    End Function

#End Region

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        DialogResult = DialogResult.OK
        SetDicValues()
        Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        SetDicValues()
        If ValidateCalculos() Then
            'DialogResult = DialogResult.OK
            'Close()
            Hide()
        End If

    End Sub

    Private Sub BtnPreView_Click(sender As Object, e As EventArgs) Handles btnPreView.Click

        _FormReportEqmtCostOpyPoss = New FormReportEqmtCostOpyPoss(Me)
        _FormReportEqmtCostOpyPoss.TopLevel = False
        _FormReportEqmtCostOpyPoss.FormBorderStyle = FormBorderStyle.None
        _FormReportEqmtCostOpyPoss.Dock = DockStyle.Fill
        scEqmtPriceEst.Panel2.Controls.Add(_FormReportEqmtCostOpyPoss)
        _FormReportEqmtCostOpyPoss.BringToFront()
        _FormReportEqmtCostOpyPoss.Show()

        scEqmtPriceEst.Panel2Collapsed = False

    End Sub

    Private Sub ReportEqmtCostHourShow()

    End Sub

    Private Sub FomEqmtPriceEst_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        scEqmtPriceEst.SplitterDistance = 1100
        scEqmtPriceEst.Panel1MinSize = 600
        scEqmtPriceEst.Panel2MinSize = 500

    End Sub

    Private Sub FomEqmtPriceEst_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            DialogResult = DialogResult.Cancel
            _dicValuesEqmtPriceEst = Nothing
        Else
            DialogResult = DialogResult.OK
        End If
    End Sub


End Class