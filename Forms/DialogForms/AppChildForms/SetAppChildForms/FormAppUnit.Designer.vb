<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAppUnit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAppUnit))
        Me.lblEdicionUnidades = New System.Windows.Forms.Label()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.PanelArea = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblListadoUnidades = New System.Windows.Forms.Label()
        Me.PanelLista = New System.Windows.Forms.Panel()
        Me.tlpUnitLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnUnitFilter = New FontAwesome.Sharp.IconButton()
        Me.tlpListUnit = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContUnit = New System.Windows.Forms.SplitContainer()
        Me.UpPanelEdicion = New UPAZ.UPPanel()
        Me.tlyPanelCheck = New System.Windows.Forms.TableLayoutPanel()
        Me.tlyPanelEdicion = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelBotton.SuspendLayout()
        Me.PanelArea.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelLista.SuspendLayout()
        Me.tlpUnitLook.SuspendLayout()
        Me.tlpListUnit.SuspendLayout()
        CType(Me.splitContUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContUnit.Panel1.SuspendLayout()
        Me.splitContUnit.Panel2.SuspendLayout()
        Me.splitContUnit.SuspendLayout()
        Me.UpPanelEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEdicionUnidades
        '
        Me.lblEdicionUnidades.AutoSize = True
        Me.lblEdicionUnidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblEdicionUnidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEdicionUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEdicionUnidades.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionUnidades.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEdicionUnidades.Location = New System.Drawing.Point(4, 8)
        Me.lblEdicionUnidades.Margin = New System.Windows.Forms.Padding(4, 8, 8, 0)
        Me.lblEdicionUnidades.Name = "lblEdicionUnidades"
        Me.lblEdicionUnidades.Padding = New System.Windows.Forms.Padding(1)
        Me.lblEdicionUnidades.Size = New System.Drawing.Size(491, 32)
        Me.lblEdicionUnidades.TabIndex = 0
        Me.lblEdicionUnidades.Text = "Edición de Unidades"
        Me.lblEdicionUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 529)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(503, 50)
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
        Me.btnGuardar.Location = New System.Drawing.Point(411, 9)
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
        Me.PanelArea.Location = New System.Drawing.Point(2, 42)
        Me.PanelArea.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelArea.Name = "PanelArea"
        Me.PanelArea.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelArea.Size = New System.Drawing.Size(499, 485)
        Me.PanelArea.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEdicionUnidades, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelBotton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelArea, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 579)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblListadoUnidades
        '
        Me.lblListadoUnidades.AutoSize = True
        Me.lblListadoUnidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblListadoUnidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblListadoUnidades.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoUnidades.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblListadoUnidades.Location = New System.Drawing.Point(8, 8)
        Me.lblListadoUnidades.Margin = New System.Windows.Forms.Padding(8, 8, 4, 0)
        Me.lblListadoUnidades.Name = "lblListadoUnidades"
        Me.lblListadoUnidades.Padding = New System.Windows.Forms.Padding(1)
        Me.lblListadoUnidades.Size = New System.Drawing.Size(565, 32)
        Me.lblListadoUnidades.TabIndex = 0
        Me.lblListadoUnidades.Text = "Listado de Unidades"
        Me.lblListadoUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelLista
        '
        Me.PanelLista.Controls.Add(Me.tlpUnitLook)
        Me.PanelLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLista.Location = New System.Drawing.Point(0, 40)
        Me.PanelLista.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelLista.Name = "PanelLista"
        Me.PanelLista.Size = New System.Drawing.Size(577, 40)
        Me.PanelLista.TabIndex = 1
        '
        'tlpUnitLook
        '
        Me.tlpUnitLook.ColumnCount = 2
        Me.tlpUnitLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUnitLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUnitLook.Controls.Add(Me.btnUnitFilter, 1, 0)
        Me.tlpUnitLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUnitLook.Location = New System.Drawing.Point(0, 0)
        Me.tlpUnitLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpUnitLook.Name = "tlpUnitLook"
        Me.tlpUnitLook.RowCount = 1
        Me.tlpUnitLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUnitLook.Size = New System.Drawing.Size(577, 40)
        Me.tlpUnitLook.TabIndex = 1
        '
        'btnUnitFilter
        '
        Me.btnUnitFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUnitFilter.FlatAppearance.BorderSize = 0
        Me.btnUnitFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnitFilter.ForeColor = System.Drawing.Color.Transparent
        Me.btnUnitFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnUnitFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnUnitFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUnitFilter.IconSize = 28
        Me.btnUnitFilter.Location = New System.Drawing.Point(537, 8)
        Me.btnUnitFilter.Margin = New System.Windows.Forms.Padding(0, 8, 4, 4)
        Me.btnUnitFilter.Name = "btnUnitFilter"
        Me.btnUnitFilter.Size = New System.Drawing.Size(36, 28)
        Me.btnUnitFilter.TabIndex = 0
        Me.btnUnitFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUnitFilter.UseVisualStyleBackColor = True
        '
        'tlpListUnit
        '
        Me.tlpListUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListUnit.ColumnCount = 1
        Me.tlpListUnit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListUnit.Controls.Add(Me.lblListadoUnidades, 0, 0)
        Me.tlpListUnit.Controls.Add(Me.PanelLista, 0, 1)
        Me.tlpListUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListUnit.Location = New System.Drawing.Point(0, 0)
        Me.tlpListUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListUnit.Name = "tlpListUnit"
        Me.tlpListUnit.RowCount = 3
        Me.tlpListUnit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListUnit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListUnit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListUnit.Size = New System.Drawing.Size(577, 579)
        Me.tlpListUnit.TabIndex = 0
        '
        'splitContUnit
        '
        Me.splitContUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContUnit.Location = New System.Drawing.Point(0, 0)
        Me.splitContUnit.Name = "splitContUnit"
        '
        'splitContUnit.Panel1
        '
        Me.splitContUnit.Panel1.Controls.Add(Me.tlpListUnit)
        '
        'splitContUnit.Panel2
        '
        Me.splitContUnit.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splitContUnit.Size = New System.Drawing.Size(1084, 579)
        Me.splitContUnit.SplitterDistance = 577
        Me.splitContUnit.TabIndex = 1
        '
        'UpPanelEdicion
        '
        Me.UpPanelEdicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.UpPanelEdicion.Controls.Add(Me.tlyPanelCheck)
        Me.UpPanelEdicion.Controls.Add(Me.tlyPanelEdicion)
        Me.UpPanelEdicion.CornerRadius = 10
        Me.UpPanelEdicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpPanelEdicion.Location = New System.Drawing.Point(6, 6)
        Me.UpPanelEdicion.Margin = New System.Windows.Forms.Padding(2)
        Me.UpPanelEdicion.Name = "UpPanelEdicion"
        Me.UpPanelEdicion.Size = New System.Drawing.Size(487, 473)
        Me.UpPanelEdicion.TabIndex = 8
        '
        'tlyPanelCheck
        '
        Me.tlyPanelCheck.ColumnCount = 3
        Me.tlyPanelCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.tlyPanelCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlyPanelCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlyPanelCheck.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlyPanelCheck.Location = New System.Drawing.Point(0, 180)
        Me.tlyPanelCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.tlyPanelCheck.Name = "tlyPanelCheck"
        Me.tlyPanelCheck.RowCount = 3
        Me.tlyPanelCheck.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlyPanelCheck.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlyPanelCheck.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlyPanelCheck.Size = New System.Drawing.Size(487, 180)
        Me.tlyPanelCheck.TabIndex = 7
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
        Me.tlyPanelEdicion.RowCount = 6
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlyPanelEdicion.Size = New System.Drawing.Size(487, 180)
        Me.tlyPanelEdicion.TabIndex = 6
        '
        'FormAppUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 579)
        Me.Controls.Add(Me.splitContUnit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 309)
        Me.Name = "FormAppUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unidades"
        Me.PanelBotton.ResumeLayout(False)
        Me.PanelArea.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelLista.ResumeLayout(False)
        Me.tlpUnitLook.ResumeLayout(False)
        Me.tlpListUnit.ResumeLayout(False)
        Me.tlpListUnit.PerformLayout()
        Me.splitContUnit.Panel1.ResumeLayout(False)
        Me.splitContUnit.Panel2.ResumeLayout(False)
        CType(Me.splitContUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContUnit.ResumeLayout(False)
        Me.UpPanelEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEdicionUnidades As Label
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlyPanelEdicion As TableLayoutPanel
    Friend WithEvents UpPanelEdicion As UPPanel
    Friend WithEvents PanelArea As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblListadoUnidades As Label
    Friend WithEvents PanelLista As Panel
    Friend WithEvents tlpListUnit As TableLayoutPanel
    Friend WithEvents splitContUnit As SplitContainer
    Friend WithEvents tlyPanelCheck As TableLayoutPanel
    Friend WithEvents tlpUnitLook As TableLayoutPanel
    Friend WithEvents btnUnitFilter As FontAwesome.Sharp.IconButton
End Class
