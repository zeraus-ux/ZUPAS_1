<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAppCostCalType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAppCostCalType))
        Me.splitContCostCalType = New System.Windows.Forms.SplitContainer()
        Me.tlpListCostType = New System.Windows.Forms.TableLayoutPanel()
        Me.lblListadoCostCalType = New System.Windows.Forms.Label()
        Me.tlpMatrizList = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEdicionCostCalType = New System.Windows.Forms.Label()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.PanelArea = New System.Windows.Forms.Panel()
        Me.UpPanelEdicion = New UPAZ.UPPanel()
        Me.tlyPanelEdicion = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.splitContCostCalType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContCostCalType.Panel1.SuspendLayout()
        Me.splitContCostCalType.Panel2.SuspendLayout()
        Me.splitContCostCalType.SuspendLayout()
        Me.tlpListCostType.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelBotton.SuspendLayout()
        Me.PanelArea.SuspendLayout()
        Me.UpPanelEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContCostCalType
        '
        Me.splitContCostCalType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContCostCalType.Location = New System.Drawing.Point(0, 0)
        Me.splitContCostCalType.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContCostCalType.Name = "splitContCostCalType"
        '
        'splitContCostCalType.Panel1
        '
        Me.splitContCostCalType.Panel1.Controls.Add(Me.tlpListCostType)
        '
        'splitContCostCalType.Panel2
        '
        Me.splitContCostCalType.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splitContCostCalType.Size = New System.Drawing.Size(1080, 568)
        Me.splitContCostCalType.SplitterDistance = 451
        Me.splitContCostCalType.TabIndex = 3
        '
        'tlpListCostType
        '
        Me.tlpListCostType.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListCostType.ColumnCount = 1
        Me.tlpListCostType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListCostType.Controls.Add(Me.lblListadoCostCalType, 0, 0)
        Me.tlpListCostType.Controls.Add(Me.tlpMatrizList, 0, 1)
        Me.tlpListCostType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListCostType.Location = New System.Drawing.Point(0, 0)
        Me.tlpListCostType.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListCostType.Name = "tlpListCostType"
        Me.tlpListCostType.RowCount = 3
        Me.tlpListCostType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListCostType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListCostType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListCostType.Size = New System.Drawing.Size(451, 568)
        Me.tlpListCostType.TabIndex = 0
        '
        'lblListadoCostCalType
        '
        Me.lblListadoCostCalType.AutoSize = True
        Me.lblListadoCostCalType.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblListadoCostCalType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblListadoCostCalType.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoCostCalType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblListadoCostCalType.Location = New System.Drawing.Point(8, 8)
        Me.lblListadoCostCalType.Margin = New System.Windows.Forms.Padding(8, 8, 4, 0)
        Me.lblListadoCostCalType.Name = "lblListadoCostCalType"
        Me.lblListadoCostCalType.Padding = New System.Windows.Forms.Padding(1)
        Me.lblListadoCostCalType.Size = New System.Drawing.Size(439, 32)
        Me.lblListadoCostCalType.TabIndex = 0
        Me.lblListadoCostCalType.Text = "Listado de Tipo de Costos "
        Me.lblListadoCostCalType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpMatrizList
        '
        Me.tlpMatrizList.ColumnCount = 2
        Me.tlpMatrizList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpMatrizList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMatrizList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMatrizList.Location = New System.Drawing.Point(0, 40)
        Me.tlpMatrizList.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMatrizList.Name = "tlpMatrizList"
        Me.tlpMatrizList.RowCount = 1
        Me.tlpMatrizList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMatrizList.Size = New System.Drawing.Size(451, 30)
        Me.tlpMatrizList.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEdicionCostCalType, 0, 0)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(625, 568)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblEdicionCostCalType
        '
        Me.lblEdicionCostCalType.AutoSize = True
        Me.lblEdicionCostCalType.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblEdicionCostCalType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEdicionCostCalType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEdicionCostCalType.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionCostCalType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEdicionCostCalType.Location = New System.Drawing.Point(4, 8)
        Me.lblEdicionCostCalType.Margin = New System.Windows.Forms.Padding(4, 8, 8, 0)
        Me.lblEdicionCostCalType.Name = "lblEdicionCostCalType"
        Me.lblEdicionCostCalType.Padding = New System.Windows.Forms.Padding(1)
        Me.lblEdicionCostCalType.Size = New System.Drawing.Size(613, 32)
        Me.lblEdicionCostCalType.TabIndex = 0
        Me.lblEdicionCostCalType.Text = "Edición Tipo de Costos "
        Me.lblEdicionCostCalType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 520)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(625, 48)
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
        Me.btnGuardar.Location = New System.Drawing.Point(531, 7)
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
        Me.PanelArea.Size = New System.Drawing.Size(625, 480)
        Me.PanelArea.TabIndex = 15
        '
        'UpPanelEdicion
        '
        Me.UpPanelEdicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.UpPanelEdicion.Controls.Add(Me.tlyPanelEdicion)
        Me.UpPanelEdicion.CornerRadius = 10
        Me.UpPanelEdicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpPanelEdicion.Location = New System.Drawing.Point(6, 6)
        Me.UpPanelEdicion.Margin = New System.Windows.Forms.Padding(2)
        Me.UpPanelEdicion.Name = "UpPanelEdicion"
        Me.UpPanelEdicion.Size = New System.Drawing.Size(613, 468)
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
        Me.tlyPanelEdicion.RowCount = 7
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.Size = New System.Drawing.Size(613, 330)
        Me.tlyPanelEdicion.TabIndex = 6
        '
        'FormAppCostCalType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 568)
        Me.Controls.Add(Me.splitContCostCalType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 309)
        Me.Name = "FormAppCostCalType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipo de costos directos e indirectos"
        Me.splitContCostCalType.Panel1.ResumeLayout(False)
        Me.splitContCostCalType.Panel2.ResumeLayout(False)
        CType(Me.splitContCostCalType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContCostCalType.ResumeLayout(False)
        Me.tlpListCostType.ResumeLayout(False)
        Me.tlpListCostType.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelBotton.ResumeLayout(False)
        Me.PanelArea.ResumeLayout(False)
        Me.UpPanelEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContCostCalType As SplitContainer
    Friend WithEvents tlpListCostType As TableLayoutPanel
    Friend WithEvents lblListadoCostCalType As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblEdicionCostCalType As Label
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelArea As Panel
    Friend WithEvents UpPanelEdicion As UPPanel
    Friend WithEvents tlyPanelEdicion As TableLayoutPanel
    Friend WithEvents tlpMatrizList As TableLayoutPanel
End Class
