Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class ReportSROI


    Private Sub ReportSROI_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Disc1.Text = TotalYear1
        Disc2.Text = TotalYear2
        Disc3.Text = TotalYear3
        Disc4.Text = TotalYear4
        Disc5.Text = TotalYear5

        TotalNPV.Text = "Total NPV" & TotalValueOfChange.ToString("C")
        TotalInput.Text = "Total Input" & TotalOfInput.ToString("c")
        'SroiRatio.Text = NetPresentValue
    End Sub
End Class