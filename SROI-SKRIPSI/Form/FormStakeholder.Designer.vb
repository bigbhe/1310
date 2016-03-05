<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStakeholder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStakeholder))
        Me.DataSetStakeholder = New SROI_SKRIPSI.DataSetStakeholder()
        Me.MstStakeholdersDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstStakeholdersDataTableTableAdapter = New SROI_SKRIPSI.DataSetStakeholderTableAdapters.mstStakeholdersDataTableTableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetStakeholderTableAdapters.TableAdapterManager()
        Me.MstStakeholdersDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstStakeholdersDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstStakeholdersDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.idProjectSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.idUserSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.NameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.amountSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ReasonTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ItemForid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidProject = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidUser = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForReason = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForamount = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetStakeholder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstStakeholdersDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstStakeholdersDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstStakeholdersDataTableBindingNavigator.SuspendLayout()
        CType(Me.MstStakeholdersDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idProjectSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idUserSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForamount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetStakeholder
        '
        Me.DataSetStakeholder.DataSetName = "DataSetStakeholder"
        Me.DataSetStakeholder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstStakeholdersDataTableBindingSource
        '
        Me.MstStakeholdersDataTableBindingSource.DataMember = "mstStakeholdersDataTable"
        Me.MstStakeholdersDataTableBindingSource.DataSource = Me.DataSetStakeholder
        '
        'MstStakeholdersDataTableTableAdapter
        '
        Me.MstStakeholdersDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstStakeholdersDataTableTableAdapter = Me.MstStakeholdersDataTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetStakeholderTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstStakeholdersDataTableBindingNavigator
        '
        Me.MstStakeholdersDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstStakeholdersDataTableBindingNavigator.BindingSource = Me.MstStakeholdersDataTableBindingSource
        Me.MstStakeholdersDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstStakeholdersDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstStakeholdersDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstStakeholdersDataTableBindingNavigatorSaveItem})
        Me.MstStakeholdersDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstStakeholdersDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstStakeholdersDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstStakeholdersDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstStakeholdersDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstStakeholdersDataTableBindingNavigator.Name = "MstStakeholdersDataTableBindingNavigator"
        Me.MstStakeholdersDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstStakeholdersDataTableBindingNavigator.Size = New System.Drawing.Size(872, 25)
        Me.MstStakeholdersDataTableBindingNavigator.TabIndex = 0
        Me.MstStakeholdersDataTableBindingNavigator.Text = "BindingNavigator1"
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
        'MstStakeholdersDataTableBindingNavigatorSaveItem
        '
        Me.MstStakeholdersDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstStakeholdersDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstStakeholdersDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstStakeholdersDataTableBindingNavigatorSaveItem.Name = "MstStakeholdersDataTableBindingNavigatorSaveItem"
        Me.MstStakeholdersDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstStakeholdersDataTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstStakeholdersDataTableGridControl
        '
        Me.MstStakeholdersDataTableGridControl.DataSource = Me.MstStakeholdersDataTableBindingSource
        Me.MstStakeholdersDataTableGridControl.Location = New System.Drawing.Point(385, 40)
        Me.MstStakeholdersDataTableGridControl.MainView = Me.GridView1
        Me.MstStakeholdersDataTableGridControl.Name = "MstStakeholdersDataTableGridControl"
        Me.MstStakeholdersDataTableGridControl.Size = New System.Drawing.Size(484, 287)
        Me.MstStakeholdersDataTableGridControl.TabIndex = 2
        Me.MstStakeholdersDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidProject, Me.colidUser, Me.colName, Me.colReason, Me.colamount})
        Me.GridView1.GridControl = Me.MstStakeholdersDataTableGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidProject
        '
        Me.colidProject.FieldName = "idProject"
        Me.colidProject.Name = "colidProject"
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colReason
        '
        Me.colReason.FieldName = "Reason"
        Me.colReason.Name = "colReason"
        Me.colReason.Visible = True
        Me.colReason.VisibleIndex = 1
        '
        'colamount
        '
        Me.colamount.FieldName = "amount"
        Me.colamount.Name = "colamount"
        Me.colamount.Visible = True
        Me.colamount.VisibleIndex = 2
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.idSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idProjectSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idUserSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.amountSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ReasonTextEdit)
        Me.DataLayoutControl1.DataSource = Me.MstStakeholdersDataTableBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid, Me.ItemForidProject, Me.ItemForidUser})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 28)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(386, 311)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idSpinEdit
        '
        Me.idSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStakeholdersDataTableBindingSource, "id", True))
        Me.idSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.idSpinEdit.Location = New System.Drawing.Point(61, 12)
        Me.idSpinEdit.Name = "idSpinEdit"
        Me.idSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.idSpinEdit.Properties.Mask.EditMask = "N0"
        Me.idSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idSpinEdit.Size = New System.Drawing.Size(313, 20)
        Me.idSpinEdit.StyleController = Me.DataLayoutControl1
        Me.idSpinEdit.TabIndex = 4
        '
        'idProjectSpinEdit
        '
        Me.idProjectSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStakeholdersDataTableBindingSource, "idProject", True))
        Me.idProjectSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.idProjectSpinEdit.Location = New System.Drawing.Point(61, 12)
        Me.idProjectSpinEdit.Name = "idProjectSpinEdit"
        Me.idProjectSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idProjectSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idProjectSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idProjectSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.idProjectSpinEdit.Properties.Mask.EditMask = "N0"
        Me.idProjectSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idProjectSpinEdit.Size = New System.Drawing.Size(313, 20)
        Me.idProjectSpinEdit.StyleController = Me.DataLayoutControl1
        Me.idProjectSpinEdit.TabIndex = 5
        '
        'idUserSpinEdit
        '
        Me.idUserSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStakeholdersDataTableBindingSource, "idUser", True))
        Me.idUserSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.idUserSpinEdit.Location = New System.Drawing.Point(52, 12)
        Me.idUserSpinEdit.Name = "idUserSpinEdit"
        Me.idUserSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idUserSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idUserSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idUserSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.idUserSpinEdit.Properties.Mask.EditMask = "N0"
        Me.idUserSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idUserSpinEdit.Size = New System.Drawing.Size(322, 20)
        Me.idUserSpinEdit.StyleController = Me.DataLayoutControl1
        Me.idUserSpinEdit.TabIndex = 6
        '
        'NameTextEdit
        '
        Me.NameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStakeholdersDataTableBindingSource, "Name", True))
        Me.NameTextEdit.Location = New System.Drawing.Point(51, 12)
        Me.NameTextEdit.Name = "NameTextEdit"
        Me.NameTextEdit.Size = New System.Drawing.Size(323, 20)
        Me.NameTextEdit.StyleController = Me.DataLayoutControl1
        Me.NameTextEdit.TabIndex = 7
        '
        'amountSpinEdit
        '
        Me.amountSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStakeholdersDataTableBindingSource, "amount", True))
        Me.amountSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.amountSpinEdit.Location = New System.Drawing.Point(51, 279)
        Me.amountSpinEdit.Name = "amountSpinEdit"
        Me.amountSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.amountSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.amountSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.amountSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.amountSpinEdit.Properties.Mask.EditMask = "N0"
        Me.amountSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.amountSpinEdit.Size = New System.Drawing.Size(323, 20)
        Me.amountSpinEdit.StyleController = Me.DataLayoutControl1
        Me.amountSpinEdit.TabIndex = 9
        '
        'ReasonTextEdit
        '
        Me.ReasonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStakeholdersDataTableBindingSource, "Reason", True))
        Me.ReasonTextEdit.Location = New System.Drawing.Point(51, 36)
        Me.ReasonTextEdit.Name = "ReasonTextEdit"
        Me.ReasonTextEdit.Size = New System.Drawing.Size(323, 239)
        Me.ReasonTextEdit.StyleController = Me.DataLayoutControl1
        Me.ReasonTextEdit.TabIndex = 8
        '
        'ItemForid
        '
        Me.ItemForid.Control = Me.idSpinEdit
        Me.ItemForid.Location = New System.Drawing.Point(0, 0)
        Me.ItemForid.Name = "ItemForid"
        Me.ItemForid.Size = New System.Drawing.Size(366, 24)
        Me.ItemForid.Text = "id"
        Me.ItemForid.TextSize = New System.Drawing.Size(50, 20)
        '
        'ItemForidProject
        '
        Me.ItemForidProject.Control = Me.idProjectSpinEdit
        Me.ItemForidProject.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidProject.Name = "ItemForidProject"
        Me.ItemForidProject.Size = New System.Drawing.Size(366, 24)
        Me.ItemForidProject.Text = "id Project"
        Me.ItemForidProject.TextSize = New System.Drawing.Size(50, 20)
        '
        'ItemForidUser
        '
        Me.ItemForidUser.Control = Me.idUserSpinEdit
        Me.ItemForidUser.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidUser.Name = "ItemForidUser"
        Me.ItemForidUser.Size = New System.Drawing.Size(366, 24)
        Me.ItemForidUser.Text = "id User"
        Me.ItemForidUser.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(386, 311)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForName, Me.ItemForReason, Me.ItemForamount})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(366, 291)
        '
        'ItemForName
        '
        Me.ItemForName.Control = Me.NameTextEdit
        Me.ItemForName.Location = New System.Drawing.Point(0, 0)
        Me.ItemForName.Name = "ItemForName"
        Me.ItemForName.Size = New System.Drawing.Size(366, 24)
        Me.ItemForName.Text = "Name"
        Me.ItemForName.TextSize = New System.Drawing.Size(36, 13)
        '
        'ItemForReason
        '
        Me.ItemForReason.Control = Me.ReasonTextEdit
        Me.ItemForReason.Location = New System.Drawing.Point(0, 24)
        Me.ItemForReason.Name = "ItemForReason"
        Me.ItemForReason.Size = New System.Drawing.Size(366, 243)
        Me.ItemForReason.Text = "Reason"
        Me.ItemForReason.TextSize = New System.Drawing.Size(36, 13)
        '
        'ItemForamount
        '
        Me.ItemForamount.Control = Me.amountSpinEdit
        Me.ItemForamount.Location = New System.Drawing.Point(0, 267)
        Me.ItemForamount.Name = "ItemForamount"
        Me.ItemForamount.Size = New System.Drawing.Size(366, 24)
        Me.ItemForamount.Text = "amount"
        Me.ItemForamount.TextSize = New System.Drawing.Size(36, 13)
        '
        'FormStakeholder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 335)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.MstStakeholdersDataTableGridControl)
        Me.Controls.Add(Me.MstStakeholdersDataTableBindingNavigator)
        Me.Name = "FormStakeholder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormStakeholder"
        CType(Me.DataSetStakeholder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstStakeholdersDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstStakeholdersDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstStakeholdersDataTableBindingNavigator.ResumeLayout(False)
        Me.MstStakeholdersDataTableBindingNavigator.PerformLayout()
        CType(Me.MstStakeholdersDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idProjectSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idUserSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForamount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetStakeholder As DataSetStakeholder
    Friend WithEvents MstStakeholdersDataTableBindingSource As BindingSource
    Friend WithEvents MstStakeholdersDataTableTableAdapter As DataSetStakeholderTableAdapters.mstStakeholdersDataTableTableAdapter
    Friend WithEvents TableAdapterManager As DataSetStakeholderTableAdapters.TableAdapterManager
    Friend WithEvents MstStakeholdersDataTableBindingNavigator As BindingNavigator
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
    Friend WithEvents MstStakeholdersDataTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstStakeholdersDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents idSpinEdit As SpinEdit
    Friend WithEvents idProjectSpinEdit As SpinEdit
    Friend WithEvents idUserSpinEdit As SpinEdit
    Friend WithEvents NameTextEdit As TextEdit
    Friend WithEvents amountSpinEdit As SpinEdit
    Friend WithEvents ReasonTextEdit As MemoEdit
    Friend WithEvents ItemForid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidProject As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidUser As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForReason As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForamount As DevExpress.XtraLayout.LayoutControlItem
End Class
