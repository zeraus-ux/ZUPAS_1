Imports UPAZ.My

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private _UnserName As String
    Private _Password As String
    Public ReadOnly Property UserName As String
        Get
            Return _UnserName
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UsernameTextBox.Text = My.Settings.LastUserName
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        _UnserName = UsernameTextBox.Text
        _Password = PasswordTextBox.Text
        If ServerServices.Login(_UnserName, _Password) Then
            My.Settings.LastUserName = _UnserName
            My.Settings.Save()
            Me.Close()
            DialogResult = DialogResult.OK
        Else
            DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class
