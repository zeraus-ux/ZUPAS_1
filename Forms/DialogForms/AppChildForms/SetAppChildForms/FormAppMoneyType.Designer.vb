<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAppMoneyType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAppMoneyType))
        Me.lblEdicionMoneyType = New System.Windows.Forms.Label()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlpEdicionMoney = New System.Windows.Forms.TableLayoutPanel()
        Me.UpPanelEdicion = New UPAZ.UPPanel()
        Me.PanelArea = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblListadoMoney = New System.Windows.Forms.Label()
        Me.PanelLista = New System.Windows.Forms.Panel()
        Me.tlpListMoney = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContMoney = New System.Windows.Forms.SplitContainer()
        Me.PanelBotton.SuspendLayout()
        Me.UpPanelEdicion.SuspendLayout()
        Me.PanelArea.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpListMoney.SuspendLayout()
        CType(Me.splitContMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContMoney.Panel1.SuspendLayout()
        Me.splitContMoney.Panel2.SuspendLayout()
        Me.splitContMoney.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEdicionMoneyType
        '
        Me.lblEdicionMoneyType.AutoSize = True
        Me.lblEdicionMoneyType.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblEdicionMoneyType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEdicionMoneyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEdicionMoneyType.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionMoneyType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEdicionMoneyType.Location = New System.Drawing.Point(4, 8)
        Me.lblEdicionMoneyType.Margin = New System.Windows.Forms.Padding(4, 8, 8, 0)
        Me.lblEdicionMoneyType.Name = "lblEdicionMoneyType"
        Me.lblEdicionMoneyType.Padding = New System.Windows.Forms.Padding(1)
        Me.lblEdicionMoneyType.Size = New System.Drawing.Size(358, 32)
        Me.lblEdicionMoneyType.TabIndex = 0
        Me.lblEdicionMoneyType.Text = "Edición de Monedas"
        Me.lblEdicionMoneyType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 402)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(370, 48)
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
        Me.btnGuardar.Location = New System.Drawing.Point(278, 7)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlpEdicionMoney
        '
        Me.tlpEdicionMoney.ColumnCount = 2
        Me.tlpEdicionMoney.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpEdicionMoney.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEdicionMoney.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEdicionMoney.Location = New System.Drawing.Point(0, 0)
        Me.tlpEdicionMoney.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEdicionMoney.Name = "tlpEdicionMoney"
        Me.tlpEdicionMoney.RowCount = 3
        Me.tlpEdicionMoney.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEdicionMoney.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEdicionMoney.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpEdicionMoney.Size = New System.Drawing.Size(354, 90)
        Me.tlpEdicionMoney.TabIndex = 6
        '
        'UpPanelEdicion
        '
        Me.UpPanelEdicion.AutoSize = True
        Me.UpPanelEdicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.UpPanelEdicion.Controls.Add(Me.tlpEdicionMoney)
        Me.UpPanelEdicion.CornerRadius = 10
        Me.UpPanelEdicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpPanelEdicion.Location = New System.Drawing.Point(6, 6)
        Me.UpPanelEdicion.Margin = New System.Windows.Forms.Padding(2)
        Me.UpPanelEdicion.Name = "UpPanelEdicion"
        Me.UpPanelEdicion.Size = New System.Drawing.Size(354, 346)
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
        Me.PanelArea.Size = New System.Drawing.Size(366, 358)
        Me.PanelArea.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEdicionMoneyType, 0, 0)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(370, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblListadoMoney
        '
        Me.lblListadoMoney.AutoSize = True
        Me.lblListadoMoney.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblListadoMoney.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblListadoMoney.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoMoney.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblListadoMoney.Location = New System.Drawing.Point(8, 8)
        Me.lblListadoMoney.Margin = New System.Windows.Forms.Padding(8, 8, 4, 0)
        Me.lblListadoMoney.Name = "lblListadoMoney"
        Me.lblListadoMoney.Padding = New System.Windows.Forms.Padding(1)
        Me.lblListadoMoney.Size = New System.Drawing.Size(414, 32)
        Me.lblListadoMoney.TabIndex = 0
        Me.lblListadoMoney.Text = "Listado de Monedas Disponibles"
        Me.lblListadoMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelLista
        '
        Me.PanelLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLista.Location = New System.Drawing.Point(8, 48)
        Me.PanelLista.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        Me.PanelLista.Name = "PanelLista"
        Me.PanelLista.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelLista.Size = New System.Drawing.Size(414, 394)
        Me.PanelLista.TabIndex = 1
        '
        'tlpListMoney
        '
        Me.tlpListMoney.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListMoney.ColumnCount = 1
        Me.tlpListMoney.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMoney.Controls.Add(Me.lblListadoMoney, 0, 0)
        Me.tlpListMoney.Controls.Add(Me.PanelLista, 0, 1)
        Me.tlpListMoney.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListMoney.Location = New System.Drawing.Point(0, 0)
        Me.tlpListMoney.Name = "tlpListMoney"
        Me.tlpListMoney.RowCount = 2
        Me.tlpListMoney.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListMoney.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListMoney.Size = New System.Drawing.Size(426, 450)
        Me.tlpListMoney.TabIndex = 0
        '
        'splitContMoney
        '
        Me.splitContMoney.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContMoney.Location = New System.Drawing.Point(0, 0)
        Me.splitContMoney.Name = "splitContMoney"
        '
        'splitContMoney.Panel1
        '
        Me.splitContMoney.Panel1.Controls.Add(Me.tlpListMoney)
        '
        'splitContMoney.Panel2
        '
        Me.splitContMoney.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splitContMoney.Size = New System.Drawing.Size(800, 450)
        Me.splitContMoney.SplitterDistance = 426
        Me.splitContMoney.TabIndex = 2
        '
        'FormAppMoneyType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.splitContMoney)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 309)
        Me.Name = "FormAppMoneyType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormMoney"
        Me.PanelBotton.ResumeLayout(False)
        Me.UpPanelEdicion.ResumeLayout(False)
        Me.PanelArea.ResumeLayout(False)
        Me.PanelArea.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpListMoney.ResumeLayout(False)
        Me.tlpListMoney.PerformLayout()
        Me.splitContMoney.Panel1.ResumeLayout(False)
        Me.splitContMoney.Panel2.ResumeLayout(False)
        CType(Me.splitContMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContMoney.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblEdicionMoneyType As Label
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpEdicionMoney As TableLayoutPanel
    Friend WithEvents UpPanelEdicion As UPPanel
    Friend WithEvents PanelArea As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblListadoMoney As Label
    Friend WithEvents PanelLista As Panel
    Friend WithEvents tlpListMoney As TableLayoutPanel
    Friend WithEvents splitContMoney As SplitContainer
End Class
