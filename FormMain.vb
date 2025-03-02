Imports System.Drawing.Text
Imports System.Globalization
Imports System.Resources
Imports System.Windows

'Imports Newtonsoft.Json.Linq
Imports System.Windows.Media.Media3D
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Newtonsoft.Json.Linq
Imports System.Runtime.Remoting.Messaging

Public Class FormUpaz

    Private WithEvents _formMaterial As FormMaterial = Nothing
    'Private WithEvents _formTool As FormTool = Nothing
    Private WithEvents _formEquipment As FormEquipment = Nothing
    Private WithEvents _formTransport As FormTransport = Nothing
    Private WithEvents _formLabour As FormLabour = Nothing
    Private WithEvents _formMaterialPrice As FormMaterialPrice = Nothing
    'Private WithEvents _formToolPrice As FormToolPrice = Nothing
    Private WithEvents _formequipmentCostPyOUser As FormEquipmentCostPyOUser = Nothing
    Private WithEvents _formLabourPrice As FormLabourPrice = Nothing
    Private WithEvents _formTransportPrice As FormTransportPrice = Nothing
    Private WithEvents _formFormulacionPartida As FormFormulacionPartida = Nothing
    Private WithEvents _formFormulaciobObra As FormFormulacionObra = Nothing
    'Private WithEvents _formAppMoneyChange As FormAppMoneyChange = Nothing
    'Private WithEvents _formReportPartida As FormReportPartida = Nothing
    'Private WithEvents _formMoneyType As FormAppMoneyType = Nothing
    'Private WithEvents _formMoneyChange As FormAppMoneyChange = Nothing
    'Private WithEvents _formEqmtPriceEst1 As FormEqmtPriceEst1 = Nothing
    'Private WithEvents _FormEqmtPriceEst1 As FormEqmtPriceEst1 = Nothing


    Private WithEvents _formLogin As FormLogin = Nothing

    Private WithEvents _UPCBoxProjectSeleted As UPComboBox

    Private _CurrentForm As Form = Nothing 'declaracion de variable para almacenar formulario que se abre
    Private _CurrentForm1 As Form = Nothing
    Private _subMenuActive As Panel = Nothing
    Private _UserName As String
    Private _IdMatrixProjectType As Int32 = -1
    Private _ProjectHorasPerDay As Double = Double.NaN

    'Public Event EvProjectSeletedChnge(sender As Object, e As EventArgs)
    Private Sub Login()

        Dim _LoginForm1 As New FormLogin()
        _LoginForm1.TopMost = True

        If _LoginForm1.ShowDialog() = DialogResult.OK Then
            _UserName = _LoginForm1.UserName
        Else
            End
        End If

    End Sub

#Region "Icons"

    Private Sub LoadIcons()

        Dim _ResourceManager As ResourceManager
        Dim _ResourceSet As ResourceSet

        _ResourceManager = New ResourceManager(My.Resources.ResourceManager.BaseName, GetType(FormUpaz).Assembly)
        _ResourceSet = _ResourceManager.GetResourceSet(CultureInfo.InvariantCulture, True, True)

        For Each resource As DictionaryEntry In _ResourceSet
            If TypeOf resource.Value Is Icon Then
                Dim myIcon As Icon = DirectCast(_ResourceManager.GetObject(resource.Key), Icon)
                Me.ImageList1.Images.Add(CType(resource.Key.ToString, String), myIcon)
            End If
        Next

    End Sub

    Public ReadOnly Property UPImagenList As ImageList
        Get
            Return Me.ImageList1
        End Get
    End Property

    Public Function GetImage(ByVal ImageKey As String) As System.Drawing.Image

        If ImageKey Is Nothing OrElse Not ImageList1.Images.ContainsKey(ImageKey) Then
            Return CType(ImageList1.Images("Defecto"), System.Drawing.Image)
        Else
            Return CType(ImageList1.Images(ImageKey), System.Drawing.Image)
        End If
    End Function

    Public Function GetIcon(ByVal ImageKey As String) As System.Drawing.Icon

        Dim _ResourceManager As ResourceManager
        Dim _ResourceSet As ResourceSet

        _ResourceManager = New ResourceManager(My.Resources.ResourceManager.BaseName, GetType(FormUpaz).Assembly)
        _ResourceSet = _ResourceManager.GetResourceSet(CultureInfo.InvariantCulture, True, True)

        If ImageKey Is Nothing OrElse Not ImageList1.Images.ContainsKey(ImageKey) Then

            Return DirectCast(_ResourceManager.GetObject("Defecto"), Icon)
        Else
            Return DirectCast(_ResourceManager.GetObject(ImageKey), Icon)
        End If
    End Function

