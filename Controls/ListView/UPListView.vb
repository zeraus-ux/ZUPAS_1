Public Class UPListView

    Private _IsAutoResizeColumns As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        MyBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer))
        MyBase.BorderStyle = System.Windows.Forms.BorderStyle.None
        MyBase.Dock = System.Windows.Forms.DockStyle.Fill
        MyBase.FullRowSelect = True
        MyBase.Font = My.Settings.UPFont
        MyBase.FontHeight = My.Settings.UPFont.Height
        'MyBase.GridLines = True
        MyBase.HideSelection = False
        MyBase.Margin = New System.Windows.Forms.Padding(8, 8, 0, 8)
        MyBase.Name = "UPListView"
        'MyBase.OwnerDraw = True
        'MyBase.Size = New System.Drawing.Size(310, 530)
        'MyBase.TabIndex = 0


    End Sub


    Public Shadows Sub AutoResizeColumns()
        'If Visible And Not _IsAutoResizeColumns Then
        '    _IsAutoResizeColumns = True
        '    If MyBase.Columns.Count = 1 Then
        '        MyBase.Columns(0).Width = Me.Width
        '    Else
        '        If Items.Count > 0 Then
        '            MyBase.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        '        Else
        '            MyBase.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        '        End If


        '    End If
        '    _IsAutoResizeColumns = False
        'End If
    End Sub

End Class
