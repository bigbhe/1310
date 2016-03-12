
Partial Public Class SroiMainForm
    Inherits XtraForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.Skins.SkinManager.EnableMdiFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SroiMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLogin.ShowDialog()
        CompanyDialog.ShowDialog()
    End Sub


    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarNewCompany.LinkClicked
        If Me.MdiChildren.Contains(FormCompany) Then
            FormCompany.Focus()
        Else
            FormCompany.MdiParent = Me
            FormCompany.Show()
        End If
    End Sub
    Private Sub navBarProject_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarProject.LinkClicked
        If Me.MdiChildren.Contains(FormProject) Then
            FormProject.Focus()
        Else
            FormProject.MdiParent = Me
            FormProject.Show()
        End If
    End Sub

    Private Sub navBarMainIssue_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarMainIssue.LinkClicked
        If oProject.idProject2 = 0 Then
            warningDialog(Me, "No Project Selected, in order to view Teory of Changes" & vbNewLine & "You have to select a project")
        Else
            If Me.MdiChildren.Contains(FormMainIssue) Then
                FormMainIssue.Focus()
            Else
                FormMainIssue.MdiParent = Me
                FormMainIssue.Show()
            End If
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        XtraMessageBox.Show(String.Format("Information{0}Company Name : {1}{0}Project Name: {2}", vbNewLine, oCompany.name, oProject.Name))
        XtraMessageBox.Show(oProject.idProject)
    End Sub

    Private Sub navBarStakeholders_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarStakeholders.LinkClicked
        If oProject.idProject2 = 0 Then
            warningDialog(Me, "No Project Selected, in order to view Stakeholder data" & vbNewLine & "You have to select a project")
        Else
            If Me.MdiChildren.Contains(FormStakeholder) Then
                FormStakeholder.Focus()
            Else
                FormStakeholder.MdiParent = Me
                FormStakeholder.Show()
            End If
        End If
    End Sub

    Private Sub navBarInput_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarInput.LinkClicked
        If oProject.idProject2 = 0 Then
            warningDialog(Me, "No Project Selected, in order to view Input data" & vbNewLine & "You have to select a project")
        Else
            If Me.MdiChildren.Contains(FormInput) Then
                FormInput.Focus()
            Else
                FormInput.MdiParent = Me
                FormInput.Show()
            End If
        End If
    End Sub

    Private Sub navBarOutcome_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarOutcome.LinkClicked
        If oProject.idProject2 = 0 Then
            warningDialog(Me, "No Project Selected, in order to view Input data" & vbNewLine & "You have to select a project")
        Else
            If Me.MdiChildren.Contains(FormOutcome2) Then
                FormOutcome2.Focus()
            Else
                FormOutcome2.MdiParent = Me
                FormOutcome2.Show()
            End If
        End If
    End Sub


    Private Sub navBarCompanyList_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarCompanyList.LinkClicked

        If Me.MdiChildren.Contains(FormCompanyList) Then
            FormCompanyList.Focus()
        Else
            FormCompanyList.MdiParent = Me
            FormCompanyList.Show()
        End If

    End Sub

    Private Sub navbarProxyAndDeadweight_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarProxyAndDeadweight.LinkClicked
        If oProject.idProject2 = 0 Then
            warningDialog(Me, "No Project Selected, in order to view Input data" & vbNewLine & "You have to select a project")
        Else
            If Me.MdiChildren.Contains(FormProxy) Then
                FormProxy.Focus()
            Else
                FormProxy.MdiParent = Me
                FormProxy.Show()
            End If
        End If
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        If oProject.idProject2 = 0 Then
            warningDialog(Me, "No Project Selected, in order to view Input data" & vbNewLine & "You have to select a project")
        Else
            If Me.MdiChildren.Contains(FormSroiReport) Then
                FormSroiReport.Focus()
            Else
                FormSroiReport.MdiParent = Me
                FormSroiReport.Show()
            End If
        End If
    End Sub

    Private Sub NavBarControl1_Click(sender As Object, e As EventArgs) Handles NavBarControl1.Click

    End Sub
End Class
