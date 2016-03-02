Imports System.ComponentModel

Public Class FormCompanyList
    Private Sub FormCompanyList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SroiMainForm.Text = "Social Return On Investment---" & oCompany.name
    End Sub

    Private Sub FormCompanyList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetCompany.CompanyList_SelectCommand' table. You can move, or remove it, as needed.
        Me.CompanyList_SelectCommandTableAdapter.Fill(Me.DataSetCompany.CompanyList_SelectCommand)
    End Sub
    Sub getDetail()
        oCompany.idCompany = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("id")))
        oCompany.name = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("name"))
        oCompany.city = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("city"))
        oCompany.address = IIf(IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("address"))), "", (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("address"))))
        oCompany.subsidiary = IIf(IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("subsidiary"))), "", (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("subsidiary"))))
        'oCompany.logo = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("logo"))
        oCompany.note = IIf(IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("note"))), "", (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("note"))))
        oCompany.email = IIf(IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("email"))), "", (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("email"))))
        oCompany.website = IIf(IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("website"))), "", (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("website"))))
        oCompany.phone = IIf(IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("phone"))), "", (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("phone"))))
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If oCompany.idCompany = 0 Then
            getDetail()
        Else
            If XtraMessageBox.Show("Do you really want to open new company data? " & vbNewLine & " all current data will be lost, make sure to save your data", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                getDetail()
            End If
        End If
        Me.Close()
    End Sub
End Class