Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid
Public Class FormDataSourceInput
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtRefDataSourceInput As UPTextBox
    Private WithEvents _UPTxtNameDataSourceInput As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox

    Private _ListRefDataSourceInput As List(Of String)

    Private _IsEdit As Boolean = False
    Private _IsCargandoConstructor = False
    Public Sub New()

        InitializeComponent()

        _UPlbl0 = New UPLabel("Listado de Origen de Datos")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl5 = New UPLabel("Edición de Origen de Datos")
        _UPlbl5.SetFortmatEtiquetaInsumo()
        _UPlbl5.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Origen de datos para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefDataSourceInput = GetColumnList(Of String)("appDataSourceInput", "refDataSourceInput")
        Dim ListRefDataSourceInput1 As New List(Of String)
        For Each _RefDataSourceInput As String In _ListRefDataSourceInput
            ListRefDataSourceInput1.Add(Trim(_RefDataSourceInput))
        Next
        _ListRefDataSourceInput = ListRefDataSourceInput1


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Origen de Datos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDGViewList = New UPDGViewList("appDataSourceInput", "refDataSourceInput", "nameDataSourceInput", "Código", "Nombre Origen de Datos")
        _UPDGViewList.Columns(1).DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _UPDGViewList.Columns(2).DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        _UPDGViewList.CallDeletedActive = False

        '_UPDGViewList.ContextMenuStrip = Nothing

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefDataSourceInput = New UPTextBox(12)
        _UPTxtNameDataSourceInput = New UPTextBox(100)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListDataSourceInput.Controls.Add(_UPlbl0, 0, 0)

        Me.tlpEditionDataSourceInput2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEditionDataSourceInput2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpEditionDataSourceInput2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpEditionDataSourceInput.Controls.Add(_UPlbl5, 0, 0)
        Me.tlpEditionDataSourceInput2.Controls.Add(_UPTxtRefDataSourceInput, 1, 0)
        Me.tlpEditionDataSourceInput2.Controls.Add(_UPTxtNameDataSourceInput, 1, 1)
        Me.tlpEditionDataSourceInput2.Controls.Add(_UPTxtDescription, 1, 2)

        Me.tlpListDataSourceInput.Controls.Add(_UPDGViewList, 0, 1)

        btnGuardar.Visible = False

        EnableControls(False)

        _IsCargandoConstructor = False

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

    Public Function ValidateDataSourceImput() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefDataSourceInput.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameDataSourceInput.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 100) Then
            Return False

        End If

        Return True
    End Function

    Public _IsGuardando As Boolean = False


    Private Sub EnableControls(ByVal Enabled As Boolean)

        _UPTxtRefDataSourceInput.Enabled = Enabled
        _UPTxtNameDataSourceInput.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled

    End Sub

    Private Sub LoadDataSourceInput()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("appDataSourceInput", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefDataSourceInput.Text = _datatable.Rows(0)("refDataSourceInput")
            _UPTxtNameDataSourceInput.Text = _datatable.Rows(0)("nameDataSourceInput")
            _UPTxtDescription.Text = _datatable.Rows(0)("descriptioncostDataSourceInput")

        End If

    End Sub

    Private Sub ValidateRefDataSourceInput()
        Dim _RefDataSourceInput As String = _UPTxtRefDataSourceInput.Text.Trim()
        If _ListRefDataSourceInput.Contains(_RefDataSourceInput) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' _UPTxtRefLabour.Focus()
        End If

    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply
        btnGuardar.Visible = True
        EnableControls(True)
        _IsEdit = True
    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply
        _UPTxtRefDataSourceInput.Text = ""
        _UPTxtNameDataSourceInput.Text = ""
        _UPTxtDescription.Text = ""

        btnGuardar.Visible = True
        EnableControls(True)
        Me._UPTxtRefDataSourceInput.Focus()

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged
        LoadDataSourceInput()
        EnableControls(False)

        If Not _IsGuardando Then
            btnGuardar.Visible = False
        End If

        _IsEdit = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidateDataSourceImput() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refDataSourceInput") = _UPTxtRefDataSourceInput.Text
            _dicValues("nameDataSourceInput") = _UPTxtNameDataSourceInput.Text
            _dicValues("descriptioncostDataSourceInput") = _UPTxtDescription.Text

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("appDataSourceInput", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_SelectedIndex)

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            Else

                If GetInsertTable("appDataSourceInput", _DataServices) > 0 Then
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

    Private Sub FormDataSourceInput_Load(sender As Object, e As EventArgs) Handles Me.Load
        splitContDataSourceInput.SplitterDistance = 340
        splitContDataSourceInput.Panel1MinSize = 220
        splitContDataSourceInput.Panel2MinSize = 330
    End Sub

    Private Sub _UPTxtRefDataSourceInput_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefDataSourceInput.Validating
        ValidateRefDataSourceInput()
    End Sub
End Class