<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormModalProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModalProject))
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.PanelArea = New System.Windows.Forms.Panel()
        Me.UpPanelEdicion = New UPAZ.UPPanel()
        Me.tlpProjectEdit = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpProject = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListProject = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContProject = New System.Windows.Forms.SplitContainer()
        Me.PanelBotton.SuspendLayout()
        Me.PanelArea.SuspendLayout()
        Me.UpPanelEdicion.SuspendLayout()
        Me.tlpProject.SuspendLayout()
        CType(Me.splitContProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContProject.Panel1.SuspendLayout()
        Me.splitContProject.Panel2.SuspendLayout()
        Me.splitContProject.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(0, 478)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(402, 48)
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
        Me.btnGuardar.Location = New System.Drawing.Point(310, 7)
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
        Me.PanelArea.Location = New System.Drawing.Point(0, 40)
        Me.PanelArea.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelArea.Name = "PanelArea"
        Me.PanelArea.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelArea.Size = New System.Drawing.Size(402, 438)
        Me.PanelArea.TabIndex = 15
        '
        'UpPanelEdicion
        '
        Me.UpPanelEdicion.AutoSize = True
        Me.UpPanelEdicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.UpPanelEdicion.Controls.Add(Me.tlpProjectEdit)
        Me.UpPanelEdicion.CornerRadius = 10
        Me.UpPanelEdicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpPanelEdicion.Location = New System.Drawing.Point(6, 6)
        Me.UpPanelEdicion.Margin = New System.Windows.Forms.Padding(0)
        Me.UpPanelEdicion.Name = "UpPanelEdicion"
        Me.UpPanelEdicion.Size = New System.Drawing.Size(390, 426)
        Me.UpPanelEdicion.TabIndex = 8
        '
        'tlpProjectEdit
        '
        Me.tlpProjectEdit.ColumnCount = 2
        Me.tlpProjectEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlpProjectEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProjectEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpProjectEdit.Location = New System.Drawing.Point(0, 0)
        Me.tlpProjectEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpProjectEdit.Name = "tlpProjectEdit"
        Me.tlpProjectEdit.RowCount = 6
        Me.tlpProjectEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpProjectEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpProjectEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpProjectEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpProjectEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpProjectEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpProjectEdit.Size = New System.Drawing.Size(390, 180)
        Me.tlpProjectEdit.TabIndex = 6
        '
        'tlpProject
        '
        Me.tlpProject.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpProject.ColumnCount = 1
        Me.tlpProject.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProject.Controls.Add(Me.PanelBotton, 0, 2)
        Me.tlpProject.Controls.Add(Me.PanelArea, 0, 1)
        Me.tlpProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpProject.Location = New System.Drawing.Point(0, 0)
        Me.tlpProject.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpProject.Name = "tlpProject"
        Me.tlpProject.RowCount = 3
        Me.tlpProject.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpProject.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProject.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpProject.Size = New System.Drawing.Size(402, 526)
        Me.tlpProject.TabIndex = 0
        '
        'tlpListProject
        '
        Me.tlpListProject.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListProject.ColumnCount = 1
        Me.tlpListProject.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListProject.Location = New System.Drawing.Point(0, 0)
        Me.tlpListProject.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpListProject.Name = "tlpListProject"
        Me.tlpListProject.RowCount = 2
        Me.tlpListProject.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListProject.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListProject.Size = New System.Drawing.Size(463, 526)
        Me.tlpListProject.TabIndex = 0
        '
        'splitContProject
        '
        Me.splitContProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContProject.Location = New System.Drawing.Point(0, 0)
        Me.splitContProject.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContProject.Name = "splitContProject"
        '
        'splitContProject.Panel1
        '
        Me.splitContProject.Panel1.Controls.Add(Me.tlpListProject)
        '
        'splitContProject.Panel2
        '
        Me.splitContProject.Panel2.Controls.Add(Me.tlpProject)
        Me.splitContProject.Size = New System.Drawing.Size(869, 526)
        Me.splitContProject.SplitterDistance = 463
        Me.splitContProject.TabIndex = 2
        '
        'FormModalProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(869, 526)
        Me.Controls.Add(Me.splitContProject)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormModalProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edición de Proyectos"
        Me.PanelBotton.ResumeLayout(False)
        Me.PanelArea.ResumeLayout(False)
        Me.PanelArea.PerformLayout()
        Me.UpPanelEdicion.ResumeLayout(False)
        Me.tlpProject.ResumeLayout(False)
        Me.splitContProject.Panel1.ResumeLayout(False)
        Me.splitContProject.Panel2.ResumeLayout(False)
        CType(Me.splitContProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContProject.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents tlpProjectEdit As TableLayoutPanel
    Friend WithEvents UpPanelEdicion As UPPanel
    Friend WithEvents PanelArea As Panel
    Friend WithEvents tlpProject As TableLayoutPanel
    Friend WithEvents tlpListProject As TableLayoutPanel
    Friend WithEvents splitContProject As SplitContainer
End Class
