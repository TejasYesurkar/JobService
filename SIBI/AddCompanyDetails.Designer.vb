<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCompanyDetails
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtmob = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtcmpy = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.txtAddress)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txtmob)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtcmpy)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(387, 416)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(59, 358)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 32
		Me.Button1.Text = "Add"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'txtAddress
		'
		Me.txtAddress.Location = New System.Drawing.Point(59, 247)
		Me.txtAddress.Multiline = True
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(244, 77)
		Me.txtAddress.TabIndex = 30
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(56, 216)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(52, 18)
		Me.Label3.TabIndex = 31
		Me.Label3.Text = "Address"
		'
		'txtmob
		'
		Me.txtmob.Location = New System.Drawing.Point(59, 173)
		Me.txtmob.Name = "txtmob"
		Me.txtmob.Size = New System.Drawing.Size(237, 20)
		Me.txtmob.TabIndex = 28
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(56, 142)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 18)
		Me.Label1.TabIndex = 29
		Me.Label1.Text = "Contact No."
		'
		'txtcmpy
		'
		Me.txtcmpy.Location = New System.Drawing.Point(59, 101)
		Me.txtcmpy.Name = "txtcmpy"
		Me.txtcmpy.Size = New System.Drawing.Size(237, 20)
		Me.txtcmpy.TabIndex = 26
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(56, 70)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(94, 18)
		Me.Label2.TabIndex = 27
		Me.Label2.Text = "Company Name"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Label6.Location = New System.Drawing.Point(53, 16)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(272, 31)
		Me.Label6.TabIndex = 25
		Me.Label6.Text = "Add Company Details"
		'
		'AddCompanyDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(420, 449)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "AddCompanyDetails"
		Me.Text = "AddCompanyDetails"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents Label6 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtmob As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtcmpy As TextBox
	Friend WithEvents Label2 As Label
End Class
