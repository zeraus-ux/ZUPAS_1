<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelListEquipment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tlpListEquipment = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpEquipmentLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEquipmentFilter = New FontAwesome.Sharp.IconButton()
        Me.tlpListEquipment.SuspendLayout()
        Me.tlpEquipmentLook.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpListEquipment
        '
        Me.tlpListEquipment.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListEquipment.ColumnCount = 1
        Me.tlpListEquipment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListEquipment.Controls.Add(Me.tlpEquipmentLook, 0, 3)
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
        Me.tlpListEquipment.Size = New System.Drawing.Size(466, 668)
        Me.tlpListEquipment.TabIndex = 1
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
        Me.tlpEquipmentLook.Size = New System.Drawing.Size(466, 30)
        Me.tlpEquipmentLook.TabIndex = 0
        '
        'btnEquipmentFilter
        '
        Me.btnEquipmentFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEquipmentFilter.FlatAppearance.BorderSize = 0
        Me.btnEquipmentFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquipmentFilter.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEquipmentFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnEquipmentFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnEquipmentFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEquipmentFilter.IconSize = 28
        Me.btnEquipmentFilter.Location = New System.Drawing.Point(426, 4)
        Me.btnEquipmentFilter.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnEquipmentFilter.Name = "btnEquipmentFilter"
        Me.btnEquipmentFilter.Size = New System.Drawing.Size(40, 26)
        Me.btnEquipmentFilter.TabIndex = 0
        Me.btnEquipmentFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEquipmentFilter.UseVisualStyleBackColor = True
        '
        'PanelListEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpListEquipment)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "PanelListEquipment"
        Me.Size = New System.Drawing.Size(466, 668)
        Me.tlpListEquipment.ResumeLayout(False)
        Me.tlpEquipmentLook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpListEquipment As TableLayoutPanel
    Friend WithEvents tlpEquipmentLook As TableLayoutPanel
    Friend WithEvents btnEquipmentFilter As FontAwesome.Sharp.IconButton
End Class
