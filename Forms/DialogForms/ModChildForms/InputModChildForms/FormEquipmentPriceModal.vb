Imports Newtonsoft.Json.Linq

Public Class FormequipmentCostPyOUserModal
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel

    Private WithEvents _UPCBoxCodigoNombre As UPComboBox
    Private WithEvents _UPCBoxUnit As UPComboBox
    Private WithEvents _UPDateTimePicker As UPDateTimePicker
    Private WithEvents _UPTxtBoxNumerico1 As UPTextBoxNumerico

    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False

    Private _Equipment_Id As Int32 = -1
    Private _Unit_Id As Int32 = -1
    Public Sub New(ByVal Equipment_Id As Int32, ByVal Unit_Id As Int32)

        InitializeComponent()
        Me.Text = "Precio equipos"
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False

        _IsInitialize = True  'YYYYYYYYYYYYYY

        _Equipment_Id = Equipment_Id
        _Unit_Id = Unit_Id

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Nombre")
        _UPlbl2 = New UPLabel("Unidad")
        _UPlbl3 = New UPLabel("Fecha")
        _UPlbl4 = New UPLabel($"Precio ({ProjectSymbolMoneyType})")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("N u e v o  d e  P r e c i o  d e  E q u i p o s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Código - Nombre
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNamesMaterial As New List(Of String)
        _ColumnNamesMaterial.Add("refEquipment")
        _ColumnNamesMaterial.Add("nameEquipment")

        _UPCBoxCodigoNombre = New UPComboBox("equipment", _ColumnNamesMaterial, "Equipo", True)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Unit
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnUnit As New List(Of String)
        _ColumnUnit.Add("symbolUnit")

        Dim _dicValuesFilterUnit As New JObject()
        _dicValuesFilterUnit("unitEquipment") = True

        _UPCBoxUnit = New UPComboBox("unit", _ColumnUnit, "Unidad", True, _dicValuesFilterUnit)
        _UPCBoxUnit.BackColor = Color.WhiteSmoke

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDateTimePicker Fecha
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDateTimePicker = New UPDateTimePicker()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Númerico
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtBoxNumerico1 = New UPTextBoxNumerico(0, Double.NaN)
        _UPTxtBoxNumerico1.Margin = New System.Windows.Forms.Padding(4, 6, 8, 2)

        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.btnEqmtPriceEst.Margin = New System.Windows.Forms.Padding(2, 6, 8, 2)
        Me.btnEqmtPriceEstReset.Margin = New System.Windows.Forms.Padding(2, 6, 8, 2)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpequipmentCostPyOUserEdition.Controls.Add(_UPlbl0, 0, 0)

        Me.tlpequipmentCostPyOUserEdition2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpequipmentCostPyOUserEdition2.Controls.Add(_UPlbl2, 0, 2)
        Me.tlpequipmentCostPyOUserEdition2.Controls.Add(_UPlbl3, 0, 3)
        Me.tlpequipmentCostPyOUserEdition2.Controls.Add(_UPlbl4, 0, 1)

        Me.tlpequipmentCostPyOUserEdition2.Controls.Add(_UPCBoxCodigoNombre, 1, 0)
        Me.tlpequipmentCostPyOUserEdition2.Controls.Add(_UPCBoxUnit, 1, 2)
        Me.tlpequipmentCostPyOUserEdition2.Controls.Add(_UPDateTimePicker, 1, 3)
        'Me.tlpequipmentCostPyOUserEdition2.Controls.Add(_UPTxtBoxNumerico1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(_UPTxtBoxNumerico1, 0, 0)

        EnableControls()
        LoadEquipmentSeleccionado()

        _IsInitialize = False

    End Sub

    Public Function Validate2() As Boolean
        'pendiente
        Return True
    End Function

    Private Sub EnableControls()
        _UPCBoxCodigoNombre.Enabled = False
        _UPCBoxUnit.Enabled = False
        _UPDateTimePicker.Enabled = False

    End Sub

    Private Sub LoadEquipmentSeleccionado()

        Dim _id As Int32 = _Equipment_Id

        Dim _ColumnNames As New List(Of String)

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("id") = _id

        Dim _datatable As DataTable = GetDataTable("equipment", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

        _UPCBoxCodigoNombre.SetSelectedItem(_Equipment_Id)
        _UPCBoxUnit.SetSelectedItem(_Unit_Id)
        _UPDateTimePicker.Value = Now()
        _UPTxtBoxNumerico1.Value = Nothing

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Validate2() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()

            _dicValues("equipment_id") = _Equipment_Id
            _dicValues("unit_id") = _Unit_Id
            _dicValues("dateUser") = CType(_UPDateTimePicker.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("price") = CType(_UPTxtBoxNumerico1.Value, Double)
            _dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If GetInsertTable("equipmentCostPyOUser", _DataServices) > 0 Then
                MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
            Else
                MessageBox.Show("ERROR !!! Revisar")
            End If

            _IsGuardando = False
        End If

    End Sub

    Private Sub FormequipmentCostPyOUserModal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            DialogResult = DialogResult.Cancel
        Else
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub FormequipmentCostPyOUserModal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
    End Sub

End Class