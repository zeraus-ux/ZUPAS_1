<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMateriaModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMateriaModal))
        Me.tlpEdicionMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlplEditionMaterial2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpEdicionMaterial.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpEdicionMaterial
        '
        Me.tlpEdicionMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEdicionMaterial.ColumnCount = 1
        Me.tlpEdicionMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionMaterial.Controls.Add(Me.PanelButton, 0, 2)
        Me.tlpEdicionMaterial.Controls.Add(Me.tlplEditionMaterial2, 0, 1)
        Me.tlpEdicionMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEdicionMaterial.Location = New System.Drawing.Point(0, 0)
        Me.tlpEdicionMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEdicionMaterial.Name = "tlpEdicionMaterial"
        Me.tlpEdicionMaterial.RowCount = 3
        Me.tlpEdicionMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEdicionMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEdicionMaterial.Size = New System.Drawing.Size(989, 615)
        Me.tlpEdicionMaterial.TabIndex = 1
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.btnGuardar)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelButton.Location = New System.Drawing.Point(0, 567)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(989, 48)
        Me.PanelButton.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.IconSize = 28
        Me.btnGuardar.Location = New System.Drawing.Point(896, 8)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlplEditionMaterial2
        '
        Me.tlplEditionMaterial2.ColumnCount = 2
        Me.tlplEditionMaterial2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlplEditionMaterial2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlplEditionMaterial2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlplEditionMaterial2.Location = New System.Drawing.Point(0, 40)
        Me.tlplEditionMaterial2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlplEditionMaterial2.Name = "tlplEditionMaterial2"
        Me.tlplEditionMaterial2.RowCount = 6
        Me.tlplEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlplEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlplEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionMaterial2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionMaterial2.Size = New System.Drawing.Size(989, 270)
        Me.tlplEditionMaterial2.TabIndex = 9
        '
        'FormMateriaModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 615)
        Me.Controls.Add(Me.tlpEdicionMaterial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMateriaModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormMateriaModal"
        Me.tlpEdicionMaterial.ResumeLayout(False)
        Me.PanelButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpEdicionMaterial As TableLayoutPanel
    Friend WithEvents PanelButton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlplEditionMaterial2 As TableLayoutPanel
End Class
