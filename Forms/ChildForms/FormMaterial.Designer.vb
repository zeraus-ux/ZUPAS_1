<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaterial))
        Me.tlpListMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMaterialLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMaterialFilter = New FontAwesome.Sharp.IconButton()
        Me.tlpEdicionMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.tlpEditionMaterial2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMaterialType = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlpHeaderButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDataSource = New FontAwesome.Sharp.IconButton()
        Me.btnMaterialCompound = New FontAwesome.Sharp.IconButton()
        Me.SplitContMaterial = New System.Windows.Forms.SplitContainer()
        Me.tlpListMaterial.SuspendLayout()
        Me.tlpMaterialLook.SuspendLayout()
        Me.tlpEdicionMaterial.SuspendLayout()
        Me.tlpHeaderButton.SuspendLayout()
        CType(Me.SplitContMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContMaterial.Panel1.SuspendLayout()
        Me.SplitContMaterial.Panel2.SuspendLayout()
        Me.SplitContMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpListMaterial
        '
        Me.tlpListMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListMaterial.ColumnCount = 1
        Me.tlpListMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMaterial.Controls.Add(Me.tlpMaterialLook, 0, 3)
        Me.tlpListMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListMaterial.Location = New System.Drawing.Point(0, 0)
        Me.tlpListMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListMaterial.Name = "tlpListMaterial"
        Me.tlpListMaterial.RowCount = 5
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMaterial.Size = New System.Drawing.Size(323, 565)
        Me.tlpListMaterial.TabIndex = 0
        '
        'tlpMaterialLook
        '
        Me.tlpMaterialLook.ColumnCount = 2
        Me.tlpMaterialLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMaterialLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpMaterialLook.Controls.Add(Me.btnMaterialFilter, 1, 0)
        Me.tlpMaterialLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMaterialLook.Location = New System.Drawing.Point(0, 100)
        Me.tlpMaterialLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMaterialLook.Name = "tlpMaterialLook"
        Me.tlpMaterialLook.RowCount = 1
        Me.tlpMaterialLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMaterialLook.Size = New System.Drawing.Size(323, 30)
        Me.tlpMaterialLook.TabIndex = 0
        '
        'btnMaterialFilter
        '
        Me.btnMaterialFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaterialFilter.FlatAppearance.BorderSize = 0
        Me.btnMaterialFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaterialFilter.ForeColor = System.Drawing.Color.Transparent
        Me.btnMaterialFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnMaterialFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnMaterialFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaterialFilter.IconSize = 28
        Me.btnMaterialFilter.Location = New System.Drawing.Point(283, 0)
        Me.btnMaterialFilter.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.btnMaterialFilter.Name = "btnMaterialFilter"
        Me.btnMaterialFilter.Size = New System.Drawing.Size(40, 22)
        Me.btnMaterialFilter.TabIndex = 0
        Me.btnMaterialFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaterialFilter.UseVisualStyleBackColor = True
        '
        'tlpEdicionMaterial
        '
        Me.tlpEdicionMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEdicionMaterial.ColumnCount = 1
        Me.tlpEdicionMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionMaterial.Controls.Add(Me.PanelButton, 0, 2)
        Me.tlpEdicionMaterial.Controls.Add(Me.tlpEditionMaterial2, 0, 1)
        Me.tlpEdicionMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEdicionMaterial.Location = New System.Drawing.Point(0, 0)
        Me.tlpEdicionMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEdicionMaterial.Name = "tlpEdicionMaterial"
        Me.tlpEdicionMaterial.RowCount = 3
        Me.tlpEdicionMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEdicionMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEdicionMaterial.Size = New System.Drawing.Size(665, 565)
        Me.tlpEdicionMaterial.TabIndex = 0
        '
        'PanelButton
        '
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelButton.Location = New System.Drawing.Point(0, 517)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(665, 48)
        Me.PanelButton.TabIndex = 8
        '
        'tlpEditionMaterial2
        '
        Me.tlpEditionMaterial2.ColumnCount = 2
        Me.tlpEditionMaterial2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEditionMaterial2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionMaterial2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEditionMaterial2.Location = New System.Drawing.Point(0, 40)
        Me.tlpEditionMaterial2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionMaterial2.Name = "tlpEditionMaterial2"
        Me.tlpEditionMaterial2.RowCount = 6
        Me.tlpEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionMaterial2.Size = New System.Drawing.Size(665, 270)
        Me.tlpEditionMaterial2.TabIndex = 9
        '
        'btnMaterialType
        '
        Me.btnMaterialType.BackColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaterialType.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnMaterialType.FlatAppearance.BorderSize = 0
        Me.btnMaterialType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaterialType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterialType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMaterialType.IconChar = FontAwesome.Sharp.IconChar.T
        Me.btnMaterialType.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnMaterialType.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaterialType.IconSize = 28
        Me.btnMaterialType.Location = New System.Drawing.Point(44, 2)
        Me.btnMaterialType.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnMaterialType.Name = "btnMaterialType"
        Me.btnMaterialType.Size = New System.Drawing.Size(28, 28)
        Me.btnMaterialType.TabIndex = 2
        Me.btnMaterialType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaterialType.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.IconSize = 28
        Me.btnGuardar.Location = New System.Drawing.Point(116, 2)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(28, 28)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlpHeaderButton
        '
        Me.tlpHeaderButton.BackColor = System.Drawing.Color.Gainsboro
        Me.tlpHeaderButton.ColumnCount = 5
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHeaderButton.Controls.Add(Me.btnDataSource, 0, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnMaterialType, 1, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnGuardar, 3, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnMaterialCompound, 2, 0)
        Me.tlpHeaderButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpHeaderButton.Location = New System.Drawing.Point(0, 0)
        Me.tlpHeaderButton.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpHeaderButton.Name = "tlpHeaderButton"
        Me.tlpHeaderButton.RowCount = 1
        Me.tlpHeaderButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpHeaderButton.Size = New System.Drawing.Size(992, 30)
        Me.tlpHeaderButton.TabIndex = 0
        '
        'btnDataSource
        '
        Me.btnDataSource.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDataSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDataSource.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDataSource.FlatAppearance.BorderSize = 0
        Me.btnDataSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnDataSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnDataSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDataSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataSource.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDataSource.IconChar = FontAwesome.Sharp.IconChar.D
        Me.btnDataSource.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDataSource.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDataSource.IconSize = 28
        Me.btnDataSource.Location = New System.Drawing.Point(8, 2)
        Me.btnDataSource.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnDataSource.Name = "btnDataSource"
        Me.btnDataSource.Size = New System.Drawing.Size(28, 28)
        Me.btnDataSource.TabIndex = 3
        Me.btnDataSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDataSource.UseVisualStyleBackColor = False
        '
        'btnMaterialCompound
        '
        Me.btnMaterialCompound.BackColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialCompound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaterialCompound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnMaterialCompound.FlatAppearance.BorderSize = 0
        Me.btnMaterialCompound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialCompound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialCompound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaterialCompound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterialCompound.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialCompound.IconChar = FontAwesome.Sharp.IconChar.Cubes
        Me.btnMaterialCompound.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnMaterialCompound.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaterialCompound.IconSize = 28
        Me.btnMaterialCompound.Location = New System.Drawing.Point(80, 2)
        Me.btnMaterialCompound.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnMaterialCompound.Name = "btnMaterialCompound"
        Me.btnMaterialCompound.Size = New System.Drawing.Size(28, 28)
        Me.btnMaterialCompound.TabIndex = 4
        Me.btnMaterialCompound.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaterialCompound.UseVisualStyleBackColor = False
        '
        'SplitContMaterial
        '
        Me.SplitContMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContMaterial.Location = New System.Drawing.Point(0, 30)
        Me.SplitContMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContMaterial.Name = "SplitContMaterial"
        '
        'SplitContMaterial.Panel1
        '
        Me.SplitContMaterial.Panel1.Controls.Add(Me.tlpListMaterial)
        '
        'SplitContMaterial.Panel2
        '
        Me.SplitContMaterial.Panel2.Controls.Add(Me.tlpEdicionMaterial)
        Me.SplitContMaterial.Size = New System.Drawing.Size(992, 565)
        Me.SplitContMaterial.SplitterDistance = 323
        Me.SplitContMaterial.TabIndex = 2
        '
        'FormMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(992, 595)
        Me.Controls.Add(Me.SplitContMaterial)
        Me.Controls.Add(Me.tlpHeaderButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMaterial"
        Me.Text = "FormMaterial"
        Me.tlpListMaterial.ResumeLayout(False)
        Me.tlpMaterialLook.ResumeLayout(False)
        Me.tlpEdicionMaterial.ResumeLayout(False)
        Me.tlpHeaderButton.ResumeLayout(False)
        Me.SplitContMaterial.Panel1.ResumeLayout(False)
        Me.SplitContMaterial.Panel2.ResumeLayout(False)
        CType(Me.SplitContMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContMaterial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpListMaterial As TableLayoutPanel
    Friend WithEvents tlpEdicionMaterial As TableLayoutPanel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelButton As Panel
    Friend WithEvents tlpMaterialLook As TableLayoutPanel
    Friend WithEvents btnMaterialFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpEditionMaterial2 As TableLayoutPanel
    Friend WithEvents btnMaterialType As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpHeaderButton As TableLayoutPanel
    Friend WithEvents SplitContMaterial As SplitContainer
    Friend WithEvents btnDataSource As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaterialCompound As FontAwesome.Sharp.IconButton
End Class
