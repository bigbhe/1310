<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProject))
        Me.DataSetProject = New SROI_SKRIPSI.DataSetProject()
        Me.MstProjectDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstProjectDataTableTableAdapter = New SROI_SKRIPSI.DataSetProjectTableAdapters.mstProjectDataTableTableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetProjectTableAdapters.TableAdapterManager()
        Me.MstProjectDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MstProjectDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstProjectDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidCompany = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lookUpEditCompany = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CountryForProjectSelectCommandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProject1 = New SROI_SKRIPSI.DataSetProject()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.NameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.idCompanyLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.DateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.idUserSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.noteMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ItemForid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidCompany = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidUser = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFornote = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CountryForProject_SelectCommandTableAdapter = New SROI_SKRIPSI.DataSetProjectTableAdapters.CountryForProject_SelectCommandTableAdapter()
        CType(Me.DataSetProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstProjectDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstProjectDataTableBindingNavigator.SuspendLayout()
        CType(Me.MstProjectDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpEditCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryForProjectSelectCommandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProject1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idCompanyLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idUserSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetProject
        '
        Me.DataSetProject.DataSetName = "DataSetProject"
        Me.DataSetProject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstProjectDataTableBindingSource
        '
        Me.MstProjectDataTableBindingSource.DataMember = "mstProjectDataTable"
        Me.MstProjectDataTableBindingSource.DataSource = Me.DataSetProject
        '
        'MstProjectDataTableTableAdapter
        '
        Me.MstProjectDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstProjectDataTableTableAdapter = Me.MstProjectDataTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetProjectTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstProjectDataTableBindingNavigator
        '
        Me.MstProjectDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstProjectDataTableBindingNavigator.BindingSource = Me.MstProjectDataTableBindingSource
        Me.MstProjectDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstProjectDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstProjectDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstProjectDataTableBindingNavigatorSaveItem})
        Me.MstProjectDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstProjectDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstProjectDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstProjectDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstProjectDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstProjectDataTableBindingNavigator.Name = "MstProjectDataTableBindingNavigator"
        Me.MstProjectDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstProjectDataTableBindingNavigator.Size = New System.Drawing.Size(840, 25)
        Me.MstProjectDataTableBindingNavigator.TabIndex = 0
        Me.MstProjectDataTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MstProjectDataTableBindingNavigatorSaveItem
        '
        Me.MstProjectDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstProjectDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstProjectDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstProjectDataTableBindingNavigatorSaveItem.Name = "MstProjectDataTableBindingNavigatorSaveItem"
        Me.MstProjectDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstProjectDataTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstProjectDataTableGridControl
        '
        Me.MstProjectDataTableGridControl.DataSource = Me.MstProjectDataTableBindingSource
        Me.MstProjectDataTableGridControl.Location = New System.Drawing.Point(333, 39)
        Me.MstProjectDataTableGridControl.MainView = Me.GridView1
        Me.MstProjectDataTableGridControl.Name = "MstProjectDataTableGridControl"
        Me.MstProjectDataTableGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookUpEditCompany})
        Me.MstProjectDataTableGridControl.Size = New System.Drawing.Size(498, 333)
        Me.MstProjectDataTableGridControl.TabIndex = 2
        Me.MstProjectDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colName, Me.colidCompany, Me.colDate, Me.colidUser, Me.colnote})
        Me.GridView1.GridControl = Me.MstProjectDataTableGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        '
        'colidCompany
        '
        Me.colidCompany.ColumnEdit = Me.lookUpEditCompany
        Me.colidCompany.FieldName = "idCompany"
        Me.colidCompany.Name = "colidCompany"
        Me.colidCompany.Visible = True
        Me.colidCompany.VisibleIndex = 2
        '
        'lookUpEditCompany
        '
        Me.lookUpEditCompany.AutoHeight = False
        Me.lookUpEditCompany.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpEditCompany.DataSource = Me.CountryForProjectSelectCommandBindingSource
        Me.lookUpEditCompany.DisplayMember = "name"
        Me.lookUpEditCompany.Name = "lookUpEditCompany"
        Me.lookUpEditCompany.ValueMember = "id"
        '
        'CountryForProjectSelectCommandBindingSource
        '
        Me.CountryForProjectSelectCommandBindingSource.DataMember = "CountryForProject_SelectCommand"
        Me.CountryForProjectSelectCommandBindingSource.DataSource = Me.DataSetProject1
        '
        'DataSetProject1
        '
        Me.DataSetProject1.DataSetName = "DataSetProject"
        Me.DataSetProject1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colDate
        '
        Me.colDate.FieldName = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 3
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        '
        'colnote
        '
        Me.colnote.FieldName = "note"
        Me.colnote.Name = "colnote"
        Me.colnote.Visible = True
        Me.colnote.VisibleIndex = 4
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.idSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idCompanyLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DateDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idUserSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.noteMemoEdit)
        Me.DataLayoutControl1.DataSource = Me.MstProjectDataTableBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid, Me.ItemForidCompany, Me.ItemForidUser})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 28)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(593, 83, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(333, 253)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idSpinEdit
        '
        Me.idSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstProjectDataTableBindingSource, "id", True))
        Me.idSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.idSpinEdit.Location = New System.Drawing.Point(72, 12)
        Me.idSpinEdit.Name = "idSpinEdit"
        Me.idSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.idSpinEdit.Properties.Mask.EditMask = "N0"
        Me.idSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idSpinEdit.Size = New System.Drawing.Size(249, 20)
        Me.idSpinEdit.StyleController = Me.DataLayoutControl1
        Me.idSpinEdit.TabIndex = 4
        '
        'NameTextEdit
        '
        Me.NameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstProjectDataTableBindingSource, "Name", True))
        Me.NameTextEdit.Location = New System.Drawing.Point(42, 12)
        Me.NameTextEdit.Name = "NameTextEdit"
        Me.NameTextEdit.Size = New System.Drawing.Size(279, 20)
        Me.NameTextEdit.StyleController = Me.DataLayoutControl1
        Me.NameTextEdit.TabIndex = 5
        '
        'idCompanyLookUpEdit
        '
        Me.idCompanyLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstProjectDataTableBindingSource, "idCompany", True))
        Me.idCompanyLookUpEdit.Location = New System.Drawing.Point(61, 197)
        Me.idCompanyLookUpEdit.Name = "idCompanyLookUpEdit"
        Me.idCompanyLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idCompanyLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idCompanyLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idCompanyLookUpEdit.Properties.DataSource = Me.CountryForProjectSelectCommandBindingSource
        Me.idCompanyLookUpEdit.Properties.DisplayMember = "name"
        Me.idCompanyLookUpEdit.Properties.NullText = ""
        Me.idCompanyLookUpEdit.Properties.ValueMember = "id"
        Me.idCompanyLookUpEdit.Size = New System.Drawing.Size(260, 20)
        Me.idCompanyLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idCompanyLookUpEdit.TabIndex = 6
        '
        'DateDateEdit
        '
        Me.DateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstProjectDataTableBindingSource, "Date", True))
        Me.DateDateEdit.EditValue = Nothing
        Me.DateDateEdit.Location = New System.Drawing.Point(42, 36)
        Me.DateDateEdit.Name = "DateDateEdit"
        Me.DateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateDateEdit.Size = New System.Drawing.Size(279, 20)
        Me.DateDateEdit.StyleController = Me.DataLayoutControl1
        Me.DateDateEdit.TabIndex = 7
        '
        'idUserSpinEdit
        '
        Me.idUserSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstProjectDataTableBindingSource, "idUser", True))
        Me.idUserSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.idUserSpinEdit.Location = New System.Drawing.Point(49, 221)
        Me.idUserSpinEdit.Name = "idUserSpinEdit"
        Me.idUserSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idUserSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idUserSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idUserSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.idUserSpinEdit.Properties.Mask.EditMask = "N0"
        Me.idUserSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idUserSpinEdit.Size = New System.Drawing.Size(272, 20)
        Me.idUserSpinEdit.StyleController = Me.DataLayoutControl1
        Me.idUserSpinEdit.TabIndex = 8
        '
        'noteMemoEdit
        '
        Me.noteMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstProjectDataTableBindingSource, "note", True))
        Me.noteMemoEdit.Location = New System.Drawing.Point(12, 76)
        Me.noteMemoEdit.Name = "noteMemoEdit"
        Me.noteMemoEdit.Size = New System.Drawing.Size(309, 165)
        Me.noteMemoEdit.StyleController = Me.DataLayoutControl1
        Me.noteMemoEdit.TabIndex = 9
        '
        'ItemForid
        '
        Me.ItemForid.Control = Me.idSpinEdit
        Me.ItemForid.Location = New System.Drawing.Point(0, 0)
        Me.ItemForid.Name = "ItemForid"
        Me.ItemForid.Size = New System.Drawing.Size(313, 24)
        Me.ItemForid.Text = "id"
        Me.ItemForid.TextSize = New System.Drawing.Size(50, 20)
        '
        'ItemForidCompany
        '
        Me.ItemForidCompany.Control = Me.idCompanyLookUpEdit
        Me.ItemForidCompany.Location = New System.Drawing.Point(0, 185)
        Me.ItemForidCompany.Name = "ItemForidCompany"
        Me.ItemForidCompany.Size = New System.Drawing.Size(313, 24)
        Me.ItemForidCompany.Text = "Company"
        Me.ItemForidCompany.TextSize = New System.Drawing.Size(50, 20)
        '
        'ItemForidUser
        '
        Me.ItemForidUser.Control = Me.idUserSpinEdit
        Me.ItemForidUser.Location = New System.Drawing.Point(0, 209)
        Me.ItemForidUser.Name = "ItemForidUser"
        Me.ItemForidUser.Size = New System.Drawing.Size(313, 24)
        Me.ItemForidUser.Text = "id User"
        Me.ItemForidUser.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(333, 253)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForName, Me.ItemForDate, Me.ItemFornote})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(313, 233)
        '
        'ItemForName
        '
        Me.ItemForName.Control = Me.NameTextEdit
        Me.ItemForName.Location = New System.Drawing.Point(0, 0)
        Me.ItemForName.Name = "ItemForName"
        Me.ItemForName.Size = New System.Drawing.Size(313, 24)
        Me.ItemForName.Text = "Name"
        Me.ItemForName.TextSize = New System.Drawing.Size(27, 13)
        '
        'ItemForDate
        '
        Me.ItemForDate.Control = Me.DateDateEdit
        Me.ItemForDate.Location = New System.Drawing.Point(0, 24)
        Me.ItemForDate.Name = "ItemForDate"
        Me.ItemForDate.Size = New System.Drawing.Size(313, 24)
        Me.ItemForDate.Text = "Date"
        Me.ItemForDate.TextSize = New System.Drawing.Size(27, 13)
        '
        'ItemFornote
        '
        Me.ItemFornote.Control = Me.noteMemoEdit
        Me.ItemFornote.Location = New System.Drawing.Point(0, 48)
        Me.ItemFornote.Name = "ItemFornote"
        Me.ItemFornote.Size = New System.Drawing.Size(313, 185)
        Me.ItemFornote.StartNewLine = True
        Me.ItemFornote.Text = "note"
        Me.ItemFornote.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemFornote.TextSize = New System.Drawing.Size(27, 13)
        '
        'CountryForProject_SelectCommandTableAdapter
        '
        Me.CountryForProject_SelectCommandTableAdapter.ClearBeforeFill = True
        '
        'FormProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 377)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.MstProjectDataTableGridControl)
        Me.Controls.Add(Me.MstProjectDataTableBindingNavigator)
        Me.Name = "FormProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProject"
        CType(Me.DataSetProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstProjectDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstProjectDataTableBindingNavigator.ResumeLayout(False)
        Me.MstProjectDataTableBindingNavigator.PerformLayout()
        CType(Me.MstProjectDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpEditCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryForProjectSelectCommandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProject1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idCompanyLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idUserSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetProject As DataSetProject
    Friend WithEvents MstProjectDataTableBindingSource As BindingSource
    Friend WithEvents MstProjectDataTableTableAdapter As DataSetProjectTableAdapters.mstProjectDataTableTableAdapter
    Friend WithEvents TableAdapterManager As DataSetProjectTableAdapters.TableAdapterManager
    Friend WithEvents MstProjectDataTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MstProjectDataTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstProjectDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents idSpinEdit As SpinEdit
    Friend WithEvents NameTextEdit As TextEdit
    Friend WithEvents idCompanyLookUpEdit As LookUpEdit
    Friend WithEvents DateDateEdit As DateEdit
    Friend WithEvents idUserSpinEdit As SpinEdit
    Friend WithEvents noteMemoEdit As MemoEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidCompany As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidUser As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornote As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataSetProject1 As DataSetProject
    Friend WithEvents CountryForProjectSelectCommandBindingSource As BindingSource
    Friend WithEvents CountryForProject_SelectCommandTableAdapter As DataSetProjectTableAdapters.CountryForProject_SelectCommandTableAdapter
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidCompany As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookUpEditCompany As Repository.RepositoryItemLookUpEdit
End Class
