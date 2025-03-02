<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChapterModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChapterModal))
        Me.tlpListChapter = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContChapter = New System.Windows.Forms.SplitContainer()
        Me.tlpEditionChapter = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlpEditionChapter2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.splitContChapter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContChapter.Panel1.SuspendLayout()
        Me.splitContChapter.Panel2.SuspendLayout()
        Me.splitContChapter.SuspendLayout()
        Me.tlpEditionChapter.SuspendLayout()
        Me.PanelBotton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpListChapter
        '
        Me.tlpListChapter.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListChapter.ColumnCount = 1
        Me.tlpListChapter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListChapter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListChapter.Location = New System.Drawing.Point(0, 0)
        Me.tlpListChapter.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListChapter.Name = "tlpListChapter"
        Me.tlpListChapter.RowCount = 2
        Me.tlpListChapter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListChapter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListChapter.Size = New System.Drawing.Size(423, 450)
        Me.tlpListChapter.TabIndex = 0
        '
        'splitContChapter
        '
        Me.splitContChapter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContChapter.Location = New System.Drawing.Point(0, 0)
        Me.splitContChapter.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContChapter.Name = "splitContChapter"
        '
        'splitContChapter.Panel1
        '
        Me.splitContChapter.Panel1.Controls.Add(Me.tlpListChapter)
        '
        'splitContChapter.Panel2
        '
        Me.splitContChapter.Panel2.Controls.Add(Me.tlpEditionChapter)
        Me.splitContChapter.Size = New System.Drawing.Size(800, 450)
        Me.splitContChapter.SplitterDistance = 423
        Me.splitContChapter.TabIndex = 2
        '
        'tlpEditionChapter
        '
        Me.tlpEditionChapter.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEditionChapter.ColumnCount = 1
        Me.tlpEditionChapter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionChapter.Controls.Add(Me.PanelBotton, 0, 2)
        Me.tlpEditionChapter.Controls.Add(Me.tlpEditionChapter2, 0, 1)
        Me.tlpEditionChapter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEditionChapter.Location = New System.Drawing.Point(0, 0)
        Me.tlpEditionChapter.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionChapter.Name = "tlpEditionChapter"
        Me.tlpEditionChapter.RowCount = 3
        Me.tlpEditionChapter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEditionChapter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionChapter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEditionChapter.Size = New System.Drawing.Size(373, 450)
        Me.tlpEditionChapter.TabIndex = 0
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
        'tlpEditionChapter2
        '
        Me.tlpEditionChapter2.ColumnCount = 2
        Me.tlpEditionChapter2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEditionChapter2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionChapter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEditionChapter2.Location = New System.Drawing.Point(0, 40)
        Me.tlpEditionChapter2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionChapter2.Name = "tlpEditionChapter2"
        Me.tlpEditionChapter2.RowCount = 4
        Me.tlpEditionChapter2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionChapter2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionChapter2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionChapter2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionChapter2.Size = New System.Drawing.Size(373, 120)
        Me.tlpEditionChapter2.TabIndex = 7
        '
        'FormChapterModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.splitContChapter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormChapterModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormCapter"
        Me.splitContChapter.Panel1.ResumeLayout(False)
        Me.splitContChapter.Panel2.ResumeLayout(False)
        CType(Me.splitContChapter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContChapter.ResumeLayout(False)
        Me.tlpEditionChapter.ResumeLayout(False)
        Me.PanelBotton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpListChapter As TableLayoutPanel
    Friend WithEvents splitContChapter As SplitContainer
    Friend WithEvents tlpEditionChapter As TableLayoutPanel
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpEditionChapter2 As TableLayoutPanel
End Class
