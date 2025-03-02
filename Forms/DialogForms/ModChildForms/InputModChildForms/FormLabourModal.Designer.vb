<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLabourModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLabourModal))
        Me.tlpEdicionLabour = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlplEditionLabour2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpEdicionLabour.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpEdicionLabour
        '
        Me.tlpEdicionLabour.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEdicionLabour.ColumnCount = 1
        Me.tlpEdicionLabour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionLabour.Controls.Add(Me.PanelButton, 0, 2)
        Me.tlpEdicionLabour.Controls.Add(Me.tlplEditionLabour2, 0, 1)
        Me.tlpEdicionLabour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEdicionLabour.Location = New System.Drawing.Point(0, 0)
        Me.tlpEdicionLabour.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEdicionLabour.Name = "tlpEdicionLabour"
        Me.tlpEdicionLabour.RowCount = 3
        Me.tlpEdicionLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEdicionLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEdicionLabour.Size = New System.Drawing.Size(800, 450)
        Me.tlpEdicionLabour.TabIndex = 3
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.btnGuardar)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelButton.Location = New System.Drawing.Point(0, 402)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(800, 48)
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
        Me.btnGuardar.IconSize = 20
        Me.btnGuardar.Location = New System.Drawing.Point(707, 8)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlplEditionLabour2
        '
        Me.tlplEditionLabour2.ColumnCount = 2
        Me.tlplEditionLabour2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlplEditionLabour2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlplEditionLabour2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlplEditionLabour2.Location = New System.Drawing.Point(0, 40)
        Me.tlplEditionLabour2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlplEditionLabour2.Name = "tlplEditionLabour2"
        Me.tlplEditionLabour2.RowCount = 5
        Me.tlplEditionLabour2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionLabour2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlplEditionLabour2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlplEditionLabour2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionLabour2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplEditionLabour2.Size = New System.Drawing.Size(800, 240)
        Me.tlplEditionLabour2.TabIndex = 9
        '
        'FormLabourModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpEdicionLabour)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLabourModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormLabourModal"
        Me.tlpEdicionLabour.ResumeLayout(False)
        Me.PanelButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpEdicionLabour As TableLayoutPanel
    Friend WithEvents PanelButton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlplEditionLabour2 As TableLayoutPanel
End Class
