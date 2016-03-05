<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOutcome
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.memoInput = New DevExpress.XtraEditors.MemoEdit()
        Me.labelValue = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.memoOutput = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelStakeholder = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.memoInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoOutput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Location = New System.Drawing.Point(12, 35)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(176, 442)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Choose Stakeholder Below"
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
        Me.GroupControl2.Location = New System.Drawing.Point(194, 35)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(590, 163)
        Me.GroupControl2.TabIndex = 1
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
        'FormOutcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 491)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FormOutcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormOutcome"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.memoInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoOutput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents GroupControl2 As GroupControl
    Friend WithEvents labelValue As LabelControl
    Friend WithEvents LabelControl5 As LabelControl
    Friend WithEvents memoOutput As MemoEdit
    Friend WithEvents LabelControl3 As LabelControl
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents labelStakeholder As LabelControl
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents memoInput As MemoEdit
End Class