#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Login()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        '!!!!!!!!!!!!!!!  Prueba  !!!!!!!!!!!!!!!!!!!!!!

        'openChildForm(New FormMaterial)
        'openChildForm(New FormMaterialPrice)
        'openChildForm(New FormFormulacionObra)
        'openChildForm(New FormFormulacionPartida)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    End Sub

    Public ReadOnly Property UserName As String
        Get
            Return _UserName
        End Get
    End Property

    Public ReadOnly Property ProjectSelectedId As Int32
        Get
            Return _UPCBoxProjectSeleted.GetSelectedItemId()
        End Get
    End Property

    Public ReadOnly Property IdMatrixProjectType As Int32
        Get
            If _IdMatrixProjectType = -1 Then
                _IdMatrixProjectType = GetIdMatrixProjectType()
            End If
            Return _IdMatrixProjectType
        End Get
    End Property

    Public ReadOnly Property ProjectHorasPerDay As Double
        Get
            If Double.IsNaN(_ProjectHorasPerDay) Then
                _ProjectHorasPerDay = GetProjectHorasPerDay()
            End If
            Return _ProjectHorasPerDay

        End Get
    End Property

    Public ReadOnly Property PartidaTypeForm As EnumPartidaTypeForm
        Get
            Return GetNumeration(Of EnumPartidaTypeForm)(IdMatrixProjectType - 1)
        End Get
    End Property

    Public ReadOnly Property IsPartidaARG As Boolean
        Get
            Return PartidaTypeForm = EnumPartidaTypeForm.ARG
        End Get
    End Property

    Private Sub LoadFormChileds()

        _formMaterial = New FormMaterial
        ' _formTool = New FormTool 
        _formEquipment = New FormEquipment
        _formTransport = New FormTransport
        _formLabour = New FormLabour
        _formMaterialPrice = New FormMaterialPrice
        ' _formToolPrice = New FormToolPrice 
        _formequipmentCostPyOUser = New FormEquipmentCostPyOUser
        _formLabourPrice = New FormLabourPrice
        _formTransportPrice = New FormTransportPrice
        _formFormulacionPartida = New FormFormulacionPartida
        _formFormulaciobObra = New FormFormulacionObra
        ' _formAppMoneyChange = New FormAppMoneyChange 
        ' _formReportPartida = New FormReportPartida 
        ' _formMoneyType = New FormAppMoneyType 
        ' _formMoneyChange = New FormAppMoneyChange 
        ' _formEqmtPriceEst1 = New FormEqmtPriceEst1 
        '_FormEqmtPriceEst1 = New FormEqmtPriceEst1()

    End Sub


    Private Sub ValidateProject()


        If _UPCBoxProjectSeleted.Items.Count = 1 And ProjectSelectedId = -1 Then
            Try
                Show()
            Catch ex As Exception
            End Try



            Dim _Message As String = "No hay proyecto creado, cree uno"
            MessageBox.Show(_Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ProjectNew()
            ValidateProject()
        ElseIf ProjectSelectedId < 1 Then
            Try
                Show()
            Catch ex As Exception
            End Try

            Dim _Message As String = "No hay proyecto seleccionado, seleccione uno"
            MessageBox.Show(_Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ProjectOpen()
            ValidateProject()
        End If

    End Sub

    Private Sub hideSubMenu()
        'Test~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Return
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        PanelInsumos.Visible = _subMenuActive IsNot Nothing AndAlso PanelInsumos.Equals(_subMenuActive)
        PanelMantenimiento.Visible = _subMenuActive IsNot Nothing AndAlso PanelInsumos.Equals(PanelMantenimiento)
        PanelFormulacionObras.Visible = _subMenuActive IsNot Nothing AndAlso PanelInsumos.Equals(PanelFormulacionObras)
        PanelReport.Visible = _subMenuActive IsNot Nothing AndAlso PanelInsumos.Equals(PanelReport)
        PanelUtilitario.Visible = _subMenuActive IsNot Nothing AndAlso PanelInsumos.Equals(PanelUtilitario)

    End Sub

    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
            _subMenuActive = subMenu
        Else
            subMenu.Visible = False
            _subMenuActive = Nothing
            hideSubMenu()
        End If

    End Sub

    Private Sub OnProjectSeletedChnged()

        ToolStripStatusProject.Text = _UPCBoxProjectSeleted.GetSelectedItemText()

        My.Settings.ProjectSelectedId = _UPCBoxProjectSeleted.GetSelectedItemId()
        My.Settings.Save()

        'RaiseEvent EvProjectSeletedChnge(Me, New EventArgs)
        _IdMatrixProjectType = -1

        OnRaiseEvProjectSeletedChnge(Me, New EventArgs)

        ResetMoneda()

    End Sub

    Public Sub ProjectNew()
        Dim _FormModalProject As New FormModalProject()
        If _FormModalProject.ShowDialog(Me) = DialogResult.OK Then   'preguntar Daniel
            _UPCBoxProjectSeleted.ReLoad()

            _UPCBoxProjectSeleted.SetSelectedItem(_FormModalProject.selectedId)
            OnProjectSeletedChnged()
        End If
    End Sub


    Public Sub ProjectOpen()
        Dim _FormProjectSelect As New FormSelectProject(_UPCBoxProjectSeleted)
        If _FormProjectSelect.ShowDialog(Me) = DialogResult.OK Then

            '----------------------------------------------
            Dim _ProgressBarLock1 As Object = GetProgressBarDialog("Loading Data...")

            'Test-----------------------------------
            'OnProjectSeletedChnged()
            'Stop
            '-------------------------------------

            Try
                '--------------------------------
                OnProjectSeletedChnged()
                '--------------------------------

                EndProgressBarDialog(_ProgressBarLock1)
            Catch ex As Exception
                EndProgressBarDialog(_ProgressBarLock1)
                Throw ex
            End Try
            '----------------------------------------------

        End If
    End Sub

    Public Sub FormInicio()
        closeChildForm()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New System.Drawing.Size(1300, 600)
        'Test-------------------------------------
        'Dim _Form1 As New Form2()
        '_Form1.Show()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~------------------------
        btnHeader1.Visible = False
        Inicializar(Me)
        LoadIcons()
        hideSubMenu()

        Me.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnInsumos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnMantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnFormulacionObras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnMiscellaneous.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))

        Me.btnMateriales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnTool.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnEquipment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnTransport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnLabour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))

        Me.btnMaterialPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnToolPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnequipmentCostPyOUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnTransportPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnLabourPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))

        'se movio a al formulario modal de projectselect
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ListColumnNames As New List(Of String)
        _ListColumnNames.Add("nameproject")
        _UPCBoxProjectSeleted = New UPComboBox("project", _ListColumnNames, "project", False)
        _UPCBoxProjectSeleted.Location = New System.Drawing.Point(17, 500)

        _UPCBoxProjectSeleted.Size = New System.Drawing.Size(186, 40)

        Me.SplitContainerWork.Panel2Collapsed = True '05/17/24

        If My.Settings.ProjectSelectedId > 0 Then
            _UPCBoxProjectSeleted.SetSelectedItem(My.Settings.ProjectSelectedId)
        Else
            _UPCBoxProjectSeleted.SetSelectedFirtItem()
        End If
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        ''Me.SplitContainer1.Panel2.Controls.Add(_UPCBoxProjectSeleted)

        Me.SplitContainer1.Panel2Collapsed = True

        ToolStripStatusProject.Text = _UPCBoxProjectSeleted.GetSelectedItemText()
        '12/07

        ToolStripStatusProject.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer),
                                                                          CType(CType(76, Byte), Integer),
                                                                          CType(CType(33, Byte), Integer))
        ToolStripStatusProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Bold,
                                              System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        ToolStripStatusProject.ForeColor = System.Drawing.Color.WhiteSmoke
        ToolStripStatusProject.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'ToolTips
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim toolTip1 As New ToolTip()

        ' Configura los retrasos para el tooltip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500

        ' Muestra el tooltip siempre, independientemente de si el formulario está activo.
        toolTip1.ShowAlways = True

        ' Asigna tooltips a los controles específicos.
        toolTip1.SetToolTip(Me.btnMenuShow, "Ocultar Menú Principal")
        toolTip1.SetToolTip(Me.btnMenuSetting, "Menú de Configuración")

        LoadMonedas()
        LoadFormChileds()
        ValidateProject()
    End Sub

