<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataSourceInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataSourceInput))
        Me.tlpListDataSourceInput = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContDataSourceInput = New System.Windows.Forms.SplitContainer()
        Me.tlpEditionDataSourceInput = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlpEditionDataSourceInput2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.splitContDataSourceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContDataSourceInput.Panel1.SuspendLayout()
        Me.splitContDataSourceInput.Panel2.SuspendLayout()
        Me.splitContDataSourceInput.SuspendLayout()
        Me.tlpEditionDataSourceInput.SuspendLayout()
        Me.PanelBotton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpListDataSourceInput
        '
        Me.tlpListDataSourceInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListDataSourceInput.ColumnCount = 1
        Me.tlpListDataSourceInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListDataSourceInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListDataSourceInput.Location = New System.Drawing.Point(0, 0)
        Me.tlpListDataSourceInput.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListDataSourceInput.Name = "tlpListDataSourceInput"
        Me.tlpListDataSourceInput.RowCount = 2
        Me.tlpListDataSourceInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListDataSourceInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListDataSourceInput.Size = New System.Drawing.Size(423, 450)
        Me.tlpListDataSourceInput.TabIndex = 0
        '
        'splitContDataSourceInput
        '
        Me.splitContDataSourceInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContDataSourceInput.Location = New System.Drawing.Point(0, 0)
        Me.splitContDataSourceInput.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContDataSourceInput.Name = "splitContDataSourceInput"
        '
        'splitContDataSourceInput.Panel1
        '
        Me.splitContDataSourceInput.Panel1.Controls.Add(Me.tlpListDataSourceInput)
        '
        'splitContDataSourceInput.Panel2
        '
        Me.splitContDataSourceInput.Panel2.Controls.Add(Me.tlpEditionDataSourceInput)
        Me.splitContDataSourceInput.Size = New System.Drawing.Size(800, 450)
        Me.splitContDataSourceInput.SplitterDistance = 423
        Me.splitContDataSourceInput.TabIndex = 4
        '
        'tlpEditionDataSourceInput
        '
        Me.tlpEditionDataSourceInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpEditionDataSourceInput.ColumnCount = 1
        Me.tlpEditionDataSourceInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionDataSourceInput.Controls.Add(Me.PanelBotton, 0, 2)
        Me.tlpEditionDataSourceInput.Controls.Add(Me.tlpEditionDataSourceInput2, 0, 1)
        Me.tlpEditionDataSourceInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEditionDataSourceInput.Location = New System.Drawing.Point(0, 0)
        Me.tlpEditionDataSourceInput.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionDataSourceInput.Name = "tlpEditionDataSourceInput"
        Me.tlpEditionDataSourceInput.RowCount = 3
        Me.tlpEditionDataSourceInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEditionDataSourceInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionDataSourceInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpEditionDataSourceInput.Size = New System.Drawing.Size(373, 450)
        Me.tlpEditionDataSourceInput.TabIndex = 0
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
        'tlpEditionDataSourceInput2
        '
        Me.tlpEditionDataSourceInput2.ColumnCount = 2
        Me.tlpEditionDataSourceInput2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEditionDataSourceInput2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEditionDataSourceInput2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEditionDataSourceInput2.Location = New System.Drawing.Point(0, 40)
        Me.tlpEditionDataSourceInput2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEditionDataSourceInput2.Name = "tlpEditionDataSourceInput2"
        Me.tlpEditionDataSourceInput2.RowCount = 4
        Me.tlpEditionDataSourceInput2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionDataSourceInput2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEditionDataSourceInput2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEditionDataSourceInput2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEditionDataSourceInput2.Size = New System.Drawing.Size(373, 180)
        Me.tlpEditionDataSourceInput2.TabIndex = 7
        '
        'FormDataSourceInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.splitContDataSourceInput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDataSourceInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormDataSourceInput"
        Me.splitContDataSourceInput.Panel1.ResumeLayout(False)
        Me.splitContDataSourceInput.Panel2.ResumeLayout(False)
        CType(Me.splitContDataSourceInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContDataSourceInput.ResumeLayout(False)
        Me.tlpEditionDataSourceInput.ResumeLayout(False)
        Me.PanelBotton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpListDataSourceInput As TableLayoutPanel
    Friend WithEvents splitContDataSourceInput As SplitContainer
    Friend WithEvents tlpEditionDataSourceInput As TableLayoutPanel
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpEditionDataSourceInput2 As TableLayoutPanel
End Class
