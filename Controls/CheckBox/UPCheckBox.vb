Public Class UPCheckBox
    Inherits CheckBox

    Public Sub New(ByVal lblNombre As String)

        'MyBase.Font = My.Settings.UPFont
        MyBase.AutoSize = False
        MyBase.Dock = System.Windows.Forms.DockStyle.Fill
        MyBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        MyBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Regular,
                                              System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        MyBase.ForeColor = System.Drawing.Color.WhiteSmoke

        MyBase.Location = New System.Drawing.Point(0, 0)
        MyBase.Margin = New System.Windows.Forms.Padding(0)
        'MyBase.Name = "UPLabel"
        MyBase.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        'MyBase.Size = New System.Drawing.Size(173, 33)
        MyBase.TabIndex = 0
        MyBase.Text = lblNombre
        'MyBase.UseVisualStyleBackColor = False

    End Sub

    ' En tu formulario, añade el evento Paint para el CheckBox
    'Private Sub me_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
    '    If Not Me.Enabled Then
    '        ' Dibujar el texto en blanco cuando el CheckBox está deshabilitado
    '        TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font, Me.ClientRectangle, Color.White, TextFormatFlags.Left)
    '    End If
    'End Sub


End Class
