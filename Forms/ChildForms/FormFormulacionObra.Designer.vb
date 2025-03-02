<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFormulacionObra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tlpListObra = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpObraLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnObraFilter = New FontAwesome.Sharp.IconButton()
        Me.splitContObra = New System.Windows.Forms.SplitContainer()
        Me.tlpObra = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelCalculation = New System.Windows.Forms.Panel()
        Me.tlpObraEdit2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.btnReport = New FontAwesome.Sharp.IconButton()
        Me.btnCost = New FontAwesome.Sharp.IconButton()
        Me.btnStage = New FontAwesome.Sharp.IconButton()
        Me.PanelHeadButton = New System.Windows.Forms.Panel()
        Me.btnPUObra = New FontAwesome.Sharp.IconButton()
        Me.btnReportMat = New FontAwesome.Sharp.IconButton()
        Me.tlpListObra.SuspendLayout()
        Me.tlpObraLook.SuspendLayout()
        CType(Me.splitContObra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContObra.Panel1.SuspendLayout()
        Me.splitContObra.Panel2.SuspendLayout()
        Me.splitContObra.SuspendLayout()
        Me.tlpObra.SuspendLayout()
        Me.PanelHeadButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpListObra
        '
        Me.tlpListObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListObra.ColumnCount = 1
        Me.tlpListObra.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListObra.Controls.Add(Me.tlpObraLook, 0, 2)
        Me.tlpListObra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListObra.Location = New System.Drawing.Point(0, 0)
        Me.tlpListObra.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListObra.Name = "tlpListObra"
        Me.tlpListObra.RowCount = 4
        Me.tlpListObra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListObra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListObra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListObra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListObra.Size = New System.Drawing.Size(440, 570)
        Me.tlpListObra.TabIndex = 0
        '
        'tlpObraLook
        '
        Me.tlpObraLook.ColumnCount = 2
        Me.tlpObraLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpObraLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpObraLook.Controls.Add(Me.btnObraFilter, 1, 0)
        Me.tlpObraLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpObraLook.Location = New System.Drawing.Point(0, 70)
        Me.tlpObraLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpObraLook.Name = "tlpObraLook"
        Me.tlpObraLook.RowCount = 1
        Me.tlpObraLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpObraLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpObraLook.Size = New System.Drawing.Size(440, 30)
        Me.tlpObraLook.TabIndex = 0
        '
        'btnObraFilter
        '
        Me.btnObraFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnObraFilter.FlatAppearance.BorderSize = 0
        Me.btnObraFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnObraFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnObraFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnObraFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnObraFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnObraFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnObraFilter.IconSize = 28
        Me.btnObraFilter.Location = New System.Drawing.Point(400, 0)
        Me.btnObraFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnObraFilter.Name = "btnObraFilter"
        Me.btnObraFilter.Size = New System.Drawing.Size(40, 30)
        Me.btnObraFilter.TabIndex = 0
        Me.btnObraFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnObraFilter.UseVisualStyleBackColor = True
        '
        'splitContObra
        '
        Me.splitContObra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContObra.BackColor = System.Drawing.SystemColors.Control
        Me.splitContObra.Location = New System.Drawing.Point(0, 34)
        Me.splitContObra.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContObra.Name = "splitContObra"
        '
        'splitContObra.Panel1
        '
        Me.splitContObra.Panel1.Controls.Add(Me.tlpListObra)
        '
        'splitContObra.Panel2
        '
        Me.splitContObra.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.splitContObra.Panel2.Controls.Add(Me.tlpObra)
        Me.splitContObra.Size = New System.Drawing.Size(920, 570)
        Me.splitContObra.SplitterDistance = 440
        Me.splitContObra.TabIndex = 2
        '
        'tlpObra
        '
        Me.tlpObra.ColumnCount = 1
        Me.tlpObra.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpObra.Controls.Add(Me.PanelCalculation, 0, 2)
        Me.tlpObra.Controls.Add(Me.tlpObraEdit2, 0, 1)
        Me.tlpObra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpObra.Location = New System.Drawing.Point(0, 0)
        Me.tlpObra.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpObra.Name = "tlpObra"
        Me.tlpObra.RowCount = 3
        Me.tlpObra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpObra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me.tlpObra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpObra.Size = New System.Drawing.Size(476, 570)
        Me.tlpObra.TabIndex = 0
        '
        'PanelCalculation
        '
        Me.PanelCalculation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCalculation.Location = New System.Drawing.Point(0, 250)
        Me.PanelCalculation.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelCalculation.Name = "PanelCalculation"
        Me.PanelCalculation.Size = New System.Drawing.Size(476, 320)
        Me.PanelCalculation.TabIndex = 2
        '
        'tlpObraEdit2
        '
        Me.tlpObraEdit2.ColumnCount = 2
        Me.tlpObraEdit2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.tlpObraEdit2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpObraEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpObraEdit2.Location = New System.Drawing.Point(0, 40)
        Me.tlpObraEdit2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpObraEdit2.Name = "tlpObraEdit2"
        Me.tlpObraEdit2.RowCount = 5
        Me.tlpObraEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpObraEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpObraEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpObraEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpObraEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpObraEdit2.Size = New System.Drawing.Size(476, 210)
        Me.tlpObraEdit2.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnSave.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 28
        Me.btnSave.Location = New System.Drawing.Point(188, 2)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(27, 27)
        Me.btnSave.TabIndex = 0
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReport.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnReport.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReport.IconSize = 28
        Me.btnReport.Location = New System.Drawing.Point(80, 2)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(27, 27)
        Me.btnReport.TabIndex = 1
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCost.FlatAppearance.BorderSize = 0
        Me.btnCost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCost.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCost.IconChar = FontAwesome.Sharp.IconChar.C
        Me.btnCost.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCost.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCost.IconSize = 28
        Me.btnCost.Location = New System.Drawing.Point(44, 2)
        Me.btnCost.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(27, 27)
        Me.btnCost.TabIndex = 2
        Me.btnCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnStage
        '
        Me.btnStage.BackColor = System.Drawing.Color.Gainsboro
        Me.btnStage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnStage.FlatAppearance.BorderSize = 0
        Me.btnStage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnStage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnStage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnStage.IconChar = FontAwesome.Sharp.IconChar.CubesStacked
        Me.btnStage.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnStage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStage.IconSize = 28
        Me.btnStage.Location = New System.Drawing.Point(8, 2)
        Me.btnStage.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStage.Name = "btnStage"
        Me.btnStage.Size = New System.Drawing.Size(27, 27)
        Me.btnStage.TabIndex = 3
        Me.btnStage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStage.UseVisualStyleBackColor = False
        '
        'PanelHeadButton
        '
        Me.PanelHeadButton.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelHeadButton.Controls.Add(Me.btnPUObra)
        Me.PanelHeadButton.Controls.Add(Me.btnReportMat)
        Me.PanelHeadButton.Controls.Add(Me.btnSave)
        Me.PanelHeadButton.Controls.Add(Me.btnReport)
        Me.PanelHeadButton.Controls.Add(Me.btnCost)
        Me.PanelHeadButton.Controls.Add(Me.btnStage)
        Me.PanelHeadButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeadButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeadButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelHeadButton.Name = "PanelHeadButton"
        Me.PanelHeadButton.Size = New System.Drawing.Size(920, 30)
        Me.PanelHeadButton.TabIndex = 0
        '
        'btnPUObra
        '
        Me.btnPUObra.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPUObra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPUObra.FlatAppearance.BorderSize = 0
        Me.btnPUObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnPUObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnPUObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPUObra.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPUObra.IconChar = FontAwesome.Sharp.IconChar.Rev
        Me.btnPUObra.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPUObra.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPUObra.IconSize = 28
        Me.btnPUObra.Location = New System.Drawing.Point(152, 1)
        Me.btnPUObra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPUObra.Name = "btnPUObra"
        Me.btnPUObra.Size = New System.Drawing.Size(27, 27)
        Me.btnPUObra.TabIndex = 5
        Me.btnPUObra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPUObra.UseVisualStyleBackColor = False
        '
        'btnReportMat
        '
        Me.btnReportMat.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReportMat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportMat.FlatAppearance.BorderSize = 0
        Me.btnReportMat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportMat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportMat.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReportMat.IconChar = FontAwesome.Sharp.IconChar.FileText
        Me.btnReportMat.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportMat.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportMat.IconSize = 28
        Me.btnReportMat.Location = New System.Drawing.Point(116, 2)
        Me.btnReportMat.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReportMat.Name = "btnReportMat"
        Me.btnReportMat.Size = New System.Drawing.Size(27, 27)
        Me.btnReportMat.TabIndex = 4
        Me.btnReportMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportMat.UseVisualStyleBackColor = False
        '
        'FormFormulacionObra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(920, 604)
        Me.Controls.Add(Me.PanelHeadButton)
        Me.Controls.Add(Me.splitContObra)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormFormulacionObra"
        Me.Text = "FormObra"
        Me.tlpListObra.ResumeLayout(False)
        Me.tlpObraLook.ResumeLayout(False)
        Me.splitContObra.Panel1.ResumeLayout(False)
        Me.splitContObra.Panel2.ResumeLayout(False)
        CType(Me.splitContObra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContObra.ResumeLayout(False)
        Me.tlpObra.ResumeLayout(False)
        Me.PanelHeadButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpListObra As TableLayoutPanel
    Friend WithEvents splitContObra As SplitContainer
    Friend WithEvents tlpObraLook As TableLayoutPanel
    Friend WithEvents btnObraFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpObra As TableLayoutPanel
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCost As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStage As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelCalculation As Panel
    Friend WithEvents PanelHeadButton As Panel
    Friend WithEvents btnReportMat As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPUObra As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpObraEdit2 As TableLayoutPanel
End Class
