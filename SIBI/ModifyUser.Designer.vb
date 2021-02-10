<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyUser
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
		Me.btnupdate = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtnewpswd = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtold = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.txtconfirm = New System.Windows.Forms.Label()
		Me.txtusernm = New System.Windows.Forms.Label()
		Me.txtuser = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnupdate
		'
		Me.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.btnupdate.Location = New System.Drawing.Point(192, 332)
		Me.btnupdate.Name = "btnupdate"
		Me.btnupdate.Size = New System.Drawing.Size(130, 23)
		Me.btnupdate.TabIndex = 139
		Me.btnupdate.Text = "Update"
		Me.btnupdate.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(135, 822)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(83, 13)
		Me.Label5.TabIndex = 137
		Me.Label5.Text = "Estimated Value"
		'
		'txtnewpswd
		'
		Me.txtnewpswd.Location = New System.Drawing.Point(138, 221)
		Me.txtnewpswd.Name = "txtnewpswd"
		Me.txtnewpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtnewpswd.Size = New System.Drawing.Size(248, 20)
		Me.txtnewpswd.TabIndex = 133
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(135, 205)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(90, 13)
		Me.Label6.TabIndex = 138
		Me.Label6.Text = "New Password:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(135, 750)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(83, 13)
		Me.Label3.TabIndex = 135
		Me.Label3.Text = "Estimated Value"
		'
		'txtold
		'
		Me.txtold.Location = New System.Drawing.Point(138, 149)
		Me.txtold.Name = "txtold"
		Me.txtold.Size = New System.Drawing.Size(248, 20)
		Me.txtold.TabIndex = 132
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label4.Location = New System.Drawing.Point(135, 133)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(85, 13)
		Me.Label4.TabIndex = 136
		Me.Label4.Text = "Old Password:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(135, 28)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(223, 31)
		Me.Label1.TabIndex = 134
		Me.Label1.Text = "Change Password"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(138, 285)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(248, 20)
		Me.TextBox1.TabIndex = 141
		'
		'txtconfirm
		'
		Me.txtconfirm.AutoSize = True
		Me.txtconfirm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtconfirm.Location = New System.Drawing.Point(135, 269)
		Me.txtconfirm.Name = "txtconfirm"
		Me.txtconfirm.Size = New System.Drawing.Size(114, 13)
		Me.txtconfirm.TabIndex = 142
		Me.txtconfirm.Text = "Confirm  Password:"
		'
		'txtusernm
		'
		Me.txtusernm.AutoSize = True
		Me.txtusernm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtusernm.Location = New System.Drawing.Point(138, 78)
		Me.txtusernm.Name = "txtusernm"
		Me.txtusernm.Size = New System.Drawing.Size(68, 13)
		Me.txtusernm.TabIndex = 143
		Me.txtusernm.Text = "UserName:"
		'
		'txtuser
		'
		Me.txtuser.Location = New System.Drawing.Point(141, 94)
		Me.txtuser.Name = "txtuser"
		Me.txtuser.Size = New System.Drawing.Size(245, 20)
		Me.txtuser.TabIndex = 144
		'
		'ModifyUser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(515, 450)
		Me.Controls.Add(Me.txtuser)
		Me.Controls.Add(Me.txtusernm)
		Me.Controls.Add(Me.txtconfirm)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.btnupdate)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtnewpswd)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtold)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label1)
		Me.Name = "ModifyUser"
		Me.Text = "ModifyUser"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnupdate As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents txtnewpswd As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtold As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents txtconfirm As Label
	Friend WithEvents txtusernm As Label
	Friend WithEvents txtuser As TextBox
End Class
