Public Class FormMainIssue
    'Public dataExist As Boolean = False
    Private Sub SaveData()
        Me.Validate()
        Me.MainIssueDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetMainIssue)
    End Sub
    Private Sub loadMainIssue()
        Try
            If oMainIssue.funcCheckIsMainIssueExist() = True Then
                Me.MainIssueDataTableTableAdapter.Fill(Me.DataSetMainIssue.MainIssueDataTable, New Nullable(Of Integer)(CType(oProject.idProject2, Integer)))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FormMainIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If oMainIssue.funcCheckIsMainIssueExist() = True Then
            loadMainIssue()
        End If
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        SaveData()
        SaveDialog(Me)
    End Sub

    Private Sub FormMainIssue_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If oMainIssue.funcCheckIsMainIssueExist() = 0 Then
            GridView1.AddNewRow()
            GridView1.SetFocusedRowCellValue(colidUser, aUser.IDUser)
            GridView1.SetFocusedRowCellValue(colidProject, oProject.idProject2)
            purposeMemoEdit.Focus()
        End If
    End Sub
End Class