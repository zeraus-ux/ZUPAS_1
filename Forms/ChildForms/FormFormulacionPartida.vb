Imports System.CodeDom.Compiler
Imports System.Windows.Controls.Primitives
Imports System.Windows.Media
Imports System.Windows.Media.Media3D
Imports FontAwesome.Sharp
Imports Newtonsoft.Json.Linq

Public Class FormFormulacionPartida

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel
    Private WithEvents _UPlbl8 As UPLabel
    Private WithEvents _UPlbl9 As UPLabel

    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPCBoxCharter As UPComboBox
    Private WithEvents _UPCBoxUnitPartida As UPComboBox
    Private WithEvents _UPCBoxUnitRendimiento As UPComboBox
    Private WithEvents _UPCBoxDataSourceInputList As UPComboBox
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox
    Private WithEvents _UPCBoxChapterList As UPComboBox

    Private WithEvents _UPDGViewPartidaMaterial As UPDataGridView
    Private WithEvents _UPDGViewPartidaEquipment As UPDataGridView
    'Private WithEvents _UPDGViewPartidaTool As UPDataGridView
    'Private WithEvents _UPDGViewPartidaTransport As UPDataGridView
    Private WithEvents _UPDGViewPartidaLabour As UPDataGridView

    Private WithEvents _UPDGViewpartidaCostValue As UPDataGridView

    Private WithEvents _TabPageMaterial As TabPage
    Private WithEvents _TabPageEquipment As TabPage
    'Private WithEvents _TabPageTool As TabPage
    'Private WithEvents _TabPageTransport As TabPage
    Private WithEvents _TabPageLabour As TabPage

    Private WithEvents _UPTxtRefPartida As UPTextBox
    Private WithEvents _UPTxtNamePartida As UPTextBox
    Private WithEvents _UPTxtDescriptionPartida As UPTextBox
    Private WithEvents _UPTxtPartidaFilter As UPTextBox

    Private WithEvents _UPTxtRendimiento As UPTextBoxNumerico

    Private _FormReportPriceAnalysis As FormReportPriceAnalysis = Nothing
    Private _FormReportPriceAnalysisArg As FormReportPriceAnalisysArg = Nothing

    Private _IsGuardando As Boolean = False
    Private _IsEdit As Boolean = False
    Private _HeigntBaseTable As Int16 = 300
    Private _IsInitialize = False
    'Private _partida_id As Int32 '2406
    Private _CurrentForm As Form = Nothing

    Public Sub New()

        InitializeComponent()

        _IsInitialize = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Chapter2
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _columnamesPartidaChapter As New List(Of String)
        _columnamesPartidaChapter.Add("nameChapter")

        Dim _dicValuesFilterProj As JObject = Nothing
        'Dim _dicValuesFilterProj As New JObject()
        '_dicValuesFilterProj("project_id") = ProjectSelectedId

        _UPCBoxChapterList = New UPComboBox("chapter", _columnamesPartidaChapter, "Capítulo", True, _dicValuesFilterProj)
        _UPCBoxChapterList.SetSelectedItem(1)
        _UPCBoxChapterList.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista: partidas
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter0 As New JObject()
        _dicValuesFilter0("chapter_id") = 8
        '_dicValuesFilter0("project_id") = -1

        _UPDGViewList = New UPDGViewList("partida", "refPartida", "namePartida", "Código", "Nombre de la partida", _dicValuesFilter0,
                                         IsDuplicateSupplyActive:=True)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        '_UPDGViewList.Columns("refPartida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '_UPDGViewList.Dock = DockStyle.Top

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        '_UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Unidad Partida")
        _UPlbl5 = New UPLabel("Capítulo")
        _UPlbl6 = New UPLabel("Rendimiento")
        _UPlbl7 = New UPLabel("Unidad Rendimiento")
        _UPlbl9 = New UPLabel("Fuente de Datos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  P a r t i d a s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl8 = New UPLabel("E d i c i ó n  d e  P a r t i d a s")
        _UPlbl8.SetFortmatEtiquetaInsumo()
        _UPlbl8.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefPartida = New UPTextBox(13)
        _UPTxtNamePartida = New UPTextBox(155)
        'Dim indentedText As String = IndentText(Text, vbTab)

        '_UPTxtNamePartida.Text = indentedText
        _UPTxtNamePartida.WordWrap = True
        _UPTxtDescriptionPartida = New UPTextBox(255)
        _UPTxtPartidaFilter = New UPTextBox()

        _UPTxtPartidaFilter.Margin = New System.Windows.Forms.Padding(8, 4, 8, 4)

        _UPTxtRendimiento = New UPTextBoxNumerico(0.000000000001, Double.NaN)
        _UPTxtRendimiento.Value = 1

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
        'Cbx: Chapter
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames3 As New List(Of String)
        _ColumnNames3.Add("nameChapter")

        _UPCBoxCharter = New UPComboBox("chapter", _ColumnNames3, "Chapter", True)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbx: UPCBox Unidad Partida
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColUnitPartida As New List(Of String)
        _ColUnitPartida.Add("symbolUnit")

        Dim _dicValuesFilterUnit1 As New JObject()
        _dicValuesFilterUnit1("unitPartida") = True

        _UPCBoxUnitPartida = New UPComboBox("unit", _ColUnitPartida, "Unit", True, _dicValuesFilterUnit1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbx: UPCBox Unidad Rendimiento
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _columUnit As New List(Of String)
        _columUnit.Add("symbolUnit")

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("unitRendimiento") = True

        _UPCBoxUnitRendimiento = New UPComboBox("unit", _columUnit, "Unit", True, _dicValuesFilter)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInpute
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnImputSource2 As New List(Of String)
        _ColumnImputSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnImputSource2, "Fuente de Datos", True)
        _UPCBoxDataSourceInput.BackColor = System.Drawing.Color.WhiteSmoke


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me.tlpListPartida.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListPartida.Controls.Add(_UPCBoxDataSourceInputList, 0, 1)
        Me.tlpListPartida.Controls.Add(_UPCBoxChapterList, 0, 2)
        Me.tlpListPartida.Controls.Add(_UPDGViewList, 0, 4)

        Me.tlpPartidaLook.Controls.Add(_UPTxtPartidaFilter, 0, 0)

        Me.tlpPartidaEdition.Controls.Add(_UPlbl8, 0, 0)

        Me.tlpPartidaEdition2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpPartidaEdition2.Controls.Add(_UPlbl2, 0, 1)
        'Me.tlpPartidaEdition2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpPartidaEdition2.Controls.Add(_UPlbl4, 0, 2)
        Me.tlpPartidaEdition2.Controls.Add(_UPlbl9, 0, 3)
        Me.tlpPartidaEdition2.Controls.Add(_UPlbl5, 0, 4)
        Me.tlpPartidaEdition2.Controls.Add(_UPlbl6, 0, 5)
        Me.tlpPartidaEdition2.Controls.Add(_UPlbl7, 0, 6)

        Me.tlpPartidaEdition2.Controls.Add(_UPTxtRefPartida, 1, 0)
        Me.tlpPartidaEdition2.Controls.Add(_UPTxtNamePartida, 1, 1)
        'Me.tlpPartidaEdition2.Controls.Add(_UPTxtDescriptionPartida, 1, 2)
        Me.tlpPartidaEdition2.Controls.Add(_UPCBoxUnitPartida, 1, 2)
        Me.tlpPartidaEdition2.Controls.Add(_UPCBoxDataSourceInput, 1, 3)
        Me.tlpPartidaEdition2.Controls.Add(_UPCBoxCharter, 1, 4)
        Me.tlpPartidaEdition2.Controls.Add(_UPTxtRendimiento, 1, 5)
        Me.tlpPartidaEdition2.Controls.Add(_UPCBoxUnitRendimiento, 1, 6)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' TabPages
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        '_TabPageMaterial
        _TabPageMaterial = New TabPage()
        _TabPageMaterial.Location = New System.Drawing.Point(4, 25)
        _TabPageMaterial.Name = "_TabPageMaterial"
        _TabPageMaterial.Padding = New System.Windows.Forms.Padding(3)
        _TabPageMaterial.Size = New System.Drawing.Size(803, 579)
        _TabPageMaterial.TabIndex = 0
        _TabPageMaterial.Text = "Material"
        _TabPageMaterial.UseVisualStyleBackColor = True
        '_TabPageMaterial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular,
        '                                               System.Drawing.GraphicsUnit.Point, CType(0, Byte))


        '_TabPageEquipment
        _TabPageEquipment = New TabPage()
        _TabPageEquipment.Location = New System.Drawing.Point(4, 25)
        _TabPageEquipment.Name = "_TabPageEquipment"
        _TabPageEquipment.Padding = New System.Windows.Forms.Padding(3)
        _TabPageEquipment.Size = New System.Drawing.Size(803, 579)
        _TabPageEquipment.TabIndex = 1
        _TabPageEquipment.Text = "Equipo"
        _TabPageEquipment.UseVisualStyleBackColor = True
        '_TabPageEquipment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular,
        '                                                System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        '_TabPageTool
        '_TabPageTool = New TabPage()
        '_TabPageTool.Location = New System.Drawing.Point(4, 25)
        '_TabPageTool.Name = "_TabPageTool"
        '_TabPageTool.Padding = New System.Windows.Forms.Padding(3)
        '_TabPageTool.Size = New System.Drawing.Size(803, 579)
        '_TabPageTool.TabIndex = 2
        '_TabPageTool.Text = "Herramientas"
        '_TabPageTool.UseVisualStyleBackColor = True
        '_TabPageTool.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular,
        '                                                System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        '_TabPageTransport
        '_TabPageTransport = New TabPage()
        '_TabPageTransport.Padding = New System.Windows.Forms.Padding(3)
        '_TabPageTransport.Location = New System.Drawing.Point(4, 25)
        '_TabPageTransport.Name = "_TabPageTransport"
        '_TabPageTransport.Size = New System.Drawing.Size(803, 579)
        '_TabPageTransport.TabIndex = 3
        '_TabPageTransport.Text = "Transporte"
        '_TabPageTransport.UseVisualStyleBackColor = True
        '_TabPageTransport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular,
        '                                                System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        '_TabPageLabour
        _TabPageLabour = New TabPage()
        _TabPageLabour.Padding = New System.Windows.Forms.Padding(3)
        _TabPageLabour.Location = New System.Drawing.Point(4, 25)
        _TabPageLabour.Name = "_TabPageLabour"
        _TabPageLabour.Size = New System.Drawing.Size(803, 579)
        _TabPageLabour.TabIndex = 4
        _TabPageLabour.Text = "Mano de Obra"
        _TabPageLabour.UseVisualStyleBackColor = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Tabla: partidaMaterial
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        OnCargarTypePartida()

        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnProjectSeletedChnge

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDGViewpartidaCostValue
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        OnCreateUPDGViewpartidaCostValue(True)

        _IsInitialize = False
        EnableControls(False)
        btnGuardar.Visible = False

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

    Public ReadOnly Property selectedChapterId As Int32
        Get
            Return _UPCBoxChapterList.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _UPCBoxDataSourceInputList.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property chapterId As Int32
        Get
            Return _UPCBoxCharter.GetSelectedItemId()
        End Get
    End Property

    Private Sub OnCargarTypePartida()

        Me.TabControl1.TabPages.Clear()

        OnCrearpartidaMaterial()
        OnCrearpartidaEquipment()
        'OnCrearpartidaTool()
        'OnCrearpartidaTransport()
        OnCrearpartidaLabour()

        Select Case PartidaTypeForm
            Case EnumPartidaTypeForm.CIV

                _TabPageMaterial.Controls.Clear()
                _TabPageEquipment.Controls.Clear()
                _TabPageLabour.Controls.Clear()

                _TabPageMaterial.Controls.Add(_UPDGViewPartidaMaterial)
                _TabPageEquipment.Controls.Add(_UPDGViewPartidaEquipment)
                _TabPageLabour.Controls.Add(_UPDGViewPartidaLabour)

                Me.TabControl1.TabPages.Add(_TabPageMaterial)
                Me.TabControl1.TabPages.Add(_TabPageEquipment)
                Me.TabControl1.TabPages.Add(_TabPageLabour)

            Case EnumPartidaTypeForm.MEX

                _TabPageMaterial.Controls.Clear()
                _TabPageEquipment.Controls.Clear()
                _TabPageLabour.Controls.Clear()

                _TabPageMaterial.Controls.Add(_UPDGViewPartidaMaterial)
                _TabPageEquipment.Controls.Add(_UPDGViewPartidaEquipment)
                _TabPageLabour.Controls.Add(_UPDGViewPartidaLabour)

                Me.TabControl1.TabPages.Add(_TabPageMaterial)
                Me.TabControl1.TabPages.Add(_TabPageEquipment)
                Me.TabControl1.TabPages.Add(_TabPageLabour)

            Case EnumPartidaTypeForm.ARG

                _TabPageMaterial.Controls.Clear()
                _TabPageEquipment.Controls.Clear()
                _TabPageLabour.Controls.Clear()

                _TabPageMaterial.Controls.Add(_UPDGViewPartidaMaterial)
                _TabPageEquipment.Controls.Add(_UPDGViewPartidaEquipment)
                '_TabPageTransport.Controls.Add(_UPDGViewPartidaTransport)
                _TabPageLabour.Controls.Add(_UPDGViewPartidaLabour)

                Me.TabControl1.TabPages.Add(_TabPageMaterial)
                Me.TabControl1.TabPages.Add(_TabPageEquipment)
                'Me.TabControl1.TabPages.Add(_TabPageTransport)
                Me.TabControl1.TabPages.Add(_TabPageLabour)

            Case EnumPartidaTypeForm.ATN

                _TabPageMaterial.Controls.Clear()
                _TabPageEquipment.Controls.Clear()
                '_TabPageTool.Controls.Clear()
                '_TabPageTransport.Controls.Clear()
                _TabPageLabour.Controls.Clear()

                _TabPageMaterial.Controls.Add(_UPDGViewPartidaMaterial)
                _TabPageEquipment.Controls.Add(_UPDGViewPartidaEquipment)
                '_TabPageTool.Controls.Add(_UPDGViewPartidaTool)
                '_TabPageTransport.Controls.Add(_UPDGViewPartidaTransport)
                _TabPageLabour.Controls.Add(_UPDGViewPartidaLabour)

                Me.TabControl1.TabPages.Add(_TabPageMaterial)
                Me.TabControl1.TabPages.Add(_TabPageEquipment)
                'Me.TabControl1.TabPages.Add(_TabPageTool)
                'Me.TabControl1.TabPages.Add(_TabPageTransport)
                Me.TabControl1.TabPages.Add(_TabPageLabour)

            Case EnumPartidaTypeForm.USA

                _TabPageMaterial.Controls.Clear()
                _TabPageEquipment.Controls.Clear()
                _TabPageLabour.Controls.Clear()

                _TabPageMaterial.Controls.Add(_UPDGViewPartidaMaterial)
                _TabPageEquipment.Controls.Add(_UPDGViewPartidaEquipment)
                _TabPageLabour.Controls.Add(_UPDGViewPartidaLabour)

                Me.TabControl1.TabPages.Add(_TabPageMaterial)
                Me.TabControl1.TabPages.Add(_TabPageEquipment)
                Me.TabControl1.TabPages.Add(_TabPageLabour)

        End Select

    End Sub

    Public Function Validate1() As Boolean

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
        Return True

    End Function

    ' hay que copiar este procedimiento en todas las demas donde tengas boton costo
    Private Sub OnCreateUPDGViewpartidaCostValue(ByVal IsNew As Boolean)

        _UPDGViewpartidaCostValue = New UPDataGridView("partidaCostValue")
        _UPDGViewpartidaCostValue.Dock = DockStyle.Fill
        _UPDGViewpartidaCostValue.EditMode = DataGridViewEditMode.EditOnEnter
        _UPDGViewpartidaCostValue.AllowUserToAddRows = False
        _UPDGViewpartidaCostValue.AllowUserToDeleteRows = False
        _UPDGViewpartidaCostValue.AllowUserToOrderColumns = False
        _UPDGViewpartidaCostValue.AllowUserToResizeColumns = False

        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewpartidaCostValue.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column partida_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewpartidaCostValue.CrearteColumnText("partida_id", "partida_id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cost_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames2 As New List(Of String)
        _ColumnNames2.Add("refCostValue")
        _ColumnNames2.Add("nameCostValue")

        _DataGridViewColumn = _UPDGViewpartidaCostValue.CreateColumnComboBox("appCostValue_id", "Variables Administrativas", True, True, False,
                                                                  "appCostValue", _ColumnNames2, "cost", True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DataGridViewColumn.ReadOnly = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Value
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewpartidaCostValue.CrearteColumnFloat("defaultCostUser", "Value", False, True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.Width = 150

        If IsNew Then
            Dim _DataTable1 = GetNewPartidaCostValue(ProjectSelectedId)
            _UPDGViewpartidaCostValue.DataSource = _DataTable1
        Else
            Dim _ColumnNames3 As New List(Of String)

            Dim _dicValuesFilter2 As New JObject()
            _dicValuesFilter2("partida_id") = selectedId
            _dicValuesFilter2("project_Id") = ProjectSelectedId

            Dim _DataTable1 = GetDataTable("partidaCostValue", ColumnNames:=_ColumnNames3,
                                                       dicValuesFilter:=_dicValuesFilter2)
            _UPDGViewpartidaCostValue.DataSource = _DataTable1
        End If

    End Sub

    Public Sub SetViewPartida(ByVal Partida_Id As Int32)
        _UPDGViewList.SetSelectedItemId(Partida_Id)
        Me.splitContPartida.Panel1Collapsed = True
        LoadPartidaSeleccionada()
    End Sub

    Public Sub ReloadPartidas()

        Dim _dicValuesFilter0 As JObject
        '_dicValuesFilter0("PartidaTypeForm_id") = PartidaTypeForm
        '_dicValuesFilter0("project_id") = ProjectSelectedId

        If selectedChapterId > 0 Then
            _dicValuesFilter0 = New JObject()
            _dicValuesFilter0("chapter_Id") = selectedChapterId

            If appDataSourceInputId > 0 Then
                _dicValuesFilter0("appDataSourceInput_id") = appDataSourceInputId
            End If

        Else
            If appDataSourceInputId > 0 Then
                _dicValuesFilter0 = New JObject()
                _dicValuesFilter0("appDataSourceInput_id") = appDataSourceInputId
            Else
                _dicValuesFilter0 = Nothing
            End If


        End If

        _UPDGViewList.ReLoadData(_dicValuesFilter0, True)

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
        ' cada vez que cargue partida selecciona el evento 1

        _UPDGViewList.SetSelectedItem(0)

    End Sub


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

    Private Sub OnProjectSeletedChnge(sender As Object, e As EventArgs)

        SplitContainerAPU.Panel2Collapsed = True
        _FormReportPriceAnalysis = Nothing
        _FormReportPriceAnalysisArg = Nothing


        '    If ProjectSelectedId > 0 Then
        '        'Dim _dicValuesFilter0 As New JObject
        '        '_dicValuesFilter0("project_id") = ProjectSelectedId

        '        _UPDGViewList.LoadList()
        '        _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

        '        _UPCBoxChapterList.ReLoad()
        '        '_UPCBoxChapterList.SetSelectedItem(1)

        '        _IsEdit = False
        '        EnableControls(False)
        '        btnGuardar.Visible = False

        '    Else
        '        FormInicio()
        '    End If

        '    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
        '    ' cada vez que cargue partida selecciona el evento 1

        '    _UPDGViewList.SetSelectedItem(0)

        LoadPartidaSeleccionada()


    End Sub

    Private Sub OnCrearpartidaMaterial()

        _UPDGViewPartidaMaterial = New UPDataGridView("partidaMaterial")
        _UPDGViewPartidaMaterial.Dock = DockStyle.Fill

        SetUPDGViewReadOnly(_UPDGViewPartidaMaterial, True)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cargar Columnas de: partidaMaterial
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column partida_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnText("partida_id", "partida_id", True, False, False)
        _DataGridViewColumn.Visible = False


        Select Case PartidaTypeForm
            Case EnumPartidaTypeForm.CIV

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Código | Material", False, True, False,
                                                                               "material", _ColumnNames, "Material", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.MinimumWidth = 300
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
                CType(_DataGridViewColumn, UPDataGridViewColumnComboBox).IsFilterOptionsList = True  'XXXXX

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                    "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)

                _DataGridViewColumn.Visible = True

                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True

                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Desperdicio 
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("defalultWasteMaterial", "Desperdicio", False, True)
                _DataGridViewColumn.Visible = True

                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60

            Case EnumPartidaTypeForm.MEX
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Código | Material", False, True, False,
                                                                               "material", _ColumnNames, "Material", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                               "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True

            Case EnumPartidaTypeForm.ARG
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Código | Material", False, True, False,
                                                                               "material", _ColumnNames, "Material", True, Nothing)
                _DataGridViewColumn.Visible = True
                '_DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                _DataGridViewColumn.MinimumWidth = 300 '03/07
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
                CType(_DataGridViewColumn, UPDataGridViewColumnComboBox).IsFilterOptionsList = True  'XXXXX ???????????
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                               "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60 '30/01


                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60 '30/01


            Case EnumPartidaTypeForm.ATN

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Código | Material", False, True, False,
                                                                               "material", _ColumnNames, "Material", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                               "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True


                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True

            Case EnumPartidaTypeForm.USA

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Material
                _ColumnNames.Add("refMaterial")
                _ColumnNames.Add("nameMaterial")

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("material_id", "Code | Material", False, True, False,
                                                                               "material", _ColumnNames, "Materials", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unit
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitMaterial") = True

                _DataGridViewColumn = _UPDGViewPartidaMaterial.CreateColumnComboBox("unit_id", "Unit", False, True, False,
                                                                               "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Quantity
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("quantityMaterial", "Quantity", False, True)
                _DataGridViewColumn.Visible = True

        End Select

    End Sub

    Private Sub OnCrearpartidaEquipment()

        _UPDGViewPartidaEquipment = New UPDataGridView("partidaEquipment")
        _UPDGViewPartidaEquipment.Dock = DockStyle.Fill
        SetUPDGViewReadOnly(_UPDGViewPartidaEquipment, True)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cargar Columnas de: partidaEquipment
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column partida_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnText("partida_id", "partida_id", True, False, False)
        _DataGridViewColumn.Visible = False

        Select Case PartidaTypeForm
            Case EnumPartidaTypeForm.CIV
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Código | Equipo", False, True, False,
                                                                               "equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.MinimumWidth = 300
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
                'CType(_DataGridViewColumn, UPDataGridViewColumnComboBox).IsFilterOptionsList = True  'XXXXX

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitEquipment") = True


                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True

                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Costos de Posesión y Operación
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                ' _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("c", "COP", False, True)

                '_DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("EquitmentTime", "Tiempo", False, True, 5)
                '_DataGridViewColumn.Visible = True

                '_DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                '_DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                '_DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.MEX

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Código | Equipo", False, True, False,
                                                                               "Equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitEquipment") = True

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Rendimiento
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("rendimientoEquipment", "Rendimiento", False, True)
                _DataGridViewColumn.Visible = True


            Case EnumPartidaTypeForm.ARG

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Código | Equipo", False, True, False,
                                                                               "Equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unit
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Dim _ColumnNames1 As New List(Of String)
                '_ColumnNames1.Add("symbolUnit")
                'Dim _dicValuesFilterUnit As New JObject()
                '_dicValuesFilterUnit("unitEquipment") = True

                '_DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                '                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                '_DataGridViewColumn.Visible = False

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True

                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200


                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column HP
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                '_DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("HP", "HP", False, True)
                '_DataGridViewColumn.Visible = True


            Case EnumPartidaTypeForm.ATN

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Código | Equipo", False, True, False,
                                                                               "Equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitEquipment") = True

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True


                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Rendimiento
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("rendimientoEquipment", "Rendimiento", False, True)
                _DataGridViewColumn.Visible = True


            Case EnumPartidaTypeForm.USA

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Equipment
                _ColumnNames.Add("refEquipment")
                _ColumnNames.Add("nameEquipment")

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("equipment_id", "Codigo | Equipment", False, True, False,
                                                                               "Equipment", _ColumnNames, "Equipment", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unit
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitEquipment") = True

                _DataGridViewColumn = _UPDGViewPartidaEquipment.CreateColumnComboBox("unit_id", "Unit", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit, 3)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.ReadOnly = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column N°
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityEquipment", "N°", False, True, 2)
                _DataGridViewColumn.Visible = True


                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column N° of Hour
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("quantityhours", "Hours", False, True, 2)
                '_DataGridViewColumn = _UPDGViewPartidaEquipment.CrearteColumnFloat("rendimientoEquipment", "N° of Hours", False, True)
                _DataGridViewColumn.Visible = True

        End Select


    End Sub

    'Private Sub OnCrearpartidaTool()

    '    _UPDGViewPartidaTool = New UPDataGridView("partidaTool")
    '    _UPDGViewPartidaTool.Dock = DockStyle.Fill
    '    SetUPDGViewReadOnly(_UPDGViewPartidaTool, True)

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Cargar Columnas de: partidaTool
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    Dim _DataGridViewColumn As DataGridViewColumn

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Column Id
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    _DataGridViewColumn = _UPDGViewPartidaTool.CrearteColumnText("id", "id", True, False, False)
    '    _DataGridViewColumn.Visible = False

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Column partida_id
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    _DataGridViewColumn = _UPDGViewPartidaTool.CrearteColumnText("partida_id", "partida_id", True, False, False)
    '    _DataGridViewColumn.Visible = False

    '    Select Case PartidaTypeForm
    '        Case EnumPartidaTypeForm.ATN

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Codigo
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames As New List(Of String)  ' Tabla: Tool
    '            _ColumnNames.Add("refTool")
    '            _ColumnNames.Add("nameTool")

    '            _DataGridViewColumn = _UPDGViewPartidaTool.CreateColumnComboBox("tool_id", "Codigo | Herrmientas", False, True, False,
    '                                                                           "tool", _ColumnNames, "Herramienta", True, Nothing)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Unit
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames1 As New List(Of String)
    '            _ColumnNames1.Add("nameUnit")

    '            _DataGridViewColumn = _UPDGViewPartidaTool.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
    '                                                                           "unit", _ColumnNames1, "Unit", True, Nothing)
    '            _DataGridViewColumn.Visible = True

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Cantidad
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    '            _DataGridViewColumn = _UPDGViewPartidaTool.CrearteColumnFloat("quantityTool", "Cantidad", False, True)
    '            _DataGridViewColumn.Visible = True

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Costos de Posesión y Operación
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    '            _DataGridViewColumn = _UPDGViewPartidaTool.CrearteColumnFloat("costPyO", "Costo O & M", False, True)
    '            _DataGridViewColumn.Visible = True

    '    End Select

    'End Sub

    'Private Sub OnCrearpartidaTransport()

    '    _UPDGViewPartidaTransport = New UPDataGridView("partidaTransport")
    '    _UPDGViewPartidaTransport.Dock = DockStyle.Fill
    '    SetUPDGViewReadOnly(_UPDGViewPartidaTransport, True)

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Cargar Columnas de: partidaTransport
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    Dim _DataGridViewColumn As DataGridViewColumn

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Column Id
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnText("id", "id", True, False, False)
    '    _DataGridViewColumn.Visible = False

    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    'Column partida_id
    '    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '    _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnText("partida_id", "partida_id", True, False, False)
    '    _DataGridViewColumn.Visible = False

    '    Select Case PartidaTypeForm

    '        Case EnumPartidaTypeForm.ARG

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Codigo
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames As New List(Of String)  ' Tabla: Transport
    '            _ColumnNames.Add("refTransport")
    '            _ColumnNames.Add("nameTransport")

    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CreateColumnComboBox("transport_id", "Código | Transporte", False, True, False,
    '                                                                   "transport", _ColumnNames, "Transport", True, Nothing)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Unit
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames1 As New List(Of String)
    '            _ColumnNames1.Add("nameUnit")

    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CreateColumnComboBox("unit_id", "Unit", False, True, False,
    '                                                                   "unit", _ColumnNames1, "Unit", True, Nothing)
    '            _DataGridViewColumn.Visible = True

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Cantidad
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnFloat("quantityTransport", "Cantidad", False, True)
    '            _DataGridViewColumn.Visible = True

    '           '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---
    '            'Column Distancia
    '           '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--- 
    '            '_DataGridViewColumn = _UPDGViewPartidaMaterial.CrearteColumnFloat("distancia", "Distancia", False, True)
    '            '_DataGridViewColumn.Visible = True

    '        Case EnumPartidaTypeForm.ATN

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Codigo
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames As New List(Of String)  ' Tabla: Transport
    '            _ColumnNames.Add("refTransport")
    '            _ColumnNames.Add("nameTransport")

    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CreateColumnComboBox("transport_id", "Código | Transporte", False, True, False,
    '                                                                   "transport", _ColumnNames, "Transport", True, Nothing)
    '            _DataGridViewColumn.Visible = True
    '            _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Unit
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            Dim _ColumnNames1 As New List(Of String)
    '            _ColumnNames1.Add("nameUnit")

    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
    '                                                                   "unit", _ColumnNames1, "Unit", True, Nothing)
    '            _DataGridViewColumn.Visible = True

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Column Cantidad
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnFloat("quantityTransport", "Cantidad", False, True)
    '            _DataGridViewColumn.Visible = True

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---
    '            'Column Distancia
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--- 
    '            _DataGridViewColumn = _UPDGViewPartidaTransport.CrearteColumnFloat("distance", "Distancia", False, True)
    '            _DataGridViewColumn.Visible = True


    '    End Select

    'End Sub

    Private Sub OnCrearpartidaLabour()

        _UPDGViewPartidaLabour = New UPDataGridView("partidaLabour")
        _UPDGViewPartidaLabour.Dock = DockStyle.Fill
        SetUPDGViewReadOnly(_UPDGViewPartidaLabour, True)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cargar Columnas de: partidaLabour
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column partida_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnText("partida_id", "partida_id", True, False, False)
        _DataGridViewColumn.Visible = False

        Select Case PartidaTypeForm
            Case EnumPartidaTypeForm.CIV

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Código | Mano de Obra", False, True, False,
                                                                               "labour", _ColumnNames, "Mano de Obra", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.MinimumWidth = 300
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
                'CType(_DataGridViewColumn, UPDataGridViewColumnComboBox).IsFilterOptionsList = True  'XXXXX

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                     "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True

                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True

                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200
                _DataGridViewColumn.MinimumWidth = 60

            Case EnumPartidaTypeForm.MEX

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Código | Mano de Obra", False, True, False,
                                                                               "labour", _ColumnNames, "Mano de Obra", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                  "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Rendimiento
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("rendimientoLabour", "Rendimiento", False, True)
                _DataGridViewColumn.Visible = True


            Case EnumPartidaTypeForm.ARG

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Código | Mano de Obra", False, True, False,
                                                                               "labour", _ColumnNames, "Mano de Obra", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                  "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                '30/01
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
                _DataGridViewColumn.Width = 200

            Case EnumPartidaTypeForm.ATN

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Código | Mano de Obra", False, True, False,
                                                                               "labour", _ColumnNames, "Mano de Obra", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                  "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "Cantidad", False, True)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Prestaciones
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("prestacionesUser", "Prestaciones %", False, True)
                _DataGridViewColumn.Visible = True

            Case EnumPartidaTypeForm.USA

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Codigo
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames As New List(Of String)  ' Tabla: Labour
                _ColumnNames.Add("refLabour")
                _ColumnNames.Add("nameLabour")

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("labour_id", "Code | Labor", False, True, False,
                                                                               "labour", _ColumnNames, "Labor", True, Nothing)
                _DataGridViewColumn.Visible = True
                _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Unidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim _ColumnNames1 As New List(Of String)
                _ColumnNames1.Add("symbolUnit")
                Dim _dicValuesFilterUnit As New JObject()
                _dicValuesFilterUnit("unitLabour") = True

                _DataGridViewColumn = _UPDGViewPartidaLabour.CreateColumnComboBox("unit_id", "Unit", False, True, False,
                                                                                  "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)
                _DataGridViewColumn.Visible = True
                'todas las unidades de FORM USA son en horas, el Usuario no la selecciona
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column Cantidad
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityLabour", "N°", False, True)
                _DataGridViewColumn.Visible = True

                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                'Column N° de Horas
                '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                _DataGridViewColumn = _UPDGViewPartidaLabour.CrearteColumnFloat("quantityhours", "N° of Hours", False, True)
                _DataGridViewColumn.Visible = True

        End Select

    End Sub

    Private Sub RendimientoVisisble()

        Select Case PartidaTypeForm
            Case EnumPartidaTypeForm.CIV
                _UPlbl6.Visible = True
                _UPlbl7.Visible = True
                _UPCBoxUnitRendimiento.Visible = True
                _UPTxtRendimiento.Visible = True
            Case EnumPartidaTypeForm.MEX
                _UPlbl6.Visible = False
                _UPlbl7.Visible = False
                _UPCBoxUnitRendimiento.Visible = False
                _UPTxtRendimiento.Visible = False
            Case EnumPartidaTypeForm.ARG
                _UPlbl6.Visible = True
                _UPlbl7.Visible = True
                _UPCBoxUnitRendimiento.Visible = True
                _UPTxtRendimiento.Visible = True
            Case EnumPartidaTypeForm.ATN
                _UPlbl6.Visible = False
                _UPlbl7.Visible = False
                _UPCBoxUnitRendimiento.Visible = False
                _UPTxtRendimiento.Visible = False
            Case EnumPartidaTypeForm.USA
                _UPlbl6.Visible = True
                _UPlbl7.Visible = True
                _UPCBoxUnitRendimiento.Visible = True
                _UPTxtRendimiento.Visible = True
        End Select

    End Sub

    Private Sub LoadPartidaSeleccionada()

        If HasSelectedItem Then

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar Partida
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("partida", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            If _datatable.Rows.Count > 0 Then
                _UPTxtRefPartida.Text = _datatable.Rows(0)("refPartida")
                _UPTxtNamePartida.Text = _datatable.Rows(0)("namePartida")
                _UPTxtDescriptionPartida.Text = _datatable.Rows(0)("descriptionPartida")

                _UPCBoxUnitPartida.SetSelectedItem(_datatable.Rows(0)("unit_id"))

                _UPCBoxDataSourceInput.SetSelectedItem(_datatable.Rows(0)("appDataSourceInput_id"))

                _UPCBoxCharter.SetSelectedItem(_datatable.Rows(0)("chapter_id"))

                If Double.IsNaN(_datatable.Rows(0)("rendimiento")) Then
                    _UPTxtRendimiento.Value = 1
                Else
                    _UPTxtRendimiento.Value = _datatable.Rows(0)("rendimiento")
                End If

                _UPCBoxUnitRendimiento.SetSelectedItem(_datatable.Rows(0)("unitRendimiento_id"))
            Else
                _UPTxtRefPartida.Text = ""
                _UPTxtNamePartida.Text = ""
                _UPTxtDescriptionPartida.Text = ""
                _UPCBoxUnitPartida.SetSelectedItem(1)
                _UPCBoxDataSourceInput.SetSelectedItem(1)
                _UPCBoxCharter.SetSelectedItem(1)
                _UPTxtRendimiento.Value = 1 'Preguntar a Daniel

                _UPCBoxUnitRendimiento.SetSelectedItem(1)


            End If



            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaMaterial
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _ColumnNames1 As New List(Of String)

            Dim _dicValuesFilter1 As New JObject()
            _dicValuesFilter1("partida_id") = _id

            _UPDGViewPartidaMaterial.ReLoadData(_dicValuesFilter1, False)

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaEquitment
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            'Dim _dicValuesFilter2 As New JObject()
            '_dicValuesFilter1("partida_id") = _id

            _UPDGViewPartidaEquipment.ReLoadData(_dicValuesFilter1, False)

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaTool
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            '_UPDGViewPartidaTool.ReLoadData(_dicValuesFilter1, False)


            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaLabour
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            '_UPDGViewPartidaTransport.ReLoadData(_dicValuesFilter1, False)

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaLabour
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            _UPDGViewPartidaLabour.ReLoadData(_dicValuesFilter1, False)

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaCostValue
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OnCreateUPDGViewpartidaCostValue(False)

        Else
            _UPTxtRefPartida.Text = ""
            _UPTxtNamePartida.Text = ""
            _UPTxtDescriptionPartida.Text = ""

            _UPCBoxUnitPartida.SetSelectedFirtItem()
            _UPCBoxCharter.SetSelectedFirtItem()
            _UPTxtRendimiento.Value = 1
            _UPCBoxUnitRendimiento.SetSelectedFirtItem()

            _UPDGViewPartidaMaterial.DataSource = Nothing
            _UPDGViewPartidaEquipment.DataSource = Nothing
            '_UPDGViewPartidaTool.DataSource = Nothing
            '_UPDGViewPartidaTransport.DataSource = Nothing
            _UPDGViewPartidaLabour.DataSource = Nothing
            _UPDGViewpartidaCostValue.DataSource = Nothing

        End If

    End Sub

    Private Sub SavesPartida()

        If Validate1() Then

            _IsGuardando = True

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Guardando Partida
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()

            _dicValues("refPartida") = _UPTxtRefPartida.Text
            _dicValues("namePartida") = _UPTxtNamePartida.Text
            _dicValues("descriptionPartida") = _UPTxtDescriptionPartida.Text
            _dicValues("appDataSourceInput_id") = _UPCBoxDataSourceInput.GetSelectedItemId()
            _dicValues("chapter_id") = _UPCBoxCharter.GetSelectedItemId()
            _dicValues("unit_id") = _UPCBoxUnitPartida.GetSelectedItemId()
            _dicValues("rendimiento") = CType(_UPTxtRendimiento.Text, Double)
            _dicValues("unitRendimiento_id") = _UPCBoxUnitRendimiento.GetSelectedItemId()
            _dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                _dicValues("id") = selectedId

                If GetUpdateTable("partida", _DataServices) IsNot Nothing Then

                    Dim _idPartida As Int32 = selectedId

                    Select Case PartidaTypeForm
                        Case EnumPartidaTypeForm.CIV

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.MEX

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.ARG

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaTransport.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.ATN

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaTool.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaTransport.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.USA

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)


                    End Select

                    _UPDGViewpartidaCostValue.Saves("partida_id", _idPartida)

                    Dim _dicValuesFilter0 As New JObject
                    _dicValuesFilter0("project_id") = ProjectSelectedId

                    _UPDGViewList.LoadList(_dicValuesFilter0)
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else


                Dim _idPartida As Int32 = GetInsertTable("partida", _DataServices)
                If _idPartida > 0 Then

                    Select Case PartidaTypeForm
                        Case EnumPartidaTypeForm.CIV

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.MEX

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.ARG

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaTransport.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.ATN

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaTool.Saves("partida_id", _idPartida)
                            '_UPDGViewPartidaTransport.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                        Case EnumPartidaTypeForm.USA

                            _UPDGViewPartidaMaterial.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaEquipment.Saves("partida_id", _idPartida)
                            _UPDGViewPartidaLabour.Saves("partida_id", _idPartida)

                    End Select

                    _UPDGViewpartidaCostValue.Saves("partida_id", _idPartida)

                    Dim _dicValuesFilter0 As New JObject
                    _dicValuesFilter0("project_id") = ProjectSelectedId

                    _UPDGViewList.LoadList(_dicValuesFilter0)
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If
    End Sub

    Private Sub EnableControls(ByVal Enabled As Boolean)

        If Not _IsInitialize Then

            _UPTxtRefPartida.Enabled = Enabled
            _UPTxtNamePartida.Enabled = Enabled
            _UPTxtDescriptionPartida.Enabled = Enabled

            _UPCBoxUnitPartida.Enabled = Enabled
            _UPCBoxCharter.Enabled = Enabled

            _UPTxtRendimiento.Enabled = Enabled
            _UPCBoxUnitRendimiento.Enabled = Enabled

            _UPCBoxDataSourceInput.Enabled = Enabled

            SetUPDGViewReadOnly(_UPDGViewPartidaMaterial, Not Enabled)
            SetUPDGViewReadOnly(_UPDGViewPartidaEquipment, Not Enabled)
            'SetUPDGViewReadOnly(_UPDGViewPartidaTool, Not Enabled)
            'SetUPDGViewReadOnly(_UPDGViewPartidaTransport, Not Enabled)
            SetUPDGViewReadOnly(_UPDGViewPartidaLabour, Not Enabled)

            If PartidaTypeForm = EnumPartidaTypeForm.USA And Enabled Then
                _UPDGViewPartidaEquipment.Columns("unit_id").ReadOnly = True
            End If

        End If

    End Sub

    Private Sub OnDesabilitaEdit()
        LoadPartidaSeleccionada()
        EnableControls(False)
        If Not _IsGuardando Then
            btnGuardar.Visible = False
        End If

        _IsEdit = False

    End Sub

    Private Sub RefreshReportPriceAnalysis()

        If Not SplitContainerAPU.Panel2Collapsed Then

            If selectedId = -1 Then
                'MessageBox.Show("No hay partida seleccionada", "visualizar partida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SplitContainerAPU.Panel2Collapsed = True
                Exit Sub
            End If

            If _FormReportPriceAnalysis Is Nothing Then

                If IsPartidaARG Then

                    _FormReportPriceAnalysisArg = New FormReportPriceAnalisysArg(selectedId)

                    If _FormReportPriceAnalysisArg IsNot Nothing Then
                        _FormReportPriceAnalysisArg.TopLevel = False
                        _FormReportPriceAnalysisArg.FormBorderStyle = FormBorderStyle.None
                        _FormReportPriceAnalysisArg.Dock = DockStyle.Fill
                        SplitContainerAPU.Panel2.Controls.Add(_FormReportPriceAnalysisArg)
                        _FormReportPriceAnalysisArg.BringToFront()
                        _FormReportPriceAnalysisArg.Show()
                    End If

                Else
                    _FormReportPriceAnalysis = New FormReportPriceAnalysis(selectedId)

                    If _FormReportPriceAnalysis IsNot Nothing Then
                        _FormReportPriceAnalysis.TopLevel = False
                        _FormReportPriceAnalysis.FormBorderStyle = FormBorderStyle.None
                        _FormReportPriceAnalysis.Dock = DockStyle.Fill
                        SplitContainerAPU.Panel2.Controls.Add(_FormReportPriceAnalysis)
                        _FormReportPriceAnalysis.BringToFront()
                        _FormReportPriceAnalysis.Show()
                    End If

                End If

            Else
                If IsPartidaARG Then
                    _FormReportPriceAnalysisArg.RefreshReportPriceAnalysis(selectedId)
                Else
                    _FormReportPriceAnalysis.RefreshReportPriceAnalysis(selectedId)
                End If


            End If

        End If

    End Sub

    Private Sub ReportPriceAnalysisShow()

        SplitContainerAPU.Panel2Collapsed = Not SplitContainerAPU.Panel2Collapsed

        RefreshReportPriceAnalysis()



    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged
        If Not _IsInitialize AndAlso Visible Then
            OnDesabilitaEdit()
            RefreshReportPriceAnalysis()
        End If
    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        Dim _FormAPU1 As New FormAPU(appDataSourceInputId:=appDataSourceInputId, CharterId:=chapterId)

        If _FormAPU1.ShowDialog(Me) = DialogResult.OK Then
            ReloadPartidas()
            _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1) '21/11/24
        End If


    End Sub

    Private Sub _UPDGViewList_EvDuplicateSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvDuplicateSupply
        Dim _FormAPU1 As New FormAPU(appDataSourceInputId:=appDataSourceInputId, CharterId:=chapterId,
                                     DuplicatePartida_id:=selectedId)

        If _FormAPU1.ShowDialog(Me) = DialogResult.OK Then
            ReloadPartidas()
        End If
    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply
        'Dim _FormAPUEdit As New FormAPU(appDataSourceInputId:=appDataSourceInputId, appDataSourceInputId:=appDataSourceInputId)

        Dim _FormAPUEdit As New FormAPU(selectedId, -1, appDataSourceInputId:=appDataSourceInputId, CharterId:=chapterId)
        If _FormAPUEdit.ShowDialog(Me) = DialogResult.OK Then
            ReloadPartidas()
        End If

    End Sub

    Private Sub FormFormulacionPartidas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            OnDesabilitaEdit()

        End If
    End Sub

    'Private Sub FormFormulacionPartidas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    '    RemoveHandler CommonFuntion.EvProjectSeletedChnge, AddressOf Me.OnProjectSeletedChnge

    'End Sub

    'Private Sub btnReport_Click(sender As Object, e As EventArgs)
    '    Dim _Report As New FormReportPriceAnalysis(selectedId)
    '    _Report.Show(Me)
    'End Sub

    Private Sub btnReport_Click_1(sender As Object, e As EventArgs) Handles btnReport.Click '*******
        'Dim _Report As New FormReportPriceAnalysis(selectedId)
        ''_Report.Show(Me)

        '///////////////////////////////////////////////////////
        If IsPartidaARG Then
            'Dim _Report As New FormReportPriceAnalysis(selectedId)
            '_Report.Show(Me)

            Dim _Report = New FormReportPriceAnalisysArg(selectedId)
            _Report.Show(Me)

            '_FormReportPriceAnalysisArg.RefreshReportPriceAnalysis(selectedId)
        Else
            'Dim _Report As New FormReportPriceAnalysis(selectedId)
            '_Report.Show(Me)

            Dim _Report = New FormReportPriceAnalysis(selectedId)
            _Report.Show(Me)

            '_FormReportPriceAnalysis.RefreshReportPriceAnalysis(selectedId)
        End If
        '///////////////////////////////////////////////////////




    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) 
        'Dim _Report As New FormReportPriceAnalisysArg(selectedId)
        '_Report.Show(Me)
    End Sub

    Private Sub btnSplit1_Click(sender As Object, e As EventArgs) Handles btnSplit1.Click

        If selectedId = -1 Then
            MessageBox.Show("No hay partida seleccionada", "visualizar partida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Me.SplitContainerAPU.Panel2Collapsed = Not Me.SplitContainerAPU.Panel2Collapsed
            ReportPriceAnalysisShow()

        End If



    End Sub

    Private Sub FormFormulacionPartida_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        splitContPartida.SplitterDistance = 440

        splitContPartida.Panel1MinSize = 220
        splitContPartida.Panel2MinSize = 330


        Dim toolTipPart As New ToolTip()
        ' Configura los retrasos para el tooltip.
        toolTipPart.AutoPopDelay = 5000
        toolTipPart.InitialDelay = 1000
        toolTipPart.ReshowDelay = 500

        ' Muestra el tooltip siempre, independientemente de si el formulario está activo.
        toolTipPart.ShowAlways = True

        ' Asigna tooltips a los controles específicos.
        toolTipPart.SetToolTip(Me._UPCBoxChapterList, "Capítulo de la Partida")
        toolTipPart.SetToolTip(Me._UPTxtPartidaFilter, "Buscar partida")
        toolTipPart.SetToolTip(Me.btnChapter, "Cápitulos contenidos en el proyecto")
        toolTipPart.SetToolTip(Me.btnCostos, "Costos de la partida")
        toolTipPart.SetToolTip(Me.btnReport, "Reporte de la partida")
        toolTipPart.SetToolTip(Me.btnSplit1, "Vista con Reporte de la partida")

    End Sub

    Private Sub _UPCBoxChapter2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxChapterList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadPartidas()
            _UPTxtPartidaFilter.Text = ""
        End If
    End Sub

    Private Sub _UPTxtPartidaFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtPartidaFilter.TextChanged
        _UPDGViewList.FilterList(_UPTxtPartidaFilter.Text)
    End Sub

    Private Sub btnCostos_Click(sender As Object, e As EventArgs) Handles btnCostos.Click
        Dim _FormpartidaCost As New FormPartidaCost(_UPDGViewpartidaCostValue, True)
        _FormpartidaCost.ShowDialog(Me)
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SavesPartida()
    End Sub

    Private Sub btnPartidaFilter_Click(sender As Object, e As EventArgs) Handles btnPartidaFilter.Click
        If _UPDGViewList.Rows.Count = 0 Then
            ReloadPartidas()
        End If

        _UPDGViewList.FilterList(_UPTxtPartidaFilter.Text)
    End Sub

    Private Sub _UPCBoxDataSourceInputList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInputList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadPartidas()
            LoadPartidaSeleccionada()
            _UPTxtPartidaFilter.Text = ""
        End If


    End Sub

#Region "Bordes Botones"

    Private Sub btnChapter_Click(sender As Object, e As EventArgs) Handles btnChapter.Click
        Dim _FormChapterModal As New FormChapterModal()
        _FormChapterModal.ShowDialog()
    End Sub

    Private Sub btnSplit1_MouseEnter(sender As Object, e As EventArgs) Handles btnSplit1.MouseEnter
        btnSplit1.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnSplit1_MouseLeave(sender As Object, e As EventArgs) Handles btnSplit1.MouseLeave
        btnSplit1.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnChapter_MouseEnter(sender As Object, e As EventArgs) Handles btnChapter.MouseEnter
        btnChapter.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnChapter_MouseLeave(sender As Object, e As EventArgs) Handles btnChapter.MouseLeave
        btnChapter.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnReport_MouseEnter(sender As Object, e As EventArgs) Handles btnReport.MouseEnter
        btnReport.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReport_MouseLeave(sender As Object, e As EventArgs) Handles btnReport.MouseLeave
        btnReport.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnCostos_MouseEnter(sender As Object, e As EventArgs) Handles btnCostos.MouseEnter
        btnCostos.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCostos_MouseLeave(sender As Object, e As EventArgs) Handles btnCostos.MouseLeave
        btnCostos.FlatAppearance.BorderSize = 0
    End Sub








#End Region

End Class