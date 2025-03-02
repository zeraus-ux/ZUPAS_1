Imports System.Globalization
Imports System.Resources
Imports System.Security.Policy
Imports System.Threading
Imports System.Windows.Media.Animation
Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel
Imports Newtonsoft.Json.Linq
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports System.IO

Module CommonFuntion  'funciones que pueden ser llamadas desde cualquier parte de la aplicacion

    Public Function GetNumeration(Of T)(ByVal EnumIndex As Integer) As [Enum]
        For i As Integer = 0 To [Enum].GetNames(GetType(T)).Count - 1
            If CType([Enum].GetValues(GetType(T))(i), Integer) = EnumIndex Then Return [Enum].GetValues(GetType(T))(i)
        Next
        Return [Enum].GetValues(GetType(T))(0)
    End Function

    Public Function Max(ByVal X1 As Double, ByVal X2 As Double) As Double

        Dim list As New List(Of Double)
        list.Add(X1)
        list.Add(X2)

        Return list.Max
    End Function

    Public Function GetNotNulDouble(ByVal Value As Double) As JValue

        If Double.IsNaN(Value) Then
            Return Nothing
        Else
            Return New JValue(Value)
        End If

    End Function

    Public Function GetNotNulJValue(ByVal Value As JValue) As Double

        ' hay q revisar cuando funcione todo

        If Value Is Nothing OrElse Value.Value Is Nothing Then
            Return Double.NaN
        Else
            Return Value.Value
        End If

    End Function

#Region "ChangeUnit"

    Public Event EvUnitChanged(sender As Object, e As EventArgs)


    Public Sub OnEvUnitChanged(sender As Object, e As EventArgs)

        RaiseEvent EvUnitChanged(sender, e)
    End Sub

#End Region

#Region "VariablesGlobales"
    'solo declaraciones publicas

    Public Event EvProjectSeletedChnge(sender As Object, e As EventArgs)
    Public Event EvDisplayReportMoneyCheged(sender As Object, e As EventArgs)

    Private _FormMain As FormUpaz
    Private _ProjectMoneyTypeid As Int32 = -1
    Private _ProjectSymbolMoneyType As String = Nothing

    Public Sub Inicializar(ByRef vFormMain As FormUpaz)
        _FormMain = vFormMain

    End Sub

    Public ReadOnly Property UserName As String
        Get
            Return _FormMain.UserName
        End Get
    End Property

    Public ReadOnly Property UPImagenList As ImageList
        Get
            Return _FormMain.UPImagenList
        End Get
    End Property

    Public ReadOnly Property ProjectSelectedId As Int32
        Get
            Return _FormMain.ProjectSelectedId
        End Get
    End Property

    Public ReadOnly Property ProjectMoneyTypeid As Int32
        Get
            If _ProjectMoneyTypeid = -1 Then
                _ProjectMoneyTypeid = GetProjectMoneyTypeid(ProjectSelectedId)
            End If
            Return _ProjectMoneyTypeid
        End Get
    End Property

    Public ReadOnly Property ProjectSymbolMoneyType As String
        Get
            If _ProjectSymbolMoneyType Is Nothing Then
                _ProjectSymbolMoneyType = GetsymbolMoneyType(ProjectMoneyTypeid)
            End If
            Return _ProjectSymbolMoneyType
        End Get
    End Property

    Public ReadOnly Property DisplayReportMoneyTypeid As Int32
        Get
            Return _FormMain.DisplayReportMoneyTypeid
        End Get
    End Property

    Public ReadOnly Property DisplayReportSymbolMoney As String
        Get
            Return _FormMain.DisplayReportSymbolMoney
        End Get
    End Property

    Public ReadOnly Property PartidaTypeForm As EnumPartidaTypeForm
        Get
            Return _FormMain.PartidaTypeForm
        End Get
    End Property

    Public ReadOnly Property IsPartidaARG As Boolean
        Get
            Return _FormMain.IsPartidaARG
        End Get
    End Property

    Public ReadOnly Property IdMatrixProjectType As Int32
        Get
            Return _FormMain.IdMatrixProjectType
        End Get
    End Property

    Public ReadOnly Property ProjectHorasPerDay As Double
        Get
            Return _FormMain.ProjectHorasPerDay

        End Get
    End Property

    Public Function GetImage(ByVal ImageKey As String) As System.Drawing.Image
        Return _FormMain.GetImage(ImageKey)

    End Function

    Public Function GetIcon(ByVal ImageKey As String) As System.Drawing.Icon
        Return _FormMain.GetIcon(ImageKey)
    End Function

    Public Sub OnRaiseEvProjectSeletedChnge(sender As Object, e As EventArgs) 'on se llama de forma privada una sola vez
        _ProjectMoneyTypeid = -1
        _ProjectSymbolMoneyType = Nothing
        RaiseEvent EvProjectSeletedChnge(sender, e) 'lanza el evento  e==> variable de argumento
        GC.Collect()
    End Sub

    Public Sub OnRaiseEvDisplayReportMoneyCheged(sender As Object, e As EventArgs)

        RaiseEvent EvDisplayReportMoneyCheged(sender, e)
    End Sub

    Public Sub FormInicio()
        _FormMain.FormInicio()
    End Sub

    Public Sub ProjectOpen()
        _FormMain.ProjectOpen()
    End Sub

#End Region

