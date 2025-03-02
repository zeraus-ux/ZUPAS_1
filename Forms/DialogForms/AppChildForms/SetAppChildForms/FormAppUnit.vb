Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq

Public Class FormAppUnit
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel

    Private WithEvents _UPTxtRefUnit As UPTextBox
    Private WithEvents _UPTxtNameUnit As UPTextBox
    Private WithEvents _UPTxtSymbolUnit As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox
    Private WithEvents _UPTxtQuantityUnit As UPTextBox
    Private WithEvents _UPTxtFilterUnit As UPTextBox

    Private WithEvents _UPCBoxMoneyType As UPComboBox

    Private WithEvents _ChcBoxIsUnitMaterial As UPCheckBox
    Private WithEvents _ChcBoxIsUnitEquipment As UPCheckBox
    Private WithEvents _ChcBoxIsUnitTool As UPCheckBox
    Private WithEvents _ChcBoxIsUnitTransport As UPCheckBox
    Private WithEvents _ChcBoxIsUnitLabour As UPCheckBox
    Private WithEvents _ChcBoxIsUnitPartida As UPCheckBox
    Private WithEvents _ChcBoxIsUnitRendimiento As UPCheckBox

    Private _IsEdit As Boolean = False
    Private _IsInitialize = False
    Private _ListRefUnit As List(Of String) '23/12

    Public Sub New()

        InitializeComponent()

        _IsInitialize = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Unidades para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefUnit = GetColumnList(Of String)("unit", "refUnit")
        Dim _ListRefUnit1 As New List(Of String)
        For Each _RefUnit As String In _ListRefUnit
            _ListRefUnit1.Add(Trim(_RefUnit))
        Next
        _ListRefUnit = _ListRefUnit1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Unidades
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDGViewList = New UPDGViewList("unit", "refUnit", "nameUnit", "Código", "Nombre de la Unidad")
        _UPDGViewList.CrearteColumnText("symbolUnit", "Símbolo", True, True, False)
        _UPDGViewList.Columns("refUnit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _UPDGViewList.Columns("symbolUnit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _UPDGViewList.LoadList()
        _UPDGViewList.CallDeletedActive = False 'xxxx
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 4, 5, 8)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Símbolo")
        _UPlbl4 = New UPLabel("Descripción")
        _UPlbl5 = New UPLabel("Cantidad")
        _UPlbl6 = New UPLabel("Tipo de Moneda")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefUnit = New UPTextBox(12)
        _UPTxtNameUnit = New UPTextBox(100)
        _UPTxtDescription = New UPTextBox(150)
        _UPTxtSymbolUnit = New UPTextBox(12)
        _UPTxtQuantityUnit = New UPTextBox(100)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters (MoneyType)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMoneyType As New List(Of String)
        _ColumnMoneyType.Add("nameMoneyType")

        _UPCBoxMoneyType = New UPComboBox("moneyType", _ColumnMoneyType, "Tipo de Moneda", False)
        _UPCBoxMoneyType.BackColor = Color.WhiteSmoke

        _UPTxtFilterUnit = New UPTextBox
        _UPTxtFilterUnit.Margin = New Padding(8, 8, 4, 4)
        _UPTxtFilterUnit.Dock = DockStyle.Fill

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Check Boxes
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ChcBoxIsUnitMaterial = New UPCheckBox("Unidad de Materiales")
        _ChcBoxIsUnitEquipment = New UPCheckBox("Unidad de Equipos")
        _ChcBoxIsUnitTool = New UPCheckBox("Unidad de Herramientas")
        _ChcBoxIsUnitTransport = New UPCheckBox("Unidad de Transporte")
        _ChcBoxIsUnitLabour = New UPCheckBox("Unidad de Mano de Obra")
        _ChcBoxIsUnitPartida = New UPCheckBox("Unidad de Partidas")
        _ChcBoxIsUnitRendimiento = New UPCheckBox("Unidad de Rendimientos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        'PanelLista.Controls.Add(_UPDGViewList)

        Me.tlpListUnit.Controls.Add(_UPDGViewList, 0, 2)

        Me.tlyPanelEdicion.Controls.Add(_UPlbl1, 0, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl2, 0, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl3, 0, 2)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl4, 0, 3)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl5, 0, 4)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl6, 0, 5)

        Me.tlyPanelEdicion.Controls.Add(_UPTxtRefUnit, 1, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtNameUnit, 1, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtSymbolUnit, 1, 2)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtDescription, 1, 3)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtQuantityUnit, 1, 4)
        Me.tlyPanelEdicion.Controls.Add(_UPCBoxMoneyType, 1, 5)
        Me.tlpUnitLook.Controls.Add(_UPTxtFilterUnit, 0, 0)

        Me.tlyPanelCheck.Controls.Add(_ChcBoxIsUnitMaterial, 0, 0)
        _ChcBoxIsUnitMaterial.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0)
        Me.tlyPanelCheck.Controls.Add(_ChcBoxIsUnitEquipment, 1, 0)
        _ChcBoxIsUnitEquipment.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0)
        Me.tlyPanelCheck.Controls.Add(_ChcBoxIsUnitTool, 2, 0)
        _ChcBoxIsUnitTool.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0)
        Me.tlyPanelCheck.Controls.Add(_ChcBoxIsUnitTransport, 0, 1)
        _ChcBoxIsUnitTransport.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0)
        Me.tlyPanelCheck.Controls.Add(_ChcBoxIsUnitLabour, 1, 1)
        _ChcBoxIsUnitLabour.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0)
        Me.tlyPanelCheck.Controls.Add(_ChcBoxIsUnitPartida, 2, 1)
        _ChcBoxIsUnitPartida.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0)
        Me.tlyPanelCheck.Controls.Add(_ChcBoxIsUnitRendimiento, 0, 2)
        _ChcBoxIsUnitRendimiento.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0)

        btnGuardar.Visible = False

        _IsInitialize = False

        EnableControls(False)

        _UPDGViewList.SetSelectedItem(0)

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

    Private Sub EnableControls(ByVal Enabled As Boolean)

        _UPTxtRefUnit.Enabled = Enabled
        _UPTxtNameUnit.Enabled = Enabled
        _UPTxtSymbolUnit.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled
        _UPTxtQuantityUnit.Enabled = Enabled

        _UPCBoxMoneyType.Enabled = Enabled

        _ChcBoxIsUnitMaterial.Enabled = Enabled
        _ChcBoxIsUnitEquipment.Enabled = Enabled
        _ChcBoxIsUnitTool.Enabled = Enabled
        _ChcBoxIsUnitTransport.Enabled = Enabled
        _ChcBoxIsUnitLabour.Enabled = Enabled
        _ChcBoxIsUnitPartida.Enabled = Enabled
        _ChcBoxIsUnitRendimiento.Enabled = Enabled

    End Sub

    Public Function ValidateUnit() As Boolean

        If Not (_ChcBoxIsUnitMaterial.Checked Or _ChcBoxIsUnitEquipment.Checked _
            Or _ChcBoxIsUnitEquipment.Checked Or _ChcBoxIsUnitTool.Checked _
            Or _ChcBoxIsUnitTransport.Checked Or _ChcBoxIsUnitLabour.Checked _
            Or _ChcBoxIsUnitRendimiento.Checked) Then

            MessageBox.Show("Especifique al menos un insumo que utilizará la unidad", "Advertencia de la aplicación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefUnit.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameUnit.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 150) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtSymbolUnit.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtQuantityUnit.Text, 100) Then
            Return False
        End If

        Return True

    End Function

    Public _IsGuardando As Boolean = False

    Private Sub LoadUnitSelected()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("unit", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefUnit.Text = _datatable.Rows(0)("refUnit")
            _UPTxtNameUnit.Text = _datatable.Rows(0)("nameUnit")
            _UPTxtSymbolUnit.Text = _datatable.Rows(0)("symbolUnit")
            _UPTxtDescription.Text = _datatable.Rows(0)("descriptionUnit")
            _UPTxtQuantityUnit.Text = _datatable.Rows(0)("quantityUnit")
            _ChcBoxIsUnitMaterial.Checked = _datatable.Rows(0)("unitMaterial")
            _ChcBoxIsUnitEquipment.Checked = _datatable.Rows(0)("unitEquipment")
            _ChcBoxIsUnitTool.Checked = _datatable.Rows(0)("unitTool")
            _ChcBoxIsUnitTransport.Checked = _datatable.Rows(0)("unitTransport")
            _ChcBoxIsUnitLabour.Checked = _datatable.Rows(0)("unitLabour")
            _ChcBoxIsUnitPartida.Checked = _datatable.Rows(0)("unitPartida")
            _ChcBoxIsUnitRendimiento.Checked = _datatable.Rows(0)("unitRendimiento")

        End If

    End Sub

    Private Sub ValidateRefUnit() '23/12
        Dim _RefUnit As String = _UPTxtRefUnit.Text.Trim()
        If _ListRefUnit.Contains(_RefUnit) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_UPTxtRefUnit.Focus()
        End If

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged
        If Not _IsInitialize Then  ' XXXXXXXXXXX  controlar el error para incializacion
            LoadUnitSelected()

            EnableControls(False)
            If Not _IsGuardando Then '3/2/2024
                btnGuardar.Visible = False
            End If

            _IsEdit = False
        End If
    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        btnGuardar.Visible = True
        EnableControls(True)
        _IsEdit = True

        Me._UPTxtRefUnit.Focus()

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        _UPTxtRefUnit.Text = ""
        _UPTxtNameUnit.Text = ""
        _UPTxtSymbolUnit.Text = ""
        _UPTxtDescription.Text = ""
        _UPTxtQuantityUnit.Text = ""

        _ChcBoxIsUnitMaterial.Checked = False
        _ChcBoxIsUnitEquipment.Checked = False
        _ChcBoxIsUnitTransport.Checked = False
        _ChcBoxIsUnitTool.Checked = False
        _ChcBoxIsUnitLabour.Checked = False
        _ChcBoxIsUnitPartida.Checked = False
        _ChcBoxIsUnitRendimiento.Checked = False

        btnGuardar.Visible = True
        EnableControls(True)

        Me._UPTxtRefUnit.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidateUnit() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refUnit") = _UPTxtRefUnit.Text
            _dicValues("nameUnit") = _UPTxtNameUnit.Text
            _dicValues("symbolUnit") = _UPTxtSymbolUnit.Text
            _dicValues("descriptionUnit") = _UPTxtDescription.Text
            _dicValues("quantityUnit") = _UPTxtQuantityUnit.Text
            _dicValues("moneyType_Id") = _UPCBoxMoneyType.GetSelectedItemId()

            _dicValues("unitMaterial") = _ChcBoxIsUnitMaterial.Checked
            _dicValues("unitEquipment") = _ChcBoxIsUnitEquipment.Checked
            _dicValues("unitTool") = _ChcBoxIsUnitTool.Checked
            _dicValues("unitTransport") = _ChcBoxIsUnitTransport.Checked
            _dicValues("unitLabour") = _ChcBoxIsUnitLabour.Checked
            _dicValues("unitPartida") = _ChcBoxIsUnitPartida.Checked
            _dicValues("unitRendimiento") = _ChcBoxIsUnitRendimiento.Checked

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("unit", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_SelectedIndex)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _IsEdit = False
                    EnableControls(False)
                    btnGuardar.Visible = False

                    OnEvUnitChanged(Me, New EventArgs)

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("unit", _DataServices) > 0 Then
                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Visible = False

                    OnEvUnitChanged(Me, New EventArgs)
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

        _UPTxtFilterUnit.Clear()

    End Sub

    Private Sub FormUnit_Load(sender As Object, e As EventArgs) Handles Me.Load

        'splitContUnit.SplitterDistance = 807

        'splitContUnit.Panel1MinSize = 220
        'splitContUnit.Panel2MinSize = 330

        splitContUnit.SplitterDistance = 1000

        splitContUnit.Panel1MinSize = 500
        splitContUnit.Panel2MinSize = 500

    End Sub

    Private Sub btnUnitFilter_Click(sender As Object, e As EventArgs) Handles btnUnitFilter.Click
        _UPDGViewList.FilterList(_UPTxtFilterUnit.Text)
    End Sub

    Private Sub _UPTxtFilterUnit_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtFilterUnit.TextChanged
        If String.IsNullOrEmpty(_UPTxtFilterUnit.Text) Then
            _UPDGViewList.FilterList(_UPTxtFilterUnit.Text)
        End If
    End Sub

    Private Sub _UPTxtFilterUnit_KeyDown(sender As Object, e As KeyEventArgs) Handles _UPTxtFilterUnit.KeyDown
        _UPDGViewList.FilterList(_UPTxtFilterUnit.Text)
    End Sub

    Private Sub _UPTxtRefUnit_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefUnit.Validating
        ValidateRefUnit()
    End Sub
End Class