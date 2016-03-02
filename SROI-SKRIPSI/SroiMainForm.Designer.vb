﻿Partial Public Class SroiMainForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SroiMainForm))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.SkinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.navBarSettings = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navBarTheme = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarCompany = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navBarNewCompany = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarCompanyList = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarProject = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarMainIssue = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarStakeholders = New DevExpress.XtraNavBar.NavBarItem()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.SkinBarSubItem1})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Tools"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SkinBarSubItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'SkinBarSubItem1
        '
        Me.SkinBarSubItem1.Caption = "Theme"
        Me.SkinBarSubItem1.Id = 0
        Me.SkinBarSubItem1.Name = "SkinBarSubItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(690, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 384)
        Me.barDockControlBottom.Size = New System.Drawing.Size(690, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 355)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(690, 29)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 355)
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.navBarSettings
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup2, Me.NavBarCompany, Me.navBarSettings})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBarTheme, Me.navBarNewCompany, Me.navBarCompanyList, Me.navBarProject, Me.navBarMainIssue, Me.navBarStakeholders})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 29)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 182
        Me.NavBarControl1.Size = New System.Drawing.Size(182, 355)
        Me.NavBarControl1.TabIndex = 5
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'navBarSettings
        '
        Me.navBarSettings.Caption = "Settings"
        Me.navBarSettings.Expanded = True
        Me.navBarSettings.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarTheme)})
        Me.navBarSettings.Name = "navBarSettings"
        Me.navBarSettings.SmallImage = CType(resources.GetObject("navBarSettings.SmallImage"), System.Drawing.Image)
        '
        'navBarTheme
        '
        Me.navBarTheme.Caption = "Theme"
        Me.navBarTheme.Name = "navBarTheme"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Establishing Scope"
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarMainIssue), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarStakeholders)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarCompany
        '
        Me.NavBarCompany.Caption = "Company and Project"
        Me.NavBarCompany.Expanded = True
        Me.NavBarCompany.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarNewCompany), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarCompanyList), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarProject)})
        Me.NavBarCompany.Name = "NavBarCompany"
        '
        'navBarNewCompany
        '
        Me.navBarNewCompany.Caption = "New Company"
        Me.navBarNewCompany.Name = "navBarNewCompany"
        '
        'navBarCompanyList
        '
        Me.navBarCompanyList.Caption = "Company List"
        Me.navBarCompanyList.Name = "navBarCompanyList"
        '
        'navBarProject
        '
        Me.navBarProject.Caption = "Project"
        Me.navBarProject.Name = "navBarProject"
        '
        'navBarMainIssue
        '
        Me.navBarMainIssue.Caption = "Main Issue"
        Me.navBarMainIssue.Name = "navBarMainIssue"
        '
        'navBarStakeholders
        '
        Me.navBarStakeholders.Caption = "Stakeholders"
        Me.navBarStakeholders.Name = "navBarStakeholders"
        '
        'SroiMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 409)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Name = "SroiMainForm"
        Me.Text = "Social Return On Investment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents navBarSettings As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarCompany As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navBarTheme As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents navBarNewCompany As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarCompanyList As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarProject As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarMainIssue As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarStakeholders As DevExpress.XtraNavBar.NavBarItem

#End Region

End Class
