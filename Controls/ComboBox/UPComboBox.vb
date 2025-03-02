Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports Newtonsoft.Json.Linq

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Public Class UPComboBox

    Private Const SB_VERT As Integer = 1
    Private Const SIF_TRACKPOS As Integer = &H10
    Private Const SIF_RANGE As Integer = &H1
    Private Const SIF_POS As Integer = &H4
    Private Const SIF_PAGE As Integer = &H2
    Private Const SIF_ALL As Integer = SIF_RANGE Or SIF_PAGE Or SIF_POS Or SIF_TRACKPOS
    Private Const SCROLLBAR_WIDTH = 17
    Private Const LISTBOX_YOFFSET = 21

    Public Delegate Sub HoverEventHandler(ByVal sender As Object, ByVal e As HoverEventArgs)

    Public Event Hover As HoverEventHandler

    Public Shadows Event DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)


    Private _x As Integer
    Private _y As Integer
    Private _scroll As Integer
    Private _xFact As Integer = -1
    Private _offset As Integer

    Private _TableName As String
    Private _ColumnNames As List(Of String)
    Private _ImageKey As String
    Private _IsRequerido As Boolean
    Private _dicValuesFilter As JObject

    Public Sub New(Optional vMaxLength As Int32 = -1) '03/08/24

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MyBase.AllowDrop = False
        MyBase.AutoCompleteSource = Windows.Forms.AutoCompleteSource.ListItems
        MyBase.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
        'MyBase.DrawMode = DrawMode.OwnerDrawFixed
        MyBase.FormattingEnabled = True
        MyBase.Cursor = System.Windows.Forms.Cursors.Hand

        MyBase.DropDownWidth = 140
        MyBase.Dock = DockStyle.Fill
        MyBase.DropDownStyle = ComboBoxStyle.DropDownList

        MyBase.Size = New System.Drawing.Size(236, 27)

        MyBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        'MyBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer),
        'CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer))
        MyBase.BackColor = System.Drawing.Color.WhiteSmoke

        MyBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Regular,
                                              System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyBase.ForeColor = System.Drawing.Color.Black
        MyBase.Location = New System.Drawing.Point(109, 218)
        'MyBase.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0) 05/06
        MyBase.Margin = New System.Windows.Forms.Padding(4, 4, 8, 4)

        MyBase.Name = "txtFactor"

        MyBase.TabIndex = 5

        If vMaxLength > 0 Then    '03/08/24
            MyBase.MaxLength = vMaxLength
        End If

    End Sub

    Public Sub New(ByVal TableName As String, ByVal ColumnNames As List(Of String), ByVal ImageKey As String, ByVal IsRequerido As Boolean,
                   Optional dicValuesFilter As JObject = Nothing)
        Me.New()
        'Me.DropDownWidth = 200
        ' This call is required by the designer.
        'InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _TableName = TableName
        _ColumnNames = ColumnNames
        _ImageKey = ImageKey
        _IsRequerido = IsRequerido
        _dicValuesFilter = dicValuesFilter


        Dim _OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String))
        _OptionsList = GetOptionsList(TableName, ColumnNames, ImageKey, IsRequerido, dicValuesFilter)

        Load(_OptionsList)

        If IsRequerido And _OptionsList.Count > 0 Then
            SetSelectedItem(_OptionsList.First.Id)
        End If


        AddHandler CommonFuntion.EvInsertRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvUpdateRecord, AddressOf OnEvReLoadForCrud
        AddHandler CommonFuntion.EvDeleteRecord, AddressOf OnEvReLoadForCrud

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ojo-------------------------------???
        'MyBase.DropDownStyle = ComboBoxStyle.Simple
        'MyBase.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'MyBase.AutoCompleteSource = AutoCompleteSource.ListItems
        'MyBase.DataSource = Items

    End Sub

    Public Sub Load(ByRef OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String)))
        Dim _Id As String
        Dim _Text As String
        Dim _ImageKey As String

        For Each _Option As Object In OptionsList
            _Text = _Option.item1
            _Id = _Option.item2
            _ImageKey = _Option.item3
            Items.Add(New ComboBoxItem(_Id, _Text, _ImageKey))
        Next

    End Sub

    Public Sub ReLoad(ByRef OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String)))
        Items.Clear()
        Load(OptionsList)
    End Sub

    Public Sub ReLoad(Optional dicValuesFilter As JObject = Nothing)

        Dim _OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String))
        _OptionsList = GetOptionsList(_TableName, _ColumnNames, _ImageKey, _IsRequerido, dicValuesFilter)

        ReLoad(_OptionsList)

        If _IsRequerido And _OptionsList.Count > 0 Then
            SetSelectedItem(_OptionsList.First.Id)
        End If

    End Sub

    Public Sub ReLoad()
        Dim _OptionsList As List(Of (Name As String, Id As Integer, ImageKey As String))
        _OptionsList = GetOptionsList(_TableName, _ColumnNames, _ImageKey, _IsRequerido, _dicValuesFilter)
        ReLoad(_OptionsList)
    End Sub

    Private Sub OnEvReLoadForCrud(ByVal TableName As String)
        If _TableName.ToLower() = TableName.ToLower() Then
            ReLoad()
        End If
    End Sub


    Public Function GetItemIndex(ByVal Id As Int32) As Int32

        For Each _ComboBoxItem As ComboBoxItem In Items
            If _ComboBoxItem.Id = Id Then
                Return Items.IndexOf(_ComboBoxItem)
            End If
        Next
        Return -1
    End Function

    Public Function GetItemIndex(ByVal Text As String) As Int32
        For Each _ComboBoxItem As ComboBoxItem In Items
            If _ComboBoxItem.ToString() = Text Then
                Return Items.IndexOf(_ComboBoxItem)
            End If
        Next
        Return 0
    End Function

    Public Function GetComboBoxItem(ByVal Id As Int32) As ComboBoxItem
        For Each _ComboBoxItem As ComboBoxItem In Items
            If _ComboBoxItem.Id = Id Then
                Return _ComboBoxItem
            End If
        Next
        Return Items(0)
    End Function

    Public Function GetItemId(ByVal Index As Integer) As Int32
        If Index > -1 Then                                             '140224
            Dim _ComboBoxItem As ComboBoxItem = Items(Index)
            Return _ComboBoxItem.Id
        Else
            Return -1
        End If
        'Dim _ComboBoxItem As ComboBoxItem = Items(Index)
        'Return _ComboBoxItem.Id
    End Function

    Public Function GetSelectedItemId() As Int32
        Return GetItemId(MyBase.SelectedIndex)
    End Function

    Public Function GetSelectedItemText() As String
        If MyBase.SelectedIndex > -1 Then
            Dim _ComboBoxItem As ComboBoxItem = Items(MyBase.SelectedIndex)
            Return _ComboBoxItem.ToString()
        Else
            Return ""
        End If
    End Function

    Public Function GetItemId(ByVal Text As String) As Int32
        Dim _Index As Int32 = GetItemIndex(Text)                   '140224
        If _Index > -1 Then
            Dim _ComboBoxItem As ComboBoxItem = Items(_Index)
            Return _ComboBoxItem.Id
        Else
            Return -1
        End If
        'Dim _Index As Int32 = GetItemIndex(Text)
        'Dim _ComboBoxItem As ComboBoxItem = Items(_Index)
        'Return _ComboBoxItem.Id
    End Function

    Public Sub SetSelectedItem(ByVal Id As Int32)
        If Id > 0 Then                                           '140224
            MyBase.SelectedIndex = GetItemIndex(Id)
        End If
        'MyBase.SelectedIndex = GetItemIndex(Id) 
    End Sub


    Public Sub SetSelectedFirtItem()
        If Items.Count > 0 Then
            MyBase.SelectedIndex = 0
        End If
    End Sub

