<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAPU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAPU))
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnReportAPU = New FontAwesome.Sharp.IconButton()
        Me.btnCostos = New FontAwesome.Sharp.IconButton()
        Me.btnPreView = New FontAwesome.Sharp.IconButton()
        Me.scParent = New System.Windows.Forms.SplitContainer()
        Me.scAPU = New System.Windows.Forms.SplitContainer()
        Me.PanelFoot = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlpPartidaEdit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpPartidaEdition = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLabelEdit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTexEdit = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelButton2 = New System.Windows.Forms.Panel()
        Me.tlpPartidaEditButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCost = New FontAwesome.Sharp.IconButton()
        Me.btnAddInsumo = New FontAwesome.Sharp.IconButton()
        Me.PanelHeader2 = New System.Windows.Forms.Panel()
        Me.PanelButton.SuspendLayout()
        CType(Me.scParent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scParent.Panel1.SuspendLayout()
        Me.scParent.SuspendLayout()
        CType(Me.scAPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scAPU.SuspendLayout()
        Me.PanelFoot.SuspendLayout()
        Me.tlpPartidaEdit.SuspendLayout()
        Me.tlpPartidaEdition.SuspendLayout()
        Me.PanelButton2.SuspendLayout()
        Me.tlpPartidaEditButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelButton.Controls.Add(Me.btnReportAPU)
        Me.PanelButton.Controls.Add(Me.btnCostos)
        Me.PanelButton.Controls.Add(Me.btnPreView)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(1297, 30)
        Me.PanelButton.TabIndex = 1
        '
        'btnReportAPU
        '
        Me.btnReportAPU.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReportAPU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportAPU.FlatAppearance.BorderSize = 0
        Me.btnReportAPU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportAPU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportAPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportAPU.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnReportAPU.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportAPU.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportAPU.IconSize = 28
        Me.btnReportAPU.Location = New System.Drawing.Point(80, 2)
        Me.btnReportAPU.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReportAPU.Name = "btnReportAPU"
        Me.btnReportAPU.Size = New System.Drawing.Size(27, 27)
        Me.btnReportAPU.TabIndex = 18
        Me.btnReportAPU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportAPU.UseVisualStyleBackColor = False
        '
        'btnCostos
        '
        Me.btnCostos.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCostos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCostos.FlatAppearance.BorderSize = 0
        Me.btnCostos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCostos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCostos.IconChar = FontAwesome.Sharp.IconChar.C
        Me.btnCostos.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCostos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCostos.IconSize = 28
        Me.btnCostos.Location = New System.Drawing.Point(8, 2)
        Me.btnCostos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.Size = New System.Drawing.Size(27, 27)
        Me.btnCostos.TabIndex = 1
        Me.btnCostos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCostos.UseVisualStyleBackColor = False
        '
        'btnPreView
        '
        Me.btnPreView.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPreView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPreView.FlatAppearance.BorderSize = 0
        Me.btnPreView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnPreView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnPreView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreView.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPreView.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnPreView.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPreView.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPreView.IconSize = 28
        Me.btnPreView.Location = New System.Drawing.Point(44, 2)
        Me.btnPreView.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPreView.Name = "btnPreView"
        Me.btnPreView.Size = New System.Drawing.Size(27, 27)
        Me.btnPreView.TabIndex = 0
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
        Me.scParent.Panel1.Controls.Add(Me.scAPU)
        Me.scParent.Panel1.Controls.Add(Me.PanelFoot)
        Me.scParent.Panel1.Controls.Add(Me.tlpPartidaEdit)
        '
        'scParent.Panel2
        '
        Me.scParent.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scParent.Size = New System.Drawing.Size(1297, 651)
        Me.scParent.SplitterDistance = 736
        Me.scParent.TabIndex = 2
        '
        'scAPU
        '
        Me.scAPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scAPU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scAPU.Location = New System.Drawing.Point(0, 190)
        Me.scAPU.Margin = New System.Windows.Forms.Padding(0)
        Me.scAPU.Name = "scAPU"
        '
        'scAPU.Panel1
        '
        Me.scAPU.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'scAPU.Panel2
        '
        Me.scAPU.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scAPU.Size = New System.Drawing.Size(736, 413)
        Me.scAPU.SplitterDistance = 390
        Me.scAPU.TabIndex = 2
        '
        'PanelFoot
        '
        Me.PanelFoot.Controls.Add(Me.btnCerrar)
        Me.PanelFoot.Controls.Add(Me.btnGuardar)
        Me.PanelFoot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFoot.Location = New System.Drawing.Point(0, 603)
        Me.PanelFoot.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelFoot.Name = "PanelFoot"
        Me.PanelFoot.Size = New System.Drawing.Size(736, 48)
        Me.PanelFoot.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Cancel
        Me.btnCerrar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCerrar.IconSize = 28
        Me.btnCerrar.Location = New System.Drawing.Point(643, 8)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(85, 32)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.IconSize = 28
        Me.btnGuardar.Location = New System.Drawing.Point(546, 8)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlpPartidaEdit
        '
        Me.tlpPartidaEdit.ColumnCount = 1
        Me.tlpPartidaEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaEdit.Controls.Add(Me.tlpPartidaEdition, 0, 0)
        Me.tlpPartidaEdit.Controls.Add(Me.PanelButton2, 0, 1)
        Me.tlpPartidaEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPartidaEdit.Location = New System.Drawing.Point(0, 0)
        Me.tlpPartidaEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPartidaEdit.Name = "tlpPartidaEdit"
        Me.tlpPartidaEdit.RowCount = 2
        Me.tlpPartidaEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPartidaEdit.Size = New System.Drawing.Size(736, 190)
        Me.tlpPartidaEdit.TabIndex = 0
        '
        'tlpPartidaEdition
        '
        Me.tlpPartidaEdition.ColumnCount = 4
        Me.tlpPartidaEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpPartidaEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPartidaEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpPartidaEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPartidaEdition.Controls.Add(Me.tlpLabelEdit, 2, 1)
        Me.tlpPartidaEdition.Controls.Add(Me.tlpTexEdit, 3, 1)
        Me.tlpPartidaEdition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPartidaEdition.Location = New System.Drawing.Point(0, 0)
        Me.tlpPartidaEdition.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPartidaEdition.Name = "tlpPartidaEdition"
        Me.tlpPartidaEdition.RowCount = 2
        Me.tlpPartidaEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPartidaEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpPartidaEdition.Size = New System.Drawing.Size(736, 150)
        Me.tlpPartidaEdition.TabIndex = 0
        '
        'tlpLabelEdit
        '
        Me.tlpLabelEdit.ColumnCount = 1
        Me.tlpLabelEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabelEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLabelEdit.Location = New System.Drawing.Point(343, 30)
        Me.tlpLabelEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLabelEdit.Name = "tlpLabelEdit"
        Me.tlpLabelEdit.RowCount = 4
        Me.tlpLabelEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabelEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabelEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabelEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabelEdit.Size = New System.Drawing.Size(200, 150)
        Me.tlpLabelEdit.TabIndex = 0
        '
        'tlpTexEdit
        '
        Me.tlpTexEdit.ColumnCount = 1
        Me.tlpTexEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTexEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTexEdit.Location = New System.Drawing.Point(543, 30)
        Me.tlpTexEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTexEdit.Name = "tlpTexEdit"
        Me.tlpTexEdit.RowCount = 4
        Me.tlpTexEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTexEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTexEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTexEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTexEdit.Size = New System.Drawing.Size(193, 150)
        Me.tlpTexEdit.TabIndex = 1
        '
        'PanelButton2
        '
        Me.PanelButton2.Controls.Add(Me.tlpPartidaEditButton)
        Me.PanelButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelButton2.Location = New System.Drawing.Point(0, 150)
        Me.PanelButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton2.Name = "PanelButton2"
        Me.PanelButton2.Size = New System.Drawing.Size(736, 40)
        Me.PanelButton2.TabIndex = 1
        '
        'tlpPartidaEditButton
        '
        Me.tlpPartidaEditButton.ColumnCount = 5
        Me.tlpPartidaEditButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpPartidaEditButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpPartidaEditButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPartidaEditButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPartidaEditButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaEditButton.Controls.Add(Me.btnCost, 2, 0)
        Me.tlpPartidaEditButton.Controls.Add(Me.btnAddInsumo, 3, 0)
        Me.tlpPartidaEditButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPartidaEditButton.Location = New System.Drawing.Point(0, 0)
        Me.tlpPartidaEditButton.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPartidaEditButton.Name = "tlpPartidaEditButton"
        Me.tlpPartidaEditButton.RowCount = 1
        Me.tlpPartidaEditButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaEditButton.Size = New System.Drawing.Size(736, 37)
        Me.tlpPartidaEditButton.TabIndex = 0
        '
        'btnCost
        '
        Me.btnCost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCost.FlatAppearance.BorderSize = 0
        Me.btnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCost.IconChar = FontAwesome.Sharp.IconChar.C
        Me.btnCost.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnCost.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCost.IconSize = 28
        Me.btnCost.Location = New System.Drawing.Point(308, 8)
        Me.btnCost.Margin = New System.Windows.Forms.Padding(8, 8, 4, 4)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(28, 25)
        Me.btnCost.TabIndex = 14
        Me.btnCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnAddInsumo
        '
        Me.btnAddInsumo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddInsumo.FlatAppearance.BorderSize = 0
        Me.btnAddInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddInsumo.IconChar = FontAwesome.Sharp.IconChar.ChevronRight
        Me.btnAddInsumo.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddInsumo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddInsumo.IconSize = 28
        Me.btnAddInsumo.Location = New System.Drawing.Point(348, 8)
        Me.btnAddInsumo.Margin = New System.Windows.Forms.Padding(8, 8, 4, 4)
        Me.btnAddInsumo.Name = "btnAddInsumo"
        Me.btnAddInsumo.Size = New System.Drawing.Size(28, 25)
        Me.btnAddInsumo.TabIndex = 0
        Me.btnAddInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddInsumo.UseVisualStyleBackColor = True
        '
        'PanelHeader2
        '
        Me.PanelHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader2.Location = New System.Drawing.Point(0, 30)
        Me.PanelHeader2.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelHeader2.Name = "PanelHeader2"
        Me.PanelHeader2.Size = New System.Drawing.Size(1297, 37)
        Me.PanelHeader2.TabIndex = 3
        '
        'FormAPU
        '
        Me.AcceptButton = Me.btnCerrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1297, 725)
        Me.Controls.Add(Me.PanelHeader2)
        Me.Controls.Add(Me.scParent)
        Me.Controls.Add(Me.PanelButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAPU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormAPU"
        Me.PanelButton.ResumeLayout(False)
        Me.scParent.Panel1.ResumeLayout(False)
        CType(Me.scParent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scParent.ResumeLayout(False)
        CType(Me.scAPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scAPU.ResumeLayout(False)
        Me.PanelFoot.ResumeLayout(False)
        Me.tlpPartidaEdit.ResumeLayout(False)
        Me.tlpPartidaEdition.ResumeLayout(False)
        Me.PanelButton2.ResumeLayout(False)
        Me.tlpPartidaEditButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelButton As Panel
    Friend WithEvents scParent As SplitContainer
    Friend WithEvents tlpPartidaEdit As TableLayoutPanel
    Friend WithEvents scAPU As SplitContainer
    Friend WithEvents PanelFoot As Panel
    Friend WithEvents tlpPartidaEdition As TableLayoutPanel
    Friend WithEvents tlpLabelEdit As TableLayoutPanel
    Friend WithEvents tlpTexEdit As TableLayoutPanel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelButton2 As Panel
    Friend WithEvents tlpPartidaEditButton As TableLayoutPanel
    Friend WithEvents btnPreView As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCostos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddInsumo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCost As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelHeader2 As Panel
    Friend WithEvents btnReportAPU As FontAwesome.Sharp.IconButton
End Class
