Public Class ClassCompany
    Public Property idCompany As Integer
    Public Property name As String
    Public Property country As String
    Public Property city As String
    Public Property address As String
    Public Property subsidiary As String
    Public Property logo As Image
    Public Property note As String
    Public Property email As String
    Public Property website As String
    Public Property phone As String

    Sub New()
        idCompany = 0
    End Sub
    Public Function funcCheckIfCompanyExist() As Boolean
        If Not dbOpen() Then Throw New Exception("Cannot Open Database")
        sqlCmd = New SqlCommand With {.Connection = sqlCnn, .CommandType = CommandType.StoredProcedure, .CommandText = "checkIfCompanyExist"}

        With sqlCmd.Parameters
            .Add("@Result", SqlDbType.Bit).Direction = ParameterDirection.Output
        End With
        Try
            sqlCmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception(ex.ToString)
        Finally
            dbClose()
        End Try

        Return Convert.ToBoolean(sqlCmd.Parameters("@Result").Value)
    End Function
End Class
