Partial Public Class SroiMainForm
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
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarMdiChildrenListItem1 = New DevExpress.XtraBars.BarMdiChildrenListItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.navBarSettings = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navBarTheme = New DevExpress.XtraNavBar.NavBarItem()
        Me.navbarEScope = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navBarMainIssue = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarStakeholders = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarImpactMap = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navBarInput = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarOutcome = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarCompany = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navBarNewCompany = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarCompanyList = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarProject = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarProxy = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navbarProxyAndDeadweight = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.SkinBarSubItem1, Me.BarStaticItem1, Me.BarDockingMenuItem1, Me.BarMdiChildrenListItem1, Me.BarEditItem1, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SkinBarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarStaticItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarMdiChildrenListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
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
        'BarStaticItem1
        '
        Me.BarStaticItem1.Id = 1
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarMdiChildrenListItem1
        '
        Me.BarMdiChildrenListItem1.Caption = "Open Form"
        Me.BarMdiChildrenListItem1.Id = 3
        Me.BarMdiChildrenListItem1.Name = "BarMdiChildrenListItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 382)
        Me.barDockControlBottom.Size = New System.Drawing.Size(690, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 353)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(690, 29)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 353)
        '
        'BarDockingMenuItem1
        '
        Me.BarDockingMenuItem1.Caption = "BarDockingMenuItem1"
        Me.BarDockingMenuItem1.Id = 2
        Me.BarDockingMenuItem1.Name = "BarDockingMenuItem1"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Project Information: "
        Me.BarEditItem1.Edit = Me.RepositoryItemButtonEdit1
        Me.BarEditItem1.EditWidth = 59
        Me.BarEditItem1.Glyph = CType(resources.GetObject("BarEditItem1.Glyph"), System.Drawing.Image)
        Me.BarEditItem1.Id = 4
        Me.BarEditItem1.LargeGlyph = CType(resources.GetObject("BarEditItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.navBarSettings
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navbarEScope, Me.navBarImpactMap, Me.NavBarCompany, Me.navBarSettings, Me.NavBarProxy, Me.NavBarGroup1})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBarTheme, Me.navBarNewCompany, Me.navBarCompanyList, Me.navBarProject, Me.navBarMainIssue, Me.navBarStakeholders, Me.navBarInput, Me.navBarOutcome, Me.navbarProxyAndDeadweight, Me.NavBarItem1})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 29)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 182
        Me.NavBarControl1.Size = New System.Drawing.Size(182, 353)
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
        'navbarEScope
        '
        Me.navbarEScope.Caption = "Establishing Scope"
        Me.navbarEScope.Expanded = True
        Me.navbarEScope.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarMainIssue), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarStakeholders)})
        Me.navbarEScope.Name = "navbarEScope"
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
        'navBarImpactMap
        '
        Me.navBarImpactMap.Caption = "Impact Map"
        Me.navBarImpactMap.Expanded = True
        Me.navBarImpactMap.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarInput), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarOutcome)})
        Me.navBarImpactMap.Name = "navBarImpactMap"
        '
        'navBarInput
        '
        Me.navBarInput.Caption = "Input"
        Me.navBarInput.Name = "navBarInput"
        '
        'navBarOutcome
        '
        Me.navBarOutcome.Caption = "Outcomes"
        Me.navBarOutcome.Name = "navBarOutcome"
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
        'NavBarProxy
        '
        Me.NavBarProxy.Caption = "Proxy and Deadweight"
        Me.NavBarProxy.Expanded = True
        Me.NavBarProxy.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navbarProxyAndDeadweight)})
        Me.NavBarProxy.Name = "NavBarProxy"
        '
        'navbarProxyAndDeadweight
        '
        Me.navbarProxyAndDeadweight.Caption = "Proxy"
        Me.navbarProxyAndDeadweight.Name = "navbarProxyAndDeadweight"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Report"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "SROI Value"
        Me.NavBarItem1.Name = "NavBarItem1"
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
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents navbarEScope As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarCompany As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navBarTheme As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents navBarNewCompany As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarCompanyList As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarProject As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarMainIssue As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarStakeholders As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem
    Friend WithEvents BarMdiChildrenListItem1 As DevExpress.XtraBars.BarMdiChildrenListItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemButtonEdit1 As Repository.RepositoryItemButtonEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents navBarImpactMap As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navBarInput As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarOutcome As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarProxy As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navbarProxyAndDeadweight As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem

#End Region

End Class
