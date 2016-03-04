<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInput))
        Me.DataSetInput = New SROI_SKRIPSI.DataSetInput()
        Me.DataTableInputBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableInputTableAdapter = New SROI_SKRIPSI.DataSetInputTableAdapters.DataTableInputTableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetInputTableAdapters.TableAdapterManager()
        Me.DataTableInputBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DataTableInputBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataTableInputGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidStakeholder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lookUpStakeholder = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.StakeholderForInputSelectCommandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colinput = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colvalue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coloutputs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.lookUpEditStakeholder = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.StakeholderForInput_SelectCommandTableAdapter = New SROI_SKRIPSI.DataSetInputTableAdapters.StakeholderForInput_SelectCommandTableAdapter()
        CType(Me.DataSetInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableInputBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableInputBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataTableInputBindingNavigator.SuspendLayout()
        CType(Me.DataTableInputGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpStakeholder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StakeholderForInputSelectCommandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpEditStakeholder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetInput
        '
        Me.DataSetInput.DataSetName = "DataSetInput"
        Me.DataSetInput.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTableInputBindingSource
        '
        Me.DataTableInputBindingSource.DataMember = "DataTableInput"
        Me.DataTableInputBindingSource.DataSource = Me.DataSetInput
        '
        'DataTableInputTableAdapter
        '
        Me.DataTableInputTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DataTableInputTableAdapter = Me.DataTableInputTableAdapter
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetInputTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataTableInputBindingNavigator
        '
        Me.DataTableInputBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DataTableInputBindingNavigator.BindingSource = Me.DataTableInputBindingSource
        Me.DataTableInputBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DataTableInputBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DataTableInputBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DataTableInputBindingNavigatorSaveItem})
        Me.DataTableInputBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DataTableInputBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DataTableInputBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DataTableInputBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DataTableInputBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DataTableInputBindingNavigator.Name = "DataTableInputBindingNavigator"
        Me.DataTableInputBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DataTableInputBindingNavigator.Size = New System.Drawing.Size(796, 25)
        Me.DataTableInputBindingNavigator.TabIndex = 0
        Me.DataTableInputBindingNavigator.Text = "BindingNavigator1"
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
        'DataTableInputBindingNavigatorSaveItem
        '
        Me.DataTableInputBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DataTableInputBindingNavigatorSaveItem.Image = CType(resources.GetObject("DataTableInputBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DataTableInputBindingNavigatorSaveItem.Name = "DataTableInputBindingNavigatorSaveItem"
        Me.DataTableInputBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DataTableInputBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataTableInputGridControl
        '
        Me.DataTableInputGridControl.DataSource = Me.DataTableInputBindingSource
        Me.DataTableInputGridControl.Location = New System.Drawing.Point(12, 28)
        Me.DataTableInputGridControl.MainView = Me.GridView1
        Me.DataTableInputGridControl.Name = "DataTableInputGridControl"
        Me.DataTableInputGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookUpStakeholder, Me.RepositoryItemMemoEdit1, Me.lookUpEditStakeholder, Me.RepositoryItemMemoEdit2})
        Me.DataTableInputGridControl.Size = New System.Drawing.Size(772, 378)
        Me.DataTableInputGridControl.TabIndex = 2
        Me.DataTableInputGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidStakeholder, Me.colinput, Me.colvalue, Me.colidUser, Me.colidProject, Me.coloutputs})
        Me.GridView1.GridControl = Me.DataTableInputGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidStakeholder
        '
        Me.colidStakeholder.ColumnEdit = Me.lookUpStakeholder
        Me.colidStakeholder.FieldName = "idStakeholder"
        Me.colidStakeholder.Name = "colidStakeholder"
        Me.colidStakeholder.Visible = True
        Me.colidStakeholder.VisibleIndex = 0
        '
        'lookUpStakeholder
        '
        Me.lookUpStakeholder.AutoHeight = False
        Me.lookUpStakeholder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpStakeholder.DataSource = Me.StakeholderForInputSelectCommandBindingSource
        Me.lookUpStakeholder.DisplayMember = "Name"
        Me.lookUpStakeholder.Name = "lookUpStakeholder"
        Me.lookUpStakeholder.ReadOnly = True
        Me.lookUpStakeholder.ValueMember = "id"
        '
        'StakeholderForInputSelectCommandBindingSource
        '
        Me.StakeholderForInputSelectCommandBindingSource.DataMember = "StakeholderForInput_SelectCommand"
        Me.StakeholderForInputSelectCommandBindingSource.DataSource = Me.DataSetInput
        '
        'colinput
        '
        Me.colinput.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colinput.FieldName = "input"
        Me.colinput.Name = "colinput"
        Me.colinput.Visible = True
        Me.colinput.VisibleIndex = 1
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colvalue
        '
        Me.colvalue.DisplayFormat.FormatString = "c2"
        Me.colvalue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colvalue.FieldName = "value"
        Me.colvalue.Name = "colvalue"
        Me.colvalue.Visible = True
        Me.colvalue.VisibleIndex = 2
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        '
        'colidProject
        '
        Me.colidProject.FieldName = "idProject"
        Me.colidProject.Name = "colidProject"
        '
        'coloutputs
        '
        Me.coloutputs.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.coloutputs.FieldName = "outputs"
        Me.coloutputs.Name = "coloutputs"
        Me.coloutputs.Visible = True
        Me.coloutputs.VisibleIndex = 3
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'lookUpEditStakeholder
        '
        Me.lookUpEditStakeholder.AutoHeight = False
        Me.lookUpEditStakeholder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpEditStakeholder.DataSource = Me.StakeholderForInputSelectCommandBindingSource
        Me.lookUpEditStakeholder.DisplayMember = "Name"
        Me.lookUpEditStakeholder.Name = "lookUpEditStakeholder"
        Me.lookUpEditStakeholder.ReadOnly = True
        Me.lookUpEditStakeholder.ValueMember = "id"
        '
        'StakeholderForInput_SelectCommandTableAdapter
        '
        Me.StakeholderForInput_SelectCommandTableAdapter.ClearBeforeFill = True
        '
        'FormInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 418)
        Me.Controls.Add(Me.DataTableInputGridControl)
        Me.Controls.Add(Me.DataTableInputBindingNavigator)
        Me.Name = "FormInput"
        Me.Text = "FormInput"
        CType(Me.DataSetInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableInputBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableInputBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataTableInputBindingNavigator.ResumeLayout(False)
        Me.DataTableInputBindingNavigator.PerformLayout()
        CType(Me.DataTableInputGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpStakeholder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StakeholderForInputSelectCommandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpEditStakeholder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetInput As DataSetInput
    Friend WithEvents DataTableInputBindingSource As BindingSource
    Friend WithEvents DataTableInputTableAdapter As DataSetInputTableAdapters.DataTableInputTableAdapter
    Friend WithEvents TableAdapterManager As DataSetInputTableAdapters.TableAdapterManager
    Friend WithEvents DataTableInputBindingNavigator As BindingNavigator
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
    Friend WithEvents DataTableInputBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataTableInputGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lookUpStakeholder As Repository.RepositoryItemLookUpEdit
    Friend WithEvents StakeholderForInputSelectCommandBindingSource As BindingSource
    Friend WithEvents StakeholderForInput_SelectCommandTableAdapter As DataSetInputTableAdapters.StakeholderForInput_SelectCommandTableAdapter
    Friend WithEvents RepositoryItemMemoEdit1 As Repository.RepositoryItemMemoEdit
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidStakeholder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinput As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coloutputs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As Repository.RepositoryItemMemoEdit
    Friend WithEvents lookUpEditStakeholder As Repository.RepositoryItemLookUpEdit
End Class