#Region "ImageKey"


    '<DllImport("user32.dll", SetLastError:=True)>
    'Private Shared Function GetScrollInfo(ByVal hWnd As IntPtr, ByVal n As Integer, ByRef lpScrollInfo As ScrollInfoStruct) As Integer
    'End Function

    '<StructLayout(LayoutKind.Sequential)>
    'Private Structure ScrollInfoStruct
    '    Public cbSize As Integer
    '    Public fMask As Integer
    '    Public nMin As Integer
    '    Public nMax As Integer
    '    Public nPage As Integer
    '    Public nPos As Integer
    '    Public nTrackPos As Integer
    'End Structure

    'Protected Overridable Sub OnHover(ByVal e As HoverEventArgs)
    '    RaiseEvent Hover(Me, e)
    'End Sub

    'Protected Overrides Sub WndProc(ByRef msg As Message)

    '    If msg.Msg = 32 OrElse msg.Msg = 308 Then
    '        Dim screenIdx As Integer = 0
    '        Dim mousePos As Point = PointToClient(Cursor.Position)

    '        _x = mousePos.X
    '        _y = If(DropDownStyle = ComboBoxStyle.Simple, mousePos.Y - (ItemHeight + 10), mousePos.Y - (ItemHeight + 1))

    '        Dim oldYPos As Integer = _y

    '        While _y >= ItemHeight
    '            _y -= ItemHeight
    '            screenIdx += 1
    '        End While

    '        Dim si As New ScrollInfoStruct()
    '        si.fMask = SIF_ALL
    '        si.cbSize = Marshal.SizeOf(si)
    '        Dim getScrollInfoResult As Integer = GetScrollInfo(msg.LParam, SB_VERT, si)

    '        If getScrollInfoResult > 0 Then
    '            screenIdx += si.nTrackPos
    '            If DropDownStyle = ComboBoxStyle.Simple Then _offset = si.nTrackPos
    '        End If

    '        If DropDownStyle = ComboBoxStyle.Simple Then
    '            screenIdx += _offset
    '            If screenIdx > DropDownHeight / ItemHeight + _offset Then screenIdx = DropDownHeight / ItemHeight + _offset - 1
    '        End If

    '        If Not _x > (Width - SCROLLBAR_WIDTH) _
    '            OrElse _x < 1 _
    '            OrElse oldYPos < 0 _
    '            OrElse oldYPos > (ItemHeight * MaxDropDownItems) _
    '            AndAlso DropDownStyle <> ComboBoxStyle.Simple Then

    '            OnHover(New HoverEventArgs() With {.ItemIndex = If(screenIdx > (Items.Count - 1), Items.Count - 1, screenIdx)})

    '            If _scroll <> si.nPos Then
    '                Cursor.Position = New Point(Cursor.Position.X + _xFact, Cursor.Position.Y)
    '                _xFact = -_xFact
    '            End If
    '        End If
    '        _scroll = si.nPos
    '    End If
    '    MyBase.WndProc(msg)
    'End Sub

    'Private Sub ComboBoxBas_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles MyBase.DrawItem
    '    If e.Index <> -1 Then
    '        Const Padding_Left As Integer = 5
    '        Dim item As ComboBoxItem = CType(Items(e.Index), ComboBoxItem)
    '        e.DrawBackground()

    '        Dim _Image As System.Drawing.Image
    '        _Image = GetImage(item.ImageKey)

    '        ' dibujar la Image con DrawImage
    '        e.Graphics.DrawImage(_Image, New PointF(e.Bounds.Left + Padding_Left, e.Bounds.Top))

    '        ' dibujar el Text del item con el méAll DrawString
    '        'e.Graphics.DrawString(item.ToString, e.Font, New SolidBrush(e.ForeColor),
    '        '                New PointF(Padding_Left + e.Bounds.Left + (ImageList.ImageSize.Width + 1), e.Bounds.Top))

    '        e.Graphics.DrawString(item.ToString, e.Font, New SolidBrush(e.ForeColor),
    '                        New PointF(Padding_Left + e.Bounds.Left + (_Image.Size.Width + 1), e.Bounds.Top))

    '        RaiseEvent DrawItem(Me, e)
    '    End If
    'End Sub



#End Region

    Public Sub SetFortmatComboBox1()

        MyBase.Margin = New Padding(8, 4, 4, 4)
        MyBase.Padding = New Padding(0, 0, 0, 0)
        MyBase.BackColor = Color.WhiteSmoke
        MyBase.Dock = DockStyle.Fill


    End Sub


End Class