#Region "ManejoDeTexto"
    'solo para manejo de texto
    Private _ConstLenText As Int32 = 100

    Function GetIndentedText(ByVal Text As String, Optional separador As String = vbCrLf, Optional WithTab As Boolean = True) As String

        If Text IsNot Nothing Then
            Dim _IndentedText As String = ""
            Dim _Position As Integer = 1
            Dim _Text As String
            Dim _Length As Integer

            _Text = Text.Trim()
            _Text = _Text.Replace(vbCrLf, " ")
            _Text = _Text.Replace("  ", " ")
            _Text = _Text.Replace("  ", " ")
            _Text = _Text.Replace("  ", " ")

            _Length = _Text.Length

            While _Position <= _Length

                If _Position + _ConstLenText - 1 > _Length Then

                    If _Position = 1 Then
                        _IndentedText &= _Text.Substring(_Position - 1).Trim()
                    Else
                        If WithTab Then
                            _IndentedText &= vbTab & _Text.Substring(_Position - 1).Trim()
                        Else
                            _IndentedText &= _Text.Substring(_Position - 1).Trim()
                        End If

                    End If
                    _Position = _Length + 1
                Else
                    Dim ultimoEspacio As Integer = _Text.LastIndexOf(" ", _Position + _ConstLenText - 2)
                    If ultimoEspacio <> -1 Then
                        If _Position = 1 Then
                            _IndentedText &= _Text.Substring(_Position - 1, ultimoEspacio - _Position + 1).Trim() & separador
                        Else
                            If WithTab Then
                                _IndentedText &= vbTab & _Text.Substring(_Position - 1, ultimoEspacio - _Position + 1).Trim() & separador
                            Else
                                _IndentedText &= _Text.Substring(_Position - 1, ultimoEspacio - _Position + 1).Trim() & separador
                            End If

                        End If

                        _Position = ultimoEspacio + 1
                    Else
                        If _Position = 1 Then
                            _IndentedText &= _Text.Substring(_Position - 1, _ConstLenText).Trim() & separador

                        Else
                            If WithTab Then
                                _IndentedText &= vbTab & _Text.Substring(_Position - 1, _ConstLenText).Trim() & separador
                            Else
                                _IndentedText &= _Text.Substring(_Position - 1, _ConstLenText).Trim() & separador
                            End If

                        End If

                        _Position += _ConstLenText
                    End If
                End If
            End While
            Return _IndentedText

        Else
            Stop
            Return ""

        End If
    End Function

#End Region

#Region "CRUD Table"
    'select e insert
