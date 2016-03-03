<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProjectList
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
        Me.DataSetProject = New SROI_SKRIPSI.DataSetProject()
        Me.ListProjectDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListProjectDataTableTableAdapter = New SROI_SKRIPSI.DataSetProjectTableAdapters.listProjectDataTableTableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetProjectTableAdapters.TableAdapterManager()
        Me.ListProjectDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidCompany = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.buttonSelect = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DataSetProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListProjectDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetProject
        '
        Me.DataSetProject.DataSetName = "DataSetProject"
        Me.DataSetProject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListProjectDataTableBindingSource
        '
        Me.ListProjectDataTableBindingSource.DataMember = "listProjectDataTable"
        Me.ListProjectDataTableBindingSource.DataSource = Me.DataSetProject
        '
        'ListProjectDataTableTableAdapter
        '
        Me.ListProjectDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.mstProjectDataTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetProjectTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListProjectDataTableGridControl
        '
        Me.ListProjectDataTableGridControl.DataSource = Me.ListProjectDataTableBindingSource
        Me.ListProjectDataTableGridControl.Location = New System.Drawing.Point(10, 22)
        Me.ListProjectDataTableGridControl.MainView = Me.GridView1
        Me.ListProjectDataTableGridControl.Name = "ListProjectDataTableGridControl"
        Me.ListProjectDataTableGridControl.Size = New System.Drawing.Size(678, 376)
        Me.ListProjectDataTableGridControl.TabIndex = 2
        Me.ListProjectDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colName, Me.colidCompany, Me.colDate, Me.colidUser, Me.colnote})
        Me.GridView1.GridControl = Me.ListProjectDataTableGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colidCompany
        '
        Me.colidCompany.FieldName = "idCompany"
        Me.colidCompany.Name = "colidCompany"
        '
        'colDate
        '
        Me.colDate.DisplayFormat.FormatString = "D"
        Me.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDate.FieldName = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 1
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
        Me.colnote.VisibleIndex = 2
        '
        'buttonSelect
        '
        Me.buttonSelect.Location = New System.Drawing.Point(302, 404)
        Me.buttonSelect.Name = "buttonSelect"
        Me.buttonSelect.Size = New System.Drawing.Size(100, 23)
        Me.buttonSelect.TabIndex = 3
        Me.buttonSelect.Text = "Select"
        '
        'FormProjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 443)
        Me.ControlBox = False
        Me.Controls.Add(Me.buttonSelect)
        Me.Controls.Add(Me.ListProjectDataTableGridControl)
        Me.Name = "FormProjectList"
        Me.Text = "FormProjectList"
        CType(Me.DataSetProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListProjectDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSetProject As DataSetProject
    Friend WithEvents ListProjectDataTableBindingSource As BindingSource
    Friend WithEvents ListProjectDataTableTableAdapter As DataSetProjectTableAdapters.listProjectDataTableTableAdapter
    Friend WithEvents TableAdapterManager As DataSetProjectTableAdapters.TableAdapterManager
    Friend WithEvents ListProjectDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidCompany As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents buttonSelect As SimpleButton
End Class
