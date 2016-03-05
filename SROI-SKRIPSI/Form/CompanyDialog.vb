Public Class CompanyDialog
    Private Sub buttonCreate_Click(sender As Object, e As EventArgs) Handles buttonCreate.Click
        FormCompany.ShowDialog()
        Me.Close()

    End Sub

    Private Sub buttonLoad_Click(sender As Object, e As EventArgs) Handles buttonLoad.Click
        FormCompanyList.ShowDialog()
        Me.Close()
    End Sub
End Class