<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReportPartida
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportPartida))
        Me.btnCostos = New FontAwesome.Sharp.IconButton()
        Me.btnChapter = New FontAwesome.Sharp.IconButton()
        Me.btnReport = New FontAwesome.Sharp.IconButton()
        Me.PanelPartidHeader = New System.Windows.Forms.Panel()
        Me.btnSplit1 = New FontAwesome.Sharp.IconButton()
        Me.SplitContPartida = New System.Windows.Forms.SplitContainer()
        Me.tlpListPartida = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpPartidaLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPartidaFilter = New FontAwesome.Sharp.IconButton()
        Me.PanelPartidHeader.SuspendLayout()
        CType(Me.SplitContPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContPartida.Panel1.SuspendLayout()
        Me.SplitContPartida.SuspendLayout()
        Me.tlpListPartida.SuspendLayout()
        Me.tlpPartidaLook.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCostos
        '
        Me.btnCostos.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCostos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCostos.FlatAppearance.BorderSize = 0
        Me.btnCostos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCostos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCostos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCostos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCostos.IconChar = FontAwesome.Sharp.IconChar.C
        Me.btnCostos.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCostos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCostos.IconSize = 28
        Me.btnCostos.Location = New System.Drawing.Point(116, 2)
        Me.btnCostos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.Size = New System.Drawing.Size(27, 27)
        Me.btnCostos.TabIndex = 13
        Me.btnCostos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCostos.UseVisualStyleBackColor = False
        '
        'btnChapter
        '
        Me.btnChapter.BackColor = System.Drawing.Color.Gainsboro
        Me.btnChapter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnChapter.FlatAppearance.BorderSize = 0
        Me.btnChapter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnChapter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChapter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChapter.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnChapter.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnChapter.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnChapter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnChapter.IconSize = 28
        Me.btnChapter.Location = New System.Drawing.Point(44, 2)
        Me.btnChapter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnChapter.Name = "btnChapter"
        Me.btnChapter.Size = New System.Drawing.Size(27, 27)
        Me.btnChapter.TabIndex = 14
        Me.btnChapter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChapter.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReport.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnReport.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReport.IconSize = 28
        Me.btnReport.Location = New System.Drawing.Point(80, 2)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(27, 27)
        Me.btnReport.TabIndex = 12
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'PanelPartidHeader
        '
        Me.PanelPartidHeader.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelPartidHeader.Controls.Add(Me.btnCostos)
        Me.PanelPartidHeader.Controls.Add(Me.btnChapter)
        Me.PanelPartidHeader.Controls.Add(Me.btnReport)
        Me.PanelPartidHeader.Controls.Add(Me.btnSplit1)
        Me.PanelPartidHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPartidHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelPartidHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPartidHeader.Name = "PanelPartidHeader"
        Me.PanelPartidHeader.Size = New System.Drawing.Size(1134, 30)
        Me.PanelPartidHeader.TabIndex = 3
        '
        'btnSplit1
        '
        Me.btnSplit1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSplit1.FlatAppearance.BorderSize = 0
        Me.btnSplit1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnSplit1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnSplit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSplit1.ForeColor = System.Drawing.Color.Gray
        Me.btnSplit1.IconChar = FontAwesome.Sharp.IconChar.VectorSquare
        Me.btnSplit1.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSplit1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSplit1.IconSize = 28
        Me.btnSplit1.Location = New System.Drawing.Point(8, 2)
        Me.btnSplit1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSplit1.Name = "btnSplit1"
        Me.btnSplit1.Size = New System.Drawing.Size(27, 27)
        Me.btnSplit1.TabIndex = 0
        Me.btnSplit1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSplit1.UseVisualStyleBackColor = True
        '
        'SplitContPartida
        '
        Me.SplitContPartida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContPartida.Location = New System.Drawing.Point(0, 30)
        Me.SplitContPartida.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContPartida.Name = "SplitContPartida"
        '
        'SplitContPartida.Panel1
        '
        Me.SplitContPartida.Panel1.Controls.Add(Me.tlpListPartida)
        Me.SplitContPartida.Size = New System.Drawing.Size(1134, 627)
        Me.SplitContPartida.SplitterDistance = 378
        Me.SplitContPartida.TabIndex = 4
        '
        'tlpListPartida
        '
        Me.tlpListPartida.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListPartida.ColumnCount = 1
        Me.tlpListPartida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListPartida.Controls.Add(Me.tlpPartidaLook, 0, 3)
        Me.tlpListPartida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListPartida.Location = New System.Drawing.Point(0, 0)
        Me.tlpListPartida.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListPartida.Name = "tlpListPartida"
        Me.tlpListPartida.RowCount = 5
        Me.tlpListPartida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListPartida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListPartida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListPartida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListPartida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListPartida.Size = New System.Drawing.Size(378, 627)
        Me.tlpListPartida.TabIndex = 1
        '
        'tlpPartidaLook
        '
        Me.tlpPartidaLook.ColumnCount = 2
        Me.tlpPartidaLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPartidaLook.Controls.Add(Me.btnPartidaFilter, 1, 0)
        Me.tlpPartidaLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPartidaLook.Location = New System.Drawing.Point(0, 100)
        Me.tlpPartidaLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPartidaLook.Name = "tlpPartidaLook"
        Me.tlpPartidaLook.RowCount = 1
        Me.tlpPartidaLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPartidaLook.Size = New System.Drawing.Size(378, 30)
        Me.tlpPartidaLook.TabIndex = 0
        '
        'btnPartidaFilter
        '
        Me.btnPartidaFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPartidaFilter.FlatAppearance.BorderSize = 0
        Me.btnPartidaFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPartidaFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPartidaFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPartidaFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnPartidaFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnPartidaFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPartidaFilter.IconSize = 28
        Me.btnPartidaFilter.Location = New System.Drawing.Point(338, 0)
        Me.btnPartidaFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPartidaFilter.Name = "btnPartidaFilter"
        Me.btnPartidaFilter.Size = New System.Drawing.Size(40, 30)
        Me.btnPartidaFilter.TabIndex = 0
        Me.btnPartidaFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPartidaFilter.UseVisualStyleBackColor = True
        '
        'FormReportPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 657)
        Me.Controls.Add(Me.SplitContPartida)
        Me.Controls.Add(Me.PanelPartidHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "FormReportPartida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormReportPartida"
        Me.PanelPartidHeader.ResumeLayout(False)
        Me.SplitContPartida.Panel1.ResumeLayout(False)
        CType(Me.SplitContPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContPartida.ResumeLayout(False)
        Me.tlpListPartida.ResumeLayout(False)
        Me.tlpPartidaLook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCostos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnChapter As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReport As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelPartidHeader As Panel
    Friend WithEvents btnSplit1 As FontAwesome.Sharp.IconButton
    Friend WithEvents SplitContPartida As SplitContainer
    Friend WithEvents tlpListPartida As TableLayoutPanel
    Friend WithEvents tlpPartidaLook As TableLayoutPanel
    Friend WithEvents btnPartidaFilter As FontAwesome.Sharp.IconButton
End Class
