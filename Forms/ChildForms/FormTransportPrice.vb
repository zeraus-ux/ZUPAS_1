Imports System.ComponentModel
Imports System.Windows.Documents
Imports System.Windows.Forms.ListView
Imports Newtonsoft.Json.Linq
Public Class FormTransportPrice
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel

    Private WithEvents _UPTxtBox As UPTextBox
    Private WithEvents _UPTxtBoxTransportPriceFilter As UPTextBox

    Private WithEvents _UPTxtBoxNumerico1 As UPTextBoxNumerico

    Private WithEvents _UPDGViewList As UPDGViewList

    Private WithEvents _UPCBoxUnit As UPComboBox
    Private WithEvents _UPCBoxUnit2 As UPComboBox
    Private WithEvents _UPCBoxCodigoNombre As UPComboBox

    Private WithEvents _UPDateTimePicker As UPDateTimePicker

    Private _IsEdit As Boolean = False
    Private _IsCargandoConstructor = False
    Private _transportPrice_Id As Int32 = -1

    Public Sub New()

        InitializeComponent()

        _IsCargandoConstructor = True

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Lista de Transporte
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _UPDGViewList = New UPDGViewList("transport", "refTransport", "nameTransport", "Código", "Nombre del Transporte")
        _UPDGViewList.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        _UPDGViewList.MenuItemEditSupplyVisible = False
        _UPDGViewList.CallDeletedActive = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _UPlbl1 = New UPLabel("Nombre")
        _UPlbl2 = New UPLabel("Unidad")
        _UPlbl3 = New UPLabel("Fecha")
        _UPlbl4 = New UPLabel("Precio")
        _UPlbl6 = New UPLabel("Unidad para el precio")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("L i s t a d o  d e  T r a n s p o r t e")
        _UPlbl0.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        _UPlbl0.Font = New System.Drawing.Font("Microsoft Segoe UI", 14.25, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPlbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        _UPlbl0.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)

        _UPlbl7 = New UPLabel("E d i c i ó n  P r e c i o  d e  T r a n s p o r t e")
        _UPlbl7.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        _UPlbl7.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        _UPlbl7.Font = New System.Drawing.Font("Microsoft Segoe UI", 14.25, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPlbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        _UPlbl7.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Código - Nombre
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim _ColumnNames4 As New List(Of String)
        _ColumnNames4.Add("refTransport")
        _ColumnNames4.Add("nameTransport")

        _UPCBoxCodigoNombre = New UPComboBox("transport", _ColumnNames4, "Transport", True)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Unit
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim _ColumnNames3 As New List(Of String)
        _ColumnNames3.Add("nameUnit")

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("unitTransport") = True

        _UPCBoxUnit = New UPComboBox("unit", _ColumnNames3, "Unidad", True, _dicValuesFilter)
        _UPCBoxUnit.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

        _UPCBoxUnit2 = New UPComboBox("unit", _ColumnNames3, "Unidad", True, _dicValuesFilter)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDateTimePicker Fecha
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _UPDateTimePicker = New UPDateTimePicker()


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Texbox 
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtBoxTransportPriceFilter = New UPTextBox
        _UPTxtBoxTransportPriceFilter.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Númerico
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _UPTxtBoxNumerico1 = New UPTextBoxNumerico(0, Double.NaN)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpListTransport.Controls.Add(_UPlbl0, 0, 0)

        Me.tlpListUnit.Controls.Add(_UPlbl6, 0, 0)
        Me.tlpListUnit.Controls.Add(_UPCBoxUnit, 1, 0)
        Me.tlpTransportLook.Controls.Add(_UPTxtBoxTransportPriceFilter, 0, 0)

        Me.tlpListTransport.Controls.Add(_UPDGViewList, 0, 3)

        Me.tlyPanelEdicion.Controls.Add(_UPlbl1, 0, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl2, 0, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl3, 0, 2)
        Me.tlyPanelEdicion.Controls.Add(_UPlbl4, 0, 3)

        Me.tlyPanelEdicion.Controls.Add(_UPCBoxCodigoNombre, 1, 0)
        Me.tlyPanelEdicion.Controls.Add(_UPCBoxUnit2, 1, 1)
        Me.tlyPanelEdicion.Controls.Add(_UPDateTimePicker, 1, 2)
        Me.tlyPanelEdicion.Controls.Add(_UPTxtBoxNumerico1, 1, 3)

        _IsCargandoConstructor = False
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

        If Not _IsCargandoConstructor Then

            _UPCBoxCodigoNombre.Enabled = Enabled
            _UPCBoxUnit2.Enabled = Enabled
            _UPDateTimePicker.Enabled = Enabled
            _UPTxtBoxNumerico1.Enabled = Enabled

        End If

    End Sub

    Private Sub LoadPriceTransportSelect()

        If HasSelectedItem Then

            Dim _id As Int32 = selectedId

            Dim _ColumnNames2 As New List(Of String)

            Dim _dicValuesFilter2 As New JObject()
            _dicValuesFilter2("transport_id") = selectedId
            _dicValuesFilter2("unit_id") = _UPCBoxUnit.GetSelectedItemId()

            Dim _SelectMax As String = "dateUser"

            Dim _datatable3 As DataTable = GetDataTable("transportPrice", ColumnNames:=_ColumnNames2,
                                                       dicValuesFilter:=_dicValuesFilter2, SelectMax:=_SelectMax)

            If _datatable3.Rows.Count > 0 Then

                _UPCBoxCodigoNombre.SetSelectedItem(_datatable3.Rows(0)("transport_id"))
                _UPCBoxUnit2.SetSelectedItem(_datatable3.Rows(0)("unit_id"))
                _UPDateTimePicker.Value = _datatable3.Rows(0)("dateUser")
                _UPTxtBoxNumerico1.Value = _datatable3.Rows(0)("price")
                _transportPrice_Id = _datatable3.Rows(0)("Id")

            Else
                _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
                _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
                _UPDateTimePicker.Value = Now()
                _UPTxtBoxNumerico1.Value = Nothing
                _transportPrice_Id = -1

            End If

        End If

    End Sub


    Public Function Validate1() As Boolean
        'pendiente
        Return True
    End Function

    Public _IsGuardando As Boolean = False

    Private Sub _UPDGViewList_EvSelectedIndexChanged(sender As Object, e As DataGridViewCellEventArgs) Handles _UPDGViewList.EvSelectedIndexChanged

        LoadPriceTransportSelect()
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

        If HasSelectedItem Then
            _UPCBoxCodigoNombre.SetSelectedItem(selectedId)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing

        Else
            _UPCBoxCodigoNombre.SetSelectedItem(1)
            _UPCBoxUnit2.SetSelectedItem(_UPCBoxUnit.GetSelectedItemId())
            _UPDateTimePicker.Value = Now
            _UPTxtBoxNumerico1.Value = Nothing

        End If

        btnGuardar.Visible = True
        EnableControls(True)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Validate1() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()

            _dicValues("transport_id") = _UPCBoxCodigoNombre.GetSelectedItemId()
            _dicValues("unit_id") = _UPCBoxUnit2.GetSelectedItemId()
            _dicValues("dateUser") = CType(_UPDateTimePicker.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("price") = CType(_UPTxtBoxNumerico1.Value, Double)

            _DataServices.Add(_dicValues)

            If _IsEdit Then

                Dim _SelectedIndex As Int32 = _UPDGViewList.selectedItem.Index
                _dicValues("id") = selectedId

                If GetUpdateTable("transportPrice", _DataServices) IsNot Nothing Then

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
                If GetInsertTable("transportPrice", _DataServices) > 0 Then

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

    Private Sub _UPCBoxUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _UPCBoxUnit.SelectedIndexChanged
        LoadPriceTransportSelect()
    End Sub

    Private Sub _UPDGViewList_EvDeleteSupply(sender As Object, e As EventArgs) Handles _UPDGViewList.EvDeleteSupply

        If selectedId > 0 AndAlso _transportPrice_Id > 0 Then
            GetDelete("transportPrice", _transportPrice_Id)
        End If

    End Sub

    Private Sub FormTransportPrice_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        splitContTransport.SplitterDistance = 440

        splitContTransport.Panel1MinSize = 220
        splitContTransport.Panel2MinSize = 330
    End Sub
End Class