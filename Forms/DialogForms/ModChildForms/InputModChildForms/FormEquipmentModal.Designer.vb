<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEquipmentModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEquipmentModal))
        Me.tlpEdicionEquipment = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlplEditionEquipment2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpEdicionEquipment.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpEdicionEquipment
        '
        Me.tlpEdicionEquipment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpEdicionEquipment.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEdicionEquipment.ColumnCount = 1
        Me.tlpEdicionEquipment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionEquipment.Controls.Add(Me.PanelButton, 0, 2)
        Me.tlpEdicionEquipment.Controls.Add(Me.tlplEditionEquipment2, 0, 1)
        Me.tlpEdicionEquipment.Location = New System.Drawing.Point(0, 0)
        Me.tlpEdicionEquipment.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEdicionEquipment.Name = "tlpEdicionEquipment"
        Me.tlpEdicionEquipment.RowCount = 3
        Me.tlpEdicionEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEdicionEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionEquipment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEdicionEquipment.Size = New System.Drawing.Size(800, 450)
        Me.tlpEdicionEquipment.TabIndex = 2
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.btnGuardar)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelButton.Location = New System.Drawing.Point(0, 410)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(800, 40)
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
        Me.btnGuardar.Location = New System.Drawing.Point(707, 4)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 35)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlplEditionEquipment2
        '
        Me.tlplEditionEquipment2.ColumnCount = 2
        Me.tlplEditionEquipment2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlplEditionEquipment2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlplEditionEquipment2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlplEditionEquipment2.Location = New System.Drawing.Point(0, 40)
        Me.tlplEditionEquipment2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlplEditionEquipment2.Name = "tlplEditionEquipment2"
        Me.tlplEditionEquipment2.RowCount = 6
        Me.tlplEditionEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlplEditionEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlplEditionEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionEquipment2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionEquipment2.Size = New System.Drawing.Size(800, 270)
        Me.tlplEditionEquipment2.TabIndex = 9
        '
        'FormEquipmentModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpEdicionEquipment)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEquipmentModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormEquipmentModal"
        Me.tlpEdicionEquipment.ResumeLayout(False)
        Me.PanelButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpEdicionEquipment As TableLayoutPanel
    Friend WithEvents PanelButton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlplEditionEquipment2 As TableLayoutPanel
End Class
