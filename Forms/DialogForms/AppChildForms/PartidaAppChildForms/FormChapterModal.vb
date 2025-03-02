Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormChapterModal

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtRefChapter As UPTextBox
    Private WithEvents _UPTxtNameChapter As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox

    Private _IsEdit As Boolean = False
    Private _IsCargandoConstructor = False

    Public Sub New()

        InitializeComponent()
        _IsCargandoConstructor = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  C á p i t u l o s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl5 = New UPLabel("E d i c i ó n  d e  C á p i t u l o s")
        _UPlbl5.SetFortmatEtiquetaInsumo()
        _UPlbl5.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Cápitulos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        '<<<<<<<<<<<<<<<<<<<<<<<<<< debe seleccionar la lista de capitulos del proyecto Activo >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim _dicValuesFilterProj As JObject = Nothing '30/06
        '_dicValuesFilterProj("project_id") = -1  '30/06
        '_dicValuesFilterProj("project_id") = ProjectSelectedId


        _UPDGViewList = New UPDGViewList("chapter", "refChapter", "nameChapter", "Código", "Nombre del Cápitulo", _dicValuesFilterProj) '30/06
        _UPDGViewList.Columns(1).DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _UPDGViewList.Columns(2).DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft

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
        _UPTxtRefChapter = New UPTextBox(12)
        _UPTxtNameChapter = New UPTextBox(100)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListChapter.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpEditionChapter2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEditionChapter2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpEditionChapter2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpEditionChapter.Controls.Add(_UPlbl5, 0, 0)
        Me.tlpEditionChapter2.Controls.Add(_UPTxtRefChapter, 1, 0)
        Me.tlpEditionChapter2.Controls.Add(_UPTxtNameChapter, 1, 1)
        Me.tlpEditionChapter2.Controls.Add(_UPTxtDescription, 1, 2)

        Me.tlpListChapter.Controls.Add(_UPDGViewList, 0, 1)

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

    Public Function ValidateChapter() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefChapter.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameChapter.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 250) Then
            Return False


        End If

        Return True
    End Function

    Public _IsGuardando As Boolean = False


    Private Sub EnableControls(ByVal Enabled As Boolean)

        _UPTxtRefChapter.Enabled = Enabled
        _UPTxtNameChapter.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled

    End Sub


    Private Sub LoadChapterSelect()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("chapter", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefChapter.Text = _datatable.Rows(0)("refChapter")
            _UPTxtNameChapter.Text = _datatable.Rows(0)("nameChapter")
            _UPTxtDescription.Text = _datatable.Rows(0)("descriptionChapter")

        End If

    End Sub


    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        btnGuardar.Visible = True
        EnableControls(True)
        _IsEdit = True

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        _UPTxtRefChapter.Text = ""
        _UPTxtNameChapter.Text = ""
        _UPTxtDescription.Text = ""

        btnGuardar.Visible = True
        EnableControls(True)

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadChapterSelect()
        EnableControls(False)

        If Not _IsGuardando Then
            btnGuardar.Visible = False
        End If

        _IsEdit = False

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidateChapter() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refChapter") = _UPTxtRefChapter.Text
            _dicValues("nameChapter") = _UPTxtNameChapter.Text
            _dicValues("descriptionChapter") = _UPTxtDescription.Text
            _dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("chapter", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If

            Else

                If GetInsertTable("chapter", _DataServices) > 0 Then
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

    Private Sub FormStageModal_Load(sender As Object, e As EventArgs) Handles Me.Load

        splitContChapter.SplitterDistance = 340
        splitContChapter.Panel1MinSize = 220
        splitContChapter.Panel2MinSize = 330
    End Sub


End Class