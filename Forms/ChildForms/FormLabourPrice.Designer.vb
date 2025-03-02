<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLabourPrice
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
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.tlpLabourEdition = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLabourEdition2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListLabour = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListUnit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLabourPriceLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLabourFilter = New FontAwesome.Sharp.IconButton()
        Me.splitContLabour = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReportLabourPriceList = New FontAwesome.Sharp.IconButton()
        Me.btnLabourPriceList = New FontAwesome.Sharp.IconButton()
        Me.btnDataSource = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar1 = New FontAwesome.Sharp.IconButton()
        Me.tlpLabourEdition.SuspendLayout()
        Me.tlpListLabour.SuspendLayout()
        Me.tlpLabourPriceLook.SuspendLayout()
        CType(Me.splitContLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContLabour.Panel1.SuspendLayout()
        Me.splitContLabour.Panel2.SuspendLayout()
        Me.splitContLabour.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBotton
        '
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 561)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(419, 48)
        Me.PanelBotton.TabIndex = 6
        '
        'tlpLabourEdition
        '
        Me.tlpLabourEdition.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpLabourEdition.ColumnCount = 1
        Me.tlpLabourEdition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabourEdition.Controls.Add(Me.PanelBotton, 0, 2)
        Me.tlpLabourEdition.Controls.Add(Me.tlpLabourEdition2, 0, 1)
        Me.tlpLabourEdition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLabourEdition.Location = New System.Drawing.Point(0, 0)
        Me.tlpLabourEdition.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLabourEdition.Name = "tlpLabourEdition"
        Me.tlpLabourEdition.RowCount = 3
        Me.tlpLabourEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLabourEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabourEdition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpLabourEdition.Size = New System.Drawing.Size(419, 609)
        Me.tlpLabourEdition.TabIndex = 0
        '
        'tlpLabourEdition2
        '
        Me.tlpLabourEdition2.ColumnCount = 2
        Me.tlpLabourEdition2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpLabourEdition2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabourEdition2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpLabourEdition2.Location = New System.Drawing.Point(0, 40)
        Me.tlpLabourEdition2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLabourEdition2.Name = "tlpLabourEdition2"
        Me.tlpLabourEdition2.RowCount = 4
        Me.tlpLabourEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpLabourEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabourEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabourEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabourEdition2.Size = New System.Drawing.Size(419, 150)
        Me.tlpLabourEdition2.TabIndex = 7
        '
        'tlpListLabour
        '
        Me.tlpListLabour.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListLabour.ColumnCount = 1
        Me.tlpListLabour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListLabour.Controls.Add(Me.tlpListUnit, 0, 3)
        Me.tlpListLabour.Controls.Add(Me.tlpLabourPriceLook, 0, 2)
        Me.tlpListLabour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListLabour.Location = New System.Drawing.Point(0, 0)
        Me.tlpListLabour.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListLabour.Name = "tlpListLabour"
        Me.tlpListLabour.RowCount = 5
        Me.tlpListLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListLabour.Size = New System.Drawing.Size(473, 609)
        Me.tlpListLabour.TabIndex = 0
        '
        'tlpListUnit
        '
        Me.tlpListUnit.ColumnCount = 2
        Me.tlpListUnit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpListUnit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListUnit.Location = New System.Drawing.Point(0, 100)
        Me.tlpListUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListUnit.Name = "tlpListUnit"
        Me.tlpListUnit.RowCount = 1
        Me.tlpListUnit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListUnit.Size = New System.Drawing.Size(473, 30)
        Me.tlpListUnit.TabIndex = 3
        '
        'tlpLabourPriceLook
        '
        Me.tlpLabourPriceLook.ColumnCount = 2
        Me.tlpLabourPriceLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabourPriceLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLabourPriceLook.Controls.Add(Me.btnLabourFilter, 1, 0)
        Me.tlpLabourPriceLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLabourPriceLook.Location = New System.Drawing.Point(0, 70)
        Me.tlpLabourPriceLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLabourPriceLook.Name = "tlpLabourPriceLook"
        Me.tlpLabourPriceLook.RowCount = 1
        Me.tlpLabourPriceLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabourPriceLook.Size = New System.Drawing.Size(473, 30)
        Me.tlpLabourPriceLook.TabIndex = 2
        '
        'btnLabourFilter
        '
        Me.btnLabourFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLabourFilter.FlatAppearance.BorderSize = 0
        Me.btnLabourFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLabourFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLabourFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLabourFilter.ForeColor = System.Drawing.Color.Transparent
        Me.btnLabourFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnLabourFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnLabourFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLabourFilter.IconSize = 28
        Me.btnLabourFilter.Location = New System.Drawing.Point(433, 0)
        Me.btnLabourFilter.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.btnLabourFilter.Name = "btnLabourFilter"
        Me.btnLabourFilter.Size = New System.Drawing.Size(32, 22)
        Me.btnLabourFilter.TabIndex = 0
        Me.btnLabourFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLabourFilter.UseVisualStyleBackColor = True
        '
        'splitContLabour
        '
        Me.splitContLabour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContLabour.Location = New System.Drawing.Point(0, 30)
        Me.splitContLabour.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContLabour.Name = "splitContLabour"
        '
        'splitContLabour.Panel1
        '
        Me.splitContLabour.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.splitContLabour.Panel1.Controls.Add(Me.tlpListLabour)
        '
        'splitContLabour.Panel2
        '
        Me.splitContLabour.Panel2.Controls.Add(Me.tlpLabourEdition)
        Me.splitContLabour.Size = New System.Drawing.Size(896, 609)
        Me.splitContLabour.SplitterDistance = 473
        Me.splitContLabour.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReportLabourPriceList, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDataSource, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnGuardar1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLabourPriceList, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(896, 30)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btnReportLabourPriceList
        '
        Me.btnReportLabourPriceList.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReportLabourPriceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReportLabourPriceList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportLabourPriceList.FlatAppearance.BorderSize = 0
        Me.btnReportLabourPriceList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportLabourPriceList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReportLabourPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportLabourPriceList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportLabourPriceList.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnReportLabourPriceList.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnReportLabourPriceList.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReportLabourPriceList.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportLabourPriceList.IconSize = 28
        Me.btnReportLabourPriceList.Location = New System.Drawing.Point(44, 2)
        Me.btnReportLabourPriceList.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnReportLabourPriceList.Name = "btnReportLabourPriceList"
        Me.btnReportLabourPriceList.Size = New System.Drawing.Size(28, 28)
        Me.btnReportLabourPriceList.TabIndex = 9
        Me.btnReportLabourPriceList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportLabourPriceList.UseVisualStyleBackColor = False
        '
        'btnLabourPriceList
        '
        Me.btnLabourPriceList.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLabourPriceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLabourPriceList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnLabourPriceList.FlatAppearance.BorderSize = 0
        Me.btnLabourPriceList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnLabourPriceList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnLabourPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLabourPriceList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabourPriceList.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLabourPriceList.IconChar = FontAwesome.Sharp.IconChar.Coins
        Me.btnLabourPriceList.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnLabourPriceList.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLabourPriceList.IconSize = 28
        Me.btnLabourPriceList.Location = New System.Drawing.Point(80, 2)
        Me.btnLabourPriceList.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnLabourPriceList.Name = "btnLabourPriceList"
        Me.btnLabourPriceList.Size = New System.Drawing.Size(28, 28)
        Me.btnLabourPriceList.TabIndex = 8
        Me.btnLabourPriceList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLabourPriceList.UseVisualStyleBackColor = False
        '
        'btnDataSource
        '
        Me.btnDataSource.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDataSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDataSource.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDataSource.FlatAppearance.BorderSize = 0
        Me.btnDataSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnDataSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnDataSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDataSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataSource.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDataSource.IconChar = FontAwesome.Sharp.IconChar.D
        Me.btnDataSource.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDataSource.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDataSource.IconSize = 28
        Me.btnDataSource.Location = New System.Drawing.Point(8, 2)
        Me.btnDataSource.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnDataSource.Name = "btnDataSource"
        Me.btnDataSource.Size = New System.Drawing.Size(28, 28)
        Me.btnDataSource.TabIndex = 5
        Me.btnDataSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDataSource.UseVisualStyleBackColor = False
        '
        'btnGuardar1
        '
        Me.btnGuardar1.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar1.FlatAppearance.BorderSize = 0
        Me.btnGuardar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar1.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar1.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar1.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar1.IconSize = 28
        Me.btnGuardar1.Location = New System.Drawing.Point(116, 2)
        Me.btnGuardar1.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(28, 28)
        Me.btnGuardar1.TabIndex = 7
        Me.btnGuardar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar1.UseVisualStyleBackColor = False
        '
        'FormLabourPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 639)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.splitContLabour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLabourPrice"
        Me.Text = "FormLabourPrice"
        Me.tlpLabourEdition.ResumeLayout(False)
        Me.tlpListLabour.ResumeLayout(False)
        Me.tlpLabourPriceLook.ResumeLayout(False)
        Me.splitContLabour.Panel1.ResumeLayout(False)
        Me.splitContLabour.Panel2.ResumeLayout(False)
        CType(Me.splitContLabour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContLabour.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents tlpLabourEdition As TableLayoutPanel
    Friend WithEvents tlpListLabour As TableLayoutPanel
    Friend WithEvents splitContLabour As SplitContainer
    Friend WithEvents tlpLabourPriceLook As TableLayoutPanel
    Friend WithEvents btnLabourFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpListUnit As TableLayoutPanel
    Friend WithEvents tlpLabourEdition2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDataSource As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGuardar1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLabourPriceList As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReportLabourPriceList As FontAwesome.Sharp.IconButton
End Class
