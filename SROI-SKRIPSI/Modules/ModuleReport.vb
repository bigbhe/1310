Module ModuleReport

    Public Property NetPresentValue As Decimal

    Public Property TotalOfInput As Decimal
    Public Property TotalQuantity As Decimal
    Public Property TotalValueOfChange As Decimal
    Public Property TotalYear1 As Decimal
    Public Property TotalYear2 As Decimal
    Public Property TotalYear3 As Decimal
    Public Property TotalYear4 As Decimal
    Public Property TotalYear5 As Decimal

    Sub CalculateNPV()
        TotalYear1 = TotalYear1 / 1.035
        TotalYear2 = TotalYear2 / 1.035 * 1.035
        TotalYear3 = TotalYear3 / 1.035 * 1.035 * 1.035
        TotalYear4 = TotalYear4 / 1.035 * 1.035 * 1.035 * 1.035
        TotalYear5 = TotalYear5 / 1.035 * 1.035 * 1.035 * 1.035 * 1.035

        TotalValueOfChange = TotalYear1 + TotalYear2 + TotalYear3 + TotalYear4 + TotalYear5

        NetPresentValue = TotalValueOfChange / TotalOfInput


    End Sub
End Module
