<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActivityAddForm
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
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.showall = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.cmbjobst = New System.Windows.Forms.ComboBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btnshow = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Controls.Add(Me.Button2)
		Me.GroupBox2.Controls.Add(Me.showall)
		Me.GroupBox2.Controls.Add(Me.Button1)
		Me.GroupBox2.Controls.Add(Me.Label14)
		Me.GroupBox2.Controls.Add(Me.cmbjobst)
		Me.GroupBox2.Controls.Add(Me.DataGridView1)
		Me.GroupBox2.Controls.Add(Me.btnshow)
		Me.GroupBox2.Location = New System.Drawing.Point(26, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(1004, 570)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "View Activity  "
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(655, 54)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 131
		Me.Button2.Text = "Todays FollowUp"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'showall
		'
		Me.showall.Location = New System.Drawing.Point(455, 54)
		Me.showall.Name = "showall"
		Me.showall.Size = New System.Drawing.Size(75, 23)
		Me.showall.TabIndex = 130
		Me.showall.Text = "Show All"
		Me.showall.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(226, 52)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 129
		Me.Button1.Text = "Refresh"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label14.Location = New System.Drawing.Point(20, 32)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(66, 18)
		Me.Label14.TabIndex = 128
		Me.Label14.Text = "Job Status"
		'
		'cmbjobst
		'
		Me.cmbjobst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbjobst.FormattingEnabled = True
		Me.cmbjobst.Location = New System.Drawing.Point(20, 54)
		Me.cmbjobst.Name = "cmbjobst"
		Me.cmbjobst.Size = New System.Drawing.Size(154, 21)
		Me.cmbjobst.Sorted = True
		Me.cmbjobst.TabIndex = 11
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(20, 98)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(958, 422)
		Me.DataGridView1.TabIndex = 0
		'
		'btnshow
		'
		Me.btnshow.Location = New System.Drawing.Point(841, 54)
		Me.btnshow.Name = "btnshow"
		Me.btnshow.Size = New System.Drawing.Size(137, 23)
		Me.btnshow.TabIndex = 17
		Me.btnshow.Text = "Add FollowUp"
		Me.btnshow.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Red
		Me.Label1.Location = New System.Drawing.Point(376, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(232, 35)
		Me.Label1.TabIndex = 132
		Me.Label1.Text = "Today's Followup"
		'
		'ActivityAddForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1042, 589)
		Me.Controls.Add(Me.GroupBox2)
		Me.Name = "ActivityAddForm"
		Me.Text = "ActivityAddForm"
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label14 As Label
	Friend WithEvents cmbjobst As ComboBox
	Friend WithEvents btnshow As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents showall As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label1 As Label
End Class
