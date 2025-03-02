<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormObraCost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormObraCost))
        Me.tlpCostos = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelBoutton = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.tlpCostos.SuspendLayout()
        Me.PanelBoutton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpCostos
        '
        Me.tlpCostos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tlpCostos.ColumnCount = 1
        Me.tlpCostos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCostos.Controls.Add(Me.PanelBoutton, 0, 1)
        Me.tlpCostos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCostos.Location = New System.Drawing.Point(0, 0)
        Me.tlpCostos.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCostos.Name = "tlpCostos"
        Me.tlpCostos.RowCount = 2
        Me.tlpCostos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCostos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCostos.Size = New System.Drawing.Size(634, 326)
        Me.tlpCostos.TabIndex = 0
        '
        'PanelBoutton
        '
        Me.PanelBoutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelBoutton.Controls.Add(Me.btnCerrar)
        Me.PanelBoutton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBoutton.Location = New System.Drawing.Point(0, 278)
        Me.PanelBoutton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBoutton.Name = "PanelBoutton"
        Me.PanelBoutton.Size = New System.Drawing.Size(634, 48)
        Me.PanelBoutton.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Cancel
        Me.btnCerrar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCerrar.IconSize = 28
        Me.btnCerrar.Location = New System.Drawing.Point(541, 8)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(85, 32)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'FormObraCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(634, 326)
        Me.Controls.Add(Me.tlpCostos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 365)
        Me.Name = "FormObraCost"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Costos Directos e Indirectos"
        Me.TopMost = True
        Me.tlpCostos.ResumeLayout(False)
        Me.PanelBoutton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpCostos As TableLayoutPanel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelBoutton As Panel
End Class
