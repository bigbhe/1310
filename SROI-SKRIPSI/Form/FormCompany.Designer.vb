<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompany))
        Me.DataSetCompany = New SROI_SKRIPSI.DataSetCompany()
        Me.CompanyDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataTableTableAdapter = New SROI_SKRIPSI.DataSetCompanyTableAdapters.companyDataTableTableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetCompanyTableAdapters.TableAdapterManager()
        Me.CompanyDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CompanyDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CompanyDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.nameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.addressMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.subsidiaryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.logoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.noteMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.emailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.websiteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.phoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.countryLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CountryDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cityLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CityDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemForid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForname = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForcountry = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForcity = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForaddress = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForsubsidiary = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForlogo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFornote = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForemail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForwebsite = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForphone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.CountryDataTableTableAdapter = New SROI_SKRIPSI.DataSetCompanyTableAdapters.CountryDataTableTableAdapter()
        Me.CityDataTableTableAdapter = New SROI_SKRIPSI.DataSetCompanyTableAdapters.CityDataTableTableAdapter()
        CType(Me.DataSetCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompanyDataTableBindingNavigator.SuspendLayout()
        CType(Me.CompanyDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addressMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subsidiaryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.websiteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.countryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cityLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForcountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForcity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForaddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForsubsidiary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForemail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForwebsite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetCompany
        '
        Me.DataSetCompany.DataSetName = "DataSetCompany"
        Me.DataSetCompany.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyDataTableBindingSource
        '
        Me.CompanyDataTableBindingSource.DataMember = "companyDataTable"
        Me.CompanyDataTableBindingSource.DataSource = Me.DataSetCompany
        '
        'CompanyDataTableTableAdapter
        '
        Me.CompanyDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.companyDataTableTableAdapter = Me.CompanyDataTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetCompanyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompanyDataTableBindingNavigator
        '
        Me.CompanyDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CompanyDataTableBindingNavigator.BindingSource = Me.CompanyDataTableBindingSource
        Me.CompanyDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CompanyDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CompanyDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CompanyDataTableBindingNavigatorSaveItem})
        Me.CompanyDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CompanyDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CompanyDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CompanyDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CompanyDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CompanyDataTableBindingNavigator.Name = "CompanyDataTableBindingNavigator"
        Me.CompanyDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CompanyDataTableBindingNavigator.Size = New System.Drawing.Size(709, 25)
        Me.CompanyDataTableBindingNavigator.TabIndex = 0
        Me.CompanyDataTableBindingNavigator.Text = "BindingNavigator1"
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
        'CompanyDataTableBindingNavigatorSaveItem
        '
        Me.CompanyDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CompanyDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("CompanyDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CompanyDataTableBindingNavigatorSaveItem.Name = "CompanyDataTableBindingNavigatorSaveItem"
        Me.CompanyDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CompanyDataTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CompanyDataTableGridControl
        '
        Me.CompanyDataTableGridControl.DataSource = Me.CompanyDataTableBindingSource
        Me.CompanyDataTableGridControl.Location = New System.Drawing.Point(531, 411)
        Me.CompanyDataTableGridControl.MainView = Me.GridView1
        Me.CompanyDataTableGridControl.Name = "CompanyDataTableGridControl"
        Me.CompanyDataTableGridControl.Size = New System.Drawing.Size(33, 40)
        Me.CompanyDataTableGridControl.TabIndex = 2
        Me.CompanyDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.CompanyDataTableGridControl
        Me.GridView1.Name = "GridView1"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.idSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.addressMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.subsidiaryTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.logoPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.noteMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.emailTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.websiteTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.phoneTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.countryLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.cityLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.CompanyDataTableBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(709, 382)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idSpinEdit
        '
        Me.idSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "id", True))
        Me.idSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.idSpinEdit.Location = New System.Drawing.Point(24, 42)
        Me.idSpinEdit.Name = "idSpinEdit"
        Me.idSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.idSpinEdit.Properties.Mask.EditMask = "N0"
        Me.idSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idSpinEdit.Size = New System.Drawing.Size(368, 20)
        Me.idSpinEdit.StyleController = Me.DataLayoutControl1
        Me.idSpinEdit.TabIndex = 4
        '
        'nameTextEdit
        '
        Me.nameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "name", True))
        Me.nameTextEdit.Location = New System.Drawing.Point(75, 42)
        Me.nameTextEdit.Name = "nameTextEdit"
        Me.nameTextEdit.Size = New System.Drawing.Size(317, 20)
        Me.nameTextEdit.StyleController = Me.DataLayoutControl1
        Me.nameTextEdit.TabIndex = 5
        '
        'addressMemoEdit
        '
        Me.addressMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "address", True))
        Me.addressMemoEdit.Location = New System.Drawing.Point(75, 114)
        Me.addressMemoEdit.Name = "addressMemoEdit"
        Me.addressMemoEdit.Size = New System.Drawing.Size(317, 81)
        Me.addressMemoEdit.StyleController = Me.DataLayoutControl1
        Me.addressMemoEdit.TabIndex = 8
        '
        'subsidiaryTextEdit
        '
        Me.subsidiaryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "subsidiary", True))
        Me.subsidiaryTextEdit.Location = New System.Drawing.Point(75, 210)
        Me.subsidiaryTextEdit.Name = "subsidiaryTextEdit"
        Me.subsidiaryTextEdit.Size = New System.Drawing.Size(317, 20)
        Me.subsidiaryTextEdit.StyleController = Me.DataLayoutControl1
        Me.subsidiaryTextEdit.TabIndex = 9
        '
        'logoPictureEdit
        '
        Me.logoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "logo", True))
        Me.logoPictureEdit.Location = New System.Drawing.Point(471, 42)
        Me.logoPictureEdit.Name = "logoPictureEdit"
        Me.logoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.logoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.logoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.logoPictureEdit.Size = New System.Drawing.Size(214, 166)
        Me.logoPictureEdit.StyleController = Me.DataLayoutControl1
        Me.logoPictureEdit.TabIndex = 10
        '
        'noteMemoEdit
        '
        Me.noteMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "note", True))
        Me.noteMemoEdit.Location = New System.Drawing.Point(471, 222)
        Me.noteMemoEdit.Name = "noteMemoEdit"
        Me.noteMemoEdit.Size = New System.Drawing.Size(214, 64)
        Me.noteMemoEdit.StyleController = Me.DataLayoutControl1
        Me.noteMemoEdit.TabIndex = 11
        '
        'emailTextEdit
        '
        Me.emailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "email", True))
        Me.emailTextEdit.Location = New System.Drawing.Point(471, 290)
        Me.emailTextEdit.Name = "emailTextEdit"
        Me.emailTextEdit.Size = New System.Drawing.Size(214, 20)
        Me.emailTextEdit.StyleController = Me.DataLayoutControl1
        Me.emailTextEdit.TabIndex = 12
        '
        'websiteTextEdit
        '
        Me.websiteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "website", True))
        Me.websiteTextEdit.Location = New System.Drawing.Point(471, 314)
        Me.websiteTextEdit.Name = "websiteTextEdit"
        Me.websiteTextEdit.Size = New System.Drawing.Size(214, 20)
        Me.websiteTextEdit.StyleController = Me.DataLayoutControl1
        Me.websiteTextEdit.TabIndex = 13
        '
        'phoneTextEdit
        '
        Me.phoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "phone", True))
        Me.phoneTextEdit.Location = New System.Drawing.Point(471, 338)
        Me.phoneTextEdit.Name = "phoneTextEdit"
        Me.phoneTextEdit.Size = New System.Drawing.Size(214, 20)
        Me.phoneTextEdit.StyleController = Me.DataLayoutControl1
        Me.phoneTextEdit.TabIndex = 14
        '
        'countryLookUpEdit
        '
        Me.countryLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "country", True))
        Me.countryLookUpEdit.Location = New System.Drawing.Point(75, 66)
        Me.countryLookUpEdit.Name = "countryLookUpEdit"
        Me.countryLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.countryLookUpEdit.Properties.DataSource = Me.CountryDataTableBindingSource
        Me.countryLookUpEdit.Properties.DisplayMember = "name"
        Me.countryLookUpEdit.Properties.NullText = ""
        Me.countryLookUpEdit.Properties.ValueMember = "iso"
        Me.countryLookUpEdit.Size = New System.Drawing.Size(317, 20)
        Me.countryLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.countryLookUpEdit.TabIndex = 6
        '
        'CountryDataTableBindingSource
        '
        Me.CountryDataTableBindingSource.DataMember = "CountryDataTable"
        Me.CountryDataTableBindingSource.DataSource = Me.DataSetCompany
        '
        'cityLookUpEdit
        '
        Me.cityLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyDataTableBindingSource, "city", True))
        Me.cityLookUpEdit.Location = New System.Drawing.Point(75, 90)
        Me.cityLookUpEdit.Name = "cityLookUpEdit"
        Me.cityLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cityLookUpEdit.Properties.DataSource = Me.CityDataTableBindingSource
        Me.cityLookUpEdit.Properties.DisplayMember = "city"
        Me.cityLookUpEdit.Properties.NullText = ""
        Me.cityLookUpEdit.Properties.ValueMember = "city"
        Me.cityLookUpEdit.Size = New System.Drawing.Size(317, 20)
        Me.cityLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.cityLookUpEdit.TabIndex = 7
        '
        'CityDataTableBindingSource
        '
        Me.CityDataTableBindingSource.DataMember = "CityDataTable"
        Me.CityDataTableBindingSource.DataSource = Me.DataSetCompany
        '
        'ItemForid
        '
        Me.ItemForid.Control = Me.idSpinEdit
        Me.ItemForid.Location = New System.Drawing.Point(0, 0)
        Me.ItemForid.Name = "ItemForid"
        Me.ItemForid.Size = New System.Drawing.Size(372, 24)
        Me.ItemForid.Text = "id"
        Me.ItemForid.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForid.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(709, 382)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(689, 362)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForname, Me.ItemForcountry, Me.ItemForcity, Me.ItemForaddress, Me.ItemForsubsidiary, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(396, 362)
        Me.LayoutControlGroup3.Text = "Profile"
        '
        'ItemForname
        '
        Me.ItemForname.Control = Me.nameTextEdit
        Me.ItemForname.Location = New System.Drawing.Point(0, 0)
        Me.ItemForname.Name = "ItemForname"
        Me.ItemForname.Size = New System.Drawing.Size(372, 24)
        Me.ItemForname.Text = "name"
        Me.ItemForname.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForcountry
        '
        Me.ItemForcountry.Control = Me.countryLookUpEdit
        Me.ItemForcountry.Location = New System.Drawing.Point(0, 24)
        Me.ItemForcountry.Name = "ItemForcountry"
        Me.ItemForcountry.Size = New System.Drawing.Size(372, 24)
        Me.ItemForcountry.Text = "country"
        Me.ItemForcountry.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForcity
        '
        Me.ItemForcity.Control = Me.cityLookUpEdit
        Me.ItemForcity.Location = New System.Drawing.Point(0, 48)
        Me.ItemForcity.Name = "ItemForcity"
        Me.ItemForcity.Size = New System.Drawing.Size(372, 24)
        Me.ItemForcity.Text = "city"
        Me.ItemForcity.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForaddress
        '
        Me.ItemForaddress.Control = Me.addressMemoEdit
        Me.ItemForaddress.Location = New System.Drawing.Point(0, 72)
        Me.ItemForaddress.Name = "ItemForaddress"
        Me.ItemForaddress.Size = New System.Drawing.Size(372, 85)
        Me.ItemForaddress.StartNewLine = True
        Me.ItemForaddress.Text = "address"
        Me.ItemForaddress.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForsubsidiary
        '
        Me.ItemForsubsidiary.Control = Me.subsidiaryTextEdit
        Me.ItemForsubsidiary.Location = New System.Drawing.Point(0, 168)
        Me.ItemForsubsidiary.Name = "ItemForsubsidiary"
        Me.ItemForsubsidiary.Size = New System.Drawing.Size(372, 24)
        Me.ItemForsubsidiary.Text = "subsidiary"
        Me.ItemForsubsidiary.TextSize = New System.Drawing.Size(48, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 157)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(372, 11)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 192)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(372, 128)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForlogo, Me.ItemFornote, Me.ItemForemail, Me.ItemForwebsite, Me.ItemForphone, Me.EmptySpaceItem1})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(396, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(293, 362)
        Me.LayoutControlGroup4.Text = "Additional and Net Address"
        '
        'ItemForlogo
        '
        Me.ItemForlogo.Control = Me.logoPictureEdit
        Me.ItemForlogo.Location = New System.Drawing.Point(0, 0)
        Me.ItemForlogo.Name = "ItemForlogo"
        Me.ItemForlogo.Size = New System.Drawing.Size(269, 170)
        Me.ItemForlogo.StartNewLine = True
        Me.ItemForlogo.Text = "logo"
        Me.ItemForlogo.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemFornote
        '
        Me.ItemFornote.Control = Me.noteMemoEdit
        Me.ItemFornote.Location = New System.Drawing.Point(0, 180)
        Me.ItemFornote.Name = "ItemFornote"
        Me.ItemFornote.Size = New System.Drawing.Size(269, 68)
        Me.ItemFornote.StartNewLine = True
        Me.ItemFornote.Text = "note"
        Me.ItemFornote.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForemail
        '
        Me.ItemForemail.Control = Me.emailTextEdit
        Me.ItemForemail.Location = New System.Drawing.Point(0, 248)
        Me.ItemForemail.Name = "ItemForemail"
        Me.ItemForemail.Size = New System.Drawing.Size(269, 24)
        Me.ItemForemail.Text = "email"
        Me.ItemForemail.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForwebsite
        '
        Me.ItemForwebsite.Control = Me.websiteTextEdit
        Me.ItemForwebsite.Location = New System.Drawing.Point(0, 272)
        Me.ItemForwebsite.Name = "ItemForwebsite"
        Me.ItemForwebsite.Size = New System.Drawing.Size(269, 24)
        Me.ItemForwebsite.Text = "website"
        Me.ItemForwebsite.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForphone
        '
        Me.ItemForphone.Control = Me.phoneTextEdit
        Me.ItemForphone.Location = New System.Drawing.Point(0, 296)
        Me.ItemForphone.Name = "ItemForphone"
        Me.ItemForphone.Size = New System.Drawing.Size(269, 24)
        Me.ItemForphone.Text = "phone"
        Me.ItemForphone.TextSize = New System.Drawing.Size(48, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 170)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(269, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'CountryDataTableTableAdapter
        '
        Me.CountryDataTableTableAdapter.ClearBeforeFill = True
        '
        'CityDataTableTableAdapter
        '
        Me.CityDataTableTableAdapter.ClearBeforeFill = True
        '
        'FormCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 407)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.CompanyDataTableGridControl)
        Me.Controls.Add(Me.CompanyDataTableBindingNavigator)
        Me.Name = "FormCompany"
        Me.Text = "FormCompany"
        CType(Me.DataSetCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompanyDataTableBindingNavigator.ResumeLayout(False)
        Me.CompanyDataTableBindingNavigator.PerformLayout()
        CType(Me.CompanyDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addressMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subsidiaryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.websiteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.countryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cityLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForcountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForcity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForaddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForsubsidiary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForemail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForwebsite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetCompany As DataSetCompany
    Friend WithEvents CompanyDataTableBindingSource As BindingSource
    Friend WithEvents CompanyDataTableTableAdapter As DataSetCompanyTableAdapters.companyDataTableTableAdapter
    Friend WithEvents TableAdapterManager As DataSetCompanyTableAdapters.TableAdapterManager
    Friend WithEvents CompanyDataTableBindingNavigator As BindingNavigator
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
    Friend WithEvents CompanyDataTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CompanyDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents idSpinEdit As SpinEdit
    Friend WithEvents nameTextEdit As TextEdit
    Friend WithEvents addressMemoEdit As MemoEdit
    Friend WithEvents subsidiaryTextEdit As TextEdit
    Friend WithEvents logoPictureEdit As PictureEdit
    Friend WithEvents noteMemoEdit As MemoEdit
    Friend WithEvents emailTextEdit As TextEdit
    Friend WithEvents websiteTextEdit As TextEdit
    Friend WithEvents phoneTextEdit As TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForname As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForcountry As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForcity As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForaddress As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForsubsidiary As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForlogo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornote As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForemail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForwebsite As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForphone As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents countryLookUpEdit As LookUpEdit
    Friend WithEvents cityLookUpEdit As LookUpEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CountryDataTableTableAdapter As DataSetCompanyTableAdapters.CountryDataTableTableAdapter
    Friend WithEvents CountryDataTableBindingSource As BindingSource
    Friend WithEvents CityDataTableBindingSource As BindingSource
    Friend WithEvents CityDataTableTableAdapter As DataSetCompanyTableAdapters.CityDataTableTableAdapter
End Class
