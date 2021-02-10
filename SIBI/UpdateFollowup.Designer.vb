<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateFollowup
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.dpclosedate = New System.Windows.Forms.DateTimePicker()
		Me.nxtfollow = New System.Windows.Forms.CheckBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.weekDays = New System.Windows.Forms.ComboBox()
		Me.cmbassign = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.mm = New System.Windows.Forms.TextBox()
		Me.ss = New System.Windows.Forms.TextBox()
		Me.hh = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtdays = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnupdate = New System.Windows.Forms.Button()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtcustnm = New System.Windows.Forms.TextBox()
		Me.txtremark = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtdecs = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.txtmob = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.txttime = New System.Windows.Forms.TextBox()
		Me.dpdate = New System.Windows.Forms.DateTimePicker()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.txtid = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.txteditDesc = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.dpclosedate)
		Me.GroupBox1.Controls.Add(Me.nxtfollow)
		Me.GroupBox1.Controls.Add(Me.GroupBox2)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.btnupdate)
		Me.GroupBox1.Controls.Add(Me.Label10)
		Me.GroupBox1.Controls.Add(Me.txtcustnm)
		Me.GroupBox1.Controls.Add(Me.txtremark)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Controls.Add(Me.txtdecs)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.Label15)
		Me.GroupBox1.Controls.Add(Me.txtmob)
		Me.GroupBox1.Controls.Add(Me.Label16)
		Me.GroupBox1.Controls.Add(Me.txttime)
		Me.GroupBox1.Controls.Add(Me.dpdate)
		Me.GroupBox1.Controls.Add(Me.Label17)
		Me.GroupBox1.Controls.Add(Me.txtid)
		Me.GroupBox1.Controls.Add(Me.Label18)
		Me.GroupBox1.Location = New System.Drawing.Point(104, 30)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(656, 503)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Add Follow Up"
		'
		'dpclosedate
		'
		Me.dpclosedate.Location = New System.Drawing.Point(417, 104)
		Me.dpclosedate.Name = "dpclosedate"
		Me.dpclosedate.Size = New System.Drawing.Size(130, 20)
		Me.dpclosedate.TabIndex = 522
		'
		'nxtfollow
		'
		Me.nxtfollow.AutoSize = True
		Me.nxtfollow.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.nxtfollow.Location = New System.Drawing.Point(37, 246)
		Me.nxtfollow.Name = "nxtfollow"
		Me.nxtfollow.Size = New System.Drawing.Size(166, 22)
		Me.nxtfollow.TabIndex = 22
		Me.nxtfollow.Text = "Schedule Next Followup"
		Me.nxtfollow.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.txteditDesc)
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.weekDays)
		Me.GroupBox2.Controls.Add(Me.cmbassign)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.Button2)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.mm)
		Me.GroupBox2.Controls.Add(Me.ss)
		Me.GroupBox2.Controls.Add(Me.hh)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.txtdays)
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
		Me.GroupBox2.Location = New System.Drawing.Point(37, 262)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(541, 157)
		Me.GroupBox2.TabIndex = 502
		Me.GroupBox2.TabStop = False
		'
		'Label8
		'
		Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label8.Location = New System.Drawing.Point(295, 117)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(51, 18)
		Me.Label8.TabIndex = 523
		Me.Label8.Text = "Holiday"
		'
		'weekDays
		'
		Me.weekDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.weekDays.FormattingEnabled = True
		Me.weekDays.Location = New System.Drawing.Point(362, 113)
		Me.weekDays.Name = "weekDays"
		Me.weekDays.Size = New System.Drawing.Size(148, 21)
		Me.weekDays.TabIndex = 10
		'
		'cmbassign
		'
		Me.cmbassign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbassign.FormattingEnabled = True
		Me.cmbassign.Location = New System.Drawing.Point(362, 80)
		Me.cmbassign.Name = "cmbassign"
		Me.cmbassign.Size = New System.Drawing.Size(148, 21)
		Me.cmbassign.TabIndex = 8
		'
		'Label7
		'
		Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label7.Location = New System.Drawing.Point(295, 80)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(61, 18)
		Me.Label7.TabIndex = 517
		Me.Label7.Text = "Assign To"
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(476, 32)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(34, 23)
		Me.Button2.TabIndex = 7
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(406, 35)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(11, 15)
		Me.Label5.TabIndex = 521
		Me.Label5.Text = ":"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(355, 36)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(11, 13)
		Me.Label6.TabIndex = 520
		Me.Label6.Text = ":"
		'
		'mm
		'
		Me.mm.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.mm.AllowDrop = True
		Me.mm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.mm.Location = New System.Drawing.Point(371, 33)
		Me.mm.MaxLength = 2
		Me.mm.Name = "mm"
		Me.mm.Size = New System.Drawing.Size(33, 21)
		Me.mm.TabIndex = 5
		'
		'ss
		'
		Me.ss.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.ss.AllowDrop = True
		Me.ss.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.ss.Location = New System.Drawing.Point(423, 33)
		Me.ss.MaxLength = 2
		Me.ss.Name = "ss"
		Me.ss.Size = New System.Drawing.Size(33, 21)
		Me.ss.TabIndex = 6
		'
		'hh
		'
		Me.hh.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.hh.AllowDrop = True
		Me.hh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.hh.Location = New System.Drawing.Point(319, 35)
		Me.hh.MaxLength = 2
		Me.hh.Name = "hh"
		Me.hh.Size = New System.Drawing.Size(33, 21)
		Me.hh.TabIndex = 4
		'
		'Label4
		'
		Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.Location = New System.Drawing.Point(93, 35)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(34, 18)
		Me.Label4.TabIndex = 516
		Me.Label4.Text = "Days"
		'
		'Label3
		'
		Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(12, 10)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(95, 18)
		Me.Label3.TabIndex = 515
		Me.Label3.Text = "Reminder After"
		'
		'txtdays
		'
		Me.txtdays.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtdays.AllowDrop = True
		Me.txtdays.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtdays.Location = New System.Drawing.Point(15, 34)
		Me.txtdays.Name = "txtdays"
		Me.txtdays.Size = New System.Drawing.Size(72, 21)
		Me.txtdays.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(147, 10)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(34, 18)
		Me.Label2.TabIndex = 513
		Me.Label2.Text = "Date"
		'
		'Label1
		'
		Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(318, 10)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(36, 18)
		Me.Label1.TabIndex = 512
		Me.Label1.Text = "Time"
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(150, 35)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(142, 20)
		Me.DateTimePicker1.TabIndex = 3
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(320, 425)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 513
		Me.Button1.Text = "Close"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'btnupdate
		'
		Me.btnupdate.Location = New System.Drawing.Point(171, 425)
		Me.btnupdate.Name = "btnupdate"
		Me.btnupdate.Size = New System.Drawing.Size(75, 23)
		Me.btnupdate.TabIndex = 511
		Me.btnupdate.Text = "Submit"
		Me.btnupdate.UseVisualStyleBackColor = True
		'
		'Label10
		'
		Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label10.Location = New System.Drawing.Point(205, 86)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(96, 18)
		Me.Label10.TabIndex = 498
		Me.Label10.Text = "Customer Name"
		'
		'txtcustnm
		'
		Me.txtcustnm.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtcustnm.AllowDrop = True
		Me.txtcustnm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtcustnm.Location = New System.Drawing.Point(208, 107)
		Me.txtcustnm.Name = "txtcustnm"
		Me.txtcustnm.Size = New System.Drawing.Size(187, 21)
		Me.txtcustnm.TabIndex = 497
		'
		'txtremark
		'
		Me.txtremark.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtremark.AllowDrop = True
		Me.txtremark.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtremark.Location = New System.Drawing.Point(287, 169)
		Me.txtremark.Multiline = True
		Me.txtremark.Name = "txtremark"
		Me.txtremark.Size = New System.Drawing.Size(200, 71)
		Me.txtremark.TabIndex = 1
		'
		'Label11
		'
		Me.Label11.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(284, 148)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(50, 18)
		Me.Label11.TabIndex = 496
		Me.Label11.Text = "Remark"
		'
		'txtdecs
		'
		Me.txtdecs.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtdecs.AllowDrop = True
		Me.txtdecs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtdecs.Location = New System.Drawing.Point(36, 169)
		Me.txtdecs.Multiline = True
		Me.txtdecs.Name = "txtdecs"
		Me.txtdecs.Size = New System.Drawing.Size(216, 71)
		Me.txtdecs.TabIndex = 489
		'
		'Label14
		'
		Me.Label14.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label14.Location = New System.Drawing.Point(33, 148)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(73, 18)
		Me.Label14.TabIndex = 495
		Me.Label14.Text = "Description"
		'
		'Label15
		'
		Me.Label15.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label15.Location = New System.Drawing.Point(34, 86)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(70, 18)
		Me.Label15.TabIndex = 494
		Me.Label15.Text = "Mobile No."
		'
		'txtmob
		'
		Me.txtmob.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtmob.AllowDrop = True
		Me.txtmob.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtmob.Location = New System.Drawing.Point(37, 107)
		Me.txtmob.Name = "txtmob"
		Me.txtmob.Size = New System.Drawing.Size(151, 21)
		Me.txtmob.TabIndex = 486
		'
		'Label16
		'
		Me.Label16.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label16.Location = New System.Drawing.Point(359, 19)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(36, 18)
		Me.Label16.TabIndex = 493
		Me.Label16.Text = "Time"
		'
		'txttime
		'
		Me.txttime.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txttime.AllowDrop = True
		Me.txttime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txttime.Location = New System.Drawing.Point(362, 40)
		Me.txttime.Name = "txttime"
		Me.txttime.Size = New System.Drawing.Size(129, 21)
		Me.txttime.TabIndex = 488
		'
		'dpdate
		'
		Me.dpdate.Location = New System.Drawing.Point(211, 41)
		Me.dpdate.Name = "dpdate"
		Me.dpdate.Size = New System.Drawing.Size(130, 20)
		Me.dpdate.TabIndex = 487
		'
		'Label17
		'
		Me.Label17.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label17.Location = New System.Drawing.Point(208, 19)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(34, 18)
		Me.Label17.TabIndex = 492
		Me.Label17.Text = "Date"
		'
		'txtid
		'
		Me.txtid.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtid.AllowDrop = True
		Me.txtid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtid.Location = New System.Drawing.Point(36, 44)
		Me.txtid.Name = "txtid"
		Me.txtid.Size = New System.Drawing.Size(148, 21)
		Me.txtid.TabIndex = 485
		'
		'Label18
		'
		Me.Label18.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label18.Location = New System.Drawing.Point(33, 23)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(80, 18)
		Me.Label18.TabIndex = 491
		Me.Label18.Text = "Follow up ID"
		'
		'txteditDesc
		'
		Me.txteditDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txteditDesc.AllowDrop = True
		Me.txteditDesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txteditDesc.Location = New System.Drawing.Point(22, 80)
		Me.txteditDesc.Multiline = True
		Me.txteditDesc.Name = "txteditDesc"
		Me.txteditDesc.Size = New System.Drawing.Size(216, 71)
		Me.txteditDesc.TabIndex = 525
		'
		'Label9
		'
		Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label9.Location = New System.Drawing.Point(19, 58)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(73, 18)
		Me.Label9.TabIndex = 526
		Me.Label9.Text = "Description"
		'
		'UpdateFollowup
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(832, 545)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "UpdateFollowup"
		Me.Text = "UpdateFollowup"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtcustnm As TextBox
	Friend WithEvents txtremark As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents txtdecs As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents txtmob As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents txttime As TextBox
	Friend WithEvents dpdate As DateTimePicker
	Friend WithEvents Label17 As Label
	Friend WithEvents txtid As TextBox
	Friend WithEvents Label18 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Button1 As Button
	Friend WithEvents btnupdate As Button
	Friend WithEvents nxtfollow As CheckBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtdays As TextBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents mm As TextBox
	Friend WithEvents ss As TextBox
	Friend WithEvents hh As TextBox
	Friend WithEvents cmbassign As ComboBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents weekDays As ComboBox
	Friend WithEvents dpclosedate As DateTimePicker
	Friend WithEvents txteditDesc As TextBox
	Friend WithEvents Label9 As Label
End Class
