<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOutcome2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOutcome2))
        Me.DataSetOutcome = New SROI_SKRIPSI.DataSetOutcome()
        Me.OutcomeDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OutcomeDataTableTableAdapter = New SROI_SKRIPSI.DataSetOutcomeTableAdapters.outcomeDataTableTableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetOutcomeTableAdapters.TableAdapterManager()
        Me.OutcomeDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OutcomeDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OutcomeDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidStakeholder1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coloutcomes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.memoOutcomes = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colindicator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.memoIndicator = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colsource = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colduration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.memoSource = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.memoQuantity = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.InputForOutcomeDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InputForOutcomeDataTableTableAdapter = New SROI_SKRIPSI.DataSetOutcomeTableAdapters.InputForOutcomeDataTableTableAdapter()
        Me.InputForOutcomeDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidInput = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidStakeholder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinput = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coloutputs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.memoInput = New DevExpress.XtraEditors.MemoEdit()
        Me.labelValue = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.memoOutput = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelStakeholder = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.DataSetOutcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutcomeDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutcomeDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OutcomeDataTableBindingNavigator.SuspendLayout()
        CType(Me.OutcomeDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoOutcomes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputForOutcomeDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputForOutcomeDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.memoInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoOutput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetOutcome
        '
        Me.DataSetOutcome.DataSetName = "DataSetOutcome"
        Me.DataSetOutcome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OutcomeDataTableBindingSource
        '
        Me.OutcomeDataTableBindingSource.DataMember = "outcomeDataTable"
        Me.OutcomeDataTableBindingSource.DataSource = Me.DataSetOutcome
        '
        'OutcomeDataTableTableAdapter
        '
        Me.OutcomeDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.outcomeDataTableTableAdapter = Me.OutcomeDataTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetOutcomeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OutcomeDataTableBindingNavigator
        '
        Me.OutcomeDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OutcomeDataTableBindingNavigator.BindingSource = Me.OutcomeDataTableBindingSource
        Me.OutcomeDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OutcomeDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OutcomeDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OutcomeDataTableBindingNavigatorSaveItem})
        Me.OutcomeDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OutcomeDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OutcomeDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OutcomeDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OutcomeDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OutcomeDataTableBindingNavigator.Name = "OutcomeDataTableBindingNavigator"
        Me.OutcomeDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OutcomeDataTableBindingNavigator.Size = New System.Drawing.Size(1066, 25)
        Me.OutcomeDataTableBindingNavigator.TabIndex = 0
        Me.OutcomeDataTableBindingNavigator.Text = "BindingNavigator1"
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
        'OutcomeDataTableBindingNavigatorSaveItem
        '
        Me.OutcomeDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OutcomeDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("OutcomeDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OutcomeDataTableBindingNavigatorSaveItem.Name = "OutcomeDataTableBindingNavigatorSaveItem"
        Me.OutcomeDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OutcomeDataTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OutcomeDataTableGridControl
        '
        Me.OutcomeDataTableGridControl.DataSource = Me.OutcomeDataTableBindingSource
        Me.OutcomeDataTableGridControl.Location = New System.Drawing.Point(181, 192)
        Me.OutcomeDataTableGridControl.MainView = Me.GridView1
        Me.OutcomeDataTableGridControl.Name = "OutcomeDataTableGridControl"
        Me.OutcomeDataTableGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.memoOutcomes, Me.memoIndicator, Me.memoSource, Me.memoQuantity})
        Me.OutcomeDataTableGridControl.Size = New System.Drawing.Size(876, 342)
        Me.OutcomeDataTableGridControl.TabIndex = 2
        Me.OutcomeDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidStakeholder1, Me.coloutcomes, Me.colindicator, Me.colsource, Me.colQuantity, Me.colidProject, Me.colduration})
        Me.GridView1.GridControl = Me.OutcomeDataTableGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 2
        Me.GridView1.OptionsView.AllowHtmlDrawHeaders = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidStakeholder1
        '
        Me.colidStakeholder1.FieldName = "idStakeholder"
        Me.colidStakeholder1.Name = "colidStakeholder1"
        '
        'coloutcomes
        '
        Me.coloutcomes.ColumnEdit = Me.memoOutcomes
        Me.coloutcomes.FieldName = "outcomes"
        Me.coloutcomes.Name = "coloutcomes"
        Me.coloutcomes.Visible = True
        Me.coloutcomes.VisibleIndex = 0
        '
        'memoOutcomes
        '
        Me.memoOutcomes.Name = "memoOutcomes"
        '
        'colindicator
        '
        Me.colindicator.ColumnEdit = Me.memoIndicator
        Me.colindicator.FieldName = "indicator"
        Me.colindicator.Name = "colindicator"
        Me.colindicator.Visible = True
        Me.colindicator.VisibleIndex = 1
        '
        'memoIndicator
        '
        Me.memoIndicator.Name = "memoIndicator"
        '
        'colsource
        '
        Me.colsource.ColumnEdit = Me.memoSource
        Me.colsource.FieldName = "source"
        Me.colsource.Name = "colsource"
        Me.colsource.Visible = True
        Me.colsource.VisibleIndex = 2
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 3
        '
        'colidProject
        '
        Me.colidProject.FieldName = "idProject"
        Me.colidProject.Name = "colidProject"
        '
        'colduration
        '
        Me.colduration.Caption = "Duration / Year"
        Me.colduration.FieldName = "duration"
        Me.colduration.Name = "colduration"
        Me.colduration.Visible = True
        Me.colduration.VisibleIndex = 4
        '
        'memoSource
        '
        Me.memoSource.Name = "memoSource"
        '
        'memoQuantity
        '
        Me.memoQuantity.Name = "memoQuantity"
        '
        'InputForOutcomeDataTableBindingSource
        '
        Me.InputForOutcomeDataTableBindingSource.DataMember = "InputForOutcomeDataTable"
        Me.InputForOutcomeDataTableBindingSource.DataSource = Me.DataSetOutcome
        '
        'InputForOutcomeDataTableTableAdapter
        '
        Me.InputForOutcomeDataTableTableAdapter.ClearBeforeFill = True
        '
        'InputForOutcomeDataTableGridControl
        '
        Me.InputForOutcomeDataTableGridControl.DataSource = Me.InputForOutcomeDataTableBindingSource
        Me.InputForOutcomeDataTableGridControl.Location = New System.Drawing.Point(0, 28)
        Me.InputForOutcomeDataTableGridControl.MainView = Me.GridView2
        Me.InputForOutcomeDataTableGridControl.Name = "InputForOutcomeDataTableGridControl"
        Me.InputForOutcomeDataTableGridControl.Size = New System.Drawing.Size(175, 506)
        Me.InputForOutcomeDataTableGridControl.TabIndex = 4
        Me.InputForOutcomeDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidInput, Me.colidStakeholder, Me.colName, Me.colinput, Me.colvalue, Me.coloutputs})
        Me.GridView2.GridControl = Me.InputForOutcomeDataTableGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colidInput
        '
        Me.colidInput.FieldName = "idInput"
        Me.colidInput.Name = "colidInput"
        '
        'colidStakeholder
        '
        Me.colidStakeholder.FieldName = "idStakeholder"
        Me.colidStakeholder.Name = "colidStakeholder"
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colinput
        '
        Me.colinput.FieldName = "input"
        Me.colinput.Name = "colinput"
        '
        'colvalue
        '
        Me.colvalue.FieldName = "value"
        Me.colvalue.Name = "colvalue"
        '
        'coloutputs
        '
        Me.coloutputs.FieldName = "outputs"
        Me.coloutputs.Name = "coloutputs"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.memoInput)
        Me.GroupControl2.Controls.Add(Me.labelValue)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.memoOutput)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.labelStakeholder)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(181, 28)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(876, 163)
        Me.GroupControl2.TabIndex = 5
        Me.GroupControl2.Text = "Fill Outcomes Data For :"
        '
        'memoInput
        '
        Me.memoInput.Location = New System.Drawing.Point(113, 42)
        Me.memoInput.Name = "memoInput"
        Me.memoInput.Properties.ReadOnly = True
        Me.memoInput.Size = New System.Drawing.Size(297, 49)
        Me.memoInput.TabIndex = 8
        '
        'labelValue
        '
        Me.labelValue.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelValue.Location = New System.Drawing.Point(426, 42)
        Me.labelValue.Name = "labelValue"
        Me.labelValue.Size = New System.Drawing.Size(80, 39)
        Me.labelValue.TabIndex = 7
        Me.labelValue.Text = "0000"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(426, 23)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Value :"
        '
        'memoOutput
        '
        Me.memoOutput.Location = New System.Drawing.Point(113, 97)
        Me.memoOutput.Name = "memoOutput"
        Me.memoOutput.Properties.ReadOnly = True
        Me.memoOutput.Size = New System.Drawing.Size(297, 61)
        Me.memoOutput.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 98)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Output                   :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 42)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "Input                     :"
        '
        'labelStakeholder
        '
        Me.labelStakeholder.Location = New System.Drawing.Point(113, 23)
        Me.labelStakeholder.Name = "labelStakeholder"
        Me.labelStakeholder.Size = New System.Drawing.Size(79, 13)
        Me.labelStakeholder.TabIndex = 1
        Me.labelStakeholder.Text = "labelStakeholder"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Stakeholder Name :"
        '
        'FormOutcome2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 546)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.InputForOutcomeDataTableGridControl)
        Me.Controls.Add(Me.OutcomeDataTableGridControl)
        Me.Controls.Add(Me.OutcomeDataTableBindingNavigator)
        Me.Name = "FormOutcome2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormOutcome2"
        CType(Me.DataSetOutcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutcomeDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutcomeDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OutcomeDataTableBindingNavigator.ResumeLayout(False)
        Me.OutcomeDataTableBindingNavigator.PerformLayout()
        CType(Me.OutcomeDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoOutcomes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputForOutcomeDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputForOutcomeDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.memoInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoOutput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetOutcome As DataSetOutcome
    Friend WithEvents OutcomeDataTableBindingSource As BindingSource
    Friend WithEvents OutcomeDataTableTableAdapter As DataSetOutcomeTableAdapters.outcomeDataTableTableAdapter
    Friend WithEvents TableAdapterManager As DataSetOutcomeTableAdapters.TableAdapterManager
    Friend WithEvents OutcomeDataTableBindingNavigator As BindingNavigator
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
    Friend WithEvents OutcomeDataTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents OutcomeDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents InputForOutcomeDataTableBindingSource As BindingSource
    Friend WithEvents InputForOutcomeDataTableTableAdapter As DataSetOutcomeTableAdapters.InputForOutcomeDataTableTableAdapter
    Friend WithEvents InputForOutcomeDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As GroupControl
    Friend WithEvents memoInput As MemoEdit
    Friend WithEvents labelValue As LabelControl
    Friend WithEvents LabelControl5 As LabelControl
    Friend WithEvents memoOutput As MemoEdit
    Friend WithEvents LabelControl3 As LabelControl
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents labelStakeholder As LabelControl
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents colidInput As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidStakeholder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinput As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coloutputs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents memoOutcomes As Repository.RepositoryItemMemoEdit
    Friend WithEvents memoIndicator As Repository.RepositoryItemMemoEdit
    Friend WithEvents memoSource As Repository.RepositoryItemMemoEdit
    Friend WithEvents memoQuantity As Repository.RepositoryItemMemoEdit
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidStakeholder1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coloutcomes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colindicator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsource As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colduration As DevExpress.XtraGrid.Columns.GridColumn
End Class