#Region "FormsChild"
    Private Sub btnMateriales_Click(sender As Object, e As EventArgs) Handles btnMateriales.Click

        If _formMaterial Is Nothing Then
            _formMaterial = New FormMaterial()
        End If

        openChildForm(_formMaterial)
        'openChildForm(New FormMaterial)

    End Sub

    Private Sub btnMaterialPrice_Click(sender As Object, e As EventArgs) Handles btnMaterialPrice.Click

        'Option 1: consume memoria es mas eficiente 
        If _formMaterialPrice Is Nothing Then
            _formMaterialPrice = New FormMaterialPrice()
        End If
        openChildForm(_formMaterialPrice)

        'Option 2: consume menos memoria, pero es inficiente
        'openChildForm(New FormMaterialPrice)

    End Sub

    Private Sub btnTool_Click(sender As Object, e As EventArgs) Handles btnTool.Click

        'If _formTool Is Nothing Then
        '    _formTool = New FormTool()
        'End If

        openChildForm(New FormTool)
    End Sub

    Private Sub btnToolPrice_Click(sender As Object, e As EventArgs) Handles btnToolPrice.Click

        'If _formToolPrice Is Nothing Then
        '    _formToolPrice = New FormToolPrice()
        'End If

        openChildForm(New FormToolPrice)

    End Sub

    Private Sub btnEquipment_Click(sender As Object, e As EventArgs) Handles btnEquipment.Click

        If _formEquipment Is Nothing Then
            _formEquipment = New FormEquipment()
        End If
        openChildForm(_formEquipment)
        'openChildForm(New FormEquipment())

    End Sub

    Private Sub btnequipmentCostPyOUser_Click(sender As Object, e As EventArgs) Handles btnequipmentCostPyOUser.Click

        If _formequipmentCostPyOUser Is Nothing Then
            _formequipmentCostPyOUser = New FormEquipmentCostPyOUser()
        End If
        openChildForm(_formequipmentCostPyOUser)

        'openChildForm(New FormEquipmentCostPyOUser)

    End Sub

    Private Sub btnTransport_Click(sender As Object, e As EventArgs) Handles btnTransport.Click

        If _formTransport Is Nothing Then
            _formTransport = New FormTransport()
        End If
        openChildForm(_formTransport)
        ' openChildForm(New FormTransport())

    End Sub

    Private Sub btnTransportPrice_Click(sender As Object, e As EventArgs) Handles btnTransportPrice.Click

        If _formTransportPrice Is Nothing Then
            _formTransportPrice = New FormTransportPrice()
        End If
        openChildForm(_formTransportPrice)
        'openChildForm(New FormTransportPrice)

    End Sub

    Private Sub btnLabour_Click(sender As Object, e As EventArgs) Handles btnLabour.Click

        If _formLabour Is Nothing Then
            _formLabour = New FormLabour()
        End If
        openChildForm(_formLabour)
        'openChildForm(New FormLabour())

    End Sub

    Private Sub btnLabourPrice_Click(sender As Object, e As EventArgs) Handles btnLabourPrice.Click

        If _formLabourPrice Is Nothing Then
            _formLabourPrice = New FormLabourPrice()
        End If
        openChildForm(_formLabourPrice)
        ' openChildForm(New FormLabourPrice)

    End Sub

    Private Sub btnPartida_Click(sender As Object, e As EventArgs) Handles btnPartida.Click

        If ProjectSelectedId < 1 Then
            MessageBox.Show("debe seleccionar un proyecto", "Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ProjectOpen()
            If ProjectSelectedId < 1 Then
                MessageBox.Show("No selecciono proyecto. Formulacion de partida cancelada", "Proyecto",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        If ProjectSelectedId > 0 Then

            If _formFormulacionPartida Is Nothing Then
                _formFormulacionPartida = New FormFormulacionPartida()
            End If

            openChildForm(_formFormulacionPartida)
            'openChildForm(New FormFormulacionPartida)

        End If

    End Sub

    Private Sub btnObra_Click(sender As Object, e As EventArgs) Handles btnObra.Click

        If ProjectSelectedId < 1 Then
            MessageBox.Show("debe seleccionar un proyecto", "Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ProjectOpen()
            If ProjectSelectedId < 1 Then
                MessageBox.Show("No selecciono proyecto. Formulacion de obra cancelada", "Proyecto",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If


        If ProjectSelectedId > 0 Then

            If _formFormulaciobObra Is Nothing Then

                Dim _ProgressBarLock1 As Object = GetProgressBarDialog("Loading Data...") 'Barra de Progreso

                Try
                    _formFormulaciobObra = New FormFormulacionObra()

                    EndProgressBarDialog(_ProgressBarLock1)
                Catch ex As Exception
                    EndProgressBarDialog(_ProgressBarLock1)
                    Throw ex
                End Try
            End If

            openChildForm(_formFormulaciobObra)

            'openChildForm(New FormFormulacionObra)

        End If

    End Sub

    Private Sub btnFormulacionObras_Click(sender As Object, e As EventArgs) Handles btnFormulacionObras.Click
        showSubMenu(PanelFormulacionObras)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        showSubMenu(PanelReport)
    End Sub

    Private Sub btnUtilitarios_Click(sender As Object, e As EventArgs) Handles btnMiscellaneous.Click
        showSubMenu(PanelUtilitario)
    End Sub


#End Region

    Private Sub openChildForm(childForm As Form) 'Abrir un solo formulario en el panel contenedor

        If _CurrentForm Is Nothing OrElse Not _CurrentForm.Equals(childForm) Then

            Me.SuspendLayout()
            PanelChildForm.SuspendLayout()

            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill

            'PanelChildForm.Controls.Clear()
            PanelChildForm.Controls.Add(childForm)
            PanelChildForm.Tag = childForm

            childForm.BringToFront() 'se trae el formulario hacia el frente 


            If _CurrentForm IsNot Nothing AndAlso PanelChildForm.Controls.Contains(_CurrentForm) Then
                PanelChildForm.Controls.Remove(_CurrentForm)
            End If

            _CurrentForm = childForm

            PanelChildForm.ResumeLayout(False)
            PanelChildForm.PerformLayout()

            Me.ResumeLayout(False)
            Me.PerformLayout()

            'childForm.Refresh()
            childForm.Show()

        End If
    End Sub

    Private Sub openChildForm1(childForm As Form) 'Abrir un solo formulario en el panel contenedor
        If _CurrentForm1 IsNot Nothing Then
            Panel1.Controls.Remove(_CurrentForm1)
        End If

        'If _CurrentForm1 IsNot Nothing Then _CurrentForm1.Close() 'si existe un formulario abierto se cierra
        _CurrentForm1 = childForm 'se guarda el formulario que se abre en la variable formulario actual
        childForm.TopLevel = False 'el formulario hijo no es de nivel superior se comporta como un control
        childForm.FormBorderStyle = FormBorderStyle.None 'se quita el borde del formulario
        childForm.Dock = DockStyle.Fill 'se rellena todo el panel contenedor
        Panel1.Controls.Clear()
        Panel1.Controls.Add(childForm) 'se agrega el formulario a la lista panel contenedor
        Panel1.Tag = childForm 'se asocia el formulario con el panel contenedor
        childForm.BringToFront() 'se trae el formulario hacia el frente 
        childForm.Show()
    End Sub

    Private Sub btnInsumos_Click(sender As Object, e As EventArgs) Handles btnInsumos.Click
        showSubMenu(PanelInsumos)
    End Sub

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click
        showSubMenu(PanelMantenimiento)
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        closeChildForm()
    End Sub

    Private Sub closeChildForm()

        If _CurrentForm IsNot Nothing Then
            PanelChildForm.Controls.Remove(_CurrentForm)
        End If

        Me.PanelChildForm.Controls.Add(Me.PictureBox2)
    End Sub

#Region "SelectorMoneda"

    Private _IsCheckedChanged As Boolean = False

    Public ReadOnly Property DisplayReportMoneyTypeid As Int32
        Get
            Return MnuSelectedMoneda.Tag
        End Get
    End Property

    Public ReadOnly Property DisplayReportSymbolMoney As String
        Get
            Return MnuSelectedMoneda.Text
        End Get
    End Property

    Private Sub LoadMonedas()

        Dim _ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

        Dim _ColumnNames As New List(Of String)
        Dim _DataTable As DataTable = GetDataTable("moneyType", _ColumnNames, Nothing, True)

        For Each DataRow As DataRow In _DataTable.Rows
            _ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            _ToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            _ToolStripMenuItem.Text = DataRow("symbolMoneyType")
            _ToolStripMenuItem.CheckOnClick = True
            _ToolStripMenuItem.Checked = False
            _ToolStripMenuItem.Tag = DataRow("id")

            AddHandler _ToolStripMenuItem.CheckedChanged, AddressOf OnToolStripMenuItemCheckedChanged

            MnuSelectedMoneda.DropDownItems.Add(_ToolStripMenuItem)
        Next

        MnuSelectedMoneda.Text = ProjectSymbolMoneyType
        MnuSelectedMoneda.Tag = ProjectMoneyTypeid

    End Sub

    Private Sub OnToolStripMenuItemCheckedChanged(sender As Object, e As EventArgs)

        If Not _IsCheckedChanged Then
            _IsCheckedChanged = True
            For Each _ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem In MnuSelectedMoneda.DropDownItems
                If Not _ToolStripMenuItem.Equals(sender) Then
                    _ToolStripMenuItem.Checked = False
                End If
            Next

            With CType(sender, System.Windows.Forms.ToolStripMenuItem)
                If .Checked Then
                    MnuSelectedMoneda.Text = .Text
                    MnuSelectedMoneda.Tag = .Tag
                Else
                    MnuSelectedMoneda.Text = ProjectSymbolMoneyType
                    MnuSelectedMoneda.Tag = ProjectMoneyTypeid
                End If

            End With

            OnRaiseEvDisplayReportMoneyCheged(Me, New EventArgs)
            _IsCheckedChanged = False
        End If



    End Sub

    Private Sub ResetMoneda()
        If Not _IsCheckedChanged Then
            _IsCheckedChanged = True
            For Each _ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem In MnuSelectedMoneda.DropDownItems
                _ToolStripMenuItem.Checked = False
            Next

            MnuSelectedMoneda.Text = ProjectSymbolMoneyType
            MnuSelectedMoneda.Tag = ProjectMoneyTypeid

            'OnRaiseEvDisplayReportMoneyCheged(Me, New EventArgs)
            _IsCheckedChanged = False
        End If

    End Sub

#End Region

#Region "Formularios Modales"

    'Private Sub btnUnit2_Click(sender As Object, e As EventArgs)
    '    Dim _FormAppUnit As New FormUnit()
    '    _FormAppUnit.ShowDialog(Me)
    'End Sub

    Private Sub btnAppPartidaMatrixType_Click(sender As Object, e As EventArgs) Handles btnAppPartidaMatrixType.Click
        Dim _FormAppMatrix As New FormAppPartidaMatrixType()
        _FormAppMatrix.ShowDialog(Me)
    End Sub

    Private Sub btnMoneyType_Click(sender As Object, e As EventArgs) Handles btnMoneyType.Click
        Dim _formAppMoneyType As New FormAppMoneyType()
        _formAppMoneyType.ShowDialog(Me)
    End Sub

    Private Sub btnMoneyChange_Click(sender As Object, e As EventArgs) Handles btnMoneyChange.Click
        Dim _formAppMoneyChange As New FormAppMoneyChange()
        _formAppMoneyChange.Show(Me)
    End Sub

    'Private Sub btnCostCalType2_Click(sender As Object, e As EventArgs)
    '    Dim _FormAppCostCalType As New FormAppCostCalType()
    '    _FormAppCostCalType.ShowDialog(Me)
    'End Sub


    'Private Sub btnCostSetting3_Click(sender As Object, e As EventArgs)
    '    Dim _FormappCostValue As New FormAppCostValue()
    '    _FormappCostValue.ShowDialog(Me)
    'End Sub

    'Private Sub btnProject1_Click(sender As Object, e As EventArgs)

    '    Dim _FormModalProject As New FormModalProject()
    '    If _FormModalProject.ShowDialog(Me) = DialogResult.OK Then
    '        _UPCBoxProjectSeleted.ReLoad()

    '    End If

    'End Sub


    'Private Sub btnProjectSelect_Click(sender As Object, e As EventArgs)
    '    Dim _FormProjectSelect As New FormSelectProject(_UPCBoxProjectSeleted)
    '    _FormProjectSelect.ShowDialog(Me)
    'End Sub


    'Private Sub btnProjectCost_Click(sender As Object, e As EventArgs)
    '    Dim _FormProjectCost As New FormProjectCost()
    '    _FormProjectCost.ShowDialog(Me)
    'End Sub


#End Region

#Region "Bordes Botones"


    Private Sub btnMateriales_MouseEnter(sender As Object, e As EventArgs) Handles btnMateriales.MouseEnter
        btnMateriales.FlatAppearance.BorderSize = 1

    End Sub

    Private Sub btnMateriales_MouseLeave(sender As Object, e As EventArgs) Handles btnMateriales.MouseLeave
        btnMateriales.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnHerramientas_MouseEnter(sender As Object, e As EventArgs) Handles btnTool.MouseEnter
        btnTool.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnHerramientas_MouseLeave(sender As Object, e As EventArgs) Handles btnTool.MouseLeave
        btnTool.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnInsumos_MouseEnter(sender As Object, e As EventArgs) Handles btnInsumos.MouseEnter
        btnInsumos.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnInsumos_MouseLeave(sender As Object, e As EventArgs) Handles btnInsumos.MouseLeave
        btnInsumos.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnInicio_MouseEnter(sender As Object, e As EventArgs) Handles btnInicio.MouseEnter
        btnInicio.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnInicio_MouseLeave(sender As Object, e As EventArgs) Handles btnInicio.MouseLeave
        btnInicio.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnMantenimiento_MouseEnter(sender As Object, e As EventArgs) Handles btnMantenimiento.MouseEnter
        btnMantenimiento.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMantenimiento_MouseLeave(sender As Object, e As EventArgs) Handles btnMantenimiento.MouseLeave
        btnMantenimiento.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnFormulacionObras_MouseEnter(sender As Object, e As EventArgs) Handles btnFormulacionObras.MouseEnter
        btnFormulacionObras.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnFormulacionObras_MouseLeave(sender As Object, e As EventArgs) Handles btnFormulacionObras.MouseLeave
        btnFormulacionObras.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnUtilitarios_MouseEnter(sender As Object, e As EventArgs) Handles btnMiscellaneous.MouseEnter
        btnMiscellaneous.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnUtilitarios_MouseLeave(sender As Object, e As EventArgs) Handles btnMiscellaneous.MouseLeave
        btnMiscellaneous.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnAyuda_MouseEnter(sender As Object, e As EventArgs) Handles btnReport.MouseEnter
        btnReport.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnAyuda_MouseLeave(sender As Object, e As EventArgs) Handles btnReport.MouseLeave
        btnReport.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnEquipos_MouseEnter(sender As Object, e As EventArgs) Handles btnEquipment.MouseEnter
        btnEquipment.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnEquipos_MouseLeave(sender As Object, e As EventArgs) Handles btnEquipment.MouseLeave
        btnEquipment.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnTransporte_MouseEnter(sender As Object, e As EventArgs) Handles btnTransport.MouseEnter
        btnTransport.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnTransporte_MouseLeave(sender As Object, e As EventArgs) Handles btnTransport.MouseLeave
        btnTransport.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnLabour_MouseEnter(sender As Object, e As EventArgs) Handles btnLabour.MouseEnter
        btnLabour.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnLabour_MouseLeave(sender As Object, e As EventArgs) Handles btnLabour.MouseLeave
        btnLabour.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnObras_MouseEnter(sender As Object, e As EventArgs) Handles btnObra.MouseEnter
        btnObra.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnObras_MouseLeave(sender As Object, e As EventArgs) Handles btnObra.MouseLeave
        btnObra.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnPartida_MouseEnter(sender As Object, e As EventArgs) Handles btnPartida.MouseEnter
        btnPartida.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnPartida_MouseLeave(sender As Object, e As EventArgs) Handles btnPartida.MouseLeave
        btnPartida.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnUser_MouseEnter(sender As Object, e As EventArgs) Handles btnReservado.MouseEnter
        btnReservado.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnUser_MouseLeave(sender As Object, e As EventArgs) Handles btnReservado.MouseLeave
        btnReservado.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnPermission_MouseEnter(sender As Object, e As EventArgs) Handles btnReservado2.MouseEnter
        btnReservado2.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnPermission_MouseLeave(sender As Object, e As EventArgs) Handles btnReservado2.MouseLeave
        btnReservado2.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnMaterialPrice_MouseEnter(sender As Object, e As EventArgs) Handles btnMaterialPrice.MouseEnter
        btnMaterialPrice.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMaterialPrice_MouseLeave(sender As Object, e As EventArgs) Handles btnMaterialPrice.MouseLeave
        btnMaterialPrice.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnequipmentCostPyOUser_MouseEnter(sender As Object, e As EventArgs) Handles btnequipmentCostPyOUser.MouseEnter
        btnequipmentCostPyOUser.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnequipmentCostPyOUser_MouseLeave(sender As Object, e As EventArgs) Handles btnequipmentCostPyOUser.MouseLeave
        btnequipmentCostPyOUser.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnTransportPrice_MouseEnter(sender As Object, e As EventArgs) Handles btnTransportPrice.MouseEnter
        btnTransportPrice.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnTransportPrice_MouseLeave(sender As Object, e As EventArgs) Handles btnTransportPrice.MouseLeave
        btnTransportPrice.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnToolPrice_MouseEnter(sender As Object, e As EventArgs) Handles btnToolPrice.MouseEnter
        btnToolPrice.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnToolPrice_MouseLeave(sender As Object, e As EventArgs) Handles btnToolPrice.MouseLeave
        btnToolPrice.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnLabourPrice_MouseEnter(sender As Object, e As EventArgs) Handles btnLabourPrice.MouseEnter
        btnLabourPrice.FlatAppearance.BorderSize = 1

    End Sub

    Private Sub btnLabourPrice_MouseLeave(sender As Object, e As EventArgs) Handles btnLabourPrice.MouseLeave
        btnLabourPrice.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnReport1_MouseEnter(sender As Object, e As EventArgs) Handles btnReport1.MouseEnter
        btnReport1.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReport1_MouseLeave(sender As Object, e As EventArgs) Handles btnReport1.MouseLeave
        btnReport1.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnReport2_MouseEnter(sender As Object, e As EventArgs) Handles btnReport2.MouseEnter
        btnReport2.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnReport2_MouseLeave(sender As Object, e As EventArgs) Handles btnReport2.MouseLeave
        btnReport2.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnHelp_MouseEnter(sender As Object, e As EventArgs) Handles btnHelp.MouseEnter
        btnHelp.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnHelp_MouseLeave(sender As Object, e As EventArgs) Handles btnHelp.MouseLeave
        btnHelp.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnProject1_MouseEnter(sender As Object, e As EventArgs)
        btnProjectNew.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnProject1_MouseLeave(sender As Object, e As EventArgs)
        btnProjectNew.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnCostSetting3_MouseEnter(sender As Object, e As EventArgs)
        btnCostValue.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCostSetting3_MouseLeave(sender As Object, e As EventArgs)
        btnCostValue.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnCostCalType2_MouseEnter(sender As Object, e As EventArgs)
        btnCostCalType.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCostCalType2_MouseLeave(sender As Object, e As EventArgs)
        btnCostCalType.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnUnit2_MouseEnter(sender As Object, e As EventArgs)
        btnAppUnit.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnUnit2_MouseLeave(sender As Object, e As EventArgs)
        btnAppUnit.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnMatrixType2_MouseEnter(sender As Object, e As EventArgs) Handles btnAppPartidaMatrixType.MouseEnter
        btnAppPartidaMatrixType.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMatrixType2_MouseLeave(sender As Object, e As EventArgs) Handles btnAppPartidaMatrixType.MouseLeave
        btnAppPartidaMatrixType.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnUsers_MouseEnter(sender As Object, e As EventArgs) Handles btnUsers.MouseEnter
        btnUsers.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnUsers_MouseLeave(sender As Object, e As EventArgs) Handles btnUsers.MouseLeave
        btnUsers.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnPermissions_MouseEnter(sender As Object, e As EventArgs) Handles btnPermissions.MouseEnter
        btnPermissions.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnPermissions_MouseLeave(sender As Object, e As EventArgs) Handles btnPermissions.MouseLeave
        btnPermissions.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnAppUnit_MouseEnter(sender As Object, e As EventArgs) Handles btnAppUnit.MouseEnter
        btnAppUnit.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnAppUnit_MouseLeave(sender As Object, e As EventArgs) Handles btnAppUnit.MouseLeave
        btnAppUnit.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnCostCalType_MouseEnter(sender As Object, e As EventArgs) Handles btnCostCalType.MouseEnter
        btnCostCalType.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCostCalType_MouseLeave(sender As Object, e As EventArgs) Handles btnCostCalType.MouseLeave
        btnCostCalType.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnCostValue_MouseEnter(sender As Object, e As EventArgs) Handles btnCostValue.MouseEnter
        btnCostValue.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnCostValue_MouseLeave(sender As Object, e As EventArgs) Handles btnCostValue.MouseLeave
        btnCostValue.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnProjectNew_MouseEnter(sender As Object, e As EventArgs) Handles btnProjectNew.MouseEnter
        btnProjectNew.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnProjectNew_MouseLeave(sender As Object, e As EventArgs) Handles btnProjectNew.MouseLeave
        btnProjectNew.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnProjectOpen_MouseEnter(sender As Object, e As EventArgs) Handles btnProjectOpen.MouseEnter
        btnProjectOpen.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnProjectOpen_MouseLeave(sender As Object, e As EventArgs) Handles btnProjectOpen.MouseLeave
        btnProjectOpen.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnProjectCost_MouseEnter(sender As Object, e As EventArgs) Handles btnProjectCost.MouseEnter
        btnProjectCost.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnProjectCost_MouseLeave(sender As Object, e As EventArgs) Handles btnProjectCost.MouseLeave
        btnProjectCost.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnMenuShow_MouseEnter(sender As Object, e As EventArgs) Handles btnMenuShow.MouseEnter
        btnMenuShow.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMenuShow_MouseLeave(sender As Object, e As EventArgs) Handles btnMenuShow.MouseLeave
        btnMenuShow.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnMenuSetting_MouseEnter(sender As Object, e As EventArgs) Handles btnMenuSetting.MouseEnter
        btnMenuSetting.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMenuSetting_MouseLeave(sender As Object, e As EventArgs) Handles btnMenuSetting.MouseLeave
        btnMenuSetting.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnMoneyType_MouseEnter(sender As Object, e As EventArgs) Handles btnMoneyType.MouseEnter
        btnMoneyType.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMoneyType_MouseLeave(sender As Object, e As EventArgs) Handles btnMoneyType.MouseLeave
        btnMoneyType.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnMoneyChange_MouseEnter(sender As Object, e As EventArgs) Handles btnMoneyChange.MouseEnter
        btnMoneyChange.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMoneyChange_MouseLeave(sender As Object, e As EventArgs) Handles btnMoneyChange.MouseLeave
        btnMoneyChange.FlatAppearance.BorderSize = 0
    End Sub


#End Region

    Private Sub ToolStripStatusLabel1_DoubleClick(sender As Object, e As EventArgs) Handles ToolStripStatusProject.DoubleClick
        Me.SplitContainer1.Panel2Collapsed = Not Me.SplitContainer1.Panel2Collapsed
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Dim _FormModalProject As New FormModalProject()
        'If _FormModalProject.ShowDialog(Me) = DialogResult.OK Then   'preguntar Daniel
        '    _UPCBoxProjectSeleted.ReLoad()
        '    '_UPCBoxProjectSeleted.SetSelectedItem(_FormModalProject.ProjectId)
        'End If
    End Sub

    Private Sub btnAppUnit_Click(sender As Object, e As EventArgs) Handles btnAppUnit.Click
        Dim _FormAppUnit As New FormAppUnit()
        _FormAppUnit.ShowDialog(Me)
    End Sub

    Private Sub btnCostCalType_Click(sender As Object, e As EventArgs) Handles btnCostCalType.Click
        Dim _FormAppCostCalType As New FormAppCostCalType()
        _FormAppCostCalType.ShowDialog(Me)
    End Sub

    Private Sub btnCostValue_Click(sender As Object, e As EventArgs) Handles btnCostValue.Click
        Dim _FormappCostValue As New FormAppCostValue()
        _FormappCostValue.ShowDialog(Me)
    End Sub

    Private Sub btnProjectNew_Click(sender As Object, e As EventArgs) Handles btnProjectNew.Click
        ProjectNew()
    End Sub

    Private Sub btnProjectOpen_Click(sender As Object, e As EventArgs) Handles btnProjectOpen.Click
        ProjectOpen()
    End Sub

    Private Sub btnProjectCost_Click_1(sender As Object, e As EventArgs) Handles btnProjectCost.Click
        Dim _FormProjectCost As New FormProjectCost()
        _FormProjectCost.ShowDialog(Me)
    End Sub

    Private Sub btnMenuShow_Click(sender As Object, e As EventArgs) Handles btnMenuShow.Click
        'PanelMenu.Hide()
        'Me.PanelMenu.Width = 249
        'If PanelMenu.Width = 250 Then
        '    TimerHideMenu.Enabled = True
        'ElseIf PanelMenu.Width = 50 Then
        '    TimerShowMenu.Enabled = True
        'End If
        If PanelMenu.Width = 250 Then
            PanelMenu.Width = 0
        ElseIf PanelMenu.Width = 0 Then
            PanelMenu.Width = 250
        End If

    End Sub

    Private Sub btnMenuShow_DoubleClick(sender As Object, e As EventArgs) Handles btnMenuShow.DoubleClick
        Me.PanelMenu.Width = 0
    End Sub

    Private Sub btnHeader1_Click(sender As Object, e As EventArgs) Handles btnHeader1.Click


        Me.SplitContainerWork.Panel2Collapsed = Not Me.SplitContainerWork.Panel2Collapsed


        Dim _Report As New FormReportPriceAnalysis(1)
        openChildForm1(_Report)
    End Sub

    Private Sub btnHeader2_Click(sender As Object, e As EventArgs) Handles btnMenuSetting.Click
        Me.SplitContainer1.Panel2Collapsed = Not Me.SplitContainer1.Panel2Collapsed
    End Sub

    Private Sub btnReport2_Click(sender As Object, e As EventArgs) Handles btnReport2.Click
        'If IsPartidaARG Then
        '    Dim _FormReportPartida As New FormReportPriceAnalisysArg()
        '    _FormReportPartida.Show(Me)
        'Else

        'End If
        'Dim _FormReportPartida As New FormReportPartida()
        '_FormReportPartida.Show(Me)


        Dim _FormReportPartida As New FormReportPartida()
        _FormReportPartida.Show(Me)
    End Sub

    Private Sub btnReport1_Click(sender As Object, e As EventArgs) Handles btnReport1.Click
        'Dim _FormBudget As New FormBudget()
        '_FormBudget.ShowDialog(Me)
        'Dim _FormCompoundLabour As New FormCompoundLabour()
        '_FormCompoundLabour.Show(Me)

        Dim _Report As New FormReportMaterialPrice()
        _Report.Show(Me)

    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnReservado.Click

        'ViewEquipmentPrice()
        'ViewAPU(VForm:=Me)
        'Dim _FormCompoundMaterial As New FormCompoundMaterial()
        '_FormCompoundMaterial.Show(Me) EquipmentType_id As Int32, ByVal DisplayType As EnumDisplayType
        'FomEqmtPriceEst

        'Dim _FormEqmtPriceEst1 As New FomEqmtPriceEst(1, EnumDisplayType.Display)
        '_FormEqmtPriceEst1.Show(Me)

    End Sub

    Private Sub btnReservado2_Click(sender As Object, e As EventArgs) Handles btnReservado2.Click
        'Dim _FormCompoundEquipment As New FormCompoundEquipment()
        '_FormCompoundEquipment.Show(Me)

        'Dim _FormEqmtPriceEst3 As New FormEqmtPriceEst3(1, EnumDisplayType.Display)
        '_FormEqmtPriceEst3.Show(Me)


    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim _FormEqmtPriceEst2 As New FormEqmtPriceEst2(1, EnumDisplayType.Display)
        _FormEqmtPriceEst2.Show(Me)
    End Sub

    Private Sub PanelHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelHeader.Paint


        'Dim startPoint As New System.Drawing.Point(Me.Width - Me.Size.Width, Me.Height - Me.Size.Height)
        Dim startPoint As New System.Drawing.Point(0, 0)
        'Dim endPoint As New System.Drawing.Point(Me.Width, Me.Height)
        Dim endPoint As New System.Drawing.Point(PanelHeader.Width, PanelHeader.Height)
        Dim startColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer),
                                                       CType(CType(33, Byte), Integer),
                                                       CType(CType(58, Byte), Integer))
        Dim endColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer),
                                                     CType(CType(88, Byte), Integer),
                                                     CType(CType(177, Byte), Integer))


        'startColor = Color.Red

        Using linGrBrush As New LinearGradientBrush(startPoint, endPoint, startColor, endColor)
            'e.Graphics.FillRectangle(linGrBrush, Me.Width - Me.Size.Width, Me.Height - Me.Size.Height, Me.Width, Me.Height)
            e.Graphics.FillRectangle(linGrBrush, 0, 0, PanelHeader.Width, PanelHeader.Height)
        End Using
    End Sub

    Private Sub FormUpaz_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        PanelHeader.Refresh()
    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

        Dim startPoint As New System.Drawing.Point(0, 0)

        Dim endPoint As New System.Drawing.Point(PanelHeader.Width, PanelHeader.Height)
        Dim startColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer),
                                                       CType(CType(33, Byte), Integer),
                                                       CType(CType(58, Byte), Integer))
        'Dim endColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer),
        '                                             CType(CType(88, Byte), Integer),
        '                                             CType(CType(177, Byte), Integer))

        Dim endColor = System.Drawing.Color.Red

        Using linGrBrush As New LinearGradientBrush(startPoint, endPoint, startColor, endColor)

            e.Graphics.FillRectangle(linGrBrush, 0, 0, PanelHeader.Width, PanelHeader.Height)
        End Using
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    '(https://fontawesome.com/search?s=solid&f=sharp-duotone&o=r)

End Class





