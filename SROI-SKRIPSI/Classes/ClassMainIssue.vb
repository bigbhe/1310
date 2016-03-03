Public Class ClassMainIssue
    Public Property id As Integer
    Public Property purpose As String
    Public Property background As String
    Public Property rangeOfActivities As String
    Public Property isForecast As Boolean

    Public Function funcCheckIsMainIssueExist() As Boolean
        If Not dbOpen() Then Throw New Exception("Cannot Open Database")
        sqlCmd = New SqlCommand With {.Connection = sqlCnn, .CommandType = CommandType.StoredProcedure, .CommandText = "checkIsMainIssueExist"}

        With sqlCmd.Parameters
            .Add("@Result", SqlDbType.Bit).Direction = ParameterDirection.Output
            .AddWithValue("@idProject", oProject.idProject2)
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
