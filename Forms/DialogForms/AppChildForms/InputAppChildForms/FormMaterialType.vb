Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormMaterialType

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtRefMaterialType As UPTextBox
    Private WithEvents _UPTxtNameMaterialType As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox

    Private _ListRefMaterialType As List(Of String)

    Private _IsEdit As Boolean = False
    Private _IsCargandoConstructor = False
    Public Sub New()

        InitializeComponent()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Pendiente preguntar a Daniel

        If Me.WindowState = FormWindowState.Maximized Then
            _UPlbl0 = New UPLabel("L i s t a d o  d e  T i p o s  d e  M a t e r i a l e s")
            _UPlbl5 = New UPLabel("E d i c i ó n  d e  T i p o s  d e  M a t e r i a l e s")

        Else
            _UPlbl0 = New UPLabel("Tipo de Materiales")
            _UPlbl5 = New UPLabel("Edición de Tipos de Materiales")
        End If
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        _UPlbl5.SetFortmatEtiquetaInsumo()
        _UPlbl5.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista tipos de material para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefMaterialType = GetColumnList(Of String)("materialType", "refMaterialType")
        Dim _ListRefMaterialType1 As New List(Of String)
        For Each _RefDataSourceInput As String In _ListRefMaterialType
            _ListRefMaterialType1.Add(Trim(_RefDataSourceInput))
        Next
        _ListRefMaterialType = _ListRefMaterialType1


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Tipos de Materiales
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDGViewList = New UPDGViewList("materialType", "refMaterialType", "nameMaterialType", "Código", "Nombre del Tipo de Material") '13/07
        _UPDGViewList.Columns(1).DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _UPDGViewList.Columns(2).DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        _UPDGViewList.CallDeletedActive = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefMaterialType = New UPTextBox(12)
        _UPTxtNameMaterialType = New UPTextBox(100)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListMaterialType.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpEditionMaterialType2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEditionMaterialType2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpEditionMaterialType2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpEditionMaterialType.Controls.Add(_UPlbl5, 0, 0)
        Me.tlpEditionMaterialType2.Controls.Add(_UPTxtRefMaterialType, 1, 0)
        Me.tlpEditionMaterialType2.Controls.Add(_UPTxtNameMaterialType, 1, 1)
        Me.tlpEditionMaterialType2.Controls.Add(_UPTxtDescription, 1, 2)

        Me.tlpListMaterialType.Controls.Add(_UPDGViewList, 0, 1)

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

    Public Function ValidateMaterialType() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefMaterialType.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameMaterialType.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 250) Then
            Return False

        End If

        Return True
    End Function

    Public _IsGuardando As Boolean = False

    Private Sub EnableControls(ByVal Enabled As Boolean)

        _UPTxtRefMaterialType.Enabled = Enabled
        _UPTxtNameMaterialType.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled

    End Sub

    Private Sub LoadMaterialTypeSelected()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("materialType", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefMaterialType.Text = _datatable.Rows(0)("refMaterialType")
            _UPTxtNameMaterialType.Text = _datatable.Rows(0)("nameMaterialType")
            _UPTxtDescription.Text = _datatable.Rows(0)("descriptionMaterialType")

        End If

    End Sub

    Private Sub ValidateRefMaterialType() '23/12
        Dim _RefMaterialType As String = _UPTxtRefMaterialType.Text.Trim()
        If _ListRefMaterialType.Contains(_RefMaterialType) Then
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

        _UPTxtRefMaterialType.Text = ""
        _UPTxtNameMaterialType.Text = ""
        _UPTxtDescription.Text = ""

        btnGuardar.Visible = True
        EnableControls(True)

        Me._UPTxtRefMaterialType.Focus()

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadMaterialTypeSelected()
        EnableControls(False)

        If Not _IsGuardando Then
            btnGuardar.Visible = False
        End If

        _IsEdit = False

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidateMaterialType() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refMaterialType") = _UPTxtRefMaterialType.Text
            _dicValues("nameMaterialType") = _UPTxtNameMaterialType.Text
            _dicValues("descriptionMaterialType") = _UPTxtDescription.Text

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("materialType", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_SelectedIndex)

                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _IsEdit = False
                    EnableControls(False)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            Else

                If GetInsertTable("materialType", _DataServices) > 0 Then
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

    Private Sub FormMaterialType_Load(sender As Object, e As EventArgs) Handles Me.Load
        splitContMaterialType.SplitterDistance = 340
        splitContMaterialType.Panel1MinSize = 220
        splitContMaterialType.Panel2MinSize = 330
    End Sub

    Private Sub _UPTxtRefMaterialType_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefMaterialType.Validating
        ValidateRefMaterialType()
    End Sub
End Class