#Region "SELECT"

    'convierte el string de python  en type de visual 
    Public Function GetColumnType(ByVal StrType As String) As Type

        Select Case StrType
            Case "int"
                Return GetType(Int32)

            Case "str"
                Return GetType(String)

            Case "Decimal"
                Return GetType(Double)

            Case "datetime"
                Return GetType(DateTime)

            Case "float", "Money"
                Return GetType(Double)

            Case "bool"
                Return GetType(Boolean)

            Case Else
                Stop

        End Select


    End Function

    Public Function NotNull(ByVal Value As Object, vType As Type) As Object

        If Value Is Nothing OrElse Value.Type = JTokenType.Null Then
            Select Case vType
                Case GetType(Int32)
                    Return -1

                Case GetType(String)
                    Return ""

                Case GetType(Double)
                    Return Double.NaN

                Case GetType(DateTime)
                    Return Now()

                Case GetType(Boolean)
                    Return False

                Case Else
                    Stop
                    Return Value
            End Select
        Else
            Select Case vType
                Case GetType(DateTime)
                    Dim format As String = "ddd, dd MMM yyyy HH:mm:ss 'GMT'"
                    Dim provider As CultureInfo = CultureInfo.InvariantCulture

                    Try
                        Dim result As DateTime = DateTime.ParseExact(Value.ToString(), format, provider, DateTimeStyles.AdjustToUniversal)
                        Return result
                    Catch e As FormatException
                    End Try
                    Return Value
                Case Else
                    Return Value
            End Select
        End If
    End Function

    Public Function GetDataTable(ByVal vJObject As JObject) As DataTable

        If vJObject IsNot Nothing Then

            Dim _DataTable As New DataTable()

            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~----------------------------
            ' Craete Columns 
            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~----------------------------


            Dim _ColumnNames As JArray = vJObject("Data")("ColumnNames")
            Dim _ColumnTypes As JObject = vJObject("Data")("ColumnTypes")
            Dim _DataService As JArray = vJObject("Data")("DataServices")

            Dim _dicColumnTypes As New Dictionary(Of String, Type)
            For Each _ColumnName As String In _ColumnNames
                Dim _Type As Type = GetColumnType(_ColumnTypes(_ColumnName))  ' Almaceno los tipos en un diccionario
                _dicColumnTypes.Add(_ColumnName, _Type)
                _DataTable.Columns.Add(_ColumnName, _Type)
            Next


            For Each _dicValues As JObject In _DataService
                Dim row As DataRow = _DataTable.NewRow()
                For Each _ColumnName As String In _ColumnNames
                    row(_ColumnName) = NotNull(_dicValues(_ColumnName), _dicColumnTypes(_ColumnName)) ' Valido si es nothing/ null y retorno  un valor valido
                Next
                _DataTable.Rows.Add(row)
            Next

            Return _DataTable
        Else
            Return Nothing
        End If

    End Function

    Public Function GetDataTable(ByVal URl As String) As DataTable

        Dim _JObject As JObject = GetSJson(URl)
        Return GetDataTable(_JObject)

    End Function

    Public Function GetDataTable(ByVal URl As String, ByVal SJsonValues As JObject) As DataTable

        Dim _JObject As JObject = GetSJson(URl, SJsonValues)

        Return GetDataTable(_JObject)
    End Function

    Public Function GetDataTable(ByVal URl As String, ByVal TableName As String, Optional ByVal ColumnNames As List(Of String) = Nothing,
                                 Optional dicValuesFilter As JObject = Nothing, Optional IsDistinct As Boolean = False,
                                 Optional SelectMax As String = Nothing) As DataTable

        Dim _SJsonValues As New JObject()
        _SJsonValues("TableName") = TableName
        _SJsonValues("ColumnNames") = New JArray(ColumnNames)
        _SJsonValues("dicValuesFilter") = dicValuesFilter
        _SJsonValues("IsDistinct") = IsDistinct

        If SelectMax IsNot Nothing Then
            _SJsonValues("SelectMax") = SelectMax
        End If


        Return GetDataTable(URl, _SJsonValues)
    End Function

    Public Function GetDataTable(ByVal TableName As String, ByVal ColumnNames As List(Of String),
                                 Optional dicValuesFilter As JObject = Nothing, Optional IsDistinct As Boolean = False,
                                 Optional SelectMax As String = Nothing) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/DataService", My.Settings.URLBase)

        Return GetDataTable(_URl, TableName, ColumnNames, dicValuesFilter, IsDistinct, SelectMax)
    End Function

    Public Function GetOptionsList(ByVal TableName As String, ByVal ColumnNames As List(Of String), ByVal ImageKey As String, ByVal IsRequerido As Boolean,
                                   Optional dicValuesFilter As JObject = Nothing) As List(Of (Name As String, Id As Integer, ImageKey As String))

        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add("id")
        For Each _ColumnName In ColumnNames
            _ColumnNames.Add(_ColumnName)
        Next

        Dim _DataTable As DataTable = GetDataTable(TableName, _ColumnNames, dicValuesFilter, True)

        Dim _OptionsList As New List(Of (Name As String, Id As Integer, ImageKey As String))

        If Not IsRequerido Then
            _OptionsList.Add(("----", -1, ImageKey))
        End If


        Dim _Name As String
        Dim _Id As Integer
        If _DataTable IsNot Nothing Then
            For Each row As DataRow In _DataTable.Rows
                Dim _LisNames As New List(Of String)

                For Each _ColumnName In ColumnNames
                    _LisNames.Add(row(_ColumnName))
                Next
                _Name = String.Join(" | ", _LisNames)
                _Id = row("Id")

                _OptionsList.Add((_Name, _Id, ImageKey))
            Next
        End If

        Return _OptionsList
    End Function

    Public Function GetIdMatrixProjectType() As Int32

        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add("MatrixProjectType_id")

        Dim _dicValuesFilter As New JObject()

        _dicValuesFilter("id") = ProjectSelectedId

        Dim _DataTable As DataTable = GetDataTable("project", _ColumnNames, _dicValuesFilter, True)

        If _DataTable IsNot Nothing AndAlso _DataTable.Rows.Count > 0 Then
            Dim _IdMatrixProjectType As Int32 = _DataTable.Rows(0).Item("MatrixProjectType_id")
            Return _IdMatrixProjectType
        Else
            Return -1
        End If

    End Function

    Public Function GetProjectHorasPerDay() As Double

        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add("horasPerDay")

        Dim _dicValuesFilter As New JObject()

        _dicValuesFilter("id") = ProjectSelectedId

        Dim _DataTable As DataTable = GetDataTable("project", _ColumnNames, _dicValuesFilter, True)

        If _DataTable IsNot Nothing AndAlso _DataTable.Rows.Count > 0 Then
            Dim _horasPerDay As Double = _DataTable.Rows(0).Item("horasPerDay")

            If Double.IsNaN(_horasPerDay) Then
                Return 8
            Else
                Return _horasPerDay
            End If

        Else
            Return 8
        End If

    End Function

    Public Function GetDataValue(ByVal TableName As String, ByVal ColumnName As String, ByVal IdTable As Int32) As Object
        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add(ColumnName)

        Dim _dicValuesFilter As New JObject()
        _dicValuesFilter("id") = IdTable

        Dim _DataTable As DataTable = GetDataTable(TableName, _ColumnNames, _dicValuesFilter, True)

        If _DataTable IsNot Nothing Then
            Return _DataTable.Rows(0)(ColumnName)
        Else
            Return Nothing
        End If

    End Function


    Public Function GetColumnList(Of T)(ByVal TableName As String, ByVal ColumnName As String,
                                        Optional dicValuesFilter As JObject = Nothing) As List(Of T)

        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add(ColumnName)

        Dim _DataTable As DataTable = GetDataTable(TableName, _ColumnNames, dicValuesFilter, True)

        Dim _OptionsList As New List(Of T)

        If _DataTable IsNot Nothing Then
            For Each row As DataRow In _DataTable.Rows
                _OptionsList.Add(row(ColumnName))
            Next
        End If

        Return _OptionsList
    End Function


#End Region

