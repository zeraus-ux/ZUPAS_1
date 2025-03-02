Imports System.Drawing.Printing
Imports Newtonsoft.Json.Linq
Public Class FormAppMoneyChange


    Private WithEvents _UPlbl0 As UPLabel
    Private WithEvents _UPlbl1 As UPLabel
    Private WithEvents _UPlbl2 As UPLabel
    Private WithEvents _UPlbl3 As UPLabel
    Private WithEvents _UPlbl4 As UPLabel
    Private WithEvents _UPlbl5 As UPLabel
    Private WithEvents _UPlbl6 As UPLabel
    Private WithEvents _UPlbl7 As UPLabel
    Private WithEvents _UPlbl8 As UPLabel
    Private WithEvents _UPlbl9 As UPLabel
    Private WithEvents _UPlbl10 As UPLabel
    Private WithEvents _UPlbl11 As UPLabel
    Private WithEvents _UPlbl12 As UPLabel

    Private WithEvents _UPlbl13 As UPLabel
    Private WithEvents _UPlbl14 As UPLabel
    Private WithEvents _UPlbl15 As UPLabel

    Private WithEvents _UPTxtBUSDDolarEstadounidense As UPTextBoxNumerico
    Private WithEvents _UPTxtBVESBolivarVenezolano As UPTextBoxNumerico
    Private WithEvents _UPTxtBARSPesoArgentino As UPTextBoxNumerico
    Private WithEvents _UPTxtBMXNPesoMexicano As UPTextBoxNumerico
    Private WithEvents _UPTxtBCOPPesoColombiano As UPTextBoxNumerico
    Private WithEvents _UPTxtBEUREuro As UPTextBoxNumerico
    Private WithEvents _UPTxtBBLRRealBrasilero As UPTextBoxNumerico
    Private WithEvents _UPTxtBCLPPesoChileno As UPTextBoxNumerico
    Private WithEvents _UPTxtBPENSolPeruano As UPTextBoxNumerico
    Private WithEvents _UPTxtBUYUPesoUruguayo As UPTextBoxNumerico
    Private WithEvents _UPTxtBDOPPesoDominicano As UPTextBoxNumerico
    Private WithEvents _UPTxtBCNYYuanRenminbiChino As UPTextBoxNumerico

    Private WithEvents _UPTxtBUSDDolarEstadounidense1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBVESBolivarVenezolano1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBARSPesoArgentino1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBMXNPesoMexicano1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBCOPPesoColombiano1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBEUREuro1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBBLRRealBrasilero1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBCLPPesoChileno1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBPENSolPeruano1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBUYUPesoUruguayo1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBDOPPesoDominicano1 As UPTextBoxNumerico
    Private WithEvents _UPTxtBCNYYuanRenminbiChino1 As UPTextBoxNumerico

    Private WithEvents _UPDateTimePicker As UPDateTimePicker
    Private WithEvents _UPDateTimePicker2 As UPDateTimePicker

    Private _IsGuardando As Boolean = False


    Public Sub New()

        InitializeComponent()
        Me.Text = "Tasas de cambio divisas disponibles"
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Etiquetas: lbl
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl1 = New UPLabel($"USD/{ProjectSymbolMoneyType} - Dólar estadounidense")
        _UPlbl2 = New UPLabel($"VES/{ProjectSymbolMoneyType} - Bolívar venezolano")
        _UPlbl3 = New UPLabel($"ARS/{ProjectSymbolMoneyType} - Peso argentino")
        _UPlbl4 = New UPLabel($"MXN/{ProjectSymbolMoneyType} - Peso mexicano")
        _UPlbl5 = New UPLabel($"COP/{ProjectSymbolMoneyType} - Peso colombiano")
        _UPlbl6 = New UPLabel($"EUR/{ProjectSymbolMoneyType} - Euro")
        _UPlbl7 = New UPLabel($"BLR/{ProjectSymbolMoneyType} - Real brasilero")
        _UPlbl8 = New UPLabel($"CLP/{ProjectSymbolMoneyType} - Peso chileno")
        _UPlbl9 = New UPLabel($"PEN/{ProjectSymbolMoneyType} - Sol peruano")
        _UPlbl10 = New UPLabel($"UYU/{ProjectSymbolMoneyType} - Peso uruguayo")
        _UPlbl11 = New UPLabel($"DOP/{ProjectSymbolMoneyType} - Peso dominicano")
        _UPlbl12 = New UPLabel($"CNY/{ProjectSymbolMoneyType} - Yuan renminbi chino")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Configuracion Etiquetas Encabezado
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPlbl0 = New UPLabel("D I V I S A S  D I S P O N I B L E S")
        _UPlbl0.SetFortmatEtiquetaInsumo()
        _UPlbl0.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)

        _UPlbl13 = New UPLabel("Importe Actual")
        _UPlbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        _UPlbl14 = New UPLabel("Nuevo Importe")
        _UPlbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        _UPlbl15 = New UPLabel("Fecha de última actualización")
        _UPlbl15.Margin = New System.Windows.Forms.Padding(4, 15, 4, 4)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Cajas de Texto: txtnumerico
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'NUEVAS TASAS
        _UPTxtBARSPesoArgentino = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBBLRRealBrasilero = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBCLPPesoChileno = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBCNYYuanRenminbiChino = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBDOPPesoDominicano = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBEUREuro = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBMXNPesoMexicano = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBPENSolPeruano = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBUSDDolarEstadounidense = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBUYUPesoUruguayo = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBVESBolivarVenezolano = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBCOPPesoColombiano = New UPTextBoxNumerico(1, Double.NaN)

        'TASAS EXISTENTES
        _UPTxtBARSPesoArgentino1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBBLRRealBrasilero1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBCLPPesoChileno1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBCNYYuanRenminbiChino1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBDOPPesoDominicano1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBEUREuro1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBMXNPesoMexicano1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBPENSolPeruano1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBUSDDolarEstadounidense1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBUYUPesoUruguayo1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBVESBolivarVenezolano1 = New UPTextBoxNumerico(1, Double.NaN)
        _UPTxtBCOPPesoColombiano1 = New UPTextBoxNumerico(1, Double.NaN)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDateTimePicker Fecha
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDateTimePicker = New UPDateTimePicker()
        _UPDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 15, 8, 4)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ubicación de Controles
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 

        Me.tlpConversionMoney.Controls.Add(_UPlbl0, 0, 0)

        Me.tlplConversionMoney2.Controls.Add(_UPlbl13, 1, 0)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl14, 2, 0)

        Me.tlplConversionMoney2.Controls.Add(_UPlbl1, 0, 1)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl2, 0, 2)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl3, 0, 3)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl4, 0, 4)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl5, 0, 5)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl6, 0, 6)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl7, 0, 7)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl8, 0, 8)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl9, 0, 9)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl10, 0, 10)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl11, 0, 11)
        Me.tlplConversionMoney2.Controls.Add(_UPlbl12, 0, 12)

        Me.tlplConversionMoney2.Controls.Add(_UPTxtBUSDDolarEstadounidense, 2, 1)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBVESBolivarVenezolano, 2, 2)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBARSPesoArgentino, 2, 3)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBMXNPesoMexicano, 2, 4)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBCOPPesoColombiano, 2, 5)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBEUREuro, 2, 6)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBBLRRealBrasilero, 2, 7)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBCLPPesoChileno, 2, 8)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBPENSolPeruano, 2, 9)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBUYUPesoUruguayo, 2, 10)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBDOPPesoDominicano, 2, 11)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBCNYYuanRenminbiChino, 2, 12)

        Me.tlplConversionMoney2.Controls.Add(_UPTxtBUSDDolarEstadounidense1, 1, 1)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBVESBolivarVenezolano1, 1, 2)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBARSPesoArgentino1, 1, 3)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBMXNPesoMexicano1, 1, 4)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBCOPPesoColombiano1, 1, 5)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBEUREuro1, 1, 6)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBBLRRealBrasilero1, 1, 7)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBCLPPesoChileno1, 1, 8)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBPENSolPeruano1, 1, 9)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBUYUPesoUruguayo1, 1, 10)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBDOPPesoDominicano1, 1, 11)
        Me.tlplConversionMoney2.Controls.Add(_UPTxtBCNYYuanRenminbiChino1, 1, 12)

        Me.tlpfootAppMoneyChange.Controls.Add(_UPlbl15, 0, 0)
        Me.tlpfootAppMoneyChange.Controls.Add(_UPDateTimePicker, 1, 0)

        MonedaEnabled()

    End Sub

    Private Sub MonedaEnabled()

        _UPTxtBUSDDolarEstadounidense.Enabled = True
        _UPTxtBVESBolivarVenezolano.Enabled = True
        _UPTxtBARSPesoArgentino.Enabled = True
        _UPTxtBMXNPesoMexicano.Enabled = True
        _UPTxtBCOPPesoColombiano.Enabled = True
        _UPTxtBEUREuro.Enabled = True
        _UPTxtBBLRRealBrasilero.Enabled = True
        _UPTxtBCLPPesoChileno.Enabled = True
        _UPTxtBPENSolPeruano.Enabled = True
        _UPTxtBUYUPesoUruguayo.Enabled = True
        _UPTxtBDOPPesoDominicano.Enabled = True
        _UPTxtBCNYYuanRenminbiChino.Enabled = True

        _UPTxtBUSDDolarEstadounidense1.Enabled = False
        _UPTxtBVESBolivarVenezolano1.Enabled = False
        _UPTxtBARSPesoArgentino1.Enabled = False
        _UPTxtBMXNPesoMexicano1.Enabled = False
        _UPTxtBCOPPesoColombiano1.Enabled = False
        _UPTxtBEUREuro1.Enabled = False
        _UPTxtBBLRRealBrasilero1.Enabled = False
        _UPTxtBCLPPesoChileno1.Enabled = False
        _UPTxtBPENSolPeruano1.Enabled = False
        _UPTxtBUYUPesoUruguayo1.Enabled = False
        _UPTxtBDOPPesoDominicano1.Enabled = False
        _UPTxtBCNYYuanRenminbiChino1.Enabled = False

        _UPDateTimePicker.Enabled = False

        Dim _UPTxtMoneda As UPTextBoxNumerico = Nothing
        Select Case ProjectMoneyTypeid
            Case 1
                _UPTxtMoneda = _UPTxtBUSDDolarEstadounidense
            Case 2
                _UPTxtMoneda = _UPTxtBVESBolivarVenezolano
            Case 3
                _UPTxtMoneda = _UPTxtBARSPesoArgentino
            Case 4
                _UPTxtMoneda = _UPTxtBMXNPesoMexicano
            Case 6
                _UPTxtMoneda = _UPTxtBCOPPesoColombiano
            Case 7
                _UPTxtMoneda = _UPTxtBEUREuro
            Case 8
                _UPTxtMoneda = _UPTxtBBLRRealBrasilero
            Case 9
                _UPTxtMoneda = _UPTxtBCLPPesoChileno
            Case 10
                _UPTxtMoneda = _UPTxtBPENSolPeruano
            Case 11
                _UPTxtMoneda = _UPTxtBUYUPesoUruguayo
            Case 12
                _UPTxtMoneda = _UPTxtBDOPPesoDominicano
            Case 13
                _UPTxtMoneda = _UPTxtBCNYYuanRenminbiChino
        End Select

        _UPTxtMoneda.Enabled = False
        _UPTxtMoneda.Value = 1
    End Sub

    Public Function Validate1() As Boolean

        Return True

    End Function

    Private Function GetValue(ByVal Value As Double) As JValue
        If Double.IsNaN(Value) Then
            Return Nothing
        Else
            Return New JValue(Value)
        End If
    End Function


    Private Sub LoadTasaMoneyChange()

        Dim _ColumnNames2 As New List(Of String)

        Dim _dicValuesFilter2 As New JObject()

        _dicValuesFilter2("project_id") = ProjectSelectedId

        Dim _SelectMax As String = "dateConvertion"

        Dim _datatable3 As DataTable = GetDataTable("convertion", ColumnNames:=_ColumnNames2,
                                                       dicValuesFilter:=_dicValuesFilter2, SelectMax:=_SelectMax)


        _UPDateTimePicker.Value = _datatable3.Rows(0)("dateConvertion")
        _UPTxtBUSDDolarEstadounidense1.Value = _datatable3.Rows(0)("MonedaUSD")
        _UPTxtBVESBolivarVenezolano1.Value = _datatable3.Rows(0)("MonedaVES")
        _UPTxtBARSPesoArgentino1.Value = _datatable3.Rows(0)("MonedaARS")
        _UPTxtBMXNPesoMexicano1.Value = _datatable3.Rows(0)("MonedaMXN")
        _UPTxtBCOPPesoColombiano1.Value = _datatable3.Rows(0)("MonedaCOP")
        _UPTxtBEUREuro1.Value = _datatable3.Rows(0)("MonedaEUR")
        _UPTxtBBLRRealBrasilero1.Value = _datatable3.Rows(0)("MonedaBLR")
        _UPTxtBCLPPesoChileno1.Value = _datatable3.Rows(0)("MonedaCLP")
        _UPTxtBPENSolPeruano1.Value = _datatable3.Rows(0)("MonedaPEN")
        _UPTxtBUYUPesoUruguayo1.Value = _datatable3.Rows(0)("MonedaUYU")
        _UPTxtBDOPPesoDominicano1.Value = _datatable3.Rows(0)("MonedaDOP")
        _UPTxtBCNYYuanRenminbiChino1.Value = _datatable3.Rows(0)("MonedaCNY")

    End Sub


    Private Sub Saves()

        If Validate1() Then

            _IsGuardando = True

            Dim _DataServices As New JArray()
            Dim _dicValues As New JObject()

            _dicValues("project_id") = ProjectSelectedId
            _dicValues("dateConvertion") = CType(Now, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            _dicValues("MonedaUSD") = GetValue(_UPTxtBUSDDolarEstadounidense.Value)
            _dicValues("MonedaVES") = GetValue(_UPTxtBVESBolivarVenezolano.Value)
            _dicValues("MonedaARS") = GetValue(_UPTxtBARSPesoArgentino.Value)
            _dicValues("MonedaMXN") = GetValue(_UPTxtBMXNPesoMexicano.Value)
            _dicValues("MonedaCOP") = GetValue(_UPTxtBCOPPesoColombiano.Value)
            _dicValues("MonedaEUR") = GetValue(_UPTxtBEUREuro.Value)
            _dicValues("MonedaBLR") = GetValue(_UPTxtBBLRRealBrasilero.Value)
            _dicValues("MonedaCLP") = GetValue(_UPTxtBCLPPesoChileno.Value)
            _dicValues("MonedaPEN") = GetValue(_UPTxtBPENSolPeruano.Value)
            _dicValues("MonedaUYU") = GetValue(_UPTxtBUYUPesoUruguayo.Value)
            _dicValues("MonedaDOP") = GetValue(_UPTxtBDOPPesoDominicano.Value)
            _dicValues("MonedaCNY") = GetValue(_UPTxtBCNYYuanRenminbiChino.Value)

            _DataServices.Add(_dicValues)

            Dim _Idconvertion As Int32 = GetInsertTable("convertion", _DataServices)

            _IsGuardando = False

            If _Idconvertion > 0 Then
                Close()
            End If


        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Saves()
    End Sub

    Private Sub FormAppMoneyChange_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadTasaMoneyChange()
    End Sub
End Class