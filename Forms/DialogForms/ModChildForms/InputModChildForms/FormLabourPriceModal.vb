Imports Newtonsoft.Json.Linq
Public Class FormLabourPriceModal
    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel

    Private WithEvents _UPCBoxCodigoNombre As UPComboBox
    Private WithEvents _UPCBoxUnit As UPComboBox
    Private WithEvents _UPDateTimePicker As UPDateTimePicker
    Private WithEvents _UPTxtBoxNumerico1 As UPTextBoxNumerico

    Private _IsGuardando As Boolean = False
    Private _IsInitialize = False
    Private _ReferenceDate? As DateTime = Nothing

    Private _Labour_Id As Int32 = -1
    Private _Unit_Id As Int32 = -1

    Public Sub New(ByVal Labour_Id As Int32, ByVal Unit_Id As Int32,
                  Optional ByVal ReferenceDate As DateTime = Nothing)

        InitializeComponent()

        Me.Text = "Precio mano de obra"
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False

        _IsInitialize = True  'YYYYYYYYYYYYYY

        _Labour_Id = Labour_Id
        _Unit_Id = Unit_Id
        _ReferenceDate = ReferenceDate

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel("Nombre")
        _UPlbl2 = New UPLabel("Unidad")
        _UPlbl3 = New UPLabel("Fecha")
        _UPlbl4 = New UPLabel($"Precio ({ProjectSymbolMoneyType})")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("N u e v o  d e  P r e c i o  d e  M a n o  d e  O b r a")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Código - Nombre
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNamesMaterial As New List(Of String)
        _ColumnNamesMaterial.Add("refLabour")
        _ColumnNamesMaterial.Add("nameLabour")

        _UPCBoxCodigoNombre = New UPComboBox("labour", _ColumnNamesMaterial, "Mano de Obra", True)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cbox: Unit
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnUnit As New List(Of String)
        _ColumnUnit.Add("symbolUnit")

        Dim _dicValuesFilterUnit As New JObject()
        _dicValuesFilterUnit("unitLabour") = True

        _UPCBoxUnit = New UPComboBox("unit", _ColumnUnit, "Unidad", True, _dicValuesFilterUnit)
        _UPCBoxUnit.BackColor = Color.WhiteSmoke

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDateTimePicker Fecha
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDateTimePicker = New UPDateTimePicker()

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Tbox Númerico
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPTxtBoxNumerico1 = New UPTextBoxNumerico(0, Double.NaN)
        _UPTxtBoxNumerico1.Margin = New System.Windows.Forms.Padding(4, 6, 8, 2)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        Me.tlpEdicionLabourPrice.Controls.Add(_UPlbl0, 0, 0)

        Me.tlpEditionLabourPrice2.Controls.Add(_UPlbl1, 0, 0)
        Me.tlpEditionLabourPrice2.Controls.Add(_UPlbl2, 0, 2)
        Me.tlpEditionLabourPrice2.Controls.Add(_UPlbl3, 0, 3)
        Me.tlpEditionLabourPrice2.Controls.Add(_UPlbl4, 0, 1)

        Me.tlpEditionLabourPrice2.Controls.Add(_UPCBoxCodigoNombre, 1, 0)
        Me.tlpEditionLabourPrice2.Controls.Add(_UPCBoxUnit, 1, 2)
        Me.tlpEditionLabourPrice2.Controls.Add(_UPDateTimePicker, 1, 3)
        Me.tlpEditionLabourPrice2.Controls.Add(_UPTxtBoxNumerico1, 1, 1)

        EnableControls()
        LoadLabourSeleccionado()

        _IsInitialize = False

    End Sub

    Public Function Validate2() As Boolean
        'pendiente
        Return True
    End Function

    Private Sub EnableControls()
        _UPCBoxCodigoNombre.Enabled = False
        _UPCBoxUnit.Enabled = False
        _UPDateTimePicker.Enabled = False

    End Sub

    Private Sub LoadLabourSeleccionado()

        Dim _id As Int32 = _Labour_Id

        Dim _ColumnNames As New List(Of String)

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("id") = _id

        Dim _datatable As DataTable = GetDataTable("labour", ColumnNames:=_ColumnNames,
                                                       dicValuesFilter:=_dicValuesFilter)

        _UPCBoxCodigoNombre.SetSelectedItem(_Labour_Id)
        _UPCBoxUnit.SetSelectedItem(_Unit_Id)
        _UPDateTimePicker.Value = IIf(_ReferenceDate > DateTime.MinValue, _ReferenceDate, Now())
        _UPTxtBoxNumerico1.Value = Nothing

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Validate2() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()

            Dim _dicValues As New JObject()

            _dicValues("labour_id") = _Labour_Id
            _dicValues("unit_id") = _Unit_Id
            _dicValues("dateUser") = CType(_UPDateTimePicker.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("price") = CType(_UPTxtBoxNumerico1.Value, Double)
            _dicValues("project_id") = ProjectSelectedId

            _DataServices.Add(_dicValues)

            If GetInsertTable("labourPrice", _DataServices) > 0 Then
                MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
            Else
                MessageBox.Show("ERROR !!! Revisar")
            End If

            _IsGuardando = False
        End If


    End Sub

    Private Sub FormLabourPriceModal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            DialogResult = DialogResult.Cancel
        Else
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub FormLabourPriceModal_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.MinimumSize = New System.Drawing.Size(1000, 600)
    End Sub

    Private Sub FormLabourPriceModal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        _UPTxtBoxNumerico1.Focus()
    End Sub
End Class