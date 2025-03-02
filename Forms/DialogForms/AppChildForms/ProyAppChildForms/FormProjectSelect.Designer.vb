<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectProject))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAceptar = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 108)
        Me.Panel1.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnAceptar.IconColor = System.Drawing.Color.White
        Me.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAceptar.IconSize = 28
        Me.btnAceptar.Location = New System.Drawing.Point(277, 67)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 32)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'FormSelectProject
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 108)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSelectProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccionar Proyecto"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAceptar As FontAwesome.Sharp.IconButton
End Class
