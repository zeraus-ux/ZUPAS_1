Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid
Imports System.Xml
Imports MS.Internal.WindowsRuntime.Windows
Imports System.Windows
Imports System.Security.Cryptography

Public Class FormMaterial

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel

    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPCBoxMaterialTypeList As UPComboBox
    Private WithEvents _UPCBoxMaterialType As UPComboBox
    Private WithEvents _UPCBoxDataSourceInputeList As UPComboBox
    Private WithEvents _UPCBoxDataSourceInpute As UPComboBox

    Private WithEvents _UPTxtRefMaterial As UPTextBox
    Private WithEvents _UPTxtNameMaterial As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox
    Private WithEvents _UPTxtFilterType As UPTextBox

    Private WithEvents _ChcBoxIsAtomico As UPCheckBox

    Private _IsEdit As Boolean = False
    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False
    Private _ListRefMaterial As List(Of String) '23/12

    Public Sub New()

        InitializeComponent()

        _IsInitialize = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Materiales para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefMaterial = GetColumnList(Of String)("material", "refMaterial")
        Dim _ListRefMaterial1 As New List(Of String)
        For Each _RefMaterial As String In _ListRefMaterial
            _ListRefMaterial1.Add(Trim(_RefMaterial))
        Next
        _ListRefMaterial = _ListRefMaterial1


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialMode As New List(Of String)
        _ColumnMaterialMode.Add("nameMaterialType")

        _UPCBoxMaterialTypeList = New UPComboBox("materialType", _ColumnMaterialMode, "Tipo de Material", True)
        _UPCBoxMaterialTypeList.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxMaterialTypeList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxMaterialTypeList.BackColor = Color.WhiteSmoke
        _UPCBoxMaterialTypeList.Dock = DockStyle.Fill
        _UPCBoxMaterialTypeList.SetSelectedItem(1)

        _UPTxtFilterType = New UPTextBox
        _UPTxtFilterType.Margin = New Padding(8, 0, 4, 8)
        _UPTxtFilterType.Dock = DockStyle.Fill

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: (SourceInput) Para la Lista
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInputeList = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", False)
        _UPCBoxDataSourceInputeList.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInputeList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInputeList.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInputeList.Dock = DockStyle.Fill
        _UPCBoxDataSourceInputeList.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Materiales
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter As New JObject()

        If materialTypeId > 0 Then
            _dicValuesFilter = New JObject()
            _dicValuesFilter("materialType_id") = materialTypeId
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

        _UPDGViewList = New UPDGViewList("material", "refMaterial", "nameMaterial", "Codigo", "Nombre del Material", _dicValuesFilter)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 0, 5, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Modo")
        _UPlbl5 = New UPLabel("Tipo de Material")
        _UPlbl7 = New UPLabel("Origen de Datos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  M a t e r i a l e s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl6 = New UPLabel("E d i c i ó n  d e  M a t e r i a l e s")
        _UPlbl6.SetFortmatEtiquetaInsumo()
        _UPlbl6.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefMaterial = New UPTextBox(13)

        _UPTxtRefMaterial.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
        _UPTxtNameMaterial = New UPTextBox(155)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Check Box
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ChcBoxIsAtomico = New UPCheckBox("Atómico")



        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: materialType
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _columnamesMaterialType As New List(Of String)
        _columnamesMaterialType.Add("nameMaterialType")
        _UPCBoxMaterialType = New UPComboBox("materialType", _columnamesMaterialType, "Tipo de Material", True)
        '_UPCBoxMaterialType.Margin = New System.Windows.Forms.Padding(4, 8, 8, 4)
        _UPCBoxMaterialType.BackColor = Color.WhiteSmoke

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInput
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource2 As New List(Of String)
        _ColumnMaterialSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInpute = New UPComboBox("appDataSourceInput", _ColumnMaterialSource2, "Fuente de Datos", True)
        _UPCBoxDataSourceInpute.BackColor = Color.WhiteSmoke

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListMaterial.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListMaterial.Controls.Add(_UPCBoxDataSourceInputeList, 0, 1)
        Me.tlpListMaterial.Controls.Add(_UPCBoxMaterialTypeList, 0, 2)
        Me.tlpListMaterial.Controls.Add(_UPDGViewList, 0, 4)

        Me.tlpMaterialLook.Controls.Add(_UPTxtFilterType, 0, 0)

        Me.tlpEdicionMaterial.Controls.Add(_UPlbl6, 0, 0)

        Me.tlpEditionMaterial2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEditionMaterial2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpEditionMaterial2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpEditionMaterial2.Controls.Add(_UPlbl4, 0, 3)
        Me.tlpEditionMaterial2.Controls.Add(_UPlbl7, 0, 4)
        Me.tlpEditionMaterial2.Controls.Add(_UPlbl5, 0, 5)

        Me.tlpEditionMaterial2.Controls.Add(_UPTxtRefMaterial, 1, 0)
        Me.tlpEditionMaterial2.Controls.Add(_UPTxtNameMaterial, 1, 1)
        Me.tlpEditionMaterial2.Controls.Add(_UPTxtDescription, 1, 2)
        Me.tlpEditionMaterial2.Controls.Add(_ChcBoxIsAtomico, 1, 3)
        Me.tlpEditionMaterial2.Controls.Add(_UPCBoxDataSourceInpute, 1, 4)
        Me.tlpEditionMaterial2.Controls.Add(_UPCBoxMaterialType, 1, 5)


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

    Public ReadOnly Property IsCompositeMaterial As Boolean
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

    Public ReadOnly Property materialTypeId As Int32
        Get
            Return _UPCBoxMaterialTypeList.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _UPCBoxDataSourceInputeList.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property material_Id As Int32 '19/12
        Get
            Return _UPDGViewList.selectedId
        End Get

    End Property

    Public ReadOnly Property materialName As String
        Get
            Return _UPDGViewList.selectedSupplyName
        End Get
    End Property

    Private Function ValidateMaterial() As Boolean

        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefMaterial.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameMaterial.Text, 150) Then
            Return False

            'ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 250) Then
            '    Return False

            'ElseIf Not ValidateDoubleIsNA("columnaprueba", Double.NaN) Then
            '    Return False

        End If

        Return True
    End Function

    Private Sub EnableControls(ByVal Enabled As Boolean)
        _UPTxtRefMaterial.Enabled = Enabled
        _UPTxtNameMaterial.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled
        _ChcBoxIsAtomico.Enabled = Enabled
        _UPCBoxMaterialType.Enabled = Enabled
        _UPCBoxDataSourceInpute.Enabled = Enabled
    End Sub

    Private Sub LoadMaterialSeleccionado()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("material", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            If _datatable.Rows.Count > 0 Then
                _UPTxtRefMaterial.Text = _datatable.Rows(0)("refMaterial")
                _UPTxtNameMaterial.Text = _datatable.Rows(0)("nameMaterial")
                _UPTxtDescription.Text = _datatable.Rows(0)("descriptionMaterial")
                _ChcBoxIsAtomico.Checked = _datatable.Rows(0)("isAtomic")
                _UPCBoxMaterialType.SetSelectedItem(_datatable.Rows(0)("materialType_id"))
                _UPCBoxDataSourceInpute.SetSelectedItem(_datatable.Rows(0)("appDataSourceInput_id"))
            Else
                _UPTxtRefMaterial.Text = ""
                _UPTxtNameMaterial.Text = ""
                _UPTxtDescription.Text = ""
                _ChcBoxIsAtomico.Checked = False
                _UPCBoxMaterialType.SetSelectedItem(1)
                _UPCBoxDataSourceInpute.SetSelectedItem(1)
            End If

        End If

    End Sub

    Private Sub ReloadMateriales()

        Dim _dicValuesFilter As JObject
        If materialTypeId > 0 Then
            _dicValuesFilter = New JObject()
            _dicValuesFilter("materialType_id") = materialTypeId
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

        If String.IsNullOrEmpty(_UPTxtFilterType.Text) Then
            _UPDGViewList.FilterList(_UPTxtFilterType.Text)
        End If


        'Dim _dicValuesFilter As JObject = Nothing

        'If materialTypeId > 0 Then

        '    If _dicValuesFilter Is Nothing Then
        '        _dicValuesFilter = New JObject()
        '    End If

        '    '_dicValuesFilter = New JObject()
        '    _dicValuesFilter("materialType_id") = materialTypeId
        'Else
        '    _dicValuesFilter = Nothing

        'End If

        'If appDataSourceInputId > 0 Then

        '    If _dicValuesFilter Is Nothing Then
        '        _dicValuesFilter = New JObject()
        '    End If

        '    _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        'Else
        '    _dicValuesFilter = Nothing
        'End If

        '_UPDGViewList.ReLoadData(_dicValuesFilter, True)

    End Sub

    Public Sub cerrarFormulario()

        Me.Close()

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadMaterialSeleccionado()
        EnableControls(False)
        If Not _IsGuardando Then
            btnGuardar.Enabled = False
        End If

        _IsEdit = False

    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        If IsCompositeMaterial Then

            Dim _FormCompoundMaterial As New FormCompoundMaterial(selectedId)
            If _FormCompoundMaterial.ShowDialog(Me) = DialogResult.OK Then
                ReloadMateriales()
            End If

        Else
            btnGuardar.Enabled = True
            EnableControls(True)
            _IsEdit = True
        End If

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        'If MessageBox.Show("Nuevo Materal compuesto?", "Material", MessageBoxButtons.YesNo,
        '                   MessageBoxIcon.Question) = MessageBoxResult.Yes Then

        '    Dim _FormCompoundMaterial As New FormCompoundMaterial(materialTypeId:=materialTypeId,
        '                                                          appDataSourceInputId:=appDataSourceInputId)

        '    If _FormCompoundMaterial.ShowDialog(Me) = DialogResult.OK Then

        '        ReloadMateriales()

        '        _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

        '    End If

        'Else
        'End If

        Me._UPTxtRefMaterial.Text = ""
        Me._UPTxtNameMaterial.Text = ""
        Me._UPTxtDescription.Text = ""
        Me._ChcBoxIsAtomico.Checked = True
        btnGuardar.Enabled = True
        EnableControls(True)
        Me._UPTxtRefMaterial.Focus()


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'tab's
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me._UPTxtRefMaterial.TabIndex = 1
            Me._UPTxtNameMaterial.TabIndex = 2
            Me._UPTxtDescription.TabIndex = 3
            Me._ChcBoxIsAtomico.TabIndex = 4
            Me._UPCBoxDataSourceInpute.TabIndex = 5
            Me._UPCBoxMaterialType.TabIndex = 6
            Me.btnGuardar.TabIndex = 7
            Me.btnDataSource.TabIndex = 8
            Me.btnMaterialType.TabIndex = 9
            Me.btnMaterialCompound.TabIndex = 10

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidateMaterial() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refMaterial") = Me._UPTxtRefMaterial.Text
            _dicValues("nameMaterial") = Me._UPTxtNameMaterial.Text
            _dicValues("descriptionMaterial") = Me._UPTxtDescription.Text
            _dicValues("isAtomic") = Me._ChcBoxIsAtomico.Checked
            _dicValues("materialType_id") = _UPCBoxMaterialType.GetSelectedItemId()
            _dicValues("appDataSourceInput_id") = _UPCBoxDataSourceInpute.GetSelectedItemId()

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("material", _DataServices) IsNot Nothing Then

                    '_UPDGViewList.LoadList()
                    ReloadMateriales()
                    _UPDGViewList.SetSelectedItem(_SelectedIndex)

                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _IsEdit = False
                    EnableControls(False)
                    btnGuardar.Enabled = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("material", _DataServices) > 0 Then
                    '_UPDGViewList.LoadList()
                    ReloadMateriales()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Enabled = False
                Else
                    'MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

        _UPTxtFilterType.Clear()

    End Sub

    Private Sub formMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        SplitContMaterial.SplitterDistance = 440

        SplitContMaterial.Panel1MinSize = 220
        SplitContMaterial.Panel2MinSize = 330

        Dim toolTipMat As New ToolTip()
        toolTipMat.AutoPopDelay = 5000
        toolTipMat.InitialDelay = 1000
        toolTipMat.ReshowDelay = 500
        toolTipMat.ShowAlways = True

        toolTipMat.SetToolTip(Me.btnMaterialFilter, "Busca el Material")
        toolTipMat.SetToolTip(Me.btnMaterialType, "Ir a Tipo del Material")
        toolTipMat.SetToolTip(Me.btnDataSource, "Ir a Origen de Datos")
        toolTipMat.SetToolTip(Me.btnGuardar, "Guardar Material")
        toolTipMat.SetToolTip(Me._UPCBoxDataSourceInputeList, "Origen de Datos")
        toolTipMat.SetToolTip(Me._UPCBoxMaterialTypeList, "Tipo de el Material")
        toolTipMat.SetToolTip(Me._UPCBoxDataSourceInpute, "Asigna Origen de Datos")
        toolTipMat.SetToolTip(Me._UPTxtFilterType, "Filtro Dinámico Materiales")
        toolTipMat.SetToolTip(Me.btnMaterialCompound, "Ir a Nuevo Material Compuesto")

    End Sub

    Private Sub _UPCBoxMaterialTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxMaterialTypeList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadMateriales()
            LoadMaterialSeleccionado()
            _UPTxtFilterType.Text = ""
        End If

    End Sub

    Private Sub _UPCBoxDataSourceInputeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInputeList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadMateriales()
            LoadMaterialSeleccionado()
            _UPTxtFilterType.Text = ""
        End If
    End Sub

    Private Sub btnMaterialFilter_Click(sender As Object, e As EventArgs) Handles btnMaterialFilter.Click
        _UPDGViewList.FilterList(_UPTxtFilterType.Text)
    End Sub

    Private Sub _UPTxtFilterType_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtFilterType.TextChanged
        '021124
        If String.IsNullOrEmpty(_UPTxtFilterType.Text) Then
            _UPDGViewList.FilterList(_UPTxtFilterType.Text)
        End If

    End Sub

    '021124

    Private Sub _UPTxtFilterType_KeyDown(sender As Object, e As KeyEventArgs) Handles _UPTxtFilterType.KeyDown
        _UPDGViewList.FilterList(_UPTxtFilterType.Text)
    End Sub

    Private Sub ValidateRefMaterial() '23/12
        Dim _RefMaterial As String = _UPTxtRefMaterial.Text.Trim()
        If _ListRefMaterial.Contains(_RefMaterial) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' _UPTxtRefMaterial.Focus()
        End If

    End Sub

    Private Sub btnMaterialType_Click(sender As Object, e As EventArgs) Handles btnMaterialType.Click
        Dim _FormMaterialType As New FormMaterialType()
        _FormMaterialType.ShowDialog()
    End Sub

    Private Sub btnDataSource_Click(sender As Object, e As EventArgs) Handles btnDataSource.Click
        Dim _FormAppDataSource As New FormDataSourceInput()
        _FormAppDataSource.ShowDialog()
    End Sub

    Private Sub btnMaterialCompound_Click(sender As Object, e As EventArgs) Handles btnMaterialCompound.Click
        ' Dim _FormCompoundMaterial As New FormCompoundMaterial()
        Dim _FormCompoundMaterial As New FormCompoundMaterial(materialTypeId:=materialTypeId,
                                                                  appDataSourceInputId:=appDataSourceInputId)
        _FormCompoundMaterial.Show(Me)
    End Sub

    Private Sub _UPTxtRefMaterial_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefMaterial.Validating
        ValidateRefMaterial()
    End Sub



#Region "Bordes Botones"

    Private Sub btnMaterialType_MouseEnter(sender As Object, e As EventArgs) Handles btnMaterialType.MouseEnter
        btnMaterialType.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMaterialType_MouseLeave(sender As Object, e As EventArgs) Handles btnMaterialType.MouseLeave
        btnMaterialType.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnGuardar_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnDataSource_MouseEnter(sender As Object, e As EventArgs) Handles btnDataSource.MouseEnter
        btnDataSource.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnDataSource_MouseLeave(sender As Object, e As EventArgs) Handles btnDataSource.MouseLeave
        btnDataSource.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnMaterialCompound_MouseEnter(sender As Object, e As EventArgs) Handles btnMaterialCompound.MouseEnter
        btnMaterialCompound.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMaterialCompound_MouseLeave(sender As Object, e As EventArgs) Handles btnMaterialCompound.MouseLeave
        btnMaterialCompound.FlatAppearance.BorderSize = 0
    End Sub

#End Region


End Class