Imports System.ComponentModel

Public Class FormProjectList
    Private Sub loadProject()
        Try
            Me.ListProjectDataTableTableAdapter.Fill(Me.DataSetProject.listProjectDataTable, New Nullable(Of Integer)(CType(oCompany.idCompany, Integer)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lNewVariable As String = "List Of Project --- " & oCompany.name
        Me.Text = lNewVariable
        loadProject()
    End Sub

    Private Sub buttonSelect_Click(sender As Object, e As EventArgs) Handles buttonSelect.Click
        getDetail()
        Me.Close()
        SroiMainForm.Text = String.Format("Social Return On Investment --- {0} --- {1}", oCompany.name, oProject.Name)
        informationDialog(SroiMainForm, "Selected Project Data will be applied to all Project Properties")

    End Sub
    Sub getDetail()
        oProject.idProject = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("id")))
        oProject.Name = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("Name"))
        oProject.idCompany = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("idCompany")))
        oProject.ProjectDate = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("Date"))
        oProject.Note = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("note"))
    End Sub

    Private Sub FormProjectList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If oProject.idProject = 0 Then
            e.Cancel = True
        End If
    End Sub
End Class