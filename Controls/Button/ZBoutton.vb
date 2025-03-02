Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel


'https://www.youtube.com/watch?v=tdDOfFBkazk&ab_channel=RJCodeAdvance

Public Class WWWTY
    Inherits Button

    Private borderSize As Integer = 0
    Private borderRadius As Integer = 20
    Private borderColor As Color = Color.PaleVioletRed
    Private _borderSize As Int32

    'Public Property _borderSize As Int32
    '    Get
    '        Return _borderSize
    '    End Get
    '    Set(ByVal value As Integer)
    '        _borderSize = value
    '        Me.Invalidate()
    '    End Set
    'End Property




End Class


'Public Class ZBoutton

'    Public Class RJButton
'        Inherits Button
'    End Class

'    Private borderSize As Integer = 0
'    Private borderRadius As Integer = 20
'    Private borderColor As Color = Color.PaleVioletRed

'    ' <Category("RJ Code Advance")>
'    Public Property BorderSize As Integer
'        Get
'            Return BorderSize
'        End Get
'        Set(ByVal value As Integer)
'            borderSize = value
'            Me.Invalidate()
'        End Set
'    End Property

'    <Category("RJ Code Advance")>
'    Public Property BorderRadius As Integer
'        Get
'            Return BorderRadius
'        End Get
'        Set(ByVal value As Integer)
'            borderRadius = value
'            Me.Invalidate()
'        End Set
'    End Property

'    <Category("RJ Code Advance")>
'    Public Property BorderColor As Color
'        Get
'            Return BorderColor
'        End Get
'        Set(ByVal value As Color)
'            borderColor = value
'            Me.Invalidate()
'        End Set
'    End Property

'    <Category("RJ Code Advance")>
'    Public Property BackgroundColor As Color
'        Get
'            Return Me.BackColor
'        End Get
'        Set(ByVal value As Color)
'            Me.BackColor = value
'        End Set
'    End Property

'    <Category("RJ Code Advance")>
'    Public Property TextColor As Color
'        Get
'            Return Me.ForeColor
'        End Get
'        Set(ByVal value As Color)
'            Me.ForeColor = value
'        End Set
'    End Property

'    Public Sub New()
'        Me.FlatStyle = FlatStyle.Flat
'        Me.FlatAppearance.BorderSize = 0
'        Me.Size = New Size(150, 40)
'        Me.BackColor = Color.MediumSlateBlue
'        Me.ForeColor = Color.White
'        Me.Resize += New EventHandler(AddressOf Button_Resize)
'    End Sub

'    Private Sub Button_Resize(ByVal sender As Object, ByVal e As EventArgs)
'        If borderRadius > Me.Height Then borderRadius = Me.Height
'    End Sub

'    Private Function GetFigurePath(ByVal rect As Rectangle, ByVal radius As Single) As GraphicsPath
'        Dim path As GraphicsPath = New GraphicsPath()
'        Dim curveSize As Single = radius * 2.0F
'        path.StartFigure()
'        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
'        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
'        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
'        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
'        path.CloseFigure()
'        Return path
'    End Function

'    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
'        MyBase.OnPaint(pevent)
'        Dim rectSurface As Rectangle = Me.ClientRectangle
'        Dim rectBorder As Rectangle = Rectangle.Inflate(rectSurface, -borderSize, -borderSize)
'        Dim smoothSize As Integer = 2
'        If borderSize > 0 Then smoothSize = borderSize

'        If borderRadius > 2 Then

'            Using pathSurface As GraphicsPath = GetFigurePath(rectSurface, borderRadius)

'                Using pathBorder As GraphicsPath = GetFigurePath(rectBorder, borderRadius - borderSize)

'                    Using penSurface As Pen = New Pen(Me.Parent.BackColor, smoothSize)

'                        Using penBorder As Pen = New Pen(borderColor, borderSize)
'                            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
'                            Me.Region = New Region(pathSurface)
'                            pevent.Graphics.DrawPath(penSurface, pathSurface)
'                            If borderSize >= 1 Then pevent.Graphics.DrawPath(penBorder, pathBorder)
'                        End Using
'                    End Using
'                End Using
'            End Using
'        Else
'            pevent.Graphics.SmoothingMode = SmoothingMode.None
'            Me.Region = New Region(rectSurface)

'            If borderSize >= 1 Then

'                Using penBorder As Pen = New Pen(borderColor, borderSize)
'                    penBorder.Alignment = PenAlignment.Inset
'                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, Me.Width - 1, Me.Height - 1)
'                End Using
'            End If
'        End If
'    End Sub

'    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
'        MyBase.OnHandleCreated(e)
'        Me.Parent.BackColorChanged += New EventHandler(AddressOf Container_BackColorChanged)
'    End Sub

'    Private Sub Container_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
'        Me.Invalidate()
'    End Sub



'End Class
