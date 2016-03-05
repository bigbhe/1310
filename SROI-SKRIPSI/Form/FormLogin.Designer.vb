<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.textEditUserName = New DevExpress.XtraEditors.TextEdit()
        Me.textEditPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.buttonSubmit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.textEditUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textEditUserName
        '
        Me.textEditUserName.Location = New System.Drawing.Point(104, 40)
        Me.textEditUserName.Name = "textEditUserName"
        Me.textEditUserName.Size = New System.Drawing.Size(222, 20)
        Me.textEditUserName.TabIndex = 0
        '
        'textEditPassword
        '
        Me.textEditPassword.Location = New System.Drawing.Point(104, 87)
        Me.textEditPassword.Name = "textEditPassword"
        Me.textEditPassword.Properties.UseSystemPasswordChar = True
        Me.textEditPassword.Size = New System.Drawing.Size(222, 20)
        Me.textEditPassword.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(26, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "User Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 90)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Password"
        '
        'buttonSubmit
        '
        Me.buttonSubmit.Location = New System.Drawing.Point(136, 123)
        Me.buttonSubmit.Name = "buttonSubmit"
        Me.buttonSubmit.Size = New System.Drawing.Size(75, 23)
        Me.buttonSubmit.TabIndex = 4
        Me.buttonSubmit.Text = "Submit"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.buttonSubmit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.textEditPassword)
        Me.Controls.Add(Me.textEditUserName)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        CType(Me.textEditUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textEditUserName As TextEdit
    Friend WithEvents textEditPassword As TextEdit
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents buttonSubmit As SimpleButton
End Class
