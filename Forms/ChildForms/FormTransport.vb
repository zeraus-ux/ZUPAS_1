Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid

Public Class FormTransport

    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel

    Private WithEvents _UPTxtRefTransport As UPTextBox
    Private WithEvents _UPTxtNameTransport As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox
    Private WithEvents _UPDGViewList As UPDGViewList

    Private _IsEdit As Boolean = False
    Private _ListRefTransport As List(Of String) '23/12

    Public Sub New()

        InitializeComponent()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Materiales para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefTransport = GetColumnList(Of String)("transport", "refTransport")
        Dim _ListRefTransport1 As New List(Of String)
        For Each _RefTransport As String In _ListRefTransport
            _ListRefTransport1.Add(Trim(_RefTransport))
        Next
        _ListRefTransport = _ListRefTransport1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Transporte
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDGViewList = New UPDGViewList("transport", "refTransport", "nameTransport", "Código", "Nombre del Transporte")
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
        _UPTxtRefTransport = New UPTextBox(13)
        _UPTxtNameTransport = New UPTextBox(150)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        tlpListMaterial.Controls.Add(_UPDGViewList)

        Me.tlyPanelEdicion.Controls.Add(_UPlbl1, 0, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl2, 0, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl3, 0, 2)

        Me.tlyPanelEdicion.Controls.Add(_UPTxtRefTransport, 1, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtNameTransport, 1, 1)
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
        Me._UPTxtRefTransport.Enabled = Enabled
        Me._UPTxtNameTransport.Enabled = Enabled
        Me._UPTxtDescription.Enabled = Enabled

    End Sub

    Private Sub LoadTransporteSeleccionado()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("transport", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            Me._UPTxtRefTransport.Text = _datatable.Rows(0)("refTransport")
            Me._UPTxtNameTransport.Text = _datatable.Rows(0)("nameTransport")
            Me._UPTxtDescription.Text = _datatable.Rows(0)("descriptionTransport")

        End If

    End Sub

    Public Function ValidateTransport() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefTransport.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameTransport.Text, 150) Then
            Return False

            'ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 250) Then
            '    Return False

            'ElseIf Not ValidateDoubleIsNA("columnaprueba", Double.NaN) Then
            '    Return False

        End If

        Return True
    End Function

    Private Sub ValidateRefTransport() '23/12
        Dim _RefTransport As String = _UPTxtRefTransport.Text.Trim()
        If _ListRefTransport.Contains(_RefTransport) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _UPTxtRefTransport.Focus()
        End If

    End Sub

    Public _IsGuardando As Boolean = False
    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadTransporteSeleccionado()
        EnableControls(False)
        If Not _IsGuardando Then '3/2/2024
            btnGuardar.Visible = False
        End If

        _IsEdit = False

    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        '_UPDGViewList.LoadList()
        btnGuardar.Visible = True
        EnableControls(True)
        _IsEdit = True

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        Me._UPTxtRefTransport.Text = ""
        Me._UPTxtNameTransport.Text = ""
        Me._UPTxtDescription.Text = ""

        btnGuardar.Visible = True
        EnableControls(True)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidateTransport() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refTransport") = Me._UPTxtRefTransport.Text
            _dicValues("nameTransport") = Me._UPTxtNameTransport.Text
            _dicValues("descriptionTransport") = Me._UPTxtDescription.Text

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("transport", _DataServices) IsNot Nothing Then

                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("transport", _DataServices) > 0 Then
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

    Private Sub FormTransport_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        splitContTransport.SplitterDistance = 440

        splitContTransport.Panel1MinSize = 220
        splitContTransport.Panel2MinSize = 330
    End Sub

    Private Sub _UPTxtRefTransport_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefTransport.Validating
        ValidateRefTransport()
    End Sub
End Class