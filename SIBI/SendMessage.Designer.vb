<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendMessage
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
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.txtcustName = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtfileName = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.textBox1)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.button1)
		Me.GroupBox1.Controls.Add(Me.Button4)
		Me.GroupBox1.Controls.Add(Me.txtcustName)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.richTextBox1)
		Me.GroupBox1.Controls.Add(Me.label1)
		Me.GroupBox1.Controls.Add(Me.label2)
		Me.GroupBox1.Location = New System.Drawing.Point(224, 43)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(342, 439)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Send WhatsApp Message"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(65, 313)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(190, 20)
		Me.TextBox2.TabIndex = 17
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(65, 268)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(61, 13)
		Me.Label4.TabIndex = 16
		Me.Label4.Text = "Attachment"
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(68, 349)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(187, 23)
		Me.button1.TabIndex = 5
		Me.button1.Text = "Send Message"
		Me.button1.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(65, 284)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(190, 23)
		Me.Button4.TabIndex = 15
		Me.Button4.Text = "Select File"
		Me.Button4.UseVisualStyleBackColor = True
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
		Me.Button2.Location = New System.Drawing.Point(204, 135)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(48, 23)
		Me.Button2.TabIndex = 13
		Me.Button2.Text = "CRM"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.RadioButton1)
		Me.FlowLayoutPanel1.Controls.Add(Me.RadioButton2)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(131, 104)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(120, 25)
		Me.FlowLayoutPanel1.TabIndex = 12
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
		Me.RadioButton1.TabIndex = 1
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "India"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(57, 3)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(51, 17)
		Me.RadioButton2.TabIndex = 2
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "Other"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(73, 42)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(188, 25)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "SIBI Service App"
		'
		'richTextBox1
		'
		Me.richTextBox1.Location = New System.Drawing.Point(68, 202)
		Me.richTextBox1.Name = "richTextBox1"
		Me.richTextBox1.Size = New System.Drawing.Size(187, 54)
		Me.richTextBox1.TabIndex = 4
		Me.richTextBox1.Text = ""
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(65, 135)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(132, 20)
		Me.textBox1.TabIndex = 3
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(65, 116)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(38, 13)
		Me.label1.TabIndex = 9
		Me.label1.Text = "Mobile"
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(68, 186)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(50, 13)
		Me.label2.TabIndex = 10
		Me.label2.Text = "Message"
		'
		'txtfileName
		'
		Me.txtfileName.AutoSize = True
		Me.txtfileName.Location = New System.Drawing.Point(126, 257)
		Me.txtfileName.Name = "txtfileName"
		Me.txtfileName.Size = New System.Drawing.Size(10, 13)
		Me.txtfileName.TabIndex = 16
		Me.txtfileName.Text = "."
		'
		'SendMessage
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 513)
		Me.Controls.Add(Me.txtfileName)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "SendMessage"
		Me.Text = "SendMessage"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Public WithEvents richTextBox1 As RichTextBox
	Public WithEvents textBox1 As TextBox
	Private WithEvents label1 As Label
	Private WithEvents label2 As Label
	Private WithEvents button1 As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Button2 As Button
	Friend WithEvents txtcustName As Label
	Friend WithEvents txtfileName As Label
	Private WithEvents TextBox2 As TextBox
	Private WithEvents Label4 As Label
	Friend WithEvents Button4 As Button
End Class
