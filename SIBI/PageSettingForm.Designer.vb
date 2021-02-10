<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageSettingForm
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txttop = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtleft = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtbot = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtright = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtpaperwidth = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtpaperheight = New System.Windows.Forms.TextBox()
		Me.btnclose = New System.Windows.Forms.Button()
		Me.btnsave = New System.Windows.Forms.Button()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtwidth = New System.Windows.Forms.TextBox()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtwidth)
		Me.GroupBox1.Controls.Add(Me.Label10)
		Me.GroupBox1.Controls.Add(Me.btnsave)
		Me.GroupBox1.Controls.Add(Me.btnclose)
		Me.GroupBox1.Controls.Add(Me.txtpaperheight)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.txtpaperwidth)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.ComboBox2)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.txtright)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.txtbot)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtleft)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txttop)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.ComboBox1)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(34, 39)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(500, 383)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Print Page Setting"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(59, 48)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(88, 15)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Printer Type:"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(170, 47)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(213, 21)
		Me.ComboBox1.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(26, 121)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 15)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Top Margin"
		'
		'txttop
		'
		Me.txttop.Location = New System.Drawing.Point(112, 121)
		Me.txttop.Name = "txttop"
		Me.txttop.Size = New System.Drawing.Size(100, 20)
		Me.txttop.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(236, 121)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(80, 15)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Left Margin"
		'
		'txtleft
		'
		Me.txtleft.Location = New System.Drawing.Point(332, 121)
		Me.txtleft.Name = "txtleft"
		Me.txtleft.Size = New System.Drawing.Size(100, 20)
		Me.txtleft.TabIndex = 5
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(6, 158)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(101, 15)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Bottom Margin"
		'
		'txtbot
		'
		Me.txtbot.Location = New System.Drawing.Point(112, 158)
		Me.txtbot.Name = "txtbot"
		Me.txtbot.Size = New System.Drawing.Size(100, 20)
		Me.txtbot.TabIndex = 7
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(236, 158)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(90, 15)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Right Margin"
		'
		'txtright
		'
		Me.txtright.Location = New System.Drawing.Point(332, 157)
		Me.txtright.Name = "txtright"
		Me.txtright.Size = New System.Drawing.Size(100, 20)
		Me.txtright.TabIndex = 9
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(26, 201)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(79, 15)
		Me.Label7.TabIndex = 12
		Me.Label7.Text = "Paper Type"
		'
		'ComboBox2
		'
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(112, 194)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
		Me.ComboBox2.TabIndex = 13
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(20, 242)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(85, 15)
		Me.Label9.TabIndex = 14
		Me.Label9.Text = "Paper Width"
		'
		'txtpaperwidth
		'
		Me.txtpaperwidth.Location = New System.Drawing.Point(112, 243)
		Me.txtpaperwidth.Name = "txtpaperwidth"
		Me.txtpaperwidth.Size = New System.Drawing.Size(100, 20)
		Me.txtpaperwidth.TabIndex = 15
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(236, 243)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(91, 15)
		Me.Label8.TabIndex = 16
		Me.Label8.Text = "Paper Height"
		'
		'txtpaperheight
		'
		Me.txtpaperheight.Location = New System.Drawing.Point(332, 242)
		Me.txtpaperheight.Name = "txtpaperheight"
		Me.txtpaperheight.Size = New System.Drawing.Size(100, 20)
		Me.txtpaperheight.TabIndex = 17
		'
		'btnclose
		'
		Me.btnclose.Location = New System.Drawing.Point(239, 338)
		Me.btnclose.Name = "btnclose"
		Me.btnclose.Size = New System.Drawing.Size(192, 23)
		Me.btnclose.TabIndex = 18
		Me.btnclose.Text = "Close"
		Me.btnclose.UseVisualStyleBackColor = True
		'
		'btnsave
		'
		Me.btnsave.Location = New System.Drawing.Point(23, 338)
		Me.btnsave.Name = "btnsave"
		Me.btnsave.Size = New System.Drawing.Size(192, 23)
		Me.btnsave.TabIndex = 19
		Me.btnsave.Text = "Save"
		Me.btnsave.UseVisualStyleBackColor = True
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(252, 195)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(74, 15)
		Me.Label10.TabIndex = 20
		Me.Label10.Text = "Text Width"
		'
		'txtwidth
		'
		Me.txtwidth.Location = New System.Drawing.Point(332, 194)
		Me.txtwidth.Name = "txtwidth"
		Me.txtwidth.Size = New System.Drawing.Size(100, 20)
		Me.txtwidth.TabIndex = 21
		'
		'PageSettingForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(572, 459)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "PageSettingForm"
		Me.Text = "printPageSetting"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtwidth As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents btnsave As Button
	Friend WithEvents btnclose As Button
	Friend WithEvents txtpaperheight As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtpaperwidth As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtright As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtbot As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtleft As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txttop As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label1 As Label
End Class
