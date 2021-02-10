<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardResult
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.txtpending = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.cmbRepotyp = New System.Windows.Forms.ComboBox()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.dptodate = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.dpfromdate = New System.Windows.Forms.DateTimePicker()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(12, 116)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(986, 519)
		Me.DataGridView1.TabIndex = 0
		'
		'txtpending
		'
		Me.txtpending.AutoSize = True
		Me.txtpending.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtpending.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.txtpending.Location = New System.Drawing.Point(6, 33)
		Me.txtpending.Name = "txtpending"
		Me.txtpending.Size = New System.Drawing.Size(127, 38)
		Me.txtpending.TabIndex = 1
		Me.txtpending.Text = "Label1"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.cmbRepotyp)
		Me.GroupBox2.Controls.Add(Me.Button3)
		Me.GroupBox2.Controls.Add(Me.Button2)
		Me.GroupBox2.Controls.Add(Me.Button1)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.dptodate)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.dpfromdate)
		Me.GroupBox2.Location = New System.Drawing.Point(425, 10)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(535, 92)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Date Filter"
		'
		'cmbRepotyp
		'
		Me.cmbRepotyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbRepotyp.FormattingEnabled = True
		Me.cmbRepotyp.Location = New System.Drawing.Point(273, 35)
		Me.cmbRepotyp.Name = "cmbRepotyp"
		Me.cmbRepotyp.Size = New System.Drawing.Size(171, 21)
		Me.cmbRepotyp.TabIndex = 121
		'
		'Button3
		'
		Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.Location = New System.Drawing.Point(50, 62)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(47, 24)
		Me.Button3.TabIndex = 120
		Me.Button3.Text = "<<"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(175, 62)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(47, 24)
		Me.Button2.TabIndex = 119
		Me.Button2.Text = ">>"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(291, 62)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(123, 23)
		Me.Button1.TabIndex = 118
		Me.Button1.Text = "Refresh"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(144, 17)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(48, 18)
		Me.Label6.TabIndex = 117
		Me.Label6.Text = "ToDate"
		'
		'dptodate
		'
		Me.dptodate.Location = New System.Drawing.Point(147, 36)
		Me.dptodate.Name = "dptodate"
		Me.dptodate.Size = New System.Drawing.Size(116, 20)
		Me.dptodate.TabIndex = 115
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label5.Location = New System.Drawing.Point(22, 17)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(63, 18)
		Me.Label5.TabIndex = 116
		Me.Label5.Text = "FromDate"
		'
		'dpfromdate
		'
		Me.dpfromdate.Location = New System.Drawing.Point(22, 36)
		Me.dpfromdate.Name = "dpfromdate"
		Me.dpfromdate.Size = New System.Drawing.Size(119, 20)
		Me.dpfromdate.TabIndex = 114
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.GroupBox2)
		Me.GroupBox1.Controls.Add(Me.txtpending)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(986, 108)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Report"
		'
		'DashboardResult
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1053, 656)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "DashboardResult"
		Me.Text = "DashboardResult"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents txtpending As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents dptodate As DateTimePicker
	Friend WithEvents Label5 As Label
	Friend WithEvents dpfromdate As DateTimePicker
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents cmbRepotyp As ComboBox
End Class
