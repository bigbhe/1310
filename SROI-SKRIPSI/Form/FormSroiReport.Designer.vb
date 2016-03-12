<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSroiReport
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
        Me.DataSetReport = New SROI_SKRIPSI.DataSetReport()
        Me.ReportSROIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportSROITableAdapter = New SROI_SKRIPSI.DataSetReportTableAdapters.ReportSROITableAdapter()
        Me.TableAdapterManager = New SROI_SKRIPSI.DataSetReportTableAdapters.TableAdapterManager()
        Me.ReportSROIGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdCompany = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidStakeHolder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstakeholderName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colreason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.memoReason = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colInput = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.memoInput = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colvalueOfInput = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutputs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colOutcomes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colIndicator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colSourceOfOutcome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colQuantityOfChanges = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinancialProxy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colValueOfInput1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourceOfProxy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeadweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAttribution = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDropOff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImpact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DataSetReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportSROIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportSROIGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetReport
        '
        Me.DataSetReport.DataSetName = "DataSetReport"
        Me.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportSROIBindingSource
        '
        Me.ReportSROIBindingSource.DataMember = "ReportSROI"
        Me.ReportSROIBindingSource.DataSource = Me.DataSetReport
        '
        'ReportSROITableAdapter
        '
        Me.ReportSROITableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SROI_SKRIPSI.DataSetReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReportSROIGridControl
        '
        Me.ReportSROIGridControl.DataSource = Me.ReportSROIBindingSource
        Me.ReportSROIGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportSROIGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ReportSROIGridControl.MainView = Me.GridView1
        Me.ReportSROIGridControl.Name = "ReportSROIGridControl"
        Me.ReportSROIGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.memoReason, Me.memoInput, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3, Me.RepositoryItemMemoEdit4, Me.RepositoryItemMemoEdit5})
        Me.ReportSROIGridControl.Size = New System.Drawing.Size(1029, 471)
        Me.ReportSROIGridControl.TabIndex = 2
        Me.ReportSROIGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdCompany, Me.colidProject, Me.colCompanyName, Me.colidStakeHolder, Me.colProjectName, Me.colstakeholderName, Me.colreason, Me.colInput, Me.colvalueOfInput, Me.colOutputs, Me.colOutcomes, Me.colIndicator, Me.colSourceOfOutcome, Me.colQuantityOfChanges, Me.colFinancialProxy, Me.colValueOfInput1, Me.colSourceOfProxy, Me.colDeadweight, Me.colAttribution, Me.colDropOff, Me.colImpact, Me.colYear1, Me.colYear2, Me.colYear3, Me.colYear4, Me.colYear5})
        Me.GridView1.GridControl = Me.ReportSROIGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colIdCompany
        '
        Me.colIdCompany.FieldName = "IdCompany"
        Me.colIdCompany.Name = "colIdCompany"
        '
        'colidProject
        '
        Me.colidProject.FieldName = "idProject"
        Me.colidProject.Name = "colidProject"
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 0
        '
        'colidStakeHolder
        '
        Me.colidStakeHolder.FieldName = "idStakeHolder"
        Me.colidStakeHolder.Name = "colidStakeHolder"
        '
        'colProjectName
        '
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 1
        '
        'colstakeholderName
        '
        Me.colstakeholderName.FieldName = "stakeholderName"
        Me.colstakeholderName.Name = "colstakeholderName"
        Me.colstakeholderName.Visible = True
        Me.colstakeholderName.VisibleIndex = 2
        '
        'colreason
        '
        Me.colreason.ColumnEdit = Me.memoReason
        Me.colreason.FieldName = "reason"
        Me.colreason.Name = "colreason"
        Me.colreason.Visible = True
        Me.colreason.VisibleIndex = 3
        '
        'memoReason
        '
        Me.memoReason.Name = "memoReason"
        '
        'colInput
        '
        Me.colInput.ColumnEdit = Me.memoInput
        Me.colInput.FieldName = "Input"
        Me.colInput.Name = "colInput"
        Me.colInput.Visible = True
        Me.colInput.VisibleIndex = 4
        '
        'memoInput
        '
        Me.memoInput.Name = "memoInput"
        '
        'colvalueOfInput
        '
        Me.colvalueOfInput.DisplayFormat.FormatString = "c2"
        Me.colvalueOfInput.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colvalueOfInput.FieldName = "valueOfInput"
        Me.colvalueOfInput.Name = "colvalueOfInput"
        Me.colvalueOfInput.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valueOfInput", "{0:c2}")})
        Me.colvalueOfInput.Visible = True
        Me.colvalueOfInput.VisibleIndex = 5
        '
        'colOutputs
        '
        Me.colOutputs.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colOutputs.FieldName = "Outputs"
        Me.colOutputs.Name = "colOutputs"
        Me.colOutputs.Visible = True
        Me.colOutputs.VisibleIndex = 6
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colOutcomes
        '
        Me.colOutcomes.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colOutcomes.FieldName = "Outcomes"
        Me.colOutcomes.Name = "colOutcomes"
        Me.colOutcomes.Visible = True
        Me.colOutcomes.VisibleIndex = 7
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colIndicator
        '
        Me.colIndicator.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colIndicator.FieldName = "Indicator"
        Me.colIndicator.Name = "colIndicator"
        Me.colIndicator.Visible = True
        Me.colIndicator.VisibleIndex = 8
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'colSourceOfOutcome
        '
        Me.colSourceOfOutcome.ColumnEdit = Me.RepositoryItemMemoEdit4
        Me.colSourceOfOutcome.FieldName = "SourceOfOutcome"
        Me.colSourceOfOutcome.Name = "colSourceOfOutcome"
        Me.colSourceOfOutcome.Visible = True
        Me.colSourceOfOutcome.VisibleIndex = 9
        '
        'RepositoryItemMemoEdit4
        '
        Me.RepositoryItemMemoEdit4.Name = "RepositoryItemMemoEdit4"
        '
        'colQuantityOfChanges
        '
        Me.colQuantityOfChanges.FieldName = "QuantityOfChanges"
        Me.colQuantityOfChanges.Name = "colQuantityOfChanges"
        Me.colQuantityOfChanges.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityOfChanges", "{0:0.##}")})
        Me.colQuantityOfChanges.Visible = True
        Me.colQuantityOfChanges.VisibleIndex = 10
        '
        'colFinancialProxy
        '
        Me.colFinancialProxy.ColumnEdit = Me.RepositoryItemMemoEdit5
        Me.colFinancialProxy.FieldName = "FinancialProxy"
        Me.colFinancialProxy.Name = "colFinancialProxy"
        Me.colFinancialProxy.Visible = True
        Me.colFinancialProxy.VisibleIndex = 11
        '
        'RepositoryItemMemoEdit5
        '
        Me.RepositoryItemMemoEdit5.Name = "RepositoryItemMemoEdit5"
        '
        'colValueOfInput1
        '
        Me.colValueOfInput1.DisplayFormat.FormatString = "c2"
        Me.colValueOfInput1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValueOfInput1.FieldName = "ValueOfInput1"
        Me.colValueOfInput1.Name = "colValueOfInput1"
        Me.colValueOfInput1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValueOfInput1", "{0:c2}")})
        Me.colValueOfInput1.Visible = True
        Me.colValueOfInput1.VisibleIndex = 12
        '
        'colSourceOfProxy
        '
        Me.colSourceOfProxy.FieldName = "SourceOfProxy"
        Me.colSourceOfProxy.Name = "colSourceOfProxy"
        Me.colSourceOfProxy.Visible = True
        Me.colSourceOfProxy.VisibleIndex = 13
        '
        'colDeadweight
        '
        Me.colDeadweight.DisplayFormat.FormatString = "p"
        Me.colDeadweight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDeadweight.FieldName = "Deadweight"
        Me.colDeadweight.Name = "colDeadweight"
        Me.colDeadweight.Visible = True
        Me.colDeadweight.VisibleIndex = 14
        '
        'colAttribution
        '
        Me.colAttribution.DisplayFormat.FormatString = "p"
        Me.colAttribution.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAttribution.FieldName = "Attribution"
        Me.colAttribution.Name = "colAttribution"
        Me.colAttribution.Visible = True
        Me.colAttribution.VisibleIndex = 15
        '
        'colDropOff
        '
        Me.colDropOff.DisplayFormat.FormatString = "p"
        Me.colDropOff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDropOff.FieldName = "DropOff"
        Me.colDropOff.Name = "colDropOff"
        Me.colDropOff.Visible = True
        Me.colDropOff.VisibleIndex = 16
        '
        'colImpact
        '
        Me.colImpact.DisplayFormat.FormatString = "c2"
        Me.colImpact.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImpact.FieldName = "Impact"
        Me.colImpact.Name = "colImpact"
        Me.colImpact.Visible = True
        Me.colImpact.VisibleIndex = 17
        '
        'colYear1
        '
        Me.colYear1.DisplayFormat.FormatString = "c2"
        Me.colYear1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYear1.FieldName = "Year1"
        Me.colYear1.Name = "colYear1"
        Me.colYear1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Year1", "{0:c2}")})
        Me.colYear1.Visible = True
        Me.colYear1.VisibleIndex = 18
        '
        'colYear2
        '
        Me.colYear2.DisplayFormat.FormatString = "c2"
        Me.colYear2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYear2.FieldName = "Year2"
        Me.colYear2.Name = "colYear2"
        Me.colYear2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Year2", "{0:c2}")})
        Me.colYear2.Visible = True
        Me.colYear2.VisibleIndex = 19
        '
        'colYear3
        '
        Me.colYear3.DisplayFormat.FormatString = "c2"
        Me.colYear3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYear3.FieldName = "Year3"
        Me.colYear3.Name = "colYear3"
        Me.colYear3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Year3", "{0:c2}")})
        Me.colYear3.Visible = True
        Me.colYear3.VisibleIndex = 20
        '
        'colYear4
        '
        Me.colYear4.DisplayFormat.FormatString = "c2"
        Me.colYear4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYear4.FieldName = "Year4"
        Me.colYear4.Name = "colYear4"
        Me.colYear4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Year4", "{0:c2}")})
        Me.colYear4.Visible = True
        Me.colYear4.VisibleIndex = 21
        '
        'colYear5
        '
        Me.colYear5.DisplayFormat.FormatString = "c2"
        Me.colYear5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYear5.FieldName = "Year5"
        Me.colYear5.Name = "colYear5"
        Me.colYear5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Year5", "{0:c2}")})
        Me.colYear5.Visible = True
        Me.colYear5.VisibleIndex = 22
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(939, 6)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(733, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "SimpleButton2"
        '
        'FormSroiReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 471)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.ReportSROIGridControl)
        Me.Name = "FormSroiReport"
        Me.Text = "FormSroiReport"
        CType(Me.DataSetReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportSROIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportSROIGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSetReport As DataSetReport
    Friend WithEvents ReportSROIBindingSource As BindingSource
    Friend WithEvents ReportSROITableAdapter As DataSetReportTableAdapters.ReportSROITableAdapter
    Friend WithEvents TableAdapterManager As DataSetReportTableAdapters.TableAdapterManager
    Friend WithEvents ReportSROIGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdCompany As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidStakeHolder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstakeholderName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colreason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents memoReason As Repository.RepositoryItemMemoEdit
    Friend WithEvents colInput As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents memoInput As Repository.RepositoryItemMemoEdit
    Friend WithEvents colvalueOfInput As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutputs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As Repository.RepositoryItemMemoEdit
    Friend WithEvents colOutcomes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As Repository.RepositoryItemMemoEdit
    Friend WithEvents colIndicator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit3 As Repository.RepositoryItemMemoEdit
    Friend WithEvents colSourceOfOutcome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit4 As Repository.RepositoryItemMemoEdit
    Friend WithEvents colQuantityOfChanges As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinancialProxy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit5 As Repository.RepositoryItemMemoEdit
    Friend WithEvents colValueOfInput1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourceOfProxy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeadweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAttribution As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDropOff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImpact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As SimpleButton
    Friend WithEvents SimpleButton2 As SimpleButton
End Class
