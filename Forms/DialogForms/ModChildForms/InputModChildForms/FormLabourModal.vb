Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class FormLabourModal

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel

    Private WithEvents _UPTxtRefLabour As UPTextBox
    Private WithEvents _UPTxtNameLabour As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox
    Private WithEvents _ChcBoxIsAtomico As UPCheckBox
    Private WithEvents _UPCBoxDataSourceInput As UPComboBox

    Private _IsEdit As Boolean = False
    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False

    Private _Labour_Id As Int32 = -1
    Private _ListRefLabour As List(Of String) '23/12

    Public Sub New(Optional ByVal Labour_Id As Int32 = -1, Optional appDataSourceInputId As Int32 = -1)

        InitializeComponent()
        Me.Text = "Mano de obra"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        _IsInitialize = True

        _Labour_Id = Labour_Id
        _IsEdit = Labour_Id > 0

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
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Modo")
        _UPlbl5 = New UPLabel("Origen de Datos")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl6 = New UPLabel("E d i c i ó n  d e  M a n o  d e  O b r a")
        _UPlbl6.SetFortmatEtiquetaInsumo()
        _UPlbl6.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefLabour = New UPTextBox(13)
        _UPTxtNameLabour = New UPTextBox(155)
        _UPTxtDescription = New UPTextBox(250)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Check Box
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ChcBoxIsAtomico = New UPCheckBox("Atómico")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: DataSourceInput
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnLabourSource2 As New List(Of String)
        _ColumnLabourSource2.Add("nameDataSourceInput")
        _UPCBoxDataSourceInput = New UPComboBox("appDataSourceInput", _ColumnLabourSource2, "Fuente de Datos", True)
        _UPCBoxDataSourceInput.BackColor = Color.WhiteSmoke

        If appDataSourceInputId > 0 Then
            _UPCBoxDataSourceInput.SetSelectedItem(appDataSourceInputId)
        End If


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpEdicionLabour.Controls.Add(_UPlbl6, 0, 0)

        Me.tlplEditionLabour2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlplEditionLabour2.Controls.Add(_UPlbl2, 0, 1)
        Me.tlplEditionLabour2.Controls.Add(_UPlbl3, 0, 2)
        Me.tlplEditionLabour2.Controls.Add(_UPlbl4, 0, 3)
        Me.tlplEditionLabour2.Controls.Add(_UPlbl5, 0, 4)

        Me.tlplEditionLabour2.Controls.Add(_UPTxtRefLabour, 1, 0)
        Me.tlplEditionLabour2.Controls.Add(_UPTxtNameLabour, 1, 1)
        Me.tlplEditionLabour2.Controls.Add(_UPTxtDescription, 1, 2)
        Me.tlplEditionLabour2.Controls.Add(_ChcBoxIsAtomico, 1, 3)
        Me.tlplEditionLabour2.Controls.Add(_UPCBoxDataSourceInput, 1, 4)

        EnableControls(True)

        If _IsEdit Then
            LoadLabourSelected()
        End If

        _IsInitialize = False

    End Sub

    Private Sub EnableControls(ByVal Enabled As Boolean)
        _UPTxtRefLabour.Enabled = Enabled
        _UPTxtNameLabour.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled
        _ChcBoxIsAtomico.Enabled = Enabled
        _UPCBoxDataSourceInput.Enabled = Enabled

    End Sub

    Private Sub LoadLabourSelected()

        Dim _id As Int32 = _Labour_Id

        Dim _ColumnNames As New List(Of String)

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("id") = _id

        Dim _datatable As DataTable = GetDataTable("Labour", ColumnNames:=_ColumnNames,
                                                           dicValuesFilter:=_dicValuesFilter)

        _UPTxtRefLabour.Text = _datatable.Rows(0)("refLabour")
        _UPTxtNameLabour.Text = _datatable.Rows(0)("nameLabour")
        _UPTxtDescription.Text = _datatable.Rows(0)("descriptionLabour")
        _ChcBoxIsAtomico.Checked = _datatable.Rows(0)("isAtomic")
        _UPCBoxDataSourceInput.SetSelectedItem(_datatable.Rows(0)("appDataSourceInput_id"))

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidateLabour() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("id") = _Labour_Id
            _dicValues("refLabour") = Me._UPTxtRefLabour.Text
            _dicValues("nameLabour") = Me._UPTxtNameLabour.Text
            _dicValues("descriptionLabour") = Me._UPTxtDescription.Text
            _dicValues("isAtomic") = Me._ChcBoxIsAtomico.Checked
            _dicValues("appDataSourceInput_id") = _UPCBoxDataSourceInput.GetSelectedItemId()

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                If GetUpdateTable("Labour", _DataServices) IsNot Nothing Then

                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                If GetInsertTable("Labour", _DataServices) > 0 Then
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

    Private Sub ValidateRefLabour() '23/12
        Dim _RefLabour As String = _UPTxtRefLabour.Text.Trim()
        If _ListRefLabour.Contains(_RefLabour) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_UPTxtRefLabour.Focus()
        End If

    End Sub

    Private Sub FormLabourModal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            DialogResult = DialogResult.Cancel
        End If

    End Sub

    Private Sub _UPTxtRefLabour_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefLabour.Validating
        ValidateRefLabour()
    End Sub

    'Private Sub FormLabourModal_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Me.MinimumSize = New System.Drawing.Size(1000, 600)
    'End Sub

    Private Function ValidateLabour() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefLabour.Text, 13) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameLabour.Text, 155) Then
            Return False

        End If

        Return True
    End Function


End Class