
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

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked

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
End Class
