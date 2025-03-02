<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompoundLabour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompoundLabour))
        Me.PanelHeader2 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.tlpCompoundLabourEdit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCLEdit1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCLEdit2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCLEditLbl2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCLEditTex2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCLEdit3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.scCompoundLabour = New System.Windows.Forms.SplitContainer()
        Me.PanelFoot = New System.Windows.Forms.Panel()
        Me.scParent = New System.Windows.Forms.SplitContainer()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.tlpCompoundLabourEdit.SuspendLayout()
        Me.tlpCLEdit1.SuspendLayout()
        Me.tlpCLEdit2.SuspendLayout()
        CType(Me.scCompoundLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scCompoundLabour.SuspendLayout()
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
        Me.PanelHeader2.TabIndex = 12
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
        'tlpCompoundLabourEdit
        '
        Me.tlpCompoundLabourEdit.ColumnCount = 1
        Me.tlpCompoundLabourEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCompoundLabourEdit.Controls.Add(Me.tlpCLEdit1, 0, 0)
        Me.tlpCompoundLabourEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpCompoundLabourEdit.Location = New System.Drawing.Point(0, 0)
        Me.tlpCompoundLabourEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCompoundLabourEdit.Name = "tlpCompoundLabourEdit"
        Me.tlpCompoundLabourEdit.RowCount = 1
        Me.tlpCompoundLabourEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCompoundLabourEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.tlpCompoundLabourEdit.Size = New System.Drawing.Size(736, 157)
        Me.tlpCompoundLabourEdit.TabIndex = 0
        '
        'tlpCLEdit1
        '
        Me.tlpCLEdit1.ColumnCount = 2
        Me.tlpCLEdit1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.98913!))
        Me.tlpCLEdit1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.01087!))
        Me.tlpCLEdit1.Controls.Add(Me.tlpCLEdit2, 0, 0)
        Me.tlpCLEdit1.Controls.Add(Me.tlpCLEdit3, 1, 0)
        Me.tlpCLEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCLEdit1.Location = New System.Drawing.Point(0, 0)
        Me.tlpCLEdit1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCLEdit1.Name = "tlpCLEdit1"
        Me.tlpCLEdit1.RowCount = 1
        Me.tlpCLEdit1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCLEdit1.Size = New System.Drawing.Size(736, 157)
        Me.tlpCLEdit1.TabIndex = 2
        '
        'tlpCLEdit2
        '
        Me.tlpCLEdit2.ColumnCount = 2
        Me.tlpCLEdit2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpCLEdit2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCLEdit2.Controls.Add(Me.tlpCLEditLbl2, 0, 2)
        Me.tlpCLEdit2.Controls.Add(Me.tlpCLEditTex2, 1, 2)
        Me.tlpCLEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCLEdit2.Location = New System.Drawing.Point(0, 0)
        Me.tlpCLEdit2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCLEdit2.Name = "tlpCLEdit2"
        Me.tlpCLEdit2.RowCount = 3
        Me.tlpCLEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCLEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCLEdit2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpCLEdit2.Size = New System.Drawing.Size(390, 157)
        Me.tlpCLEdit2.TabIndex = 0
        '
        'tlpCLEditLbl2
        '
        Me.tlpCLEditLbl2.ColumnCount = 1
        Me.tlpCLEditLbl2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCLEditLbl2.Location = New System.Drawing.Point(0, 60)
        Me.tlpCLEditLbl2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCLEditLbl2.Name = "tlpCLEditLbl2"
        Me.tlpCLEditLbl2.RowCount = 3
        Me.tlpCLEditLbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCLEditLbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCLEditLbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCLEditLbl2.Size = New System.Drawing.Size(150, 97)
        Me.tlpCLEditLbl2.TabIndex = 0
        '
        'tlpCLEditTex2
        '
        Me.tlpCLEditTex2.ColumnCount = 1
        Me.tlpCLEditTex2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCLEditTex2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCLEditTex2.Location = New System.Drawing.Point(150, 60)
        Me.tlpCLEditTex2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCLEditTex2.Name = "tlpCLEditTex2"
        Me.tlpCLEditTex2.RowCount = 3
        Me.tlpCLEditTex2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCLEditTex2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCLEditTex2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCLEditTex2.Size = New System.Drawing.Size(240, 97)
        Me.tlpCLEditTex2.TabIndex = 1
        '
        'tlpCLEdit3
        '
        Me.tlpCLEdit3.ColumnCount = 2
        Me.tlpCLEdit3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpCLEdit3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCLEdit3.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpCLEdit3.Location = New System.Drawing.Point(390, 0)
        Me.tlpCLEdit3.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCLEdit3.Name = "tlpCLEdit3"
        Me.tlpCLEdit3.RowCount = 1
        Me.tlpCLEdit3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCLEdit3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpCLEdit3.Size = New System.Drawing.Size(346, 90)
        Me.tlpCLEdit3.TabIndex = 1
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
        'scCompoundLabour
        '
        Me.scCompoundLabour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scCompoundLabour.Location = New System.Drawing.Point(0, 157)
        Me.scCompoundLabour.Margin = New System.Windows.Forms.Padding(0)
        Me.scCompoundLabour.Name = "scCompoundLabour"
        '
        'scCompoundLabour.Panel1
        '
        Me.scCompoundLabour.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'scCompoundLabour.Panel2
        '
        Me.scCompoundLabour.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scCompoundLabour.Size = New System.Drawing.Size(736, 446)
        Me.scCompoundLabour.SplitterDistance = 390
        Me.scCompoundLabour.TabIndex = 2
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
        Me.scParent.Location = New System.Drawing.Point(0, 73)
        Me.scParent.Margin = New System.Windows.Forms.Padding(0)
        Me.scParent.Name = "scParent"
        '
        'scParent.Panel1
        '
        Me.scParent.Panel1.Controls.Add(Me.scCompoundLabour)
        Me.scParent.Panel1.Controls.Add(Me.PanelFoot)
        Me.scParent.Panel1.Controls.Add(Me.tlpCompoundLabourEdit)
        '
        'scParent.Panel2
        '
        Me.scParent.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scParent.Size = New System.Drawing.Size(1297, 651)
        Me.scParent.SplitterDistance = 736
        Me.scParent.TabIndex = 11
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(1297, 30)
        Me.PanelButton.TabIndex = 10
        '
        'FormCompoundLabour
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
        Me.Name = "FormCompoundLabour"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormCompoundLabour"
        Me.tlpCompoundLabourEdit.ResumeLayout(False)
        Me.tlpCLEdit1.ResumeLayout(False)
        Me.tlpCLEdit2.ResumeLayout(False)
        CType(Me.scCompoundLabour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scCompoundLabour.ResumeLayout(False)
        Me.PanelFoot.ResumeLayout(False)
        Me.scParent.Panel1.ResumeLayout(False)
        CType(Me.scParent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scParent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader2 As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpCompoundLabourEdit As TableLayoutPanel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents scCompoundLabour As SplitContainer
    Friend WithEvents PanelFoot As Panel
    Friend WithEvents scParent As SplitContainer
    Friend WithEvents PanelButton As Panel
    Friend WithEvents tlpCLEdit1 As TableLayoutPanel
    Friend WithEvents tlpCLEdit2 As TableLayoutPanel
    Friend WithEvents tlpCLEdit3 As TableLayoutPanel
    Friend WithEvents tlpCLEditLbl2 As TableLayoutPanel
    Friend WithEvents tlpCLEditTex2 As TableLayoutPanel
End Class
