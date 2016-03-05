<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainIssue
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataSetMainIssue = New SROI_SKRIPSI.DataSetMainIssue()
        Me.MainIssueDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainIssueDataTableTableAdapter = New SROI_SKRIPSI.DataSetMainIssueTableAdapters.MainIssueDataTableTableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetMainIssueTableAdapters.TableAdapterManager()
        Me.MainIssueDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpurpose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbackground = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrangeOfActivities = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisForecast = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.buttonSave = New DevExpress.XtraEditors.SimpleButton()
        Me.idSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.idProjectSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.purposeMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.backgroundMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.rangeOfActivitiesMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.isForecastCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.idUserSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ItemForid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidProject = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidUser = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForpurpose = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForbackground = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForrangeOfActivities = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForisForecast = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetMainIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainIssueDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainIssueDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idProjectSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.purposeMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backgroundMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rangeOfActivitiesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isForecastCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idUserSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpurpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForrangeOfActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForisForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetMainIssue
        '
        Me.DataSetMainIssue.DataSetName = "DataSetMainIssue"
        Me.DataSetMainIssue.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainIssueDataTableBindingSource
        '
        Me.MainIssueDataTableBindingSource.DataMember = "MainIssueDataTable"
        Me.MainIssueDataTableBindingSource.DataSource = Me.DataSetMainIssue
        '
        'MainIssueDataTableTableAdapter
        '
        Me.MainIssueDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MainIssueDataTableTableAdapter = Me.MainIssueDataTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetMainIssueTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainIssueDataTableGridControl
        '
        Me.MainIssueDataTableGridControl.DataSource = Me.MainIssueDataTableBindingSource
        Me.MainIssueDataTableGridControl.Location = New System.Drawing.Point(433, 25)
        Me.MainIssueDataTableGridControl.MainView = Me.GridView1
        Me.MainIssueDataTableGridControl.Name = "MainIssueDataTableGridControl"
        Me.MainIssueDataTableGridControl.Size = New System.Drawing.Size(296, 261)
        Me.MainIssueDataTableGridControl.TabIndex = 2
        Me.MainIssueDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidProject, Me.colpurpose, Me.colbackground, Me.colrangeOfActivities, Me.colisForecast, Me.colidUser})
        Me.GridView1.GridControl = Me.MainIssueDataTableGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'colidProject
        '
        Me.colidProject.FieldName = "idProject"
        Me.colidProject.Name = "colidProject"
        Me.colidProject.Visible = True
        Me.colidProject.VisibleIndex = 1
        '
        'colpurpose
        '
        Me.colpurpose.FieldName = "purpose"
        Me.colpurpose.Name = "colpurpose"
        Me.colpurpose.Visible = True
        Me.colpurpose.VisibleIndex = 2
        '
        'colbackground
        '
        Me.colbackground.FieldName = "background"
        Me.colbackground.Name = "colbackground"
        Me.colbackground.Visible = True
        Me.colbackground.VisibleIndex = 3
        '
        'colrangeOfActivities
        '
        Me.colrangeOfActivities.FieldName = "rangeOfActivities"
        Me.colrangeOfActivities.Name = "colrangeOfActivities"
        Me.colrangeOfActivities.Visible = True
        Me.colrangeOfActivities.VisibleIndex = 4
        '
        'colisForecast
        '
        Me.colisForecast.FieldName = "isForecast"
        Me.colisForecast.Name = "colisForecast"
        Me.colisForecast.Visible = True
        Me.colisForecast.VisibleIndex = 5
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        Me.colidUser.Visible = True
        Me.colidUser.VisibleIndex = 6
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.buttonSave)
        Me.DataLayoutControl1.Controls.Add(Me.idSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idProjectSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.purposeMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.backgroundMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.rangeOfActivitiesMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.isForecastCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idUserSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.MainIssueDataTableBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid, Me.ItemForidProject, Me.ItemForidUser})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 12)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(405, 365)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'buttonSave
        '
        Me.buttonSave.Location = New System.Drawing.Point(12, 331)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(381, 22)
        Me.buttonSave.StyleController = Me.DataLayoutControl1
        Me.buttonSave.TabIndex = 11
        Me.buttonSave.Text = "Save"
        '
        'idSpinEdit
        '
        Me.idSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MainIssueDataTableBindingSource, "id", True))
        Me.idSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.idSpinEdit.Location = New System.Drawing.Point(105, 12)
        Me.idSpinEdit.Name = "idSpinEdit"
        Me.idSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.idSpinEdit.Properties.Mask.EditMask = "N0"
        Me.idSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idSpinEdit.Size = New System.Drawing.Size(248, 20)
        Me.idSpinEdit.StyleController = Me.DataLayoutControl1
        Me.idSpinEdit.TabIndex = 4
        '
        'idProjectSpinEdit
        '
        Me.idProjectSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MainIssueDataTableBindingSource, "idProject", True))
        Me.idProjectSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.idProjectSpinEdit.Location = New System.Drawing.Point(105, 12)
        Me.idProjectSpinEdit.Name = "idProjectSpinEdit"
        Me.idProjectSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idProjectSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idProjectSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idProjectSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.idProjectSpinEdit.Properties.Mask.EditMask = "N0"
        Me.idProjectSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idProjectSpinEdit.Size = New System.Drawing.Size(248, 20)
        Me.idProjectSpinEdit.StyleController = Me.DataLayoutControl1
        Me.idProjectSpinEdit.TabIndex = 5
        '
        'purposeMemoEdit
        '
        Me.purposeMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MainIssueDataTableBindingSource, "purpose", True))
        Me.purposeMemoEdit.Location = New System.Drawing.Point(107, 12)
        Me.purposeMemoEdit.Name = "purposeMemoEdit"
        Me.purposeMemoEdit.Size = New System.Drawing.Size(286, 88)
        Me.purposeMemoEdit.StyleController = Me.DataLayoutControl1
        Me.purposeMemoEdit.TabIndex = 6
        '
        'backgroundMemoEdit
        '
        Me.backgroundMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MainIssueDataTableBindingSource, "background", True))
        Me.backgroundMemoEdit.Location = New System.Drawing.Point(107, 104)
        Me.backgroundMemoEdit.Name = "backgroundMemoEdit"
        Me.backgroundMemoEdit.Size = New System.Drawing.Size(286, 59)
        Me.backgroundMemoEdit.StyleController = Me.DataLayoutControl1
        Me.backgroundMemoEdit.TabIndex = 7
        '
        'rangeOfActivitiesMemoEdit
        '
        Me.rangeOfActivitiesMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MainIssueDataTableBindingSource, "rangeOfActivities", True))
        Me.rangeOfActivitiesMemoEdit.Location = New System.Drawing.Point(107, 167)
        Me.rangeOfActivitiesMemoEdit.Name = "rangeOfActivitiesMemoEdit"
        Me.rangeOfActivitiesMemoEdit.Size = New System.Drawing.Size(286, 137)
        Me.rangeOfActivitiesMemoEdit.StyleController = Me.DataLayoutControl1
        Me.rangeOfActivitiesMemoEdit.TabIndex = 8
        '
        'isForecastCheckEdit
        '
        Me.isForecastCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MainIssueDataTableBindingSource, "isForecast", True))
        Me.isForecastCheckEdit.Location = New System.Drawing.Point(107, 308)
        Me.isForecastCheckEdit.Name = "isForecastCheckEdit"
        Me.isForecastCheckEdit.Properties.Caption = "is Forecast"
        Me.isForecastCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.isForecastCheckEdit.Size = New System.Drawing.Size(286, 19)
        Me.isForecastCheckEdit.StyleController = Me.DataLayoutControl1
        Me.isForecastCheckEdit.TabIndex = 9
        '
        'idUserSpinEdit
        '
        Me.idUserSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MainIssueDataTableBindingSource, "idUser", True))
        Me.idUserSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.idUserSpinEdit.Location = New System.Drawing.Point(12, 333)
        Me.idUserSpinEdit.Name = "idUserSpinEdit"
        Me.idUserSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idUserSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idUserSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idUserSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.idUserSpinEdit.Properties.Mask.EditMask = "N0"
        Me.idUserSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idUserSpinEdit.Size = New System.Drawing.Size(381, 20)
        Me.idUserSpinEdit.StyleController = Me.DataLayoutControl1
        Me.idUserSpinEdit.TabIndex = 10
        '
        'ItemForid
        '
        Me.ItemForid.Control = Me.idSpinEdit
        Me.ItemForid.Location = New System.Drawing.Point(0, 0)
        Me.ItemForid.Name = "ItemForid"
        Me.ItemForid.Size = New System.Drawing.Size(345, 24)
        Me.ItemForid.Text = "id"
        Me.ItemForid.TextSize = New System.Drawing.Size(50, 20)
        '
        'ItemForidProject
        '
        Me.ItemForidProject.Control = Me.idProjectSpinEdit
        Me.ItemForidProject.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidProject.Name = "ItemForidProject"
        Me.ItemForidProject.Size = New System.Drawing.Size(345, 24)
        Me.ItemForidProject.Text = "id Project"
        Me.ItemForidProject.TextSize = New System.Drawing.Size(50, 20)
        '
        'ItemForidUser
        '
        Me.ItemForidUser.Control = Me.idUserSpinEdit
        Me.ItemForidUser.Location = New System.Drawing.Point(0, 321)
        Me.ItemForidUser.Name = "ItemForidUser"
        Me.ItemForidUser.Size = New System.Drawing.Size(385, 24)
        Me.ItemForidUser.Text = "id User"
        Me.ItemForidUser.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForidUser.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(405, 365)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForpurpose, Me.ItemForbackground, Me.ItemForrangeOfActivities, Me.ItemForisForecast, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(385, 345)
        '
        'ItemForpurpose
        '
        Me.ItemForpurpose.Control = Me.purposeMemoEdit
        Me.ItemForpurpose.Location = New System.Drawing.Point(0, 0)
        Me.ItemForpurpose.Name = "ItemForpurpose"
        Me.ItemForpurpose.Size = New System.Drawing.Size(385, 92)
        Me.ItemForpurpose.StartNewLine = True
        Me.ItemForpurpose.Text = "Purpose"
        Me.ItemForpurpose.TextSize = New System.Drawing.Size(92, 13)
        '
        'ItemForbackground
        '
        Me.ItemForbackground.Control = Me.backgroundMemoEdit
        Me.ItemForbackground.Location = New System.Drawing.Point(0, 92)
        Me.ItemForbackground.Name = "ItemForbackground"
        Me.ItemForbackground.Size = New System.Drawing.Size(385, 63)
        Me.ItemForbackground.StartNewLine = True
        Me.ItemForbackground.Text = "Background"
        Me.ItemForbackground.TextSize = New System.Drawing.Size(92, 13)
        '
        'ItemForrangeOfActivities
        '
        Me.ItemForrangeOfActivities.Control = Me.rangeOfActivitiesMemoEdit
        Me.ItemForrangeOfActivities.Location = New System.Drawing.Point(0, 155)
        Me.ItemForrangeOfActivities.Name = "ItemForrangeOfActivities"
        Me.ItemForrangeOfActivities.Size = New System.Drawing.Size(385, 141)
        Me.ItemForrangeOfActivities.StartNewLine = True
        Me.ItemForrangeOfActivities.Text = "Range Of Activities"
        Me.ItemForrangeOfActivities.TextSize = New System.Drawing.Size(92, 13)
        '
        'ItemForisForecast
        '
        Me.ItemForisForecast.Control = Me.isForecastCheckEdit
        Me.ItemForisForecast.Location = New System.Drawing.Point(0, 296)
        Me.ItemForisForecast.Name = "ItemForisForecast"
        Me.ItemForisForecast.Size = New System.Drawing.Size(385, 23)
        Me.ItemForisForecast.Text = "Is Forecast"
        Me.ItemForisForecast.TextLocation = DevExpress.Utils.Locations.Left
        Me.ItemForisForecast.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.buttonSave
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 319)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(385, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormMainIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 398)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.MainIssueDataTableGridControl)
        Me.Name = "FormMainIssue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMainIssue"
        CType(Me.DataSetMainIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainIssueDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainIssueDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idProjectSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.purposeMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backgroundMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rangeOfActivitiesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isForecastCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idUserSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpurpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForbackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForrangeOfActivities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForisForecast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSetMainIssue As DataSetMainIssue
    Friend WithEvents MainIssueDataTableBindingSource As BindingSource
    Friend WithEvents MainIssueDataTableTableAdapter As DataSetMainIssueTableAdapters.MainIssueDataTableTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMainIssueTableAdapters.TableAdapterManager
    Friend WithEvents MainIssueDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents idSpinEdit As SpinEdit
    Friend WithEvents idProjectSpinEdit As SpinEdit
    Friend WithEvents purposeMemoEdit As MemoEdit
    Friend WithEvents backgroundMemoEdit As MemoEdit
    Friend WithEvents rangeOfActivitiesMemoEdit As MemoEdit
    Friend WithEvents isForecastCheckEdit As CheckEdit
    Friend WithEvents idUserSpinEdit As SpinEdit
    Friend WithEvents ItemForid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidProject As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidUser As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForpurpose As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForbackground As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForrangeOfActivities As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForisForecast As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpurpose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbackground As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrangeOfActivities As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisForecast As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents buttonSave As SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
