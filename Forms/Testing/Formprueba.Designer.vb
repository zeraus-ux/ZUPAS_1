<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formprueba
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
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.lblEdicionObra = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelComputos = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UpPPartidas = New UPAZ.UPPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblListadoObra = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlpListObra = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContObra = New System.Windows.Forms.SplitContainer()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.UpPPartidas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tlpListObra.SuspendLayout()
        CType(Me.splitContObra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContObra.Panel1.SuspendLayout()
        Me.splitContObra.Panel2.SuspendLayout()
        Me.splitContObra.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnGuardar.Location = New System.Drawing.Point(227, 448)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(91, 35)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblEdicionObra
        '
        Me.lblEdicionObra.AutoSize = True
        Me.lblEdicionObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblEdicionObra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEdicionObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEdicionObra.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionObra.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEdicionObra.Location = New System.Drawing.Point(4, 8)
        Me.lblEdicionObra.Margin = New System.Windows.Forms.Padding(4, 8, 8, 0)
        Me.lblEdicionObra.Name = "lblEdicionObra"
        Me.lblEdicionObra.Padding = New System.Windows.Forms.Padding(1)
        Me.lblEdicionObra.Size = New System.Drawing.Size(306, 32)
        Me.lblEdicionObra.TabIndex = 0
        Me.lblEdicionObra.Text = "Formulación de Obra"
        Me.lblEdicionObra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.PanelComputos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 164)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(314, 276)
        Me.Panel3.TabIndex = 9
        '
        'PanelComputos
        '
        Me.PanelComputos.Location = New System.Drawing.Point(25, 35)
        Me.PanelComputos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelComputos.Name = "PanelComputos"
        Me.PanelComputos.Size = New System.Drawing.Size(228, 103)
        Me.PanelComputos.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnGuardar, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEdicionObra, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UpPPartidas, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(318, 483)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'UpPPartidas
        '
        Me.UpPPartidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.UpPPartidas.Controls.Add(Me.TableLayoutPanel2)
        Me.UpPPartidas.CornerRadius = 10
        Me.UpPPartidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpPPartidas.Location = New System.Drawing.Point(2, 42)
        Me.UpPPartidas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UpPPartidas.Name = "UpPPartidas"
        Me.UpPPartidas.Size = New System.Drawing.Size(314, 118)
        Me.UpPPartidas.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(56, 29)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.67568!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.97297!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(233, 74)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(6, 83)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(133, 79)
        Me.Panel5.TabIndex = 2
        '
        'lblListadoObra
        '
        Me.lblListadoObra.AutoSize = True
        Me.lblListadoObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblListadoObra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblListadoObra.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoObra.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblListadoObra.Location = New System.Drawing.Point(8, 8)
        Me.lblListadoObra.Margin = New System.Windows.Forms.Padding(8, 8, 4, 0)
        Me.lblListadoObra.Name = "lblListadoObra"
        Me.lblListadoObra.Padding = New System.Windows.Forms.Padding(1)
        Me.lblListadoObra.Size = New System.Drawing.Size(137, 32)
        Me.lblListadoObra.TabIndex = 0
        Me.lblListadoObra.Text = "Listado de Obras"
        Me.lblListadoObra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(2, 42)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Panel1.Size = New System.Drawing.Size(145, 324)
        Me.Panel1.TabIndex = 1
        '
        'tlpListObra
        '
        Me.tlpListObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListObra.ColumnCount = 1
        Me.tlpListObra.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListObra.Controls.Add(Me.lblListadoObra, 0, 0)
        Me.tlpListObra.Controls.Add(Me.Panel1, 0, 1)
        Me.tlpListObra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListObra.Location = New System.Drawing.Point(0, 0)
        Me.tlpListObra.Name = "tlpListObra"
        Me.tlpListObra.RowCount = 2
        Me.tlpListObra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListObra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListObra.Size = New System.Drawing.Size(149, 483)
        Me.tlpListObra.TabIndex = 0
        '
        'splitContObra
        '
        Me.splitContObra.BackColor = System.Drawing.SystemColors.Control
        Me.splitContObra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContObra.Location = New System.Drawing.Point(0, 0)
        Me.splitContObra.Name = "splitContObra"
        '
        'splitContObra.Panel1
        '
        Me.splitContObra.Panel1.Controls.Add(Me.tlpListObra)
        '
        'splitContObra.Panel2
        '
        Me.splitContObra.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splitContObra.Size = New System.Drawing.Size(471, 483)
        Me.splitContObra.SplitterDistance = 149
        Me.splitContObra.TabIndex = 3
        '
        'Formprueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 483)
        Me.Controls.Add(Me.splitContObra)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Formprueba"
        Me.Text = "Formprueba"
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.UpPPartidas.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.tlpListObra.ResumeLayout(False)
        Me.tlpListObra.PerformLayout()
        Me.splitContObra.Panel1.ResumeLayout(False)
        Me.splitContObra.Panel2.ResumeLayout(False)
        CType(Me.splitContObra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContObra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents lblEdicionObra As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents UpPPartidas As UPPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblListadoObra As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tlpListObra As TableLayoutPanel
    Friend WithEvents splitContObra As SplitContainer
    Friend WithEvents PanelComputos As Panel
End Class
