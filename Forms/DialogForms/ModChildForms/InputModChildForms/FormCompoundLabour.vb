Imports Newtonsoft.Json.Linq
Imports System.Windows.Media.Media3D
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.ComponentModel
Public Class FormCompoundLabour
    Private _PanelListActived As System.Windows.Forms.UserControl = Nothing

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel

    Private WithEvents _UPTxtRefLabour As UPTextBox
    Private WithEvents _UPTxtNameLabour As UPTextBox
    Private WithEvents _UPTxtDescriptionLabour As UPTextBox

    Private WithEvents _PanelListLabour As PanelListLabour = Nothing

    Private WithEvents _UPDGViewCompoundLabour As UPDataGridView = Nothing

    Private WithEvents _ContextMenuStripPrices As ContextMenuStrip
    Private WithEvents _MenuItemNewPrices As ToolStripMenuItem

    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Private _IsGuardando As Boolean = False
    Private _IsEdit As Boolean = False
    Private _Labour_id As Int32 = -1
    Private _ListRefLabour As List(Of String) '23/12

    Public Sub New(Optional ByVal labour_id As Int32 = -1, Optional appDataSourceInputId As Int32 = -1)

        InitializeComponent()
        Me.Text = "Mano de obra compuesta"
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Mano de Obra para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefLabour = GetColumnList(Of String)("labour", "refLabour")
        Dim _ListRefLabour1 As New List(Of String)
        For Each _RefLabour As String In _ListRefLabour
            _ListRefLabour1.Add(Trim(_RefLabour))
        Next
        _ListRefLabour = _ListRefLabour1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Panel de Lista
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter1 As New JObject()
        _dicValuesFilter1("isAtomic") = True

        '_PanelListLabour = New PanelListLabour(_dicValuesFilter1, DSourceIsRequerido:=True)
        _PanelListLabour = New PanelListLabour(_dicValuesFilter1)
        _PanelListLabour.SetFilterSourceInput(appDataSourceInputId)
        _PanelListActived = _PanelListLabour

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _Labour_id = labour_id

        If labour_id > 0 Then
            _UPlbl0 = New UPLabel("E d i c i ó n  d e  M a n o  d e  O b r a  C o m p u e s t a")
            _IsEdit = True
        Else
            _UPlbl0 = New UPLabel("N u e v a   M a n o  d e  O b r a  C o m p u e s t a")
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

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefLabour = New UPTextBox(13)

        _UPTxtRefLabour.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
        _UPTxtNameLabour = New UPTextBox(155)
        _UPTxtDescriptionLabour = New UPTextBox(250)

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

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' ContextMenuStripPrices
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ContextMenuStripPrices = New ContextMenuStrip()

        _MenuItemNewPrices = New ToolStripMenuItem()
        _MenuItemNewPrices.Text = "Nuevo precio"

        _ContextMenuStripPrices.Items.Add(_MenuItemNewPrices)

        OnCrearpartidaLabour()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me.PanelHeader2.Controls.Add(_UPlbl0)

        Me.tlpCLEdit2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpCLEdit2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpCLEdit3.Controls.Add(_UPlbl3, 0, 0)

        Me.tlpCLEditLbl2.Controls.Add(_UPlbl4, 0, 0)
        Me.tlpCLEditTex2.Controls.Add(_UPCBoxDataSourceInput, 0, 0)

        Me.tlpCLEdit2.Controls.Add(_UPTxtRefLabour, 1, 0)
        Me.tlpCLEdit2.Controls.Add(_UPTxtNameLabour, 1, 1)
        Me.tlpCLEdit3.Controls.Add(_UPTxtDescriptionLabour, 1, 0)

        scCompoundLabour.Panel1.Controls.Add(_PanelListActived)
        scCompoundLabour.Panel2.Controls.Add(_UPDGViewCompoundLabour)

        LoadLabour()

        scParent.Panel2Collapsed = True

    End Sub

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _PanelListLabour.appDataSourceInputId
        End Get
    End Property

    Public ReadOnly Property compoundLabour_Id As Int32
        Get
            Dim _PartdiaLabour_Id As Object = _UPDGViewCompoundLabour.GetColumnValue("labour_Id")
            If _PartdiaLabour_Id IsNot Nothing Then
                Return _PartdiaLabour_Id
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property compoundLabourUnit_Id As Int32
        Get
            Dim _PartdiaLabour_Id As Object = _UPDGViewCompoundLabour.GetColumnValue("unit_id")
            If _PartdiaLabour_Id IsNot Nothing Then
                Return _PartdiaLabour_Id
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property labour_Id As Int32
        Get
            Return _PanelListLabour.selectedId
        End Get
    End Property

    Public ReadOnly Property labourName As String
        Get
            Return _PanelListLabour.labourName
        End Get
    End Property


    Private Sub OnCrearpartidaLabour()

        _UPDGViewCompoundLabour = New UPDataGridView("compoundLabour")
        _UPDGViewCompoundLabour.Dock = DockStyle.Fill
        _UPDGViewCompoundLabour.ContextMenuStrip = _ContextMenuStripPrices

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cargar Columnas de: partidaLabour
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _DataGridViewColumn As DataGridViewColumn

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewCompoundLabour.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column _labour_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewCompoundLabour.CrearteColumnText("labour_id", "labour_id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add("refLabour")
        _ColumnNames.Add("nameLabour")

        Dim _CbxdicValuesFilter As New JObject()
        _CbxdicValuesFilter("isAtomic") = True

        _DataGridViewColumn = _UPDGViewCompoundLabour.CreateColumnComboBox("labour2_id", "Código | Personal", False, True, False,
                                                                               "labour", _ColumnNames, "Personal", True,
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
        _dicValuesFilterUnit("unitLabour") = True

        _DataGridViewColumn = _UPDGViewCompoundLabour.CreateColumnComboBox("unit_id", "Unidad", False, True, False,
                                                                                    "unit", _ColumnNames1, "Unit", True, _dicValuesFilterUnit)

        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        _DataGridViewColumn.Width = 200
        _DataGridViewColumn.MinimumWidth = 60 '03/07


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cantidad
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewCompoundLabour.CrearteColumnFloat("quantityLabour", "Cantidad", False, True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _DataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        _DataGridViewColumn.Width = 200
        _DataGridViewColumn.MinimumWidth = 60 '03/07


        _UPDGViewCompoundLabour.SetUPDGViewReadOnly(False)
        _UPDGViewCompoundLabour.SetColumnReadOnly("labour_id", True)


    End Sub

    Private Sub LoadLabour()

        If _Labour_id > 0 Then


            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Cargar Partida
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dim _id As Int32 = _Labour_id

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("labour", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefLabour.Text = _datatable.Rows(0)("refLabour")
            _UPTxtNameLabour.Text = _datatable.Rows(0)("nameLabour")
            _UPTxtDescriptionLabour.Text = _datatable.Rows(0)("descriptionLabour")

            RefrechTables()

        End If
    End Sub

    Private Sub AddInsumo()
        If labour_Id > 0 Then

            Dim _List As List(Of Int32) = _UPDGViewCompoundLabour.GetListValues(Of Int32)("labour_id")

            If _List.Contains(labour_Id) Then

                MessageBox.Show($"Mano de Obra '{labourName}' cargado", "Mano de Obra", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Dim _dicValues As New JObject()
                _dicValues("labour2_id") = labour_Id
                _dicValues("quantityLabour") = 1
                _dicValues("unit_id") = 4

                _UPDGViewCompoundLabour.LoadRow(_dicValues)
            End If

            _UPDGViewCompoundLabour.StartEditing()
            _UPDGViewCompoundLabour.AllowUserToAddRows = False
        End If
    End Sub

    Public Function ValidateCopmLabour() As Boolean

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
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefLabour.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameLabour.Text, 155) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescriptionLabour.Text, 250) Then
            Return False

        End If

        Return True

    End Function

    Private Sub RefrechTables()
        Dim _dicValuesFilter As New JObject
        _dicValuesFilter("labour_id") = _Labour_id

        _UPDGViewCompoundLabour.ReLoadData(_dicValuesFilter)

        'ValidatePrecios()
    End Sub

    Private Sub SavesPartida()

        If ValidateCopmLabour() Then

            _IsGuardando = True

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ' Guardando Partida
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            Dim _DataServices As New JArray()
            Dim _dicValues As New JObject()

            _dicValues("refLabour") = _UPTxtRefLabour.Text
            _dicValues("nameLabour") = _UPTxtNameLabour.Text
            _dicValues("descriptionLabour") = _UPTxtDescriptionLabour.Text
            _dicValues("isAtomic") = False
            _dicValues("appDataSourceInput_id") = appDataSourceInputId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                _dicValues("id") = _Labour_id

                If GetUpdateTable("labour", _DataServices) IsNot Nothing Then

                    _UPDGViewCompoundLabour.Saves("labour_id", _Labour_id)

                    Dim _dicValuesFilter As New JObject()
                    _dicValuesFilter("labour_id") = _Labour_id

                    _UPDGViewCompoundLabour.ReLoadData(dicValuesFilter:=_dicValuesFilter) 'yo

                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Close()
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            Else

                _Labour_id = GetInsertTable("labour", _DataServices)

                If _Labour_id > 0 Then

                    _UPDGViewCompoundLabour.Saves("labour_id", _Labour_id)

                    Dim _dicValuesFilter As New JObject()
                    _dicValuesFilter("labour_id") = _Labour_id

                    _UPDGViewCompoundLabour.ReLoadData(dicValuesFilter:=_dicValuesFilter) 'yo
                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    _IsEdit = True
                    'DialogResult = DialogResult.OK
                    'Close()
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            End If

            _IsGuardando = False

            ' LoadLabour()

        End If
    End Sub

    Private Sub ValidateRefLabour() '23/12
        Dim _RefLabour As String = _UPTxtRefLabour.Text.Trim()
        If _ListRefLabour.Contains(_RefLabour) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_UPTxtRefLabour.Focus()
        End If

    End Sub

    'Private Sub ValidatePrecios()
    '    Dim _price As Object
    '    Dim _labour_id As Int32
    '    Dim _ReferenceDate As DateTime
    '    Dim _moneyType_Id As Int32
    '    Dim _unit_id As Int32

    '    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

    '    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    '    DataGridViewCellStyle3.BackColor = Color.Red
    '    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    DataGridViewCellStyle3.ForeColor = Color.Red

    '    For Each _DataGridRow As DataGridViewRow In _UPDGViewCompoundLabour.Rows

    '        _labour_id = _DataGridRow.Cells("labour2_id").Value
    '        _ReferenceDate = Now
    '        _moneyType_Id = DisplayReportMoneyTypeid
    '        _unit_id = _DataGridRow.Cells("unit_id").Value

    '        _price = GetLabourprice(_labour_id, _ReferenceDate, _moneyType_Id,
    '                                   _unit_id)
    '        'no obedece estas lineas ???????????
    '        If Not IsNumeric(_price) OrElse Double.IsNaN(_price) Or True Then

    '            _DataGridRow.Cells("labour2_id").Style.ApplyStyle(DataGridViewCellStyle3)
    '        Else
    '            _DataGridRow.Cells("labour2_id").Style.ForeColor = Color.Black
    '        End If

    '    Next

    'End Sub

    Private Sub _PanelListLabour_DoubleClick(sender As Object, e As EventArgs) Handles _PanelListLabour.EvDoubleClick
        AddInsumo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SavesPartida()

        'If IsReportPriceAnalysisShow Then
        '    ReportPriceAnalysisShowRefresh()
        'End If
    End Sub

    Private Sub _UPDGViewPartidaLabour_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles _UPDGViewCompoundLabour.CellBeginEdit
        If e.ColumnIndex = 2 Then
            e.Cancel = True
        End If
    End Sub

#Region "NewPrices"

    Private Sub _ContextMenuStripPrices_Opening(sender As Object, e As CancelEventArgs) Handles _ContextMenuStripPrices.Opening
        _MenuItemNewPrices.Enabled = compoundLabourUnit_Id > 0
    End Sub

    Private Sub _MenuItemNewPrices_Click(sender As Object, e As EventArgs) Handles _MenuItemNewPrices.Click

        Dim _FormLabourPriceModal As New FormLabourPriceModal(compoundLabourUnit_Id, compoundLabourUnit_Id)
        If _FormLabourPriceModal.ShowDialog(Me) = DialogResult.OK Then
            'ReportPriceAnalysisShowRefresh()
        End If


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub FormCompoundLabour_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            DialogResult = DialogResult.Cancel

        Else
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub FormCompoundLabour_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
    End Sub

    Private Sub _UPTxtRefLabour_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefLabour.Validating
        ValidateRefLabour()
    End Sub

#End Region

End Class