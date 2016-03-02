Public Class ActiveUser
    Implements IDisposable

#Region "private members"
    Private _username As String
    Private _password As String
#End Region

#Region "public members - User information"
    Public Property IDUser As Integer

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Fullname As String

    Public Property Password As String
        Get
            Return crypt.DecryptData(_password)
        End Get
        Set(value As String)
            _password = crypt.EncryptData(value)
        End Set
    End Property

    Public Property Signature As Image

    Public Property LastIP As String

    Public Property LastLogon As DateTime

    Public Property IsLogon As Boolean

    Public Property IsActive As Boolean

    Public Property Rights As DataTable
#End Region

#Region "public members - Group information"
    Public Property IDGroup As Integer
    Public Property GroupName As String
#End Region

#Region "public members - Branch information"
    Public Property IDBranch As Integer
    Public Property Address As String
    Public Property City As String
    Public Property IDProvince As Integer
    Public Property Province As String
    Public Property Phone As String
    Public Property Fax As String
    Public Property isHQ As Boolean
#End Region

#Region "Class Constructor"
    Public Sub New()
        _username = ""
        _password = ""
        Rights = New DataTable
    End Sub
#End Region

#Region "private methods"
    Private Function GetIPAddress() As String
        GetIPAddress = String.Empty
        Dim host As String = System.Net.Dns.GetHostName()
        Dim ip As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(host)

        For Each iph As System.Net.IPAddress In ip.AddressList
            If iph.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                Return iph.ToString()
            End If
        Next
    End Function
#End Region

#Region "public methods"
    Public Function DoValidation() As Integer
        '   @result value Is
        '   0 = success,
        '   1 = failed by username Not found,
        '   2 = failed by password unmatched,
        '   3 = failed by account logged on,
        '   4 = failed by account non-activated
        '  99 = system failure

        If Not dbOpen() Then
            XtraMessageBox.Show("System failed open connection to SQL Server.", "System Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return 99
        End If

        sqlCmd = New SqlCommand("sysValidationLogin", sqlCnn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Clear()
        sqlCmd.Parameters.AddWithValue("@username", _username)
        sqlCmd.Parameters.AddWithValue("@password", _password)

        Dim ds As New DataSet


        Try
            sqlDta = New SqlDataAdapter(sqlCmd)
            sqlDta.Fill(ds)
            sqlDta.Dispose()
            sqlCmd.Dispose()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("System failed to validate user with this error:{0}{1}", vbCrLf, ex.Message), "System Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return 99
        Finally
            dbClose()
        End Try

        If ds.Tables(0).Rows(0)(0) = 0 Then
            IDUser = ds.Tables(1).Rows(0)("idUser")
            Fullname = ds.Tables(1).Rows(0)("fullname")
            'Signature = ds.Tables(1).Rows(0)("signature") 'have to create a class to convert byte array to image
        End If

        Return ds.Tables(0).Rows(0)(0)
    End Function


#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                Rights.Dispose()
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
