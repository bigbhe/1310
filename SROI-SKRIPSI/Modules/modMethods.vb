Imports DevExpress.XtraEditors

Module modMethods

    Public Function dbOpen() As Boolean
        If sqlCnn.State <> ConnectionState.Open Then
            Try
                sqlCnn.Open()
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function

    Public Function dbClose() As Boolean
        If sqlCnn.State = ConnectionState.Open Then
            Try
                sqlCnn.Close()
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function

End Module
