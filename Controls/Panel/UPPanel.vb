Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms


Public Class UPPanel
    Inherits Panel

    Private _cornerRadius As Integer = 10

    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim path As New GraphicsPath()
        Dim rect As Rectangle = ClientRectangle
        rect.Inflate(-1, -1) ' Optional: Adjust the size of the rounded panel

        path.AddArc(rect.Left, rect.Top, CornerRadius, CornerRadius, 180, 90)
        path.AddArc(rect.Right - CornerRadius, rect.Top, CornerRadius, CornerRadius, 270, 90)
        path.AddArc(rect.Right - CornerRadius, rect.Bottom - CornerRadius, CornerRadius, CornerRadius, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - CornerRadius, CornerRadius, CornerRadius, 90, 90)
        path.CloseFigure()

        Region = New Region(path)
    End Sub
End Class
