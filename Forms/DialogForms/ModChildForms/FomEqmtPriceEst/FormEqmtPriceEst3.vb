Imports Newtonsoft.Json.Linq

Public Class FormEqmtPriceEst3
    Private _UPlblEqmtPriceEstType As UPLabel

    Private _UPlblQuantityLabour As UPLabel
    Private _UPlblEquipmentPriceNew As UPLabel
    Private _UPlblEquipmentTiresPrice As UPLabel
    Private _UPlblEquipmentTiresNumber As UPLabel
    Private _UPlblEquipmetUsefulLife As UPLabel
    Private _UPlblEquipmentUseTime As UPLabel
    Private _UPlblEquipmentSalvateValue As UPLabel
    Private _UPlblEquipmentInterestRate As UPLabel
    Private _UPlblEquipmentInsurance As UPLabel
    Private _UPlblEquipmentTax As UPLabel
    Private _UPlblEquipmentCustodyHour As UPLabel
    Private _UPlblEquipmentMaintenanceFactor As UPLabel
    Private _UPlblEquipmentHp As UPLabel
    Private _UPlblEquipmentMajorRepairs As UPLabel
    Private _UPlblEquipmentWorkshopSpareParts As UPLabel
    Private _UPlblEquipmentFuel As UPLabel
    Private _UPlblEquipmetLubricants As UPLabel
    Private _UPlblEquipmentLabor As UPLabel
    Private _UPlblEquipmentWearElements As UPLabel
    Private _UPlblEquipmentFuelPrice As UPLabel
    Private _UPlblEquipmentTiresHour As UPLabel
    Private _UPlblEquipmentTiresUsefulLife As UPLabel
    Private _UPlblEquipmetLubricantPrice As UPLabel
    Private _UPlblEquipmentfuelType As UPLabel
    Private _UPlblEquipmentcrankcaseCap As UPLabel

    Private _UPlblEquipmentOperationFactor As UPLabel
    Private _UPlblEquipmentlubricateTime As UPLabel
    Private _UPlblequipmentOtherEnergySources As UPLabel
    Private _UPlblEquipmentspecialPices As UPLabel
    Private _UPlblEquipmentLabor1 As UPLabel
    Private _UPlblEquipmentLabor2 As UPLabel


    Private _UPlblFixedCost As UPLabel
    Private _UPlblOperatingCost As UPLabel
    Private _UPlblConsumptionCost As UPLabel
    Private _UPlblTotalHourlyCost As UPLabel

    Private WithEvents _UPCBxEqmtPriceEstType As UPComboBox
    Private WithEvents _UPNumQuantityLabour As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentPriceNew As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTiresPrice As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTiresNumber As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmetUsefulLife As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentUseTime As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentSalvateValue As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentInterestRate As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentInsurance As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTax As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentCustodyHour As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentMaintenanceFactor As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentHp As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentMajorRepairs As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentWorkshopSpareParts As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentFuel As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmetLubricants As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentLabor As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentWearElements As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentFuelPrice As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTiresHour As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentOperationFactor As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentfuelType As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentcrankcaseCap As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentlubricateTime As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmetLubricantPrice As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentTiresUseful As UPTextBoxNumerico
    Private WithEvents _UPNumEquipmentspecialPices As UPTextBoxNumerico

    Private WithEvents _UPNumFixedCost As UPTextBoxNumerico
    Private WithEvents _UPNumOperatingCost As UPTextBoxNumerico
    Private WithEvents _UPNumConsumptionCost As UPTextBoxNumerico
    Private WithEvents _UPNumTotalHourlyCost As UPTextBoxNumerico

    Private _dicValuesEqmtPriceEst As JObject
    Private _EquipmentType_id As Int32
    Private _DisplayType As EnumDisplayType

    Public Sub New(ByVal EquipmentType_id As Int32, ByVal DisplayType As EnumDisplayType,
                   Optional dicValuesEqmtPriceEst As JObject = Nothing)

        InitializeComponent()

        _EquipmentType_id = EquipmentType_id
        _dicValuesEqmtPriceEst = dicValuesEqmtPriceEst
        _DisplayType = DisplayType


        _UPlblEquipmentPriceNew = New UPLabel("Valor de mercado, USD​")
        _UPlblEquipmentSalvateValue = New UPLabel("Valor de rescate, %​")
        _UPlblEquipmentInterestRate = New UPLabel("Tasa de interés anual, %​")
        _UPlblEquipmentInsurance = New UPLabel("Prima de seguro anual, %")
        _UPlblEquipmentMaintenanceFactor = New UPLabel("Factor de mantenimiento")
        _UPlblEquipmetUsefulLife = New UPLabel("Vida económica, h​")
        _UPlblEquipmentUseTime = New UPLabel("Horas efectivas trab./año, h​")
        _UPlblEquipmentHp = New UPLabel("Potencia de operación, hp")
        _UPlblEquipmentOperationFactor = New UPLabel("Factor de operación")

        _UPlblEquipmentfuelType = New UPLabel("Tipo de combustible")
        _UPlblEquipmentFuelPrice = New UPLabel("Precio combustible, USD/l")
        _UPlblEquipmentcrankcaseCap = New UPLabel("Capacidad del carter, l")
        _UPlblEquipmentlubricateTime = New UPLabel("Tiempo entre cambios, h")
        _UPlblEquipmetLubricantPrice = New UPLabel("Precio lubricante, USD/l")
        _UPlblEquipmentTiresNumber = New UPLabel("Cantidad de neumáticos")
        _UPlblEquipmentTiresPrice = New UPLabel("Precio de neumáticos, USD")
        _UPlblEquipmentTiresUsefulLife = New UPLabel("Vida económica de neumáticos, h")
        _UPlblEquipmentspecialPices = New UPLabel("Piezas especiales, USD/h")


        _UPlblEqmtPriceEstType = New UPLabel("EqmtPriceEstType")
        _UPlblQuantityLabour = New UPLabel("QuantityLabour")

        _UPlblFixedCost = New UPLabel("Costos fijos, USD/h")
        _UPlblFixedCost.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
        _UPlblFixedCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        _UPlblConsumptionCost = New UPLabel("Costos por consumo, USD/h")
        _UPlblConsumptionCost.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
        '_UPlblConsumptionCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        _UPlblOperatingCost = New UPLabel("Costos de operación, USD/h")
        _UPlblOperatingCost.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
        '_UPlblOperatingCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight


        _UPlblTotalHourlyCost = New UPLabel("Costos directo máquina, USD/h")
        _UPlblTotalHourlyCost.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
        '_UPlblTotalHourlyCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight


        _UPNumEquipmentPriceNew = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentSalvateValue = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentInterestRate = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentInsurance = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentMaintenanceFactor = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmetUsefulLife = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentUseTime = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentHp = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentOperationFactor = New UPTextBoxNumerico(0, Double.NaN)


        _UPNumEquipmentfuelType = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentFuelPrice = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentcrankcaseCap = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentlubricateTime = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmetLubricantPrice = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTiresNumber = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTiresPrice = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTiresUseful = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentspecialPices = New UPTextBoxNumerico(0, Double.NaN)

        _UPNumQuantityLabour = New UPTextBoxNumerico(0, Double.NaN)

        _UPNumFixedCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumFixedCost.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
        _UPNumFixedCost.Dock = DockStyle.None

        _UPNumConsumptionCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumConsumptionCost.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
        _UPNumOperatingCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumOperatingCost.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)

        _UPNumTotalHourlyCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumTotalHourlyCost.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)


        TableLayoutPanel12.Controls.Add(_UPlblEquipmentPriceNew, 0, 0)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentSalvateValue, 0, 1)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentInterestRate, 0, 2)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentInsurance, 0, 3)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentMaintenanceFactor, 0, 4)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmetUsefulLife, 0, 5)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentUseTime, 0, 6)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentHp, 0, 7)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentOperationFactor, 0, 8)

        TableLayoutPanel12.Controls.Add(_UPlblEquipmentfuelType, 3, 0)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentFuelPrice, 3, 1)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentcrankcaseCap, 3, 2)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentlubricateTime, 3, 3)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmetLubricantPrice, 3, 4)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentTiresNumber, 3, 5)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentTiresPrice, 3, 6)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentTiresUsefulLife, 3, 7)
        TableLayoutPanel12.Controls.Add(_UPlblEquipmentspecialPices, 3, 8)

        TableLayoutPanel12.Controls.Add(_UPNumEquipmentPriceNew, 1, 0)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentSalvateValue, 1, 1)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentInterestRate, 1, 2)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentInsurance, 1, 3)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentMaintenanceFactor, 1, 4)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmetUsefulLife, 1, 5)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentUseTime, 1, 6)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentHp, 1, 7)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentOperationFactor, 1, 8)


        TableLayoutPanel12.Controls.Add(_UPNumEquipmentfuelType, 4, 0)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentFuelPrice, 4, 1)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentcrankcaseCap, 4, 2)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentlubricateTime, 4, 3)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmetLubricantPrice, 4, 4)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentTiresNumber, 4, 5)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentTiresPrice, 4, 6)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentTiresUseful, 4, 7)
        TableLayoutPanel12.Controls.Add(_UPNumEquipmentspecialPices, 4, 8)

        TableLayoutPanel11.Controls.Add(_UPlblFixedCost, 0, 0)
        TableLayoutPanel11.Controls.Add(_UPlblConsumptionCost, 3, 0)
        TableLayoutPanel11.Controls.Add(_UPlblOperatingCost, 6, 0)


        TableLayoutPanel11.Controls.Add(_UPNumFixedCost, 1, 0)
        TableLayoutPanel11.Controls.Add(_UPNumConsumptionCost, 4, 0)
        TableLayoutPanel11.Controls.Add(_UPNumOperatingCost, 7, 0)


        TableLayoutPanel11.Controls.Add(_UPlblTotalHourlyCost, 0, 1)
        TableLayoutPanel11.Controls.Add(_UPNumTotalHourlyCost, 1, 1)

    End Sub

    Private Sub SetDicValues()
        _dicValuesEqmtPriceEst = New JObject()

        _dicValuesEqmtPriceEst("eqmtPriceEstType_id") = _UPCBxEqmtPriceEstType.GetSelectedItemId()

        _dicValuesEqmtPriceEst("equipmentPriceNew") = CType(_UPNumEquipmentPriceNew.Value, Double)
        _dicValuesEqmtPriceEst("equipmentSalvageValue") = CType(_UPNumEquipmentSalvateValue.Value, Double)
        _dicValuesEqmtPriceEst("equipmentInterestRate") = CType(_UPNumEquipmentInterestRate.Value, Double)
        _dicValuesEqmtPriceEst("equipmentInsurance") = CType(_UPNumEquipmentInsurance.Value, Double)
        _dicValuesEqmtPriceEst("equipmentMaintenanceFactor") = CType(_UPNumEquipmentMaintenanceFactor.Value, Double)
        _dicValuesEqmtPriceEst("equipmentUsefulLife") = CType(_UPNumEquipmetUsefulLife.Value, Double)
        _dicValuesEqmtPriceEst("equipmentUseTime") = CType(_UPNumEquipmentUseTime.Value, Double)
        _dicValuesEqmtPriceEst("equipmentHp") = CType(_UPNumEquipmentHp.Value, Double)
        _dicValuesEqmtPriceEst("equipmentOperationFactor") = CType(_UPNumEquipmentOperationFactor.Value, Double)
        '_dicValuesEqmtPriceEst("XXX") = CType(_UPNumEquipmentfuelType.Value, Double)
        _dicValuesEqmtPriceEst("equipmentFuelPrice") = CType(_UPNumEquipmentFuelPrice.Value, Double)
        _dicValuesEqmtPriceEst("equipmentCrankcaseCap") = CType(_UPNumEquipmentcrankcaseCap.Value, Double)
        _dicValuesEqmtPriceEst("equipmentLubricantTime") = CType(_UPNumEquipmentlubricateTime.Value, Double)
        _dicValuesEqmtPriceEst("equipmentLubricantPrice") = CType(_UPNumEquipmetLubricantPrice.Value, Double)
        _dicValuesEqmtPriceEst("equipmentTiresNumber") = CType(_UPNumEquipmentTiresNumber.Value, Double)
        _dicValuesEqmtPriceEst("equipmentTiresPrice") = CType(_UPNumEquipmentTiresPrice.Value, Double)
        _dicValuesEqmtPriceEst("equipmentTiresUsefulLife") = CType(_UPNumEquipmentTiresUseful.Value, Double)
        _dicValuesEqmtPriceEst("equipmentSpecialPices") = CType(_UPNumEquipmentspecialPices.Value, Double)

    End Sub


    Private Sub SetDicValuesControls()

        If _dicValuesEqmtPriceEst IsNot Nothing Then

            _UPCBxEqmtPriceEstType.SetSelectedItem(CType(_dicValuesEqmtPriceEst("eqmtPriceEstType_id"), Int32))

            _UPNumEquipmentPriceNew.Value = CType(_dicValuesEqmtPriceEst("equipmentPriceNew"), Double)
            _UPNumEquipmentSalvateValue.Value = CType(_dicValuesEqmtPriceEst("equipmentSalvageValue"), Double)
            _UPNumEquipmentInterestRate.Value = CType(_dicValuesEqmtPriceEst("equipmentInterestRate"), Double)
            _UPNumEquipmentInsurance.Value = CType(_dicValuesEqmtPriceEst("equipmentInsurance"), Double)
            _UPNumEquipmentMaintenanceFactor.Value = CType(_dicValuesEqmtPriceEst("equipmentMaintenanceFactor"), Double)
            _UPNumEquipmetUsefulLife.Value = CType(_dicValuesEqmtPriceEst("equipmentUsefulLife"), Double)
            _UPNumEquipmentUseTime.Value = CType(_dicValuesEqmtPriceEst("equipmentUseTime"), Double)
            _UPNumEquipmentHp.Value = CType(_dicValuesEqmtPriceEst("equipmentHp"), Double)
            _UPNumEquipmentOperationFactor.Value = CType(_dicValuesEqmtPriceEst("equipmentOperationFactor"), Double)

            _UPNumEquipmentFuelPrice.Value = CType(_dicValuesEqmtPriceEst("equipmentFuelPrice"), Double)
            _UPNumEquipmentcrankcaseCap.Value = CType(_dicValuesEqmtPriceEst("equipmentCrankcaseCap"), Double)
            _UPNumEquipmentlubricateTime.Value = CType(_dicValuesEqmtPriceEst("equipmentLubricantTime"), Double)
            _UPNumEquipmetLubricantPrice.Value = CType(_dicValuesEqmtPriceEst("equipmentLubricantPrice"), Double)
            _UPNumEquipmentTiresNumber.Value = CType(_dicValuesEqmtPriceEst("equipmentTiresNumber"), Double)
            _UPNumEquipmentTiresPrice.Value = CType(_dicValuesEqmtPriceEst("equipmentTiresPrice"), Double)
            _UPNumEquipmentTiresUseful.Value = CType(_dicValuesEqmtPriceEst("equipmentTiresUsefulLife"), Double)
            _UPNumEquipmentspecialPices.Value = CType(_dicValuesEqmtPriceEst("equipmentSpecialPices"), Double)

        End If
    End Sub





    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        DialogResult = DialogResult.OK
        SetDicValues()
        Close()
    End Sub


End Class