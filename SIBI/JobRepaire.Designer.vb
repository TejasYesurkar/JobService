<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobRepaire
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtprblobserve = New System.Windows.Forms.RichTextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cmbjobst = New System.Windows.Forms.ComboBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.dpdaterep = New System.Windows.Forms.DateTimePicker()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtrepairdone = New System.Windows.Forms.RichTextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtprjobid = New System.Windows.Forms.TextBox()
		Me.txtnamerep = New System.Windows.Forms.TextBox()
		Me.txtcomp = New System.Windows.Forms.RichTextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.txtremark = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.btnfetch = New System.Windows.Forms.Button()
		Me.txtCustnm = New System.Windows.Forms.TextBox()
		Me.txtjobid = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txttotalamt = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtprblobserve)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.cmbjobst)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.dpdaterep)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtrepairdone)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.txtprjobid)
		Me.GroupBox1.Controls.Add(Me.txtnamerep)
		Me.GroupBox1.Controls.Add(Me.txtcomp)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.txtremark)
		Me.GroupBox1.Controls.Add(Me.Label16)
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.btnfetch)
		Me.GroupBox1.Controls.Add(Me.txtCustnm)
		Me.GroupBox1.Controls.Add(Me.txtjobid)
		Me.GroupBox1.Controls.Add(Me.Label10)
		Me.GroupBox1.Location = New System.Drawing.Point(34, 46)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(937, 218)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Job Repaired Details"
		'
		'txtprblobserve
		'
		Me.txtprblobserve.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtprblobserve.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtprblobserve.Location = New System.Drawing.Point(712, 32)
		Me.txtprblobserve.Name = "txtprblobserve"
		Me.txtprblobserve.Size = New System.Drawing.Size(219, 81)
		Me.txtprblobserve.TabIndex = 201
		Me.txtprblobserve.Text = ""
		'
		'Label2
		'
		Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(709, 11)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(113, 18)
		Me.Label2.TabIndex = 202
		Me.Label2.Text = "Problems Observe:"
		'
		'cmbjobst
		'
		Me.cmbjobst.FormattingEnabled = True
		Me.cmbjobst.Location = New System.Drawing.Point(701, 147)
		Me.cmbjobst.Name = "cmbjobst"
		Me.cmbjobst.Size = New System.Drawing.Size(171, 21)
		Me.cmbjobst.TabIndex = 199
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label8.Location = New System.Drawing.Point(698, 127)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(70, 18)
		Me.Label8.TabIndex = 200
		Me.Label8.Text = "Job Status:"
		'
		'dpdaterep
		'
		Me.dpdaterep.Location = New System.Drawing.Point(545, 148)
		Me.dpdaterep.Name = "dpdaterep"
		Me.dpdaterep.Size = New System.Drawing.Size(122, 20)
		Me.dpdaterep.TabIndex = 194
		Me.dpdaterep.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(542, 127)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(94, 18)
		Me.Label1.TabIndex = 195
		Me.Label1.Text = "Date Of Repair:"
		'
		'txtrepairdone
		'
		Me.txtrepairdone.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtrepairdone.Location = New System.Drawing.Point(16, 150)
		Me.txtrepairdone.Name = "txtrepairdone"
		Me.txtrepairdone.Size = New System.Drawing.Size(284, 52)
		Me.txtrepairdone.TabIndex = 193
		Me.txtrepairdone.Text = ""
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label13.Location = New System.Drawing.Point(13, 131)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(158, 18)
		Me.Label13.TabIndex = 191
		Me.Label13.Text = "Repairs Done / Parts Used:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label4.Location = New System.Drawing.Point(310, 130)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(83, 18)
		Me.Label4.TabIndex = 192
		Me.Label4.Text = "Repairing By:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label6.Location = New System.Drawing.Point(17, 48)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(99, 18)
		Me.Label6.TabIndex = 184
		Me.Label6.Text = "Previous Job ID:"
		'
		'txtprjobid
		'
		Me.txtprjobid.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtprjobid.Location = New System.Drawing.Point(122, 48)
		Me.txtprjobid.Name = "txtprjobid"
		Me.txtprjobid.Size = New System.Drawing.Size(123, 20)
		Me.txtprjobid.TabIndex = 2
		'
		'txtnamerep
		'
		Me.txtnamerep.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtnamerep.Location = New System.Drawing.Point(316, 151)
		Me.txtnamerep.Name = "txtnamerep"
		Me.txtnamerep.Size = New System.Drawing.Size(199, 20)
		Me.txtnamerep.TabIndex = 188
		'
		'txtcomp
		'
		Me.txtcomp.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtcomp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtcomp.Location = New System.Drawing.Point(487, 32)
		Me.txtcomp.Name = "txtcomp"
		Me.txtcomp.Size = New System.Drawing.Size(219, 81)
		Me.txtcomp.TabIndex = 6
		Me.txtcomp.Text = ""
		'
		'Label14
		'
		Me.Label14.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label14.Location = New System.Drawing.Point(484, 11)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(195, 18)
		Me.Label14.TabIndex = 180
		Me.Label14.Text = "Problems Reported by Customer:"
		'
		'txtremark
		'
		Me.txtremark.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtremark.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtremark.Location = New System.Drawing.Point(251, 32)
		Me.txtremark.Multiline = True
		Me.txtremark.Name = "txtremark"
		Me.txtremark.Size = New System.Drawing.Size(223, 81)
		Me.txtremark.TabIndex = 5
		'
		'Label16
		'
		Me.Label16.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label16.Location = New System.Drawing.Point(251, 11)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(54, 18)
		Me.Label16.TabIndex = 182
		Me.Label16.Text = "Remark:"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label12.Location = New System.Drawing.Point(17, 22)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(47, 18)
		Me.Label12.TabIndex = 174
		Me.Label12.Text = "Job ID:"
		'
		'btnfetch
		'
		Me.btnfetch.Location = New System.Drawing.Point(170, 17)
		Me.btnfetch.Name = "btnfetch"
		Me.btnfetch.Size = New System.Drawing.Size(75, 23)
		Me.btnfetch.TabIndex = 2
		Me.btnfetch.TabStop = False
		Me.btnfetch.Text = "&Fetch"
		Me.btnfetch.UseVisualStyleBackColor = True
		'
		'txtCustnm
		'
		Me.txtCustnm.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtCustnm.Location = New System.Drawing.Point(21, 93)
		Me.txtCustnm.Name = "txtCustnm"
		Me.txtCustnm.Size = New System.Drawing.Size(224, 20)
		Me.txtCustnm.TabIndex = 3
		'
		'txtjobid
		'
		Me.txtjobid.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtjobid.Location = New System.Drawing.Point(65, 19)
		Me.txtjobid.Name = "txtjobid"
		Me.txtjobid.Size = New System.Drawing.Size(90, 20)
		Me.txtjobid.TabIndex = 1
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label10.Location = New System.Drawing.Point(18, 76)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(116, 18)
		Me.Label10.TabIndex = 173
		Me.Label10.Text = "Name Of Customer:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold)
		Me.Label5.ForeColor = System.Drawing.Color.Blue
		Me.Label5.Location = New System.Drawing.Point(343, 8)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(222, 35)
		Me.Label5.TabIndex = 184
		Me.Label5.Text = "Repair Summary"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(34, 287)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(937, 242)
		Me.DataGridView1.TabIndex = 14
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label3.Location = New System.Drawing.Point(407, 536)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(101, 18)
		Me.Label3.TabIndex = 190
		Me.Label3.Text = "Chargeable Amt:"
		'
		'txttotalamt
		'
		Me.txttotalamt.BackColor = System.Drawing.Color.LemonChiffon
		Me.txttotalamt.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txttotalamt.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txttotalamt.Location = New System.Drawing.Point(514, 536)
		Me.txttotalamt.Name = "txttotalamt"
		Me.txttotalamt.Size = New System.Drawing.Size(181, 20)
		Me.txttotalamt.TabIndex = 189
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(735, 535)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(112, 23)
		Me.Button1.TabIndex = 191
		Me.Button1.TabStop = False
		Me.Button1.Text = "&Submit"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(119, 270)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(70, 17)
		Me.CheckBox1.TabIndex = 192
		Me.CheckBox1.Text = "Select All"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'JobRepaire
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(989, 643)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txttotalamt)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "JobRepaire"
		Me.Text = "JobRepaire"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label12 As Label
	Friend WithEvents btnfetch As Button
	Friend WithEvents txtCustnm As TextBox
	Friend WithEvents txtjobid As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtcomp As RichTextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents txtremark As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtprjobid As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtnamerep As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents txtrepairdone As RichTextBox
	Friend WithEvents dpdaterep As DateTimePicker
	Friend WithEvents Label1 As Label
	Friend WithEvents cmbjobst As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label3 As Label
	Friend WithEvents txttotalamt As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents txtprblobserve As RichTextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents CheckBox1 As CheckBox
End Class
