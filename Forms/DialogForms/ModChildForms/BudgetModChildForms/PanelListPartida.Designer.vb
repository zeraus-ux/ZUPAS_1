<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelListPartida
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
        Me.tlpPartidaLook = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListPartida = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpPartidaLook.SuspendLayout()
        Me.tlpListPartida.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMaterialFilter
        '
        Me.btnMaterialFilter.AutoSize = True
        Me.btnMaterialFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaterialFilter.FlatAppearance.BorderSize = 0
        Me.btnMaterialFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaterialFilter.ForeColor = System.Drawing.Color.Transparent
        Me.btnMaterialFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnMaterialFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnMaterialFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaterialFilter.IconSize = 28
        Me.btnMaterialFilter.Location = New System.Drawing.Point(470, 0)
        Me.btnMaterialFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMaterialFilter.Name = "btnMaterialFilter"
        Me.btnMaterialFilter.Size = New System.Drawing.Size(40, 30)
        Me.btnMaterialFilter.TabIndex = 0
        Me.btnMaterialFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaterialFilter.UseVisualStyleBackColor = True
        '
        'tlpPartidaLook
        '
        Me.tlpPartidaLook.ColumnCount = 2
        Me.tlpPartidaLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPartidaLook.Controls.Add(Me.btnMaterialFilter, 1, 0)
        Me.tlpPartidaLook.Location = New System.Drawing.Point(0, 70)
        Me.tlpPartidaLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPartidaLook.Name = "tlpPartidaLook"
        Me.tlpPartidaLook.RowCount = 1
        Me.tlpPartidaLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPartidaLook.Size = New System.Drawing.Size(510, 30)
        Me.tlpPartidaLook.TabIndex = 0
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
        Me.tlpListPartida.Size = New System.Drawing.Size(510, 691)
        Me.tlpListPartida.TabIndex = 3
        '
        'PanelListPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.tlpListPartida)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "PanelListPartida"
        Me.Size = New System.Drawing.Size(510, 691)
        Me.tlpPartidaLook.ResumeLayout(False)
        Me.tlpPartidaLook.PerformLayout()
        Me.tlpListPartida.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMaterialFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpPartidaLook As TableLayoutPanel
    Friend WithEvents tlpListPartida As TableLayoutPanel
End Class
