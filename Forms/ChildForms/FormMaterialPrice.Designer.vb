<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMaterialPrice
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
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.tlpEditionPriceMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpEditionPriceMaterial2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListUnit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMaterialLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMaterialFilter = New FontAwesome.Sharp.IconButton()
        Me.splitContMaterial = New System.Windows.Forms.SplitContainer()
        Me.tlpHeaderButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMaterialPriceList = New FontAwesome.Sharp.IconButton()
        Me.btnReportMaterialPriceList = New FontAwesome.Sharp.IconButton()
        Me.btnMaterialType = New FontAwesome.Sharp.IconButton()
        Me.btnDataSource = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar2 = New FontAwesome.Sharp.IconButton()
        Me.tlpEditionPriceMaterial.SuspendLayout()
        Me.tlpListMaterial.SuspendLayout()
        Me.tlpMaterialLook.SuspendLayout()
        CType(Me.splitContMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContMaterial.Panel1.SuspendLayout()
        Me.splitContMaterial.Panel2.SuspendLayout()
        Me.splitContMaterial.SuspendLayout()
        Me.tlpHeaderButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBotton
        '
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 552)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(415, 48)
        Me.PanelBotton.TabIndex = 6
        '
        'tlpEditionPriceMaterial
        '
        Me.tlpEditionPriceMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEditionPriceMaterial.ColumnCount = 1
        Me.tlpEditionPriceMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionPriceMaterial.Controls.Add(Me.PanelBotton, 0, 2)
        Me.tlpEditionPriceMaterial.Controls.Add(Me.tlpEditionPriceMaterial2, 0, 1)
        Me.tlpEditionPriceMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEditionPriceMaterial.Location = New System.Drawing.Point(0, 0)
        Me.tlpEditionPriceMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionPriceMaterial.Name = "tlpEditionPriceMaterial"
        Me.tlpEditionPriceMaterial.RowCount = 3
        Me.tlpEditionPriceMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEditionPriceMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionPriceMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEditionPriceMaterial.Size = New System.Drawing.Size(415, 600)
        Me.tlpEditionPriceMaterial.TabIndex = 0
        '
        'tlpEditionPriceMaterial2
        '
        Me.tlpEditionPriceMaterial2.ColumnCount = 2
        Me.tlpEditionPriceMaterial2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEditionPriceMaterial2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionPriceMaterial2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEditionPriceMaterial2.Location = New System.Drawing.Point(0, 40)
        Me.tlpEditionPriceMaterial2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionPriceMaterial2.Name = "tlpEditionPriceMaterial2"
        Me.tlpEditionPriceMaterial2.RowCount = 4
        Me.tlpEditionPriceMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEditionPriceMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionPriceMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionPriceMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionPriceMaterial2.Size = New System.Drawing.Size(415, 150)
        Me.tlpEditionPriceMaterial2.TabIndex = 7
        '
        'tlpListMaterial
        '
        Me.tlpListMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListMaterial.ColumnCount = 1
        Me.tlpListMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMaterial.Controls.Add(Me.tlpListUnit, 0, 4)
        Me.tlpListMaterial.Controls.Add(Me.tlpMaterialLook, 0, 3)
        Me.tlpListMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListMaterial.Location = New System.Drawing.Point(0, 0)
        Me.tlpListMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListMaterial.Name = "tlpListMaterial"
        Me.tlpListMaterial.RowCount = 6
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMaterial.Size = New System.Drawing.Size(470, 600)
        Me.tlpListMaterial.TabIndex = 0
        '
        'tlpListUnit
        '
        Me.tlpListUnit.ColumnCount = 2
        Me.tlpListUnit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpListUnit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListUnit.Location = New System.Drawing.Point(0, 130)
        Me.tlpListUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListUnit.Name = "tlpListUnit"
        Me.tlpListUnit.RowCount = 1
        Me.tlpListUnit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListUnit.Size = New System.Drawing.Size(470, 30)
        Me.tlpListUnit.TabIndex = 3
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
        Me.tlpMaterialLook.Size = New System.Drawing.Size(470, 30)
        Me.tlpMaterialLook.TabIndex = 2
        '
        'btnMaterialFilter
        '
        Me.btnMaterialFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaterialFilter.FlatAppearance.BorderSize = 0
        Me.btnMaterialFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMaterialFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMaterialFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaterialFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnMaterialFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnMaterialFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaterialFilter.IconSize = 28
        Me.btnMaterialFilter.Location = New System.Drawing.Point(430, 0)
        Me.btnMaterialFilter.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.btnMaterialFilter.Name = "btnMaterialFilter"
        Me.btnMaterialFilter.Size = New System.Drawing.Size(32, 22)
        Me.btnMaterialFilter.TabIndex = 0
        Me.btnMaterialFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaterialFilter.UseVisualStyleBackColor = True
        '
        'splitContMaterial
        '
        Me.splitContMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContMaterial.Location = New System.Drawing.Point(0, 33)
        Me.splitContMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContMaterial.Name = "splitContMaterial"
        '
        'splitContMaterial.Panel1
        '
        Me.splitContMaterial.Panel1.Controls.Add(Me.tlpListMaterial)
        '
        'splitContMaterial.Panel2
        '
        Me.splitContMaterial.Panel2.Controls.Add(Me.tlpEditionPriceMaterial)
        Me.splitContMaterial.Size = New System.Drawing.Size(889, 600)
        Me.splitContMaterial.SplitterDistance = 470
        Me.splitContMaterial.TabIndex = 1
        '
        'tlpHeaderButton
        '
        Me.tlpHeaderButton.BackColor = System.Drawing.Color.Gainsboro
        Me.tlpHeaderButton.ColumnCount = 6
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHeaderButton.Controls.Add(Me.btnDataSource, 0, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnGuardar2, 4, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnMaterialType, 1, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnMaterialPriceList, 3, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnReportMaterialPriceList, 2, 0)
        Me.tlpHeaderButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpHeaderButton.Location = New System.Drawing.Point(0, 0)
        Me.tlpHeaderButton.Name = "tlpHeaderButton"
        Me.tlpHeaderButton.RowCount = 1
        Me.tlpHeaderButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpHeaderButton.Size = New System.Drawing.Size(889, 30)
        Me.tlpHeaderButton.TabIndex = 2
        '
        'btnMaterialPriceList
        '
        Me.btnMaterialPriceList.BackColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialPriceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaterialPriceList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnMaterialPriceList.FlatAppearance.BorderSize = 0
        Me.btnMaterialPriceList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialPriceList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnMaterialPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaterialPriceList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterialPriceList.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMaterialPriceList.IconChar = FontAwesome.Sharp.IconChar.Coins
        Me.btnMaterialPriceList.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnMaterialPriceList.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaterialPriceList.IconSize = 28
        Me.btnMaterialPriceList.Location = New System.Drawing.Point(116, 2)
        Me.btnMaterialPriceList.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnMaterialPriceList.Name = "btnMaterialPriceList"
        Me.btnMaterialPriceList.Size = New System.Drawing.Size(28, 28)
        Me.btnMaterialPriceList.TabIndex = 10
        Me.btnMaterialPriceList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaterialPriceList.UseVisualStyleBackColor = False
        '
        'btnReportMaterialPriceList
        '
        Me.btnReportMaterialPriceList.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReportMaterialPriceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReportMaterialPriceList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportMaterialPriceList.FlatAppearance.BorderSize = 0
        Me.btnReportMaterialPriceList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportMaterialPriceList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportMaterialPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportMaterialPriceList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportMaterialPriceList.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReportMaterialPriceList.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnReportMaterialPriceList.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportMaterialPriceList.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportMaterialPriceList.IconSize = 28
        Me.btnReportMaterialPriceList.Location = New System.Drawing.Point(80, 2)
        Me.btnReportMaterialPriceList.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnReportMaterialPriceList.Name = "btnReportMaterialPriceList"
        Me.btnReportMaterialPriceList.Size = New System.Drawing.Size(28, 28)
        Me.btnReportMaterialPriceList.TabIndex = 9
        Me.btnReportMaterialPriceList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportMaterialPriceList.UseVisualStyleBackColor = False
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
        Me.btnMaterialType.TabIndex = 8
        Me.btnMaterialType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaterialType.UseVisualStyleBackColor = False
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
        Me.btnDataSource.TabIndex = 6
        Me.btnDataSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDataSource.UseVisualStyleBackColor = False
        '
        'btnGuardar2
        '
        Me.btnGuardar2.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar2.FlatAppearance.BorderSize = 0
        Me.btnGuardar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar2.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar2.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar2.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar2.IconSize = 28
        Me.btnGuardar2.Location = New System.Drawing.Point(152, 2)
        Me.btnGuardar2.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnGuardar2.Name = "btnGuardar2"
        Me.btnGuardar2.Size = New System.Drawing.Size(28, 28)
        Me.btnGuardar2.TabIndex = 7
        Me.btnGuardar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar2.UseVisualStyleBackColor = False
        '
        'FormMaterialPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 633)
        Me.Controls.Add(Me.tlpHeaderButton)
        Me.Controls.Add(Me.splitContMaterial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormMaterialPrice"
        Me.Text = "FormMaterialPrice"
        Me.tlpEditionPriceMaterial.ResumeLayout(False)
        Me.tlpListMaterial.ResumeLayout(False)
        Me.tlpMaterialLook.ResumeLayout(False)
        Me.splitContMaterial.Panel1.ResumeLayout(False)
        Me.splitContMaterial.Panel2.ResumeLayout(False)
        CType(Me.splitContMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContMaterial.ResumeLayout(False)
        Me.tlpHeaderButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents tlpEditionPriceMaterial As TableLayoutPanel
    Friend WithEvents tlpListMaterial As TableLayoutPanel
    Friend WithEvents splitContMaterial As SplitContainer
    Friend WithEvents tlpMaterialLook As TableLayoutPanel
    Friend WithEvents btnMaterialFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpListUnit As TableLayoutPanel
    Friend WithEvents tlpEditionPriceMaterial2 As TableLayoutPanel
    Friend WithEvents tlpHeaderButton As TableLayoutPanel
    Friend WithEvents btnDataSource As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGuardar2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaterialType As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReportMaterialPriceList As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaterialPriceList As FontAwesome.Sharp.IconButton
End Class
