Imports System.ComponentModel
Imports System.Windows.Controls

Public Class UPListViewInsumos
    Inherits UPListView

    Private _ColumnName1 As String
    Private _ColumnName2 As String
    Private _ColumnText1 As String
    Private _ColumnText2 As String
    Private _TableNme As String

    Private WithEvents _ContextMenuStrip As ContextMenuStrip
    Private WithEvents _MenuItemNewInsumo As ToolStripMenuItem
    Private WithEvents _MenuItemEditInsumo As ToolStripMenuItem
    Private WithEvents _MenuItemDeleteInsumo As ToolStripMenuItem
    Private WithEvents _MenuItemFilterInsumo As ToolStripMenuItem
    Private WithEvents _MenuItemFilterClear As ToolStripMenuItem

    Public Event EvNewInsumo(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EvEditInsumo(ByVal sender As Object, ByVal e As EventArgs)


    Public Sub New(ByVal TableNme As String, ByVal ColumnName1 As String, ByVal ColumnName2 As String,
                    ByVal ColumnText1 As String, ByVal ColumnText2 As String)
        MyBase.New()
        MyBase.OwnerDraw = True
        MyBase.UseCompatibleStateImageBehavior = False

        _ColumnName1 = ColumnName1
        _ColumnName2 = ColumnName2
        _ColumnText1 = ColumnText1
        _ColumnText2 = ColumnText2
        _TableNme = TableNme

        Dim _Codigo As New ColumnHeader()
        _Codigo.Text = ColumnText1



        Dim _Nombre As New ColumnHeader()
        _Nombre.Text = ColumnText2




        MyBase.Name = "UPListViewInsumos"
        MyBase.View = System.Windows.Forms.View.Details
        MyBase.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {_Codigo, _Nombre})

       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------
        ' ContextMenuStrip
       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------
        _ContextMenuStrip = New ContextMenuStrip()

        _MenuItemNewInsumo = New ToolStripMenuItem()
        _MenuItemNewInsumo.Text = "Nuevo"

        _MenuItemEditInsumo = New ToolStripMenuItem()
        _MenuItemEditInsumo.Text = "Edit"

        _MenuItemDeleteInsumo = New ToolStripMenuItem()
        _MenuItemDeleteInsumo.Text = "Delete"

        _MenuItemFilterInsumo = New ToolStripMenuItem()
        _MenuItemFilterInsumo.Text = "Filtar"

        _MenuItemFilterClear = New ToolStripMenuItem()
        _MenuItemFilterClear.Text = "Filtar Clear"

        _ContextMenuStrip.Items.Add(_MenuItemNewInsumo)
        _ContextMenuStrip.Items.Add(_MenuItemEditInsumo)
        _ContextMenuStrip.Items.Add(_MenuItemDeleteInsumo)
        _ContextMenuStrip.Items.Add(New ToolStripSeparator())
        _ContextMenuStrip.Items.Add(_MenuItemFilterInsumo)
        _ContextMenuStrip.Items.Add(_MenuItemFilterClear)

        Me.ContextMenuStrip = _ContextMenuStrip

    End Sub


    Public Sub LoadListInsumois()

        Items.Clear()

        Dim _ColumnNames As New List(Of String)
        _ColumnNames.Add("id")
        _ColumnNames.Add(_ColumnName1)
        _ColumnNames.Add(_ColumnName2)

        Dim _datatable As DataTable = GetDataTable(_TableNme, ColumnNames:=_ColumnNames)

        For Each row In _datatable.Rows
            Dim _Array As String()
            ReDim _Array(1)
            _Array(0) = row(_ColumnName1).ToString()
            _Array(1) = row(_ColumnName2).ToString()


            Dim _listViewItem As New System.Windows.Forms.ListViewItem(_Array)
            _listViewItem.Tag = row("id")
            Items.Add(_listViewItem)

        Next
        _MenuItemFilterInsumo.Text = "Filter"

    End Sub


    Public Sub FilterList(ByVal Filter As String)

        LoadListInsumois()

        Dim items As ListViewItemCollection = MyBase.Items
        Dim filteredItems() As System.Windows.Forms.ListViewItem = items.Cast(Of System.Windows.Forms.ListViewItem)().Where(Function(x) x.SubItems(0).Text.Contains(Filter)).ToArray()

        Me.Items.Clear()
        MyBase.Items.AddRange(filteredItems)

        _MenuItemFilterInsumo.Text = String.Format("Filerted: {0}", Filter)


    End Sub


    Private Sub _ContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles _ContextMenuStrip.Opening
        _MenuItemEditInsumo.Enabled = SelectedItems IsNot Nothing And SelectedItems.Count > 0

    End Sub


    Private Sub _MenuItemNewInsumo_Click(sender As Object, e As EventArgs) Handles _MenuItemNewInsumo.Click
        RaiseEvent EvNewInsumo(sender, e)

    End Sub

    Private Sub _MenuItemEditInsumo_Click(sender As Object, e As EventArgs) Handles _MenuItemEditInsumo.Click
        RaiseEvent EvEditInsumo(sender, e)

    End Sub

    Private Sub _MenuItemFilterInsumo_Click(sender As Object, e As EventArgs) Handles _MenuItemFilterInsumo.Click

        Dim _Result As String = InputBox("Indicar el filtro", "Filter Materiales", "")
        If Not String.IsNullOrEmpty(_Result) Then
            FilterList(_Result)
        End If

    End Sub



    Private Sub _MenuItemFilterClear_Click(sender As Object, e As EventArgs) Handles _MenuItemFilterClear.Click

        LoadListInsumois()

    End Sub


#Region "REdRAW"

    Private Sub lstvMateriales_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles MyBase.DrawItem
        If e.ItemIndex Mod 2 = 0 Then
            e.Item.BackColor = Color.FromArgb(235, 235, 235)
        Else
            e.Item.BackColor = Color.FromArgb(227, 232, 241)
        End If
        e.DrawBackground()

    End Sub
    Private Sub lstvMateriales_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles MyBase.DrawSubItem

        e.DrawText()

    End Sub

    Private Sub lstvMateriales_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles MyBase.DrawColumnHeader
        'e.DrawDefault = True
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        Dim headerBrush As New SolidBrush(Color.FromArgb(255, 255, 0))
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(232, 228, 227)), e.Bounds)
        Dim headerStringFormat As New StringFormat()
        headerStringFormat.Alignment = StringAlignment.Center
        headerStringFormat.LineAlignment = StringAlignment.Center
        e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, headerStringFormat)


    End Sub

#End Region

End Class
