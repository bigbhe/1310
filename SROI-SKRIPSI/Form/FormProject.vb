Public Class FormProject
    Friend Property _FormOpenMode As FormOpenMode
    Private Sub MstProjectDataTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstProjectDataTableBindingNavigatorSaveItem.Click

        GridView1.SetFocusedRowCellValue(colidUser, aUser.IDUser)
        GridView1.SetFocusedRowCellValue(colidCompany, oCompany.idCompany)
        Me.Validate()
        Me.MstProjectDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetProject)
    End Sub
    Private Sub LoadProject()
        Try
            Me.MstProjectDataTableTableAdapter.Fill(Me.DataSetProject.mstProjectDataTable, New Nullable(Of Integer)(CType(oCompany.idCompany, Integer)), CType(oProject.idProject, Integer))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FormProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetProject1.CountryForProject_SelectCommand' table. You can move, or remove it, as needed.
           LoadProject()
        Me.CountryForProject_SelectCommandTableAdapter.Fill(Me.DataSetProject1.CountryForProject_SelectCommand)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        'If _FormOpenMode = FormOpenMode.OpenAdd Then MstProjectDataTableBindingNavigatorSaveItem.Enabled = True
        MstProjectDataTableBindingNavigatorSaveItem.Enabled = True
        'GridView1.AddNewRow()


    End Sub
End Class