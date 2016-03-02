<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expendable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Expendable))
        Me.DataSetCompany = New SROI_SKRIPSI.DataSetCompany()
        Me.CityDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityDataTableTableAdapter = New SROI_SKRIPSI.DataSetCompanyTableAdapters.CityDataTableTableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetCompanyTableAdapters.TableAdapterManager()
        Me.CityDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CityDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CodeCountryToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodeCountryToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CityDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.DataSetCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CityDataTableBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.CityDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetCompany
        '
        Me.DataSetCompany.DataSetName = "DataSetCompany"
        Me.DataSetCompany.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CityDataTableBindingSource
        '
        Me.CityDataTableBindingSource.DataMember = "CityDataTable"
        Me.CityDataTableBindingSource.DataSource = Me.DataSetCompany
        '
        'CityDataTableTableAdapter
        '
        Me.CityDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.companyDataTableTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetCompanyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CityDataTableBindingNavigator
        '
        Me.CityDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CityDataTableBindingNavigator.BindingSource = Me.CityDataTableBindingSource
        Me.CityDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CityDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CityDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CityDataTableBindingNavigatorSaveItem})
        Me.CityDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CityDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CityDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CityDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CityDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CityDataTableBindingNavigator.Name = "CityDataTableBindingNavigator"
        Me.CityDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CityDataTableBindingNavigator.Size = New System.Drawing.Size(476, 25)
        Me.CityDataTableBindingNavigator.TabIndex = 0
        Me.CityDataTableBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CityDataTableBindingNavigatorSaveItem
        '
        Me.CityDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CityDataTableBindingNavigatorSaveItem.Enabled = False
        Me.CityDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("CityDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CityDataTableBindingNavigatorSaveItem.Name = "CityDataTableBindingNavigatorSaveItem"
        Me.CityDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.CityDataTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodeCountryToolStripLabel, Me.CodeCountryToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(476, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'CodeCountryToolStripLabel
        '
        Me.CodeCountryToolStripLabel.Name = "CodeCountryToolStripLabel"
        Me.CodeCountryToolStripLabel.Size = New System.Drawing.Size(79, 22)
        Me.CodeCountryToolStripLabel.Text = "codeCountry:"
        '
        'CodeCountryToolStripTextBox
        '
        Me.CodeCountryToolStripTextBox.Name = "CodeCountryToolStripTextBox"
        Me.CodeCountryToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 19)
        Me.FillToolStripButton.Text = "Fill"
        '
        'CityDataTableGridControl
        '
        Me.CityDataTableGridControl.DataSource = Me.CityDataTableBindingSource
        Me.CityDataTableGridControl.Location = New System.Drawing.Point(156, 74)
        Me.CityDataTableGridControl.MainView = Me.GridView1
        Me.CityDataTableGridControl.Name = "CityDataTableGridControl"
        Me.CityDataTableGridControl.Size = New System.Drawing.Size(300, 220)
        Me.CityDataTableGridControl.TabIndex = 2
        Me.CityDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.CityDataTableGridControl
        Me.GridView1.Name = "GridView1"
        '
        'Expendable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 314)
        Me.Controls.Add(Me.CityDataTableGridControl)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.CityDataTableBindingNavigator)
        Me.Name = "Expendable"
        Me.Text = "Expendable"
        CType(Me.DataSetCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CityDataTableBindingNavigator.ResumeLayout(False)
        Me.CityDataTableBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.CityDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetCompany As DataSetCompany
    Friend WithEvents CityDataTableBindingSource As BindingSource
    Friend WithEvents CityDataTableTableAdapter As DataSetCompanyTableAdapters.CityDataTableTableAdapter
    Friend WithEvents TableAdapterManager As DataSetCompanyTableAdapters.TableAdapterManager
    Friend WithEvents CityDataTableBindingNavigator As BindingNavigator
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
    Friend WithEvents CityDataTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents CodeCountryToolStripLabel As ToolStripLabel
    Friend WithEvents CodeCountryToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents CityDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
