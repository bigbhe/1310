Public Class FormInput
    Private Sub DataTableInputBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DataTableInputBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colidUser, aUser.IDUser)
        Me.Validate()
        Me.DataTableInputBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetInput)
        SaveDialog(Me)
    End Sub

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadStakeholder()
        loadData()
    End Sub

    Private Sub loadData()
        Try
            Me.DataTableInputTableAdapter.Fill(Me.DataSetInput.DataTableInput, New Nullable(Of Integer)(CType(oProject.idProject2, Integer)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub loadStakeholder()
        Try
            Me.StakeholderForInput_SelectCommandTableAdapter.Fill(Me.DataSetInput.StakeholderForInput_SelectCommand, New Nullable(Of Integer)(CType(oProject.idProject2, Integer)))
            GridView1.BestFitColumns(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class