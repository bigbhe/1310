Imports DevExpress.XtraGrid.Views.Base

Public Class FormOutcome2
    Private Sub OutcomeDataTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OutcomeDataTableBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colidProject, oProject.idProject2)
        GridView1.SetFocusedRowCellValue(colidStakeholder1, oInput.idStakeholder)
        Me.Validate()
        Me.OutcomeDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetOutcome)

    End Sub


    Private Sub FillToolStripButton1_Click(sender As Object, e As EventArgs)
        MsgBox("a")

    End Sub

    Private Sub FormOutcome2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataInput()
        loadDataOutcome()

    End Sub

    Sub loadDataInput()
        Try
            Me.InputForOutcomeDataTableTableAdapter.Fill(Me.DataSetOutcome.InputForOutcomeDataTable, New Nullable(Of Integer)(CType(oProject.idProject2, Integer)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub loadDataOutcome()
        Try
            Me.OutcomeDataTableTableAdapter.Fill(Me.DataSetOutcome.outcomeDataTable, New Nullable(Of Integer)(CType(oInput.idStakeholder, Integer)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub getDetailInput()
        oInput.id = Convert.ToInt32(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("idInput")))
        oInput.idStakeholder = Convert.ToInt32(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("idStakeholder")))
        oInput.name = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("Name"))
        oInput.input = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("input"))
        oInput.value = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("value"))
        oInput.outputs = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("outputs"))
    End Sub

    Sub setDetailInput()
        labelStakeholder.Text = oInput.name
        memoInput.Text = oInput.input
        memoOutput.Text = oInput.outputs
        labelValue.Text = oInput.value.ToString("C2")
    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        getDetailInput()
        setDetailInput()

        loadDataOutcome()

    End Sub

End Class