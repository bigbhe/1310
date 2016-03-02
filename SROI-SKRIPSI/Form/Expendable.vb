Public Class Expendable
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.CityDataTableTableAdapter.Fill(Me.DataSetCompany.CityDataTable, CodeCountryToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class