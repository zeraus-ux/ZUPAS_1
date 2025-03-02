<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAppMoneyChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAppMoneyChange))
        Me.tlpConversionMoney = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.tlpfootAppMoneyChange = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.tlplConversionMoney2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpConversionMoney.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.tlpfootAppMoneyChange.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpConversionMoney
        '
        Me.tlpConversionMoney.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpConversionMoney.ColumnCount = 1
        Me.tlpConversionMoney.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpConversionMoney.Controls.Add(Me.PanelButton, 0, 2)
        Me.tlpConversionMoney.Controls.Add(Me.tlplConversionMoney2, 0, 1)
        Me.tlpConversionMoney.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpConversionMoney.Location = New System.Drawing.Point(0, 0)
        Me.tlpConversionMoney.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpConversionMoney.Name = "tlpConversionMoney"
        Me.tlpConversionMoney.RowCount = 3
        Me.tlpConversionMoney.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpConversionMoney.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpConversionMoney.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpConversionMoney.Size = New System.Drawing.Size(684, 478)
        Me.tlpConversionMoney.TabIndex = 2
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.tlpfootAppMoneyChange)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelButton.Location = New System.Drawing.Point(0, 430)
        Me.PanelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(684, 48)
        Me.PanelButton.TabIndex = 8
        '
        'tlpfootAppMoneyChange
        '
        Me.tlpfootAppMoneyChange.ColumnCount = 3
        Me.tlpfootAppMoneyChange.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpfootAppMoneyChange.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpfootAppMoneyChange.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpfootAppMoneyChange.Controls.Add(Me.btnGuardar, 2, 0)
        Me.tlpfootAppMoneyChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpfootAppMoneyChange.Location = New System.Drawing.Point(0, 0)
        Me.tlpfootAppMoneyChange.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpfootAppMoneyChange.Name = "tlpfootAppMoneyChange"
        Me.tlpfootAppMoneyChange.RowCount = 1
        Me.tlpfootAppMoneyChange.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpfootAppMoneyChange.Size = New System.Drawing.Size(684, 48)
        Me.tlpfootAppMoneyChange.TabIndex = 0
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
        Me.btnGuardar.Location = New System.Drawing.Point(591, 8)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 8, 8, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tlplConversionMoney2
        '
        Me.tlplConversionMoney2.ColumnCount = 3
        Me.tlplConversionMoney2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlplConversionMoney2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlplConversionMoney2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlplConversionMoney2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlplConversionMoney2.Location = New System.Drawing.Point(0, 40)
        Me.tlplConversionMoney2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlplConversionMoney2.Name = "tlplConversionMoney2"
        Me.tlplConversionMoney2.RowCount = 13
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlplConversionMoney2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlplConversionMoney2.Size = New System.Drawing.Size(684, 390)
        Me.tlplConversionMoney2.TabIndex = 9
        '
        'FormAppMoneyChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 478)
        Me.Controls.Add(Me.tlpConversionMoney)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 309)
        Me.Name = "FormAppMoneyChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormAppMoneyChange"
        Me.tlpConversionMoney.ResumeLayout(False)
        Me.PanelButton.ResumeLayout(False)
        Me.tlpfootAppMoneyChange.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpConversionMoney As TableLayoutPanel
    Friend WithEvents PanelButton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlplConversionMoney2 As TableLayoutPanel
    Friend WithEvents tlpfootAppMoneyChange As TableLayoutPanel
End Class
