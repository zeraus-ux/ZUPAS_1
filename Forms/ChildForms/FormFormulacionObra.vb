Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.Windows.Media.Media3D
Imports FontAwesome.Sharp
Imports Newtonsoft.Json.Linq
Imports System.Drawing
Imports System.Drawing.Drawing2D

Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports System.Windows.Forms.DataGrid
Imports MS.Internal.WindowsRuntime.Windows
Imports System.Security.Policy
Imports System.Windows.Media.Animation
Imports Microsoft.Reporting.WinForms

Public Class FormFormulacionObra

    Private WithEvents _MenuItemEditEtapa As ToolStripMenuItem
    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel

    Private WithEvents _UPTxtRefObra As UPTextBox
    Private WithEvents _UPTxtNameObra As UPTextBox
    Private WithEvents _UPTxtDescriptionObra As UPTextBox
    Private WithEvents _UPTxtObraFilter As UPTextBox

    Private WithEvents _UPComboBoxEtapa As UPComboBox
    Private WithEvents _UPCBoxDataSourceInputList As UPComboBox
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Private WithEvents _UPDateTimePicker As UPDateTimePicker
    Private WithEvents _UPDGViewobraCostValue As UPDataGridView

    Private WithEvents _TabControlEtapas As System.Windows.Forms.TabControl

    Private WithEvents _ButtontemReportPartida As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _ButtontemvIEWPartida As System.Windows.Forms.ToolStripMenuItem

    Private WithEvents _ContextMenuStripPartida As ContextMenuStrip

    Private _IsCargandoConstructor = False
    Private _IsGuardando As Boolean = False
    Private _IsEdit As Boolean = False
    Private _HeigntBaseTable As Int16 = 300

    Private _LisTabPaque As New List(Of System.Windows.Forms.TabPage)
    Private _OptionsListEtapasDefaolt As List(Of (Name As String, Id As Integer, ImageKey As String))
    Private _dicUPDGViewObraStagePartida As New Dictionary(Of Int16, UPDataGridView)
    Private _dicIdEtapas As New Dictionary(Of Int16, Int32)

    Private _IdPartidaSelececionada As Int32 = -1

    Private WithEvents _formBudget As FormBudget = Nothing

    Public Sub New()

        InitializeComponent()

        _IsCargandoConstructor = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'ContextMenuStripPartida
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ContextMenuStripPartida = New ContextMenuStrip()

        _ButtontemReportPartida = New System.Windows.Forms.ToolStripMenuItem()
        _ButtontemReportPartida.Name = "_ButtontemReportPartida"
        _ButtontemReportPartida.Size = New System.Drawing.Size(213, 24)
        _ButtontemReportPartida.Text = "Report"
        _ContextMenuStripPartida.Items.Add(_ButtontemReportPartida)

        _ButtontemvIEWPartida = New System.Windows.Forms.ToolStripMenuItem()
        _ButtontemvIEWPartida.Name = "_ButtontemvIEWPartida"
        _ButtontemvIEWPartida.Size = New System.Drawing.Size(213, 24)
        _ButtontemvIEWPartida.Text = "View Partida"
        _ContextMenuStripPartida.Items.Add(_ButtontemvIEWPartida)

        _MenuItemEditEtapa = New ToolStripMenuItem()
        _MenuItemEditEtapa.Text = "Etapas"

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista: Obras
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter0 As New JObject
        _dicValuesFilter0("project_id") = ProjectSelectedId

        _UPDGViewList = New UPDGViewList("obra", "refObra", "nameObra", "Código", "Nombre de la obra", _dicValuesFilter0)
        _UPDGViewList.LoadMenuItem(New ToolStripSeparator())
        _UPDGViewList.LoadMenuItem(_MenuItemEditEtapa)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        '_UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Etapa")
        _UPlbl5 = New UPLabel("Fecha Precio")
        _UPlbl7 = New UPLabel("Origen de Datos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  O b r a s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl6 = New UPLabel("E d i c i ó n  d e  O b r a s")
        _UPlbl6.SetFortmatEtiquetaInsumo()
        _UPlbl6.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefObra = New UPTextBox(12)
        _UPTxtNameObra = New UPTextBox(155)
        _UPTxtDescriptionObra = New UPTextBox(250)
        _UPTxtObraFilter = New UPTextBox()
        _UPTxtObraFilter.Margin = New System.Windows.Forms.Padding(8, 4, 8, 4)

        _UPComboBoxEtapa = New UPComboBox()
        _UPDateTimePicker = New UPDateTimePicker()

        _OptionsListEtapasDefaolt = New List(Of (Name As String, Id As Integer, ImageKey As String))
        For i As Int16 = 1 To 10
            Dim _Name As String = String.Format("{0} Etapas", i)
            Dim _Id As Integer = i
            Dim _ImageKey As String = String.Format("{0} Etapas", i)
            _OptionsListEtapasDefaolt.Add((_Name, _Id, _ImageKey))
        Next

        _UPComboBoxEtapa.Load(_OptionsListEtapasDefaolt)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: (SourceInput) Para la Lista
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnImputSource As New List(Of String)
        _ColumnImputSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInputList = New UPComboBox("appDataSourceInput", _ColumnImputSource, "Origen de Datos", False)
        _UPCBoxDataSourceInputList.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInputList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInputList.BackColor = System.Drawing.Color.WhiteSmoke
        _UPCBoxDataSourceInputList.Dock = DockStyle.Fill
        _UPCBoxDataSourceInputList.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInpute
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnImputSource2 As New List(Of String)
        _ColumnImputSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnImputSource2, "Origen de Datos", True)
        _UPCBoxDataSourceInput.BackColor = System.Drawing.Color.WhiteSmoke

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListObra.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpObraLook.Controls.Add(_UPTxtObraFilter, 0, 0)
        Me.tlpListObra.Controls.Add(_UPCBoxDataSourceInputList, 0, 1)
        Me.tlpListObra.Controls.Add(_UPDGViewList, 0, 3)

        Me.tlpObra.Controls.Add(_UPlbl6, 0, 0)

        Me.tlpObraEdit2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpObraEdit2.Controls.Add(_UPlbl2, 0, 1)
        ' Me.tlpObraEdit.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpObraEdit2.Controls.Add(_UPlbl7, 0, 2)
        Me.tlpObraEdit2.Controls.Add(_UPlbl4, 0, 3)
        Me.tlpObraEdit2.Controls.Add(_UPlbl5, 0, 4)

        Me.tlpObraEdit2.Controls.Add(_UPTxtRefObra, 1, 0)
        Me.tlpObraEdit2.Controls.Add(_UPTxtNameObra, 1, 1)
        Me.tlpObraEdit2.Controls.Add(_UPCBoxDataSourceInput, 1, 2)
        Me.tlpObraEdit2.Controls.Add(_UPComboBoxEtapa, 1, 3)
        Me.tlpObraEdit2.Controls.Add(_UPDateTimePicker, 1, 4)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'TabControlEtapas
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        _TabControlEtapas = New System.Windows.Forms.TabControl()
        _TabControlEtapas.Dock = DockStyle.Fill

        For i As Int16 = 1 To 10
            Dim _TappagueEtapa As New System.Windows.Forms.TabPage(String.Format("{0} Etapas", i))
            _TabControlEtapas.TabPages.Add(_TappagueEtapa)
            _LisTabPaque.Add(_TappagueEtapa)
            createComputo(_TappagueEtapa)
        Next

        Me.PanelCalculation.Controls.Add(_TabControlEtapas)
        _UPComboBoxEtapa.SetSelectedFirtItem()

        _UPDGViewList.SetSelectedItem(0)

        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf Me.OnProjectSeletedChnge

        OnCrearObraCost(True)
        EnableControls(False)

        _IsCargandoConstructor = False
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

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _UPCBoxDataSourceInputList.GetSelectedItemId()
        End Get
    End Property

    Public Function ValidateObra() As Boolean

        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefObra.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameObra.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescriptionObra.Text, 250) Then
            Return False

        ElseIf Not ValidateDoubleIsNA("columnaprueba", Double.NaN) Then
            Return False

        End If

        Return True

    End Function

    Private Sub SetUPDGViewReadOnly(ByRef vUPDataGridView As UPDataGridView, ByVal IsReadOnly As Boolean)
        If vUPDataGridView IsNot Nothing Then
            If IsReadOnly Then

                vUPDataGridView.EndEditing()
                For Each columna As DataGridViewColumn In vUPDataGridView.Columns
                    columna.ReadOnly = True
                Next
            Else
                vUPDataGridView.StartEditing()
                For Each columna As DataGridViewColumn In vUPDataGridView.Columns
                    columna.ReadOnly = False
                Next
            End If
        End If
    End Sub

    Private Function GetOptListEtapas(ByVal obra_id As Int32) As List(Of (Name As String, Id As Integer, ImageKey As String))


        Dim _OptListEtapas As List(Of (Name As String, Id As Integer, ImageKey As String))

        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add("nameStage")

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("obra_id") = obra_id

        _OptListEtapas = GetOptionsList("obraStage", _ColumnNames, "Etapa", True, _dicValuesFilter)

        Return _OptListEtapas

    End Function

    Private Sub OnCrearObraCost(ByVal IsNew As Boolean)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cost
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDGViewobraCostValue
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDGViewobraCostValue = New UPDataGridView("obraCostValue")
        _UPDGViewobraCostValue.Dock = DockStyle.Fill
        _UPDGViewobraCostValue.EditMode = DataGridViewEditMode.EditOnEnter
        _UPDGViewobraCostValue.AllowUserToAddRows = False
        _UPDGViewobraCostValue.AllowUserToDeleteRows = False
        _UPDGViewobraCostValue.AllowUserToOrderColumns = False
        _UPDGViewobraCostValue.AllowUserToResizeColumns = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewobraCostValue.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Obra_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewobraCostValue.CrearteColumnText("Obra_id", "Obra_id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cost_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames2 As New List(Of String)
        _ColumnNames2.Add("refCostValue")
        _ColumnNames2.Add("nameCostValue")

        _DataGridViewColumn = _UPDGViewobraCostValue.CreateColumnComboBox("appCostValue_id", "Variables Administrativas", True, True, False,
                                                                          "appCostValue", _ColumnNames2, "cost", True)

        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DataGridViewColumn.ReadOnly = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Value
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewobraCostValue.CrearteColumnFloat("defaultCostUser", "Value", False, True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.Width = 150

        If IsNew Then
            Dim _DataTable1 = GetNewObraCostValue(ProjectSelectedId)
            _UPDGViewobraCostValue.DataSource = _DataTable1

        Else
            Dim _ColumnNames3 As New List(Of String)

            Dim _dicValuesFilter2 As New JObject()
            _dicValuesFilter2("Obra_id") = selectedId

            Dim _DataTable1 = GetDataTable("obraCostValue", ColumnNames:=_ColumnNames3,
                                                       dicValuesFilter:=_dicValuesFilter2)
            _UPDGViewobraCostValue.DataSource = _DataTable1
        End If

    End Sub

    Private Sub EnableControls(ByVal Enabled As Boolean)

        If Not _IsCargandoConstructor Then

            _UPTxtRefObra.Enabled = Enabled
            _UPTxtNameObra.Enabled = Enabled
            _UPTxtDescriptionObra.Enabled = Enabled
            _UPComboBoxEtapa.Enabled = Enabled
            _UPDateTimePicker.Enabled = Enabled
            _UPCBoxDataSourceInput.Enabled = Enabled

            For Each kvp As KeyValuePair(Of Int16, UPDataGridView) In _dicUPDGViewObraStagePartida
                Dim _UPDGViewObraStagePartida As UPDataGridView = kvp.Value
                _UPDGViewObraStagePartida.ReadOnly = Not Enabled
                SetUPDGViewReadOnly(_UPDGViewObraStagePartida, Not Enabled)
            Next

            'SetUPDGViewReadOnly(_UPDGViewObraCost, Not Enabled)

            _UPDGViewobraCostValue.Columns("appCostValue_id").ReadOnly = True
            _UPDGViewobraCostValue.Columns("defaultCostUser").ReadOnly = Not Enabled

        End If

    End Sub

    Private Sub VisibleEtapas()
        _TabControlEtapas.TabPages.Clear()

        Dim _NumEtapas As Int16 = _UPComboBoxEtapa.GetSelectedItemId()
        For i As Int16 = 0 To _NumEtapas - 1
            _TabControlEtapas.TabPages.Add(_LisTabPaque(i))
        Next
    End Sub

    Private Sub loadObraSelected()

        If HasSelectedItem Then

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar Obra
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("obra", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            If _datatable.Rows.Count > 0 Then
                _UPTxtRefObra.Text = _datatable.Rows(0)("refObra")
                _UPTxtNameObra.Text = _datatable.Rows(0)("nameObra")

                _UPCBoxDataSourceInput.SetSelectedItem(_datatable.Rows(0)("appDataSourceInput_id"))


            Else
                _UPTxtRefObra.Text = ""
                _UPTxtNameObra.Text = ""

                _UPCBoxDataSourceInput.SetSelectedItem(1)

            End If

            'preguntar a daniel si esto va dentro del if

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Set Etapas
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _OptListEtapas As List(Of (Name As String, Id As Integer, ImageKey As String)) = GetOptListEtapas(selectedId)
            If _OptListEtapas.Count = 0 Then
                _UPComboBoxEtapa.SetSelectedItem(1)
            Else
                _UPComboBoxEtapa.SetSelectedItem(_OptListEtapas.Count)
            End If

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar ObraStagePartida
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            _dicIdEtapas.Clear()
            Dim _IndexEtape As Int16 = 0
            For Each _Item As (Name As String, Id As Integer, ImageKey As String) In _OptListEtapas

                Dim _ColumnNames1 As New List(Of String)

                Dim _dicValuesFilter1 As New JObject()
                _dicValuesFilter1("obraStage_id") = _Item.Id

                _dicUPDGViewObraStagePartida(_IndexEtape).ReLoadData(_dicValuesFilter1, False)
                _dicIdEtapas.Add(_IndexEtape, _Item.Id)


                _IndexEtape += 1
            Next

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar obraCostValue
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            OnCrearObraCost(False)

        End If
    End Sub

    Private Sub createComputo(ByRef TappagueEtapa As System.Windows.Forms.TabPage)

        Dim _UPDGViewObraStagePartida As New UPDataGridView("obraStagePartida")
        _UPDGViewObraStagePartida.Dock = DockStyle.Fill
        _UPDGViewObraStagePartida.ContextMenuStrip = _ContextMenuStripPartida

        _UPDGViewObraStagePartida.RowHeadersVisible = False '04/03

        AddHandler _UPDGViewObraStagePartida.RowEnter, AddressOf OnUPDGViewObraStagePartidaRowEnter

        SetUPDGViewReadOnly(_UPDGViewObraStagePartida, True)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
        'Cargar Columnas de: ObraStagePartida
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--------------
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewObraStagePartida.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column partida_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewObraStagePartida.CrearteColumnText("obraStage_id", "obraStage_id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add("refPartida")
        _ColumnNames.Add("namePartida")


        Dim _dicValuesFilter As JObject = Nothing

        'Dim _dicValuesFilter As New JObject()
        '_dicValuesFilter("project_id") = ProjectSelectedId

        'Dim _dicValuesFilter As New JObject()
        '_dicValuesFilter("chapter_id") = 8

        _DataGridViewColumn = _UPDGViewObraStagePartida.CreateColumnComboBox("partida_id", "Código | Partida", False, True, False,
                                                                       "partida", _ColumnNames, "Partida", True, _dicValuesFilter)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        CType(_DataGridViewColumn, UPDataGridViewColumnComboBox).IsFilterOptionsList = True  'XXXXX

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Unidad
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames1 As New List(Of String)
        _ColumnNames1.Add("symbolUnit")

        Dim _dicValuesFilterUnit As New JObject()
        _dicValuesFilterUnit("unitPartida") = True

        _DataGridViewColumn = _UPDGViewObraStagePartida.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                            "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)

        _DataGridViewColumn.Visible = True

        _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        _DataGridViewColumn.Width = 200

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cantidad
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _DataGridViewColumn = _UPDGViewObraStagePartida.CrearteColumnFloat("quantityPartida", "Cantidad", False, True)
        _DataGridViewColumn.Visible = True

        TappagueEtapa.Controls.Add(_UPDGViewObraStagePartida)

        _dicUPDGViewObraStagePartida.Add(TappagueEtapa.TabIndex, _UPDGViewObraStagePartida)

        _UPDGViewObraStagePartida.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))

        _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        _DataGridViewColumn.Width = 200

    End Sub

    Private Sub OnDesabilitaEdit()

        loadObraSelected()
        EnableControls(False)
        If Not _IsGuardando Then
            btnSave.Visible = False
        End If
        _IsEdit = False

    End Sub

    Private Sub OnProjectSeletedChnge(sender As Object, e As EventArgs)

        If ProjectSelectedId > 0 Then
            Dim _dicValuesFilter0 As New JObject
            _dicValuesFilter0("project_id") = ProjectSelectedId

            _UPDGViewList.LoadList(_dicValuesFilter0)
            _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

            _IsEdit = False
            EnableControls(False)
            btnSave.Visible = False
        Else
            FormInicio()
        End If

    End Sub

    Private Sub OnUPDGViewObraStagePartidaRowEnter(sender As Object, e As DataGridViewCellEventArgs)
        If sender.SelectedRows IsNot Nothing AndAlso sender.SelectedRows.Count > 0 Then
            Dim _DataGridViewRow As DataGridViewRow = sender.SelectedRows(0)
            If IsDBNull(_DataGridViewRow.Cells.Item("partida_id").Value) Then
                _IdPartidaSelececionada = sender.GetDefaultValues("partida_id")
            Else
                _IdPartidaSelececionada = _DataGridViewRow.Cells.Item("partida_id").Value
            End If
        Else
            _IdPartidaSelececionada = -1
        End If
    End Sub

    Public Sub ReloadObras()

        Dim _dicValuesFilterObras As JObject

        If appDataSourceInputId > 0 Then
            _dicValuesFilterObras = New JObject()
            _dicValuesFilterObras("appDataSourceInput_id") = appDataSourceInputId
        Else
            _dicValuesFilterObras = Nothing
        End If

        _UPDGViewList.ReLoadData(_dicValuesFilterObras, True)

        _UPDGViewList.SetSelectedItem(0)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)

        If ValidateObra() Then

            _IsGuardando = True

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Guardando Obra
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("project_id") = ProjectSelectedId
            _dicValues("refObra") = _UPTxtRefObra.Text
            _dicValues("nameObra") = _UPTxtNameObra.Text
            _dicValues("created") = Now().ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("updated") = Now().ToString("yyyy-MM-dd HH:mm:ss")
            ' _dicValues("descriptionObra") = _UPTxtDescriptionObra.Text
            _dicValues("budgetPrice") = CType(_UPDateTimePicker.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                _dicValues("id") = selectedId

                If GetUpdateTable("obra", _DataServices) IsNot Nothing Then '0203

                    Dim _idObra As Int32 = selectedId '0203

                    Dim _NumEtapas As Int16 = _UPComboBoxEtapa.GetSelectedItemId()

                    For i As Int16 = 0 To _NumEtapas - 1
                        If _dicIdEtapas.ContainsKey(i) Then
                            _dicUPDGViewObraStagePartida(i).Saves("obraStage_id", _dicIdEtapas(i))
                        End If
                    Next

                    _UPDGViewobraCostValue.Saves("obra_id", _idObra)

                    Dim _dicValuesFilter0 As New JObject
                    _dicValuesFilter0("project_id") = ProjectSelectedId

                    _UPDGViewList.LoadList(_dicValuesFilter0)
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnSave.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                Dim _idObra As Int32 = GetInsertTable("obra", _DataServices)
                If _idObra > 0 Then

                    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    'Etapas
                    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    Dim _NumEtapas As Int16 = _UPComboBoxEtapa.GetSelectedItemId()
                    _dicIdEtapas.Clear()
                    For i As Int16 = 0 To _NumEtapas - 1
                        Dim _DataServices1 As New JArray()

                        Dim _dicValues1 As New JObject()
                        _dicValues1("refStage") = String.Format("Etapa {0} ", i + 1)
                        _dicValues1("nameStage") = String.Format("Etapa {0} ", i + 1)
                        _dicValues1("descriptionStage") = String.Format("Etapa {0} ", i + 1)
                        _dicValues1("obra_id") = _idObra

                        _DataServices1.Add(_dicValues1)

                        Dim _idobraStage As Int32 = GetInsertTable("obraStage", _DataServices1)
                        If _idobraStage > 0 Then
                            _dicIdEtapas.Add(i, _idobraStage)
                            _dicUPDGViewObraStagePartida(i).Saves("obraStage_id", _idobraStage)
                        End If
                    Next

                    _UPDGViewobraCostValue.Saves("obra_id", _idObra)

                    Dim _dicValuesFilter0 As New JObject
                    _dicValuesFilter0("project_id") = ProjectSelectedId

                    _UPDGViewList.LoadList(_dicValuesFilter0)
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)

                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnSave.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged
        If Not _IsCargandoConstructor Then
            OnDesabilitaEdit()
        End If

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        Dim _FormBudget As FormBudget

        Dim _ProgressBarLock1 As Object = GetProgressBarDialog("Loading Data...") 'Barra de Progreso

        Try
            _FormBudget = New FormBudget(appDataSourceInputId:=appDataSourceInputId)

            EndProgressBarDialog(_ProgressBarLock1)
        Catch ex As Exception
            EndProgressBarDialog(_ProgressBarLock1)
            Throw ex
        End Try

        If _FormBudget.ShowDialog(Me) = DialogResult.OK Then
            ReloadObras()
            Dim _dicValuesFilter0 As New JObject
            _dicValuesFilter0("project_id") = ProjectSelectedId

            _UPDGViewList.LoadList(_dicValuesFilter0)
            _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
        End If

    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        Dim _FormBudget As FormBudget
        'Dim _FormBudget As FormBudget
        Dim _ProgressBarLock1 As Object = GetProgressBarDialog("Loading Data...") 'Barra de Progreso

        Try
            _FormBudget = New FormBudget(selectedId, appDataSourceInputId:=appDataSourceInputId)

            EndProgressBarDialog(_ProgressBarLock1)
        Catch ex As Exception
            EndProgressBarDialog(_ProgressBarLock1)
            Throw ex
        End Try


        If _FormBudget.ShowDialog(Me) = DialogResult.OK Then
            ReloadObras()
            Dim _dicValuesFilter0 As New JObject
            _dicValuesFilter0("project_id") = ProjectSelectedId

            _UPDGViewList.LoadList(_dicValuesFilter0)
            _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
        End If


    End Sub

    Private Sub _UPComboBoxEtapa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPComboBoxEtapa.SelectedIndexChanged
        VisibleEtapas()
    End Sub

    Private Sub _ButtontemReportPartida_Click(sender As Object, e As EventArgs) Handles _ButtontemReportPartida.Click
        Dim _Report As New FormReportPriceAnalysis(_IdPartidaSelececionada, selectedId)
        _Report.Show(Me)
    End Sub

    Private Sub _ButtontemvIEWPartida_Click(sender As Object, e As EventArgs) Handles _ButtontemvIEWPartida.Click
        If _IdPartidaSelececionada > 0 Then
            ViewPartida(_IdPartidaSelececionada)
        End If

    End Sub

    Private Sub _ContextMenuStripPartida_Opening(sender As Object, e As CancelEventArgs) Handles _ContextMenuStripPartida.Opening

        _ButtontemReportPartida.Enabled = _IdPartidaSelececionada > 0 And Not btnSave.Visible
        _ButtontemvIEWPartida.Enabled = _IdPartidaSelececionada > 0 And Not btnSave.Visible
    End Sub

    Private Sub _MenuItemEditEtapa_Click(sender As Object, e As EventArgs) Handles _MenuItemEditEtapa.Click
        Dim _FormStageModal As New FormStageModal(selectedId)
        _FormStageModal.ShowDialog()

    End Sub

    Private Sub FormFormulacionObra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler CommonFuntion.EvProjectSeletedChnge, AddressOf Me.OnProjectSeletedChnge
    End Sub

    Private Sub btnReport_Click_1(sender As Object, e As EventArgs) Handles btnReport.Click

        Dim _FormSelectReport As New FormSelectReport()

        If _FormSelectReport.ShowDialog(Me) = DialogResult.OK Then
            Dim _Report As New FormReportPresupuesto(selectedId, _FormSelectReport.PresupuestoType)
            _Report.Show(Me)

        End If


        'If MessageBox.Show("quieres por charter?", "report", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
        '    Dim _Report As New FormReportPresupuesto(selectedId, True)

        '    _Report.Show(Me)
        'Else
        '    Dim _Report As New FormReportPresupuesto(selectedId, False)
        '    _Report.Show(Me)
        'End If
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim _FormObraCost As New FormObraCost(_UPDGViewobraCostValue)
        _FormObraCost.ShowDialog(Me)
    End Sub

    Private Sub _UPTxtObraFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtObraFilter.TextChanged
        _UPDGViewList.FilterList(_UPTxtObraFilter.Text)
    End Sub

    Private Sub btnStage_Click(sender As Object, e As EventArgs) Handles btnStage.Click
        Dim _FormStageModal As New FormStageModal(selectedId)
        _FormStageModal.ShowDialog()

        'no obedece el size ????????
        _FormStageModal.Size = New System.Drawing.Size(1000, 500)
        _FormStageModal.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub FormFormulacionObra_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        splitContObra.SplitterDistance = 440
        splitContObra.Panel1MinSize = 220
        splitContObra.Panel2MinSize = 330

        Dim toolTipMat As New System.Windows.Forms.ToolTip()
        toolTipMat.AutoPopDelay = 5000
        toolTipMat.InitialDelay = 1000
        toolTipMat.ReshowDelay = 500
        toolTipMat.ShowAlways = True

        toolTipMat.SetToolTip(Me.btnStage, "Editar Etapas de la Obra")
        toolTipMat.SetToolTip(Me.btnCost, "Costos de la Obra")
        toolTipMat.SetToolTip(Me.btnObraFilter, "Costos de la Obra")
        toolTipMat.SetToolTip(Me.btnPUObra, "Reporte APU de las Partidas de la Obra")
        toolTipMat.SetToolTip(Me.btnReport, "Reporte Presupuesto de la Obra")
        toolTipMat.SetToolTip(Me.btnReportMat, "Reporte de Materiales de la Obra")
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnReportMat.Click
        Dim _ReportMaterialList As New FormMaterialList2(selectedId, False)
        _ReportMaterialList.Show(Me)
    End Sub

#Region "Bordes Botones"

    Private Sub btnCost_MouseEnter(sender As Object, e As EventArgs) Handles btnCost.MouseEnter
        btnCost.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCost_MouseLeave(sender As Object, e As EventArgs) Handles btnCost.MouseLeave
        btnCost.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnReport_MouseEnter(sender As Object, e As EventArgs) Handles btnReport.MouseEnter
        btnReport.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReport_MouseLeave(sender As Object, e As EventArgs) Handles btnReport.MouseLeave
        btnReport.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnStage_MouseEnter(sender As Object, e As EventArgs) Handles btnStage.MouseEnter
        btnStage.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnStage_MouseLeave(sender As Object, e As EventArgs) Handles btnStage.MouseLeave
        btnStage.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnReportMat_MouseEnter(sender As Object, e As EventArgs) Handles btnReportMat.MouseEnter
        btnReportMat.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReportMat_MouseLeave(sender As Object, e As EventArgs) Handles btnReportMat.MouseLeave
        btnReportMat.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnPUObra_MouseEnter(sender As Object, e As EventArgs) Handles btnPUObra.MouseEnter
        btnPUObra.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnPUObra_MouseLeave(sender As Object, e As EventArgs) Handles btnPUObra.MouseLeave
        btnPUObra.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub _UPCBoxDataSourceInputList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInputList.SelectedIndexChanged
        ReloadObras()
        loadObraSelected()
        _UPTxtObraFilter.Text = ""
    End Sub

    Private Sub btnPUObra_Click(sender As Object, e As EventArgs) Handles btnPUObra.Click
        'Daniel 03/12/24
        Dim _ReportViewers As New List(Of ReportViewer)

        For Each kvp As KeyValuePair(Of Int16, UPDataGridView) In _dicUPDGViewObraStagePartida
            Dim _UPDGViewObraStagePartida As UPDataGridView = kvp.Value
            For Each row As DataGridViewRow In _UPDGViewObraStagePartida.Rows
                Dim _partida_id As Int32 = row.Cells("partida_id").Value
                Dim _Report As New FormReportPriceAnalysis(_partida_id, selectedId)
                '_Report.Show(Me)

                _ReportViewers.Add(_Report.ReportViewer1)
            Next
        Next

        GetFile(_ReportViewers)

    End Sub


#End Region

End Class