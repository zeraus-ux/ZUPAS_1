<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEquipment
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
        Me.splitContEqupment = New System.Windows.Forms.SplitContainer()
        Me.tlpListEquipment = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpEquipmentLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEquipmentFilter = New FontAwesome.Sharp.IconButton()
        Me.tlpEquipment = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.tlpEquipment2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpHeaderButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCompoundEquipment = New FontAwesome.Sharp.IconButton()
        Me.btnDataSource = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        CType(Me.splitContEqupment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContEqupment.Panel1.SuspendLayout()
        Me.splitContEqupment.Panel2.SuspendLayout()
        Me.splitContEqupment.SuspendLayout()
        Me.tlpListEquipment.SuspendLayout()
        Me.tlpEquipmentLook.SuspendLayout()
        Me.tlpEquipment.SuspendLayout()
        Me.tlpHeaderButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContEqupment
        '
        Me.splitContEqupment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContEqupment.Location = New System.Drawing.Point(0, 30)
        Me.splitContEqupment.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContEqupment.Name = "splitContEqupment"
        '
        'splitContEqupment.Panel1
        '
        Me.splitContEqupment.Panel1.Controls.Add(Me.tlpListEquipment)
        '
        'splitContEqupment.Panel2
        '
        Me.splitContEqupment.Panel2.Controls.Add(Me.tlpEquipment)
        Me.splitContEqupment.Size = New System.Drawing.Size(992, 565)
        Me.splitContEqupment.SplitterDistance = 323
        Me.splitContEqupment.TabIndex = 1
        '
        'tlpListEquipment
        '
        Me.tlpListEquipment.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListEquipment.ColumnCount = 1
        Me.tlpListEquipment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListEquipment.Controls.Add(Me.tlpEquipmentLook, 0, 2)
        Me.tlpListEquipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListEquipment.Location = New System.Drawing.Point(0, 0)
        Me.tlpListEquipment.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListEquipment.Name = "tlpListEquipment"
        Me.tlpListEquipment.RowCount = 5
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListEquipment.Size = New System.Drawing.Size(323, 565)
        Me.tlpListEquipment.TabIndex = 0
        '
        'tlpEquipmentLook
        '
        Me.tlpEquipmentLook.ColumnCount = 2
        Me.tlpEquipmentLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipmentLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEquipmentLook.Controls.Add(Me.btnEquipmentFilter, 1, 0)
        Me.tlpEquipmentLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEquipmentLook.Location = New System.Drawing.Point(0, 70)
        Me.tlpEquipmentLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEquipmentLook.Name = "tlpEquipmentLook"
        Me.tlpEquipmentLook.RowCount = 1
        Me.tlpEquipmentLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipmentLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipmentLook.Size = New System.Drawing.Size(323, 30)
        Me.tlpEquipmentLook.TabIndex = 0
        '
        'btnEquipmentFilter
        '
        Me.btnEquipmentFilter.FlatAppearance.BorderSize = 0
        Me.btnEquipmentFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquipmentFilter.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEquipmentFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnEquipmentFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnEquipmentFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEquipmentFilter.IconSize = 28
        Me.btnEquipmentFilter.Location = New System.Drawing.Point(283, 0)
        Me.btnEquipmentFilter.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.btnEquipmentFilter.Name = "btnEquipmentFilter"
        Me.btnEquipmentFilter.Size = New System.Drawing.Size(32, 22)
        Me.btnEquipmentFilter.TabIndex = 0
        Me.btnEquipmentFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEquipmentFilter.UseVisualStyleBackColor = True
        '
        'tlpEquipment
        '
        Me.tlpEquipment.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEquipment.ColumnCount = 1
        Me.tlpEquipment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipment.Controls.Add(Me.PanelBotton, 0, 2)
        Me.tlpEquipment.Controls.Add(Me.tlpEquipment2, 0, 1)
        Me.tlpEquipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEquipment.Location = New System.Drawing.Point(0, 0)
        Me.tlpEquipment.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEquipment.Name = "tlpEquipment"
        Me.tlpEquipment.RowCount = 3
        Me.tlpEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEquipment.Size = New System.Drawing.Size(665, 565)
        Me.tlpEquipment.TabIndex = 0
        '
        'PanelBotton
        '
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 517)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(665, 48)
        Me.PanelBotton.TabIndex = 6
        '
        'tlpEquipment2
        '
        Me.tlpEquipment2.ColumnCount = 2
        Me.tlpEquipment2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEquipment2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEquipment2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEquipment2.Location = New System.Drawing.Point(0, 40)
        Me.tlpEquipment2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEquipment2.Name = "tlpEquipment2"
        Me.tlpEquipment2.RowCount = 7
        Me.tlpEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEquipment2.Size = New System.Drawing.Size(665, 270)
        Me.tlpEquipment2.TabIndex = 7
        '
        'tlpHeaderButton
        '
        Me.tlpHeaderButton.BackColor = System.Drawing.Color.Gainsboro
        Me.tlpHeaderButton.ColumnCount = 4
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpHeaderButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHeaderButton.Controls.Add(Me.btnCompoundEquipment, 0, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnDataSource, 0, 0)
        Me.tlpHeaderButton.Controls.Add(Me.btnGuardar, 2, 0)
        Me.tlpHeaderButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpHeaderButton.Location = New System.Drawing.Point(0, 0)
        Me.tlpHeaderButton.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpHeaderButton.Name = "tlpHeaderButton"
        Me.tlpHeaderButton.RowCount = 1
        Me.tlpHeaderButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpHeaderButton.Size = New System.Drawing.Size(992, 30)
        Me.tlpHeaderButton.TabIndex = 2
        '
        'btnCompoundEquipment
        '
        Me.btnCompoundEquipment.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCompoundEquipment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCompoundEquipment.FlatAppearance.BorderSize = 0
        Me.btnCompoundEquipment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCompoundEquipment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCompoundEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompoundEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompoundEquipment.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCompoundEquipment.IconChar = FontAwesome.Sharp.IconChar.Cubes
        Me.btnCompoundEquipment.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCompoundEquipment.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCompoundEquipment.IconSize = 28
        Me.btnCompoundEquipment.Location = New System.Drawing.Point(44, 2)
        Me.btnCompoundEquipment.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnCompoundEquipment.Name = "btnCompoundEquipment"
        Me.btnCompoundEquipment.Size = New System.Drawing.Size(27, 27)
        Me.btnCompoundEquipment.TabIndex = 5
        Me.btnCompoundEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompoundEquipment.UseVisualStyleBackColor = False
        '
        'btnDataSource
        '
        Me.btnDataSource.BackColor = System.Drawing.Color.Gainsboro
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
        Me.btnDataSource.Size = New System.Drawing.Size(27, 27)
        Me.btnDataSource.TabIndex = 4
        Me.btnDataSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDataSource.UseVisualStyleBackColor = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(80, 2)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(28, 28)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'FormEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 595)
        Me.Controls.Add(Me.tlpHeaderButton)
        Me.Controls.Add(Me.splitContEqupment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEquipment"
        Me.Text = "FormEquipment"
        Me.splitContEqupment.Panel1.ResumeLayout(False)
        Me.splitContEqupment.Panel2.ResumeLayout(False)
        CType(Me.splitContEqupment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContEqupment.ResumeLayout(False)
        Me.tlpListEquipment.ResumeLayout(False)
        Me.tlpEquipmentLook.ResumeLayout(False)
        Me.tlpEquipment.ResumeLayout(False)
        Me.tlpHeaderButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContEqupment As SplitContainer
    Friend WithEvents tlpEquipment As TableLayoutPanel
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents tlpListEquipment As TableLayoutPanel
    Friend WithEvents tlpEquipmentLook As TableLayoutPanel
    Friend WithEvents btnEquipmentFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpEquipment2 As TableLayoutPanel
    Friend WithEvents tlpHeaderButton As TableLayoutPanel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDataSource As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCompoundEquipment As FontAwesome.Sharp.IconButton
End Class
