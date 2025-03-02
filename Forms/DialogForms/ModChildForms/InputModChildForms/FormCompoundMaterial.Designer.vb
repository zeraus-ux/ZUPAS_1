<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCompoundMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompoundMaterial))
        Me.PanelHeader2 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.tlpCompoundMaterialEdit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCMEdit1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCMEdit2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCMEditLbl2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCMEditTex2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCMEdit3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.scCompoundMaterial = New System.Windows.Forms.SplitContainer()
        Me.PanelFoot = New System.Windows.Forms.Panel()
        Me.scParent = New System.Windows.Forms.SplitContainer()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.tlpCompoundMaterialEdit.SuspendLayout()
        Me.tlpCMEdit1.SuspendLayout()
        Me.tlpCMEdit2.SuspendLayout()
        CType(Me.scCompoundMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scCompoundMaterial.SuspendLayout()
        Me.PanelFoot.SuspendLayout()
        CType(Me.scParent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scParent.Panel1.SuspendLayout()
        Me.scParent.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader2
        '
        Me.PanelHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader2.Location = New System.Drawing.Point(0, 30)
        Me.PanelHeader2.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelHeader2.Name = "PanelHeader2"
        Me.PanelHeader2.Size = New System.Drawing.Size(1297, 37)
        Me.PanelHeader2.TabIndex = 6
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
        Me.btnCerrar.Location = New System.Drawing.Point(643, 8)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(85, 32)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'tlpCompoundMaterialEdit
        '
        Me.tlpCompoundMaterialEdit.ColumnCount = 1
        Me.tlpCompoundMaterialEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCompoundMaterialEdit.Controls.Add(Me.tlpCMEdit1, 0, 0)
        Me.tlpCompoundMaterialEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpCompoundMaterialEdit.Location = New System.Drawing.Point(0, 0)
        Me.tlpCompoundMaterialEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCompoundMaterialEdit.Name = "tlpCompoundMaterialEdit"
        Me.tlpCompoundMaterialEdit.RowCount = 1
        Me.tlpCompoundMaterialEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCompoundMaterialEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.tlpCompoundMaterialEdit.Size = New System.Drawing.Size(736, 157)
        Me.tlpCompoundMaterialEdit.TabIndex = 0
        '
        'tlpCMEdit1
        '
        Me.tlpCMEdit1.ColumnCount = 2
        Me.tlpCMEdit1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.66848!))
        Me.tlpCMEdit1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.33152!))
        Me.tlpCMEdit1.Controls.Add(Me.tlpCMEdit2, 0, 0)
        Me.tlpCMEdit1.Controls.Add(Me.tlpCMEdit3, 1, 0)
        Me.tlpCMEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCMEdit1.Location = New System.Drawing.Point(0, 0)
        Me.tlpCMEdit1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCMEdit1.Name = "tlpCMEdit1"
        Me.tlpCMEdit1.RowCount = 1
        Me.tlpCMEdit1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCMEdit1.Size = New System.Drawing.Size(736, 157)
        Me.tlpCMEdit1.TabIndex = 2
        '
        'tlpCMEdit2
        '
        Me.tlpCMEdit2.ColumnCount = 2
        Me.tlpCMEdit2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpCMEdit2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCMEdit2.Controls.Add(Me.tlpCMEditLbl2, 0, 2)
        Me.tlpCMEdit2.Controls.Add(Me.tlpCMEditTex2, 1, 2)
        Me.tlpCMEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCMEdit2.Location = New System.Drawing.Point(0, 0)
        Me.tlpCMEdit2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCMEdit2.Name = "tlpCMEdit2"
        Me.tlpCMEdit2.RowCount = 3
        Me.tlpCMEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCMEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCMEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpCMEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCMEdit2.Size = New System.Drawing.Size(395, 157)
        Me.tlpCMEdit2.TabIndex = 0
        '
        'tlpCMEditLbl2
        '
        Me.tlpCMEditLbl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpCMEditLbl2.ColumnCount = 1
        Me.tlpCMEditLbl2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCMEditLbl2.Location = New System.Drawing.Point(0, 60)
        Me.tlpCMEditLbl2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCMEditLbl2.Name = "tlpCMEditLbl2"
        Me.tlpCMEditLbl2.RowCount = 3
        Me.tlpCMEditLbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCMEditLbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCMEditLbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCMEditLbl2.Size = New System.Drawing.Size(150, 90)
        Me.tlpCMEditLbl2.TabIndex = 0
        '
        'tlpCMEditTex2
        '
        Me.tlpCMEditTex2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpCMEditTex2.ColumnCount = 1
        Me.tlpCMEditTex2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCMEditTex2.Location = New System.Drawing.Point(150, 60)
        Me.tlpCMEditTex2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCMEditTex2.Name = "tlpCMEditTex2"
        Me.tlpCMEditTex2.RowCount = 3
        Me.tlpCMEditTex2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCMEditTex2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCMEditTex2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCMEditTex2.Size = New System.Drawing.Size(245, 90)
        Me.tlpCMEditTex2.TabIndex = 1
        '
        'tlpCMEdit3
        '
        Me.tlpCMEdit3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpCMEdit3.ColumnCount = 2
        Me.tlpCMEdit3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpCMEdit3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCMEdit3.Location = New System.Drawing.Point(395, 0)
        Me.tlpCMEdit3.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCMEdit3.Name = "tlpCMEdit3"
        Me.tlpCMEdit3.RowCount = 1
        Me.tlpCMEdit3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCMEdit3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpCMEdit3.Size = New System.Drawing.Size(341, 90)
        Me.tlpCMEdit3.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.IconSize = 28
        Me.btnGuardar.Location = New System.Drawing.Point(546, 8)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'scCompoundMaterial
        '
        Me.scCompoundMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scCompoundMaterial.Location = New System.Drawing.Point(0, 157)
        Me.scCompoundMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.scCompoundMaterial.Name = "scCompoundMaterial"
        '
        'scCompoundMaterial.Panel1
        '
        Me.scCompoundMaterial.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'scCompoundMaterial.Panel2
        '
        Me.scCompoundMaterial.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scCompoundMaterial.Size = New System.Drawing.Size(736, 446)
        Me.scCompoundMaterial.SplitterDistance = 390
        Me.scCompoundMaterial.TabIndex = 2
        '
        'PanelFoot
        '
        Me.PanelFoot.Controls.Add(Me.btnCerrar)
        Me.PanelFoot.Controls.Add(Me.btnGuardar)
        Me.PanelFoot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFoot.Location = New System.Drawing.Point(0, 603)
        Me.PanelFoot.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelFoot.Name = "PanelFoot"
        Me.PanelFoot.Size = New System.Drawing.Size(736, 48)
        Me.PanelFoot.TabIndex = 1
        '
        'scParent
        '
        Me.scParent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scParent.Location = New System.Drawing.Point(0, 72)
        Me.scParent.Margin = New System.Windows.Forms.Padding(0)
        Me.scParent.Name = "scParent"
        '
        'scParent.Panel1
        '
        Me.scParent.Panel1.Controls.Add(Me.scCompoundMaterial)
        Me.scParent.Panel1.Controls.Add(Me.PanelFoot)
        Me.scParent.Panel1.Controls.Add(Me.tlpCompoundMaterialEdit)
        '
        'scParent.Panel2
        '
        Me.scParent.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scParent.Size = New System.Drawing.Size(1297, 651)
        Me.scParent.SplitterDistance = 736
        Me.scParent.TabIndex = 5
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(1297, 30)
        Me.PanelButton.TabIndex = 4
        '
        'FormCompoundMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1297, 725)
        Me.Controls.Add(Me.scParent)
        Me.Controls.Add(Me.PanelHeader2)
        Me.Controls.Add(Me.PanelButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCompoundMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormCompoundMaterial"
        Me.tlpCompoundMaterialEdit.ResumeLayout(False)
        Me.tlpCMEdit1.ResumeLayout(False)
        Me.tlpCMEdit2.ResumeLayout(False)
        CType(Me.scCompoundMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scCompoundMaterial.ResumeLayout(False)
        Me.PanelFoot.ResumeLayout(False)
        Me.scParent.Panel1.ResumeLayout(False)
        CType(Me.scParent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scParent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader2 As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpCompoundMaterialEdit As TableLayoutPanel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents scCompoundMaterial As SplitContainer
    Friend WithEvents PanelFoot As Panel
    Friend WithEvents scParent As SplitContainer
    Friend WithEvents PanelButton As Panel
    Friend WithEvents tlpCMEdit1 As TableLayoutPanel
    Friend WithEvents tlpCMEdit2 As TableLayoutPanel
    Friend WithEvents tlpCMEdit3 As TableLayoutPanel
    Friend WithEvents tlpCMEditLbl2 As TableLayoutPanel
    Friend WithEvents tlpCMEditTex2 As TableLayoutPanel
End Class
