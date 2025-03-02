Imports Newtonsoft.Json.Linq
Imports System.Windows.Media.Media3D
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.ComponentModel
Public Class FormCompoundEquipment
    Private _PanelListActived As System.Windows.Forms.UserControl = Nothing

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel

    Private WithEvents _UPTxtRefEquipment As UPTextBox
    Private WithEvents _UPTxtNameEquipment As UPTextBox
    Private WithEvents _UPTxtDescriptionEquipment As UPTextBox

    Private WithEvents _PanelListEquipment As PanelListEquipment = Nothing

    Private WithEvents _UPDGViewEquipmentInput As UPDataGridView = Nothing

    Private WithEvents _ContextMenuStripPrices As ContextMenuStrip
    Private WithEvents _MenuItemNewPrices As ToolStripMenuItem

    Private WithEvents _UPCBoxDataSourceInput As UPComboBox
    Private WithEvents _UPCBoxEquipmentType As UPComboBox

    Private _IsGuardando As Boolean = False
    Private _IsEdit As Boolean = False
    Private _equipment_id As Int32 = -1
    Private _ListRefEquipment As List(Of String) '23/12

    Public Sub New(Optional ByVal equipment_id As Int32 = -1, Optional equipmentTypeId As Int32 = -1,
                   Optional appDataSourceInputId As Int32 = -1)

        InitializeComponent()
        Me.Text = "Equipos Compuestos"
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
        'Panel de Lista
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter2 As New JObject()
        _dicValuesFilter2("isAtomic") = True

        _PanelListEquipment = New PanelListEquipment(_dicValuesFilter2)
        _PanelListEquipment.SetFiltersEquipment(equipmentTypeId, appDataSourceInputId)
        _PanelListActived = _PanelListEquipment

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _equipment_id = equipment_id

        If equipment_id > 0 Then
            _UPlbl0 = New UPLabel("E d i c i ó n  d e  E q u i p o  C o m p u e s t o")
            _IsEdit = True
        Else
            _UPlbl0 = New UPLabel("N u e v o   E q u i p o  C o m p u e s t o")
        End If

        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: _UPlbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Tipo de Equipo")
        _UPlbl5 = New UPLabel("Origen de Datos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefEquipment = New UPTextBox(13)

        _UPTxtRefEquipment.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
        _UPTxtNameEquipment = New UPTextBox(155)
        _UPTxtDescriptionEquipment = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInpute
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource2 As New List(Of String)
        _ColumnMaterialSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnMaterialSource2, "Origen de Datos", True)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInput.SetSelectedItem(appDataSourceInputId)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: equipmentType
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _columnamesEquipmentType As New List(Of String)
        _columnamesEquipmentType.Add("nameEquipmentType")
        _UPCBoxEquipmentType = New UPComboBox("equipmentType", _columnamesEquipmentType, "Tipo de Equipo", True)
        '_UPCBoxMaterialType.Margin = New System.Windows.Forms.Padding(4, 8, 8, 4)
        _UPCBoxEquipmentType.BackColor = Color.WhiteSmoke

        If equipmentTypeId > 0 Then
            _UPCBoxEquipmentType.SetSelectedItem(equipmentTypeId)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' ContextMenuStripPrices
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ContextMenuStripPrices = New ContextMenuStrip()

        _MenuItemNewPrices = New ToolStripMenuItem()
        _MenuItemNewPrices.Text = "Nuevo precio"

        _ContextMenuStripPrices.Items.Add(_MenuItemNewPrices)

        OnCrearCompoundEquipment()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me.PanelHeader2.Controls.Add(_UPlbl0)

        Me.tlpCEEdit2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpCEEdit2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpCEEdit3.Controls.Add(_UPlbl3, 0, 0)

        'Me.tlpCEEditLbl2.Controls.Add(_UPlbl5, 0, 0)
        'Me.tlpCEEditLbl2.Controls.Add(_UPlbl4, 0, 1)

        Me.tlpCEEditLbl2.Controls.Add(_UPCBoxDataSourceInput, 0, 0)
        Me.tlpCEEditLbl2.Controls.Add(_UPCBoxEquipmentType, 0, 1)

        'Me.tlpCEEditTex2.Controls.Add(_UPCBoxDataSourceInput, 0, 0)
        'Me.tlpCEEditTex2.Controls.Add(_UPCBoxEquipmentType, 0, 1)

        Me.tlpCEEditTex2.Controls.Add(_UPlbl5, 0, 0)
        Me.tlpCEEditTex2.Controls.Add(_UPlbl4, 0, 1)

        Me.tlpCEEdit2.Controls.Add(_UPTxtRefEquipment, 1, 0)
        Me.tlpCEEdit2.Controls.Add(_UPTxtNameEquipment, 1, 1)
        Me.tlpCEEdit3.Controls.Add(_UPTxtDescriptionEquipment, 1, 0)

        scCompoundEquipment.Panel1.Controls.Add(_PanelListActived)
        scCompoundEquipment.Panel2.Controls.Add(_UPDGViewEquipmentInput)

        LoadEquipmnet()

        scParent.Panel2Collapsed = True


    End Sub

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _PanelListEquipment.appDataSourceInputId
        End Get
    End Property

    Public ReadOnly Property compoundEquipment_Id As Int32
        Get
            Dim _compoundEquipment_Id As Object = _UPDGViewEquipmentInput.GetColumnValue("equipment_Id")
            If _compoundEquipment_Id IsNot Nothing Then
                Return _compoundEquipment_Id
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property compoundEquipmentUnit_Id As Int32
        Get
            Dim _PartidaEquipment_Id As Object = _UPDGViewEquipmentInput.GetColumnValue("unit_id")
            If _PartidaEquipment_Id IsNot Nothing Then
                Return _PartidaEquipment_Id
            Else
                Return -1
            End If
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

    Private Sub OnCrearCompoundEquipment()

        _UPDGViewEquipmentInput = New UPDataGridView("compoundEquipment")
        _UPDGViewEquipmentInput.Dock = DockStyle.Fill
        _UPDGViewEquipmentInput.ContextMenuStrip = _ContextMenuStripPrices

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cargar Columnas de: Equipo Compuesto
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewEquipmentInput.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column _equipment_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewEquipmentInput.CrearteColumnText("equipment_id", "equipment_id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add("refEquipment")
        _ColumnNames.Add("nameEquipment")

        Dim _CbxdicValuesFilter As New JObject()
        _CbxdicValuesFilter("isAtomic") = True

        _DataGridViewColumn = _UPDGViewEquipmentInput.CreateColumnComboBox("equipment2_id", "Código | Equipo", False, True, False,
                                                                               "equipment", _ColumnNames, "Equipo", True,
                                                                               _CbxdicValuesFilter)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.MinimumWidth = 300 '03/07
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        CType(_DataGridViewColumn, UPDataGridViewColumnComboBox).IsFilterOptionsList = True  'XXXXX

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Unidad
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames1 As New List(Of String)
        _ColumnNames1.Add("symbolUnit")
        Dim _dicValuesFilterUnit As New JObject()
        _dicValuesFilterUnit("unitEquipment") = True

        _DataGridViewColumn = _UPDGViewEquipmentInput.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                    "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)

        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        _DataGridViewColumn.Width = 200
        _DataGridViewColumn.MinimumWidth = 60 '03/07


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cantidad
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewEquipmentInput.CrearteColumnFloat("quantityEquipment", "Cantidad", False, True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        _DataGridViewColumn.Width = 200
        _DataGridViewColumn.MinimumWidth = 60 '03/07


        _UPDGViewEquipmentInput.SetUPDGViewReadOnly(False)
        _UPDGViewEquipmentInput.SetColumnReadOnly("equipment_id", True)

    End Sub

    Private Sub LoadEquipmnet()

        If _equipment_id > 0 Then

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar equipos
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _id As Int32 = _equipment_id

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("equipment", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefEquipment.Text = _datatable.Rows(0)("refEquipment")
            _UPTxtNameEquipment.Text = _datatable.Rows(0)("nameEquipment")
            _UPTxtDescriptionEquipment.Text = _datatable.Rows(0)("descriptionEquipment")
            _UPCBoxEquipmentType.SetSelectedItem(_datatable.Rows(0)("equipmentType_id"))

            RefrechTables()

        End If
    End Sub

    Private Sub AddInsumo()

        If equipment_Id > 0 Then

            Dim _List As List(Of Int32) = _UPDGViewEquipmentInput.GetListValues(Of Int32)("equipment_id")

            If _List.Contains(equipment_Id) Then

                MessageBox.Show($"Equipo '{equipmentName}' cargado", "Equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Dim _dicValues As New JObject()
                _dicValues("equipment2_id") = equipment_Id
                _dicValues("quantityEquipment") = 1
                _dicValues("unit_id") = 2

                _UPDGViewEquipmentInput.LoadRow(_dicValues)
            End If

            _UPDGViewEquipmentInput.StartEditing()
            _UPDGViewEquipmentInput.AllowUserToAddRows = False
        End If
    End Sub

    Public Function ValidateCopmEquipment() As Boolean

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
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefEquipment.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameEquipment.Text, 155) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescriptionEquipment.Text, 250) Then
            Return False

        End If

        Return True

    End Function

    Private Sub RefrechTables()
        Dim _dicValuesFilter As New JObject
        _dicValuesFilter("equipment_id") = _equipment_id

        _UPDGViewEquipmentInput.ReLoadData(_dicValuesFilter)

        'ValidatePrecios()
    End Sub

    Private Sub SavesCompoundEquipment()

        If ValidateCopmEquipment() Then

            _IsGuardando = True

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Guardando Partida
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()


            _dicValues("refEquipment") = _UPTxtRefEquipment.Text
            _dicValues("nameEquipment") = _UPTxtNameEquipment.Text
            _dicValues("descriptionEquipment") = _UPTxtDescriptionEquipment.Text
            _dicValues("isAtomic") = False
            _dicValues("equipmentType_id") = _UPCBoxEquipmentType.GetSelectedItemId()
            _dicValues("appDataSourceInput_id") = appDataSourceInputId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                _dicValues("id") = _equipment_id

                If GetUpdateTable("equipment", _DataServices) IsNot Nothing Then

                    _UPDGViewEquipmentInput.Saves("equipment_id", _equipment_id)

                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            Else

                _equipment_id = GetInsertTable("equipment", _DataServices)

                If _equipment_id > 0 Then

                    _UPDGViewEquipmentInput.Saves("equipment_id", _equipment_id)

                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    _IsEdit = True
                    DialogResult = DialogResult.OK ' HOY131124
                    Close()
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            End If

            _IsGuardando = False

        End If
    End Sub

    Private Sub ValidateRefEquipment() '23/12
        Dim _RefEquipment As String = _UPTxtRefEquipment.Text.Trim()
        If _ListRefEquipment.Contains(_RefEquipment) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_UPTxtRefEquipment.Focus()
        End If

    End Sub

    Private Sub _PanelListEquipment_DoubleClick(sender As Object, e As EventArgs) Handles _PanelListEquipment.EvDoubleClick
        AddInsumo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SavesCompoundEquipment()

        'If IsReportPriceAnalysisShow Then
        '    ReportPriceAnalysisShowRefresh()
        'End If
    End Sub

    Private Sub _UPDGViewPartidaEquipment_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles _UPDGViewEquipmentInput.CellBeginEdit
        If e.ColumnIndex = 2 Then
            e.Cancel = True
        End If
    End Sub

#Region "NewPrices"
    Private Sub _ContextMenuStripPrices_Opening(sender As Object, e As CancelEventArgs) Handles _ContextMenuStripPrices.Opening
        _MenuItemNewPrices.Enabled = compoundEquipment_Id > 0
    End Sub

    Private Sub _MenuItemNewPrices_Click(sender As Object, e As EventArgs) Handles _MenuItemNewPrices.Click

        Dim _FormequipmentCostPyOUserModal As New FormequipmentCostPyOUserModal(compoundEquipmentUnit_Id, compoundEquipmentUnit_Id)
        If _FormequipmentCostPyOUserModal.ShowDialog(Me) = DialogResult.OK Then
            'ReportPriceAnalysisShowRefresh()
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub FormCompoundEquipment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
    End Sub

    Private Sub _UPTxtRefEquipment_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefEquipment.Validating
        ValidateRefEquipment()
    End Sub

#End Region

End Class