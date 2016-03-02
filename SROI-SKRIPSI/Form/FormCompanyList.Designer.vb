<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompanyList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompanyList))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DataSetCompany = New SROI_SKRIPSI.DataSetCompany()
        Me.CompanyList_SelectCommandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyList_SelectCommandTableAdapter = New SROI_SKRIPSI.DataSetCompanyTableAdapters.CompanyList_SelectCommandTableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetCompanyTableAdapters.TableAdapterManager()
        Me.CompanyList_SelectCommandGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsubsidiary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collogo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwebsite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.buttonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DataSetCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyList_SelectCommandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyList_SelectCommandGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetCompany
        '
        Me.DataSetCompany.DataSetName = "DataSetCompany"
        Me.DataSetCompany.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyList_SelectCommandBindingSource
        '
        Me.CompanyList_SelectCommandBindingSource.DataMember = "CompanyList_SelectCommand"
        Me.CompanyList_SelectCommandBindingSource.DataSource = Me.DataSetCompany
        '
        'CompanyList_SelectCommandTableAdapter
        '
        Me.CompanyList_SelectCommandTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.companyDataTableTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetCompanyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompanyList_SelectCommandGridControl
        '
        Me.CompanyList_SelectCommandGridControl.DataSource = Me.CompanyList_SelectCommandBindingSource
        Me.CompanyList_SelectCommandGridControl.Location = New System.Drawing.Point(0, 0)
        Me.CompanyList_SelectCommandGridControl.MainView = Me.GridView1
        Me.CompanyList_SelectCommandGridControl.Name = "CompanyList_SelectCommandGridControl"
        Me.CompanyList_SelectCommandGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.buttonEdit})
        Me.CompanyList_SelectCommandGridControl.Size = New System.Drawing.Size(815, 386)
        Me.CompanyList_SelectCommandGridControl.TabIndex = 1
        Me.CompanyList_SelectCommandGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colname, Me.colCountry, Me.colcity, Me.coladdress, Me.colsubsidiary, Me.collogo, Me.colnote, Me.colemail, Me.colwebsite, Me.colphone, Me.GridColumn1})
        Me.GridView1.GridControl = Me.CompanyList_SelectCommandGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = True
        Me.colCountry.VisibleIndex = 1
        '
        'colcity
        '
        Me.colcity.FieldName = "city"
        Me.colcity.Name = "colcity"
        Me.colcity.Visible = True
        Me.colcity.VisibleIndex = 2
        '
        'coladdress
        '
        Me.coladdress.FieldName = "address"
        Me.coladdress.Name = "coladdress"
        '
        'colsubsidiary
        '
        Me.colsubsidiary.FieldName = "subsidiary"
        Me.colsubsidiary.Name = "colsubsidiary"
        '
        'collogo
        '
        Me.collogo.FieldName = "logo"
        Me.collogo.Name = "collogo"
        Me.collogo.Visible = True
        Me.collogo.VisibleIndex = 3
        '
        'colnote
        '
        Me.colnote.FieldName = "note"
        Me.colnote.Name = "colnote"
        '
        'colemail
        '
        Me.colemail.FieldName = "email"
        Me.colemail.Name = "colemail"
        Me.colemail.Visible = True
        Me.colemail.VisibleIndex = 4
        '
        'colwebsite
        '
        Me.colwebsite.FieldName = "website"
        Me.colwebsite.Name = "colwebsite"
        Me.colwebsite.Visible = True
        Me.colwebsite.VisibleIndex = 5
        '
        'colphone
        '
        Me.colphone.FieldName = "phone"
        Me.colphone.Name = "colphone"
        Me.colphone.Visible = True
        Me.colphone.VisibleIndex = 6
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Action"
        Me.GridColumn1.ColumnEdit = Me.buttonEdit
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        '
        'buttonEdit
        '
        Me.buttonEdit.AutoHeight = False
        Me.buttonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("buttonEdit.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(372, 392)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Choose"
        '
        'FormCompanyList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.CompanyList_SelectCommandGridControl)
        Me.Name = "FormCompanyList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCompanyList"
        CType(Me.DataSetCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyList_SelectCommandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyList_SelectCommandGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSetCompany As DataSetCompany
    Friend WithEvents CompanyList_SelectCommandBindingSource As BindingSource
    Friend WithEvents CompanyList_SelectCommandTableAdapter As DataSetCompanyTableAdapters.CompanyList_SelectCommandTableAdapter
    Friend WithEvents TableAdapterManager As DataSetCompanyTableAdapters.TableAdapterManager
    Friend WithEvents CompanyList_SelectCommandGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsubsidiary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collogo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwebsite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents buttonEdit As Repository.RepositoryItemButtonEdit
End Class
