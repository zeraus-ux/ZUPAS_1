Public Class FormProjectCost

    Private WithEvents _UPDGViewProjectCost As UPDataGridView
    Private WithEvents _UPDGViewprojectCostValue As UPDataGridView

    Public Sub New()

        InitializeComponent()

        Dim _DataGridViewColumn As DataGridViewColumn

        _UPDGViewProjectCost = New UPDataGridView("projectCost")
        _UPDGViewProjectCost.Dock = DockStyle.Fill
        _UPDGViewProjectCost.AllowUserToAddRows = False
        _UPDGViewProjectCost.AllowUserToDeleteRows = False
        _UPDGViewProjectCost.EditMode = DataGridViewEditMode.EditOnEnter

        _UPDGViewProjectCost.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Regular), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPDGViewProjectCost.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _UPDGViewProjectCost.Font = New System.Drawing.Font("Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Regular), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))


        _UPDGViewProjectCost.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))


        _UPDGViewProjectCost.RowHeadersVisible = False

       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewProjectCost.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Obra_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewProjectCost.CrearteColumnText("project_id", "project_id", True, False, False)
        _DataGridViewColumn.Visible = False

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cost_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim _ColumnNames2 As New List(Of String)
        _ColumnNames2.Add("refCostCalType")
        _ColumnNames2.Add("nameCostCalType")

        _DataGridViewColumn = _UPDGViewProjectCost.CreateColumnComboBox("appCostCalType_id", "Costos Directos e Indirectos", True, True, False,
                                                                         "appCostCalType", _ColumnNames2, "cost", True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DataGridViewColumn.ReadOnly = True

       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Value
       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim _DataTable1 = GetProjectCost(ProjectSelectedId)
        _UPDGViewProjectCost.DataSource = _DataTable1

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'UPDGViewprojectCostValue
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _UPDGViewprojectCostValue = New UPDataGridView("projectCostValue")
        _UPDGViewprojectCostValue.Dock = DockStyle.Fill
        _UPDGViewprojectCostValue.AllowUserToAddRows = False
        _UPDGViewprojectCostValue.AllowUserToDeleteRows = False
        _UPDGViewprojectCostValue.EditMode = DataGridViewEditMode.EditOnEnter

        _UPDGViewprojectCostValue.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Regular), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPDGViewprojectCostValue.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        _UPDGViewprojectCostValue.Font = New System.Drawing.Font("Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Regular), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _UPDGViewprojectCostValue.RowHeadersVisible = False

        _UPDGViewprojectCostValue.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))

       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewprojectCostValue.CrearteColumnText("id", "id", True, False, False)
        _DataGridViewColumn.Visible = False

        ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-
        ''Column Obra_id
        ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        _DataGridViewColumn = _UPDGViewprojectCostValue.CrearteColumnText("project_id", "project_id", True, False, False)
        _DataGridViewColumn.Visible = False

       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Cost_id
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim _ColumnNames3 As New List(Of String)
        _ColumnNames3.Add("refCostValue")
        _ColumnNames3.Add("nameCostValue")

        _DataGridViewColumn = _UPDGViewprojectCostValue.CreateColumnComboBox("appCostValue_id", "Costos Directos e Indirectos", True, True, False,
                                                                               "appCostValue", _ColumnNames3, "cost", True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        _DataGridViewColumn.ReadOnly = True

       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Column Value
       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        _DataGridViewColumn = _UPDGViewprojectCostValue.CrearteColumnFloat("defaultCostUser", "Valor", False, True)
        _DataGridViewColumn.Visible = True
        _DataGridViewColumn.Width = 150

        Dim _DataTable2 = GetprojectCostValue(ProjectSelectedId)
        _UPDGViewprojectCostValue.DataSource = _DataTable2

        Me.TabPage1.Controls.Add(_UPDGViewProjectCost)
        Me.TabPage2.Controls.Add(_UPDGViewprojectCostValue)

        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))

    End Sub

    Private Sub FormObraCostDirect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Controls.Remove(_UPDGViewProjectCost)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        _UPDGViewProjectCost.Saves("project_id", ProjectSelectedId)
        _UPDGViewprojectCostValue.Saves("project_id", ProjectSelectedId)

        Me.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class