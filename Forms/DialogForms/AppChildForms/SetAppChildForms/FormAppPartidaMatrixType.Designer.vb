<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAppPartidaMatrixType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAppPartidaMatrixType))
        Me.lblEdicionAPUType = New System.Windows.Forms.Label()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlpEdicionProjectMatrix = New System.Windows.Forms.TableLayoutPanel()
        Me.UpPanelEdicion = New UPAZ.UPPanel()
        Me.PanelArea = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblListadoMatrizAPU = New System.Windows.Forms.Label()
        Me.PanelLista = New System.Windows.Forms.Panel()
        Me.tlpListMatrixProjectType = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContPartidaType = New System.Windows.Forms.SplitContainer()
        Me.PanelBotton.SuspendLayout()
        Me.UpPanelEdicion.SuspendLayout()
        Me.PanelArea.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpListMatrixProjectType.SuspendLayout()
        CType(Me.splitContPartidaType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContPartidaType.Panel1.SuspendLayout()
        Me.splitContPartidaType.Panel2.SuspendLayout()
        Me.splitContPartidaType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEdicionAPUType
        '
        Me.lblEdicionAPUType.AutoSize = True
        Me.lblEdicionAPUType.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblEdicionAPUType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEdicionAPUType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEdicionAPUType.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionAPUType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEdicionAPUType.Location = New System.Drawing.Point(4, 8)
        Me.lblEdicionAPUType.Margin = New System.Windows.Forms.Padding(4, 8, 8, 0)
        Me.lblEdicionAPUType.Name = "lblEdicionAPUType"
        Me.lblEdicionAPUType.Padding = New System.Windows.Forms.Padding(1)
        Me.lblEdicionAPUType.Size = New System.Drawing.Size(490, 32)
        Me.lblEdicionAPUType.TabIndex = 0
        Me.lblEdicionAPUType.Text = "Edición de Tipo de Matriz para APU"
        Me.lblEdicionAPUType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 531)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(502, 48)
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
        Me.btnGuardar.Location = New System.Drawing.Point(410, 7)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlpEdicionProjectMatrix
        '
        Me.tlpEdicionProjectMatrix.ColumnCount = 2
        Me.tlpEdicionProjectMatrix.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEdicionProjectMatrix.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionProjectMatrix.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEdicionProjectMatrix.Location = New System.Drawing.Point(0, 0)
        Me.tlpEdicionProjectMatrix.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEdicionProjectMatrix.Name = "tlpEdicionProjectMatrix"
        Me.tlpEdicionProjectMatrix.RowCount = 3
        Me.tlpEdicionProjectMatrix.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEdicionProjectMatrix.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEdicionProjectMatrix.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpEdicionProjectMatrix.Size = New System.Drawing.Size(486, 120)
        Me.tlpEdicionProjectMatrix.TabIndex = 6
        '
        'UpPanelEdicion
        '
        Me.UpPanelEdicion.AutoSize = True
        Me.UpPanelEdicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.UpPanelEdicion.Controls.Add(Me.tlpEdicionProjectMatrix)
        Me.UpPanelEdicion.CornerRadius = 10
        Me.UpPanelEdicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpPanelEdicion.Location = New System.Drawing.Point(6, 6)
        Me.UpPanelEdicion.Margin = New System.Windows.Forms.Padding(2)
        Me.UpPanelEdicion.Name = "UpPanelEdicion"
        Me.UpPanelEdicion.Size = New System.Drawing.Size(486, 475)
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
        Me.PanelArea.Size = New System.Drawing.Size(498, 487)
        Me.PanelArea.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEdicionAPUType, 0, 0)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(502, 579)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblListadoMatrizAPU
        '
        Me.lblListadoMatrizAPU.AutoSize = True
        Me.lblListadoMatrizAPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblListadoMatrizAPU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblListadoMatrizAPU.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoMatrizAPU.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblListadoMatrizAPU.Location = New System.Drawing.Point(8, 8)
        Me.lblListadoMatrizAPU.Margin = New System.Windows.Forms.Padding(8, 8, 4, 0)
        Me.lblListadoMatrizAPU.Name = "lblListadoMatrizAPU"
        Me.lblListadoMatrizAPU.Padding = New System.Windows.Forms.Padding(1)
        Me.lblListadoMatrizAPU.Size = New System.Drawing.Size(566, 32)
        Me.lblListadoMatrizAPU.TabIndex = 0
        Me.lblListadoMatrizAPU.Text = "Listado de Matrices para APU"
        Me.lblListadoMatrizAPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelLista
        '
        Me.PanelLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLista.Location = New System.Drawing.Point(8, 48)
        Me.PanelLista.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        Me.PanelLista.Name = "PanelLista"
        Me.PanelLista.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelLista.Size = New System.Drawing.Size(566, 523)
        Me.PanelLista.TabIndex = 1
        '
        'tlpListMatrixProjectType
        '
        Me.tlpListMatrixProjectType.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListMatrixProjectType.ColumnCount = 1
        Me.tlpListMatrixProjectType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMatrixProjectType.Controls.Add(Me.lblListadoMatrizAPU, 0, 0)
        Me.tlpListMatrixProjectType.Controls.Add(Me.PanelLista, 0, 1)
        Me.tlpListMatrixProjectType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListMatrixProjectType.Location = New System.Drawing.Point(0, 0)
        Me.tlpListMatrixProjectType.Name = "tlpListMatrixProjectType"
        Me.tlpListMatrixProjectType.RowCount = 2
        Me.tlpListMatrixProjectType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListMatrixProjectType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMatrixProjectType.Size = New System.Drawing.Size(578, 579)
        Me.tlpListMatrixProjectType.TabIndex = 0
        '
        'splitContPartidaType
        '
        Me.splitContPartidaType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContPartidaType.Location = New System.Drawing.Point(0, 0)
        Me.splitContPartidaType.Name = "splitContPartidaType"
        '
        'splitContPartidaType.Panel1
        '
        Me.splitContPartidaType.Panel1.Controls.Add(Me.tlpListMatrixProjectType)
        '
        'splitContPartidaType.Panel2
        '
        Me.splitContPartidaType.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splitContPartidaType.Size = New System.Drawing.Size(1084, 579)
        Me.splitContPartidaType.SplitterDistance = 578
        Me.splitContPartidaType.TabIndex = 1
        '
        'FormAppPartidaMatrixType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 579)
        Me.Controls.Add(Me.splitContPartidaType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 309)
        Me.Name = "FormAppPartidaMatrixType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipo de Matriz"
        Me.PanelBotton.ResumeLayout(False)
        Me.UpPanelEdicion.ResumeLayout(False)
        Me.PanelArea.ResumeLayout(False)
        Me.PanelArea.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpListMatrixProjectType.ResumeLayout(False)
        Me.tlpListMatrixProjectType.PerformLayout()
        Me.splitContPartidaType.Panel1.ResumeLayout(False)
        Me.splitContPartidaType.Panel2.ResumeLayout(False)
        CType(Me.splitContPartidaType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContPartidaType.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEdicionAPUType As Label
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpEdicionProjectMatrix As TableLayoutPanel
    Friend WithEvents UpPanelEdicion As UPPanel
    Friend WithEvents PanelArea As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblListadoMatrizAPU As Label
    Friend WithEvents PanelLista As Panel
    Friend WithEvents tlpListMatrixProjectType As TableLayoutPanel
    Friend WithEvents splitContPartidaType As SplitContainer
End Class
