<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration
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
		Me.btnupdate = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtpswd = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtuser = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SuspendLayout()
		'
		'btnupdate
		'
		Me.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.btnupdate.Location = New System.Drawing.Point(83, 245)
		Me.btnupdate.Name = "btnupdate"
		Me.btnupdate.Size = New System.Drawing.Size(130, 23)
		Me.btnupdate.TabIndex = 125
		Me.btnupdate.Text = "Register"
		Me.btnupdate.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(80, 795)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(83, 13)
		Me.Label5.TabIndex = 123
		Me.Label5.Text = "Estimated Value"
		'
		'txtpswd
		'
		Me.txtpswd.Location = New System.Drawing.Point(83, 194)
		Me.txtpswd.Name = "txtpswd"
		Me.txtpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtpswd.Size = New System.Drawing.Size(248, 20)
		Me.txtpswd.TabIndex = 2
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(80, 178)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(61, 13)
		Me.Label6.TabIndex = 124
		Me.Label6.Text = "Password"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(80, 723)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(83, 13)
		Me.Label3.TabIndex = 121
		Me.Label3.Text = "Estimated Value"
		'
		'txtuser
		'
		Me.txtuser.Location = New System.Drawing.Point(83, 122)
		Me.txtuser.Name = "txtuser"
		Me.txtuser.Size = New System.Drawing.Size(248, 20)
		Me.txtuser.TabIndex = 1
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label4.Location = New System.Drawing.Point(80, 106)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(65, 13)
		Me.Label4.TabIndex = 122
		Me.Label4.Text = "Username"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(93, 41)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(222, 31)
		Me.Label1.TabIndex = 120
		Me.Label1.Text = "Registration Page"
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'Registration
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(460, 404)
		Me.Controls.Add(Me.btnupdate)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtpswd)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtuser)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Registration"
		Me.Text = "Registration"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnupdate As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents txtpswd As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtuser As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
