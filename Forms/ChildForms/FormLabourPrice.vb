Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid
Public Class FormLabourPrice

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPTxtBox As UPTextBox
    Private WithEvents _UPCTBoxCodigoNombre As UPTextBox

    Private WithEvents _UPTxtLabourPriceFilter As UPTextBox

    Private WithEvents _UPTxtBoxNumerico1 As UPTextBoxNumerico

    Private WithEvents _UPCBoxUnit As UPComboBox
    Private WithEvents _UPCBoxUnit2 As UPComboBox
    Private WithEvents _UPCBoxCodigoNombre As UPComboBox
    Private WithEvents _UPCBoxDataSourceInpute As UPComboBox

    Private WithEvents _UPDateTimePicker As UPDateTimePicker

    Private _IsEdit As Boolean = False
    Private _labourPrice_Id As Int32 = -1
    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False

    Public Sub New()

        InitializeComponent()
        _IsInitialize = True
        '_IsCargandoConstructor = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtLabourPriceFilter = New UPTextBox
        _UPTxtLabourPriceFilter.Margin = New Padding(8, 0, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters (SourceInput)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInpute = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", True)
        _UPCBoxDataSourceInpute.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInpute.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInpute.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInpute.Dock = DockStyle.Fill
        _UPCBoxDataSourceInpute.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Mano de Obra
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Dim _dicValuesFilter As New JObject()
        '_dicValuesFilter = New JObject()
        '_dicValuesFilter = Nothing

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("isAtomic") = True

        If appDataSourceInputId > 0 Then
            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        End If

        _UPDGViewList = New UPDGViewList("labour", "refLabour", "nameLabour", "Código", "Nombre de Mano de Obra", _dicValuesFilter)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 0, 5, 8)
        _UPDGViewList.MenuItemEditSupplyVisible = False
        _UPDGViewList.CallDeletedActive = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _UPlbl1 = New UPLabel("Nombre")
        _UPlbl2 = New UPLabel("Unidad")
        _UPlbl3 = New UPLabel("Fecha")
        _UPlbl4 = New UPLabel($"Precio ({ProjectSymbolMoneyType})")
        _UPlbl6 = New UPLabel("Unidad para el precio")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  M a n o  d e  O b r a")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl7 = New UPLabel("E d i c i ó n  P r e c i o  d e  M a n o  d e  O b r a")
        _UPlbl7.SetFortmatEtiquetaInsumo()
        _UPlbl7.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Código - Nombre
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim _listLabour As New List(Of String)
        _listLabour.Add("refLabour")
        _listLabour.Add("nameLabour")

        _UPCBoxCodigoNombre = New UPComboBox("labour", _listLabour, "Labour", True)
        _UPCBoxCodigoNombre.SetSelectedItem(1)

        _UPCTBoxCodigoNombre = New UPTextBox

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Unit
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _listUnit As New List(Of String)
        _listUnit.Add("nameUnit")

        Dim _dicValuesFilterUnit As New JObject()
        _dicValuesFilterUnit("unitLabour") = True

        _UPCBoxUnit = New UPComboBox("unit", _listUnit, "Unidad", True, _dicValuesFilterUnit)
        _UPCBoxUnit.Margin = New System.Windows.Forms.Padding(8, 0, 4, 4)
        '_UPCBoxUnit.SetSelectedItem(2)

        _UPCBoxUnit2 = New UPComboBox("unit", _listUnit, "Unidad", True, _dicValuesFilterUnit)
        ' _UPCBoxUnit2.SetSelectedItem(2)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDateTimePicker Fecha
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDateTimePicker = New UPDateTimePicker()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Númerico
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtBoxNumerico1 = New UPTextBoxNumerico(0, Double.NaN)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListLabour.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListLabour.Controls.Add(_UPCBoxDataSourceInpute, 0, 1)

        Me.tlpListUnit.Controls.Add(_UPlbl6, 0, 0)

        Me._UPlbl6.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me._UPlbl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me._UPlbl6.Padding = New System.Windows.Forms.Padding(0)

        Me.tlpListUnit.Controls.Add(_UPCBoxUnit, 1, 0)

        Me.tlpLabourPriceLook.Controls.Add(_UPTxtLabourPriceFilter, 0, 0)

        Me.tlpListLabour.Controls.Add(_UPDGViewList, 0, 4)

        Me.tlpLabourEdition.Controls.Add(_UPlbl7, 0, 0)

        Me.tlpLabourEdition2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpLabourEdition2.Controls.Add(_UPlbl2, 0, 2)
        Me.tlpLabourEdition2.Controls.Add(_UPlbl3, 0, 3)
        Me.tlpLabourEdition2.Controls.Add(_UPlbl4, 0, 1)

        Me.tlpLabourEdition2.Controls.Add(_UPCTBoxCodigoNombre, 1, 0)
        Me.tlpLabourEdition2.Controls.Add(_UPCBoxUnit2, 1, 2)
        Me.tlpLabourEdition2.Controls.Add(_UPDateTimePicker, 1, 3)
        Me.tlpLabourEdition2.Controls.Add(_UPTxtBoxNumerico1, 1, 1)


        AddHandler CommonFuntion.EvProjectSeletedChnge, AddressOf OnProjectSeletedChnge

        _IsInitialize = False
        _UPDGViewList.SetSelectedItem(0)
        _UPCBoxUnit.SelectedIndex = 1
        _UPCBoxUnit2.SelectedIndex = 1

        btnGuardar1.Enabled = False

        EnableControls(False)

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
            Return _UPCBoxDataSourceInpute.GetSelectedItemId()
        End Get
    End Property

    Public Function Validate1() As Boolean
        'pendiente
        Return True
    End Function

    Private Sub EnableControls(ByVal Enabled As Boolean)

        _UPCBoxCodigoNombre.Enabled = Enabled
        _UPCBoxUnit2.Enabled = Enabled
        _UPDateTimePicker.Enabled = Enabled
        _UPTxtBoxNumerico1.Enabled = Enabled
        _UPCBoxCodigoNombre.Enabled = Enabled

    End Sub

    Private Sub OnProjectSeletedChnge(sender As Object, e As EventArgs)
        LoadPriceLabourSelect()
    End Sub

    Private Sub LoadPriceLabourSelect()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _listLabour2 As New List(Of String)

            Dim _dicValuesFilter2 As New JObject()
            _dicValuesFilter2("labour_id") = selectedId
            _dicValuesFilter2("unit_id") = _UPCBoxUnit.GetSelectedItemId()
            _dicValuesFilter2("project_id") = ProjectSelectedId

            Dim _SelectMax As String = "dateUser"

            Dim _datatable3 As DataTable = GetDataTable("labourPrice", ColumnNames:=_listLabour2,
                                                       dicValuesFilter:=_dicValuesFilter2, SelectMax:=_SelectMax)


            If _datatable3.Rows.Count > 0 Then

                _UPCBoxCodigoNombre.SetSelectedItem(_datatable3.Rows(0)("labour_id"))
                _UPCBoxUnit2.SetSelectedItem(_datatable3.Rows(0)("unit_id"))
                _UPDateTimePicker.Value = _datatable3.Rows(0)("dateUser")
                _UPTxtBoxNumerico1.Value = _datatable3.Rows(0)("price")
                _labourPrice_Id = _datatable3.Rows(0)("Id")
                _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text
            Else
                _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
                _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
                _UPDateTimePicker.Value = Now()
                _UPTxtBoxNumerico1.Value = Nothing
                _labourPrice_Id = -1
                _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text
            End If

        End If

    End Sub

    Private Sub ReloadLabour()

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("isAtomic") = True

        If appDataSourceInputId > 0 Then
            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        End If

        _UPDGViewList.ReLoadData(_dicValuesFilter, True)

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadPriceLabourSelect()
        EnableControls(False)

        If Not _IsGuardando Then
            btnGuardar1.Enabled = False
        End If

        _IsEdit = False

    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        ' _UPDGViewList.LoadList()
        btnGuardar1.Enabled = True
        EnableControls(True)
        _IsEdit = True

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        If HasSelectedItem Then

            _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing
            _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text
        Else

            _UPCBoxCodigoNombre.SetSelectedItem(1)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing
            _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text
        End If

        btnGuardar1.Enabled = True
        EnableControls(True)

        Me._UPTxtBoxNumerico1.Focus()
        Me._UPTxtBoxNumerico1.TabIndex = 1
        Me._UPCBoxUnit2.TabIndex = 2
        Me.btnGuardar1.TabIndex = 3
        Me.btnDataSource.TabIndex = 4
        Me.btnLabourPriceList.TabIndex = 6
        Me.btnReportLabourPriceList.TabIndex = 5


    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        If Validate1() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()

            _dicValues("labour_id") = _UPCBoxCodigoNombre.GetSelectedItemId()
            _dicValues("unit_id") = _UPCBoxUnit2.GetSelectedItemId()
            _dicValues("dateUser") = CType(_UPDateTimePicker.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("price") = CType(_UPTxtBoxNumerico1.Value, Double)
            _dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("labourPrice", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar1.Enabled = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("labourPrice", _DataServices) > 0 Then

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Precio guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar1.Enabled = False
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

        _UPTxtLabourPriceFilter.Clear()

    End Sub

    Private Sub _UPCBoxUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxUnit.SelectedIndexChanged

        LoadPriceLabourSelect()

    End Sub

    Private Sub _UPDGViewList_EvDeleteSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvDeleteSupply

        If selectedId > 0 AndAlso _labourPrice_Id > 0 Then
            GetDelete("labourPrice", _labourPrice_Id)
        End If

    End Sub

    Private Sub FormLabourPrice_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        splitContLabour.SplitterDistance = 440

        splitContLabour.Panel1MinSize = 220
        splitContLabour.Panel2MinSize = 330

        Dim toolTipLabour As New ToolTip()
        toolTipLabour.AutoPopDelay = 5000
        toolTipLabour.InitialDelay = 1000
        toolTipLabour.ReshowDelay = 500
        toolTipLabour.ShowAlways = True

        toolTipLabour.SetToolTip(Me.btnLabourFilter, "Busca de Mano de Obra")
        toolTipLabour.SetToolTip(Me.btnDataSource, "Ir a Origen de Datos")
        toolTipLabour.SetToolTip(Me.btnGuardar1, "Guardar Precio")
        toolTipLabour.SetToolTip(Me._UPCBoxDataSourceInpute, "Origen de Datos")
        toolTipLabour.SetToolTip(Me._UPCBoxDataSourceInpute, "Origen de Datos")
        toolTipLabour.SetToolTip(Me._UPTxtLabourPriceFilter, "Filtro dinámico mano de obra")

    End Sub

    Private Sub btnLabourFilter_Click(sender As Object, e As EventArgs) Handles btnLabourFilter.Click
        _UPDGViewList.FilterList(_UPTxtLabourPriceFilter.Text)
    End Sub

    Private Sub _UPTxtLabourPriceFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtLabourPriceFilter.TextChanged
        _UPDGViewList.FilterList(_UPTxtLabourPriceFilter.Text)
    End Sub

    Private Sub _UPDGViewList_DoubleClick(sender As Object, e As EventArgs) Handles _UPDGViewList.DoubleClick
        If HasSelectedItem Then

            _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing
            _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text

        Else

            _UPCBoxCodigoNombre.SetSelectedItem(1)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing
            _UPCTBoxCodigoNombre.Text = _UPCBoxCodigoNombre.Text

        End If

        btnGuardar1.Enabled = True
        EnableControls(True)
    End Sub

    Private Sub _UPCBoxDataSourceInpute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInpute.SelectedIndexChanged
        If Not _IsInitialize Then

            ReloadLabour()
            LoadPriceLabourSelect() 'Yo 22/08/24
            _UPTxtLabourPriceFilter.Text = ""
        End If
    End Sub

    Private Sub btnDataSource_Click(sender As Object, e As EventArgs) Handles btnDataSource.Click
        Dim _FormAppDataSource As New FormDataSourceInput()
        _FormAppDataSource.ShowDialog()
    End Sub

    Private Sub btnLabourPriceList_Click(sender As Object, e As EventArgs) Handles btnLabourPriceList.Click
        Dim _FormLabourPriceList As New FormLabourPriceList()
        _FormLabourPriceList.ShowDialog()

    End Sub


#Region "Bordes Botones"

    Private Sub btnDataSource_MouseEnter(sender As Object, e As EventArgs) Handles btnDataSource.MouseEnter
        btnDataSource.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnDataSource_MouseLeave(sender As Object, e As EventArgs) Handles btnDataSource.MouseLeave
        btnDataSource.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnGuardar1_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar1.MouseEnter
        btnGuardar1.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnGuardar1_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar1.MouseLeave
        btnGuardar1.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnLabourPriceList_MouseEnter(sender As Object, e As EventArgs) Handles btnLabourPriceList.MouseEnter
        btnLabourPriceList.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnLabourPriceList_MouseLeave(sender As Object, e As EventArgs) Handles btnLabourPriceList.MouseLeave
        btnLabourPriceList.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnReportLabourPriceList_MouseEnter(sender As Object, e As EventArgs) Handles btnReportLabourPriceList.MouseEnter
        btnReportLabourPriceList.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReportLabourPriceList_MouseLeave(sender As Object, e As EventArgs) Handles btnReportLabourPriceList.MouseLeave
        btnReportLabourPriceList.FlatAppearance.BorderSize = 1
    End Sub


#End Region

End Class