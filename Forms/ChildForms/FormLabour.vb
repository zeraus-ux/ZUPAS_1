Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid
Imports System.Windows

Public Class FormLabour
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPTxtRefLabour As UPTextBox
    Private WithEvents _UPTxtNameLabour As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox
    Private WithEvents _UPTxtLabourFilter As UPTextBox

    Private WithEvents _UPCBoxCodigoNombre As UPComboBox

    Private WithEvents _UPCBoxDataSourceInput As UPComboBox
    Private WithEvents _UPCBoxDataSourceInputList As UPComboBox

    Private WithEvents _ChcBoxIsAtomico As UPCheckBox

    Private _IsEdit As Boolean = False
    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False
    Private _ListRefLabour As List(Of String) '23/12

    Public Sub New()

        InitializeComponent()
        _IsInitialize = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Mano de Obra para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefLabour = GetColumnList(Of String)("labour", "refLabour")
        Dim _ListRefLabour1 As New List(Of String)
        For Each _RefLabour As String In _ListRefLabour
            _ListRefLabour1.Add(Trim(_RefLabour))
        Next
        _ListRefLabour = _ListRefLabour1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Filters
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtLabourFilter = New UPTextBox
        _UPTxtLabourFilter.Margin = New Padding(8, 0, 4, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: (SourceInput) Para la Lista
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource As New List(Of String)
        _ColumnMaterialSource.Add("nameDataSourceInput")

        _UPCBoxDataSourceInputList = New UPComboBox("appDataSourceInput", _ColumnMaterialSource, "Origen de Datos", False)
        _UPCBoxDataSourceInputList.Margin = New Padding(8, 4, 4, 4)
        _UPCBoxDataSourceInputList.Padding = New Padding(0, 0, 0, 0)
        _UPCBoxDataSourceInputList.BackColor = Color.WhiteSmoke
        _UPCBoxDataSourceInputList.Dock = DockStyle.Fill
        _UPCBoxDataSourceInputList.SetSelectedItem(1)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Mano de Obra
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter = Nothing

        If appDataSourceInputId > 0 Then
            If _dicValuesFilter Is Nothing Then
                _dicValuesFilter = New JObject()
            End If

            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        Else
            _dicValuesFilter = Nothing
        End If

        _UPDGViewList = New UPDGViewList("labour", "reflabour", "namelabour", "Código", "Nombre de la Mano de Obra", _dicValuesFilter)
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 0, 5, 8)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Modo")
        _UPlbl5 = New UPLabel("Fuente de Datos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  M a n o  d e  O b r a")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPlbl6 = New UPLabel("E d i c i ó n  M a n o  d e  O b r a")
        _UPlbl6.SetFortmatEtiquetaInsumo()
        _UPlbl6.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefLabour = New UPTextBox(13)
        _UPTxtNameLabour = New UPTextBox(150)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Check Box
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ChcBoxIsAtomico = New UPCheckBox("Atómico")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInpute
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource2 As New List(Of String)
        _ColumnMaterialSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnMaterialSource2, "Origen de Datos", True)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListLabour.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListLabour.Controls.Add(_UPCBoxDataSourceInputList, 0, 1)
        Me.tlpListLabour.Controls.Add(_UPDGViewList, 0, 3)

        Me.tlpLabourLook.Controls.Add(_UPTxtLabourFilter, 0, 0)

        Me.tlpLabourEdition.Controls.Add(_UPlbl6, 0, 0)

        Me.tlpLabourEdition2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpLabourEdition2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpLabourEdition2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpLabourEdition2.Controls.Add(_UPlbl4, 0, 3)
        Me.tlpLabourEdition2.Controls.Add(_UPlbl5, 0, 4)

        Me.tlpLabourEdition2.Controls.Add(_UPTxtRefLabour, 1, 0)
        Me.tlpLabourEdition2.Controls.Add(_UPTxtNameLabour, 1, 1)
        Me.tlpLabourEdition2.Controls.Add(_UPTxtDescription, 1, 2)
        Me.tlpLabourEdition2.Controls.Add(_ChcBoxIsAtomico, 1, 3)
        Me.tlpLabourEdition2.Controls.Add(_UPCBoxDataSourceInput, 1, 4)

        btnGuardar.Enabled = False

        EnableControls(False)
        _IsInitialize = False
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

    Public ReadOnly Property appDataSourceInputId As Int32
        Get
            Return _UPCBoxDataSourceInputList.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property IsCompositeLabour As Boolean
        Get
            Return Not _ChcBoxIsAtomico.Checked
        End Get
    End Property

    Public Function ValidateLabour() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefLabour.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameLabour.Text, 150) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 250) Then
            Return False

        End If

        Return True
    End Function

    Public Sub cerrarFormulario() '051724
        Me.Close()
    End Sub

    Private Sub EnableControls(ByVal Enabled As Boolean)

        Me._UPTxtRefLabour.Enabled = Enabled
        Me._UPTxtNameLabour.Enabled = Enabled
        Me._UPTxtDescription.Enabled = Enabled
        Me._UPCBoxDataSourceInput.Enabled = Enabled
        Me._ChcBoxIsAtomico.Enabled = Enabled

    End Sub

    Private Sub LoadLabourSeleccionado()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("labour", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            If _datatable.Rows.Count > 0 Then

                Me._UPTxtRefLabour.Text = _datatable.Rows(0)("refLabour")
                Me._UPTxtNameLabour.Text = _datatable.Rows(0)("nameLabour")
                Me._UPTxtDescription.Text = _datatable.Rows(0)("descriptionLabour")
                Me._ChcBoxIsAtomico.Checked = _datatable.Rows(0)("isAtomic")
                Me._UPCBoxDataSourceInput.SetSelectedItem(_datatable.Rows(0)("appDataSourceInput_id"))

            Else

                Me._UPTxtRefLabour.Text = ""
                Me._UPTxtNameLabour.Text = ""
                Me._UPTxtDescription.Text = ""
                Me._ChcBoxIsAtomico.Checked = False
                Me._UPCBoxDataSourceInput.SetSelectedItem(1)

            End If

        End If

    End Sub

    Private Sub ReloadLabour()

        Dim _dicValuesFilter As JObject = Nothing

        If appDataSourceInputId > 0 Then
            If _dicValuesFilter Is Nothing Then
                _dicValuesFilter = New JObject()
            End If

            _dicValuesFilter("appDataSourceInput_id") = appDataSourceInputId
        Else
            _dicValuesFilter = Nothing
        End If

        _UPDGViewList.ReLoadData(_dicValuesFilter, True)

        If String.IsNullOrEmpty(_UPTxtLabourFilter.Text) Then
            _UPDGViewList.FilterList(_UPTxtLabourFilter.Text)
        End If

    End Sub

    Private Sub ValidateRefLabour() '23/12
        Dim _RefLabour As String = _UPTxtRefLabour.Text.Trim()
        If _ListRefLabour.Contains(_RefLabour) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' _UPTxtRefLabour.Focus()
        End If

    End Sub

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged
        LoadLabourSeleccionado()
        EnableControls(False)
        If Not _IsGuardando Then '3/2/2024
            btnGuardar.Enabled = False
        End If
        _IsEdit = False

    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        If IsCompositeLabour Then

            Dim _FormCompoundLabour As New FormCompoundLabour(selectedId)
            If _FormCompoundLabour.ShowDialog(Me) = DialogResult.OK Then
                ReloadLabour()
            End If

        Else
            btnGuardar.Enabled = True
            EnableControls(True)
            _IsEdit = True
        End If


    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        'If MessageBox.Show("Nueva Mano de Obra compuesta?", "Mano de Obra", MessageBoxButtons.YesNo,
        '                   MessageBoxIcon.Question) = MessageBoxResult.Yes Then

        '    Dim _FormCompoundLabour As New FormCompoundLabour(appDataSourceInputId:=appDataSourceInputId)

        '    If _FormCompoundLabour.ShowDialog(Me) = DialogResult.OK Then
        '        ReloadLabour()
        '        _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
        '    End If 

        'Else
        'End If


        Me._UPTxtRefLabour.Text = ""
        Me._UPTxtNameLabour.Text = ""
        Me._UPTxtDescription.Text = ""
        Me._ChcBoxIsAtomico.Checked = True

        btnGuardar.Enabled = True
        EnableControls(True)
        Me._UPTxtRefLabour.Focus()

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            'tab's
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Me._UPTxtRefLabour.TabIndex = 1
            Me._UPTxtNameLabour.TabIndex = 2
            Me._UPTxtDescription.TabIndex = 3
            Me._ChcBoxIsAtomico.TabIndex = 4
            Me._UPCBoxDataSourceInput.TabIndex = 5
            'Me._UPCBoxMaterialType.TabIndex = 6
            Me.btnGuardar.TabIndex = 6
            Me.btnDataSource.TabIndex = 7
            ' Me.btnMaterialType.TabIndex = 8
            Me.btnCompoundLabour.TabIndex = 8

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidateLabour() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refLabour") = Me._UPTxtRefLabour.Text
            _dicValues("nameLabour") = Me._UPTxtNameLabour.Text
            _dicValues("descriptionLabour") = Me._UPTxtDescription.Text
            _dicValues("isAtomic") = Me._ChcBoxIsAtomico.Checked
            _dicValues("appDataSourceInput_id") = _UPCBoxDataSourceInput.GetSelectedItemId()

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("labour", _DataServices) IsNot Nothing Then

                    ReloadLabour()
                    _UPDGViewList.SetSelectedItem(_SelectedIndex)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    _IsEdit = False
                    EnableControls(False)
                    btnGuardar.Enabled = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("labour", _DataServices) > 0 Then

                    ReloadLabour()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Enabled = False
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If
    End Sub

    Private Sub FormLabour_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New System.Drawing.Size(1000, 600)

        splitContLabour.SplitterDistance = 440

        splitContLabour.Panel1MinSize = 220
        splitContLabour.Panel2MinSize = 330

        Dim toolTipLabour As New ToolTip()
        toolTipLabour.AutoPopDelay = 5000
        toolTipLabour.InitialDelay = 1000
        toolTipLabour.ReshowDelay = 500
        toolTipLabour.ShowAlways = True

        toolTipLabour.SetToolTip(Me.btnLabourFilter, "Busca de Mano de Obra")
        toolTipLabour.SetToolTip(Me.btnDataSource, "Ir a Origen de Datos")
        toolTipLabour.SetToolTip(Me.btnGuardar, "Guardar Mano de Obra")
        toolTipLabour.SetToolTip(Me._UPCBoxDataSourceInputList, "Origen de Datos")
        toolTipLabour.SetToolTip(Me._UPCBoxDataSourceInput, "Asigna Origen de Datos")
        toolTipLabour.SetToolTip(Me._UPTxtLabourFilter, "Filtro Dinámico Mano de Obra")
        toolTipLabour.SetToolTip(Me.btnCompoundLabour, "Ir a Nueva Mano de Obra Compuesta")

    End Sub

    Private Sub btnLabourFilter_Click(sender As Object, e As EventArgs) Handles btnLabourFilter.Click
        _UPDGViewList.FilterList(_UPTxtLabourFilter.Text)
    End Sub

    Private Sub _UPTxtLabourFilter_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtLabourFilter.TextChanged
        _UPDGViewList.FilterList(_UPTxtLabourFilter.Text)
    End Sub

    Private Sub _UPCBoxDataSourceInputeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxDataSourceInputList.SelectedIndexChanged
        If Not _IsInitialize Then
            ReloadLabour()
            LoadLabourSeleccionado()
            _UPTxtLabourFilter.Text = ""
        End If
    End Sub

    Private Sub btnDataSource_Click(sender As Object, e As EventArgs) Handles btnDataSource.Click
        Dim _FormAppDataSource As New FormDataSourceInput()
        _FormAppDataSource.ShowDialog()
    End Sub

    Private Sub btnCompoundLabour_Click(sender As Object, e As EventArgs) Handles btnCompoundLabour.Click
        'Dim _FormCompoundLabour As New FormCompoundLabour()
        Dim _FormCompoundLabour As New FormCompoundLabour(appDataSourceInputId:=appDataSourceInputId)
        _FormCompoundLabour.Show(Me)
    End Sub

#Region "Bordes Botones"
    Private Sub btnDataSource_MouseEnter(sender As Object, e As EventArgs) Handles btnDataSource.MouseEnter
        btnDataSource.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnDataSource_MouseLeave(sender As Object, e As EventArgs) Handles btnDataSource.MouseLeave
        btnDataSource.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnGuardar_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnCompoundLabour_MouseEnter(sender As Object, e As EventArgs) Handles btnCompoundLabour.MouseEnter
        btnCompoundLabour.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCompoundLabour_MouseLeave(sender As Object, e As EventArgs) Handles btnCompoundLabour.MouseLeave
        btnCompoundLabour.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub _UPTxtRefLabour_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefLabour.Validating
        ValidateRefLabour()
    End Sub


#End Region

End Class

