Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormAppCostCalType

    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel
    Private WithEvents _UPlbl8 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtBoxRefCostCalType As UPTextBox
    Private WithEvents _UPTxtBoxNameCostCalType As UPTextBox
    Private WithEvents _UPTxtBoxDecriptionCostCalType As UPTextBox
    Private WithEvents _UPTxtBoxFormatReportCostCalType As UPTextBox
    Private WithEvents _UPTxtBoxFormulaCostCalType As UPTextBox
    Private WithEvents _UPTxtBoxOrdenCostCalType As UPTextBoxNumerico
    Private WithEvents _UPTxtBoxVariableNameCostCalType As UPTextBox

    Private WithEvents _ChcBoxIsSystem As UPCheckBox

    Private WithEvents _UPCBoxMatrixProjectType1 As UPComboBox

    Private _IsEdit As Boolean = False
    Private _IsCargandoConstructor = False

    Public Sub New()

        InitializeComponent()

        _IsCargandoConstructor = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Combo Box1 filter matrixProjectType    
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim _ColumnNames22 As New List(Of String)
        _ColumnNames22.Add("nameMatrixProjectType")

        _UPCBoxMatrixProjectType1 = New UPComboBox("matrixProjectType", _ColumnNames22, "Matriz", True)
        _UPCBoxMatrixProjectType1.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Formulas Costos 
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("MatrixProjectType_id") = IdMatrixProjectType

        _UPDGViewList = New UPDGViewList("appCostCalType", "RefCostCalType", "NameCostCalType", "Código", "Nombre", _dicValuesFilter)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        _UPDGViewList.Columns("RefCostCalType").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _UPDGViewList.MenuItemEditSupplyVisible = False  'xxxx
        _UPDGViewList.CallDeletedActive = False 'xxxx
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Texto en el Reporte")
        _UPlbl5 = New UPLabel("Fórmula del Costo")
        _UPlbl6 = New UPLabel("Orden de la Fórmula")
        _UPlbl7 = New UPLabel("Nombre de la Fórmula")

        _UPlbl8 = New UPLabel("Tipo de Matriz")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Cuadros de textos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _UPTxtBoxRefCostCalType = New UPTextBox(12)
        _UPTxtBoxNameCostCalType = New UPTextBox(100)
        _UPTxtBoxDecriptionCostCalType = New UPTextBox(250)
        _UPTxtBoxFormatReportCostCalType = New UPTextBox(250)
        _UPTxtBoxFormulaCostCalType = New UPTextBox(250)
        _UPTxtBoxOrdenCostCalType = New UPTextBoxNumerico(0, 15)
        _UPTxtBoxVariableNameCostCalType = New UPTextBox(12)


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 

        Me.tlpMatrizList.Controls.Add(_UPlbl8, 0, 0)
        Me.tlpMatrizList.Controls.Add(_UPCBoxMatrixProjectType1, 1, 0)
        Me.tlpListCostType.Controls.Add(_UPDGViewList)

        Me.tlyPanelEdicion.Controls.Add(_UPlbl1, 0, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl2, 0, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl3, 0, 2)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl4, 0, 3)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl5, 0, 4)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl6, 0, 5)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl7, 0, 6)


        Me.tlyPanelEdicion.Controls.Add(_UPTxtBoxRefCostCalType, 1, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtBoxNameCostCalType, 1, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtBoxDecriptionCostCalType, 1, 2)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtBoxFormatReportCostCalType, 1, 3)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtBoxFormulaCostCalType, 1, 4)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtBoxOrdenCostCalType, 1, 5)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtBoxVariableNameCostCalType, 1, 6)


        _IsCargandoConstructor = False
        EnableControls(False)
        btnGuardar.Visible = False
        _UPDGViewList.SetSelectedItem(0)

    End Sub

    Public ReadOnly Property IdMatrixProjectType As Int32
        Get
            Return _UPCBoxMatrixProjectType1.GetSelectedItemId()
        End Get
    End Property

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

    Public Function ValidateCost() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtBoxRefCostCalType.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtBoxNameCostCalType.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtBoxDecriptionCostCalType.Text, 250) Then
            Return False


        End If

        Return True
    End Function

    Public _IsGuardando As Boolean = False


    Private Sub EnableControls(ByVal Enabled As Boolean)

        _UPTxtBoxRefCostCalType.Enabled = Enabled
        _UPTxtBoxNameCostCalType.Enabled = Enabled
        _UPTxtBoxDecriptionCostCalType.Enabled = Enabled
        _UPTxtBoxFormatReportCostCalType.Enabled = Enabled
        _UPTxtBoxFormulaCostCalType.Enabled = Enabled
        _UPTxtBoxOrdenCostCalType.Enabled = Enabled
        _UPTxtBoxVariableNameCostCalType.Enabled = Enabled

    End Sub

    Private Sub LoadCostCalTypeSelected()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("appCostCalType", ColumnNames:=_ColumnNames,
                                                           dicValuesFilter:=_dicValuesFilter)

            If _datatable.Rows.Count > 0 Then

                _UPTxtBoxRefCostCalType.Text = _datatable.Rows(0)("RefCostCalType")
                _UPTxtBoxNameCostCalType.Text = _datatable.Rows(0)("NameCostCalType")
                _UPTxtBoxDecriptionCostCalType.Text = _datatable.Rows(0)("descriptionCostCalType")
                _UPTxtBoxFormatReportCostCalType.Text = _datatable.Rows(0)("textFormatCostCalType")
                _UPTxtBoxFormulaCostCalType.Text = _datatable.Rows(0)("formulaCostCalType")
                _UPTxtBoxOrdenCostCalType.Value = _datatable.Rows(0)("ordenCostCalType")
                _UPTxtBoxVariableNameCostCalType.Text = _datatable.Rows(0)("variableNameCostCalType")

            Else
                _UPTxtBoxRefCostCalType.Text = ""
                _UPTxtBoxNameCostCalType.Text = ""
                _UPTxtBoxDecriptionCostCalType.Text = ""
                _UPTxtBoxFormatReportCostCalType.Text = ""
                _UPTxtBoxFormulaCostCalType.Text = ""

                _UPTxtBoxVariableNameCostCalType.Text = ""
            End If

        End If

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadCostCalTypeSelected()
        EnableControls(False)
        If Not _IsGuardando Then
            btnGuardar.Visible = False
        End If

        _IsEdit = False
    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        btnGuardar.Visible = True
        EnableControls(True)
        _IsEdit = True
    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        _UPTxtBoxRefCostCalType.Text = ""
        _UPTxtBoxNameCostCalType.Text = ""
        _UPTxtBoxDecriptionCostCalType.Text = ""

        _UPTxtBoxFormatReportCostCalType.Text = ""
        _UPTxtBoxFormulaCostCalType.Text = ""
        '_UPTxtBoxOrdenCostCalType.Value = ""
        _UPTxtBoxVariableNameCostCalType.Text = ""

        btnGuardar.Visible = True
        EnableControls(True)

        Me._UPTxtBoxRefCostCalType.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidateCost() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject() 'DANIEL
            _dicValues("RefCostCalType") = _UPTxtBoxRefCostCalType.Text
            _dicValues("NameCostCalType") = _UPTxtBoxNameCostCalType.Text
            _dicValues("DescriptionCostCalType") = _UPTxtBoxDecriptionCostCalType.Text
            _dicValues("textFormatCostCalType") = _UPTxtBoxFormatReportCostCalType.Text
            _dicValues("formulaCostCalType") = _UPTxtBoxFormulaCostCalType.Text
            _dicValues("ordenCostCalType") = CType(_UPTxtBoxOrdenCostCalType.Text, Int32)
            _dicValues("variableNameCostCalType") = _UPTxtBoxVariableNameCostCalType.Text
            _dicValues("matrixProjectType_id") = _UPCBoxMatrixProjectType1.GetSelectedItemId()

            '_dicValues("isSystemCostCalType") = Me._ChcBoxIsSystem.Checked    preguntar a Daniel

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("appCostCalType", _DataServices) IsNot Nothing Then

                    'Dim _dicValuesFilter As New JObject()
                    '_dicValuesFilter("MatrixProjectType_id") = IdMatrixProjectType

                    _UPDGViewList.ReLoadData()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("appCostCalType", _DataServices) > 0 Then

                    _UPDGViewList.ReLoadData()
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

    Private Sub FormAppCostCalType_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim FormAppCostCalType As New FormAppCostCalType

        'FormAppCostCalType.Size = New Size(1500, 400)

        splitContCostCalType.SplitterDistance = 340

        splitContCostCalType.Panel1MinSize = 220
        splitContCostCalType.Panel2MinSize = 330
    End Sub

    Private Sub _UPCBoxMatrixProjectType1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxMatrixProjectType1.SelectedIndexChanged
        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("MatrixProjectType_id") = IdMatrixProjectType
        _UPDGViewList.LoadList(_dicValuesFilter)

    End Sub

End Class