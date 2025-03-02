Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class FormEquipmentModal

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel

    Private WithEvents _UPTxtRefEquipment As UPTextBox
    Private WithEvents _UPTxtNameEquipment As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox

    Private WithEvents _ChcBoxIsAtomico As UPCheckBox

    Private WithEvents _UPCBoxEquipmentType As UPComboBox
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Private _IsEdit As Boolean = False
    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False

    Private _Equipment_Id As Int32 = -1
    Private _ListRefEquipment As List(Of String) '23/12


#Region "Constructor y Formato"

    Public Sub New(Optional ByVal Equipment_Id As Int32 = -1, Optional appDataSourceInputId As Int32 = -1,
                   Optional equipmentTypeId As Int32 = -1)

        InitializeComponent()
        Me.Text = "Equipos"
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False

        _IsInitialize = True

        _Equipment_Id = Equipment_Id
        _IsEdit = Equipment_Id > 0

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista Equipos para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefEquipment = GetColumnList(Of String)("equipment", "refEquipment")
        Dim _ListRefEquipment1 As New List(Of String)
        For Each _RefEquipment As String In _ListRefEquipment
            _ListRefEquipment1.Add(Trim(_RefEquipment))
        Next
        _ListRefEquipment = _ListRefEquipment1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Modo")
        _UPlbl5 = New UPLabel("Tipo de Equipo")
        _UPlbl7 = New UPLabel("Origen de Datos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _UPlbl6 = New UPLabel("E d i c i ó n  d e  E q u i p o s")
        _UPlbl6.SetFortmatEtiquetaInsumo()
        _UPlbl6.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefEquipment = New UPTextBox(13)
        _UPTxtNameEquipment = New UPTextBox(155)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Check Box
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ChcBoxIsAtomico = New UPCheckBox("Atómico")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInput
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnEquipmentSource2 As New List(Of String)
        _ColumnEquipmentSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnEquipmentSource2, "Fuente de Datos", True)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInput.SetSelectedItem(appDataSourceInputId)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: equipmentType
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _columnamesEquipmentType As New List(Of String)
        _columnamesEquipmentType.Add("nameEquipmentType")
        _UPCBoxEquipmentType = New UPComboBox("equipmentType", _columnamesEquipmentType, "Tipo de Equipo", True)
        '_UPCBoxMaterialType.Margin = New System.Windows.Forms.Padding(4, 8, 8, 4)
        _UPCBoxEquipmentType.BackColor = Color.WhiteSmoke

        If equipmentTypeId > 0 Then
            _UPCBoxEquipmentType.SetSelectedItem(equipmentTypeId)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpEdicionEquipment.Controls.Add(_UPlbl6, 0, 0)

        Me.tlplEditionEquipment2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlplEditionEquipment2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlplEditionEquipment2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlplEditionEquipment2.Controls.Add(_UPlbl4, 0, 3)
        Me.tlplEditionEquipment2.Controls.Add(_UPlbl7, 0, 4)
        Me.tlplEditionEquipment2.Controls.Add(_UPlbl5, 0, 5)

        Me.tlplEditionEquipment2.Controls.Add(_UPTxtRefEquipment, 1, 0)
        Me.tlplEditionEquipment2.Controls.Add(_UPTxtNameEquipment, 1, 1)
        Me.tlplEditionEquipment2.Controls.Add(_UPTxtDescription, 1, 2)
        Me.tlplEditionEquipment2.Controls.Add(_ChcBoxIsAtomico, 1, 3)
        Me.tlplEditionEquipment2.Controls.Add(_UPCBoxDataSourceInput, 1, 4)
        Me.tlplEditionEquipment2.Controls.Add(_UPCBoxEquipmentType, 1, 5)

        EnableControls(True)

        If _IsEdit Then
            LoadEquipmentSelected()
        End If

        _IsInitialize = False

    End Sub


    Private Sub EnableControls(ByVal Enabled As Boolean)
        _UPTxtRefEquipment.Enabled = Enabled
        _UPTxtNameEquipment.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled
        _ChcBoxIsAtomico.Enabled = Enabled
        _UPCBoxDataSourceInput.Enabled = Enabled
        _UPCBoxEquipmentType.Enabled = Enabled


    End Sub

#End Region

#Region "Cargar Guardar"


    Private Sub LoadEquipmentSelected()

        Dim _id As Int32 = _Equipment_Id

        Dim _ColumnNames As New List(Of String)

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("id") = _id

        Dim _datatable As DataTable = GetDataTable("equipment", ColumnNames:=_ColumnNames,
                                                           dicValuesFilter:=_dicValuesFilter)

        _UPTxtRefEquipment.Text = _datatable.Rows(0)("refEquipment")
        _UPTxtNameEquipment.Text = _datatable.Rows(0)("nameEquipment")
        _UPTxtDescription.Text = _datatable.Rows(0)("descriptionEquipment")

        _ChcBoxIsAtomico.Checked = _datatable.Rows(0)("isAtomic")

        _UPCBoxDataSourceInput.SetSelectedItem(_datatable.Rows(0)("appDataSourceInput_id"))
        _UPCBoxEquipmentType.SetSelectedItem(_datatable.Rows(0)("equipmentType_id"))

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidateEquipment() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("id") = _Equipment_Id
            _dicValues("refEquipment") = Me._UPTxtRefEquipment.Text
            _dicValues("nameEquipment") = Me._UPTxtNameEquipment.Text
            _dicValues("descriptionEquipment") = Me._UPTxtDescription.Text
            _dicValues("isAtomic") = Me._ChcBoxIsAtomico.Checked
            _dicValues("equipmentType_id") = _UPCBoxEquipmentType.GetSelectedItemId()
            _dicValues("appDataSourceInput_id") = _UPCBoxDataSourceInput.GetSelectedItemId()

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                If GetUpdateTable("equipment", _DataServices) IsNot Nothing Then

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("equipment", _DataServices) > 0 Then
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

    Private Sub ValidateRefEquipment() '23/12
        Dim _RefEquipment As String = _UPTxtRefEquipment.Text.Trim()
        If _ListRefEquipment.Contains(_RefEquipment) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_UPTxtRefEquipment.Focus()
        End If

    End Sub

    Private Sub FormEquipmentModal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            DialogResult = DialogResult.Cancel
        End If

    End Sub

    Private Sub FormEquipmentModal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Private Sub _UPTxtRefEquipment_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefEquipment.Validating
        ValidateRefEquipment()
    End Sub

    'Private Sub FormEquipmentModal_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
    '    Me.MinimumSize = New System.Drawing.Size(1000, 600)
    'End Sub

#End Region

#Region "Menu Funciones Metodos"

    Private Function ValidateEquipment() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefEquipment.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameEquipment.Text, 155) Then
            Return False

        End If

        Return True

    End Function

#End Region

End Class

