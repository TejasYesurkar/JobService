<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inverted_Form
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
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Datefilter = New System.Windows.Forms.CheckBox()
		Me.dptodate = New System.Windows.Forms.DateTimePicker()
		Me.dpfromdate = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cmbfilter = New System.Windows.Forms.ComboBox()
		Me.cmbjobst = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnfetch = New System.Windows.Forms.Button()
		Me.txtsearch = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'DataGridView2
		'
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Location = New System.Drawing.Point(12, 124)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(917, 402)
		Me.DataGridView2.TabIndex = 7
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Datefilter)
		Me.GroupBox1.Controls.Add(Me.dptodate)
		Me.GroupBox1.Controls.Add(Me.dpfromdate)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.cmbfilter)
		Me.GroupBox1.Controls.Add(Me.cmbjobst)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.btnfetch)
		Me.GroupBox1.Controls.Add(Me.txtsearch)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(917, 106)
		Me.GroupBox1.TabIndex = 8
		Me.GroupBox1.TabStop = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(314, 41)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(48, 18)
		Me.Label6.TabIndex = 123
		Me.Label6.Text = "ToDate"
		'
		'Datefilter
		'
		Me.Datefilter.AutoSize = True
		Me.Datefilter.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Datefilter.Location = New System.Drawing.Point(196, 21)
		Me.Datefilter.Name = "Datefilter"
		Me.Datefilter.Size = New System.Drawing.Size(84, 22)
		Me.Datefilter.TabIndex = 124
		Me.Datefilter.Text = "DataFilter"
		Me.Datefilter.UseVisualStyleBackColor = True
		'
		'dptodate
		'
		Me.dptodate.Location = New System.Drawing.Point(317, 60)
		Me.dptodate.Name = "dptodate"
		Me.dptodate.Size = New System.Drawing.Size(116, 20)
		Me.dptodate.TabIndex = 121
		'
		'dpfromdate
		'
		Me.dpfromdate.Location = New System.Drawing.Point(192, 60)
		Me.dpfromdate.Name = "dpfromdate"
		Me.dpfromdate.Size = New System.Drawing.Size(119, 20)
		Me.dpfromdate.TabIndex = 120
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label5.Location = New System.Drawing.Point(192, 41)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(63, 18)
		Me.Label5.TabIndex = 122
		Me.Label5.Text = "FromDate"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.Location = New System.Drawing.Point(455, 41)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(67, 18)
		Me.Label4.TabIndex = 107
		Me.Label4.Text = "Search By."
		'
		'cmbfilter
		'
		Me.cmbfilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbfilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbfilter.Location = New System.Drawing.Point(458, 59)
		Me.cmbfilter.Name = "cmbfilter"
		Me.cmbfilter.Size = New System.Drawing.Size(143, 21)
		Me.cmbfilter.TabIndex = 106
		'
		'cmbjobst
		'
		Me.cmbjobst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbjobst.FormattingEnabled = True
		Me.cmbjobst.Location = New System.Drawing.Point(16, 59)
		Me.cmbjobst.Name = "cmbjobst"
		Me.cmbjobst.Size = New System.Drawing.Size(154, 21)
		Me.cmbjobst.Sorted = True
		Me.cmbjobst.TabIndex = 102
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(16, 37)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(66, 18)
		Me.Label2.TabIndex = 103
		Me.Label2.Text = "Job Status"
		'
		'btnfetch
		'
		Me.btnfetch.Location = New System.Drawing.Point(800, 57)
		Me.btnfetch.Name = "btnfetch"
		Me.btnfetch.Size = New System.Drawing.Size(75, 23)
		Me.btnfetch.TabIndex = 26
		Me.btnfetch.TabStop = False
		Me.btnfetch.Text = "&Fetch"
		Me.btnfetch.UseVisualStyleBackColor = True
		'
		'txtsearch
		'
		Me.txtsearch.Location = New System.Drawing.Point(623, 60)
		Me.txtsearch.Name = "txtsearch"
		Me.txtsearch.Size = New System.Drawing.Size(141, 20)
		Me.txtsearch.TabIndex = 24
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(620, 37)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(47, 18)
		Me.Label1.TabIndex = 25
		Me.Label1.Text = "Job ID:"
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(417, 554)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 10
		Me.Button3.Text = "Submit"
		Me.Button3.UseVisualStyleBackColor = True
		Me.Button3.Visible = False
		'
		'inverted_Form
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(973, 596)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.DataGridView2)
		Me.Name = "inverted_Form"
		Me.Text = "inverted_Form"
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnfetch As Button
	Friend WithEvents txtsearch As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents cmbjobst As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents cmbfilter As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Datefilter As CheckBox
	Friend WithEvents dptodate As DateTimePicker
	Friend WithEvents dpfromdate As DateTimePicker
	Friend WithEvents Label5 As Label
	Friend WithEvents Button3 As Button
End Class
