<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransport
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
        Me.lblEdicionTransport = New System.Windows.Forms.Label()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlyPanelEdicion = New System.Windows.Forms.TableLayoutPanel()
        Me.UpPanelEdicion = New UPAZ.UPPanel()
        Me.PanelArea = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblListadoTransport = New System.Windows.Forms.Label()
        Me.tlpListMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContTransport = New System.Windows.Forms.SplitContainer()
        Me.PanelBotton.SuspendLayout()
        Me.UpPanelEdicion.SuspendLayout()
        Me.PanelArea.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpListMaterial.SuspendLayout()
        CType(Me.splitContTransport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContTransport.Panel1.SuspendLayout()
        Me.splitContTransport.Panel2.SuspendLayout()
        Me.splitContTransport.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEdicionTransport
        '
        Me.lblEdicionTransport.AutoSize = True
        Me.lblEdicionTransport.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblEdicionTransport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEdicionTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEdicionTransport.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionTransport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEdicionTransport.Location = New System.Drawing.Point(4, 8)
        Me.lblEdicionTransport.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.lblEdicionTransport.Name = "lblEdicionTransport"
        Me.lblEdicionTransport.Padding = New System.Windows.Forms.Padding(1)
        Me.lblEdicionTransport.Size = New System.Drawing.Size(277, 24)
        Me.lblEdicionTransport.TabIndex = 0
        Me.lblEdicionTransport.Text = "Edición de Transporte"
        Me.lblEdicionTransport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(2, 547)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(285, 46)
        Me.PanelBotton.TabIndex = 6
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.IconSize = 20
        Me.btnGuardar.Location = New System.Drawing.Point(193, 5)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(91, 35)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlyPanelEdicion
        '
        Me.tlyPanelEdicion.ColumnCount = 2
        Me.tlyPanelEdicion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlyPanelEdicion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlyPanelEdicion.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlyPanelEdicion.Location = New System.Drawing.Point(0, 0)
        Me.tlyPanelEdicion.Margin = New System.Windows.Forms.Padding(0)
        Me.tlyPanelEdicion.Name = "tlyPanelEdicion"
        Me.tlyPanelEdicion.RowCount = 3
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlyPanelEdicion.Size = New System.Drawing.Size(273, 98)
        Me.tlyPanelEdicion.TabIndex = 6
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
        Me.UpPanelEdicion.Size = New System.Drawing.Size(273, 489)
        Me.UpPanelEdicion.TabIndex = 8
        '
        'PanelArea
        '
        Me.PanelArea.Controls.Add(Me.UpPanelEdicion)
        Me.PanelArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelArea.Location = New System.Drawing.Point(2, 42)
        Me.PanelArea.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelArea.Name = "PanelArea"
        Me.PanelArea.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelArea.Size = New System.Drawing.Size(285, 501)
        Me.PanelArea.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEdicionTransport, 0, 0)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(289, 595)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblListadoTransport
        '
        Me.lblListadoTransport.AutoSize = True
        Me.lblListadoTransport.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblListadoTransport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblListadoTransport.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoTransport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblListadoTransport.Location = New System.Drawing.Point(8, 8)
        Me.lblListadoTransport.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        Me.lblListadoTransport.Name = "lblListadoTransport"
        Me.lblListadoTransport.Padding = New System.Windows.Forms.Padding(1)
        Me.lblListadoTransport.Size = New System.Drawing.Size(323, 24)
        Me.lblListadoTransport.TabIndex = 0
        Me.lblListadoTransport.Text = "Listado de Transporte"
        Me.lblListadoTransport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpListMaterial
        '
        Me.tlpListMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListMaterial.ColumnCount = 1
        Me.tlpListMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMaterial.Controls.Add(Me.lblListadoTransport, 0, 0)
        Me.tlpListMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListMaterial.Location = New System.Drawing.Point(0, 0)
        Me.tlpListMaterial.Name = "tlpListMaterial"
        Me.tlpListMaterial.RowCount = 2
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMaterial.Size = New System.Drawing.Size(335, 595)
        Me.tlpListMaterial.TabIndex = 0
        '
        'splitContTransport
        '
        Me.splitContTransport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContTransport.Location = New System.Drawing.Point(0, 0)
        Me.splitContTransport.Name = "splitContTransport"
        '
        'splitContTransport.Panel1
        '
        Me.splitContTransport.Panel1.Controls.Add(Me.tlpListMaterial)
        '
        'splitContTransport.Panel2
        '
        Me.splitContTransport.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splitContTransport.Size = New System.Drawing.Size(628, 595)
        Me.splitContTransport.SplitterDistance = 335
        Me.splitContTransport.TabIndex = 1
        '
        'FormTransport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 595)
        Me.Controls.Add(Me.splitContTransport)
        Me.Name = "FormTransport"
        Me.Text = "FormTransport"
        Me.PanelBotton.ResumeLayout(False)
        Me.UpPanelEdicion.ResumeLayout(False)
        Me.PanelArea.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpListMaterial.ResumeLayout(False)
        Me.tlpListMaterial.PerformLayout()
        Me.splitContTransport.Panel1.ResumeLayout(False)
        Me.splitContTransport.Panel2.ResumeLayout(False)
        CType(Me.splitContTransport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContTransport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEdicionTransport As Label
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlyPanelEdicion As TableLayoutPanel
    Friend WithEvents UpPanelEdicion As UPPanel
    Friend WithEvents PanelArea As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblListadoTransport As Label
    Friend WithEvents tlpListMaterial As TableLayoutPanel
    Friend WithEvents splitContTransport As SplitContainer
End Class
