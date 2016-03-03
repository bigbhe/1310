
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

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarCompanyList.LinkClicked
        If Me.MdiChildren.Contains(FormCompanyList) Then
            FormCompanyList.Focus()
        Else
            FormCompanyList.MdiParent = Me
            FormCompanyList.Show()
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
End Class
