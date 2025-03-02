<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FomEqmtPriceEst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FomEqmtPriceEst))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnReportAPU = New FontAwesome.Sharp.IconButton()
        Me.btnCostos = New FontAwesome.Sharp.IconButton()
        Me.btnPreView = New FontAwesome.Sharp.IconButton()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.tlpEqmPriceEstHead = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.scEqmtPriceEst = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpEqmPriceEstHead.SuspendLayout()
        CType(Me.scEqmtPriceEst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scEqmtPriceEst.Panel1.SuspendLayout()
        Me.scEqmtPriceEst.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpEqmPriceEstHead, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(807, 731)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelButton.Controls.Add(Me.btnReportAPU)
        Me.PanelButton.Controls.Add(Me.btnCostos)
        Me.PanelButton.Controls.Add(Me.btnPreView)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(807, 30)
        Me.PanelButton.TabIndex = 5
        '
        'btnReportAPU
        '
        Me.btnReportAPU.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReportAPU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportAPU.FlatAppearance.BorderSize = 0
        Me.btnReportAPU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportAPU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportAPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportAPU.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnReportAPU.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportAPU.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportAPU.IconSize = 28
        Me.btnReportAPU.Location = New System.Drawing.Point(80, 2)
        Me.btnReportAPU.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReportAPU.Name = "btnReportAPU"
        Me.btnReportAPU.Size = New System.Drawing.Size(27, 27)
        Me.btnReportAPU.TabIndex = 18
        Me.btnReportAPU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportAPU.UseVisualStyleBackColor = False
        '
        'btnCostos
        '
        Me.btnCostos.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCostos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCostos.FlatAppearance.BorderSize = 0
        Me.btnCostos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCostos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCostos.IconChar = FontAwesome.Sharp.IconChar.C
        Me.btnCostos.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCostos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCostos.IconSize = 28
        Me.btnCostos.Location = New System.Drawing.Point(8, 2)
        Me.btnCostos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.Size = New System.Drawing.Size(27, 27)
        Me.btnCostos.TabIndex = 1
        Me.btnCostos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCostos.UseVisualStyleBackColor = False
        '
        'btnPreView
        '
        Me.btnPreView.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPreView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPreView.FlatAppearance.BorderSize = 0
        Me.btnPreView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnPreView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnPreView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreView.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPreView.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnPreView.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPreView.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPreView.IconSize = 28
        Me.btnPreView.Location = New System.Drawing.Point(44, 2)
        Me.btnPreView.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPreView.Name = "btnPreView"
        Me.btnPreView.Size = New System.Drawing.Size(27, 27)
        Me.btnPreView.TabIndex = 0
        Me.btnPreView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreView.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnCerrar, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 683)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(807, 48)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Cancel
        Me.btnCerrar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCerrar.IconSize = 28
        Me.btnCerrar.Location = New System.Drawing.Point(714, 8)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(85, 32)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'tlpEqmPriceEstHead
        '
        Me.tlpEqmPriceEstHead.ColumnCount = 1
        Me.tlpEqmPriceEstHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEqmPriceEstHead.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.tlpEqmPriceEstHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEqmPriceEstHead.Location = New System.Drawing.Point(0, 31)
        Me.tlpEqmPriceEstHead.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEqmPriceEstHead.Name = "tlpEqmPriceEstHead"
        Me.tlpEqmPriceEstHead.RowCount = 2
        Me.tlpEqmPriceEstHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpEqmPriceEstHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEqmPriceEstHead.Size = New System.Drawing.Size(807, 170)
        Me.tlpEqmPriceEstHead.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 40)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(807, 130)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'scEqmtPriceEst
        '
        Me.scEqmtPriceEst.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scEqmtPriceEst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scEqmtPriceEst.Location = New System.Drawing.Point(0, 0)
        Me.scEqmtPriceEst.Margin = New System.Windows.Forms.Padding(0)
        Me.scEqmtPriceEst.Name = "scEqmtPriceEst"
        '
        'scEqmtPriceEst.Panel1
        '
        Me.scEqmtPriceEst.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'scEqmtPriceEst.Panel2
        '
        Me.scEqmtPriceEst.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.scEqmtPriceEst.Size = New System.Drawing.Size(1185, 731)
        Me.scEqmtPriceEst.SplitterDistance = 807
        Me.scEqmtPriceEst.TabIndex = 3
        '
        'FomEqmtPriceEst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1185, 731)
        Me.Controls.Add(Me.scEqmtPriceEst)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FomEqmtPriceEst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FomEqmtPriceEst"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelButton.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpEqmPriceEstHead.ResumeLayout(False)
        Me.scEqmtPriceEst.Panel1.ResumeLayout(False)
        CType(Me.scEqmtPriceEst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scEqmtPriceEst.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents scEqmtPriceEst As SplitContainer
    Friend WithEvents PanelButton As Panel
    Friend WithEvents btnReportAPU As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCostos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPreView As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpEqmPriceEstHead As TableLayoutPanel
End Class
