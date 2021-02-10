<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnlogin = New System.Windows.Forms.Button()
		Me.btnNewUser = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.GroupBox_CS = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.cmbDataBase = New System.Windows.Forms.ComboBox()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.btnDb = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtdbName = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.txtdbusername = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtdbpassword = New System.Windows.Forms.TextBox()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.windows = New System.Windows.Forms.RadioButton()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.btnapply = New System.Windows.Forms.Button()
		Me.btntest = New System.Windows.Forms.Button()
		Me.txtipAdd = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.ss = New System.Windows.Forms.GroupBox()
		Me.txtpswd = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtuser = New System.Windows.Forms.TextBox()
		Me.GroupBox_CS.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.ss.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(76, 53)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(151, 35)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Login Page"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(79, 737)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(83, 13)
		Me.Label3.TabIndex = 105
		Me.Label3.Text = "Estimated Value"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(79, 809)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(83, 13)
		Me.Label5.TabIndex = 108
		Me.Label5.Text = "Estimated Value"
		'
		'btnlogin
		'
		Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.btnlogin.Location = New System.Drawing.Point(136, 359)
		Me.btnlogin.Name = "btnlogin"
		Me.btnlogin.Size = New System.Drawing.Size(130, 23)
		Me.btnlogin.TabIndex = 2
		Me.btnlogin.Text = "Login"
		Me.btnlogin.UseVisualStyleBackColor = True
		'
		'btnNewUser
		'
		Me.btnNewUser.Location = New System.Drawing.Point(136, 393)
		Me.btnNewUser.Name = "btnNewUser"
		Me.btnNewUser.Size = New System.Drawing.Size(130, 23)
		Me.btnNewUser.TabIndex = 3
		Me.btnNewUser.Text = "NewUser"
		Me.btnNewUser.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(245, 144)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(78, 23)
		Me.Button2.TabIndex = 114
		Me.Button2.Text = "DB Setting"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(82, 117)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(241, 21)
		Me.ComboBox1.TabIndex = 1
		'
		'GroupBox_CS
		'
		Me.GroupBox_CS.Controls.Add(Me.GroupBox2)
		Me.GroupBox_CS.Controls.Add(Me.GroupBox1)
		Me.GroupBox_CS.Controls.Add(Me.RadioButton2)
		Me.GroupBox_CS.Controls.Add(Me.windows)
		Me.GroupBox_CS.Controls.Add(Me.Button3)
		Me.GroupBox_CS.Controls.Add(Me.btnapply)
		Me.GroupBox_CS.Controls.Add(Me.btntest)
		Me.GroupBox_CS.Controls.Add(Me.txtipAdd)
		Me.GroupBox_CS.Controls.Add(Me.Label8)
		Me.GroupBox_CS.Controls.Add(Me.Label10)
		Me.GroupBox_CS.Location = New System.Drawing.Point(41, 25)
		Me.GroupBox_CS.Name = "GroupBox_CS"
		Me.GroupBox_CS.Size = New System.Drawing.Size(362, 462)
		Me.GroupBox_CS.TabIndex = 7
		Me.GroupBox_CS.TabStop = False
		Me.GroupBox_CS.Text = "Connection Settings"
		Me.GroupBox_CS.Visible = False
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.cmbDataBase)
		Me.GroupBox2.Controls.Add(Me.Button5)
		Me.GroupBox2.Controls.Add(Me.btnDb)
		Me.GroupBox2.Controls.Add(Me.Button1)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.txtdbName)
		Me.GroupBox2.Location = New System.Drawing.Point(50, 302)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(298, 112)
		Me.GroupBox2.TabIndex = 128
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Database"
		'
		'cmbDataBase
		'
		Me.cmbDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbDataBase.FormattingEnabled = True
		Me.cmbDataBase.Location = New System.Drawing.Point(7, 77)
		Me.cmbDataBase.Name = "cmbDataBase"
		Me.cmbDataBase.Size = New System.Drawing.Size(180, 21)
		Me.cmbDataBase.TabIndex = 136
		'
		'Button5
		'
		Me.Button5.Location = New System.Drawing.Point(205, 72)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(89, 27)
		Me.Button5.TabIndex = 135
		Me.Button5.Text = "Verfiy Database"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'btnDb
		'
		Me.btnDb.Location = New System.Drawing.Point(165, 19)
		Me.btnDb.Name = "btnDb"
		Me.btnDb.Size = New System.Drawing.Size(127, 27)
		Me.btnDb.TabIndex = 134
		Me.btnDb.Text = "Create Database"
		Me.btnDb.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(6, 19)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(126, 27)
		Me.Button1.TabIndex = 133
		Me.Button1.Text = "Fetch Database"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label7.Location = New System.Drawing.Point(7, 60)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(97, 18)
		Me.Label7.TabIndex = 132
		Me.Label7.Text = "DataBase Name:"
		'
		'txtdbName
		'
		Me.txtdbName.Location = New System.Drawing.Point(6, 77)
		Me.txtdbName.Name = "txtdbName"
		Me.txtdbName.Size = New System.Drawing.Size(181, 20)
		Me.txtdbName.TabIndex = 131
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.CheckBox1)
		Me.GroupBox1.Controls.Add(Me.txtdbusername)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtdbpassword)
		Me.GroupBox1.Location = New System.Drawing.Point(50, 174)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(302, 125)
		Me.GroupBox1.TabIndex = 122
		Me.GroupBox1.TabStop = False
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(6, 105)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(119, 17)
		Me.CheckBox1.TabIndex = 127
		Me.CheckBox1.Text = "Trusted Connection"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'txtdbusername
		'
		Me.txtdbusername.Location = New System.Drawing.Point(7, 34)
		Me.txtdbusername.Name = "txtdbusername"
		Me.txtdbusername.Size = New System.Drawing.Size(198, 20)
		Me.txtdbusername.TabIndex = 123
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label9.Location = New System.Drawing.Point(4, 15)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(63, 18)
		Me.Label9.TabIndex = 124
		Me.Label9.Text = "Username"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(4, 63)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(60, 18)
		Me.Label2.TabIndex = 126
		Me.Label2.Text = "Password"
		'
		'txtdbpassword
		'
		Me.txtdbpassword.Location = New System.Drawing.Point(7, 82)
		Me.txtdbpassword.Name = "txtdbpassword"
		Me.txtdbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtdbpassword.Size = New System.Drawing.Size(198, 20)
		Me.txtdbpassword.TabIndex = 125
		Me.txtdbpassword.UseSystemPasswordChar = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(160, 154)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(80, 17)
		Me.RadioButton2.TabIndex = 120
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "SQL Server"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'windows
		'
		Me.windows.AutoSize = True
		Me.windows.Location = New System.Drawing.Point(56, 156)
		Me.windows.Name = "windows"
		Me.windows.Size = New System.Drawing.Size(69, 17)
		Me.windows.TabIndex = 119
		Me.windows.TabStop = True
		Me.windows.Text = "Windows"
		Me.windows.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(215, 428)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(127, 28)
		Me.Button3.TabIndex = 125
		Me.Button3.Text = "Cancel"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'btnapply
		'
		Me.btnapply.Location = New System.Drawing.Point(57, 427)
		Me.btnapply.Name = "btnapply"
		Me.btnapply.Size = New System.Drawing.Size(125, 29)
		Me.btnapply.TabIndex = 123
		Me.btnapply.Text = "Save"
		Me.btnapply.UseVisualStyleBackColor = True
		'
		'btntest
		'
		Me.btntest.Location = New System.Drawing.Point(253, 128)
		Me.btntest.Name = "btntest"
		Me.btntest.Size = New System.Drawing.Size(99, 27)
		Me.btntest.TabIndex = 118
		Me.btntest.Text = "Test Connection"
		Me.btntest.UseVisualStyleBackColor = True
		'
		'txtipAdd
		'
		Me.txtipAdd.Location = New System.Drawing.Point(52, 131)
		Me.txtipAdd.Name = "txtipAdd"
		Me.txtipAdd.Size = New System.Drawing.Size(193, 20)
		Me.txtipAdd.TabIndex = 119
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label8.Location = New System.Drawing.Point(53, 114)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(70, 18)
		Me.Label8.TabIndex = 121
		Me.Label8.Text = "IP Address:"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(52, 33)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(267, 37)
		Me.Label10.TabIndex = 119
		Me.Label10.Text = "Connection Setting"
		'
		'ss
		'
		Me.ss.Controls.Add(Me.txtpswd)
		Me.ss.Controls.Add(Me.Label6)
		Me.ss.Controls.Add(Me.Label4)
		Me.ss.Controls.Add(Me.txtuser)
		Me.ss.Location = New System.Drawing.Point(82, 190)
		Me.ss.Name = "ss"
		Me.ss.Size = New System.Drawing.Size(241, 151)
		Me.ss.TabIndex = 0
		Me.ss.TabStop = False
		'
		'txtpswd
		'
		Me.txtpswd.Location = New System.Drawing.Point(9, 113)
		Me.txtpswd.Name = "txtpswd"
		Me.txtpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtpswd.Size = New System.Drawing.Size(226, 20)
		Me.txtpswd.TabIndex = 1
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(9, 92)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(60, 18)
		Me.Label6.TabIndex = 125
		Me.Label6.Text = "Password"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label4.Location = New System.Drawing.Point(6, 20)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(63, 18)
		Me.Label4.TabIndex = 124
		Me.Label4.Text = "Username"
		'
		'txtuser
		'
		Me.txtuser.Location = New System.Drawing.Point(9, 41)
		Me.txtuser.Name = "txtuser"
		Me.txtuser.Size = New System.Drawing.Size(226, 20)
		Me.txtuser.TabIndex = 0
		'
		'Login
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(445, 524)
		Me.Controls.Add(Me.GroupBox_CS)
		Me.Controls.Add(Me.ss)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.btnlogin)
		Me.Controls.Add(Me.btnNewUser)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Login"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.GroupBox_CS.ResumeLayout(False)
		Me.GroupBox_CS.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ss.ResumeLayout(False)
		Me.ss.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents btnlogin As Button
	Friend WithEvents btnNewUser As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents GroupBox_CS As GroupBox
	Friend WithEvents btntest As Button
	Friend WithEvents txtipAdd As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents btnapply As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents windows As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtdbusername As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtdbpassword As TextBox
	Friend WithEvents ss As GroupBox
	Friend WithEvents txtpswd As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtuser As TextBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Button5 As Button
	Friend WithEvents btnDb As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents txtdbName As TextBox
	Friend WithEvents cmbDataBase As ComboBox
	Friend WithEvents CheckBox1 As CheckBox
End Class
