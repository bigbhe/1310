Public Class ClassProject
    Public Property idProject As Integer
    Public Property idProject2 As Integer
    Public Property idCompany As Integer
    Public Property Name As String
    Public Property Note As String
    Public Property ProjectDate As DateTime


    Sub New()
        idProject = 0
    End Sub

    Public Function checkIfProjectExist() As Boolean
        If Not dbOpen() Then Throw New Exception("Cannot Open Database")
        sqlCmd = New SqlCommand With {.Connection = sqlCnn, .CommandType = CommandType.StoredProcedure, .CommandText = "checkIfProjectExist"}
        With sqlCmd.Parameters
            .Add("@Result", SqlDbType.Bit).Direction = ParameterDirection.Output
            .AddWithValue("@idCompany", oCompany.idCompany)
        End With
        Try
            sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        Finally
            dbClose()
        End Try
        Return Convert.ToBoolean(sqlCmd.Parameters("@Result").Value)
    End Function
End Class
