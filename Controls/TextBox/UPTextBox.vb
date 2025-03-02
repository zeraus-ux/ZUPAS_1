Public Class UPTextBox

    Public Shadows Event TextChanged(sender As Object, e As EventArgs)

    Private _IsTextChanged As Boolean = False
    Public Sub New(Optional vMaxLength As Int32 = -1)

        InitializeComponent()

        MyBase.Font = My.Settings.UPFont

        MyBase.Dock = System.Windows.Forms.DockStyle.Fill
        MyBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Regular,
                                              System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyBase.ForeColor = System.Drawing.Color.Black
        MyBase.BackColor = System.Drawing.Color.WhiteSmoke
        MyBase.Location = New System.Drawing.Point(130, 10)
        MyBase.BorderStyle = BorderStyle.None
        MyBase.TextAlign = HorizontalAlignment.Left

        MyBase.Margin = New System.Windows.Forms.Padding(4, 4, 8, 4)
        ' MyBase.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)

        MyBase.Multiline = True
        If vMaxLength > 0 Then
            MyBase.MaxLength = vMaxLength

            ' Dim indentedText As String = IndentText(Text, vbTab) '21/11
            'MyBase.Text = indentedText

        End If


        ' MyBase.TextAlign = System.Windows.HorizontalAlignment.Left
        'MyBase.TextAlign = System.Windows.VerticalAlignment.Center
        ' MyBase.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)  05/06
        ' MyBase.Name = "MyBase"
        'MyBase.Size = New System.Drawing.Size(134, 30)
        ' MyBase.TabIndex = 1






    End Sub

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx

    Public Shadows Property Text As String
        Get
            Return LTrim(MyBase.Text)
        End Get
        Set(value As String)
            MyBase.Text = LTrim(value)
        End Set
    End Property

    Private Sub UPTextBox_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        If Not _IsTextChanged Then
            _IsTextChanged = True
            Dim posicionCursor As Integer
            If LTrim(MyBase.Text) = MyBase.Text Then
                posicionCursor = MyBase.SelectionStart + 1
            Else
                posicionCursor = MyBase.SelectionStart
            End If


            MyBase.Text = LTrim(MyBase.Text)
            MyBase.SelectionStart = posicionCursor
                RaiseEvent TextChanged(Me, e)
                _IsTextChanged = False
            End If
    End Sub



    'Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    '    MyBase.OnPaint(e)

    '    Dim rect As New Rectangle(5, 0, Me.Width - 10, Me.Height)

    '    e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), rect)
    'End Sub



    'Private Sub UPTextBox_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
    '    OnPaint(e)
    'End Sub
End Class
