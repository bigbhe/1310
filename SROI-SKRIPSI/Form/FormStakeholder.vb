Public Class FormStakeholder
    Private Sub MstStakeholdersDataTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstStakeholdersDataTableBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colidUser, aUser.IDUser)
        GridView1.SetFocusedRowCellValue(colidProject, oProject.idProject2)
        Me.Validate()
        Me.MstStakeholdersDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetStakeholder)
        SaveDialog(Me)
    End Sub
    Private Sub loadData()
        Try
            Me.MstStakeholdersDataTableTableAdapter.Fill(Me.DataSetStakeholder.mstStakeholdersDataTable, New Nullable(Of Integer)(CType(oProject.idProject2, Integer)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FormStakeholder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

End Class