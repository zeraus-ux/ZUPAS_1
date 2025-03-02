Public Class UPLabel


    Public Sub New(ByVal lblNombre As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'MyBase.Font = My.Settings.UPFont
        MyBase.AutoSize = False
        MyBase.Dock = System.Windows.Forms.DockStyle.Fill
        MyBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        ' MyBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyBase.ForeColor = System.Drawing.Color.White
        MyBase.Location = New System.Drawing.Point(0, 0)
        MyBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        'MyBase.Name = "UPLabel"
        ' MyBase.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0) 05/06
        MyBase.Padding = New System.Windows.Forms.Padding(0)
        'MyBase.Size = New System.Drawing.Size(173, 33)
        MyBase.TabIndex = 0
        MyBase.Text = lblNombre

    End Sub

    Public Sub SetFormatForeColor1()
        MyBase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer),
                                                         CType(CType(36, Byte), Integer),
                                                         CType(CType(34, Byte), Integer))
    End Sub


    Public Sub SetFormatForeColor2() 'color etiqueta
        MyBase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer),
                                                          CType(CType(65, Byte), Integer),
                                                          CType(CType(105, Byte), Integer))
    End Sub


    Public Sub SetFortmatEtiquetaInsumo()

        MyBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        MyBase.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        MyBase.Font = New System.Drawing.Font("Microsoft Segoe UI", 14.25, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        MyBase.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)

    End Sub

    Public Sub SetFortmatEtiquetaCost_CYO()

        MyBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer))
        MyBase.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)
        MyBase.Font = New System.Drawing.Font("Microsoft Segoe UI", 14.25, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        MyBase.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        MyBase.Margin = New System.Windows.Forms.Padding(8, 8, 4, 8)

    End Sub

End Class
