Public Class CryptForm
    Private Sub CryptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MemoEdit1.Text = crypt.EncryptData("localhost") & vbNewLine & crypt.EncryptData("SROI") & vbNewLine & crypt.EncryptData("sa") & vbNewLine & crypt.EncryptData("123") & vbNewLine & vbNewLine & vbNewLine & crypt.EncryptData("admin") & vbNewLine & "Dian" & vbNewLine & crypt.EncryptData("dian") & "Lucy" & vbNewLine & crypt.EncryptData("lucy")
    End Sub
End Class