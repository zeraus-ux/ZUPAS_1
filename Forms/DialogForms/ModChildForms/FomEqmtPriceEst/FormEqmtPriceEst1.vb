Imports System.Security.Cryptography.X509Certificates
Imports Newtonsoft.Json.Linq

Public Class FormEqmtPriceEst1
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
    Private _UPlblTotalOwnershipCost As UPLabel
    Private _UPlblTotalOperatingCost As UPLabel
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

    Private WithEvents _UPNumTotalOwnershipCost As UPTextBoxNumerico
    Private WithEvents _UPNumTotalOperatingCost As UPTextBoxNumerico
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


        _UPlblEquipmentPriceNew = New UPLabel("Valor de reposición (VRN) USD​")
        _UPlblEquipmetUsefulLife = New UPLabel("Vida útil (horas) (n)​")
        _UPlblEquipmentUseTime = New UPLabel("Horas de uso al año (horas) (H)​")
        _UPlblEquipmentInterestRate = New UPLabel("Interés [Tasa Activa] (%)​")
        _UPlblEquipmentInsurance = New UPLabel("Seguro (%)")
        _UPlblEquipmentTax = New UPLabel("Impuestos (%)")
        _UPlblEquipmentCustodyHour = New UPLabel("Resguardo (USD/h)")

        _UPlblEquipmentMajorRepairs = New UPLabel("Reparaciones Mayores (USD/h)")
        _UPlblEquipmentWorkshopSpareParts = New UPLabel("Repuestos de taller / campo (USD/h)​")
        _UPlblEquipmentFuelPrice = New UPLabel("Combustible (USD/h)")
        _UPlblEquipmetLubricants = New UPLabel("Lubricantes (USD/h)")
        _UPlblEquipmentLabor = New UPLabel("Mano de Obra (USD/h)")
        _UPlblEquipmentWearElements = New UPLabel("Elementos de desgaste (USD/h)")
        _UPlblEquipmentTiresHour = New UPLabel("Neumáticos (USD/h)")

        _UPlblEqmtPriceEstType = New UPLabel("EqmtPriceEstType")
        _UPlblQuantityLabour = New UPLabel("QuantityLabour")

        _UPlblTotalOwnershipCost = New UPLabel("Total Costo de Posesión (USD/h)")
        _UPlblTotalOwnershipCost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 8)
        _UPlblTotalOwnershipCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        _UPlblTotalOperatingCost = New UPLabel("Total Costo de Operación (USD/h)")
        _UPlblTotalOperatingCost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 8)
        _UPlblTotalOperatingCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        _UPlblTotalHourlyCost = New UPLabel("Total Costo de Horario (USD/h)")
        _UPlblTotalHourlyCost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 8)
        _UPlblTotalHourlyCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight


        _UPNumEquipmentPriceNew = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmetUsefulLife = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentUseTime = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentInterestRate = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentInsurance = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTax = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentCustodyHour = New UPTextBoxNumerico(0, Double.NaN)

        _UPNumEquipmentMajorRepairs = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentWorkshopSpareParts = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentFuel = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmetLubricants = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentLabor = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentWearElements = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumEquipmentTiresHour = New UPTextBoxNumerico(0, Double.NaN)

        _UPNumQuantityLabour = New UPTextBoxNumerico(0, Double.NaN)

        _UPNumTotalOwnershipCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumTotalOperatingCost = New UPTextBoxNumerico(0, Double.NaN)
        _UPNumTotalHourlyCost = New UPTextBoxNumerico(0, Double.NaN)



        tlpPossCost.Controls.Add(_UPlblEquipmentPriceNew, 0, 0)
        tlpPossCost.Controls.Add(_UPlblEquipmetUsefulLife, 0, 1)
        tlpPossCost.Controls.Add(_UPlblEquipmentUseTime, 0, 2)
        tlpPossCost.Controls.Add(_UPlblEquipmentInterestRate, 0, 3)
        tlpPossCost.Controls.Add(_UPlblEquipmentInsurance, 0, 4)
        tlpPossCost.Controls.Add(_UPlblEquipmentTax, 0, 5)
        tlpPossCost.Controls.Add(_UPlblEquipmentCustodyHour, 0, 6)


        tlpPossCost.Controls.Add(_UPlblEquipmentMajorRepairs, 3, 0)
        tlpPossCost.Controls.Add(_UPlblEquipmentWorkshopSpareParts, 3, 1)
        tlpPossCost.Controls.Add(_UPlblEquipmentFuelPrice, 3, 2)
        tlpPossCost.Controls.Add(_UPlblEquipmetLubricants, 3, 3)
        tlpPossCost.Controls.Add(_UPlblEquipmentLabor, 3, 4)
        tlpPossCost.Controls.Add(_UPlblEquipmentWearElements, 3, 5)
        tlpPossCost.Controls.Add(_UPlblEquipmentTiresHour, 3, 6)


        tlpPossCost.Controls.Add(_UPNumEquipmentPriceNew, 1, 0)
        tlpPossCost.Controls.Add(_UPNumEquipmetUsefulLife, 1, 1)
        tlpPossCost.Controls.Add(_UPNumEquipmentUseTime, 1, 2)
        tlpPossCost.Controls.Add(_UPNumEquipmentInterestRate, 1, 3)
        tlpPossCost.Controls.Add(_UPNumEquipmentInsurance, 1, 4)
        tlpPossCost.Controls.Add(_UPNumEquipmentTax, 1, 5)
        tlpPossCost.Controls.Add(_UPNumEquipmentCustodyHour, 1, 6)

        tlpPossCost.Controls.Add(_UPNumEquipmentMajorRepairs, 4, 0)
        tlpPossCost.Controls.Add(_UPNumEquipmentWorkshopSpareParts, 4, 1)
        tlpPossCost.Controls.Add(_UPNumEquipmentFuel, 4, 2)
        tlpPossCost.Controls.Add(_UPNumEquipmetLubricants, 4, 3)
        tlpPossCost.Controls.Add(_UPNumEquipmentLabor, 4, 4)
        tlpPossCost.Controls.Add(_UPNumEquipmentWearElements, 4, 5)
        tlpPossCost.Controls.Add(_UPNumEquipmentTiresHour, 4, 6)

        TableLayoutPanel2.Controls.Add(_UPlblTotalOwnershipCost, 0, 0)
        TableLayoutPanel2.Controls.Add(_UPlblTotalOperatingCost, 3, 0)
        TableLayoutPanel2.Controls.Add(_UPlblTotalHourlyCost, 6, 0)

        TableLayoutPanel2.Controls.Add(_UPNumTotalOwnershipCost, 1, 0)
        TableLayoutPanel2.Controls.Add(_UPNumTotalOperatingCost, 4, 0)
        TableLayoutPanel2.Controls.Add(_UPNumTotalHourlyCost, 7, 0)


    End Sub

    Private Sub SetDicValues()
        _dicValuesEqmtPriceEst = New JObject()

        _dicValuesEqmtPriceEst("eqmtPriceEstType_id") = _UPCBxEqmtPriceEstType.GetSelectedItemId()
        _dicValuesEqmtPriceEst("equipmentPriceNew") = CType(_UPNumEquipmentPriceNew.Value, Double)
        _dicValuesEqmtPriceEst("equipmentUsefulLife") = CType(_UPNumEquipmetUsefulLife.Value, Double)
        _dicValuesEqmtPriceEst("equipmentUseTime") = CType(_UPNumEquipmentUseTime.Value, Double)
        _dicValuesEqmtPriceEst("equipmentInterestRate") = CType(_UPNumEquipmentInterestRate.Value, Double)
        _dicValuesEqmtPriceEst("equipmentInsurance") = CType(_UPNumEquipmentInsurance.Value, Double)
        _dicValuesEqmtPriceEst("equipmentTax") = CType(_UPNumEquipmentTax.Value, Double)
        _dicValuesEqmtPriceEst("equipmentCustodyHour") = CType(_UPNumEquipmentCustodyHour.Value, Double)
        _dicValuesEqmtPriceEst("equipmentMajorRepairs") = CType(_UPNumEquipmentMajorRepairs.Value, Double)
        _dicValuesEqmtPriceEst("equipmentWorkshopSpareParts") = CType(_UPNumEquipmentWorkshopSpareParts.Value, Double)
        _dicValuesEqmtPriceEst("equipmentFuel") = CType(_UPNumEquipmentFuel.Value, Double)
        _dicValuesEqmtPriceEst("equipmentLubricant") = CType(_UPNumEquipmetLubricants.Value, Double)
        _dicValuesEqmtPriceEst("EquipmentLabor") = CType(_UPNumEquipmentLabor.Value, Double)
        _dicValuesEqmtPriceEst("equipmentWearElements") = CType(_UPNumEquipmentWearElements.Value, Double)
        _dicValuesEqmtPriceEst("equipmentTiresHour") = CType(_UPNumEquipmentTiresHour.Value, Double)

    End Sub

    Private Sub SetDicValuesControls()

        If _dicValuesEqmtPriceEst IsNot Nothing Then

            _UPCBxEqmtPriceEstType.SetSelectedItem(CType(_dicValuesEqmtPriceEst("eqmtPriceEstType_id"), Int32))
            _UPNumEquipmentPriceNew.Value = CType(_dicValuesEqmtPriceEst("equipmentPriceNew"), Double)
            _UPNumEquipmetUsefulLife.Value = CType(_dicValuesEqmtPriceEst("equipmentUsefulLife"), Double)
            _UPNumEquipmentUseTime.Value = CType(_dicValuesEqmtPriceEst("equipmentUseTime"), Double)
            _UPNumEquipmentInterestRate.Value = CType(_dicValuesEqmtPriceEst("equipmentInterestRate"), Double)
            _UPNumEquipmentInsurance.Value = CType(_dicValuesEqmtPriceEst("equipmentInsurance"), Double)
            _UPNumEquipmentTax.Value = CType(_dicValuesEqmtPriceEst("equipmentTax"), Double)
            _UPNumEquipmentCustodyHour.Value = CType(_dicValuesEqmtPriceEst("equipmentCustodyHour"), Double)
            _UPNumEquipmentMajorRepairs.Value = CType(_dicValuesEqmtPriceEst("equipmentMajorRepairs"), Double)
            _UPNumEquipmentWorkshopSpareParts.Value = CType(_dicValuesEqmtPriceEst("equipmentWorkshopSpareParts"), Double)
            _UPNumEquipmentFuel.Value = CType(_dicValuesEqmtPriceEst("equipmentFuel"), Double)
            _UPNumEquipmetLubricants.Value = CType(_dicValuesEqmtPriceEst("equipmentLubricant"), Double)
            _UPNumEquipmentLabor.Value = CType(_dicValuesEqmtPriceEst("equipmentLabor"), Double)
            _UPNumEquipmentWearElements.Value = CType(_dicValuesEqmtPriceEst("equipmentWearElements"), Double)
            _UPNumEquipmentTiresHour.Value = CType(_dicValuesEqmtPriceEst("equipmentTiresHour"), Double)

        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) 
        DialogResult = DialogResult.OK
        SetDicValues()
        Close()
    End Sub

    Private Sub tlpPossCost_Paint(sender As Object, e As PaintEventArgs) Handles tlpPossCost.Paint

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tlpContainerCIV.Paint

    End Sub
End Class