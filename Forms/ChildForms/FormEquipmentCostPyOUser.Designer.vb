<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEquipmentCostPyOUser
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
        Me.tlpEquipmentEdition = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpEquipmentEdition2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEqmtPriceEstReset = New FontAwesome.Sharp.IconButton()
        Me.btnEqmtPriceEst = New FontAwesome.Sharp.IconButton()
        Me.tlpListEquipment = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListUnit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpEquipmentLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEquipmentFilter = New FontAwesome.Sharp.IconButton()
        Me.splitContEquipment = New System.Windows.Forms.SplitContainer()
        Me.tlpHeaderButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEquipmentType = New FontAwesome.Sharp.IconButton()
        Me.btnDataSource = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar1 = New FontAwesome.Sharp.IconButton()
        Me.btnequipmentCostPyOUserList = New FontAwesome.Sharp.IconButton()
        Me.btnReportequipmentCostPyOUserList = New FontAwesome.Sharp.IconButton()
        Me.tlpEquipmentEdition.SuspendLayout()
        Me.tlpEquipmentEdition2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpListEquipment.SuspendLayout()
        Me.tlpEquipmentLook.SuspendLayout()
        CType(Me.splitContEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContEquipment.Panel1.SuspendLayout()
        Me.splitContEquipment.Panel2.SuspendLayout()
        Me.splitContEquipment.SuspendLayout()
        Me.tlpHeaderButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBotton
        '
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 587)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(469, 48)
        Me.PanelBotton.TabIndex = 6
        '
        'tlpEquipmentEdition
        '
        Me.tlpEquipmentEdition.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEquipmentEdition.ColumnCount = 1
        Me.tlpEquipmentEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipmentEdition.Controls.Add(Me.PanelBotton, 0, 2)
        Me.tlpEquipmentEdition.Controls.Add(Me.tlpEquipmentEdition2, 0, 1)
        Me.tlpEquipmentEdition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEquipmentEdition.Location = New System.Drawing.Point(0, 0)
        Me.tlpEquipmentEdition.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEquipmentEdition.Name = "tlpEquipmentEdition"
        Me.tlpEquipmentEdition.RowCount = 3
        Me.tlpEquipmentEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEquipmentEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipmentEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEquipmentEdition.Size = New System.Drawing.Size(469, 635)
        Me.tlpEquipmentEdition.TabIndex = 0
        '
        'tlpEquipmentEdition2
        '
        Me.tlpEquipmentEdition2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpEquipmentEdition2.ColumnCount = 2
        Me.tlpEquipmentEdition2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEquipmentEdition2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipmentEdition2.Controls.Add(Me.TableLayoutPanel1, 1, 1)
        Me.tlpEquipmentEdition2.Location = New System.Drawing.Point(0, 40)
        Me.tlpEquipmentEdition2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEquipmentEdition2.Name = "tlpEquipmentEdition2"
        Me.tlpEquipmentEdition2.RowCount = 6
        Me.tlpEquipmentEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEquipmentEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipmentEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipmentEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipmentEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipmentEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipmentEdition2.Size = New System.Drawing.Size(469, 547)
        Me.tlpEquipmentEdition2.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEqmtPriceEstReset, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEqmtPriceEst, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(130, 60)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(339, 30)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnEqmtPriceEstReset
        '
        Me.btnEqmtPriceEstReset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEqmtPriceEstReset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEqmtPriceEstReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnEqmtPriceEstReset.FlatAppearance.BorderSize = 0
        Me.btnEqmtPriceEstReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnEqmtPriceEstReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnEqmtPriceEstReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEqmtPriceEstReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqmtPriceEstReset.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEqmtPriceEstReset.IconChar = FontAwesome.Sharp.IconChar.Repeat
        Me.btnEqmtPriceEstReset.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnEqmtPriceEstReset.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEqmtPriceEstReset.IconSize = 28
        Me.btnEqmtPriceEstReset.Location = New System.Drawing.Point(303, 3)
        Me.btnEqmtPriceEstReset.Margin = New System.Windows.Forms.Padding(0, 3, 8, 3)
        Me.btnEqmtPriceEstReset.Name = "btnEqmtPriceEstReset"
        Me.btnEqmtPriceEstReset.Size = New System.Drawing.Size(28, 24)
        Me.btnEqmtPriceEstReset.TabIndex = 10
        Me.btnEqmtPriceEstReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEqmtPriceEstReset.UseVisualStyleBackColor = False
        '
        'btnEqmtPriceEst
        '
        Me.btnEqmtPriceEst.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEqmtPriceEst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEqmtPriceEst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnEqmtPriceEst.FlatAppearance.BorderSize = 0
        Me.btnEqmtPriceEst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnEqmtPriceEst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnEqmtPriceEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEqmtPriceEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqmtPriceEst.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEqmtPriceEst.IconChar = FontAwesome.Sharp.IconChar.Donate
        Me.btnEqmtPriceEst.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnEqmtPriceEst.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEqmtPriceEst.IconSize = 28
        Me.btnEqmtPriceEst.Location = New System.Drawing.Point(267, 3)
        Me.btnEqmtPriceEst.Margin = New System.Windows.Forms.Padding(0, 3, 8, 3)
        Me.btnEqmtPriceEst.Name = "btnEqmtPriceEst"
        Me.btnEqmtPriceEst.Size = New System.Drawing.Size(28, 24)
        Me.btnEqmtPriceEst.TabIndex = 9
        Me.btnEqmtPriceEst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEqmtPriceEst.UseVisualStyleBackColor = False
        '
        'tlpListEquipment
        '
        Me.tlpListEquipment.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListEquipment.ColumnCount = 1
        Me.tlpListEquipment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListEquipment.Controls.Add(Me.tlpListUnit, 0, 4)
        Me.tlpListEquipment.Controls.Add(Me.tlpEquipmentLook, 0, 3)
        Me.tlpListEquipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListEquipment.Location = New System.Drawing.Point(0, 0)
        Me.tlpListEquipment.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListEquipment.Name = "tlpListEquipment"
        Me.tlpListEquipment.RowCount = 6
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListEquipment.Size = New System.Drawing.Size(529, 635)
        Me.tlpListEquipment.TabIndex = 0
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
        Me.tlpListUnit.Size = New System.Drawing.Size(529, 30)
        Me.tlpListUnit.TabIndex = 3
        '
        'tlpEquipmentLook
        '
        Me.tlpEquipmentLook.ColumnCount = 2
        Me.tlpEquipmentLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipmentLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEquipmentLook.Controls.Add(Me.btnEquipmentFilter, 1, 0)
        Me.tlpEquipmentLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEquipmentLook.Location = New System.Drawing.Point(0, 100)
        Me.tlpEquipmentLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEquipmentLook.Name = "tlpEquipmentLook"
        Me.tlpEquipmentLook.RowCount = 1
        Me.tlpEquipmentLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipmentLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipmentLook.Size = New System.Drawing.Size(529, 30)
        Me.tlpEquipmentLook.TabIndex = 2
        '
        'btnEquipmentFilter
        '
        Me.btnEquipmentFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEquipmentFilter.FlatAppearance.BorderSize = 0
        Me.btnEquipmentFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEquipmentFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEquipmentFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquipmentFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnEquipmentFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnEquipmentFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEquipmentFilter.IconSize = 28
        Me.btnEquipmentFilter.Location = New System.Drawing.Point(489, 0)
        Me.btnEquipmentFilter.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.btnEquipmentFilter.Name = "btnEquipmentFilter"
        Me.btnEquipmentFilter.Size = New System.Drawing.Size(32, 22)
        Me.btnEquipmentFilter.TabIndex = 0
        Me.btnEquipmentFilter.UseVisualStyleBackColor = True
        '
        'splitContEquipment
        '
        Me.splitContEquipment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContEquipment.Location = New System.Drawing.Point(0, 33)
        Me.splitContEquipment.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContEquipment.Name = "splitContEquipment"
        '
        'splitContEquipment.Panel1
        '
        Me.splitContEquipment.Panel1.Controls.Add(Me.tlpListEquipment)
        '
        'splitContEquipment.Panel2
        '
        Me.splitContEquipment.Panel2.Controls.Add(Me.tlpEquipmentEdition)
        Me.splitContEquipment.Size = New System.Drawing.Size(1002, 635)
        Me.splitContEquipment.SplitterDistance = 529
        Me.splitContEquipment.TabIndex = 2
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
        Me.tlpHeaderButton.Controls.Add(Me.btnEquipmentType, 0, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnDataSource, 0, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnGuardar1, 4, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnequipmentCostPyOUserList, 3, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnReportequipmentCostPyOUserList, 2, 0)
        Me.tlpHeaderButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpHeaderButton.Location = New System.Drawing.Point(0, 0)
        Me.tlpHeaderButton.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpHeaderButton.Name = "tlpHeaderButton"
        Me.tlpHeaderButton.RowCount = 1
        Me.tlpHeaderButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpHeaderButton.Size = New System.Drawing.Size(1002, 30)
        Me.tlpHeaderButton.TabIndex = 3
        '
        'btnEquipmentType
        '
        Me.btnEquipmentType.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEquipmentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEquipmentType.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnEquipmentType.FlatAppearance.BorderSize = 0
        Me.btnEquipmentType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnEquipmentType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnEquipmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquipmentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquipmentType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEquipmentType.IconChar = FontAwesome.Sharp.IconChar.T
        Me.btnEquipmentType.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnEquipmentType.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEquipmentType.IconSize = 28
        Me.btnEquipmentType.Location = New System.Drawing.Point(44, 2)
        Me.btnEquipmentType.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnEquipmentType.Name = "btnEquipmentType"
        Me.btnEquipmentType.Size = New System.Drawing.Size(28, 28)
        Me.btnEquipmentType.TabIndex = 9
        Me.btnEquipmentType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEquipmentType.UseVisualStyleBackColor = False
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
        Me.btnDataSource.TabIndex = 4
        Me.btnDataSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDataSource.UseVisualStyleBackColor = False
        '
        'btnGuardar1
        '
        Me.btnGuardar1.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar1.FlatAppearance.BorderSize = 0
        Me.btnGuardar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar1.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar1.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar1.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar1.IconSize = 28
        Me.btnGuardar1.Location = New System.Drawing.Point(152, 2)
        Me.btnGuardar1.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(28, 28)
        Me.btnGuardar1.TabIndex = 6
        Me.btnGuardar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar1.UseVisualStyleBackColor = False
        '
        'btnequipmentCostPyOUserList
        '
        Me.btnequipmentCostPyOUserList.BackColor = System.Drawing.Color.Gainsboro
        Me.btnequipmentCostPyOUserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnequipmentCostPyOUserList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnequipmentCostPyOUserList.FlatAppearance.BorderSize = 0
        Me.btnequipmentCostPyOUserList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnequipmentCostPyOUserList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnequipmentCostPyOUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnequipmentCostPyOUserList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnequipmentCostPyOUserList.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnequipmentCostPyOUserList.IconChar = FontAwesome.Sharp.IconChar.Coins
        Me.btnequipmentCostPyOUserList.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnequipmentCostPyOUserList.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnequipmentCostPyOUserList.IconSize = 28
        Me.btnequipmentCostPyOUserList.Location = New System.Drawing.Point(116, 2)
        Me.btnequipmentCostPyOUserList.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnequipmentCostPyOUserList.Name = "btnequipmentCostPyOUserList"
        Me.btnequipmentCostPyOUserList.Size = New System.Drawing.Size(28, 28)
        Me.btnequipmentCostPyOUserList.TabIndex = 7
        Me.btnequipmentCostPyOUserList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnequipmentCostPyOUserList.UseVisualStyleBackColor = False
        '
        'btnReportequipmentCostPyOUserList
        '
        Me.btnReportequipmentCostPyOUserList.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReportequipmentCostPyOUserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReportequipmentCostPyOUserList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportequipmentCostPyOUserList.FlatAppearance.BorderSize = 0
        Me.btnReportequipmentCostPyOUserList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportequipmentCostPyOUserList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportequipmentCostPyOUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportequipmentCostPyOUserList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportequipmentCostPyOUserList.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnReportequipmentCostPyOUserList.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnReportequipmentCostPyOUserList.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportequipmentCostPyOUserList.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportequipmentCostPyOUserList.IconSize = 28
        Me.btnReportequipmentCostPyOUserList.Location = New System.Drawing.Point(80, 2)
        Me.btnReportequipmentCostPyOUserList.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnReportequipmentCostPyOUserList.Name = "btnReportequipmentCostPyOUserList"
        Me.btnReportequipmentCostPyOUserList.Size = New System.Drawing.Size(28, 28)
        Me.btnReportequipmentCostPyOUserList.TabIndex = 8
        Me.btnReportequipmentCostPyOUserList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportequipmentCostPyOUserList.UseVisualStyleBackColor = False
        '
        'FormEquipmentCostPyOUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 668)
        Me.Controls.Add(Me.tlpHeaderButton)
        Me.Controls.Add(Me.splitContEquipment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEquipmentCostPyOUser"
        Me.Text = "FormEquipmenPrice"
        Me.tlpEquipmentEdition.ResumeLayout(False)
        Me.tlpEquipmentEdition2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tlpListEquipment.ResumeLayout(False)
        Me.tlpEquipmentLook.ResumeLayout(False)
        Me.splitContEquipment.Panel1.ResumeLayout(False)
        Me.splitContEquipment.Panel2.ResumeLayout(False)
        CType(Me.splitContEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContEquipment.ResumeLayout(False)
        Me.tlpHeaderButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents tlpEquipmentEdition As TableLayoutPanel
    Friend WithEvents tlpListEquipment As TableLayoutPanel
    Friend WithEvents splitContEquipment As SplitContainer
    Friend WithEvents tlpEquipmentLook As TableLayoutPanel
    Friend WithEvents btnEquipmentFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpListUnit As TableLayoutPanel
    Friend WithEvents tlpEquipmentEdition2 As TableLayoutPanel
    Friend WithEvents tlpHeaderButton As TableLayoutPanel
    Friend WithEvents btnDataSource As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGuardar1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnequipmentCostPyOUserList As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReportequipmentCostPyOUserList As FontAwesome.Sharp.IconButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnEqmtPriceEstReset As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEqmtPriceEst As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEquipmentType As FontAwesome.Sharp.IconButton
End Class
