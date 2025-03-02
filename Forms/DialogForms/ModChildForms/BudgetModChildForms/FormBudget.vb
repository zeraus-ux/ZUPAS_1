Imports Newtonsoft.Json.Linq
Imports System.Windows.Media.Media3D
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.ComponentModel

Public Class FormBudget

    Private Const _NumEtapasTotal = 5

    Private WithEvents _MenuItemEditEtapa As ToolStripMenuItem

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
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox
    Private WithEvents _UPComboBoxEtapaActive As UPComboBox

    Private WithEvents _UPDateTimePicker As UPDateTimePicker

    Private WithEvents _UPDGViewobraCostValue As UPDataGridView

    Private WithEvents _ContextMenuStripPartida As ContextMenuStrip
    Private WithEvents _ButtontemReportPartida As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _ButtontemvIEWPartida As System.Windows.Forms.ToolStripMenuItem

    Private WithEvents _TabControlEtapas As System.Windows.Forms.TabControl
    Private WithEvents _PanelListPartida As PanelListPartida = Nothing

    Private _FormReportBudget As FormReportPresupuesto = Nothing
    Private _FormReportBudget2 As FormReportPresupuesto = Nothing

    Private _IsCargandoConstructor = False
    Private _IsGuardando As Boolean = False
    Private _IsEdit As Boolean = False
    Private _HeigntBaseTable As Int16 = 300

    Private _LisTabPaque As New List(Of System.Windows.Forms.TabPage)
    Private _OptionsListEtapasDefaolt As List(Of (Name As String, Id As Integer, ImageKey As String))
    Private _dicUPDGViewObraStagePartida As New Dictionary(Of Int32, UPDataGridView)
    Private _dicIdEtapas As New Dictionary(Of Int16, Int32)

    Private _IdPartidaSelececionada As Int32 = -1

    Private _PanelListActived As System.Windows.Forms.UserControl = Nothing

    Private _UPDGViewObraStagePartidaActive As UPDataGridView = Nothing
    Private _ListRefObra As List(Of String) '23/12

    Private _IsInitialize = False
    Private _obra_id As Int32 = -1

    Private _appDataSourceInputIdDefaut As Int32 = -1

    Private _PresupuestoType = EnumPresupuestoType.None


    Public Sub New(Optional ByVal obra_id As Int32 = -1, Optional appDataSourceInputId As Int32 = -1)

        InitializeComponent()
        Me.Text = "Formulación de Obras"
        SplitContainer1.Panel2.Padding = New Padding(4, 0, 8, 0) ' contenedor de los computis datagirdview

        _IsInitialize = True
        _appDataSourceInputIdDefaut = appDataSourceInputId

        _obra_id = obra_id
        _IsEdit = obra_id > 0

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Obra para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefObra = GetColumnList(Of String)("obra", "refObra")
        Dim _ListRefObra1 As New List(Of String)
        For Each _RefObra As String In _ListRefObra
            _ListRefObra1.Add(Trim(_RefObra))
        Next
        _ListRefObra = _ListRefObra1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        '_UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Etapa")
        _UPlbl5 = New UPLabel("Fecha Precio")
        _UPlbl7 = New UPLabel("Origen de Datos")

        '_UPlbl1.SetFormatForeColor1()
        '_UPlbl2.SetFormatForeColor1()
        '_UPlbl3.SetFormatForeColor1()
        '_UPlbl4.SetFormatForeColor1()
        '_UPlbl5.SetFormatForeColor1()

        ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        If obra_id > 0 Then
            _UPlbl0 = New UPLabel(" E d i c i ó n  d e  O b r a ")
        Else
            _UPlbl0 = New UPLabel(" N u e v a   O b r a ")
        End If

        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefObra = New UPTextBox(13)
        _UPTxtNameObra = New UPTextBox(255)
        ' _UPTxtDescriptionObra = New UPTextBox(250)
        _UPTxtObraFilter = New UPTextBox()
        _UPComboBoxEtapa = New UPComboBox()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Combo box txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' _UPComboBoxEtapa.FormattingEnabled = True

        _UPComboBoxEtapaActive = New UPComboBox()

        _UPComboBoxEtapaActive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Combo box timer
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDateTimePicker = New UPDateTimePicker()

        _OptionsListEtapasDefaolt = New List(Of (Name As String, Id As Integer, ImageKey As String))
        For i As Int16 = 1 To _NumEtapasTotal
            Dim _Name As String = String.Format("{0} Etapas", i)
            Dim _Id As Integer = i
            Dim _ImageKey As String = String.Format("{0} Etapas", i)
            _OptionsListEtapasDefaolt.Add((_Name, _Id, _ImageKey))
        Next

        _UPComboBoxEtapa.Load(_OptionsListEtapasDefaolt)
        _UPComboBoxEtapa.SelectedIndex = 0

        LoadEtappasUPComboBoxEtapaActive()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInpute                  '28/11
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource2 As New List(Of String)
        _ColumnMaterialSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnMaterialSource2, "Origen de Datos", True)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInput.SetSelectedItem(appDataSourceInputId)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~
        Me.PanelHeader1.Controls.Add(_UPlbl0)

        Me.tlpObraEdition.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpObraEdition.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpObraEdition.Controls.Add(_UPlbl7, 2, 0)
        Me.tlpLabelEdit.Controls.Add(_UPlbl4, 0, 0)
        Me.tlpLabelEdit.Controls.Add(_UPlbl5, 0, 1)
        'Me.tlpObraEdition.Controls.Add(, 2, 0)
        'Me.tlpObraEdition.Controls.Add(_UPlbl5, 2, 1)

        Me.tlpObraEdition.Controls.Add(_UPTxtRefObra, 1, 0)
        Me.tlpObraEdition.Controls.Add(_UPTxtNameObra, 1, 1)
        ' Me.tlpObraEdition.Controls.Add(_UPTxtDescriptionObra, 1, 2)

        Me.tlpObraEdition.Controls.Add(_UPCBoxDataSourceInput, 3, 0)
        'Me.tlpObraEdition.Controls.Add(_UPDateTimePicker, 3, 1)
        Me.tlpTexEdit.Controls.Add(_UPComboBoxEtapa, 0, 0)
        Me.tlpTexEdit.Controls.Add(_UPDateTimePicker, 0, 1)

        Me.tlpButton.Controls.Add(_UPComboBoxEtapaActive, 1, 0)

        _PanelListPartida = New PanelListPartida()
        SplitContainer1.Panel1.Controls.Add(_PanelListPartida)

        For i As Int16 = 1 To _NumEtapasTotal
            createComputo(i)
        Next

        _IsCargandoConstructor = False

        OnCrearObraCost()

        scParent.Panel2Collapsed = True
        _IsInitialize = False

        LoadEtapa()

        If _IsEdit Then
            loadObraSelected()
        End If

        loadListPartida()
    End Sub

    Public ReadOnly Property obra_Id As Int32
        Get
            Return _obra_id
        End Get
    End Property

    Public ReadOnly Property partida_id As Int32
        Get
            Return _PanelListPartida.selectedId
        End Get
    End Property

    Public ReadOnly Property partidaName As String
        Get
            Return _PanelListPartida.partidaName
        End Get
    End Property

    Public ReadOnly Property EtapaActiveId As Int32
        Get
            Return _UPComboBoxEtapaActive.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property PresupuestoType As EnumPresupuestoType
        Get
            Return _PresupuestoType
        End Get
    End Property

    Public Function ValidateBudget() As Boolean

        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefObra.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameObra.Text, 255) Then
            Return False

            'ElseIf Not ValidateDoubleIsNA("columnaprueba", Double.NaN) Then
            '    Return False

        End If

        Return True

    End Function

    Private Function GetOptListEtapas(ByVal obra_id As Int32) As List(Of (Name As String, Id As Integer, ImageKey As String))

        Dim _OptListEtapas As List(Of (Name As String, Id As Integer, ImageKey As String))

        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add("nameStage")

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("obra_id") = obra_id

        _OptListEtapas = GetOptionsList("obraStage", _ColumnNames, "Etapa", True, _dicValuesFilter)

        Return _OptListEtapas

    End Function

    Private Sub OnCrearObraCost()

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
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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

        Dim _DataTable1 = GetNewObraCostValue(ProjectSelectedId)
        _UPDGViewobraCostValue.DataSource = _DataTable1

    End Sub

    Private Sub loadObraSelected()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Cargar Obra
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _id As Int32 = _obra_id

        Dim _ColumnNames As New List(Of String)

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("id") = _id

        Dim _datatable As DataTable = GetDataTable("obra", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

        _UPTxtRefObra.Text = _datatable.Rows(0)("refObra")
        _UPTxtNameObra.Text = _datatable.Rows(0)("nameObra")
        '_UPTxtDescriptionObra.Text = _datatable.Rows(0)("descriptionObra")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Set Etapas
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _OptListEtapas As List(Of (Name As String, Id As Integer, ImageKey As String)) = GetOptListEtapas(_obra_id)
        If _OptListEtapas.Count = 0 Then
            _UPComboBoxEtapa.SetSelectedItem(1)
        Else
            _UPComboBoxEtapa.SetSelectedItem(_OptListEtapas.Count)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Cargar ObraStagePartida
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _IndexEtape As Int16 = 1
        For Each _Item As (Name As String, Id As Integer, ImageKey As String) In _OptListEtapas

            Dim _ColumnNames1 As New List(Of String)

            Dim _dicValuesFilter1 As New JObject()
            _dicValuesFilter1("obraStage_id") = _Item.Id

            _dicUPDGViewObraStagePartida(_IndexEtape).ReLoadData(_dicValuesFilter1, False)
            _dicUPDGViewObraStagePartida(_IndexEtape).Refresh()
            _dicIdEtapas.Add(_IndexEtape, _Item.Id)

            _IndexEtape += 1
        Next

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Cargar obraCostValue
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames2 As New List(Of String)

        Dim _dicValuesFilter2 As New JObject()
        _dicValuesFilter2("Obra_id") = _id

        Dim _DataTable1 = GetDataTable("obraCostValue", ColumnNames:=_ColumnNames2,
                                                       dicValuesFilter:=_dicValuesFilter2)
        _UPDGViewobraCostValue.DataSource = _DataTable1


    End Sub

    Private Sub LoadEtappasUPComboBoxEtapaActive()

        _OptionsListEtapasDefaolt = New List(Of (Name As String, Id As Integer, ImageKey As String))
        For i As Int16 = 1 To _UPComboBoxEtapa.GetSelectedItemId()
            Dim _Name As String = String.Format("{0} Etapas", i)
            Dim _Id As Integer = i
            Dim _ImageKey As String = String.Format("{0} Etapas", i)
            _OptionsListEtapasDefaolt.Add((_Name, _Id, _ImageKey))
        Next

        _UPComboBoxEtapaActive.Items.Clear()
        _UPComboBoxEtapaActive.Load(_OptionsListEtapasDefaolt)

        If _UPComboBoxEtapaActive.Items.Count > 0 Then
            _UPComboBoxEtapaActive.SelectedIndex = 0
        End If
        '_UPComboBoxEtapaActive.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
    End Sub

    Private Sub createComputo(ByVal Etapa As Int32)

        Dim _UPDGViewObraStagePartida As New UPDataGridView("obraStagePartida")
        _UPDGViewObraStagePartida.ContextMenuStrip = _ContextMenuStripPartida
        _UPDGViewObraStagePartida.Dock = DockStyle.Fill
        _UPDGViewObraStagePartida.RowHeadersVisible = False
        _UPDGViewObraStagePartida.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer),
                                                                                  CType(CType(245, Byte), Integer),
                                                                                  CType(CType(245, Byte), Integer))

        AddHandler _UPDGViewObraStagePartida.RowEnter, AddressOf OnUPDGViewObraStagePartidaRowEnter

        _UPDGViewObraStagePartida.SetUPDGViewReadOnly(False)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cargar Columnas de: ObraStagePartida
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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

        _DataGridViewColumn = _UPDGViewObraStagePartida.CreateColumnComboBox("partida_id", "Código | Partida", False, True, False,
                                                                       "partida", _ColumnNames, "Partida", True, _dicValuesFilter)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.MinimumWidth = 300 '03/07
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        CType(_DataGridViewColumn, UPDataGridViewColumnComboBox).IsFilterOptionsList = True
        _DataGridViewColumn.ReadOnly = True

        _DataGridViewColumn.DataGridView.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)

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
        _DataGridViewColumn.MinimumWidth = 200 '03/07
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cantidad
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _DataGridViewColumn = _UPDGViewObraStagePartida.CrearteColumnFloat("quantityPartida", "Cantidad", False, True)
        _DataGridViewColumn.Visible = True

        _dicUPDGViewObraStagePartida.Add(Etapa, _UPDGViewObraStagePartida)

        _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        _DataGridViewColumn.Width = 200
        _DataGridViewColumn.MinimumWidth = 200 '03/07

    End Sub

    Private Sub AddPartida()

        If partida_id > 0 Then

            Dim _List As List(Of Int32) = _UPDGViewObraStagePartidaActive.GetListValues(Of Int32)("partida_id")

            If _List.Contains(partida_id) Then

                MessageBox.Show($"partida '{partidaName}' cargado", "Partida", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Dim _dicValues As New JObject()
                _dicValues("obraStage_id") = EtapaActiveId
                _dicValues("partida_id") = partida_id
                _dicValues("quantityPartida") = 1
                _dicValues("unit_id") = 2

                _UPDGViewObraStagePartidaActive.LoadRow(_dicValues)
                _UPDGViewObraStagePartidaActive.Refresh()
            End If

            _UPDGViewObraStagePartidaActive.StartEditing()
        End If
    End Sub

    Private Sub LoadEtapa()

        If _UPDGViewObraStagePartidaActive IsNot Nothing Then
            SplitContainer1.Panel2.Controls.Remove(_UPDGViewObraStagePartidaActive)
        End If

        _UPDGViewObraStagePartidaActive = _dicUPDGViewObraStagePartida(EtapaActiveId)

        SplitContainer1.Panel2.Controls.Add(_UPDGViewObraStagePartidaActive)

    End Sub

    Private Sub ReportBudgetShow()

        Dim _IsShowPanel = scParent.Panel2Collapsed

        If _IsShowPanel Then

            Dim _IsRefreshReportPresupuesto As Boolean = True

            If _FormReportBudget Is Nothing Then
                If _obra_id = -1 Then

                    If MessageBox.Show("Para visualizar el reporte debe salvar primero la obra. Saves?", "Saves",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                        If ValidateBudget() Then
                            SavesPartida()
                        End If

                        If _obra_id > 0 Then
                            _FormReportBudget = New FormReportPresupuesto(_obra_id)
                        End If
                    End If

                Else
                    _FormReportBudget = New FormReportPresupuesto(_obra_id)
                End If

                If _FormReportBudget IsNot Nothing Then
                    _FormReportBudget.TopLevel = False
                    _FormReportBudget.FormBorderStyle = FormBorderStyle.None
                    _FormReportBudget.Dock = DockStyle.Fill
                    scParent.Panel2.Controls.Add(_FormReportBudget)
                    _FormReportBudget.BringToFront()
                    _FormReportBudget.Show()
                End If

                _IsRefreshReportPresupuesto = False
            Else
                _IsRefreshReportPresupuesto = True
            End If

            scParent.Panel2Collapsed = _FormReportBudget Is Nothing

            If _IsRefreshReportPresupuesto Then
                _FormReportBudget.RefreshReportPresupuesto()
            End If

        Else
            scParent.Panel2Collapsed = True
        End If

    End Sub

    Private Sub SavesPartida()
        If ValidateBudget() Then

            _IsGuardando = True

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Guardando Obra
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("project_id") = ProjectSelectedId
            _dicValues("refObra") = _UPTxtRefObra.Text
            _dicValues("nameObra") = _UPTxtNameObra.Text
            _dicValues("appDataSourceInput_id") = _UPCBoxDataSourceInput.GetSelectedItemId()
            _dicValues("created") = Now().ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("updated") = Now().ToString("yyyy-MM-dd HH:mm:ss")
            '_dicValues("descriptionObra") = _UPTxtDescriptionObra.Text
            _dicValues("budgetPrice") = CType(_UPDateTimePicker.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                'Dim _id As Int32 = _obra_id 0203
                _dicValues("id") = _obra_id

                If GetUpdateTable("obra", _DataServices) IsNot Nothing Then '0203

                    Dim _idObra As Int32 = _obra_id '0203

                    Dim _NumEtapas As Int16 = _UPComboBoxEtapa.GetSelectedItemId()
                    For i As Int16 = 1 To _NumEtapas
                        If _dicIdEtapas.ContainsKey(i) Then
                            _dicUPDGViewObraStagePartida(i).Saves("obraStage_id", _dicIdEtapas(i))
                            _dicIdEtapas.Remove(i)
                        Else
                            Dim _DataServices1 As New JArray()

                            Dim _dicValues1 As New JObject()
                            _dicValues1("refStage") = String.Format("Etapa {0} ", i)
                            _dicValues1("nameStage") = String.Format("Etapa {0} ", i)
                            _dicValues1("descriptionStage") = String.Format("Etapa {0} ", i)
                            _dicValues1("obra_id") = _idObra

                            _DataServices1.Add(_dicValues1)

                            Dim _idobraStage As Int32 = GetInsertTable("obraStage", _DataServices1)
                            If _idobraStage > 0 Then
                                _dicUPDGViewObraStagePartida(i).Saves("obraStage_id", _idobraStage)
                            End If

                        End If
                    Next

                    For Each _kval As KeyValuePair(Of Int16, Int32) In _dicIdEtapas
                        GetDelete("obraStagePartida", _kval.Value)
                    Next

                    _UPDGViewobraCostValue.Saves("obra_id", _idObra)

                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                Dim _idObra As Int32 = GetInsertTable("obra", _DataServices)
                If _idObra > 0 Then

                    Dim _NumEtapas As Int16 = _UPComboBoxEtapa.GetSelectedItemId()

                    For i As Int16 = 1 To _NumEtapas
                        Dim _DataServices1 As New JArray()

                        Dim _dicValues1 As New JObject()
                        _dicValues1("refStage") = String.Format("Etapa {0} ", i)
                        _dicValues1("nameStage") = String.Format("Etapa {0} ", i)
                        _dicValues1("descriptionStage") = String.Format("Etapa {0} ", i)
                        _dicValues1("obra_id") = _idObra

                        _DataServices1.Add(_dicValues1)

                        Dim _idobraStage As Int32 = GetInsertTable("obraStage", _DataServices1)
                        If _idobraStage > 0 Then
                            '_dicIdEtapas.Add(i, _idobraStage)
                            _dicUPDGViewObraStagePartida(i).Saves("obraStage_id", _idobraStage)
                        End If
                    Next

                    _UPDGViewobraCostValue.Saves("obra_id", _idObra)

                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    _obra_id = _idObra
                    _IsEdit = True

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

            'DialogResult = DialogResult.OK

            If Not scParent.Panel2Collapsed Then
                _FormReportBudget.RefreshReportPresupuesto()
            End If

        End If
    End Sub

    Private Sub loadListPartida()

        If _appDataSourceInputIdDefaut > 0 Then
            _PanelListPartida.SetSelectedItemappDataSource(_appDataSourceInputIdDefaut)
        End If
    End Sub

    Private Sub ValidateRefObra() '23/12
        Dim _RefObra As String = _UPTxtRefObra.Text.Trim()
        If _ListRefObra.Contains(_RefObra) Then
            MessageBox.Show("El Código de la obra existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_UPTxtRefObra.Focus()
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

    Private Sub _UPComboBoxEtapa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPComboBoxEtapa.SelectedIndexChanged
        If Not _IsInitialize Then
            LoadEtappasUPComboBoxEtapaActive()

        End If

    End Sub

    Private Sub _UPComboBoxEtapaActive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPComboBoxEtapaActive.SelectedIndexChanged
        If Not _IsInitialize Then
            LoadEtapa()
        End If

    End Sub

    Private Sub _PanelListPartida_EvDoubleClick(sender As Object, e As EventArgs) Handles _PanelListPartida.EvDoubleClick
        AddPartida()
    End Sub

    Private Sub FormBudget_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            DialogResult = DialogResult.Cancel
        Else
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnAddPartida_Click(sender As Object, e As EventArgs) Handles btnAddPartida.Click
        AddPartida()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnPreView.Click
        ReportBudgetShow()
    End Sub


    Private Sub btnCost1_Click(sender As Object, e As EventArgs) Handles btnCost1.Click
        Dim _FormObraCost As New FormObraCost(_UPDGViewobraCostValue)
        _FormObraCost.ShowDialog(Me)
    End Sub
    'Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
    '    Dim _FormObraCost As New FormObraCost(_UPDGViewobraCostValue)
    '    _FormObraCost.ShowDialog(Me)
    'End Sub

    Private Sub FormBudget_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        Dim toolTip1 As New ToolTip()

        ' Configura los retrasos para el tooltip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500

        ' Muestra el tooltip siempre, independientemente de si el formulario está activo.
        toolTip1.ShowAlways = True

        ' Asigna tooltips a los controles específicos.
        toolTip1.SetToolTip(Me.btnCost, "Costos de la partida")
        toolTip1.SetToolTip(Me.btnAddPartida, "Agregar una partida")
        toolTip1.SetToolTip(Me.btnPreView, "Reporte de obra")
        toolTip1.SetToolTip(Me._UPComboBoxEtapaActive, "Seleccionar etapa de la partida")

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        DialogResult = DialogResult.OK
        'Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SavesPartida()
    End Sub

    Private Sub _UPTxtRefObra_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefObra.Validating
        ValidateRefObra()
    End Sub

    Private Sub btnReportBudget_Click(sender As Object, e As EventArgs) Handles btnReportBudget.Click
        'Dim _FormSelectReport As New FormSelectReport()

        'If _FormSelectReport.ShowDialog(Me) = DialogResult.OK Then
        '    Dim _Report As New FormReportPresupuesto(-1, _FormSelectReport.PresupuestoType)
        '    _Report.Show(Me)

        'End If
        '_FormReportBudget2 = -1

        _FormReportBudget2 = New FormReportPresupuesto(_obra_id)

    End Sub

#Region "Bordes Botones"

    Private Sub btnCost1_MouseEnter(sender As Object, e As EventArgs) Handles btnCost1.MouseEnter
        btnCost1.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCost1_MouseLeave(sender As Object, e As EventArgs) Handles btnCost1.MouseLeave
        btnCost1.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnPreView_MouseEnter(sender As Object, e As EventArgs) Handles btnPreView.MouseEnter
        btnPreView.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnPreView_MouseLeave(sender As Object, e As EventArgs) Handles btnPreView.MouseLeave
        btnPreView.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnReportBudget_MouseEnter(sender As Object, e As EventArgs) Handles btnReportBudget.MouseEnter
        btnReportBudget.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReportBudget_MouseLeave(sender As Object, e As EventArgs) Handles btnReportBudget.MouseLeave
        btnReportBudget.FlatAppearance.BorderSize = 0
    End Sub


#End Region

End Class