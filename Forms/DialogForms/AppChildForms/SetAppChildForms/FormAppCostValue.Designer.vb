<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAppCostValue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAppCostValue))
        Me.lblEdicionCostSetting = New System.Windows.Forms.Label()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.PanelArea = New System.Windows.Forms.Panel()
        Me.UpPanelEdicion = New UPAZ.UPPanel()
        Me.tlyPanelEdicion = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblListadoCostSetting = New System.Windows.Forms.Label()
        Me.tlpListCostSetting = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMatrixType = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContCostSetting = New System.Windows.Forms.SplitContainer()
        Me.PanelBotton.SuspendLayout()
        Me.PanelArea.SuspendLayout()
        Me.UpPanelEdicion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpListCostSetting.SuspendLayout()
        CType(Me.splitContCostSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContCostSetting.Panel1.SuspendLayout()
        Me.splitContCostSetting.Panel2.SuspendLayout()
        Me.splitContCostSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEdicionCostSetting
        '
        Me.lblEdicionCostSetting.AutoSize = True
        Me.lblEdicionCostSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblEdicionCostSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEdicionCostSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEdicionCostSetting.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionCostSetting.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEdicionCostSetting.Location = New System.Drawing.Point(4, 8)
        Me.lblEdicionCostSetting.Margin = New System.Windows.Forms.Padding(4, 8, 8, 0)
        Me.lblEdicionCostSetting.Name = "lblEdicionCostSetting"
        Me.lblEdicionCostSetting.Padding = New System.Windows.Forms.Padding(1)
        Me.lblEdicionCostSetting.Size = New System.Drawing.Size(491, 32)
        Me.lblEdicionCostSetting.TabIndex = 0
        Me.lblEdicionCostSetting.Text = "Edición Costos Predeterminados"
        Me.lblEdicionCostSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 531)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(503, 48)
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
        Me.btnGuardar.Location = New System.Drawing.Point(411, 7)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'PanelArea
        '
        Me.PanelArea.Controls.Add(Me.UpPanelEdicion)
        Me.PanelArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelArea.Location = New System.Drawing.Point(0, 40)
        Me.PanelArea.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelArea.Name = "PanelArea"
        Me.PanelArea.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelArea.Size = New System.Drawing.Size(503, 491)
        Me.PanelArea.TabIndex = 15
        '
        'UpPanelEdicion
        '
        Me.UpPanelEdicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.UpPanelEdicion.Controls.Add(Me.tlyPanelEdicion)
        Me.UpPanelEdicion.CornerRadius = 10
        Me.UpPanelEdicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpPanelEdicion.Location = New System.Drawing.Point(6, 6)
        Me.UpPanelEdicion.Margin = New System.Windows.Forms.Padding(0)
        Me.UpPanelEdicion.Name = "UpPanelEdicion"
        Me.UpPanelEdicion.Size = New System.Drawing.Size(491, 479)
        Me.UpPanelEdicion.TabIndex = 8
        '
        'tlyPanelEdicion
        '
        Me.tlyPanelEdicion.ColumnCount = 2
        Me.tlyPanelEdicion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlyPanelEdicion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlyPanelEdicion.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlyPanelEdicion.Location = New System.Drawing.Point(0, 0)
        Me.tlyPanelEdicion.Margin = New System.Windows.Forms.Padding(0)
        Me.tlyPanelEdicion.Name = "tlyPanelEdicion"
        Me.tlyPanelEdicion.RowCount = 5
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.Size = New System.Drawing.Size(491, 150)
        Me.tlyPanelEdicion.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEdicionCostSetting, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelBotton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelArea, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 579)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblListadoCostSetting
        '
        Me.lblListadoCostSetting.AutoSize = True
        Me.lblListadoCostSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblListadoCostSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblListadoCostSetting.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoCostSetting.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblListadoCostSetting.Location = New System.Drawing.Point(8, 8)
        Me.lblListadoCostSetting.Margin = New System.Windows.Forms.Padding(8, 8, 4, 0)
        Me.lblListadoCostSetting.Name = "lblListadoCostSetting"
        Me.lblListadoCostSetting.Padding = New System.Windows.Forms.Padding(1)
        Me.lblListadoCostSetting.Size = New System.Drawing.Size(565, 32)
        Me.lblListadoCostSetting.TabIndex = 0
        Me.lblListadoCostSetting.Text = "Listado Costos Predeterminados"
        Me.lblListadoCostSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpListCostSetting
        '
        Me.tlpListCostSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListCostSetting.ColumnCount = 1
        Me.tlpListCostSetting.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListCostSetting.Controls.Add(Me.lblListadoCostSetting, 0, 0)
        Me.tlpListCostSetting.Controls.Add(Me.tlpMatrixType, 0, 1)
        Me.tlpListCostSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListCostSetting.Location = New System.Drawing.Point(0, 0)
        Me.tlpListCostSetting.Name = "tlpListCostSetting"
        Me.tlpListCostSetting.RowCount = 3
        Me.tlpListCostSetting.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListCostSetting.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListCostSetting.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListCostSetting.Size = New System.Drawing.Size(577, 579)
        Me.tlpListCostSetting.TabIndex = 0
        '
        'tlpMatrixType
        '
        Me.tlpMatrixType.ColumnCount = 2
        Me.tlpMatrixType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpMatrixType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMatrixType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMatrixType.Location = New System.Drawing.Point(0, 40)
        Me.tlpMatrixType.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMatrixType.Name = "tlpMatrixType"
        Me.tlpMatrixType.RowCount = 1
        Me.tlpMatrixType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMatrixType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpMatrixType.Size = New System.Drawing.Size(577, 30)
        Me.tlpMatrixType.TabIndex = 1
        '
        'splitContCostSetting
        '
        Me.splitContCostSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContCostSetting.Location = New System.Drawing.Point(0, 0)
        Me.splitContCostSetting.Name = "splitContCostSetting"
        '
        'splitContCostSetting.Panel1
        '
        Me.splitContCostSetting.Panel1.Controls.Add(Me.tlpListCostSetting)
        '
        'splitContCostSetting.Panel2
        '
        Me.splitContCostSetting.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splitContCostSetting.Size = New System.Drawing.Size(1084, 579)
        Me.splitContCostSetting.SplitterDistance = 577
        Me.splitContCostSetting.TabIndex = 1
        '
        'FormAppCostValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 579)
        Me.Controls.Add(Me.splitContCostSetting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 309)
        Me.Name = "FormAppCostValue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Costos Prefijados"
        Me.PanelBotton.ResumeLayout(False)
        Me.PanelArea.ResumeLayout(False)
        Me.UpPanelEdicion.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpListCostSetting.ResumeLayout(False)
        Me.tlpListCostSetting.PerformLayout()
        Me.splitContCostSetting.Panel1.ResumeLayout(False)
        Me.splitContCostSetting.Panel2.ResumeLayout(False)
        CType(Me.splitContCostSetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContCostSetting.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEdicionCostSetting As Label
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlyPanelEdicion As TableLayoutPanel
    Friend WithEvents UpPanelEdicion As UPPanel
    Friend WithEvents PanelArea As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblListadoCostSetting As Label
    Friend WithEvents tlpListCostSetting As TableLayoutPanel
    Friend WithEvents splitContCostSetting As SplitContainer
    Friend WithEvents tlpMatrixType As TableLayoutPanel
End Class
