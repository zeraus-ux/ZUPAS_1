Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormStageModal
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtRefStage As UPTextBox
    Private WithEvents _UPTxtNameStage As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox

    Private _IdObra As Int32
    Private _IsCargandoConstructor = False

    Public Sub New(ByVal IdObra As Int32)

        ' This call is required by the designer.
        InitializeComponent()
        _IsCargandoConstructor = True
        _IdObra = IdObra

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  E t a p a s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl5 = New UPLabel("E d i c i ó n  d e  E t a p a s")
        _UPlbl5.SetFortmatEtiquetaInsumo()
        _UPlbl5.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Etapas
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter0 As New JObject
        _dicValuesFilter0("obra_id") = IdObra

        _UPDGViewList = New UPDGViewList("obraStage", "refStage", "nameStage", "Codigo", "Nombre de la Etapa", _dicValuesFilter0)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        _UPDGViewList.ContextMenuStrip = Nothing 'inhabilita el menu contextual

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Obra")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefStage = New UPTextBox(12)
        _UPTxtNameStage = New UPTextBox(100)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListStage.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpEditionStage2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEditionStage2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpEditionStage2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpEditionStage.Controls.Add(_UPlbl5, 0, 0)
        Me.tlpEditionStage2.Controls.Add(_UPTxtRefStage, 1, 0)
        Me.tlpEditionStage2.Controls.Add(_UPTxtNameStage, 1, 1)
        Me.tlpEditionStage2.Controls.Add(_UPTxtDescription, 1, 2)

        Me.tlpListStage.Controls.Add(_UPDGViewList, 0, 1)
        btnGuardar.Visible = False
        _IsCargandoConstructor = False
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

    Public Function ValidateStage() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefStage.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameStage.Text, 100) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 250) Then
            Return False

        End If

        Return True
    End Function

    Public _IsGuardando As Boolean = False

    Private Sub EnableControls(ByVal Enabled As Boolean)

        Me._UPTxtRefStage.Enabled = Enabled
        Me._UPTxtNameStage.Enabled = Enabled
        Me._UPTxtDescription.Enabled = Enabled

    End Sub

    Private Sub LoadObraStageSelect()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("obraStage", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            _UPTxtRefStage.Text = _datatable.Rows(0)("refStage")
            _UPTxtNameStage.Text = _datatable.Rows(0)("nameStage")
            _UPTxtDescription.Text = _datatable.Rows(0)("descriptionStage")

        End If

    End Sub


    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadObraStageSelect()

    End Sub

    Private Sub FormStageModal_Load(sender As Object, e As EventArgs) Handles Me.Load

        splitContStage.SplitterDistance = 340
        splitContStage.Panel1MinSize = 220
        splitContStage.Panel2MinSize = 330
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidateStage() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refStage") = _UPTxtRefStage.Text
            _dicValues("nameStage") = _UPTxtNameStage.Text
            _dicValues("descriptionStage") = _UPTxtDescription.Text
            _dicValues("obra_id") = selectedId 'preguntar a Daniel /???????????

            _DataServices.Add(_dicValues)

            Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
            _dicValues("id") = selectedId

            If GetUpdateTable("obraStage", _DataServices) IsNot Nothing Then ' Falta la funcion update
                MessageBox.Show("Saves.. Ok")

            Else
                MessageBox.Show("ERROR !!! Revisar")
            End If

            _IsGuardando = False

        End If
    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        Me._UPTxtRefStage.Text = ""
        Me._UPTxtNameStage.Text = ""
        Me._UPTxtDescription.Text = ""

        btnGuardar.Enabled = True
        EnableControls(True)
    End Sub
End Class