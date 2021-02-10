<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
	Inherits System.Windows.Forms.Form


	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub


	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
		Me.MenuStrip = New System.Windows.Forms.MenuStrip()
		Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OutSrcProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OutwardDetalisAddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InvertedDetalisAddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.JobDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.JobRepiredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.JobDeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.BarcodePrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DayReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DataBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FollowUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TodayFollowUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddFollowUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ShowAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.WhatsAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AMCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddAMCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewAMCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStrip = New System.Windows.Forms.ToolStrip()
		Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
		Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.StatusStrip = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.MenuStrip.SuspendLayout()
		Me.ToolStrip.SuspendLayout()
		Me.StatusStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip
		'
		Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpMenu, Me.TransactionsToolStripMenuItem, Me.JobDetailsToolStripMenuItem, Me.ToolsMenu, Me.ViewMenu, Me.DataBackupToolStripMenuItem, Me.FollowUpToolStripMenuItem, Me.WhatsAppToolStripMenuItem, Me.AMCToolStripMenuItem, Me.ConfigToolStripMenuItem})
		Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip.Name = "MenuStrip"
		Me.MenuStrip.Size = New System.Drawing.Size(840, 24)
		Me.MenuStrip.TabIndex = 5
		Me.MenuStrip.Text = "MenuStrip"
		'
		'HelpMenu
		'
		Me.HelpMenu.Name = "HelpMenu"
		Me.HelpMenu.Size = New System.Drawing.Size(76, 20)
		Me.HelpMenu.Text = "&Dashboard"
		'
		'TransactionsToolStripMenuItem
		'
		Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServicesToolStripMenuItem, Me.OutSrcProductToolStripMenuItem})
		Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
		Me.TransactionsToolStripMenuItem.ShowShortcutKeys = False
		Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.TransactionsToolStripMenuItem.Text = "Services"
		'
		'ServicesToolStripMenuItem
		'
		Me.ServicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ViewToolStripMenuItem})
		Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
		Me.ServicesToolStripMenuItem.ShowShortcutKeys = False
		Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
		Me.ServicesToolStripMenuItem.Text = "Services"
		'
		'AddToolStripMenuItem
		'
		Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
		Me.AddToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
		Me.AddToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
		Me.AddToolStripMenuItem.Text = "&Add"
		'
		'ViewToolStripMenuItem
		'
		Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
		Me.ViewToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
		Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
		Me.ViewToolStripMenuItem.Text = "&View"
		'
		'OutSrcProductToolStripMenuItem
		'
		Me.OutSrcProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutwardDetalisAddToolStripMenuItem, Me.InvertedDetalisAddToolStripMenuItem})
		Me.OutSrcProductToolStripMenuItem.Name = "OutSrcProductToolStripMenuItem"
		Me.OutSrcProductToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
		Me.OutSrcProductToolStripMenuItem.Text = "OutSource Jobs"
		'
		'OutwardDetalisAddToolStripMenuItem
		'
		Me.OutwardDetalisAddToolStripMenuItem.Name = "OutwardDetalisAddToolStripMenuItem"
		Me.OutwardDetalisAddToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
		Me.OutwardDetalisAddToolStripMenuItem.Text = "Add Outward Detalis"
		'
		'InvertedDetalisAddToolStripMenuItem
		'
		Me.InvertedDetalisAddToolStripMenuItem.Name = "InvertedDetalisAddToolStripMenuItem"
		Me.InvertedDetalisAddToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
		Me.InvertedDetalisAddToolStripMenuItem.Text = "Add Inward Detalis "
		'
		'JobDetailsToolStripMenuItem
		'
		Me.JobDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JobRepiredToolStripMenuItem, Me.JobDeliveryToolStripMenuItem})
		Me.JobDetailsToolStripMenuItem.Name = "JobDetailsToolStripMenuItem"
		Me.JobDetailsToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
		Me.JobDetailsToolStripMenuItem.Text = "Job Details"
		'
		'JobRepiredToolStripMenuItem
		'
		Me.JobRepiredToolStripMenuItem.Name = "JobRepiredToolStripMenuItem"
		Me.JobRepiredToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
		Me.JobRepiredToolStripMenuItem.Text = "Job Repaired"
		'
		'JobDeliveryToolStripMenuItem
		'
		Me.JobDeliveryToolStripMenuItem.Name = "JobDeliveryToolStripMenuItem"
		Me.JobDeliveryToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
		Me.JobDeliveryToolStripMenuItem.Text = "Job Delivery"
		'
		'ToolsMenu
		'
		Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarcodePrintToolStripMenuItem})
		Me.ToolsMenu.Name = "ToolsMenu"
		Me.ToolsMenu.Size = New System.Drawing.Size(44, 20)
		Me.ToolsMenu.Text = "&Print"
		'
		'BarcodePrintToolStripMenuItem
		'
		Me.BarcodePrintToolStripMenuItem.Name = "BarcodePrintToolStripMenuItem"
		Me.BarcodePrintToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
		Me.BarcodePrintToolStripMenuItem.Text = "Barcode print"
		'
		'ViewMenu
		'
		Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem2, Me.DayReportToolStripMenuItem})
		Me.ViewMenu.Name = "ViewMenu"
		Me.ViewMenu.Size = New System.Drawing.Size(71, 20)
		Me.ViewMenu.Text = "&Customer"
		'
		'ViewToolStripMenuItem2
		'
		Me.ViewToolStripMenuItem2.Name = "ViewToolStripMenuItem2"
		Me.ViewToolStripMenuItem2.Size = New System.Drawing.Size(154, 22)
		Me.ViewToolStripMenuItem2.Text = "Add Customer"
		'
		'DayReportToolStripMenuItem
		'
		Me.DayReportToolStripMenuItem.Name = "DayReportToolStripMenuItem"
		Me.DayReportToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
		Me.DayReportToolStripMenuItem.Text = "View Customer"
		'
		'DataBackupToolStripMenuItem
		'
		Me.DataBackupToolStripMenuItem.Name = "DataBackupToolStripMenuItem"
		Me.DataBackupToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
		Me.DataBackupToolStripMenuItem.Text = "Data Backup "
		'
		'FollowUpToolStripMenuItem
		'
		Me.FollowUpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodayFollowUpToolStripMenuItem, Me.AddFollowUpToolStripMenuItem, Me.ShowAllToolStripMenuItem})
		Me.FollowUpToolStripMenuItem.Name = "FollowUpToolStripMenuItem"
		Me.FollowUpToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
		Me.FollowUpToolStripMenuItem.Text = "FollowUp"
		'
		'TodayFollowUpToolStripMenuItem
		'
		Me.TodayFollowUpToolStripMenuItem.Name = "TodayFollowUpToolStripMenuItem"
		Me.TodayFollowUpToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.TodayFollowUpToolStripMenuItem.Text = "Today Follow up"
		'
		'AddFollowUpToolStripMenuItem
		'
		Me.AddFollowUpToolStripMenuItem.Name = "AddFollowUpToolStripMenuItem"
		Me.AddFollowUpToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.AddFollowUpToolStripMenuItem.Text = "Add Follow Up"
		'
		'ShowAllToolStripMenuItem
		'
		Me.ShowAllToolStripMenuItem.Name = "ShowAllToolStripMenuItem"
		Me.ShowAllToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.ShowAllToolStripMenuItem.Text = "Show All"
		'
		'ConfigToolStripMenuItem
		'
		Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
		Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
		Me.ConfigToolStripMenuItem.Text = "Configuration"
		'
		'WhatsAppToolStripMenuItem
		'
		Me.WhatsAppToolStripMenuItem.Name = "WhatsAppToolStripMenuItem"
		Me.WhatsAppToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
		Me.WhatsAppToolStripMenuItem.Text = "WhatsApp"
		'
		'AMCToolStripMenuItem
		'
		Me.AMCToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAMCToolStripMenuItem, Me.ViewAMCToolStripMenuItem})
		Me.AMCToolStripMenuItem.Name = "AMCToolStripMenuItem"
		Me.AMCToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
		Me.AMCToolStripMenuItem.Text = "AMC"
		'
		'AddAMCToolStripMenuItem
		'
		Me.AddAMCToolStripMenuItem.Name = "AddAMCToolStripMenuItem"
		Me.AddAMCToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.AddAMCToolStripMenuItem.Text = "Add AMC"
		'
		'ViewAMCToolStripMenuItem
		'
		Me.ViewAMCToolStripMenuItem.Name = "ViewAMCToolStripMenuItem"
		Me.ViewAMCToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.ViewAMCToolStripMenuItem.Text = "View AMC"
		'
		'ToolStrip
		'
		Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripButton1})
		Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
		Me.ToolStrip.Name = "ToolStrip"
		Me.ToolStrip.Size = New System.Drawing.Size(840, 25)
		Me.ToolStrip.TabIndex = 6
		Me.ToolStrip.Text = "ToolStrip"
		'
		'NewToolStripButton
		'
		Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
		Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
		Me.NewToolStripButton.Name = "NewToolStripButton"
		Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.NewToolStripButton.Text = "Add New Job"
		'
		'OpenToolStripButton
		'
		Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
		Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
		Me.OpenToolStripButton.Name = "OpenToolStripButton"
		Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.OpenToolStripButton.Text = "View Job Detailes"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
		Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton1.Name = "ToolStripButton1"
		Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton1.Text = "FollowUp"
		'
		'StatusStrip
		'
		Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
		Me.StatusStrip.Location = New System.Drawing.Point(0, 468)
		Me.StatusStrip.Name = "StatusStrip"
		Me.StatusStrip.Size = New System.Drawing.Size(840, 22)
		Me.StatusStrip.TabIndex = 7
		Me.StatusStrip.Text = "StatusStrip"
		'
		'ToolStripStatusLabel
		'
		Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
		Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
		Me.ToolStripStatusLabel.Text = "Status"
		'
		'MDIParent1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(840, 490)
		Me.Controls.Add(Me.ToolStrip)
		Me.Controls.Add(Me.MenuStrip)
		Me.Controls.Add(Me.StatusStrip)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip
		Me.Name = "MDIParent1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Services"
		Me.MenuStrip.ResumeLayout(False)
		Me.MenuStrip.PerformLayout()
		Me.ToolStrip.ResumeLayout(False)
		Me.ToolStrip.PerformLayout()
		Me.StatusStrip.ResumeLayout(False)
		Me.StatusStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
	Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
	Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
	Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
	Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ServicesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OutSrcProductToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OutwardDetalisAddToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InvertedDetalisAddToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewToolStripMenuItem2 As ToolStripMenuItem
	Friend WithEvents DayReportToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents JobDetailsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents JobRepiredToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents JobDeliveryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BarcodePrintToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DataBackupToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FollowUpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TodayFollowUpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AddFollowUpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ShowAllToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripButton1 As ToolStripButton
	Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents WhatsAppToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AMCToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AddAMCToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewAMCToolStripMenuItem As ToolStripMenuItem
End Class
