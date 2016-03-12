Public Class FormLogin

    Private isApproved As Boolean

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isApproved = False
        'Login()

    End Sub

    Private Sub _GotFocus(sender As Object, e As EventArgs) Handles textEditUserName.GotFocus, textEditPassword.GotFocus
        Dim c As TextEdit = sender
        If Trim(Len(c.Text)) > 0 Then c.SelectAll()

    End Sub

    Private Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Login()
    End Sub

    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If isApproved Then
        Else
            Application.ExitThread()
        End If
    End Sub

    Sub Login()
        textEditPassword.Text = "admin"
        textEditUserName.Text = "admin"
        If textEditUserName.Text.Length = 0 Then
            XtraMessageBox.Show("Your account name still empty.", "Data Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textEditUserName.Focus()
            Exit Sub
        End If

        If textEditPassword.Text.Length = 0 Then
            XtraMessageBox.Show("Your password still empty.", "Data Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textEditPassword.Focus()
            Exit Sub
        End If

        aUser.Username = textEditUserName.Text
        aUser.Password = textEditPassword.Text

        Select Case aUser.DoValidation
            Case 0
                isApproved = True
                Me.Close()
            Case 1
                XtraMessageBox.Show("Your username not valid.", "Data Unmatched", MessageBoxButtons.OK, MessageBoxIcon.Error)
                textEditUserName.Focus()
                Exit Sub
            Case 2
                XtraMessageBox.Show("Your password not valid.", "Data Unmatched", MessageBoxButtons.OK, MessageBoxIcon.Error)
                textEditPassword.Focus()
                Exit Sub
            Case 3
                XtraMessageBox.Show("Your account is currently loggon from other terminal.", "Account Logged On", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                textEditUserName.Focus()
                Exit Sub
            Case 4
                XtraMessageBox.Show("Your account has been blocked by Administrator.", "Account Blocked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                textEditUserName.Focus()
                Exit Sub
            Case Else
                Exit Sub
        End Select

    End Sub
End Class