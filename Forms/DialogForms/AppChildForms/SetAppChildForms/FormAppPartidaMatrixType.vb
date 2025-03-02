
Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormAppPartidaMatrixType

    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtRefMatrixType As UPTextBox
    Private WithEvents _UPTxtNameMatrixType As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox

    Private _IsEdit As Boolean = False

    Public Sub New()

        InitializeComponent()

        _UPDGViewList = New UPDGViewList("matrixProjectType", "refMatrixProjectType", "nameMatrixProjectType", "Código", "Nombre de la Matriz")

        _UPDGViewList.Columns("refMatrixProjectType").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _UPDGViewList.Columns("nameMatrixProjectType").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        _UPDGViewList.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        _UPDGViewList.CallDeletedActive = False 'xxxx
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefMatrixType = New UPTextBox(12)
        _UPTxtNameMatrixType = New UPTextBox(100)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpEdicionProjectMatrix.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEdicionProjectMatrix.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpEdicionProjectMatrix.Controls.Add(_UPlbl3, 0, 2)

        Me.tlpEdicionProjectMatrix.Controls.Add(_UPTxtRefMatrixType, 1, 0)
        Me.tlpEdicionProjectMatrix.Controls.Add(_UPTxtNameMatrixType, 1, 1)
        Me.tlpEdicionProjectMatrix.Controls.Add(_UPTxtDescription, 1, 2)

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

    Public Function ValidateMatrix() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefMatrixType.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameMatrixType.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 250) Then
            Return False


        End If

        Return True
    End Function

    Public _IsGuardando As Boolean = False

    Private Sub EnableControls(ByVal Enabled As Boolean)

        _UPTxtRefMatrixType.Enabled = Enabled
        _UPTxtNameMatrixType.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled

    End Sub

    Private Sub LoadMatrizSelected()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("matrixProjectType", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefMatrixType.Text = _datatable.Rows(0)("refMatrixProjectType")
            _UPTxtNameMatrixType.Text = _datatable.Rows(0)("nameMatrixProjectType")
            _UPTxtDescription.Text = _datatable.Rows(0)("descriptionMatrixProjectType")

        End If


    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadMatrizSelected()
        EnableControls(False)
        If Not _IsGuardando Then '3/2/2024
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

        _UPTxtRefMatrixType.Text = ""
        _UPTxtNameMatrixType.Text = ""
        _UPTxtDescription.Text = ""

        btnGuardar.Visible = True
        EnableControls(True)

        Me._UPTxtRefMatrixType.Focus()
        Me._UPTxtRefMatrixType.TabIndex = 1
        Me._UPTxtNameMatrixType.TabIndex = 2
        Me._UPTxtDescription.TabIndex = 3
        Me.btnGuardar.TabIndex = 4
        Me._UPDGViewList.TabIndex = 5

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidateMatrix() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refMatrixProjectType") = _UPTxtRefMatrixType.Text
            _dicValues("nameMatrixProjectType") = _UPTxtNameMatrixType.Text
            _dicValues("descriptionMatrixProjectType") = _UPTxtDescription.Text

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("matrixProjectType", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("matrixProjectType", _DataServices) > 0 Then
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

    Private Sub FormPartidaMatrixType_Load(sender As Object, e As EventArgs) Handles Me.Load

        splitContPartidaType.SplitterDistance = 400

        splitContPartidaType.Panel1MinSize = 350
        splitContPartidaType.Panel2MinSize = 350

    End Sub

    Private Sub _UPDGViewList_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles _UPDGViewList.AllowUserToDeleteRowsChanged

    End Sub
End Class