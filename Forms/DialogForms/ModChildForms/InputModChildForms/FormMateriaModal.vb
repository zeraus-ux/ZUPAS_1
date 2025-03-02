Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class FormMateriaModal
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel

    Private WithEvents _UPTxtRefMaterial As UPTextBox
    Private WithEvents _UPTxtNameMaterial As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox
    Private WithEvents _ChcBoxIsAtomico As UPCheckBox
    Private WithEvents _UPCBoxMaterialType As UPComboBox
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Private _IsEdit As Boolean = False
    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False

    Private _Material_Id As Int32 = -1
    Private _ListRefMaterial As List(Of String) '23/12


#Region "Constructor y Formato"

    Public Sub New(Optional ByVal Material_Id As Int32 = -1, Optional materialTypeId As Int32 = -1,
                   Optional appDataSourceInputId As Int32 = -1)

        InitializeComponent()
        Me.Text = "Materiales"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        _IsInitialize = True

        _Material_Id = Material_Id
        _IsEdit = Material_Id > 0

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Materiales para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefMaterial = GetColumnList(Of String)("material", "refMaterial")
        Dim _ListRefMaterial1 As New List(Of String)
        For Each _RefMaterial As String In _ListRefMaterial
            _ListRefMaterial1.Add(Trim(_RefMaterial))
        Next
        _ListRefMaterial = _ListRefMaterial1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Modo")
        _UPlbl5 = New UPLabel("Tipo de Material")
        _UPlbl7 = New UPLabel("Origen de Datos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl6 = New UPLabel("E d i c i ó n  d e  M a t e r i a l e s")
        _UPlbl6.SetFortmatEtiquetaInsumo()
        _UPlbl6.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefMaterial = New UPTextBox(13)
        _UPTxtNameMaterial = New UPTextBox(155)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Check Box
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ChcBoxIsAtomico = New UPCheckBox("Atómico")
        _ChcBoxIsAtomico.Checked = True
        _ChcBoxIsAtomico.Enabled = False
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInput
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnMaterialSource2 As New List(Of String)
        _ColumnMaterialSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnMaterialSource2, "Fuente de Datos", True)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInput.SetSelectedItem(appDataSourceInputId)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: materialType
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _columnamesMaterialType As New List(Of String)
        _columnamesMaterialType.Add("nameMaterialType")
        _UPCBoxMaterialType = New UPComboBox("materialType", _columnamesMaterialType, "Tipo de Material", True)
        '_UPCBoxMaterialType.Margin = New System.Windows.Forms.Padding(4, 8, 8, 4)
        _UPCBoxMaterialType.BackColor = Color.WhiteSmoke

        If materialTypeId > 0 Then
            _UPCBoxMaterialType.SetSelectedItem(materialTypeId)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpEdicionMaterial.Controls.Add(_UPlbl6, 0, 0)

        Me.tlplEditionMaterial2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlplEditionMaterial2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlplEditionMaterial2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlplEditionMaterial2.Controls.Add(_UPlbl4, 0, 3)
        Me.tlplEditionMaterial2.Controls.Add(_UPlbl7, 0, 4)
        Me.tlplEditionMaterial2.Controls.Add(_UPlbl5, 0, 5)

        Me.tlplEditionMaterial2.Controls.Add(_UPTxtRefMaterial, 1, 0)
        Me.tlplEditionMaterial2.Controls.Add(_UPTxtNameMaterial, 1, 1)
        Me.tlplEditionMaterial2.Controls.Add(_UPTxtDescription, 1, 2)
        Me.tlplEditionMaterial2.Controls.Add(_ChcBoxIsAtomico, 1, 3)
        Me.tlplEditionMaterial2.Controls.Add(_UPCBoxDataSourceInput, 1, 4)
        Me.tlplEditionMaterial2.Controls.Add(_UPCBoxMaterialType, 1, 5)

        EnableControls(True)

        If _IsEdit Then
            LoadMaterialSeleccionado()
        End If

        _IsInitialize = False

    End Sub

    Private Sub EnableControls(ByVal Enabled As Boolean)
        _UPTxtRefMaterial.Enabled = Enabled
        _UPTxtNameMaterial.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled
        _ChcBoxIsAtomico.Enabled = Enabled
        _UPCBoxDataSourceInput.Enabled = Enabled
        _UPCBoxMaterialType.Enabled = Enabled

    End Sub

