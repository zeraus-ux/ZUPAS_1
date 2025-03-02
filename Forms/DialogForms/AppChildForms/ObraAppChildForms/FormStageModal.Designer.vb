<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStageModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStageModal))
        Me.splitContStage = New System.Windows.Forms.SplitContainer()
        Me.tlpListStage = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpEditionStage = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlpEditionStage2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.splitContStage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContStage.Panel1.SuspendLayout()
        Me.splitContStage.Panel2.SuspendLayout()
        Me.splitContStage.SuspendLayout()
        Me.tlpEditionStage.SuspendLayout()
        Me.PanelBotton.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContStage
        '
        Me.splitContStage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContStage.Location = New System.Drawing.Point(0, 0)
        Me.splitContStage.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContStage.Name = "splitContStage"
        '
        'splitContStage.Panel1
        '
        Me.splitContStage.Panel1.Controls.Add(Me.tlpListStage)
        '
        'splitContStage.Panel2
        '
        Me.splitContStage.Panel2.Controls.Add(Me.tlpEditionStage)
        Me.splitContStage.Size = New System.Drawing.Size(922, 472)
        Me.splitContStage.SplitterDistance = 488
        Me.splitContStage.TabIndex = 1
        '
        'tlpListStage
        '
        Me.tlpListStage.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListStage.ColumnCount = 1
        Me.tlpListStage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListStage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListStage.Location = New System.Drawing.Point(0, 0)
        Me.tlpListStage.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListStage.Name = "tlpListStage"
        Me.tlpListStage.RowCount = 2
        Me.tlpListStage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListStage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListStage.Size = New System.Drawing.Size(488, 472)
        Me.tlpListStage.TabIndex = 0
        '
        'tlpEditionStage
        '
        Me.tlpEditionStage.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEditionStage.ColumnCount = 1
        Me.tlpEditionStage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionStage.Controls.Add(Me.PanelBotton, 0, 2)
        Me.tlpEditionStage.Controls.Add(Me.tlpEditionStage2, 0, 1)
        Me.tlpEditionStage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEditionStage.Location = New System.Drawing.Point(0, 0)
        Me.tlpEditionStage.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionStage.Name = "tlpEditionStage"
        Me.tlpEditionStage.RowCount = 3
        Me.tlpEditionStage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEditionStage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionStage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEditionStage.Size = New System.Drawing.Size(430, 472)
        Me.tlpEditionStage.TabIndex = 0
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 424)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(430, 48)
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
        Me.btnGuardar.Location = New System.Drawing.Point(339, 10)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlpEditionStage2
        '
        Me.tlpEditionStage2.ColumnCount = 2
        Me.tlpEditionStage2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEditionStage2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionStage2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEditionStage2.Location = New System.Drawing.Point(0, 40)
        Me.tlpEditionStage2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionStage2.Name = "tlpEditionStage2"
        Me.tlpEditionStage2.RowCount = 4
        Me.tlpEditionStage2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionStage2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionStage2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionStage2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionStage2.Size = New System.Drawing.Size(430, 120)
        Me.tlpEditionStage2.TabIndex = 7
        '
        'FormStageModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 472)
        Me.Controls.Add(Me.splitContStage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 365)
        Me.Name = "FormStageModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Etapas de la Obra"
        Me.splitContStage.Panel1.ResumeLayout(False)
        Me.splitContStage.Panel2.ResumeLayout(False)
        CType(Me.splitContStage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContStage.ResumeLayout(False)
        Me.tlpEditionStage.ResumeLayout(False)
        Me.PanelBotton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContStage As SplitContainer
    Friend WithEvents tlpListStage As TableLayoutPanel
    Friend WithEvents tlpEditionStage As TableLayoutPanel
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpEditionStage2 As TableLayoutPanel
End Class
