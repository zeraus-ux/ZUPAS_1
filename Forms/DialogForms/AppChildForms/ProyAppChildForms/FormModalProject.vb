Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms.DataGrid
Public Class FormModalProject

    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel
    Private WithEvents _UPCBoxMoney As UPComboBox
    Private WithEvents _UPTxtRefProject As UPTextBox
    Private WithEvents _UPTxtNameProject As UPTextBox
    Private WithEvents _UPTxtDescription As UPTextBox
    Private WithEvents _UPDGViewList As UPDGViewList
    Private WithEvents _UPCBoxPartidaTypeForm As UPComboBox
    Private WithEvents _UPTxtBoxNumerico As UPTextBoxNumerico

    Private _ListRefProject As List(Of String)

    Private WithEvents _MenuItemDuplicarProy As ToolStripMenuItem

    Private _IsEdit As Boolean = False
    Private _NewProjectId As Int32 = -1
    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False '12/7

    Public Sub New()

        InitializeComponent()
        _IsInitialize = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de proyectos para evitar duplicados en el codigo
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _ListRefProject = GetColumnList(Of String)("project", "refProject")
        Dim _ListRefProject1 As New List(Of String)
        For Each _RefProject As String In _ListRefProject
            _ListRefProject1.Add(Trim(_RefProject))
        Next
        _ListRefProject = _ListRefProject1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Proyectos
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDGViewList = New UPDGViewList("project", "refProject", "nameProject", "Código", "Nombre del Proyecto")
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 0, 5, 8)
        _UPDGViewList.Columns("refProject").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '_UPDGViewList.Columns("nameProject").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        _MenuItemDuplicarProy = New ToolStripMenuItem()
        _MenuItemDuplicarProy.Text = "Duplicar..."

        _UPDGViewList.LoadMenuItem(New ToolStripSeparator())
        _UPDGViewList.LoadMenuItem(_MenuItemDuplicarProy)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Código")
        _UPlbl2 = New UPLabel("Nombre")
        _UPlbl3 = New UPLabel("Descripción")
        _UPlbl4 = New UPLabel("Moneda")
        _UPlbl5 = New UPLabel("Matriz APU")
        _UPlbl7 = New UPLabel("N° horas/dia en el proyecto")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  P r o y e c t o s")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)


        _UPlbl6 = New UPLabel("E d i c i ó n  d e  P r o y e c t o s")
        _UPlbl6.SetFortmatEtiquetaInsumo()
        _UPlbl6.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txt
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtRefProject = New UPTextBox(12)
        _UPTxtNameProject = New UPTextBox(100)
        _UPTxtDescription = New UPTextBox(250)


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: 
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames3 As New List(Of String)
        _ColumnNames3.Add("nameMoneyType")
        _UPCBoxMoney = New UPComboBox("moneyType", _ColumnNames3, "Money", True)
        _UPCBoxMoney.Margin = New System.Windows.Forms.Padding(4, 4, 8, 4)

        Dim _ColumNames3 As New List(Of String)
        _ColumNames3.Add("nameMatrixProjectType")
        _UPCBoxPartidaTypeForm = New UPComboBox("MatrixProjectType", _ColumNames3, "Matriz Tipo", True)
        _UPCBoxPartidaTypeForm.Margin = New System.Windows.Forms.Padding(4, 8, 8, 4)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Númerico
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtBoxNumerico = New UPTextBoxNumerico(0, Double.NaN)
        _UPTxtBoxNumerico.Margin = New System.Windows.Forms.Padding(4, 10, 8, 0)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListProject.Controls.Add(_UPlbl0, 0, 0)
        Me.tlpListProject.Controls.Add(_UPDGViewList, 0, 1)

        Me.tlpProject.Controls.Add(_UPlbl6, 0, 0)

        Me.tlpProjectEdit.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpProjectEdit.Controls.Add(_UPlbl2, 0, 1)
        Me.tlpProjectEdit.Controls.Add(_UPlbl3, 0, 2)
        Me.tlpProjectEdit.Controls.Add(_UPlbl4, 0, 3)
        Me.tlpProjectEdit.Controls.Add(_UPlbl5, 0, 4)
        Me.tlpProjectEdit.Controls.Add(_UPlbl7, 0, 5)

        Me.tlpProjectEdit.Controls.Add(_UPTxtRefProject, 1, 0)
        Me.tlpProjectEdit.Controls.Add(_UPTxtNameProject, 1, 1)
        Me.tlpProjectEdit.Controls.Add(_UPTxtDescription, 1, 2)
        Me.tlpProjectEdit.Controls.Add(_UPCBoxMoney, 1, 3)
        Me.tlpProjectEdit.Controls.Add(_UPCBoxPartidaTypeForm, 1, 4)
        Me.tlpProjectEdit.Controls.Add(_UPTxtBoxNumerico, 1, 5)

        btnGuardar.Visible = False

        _IsInitialize = False

        EnableControls(False)

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

    Public ReadOnly Property ProjectId As Int32
        Get
            Return _NewProjectId

        End Get
    End Property

    Public Function ValidateProject() As Boolean
        If Not ValidateStringLen(_UPlbl1.Text, _UPTxtRefProject.Text, 12) Then
            Return False

        ElseIf Not ValidateStringLen(_UPlbl2.Text, _UPTxtNameProject.Text, 100) Then
            Return False

            'ElseIf Not ValidateStringLen(_UPlbl3.Text, _UPTxtDescription.Text, 250) Then
            '  Return False

        End If

        Return True
    End Function

    Private Sub EnableControls(ByVal Enabled As Boolean)
        _UPTxtRefProject.Enabled = Enabled
        _UPTxtNameProject.Enabled = Enabled
        _UPTxtDescription.Enabled = Enabled
        _UPCBoxMoney.Enabled = Enabled
        _UPCBoxPartidaTypeForm.Enabled = Enabled
        _UPTxtBoxNumerico.Enabled = Enabled

    End Sub

    Private Sub LoadProjectSeleccionado()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames As New List(Of String)

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = _id

            Dim _datatable As DataTable = GetDataTable("project", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

            If _datatable.Rows.Count > 0 Then

                _UPTxtRefProject.Text = _datatable.Rows(0)("refProject")
                _UPTxtNameProject.Text = _datatable.Rows(0)("nameProject")
                _UPTxtDescription.Text = _datatable.Rows(0)("descriptionProject")
                _UPCBoxMoney.SetSelectedItem(_datatable.Rows(0)("moneyType_id"))
                _UPCBoxPartidaTypeForm.SetSelectedItem(_datatable.Rows(0)("MatrixProjectType_id"))
                _UPTxtBoxNumerico.Value = _datatable.Rows(0)("horasPerDay")

            Else

                _UPTxtRefProject.Text = ""
                _UPTxtNameProject.Text = ""
                _UPTxtDescription.Text = ""
                _UPCBoxMoney.SetSelectedItem(1)
                _UPCBoxPartidaTypeForm.SetSelectedItem(1)
                _UPTxtBoxNumerico.Value = Nothing

            End If


        End If

    End Sub

    Private Sub _UPDGViewList_EvEditSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvEditSupply

        ' _UPDGViewList.LoadList()
        btnGuardar.Visible = True
        EnableControls(True)
        _IsEdit = True

    End Sub


    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadProjectSeleccionado()
        EnableControls(False)
        If Not _IsGuardando Then
            btnGuardar.Visible = False
        End If

        _IsEdit = False

    End Sub

    Private Sub _UPDGViewList_EvNewSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvNewSupply

        Me._UPTxtRefProject.Text = ""
        Me._UPTxtNameProject.Text = ""
        Me._UPTxtDescription.Text = ""

        If HasSelectedItem Then
            _UPCBoxMoney.SetSelectedItem(selectedId)
            _UPCBoxMoney.SetSelectedItem(_UPCBoxMoney.GetSelectedItemId())
            _UPCBoxPartidaTypeForm.SetSelectedItem(selectedId)
            _UPCBoxPartidaTypeForm.SetSelectedItem(_UPCBoxPartidaTypeForm.GetSelectedItemId)
            _UPTxtBoxNumerico.Value = Nothing
        Else
            _UPCBoxMoney.SetSelectedItem(selectedId)
            _UPCBoxMoney.SetSelectedItem(_UPCBoxMoney.GetSelectedItemId())
            _UPCBoxPartidaTypeForm.SetSelectedItem(selectedId)
            _UPCBoxPartidaTypeForm.SetSelectedItem(_UPCBoxPartidaTypeForm.GetSelectedItemId)
            _UPTxtBoxNumerico.Value = Nothing
        End If

        btnGuardar.Visible = True
        EnableControls(True)

        Me._UPTxtRefProject.Focus()
    End Sub

    Private Sub FormModalProject_Load(sender As Object, e As EventArgs) Handles Me.Load

        splitContProject.SplitterDistance = 340
        splitContProject.Panel1MinSize = 220
        splitContProject.Panel2MinSize = 230

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidateProject() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()
            _dicValues("refProject") = Me._UPTxtRefProject.Text
            _dicValues("nameProject") = Me._UPTxtNameProject.Text
            _dicValues("descriptionProject") = Me._UPTxtDescription.Text

            _dicValues("moneyType_id") = _UPCBoxMoney.GetSelectedItemId()
            _dicValues("MatrixProjectType_id") = _UPCBoxPartidaTypeForm.GetSelectedItemId()
            _dicValues("created") = Now().ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("updated") = Now().ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("horasPerDay") = CType(_UPTxtBoxNumerico.Value, Double)

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("project", _DataServices) IsNot Nothing Then

                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_SelectedIndex)
                    MessageBox.Show("Proyecto modificado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _IsEdit = False
                    EnableControls(False)
                    btnGuardar.Visible = False

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            Else
                Dim _project_Id As Int32 = GetInsertTable("project", _DataServices)

                If _project_Id > 0 Then
                    _UPDGViewList.LoadList()
                    _UPDGViewList.SetSelectedItem(_UPDGViewList.RowCount - 1)
                    _IsEdit = False
                    EnableControls(False)
                    MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnGuardar.Visible = False

                    GetCreateProjectDependences(_project_Id)

                    _NewProjectId = _project_Id
                    Me.DialogResult = DialogResult.OK
                    Me.Close()

                Else
                    MessageBox.Show("ERROR !!! Revisar")
                End If
            End If

            _IsGuardando = False

        End If

    End Sub

    Private Sub _MenuItemDuplicarProy_Click(sender As Object, e As EventArgs) Handles _MenuItemDuplicarProy.Click
        If selectedId > 0 Then
            Dim form1 As New Form()
            If form1.ShowDialog() = DialogResult.OK Or True Then
                Dim refproject As String = "prueba" ' form1.refproject
                Dim nameproject As String = "nameproject"
                Dim descriptionProject As String = "descriptionProject"

                Dim _proyect_Id As Int32 = GetDuplicarProyecto(selectedId, refproject,
                                                          nameproject, descriptionProject)
                If _proyect_Id > 0 Then

                    _UPDGViewList.ReLoadData()
                    _UPDGViewList.SetSelectedItemId(_proyect_Id)
                End If

            End If
        End If

    End Sub

    Private Sub ValidateRefProject()
        Dim _RefProject As String = _UPTxtRefProject.Text.Trim()
        If _ListRefProject.Contains(_RefProject) Then
            MessageBox.Show("El Código existe, favor ingresar un nuevo código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _UPTxtRefProject.Focus()
        End If

    End Sub

    Private Sub _UPTxtRefProject_Validating(sender As Object, e As CancelEventArgs) Handles _UPTxtRefProject.Validating
        ValidateRefProject()
    End Sub
End Class