<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLabour
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
        Me.splitContLabour = New System.Windows.Forms.SplitContainer()
        Me.PanelPrueba = New System.Windows.Forms.Panel()
        Me.tlpListLabour = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLabourLook = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLabourFilter = New FontAwesome.Sharp.IconButton()
        Me.tlpLabourEdition = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.tlpLabourEdition2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tplHeadButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCompoundLabour = New FontAwesome.Sharp.IconButton()
        Me.btnDataSource = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        CType(Me.splitContLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContLabour.Panel1.SuspendLayout()
        Me.splitContLabour.Panel2.SuspendLayout()
        Me.splitContLabour.SuspendLayout()
        Me.PanelPrueba.SuspendLayout()
        Me.tlpListLabour.SuspendLayout()
        Me.tlpLabourLook.SuspendLayout()
        Me.tlpLabourEdition.SuspendLayout()
        Me.tplHeadButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContLabour
        '
        Me.splitContLabour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContLabour.Location = New System.Drawing.Point(0, 28)
        Me.splitContLabour.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContLabour.Name = "splitContLabour"
        '
        'splitContLabour.Panel1
        '
        Me.splitContLabour.Panel1.Controls.Add(Me.PanelPrueba)
        '
        'splitContLabour.Panel2
        '
        Me.splitContLabour.Panel2.Controls.Add(Me.tlpLabourEdition)
        Me.splitContLabour.Size = New System.Drawing.Size(992, 567)
        Me.splitContLabour.SplitterDistance = 323
        Me.splitContLabour.TabIndex = 2
        '
        'PanelPrueba
        '
        Me.PanelPrueba.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelPrueba.Controls.Add(Me.tlpListLabour)
        Me.PanelPrueba.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrueba.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrueba.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPrueba.Name = "PanelPrueba"
        Me.PanelPrueba.Size = New System.Drawing.Size(323, 567)
        Me.PanelPrueba.TabIndex = 0
        '
        'tlpListLabour
        '
        Me.tlpListLabour.ColumnCount = 1
        Me.tlpListLabour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListLabour.Controls.Add(Me.tlpLabourLook, 0, 2)
        Me.tlpListLabour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListLabour.Location = New System.Drawing.Point(0, 0)
        Me.tlpListLabour.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListLabour.Name = "tlpListLabour"
        Me.tlpListLabour.RowCount = 4
        Me.tlpListLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListLabour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListLabour.Size = New System.Drawing.Size(323, 567)
        Me.tlpListLabour.TabIndex = 0
        '
        'tlpLabourLook
        '
        Me.tlpLabourLook.ColumnCount = 2
        Me.tlpLabourLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabourLook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLabourLook.Controls.Add(Me.btnLabourFilter, 1, 0)
        Me.tlpLabourLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLabourLook.Location = New System.Drawing.Point(0, 70)
        Me.tlpLabourLook.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLabourLook.Name = "tlpLabourLook"
        Me.tlpLabourLook.RowCount = 1
        Me.tlpLabourLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabourLook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabourLook.Size = New System.Drawing.Size(323, 30)
        Me.tlpLabourLook.TabIndex = 0
        '
        'btnLabourFilter
        '
        Me.btnLabourFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLabourFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLabourFilter.FlatAppearance.BorderSize = 0
        Me.btnLabourFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLabourFilter.ForeColor = System.Drawing.Color.Transparent
        Me.btnLabourFilter.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnLabourFilter.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnLabourFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLabourFilter.IconSize = 28
        Me.btnLabourFilter.Location = New System.Drawing.Point(283, 0)
        Me.btnLabourFilter.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.btnLabourFilter.Name = "btnLabourFilter"
        Me.btnLabourFilter.Size = New System.Drawing.Size(32, 22)
        Me.btnLabourFilter.TabIndex = 0
        Me.btnLabourFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLabourFilter.UseVisualStyleBackColor = True
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
        Me.tlpLabourEdition.Size = New System.Drawing.Size(665, 567)
        Me.tlpLabourEdition.TabIndex = 0
        '
        'PanelBotton
        '
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 519)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(665, 48)
        Me.PanelBotton.TabIndex = 6
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
        Me.tlpLabourEdition2.RowCount = 5
        Me.tlpLabourEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabourEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpLabourEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpLabourEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabourEdition2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLabourEdition2.Size = New System.Drawing.Size(665, 210)
        Me.tlpLabourEdition2.TabIndex = 7
        '
        'tplHeadButton
        '
        Me.tplHeadButton.BackColor = System.Drawing.Color.Gainsboro
        Me.tplHeadButton.ColumnCount = 4
        Me.tplHeadButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplHeadButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplHeadButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplHeadButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplHeadButton.Controls.Add(Me.btnCompoundLabour, 0, 0)
        Me.tplHeadButton.Controls.Add(Me.btnDataSource, 0, 0)
        Me.tplHeadButton.Controls.Add(Me.btnGuardar, 2, 0)
        Me.tplHeadButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.tplHeadButton.Location = New System.Drawing.Point(0, 0)
        Me.tplHeadButton.Margin = New System.Windows.Forms.Padding(0)
        Me.tplHeadButton.Name = "tplHeadButton"
        Me.tplHeadButton.RowCount = 1
        Me.tplHeadButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tplHeadButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplHeadButton.Size = New System.Drawing.Size(992, 30)
        Me.tplHeadButton.TabIndex = 3
        '
        'btnCompoundLabour
        '
        Me.btnCompoundLabour.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCompoundLabour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCompoundLabour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCompoundLabour.FlatAppearance.BorderSize = 0
        Me.btnCompoundLabour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCompoundLabour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCompoundLabour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompoundLabour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompoundLabour.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCompoundLabour.IconChar = FontAwesome.Sharp.IconChar.Cubes
        Me.btnCompoundLabour.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCompoundLabour.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCompoundLabour.IconSize = 28
        Me.btnCompoundLabour.Location = New System.Drawing.Point(44, 2)
        Me.btnCompoundLabour.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnCompoundLabour.Name = "btnCompoundLabour"
        Me.btnCompoundLabour.Size = New System.Drawing.Size(28, 28)
        Me.btnCompoundLabour.TabIndex = 7
        Me.btnCompoundLabour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompoundLabour.UseVisualStyleBackColor = False
        '
        'btnDataSource
        '
        Me.btnDataSource.BackColor = System.Drawing.Color.Gainsboro
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
        Me.btnDataSource.Size = New System.Drawing.Size(27, 27)
        Me.btnDataSource.TabIndex = 5
        Me.btnDataSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDataSource.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnGuardar.IconColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.IconSize = 28
        Me.btnGuardar.Location = New System.Drawing.Point(80, 2)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(8, 2, 0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(28, 28)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'FormLabour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 595)
        Me.Controls.Add(Me.tplHeadButton)
        Me.Controls.Add(Me.splitContLabour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormLabour"
        Me.Text = "FormLabour"
        Me.splitContLabour.Panel1.ResumeLayout(False)
        Me.splitContLabour.Panel2.ResumeLayout(False)
        CType(Me.splitContLabour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContLabour.ResumeLayout(False)
        Me.PanelPrueba.ResumeLayout(False)
        Me.tlpListLabour.ResumeLayout(False)
        Me.tlpLabourLook.ResumeLayout(False)
        Me.tlpLabourEdition.ResumeLayout(False)
        Me.tplHeadButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContLabour As SplitContainer
    Friend WithEvents tlpLabourEdition As TableLayoutPanel
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents PanelPrueba As Panel
    Friend WithEvents tlpListLabour As TableLayoutPanel
    Friend WithEvents tlpLabourLook As TableLayoutPanel
    Friend WithEvents btnLabourFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpLabourEdition2 As TableLayoutPanel
    Friend WithEvents tplHeadButton As TableLayoutPanel
    Friend WithEvents btnDataSource As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCompoundLabour As FontAwesome.Sharp.IconButton
End Class
