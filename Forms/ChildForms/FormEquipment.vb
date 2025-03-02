Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid
Imports System.Windows

Public Class FormEquipment

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel
    Private WithEvents _UPlbl8 As UPLabel

    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtRefEquipment As UPTextBox
    Private WithEvents _UPTxtNameEquipment As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox
    Private WithEvents _UPTxtEquipmentFilter As UPTextBox

    Private WithEvents _UPCBoxEquipmentTypeList As UPComboBox
    Private WithEvents _UPCBoxEquipmentType As UPComboBox
    Private WithEvents _UPCBoxDataSourceInputList As UPComboBox
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Private WithEvents _ChcBoxIsAtomico As UPCheckBox

    Private WithEvents _UPTxtNumHp As UPTextBoxNumerico

    Private _IsEdit As Boolean = False
    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False
    Private _ListRefEquipment As List(Of String) '23/12

    Public Sub New()

        InitializeComponent()
        _IsInitialize = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Equipos para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefEquipment = GetColumnList(Of String)("equipment", "refEquipment")
        Dim _ListRefEquipment1 As New List(Of String)
        For Each _RefEquipment As String In _ListRefEquipment
            _ListRefEquipment1.Add(Trim(_RefEquipment))
        Next
        _ListRefEquipment = _ListRefEquipment1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnEquipmentType As New List(Of String)
        _ColumnEquipmentType.Add("nameEquipmentType")

        _UPCBoxEquipmentTypeList = New UPComboBox("equipmentType", _ColumnEquipmentType, "Tipo de Equipo", True)
        _UPCBoxEquipmentTypeList.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxEquipmentTypeList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxEquipmentTypeList.BackColor = Color.WhiteSmoke
        _UPCBoxEquipmentTypeList.Dock = DockStyle.Fill
        _UPCBoxEquipmentTypeList.SetSelectedItem(1)

        _UPTxtEquipmentFilter = New UPTextBox
        _UPTxtEquipmentFilter.Margin = New Padding(8, 0, 4, 8)
        _UPTxtEquipmentFilter.Dock = DockStyle.Fill

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: (SourceInput) Para la Lista
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInputList = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", False)
        _UPCBoxDataSourceInputList.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInputList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInputList.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInputList.Dock = DockStyle.Fill
        _UPCBoxDataSourceInputList.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Equipos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter As New JObject()

        If equipmentTypeId > 0 Then
            _dicValuesFilter = New JObject()
            _dicValuesFilter("equipmentType_id") = equipmentTypeId
        Else
            _dicValuesFilter = Nothing
        End If

        If appDataSourceInputId > 0 Then
            If _dicValuesFilter Is Nothing Then
                _dicValuesFilter = New JObject()
            End If

            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        Else
            _dicValuesFilter = Nothing
        End If

        _UPDGViewList = New UPDGViewList("equipment", "refEquipment", "nameEquipment", "Código", "Nombre del Equipo", _dicValuesFilter)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 0, 5, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl5 = New UPLabel("Fuente de Datos")
        _UPlbl6 = New UPLabel("Modo")
        _UPlbl7 = New UPLabel("Tipo de Equipo")
        _UPlbl8 = New UPLabel("HP")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  E q u i p o s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl4 = New UPLabel("E d i c i ó n  d e  E q u i p o s")
        _UPlbl4.SetFortmatEtiquetaInsumo()
        _UPlbl4.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefEquipment = New UPTextBox(13)
        _UPTxtNameEquipment = New UPTextBox(155)
        _UPTxtDescription = New UPTextBox(250)

        _ChcBoxIsAtomico = New UPCheckBox("Atómico")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInpute
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource2 As New List(Of String)
        _ColumnMaterialSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnMaterialSource2, "Fuente de Datos", True)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Equipment Type    
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnEquipmentType2 As New List(Of String)
        _ColumnEquipmentType2.Add("nameEquipmentType")
        _UPCBoxEquipmentType = New UPComboBox("equipmentType", _ColumnEquipmentType2, "Tipo de Equipo", True)
        _UPCBoxEquipmentType.BackColor = Color.WhiteSmoke

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Númerico
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtNumHp = New UPTextBoxNumerico(0, Double.NaN)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListEquipment.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListEquipment.Controls.Add(_UPCBoxDataSourceInputList, 0, 1)
        Me.tlpListEquipment.Controls.Add(_UPCBoxEquipmentTypeList, 0, 2)
        Me.tlpListEquipment.Controls.Add(_UPDGViewList, 0, 4)

        Me.tlpEquipmentLook.Controls.Add(_UPTxtEquipmentFilter, 0, 0)

        Me.tlpEquipment.Controls.Add(_UPlbl4, 0, 0)

        Me.tlpEquipment2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEquipment2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpEquipment2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpEquipment2.Controls.Add(_UPlbl6, 0, 4)
        Me.tlpEquipment2.Controls.Add(_UPlbl5, 0, 5)
        Me.tlpEquipment2.Controls.Add(_UPlbl7, 0, 6)
        Me.tlpEquipment2.Controls.Add(_UPlbl8, 0, 3)

        Me.tlpEquipment2.Controls.Add(_UPTxtRefEquipment, 1, 0)
        Me.tlpEquipment2.Controls.Add(_UPTxtNameEquipment, 1, 1)
        Me.tlpEquipment2.Controls.Add(_UPTxtDescription, 1, 2)
        Me.tlpEquipment2.Controls.Add(_ChcBoxIsAtomico, 1, 4)
        Me.tlpEquipment2.Controls.Add(_UPCBoxDataSourceInput, 1, 5)
        Me.tlpEquipment2.Controls.Add(_UPCBoxEquipmentType, 1, 6)
        Me.tlpEquipment2.Controls.Add(_UPTxtNumHp, 1, 3)

        btnGuardar.Enabled = False

        EnableControls(False)
        _IsInitialize = False

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

    Public ReadOnly Property IsCompositeEquipment As Boolean
        Get
            Return Not _ChcBoxIsAtomico.Checked
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

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _UPCBoxDataSourceInputList.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property equipmentTypeId As Int32
        Get
            Return _UPCBoxEquipmentTypeList.GetSelectedItemId()
        End Get
    End Property

    Public Function ValidateEquipment() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefEquipment.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameEquipment.Text, 155) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 250) Then
            Return False

        End If

        Return True

    End Function

    Public Sub cerrarFormulario() '051724
        Me.Close()
    End Sub

    Private Sub EnableControls(ByVal Enabled As Boolean)

        Me._UPTxtRefEquipment.Enabled = Enabled
        Me._UPTxtNameEquipment.Enabled = Enabled
        Me._UPTxtDescription.Enabled = Enabled
        Me._UPTxtNumHp.Enabled = Enabled
        Me._UPCBoxDataSourceInput.Enabled = Enabled
        Me._ChcBoxIsAtomico.Enabled = Enabled
        Me._UPCBoxEquipmentType.Enabled = Enabled
        Me._UPCBoxDataSourceInput.Enabled = Enabled

    End Sub

    Private Sub LoadEquipmentSelected()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("equipment", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            If _datatable.Rows.Count > 0 Then

                Me._UPTxtRefEquipment.Text = _datatable.Rows(0)("refEquipment")
                Me._UPTxtNameEquipment.Text = _datatable.Rows(0)("nameEquipment")
                Me._UPTxtDescription.Text = _datatable.Rows(0)("descriptionEquipment")
                Me._UPTxtNumHp.Value = _datatable.Rows(0)("equipmentHp")
                Me._ChcBoxIsAtomico.Checked = _datatable.Rows(0)("isAtomic")
                Me._UPCBoxEquipmentType.SetSelectedItem(_datatable.Rows(0)("equipmentType_id"))
                Me._UPCBoxDataSourceInput.SetSelectedItem(_datatable.Rows(0)("appDataSourceInput_id"))
            Else

                Me._UPTxtRefEquipment.Text = ""
                Me._UPTxtNameEquipment.Text = ""
                Me._UPTxtDescription.Text = ""
                Me._UPTxtNumHp.Value = Nothing
                Me._ChcBoxIsAtomico.Checked = False
                Me._UPCBoxDataSourceInput.SetSelectedItem(1)
                Me._UPCBoxEquipmentType.SetSelectedItem(1)

            End If

        End If

    End Sub

    Private Sub ReloadEquipment()

        Dim _dicValuesFilter As JObject = Nothing

        If equipmentTypeId > 0 Then
            _dicValuesFilter = New JObject()
            _dicValuesFilter("equipmentType_id") = equipmentTypeId
        Else
            _dicValuesFilter = Nothing
        End If

        If appDataSourceInputId > 0 Then
            If _dicValuesFilter Is Nothing Then
                _dicValuesFilter = New JObject()
            End If

            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        Else
            _dicValuesFilter = Nothing
        End If

        _UPDGViewList.ReLoadData(_dicValuesFilter, True)

    End Sub

    Private Sub ValidateRefEquipment() '23/12
        Dim _RefEquipment As String = _UPTxtRefEquipment.Text.Trim()
        If _ListRefEquipment.Contains(_RefEquipment) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_UPTxtRefEquipment.Focus()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidateEquipment() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()
            Dim _dicValues As New JObject()

            _dicValues("refEquipment") = Me._UPTxtRefEquipment.Text
            _dicValues("nameEquipment") = Me._UPTxtNameEquipment.Text
            _dicValues("descriptionEquipment") = Me._UPTxtDescription.Text
            '_dicValues("equipmentHp") = CType(_UPTxtNumHp.Value, Double)
            _dicValues("equipmentHp") = GetNotNulDouble(_UPTxtNumHp.Value) '01/25
            _dicValues("isAtomic") = Me._ChcBoxIsAtomico.Checked
            _dicValues("appDataSourceInput_id") = _UPCBoxDataSourceInput.GetSelectedItemId()
            _dicValues("equipmentType_id") = _UPCBoxEquipmentType.GetSelectedItemId()

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("equipment", _DataServices) IsNot Nothing Then

                    ReloadEquipment()
                    _UPDGViewList.SetSelectedItem(_SelectedIndex)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _IsEdit = False
                    EnableControls(False)
                    btnGuardar.Enabled = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("equipment", _DataServices) > 0 Then
                    ' _UPDGViewList.LoadList()
                    ReloadEquipment()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Enabled = False
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

        _UPTxtEquipmentFilter.Clear()


    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadEquipmentSelected()
        EnableControls(False)
        If Not _IsGuardando Then
            btnGuardar.Enabled = False
        End If

        _IsEdit = False

    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        If IsCompositeEquipment Then

            Dim _FormCompoundMaterial As New FormCompoundEquipment(selectedId)
            If _FormCompoundMaterial.ShowDialog(Me) = DialogResult.OK Then
                ReloadEquipment()
            End If

        Else
            btnGuardar.Enabled = True
            EnableControls(True)
            _IsEdit = True
        End If

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        'If MessageBox.Show("Nuevo Equipo compuesto?", "Equipo", MessageBoxButtons.YesNo,
        '                   MessageBoxIcon.Question) = MessageBoxResult.Yes Then

        '    Dim _FormCompoundEquipment As New FormCompoundEquipment(equipmentTypeId:=equipmentTypeId,
        '                                                          appDataSourceInputId:=appDataSourceInputId)
        '    If _FormCompoundEquipment.ShowDialog(Me) = DialogResult.OK Then ' HOY231024
        '        ReloadEquipment()
        '        '_UPDGViewList.LoadList()
        '        _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
        '    End If

        'Else
        'End If

        Me._UPTxtRefEquipment.Text = ""
        Me._UPTxtNameEquipment.Text = ""
        Me._UPTxtDescription.Text = ""
        Me._ChcBoxIsAtomico.Checked = True

        btnGuardar.Enabled = True
        EnableControls(True)
        Me._UPTxtRefEquipment.Focus()

        Me._UPTxtRefEquipment.TabIndex = 1
        Me._UPTxtNameEquipment.TabIndex = 2
        Me._UPTxtDescription.TabIndex = 3
        Me._UPTxtNumHp.TabIndex = 4
        Me._ChcBoxIsAtomico.TabIndex = 5
        Me._UPCBoxDataSourceInput.TabIndex = 6
        Me.btnGuardar.TabIndex = 7
        Me.btnDataSource.TabIndex = 8
        Me.btnCompoundEquipment.TabIndex = 9

    End Sub


    Private Sub FormEquipment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        splitContEqupment.SplitterDistance = 440

        splitContEqupment.Panel1MinSize = 220
        splitContEqupment.Panel2MinSize = 330

        Dim toolTipEquipment As New ToolTip()
        toolTipEquipment.AutoPopDelay = 5000
        toolTipEquipment.InitialDelay = 1000
        toolTipEquipment.ReshowDelay = 500
        toolTipEquipment.ShowAlways = True

        toolTipEquipment.SetToolTip(Me.btnEquipmentFilter, "Busca el Equipo")
        toolTipEquipment.SetToolTip(Me.btnDataSource, "Ir a Origen de Datos")
        toolTipEquipment.SetToolTip(Me.btnGuardar, "Guardar Equipo")
        toolTipEquipment.SetToolTip(Me._UPCBoxDataSourceInputList, "Origen de Datos")
        toolTipEquipment.SetToolTip(Me._UPCBoxDataSourceInput, "Asigna Origen de Datos")
        toolTipEquipment.SetToolTip(Me._UPTxtEquipmentFilter, "Filtro Dinámico Equipos")
        toolTipEquipment.SetToolTip(Me.btnCompoundEquipment, "Ir a Nuevo Equipo Compuesto")

    End Sub

    Private Sub btnEquipmentFilter_Click(sender As Object, e As EventArgs) Handles btnEquipmentFilter.Click
        _UPDGViewList.FilterList(_UPTxtEquipmentFilter.Text)
    End Sub

    Private Sub _UPTxtEquipmentFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtEquipmentFilter.TextChanged
        If String.IsNullOrEmpty(_UPTxtEquipmentFilter.Text) Then
            _UPDGViewList.FilterList(_UPTxtEquipmentFilter.Text)
        End If
    End Sub

    Private Sub _UPTxtEquipmentFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles _UPTxtEquipmentFilter.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    _UPDGViewList.FilterList(_UPTxtEquipmentFilter.Text)
        'End If
        _UPDGViewList.FilterList(_UPTxtEquipmentFilter.Text)
    End Sub

    Private Sub tlpListEquipment_Paint(sender As Object, e As PaintEventArgs) Handles tlpListEquipment.Paint

    End Sub

    Private Sub _UPCBoxEquipmentTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxEquipmentTypeList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadEquipment()
            LoadEquipmentSelected()
            _UPTxtEquipmentFilter.Text = ""
        End If
    End Sub
    Private Sub _UPCBoxDataSourceInputeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInputList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadEquipment()
            LoadEquipmentSelected()
            _UPTxtEquipmentFilter.Text = ""
        End If
    End Sub

    Private Sub btnDataSource_Click(sender As Object, e As EventArgs) Handles btnDataSource.Click
        Dim _FormAppDataSource As New FormDataSourceInput()
        _FormAppDataSource.ShowDialog()
    End Sub

    Private Sub btnCompoundEquipmet_Click(sender As Object, e As EventArgs) Handles btnCompoundEquipment.Click
        'Dim _FormCompoundEquipment As New FormCompoundEquipment()
        Dim _FormCompoundEquipment As New FormCompoundEquipment(equipmentTypeId:=equipmentTypeId,
                                                                  appDataSourceInputId:=appDataSourceInputId)
        _FormCompoundEquipment.Show(Me)
    End Sub

#Region "Bordes Botones"

    Private Sub btnDataSource_MouseEnter(sender As Object, e As EventArgs) Handles btnDataSource.MouseEnter
        btnDataSource.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnDataSource_MouseLeave(sender As Object, e As EventArgs) Handles btnDataSource.MouseLeave
        btnDataSource.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnGuardar_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnCompoundEquipment_MouseEnter(sender As Object, e As EventArgs) Handles btnCompoundEquipment.MouseEnter
        btnCompoundEquipment.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCompoundEquipment_MouseLeave(sender As Object, e As EventArgs) Handles btnCompoundEquipment.MouseLeave
        btnCompoundEquipment.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub _UPTxtRefEquipment_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefEquipment.Validating
        ValidateRefEquipment()
    End Sub

#End Region

End Class