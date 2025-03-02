<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCompoundEquipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompoundEquipment))
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.scParent = New System.Windows.Forms.SplitContainer()
        Me.scCompoundEquipment = New System.Windows.Forms.SplitContainer()
        Me.PanelFoot = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlpCompoundEquipmentEdit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCEEdit1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCEEdit2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCEEditTex2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCEEditLbl2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCEEdit3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelHeader2 = New System.Windows.Forms.Panel()
        CType(Me.scParent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scParent.Panel1.SuspendLayout()
        Me.scParent.SuspendLayout()
        CType(Me.scCompoundEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scCompoundEquipment.SuspendLayout()
        Me.PanelFoot.SuspendLayout()
        Me.tlpCompoundEquipmentEdit.SuspendLayout()
        Me.tlpCEEdit1.SuspendLayout()
        Me.tlpCEEdit2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(1297, 30)
        Me.PanelButton.TabIndex = 7
        '
        'scParent
        '
        Me.scParent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scParent.Location = New System.Drawing.Point(0, 73)
        Me.scParent.Margin = New System.Windows.Forms.Padding(0)
        Me.scParent.Name = "scParent"
        '
        'scParent.Panel1
        '
        Me.scParent.Panel1.Controls.Add(Me.scCompoundEquipment)
        Me.scParent.Panel1.Controls.Add(Me.PanelFoot)
        Me.scParent.Panel1.Controls.Add(Me.tlpCompoundEquipmentEdit)
        '
        'scParent.Panel2
        '
        Me.scParent.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scParent.Size = New System.Drawing.Size(1297, 651)
        Me.scParent.SplitterDistance = 736
        Me.scParent.TabIndex = 8
        '
        'scCompoundEquipment
        '
        Me.scCompoundEquipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scCompoundEquipment.Location = New System.Drawing.Point(0, 157)
        Me.scCompoundEquipment.Margin = New System.Windows.Forms.Padding(0)
        Me.scCompoundEquipment.Name = "scCompoundEquipment"
        '
        'scCompoundEquipment.Panel1
        '
        Me.scCompoundEquipment.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'scCompoundEquipment.Panel2
        '
        Me.scCompoundEquipment.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scCompoundEquipment.Size = New System.Drawing.Size(736, 446)
        Me.scCompoundEquipment.SplitterDistance = 390
        Me.scCompoundEquipment.TabIndex = 2
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
        'tlpCompoundEquipmentEdit
        '
        Me.tlpCompoundEquipmentEdit.ColumnCount = 1
        Me.tlpCompoundEquipmentEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCompoundEquipmentEdit.Controls.Add(Me.tlpCEEdit1, 0, 0)
        Me.tlpCompoundEquipmentEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpCompoundEquipmentEdit.Location = New System.Drawing.Point(0, 0)
        Me.tlpCompoundEquipmentEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCompoundEquipmentEdit.Name = "tlpCompoundEquipmentEdit"
        Me.tlpCompoundEquipmentEdit.RowCount = 1
        Me.tlpCompoundEquipmentEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCompoundEquipmentEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.tlpCompoundEquipmentEdit.Size = New System.Drawing.Size(736, 157)
        Me.tlpCompoundEquipmentEdit.TabIndex = 0
        '
        'tlpCEEdit1
        '
        Me.tlpCEEdit1.ColumnCount = 2
        Me.tlpCEEdit1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.85326!))
        Me.tlpCEEdit1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.14674!))
        Me.tlpCEEdit1.Controls.Add(Me.tlpCEEdit2, 0, 0)
        Me.tlpCEEdit1.Controls.Add(Me.tlpCEEdit3, 1, 0)
        Me.tlpCEEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCEEdit1.Location = New System.Drawing.Point(0, 0)
        Me.tlpCEEdit1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCEEdit1.Name = "tlpCEEdit1"
        Me.tlpCEEdit1.RowCount = 1
        Me.tlpCEEdit1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCEEdit1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.tlpCEEdit1.Size = New System.Drawing.Size(736, 157)
        Me.tlpCEEdit1.TabIndex = 2
        '
        'tlpCEEdit2
        '
        Me.tlpCEEdit2.ColumnCount = 2
        Me.tlpCEEdit2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpCEEdit2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCEEdit2.Controls.Add(Me.tlpCEEditTex2, 0, 2)
        Me.tlpCEEdit2.Controls.Add(Me.tlpCEEditLbl2, 0, 2)
        Me.tlpCEEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCEEdit2.Location = New System.Drawing.Point(0, 0)
        Me.tlpCEEdit2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCEEdit2.Name = "tlpCEEdit2"
        Me.tlpCEEdit2.RowCount = 3
        Me.tlpCEEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCEEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCEEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpCEEdit2.Size = New System.Drawing.Size(389, 157)
        Me.tlpCEEdit2.TabIndex = 0
        '
        'tlpCEEditTex2
        '
        Me.tlpCEEditTex2.ColumnCount = 1
        Me.tlpCEEditTex2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCEEditTex2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCEEditTex2.Location = New System.Drawing.Point(150, 60)
        Me.tlpCEEditTex2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCEEditTex2.Name = "tlpCEEditTex2"
        Me.tlpCEEditTex2.RowCount = 3
        Me.tlpCEEditTex2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCEEditTex2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCEEditTex2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCEEditTex2.Size = New System.Drawing.Size(239, 97)
        Me.tlpCEEditTex2.TabIndex = 2
        '
        'tlpCEEditLbl2
        '
        Me.tlpCEEditLbl2.ColumnCount = 1
        Me.tlpCEEditLbl2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCEEditLbl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCEEditLbl2.Location = New System.Drawing.Point(0, 60)
        Me.tlpCEEditLbl2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCEEditLbl2.Name = "tlpCEEditLbl2"
        Me.tlpCEEditLbl2.RowCount = 3
        Me.tlpCEEditLbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCEEditLbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCEEditLbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCEEditLbl2.Size = New System.Drawing.Size(150, 97)
        Me.tlpCEEditLbl2.TabIndex = 1
        '
        'tlpCEEdit3
        '
        Me.tlpCEEdit3.ColumnCount = 2
        Me.tlpCEEdit3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpCEEdit3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCEEdit3.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpCEEdit3.Location = New System.Drawing.Point(389, 0)
        Me.tlpCEEdit3.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCEEdit3.Name = "tlpCEEdit3"
        Me.tlpCEEdit3.RowCount = 1
        Me.tlpCEEdit3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpCEEdit3.Size = New System.Drawing.Size(347, 90)
        Me.tlpCEEdit3.TabIndex = 1
        '
        'PanelHeader2
        '
        Me.PanelHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader2.Location = New System.Drawing.Point(0, 30)
        Me.PanelHeader2.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelHeader2.Name = "PanelHeader2"
        Me.PanelHeader2.Size = New System.Drawing.Size(1297, 37)
        Me.PanelHeader2.TabIndex = 9
        '
        'FormCompoundEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1297, 725)
        Me.Controls.Add(Me.PanelHeader2)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.scParent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCompoundEquipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormCompoundEquipment"
        Me.scParent.Panel1.ResumeLayout(False)
        CType(Me.scParent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scParent.ResumeLayout(False)
        CType(Me.scCompoundEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scCompoundEquipment.ResumeLayout(False)
        Me.PanelFoot.ResumeLayout(False)
        Me.tlpCompoundEquipmentEdit.ResumeLayout(False)
        Me.tlpCEEdit1.ResumeLayout(False)
        Me.tlpCEEdit2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelButton As Panel
    Friend WithEvents scParent As SplitContainer
    Friend WithEvents scCompoundEquipment As SplitContainer
    Friend WithEvents PanelFoot As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpCompoundEquipmentEdit As TableLayoutPanel
    Friend WithEvents tlpCEEdit1 As TableLayoutPanel
    Friend WithEvents tlpCEEdit2 As TableLayoutPanel
    Friend WithEvents tlpCEEdit3 As TableLayoutPanel
    Friend WithEvents PanelHeader2 As Panel
    Friend WithEvents tlpCEEditLbl2 As TableLayoutPanel
    Friend WithEvents tlpCEEditTex2 As TableLayoutPanel
End Class
