Imports Newtonsoft.Json.Linq
Imports System.Windows.Media.Media3D
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.ComponentModel
Imports System.Windows.Media.Animation
Imports System.Windows.Controls
Imports System.Diagnostics.Eventing.Reader
Public Class FormCompoundMaterial
    Private _PanelListActived As System.Windows.Forms.UserControl = Nothing

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel

    Private WithEvents _UPTxtRefMaterial As UPTextBox
    Private WithEvents _UPTxtNameMaterial As UPTextBox
    Private WithEvents _UPTxtDescriptionMaterial As UPTextBox

    Private WithEvents _PanelListMaterial As PanelListMaterial = Nothing

    Private WithEvents _UPDGViewMaterialInput As UPDataGridView = Nothing

    Private WithEvents _UPCBoxMaterialType As UPComboBox
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Private WithEvents _ContextMenuStripPrices As ContextMenuStrip
    Private WithEvents _MenuItemNewPrices As ToolStripMenuItem

    Private _IsGuardando As Boolean = False
    Private _IsEdit As Boolean = False
    Private _material_id As Int32 = -1
    Private _IsAddInsumo As Boolean = False
    Private _ListRefMaterial As List(Of String) '23/12

    Public Sub New(Optional ByVal material_id As Int32 = -1, Optional materialTypeId As Int32 = -1,
                   Optional appDataSourceInputId As Int32 = -1)

        InitializeComponent()
        Me.Text = "Material compuesto"
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Panel de Lista
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter1 As New JObject()
        _dicValuesFilter1("isAtomic") = True

        _PanelListMaterial = New PanelListMaterial(_dicValuesFilter1)
        _PanelListMaterial.SetFilters(materialTypeId, appDataSourceInputId)

        _PanelListActived = _PanelListMaterial


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Materiales para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefMaterial = GetColumnList(Of String)("material", "refMaterial")
        Dim _ListRefMaterial1 As New List(Of String)
        For Each _RefMaterial As String In _ListRefMaterial
            _ListRefMaterial1.Add(Trim(_RefMaterial))
        Next
        _ListRefMaterial = _ListRefMaterial1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _material_id = material_id

        If material_id > 0 Then
            _UPlbl0 = New UPLabel("E d i c i ó n  d e  M a t e r i a l  C o m p u e s t o")
            _IsEdit = True
        Else
            _UPlbl0 = New UPLabel("N u e v o   M a t e r i a l  C o m p u e s t o")
        End If

        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: _UPlbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Tipo de Material")
        _UPlbl5 = New UPLabel("Origen de Datos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefMaterial = New UPTextBox(13)

        _UPTxtRefMaterial.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
        _UPTxtNameMaterial = New UPTextBox(155)
        _UPTxtDescriptionMaterial = New UPTextBox(250)

        '_UPTxtFilterType = New UPTextBox
        '_UPTxtFilterType.Margin = New Padding(8, 0, 4, 8)
        '_UPTxtFilterType.Dock = DockStyle.Fill

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
        'Cbox: materialType
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _columnamesMaterialType As New List(Of String)
        _columnamesMaterialType.Add("nameMaterialType")
        _UPCBoxMaterialType = New UPComboBox("materialType", _columnamesMaterialType, "Tipo de Material", True)
        '_UPCBoxMaterialType.Margin = New System.Windows.Forms.Padding(4, 8, 8, 4)
        _UPCBoxMaterialType.BackColor = Color.WhiteSmoke

        If materialTypeId > 0 Then
            _UPCBoxMaterialType.SetSelectedItem(materialTypeId)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' ContextMenuStripPrices
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ContextMenuStripPrices = New ContextMenuStrip()

        _MenuItemNewPrices = New ToolStripMenuItem()
        _MenuItemNewPrices.Text = "Nuevo precio"

        _ContextMenuStripPrices.Items.Add(_MenuItemNewPrices)

        OnCrearMaterialComposed()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me.PanelHeader2.Controls.Add(_UPlbl0)

        Me.tlpCMEdit2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpCMEdit2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpCMEdit3.Controls.Add(_UPlbl3, 0, 0)

        Me.tlpCMEditLbl2.Controls.Add(_UPlbl5, 0, 0)
        Me.tlpCMEditLbl2.Controls.Add(_UPlbl4, 0, 1)

        Me.tlpCMEditTex2.Controls.Add(_UPCBoxDataSourceInput, 0, 0)
        Me.tlpCMEditTex2.Controls.Add(_UPCBoxMaterialType, 0, 1)

        Me.tlpCMEdit2.Controls.Add(_UPTxtRefMaterial, 1, 0)
        Me.tlpCMEdit2.Controls.Add(_UPTxtNameMaterial, 1, 1)
        Me.tlpCMEdit3.Controls.Add(_UPTxtDescriptionMaterial, 1, 0)

        'Me.tlpCMEdit3.Controls.Add(_UPDGViewMaterialInput, 1, 0)

        scCompoundMaterial.Panel1.Controls.Add(_PanelListActived)
        scCompoundMaterial.Panel2.Controls.Add(_UPDGViewMaterialInput)
        ' scCompoundMaterial.Panel2.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        _PanelListActived.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        LoadMaterial()

        scParent.Panel2Collapsed = True
        scCompoundMaterial.Panel2.Padding = New Padding(4, 0, 8, 0)

    End Sub

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _PanelListMaterial.appDataSourceInputId
        End Get
    End Property

    Public ReadOnly Property MaterialInput_Id As Int32 'PartdiaMaterial_Id
        Get
            Dim _MaterialComposed_Id As Object = _UPDGViewMaterialInput.GetColumnValue("material_Id")
            If _MaterialComposed_Id IsNot Nothing Then
                Return _MaterialComposed_Id
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property MaterialInputUnit_Id As Int32
        Get
            Dim _MaterialComposed_Id As Object = _UPDGViewMaterialInput.GetColumnValue("unit_id")
            If _MaterialComposed_Id IsNot Nothing Then
                Return _MaterialComposed_Id
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property material_Id As Int32
        Get
            Return _PanelListMaterial.selectedId
        End Get
    End Property

    Public ReadOnly Property materialName As String
        Get
            Return _PanelListMaterial.MaterialName
        End Get
    End Property

    Private Sub OnCrearMaterialComposed() 'OnCrearcompoundMaterial

        _UPDGViewMaterialInput = New UPDataGridView("compoundMaterial")
        _UPDGViewMaterialInput.Dock = DockStyle.Fill
        _UPDGViewMaterialInput.ContextMenuStrip = _ContextMenuStripPrices

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cargar Columnas de: Material Compuesto
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewMaterialInput.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column _material_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewMaterialInput.CrearteColumnText("material_id", "material_id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames As New List(Of String)  ' Tabla: Material
        _ColumnNames.Add("refMaterial")
        _ColumnNames.Add("nameMaterial")

        Dim _CbxdicValuesFilter As New JObject()
        _CbxdicValuesFilter("isAtomic") = True

        _DataGridViewColumn = _UPDGViewMaterialInput.CreateColumnComboBox("material2_id", "Código | Material", False, True, False,
                                                                           "material", _ColumnNames, "Material", True,
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
        _dicValuesFilterUnit("unitMaterial") = True

        _DataGridViewColumn = _UPDGViewMaterialInput.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                    "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)

        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        _DataGridViewColumn.Width = 100
        _DataGridViewColumn.MinimumWidth = 60 '03/07

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cantidad
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewMaterialInput.CrearteColumnFloat("quantityMaterial", "Cantidad", False, True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        _DataGridViewColumn.Width = 200
        _DataGridViewColumn.MinimumWidth = 60 '03/07


        _UPDGViewMaterialInput.SetUPDGViewReadOnly(False)
        _UPDGViewMaterialInput.SetColumnReadOnly("material_id", True)


    End Sub

    Private Sub LoadMaterial()

        If _material_id > 0 Then

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar Materiales
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _id As Int32 = _material_id

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("material", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefMaterial.Text = _datatable.Rows(0)("refMaterial")
            _UPTxtNameMaterial.Text = _datatable.Rows(0)("nameMaterial")
            _UPTxtDescriptionMaterial.Text = _datatable.Rows(0)("descriptionMaterial")
            _UPCBoxMaterialType.SetSelectedItem(_datatable.Rows(0)("materialType_id"))

            '_UPCBoxUnitPartida.SetSelectedItem(_datatable.Rows(0)("unit_id"))
            '_UPCBoxCharter.SetSelectedItem(_datatable.Rows(0)("chapter_id"))

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar partidaMaterial
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            'Dim _ColumnNames1 As New List(Of String)

            'Dim _dicValuesFilter1 As New JObject()
            '_dicValuesFilter1("partida_id") = _id

            '_UPDGViewMaterialInput.ReLoadData(_dicValuesFilter1, False)

            RefrechTables()

        End If

    End Sub

    Private Sub AddInsumo()
        If material_Id > 0 Then

            Dim _List As List(Of Int32) = _UPDGViewMaterialInput.GetListValues(Of Int32)("material_id")

            If _List.Contains(material_Id) Then

                MessageBox.Show($"Material '{materialName}' cargado", "Material", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Dim _dicValues As New JObject()
                _dicValues("material2_id") = material_Id
                _dicValues("quantityMaterial") = 1
                _dicValues("unit_id") = 2

                _UPDGViewMaterialInput.LoadRow(_dicValues)

                _IsAddInsumo = True
            End If

            _UPDGViewMaterialInput.StartEditing()
            _UPDGViewMaterialInput.AllowUserToAddRows = False
        End If
    End Sub

    Public Function ValidateCompMaterial() As Boolean

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
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefMaterial.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameMaterial.Text, 155) Then
            Return False

        ElseIf (_UPDGViewMaterialInput.Rows.Count > 0 AndAlso Not _IsAddInsumo AndAlso Not _IsEdit) _
            Or (_UPDGViewMaterialInput.Rows.Count = 0 And _IsEdit) Then
            'Dim _datarow As DataGridViewRow = _UPDGViewMaterialInput.Rows(0)

            Dim _Error As String = "Por favor cargar al menos un (01) material"
            MessageBox.Show(_Error, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

            'ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescriptionMaterial.Text, 250) Then
            '    Return False

        End If

        Return True

    End Function

    Private Sub RefrechTables()
        Dim _dicValuesFilter As New JObject
        _dicValuesFilter("material_id") = _material_id

        _UPDGViewMaterialInput.ReLoadData(_dicValuesFilter)

        'ValidatePrecios()
    End Sub

    Private Sub SavesPartida()

        If ValidateCompMaterial() Then

            _IsGuardando = True

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Guardando Partida
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()

            _dicValues("refMaterial") = _UPTxtRefMaterial.Text
            _dicValues("nameMaterial") = _UPTxtNameMaterial.Text
            _dicValues("descriptionMaterial") = _UPTxtDescriptionMaterial.Text
            _dicValues("isAtomic") = 0
            _dicValues("materialType_id") = _UPCBoxMaterialType.GetSelectedItemId()
            _dicValues("appDataSourceInput_id") = appDataSourceInputId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                _dicValues("id") = _material_id

                If GetUpdateTable("material", _DataServices) IsNot Nothing Then

                    _UPDGViewMaterialInput.Saves("material_id", _material_id)

                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            Else

                _material_id = GetInsertTable("material", _DataServices)

                If _material_id > 0 Then

                    _UPDGViewMaterialInput.Saves("material_id", _material_id)

                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    _IsEdit = True
                    DialogResult = DialogResult.OK
                    Close()
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            End If

            _IsGuardando = False

            'LoadMaterial()

        End If
    End Sub

    'Private Sub ValidatePrecios()
    '    Dim _price As Object
    '    Dim _material_id As Int32
    '    Dim _ReferenceDate As DateTime
    '    Dim _moneyType_Id As Int32
    '    Dim _unit_id As Int32

    '    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

    '    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    '    DataGridViewCellStyle3.BackColor = Color.Red
    '    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    DataGridViewCellStyle3.ForeColor = Color.Red

    '    For Each _DataGridRow As DataGridViewRow In _UPDGViewMaterialInput.Rows


    '        _material_id = _DataGridRow.Cells("material2_id").Value
    '        _ReferenceDate = Now
    '        _moneyType_Id = DisplayReportMoneyTypeid
    '        _unit_id = _DataGridRow.Cells("unit_id").Value

    '        _price = GetMaterialPrice(_material_id, _ReferenceDate, _moneyType_Id,
    '                                   _unit_id)
    '        'no obedece estas lineas ???????????
    '        If Not IsNumeric(_price) OrElse Double.IsNaN(_price) Or True Then
    '            '_DataGridRow.Cells("material2_id").Style.BackColor = Color.Red
    '            '_DataGridRow.Cells("material2_id").Style.ForeColor = Color.Red

    '            _DataGridRow.Cells("material2_id").Style.ApplyStyle(DataGridViewCellStyle3)
    '        Else
    '            _DataGridRow.Cells("material2_id").Style.ForeColor = Color.Black
    '        End If

    '    Next

    'End Sub

    Private Sub _PanelListMaterial_EvDoubleClick(sender As Object, e As EventArgs) Handles _PanelListMaterial.EvDoubleClick
        AddInsumo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SavesPartida()

        'If IsReportPriceAnalysisShow Then
        '    ReportPriceAnalysisShowRefresh()
        'End If
    End Sub

    Private Sub _UPDGViewPartidaMaterial_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles _UPDGViewMaterialInput.CellBeginEdit
        If e.ColumnIndex = 2 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ValidateRefMaterial() '23/12
        Dim _RefMaterial As String = _UPTxtRefMaterial.Text.Trim()
        If _ListRefMaterial.Contains(_RefMaterial) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' _UPTxtRefMaterial.Focus()
        End If

    End Sub
#Region "NewPrices"

    Private Sub _ContextMenuStripPrices_Opening(sender As Object, e As CancelEventArgs) Handles _ContextMenuStripPrices.Opening
        _MenuItemNewPrices.Enabled = MaterialInput_Id > 0
    End Sub

    Private Sub _MenuItemNewPrices_Click(sender As Object, e As EventArgs) Handles _MenuItemNewPrices.Click

        Dim _FormMaterialPriceModal As New FormMaterialPriceModal(MaterialInputUnit_Id, MaterialInputUnit_Id)
        If _FormMaterialPriceModal.ShowDialog(Me) = DialogResult.OK Then
            'ReportPriceAnalysisShowRefresh()
        End If

    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub FormCompoundMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
    End Sub

    Private Sub _UPTxtRefMaterial_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefMaterial.Validating
        ValidateRefMaterial()
    End Sub

    'Private Sub FormCompoundMaterial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    If e.CloseReason = CloseReason.UserClosing Then
    '        DialogResult = DialogResult.Cancel
    '    Else
    '        DialogResult = DialogResult.OK
    '    End If
    'End Sub

#End Region

End Class