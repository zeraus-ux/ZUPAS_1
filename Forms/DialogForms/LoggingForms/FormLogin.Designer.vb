<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.OK = New FontAwesome.Sharp.IconButton()
        Me.Cancel = New FontAwesome.Sharp.IconButton()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(333, 160)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(166, 22)
        Me.PasswordTextBox.TabIndex = 10
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(333, 114)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(166, 22)
        Me.UsernameTextBox.TabIndex = 8
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(331, 144)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(165, 19)
        Me.PasswordLabel.TabIndex = 9
        Me.PasswordLabel.Text = "&Clave"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(331, 97)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(165, 19)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "&Nombre de Usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, -5)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(484, 320)
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = False
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OK.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.OK.IconColor = System.Drawing.Color.WhiteSmoke
        Me.OK.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.OK.IconSize = 28
        Me.OK.Location = New System.Drawing.Point(318, 278)
        Me.OK.Margin = New System.Windows.Forms.Padding(0)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(85, 32)
        Me.OK.TabIndex = 13
        Me.OK.Text = "&Ok"
        Me.OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.IconChar = FontAwesome.Sharp.IconChar.Cancel
        Me.Cancel.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Cancel.IconSize = 28
        Me.Cancel.Location = New System.Drawing.Point(413, 278)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(85, 32)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(508, 326)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents OK As FontAwesome.Sharp.IconButton
    Friend WithEvents Cancel As FontAwesome.Sharp.IconButton
End Class
