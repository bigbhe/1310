Imports DevExpress.XtraReports.UI

Public Class FormSroiReport
    Private Sub loadDataSROI()
        Try
            Me.ReportSROITableAdapter.Fill(Me.DataSetReport.ReportSROI, New System.Nullable(Of Integer)(CType(oProject.idProject2, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormSroiReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataSROI()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadPrint()

    End Sub
    Sub LoadPrint()

        Dim Report As New ReportSROI With {.DataSource = DataSetReport.Tables("ReportSROI"), .DataMember = "ReportSROI"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub

    Sub GetSummary()

        TotalOfInput = GridView1.Columns("valueOfInput").SummaryText
        TotalQuantity = GridView1.Columns("QuantityOfChanges").SummaryText
        TotalYear1 = GridView1.Columns("Year1").SummaryText
        TotalYear2 = GridView1.Columns("Year2").SummaryText
        TotalYear3 = GridView1.Columns("Year3").SummaryText
        TotalYear4 = GridView1.Columns("Year4").SummaryText
        TotalYear5 = GridView1.Columns("Year5").SummaryText

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GetSummary()
        CalculateNPV()

    End Sub
End Class