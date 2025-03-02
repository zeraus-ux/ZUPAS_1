Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormAppMoneyType
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtRefMoneyType As UPTextBox
    Private WithEvents _UPTxtNameMoneyType As UPTextBox
    Private WithEvents _UPTxtSimboloMoneyType As UPTextBox

    Private _IsEdit As Boolean = False

    Public Sub New()

        InitializeComponent()

        Me.Text = "Divisas disponibles"
        _UPDGViewList = New UPDGViewList("moneyType", "refMoneyType", "symbolMoneyType", "Código", "Nombre de la Moneda")

        _UPDGViewList.Columns("refMoneyType").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _UPDGViewList.Columns("symbolMoneyType").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        _UPDGViewList.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        _UPDGViewList.CallDeletedActive = False 'xxxx
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Símbolo")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefMoneyType = New UPTextBox(12)
        _UPTxtNameMoneyType = New UPTextBox(100)
        _UPTxtSimboloMoneyType = New UPTextBox(100)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpEdicionMoney.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEdicionMoney.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpEdicionMoney.Controls.Add(_UPlbl3, 0, 2)

        Me.tlpEdicionMoney.Controls.Add(_UPTxtRefMoneyType, 1, 0)
        Me.tlpEdicionMoney.Controls.Add(_UPTxtNameMoneyType, 1, 1)
        Me.tlpEdicionMoney.Controls.Add(_UPTxtSimboloMoneyType, 1, 2)

        PanelLista.Controls.Add(_UPDGViewList)

        btnGuardar.Visible = False

        EnableControls(False)

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

    Public Function ValidateMoney() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefMoneyType.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameMoneyType.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtSimboloMoneyType.Text, 250) Then
            Return False

        End If

        Return True
    End Function

    Public _IsGuardando As Boolean = False

    Private Sub EnableControls(ByVal Enabled As Boolean)

        _UPTxtRefMoneyType.Enabled = Enabled
        _UPTxtNameMoneyType.Enabled = Enabled
        _UPTxtSimboloMoneyType.Enabled = Enabled

    End Sub

    Private Sub LoadMoneySelected()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("moneyType", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefMoneyType.Text = _datatable.Rows(0)("refMoneyType")
            _UPTxtNameMoneyType.Text = _datatable.Rows(0)("nameMoneyType")
            _UPTxtSimboloMoneyType.Text = _datatable.Rows(0)("symbolMoneyType")

        End If

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadMoneySelected()
        EnableControls(False)
        If Not _IsGuardando Then
            btnGuardar.Visible = False
        End If

        _IsEdit = False
    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        If _UPDGViewList.selectedSupplyName = "Delete" Then
            'e.
        End If
        btnGuardar.Visible = True
        EnableControls(True)
        _IsEdit = True

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        _UPTxtRefMoneyType.Text = ""
        _UPTxtNameMoneyType.Text = ""
        _UPTxtSimboloMoneyType.Text = ""

        btnGuardar.Visible = True
        EnableControls(True)
        Me._UPTxtRefMoneyType.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidateMoney() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refMoneyType") = _UPTxtRefMoneyType.Text
            _dicValues("nameMoneyType") = _UPTxtNameMoneyType.Text
            _dicValues("symbolMoneyType") = _UPTxtSimboloMoneyType.Text

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("moneyType", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Moneda modificada", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("moneyType", _DataServices) > 0 Then
                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Moneda guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Visible = False
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

    End Sub

    Private Sub FormPartidaMatrixType_Load(sender As Object, e As EventArgs) Handles Me.Load

        splitContMoney.SplitterDistance = 400

        splitContMoney.Panel1MinSize = 350
        splitContMoney.Panel2MinSize = 350

    End Sub

End Class