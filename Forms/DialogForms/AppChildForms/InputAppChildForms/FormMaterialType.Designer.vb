<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaterialType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaterialType))
        Me.tlpListMaterialType = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContMaterialType = New System.Windows.Forms.SplitContainer()
        Me.tlpEditionMaterialType = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlpEditionMaterialType2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.splitContMaterialType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContMaterialType.Panel1.SuspendLayout()
        Me.splitContMaterialType.Panel2.SuspendLayout()
        Me.splitContMaterialType.SuspendLayout()
        Me.tlpEditionMaterialType.SuspendLayout()
        Me.PanelBotton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpListMaterialType
        '
        Me.tlpListMaterialType.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListMaterialType.ColumnCount = 1
        Me.tlpListMaterialType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMaterialType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListMaterialType.Location = New System.Drawing.Point(0, 0)
        Me.tlpListMaterialType.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListMaterialType.Name = "tlpListMaterialType"
        Me.tlpListMaterialType.RowCount = 2
        Me.tlpListMaterialType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListMaterialType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMaterialType.Size = New System.Drawing.Size(423, 450)
        Me.tlpListMaterialType.TabIndex = 0
        '
        'splitContMaterialType
        '
        Me.splitContMaterialType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContMaterialType.Location = New System.Drawing.Point(0, 0)
        Me.splitContMaterialType.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContMaterialType.Name = "splitContMaterialType"
        '
        'splitContMaterialType.Panel1
        '
        Me.splitContMaterialType.Panel1.Controls.Add(Me.tlpListMaterialType)
        '
        'splitContMaterialType.Panel2
        '
        Me.splitContMaterialType.Panel2.Controls.Add(Me.tlpEditionMaterialType)
        Me.splitContMaterialType.Size = New System.Drawing.Size(800, 450)
        Me.splitContMaterialType.SplitterDistance = 423
        Me.splitContMaterialType.TabIndex = 3
        '
        'tlpEditionMaterialType
        '
        Me.tlpEditionMaterialType.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEditionMaterialType.ColumnCount = 1
        Me.tlpEditionMaterialType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionMaterialType.Controls.Add(Me.PanelBotton, 0, 2)
        Me.tlpEditionMaterialType.Controls.Add(Me.tlpEditionMaterialType2, 0, 1)
        Me.tlpEditionMaterialType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEditionMaterialType.Location = New System.Drawing.Point(0, 0)
        Me.tlpEditionMaterialType.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionMaterialType.Name = "tlpEditionMaterialType"
        Me.tlpEditionMaterialType.RowCount = 3
        Me.tlpEditionMaterialType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEditionMaterialType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionMaterialType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEditionMaterialType.Size = New System.Drawing.Size(373, 450)
        Me.tlpEditionMaterialType.TabIndex = 0
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 402)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(373, 48)
        Me.PanelBotton.TabIndex = 6
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
        Me.btnGuardar.Location = New System.Drawing.Point(282, 10)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlpEditionMaterialType2
        '
        Me.tlpEditionMaterialType2.ColumnCount = 2
        Me.tlpEditionMaterialType2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEditionMaterialType2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionMaterialType2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEditionMaterialType2.Location = New System.Drawing.Point(0, 40)
        Me.tlpEditionMaterialType2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionMaterialType2.Name = "tlpEditionMaterialType2"
        Me.tlpEditionMaterialType2.RowCount = 4
        Me.tlpEditionMaterialType2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionMaterialType2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEditionMaterialType2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEditionMaterialType2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionMaterialType2.Size = New System.Drawing.Size(373, 180)
        Me.tlpEditionMaterialType2.TabIndex = 7
        '
        'FormMaterialType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.splitContMaterialType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMaterialType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMaterialType"
        Me.splitContMaterialType.Panel1.ResumeLayout(False)
        Me.splitContMaterialType.Panel2.ResumeLayout(False)
        CType(Me.splitContMaterialType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContMaterialType.ResumeLayout(False)
        Me.tlpEditionMaterialType.ResumeLayout(False)
        Me.PanelBotton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpListMaterialType As TableLayoutPanel
    Friend WithEvents splitContMaterialType As SplitContainer
    Friend WithEvents tlpEditionMaterialType As TableLayoutPanel
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpEditionMaterialType2 As TableLayoutPanel
End Class
