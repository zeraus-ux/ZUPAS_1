Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormTool

    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel

    Private WithEvents _UPTxtRefTool As UPTextBox
    Private WithEvents _UPTxtNameTool As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox

    Private WithEvents _UPDGViewList As UPDGViewList
    Private _IsEdit As Boolean = False

    Public Sub New()

        InitializeComponent()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Herramientas
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _UPDGViewList = New UPDGViewList("tool", "refTool", "nameTool", "Código", "Nombre de la Herramienta")
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(10, 0, 5, 25)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefTool = New UPTextBox(12)
        _UPTxtNameTool = New UPTextBox(100)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListTool.Controls.Add(_UPDGViewList, 0, 1)

        Me.tlyPanelEdicion.Controls.Add(_UPlbl1, 0, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl2, 0, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl3, 0, 2)

        Me.tlyPanelEdicion.Controls.Add(_UPTxtRefTool, 1, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtNameTool, 1, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtDescription, 1, 2)

        btnGuardar.Visible = False

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

    Private Sub EnableControls(ByVal Enabled As Boolean)
        Me._UPTxtRefTool.Enabled = Enabled
        Me._UPTxtNameTool.Enabled = Enabled
        Me._UPTxtDescription.Enabled = Enabled

    End Sub

    Private Sub LoadHerramientaSeleccionada()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("tool", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            Me._UPTxtRefTool.Text = _datatable.Rows(0)("refTool")
            Me._UPTxtNameTool.Text = _datatable.Rows(0)("nameTool")
            Me._UPTxtDescription.Text = _datatable.Rows(0)("descriptionTool")

        End If

    End Sub

    Public Function Validate1() As Boolean
        'pendiente
        Return True
    End Function
    Public _IsGuardando As Boolean = False

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadHerramientaSeleccionada()
        EnableControls(False)
        If Not _IsGuardando Then '3/2/2024
            btnGuardar.Visible = False
        End If

        _IsEdit = False

    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        ' _UPDGViewList.LoadList()
        btnGuardar.Visible = True
        EnableControls(True)
        _IsEdit = True

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        Me._UPTxtRefTool.Text = ""
        Me._UPTxtNameTool.Text = ""
        Me._UPTxtDescription.Text = ""

        btnGuardar.Visible = True
        EnableControls(True)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Validate1() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refTool") = _UPTxtRefTool.Text
            _dicValues("nameTool") = _UPTxtNameTool.Text
            _dicValues("descriptionTool") = _UPTxtDescription.Text

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("tool", _DataServices) IsNot Nothing Then
                    'LoadListHerramientas()
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
                If GetInsertTable("tool", _DataServices) > 0 Then
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

    Private Sub FormTool_Load(sender As Object, e As EventArgs) Handles Me.Load
        splitContTool.SplitterDistance = 440

        splitContTool.Panel1MinSize = 220
        splitContTool.Panel2MinSize = 330
    End Sub
End Class