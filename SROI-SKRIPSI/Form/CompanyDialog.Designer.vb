<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyDialog
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.buttonCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.buttonLoad = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(373, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Do you want to create new company Data or select existing one from the list?"
        '
        'buttonCreate
        '
        Me.buttonCreate.Location = New System.Drawing.Point(31, 61)
        Me.buttonCreate.Name = "buttonCreate"
        Me.buttonCreate.Size = New System.Drawing.Size(154, 23)
        Me.buttonCreate.TabIndex = 1
        Me.buttonCreate.Text = "Create New Company Data"
        '
        'buttonLoad
        '
        Me.buttonLoad.Location = New System.Drawing.Point(191, 61)
        Me.buttonLoad.Name = "buttonLoad"
        Me.buttonLoad.Size = New System.Drawing.Size(121, 23)
        Me.buttonLoad.TabIndex = 2
        Me.buttonLoad.Text = "Load Existing One"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 123)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Don't show this dialog anymore, remember my choice"
        Me.CheckEdit1.Size = New System.Drawing.Size(321, 19)
        Me.CheckEdit1.TabIndex = 3
        '
        'CompanyDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 163)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.buttonLoad)
        Me.Controls.Add(Me.buttonCreate)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "CompanyDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CompanyDialog"
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents buttonCreate As SimpleButton
    Friend WithEvents buttonLoad As SimpleButton
    Friend WithEvents CheckEdit1 As CheckEdit
End Class
