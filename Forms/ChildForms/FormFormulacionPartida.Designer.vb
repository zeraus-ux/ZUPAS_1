<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFormulacionPartida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFormulacionPartida))
        Me.SplitContainerAPU = New System.Windows.Forms.SplitContainer()
        Me.splitContPartida = New System.Windows.Forms.SplitContainer()
        Me.tlpListPartida = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpPartidaLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPartidaFilter = New FontAwesome.Sharp.IconButton()
        Me.tlpPartidaEdition = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tlpPartidaEdition2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCostos = New FontAwesome.Sharp.IconButton()
        Me.btnReport = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.btnChapter = New FontAwesome.Sharp.IconButton()
        Me.PanelPartidHeader = New System.Windows.Forms.Panel()
        Me.btnSplit1 = New FontAwesome.Sharp.IconButton()
        CType(Me.SplitContainerAPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerAPU.Panel1.SuspendLayout()
        Me.SplitContainerAPU.Panel2.SuspendLayout()
        Me.SplitContainerAPU.SuspendLayout()
        CType(Me.splitContPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContPartida.Panel1.SuspendLayout()
        Me.splitContPartida.Panel2.SuspendLayout()
        Me.splitContPartida.SuspendLayout()
        Me.tlpListPartida.SuspendLayout()
        Me.tlpPartidaLook.SuspendLayout()
        Me.tlpPartidaEdition.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelPartidHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerAPU
        '
        Me.SplitContainerAPU.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerAPU.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainerAPU.Location = New System.Drawing.Point(0, 34)
        Me.SplitContainerAPU.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainerAPU.Name = "SplitContainerAPU"
        '
        'SplitContainerAPU.Panel1
        '
        Me.SplitContainerAPU.Panel1.Controls.Add(Me.splitContPartida)
        '
        'SplitContainerAPU.Panel2
        '
        Me.SplitContainerAPU.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainerAPU.Panel2Collapsed = True
        Me.SplitContainerAPU.Size = New System.Drawing.Size(1134, 624)
        Me.SplitContainerAPU.SplitterDistance = 721
        Me.SplitContainerAPU.TabIndex = 0
        '
        'splitContPartida
        '
        Me.splitContPartida.BackColor = System.Drawing.SystemColors.Control
        Me.splitContPartida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContPartida.Location = New System.Drawing.Point(0, 0)
        Me.splitContPartida.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContPartida.Name = "splitContPartida"
        '
        'splitContPartida.Panel1
        '
        Me.splitContPartida.Panel1.Controls.Add(Me.tlpListPartida)
        '
        'splitContPartida.Panel2
        '
        Me.splitContPartida.Panel2.Controls.Add(Me.tlpPartidaEdition)
        Me.splitContPartida.Size = New System.Drawing.Size(1134, 624)
        Me.splitContPartida.SplitterDistance = 440
        Me.splitContPartida.TabIndex = 2
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
        Me.tlpListPartida.Size = New System.Drawing.Size(440, 624)
        Me.tlpListPartida.TabIndex = 0
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
        Me.tlpPartidaLook.Size = New System.Drawing.Size(440, 30)
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
        Me.btnPartidaFilter.Location = New System.Drawing.Point(400, 0)
        Me.btnPartidaFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPartidaFilter.Name = "btnPartidaFilter"
        Me.btnPartidaFilter.Size = New System.Drawing.Size(40, 30)
        Me.btnPartidaFilter.TabIndex = 0
        Me.btnPartidaFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPartidaFilter.UseVisualStyleBackColor = True
        '
        'tlpPartidaEdition
        '
        Me.tlpPartidaEdition.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpPartidaEdition.ColumnCount = 1
        Me.tlpPartidaEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaEdition.Controls.Add(Me.Panel3, 0, 2)
        Me.tlpPartidaEdition.Controls.Add(Me.tlpPartidaEdition2, 0, 1)
        Me.tlpPartidaEdition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPartidaEdition.Location = New System.Drawing.Point(0, 0)
        Me.tlpPartidaEdition.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPartidaEdition.Name = "tlpPartidaEdition"
        Me.tlpPartidaEdition.RowCount = 3
        Me.tlpPartidaEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPartidaEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.tlpPartidaEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaEdition.Size = New System.Drawing.Size(690, 624)
        Me.tlpPartidaEdition.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 310)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(690, 314)
        Me.Panel3.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(690, 314)
        Me.TabControl1.TabIndex = 0
        '
        'tlpPartidaEdition2
        '
        Me.tlpPartidaEdition2.ColumnCount = 2
        Me.tlpPartidaEdition2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.tlpPartidaEdition2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaEdition2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPartidaEdition2.Location = New System.Drawing.Point(0, 40)
        Me.tlpPartidaEdition2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPartidaEdition2.Name = "tlpPartidaEdition2"
        Me.tlpPartidaEdition2.RowCount = 7
        Me.tlpPartidaEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPartidaEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpPartidaEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPartidaEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPartidaEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPartidaEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPartidaEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPartidaEdition2.Size = New System.Drawing.Size(690, 270)
        Me.tlpPartidaEdition2.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(96, 100)
        Me.Panel4.TabIndex = 0
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
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.IconSize = 28
        Me.btnGuardar.Location = New System.Drawing.Point(152, 2)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(27, 27)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        'PanelPartidHeader
        '
        Me.PanelPartidHeader.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelPartidHeader.Controls.Add(Me.btnGuardar)
        Me.PanelPartidHeader.Controls.Add(Me.btnCostos)
        Me.PanelPartidHeader.Controls.Add(Me.btnChapter)
        Me.PanelPartidHeader.Controls.Add(Me.btnReport)
        Me.PanelPartidHeader.Controls.Add(Me.btnSplit1)
        Me.PanelPartidHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPartidHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelPartidHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPartidHeader.Name = "PanelPartidHeader"
        Me.PanelPartidHeader.Size = New System.Drawing.Size(1134, 30)
        Me.PanelPartidHeader.TabIndex = 1
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
        'FormFormulacionPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1134, 657)
        Me.Controls.Add(Me.PanelPartidHeader)
        Me.Controls.Add(Me.SplitContainerAPU)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormFormulacionPartida"
        Me.Text = "FormFormulacionPartidas"
        Me.SplitContainerAPU.Panel1.ResumeLayout(False)
        Me.SplitContainerAPU.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerAPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerAPU.ResumeLayout(False)
        Me.splitContPartida.Panel1.ResumeLayout(False)
        Me.splitContPartida.Panel2.ResumeLayout(False)
        CType(Me.splitContPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContPartida.ResumeLayout(False)
        Me.tlpListPartida.ResumeLayout(False)
        Me.tlpPartidaLook.ResumeLayout(False)
        Me.tlpPartidaEdition.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelPartidHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerAPU As SplitContainer
    Friend WithEvents splitContPartida As SplitContainer
    Friend WithEvents tlpListPartida As TableLayoutPanel
    Friend WithEvents tlpPartidaEdition As TableLayoutPanel
    Friend WithEvents tlpPartidaEdition2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnCostos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelPartidHeader As Panel
    Friend WithEvents btnSplit1 As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpPartidaLook As TableLayoutPanel
    Friend WithEvents btnPartidaFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents btnChapter As FontAwesome.Sharp.IconButton
End Class
