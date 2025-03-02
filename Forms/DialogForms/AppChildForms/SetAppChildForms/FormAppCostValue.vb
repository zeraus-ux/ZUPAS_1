Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormAppCostValue
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtRefCostValue As UPTextBox
    Private WithEvents _UPTxtNameCostValue As UPTextBox
    Private WithEvents _UPTxtDescriptionCostValue As UPTextBox
    Private WithEvents _UPTxtVariableNameCostValue As UPTextBox

    Private WithEvents _UPTxtBoxFactorCostValue As UPTextBoxNumerico
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
        'Lista de Costos Prefijados
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("MatrixProjectType_id") = IdMatrixProjectType

        _UPDGViewList = New UPDGViewList("appCostValue", "refCostValue", "nameCostValue", "Código", "Nombre", _dicValuesFilter)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        _UPDGViewList.Columns("refCostValue").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _UPDGViewList.CallDeletedActive = False 'xxxx

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Valor del Factor")
        _UPlbl5 = New UPLabel("Tipo de Matriz")
        _UPlbl6 = New UPLabel("Nombre en la Fórmula")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Cuadros de textos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefCostValue = New UPTextBox(12)
        _UPTxtNameCostValue = New UPTextBox(100)
        _UPTxtDescriptionCostValue = New UPTextBox(250)
        _UPTxtVariableNameCostValue = New UPTextBox(12)

        ' _UPTxtDescriptionCostValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        '_UPTxtBoxFactorCostValue = New UPTextBoxNumerico(0, 1000)
        _UPTxtBoxFactorCostValue = New UPTextBoxNumerico(0, 1000000)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpMatrixType.Controls.Add(_UPlbl5, 0, 0)
        Me.tlpMatrixType.Controls.Add(_UPCBoxMatrixProjectType1, 1, 0)
        Me.tlpListCostSetting.Controls.Add(_UPDGViewList)

        Me.tlyPanelEdicion.Controls.Add(_UPlbl1, 0, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl2, 0, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl3, 0, 2)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl4, 0, 3)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl6, 0, 4)

        Me.tlyPanelEdicion.Controls.Add(_UPTxtRefCostValue, 1, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtNameCostValue, 1, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtDescriptionCostValue, 1, 2)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtBoxFactorCostValue, 1, 3)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtVariableNameCostValue, 1, 4)

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

    Public Function ValidateCostValue() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefCostValue.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameCostValue.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescriptionCostValue.Text, 250) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtVariableNameCostValue.Text, 250) Then
            Return False
            'falta _UPTxtBoxFactorCostValue
        End If

        Return True
    End Function

    Public _IsGuardando As Boolean = False

    Private Sub EnableControls(ByVal Enabled As Boolean)
        _UPTxtRefCostValue.Enabled = Enabled
        _UPTxtNameCostValue.Enabled = Enabled
        _UPTxtDescriptionCostValue.Enabled = Enabled
        _UPTxtBoxFactorCostValue.Enabled = Enabled
        _UPTxtVariableNameCostValue.Enabled = Enabled

    End Sub

    Private Sub LoadCostSettingSelected()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("appCostValue", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            If _datatable.Rows.Count > 0 Then

                _UPTxtRefCostValue.Text = _datatable.Rows(0)("refCostValue")
                _UPTxtNameCostValue.Text = _datatable.Rows(0)("nameCostValue")
                _UPTxtDescriptionCostValue.Text = _datatable.Rows(0)("descriptionCostValue")
                _UPTxtBoxFactorCostValue.Value = _datatable.Rows(0)("defaultCostValue")
                _UPTxtVariableNameCostValue.Text = _datatable.Rows(0)("variableNameCostValue")
            Else
                _UPTxtRefCostValue.Text = ""
                _UPTxtNameCostValue.Text = ""
                _UPTxtDescriptionCostValue.Text = ""
                _UPTxtBoxFactorCostValue.Value = 0
                _UPTxtVariableNameCostValue.Text = ""
            End If

        End If

    End Sub


    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadCostSettingSelected()
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

        _UPTxtRefCostValue.Text = ""
        _UPTxtNameCostValue.Text = ""
        _UPTxtDescriptionCostValue.Text = ""
        _UPTxtVariableNameCostValue.Text = ""

        _UPTxtBoxFactorCostValue.Value = 0

        btnGuardar.Visible = True
        EnableControls(True)
        Me._UPTxtRefCostValue.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidateCostValue() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refCostValue") = _UPTxtRefCostValue.Text
            _dicValues("nameCostValue") = _UPTxtNameCostValue.Text
            _dicValues("descriptionCostValue") = _UPTxtDescriptionCostValue.Text
            _dicValues("defaultCostValue") = CType(_UPTxtBoxFactorCostValue.Text, Double)
            _dicValues("variableNameCostValue") = _UPTxtVariableNameCostValue.Text

            _dicValues("matrixProjectType_id") = _UPCBoxMatrixProjectType1.GetSelectedItemId()

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("appCostValue", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("appCostValue", _DataServices) > 0 Then
                    _UPDGViewList.LoadList()
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

    Private Sub FormappCostValue_Load(sender As Object, e As EventArgs) Handles Me.Load
        splitContCostSetting.SplitterDistance = 340
        splitContCostSetting.Panel1MinSize = 220
        splitContCostSetting.Panel2MinSize = 330
    End Sub

    Private Sub _UPCBoxMatrixProjectType1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxMatrixProjectType1.SelectedIndexChanged
        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("MatrixProjectType_id") = IdMatrixProjectType
        _UPDGViewList.LoadList(_dicValuesFilter)
    End Sub

End Class