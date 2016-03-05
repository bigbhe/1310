Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FormProxy
    Private Sub ProxyDataTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProxyDataTableBindingNavigatorSaveItem.Click

        GridView1.SetFocusedRowCellValue(colidOutcome, Convert.ToInt32(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("idOutcome"))))

        Me.Validate()
        Me.ProxyDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetProxy)
    End Sub
    Sub LoadProxy()

        Try
            Me.ProxyDataTableTableAdapter.Fill(Me.DataSetProxy.proxyDataTable, New Nullable(Of Integer)(CType(oOutcome.idOutcome, Integer)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub loadStakeholder()
        Try
            Me.StakeHoledrForProxyDataTableTableAdapter.Fill(Me.DataSetProxy.StakeHoledrForProxyDataTable, New Nullable(Of Integer)(CType(oProject.idProject2, Integer)))
            oStakeholder.id = Convert.ToInt32(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("id")))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FormProxy_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadStakeholder()
        LoadProxy()
    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        oStakeholder.id = Convert.ToInt32(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("id")))

        LoadInputOutcomes()
        LoadProxy()
    End Sub
    Sub setDetailInput()

        memoIndicator.Text = oOutcome.indicator
        labelQuantity.Text = oOutcome.quantity
        labelDuration.Text = oOutcome.Duration
        labelValue.Text = oOutcome.value.ToString("c")
    End Sub
    Private Sub LoadInputOutcomes()
        Try
            Me.InputOutputForProxyDataTableTableAdapter.Fill(Me.DataSetProxy.inputOutputForProxyDataTable, New Nullable(Of Integer)(CType(oStakeholder.id, Integer)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GridView3_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged

        getDetailInputandOutcomes()
        setDetailInput()
        LoadProxy()

    End Sub


    Sub getDetailInputandOutcomes()

        'IIf(IsDBNull(GridView1.GetFocusedRowCellValue(colCredit)) = True, 0, GridView1.GetFocusedRowCellValue(colCredit))
        oOutcome.idOutcome = IIf(IsDBNull(Convert.ToInt32(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("idOutcome")))) = True, 0, Convert.ToInt32(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("idOutcome"))))
        oOutcome.input = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("input"))
        oOutcome.Name = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("Name"))
        oOutcome.value = Convert.ToDecimal(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("value")))
        oOutcome.outComes = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("outcomes"))
        oOutcome.quantity = Convert.ToInt32(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("Quantity")))
        oOutcome.Duration = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("Duration"))
        oOutcome.indicator = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("indicator"))

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click


        GridView1.SetFocusedRowCellValue(colidOutcome, Convert.ToInt32(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, GridView3.Columns("idOutcome"))))
    End Sub

End Class