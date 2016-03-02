Module modDescription
    Public crypt As New CryptText("Social-Return-On-Investment")
    Public rConfig As New ReadConfig
    Public aUser As New ActiveUser
    Public oCompany As New ClassCompany
    'Public oMstMember As New ClassMstMember
    'Public oTraVisit As New ClassTraVisit
    'Public otraVisit2 As New ClassTraVisit2
    'Public oQueue As New ClassQueue

    Public sqlCnn As SqlConnection
    Public sqlCmd As SqlCommand
    Public sqlDta As SqlDataAdapter
    Public sqlDtr As SqlDataReader
    Public sqlTra As SqlTransaction

    Public Enum FormOpenMode
        OpenAdd
        OpenRead
        OpenEdit
    End Enum

    Public Structure FormFlags
        Public canRead As Boolean
        Public canAdd As Boolean
        Public canEdit As Boolean
        Public canDelete As Boolean
        Public canPrint As Boolean
        Public canApprove As Boolean
    End Structure
End Module
