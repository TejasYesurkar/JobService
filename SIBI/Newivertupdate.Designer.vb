<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Newivertupdate
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtreppart = New System.Windows.Forms.TextBox()
		Me.txtRep = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtremk = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Submit = New System.Windows.Forms.Button()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.cmbjobst = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtamt = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtjobid = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(12, 190)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(886, 293)
		Me.DataGridView1.TabIndex = 0
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.txtreppart)
		Me.GroupBox1.Controls.Add(Me.txtRep)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtremk)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Submit)
		Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.cmbjobst)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtamt)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.txtjobid)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(886, 159)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "GroupBox1"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label13.Location = New System.Drawing.Point(347, 80)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(158, 18)
		Me.Label13.TabIndex = 192
		Me.Label13.Text = "Repairs Done / Parts Used:"
		'
		'txtreppart
		'
		Me.txtreppart.Location = New System.Drawing.Point(350, 106)
		Me.txtreppart.Multiline = True
		Me.txtreppart.Name = "txtreppart"
		Me.txtreppart.Size = New System.Drawing.Size(308, 47)
		Me.txtreppart.TabIndex = 134
		'
		'txtRep
		'
		Me.txtRep.BackColor = System.Drawing.SystemColors.Info
		Me.txtRep.Location = New System.Drawing.Point(494, 46)
		Me.txtRep.Name = "txtRep"
		Me.txtRep.Size = New System.Drawing.Size(164, 20)
		Me.txtRep.TabIndex = 132
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(491, 25)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(82, 18)
		Me.Label4.TabIndex = 133
		Me.Label4.Text = "RepaireMan :"
		'
		'txtremk
		'
		Me.txtremk.Location = New System.Drawing.Point(13, 106)
		Me.txtremk.Multiline = True
		Me.txtremk.Name = "txtremk"
		Me.txtremk.Size = New System.Drawing.Size(331, 47)
		Me.txtremk.TabIndex = 130
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(10, 80)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(96, 18)
		Me.Label3.TabIndex = 131
		Me.Label3.Text = "Retrun Remark:"
		'
		'Submit
		'
		Me.Submit.Location = New System.Drawing.Point(664, 119)
		Me.Submit.Name = "Submit"
		Me.Submit.Size = New System.Drawing.Size(154, 23)
		Me.Submit.TabIndex = 103
		Me.Submit.TabStop = False
		Me.Submit.Text = "Submit"
		Me.Submit.UseVisualStyleBackColor = True
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(177, 47)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(141, 20)
		Me.DateTimePicker1.TabIndex = 129
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(174, 25)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(52, 18)
		Me.Label7.TabIndex = 128
		Me.Label7.Text = "In Date:"
		'
		'cmbjobst
		'
		Me.cmbjobst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbjobst.FormattingEnabled = True
		Me.cmbjobst.Location = New System.Drawing.Point(664, 45)
		Me.cmbjobst.Name = "cmbjobst"
		Me.cmbjobst.Size = New System.Drawing.Size(154, 21)
		Me.cmbjobst.Sorted = True
		Me.cmbjobst.TabIndex = 126
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(661, 25)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 18)
		Me.Label2.TabIndex = 127
		Me.Label2.Text = "Job Status:"
		'
		'txtamt
		'
		Me.txtamt.BackColor = System.Drawing.SystemColors.Info
		Me.txtamt.Location = New System.Drawing.Point(324, 47)
		Me.txtamt.Name = "txtamt"
		Me.txtamt.Size = New System.Drawing.Size(164, 20)
		Me.txtamt.TabIndex = 124
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(321, 26)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(59, 18)
		Me.Label5.TabIndex = 125
		Me.Label5.Text = "Charges :"
		'
		'txtjobid
		'
		Me.txtjobid.Location = New System.Drawing.Point(13, 46)
		Me.txtjobid.Name = "txtjobid"
		Me.txtjobid.Size = New System.Drawing.Size(141, 20)
		Me.txtjobid.TabIndex = 101
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(10, 20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(47, 18)
		Me.Label1.TabIndex = 103
		Me.Label1.Text = "Job ID:"
		'
		'Newivertupdate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(946, 495)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "Newivertupdate"
		Me.Text = "Newivertupdate"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtjobid As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label7 As Label
	Friend WithEvents cmbjobst As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtamt As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Submit As Button
	Friend WithEvents txtremk As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtRep As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtreppart As TextBox
	Friend WithEvents Label13 As Label
End Class
