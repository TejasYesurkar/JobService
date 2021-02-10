<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AmcAdd
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
		Me.txtprod = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.txtcustomer = New System.Windows.Forms.TextBox()
		Me.txtcustName = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtmobile = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtprod)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.GroupBox2)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
		Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.button1)
		Me.GroupBox1.Controls.Add(Me.txtcustomer)
		Me.GroupBox1.Controls.Add(Me.txtcustName)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txtmobile)
		Me.GroupBox1.Controls.Add(Me.label1)
		Me.GroupBox1.Location = New System.Drawing.Point(86, 21)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(425, 349)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "AMC"
		'
		'txtprod
		'
		Me.txtprod.Location = New System.Drawing.Point(35, 139)
		Me.txtprod.Name = "txtprod"
		Me.txtprod.Size = New System.Drawing.Size(324, 20)
		Me.txtprod.TabIndex = 22
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(32, 126)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(75, 13)
		Me.Label6.TabIndex = 23
		Me.Label6.Text = "Product Name"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.RadioButton3)
		Me.GroupBox2.Controls.Add(Me.RadioButton1)
		Me.GroupBox2.Controls.Add(Me.RadioButton2)
		Me.GroupBox2.Location = New System.Drawing.Point(35, 163)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(324, 35)
		Me.GroupBox2.TabIndex = 21
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = " "
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(244, 12)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(59, 17)
		Me.RadioButton3.TabIndex = 23
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "3 years"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(23, 12)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(54, 17)
		Me.RadioButton1.TabIndex = 21
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "1 year"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(137, 12)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
		Me.RadioButton2.TabIndex = 22
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "2 years"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(201, 209)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(52, 13)
		Me.Label5.TabIndex = 20
		Me.Label5.Text = "End Date"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(32, 209)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 13)
		Me.Label4.TabIndex = 19
		Me.Label4.Text = "Start Date"
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.Location = New System.Drawing.Point(200, 225)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(159, 20)
		Me.DateTimePicker2.TabIndex = 18
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(35, 225)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(159, 20)
		Me.DateTimePicker1.TabIndex = 17
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(227, 90)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(82, 13)
		Me.Label2.TabIndex = 16
		Me.Label2.Text = "Customer Name"
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(106, 262)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(187, 23)
		Me.button1.TabIndex = 5
		Me.button1.Text = "Add AMC"
		Me.button1.UseVisualStyleBackColor = True
		'
		'txtcustomer
		'
		Me.txtcustomer.Location = New System.Drawing.Point(227, 106)
		Me.txtcustomer.Name = "txtcustomer"
		Me.txtcustomer.Size = New System.Drawing.Size(132, 20)
		Me.txtcustomer.TabIndex = 15
		'
		'txtcustName
		'
		Me.txtcustName.AutoSize = True
		Me.txtcustName.Location = New System.Drawing.Point(68, 162)
		Me.txtcustName.Name = "txtcustName"
		Me.txtcustName.Size = New System.Drawing.Size(10, 13)
		Me.txtcustName.TabIndex = 14
		Me.txtcustName.Text = "."
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(173, 103)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(48, 23)
		Me.Button2.TabIndex = 13
		Me.Button2.Text = "CRM"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(124, 32)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(148, 25)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "AMC Service"
		'
		'txtmobile
		'
		Me.txtmobile.Location = New System.Drawing.Point(35, 103)
		Me.txtmobile.Name = "txtmobile"
		Me.txtmobile.Size = New System.Drawing.Size(132, 20)
		Me.txtmobile.TabIndex = 3
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(32, 87)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(38, 13)
		Me.label1.TabIndex = 9
		Me.label1.Text = "Mobile"
		'
		'AmcAdd
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(577, 402)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "AmcAdd"
		Me.Text = "AmcAdd"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Private WithEvents button1 As Button
	Friend WithEvents txtcustName As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Label3 As Label
	Public WithEvents txtmobile As TextBox
	Private WithEvents label1 As Label
	Private WithEvents Label5 As Label
	Private WithEvents Label4 As Label
	Friend WithEvents DateTimePicker2 As DateTimePicker
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Private WithEvents Label2 As Label
	Public WithEvents txtcustomer As TextBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Public WithEvents txtprod As TextBox
	Private WithEvents Label6 As Label
End Class
