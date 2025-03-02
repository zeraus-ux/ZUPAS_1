Public Class UPDateTimePicker


    Public Shadows Event ValueChanged(sender As Object, e As EventArgs)

    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'MyBase.FormattingEnabled = True
        MyBase.Cursor = System.Windows.Forms.Cursors.Hand
        Format = DateTimePickerFormat.Custom
        CustomFormat = "yyyy-MM-dd HH:mm:ss"


        MyBase.Dock = System.Windows.Forms.DockStyle.Fill
        MyBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Regular,
                                              System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyBase.ForeColor = System.Drawing.Color.Black

        'MyBase.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0) 05/06
        MyBase.Margin = New System.Windows.Forms.Padding(4, 4, 8, 4)




    End Sub


    Public Shadows Property Value As Object
        Get
            Return MyBase.Value
        End Get
        Set(value As Object)
            If value Is Nothing Then
                CustomFormat = " "
            Else
                MyBase.Value = value
                CustomFormat = "yyyy-MM-dd HH:mm:ss"
            End If
        End Set
    End Property

    Private Sub PEDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles MyBase.ValueChanged
        CustomFormat = "yyyy-MM-dd HH:mm:ss"
        RaiseEvent ValueChanged(sender, e)
    End Sub


End Class
