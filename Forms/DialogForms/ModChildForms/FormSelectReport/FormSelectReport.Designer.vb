<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectReport))
        Me.Reportes = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnAceptar = New FontAwesome.Sharp.IconButton()
        Me.btnCancel = New FontAwesome.Sharp.IconButton()
        Me.Reportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reportes
        '
        Me.Reportes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Reportes.Controls.Add(Me.RadioButton3)
        Me.Reportes.Controls.Add(Me.RadioButton2)
        Me.Reportes.Controls.Add(Me.RadioButton1)
        Me.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reportes.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reportes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Reportes.Location = New System.Drawing.Point(21, 21)
        Me.Reportes.Name = "Reportes"
        Me.Reportes.Size = New System.Drawing.Size(335, 177)
        Me.Reportes.TabIndex = 0
        Me.Reportes.TabStop = False
        Me.Reportes.Text = "R e p o r t e s"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton3.Location = New System.Drawing.Point(33, 98)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(147, 29)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.Text = "P o r  E t a p a"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(33, 63)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(186, 29)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.Text = "P o r  C á p i t u l o"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(33, 30)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(149, 29)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "C o m p l e t o"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnAceptar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAceptar.IconSize = 28
        Me.btnAceptar.Location = New System.Drawing.Point(174, 240)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 32)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel
        Me.btnCancel.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancel.IconSize = 28
        Me.btnCancel.Location = New System.Drawing.Point(269, 240)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 32)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cerrar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FormSelectReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 293)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Reportes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSelectReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipo de Reportes"
        Me.Reportes.ResumeLayout(False)
        Me.Reportes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Reportes As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancel As FontAwesome.Sharp.IconButton
End Class
