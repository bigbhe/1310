Imports DevExpress.XtraBars.Alerter
Module ModuleAdditional
#Region "Dialog"
    Public Function deleteDialog(ByVal deleteObject As String) As Integer
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Question)
        If XtraMessageBox.Show("Do You want to Delete this data: " & deleteObject, "Attention", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Sub SaveDialog(x As Control)
        Dim alert As New AlertControl
        alert.Show(x, "Success", "New Data Successfully Saved")
    End Sub

    Public Sub warningDialog(x As Control, DialogMessage As String)
        Dim alert As New AlertControl
        alert.Show(x, "Warning", DialogMessage)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
    End Sub

    Public Sub informationDialog(x As Control, DialogMessage As String)
        Dim alert As New AlertControl
        alert.Show(x, "Information", DialogMessage)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)

    End Sub

#End Region

#Region "Clear"
    Public Sub EmptyTxt(ByVal Frm As Form)
        Dim Ctl As Control
        For Each Ctl In Frm.Controls
            If TypeOf Ctl Is TextEdit Then CType(Ctl, TextEdit).EditValue = ""
            If TypeOf Ctl Is GroupControl Then
                Dim Ctl1 As Control
                For Each Ctl1 In Ctl.Controls
                    If TypeOf Ctl1 Is TextEdit Then
                        Ctl1.Text = ""
                    End If
                Next
            End If

        Next
    End Sub
#End Region

End Module
