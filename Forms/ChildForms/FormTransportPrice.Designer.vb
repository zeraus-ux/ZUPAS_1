<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransportPrice
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
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.PanelArea = New System.Windows.Forms.Panel()
        Me.UpPanelEdicion = New UPAZ.UPPanel()
        Me.tlyPanelEdicion = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListTransport = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListUnit = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContTransport = New System.Windows.Forms.SplitContainer()
        Me.tlpTransportLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLook = New FontAwesome.Sharp.IconButton()
        Me.PanelBotton.SuspendLayout()
        Me.PanelArea.SuspendLayout()
        Me.UpPanelEdicion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpListTransport.SuspendLayout()
        CType(Me.splitContTransport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContTransport.Panel1.SuspendLayout()
        Me.splitContTransport.Panel2.SuspendLayout()
        Me.splitContTransport.SuspendLayout()
        Me.tlpTransportLook.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(2, 537)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(286, 46)
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
        'PanelArea
        '
        Me.PanelArea.Controls.Add(Me.UpPanelEdicion)
        Me.PanelArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelArea.Location = New System.Drawing.Point(2, 42)
        Me.PanelArea.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelArea.Name = "PanelArea"
        Me.PanelArea.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelArea.Size = New System.Drawing.Size(286, 491)
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
        Me.UpPanelEdicion.Size = New System.Drawing.Size(274, 479)
        Me.UpPanelEdicion.TabIndex = 8
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
        Me.tlyPanelEdicion.RowCount = 6
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlyPanelEdicion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlyPanelEdicion.Size = New System.Drawing.Size(274, 195)
        Me.tlyPanelEdicion.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(290, 585)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tlpListTransport
        '
        Me.tlpListTransport.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListTransport.ColumnCount = 1
        Me.tlpListTransport.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListTransport.Controls.Add(Me.tlpListUnit, 0, 1)
        Me.tlpListTransport.Controls.Add(Me.tlpTransportLook, 0, 2)
        Me.tlpListTransport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListTransport.Location = New System.Drawing.Point(0, 0)
        Me.tlpListTransport.Name = "tlpListTransport"
        Me.tlpListTransport.RowCount = 4
        Me.tlpListTransport.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListTransport.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListTransport.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListTransport.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListTransport.Size = New System.Drawing.Size(329, 585)
        Me.tlpListTransport.TabIndex = 0
        '
        'tlpListUnit
        '
        Me.tlpListUnit.ColumnCount = 2
        Me.tlpListUnit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpListUnit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListUnit.Location = New System.Drawing.Point(0, 40)
        Me.tlpListUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListUnit.Name = "tlpListUnit"
        Me.tlpListUnit.RowCount = 1
        Me.tlpListUnit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListUnit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListUnit.Size = New System.Drawing.Size(329, 30)
        Me.tlpListUnit.TabIndex = 1
        '
        'splitContTransport
        '
        Me.splitContTransport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContTransport.Location = New System.Drawing.Point(0, 0)
        Me.splitContTransport.Name = "splitContTransport"
        '
        'splitContTransport.Panel1
        '
        Me.splitContTransport.Panel1.Controls.Add(Me.tlpListTransport)
        '
        'splitContTransport.Panel2
        '
        Me.splitContTransport.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splitContTransport.Size = New System.Drawing.Size(623, 585)
        Me.splitContTransport.SplitterDistance = 329
        Me.splitContTransport.TabIndex = 3
        '
        'tlpTransportLook
        '
        Me.tlpTransportLook.ColumnCount = 2
        Me.tlpTransportLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTransportLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpTransportLook.Controls.Add(Me.btnLook, 1, 0)
        Me.tlpTransportLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTransportLook.Location = New System.Drawing.Point(0, 70)
        Me.tlpTransportLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTransportLook.Name = "tlpTransportLook"
        Me.tlpTransportLook.RowCount = 1
        Me.tlpTransportLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTransportLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTransportLook.Size = New System.Drawing.Size(329, 40)
        Me.tlpTransportLook.TabIndex = 2
        '
        'btnLook
        '
        Me.btnLook.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLook.FlatAppearance.BorderSize = 0
        Me.btnLook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLook.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLook.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnLook.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnLook.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLook.IconSize = 28
        Me.btnLook.Location = New System.Drawing.Point(289, 0)
        Me.btnLook.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLook.Name = "btnLook"
        Me.btnLook.Size = New System.Drawing.Size(40, 40)
        Me.btnLook.TabIndex = 0
        Me.btnLook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLook.UseVisualStyleBackColor = False
        '
        'FormTransportPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 585)
        Me.Controls.Add(Me.splitContTransport)
        Me.Name = "FormTransportPrice"
        Me.Text = "FormTransportPrice"
        Me.PanelBotton.ResumeLayout(False)
        Me.PanelArea.ResumeLayout(False)
        Me.UpPanelEdicion.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tlpListTransport.ResumeLayout(False)
        Me.splitContTransport.Panel1.ResumeLayout(False)
        Me.splitContTransport.Panel2.ResumeLayout(False)
        CType(Me.splitContTransport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContTransport.ResumeLayout(False)
        Me.tlpTransportLook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelArea As Panel
    Friend WithEvents UpPanelEdicion As UPPanel
    Friend WithEvents tlyPanelEdicion As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tlpListTransport As TableLayoutPanel
    Friend WithEvents splitContTransport As SplitContainer
    Friend WithEvents tlpListUnit As TableLayoutPanel
    Friend WithEvents tlpTransportLook As TableLayoutPanel
    Friend WithEvents btnLook As FontAwesome.Sharp.IconButton
End Class
