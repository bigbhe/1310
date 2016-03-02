Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml

Public NotInheritable Class ReadConfig

#Region "private members"
    Private _server As String
    Private _database As String
    Private _userid As String
    Private _password As String

    Private _result As String
#End Region

#Region "public members"
    Public Property Filename As String

    Public ReadOnly Property Result As String
        Get
            Return _result
        End Get
    End Property
#End Region

#Region "private methods"
    Private Sub Empty()
        _server = ""
        _database = ""
        _password = ""
        _userid = ""
        _result = ""
    End Sub

    Private Function isFileExists() As Boolean
        If Filename.Length = 0 Then Return False

        Dim oFile As FileStream

        Try
            oFile = New FileStream(Filename, FileMode.Open)
            oFile.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub WriteDefaultConfig()
        Dim oXMLSetting As New XmlWriterSettings With {.Indent = True, .NewLineOnAttributes = True}

        Using oWriter As XmlWriter = XmlWriter.Create(Filename, oXMLSetting)
            oWriter.WriteStartElement("Configuration")
            oWriter.WriteElementString("Server", crypt.EncryptData("GROOT"))
            oWriter.WriteElementString("Database", crypt.EncryptData("IHD"))
            oWriter.WriteElementString("UserID", crypt.EncryptData("sa"))
            oWriter.WriteElementString("Password", crypt.EncryptData("123"))
            oWriter.WriteEndElement()
            oWriter.Close()
        End Using
        'read the config.xml again
        Read()
    End Sub

    Private Sub GetNode(ByVal reader As XmlReader)
        If reader.NodeType = XmlNodeType.Element Then
            Select Case reader.Name.ToUpper
                Case "SERVER"
                    _server = crypt.DecryptData(reader.ReadElementContentAsString)
                Case "DATABASE"
                    _database = crypt.DecryptData(reader.ReadElementContentAsString)
                Case "USERID"
                    _userid = crypt.DecryptData(reader.ReadElementContentAsString)
                Case "PASSWORD"
                    _password = crypt.DecryptData(reader.ReadElementContentAsString)
            End Select
        End If
    End Sub
#End Region

#Region "Class Constructor"
    Public Sub New()
        Filename = String.Format("{0}\Settings\config.xml", Application.StartupPath)
        Empty()
    End Sub

    Public Sub New(ByVal configFilename As String)
        Empty()
        Filename = configFilename
    End Sub
#End Region

#Region "public methods"
    Public Sub Read()
        Dim oXMLSetting As New XmlReaderSettings With {.CheckCharacters = True, .IgnoreComments = True}

        If isFileExists() Then
            Using oXmlReader As XmlReader = XmlReader.Create(Filename, oXMLSetting)
                Do While oXmlReader.Read
                    GetNode(oXmlReader)
                Loop
            End Using
        Else
            WriteDefaultConfig()
        End If

        Dim strConnString As String = String.Format("SERVER={0}; Database={1}; ", _server, _database)

        If _userid.Length = 0 Then
            strConnString = strConnString + "Trusted_Connection = True;"
        Else
            strConnString = String.Format("{0} User ID={1}; Password={2}; ", strConnString, _userid, _password)
        End If
        'MsgBox(strConnString)
        _result = strConnString
    End Sub
#End Region

End Class
