<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelListMaterialPrice
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
        Me.btnMaterialFilter = New FontAwesome.Sharp.IconButton()
        Me.tlpMaterialLook = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMaterialLook.SuspendLayout()
        Me.tlpListMaterial.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnMaterialFilter.Location = New System.Drawing.Point(599, 4)
        Me.btnMaterialFilter.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnMaterialFilter.Name = "btnMaterialFilter"
        Me.btnMaterialFilter.Size = New System.Drawing.Size(40, 26)
        Me.btnMaterialFilter.TabIndex = 0
        Me.btnMaterialFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaterialFilter.UseVisualStyleBackColor = True
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
        Me.tlpMaterialLook.Size = New System.Drawing.Size(639, 30)
        Me.tlpMaterialLook.TabIndex = 0
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
        Me.tlpListMaterial.Size = New System.Drawing.Size(639, 542)
        Me.tlpListMaterial.TabIndex = 3
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpListMaterial)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(639, 542)
        Me.tlpMaterialLook.ResumeLayout(False)
        Me.tlpListMaterial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMaterialFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpMaterialLook As TableLayoutPanel
    Friend WithEvents tlpListMaterial As TableLayoutPanel
End Class
