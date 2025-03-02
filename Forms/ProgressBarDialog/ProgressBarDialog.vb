Imports System.ComponentModel
Imports System.Threading

Public Class ProgressBarDialog
    Inherits Form

    Private _ProgressBar As System.Windows.Forms.ProgressBar

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ProgressBarDialog
        '
        Me.ClientSize = New System.Drawing.Size(701, 27)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProgressBarDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Public Sub New(ByVal FormText As String)
        MyBase.New()

        InitializeComponent()

        MyBase.ShowIcon = False
        MyBase.TopMost = True

        _ProgressBar = New System.Windows.Forms.ProgressBar()
        _ProgressBar.Minimum = 0
        _ProgressBar.Maximum = 100
        _ProgressBar.Value = 0
        _ProgressBar.Dock = DockStyle.Fill

        Me.Controls.Add(_ProgressBar)


        'AddHandler ModHandlerMessage.EvFormNotModalHide, AddressOf FormNotModalHide
        'AddHandler ModHandlerMessage.EvFormNotModalShow, AddressOf FormNotModalShow

    End Sub

    Public Sub StartProgress()
        Try
            While True
                For i As Int32 = 1 To 100
                    Thread.Sleep(100)
                    If _ProgressBar.IsHandleCreated Then
                        _ProgressBar.Invoke(Sub()
                                                _ProgressBar.Value = i
                                                Refresh()
                                                Focus()
                                            End Sub)
                    End If
                    If Interlocked.Read(AtomicCounterProgressBar2) > 0 Then
                        If Me.InvokeRequired Then
                            Me.Invoke(Sub() 'lambda sub
                                          Me.Close()
                                      End Sub)
                        Else
                            Me.Close()
                        End If
                    End If
                Next
            End While
        Catch ex As Exception
            If Me.InvokeRequired Then
                Me.Invoke(Sub() 'lambda sub
                              Me.Close()
                          End Sub)
            Else
                Me.Close()
            End If
        End Try
    End Sub

    'Private Sub FormNotModalHide()
    '    If Me.InvokeRequired Then
    '        Me.Invoke(Sub() 'lambda sub
    '                      FormNotModalHide()
    '                  End Sub)
    '    Else
    '        Me.Visible = False
    '    End If
    'End Sub
    'Private Sub FormNotModalShow()
    '    If Me.InvokeRequired Then
    '        Me.Invoke(Sub() 'lambda sub
    '                      FormNotModalShow()
    '                  End Sub)
    '    Else
    '        Me.Visible = True
    '    End If
    'End Sub


    'Public Shadows Function ShowDialog() As DialogResult

    '    Return MyBase.ShowDialog()
    'End Function


    Private Sub ProgressBarDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim thread As New Thread(AddressOf StartProgress)
        thread.Start()

        'StartProgress()
    End Sub

    Private Sub ProgressBarDialog_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If Me.InvokeRequired Then
            _ProgressBar.Invoke(Sub()
                                    _ProgressBar.Value = 99
                                    _ProgressBar.Refresh()
                                    'RemoveHandler ModHandlerMessage.EvFormNotModalHide, AddressOf FormNotModalHide
                                    'RemoveHandler ModHandlerMessage.EvFormNotModalShow, AddressOf FormNotModalShow
                                End Sub)
        Else
            _ProgressBar.Value = 99
            _ProgressBar.Refresh()
            'RemoveHandler ModHandlerMessage.EvFormNotModalHide, AddressOf FormNotModalHide
            'RemoveHandler ModHandlerMessage.EvFormNotModalShow, AddressOf FormNotModalShow

        End If

    End Sub

    'Private Sub ProgressBarDialog_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    'EnableMDIForm()
    'End Sub
End Class
