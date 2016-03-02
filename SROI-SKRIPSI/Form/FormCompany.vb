Public Class FormCompany
    'Public Property formState As Boolean = False
    'Public Enum formOpenMode
    '    AddMode
    '    EditMode
    'End Enum

    Friend Property _formOpenMode As FormOpenMode


    Private Sub CompanyDataTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CompanyDataTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CompanyDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCompany)
        BindingNavigatorAddNewItem.Enabled = True
    End Sub

    Private Sub LoadCompany()
        Try
            Me.CompanyDataTableTableAdapter.Fill(Me.DataSetCompany.companyDataTable, CType(oCompany.idCompany, Integer))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetCompany.CountryDataTable' table. You can move, or remove it, as needed.
        If _formOpenMode = FormOpenMode.OpenAdd Then
            DataLayoutControl1.Enabled = False
        End If

        Me.CountryDataTableTableAdapter.Fill(Me.DataSetCompany.CountryDataTable)

        LoadCompany()
    End Sub
    ''' <summary>
    ''' true nya disiniiii
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        DataLayoutControl1.Enabled = True
        'formState = True
        'Me.CountryDataTableTableAdapter.Fill(Me.DataSetCompany.CountryDataTable)
        nameTextEdit.Focus()
        BindingNavigatorAddNewItem.Enabled = False

    End Sub
    Private Sub cityLookUpEdit_GotFocus(sender As Object, e As EventArgs) Handles cityLookUpEdit.GotFocus
        If countryLookUpEdit.EditValue Is DBNull.Value Then Exit Sub

        Try
            Me.cityLookUpEdit.Properties.DataSource = Me.CityDataTableBindingSource
            Me.cityLookUpEdit.Properties.DisplayMember = "city"
            Me.cityLookUpEdit.Properties.ValueMember = "city"
            Me.CityDataTableTableAdapter.Fill(Me.DataSetCompany.CityDataTable, countryLookUpEdit.EditValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub countryLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles countryLookUpEdit.EditValueChanged
        cityLookUpEdit.Properties.DataSource = Nothing
        cityLookUpEdit.EditValue = -1
        cityLookUpEdit.Text = ""
    End Sub
End Class