﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormToolPrice
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
        Me.lblEdicionTool = New System.Windows.Forms.Label()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.PanelArea = New System.Windows.Forms.Panel()
        Me.UpPanelEdicion = New UPAZ.UPPanel()
        Me.tlyPanelEdicion = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblListadoMaterial = New System.Windows.Forms.Label()
        Me.tlpListTool = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpListUnit = New System.Windows.Forms.TableLayoutPanel()
        Me.splitContTool = New System.Windows.Forms.SplitContainer()
        Me.PanelBotton.SuspendLayout()
        Me.PanelArea.SuspendLayout()
        Me.UpPanelEdicion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpListTool.SuspendLayout()
        CType(Me.splitContTool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContTool.Panel1.SuspendLayout()
        Me.splitContTool.Panel2.SuspendLayout()
        Me.splitContTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEdicionTool
        '
        Me.lblEdicionTool.AutoSize = True
        Me.lblEdicionTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblEdicionTool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEdicionTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEdicionTool.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionTool.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEdicionTool.Location = New System.Drawing.Point(4, 8)
        Me.lblEdicionTool.Margin = New System.Windows.Forms.Padding(4, 8, 8, 0)
        Me.lblEdicionTool.Name = "lblEdicionTool"
        Me.lblEdicionTool.Padding = New System.Windows.Forms.Padding(1)
        Me.lblEdicionTool.Size = New System.Drawing.Size(278, 32)
        Me.lblEdicionTool.TabIndex = 0
        Me.lblEdicionTool.Text = "Edición Precio Herramientas"
        Me.lblEdicionTool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBotton
        '
        Me.PanelBotton.Controls.Add(Me.btnGuardar)
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotton.Location = New System.Drawing.Point(2, 537)
        Me.PanelBotton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.PanelArea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelArea.Name = "PanelArea"
        Me.PanelArea.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
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
        Me.UpPanelEdicion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.TableLayoutPanel1.Controls.Add(Me.lblEdicionTool, 0, 0)
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
        'lblListadoMaterial
        '
        Me.lblListadoMaterial.AutoSize = True
        Me.lblListadoMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblListadoMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblListadoMaterial.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoMaterial.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblListadoMaterial.Location = New System.Drawing.Point(8, 8)
        Me.lblListadoMaterial.Margin = New System.Windows.Forms.Padding(8, 8, 4, 0)
        Me.lblListadoMaterial.Name = "lblListadoMaterial"
        Me.lblListadoMaterial.Padding = New System.Windows.Forms.Padding(1)
        Me.lblListadoMaterial.Size = New System.Drawing.Size(317, 32)
        Me.lblListadoMaterial.TabIndex = 0
        Me.lblListadoMaterial.Text = "Listado de Herramientas"
        Me.lblListadoMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpListTool
        '
        Me.tlpListTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlpListTool.ColumnCount = 1
        Me.tlpListTool.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListTool.Controls.Add(Me.lblListadoMaterial, 0, 0)
        Me.tlpListTool.Controls.Add(Me.tlpListUnit, 0, 1)
        Me.tlpListTool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpListTool.Location = New System.Drawing.Point(0, 0)
        Me.tlpListTool.Name = "tlpListTool"
        Me.tlpListTool.RowCount = 3
        Me.tlpListTool.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpListTool.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpListTool.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListTool.Size = New System.Drawing.Size(329, 585)
        Me.tlpListTool.TabIndex = 0
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
        'splitContTool
        '
        Me.splitContTool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContTool.Location = New System.Drawing.Point(0, 0)
        Me.splitContTool.Name = "splitContTool"
        '
        'splitContTool.Panel1
        '
        Me.splitContTool.Panel1.Controls.Add(Me.tlpListTool)
        '
        'splitContTool.Panel2
        '
        Me.splitContTool.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splitContTool.Size = New System.Drawing.Size(623, 585)
        Me.splitContTool.SplitterDistance = 329
        Me.splitContTool.TabIndex = 2
        '
        'FormToolPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 585)
        Me.Controls.Add(Me.splitContTool)
        Me.Name = "FormToolPrice"
        Me.Text = "FormToolPrice"
        Me.PanelBotton.ResumeLayout(False)
        Me.PanelArea.ResumeLayout(False)
        Me.UpPanelEdicion.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpListTool.ResumeLayout(False)
        Me.tlpListTool.PerformLayout()
        Me.splitContTool.Panel1.ResumeLayout(False)
        Me.splitContTool.Panel2.ResumeLayout(False)
        CType(Me.splitContTool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContTool.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblEdicionTool As Label
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelArea As Panel
    Friend WithEvents UpPanelEdicion As UPPanel
    Friend WithEvents tlyPanelEdicion As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblListadoMaterial As Label
    Friend WithEvents tlpListTool As TableLayoutPanel
    Friend WithEvents splitContTool As SplitContainer
    Friend WithEvents tlpListUnit As TableLayoutPanel
End Class
