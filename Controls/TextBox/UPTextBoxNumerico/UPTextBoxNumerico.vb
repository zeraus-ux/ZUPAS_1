Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Windows.Controls
Imports Newtonsoft.Json.Linq
Public Class UPTextBoxNumerico
    Inherits UPTextBox


    Private _Min As Double = Double.NaN
    Private _Max As Double = Double.NaN

    Public Shadows Event TextChanged(sender As Object, e As EventArgs)
    Public Shadows Event KeyPress(sender As Object, e As KeyPressEventArgs)


    Public Sub New(ByVal Min As Double, ByVal Max As Double, Optional ByVal IsScientific As Boolean = False, Optional ByVal Decimals As Int16 = -1)
        MyBase.New()

        _Min = Min
        _Max = Max

        ' Add any initialization after the InitializeComponent() call.

        MyBase.Name = "PETextBoxNumeric"
        MyBase.Dock = DockStyle.Fill
        'MyBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        MyBase.BorderStyle = BorderStyle.None
        MyBase.Multiline = True '21/03
        MyBase.ScrollBars = System.Windows.Forms.ScrollBars.None
        MyBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyBase.Margin = New System.Windows.Forms.Padding(4, 4, 8, 4)
        ' MyBase.Margin = New System.Windows.Forms.Padding(4, 4, 8, 3)
        'Modificacion 08/06

        MyBase.Size = New System.Drawing.Size(236, 27)
        MyBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        'MyBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer))
        MyBase.ForeColor = System.Drawing.Color.Black
        MyBase.Location = New System.Drawing.Point(109, 218)



    End Sub

    Public Function ValidateValues() As Boolean

        Dim userInput As String = Text
        Dim value As Double

        If Double.TryParse(userInput, value) Then
            If Not Double.IsNaN(_Min) AndAlso CType(Text, Double) < _Min Then
                ForeColor = Color.Red
                MessageBox.Show(String.Format("Value less than minimum {0}.", _Min), "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False

            ElseIf Not Double.IsNaN(_Max) AndAlso CType(Text, Double) > _Max Then
                ForeColor = Color.Red
                MessageBox.Show(String.Format("Value greater than minimum {0}.", _Max), "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                ForeColor = Color.Black
                Return True
            End If
        Else
            If Not String.IsNullOrEmpty(userInput) Then
                MessageBox.Show("Please enter a valid real number.", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Public Property Value As Object
        Set(value As Object)
            If String.IsNullOrEmpty(value) OrElse Not IsNumeric(value) OrElse Double.IsNaN(value) Then
                Text = ""
            Else
                Text = value
            End If
        End Set
        Get
            If Not IsNumeric(Text) Then
                Return Double.NaN
            Else
                Return CType(Text, Double)
            End If
        End Get
    End Property

    Private Sub PETextBoxNumeric_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ' Permite solo caracteres numéricos y teclas de control (suprimir, borrar)
        'e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        ' Verifica si la tecla presionada es un número o el punto decimal
        If Asc(e.KeyChar) <> 8 AndAlso (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) AndAlso Asc(e.KeyChar) <> 46 Then
            e.Handled = True ' Cancela la entrada
        Else
            RaiseEvent KeyPress(Me, e)
        End If

    End Sub

    Private Sub PETextBoxNumeric_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged

        Dim userInput As String = Text
        Dim value As Double

        If Double.TryParse(userInput, value) Then
            If Not Double.IsNaN(_Min) AndAlso CType(Text, Double) < _Min Then
                ForeColor = Color.Red

            ElseIf Not Double.IsNaN(_Max) AndAlso CType(Text, Double) > _Max Then
                ForeColor = Color.Red

            Else
                ForeColor = Color.Black
            End If
        Else
            If Not String.IsNullOrEmpty(userInput) Then
                MessageBox.Show("Please enter a valid real number.", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Text = ""
            End If
        End If

        RaiseEvent TextChanged(Me, e)
    End Sub


End Class
