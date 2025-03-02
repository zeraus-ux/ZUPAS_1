<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBudget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBudget))
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnReportBudget = New FontAwesome.Sharp.IconButton()
        Me.btnCost1 = New FontAwesome.Sharp.IconButton()
        Me.btnPreView = New FontAwesome.Sharp.IconButton()
        Me.scParent = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tlpButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddPartida = New FontAwesome.Sharp.IconButton()
        Me.btnCost = New FontAwesome.Sharp.IconButton()
        Me.PanelFoot = New System.Windows.Forms.Panel()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.tlpObraEdition = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLabelEdit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTexEdit = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelHeader1 = New System.Windows.Forms.Panel()
        Me.PanelButton.SuspendLayout()
        CType(Me.scParent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scParent.Panel1.SuspendLayout()
        Me.scParent.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.tlpButton.SuspendLayout()
        Me.PanelFoot.SuspendLayout()
        Me.tlpObraEdition.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelButton.Controls.Add(Me.btnReportBudget)
        Me.PanelButton.Controls.Add(Me.btnCost1)
        Me.PanelButton.Controls.Add(Me.btnPreView)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(1347, 30)
        Me.PanelButton.TabIndex = 1
        '
        'btnReportBudget
        '
        Me.btnReportBudget.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReportBudget.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportBudget.FlatAppearance.BorderSize = 0
        Me.btnReportBudget.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportBudget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportBudget.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnReportBudget.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportBudget.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportBudget.IconSize = 28
        Me.btnReportBudget.Location = New System.Drawing.Point(80, 2)
        Me.btnReportBudget.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReportBudget.Name = "btnReportBudget"
        Me.btnReportBudget.Size = New System.Drawing.Size(27, 27)
        Me.btnReportBudget.TabIndex = 17
        Me.btnReportBudget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportBudget.UseVisualStyleBackColor = False
        '
        'btnCost1
        '
        Me.btnCost1.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCost1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCost1.FlatAppearance.BorderSize = 0
        Me.btnCost1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCost1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCost1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCost1.IconChar = FontAwesome.Sharp.IconChar.C
        Me.btnCost1.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCost1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCost1.IconSize = 28
        Me.btnCost1.Location = New System.Drawing.Point(8, 2)
        Me.btnCost1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCost1.Name = "btnCost1"
        Me.btnCost1.Size = New System.Drawing.Size(27, 27)
        Me.btnCost1.TabIndex = 16
        Me.btnCost1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCost1.UseVisualStyleBackColor = False
        '
        'btnPreView
        '
        Me.btnPreView.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPreView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPreView.FlatAppearance.BorderSize = 0
        Me.btnPreView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnPreView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnPreView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreView.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnPreView.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPreView.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPreView.IconSize = 28
        Me.btnPreView.Location = New System.Drawing.Point(44, 2)
        Me.btnPreView.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPreView.Name = "btnPreView"
        Me.btnPreView.Size = New System.Drawing.Size(27, 27)
        Me.btnPreView.TabIndex = 15
        Me.btnPreView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreView.UseVisualStyleBackColor = False
        '
        'scParent
        '
        Me.scParent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scParent.Location = New System.Drawing.Point(0, 71)
        Me.scParent.Margin = New System.Windows.Forms.Padding(0)
        Me.scParent.Name = "scParent"
        '
        'scParent.Panel1
        '
        Me.scParent.Panel1.Controls.Add(Me.SplitContainer1)
        Me.scParent.Panel1.Controls.Add(Me.tlpButton)
        Me.scParent.Panel1.Controls.Add(Me.PanelFoot)
        Me.scParent.Panel1.Controls.Add(Me.tlpObraEdition)
        Me.scParent.Size = New System.Drawing.Size(1347, 717)
        Me.scParent.SplitterDistance = 764
        Me.scParent.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 156)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(764, 513)
        Me.SplitContainer1.SplitterDistance = 254
        Me.SplitContainer1.TabIndex = 5
        '
        'tlpButton
        '
        Me.tlpButton.ColumnCount = 5
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButton.Controls.Add(Me.btnAddPartida, 3, 0)
        Me.tlpButton.Controls.Add(Me.btnCost, 2, 0)
        Me.tlpButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpButton.Location = New System.Drawing.Point(0, 120)
        Me.tlpButton.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpButton.Name = "tlpButton"
        Me.tlpButton.RowCount = 1
        Me.tlpButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButton.Size = New System.Drawing.Size(764, 36)
        Me.tlpButton.TabIndex = 4
        '
        'btnAddPartida
        '
        Me.btnAddPartida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPartida.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddPartida.FlatAppearance.BorderSize = 0
        Me.btnAddPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPartida.IconChar = FontAwesome.Sharp.IconChar.ChevronRight
        Me.btnAddPartida.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddPartida.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddPartida.IconSize = 28
        Me.btnAddPartida.Location = New System.Drawing.Point(348, 4)
        Me.btnAddPartida.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.btnAddPartida.Name = "btnAddPartida"
        Me.btnAddPartida.Size = New System.Drawing.Size(28, 28)
        Me.btnAddPartida.TabIndex = 14
        Me.btnAddPartida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddPartida.UseVisualStyleBackColor = False
        '
        'btnCost
        '
        Me.btnCost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCost.FlatAppearance.BorderSize = 0
        Me.btnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCost.IconChar = FontAwesome.Sharp.IconChar.C
        Me.btnCost.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnCost.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCost.IconSize = 28
        Me.btnCost.Location = New System.Drawing.Point(308, 4)
        Me.btnCost.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(28, 28)
        Me.btnCost.TabIndex = 15
        Me.btnCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'PanelFoot
        '
        Me.PanelFoot.Controls.Add(Me.btnSave)
        Me.PanelFoot.Controls.Add(Me.btnCerrar)
        Me.PanelFoot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFoot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelFoot.Location = New System.Drawing.Point(0, 669)
        Me.PanelFoot.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.PanelFoot.Name = "PanelFoot"
        Me.PanelFoot.Size = New System.Drawing.Size(764, 48)
        Me.PanelFoot.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnSave.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 28
        Me.btnSave.Location = New System.Drawing.Point(574, 8)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 32)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Salvar"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Cancel
        Me.btnCerrar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCerrar.IconSize = 28
        Me.btnCerrar.Location = New System.Drawing.Point(671, 8)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(85, 32)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'tlpObraEdition
        '
        Me.tlpObraEdition.ColumnCount = 4
        Me.tlpObraEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpObraEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpObraEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpObraEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpObraEdition.Controls.Add(Me.tlpLabelEdit, 2, 1)
        Me.tlpObraEdition.Controls.Add(Me.tlpTexEdit, 3, 1)
        Me.tlpObraEdition.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpObraEdition.Location = New System.Drawing.Point(0, 0)
        Me.tlpObraEdition.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpObraEdition.Name = "tlpObraEdition"
        Me.tlpObraEdition.RowCount = 2
        Me.tlpObraEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpObraEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpObraEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpObraEdition.Size = New System.Drawing.Size(764, 120)
        Me.tlpObraEdition.TabIndex = 0
        '
        'tlpLabelEdit
        '
        Me.tlpLabelEdit.ColumnCount = 1
        Me.tlpLabelEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabelEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLabelEdit.Location = New System.Drawing.Point(382, 30)
        Me.tlpLabelEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLabelEdit.Name = "tlpLabelEdit"
        Me.tlpLabelEdit.RowCount = 3
        Me.tlpLabelEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabelEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabelEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabelEdit.Size = New System.Drawing.Size(150, 90)
        Me.tlpLabelEdit.TabIndex = 0
        '
        'tlpTexEdit
        '
        Me.tlpTexEdit.ColumnCount = 1
        Me.tlpTexEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTexEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTexEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTexEdit.Location = New System.Drawing.Point(532, 30)
        Me.tlpTexEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTexEdit.Name = "tlpTexEdit"
        Me.tlpTexEdit.RowCount = 3
        Me.tlpTexEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTexEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTexEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTexEdit.Size = New System.Drawing.Size(232, 90)
        Me.tlpTexEdit.TabIndex = 1
        '
        'PanelHeader1
        '
        Me.PanelHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader1.Location = New System.Drawing.Point(0, 30)
        Me.PanelHeader1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelHeader1.Name = "PanelHeader1"
        Me.PanelHeader1.Size = New System.Drawing.Size(1347, 37)
        Me.PanelHeader1.TabIndex = 17
        '
        'FormBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1347, 794)
        Me.Controls.Add(Me.PanelHeader1)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.scParent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBudget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormBudget"
        Me.PanelButton.ResumeLayout(False)
        Me.scParent.Panel1.ResumeLayout(False)
        CType(Me.scParent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scParent.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tlpButton.ResumeLayout(False)
        Me.PanelFoot.ResumeLayout(False)
        Me.tlpObraEdition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelButton As Panel
    Friend WithEvents scParent As SplitContainer
    Friend WithEvents tlpObraEdition As TableLayoutPanel
    Friend WithEvents PanelFoot As Panel
    Friend WithEvents tlpButton As TableLayoutPanel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnAddPartida As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPreView As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCost As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCost1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelHeader1 As Panel
    Friend WithEvents btnReportBudget As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpLabelEdit As TableLayoutPanel
    Friend WithEvents tlpTexEdit As TableLayoutPanel
End Class