#Region "ProcedimientosAlmacenados"

    Public Function GetCreatePartidaCost(ByVal partida_id As Int32) As JObject

        Dim _URl As String = String.Format("{0}/UPAZ/CreatePartidaCost", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("project_Id") = ProjectSelectedId

        Dim _JObject As JObject = GetSJson(_URl, _SJsonValues)

        Return _JObject

    End Function

    Public Function GetCreateProjectDependences(ByVal project_Id As Int32) As JObject

        Dim _URl As String = String.Format("{0}/UPAZ/CreateProjectDependences", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = project_Id

        Dim _JObject As JObject = GetSJson(_URl, _SJsonValues)

        Return _JObject

    End Function

    Public Function GetReportDataPartida(ByVal partida_id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ReportDataPartida", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetReportPartidaMaterial(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                             ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ReportPartidaMaterial", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetReportPartidaEquitpment(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                               ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ReportPartidaEquitpment", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetReportPartidaLabour(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                           ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ReportPartidaLabour", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetPartidaTotalMateriales(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                              ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/PartidaTotalMateriales", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetPartidaTotalLabour(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                          ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/PartidaTotalLabour", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetPartidaTotalEquipment(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                             ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/PartidaTotalEquipment", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetProjectCost(ByVal project_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ProjectCost", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = project_Id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetprojectCostValue(ByVal project_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ProjectCostValue", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = project_Id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetNewObraCostValue(ByVal project_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/NewObraCostValue", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = project_Id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetNewPartidaCostValue(ByVal project_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/NewpartidaCostValue", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = project_Id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetPartidaCosts(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                    ByVal moneyType_Id As Int32,
                                    Optional ByVal obra_id As Int32 = -1) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/PartidaCosts", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        If obra_id > 0 Then
            _SJsonValues("obra_id") = obra_id
        End If

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetPartidaEquipmentArg(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                                ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ParidaEquitmentArg", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetPartidaEquipmentTotalArg(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                                ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ParidaEquitmentTotalArg", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetPartidaCostsEquitmentTbArg(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                             ByVal moneyType_Id As Int32,
                                             Optional ByVal obra_id As Int32 = -1) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/PartidaCostsEquitmentTbArg", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        If obra_id > 0 Then
            _SJsonValues("obra_id") = obra_id
        Else
            _SJsonValues("obra_id") = Nothing
        End If

        Return GetDataTable(_URl, _SJsonValues)


    End Function

    Public Function GetPartidaCostsEquitmentTotalArg(ByVal partida_id As Int32, ByVal ReferenceDate As DateTime,
                                             ByVal moneyType_Id As Int32,
                                             Optional ByVal obra_id As Int32 = -1) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/PartidaCostsEquitmentTotalArg", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("partida_id") = partida_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("project_Id") = ProjectSelectedId

        If obra_id > 0 Then
            _SJsonValues("obra_id") = obra_id
        Else
            _SJsonValues("obra_id") = Nothing
        End If

        Return GetDataTable(_URl, _SJsonValues)


    End Function


    Public Function GetPresupuesto(ByVal obra_id As Int32, ByVal ReferenceDate As DateTime,
                                   ByVal moneyType_Id As Int32,
                                   Optional ByVal chapter_id As Int32 = -1,
                                   Optional ByVal obraStage_id As Int32 = -1) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/Presupuesto", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("obra_id") = obra_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id

        If chapter_id > 0 Then
            _SJsonValues("chapter_id") = chapter_id
        End If

        If obraStage_id > 0 Then
            _SJsonValues("obraStage_id") = obraStage_id
        End If

        Dim _DataTable As DataTable = GetDataTable(_URl, _SJsonValues)

        'Test---------------------------------------------------------
        'Dim _Form1 As New Form1(_DataTable)
        '_Form1.ShowDialog()
        '-----------------------------------------------------------

        Return _DataTable

    End Function

    Public Function GetChapterPresupuesto(ByVal obra_id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ChapterPresupuesto", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("obra_id") = obra_id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetStagePresupuesto(ByVal obra_id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/StagePresupuesto", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("obra_id") = obra_id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetTotalPresupuesto(ByVal obra_id As Int32, ByVal ReferenceDate As DateTime,
                                        ByVal moneyType_Id As Int32,
                                        Optional chapter_id As Int32 = -1,
                                        Optional obraStage_id As Int32 = -1) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/TotalPresupuesto", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("obra_id") = obra_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id

        If chapter_id = -1 Then
            _SJsonValues("chapter_id") = Nothing
        Else
            _SJsonValues("chapter_id") = chapter_id
        End If

        If obraStage_id = -1 Then
            _SJsonValues("obraStage_id") = Nothing
        Else
            _SJsonValues("obraStage_id") = obraStage_id
        End If

        Dim _DataTable As DataTable = GetDataTable(_URl, _SJsonValues)

        'Test---------------------------------------------------------
        'Dim _Form1 As New Form1(_DataTable)
        '_Form1.ShowDialog()
        '-----------------------------------------------------------


        Return _DataTable

    End Function

    Public Function GetListChapterPresupuesto(ByVal obra_id As Int32) As List(Of Int32)

        Dim _DataTable As DataTable = GetChapterPresupuesto(obra_id)

        Dim _ListCharter As New List(Of Int32)

        For Each _Row As DataRow In _DataTable.Rows
            _ListCharter.Add(_Row("chapter_id"))
        Next

        Return _ListCharter


    End Function

    Public Function GetListStagePresupuesto(ByVal obra_id As Int32) As List(Of Int32)

        Dim _DataTable As DataTable = GetStagePresupuesto(obra_id)

        Dim _ListCharter As New List(Of Int32)

        For Each _Row As DataRow In _DataTable.Rows
            _ListCharter.Add(_Row("obraStage_id"))
        Next

        Return _ListCharter


    End Function

    Public Function GetMaterialesDeObra(ByVal obra_id As Int32, ByVal ReferenceDate As DateTime,
                                        ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/MaterialesDeObra", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("obra_id") = obra_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id

        Return GetDataTable(_URl, _SJsonValues)


    End Function

    Public Function GetTotalMaterialesDeObra(ByVal obra_id As Int32, ByVal ReferenceDate As DateTime,
                                             ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/TotalMaterialesDeObra", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("obra_id") = obra_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id

        Return GetDataTable(_URl, _SJsonValues)



    End Function

    Public Function GetMaterialPrice(ByVal material_id As Int32, ByVal ReferenceDate As DateTime,
                                      ByVal moneyType_Id As Int32, ByVal unit_id As Int32) As Double

        'Test-----------------
        'Return Nothing
        '---------------------
        Dim _URl As String = String.Format("{0}/UPAZ/PrecioMaterial", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = ProjectSelectedId
        _SJsonValues("material_id") = material_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("unit_id") = unit_id

        Dim _DataTable As DataTable = GetDataTable(_URl, _SJsonValues)
        If _DataTable IsNot Nothing Then
            Return _DataTable.Rows(0)("Price")
        Else
            Return Nothing
        End If

    End Function

    Public Function GetequipmentCostPyOUser(ByVal equipment_id As Int32, ByVal ReferenceDate As DateTime,
                                      ByVal moneyType_Id As Int32, ByVal unit_id As Int32) As Object

        'tEST---------------------
        'Return Nothing prueba del dia 13/02
        '----------------------------
        Dim _URl As String = String.Format("{0}/UPAZ/PrecioEquipment", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = ProjectSelectedId
        _SJsonValues("equipment_id") = equipment_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("unit_id") = unit_id

        Dim _DataTable As DataTable = GetDataTable(_URl, _SJsonValues)
        If _DataTable IsNot Nothing Then
            Return _DataTable.Rows(0)("Price")
        Else
            Return Nothing
        End If

    End Function

    Public Function GetLabourprice(ByVal labour_id As Int32, ByVal ReferenceDate As DateTime,
                                      ByVal moneyType_Id As Int32, ByVal unit_id As Int32) As Object

        Dim _URl As String = String.Format("{0}/UPAZ/PrecioLabour", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = ProjectSelectedId
        _SJsonValues("labour_id") = labour_id
        _SJsonValues("ReferenceDate") = ReferenceDate.ToString("yyyy-MM-dd HH:mm:ss")
        _SJsonValues("moneyType_Id") = moneyType_Id
        _SJsonValues("unit_id") = unit_id

        Dim _DataTable As DataTable = GetDataTable(_URl, _SJsonValues)
        If _DataTable IsNot Nothing Then
            Return _DataTable.Rows(0)("Price")
        Else
            Return Nothing
        End If

    End Function

    Public Function GetListMaterialPrices(ByVal project_Id As Int32, ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ListMaterialPrices", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = ProjectSelectedId
        _SJsonValues("moneyType_Id") = moneyType_Id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetListequipmentCostPyOUsers(ByVal project_Id As Int32, ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ListequipmentCostPyOUsers", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = ProjectSelectedId
        _SJsonValues("moneyType_Id") = moneyType_Id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetListLabourPrices(ByVal project_Id As Int32, ByVal moneyType_Id As Int32) As DataTable

        Dim _URl As String = String.Format("{0}/UPAZ/ListLabourPrices", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = ProjectSelectedId
        _SJsonValues("moneyType_Id") = moneyType_Id

        Return GetDataTable(_URl, _SJsonValues)

    End Function

    Public Function GetDuplicarProyecto(ByVal project_Id As Int32, ByVal refproject As String,
                                         ByVal nameproject As String, ByVal descriptionProject As String) As Int32

        Dim _URl As String = String.Format("{0}/UPAZ/DuplicarProyecto", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("project_Id") = project_Id
        _SJsonValues("refproject") = refproject
        _SJsonValues("nameproject") = nameproject
        _SJsonValues("descriptionProject") = descriptionProject

        Dim _JObject As JObject = GetSJson(_URl, _SJsonValues)

        If _JObject IsNot Nothing Then
            Return _JObject("Data")("DataServices")(0)("project_id")
        Else
            Return -1
        End If

    End Function
#End Region

#Region "ProcedimientosAlamcenadosApp"

    Public Sub APP_RECRECAR_DATA_COST_DEFAULT()

        Dim _URl As String = String.Format("{0}/UPAZ/APP_RECRECAR_DATA_COST_DEFAULT", My.Settings.URLBase)
        GetSJson(_URl)

    End Sub

    Public Sub APP_RECRECAR_DATA_COST_USER()

        Dim _URl As String = String.Format("{0}/UPAZ/APP_RECRECAR_DATA_COST_USER", My.Settings.URLBase)
        GetSJson(_URl)

    End Sub

#End Region

#Region "INSERT / UPDATE / DELETE"

    Public Event EvInsertRecord(ByVal TableName As String)
    Public Event EvUpdateRecord(ByVal TableName As String)
    Public Event EvDeleteRecord(ByVal TableName As String)

    Private Function GetInsertTable(ByVal URL As String, ByVal SJsonValues As JObject) As Int32
        Dim _JObject As JObject = GetSJson(URL, SJsonValues)
        If _JObject Is Nothing Then
            Return -1
        Else
            Return _JObject("Data")(0)("id")
        End If
    End Function

    Private Function GetInsertTable(ByVal SJsonValues As JObject) As Int32
        Dim _URl As String = String.Format("{0}/UPAZ/Insert", My.Settings.URLBase)
        Return GetInsertTable(_URl, SJsonValues)
    End Function

    Public Function GetInsertTable(ByVal TableName As String, ByVal DataServices As JArray) As Int32
        Dim _SJsonValues As New JObject()
        _SJsonValues("TableName") = TableName
        _SJsonValues("DataServices") = DataServices

        Dim _idTableName As Int32 = GetInsertTable(_SJsonValues)

        If _idTableName > 0 Then
            RaiseEvent EvInsertRecord(TableName)
        End If

        Return _idTableName

    End Function

    Public Function GetUpdateTable(ByVal TableName As String, ByVal DataServices As JArray) As JObject

        Dim _URl As String = String.Format("{0}/UPAZ/Update", My.Settings.URLBase)

        Dim _SJsonValues As New JObject()
        _SJsonValues("TableName") = TableName
        _SJsonValues("DataServices") = DataServices

        Dim _JObject As JObject = GetSJson(_URl, _SJsonValues)

        If _JObject IsNot Nothing Then
            RaiseEvent EvUpdateRecord(TableName)
        End If

        Return _JObject

    End Function

    Public Function GetDelete(ByVal TableName As String, ByVal Id As Int32) As Boolean

        If Id > 0 Then

            Dim _SJsonValues As New JObject()
            _SJsonValues("TableName") = TableName
            _SJsonValues("IdTable") = Id

            Dim _URl As String = String.Format("{0}/UPAZ/Delete", My.Settings.URLBase)

            Dim _JObject As JObject = GetSJson(_URl, _SJsonValues)
            If _JObject Is Nothing Then
                Return False
            Else
                RaiseEvent EvDeleteRecord(TableName)
                Return True
            End If
        Else
            Return True
        End If

    End Function

    Public Function GetDeleteTable(ByVal TableName As String, ByVal ListId As List(Of Int32)) As Boolean

        Dim _IsDelete As Boolean = True
        For Each _Id As Int32 In ListId
            If Not GetDelete(TableName, _Id) Then
                _IsDelete = False
            End If
        Next
        Return _IsDelete
    End Function

#End Region

#Region "SAVES"

    Public Function GetDataServices(ByVal vDataTable As DataTable, ByVal IsNewRecord As Boolean) As JArray
        Dim _DataServices As New JArray()
        For Each _DataRow As DataRow In vDataTable.Rows
            Dim _dicValues As New JObject()
            For Each _Column As DataColumn In vDataTable.Columns
                If IsDBNull(_DataRow(_Column.ColumnName)) Then
                    If Not IsNewRecord Then
                        _dicValues(_Column.ColumnName) = Nothing
                    End If
                Else

                    Select Case _Column.DataType
                        Case GetType(Int32)
                            Dim _Objec As Int32 = _DataRow(_Column.ColumnName)
                            _dicValues(_Column.ColumnName) = _Objec

                        Case GetType(String)
                            Dim _Objec As String = _DataRow(_Column.ColumnName)
                            _dicValues(_Column.ColumnName) = _Objec

                        Case GetType(Double)
                            Dim _Objec As Double = _DataRow(_Column.ColumnName)
                            _dicValues(_Column.ColumnName) = _Objec
                        Case Else
                            Dim _ob As Type = _Column.DataType
                            Stop
                    End Select

                End If

            Next
            _DataServices.Add(_dicValues)

        Next
        Return _DataServices
    End Function

    Public Function GetArrayValidated(ByVal ItemArray As Object())

        For i As Int16 = 0 To ItemArray.Length - 1
            If IsDBNull(ItemArray(i)) Then
            ElseIf Double.IsNaN(ItemArray(i)) Then
                ItemArray(i) = DBNull.Value
            ElseIf String.IsNullOrEmpty(ItemArray(i)) Then
                ItemArray(i) = DBNull.Value
            End If
        Next
        Return ItemArray
    End Function

    Public Function Saves(ByVal TableName As String, ByVal vDataTable As DataTable, ByVal ListIdOriginales As List(Of Int32)) As List(Of Int32)

        Dim _ListIdEdit As New List(Of Int32)
        Dim _IsSaves As Boolean = False
        Dim _IsEdit As Boolean = False

        'INSERT / EDIT
        Dim _DataTableInsert As DataTable = vDataTable.Clone()
        Dim _DataTableEdit As DataTable = vDataTable.Clone()
        _DataTableInsert.Rows.Clear()
        _DataTableEdit.Rows.Clear()

        For Each _DataRow As DataRow In vDataTable.Rows
            If IsDBNull(_DataRow("id")) OrElse _DataRow("id") = -1 Then
                Dim drTemp As DataRow = _DataTableInsert.NewRow()

                If Not IsDBNull(_DataRow("id")) AndAlso _DataRow("id") = -1 Then
                    drTemp("id") = DBNull.Value
                End If

                drTemp.ItemArray = GetArrayValidated(_DataRow.ItemArray.Clone())
                _DataTableInsert.Rows.Add(drTemp)
                _IsSaves = True
            Else
                _ListIdEdit.Add(_DataRow("id"))
                Dim drTemp As DataRow = _DataTableEdit.NewRow()
                drTemp.ItemArray = GetArrayValidated(_DataRow.ItemArray.Clone())
                _DataTableEdit.Rows.Add(drTemp)
                _IsEdit = True
            End If
        Next

        If _IsSaves Then
            Dim _DataServices As JArray = GetDataServices(_DataTableInsert, True)
            GetInsertTable(TableName, _DataServices)
        End If

        If _IsEdit Then
            Dim _DataServices1 As JArray = GetDataServices(_DataTableEdit, False)
            GetUpdateTable(TableName, _DataServices1)
        End If

        'DELETE
        Dim _listIdDelete As New List(Of Int32)
        For Each _id As Int32 In ListIdOriginales
            If Not _ListIdEdit.Contains(_id) Then
                _listIdDelete.Add(_id)
            End If
        Next

        GetDeleteTable(TableName, _listIdDelete)

        Return _ListIdEdit

    End Function

#End Region

#End Region

#Region "Otras"

    Public Function GetProjectMoneyTypeid(ByVal ProjectId As Int32) As Int32
        If ProjectId > 0 Then
            Dim _ColumnNames As New List(Of String)
            _ColumnNames.Add("id")
            _ColumnNames.Add("moneyType_id")

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = ProjectId

            Dim _DataTable As DataTable = GetDataTable("project", _ColumnNames, _dicValuesFilter, True)

            Return _DataTable.Rows(0)("moneyType_id")
        Else
            Return -1
        End If
    End Function

    Public Function GetsymbolMoneyType(ByVal MoneyTypeId As Int32) As String
        If MoneyTypeId > 0 Then
            Dim _ColumnNames As New List(Of String)
            _ColumnNames.Add("id")
            _ColumnNames.Add("symbolMoneyType")

            Dim _dicValuesFilter As New JObject()
            _dicValuesFilter("id") = MoneyTypeId

            Dim _DataTable As DataTable = GetDataTable("moneyType", _ColumnNames, _dicValuesFilter, True)

            Return _DataTable.Rows(0)("symbolMoneyType")
        Else
            Return Nothing

        End If
    End Function

#End Region

#Region "Viewers"

    Public Sub ViewPartida(ByVal Partida_Id As Int32)
        Dim _FormFormulacionPartidas As New FormFormulacionPartida()
        _FormFormulacionPartidas.SetViewPartida(Partida_Id)
        _FormFormulacionPartidas.Show()
    End Sub

    Public Sub ViewEquipmentPrice(Optional ByVal IsModal As Boolean = False, Optional VForm As Form = Nothing)
        Dim _FormEquipmentPrice As New FormEquipmentCostPyOUser()
        _FormEquipmentPrice.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        If IsModal Then
            If VForm Is Nothing Then
                _FormEquipmentPrice.ShowDialog(_FormMain)
            Else
                _FormEquipmentPrice.ShowDialog(VForm)
            End If

        Else
            If VForm Is Nothing Then
                _FormEquipmentPrice.Show(_FormMain)
            Else
                _FormEquipmentPrice.Show(VForm)
            End If

        End If

    End Sub

    Public Function ViewAPU(Optional ByVal partida_id As Int32 = -1, Optional DuplicatePartida_id As Int32 = -1,
                            Optional appDataSourceInputId As Int32 = -1, Optional ByVal CharterId As Int32 = -1,
                            Optional VForm As Form = Nothing) As Boolean

        Dim _FormAPU1 As New FormAPU(partida_id, DuplicatePartida_id, appDataSourceInputId, CharterId)

        If VForm Is Nothing Then
            If _FormAPU1.ShowDialog(_FormMain) = DialogResult.OK Then
                Return True
            End If
        Else
            If _FormAPU1.ShowDialog(VForm) = DialogResult.OK Then
                Return True
            End If
        End If

        Return False
    End Function


#End Region

#Region "Validaciones"

    Public Function ValidateStringLen(ByVal VariableName As String, ByVal Text As String, ByVal len As Int16) As Boolean
        Dim _HasError As Boolean = False
        Dim _Error As String = Nothing
        If Text Is Nothing OrElse String.IsNullOrEmpty(Text) Then
            _HasError = True
            _Error = $"{VariableName} no puede ser null"

        ElseIf Text.Count > len Then
            _HasError = True
            _Error = $"{VariableName} tiene longitud mayor a {len}"

        End If

        If _HasError Then
            MessageBox.Show(_Error, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

    Public Function ValidateDoubleIsNA(ByVal VariableName As String, ByVal Value As Double) As Boolean
        Dim _HasError As Boolean = False
        Dim _Error As String = Nothing
        If Double.IsNaN(Value) Then
            _HasError = True
            _Error = $"{VariableName} debe ser introducida"

        End If

        If _HasError Then
            MessageBox.Show(_Error, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

#End Region

#Region "ProgressBarDialog"

    'Public Class ProgBarDialParameters
    '    Public Property Text As String
    '    'Public Property ShowButtom As Boolean

    'End Class

    Public AtomicCounterProgressBar As Integer = 0  'Cancel ProgressBar
    Public AtomicCounterProgressBar1 As Integer = 0 'Active ProgressBar
    Public AtomicCounterProgressBar2 As Integer = 0 'End Proc ProgressBar

    Private _messagesLock As Object = New Object
    Private _ProgressBarLock As Object = New Object

    Private _ProgressBarDialog As ProgressBarDialog

    Private Sub ShowProgressBarDialog(ByVal Text As String)
        _ProgressBarDialog = New ProgressBarDialog(Text)
        _ProgressBarDialog.TopMost = True
        _ProgressBarDialog.ShowDialog()
        Interlocked.Increment(AtomicCounterProgressBar)

    End Sub

    Public Function GetProgressBarDialog(ByVal Text As String) As Object
        Dim _ProgressBarLock1 As Object = Nothing
        SyncLock _messagesLock
            If Interlocked.Read(AtomicCounterProgressBar1) = 0 Then
                'EnableMDIForm(False)

                Interlocked.Increment(AtomicCounterProgressBar1)
                AtomicCounterProgressBar = 0
                AtomicCounterProgressBar2 = 0

                'Test ---------
                'ShowProgressBarDialog(Text)

                Dim thread As New Thread(AddressOf ShowProgressBarDialog)
                thread.Start(Text)

                _ProgressBarLock1 = _ProgressBarLock
            End If
        End SyncLock
        Return _ProgressBarLock1


    End Function

    Public Function GetProgressBarIsCancel()
        Return Interlocked.Read(AtomicCounterProgressBar) > 0
    End Function

    Public Sub EndProgressBarDialog(ByRef ProgressBarLock As Object)

        If ProgressBarLock IsNot Nothing Then
            If ProgressBarLock.Equals(_ProgressBarLock) Then
                If Interlocked.Read(AtomicCounterProgressBar1) > 0 Then
                    Interlocked.Increment(AtomicCounterProgressBar2)
                    While Interlocked.Read(AtomicCounterProgressBar) = 0
                        Thread.Sleep(100)
                    End While
                    Interlocked.Decrement(AtomicCounterProgressBar2)
                    Interlocked.Decrement(AtomicCounterProgressBar1)
                End If
            End If
            'EnableMDIForm(True)
        End If

        'MDIFormFocus()

    End Sub

    Public Sub EndProgressBarDialog()
        If _ProgressBarLock IsNot Nothing Then
            If Interlocked.Read(AtomicCounterProgressBar1) > 0 Then
                Interlocked.Increment(AtomicCounterProgressBar2)
                While Interlocked.Read(AtomicCounterProgressBar) = 0
                    Thread.Sleep(100)
                End While
                Interlocked.Decrement(AtomicCounterProgressBar2)
                Interlocked.Decrement(AtomicCounterProgressBar1)
            End If
            _ProgressBarLock = Nothing
        End If
    End Sub

#End Region

#Region "SavesPDFReport"

    Public Sub GetFile(ByRef ReportViewers As List(Of ReportViewer))


        ' Crear y configurar el SaveFileDialog
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
            saveFileDialog.Title = "Guardar Reporte como PDF"
            saveFileDialog.DefaultExt = "pdf"
            saveFileDialog.AddExtension = True

            ' Mostrar el SaveFileDialog y verificar si el usuario seleccionó una ubicación
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Obtener la ruta del archivo seleccionada por el usuario
                Dim rutaArchivo As String = saveFileDialog.FileName
                Dim folder As String = Path.GetDirectoryName(rutaArchivo)
                'Dim file As String = Path.GetFileName(rutaArchivo)


                'Dim rutaArchivo As String = saveFileDialog.FileName
                'Dim rutaFolder As String = saveFileDialog.f
                ' Exportar el reporte a PDF
                GenerarReporteUnico(ReportViewers, folder, rutaArchivo)
                MessageBox.Show("Reporte guardado exitosamente en: " & rutaArchivo)
            End If
        End Using


    End Sub


    Private Sub GenerarReporteUnico(ByRef ReportViewers As List(Of ReportViewer), ByVal folder As String,
                                    ByVal rutaArchivo As String)

        Dim archivosPDF As New List(Of String)
        Dim nuevoGuid As String = Guid.NewGuid().ToString()

        Dim _Index As Int16 = 1
        For Each _ReportViewer As ReportViewer In ReportViewers
            Dim rutaPDF1 As String = $"{folder}/{nuevoGuid}{_Index}.PDF"
            ExportarReporteAPDF(_ReportViewer, rutaPDF1)
            archivosPDF.Add(rutaPDF1)
        Next


        ' Rutas de los archivos PDF temporales
        'Dim rutaPDF1 As String = "reporte1.pdf"
        'Dim rutaPDF2 As String = "reporte2.pdf"
        '    Dim rutaPDFUnificado As String = "reporteUnificado.pdf"

        ' Exportar los reportes individuales a PDF
        'ExportarReporteAPDF(ReportViewer1, rutaPDF1)
        'ExportarReporteAPDF(ReportViewer2, rutaPDF2)

        ' Combinar los archivos PDF
        'Dim archivosPDF As New List(Of String) From {rutaPDF1, rutaPDF2}
        CombinarPDFs(archivosPDF, rutaArchivo)

        ' Opcional: Eliminar archivos PDF temporales
        For Each archivo In archivosPDF
            System.IO.File.Delete(archivo)
        Next

        'System.IO.File.Delete(rutaPDF2)
    End Sub


    Private Sub ExportarReporteAPDF(reportViewer As ReportViewer, rutaArchivo As String)
        Dim bytes As Byte() = reportViewer.LocalReport.Render("PDF")
        Using fs As New System.IO.FileStream(rutaArchivo, System.IO.FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
        End Using
    End Sub



    Private Sub CombinarPDFs(archivosPDF As List(Of String), archivoSalida As String)
        Dim documentoSalida As New PdfDocument()

        For Each archivo In archivosPDF
            Dim documento As PdfDocument = PdfReader.Open(archivo, PdfDocumentOpenMode.Import)
            For Each pagina As PdfPage In documento.Pages
                documentoSalida.AddPage(pagina)
            Next
        Next

        documentoSalida.Save(archivoSalida)
    End Sub


#End Region

End Module