#End Region

#Region "Cargar Guardar"

    Private Sub LoadMaterialSeleccionado()

        Dim _id As Int32 = _Material_Id

        Dim _ColumnNames As New List(Of String)

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("id") = _id

        Dim _datatable As DataTable = GetDataTable("material", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

        _UPTxtRefMaterial.Text = _datatable.Rows(0)("refMaterial")
        _UPTxtNameMaterial.Text = _datatable.Rows(0)("nameMaterial")
        _UPTxtDescription.Text = _datatable.Rows(0)("descriptionMaterial")

        _ChcBoxIsAtomico.Checked = _datatable.Rows(0)("isAtomic")
        _UPCBoxDataSourceInput.SetSelectedItem(_datatable.Rows(0)("appDataSourceInput_id"))
        _UPCBoxMaterialType.SetSelectedItem(_datatable.Rows(0)("materialType_id"))

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidateMaterial() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("id") = _Material_Id
            _dicValues("refMaterial") = Me._UPTxtRefMaterial.Text
            _dicValues("nameMaterial") = Me._UPTxtNameMaterial.Text
            _dicValues("descriptionMaterial") = Me._UPTxtDescription.Text
            _dicValues("isAtomic") = Me._ChcBoxIsAtomico.Checked
            _dicValues("materialType_id") = _UPCBoxMaterialType.GetSelectedItemId()
            _dicValues("appDataSourceInput_id") = _UPCBoxDataSourceInput.GetSelectedItemId()

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                If GetUpdateTable("material", _DataServices) IsNot Nothing Then

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("material", _DataServices) > 0 Then
                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

    End Sub

    Private Sub FormMateriaModal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            DialogResult = DialogResult.Cancel
        End If
    End Sub


    'Private Sub FormMateriaModal_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Me.FormBorderStyle = FormBorderStyle.FixedDialog

    '    Me.MinimizeBox = False
    '    Me.MaximizeBox = False
    'End Sub

#End Region

#Region "Menu Funciones Metodos"

    Private Function ValidateMaterial() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefMaterial.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameMaterial.Text, 155) Then
            Return False

        End If

        Return True
    End Function

    'Private Sub btnMaterialFilter_Click(sender As Object, e As EventArgs) Handles btnMaterialFilter.Click
    '    _UPDGViewList.FilterList(_UPTxtFilterType.Text)
    'End Sub

    'Private Sub _UPTxtFilterType_TextChanged(sender As Object, e As EventArgs) Handles _UPTxtFilterType.TextChanged
    '    If String.IsNullOrEmpty(_UPTxtFilterType.Text) Then
    '        _UPDGViewList.FilterList(_UPTxtFilterType.Text)
    '    End If
    'End Sub

    'Private Sub _UPTxtFilterType_KeyDown(sender As Object, e As KeyEventArgs) Handles _UPTxtFilterType.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        _UPDGViewList.FilterList(_UPTxtFilterType.Text)
    '    End If


    'End Sub

    'YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY

#End Region

    Private Sub ValidateRefMaterial() '23/12
        Dim _RefMaterial As String = _UPTxtRefMaterial.Text.Trim()
        If _ListRefMaterial.Contains(_RefMaterial) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_UPTxtRefMaterial.Focus()
        End If

    End Sub

    Private Sub _UPTxtRefMaterial_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefMaterial.Validating
        ValidateRefMaterial()
    End Sub

    Private Sub FormMateriaModal_Load(sender As Object, e As EventArgs) Handles Me.Load
        _UPTxtRefMaterial.Focus()
    End Sub
End Class